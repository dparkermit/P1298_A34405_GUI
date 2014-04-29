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
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(820, 530)
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
End Class
