<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormOverCurrentTest
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ButtonSetBaudRate = New System.Windows.Forms.Button()
        Me.TextBoxBaudRate = New System.Windows.Forms.TextBox()
        Me.ComboBoxComPorts = New System.Windows.Forms.ComboBox()
        Me.LabelComMsg = New System.Windows.Forms.Label()
        Me.SerialPortETM = New System.IO.Ports.SerialPort(Me.components)
        Me.LabelTime = New System.Windows.Forms.Label()
        Me.LabelMCUVersion = New System.Windows.Forms.Label()
        Me.LabelGUIVersion = New System.Windows.Forms.Label()
        Me.ButtonUpdate = New System.Windows.Forms.Button()
        Me.LabelState = New System.Windows.Forms.Label()
        Me.Label93 = New System.Windows.Forms.Label()
        Me.ButtonSetPosition = New System.Windows.Forms.Button()
        Me.TextBoxPosition = New System.Windows.Forms.TextBox()
        Me.TextBoxClockWise = New System.Windows.Forms.TextBox()
        Me.ButtonClockWise = New System.Windows.Forms.Button()
        Me.TextBoxCounterClockwise = New System.Windows.Forms.TextBox()
        Me.ButtonCounterClockwise = New System.Windows.Forms.Button()
        Me.LabelTarget = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelPosition = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LabelIA = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LabelADCBUF1 = New System.Windows.Forms.Label()
        Me.LabelADCBUF0 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LabelParameter = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.LabelIB = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LabelSigma = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LabelDelta = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LabelError = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LabelErrorOffset = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.LabelPRF = New System.Windows.Forms.Label()
        Me.ButtonReadErrorHistory = New System.Windows.Forms.Button()
        Me.LabelD0 = New System.Windows.Forms.Label()
        Me.LabelD1 = New System.Windows.Forms.Label()
        Me.LabelD3 = New System.Windows.Forms.Label()
        Me.LabelD2 = New System.Windows.Forms.Label()
        Me.LabelD7 = New System.Windows.Forms.Label()
        Me.LabelD6 = New System.Windows.Forms.Label()
        Me.LabelD5 = New System.Windows.Forms.Label()
        Me.LabelD4 = New System.Windows.Forms.Label()
        Me.LabelD15 = New System.Windows.Forms.Label()
        Me.LabelD14 = New System.Windows.Forms.Label()
        Me.LabelD13 = New System.Windows.Forms.Label()
        Me.LabelD12 = New System.Windows.Forms.Label()
        Me.LabelD11 = New System.Windows.Forms.Label()
        Me.LabelD10 = New System.Windows.Forms.Label()
        Me.LabelD9 = New System.Windows.Forms.Label()
        Me.LabelD8 = New System.Windows.Forms.Label()
        Me.TextBoxErrorOffset = New System.Windows.Forms.TextBox()
        Me.ButtonSetErrorOffset = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.LabelHome = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.LabelMax = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.LabelMin = New System.Windows.Forms.Label()
        Me.ButtonStartLog = New System.Windows.Forms.Button()
        Me.ButtonStopLog = New System.Windows.Forms.Button()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.TextBoxSetHomePosition = New System.Windows.Forms.TextBox()
        Me.ButtonSetHomePosition = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.LabelOnPulses = New System.Windows.Forms.Label()
        Me.ButtonAutoZero = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ButtonReadRamAddress = New System.Windows.Forms.Button()
        Me.TextBoxRamAddress = New System.Windows.Forms.TextBox()
        Me.LabelRamValue = New System.Windows.Forms.Label()
        Me.LabelRamValueHex = New System.Windows.Forms.Label()
        Me.LabelRamValueBinary = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.LabelTimeOff = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.LabelStopPosition = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.LabelAnalogInput = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.LabelAnalogOutput = New System.Windows.Forms.Label()
        Me.ButtonCoolDown = New System.Windows.Forms.Button()
        Me.TextBoxSetDamping = New System.Windows.Forms.TextBox()
        Me.ButtonSetDamping = New System.Windows.Forms.Button()
        Me.TextBoxSetSpeed = New System.Windows.Forms.TextBox()
        Me.ButtonSetSpeed = New System.Windows.Forms.Button()
        Me.ButtonStartRandomTest = New System.Windows.Forms.Button()
        Me.ButtonStopRandomTest = New System.Windows.Forms.Button()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.ComboBoxMicroStepRatio = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ButtonSetBaudRate
        '
        Me.ButtonSetBaudRate.Location = New System.Drawing.Point(678, 495)
        Me.ButtonSetBaudRate.Name = "ButtonSetBaudRate"
        Me.ButtonSetBaudRate.Size = New System.Drawing.Size(114, 23)
        Me.ButtonSetBaudRate.TabIndex = 845
        Me.ButtonSetBaudRate.Text = "Set Baud Rate"
        Me.ButtonSetBaudRate.UseVisualStyleBackColor = True
        '
        'TextBoxBaudRate
        '
        Me.TextBoxBaudRate.Location = New System.Drawing.Point(678, 469)
        Me.TextBoxBaudRate.Name = "TextBoxBaudRate"
        Me.TextBoxBaudRate.Size = New System.Drawing.Size(114, 20)
        Me.TextBoxBaudRate.TabIndex = 844
        '
        'ComboBoxComPorts
        '
        Me.ComboBoxComPorts.FormattingEnabled = True
        Me.ComboBoxComPorts.Location = New System.Drawing.Point(678, 443)
        Me.ComboBoxComPorts.Name = "ComboBoxComPorts"
        Me.ComboBoxComPorts.Size = New System.Drawing.Size(114, 21)
        Me.ComboBoxComPorts.TabIndex = 843
        '
        'LabelComMsg
        '
        Me.LabelComMsg.AutoSize = True
        Me.LabelComMsg.Location = New System.Drawing.Point(675, 427)
        Me.LabelComMsg.Name = "LabelComMsg"
        Me.LabelComMsg.Size = New System.Drawing.Size(98, 13)
        Me.LabelComMsg.TabIndex = 842
        Me.LabelComMsg.Text = "Selected COM Port"
        '
        'LabelTime
        '
        Me.LabelTime.AutoSize = True
        Me.LabelTime.Location = New System.Drawing.Point(14, 476)
        Me.LabelTime.Name = "LabelTime"
        Me.LabelTime.Size = New System.Drawing.Size(30, 13)
        Me.LabelTime.TabIndex = 867
        Me.LabelTime.Text = "Time"
        '
        'LabelMCUVersion
        '
        Me.LabelMCUVersion.AutoSize = True
        Me.LabelMCUVersion.Location = New System.Drawing.Point(14, 489)
        Me.LabelMCUVersion.Name = "LabelMCUVersion"
        Me.LabelMCUVersion.Size = New System.Drawing.Size(63, 13)
        Me.LabelMCUVersion.TabIndex = 866
        Me.LabelMCUVersion.Text = "McuVersion"
        '
        'LabelGUIVersion
        '
        Me.LabelGUIVersion.AutoSize = True
        Me.LabelGUIVersion.Location = New System.Drawing.Point(14, 502)
        Me.LabelGUIVersion.Name = "LabelGUIVersion"
        Me.LabelGUIVersion.Size = New System.Drawing.Size(64, 13)
        Me.LabelGUIVersion.TabIndex = 865
        Me.LabelGUIVersion.Text = "GUI Version"
        '
        'ButtonUpdate
        '
        Me.ButtonUpdate.Location = New System.Drawing.Point(17, 27)
        Me.ButtonUpdate.Name = "ButtonUpdate"
        Me.ButtonUpdate.Size = New System.Drawing.Size(114, 23)
        Me.ButtonUpdate.TabIndex = 873
        Me.ButtonUpdate.Text = "Update Data"
        Me.ButtonUpdate.UseVisualStyleBackColor = True
        '
        'LabelState
        '
        Me.LabelState.AutoSize = True
        Me.LabelState.Location = New System.Drawing.Point(222, 32)
        Me.LabelState.Name = "LabelState"
        Me.LabelState.Size = New System.Drawing.Size(10, 13)
        Me.LabelState.TabIndex = 875
        Me.LabelState.Text = "-"
        '
        'Label93
        '
        Me.Label93.AutoSize = True
        Me.Label93.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label93.Location = New System.Drawing.Point(171, 32)
        Me.Label93.Name = "Label93"
        Me.Label93.Size = New System.Drawing.Size(37, 13)
        Me.Label93.TabIndex = 874
        Me.Label93.Text = "State"
        '
        'ButtonSetPosition
        '
        Me.ButtonSetPosition.Location = New System.Drawing.Point(156, 148)
        Me.ButtonSetPosition.Name = "ButtonSetPosition"
        Me.ButtonSetPosition.Size = New System.Drawing.Size(134, 23)
        Me.ButtonSetPosition.TabIndex = 876
        Me.ButtonSetPosition.Text = "Set Position"
        Me.ButtonSetPosition.UseVisualStyleBackColor = True
        '
        'TextBoxPosition
        '
        Me.TextBoxPosition.Location = New System.Drawing.Point(17, 151)
        Me.TextBoxPosition.Name = "TextBoxPosition"
        Me.TextBoxPosition.Size = New System.Drawing.Size(114, 20)
        Me.TextBoxPosition.TabIndex = 877
        '
        'TextBoxClockWise
        '
        Me.TextBoxClockWise.Location = New System.Drawing.Point(17, 177)
        Me.TextBoxClockWise.Name = "TextBoxClockWise"
        Me.TextBoxClockWise.Size = New System.Drawing.Size(114, 20)
        Me.TextBoxClockWise.TabIndex = 879
        '
        'ButtonClockWise
        '
        Me.ButtonClockWise.Location = New System.Drawing.Point(156, 174)
        Me.ButtonClockWise.Name = "ButtonClockWise"
        Me.ButtonClockWise.Size = New System.Drawing.Size(134, 23)
        Me.ButtonClockWise.TabIndex = 878
        Me.ButtonClockWise.Text = "Move Clockwise"
        Me.ButtonClockWise.UseVisualStyleBackColor = True
        '
        'TextBoxCounterClockwise
        '
        Me.TextBoxCounterClockwise.Location = New System.Drawing.Point(17, 203)
        Me.TextBoxCounterClockwise.Name = "TextBoxCounterClockwise"
        Me.TextBoxCounterClockwise.Size = New System.Drawing.Size(114, 20)
        Me.TextBoxCounterClockwise.TabIndex = 881
        '
        'ButtonCounterClockwise
        '
        Me.ButtonCounterClockwise.Location = New System.Drawing.Point(156, 200)
        Me.ButtonCounterClockwise.Name = "ButtonCounterClockwise"
        Me.ButtonCounterClockwise.Size = New System.Drawing.Size(134, 23)
        Me.ButtonCounterClockwise.TabIndex = 880
        Me.ButtonCounterClockwise.Text = "Move Counter Clockwise"
        Me.ButtonCounterClockwise.UseVisualStyleBackColor = True
        '
        'LabelTarget
        '
        Me.LabelTarget.AutoSize = True
        Me.LabelTarget.Location = New System.Drawing.Point(222, 57)
        Me.LabelTarget.Name = "LabelTarget"
        Me.LabelTarget.Size = New System.Drawing.Size(38, 13)
        Me.LabelTarget.TabIndex = 882
        Me.LabelTarget.Text = "Target"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(171, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 883
        Me.Label2.Text = "Target"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(171, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 885
        Me.Label1.Text = "Position"
        '
        'LabelPosition
        '
        Me.LabelPosition.AutoSize = True
        Me.LabelPosition.Location = New System.Drawing.Point(222, 71)
        Me.LabelPosition.Name = "LabelPosition"
        Me.LabelPosition.Size = New System.Drawing.Size(44, 13)
        Me.LabelPosition.TabIndex = 884
        Me.LabelPosition.Text = "Position"
        '
        'Timer1
        '
        Me.Timer1.Interval = 37
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(647, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 13)
        Me.Label3.TabIndex = 891
        Me.Label3.Text = "I A"
        '
        'LabelIA
        '
        Me.LabelIA.AutoSize = True
        Me.LabelIA.Location = New System.Drawing.Point(728, 35)
        Me.LabelIA.Name = "LabelIA"
        Me.LabelIA.Size = New System.Drawing.Size(20, 13)
        Me.LabelIA.TabIndex = 890
        Me.LabelIA.Text = "I A"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(647, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 889
        Me.Label5.Text = "ADCBUF1"
        '
        'LabelADCBUF1
        '
        Me.LabelADCBUF1.AutoSize = True
        Me.LabelADCBUF1.Location = New System.Drawing.Point(728, 22)
        Me.LabelADCBUF1.Name = "LabelADCBUF1"
        Me.LabelADCBUF1.Size = New System.Drawing.Size(56, 13)
        Me.LabelADCBUF1.TabIndex = 888
        Me.LabelADCBUF1.Text = "ADCBUF1"
        '
        'LabelADCBUF0
        '
        Me.LabelADCBUF0.AutoSize = True
        Me.LabelADCBUF0.Location = New System.Drawing.Point(728, 9)
        Me.LabelADCBUF0.Name = "LabelADCBUF0"
        Me.LabelADCBUF0.Size = New System.Drawing.Size(55, 13)
        Me.LabelADCBUF0.TabIndex = 887
        Me.LabelADCBUF0.Text = "ABCBUF0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(647, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 13)
        Me.Label8.TabIndex = 886
        Me.Label8.Text = "ADCBUF0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label9.Location = New System.Drawing.Point(647, 61)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 13)
        Me.Label9.TabIndex = 895
        Me.Label9.Text = "Parameter"
        '
        'LabelParameter
        '
        Me.LabelParameter.AutoSize = True
        Me.LabelParameter.Location = New System.Drawing.Point(728, 61)
        Me.LabelParameter.Name = "LabelParameter"
        Me.LabelParameter.Size = New System.Drawing.Size(55, 13)
        Me.LabelParameter.TabIndex = 894
        Me.LabelParameter.Text = "Parameter"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(647, 48)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(20, 13)
        Me.Label11.TabIndex = 893
        Me.Label11.Text = "I B"
        '
        'LabelIB
        '
        Me.LabelIB.AutoSize = True
        Me.LabelIB.Location = New System.Drawing.Point(728, 48)
        Me.LabelIB.Name = "LabelIB"
        Me.LabelIB.Size = New System.Drawing.Size(20, 13)
        Me.LabelIB.TabIndex = 892
        Me.LabelIB.Text = "I B"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label4.Location = New System.Drawing.Point(647, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 897
        Me.Label4.Text = "Sigma"
        '
        'LabelSigma
        '
        Me.LabelSigma.AutoSize = True
        Me.LabelSigma.Location = New System.Drawing.Point(728, 100)
        Me.LabelSigma.Name = "LabelSigma"
        Me.LabelSigma.Size = New System.Drawing.Size(36, 13)
        Me.LabelSigma.TabIndex = 896
        Me.LabelSigma.Text = "Sigma"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label6.Location = New System.Drawing.Point(647, 113)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 13)
        Me.Label6.TabIndex = 899
        Me.Label6.Text = "Delta"
        '
        'LabelDelta
        '
        Me.LabelDelta.AutoSize = True
        Me.LabelDelta.Location = New System.Drawing.Point(728, 113)
        Me.LabelDelta.Name = "LabelDelta"
        Me.LabelDelta.Size = New System.Drawing.Size(32, 13)
        Me.LabelDelta.TabIndex = 898
        Me.LabelDelta.Text = "Delta"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label10.Location = New System.Drawing.Point(647, 126)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(29, 13)
        Me.Label10.TabIndex = 901
        Me.Label10.Text = "Error"
        '
        'LabelError
        '
        Me.LabelError.AutoSize = True
        Me.LabelError.Location = New System.Drawing.Point(728, 126)
        Me.LabelError.Name = "LabelError"
        Me.LabelError.Size = New System.Drawing.Size(29, 13)
        Me.LabelError.TabIndex = 900
        Me.LabelError.Text = "Error"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label7.Location = New System.Drawing.Point(647, 139)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 13)
        Me.Label7.TabIndex = 903
        Me.Label7.Text = "Error Offset"
        '
        'LabelErrorOffset
        '
        Me.LabelErrorOffset.AutoSize = True
        Me.LabelErrorOffset.Location = New System.Drawing.Point(728, 139)
        Me.LabelErrorOffset.Name = "LabelErrorOffset"
        Me.LabelErrorOffset.Size = New System.Drawing.Size(60, 13)
        Me.LabelErrorOffset.TabIndex = 902
        Me.LabelErrorOffset.Text = "Error Offset"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label12.Location = New System.Drawing.Point(647, 152)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(28, 13)
        Me.Label12.TabIndex = 905
        Me.Label12.Text = "PRF"
        '
        'LabelPRF
        '
        Me.LabelPRF.AutoSize = True
        Me.LabelPRF.Location = New System.Drawing.Point(728, 152)
        Me.LabelPRF.Name = "LabelPRF"
        Me.LabelPRF.Size = New System.Drawing.Size(28, 13)
        Me.LabelPRF.TabIndex = 904
        Me.LabelPRF.Text = "PRF"
        '
        'ButtonReadErrorHistory
        '
        Me.ButtonReadErrorHistory.Location = New System.Drawing.Point(650, 388)
        Me.ButtonReadErrorHistory.Name = "ButtonReadErrorHistory"
        Me.ButtonReadErrorHistory.Size = New System.Drawing.Size(114, 23)
        Me.ButtonReadErrorHistory.TabIndex = 906
        Me.ButtonReadErrorHistory.Text = "Read Error History"
        Me.ButtonReadErrorHistory.UseVisualStyleBackColor = True
        '
        'LabelD0
        '
        Me.LabelD0.AutoSize = True
        Me.LabelD0.Location = New System.Drawing.Point(647, 261)
        Me.LabelD0.Name = "LabelD0"
        Me.LabelD0.Size = New System.Drawing.Size(39, 13)
        Me.LabelD0.TabIndex = 907
        Me.LabelD0.Text = "History"
        '
        'LabelD1
        '
        Me.LabelD1.AutoSize = True
        Me.LabelD1.Location = New System.Drawing.Point(647, 274)
        Me.LabelD1.Name = "LabelD1"
        Me.LabelD1.Size = New System.Drawing.Size(39, 13)
        Me.LabelD1.TabIndex = 908
        Me.LabelD1.Text = "History"
        '
        'LabelD3
        '
        Me.LabelD3.AutoSize = True
        Me.LabelD3.Location = New System.Drawing.Point(647, 300)
        Me.LabelD3.Name = "LabelD3"
        Me.LabelD3.Size = New System.Drawing.Size(39, 13)
        Me.LabelD3.TabIndex = 910
        Me.LabelD3.Text = "History"
        '
        'LabelD2
        '
        Me.LabelD2.AutoSize = True
        Me.LabelD2.Location = New System.Drawing.Point(647, 287)
        Me.LabelD2.Name = "LabelD2"
        Me.LabelD2.Size = New System.Drawing.Size(39, 13)
        Me.LabelD2.TabIndex = 909
        Me.LabelD2.Text = "History"
        '
        'LabelD7
        '
        Me.LabelD7.AutoSize = True
        Me.LabelD7.Location = New System.Drawing.Point(647, 352)
        Me.LabelD7.Name = "LabelD7"
        Me.LabelD7.Size = New System.Drawing.Size(39, 13)
        Me.LabelD7.TabIndex = 914
        Me.LabelD7.Text = "History"
        '
        'LabelD6
        '
        Me.LabelD6.AutoSize = True
        Me.LabelD6.Location = New System.Drawing.Point(647, 339)
        Me.LabelD6.Name = "LabelD6"
        Me.LabelD6.Size = New System.Drawing.Size(39, 13)
        Me.LabelD6.TabIndex = 913
        Me.LabelD6.Text = "History"
        '
        'LabelD5
        '
        Me.LabelD5.AutoSize = True
        Me.LabelD5.Location = New System.Drawing.Point(647, 326)
        Me.LabelD5.Name = "LabelD5"
        Me.LabelD5.Size = New System.Drawing.Size(39, 13)
        Me.LabelD5.TabIndex = 912
        Me.LabelD5.Text = "History"
        '
        'LabelD4
        '
        Me.LabelD4.AutoSize = True
        Me.LabelD4.Location = New System.Drawing.Point(647, 313)
        Me.LabelD4.Name = "LabelD4"
        Me.LabelD4.Size = New System.Drawing.Size(39, 13)
        Me.LabelD4.TabIndex = 911
        Me.LabelD4.Text = "History"
        '
        'LabelD15
        '
        Me.LabelD15.AutoSize = True
        Me.LabelD15.Location = New System.Drawing.Point(728, 352)
        Me.LabelD15.Name = "LabelD15"
        Me.LabelD15.Size = New System.Drawing.Size(39, 13)
        Me.LabelD15.TabIndex = 922
        Me.LabelD15.Text = "History"
        '
        'LabelD14
        '
        Me.LabelD14.AutoSize = True
        Me.LabelD14.Location = New System.Drawing.Point(728, 339)
        Me.LabelD14.Name = "LabelD14"
        Me.LabelD14.Size = New System.Drawing.Size(39, 13)
        Me.LabelD14.TabIndex = 921
        Me.LabelD14.Text = "History"
        '
        'LabelD13
        '
        Me.LabelD13.AutoSize = True
        Me.LabelD13.Location = New System.Drawing.Point(728, 326)
        Me.LabelD13.Name = "LabelD13"
        Me.LabelD13.Size = New System.Drawing.Size(39, 13)
        Me.LabelD13.TabIndex = 920
        Me.LabelD13.Text = "History"
        '
        'LabelD12
        '
        Me.LabelD12.AutoSize = True
        Me.LabelD12.Location = New System.Drawing.Point(728, 313)
        Me.LabelD12.Name = "LabelD12"
        Me.LabelD12.Size = New System.Drawing.Size(39, 13)
        Me.LabelD12.TabIndex = 919
        Me.LabelD12.Text = "History"
        '
        'LabelD11
        '
        Me.LabelD11.AutoSize = True
        Me.LabelD11.Location = New System.Drawing.Point(728, 300)
        Me.LabelD11.Name = "LabelD11"
        Me.LabelD11.Size = New System.Drawing.Size(39, 13)
        Me.LabelD11.TabIndex = 918
        Me.LabelD11.Text = "History"
        '
        'LabelD10
        '
        Me.LabelD10.AutoSize = True
        Me.LabelD10.Location = New System.Drawing.Point(728, 287)
        Me.LabelD10.Name = "LabelD10"
        Me.LabelD10.Size = New System.Drawing.Size(39, 13)
        Me.LabelD10.TabIndex = 917
        Me.LabelD10.Text = "History"
        '
        'LabelD9
        '
        Me.LabelD9.AutoSize = True
        Me.LabelD9.Location = New System.Drawing.Point(728, 274)
        Me.LabelD9.Name = "LabelD9"
        Me.LabelD9.Size = New System.Drawing.Size(39, 13)
        Me.LabelD9.TabIndex = 916
        Me.LabelD9.Text = "History"
        '
        'LabelD8
        '
        Me.LabelD8.AutoSize = True
        Me.LabelD8.Location = New System.Drawing.Point(728, 261)
        Me.LabelD8.Name = "LabelD8"
        Me.LabelD8.Size = New System.Drawing.Size(39, 13)
        Me.LabelD8.TabIndex = 915
        Me.LabelD8.Text = "History"
        '
        'TextBoxErrorOffset
        '
        Me.TextBoxErrorOffset.Location = New System.Drawing.Point(17, 384)
        Me.TextBoxErrorOffset.Name = "TextBoxErrorOffset"
        Me.TextBoxErrorOffset.Size = New System.Drawing.Size(114, 20)
        Me.TextBoxErrorOffset.TabIndex = 924
        '
        'ButtonSetErrorOffset
        '
        Me.ButtonSetErrorOffset.Location = New System.Drawing.Point(156, 381)
        Me.ButtonSetErrorOffset.Name = "ButtonSetErrorOffset"
        Me.ButtonSetErrorOffset.Size = New System.Drawing.Size(134, 23)
        Me.ButtonSetErrorOffset.TabIndex = 923
        Me.ButtonSetErrorOffset.Text = "Set Offset"
        Me.ButtonSetErrorOffset.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(171, 84)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(39, 13)
        Me.Label13.TabIndex = 926
        Me.Label13.Text = "Home"
        '
        'LabelHome
        '
        Me.LabelHome.AutoSize = True
        Me.LabelHome.Location = New System.Drawing.Point(222, 84)
        Me.LabelHome.Name = "LabelHome"
        Me.LabelHome.Size = New System.Drawing.Size(35, 13)
        Me.LabelHome.TabIndex = 925
        Me.LabelHome.Text = "Home"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(171, 97)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(30, 13)
        Me.Label14.TabIndex = 928
        Me.Label14.Text = "Max"
        '
        'LabelMax
        '
        Me.LabelMax.AutoSize = True
        Me.LabelMax.Location = New System.Drawing.Point(222, 97)
        Me.LabelMax.Name = "LabelMax"
        Me.LabelMax.Size = New System.Drawing.Size(27, 13)
        Me.LabelMax.TabIndex = 927
        Me.LabelMax.Text = "Max"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(171, 110)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(27, 13)
        Me.Label16.TabIndex = 930
        Me.Label16.Text = "Min"
        '
        'LabelMin
        '
        Me.LabelMin.AutoSize = True
        Me.LabelMin.Location = New System.Drawing.Point(222, 110)
        Me.LabelMin.Name = "LabelMin"
        Me.LabelMin.Size = New System.Drawing.Size(24, 13)
        Me.LabelMin.TabIndex = 929
        Me.LabelMin.Text = "Min"
        '
        'ButtonStartLog
        '
        Me.ButtonStartLog.Location = New System.Drawing.Point(17, 275)
        Me.ButtonStartLog.Name = "ButtonStartLog"
        Me.ButtonStartLog.Size = New System.Drawing.Size(114, 23)
        Me.ButtonStartLog.TabIndex = 931
        Me.ButtonStartLog.Text = "Start Log"
        Me.ButtonStartLog.UseVisualStyleBackColor = True
        '
        'ButtonStopLog
        '
        Me.ButtonStopLog.Location = New System.Drawing.Point(156, 275)
        Me.ButtonStopLog.Name = "ButtonStopLog"
        Me.ButtonStopLog.Size = New System.Drawing.Size(114, 23)
        Me.ButtonStopLog.TabIndex = 932
        Me.ButtonStopLog.Text = "Stop Log"
        Me.ButtonStopLog.UseVisualStyleBackColor = True
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 1000
        '
        'TextBoxSetHomePosition
        '
        Me.TextBoxSetHomePosition.Location = New System.Drawing.Point(17, 229)
        Me.TextBoxSetHomePosition.Name = "TextBoxSetHomePosition"
        Me.TextBoxSetHomePosition.Size = New System.Drawing.Size(114, 20)
        Me.TextBoxSetHomePosition.TabIndex = 934
        '
        'ButtonSetHomePosition
        '
        Me.ButtonSetHomePosition.Location = New System.Drawing.Point(156, 226)
        Me.ButtonSetHomePosition.Name = "ButtonSetHomePosition"
        Me.ButtonSetHomePosition.Size = New System.Drawing.Size(134, 23)
        Me.ButtonSetHomePosition.TabIndex = 933
        Me.ButtonSetHomePosition.Text = "Set Home Position"
        Me.ButtonSetHomePosition.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label15.Location = New System.Drawing.Point(647, 165)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(55, 13)
        Me.Label15.TabIndex = 936
        Me.Label15.Text = "On Pulses"
        '
        'LabelOnPulses
        '
        Me.LabelOnPulses.AutoSize = True
        Me.LabelOnPulses.Location = New System.Drawing.Point(728, 165)
        Me.LabelOnPulses.Name = "LabelOnPulses"
        Me.LabelOnPulses.Size = New System.Drawing.Size(55, 13)
        Me.LabelOnPulses.TabIndex = 935
        Me.LabelOnPulses.Text = "On Pulses"
        '
        'ButtonAutoZero
        '
        Me.ButtonAutoZero.Location = New System.Drawing.Point(386, 27)
        Me.ButtonAutoZero.Name = "ButtonAutoZero"
        Me.ButtonAutoZero.Size = New System.Drawing.Size(114, 23)
        Me.ButtonAutoZero.TabIndex = 937
        Me.ButtonAutoZero.Text = "AutoZero"
        Me.ButtonAutoZero.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(386, 148)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(114, 23)
        Me.Button1.TabIndex = 938
        Me.Button1.Text = "Over Current Test"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'ButtonReadRamAddress
        '
        Me.ButtonReadRamAddress.Location = New System.Drawing.Point(329, 399)
        Me.ButtonReadRamAddress.Name = "ButtonReadRamAddress"
        Me.ButtonReadRamAddress.Size = New System.Drawing.Size(114, 23)
        Me.ButtonReadRamAddress.TabIndex = 939
        Me.ButtonReadRamAddress.Text = "Read Ram Address"
        Me.ButtonReadRamAddress.UseVisualStyleBackColor = True
        '
        'TextBoxRamAddress
        '
        Me.TextBoxRamAddress.Location = New System.Drawing.Point(329, 366)
        Me.TextBoxRamAddress.Name = "TextBoxRamAddress"
        Me.TextBoxRamAddress.Size = New System.Drawing.Size(114, 20)
        Me.TextBoxRamAddress.TabIndex = 940
        '
        'LabelRamValue
        '
        Me.LabelRamValue.AutoSize = True
        Me.LabelRamValue.Location = New System.Drawing.Point(326, 427)
        Me.LabelRamValue.Name = "LabelRamValue"
        Me.LabelRamValue.Size = New System.Drawing.Size(100, 13)
        Me.LabelRamValue.TabIndex = 941
        Me.LabelRamValue.Text = "Ram Value Decimal"
        '
        'LabelRamValueHex
        '
        Me.LabelRamValueHex.AutoSize = True
        Me.LabelRamValueHex.Location = New System.Drawing.Point(326, 446)
        Me.LabelRamValueHex.Name = "LabelRamValueHex"
        Me.LabelRamValueHex.Size = New System.Drawing.Size(84, 13)
        Me.LabelRamValueHex.TabIndex = 942
        Me.LabelRamValueHex.Text = "Ram Value HEX"
        '
        'LabelRamValueBinary
        '
        Me.LabelRamValueBinary.AutoSize = True
        Me.LabelRamValueBinary.Location = New System.Drawing.Point(326, 469)
        Me.LabelRamValueBinary.Name = "LabelRamValueBinary"
        Me.LabelRamValueBinary.Size = New System.Drawing.Size(91, 13)
        Me.LabelRamValueBinary.TabIndex = 943
        Me.LabelRamValueBinary.Text = "Ram Value Binary"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label17.Location = New System.Drawing.Point(647, 179)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(47, 13)
        Me.Label17.TabIndex = 945
        Me.Label17.Text = "Time Off"
        '
        'LabelTimeOff
        '
        Me.LabelTimeOff.AutoSize = True
        Me.LabelTimeOff.Location = New System.Drawing.Point(728, 179)
        Me.LabelTimeOff.Name = "LabelTimeOff"
        Me.LabelTimeOff.Size = New System.Drawing.Size(47, 13)
        Me.LabelTimeOff.TabIndex = 944
        Me.LabelTimeOff.Text = "Time Off"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label18.Location = New System.Drawing.Point(647, 192)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(69, 13)
        Me.Label18.TabIndex = 947
        Me.Label18.Text = "Stop Position"
        '
        'LabelStopPosition
        '
        Me.LabelStopPosition.AutoSize = True
        Me.LabelStopPosition.Location = New System.Drawing.Point(728, 192)
        Me.LabelStopPosition.Name = "LabelStopPosition"
        Me.LabelStopPosition.Size = New System.Drawing.Size(69, 13)
        Me.LabelStopPosition.TabIndex = 946
        Me.LabelStopPosition.Text = "Stop Position"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label19.Location = New System.Drawing.Point(647, 74)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(67, 13)
        Me.Label19.TabIndex = 949
        Me.Label19.Text = "Analog Input"
        '
        'LabelAnalogInput
        '
        Me.LabelAnalogInput.AutoSize = True
        Me.LabelAnalogInput.Location = New System.Drawing.Point(728, 74)
        Me.LabelAnalogInput.Name = "LabelAnalogInput"
        Me.LabelAnalogInput.Size = New System.Drawing.Size(67, 13)
        Me.LabelAnalogInput.TabIndex = 948
        Me.LabelAnalogInput.Text = "Analog Input"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label20.Location = New System.Drawing.Point(647, 87)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(75, 13)
        Me.Label20.TabIndex = 951
        Me.Label20.Text = "Analog Output"
        '
        'LabelAnalogOutput
        '
        Me.LabelAnalogOutput.AutoSize = True
        Me.LabelAnalogOutput.Location = New System.Drawing.Point(728, 87)
        Me.LabelAnalogOutput.Name = "LabelAnalogOutput"
        Me.LabelAnalogOutput.Size = New System.Drawing.Size(75, 13)
        Me.LabelAnalogOutput.TabIndex = 950
        Me.LabelAnalogOutput.Text = "Analog Output"
        '
        'ButtonCoolDown
        '
        Me.ButtonCoolDown.Location = New System.Drawing.Point(650, 226)
        Me.ButtonCoolDown.Name = "ButtonCoolDown"
        Me.ButtonCoolDown.Size = New System.Drawing.Size(114, 23)
        Me.ButtonCoolDown.TabIndex = 952
        Me.ButtonCoolDown.Text = "Finish Cool Down"
        Me.ButtonCoolDown.UseVisualStyleBackColor = True
        '
        'TextBoxSetDamping
        '
        Me.TextBoxSetDamping.Location = New System.Drawing.Point(329, 313)
        Me.TextBoxSetDamping.Name = "TextBoxSetDamping"
        Me.TextBoxSetDamping.Size = New System.Drawing.Size(114, 20)
        Me.TextBoxSetDamping.TabIndex = 956
        Me.TextBoxSetDamping.Text = "6"
        Me.TextBoxSetDamping.Visible = False
        '
        'ButtonSetDamping
        '
        Me.ButtonSetDamping.Location = New System.Drawing.Point(468, 310)
        Me.ButtonSetDamping.Name = "ButtonSetDamping"
        Me.ButtonSetDamping.Size = New System.Drawing.Size(134, 23)
        Me.ButtonSetDamping.TabIndex = 955
        Me.ButtonSetDamping.Text = "Set Motor Damping"
        Me.ButtonSetDamping.UseVisualStyleBackColor = True
        Me.ButtonSetDamping.Visible = False
        '
        'TextBoxSetSpeed
        '
        Me.TextBoxSetSpeed.Location = New System.Drawing.Point(329, 287)
        Me.TextBoxSetSpeed.Name = "TextBoxSetSpeed"
        Me.TextBoxSetSpeed.Size = New System.Drawing.Size(114, 20)
        Me.TextBoxSetSpeed.TabIndex = 954
        Me.TextBoxSetSpeed.Text = "100"
        Me.TextBoxSetSpeed.Visible = False
        '
        'ButtonSetSpeed
        '
        Me.ButtonSetSpeed.Location = New System.Drawing.Point(468, 284)
        Me.ButtonSetSpeed.Name = "ButtonSetSpeed"
        Me.ButtonSetSpeed.Size = New System.Drawing.Size(134, 23)
        Me.ButtonSetSpeed.TabIndex = 953
        Me.ButtonSetSpeed.Text = "Set Speed"
        Me.ButtonSetSpeed.UseVisualStyleBackColor = True
        Me.ButtonSetSpeed.Visible = False
        '
        'ButtonStartRandomTest
        '
        Me.ButtonStartRandomTest.Location = New System.Drawing.Point(468, 399)
        Me.ButtonStartRandomTest.Name = "ButtonStartRandomTest"
        Me.ButtonStartRandomTest.Size = New System.Drawing.Size(114, 23)
        Me.ButtonStartRandomTest.TabIndex = 957
        Me.ButtonStartRandomTest.Text = "Start MK Test"
        Me.ButtonStartRandomTest.UseVisualStyleBackColor = True
        Me.ButtonStartRandomTest.Visible = False
        '
        'ButtonStopRandomTest
        '
        Me.ButtonStopRandomTest.Location = New System.Drawing.Point(468, 427)
        Me.ButtonStopRandomTest.Name = "ButtonStopRandomTest"
        Me.ButtonStopRandomTest.Size = New System.Drawing.Size(114, 23)
        Me.ButtonStopRandomTest.TabIndex = 958
        Me.ButtonStopRandomTest.Text = "Stop MK Test"
        Me.ButtonStopRandomTest.UseVisualStyleBackColor = True
        Me.ButtonStopRandomTest.Visible = False
        '
        'Timer3
        '
        '
        'ComboBoxMicroStepRatio
        '
        Me.ComboBoxMicroStepRatio.FormattingEnabled = True
        Me.ComboBoxMicroStepRatio.Items.AddRange(New Object() {"1", "2", "4"})
        Me.ComboBoxMicroStepRatio.Location = New System.Drawing.Point(478, 499)
        Me.ComboBoxMicroStepRatio.Name = "ComboBoxMicroStepRatio"
        Me.ComboBoxMicroStepRatio.Size = New System.Drawing.Size(114, 21)
        Me.ComboBoxMicroStepRatio.TabIndex = 959
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(475, 483)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(162, 13)
        Me.Label21.TabIndex = 960
        Me.Label21.Text = "MicroStep Ratio for Display"
        '
        'FormOverCurrentTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(820, 530)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.ComboBoxMicroStepRatio)
        Me.Controls.Add(Me.ButtonStopRandomTest)
        Me.Controls.Add(Me.ButtonStartRandomTest)
        Me.Controls.Add(Me.TextBoxSetDamping)
        Me.Controls.Add(Me.ButtonSetDamping)
        Me.Controls.Add(Me.TextBoxSetSpeed)
        Me.Controls.Add(Me.ButtonSetSpeed)
        Me.Controls.Add(Me.ButtonCoolDown)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.LabelAnalogOutput)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.LabelAnalogInput)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.LabelStopPosition)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.LabelTimeOff)
        Me.Controls.Add(Me.LabelRamValueBinary)
        Me.Controls.Add(Me.LabelRamValueHex)
        Me.Controls.Add(Me.LabelRamValue)
        Me.Controls.Add(Me.TextBoxRamAddress)
        Me.Controls.Add(Me.ButtonReadRamAddress)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ButtonAutoZero)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.LabelOnPulses)
        Me.Controls.Add(Me.TextBoxSetHomePosition)
        Me.Controls.Add(Me.ButtonSetHomePosition)
        Me.Controls.Add(Me.ButtonStopLog)
        Me.Controls.Add(Me.ButtonStartLog)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.LabelMin)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.LabelMax)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.LabelHome)
        Me.Controls.Add(Me.TextBoxErrorOffset)
        Me.Controls.Add(Me.ButtonSetErrorOffset)
        Me.Controls.Add(Me.LabelD15)
        Me.Controls.Add(Me.LabelD14)
        Me.Controls.Add(Me.LabelD13)
        Me.Controls.Add(Me.LabelD12)
        Me.Controls.Add(Me.LabelD11)
        Me.Controls.Add(Me.LabelD10)
        Me.Controls.Add(Me.LabelD9)
        Me.Controls.Add(Me.LabelD8)
        Me.Controls.Add(Me.LabelD7)
        Me.Controls.Add(Me.LabelD6)
        Me.Controls.Add(Me.LabelD5)
        Me.Controls.Add(Me.LabelD4)
        Me.Controls.Add(Me.LabelD3)
        Me.Controls.Add(Me.LabelD2)
        Me.Controls.Add(Me.LabelD1)
        Me.Controls.Add(Me.LabelD0)
        Me.Controls.Add(Me.ButtonReadErrorHistory)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.LabelPRF)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.LabelErrorOffset)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.LabelError)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LabelDelta)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LabelSigma)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.LabelParameter)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.LabelIB)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LabelIA)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LabelADCBUF1)
        Me.Controls.Add(Me.LabelADCBUF0)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LabelPosition)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LabelTarget)
        Me.Controls.Add(Me.TextBoxCounterClockwise)
        Me.Controls.Add(Me.ButtonCounterClockwise)
        Me.Controls.Add(Me.TextBoxClockWise)
        Me.Controls.Add(Me.ButtonClockWise)
        Me.Controls.Add(Me.TextBoxPosition)
        Me.Controls.Add(Me.ButtonSetPosition)
        Me.Controls.Add(Me.LabelState)
        Me.Controls.Add(Me.Label93)
        Me.Controls.Add(Me.ButtonUpdate)
        Me.Controls.Add(Me.LabelTime)
        Me.Controls.Add(Me.LabelMCUVersion)
        Me.Controls.Add(Me.LabelGUIVersion)
        Me.Controls.Add(Me.ButtonSetBaudRate)
        Me.Controls.Add(Me.TextBoxBaudRate)
        Me.Controls.Add(Me.ComboBoxComPorts)
        Me.Controls.Add(Me.LabelComMsg)
        Me.Name = "FormOverCurrentTest"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonSetBaudRate As System.Windows.Forms.Button
    Friend WithEvents TextBoxBaudRate As System.Windows.Forms.TextBox
    Friend WithEvents ComboBoxComPorts As System.Windows.Forms.ComboBox
    Friend WithEvents LabelComMsg As System.Windows.Forms.Label
    Friend WithEvents SerialPortETM As System.IO.Ports.SerialPort
    Friend WithEvents LabelTime As System.Windows.Forms.Label
    Friend WithEvents LabelMCUVersion As System.Windows.Forms.Label
    Friend WithEvents LabelGUIVersion As System.Windows.Forms.Label
    Friend WithEvents ButtonUpdate As System.Windows.Forms.Button
    Friend WithEvents LabelState As System.Windows.Forms.Label
    Friend WithEvents Label93 As System.Windows.Forms.Label
    Friend WithEvents ButtonSetPosition As System.Windows.Forms.Button
    Friend WithEvents TextBoxPosition As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxClockWise As System.Windows.Forms.TextBox
    Friend WithEvents ButtonClockWise As System.Windows.Forms.Button
    Friend WithEvents TextBoxCounterClockwise As System.Windows.Forms.TextBox
    Friend WithEvents ButtonCounterClockwise As System.Windows.Forms.Button
    Friend WithEvents LabelTarget As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LabelPosition As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LabelIA As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LabelADCBUF1 As System.Windows.Forms.Label
    Friend WithEvents LabelADCBUF0 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents LabelParameter As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents LabelIB As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LabelSigma As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LabelDelta As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents LabelError As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents LabelErrorOffset As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents LabelPRF As System.Windows.Forms.Label
    Friend WithEvents ButtonReadErrorHistory As System.Windows.Forms.Button
    Friend WithEvents LabelD0 As System.Windows.Forms.Label
    Friend WithEvents LabelD1 As System.Windows.Forms.Label
    Friend WithEvents LabelD3 As System.Windows.Forms.Label
    Friend WithEvents LabelD2 As System.Windows.Forms.Label
    Friend WithEvents LabelD7 As System.Windows.Forms.Label
    Friend WithEvents LabelD6 As System.Windows.Forms.Label
    Friend WithEvents LabelD5 As System.Windows.Forms.Label
    Friend WithEvents LabelD4 As System.Windows.Forms.Label
    Friend WithEvents LabelD15 As System.Windows.Forms.Label
    Friend WithEvents LabelD14 As System.Windows.Forms.Label
    Friend WithEvents LabelD13 As System.Windows.Forms.Label
    Friend WithEvents LabelD12 As System.Windows.Forms.Label
    Friend WithEvents LabelD11 As System.Windows.Forms.Label
    Friend WithEvents LabelD10 As System.Windows.Forms.Label
    Friend WithEvents LabelD9 As System.Windows.Forms.Label
    Friend WithEvents LabelD8 As System.Windows.Forms.Label
    Friend WithEvents TextBoxErrorOffset As System.Windows.Forms.TextBox
    Friend WithEvents ButtonSetErrorOffset As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents LabelHome As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents LabelMax As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents LabelMin As System.Windows.Forms.Label
    Friend WithEvents ButtonStartLog As System.Windows.Forms.Button
    Friend WithEvents ButtonStopLog As System.Windows.Forms.Button
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents TextBoxSetHomePosition As System.Windows.Forms.TextBox
    Friend WithEvents ButtonSetHomePosition As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents LabelOnPulses As System.Windows.Forms.Label
    Friend WithEvents ButtonAutoZero As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ButtonReadRamAddress As System.Windows.Forms.Button
    Friend WithEvents TextBoxRamAddress As System.Windows.Forms.TextBox
    Friend WithEvents LabelRamValue As System.Windows.Forms.Label
    Friend WithEvents LabelRamValueHex As System.Windows.Forms.Label
    Friend WithEvents LabelRamValueBinary As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents LabelTimeOff As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents LabelStopPosition As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents LabelAnalogInput As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents LabelAnalogOutput As System.Windows.Forms.Label
    Friend WithEvents ButtonCoolDown As System.Windows.Forms.Button
    Friend WithEvents TextBoxSetDamping As System.Windows.Forms.TextBox
    Friend WithEvents ButtonSetDamping As System.Windows.Forms.Button
    Friend WithEvents TextBoxSetSpeed As System.Windows.Forms.TextBox
    Friend WithEvents ButtonSetSpeed As System.Windows.Forms.Button
    Friend WithEvents ButtonStartRandomTest As System.Windows.Forms.Button
    Friend WithEvents ButtonStopRandomTest As System.Windows.Forms.Button
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents ComboBoxMicroStepRatio As System.Windows.Forms.ComboBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
End Class
