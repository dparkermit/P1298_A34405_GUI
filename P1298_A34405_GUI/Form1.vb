'Imports System
'Imports System.IO
'Imports System.Collections

Public Class Form1
    Dim autostep As UInt16
    Dim autointerval As Integer
    Dim power_ramp As UInt16
    Dim power_ramp_dan_state As Integer

    Public ReturnData As UInt16
    Dim ComError As Boolean
    Dim Tic As Boolean = False
    Dim SerialCommandTransmitBuffer(9) As Byte
    Dim SerialCommandReceiveBuffer(9) As Byte
    Public Const SYNC_1 As Byte = &HF1
    Public Const SYNC_2 As Byte = &HF2
    Public Const SYNC_3_SEND As Byte = &HF3
    Public Const SYNC_3_RECIEVE As Byte = &HF4
    Public Const COMMAND_LENGTH As Byte = 9
    Dim fileName As String
    Dim filePath As String
    Dim file As System.IO.StreamWriter




    ' Command List
    Public Const CMD_READ_RAM_VALUE As Byte = &H20
    Public Const CMD_SET_TARGET_POSITION As Byte = &H30
    Public Const CMD_MOVE_CLOCKWISE As Byte = &H32
    Public Const CMD_MOVE_COUNTER_CLOCKWISE As Byte = &H34
    Public Const CMD_READ_EEPROM_REGISTER As Byte = &H40
    Public Const CMD_WRITE_EEPROM_REGISTER As Byte = &H42






    'RAM Locations
    Public Const RAM_READ_STATE As Byte = &H1
    Public Const RAM_READ_VERSION As Byte = &H2

    Public Const RAM_READ_CURRENT_POSITION As Byte = &H10
    Public Const RAM_READ_TARGET_POSITION As Byte = &H20




    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For Each sp As String In My.Computer.Ports.SerialPortNames
            ComboBoxComPorts.Items.Add(sp)
        Next

        TextBoxBaudRate.Text = My.Settings.SelectedBaudRate

        Try
            ComboBoxComPorts.SelectedText = My.Settings.SelectedComPortString
        Catch ex As Exception
            MsgBox("Please select a Valid Com Port")
        End Try

        If (System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed) Then
            Dim verDeployed As System.Version = My.Application.Deployment.CurrentVersion
            LabelGUIVersion.Text = "GUI Version " & verDeployed.ToString
        Else
            LabelGUIVersion.Text = "GUI Version not Available in Debug Mode"
        End If

        LabelMCUVersion.Text = "PIC Version "

        OpenLogFile()
    End Sub


    Private Sub OpenSerialPortETM()
        Try
            If SerialPortETM.IsOpen Then
                SerialPortETM.Close()
            End If
        Catch ex As Exception
            LabelComMsg.Text = "Serial Port Open/Close Error"
            ComError = True
        End Try

        Try
            SerialPortETM.PortName = My.Settings.SelectedComPortString
            SerialPortETM.ReadTimeout = 25
            SerialPortETM.BaudRate = My.Settings.SelectedBaudRate

        Catch ex As Exception
            MsgBox("Please Select a valid Com Port")
        End Try

        Try
            SerialPortETM.Open()
        Catch ex As Exception
            LabelComMsg.Text = "Serial Port Failed to Open"
            ComError = True
        End Try
    End Sub

    Private Sub CloseSerialPortETM()
        Try
            SerialPortETM.Close()
        Catch ex As Exception
            LabelComMsg.Text = "Serial Port Failed to Close"
            ComError = True
        End Try
    End Sub

    Private Function CheckCRC() As Boolean
        Dim CrcCheck As UInt16 = 0
        Dim CRC As UInt16 = 0
        CrcCheck = Int(SerialCommandReceiveBuffer(0))
        CrcCheck = CrcCheck + Int(SerialCommandReceiveBuffer(1))
        CrcCheck = CrcCheck + Int(SerialCommandReceiveBuffer(2))
        CrcCheck = CrcCheck + Int(SerialCommandReceiveBuffer(3))
        CrcCheck = CrcCheck + Int(SerialCommandReceiveBuffer(4))
        CrcCheck = CrcCheck + Int(SerialCommandReceiveBuffer(5))
        CrcCheck = CrcCheck + Int(SerialCommandReceiveBuffer(6))
        CRC = Int(SerialCommandReceiveBuffer(7)) * 256 + Int(SerialCommandReceiveBuffer(8))
        If CrcCheck = CRC Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function SendAndValidateCommand(ByVal commandB As Byte, ByVal locationB As Byte, ByVal DataHB As Byte, ByVal DataLB As Byte) As Boolean
        Dim valid_command As Boolean = False
        Dim CheckSum As UInt16 = 0


        SerialCommandTransmitBuffer(0) = SYNC_1
        SerialCommandTransmitBuffer(1) = SYNC_2
        SerialCommandTransmitBuffer(2) = SYNC_3_SEND
        SerialCommandTransmitBuffer(3) = commandB
        SerialCommandTransmitBuffer(4) = DataHB
        SerialCommandTransmitBuffer(5) = DataLB
        SerialCommandTransmitBuffer(6) = locationB



        CheckSum = SYNC_1
        CheckSum = CheckSum + SYNC_2
        CheckSum = CheckSum + SYNC_3_SEND + commandB + DataHB + DataLB + locationB

        SerialCommandTransmitBuffer(7) = Int(CheckSum / 256)
        SerialCommandTransmitBuffer(8) = CheckSum Mod 256


        Try
            If SerialPortETM.IsOpen = False Then
                OpenSerialPortETM()
            End If
            SerialPortETM.Write(SerialCommandTransmitBuffer, 0, 9)
        Catch ex As Exception
            LabelComMsg.Text = "Serial Port Failed to Write Command Buffer"
            Return False
        End Try

        Try
            SerialCommandReceiveBuffer(0) = SerialPortETM.ReadByte
            SerialCommandReceiveBuffer(1) = SerialPortETM.ReadByte
            SerialCommandReceiveBuffer(2) = SerialPortETM.ReadByte
            SerialCommandReceiveBuffer(3) = SerialPortETM.ReadByte
            SerialCommandReceiveBuffer(4) = SerialPortETM.ReadByte
            SerialCommandReceiveBuffer(5) = SerialPortETM.ReadByte
            SerialCommandReceiveBuffer(6) = SerialPortETM.ReadByte
            SerialCommandReceiveBuffer(7) = SerialPortETM.ReadByte
            SerialCommandReceiveBuffer(8) = SerialPortETM.ReadByte

        Catch ex As Exception
            LabelComMsg.Text = "Serial Port Failed to Read Return"
            Return False
        End Try



        Try

            If SerialCommandReceiveBuffer(0) = SYNC_1 Then
                If SerialCommandReceiveBuffer(1) = SYNC_2 Then
                    If SerialCommandReceiveBuffer(2) = SYNC_3_RECIEVE Then
                        If CheckCRC() = True Then
                            valid_command = True
                            LabelComMsg.Text = "Message Sent/Received"
                            'A valid return was recieved.  Check what the responce was
                            If SerialCommandReceiveBuffer(3) <> SerialCommandTransmitBuffer(3) Then
                                'The pic was not able to process the command
                                If SerialCommandReceiveBuffer(3) = &H1 Then
                                    LabelComMsg.Text = "ETM Controller Responds - Unknown Command"
                                ElseIf SerialCommandReceiveBuffer(3) = &H22 Then
                                    LabelComMsg.Text = "ETM Controller Responds - Program Value out of Valid Range"
                                ElseIf SerialCommandReceiveBuffer(3) = &H23 Then
                                    LabelComMsg.Text = "ETM Controller Responds - EEPROM ERROR - Unable to set value"
                                Else
                                    LabelComMsg.Text = "ETM Controller Responce Error - " & SerialCommandReceiveBuffer(3)
                                End If
                            End If
                        End If
                    End If
                End If
            End If
            If valid_command <> True Then
                LabelComMsg.Text = "Serial Port return data was not valid"
                SerialPortETM.Close()
            End If
        Catch ex As Exception
            LabelComMsg.Text = "Error processing Serial Port data"
            ComError = True
            Return 0
        End Try

        ReturnData = SerialCommandReceiveBuffer(4) * 256 + SerialCommandReceiveBuffer(5)
        Return valid_command
    End Function


    Private Sub ReadAllFromRam()
        LabelTime.Text = DateTime.Now

        'Read Control State
        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_STATE, 0, 0) = True Then
            If ReturnData = &H10 Then
                LabelState.Text = "Start Up"
            ElseIf ReturnData = &H20 Then
                LabelState.Text = "Motor Zero"
            ElseIf ReturnData = &H24 Then
                LabelState.Text = "Motor Startup Home"
            ElseIf ReturnData = &H30 Then
                LabelState.Text = "Reset"
            ElseIf ReturnData = &H40 Then
                LabelState.Text = "AFC - Not Pulsing"
            ElseIf ReturnData = &H44 Then
                LabelState.Text = "AFC - Start Up"
            ElseIf ReturnData = &H48 Then
                LabelState.Text = "AFC - Steady State"
            ElseIf ReturnData = &H50 Then
                LabelState.Text = "Manual Mode"
            ElseIf ReturnData = &H60 Then
                LabelState.Text = "Serial Control Mode"
            ElseIf ReturnData = &HF0 Then
                LabelState.Text = "Fault"
            End If
        Else
            LabelState.Text = "error"
            Exit Sub
        End If

        ' Read Pic Version
        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_VERSION, 0, 0) = True Then
            LabelMCUVersion.Text = ReturnData
        Else
            LabelMCUVersion.Text = "error"
            Exit Sub
        End If

        ' Read Current Position
        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_CURRENT_POSITION, 0, 0) = True Then
            LabelPosition.Text = ReturnData
        Else
            LabelPosition.Text = "error"
            Exit Sub
        End If


        ' Read Target Position
        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_TARGET_POSITION, 0, 0) = True Then
            LabelTarget.Text = ReturnData
        Else
            LabelTarget.Text = "error"
            Exit Sub
        End If



    End Sub




    Private Sub OpenLogFile()
        fileName = "ETM_AFC_Log_" & DateTime.Now.ToString("yyyy_MM_dd_HH_mm") & ".csv"
        filePath = System.IO.Path.Combine(My.Computer.FileSystem.SpecialDirectories.MyDocuments, fileName)
        file = My.Computer.FileSystem.OpenTextFileWriter(filePath, True)
        file.Write("Time , ")
        file.Write("State , ")
        'file.Write("Target Power , ")
        'file.Write("Fwd A Power , ")
        'file.Write("Fwd B Power, ")
        'file.Write("Pid Dac Out , ")
        'file.Write("RF Amp Temp , ")
        'file.WriteLine("")
        file.Close()
    End Sub

    Private Sub WriteToLogFile()
        file = My.Computer.FileSystem.OpenTextFileWriter(filePath, True)
        file.Write(LabelTime.Text & " , ")
        file.Write(LabelState.Text & " , ")
        'file.Write(LabelTargetPower.Text & " , ")
        'file.Write(LabelFwdAPower.Text & " , ")
        'file.Write(LabelFwdBPower.Text & " , ")
        'file.Write(LabelDacOut.Text & " , ")
        'file.Write(LabelRFAmpTemp.Text & " , ")
        file.WriteLine("")
        file.Close()
    End Sub


    Private Sub ButtonSetBaudRate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSetBaudRate.Click
        Try
            My.Settings.SelectedBaudRate = TextBoxBaudRate.Text
        Catch ex As Exception
            MsgBox("Baud Rate not a valid Number")
        End Try


        Try
            SerialPortETM.BaudRate = My.Settings.SelectedBaudRate
        Catch ex As Exception
        End Try
    End Sub


    Private Sub ComboBoxComPorts_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxComPorts.SelectedIndexChanged
        Try
            My.Settings.SelectedComPortString = ComboBoxComPorts.SelectedItem.ToString

        Catch ex As Exception
            MsgBox("Please select a Valid Com Port")
        End Try
        Try
            OpenSerialPortETM()
        Catch ex As Exception
            MsgBox("Unable to open selected Com Port")
        End Try
    End Sub

    Private Sub ButtonUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonUpdate.Click
        ReadAllFromRam()
    End Sub

    Private Sub ButtonSetPosition_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSetPosition.Click
        Dim ProgramWord As UInt16
        Dim ProgramHB As Byte
        Dim ProgramLB As Byte

        Try
            ProgramWord = Int(TextBoxPosition.Text)
            ProgramHB = Int(ProgramWord / 256)
            ProgramLB = ProgramWord Mod 256
        Catch ex As Exception
            MsgBox("Data not Valid")
        End Try

        If SendAndValidateCommand(CMD_SET_TARGET_POSITION, 0, ProgramHB, ProgramLB) = True Then
        Else
            MsgBox("Unable to Set Position")
        End If
    End Sub

    Private Sub ButtonClockWise_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonClockWise.Click
        Dim ProgramWord As UInt16
        Dim ProgramHB As Byte
        Dim ProgramLB As Byte

        Try
            ProgramWord = Int(TextBoxClockWise.Text)
            ProgramHB = Int(ProgramWord / 256)
            ProgramLB = ProgramWord Mod 256
        Catch ex As Exception
            MsgBox("Data not Valid")
        End Try

        If SendAndValidateCommand(CMD_MOVE_CLOCKWISE, 0, ProgramHB, ProgramLB) = True Then
        Else
            MsgBox("Unable to Move Clockwise")
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim ProgramWord As UInt16
        Dim ProgramHB As Byte
        Dim ProgramLB As Byte

        Try
            ProgramWord = Int(TextBoxCounterClockwise.Text)
            ProgramHB = Int(ProgramWord / 256)
            ProgramLB = ProgramWord Mod 256
        Catch ex As Exception
            MsgBox("Data not Valid")
        End Try

        If SendAndValidateCommand(CMD_MOVE_COUNTER_CLOCKWISE, 0, ProgramHB, ProgramLB) = True Then
        Else
            MsgBox("Unable to Move Clockwise")
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ReadAllFromRam()
    End Sub
End Class
