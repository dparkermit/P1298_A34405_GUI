<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Button2 = New System.Windows.Forms.Button()
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
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(156, 200)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(134, 23)
        Me.Button2.TabIndex = 880
        Me.Button2.Text = "Move Counter Clockwise"
        Me.Button2.UseVisualStyleBackColor = True
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
        Me.Label1.Location = New System.Drawing.Point(171, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 885
        Me.Label1.Text = "Position"
        '
        'LabelPosition
        '
        Me.LabelPosition.AutoSize = True
        Me.LabelPosition.Location = New System.Drawing.Point(222, 81)
        Me.LabelPosition.Name = "LabelPosition"
        Me.LabelPosition.Size = New System.Drawing.Size(44, 13)
        Me.LabelPosition.TabIndex = 884
        Me.LabelPosition.Text = "Position"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(646, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 13)
        Me.Label3.TabIndex = 891
        Me.Label3.Text = "I A"
        '
        'LabelIA
        '
        Me.LabelIA.AutoSize = True
        Me.LabelIA.Location = New System.Drawing.Point(727, 58)
        Me.LabelIA.Name = "LabelIA"
        Me.LabelIA.Size = New System.Drawing.Size(20, 13)
        Me.LabelIA.TabIndex = 890
        Me.LabelIA.Text = "I A"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(646, 45)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 889
        Me.Label5.Text = "ADCBUF1"
        '
        'LabelADCBUF1
        '
        Me.LabelADCBUF1.AutoSize = True
        Me.LabelADCBUF1.Location = New System.Drawing.Point(727, 45)
        Me.LabelADCBUF1.Name = "LabelADCBUF1"
        Me.LabelADCBUF1.Size = New System.Drawing.Size(56, 13)
        Me.LabelADCBUF1.TabIndex = 888
        Me.LabelADCBUF1.Text = "ADCBUF1"
        '
        'LabelADCBUF0
        '
        Me.LabelADCBUF0.AutoSize = True
        Me.LabelADCBUF0.Location = New System.Drawing.Point(727, 32)
        Me.LabelADCBUF0.Name = "LabelADCBUF0"
        Me.LabelADCBUF0.Size = New System.Drawing.Size(55, 13)
        Me.LabelADCBUF0.TabIndex = 887
        Me.LabelADCBUF0.Text = "ABCBUF0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(646, 32)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 13)
        Me.Label8.TabIndex = 886
        Me.Label8.Text = "ADCBUF0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label9.Location = New System.Drawing.Point(646, 84)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 13)
        Me.Label9.TabIndex = 895
        Me.Label9.Text = "Parameter"
        '
        'LabelParameter
        '
        Me.LabelParameter.AutoSize = True
        Me.LabelParameter.Location = New System.Drawing.Point(727, 84)
        Me.LabelParameter.Name = "LabelParameter"
        Me.LabelParameter.Size = New System.Drawing.Size(55, 13)
        Me.LabelParameter.TabIndex = 894
        Me.LabelParameter.Text = "Parameter"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(646, 71)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(20, 13)
        Me.Label11.TabIndex = 893
        Me.Label11.Text = "I B"
        '
        'LabelIB
        '
        Me.LabelIB.AutoSize = True
        Me.LabelIB.Location = New System.Drawing.Point(727, 71)
        Me.LabelIB.Name = "LabelIB"
        Me.LabelIB.Size = New System.Drawing.Size(20, 13)
        Me.LabelIB.TabIndex = 892
        Me.LabelIB.Text = "I B"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(820, 530)
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
        Me.Controls.Add(Me.Button2)
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
        Me.Name = "Form1"
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
    Friend WithEvents Button2 As System.Windows.Forms.Button
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
End Class
