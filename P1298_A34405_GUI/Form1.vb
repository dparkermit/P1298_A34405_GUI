'Imports System
'Imports System.IO
'Imports System.Collections
Imports System.Math

Public Class FormOverCurrentTest
    Dim autostep As UInt16
    Dim autointerval As Integer
    Dim power_ramp As UInt16
    Dim power_ramp_dan_state As Integer

    Dim DataLogging As Boolean

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
    Public Const CMD_SET_HOME_POSITION As Byte = &H36
    Public Const CMD_READ_EEPROM_REGISTER As Byte = &H40
    Public Const CMD_WRITE_EEPROM_REGISTER As Byte = &H42
    Public Const CMD_OVERCURRENT_SHUTDOWN_TEST As Byte = &HE0
    Public Const CMD_READ_AFC_ERROR_DATA_HISTORY As Byte = &H50
    Public Const CMD_READ_MEM_LOCATION As Byte = &H54
    Public Const CMD_SET_ERROR_OFFSET As Byte = &H60
    Public Const CMD_DO_POSITION_AUTO_ZERO As Byte = &H70
    Public Const CMD_AFC_NOT_PULSING_GO_HOME As Byte = &H72
    Public Const CMD_DATA_LOGGING As Byte = &H56
    Public Const CMD_MK_SET_SPEED As Byte = &H80
    Public ConstCMD_MK_SET_MOTOR_DAMP As Byte = &H81





    'RAM Locations
    Public Const RAM_READ_STATE As Byte = &H1
    Public Const RAM_READ_VERSION As Byte = &H2

    Public Const RAM_READ_CURRENT_POSITION As Byte = &H10
    Public Const RAM_READ_TARGET_POSITION As Byte = &H12
    Public Const RAM_READ_HOME_POSITION As Byte = &H14
    Public Const RAM_READ_MAX_POSITION As Byte = &H16
    Public Const RAM_READ_MIN_POSITION As Byte = &H18

    Public Const RAM_READ_ADCBUF0 As Byte = &H30
    Public Const RAM_READ_ADCBUF1 As Byte = &H31
    Public Const RAM_READ_ADC_MOTOR_CURRENT_A As Byte = &H32
    Public Const RAM_READ_ADC_MOTOR_CURRENT_B As Byte = &H33
    Public Const RAM_READ_ADC_PARAMETER_INPUT As Byte = &H3B
    Public Const RAM_READ_ANALOG_INPUT As Byte = &H3C
    Public Const RAM_READ_ANALOG_OUTPUT As Byte = &H3D

    Public Const RAM_READ_SIGMA_DATA As Byte = &H40
    Public Const RAM_READ_DELTA_DATA As Byte = &H41
    Public Const RAM_READ_FREQUENCY_ERROR_FILTERED As Byte = &H42
    Public Const RAM_READ_FREQUENCY_ERROR_OFFSET As Byte = &H43
    Public Const RAM_READ_NUMBER_PULSES_ON As Byte = &H44
    Public Const RAM_READ_TIME_NOT_PULSING As Byte = &H45
    Public Const RAM_READ_AFC_DISTANCE_FROM_HOME_AT_STOP As Byte = &H46

    Public ConstRAM_READ_PRF As Byte = &H50



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
        ButtonStopLog.Enabled = False

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
        Dim datadouble As Double
        LabelTime.Text = DateTime.Now

        'Read Control State
        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_STATE, 0, 0) = True Then
            If ReturnData = &H10 Then
                LabelState.Text = "Start Up"
            ElseIf ReturnData = &H18 Then
                LabelState.Text = "Wait for Zero"
            ElseIf ReturnData = &H20 Then
                LabelState.Text = "Motor Zero"
            ElseIf ReturnData = &H24 Then
                LabelState.Text = "Motor Startup Home"
            ElseIf ReturnData = &H30 Then
                LabelState.Text = "Reset"
            ElseIf ReturnData = &H40 Then
                LabelState.Text = "AFC - Not Pulsing"
            ElseIf ReturnData = &H44 Then
                LabelState.Text = "AFC - Pulsing"
            ElseIf ReturnData = &H50 Then
                LabelState.Text = "Manual Mode"
            ElseIf ReturnData = &HF0 Then
                LabelState.Text = "Fault"
            End If
        Else
            LabelState.Text = "error"
            Exit Sub
        End If

        ' Read Pic Version
        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_VERSION, 0, 0) = True Then
            LabelMCUVersion.Text = ReturnData.ToString("X4")
        Else
            LabelMCUVersion.Text = "error"
            Exit Sub
        End If

        ' Read Current Position
        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_CURRENT_POSITION, 0, 0) = True Then
            datadouble = ReturnData
            LabelPosition.Text = datadouble / 4
        Else
            LabelPosition.Text = "error"
            Exit Sub
        End If


        ' Read Target Position
        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_TARGET_POSITION, 0, 0) = True Then
            datadouble = ReturnData
            LabelTarget.Text = datadouble / 4
        Else
            LabelTarget.Text = "error"
            Exit Sub
        End If

        ' Read Home Position
        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_HOME_POSITION, 0, 0) = True Then
            datadouble = ReturnData
            LabelHome.Text = datadouble / 4
        Else
            LabelHome.Text = "error"
            Exit Sub
        End If

        ' Read Max Position
        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_MAX_POSITION, 0, 0) = True Then
            datadouble = ReturnData
            LabelMax.Text = datadouble / 4
        Else
            LabelMax.Text = "error"
            Exit Sub
        End If

        ' Read Min Position
        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_MIN_POSITION, 0, 0) = True Then
            datadouble = ReturnData
            LabelMin.Text = datadouble / 4
        Else
            LabelMin.Text = "error"
            Exit Sub
        End If

        ' Read ADCBUF0
        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_ADCBUF0, 0, 0) = True Then
            LabelADCBUF0.Text = ReturnData
        Else
            LabelADCBUF0.Text = "error"
            Exit Sub
        End If

        ' Read ADCBUF1
        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_ADCBUF1, 0, 0) = True Then
            LabelADCBUF1.Text = ReturnData
        Else
            LabelADCBUF1.Text = "error"
            Exit Sub
        End If

        ' Read Motor Current A
        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_ADC_MOTOR_CURRENT_A, 0, 0) = True Then
            LabelIA.Text = ReturnData
        Else
            LabelIA.Text = "error"
            Exit Sub
        End If

        ' Read Motor Current B
        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_ADC_MOTOR_CURRENT_B, 0, 0) = True Then
            LabelIB.Text = ReturnData
        Else
            LabelIB.Text = "error"
            Exit Sub
        End If

        ' Read PARAMETER INPUT
        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_ADC_PARAMETER_INPUT, 0, 0) = True Then
            datadouble = ReturnData
            datadouble = ReturnData * 5 / 2 ^ 16
            LabelParameter.Text = Round(datadouble, 2)
        Else
            LabelParameter.Text = "error"
            Exit Sub
        End If

        ' Read Analog INPUT
        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_ANALOG_INPUT, 0, 0) = True Then
            datadouble = ReturnData
            datadouble = ReturnData * 5 / 2 ^ 16
            LabelAnalogInput.Text = Round(datadouble, 2)
        Else
            LabelAnalogInput.Text = "error"
            Exit Sub
        End If

        ' Read Analog Output
        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_ANALOG_OUTPUT, 0, 0) = True Then
            datadouble = ReturnData
            datadouble = datadouble * 5 / 2 ^ 12
            LabelAnalogOutput.Text = Round(datadouble, 2)
        Else
            LabelAnalogOutput.Text = "error"
            Exit Sub
        End If

        ' Read Sigma Data
        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_SIGMA_DATA, 0, 0) = True Then
            LabelSigma.Text = ReturnData
        Else
            LabelSigma.Text = "error"
            Exit Sub
        End If

        ' Read Delta Data
        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_DELTA_DATA, 0, 0) = True Then
            LabelDelta.Text = ReturnData
        Else
            LabelDelta.Text = "error"
            Exit Sub
        End If

        ' Read Error Data
        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_FREQUENCY_ERROR_FILTERED, 0, 0) = True Then
            LabelError.Text = ConvertToSigned(ReturnData)
        Else
            LabelError.Text = "error"
            Exit Sub
        End If

        ' Read Error Offset
        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_FREQUENCY_ERROR_OFFSET, 0, 0) = True Then
            LabelErrorOffset.Text = ConvertToSigned(ReturnData)
        Else
            LabelErrorOffset.Text = "error"
            Exit Sub
        End If

        If SendAndValidateCommand(CMD_READ_RAM_VALUE, ConstRAM_READ_PRF, 0, 0) = True Then
            LabelPRF.Text = ReturnData
        Else
            LabelPRF.Text = "error"
            Exit Sub
        End If

        ' Read Number of Pulses
        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_NUMBER_PULSES_ON, 0, 0) = True Then
            LabelOnPulses.Text = ReturnData
        Else
            LabelOnPulses.Text = "error"
            Exit Sub
        End If

        ' Read Time not Pulsing
        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_TIME_NOT_PULSING, 0, 0) = True Then
            datadouble = ReturnData
            LabelTimeOff.Text = (datadouble / 10)
        Else
            LabelTimeOff.Text = "error"
            Exit Sub
        End If

        ' Read Position when stopped pulsing
        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_AFC_DISTANCE_FROM_HOME_AT_STOP, 0, 0) = True Then
            LabelStopPosition.Text = ConvertToSigned(ReturnData)
        Else
            LabelStopPosition.Text = "error"
            Exit Sub
        End If



    End Sub




    Private Sub OpenLogFile()
        fileName = "ETM_AFC_Log_" & DateTime.Now.ToString("yyyy_MM_dd_HH_mm") & ".csv"
        filePath = System.IO.Path.Combine(My.Computer.FileSystem.SpecialDirectories.MyDocuments, fileName)
        file = My.Computer.FileSystem.OpenTextFileWriter(filePath, True)
        file.Write("Time , ")
        file.Write("Position , ")
        file.Write("Target Position , ")
        file.Write("Sigma , ")
        file.Write("Delta , ")
        file.Write("Error Filtered , ")
        file.Write("On Pulses")
        file.WriteLine("")
    End Sub

    Private Sub WriteToLogFile()
        file.Write(DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss") & " , ")
        file.Write(LabelPosition.Text & " , ")
        file.Write(LabelError.Text & " , ")
        file.Write(LabelOnPulses.Text)
        file.WriteLine("")
    End Sub

    Private Sub CLoseLogFile()
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
        Dim DataDouble As Double
        Dim ProgramWord As UInt16
        Dim ProgramHB As Byte
        Dim ProgramLB As Byte

        Try
            DataDouble = TextBoxPosition.Text * 4
            ProgramWord = Int(DataDouble)
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

    Private Sub ButtonCounterClockwise_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCounterClockwise.Click
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
    Private Sub LogData()
        ' Read Current Position
        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_CURRENT_POSITION, 0, 0) = True Then
            LabelPosition.Text = ReturnData
        Else
            LabelPosition.Text = "error"
            Exit Sub
        End If

        ' Read Error Data
        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_FREQUENCY_ERROR_FILTERED, 0, 0) = True Then
            LabelError.Text = ConvertToSigned(ReturnData)
        Else
            LabelError.Text = "error"
            Exit Sub
        End If

        ' Read Number of Pulses
        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_NUMBER_PULSES_ON, 0, 0) = True Then
            LabelOnPulses.Text = ReturnData
        Else
            LabelOnPulses.Text = "error"
            Exit Sub
        End If

        WriteToLogFile()

    End Sub

    Private Sub LogDataFast()
        Dim datadouble As Double
        Dim data_byte As Byte
        Dim position_word As UInt16
        Dim target_word As UInt16
        Dim sigma_byte As Byte
        Dim delta_byte As Byte
        Dim error_byte As Byte
        Dim count_word As UInt16
        OpenSerialPortETM()
        OpenLogFile()
        Do While DataLogging = True
            Application.DoEvents()
            Try
                If SerialPortETM.BytesToRead >= 10 Then
                    data_byte = SerialPortETM.ReadByte
                    If data_byte = &HFE Then
                        position_word = SerialPortETM.ReadByte
                        position_word = position_word * 256
                        position_word = position_word + SerialPortETM.ReadByte
                        datadouble = position_word / 4
                        LabelPosition.Text = datadouble

                        target_word = SerialPortETM.ReadByte
                        target_word = target_word * 256
                        target_word = target_word + SerialPortETM.ReadByte
                        datadouble = target_word / 4
                        LabelTarget.Text = datadouble

                        sigma_byte = SerialPortETM.ReadByte
                        LabelSigma.Text = sigma_byte

                        delta_byte = SerialPortETM.ReadByte
                        LabelDelta.Text = delta_byte

                        error_byte = SerialPortETM.ReadByte
                        LabelError.Text = ConvertToSignedByte(error_byte)

                        count_word = SerialPortETM.ReadByte
                        count_word = count_word * 256
                        count_word = count_word + SerialPortETM.ReadByte
                        LabelOnPulses.Text = count_word


                        file.Write(DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss") & " , ")
                        file.Write(position_word & " , ")
                        file.Write(target_word & " , ")
                        file.Write(sigma_byte & " , ")
                        file.Write(delta_byte & " , ")
                        file.Write(ConvertToSignedByte(error_byte) & " , ")
                        file.Write(count_word)
                        file.WriteLine("")
                    End If
                End If
            Catch ex As Exception
                DataLogging = False
            End Try

        Loop

        CLoseLogFile()
        CloseSerialPortETM()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'LogData()
        LogDataFast()
    End Sub
    Private Function ConvertToSignedByte(ByVal value_unsigned As Byte) As Int16
        Dim ReturnDataSigned As Int16
        ReturnDataSigned = 0
        Try
            If value_unsigned <= 127 Then
                ReturnDataSigned = value_unsigned
            Else
                ReturnDataSigned = value_unsigned - 255
            End If

        Catch ex As Exception

        End Try

        Return ReturnDataSigned
    End Function

    Private Function ConvertToSigned(ByVal value_unsigned As UInt16) As Int16
        Dim ReturnDataSigned As Int16
        ReturnDataSigned = 0
        Try
            If value_unsigned <= 32767 Then
                ReturnDataSigned = value_unsigned
            Else
                ReturnDataSigned = value_unsigned - 65536
            End If

        Catch ex As Exception

        End Try

        Return ReturnDataSigned
    End Function

    Private Sub ButtonReadErrorHistory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonReadErrorHistory.Click
        If SendAndValidateCommand(CMD_READ_AFC_ERROR_DATA_HISTORY, 0, 0, 0) = True Then
            LabelD0.Text = ConvertToSigned(ReturnData)
        Else
            LabelD0.Text = "error"
            Exit Sub
        End If

        If SendAndValidateCommand(CMD_READ_AFC_ERROR_DATA_HISTORY, 1, 0, 0) = True Then
            LabelD1.Text = ConvertToSigned(ReturnData)
        Else
            LabelD1.Text = "error"
            Exit Sub
        End If

        If SendAndValidateCommand(CMD_READ_AFC_ERROR_DATA_HISTORY, 2, 0, 0) = True Then
            LabelD2.Text = ConvertToSigned(ReturnData)
        Else
            LabelD2.Text = "error"
            Exit Sub
        End If


        If SendAndValidateCommand(CMD_READ_AFC_ERROR_DATA_HISTORY, 3, 0, 0) = True Then
            LabelD3.Text = ConvertToSigned(ReturnData)
        Else
            LabelD3.Text = "error"
            Exit Sub
        End If

        If SendAndValidateCommand(CMD_READ_AFC_ERROR_DATA_HISTORY, 4, 0, 0) = True Then
            LabelD4.Text = ConvertToSigned(ReturnData)
        Else
            LabelD4.Text = "error"
            Exit Sub
        End If

        If SendAndValidateCommand(CMD_READ_AFC_ERROR_DATA_HISTORY, 5, 0, 0) = True Then
            LabelD5.Text = ConvertToSigned(ReturnData)
        Else
            LabelD5.Text = "error"
            Exit Sub
        End If

        If SendAndValidateCommand(CMD_READ_AFC_ERROR_DATA_HISTORY, 6, 0, 0) = True Then
            LabelD6.Text = ConvertToSigned(ReturnData)
        Else
            LabelD6.Text = "error"
            Exit Sub
        End If

        If SendAndValidateCommand(CMD_READ_AFC_ERROR_DATA_HISTORY, 7, 0, 0) = True Then
            LabelD7.Text = ConvertToSigned(ReturnData)
        Else
            LabelD7.Text = "error"
            Exit Sub
        End If

        If SendAndValidateCommand(CMD_READ_AFC_ERROR_DATA_HISTORY, 8, 0, 0) = True Then
            LabelD8.Text = ConvertToSigned(ReturnData)
        Else
            LabelD8.Text = "error"
            Exit Sub
        End If

        If SendAndValidateCommand(CMD_READ_AFC_ERROR_DATA_HISTORY, 9, 0, 0) = True Then
            LabelD9.Text = ConvertToSigned(ReturnData)
        Else
            LabelD9.Text = "error"
            Exit Sub
        End If

        If SendAndValidateCommand(CMD_READ_AFC_ERROR_DATA_HISTORY, 10, 0, 0) = True Then
            LabelD10.Text = ConvertToSigned(ReturnData)
        Else
            LabelD10.Text = "error"
            Exit Sub
        End If

        If SendAndValidateCommand(CMD_READ_AFC_ERROR_DATA_HISTORY, 11, 0, 0) = True Then
            LabelD11.Text = ConvertToSigned(ReturnData)
        Else
            LabelD11.Text = "error"
            Exit Sub
        End If

        If SendAndValidateCommand(CMD_READ_AFC_ERROR_DATA_HISTORY, 12, 0, 0) = True Then
            LabelD12.Text = ConvertToSigned(ReturnData)
        Else
            LabelD12.Text = "error"
            Exit Sub
        End If

        If SendAndValidateCommand(CMD_READ_AFC_ERROR_DATA_HISTORY, 13, 0, 0) = True Then
            LabelD13.Text = ConvertToSigned(ReturnData)
        Else
            LabelD13.Text = "error"
            Exit Sub
        End If

        If SendAndValidateCommand(CMD_READ_AFC_ERROR_DATA_HISTORY, 14, 0, 0) = True Then
            LabelD14.Text = ConvertToSigned(ReturnData)
        Else
            LabelD14.Text = "error"
            Exit Sub
        End If

        If SendAndValidateCommand(CMD_READ_AFC_ERROR_DATA_HISTORY, 15, 0, 0) = True Then
            LabelD15.Text = ConvertToSigned(ReturnData)
        Else
            LabelD15.Text = "error"
            Exit Sub
        End If


    End Sub

    Private Sub ButtonSetErrorOffset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSetErrorOffset.Click
        Dim Value As Int16
        Dim ProgramWord As UInt16
        Dim ProgramHB As Byte
        Dim ProgramLB As Byte
        Value = Int(TextBoxErrorOffset.Text)

        If Value >= 127 Then
            Value = 127
        End If
        If Value <= -128 Then
            Value = -128
        End If
        If Value > 0 Then
            Try
                ProgramWord = Value
                ProgramHB = Int(ProgramWord / 256)
                ProgramLB = ProgramWord Mod 256
            Catch ex As Exception
                MsgBox("Data not Valid")
            End Try

            If SendAndValidateCommand(CMD_SET_ERROR_OFFSET, 0, ProgramHB, ProgramLB) = True Then
            Else
                MsgBox("Unable to Set Offset")
            End If
        Else
            Value = 0 - Value
            Try
                ProgramWord = Value
                ProgramHB = Int(ProgramWord / 256)
                ProgramLB = ProgramWord Mod 256
            Catch ex As Exception
                MsgBox("Data not Valid")
            End Try

            If SendAndValidateCommand(CMD_SET_ERROR_OFFSET, 1, ProgramHB, ProgramLB) = True Then
            Else
                MsgBox("Unable to Set Offset")
            End If
        End If


    End Sub


    Private Sub ButtonStartLog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonStartLog.Click
        Timer2.Enabled = False
        SendAndValidateCommand(CMD_DATA_LOGGING, 1, 0, 0)
        ButtonStartLog.Enabled = False
        ButtonStopLog.Enabled = True
        DataLogging = True
        LogDataFast()
        'Timer1.Enabled = True
    End Sub

    Private Sub ButtonStopLog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonStopLog.Click
        'Timer1.Enabled = False
        DataLogging = False
        SendAndValidateCommand(CMD_DATA_LOGGING, 0, 0, 0)
        'CLoseLogFile()
        ButtonStartLog.Enabled = True
        ButtonStopLog.Enabled = False
        Timer2.Enabled = True
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        ReadAllFromRam()
    End Sub

    Private Sub ButtonSetHomePosition_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSetHomePosition.Click
        Dim datadouble As Double
        Dim ProgramWord As UInt16
        Dim ProgramHB As Byte
        Dim ProgramLB As Byte

        Try
            datadouble = TextBoxSetHomePosition.Text * 4
            ProgramWord = Int(datadouble)
            ProgramHB = Int(ProgramWord / 256)
            ProgramLB = ProgramWord Mod 256
        Catch ex As Exception
            MsgBox("Data not Valid")
        End Try

        If SendAndValidateCommand(CMD_SET_HOME_POSITION, 0, ProgramHB, ProgramLB) = True Then
        Else
            MsgBox("Unable to Set Position")
        End If
    End Sub

    Private Sub ButtonAutoZero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAutoZero.Click
        SendAndValidateCommand(CMD_DO_POSITION_AUTO_ZERO, 0, 0, 0)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        SendAndValidateCommand(CMD_OVERCURRENT_SHUTDOWN_TEST, 0, 0, 0)
    End Sub

    Private Sub ButtonReadRamAddress_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonReadRamAddress.Click
        Dim ProgramWord As UInt16
        Dim ProgramHB As Byte
        Dim ProgramLB As Byte

        Try
            ProgramWord = Int(TextBoxRamAddress.Text)
            ProgramHB = Int(ProgramWord / 256)
            ProgramLB = ProgramWord Mod 256
        Catch ex As Exception
            MsgBox("Data not Valid")
        End Try

        If SendAndValidateCommand(CMD_READ_MEM_LOCATION, 0, ProgramHB, ProgramLB) = True Then
            LabelRamValue.Text = ReturnData
            LabelRamValueHex.Text = ReturnData.ToString("X4")
            'LabelRamValueBinary.Text = ReturnData.ToString("X16")

        Else
            LabelRamValue.Text = "Error"
            LabelRamValueHex.Text = "Error"
            LabelRamValueBinary.Text = "Error"
        End If
    End Sub

    Private Sub ButtonCoolDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCoolDown.Click
        SendAndValidateCommand(CMD_AFC_NOT_PULSING_GO_HOME, 0, 0, 0)
    End Sub

    Private Sub ButtonSetSpeed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSetSpeed.Click
        Dim Dan1 As Double
        Dim ProgramWord As UInt16
        Dim ProgramHB As Byte
        Dim ProgramLB As Byte

        Try
            Dan1 = Int(TextBoxSetSpeed.Text)
            Dan1 = 29100000 / 256 / Dan1
            If Dan1 > &HFFFF Then
                Dan1 = &HFFFF
            End If
            ProgramWord = Dan1
            ProgramHB = Int(ProgramWord / 256)
            ProgramLB = ProgramWord Mod 256
        Catch ex As Exception
            MsgBox("Data not Valid")
        End Try

        If SendAndValidateCommand(CMD_MK_SET_SPEED, 0, ProgramHB, ProgramLB) = True Then
        Else
            MsgBox("Unable to Set Speed")
        End If
    End Sub

    Private Sub ButtonSetDamping_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSetDamping.Click
        Dim ProgramWord As UInt16
        Dim ProgramHB As Byte
        Dim ProgramLB As Byte

        Try
            ProgramWord = Int(TextBoxSetDamping.Text)
            ProgramHB = Int(ProgramWord / 256)
            ProgramLB = ProgramWord Mod 256
        Catch ex As Exception
            MsgBox("Data not Valid")
        End Try

        If SendAndValidateCommand(ConstCMD_MK_SET_MOTOR_DAMP, 0, ProgramHB, ProgramLB) = True Then
        Else
            MsgBox("Unable to Set Motor Damping")
        End If
    End Sub

    Private Sub ButtonStartRandomTest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonStartRandomTest.Click
        Timer2.Enabled = False
        Timer3.Enabled = True
        Timer3.Interval = 1000
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        Dim ProgramWord As UInt16
        Dim ProgramHB As Byte
        Dim ProgramLB As Byte

        Dim rnd_speed As Single
        Dim rnd_time As Single
        Dim rnd_position As Single



        rnd_speed = 99 * Rnd() + 1
        rnd_time = 10 * 1000
        rnd_position = 100 + 800 * Rnd()

        Timer3.Interval = rnd_time




        Try
            ProgramWord = Int(rnd_speed)
            TextBoxSetSpeed.Text = ProgramWord
            ProgramWord = 29100000 / 256 / ProgramWord
  

        Catch ex As Exception
            MsgBox("Data not Valid")
        End Try
        If ProgramWord > &HFFFF Then
            ProgramWord = &HFFFF
        End If
        If ProgramWord < 1136 Then
            ProgramWord = 1136
        End If

        ProgramHB = Int(ProgramWord / 256)
        ProgramLB = ProgramWord Mod 256
        If SendAndValidateCommand(CMD_MK_SET_SPEED, 0, ProgramHB, ProgramLB) = True Then
        Else
            MsgBox("Unable to Set Speed")
        End If


        Try
            ProgramWord = Int(rnd_position)
            ProgramHB = Int(ProgramWord / 256)
            ProgramLB = ProgramWord Mod 256
            TextBoxPosition.Text = ProgramWord
        Catch ex As Exception
            MsgBox("Data not Valid")
        End Try

        If SendAndValidateCommand(CMD_SET_TARGET_POSITION, 0, ProgramHB, ProgramLB) = True Then
        Else
            MsgBox("Unable to Set Position")
        End If
        ReadAllFromRam()
    End Sub

    Private Sub ButtonStopRandomTest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonStopRandomTest.Click
        Timer3.Enabled = False
        Timer2.Enabled = True
        Timer3.Interval = 1000
    End Sub

End Class
