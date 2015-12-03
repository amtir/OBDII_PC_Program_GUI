<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOdb2
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
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblProtocol = New System.Windows.Forms.Label()
        Me.lblVolt = New System.Windows.Forms.Label()
        Me.lblTemp = New System.Windows.Forms.Label()
        Me.lblRPM = New System.Windows.Forms.Label()
        Me.lblSpeed = New System.Windows.Forms.Label()
        Me.gbDataLogger = New System.Windows.Forms.GroupBox()
        Me.cbSpeed = New System.Windows.Forms.CheckBox()
        Me.cbRPM = New System.Windows.Forms.CheckBox()
        Me.cbTemp = New System.Windows.Forms.CheckBox()
        Me.cbRTC = New System.Windows.Forms.CheckBox()
        Me.btDump = New System.Windows.Forms.Button()
        Me.gbFrequency = New System.Windows.Forms.GroupBox()
        Me.rd50ms = New System.Windows.Forms.RadioButton()
        Me.rd1s = New System.Windows.Forms.RadioButton()
        Me.rd500ms = New System.Windows.Forms.RadioButton()
        Me.rd100ms = New System.Windows.Forms.RadioButton()
        Me.gbDTC = New System.Windows.Forms.GroupBox()
        Me.btReset = New System.Windows.Forms.Button()
        Me.btDiagn = New System.Windows.Forms.Button()
        Me.lblLTC = New System.Windows.Forms.Label()
        Me.lblNbrTC = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.gbDataLogger.SuspendLayout()
        Me.gbFrequency.SuspendLayout()
        Me.gbDTC.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'btnConnect
        '
        Me.btnConnect.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConnect.Location = New System.Drawing.Point(17, 451)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(507, 44)
        Me.btnConnect.TabIndex = 2
        Me.btnConnect.Text = "Start Connect"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescription.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblDescription.Location = New System.Drawing.Point(12, 9)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(207, 25)
        Me.lblDescription.TabIndex = 3
        Me.lblDescription.Text = "Device description"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblID.Location = New System.Drawing.Point(13, 34)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(107, 24)
        Me.lblID.TabIndex = 4
        Me.lblID.Text = "Version ID"
        '
        'lblProtocol
        '
        Me.lblProtocol.AutoSize = True
        Me.lblProtocol.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProtocol.Location = New System.Drawing.Point(13, 58)
        Me.lblProtocol.Name = "lblProtocol"
        Me.lblProtocol.Size = New System.Drawing.Size(67, 20)
        Me.lblProtocol.TabIndex = 5
        Me.lblProtocol.Text = "Protocol"
        '
        'lblVolt
        '
        Me.lblVolt.AutoSize = True
        Me.lblVolt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVolt.Location = New System.Drawing.Point(13, 78)
        Me.lblVolt.Name = "lblVolt"
        Me.lblVolt.Size = New System.Drawing.Size(115, 20)
        Me.lblVolt.TabIndex = 6
        Me.lblVolt.Text = "Battery voltage"
        '
        'lblTemp
        '
        Me.lblTemp.AutoSize = True
        Me.lblTemp.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTemp.ForeColor = System.Drawing.Color.Green
        Me.lblTemp.Location = New System.Drawing.Point(14, 152)
        Me.lblTemp.Name = "lblTemp"
        Me.lblTemp.Size = New System.Drawing.Size(280, 24)
        Me.lblTemp.TabIndex = 7
        Me.lblTemp.Text = "Engine Coolant Temperature"
        '
        'lblRPM
        '
        Me.lblRPM.AutoSize = True
        Me.lblRPM.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRPM.ForeColor = System.Drawing.Color.Green
        Me.lblRPM.Location = New System.Drawing.Point(14, 104)
        Me.lblRPM.Name = "lblRPM"
        Me.lblRPM.Size = New System.Drawing.Size(127, 24)
        Me.lblRPM.TabIndex = 8
        Me.lblRPM.Text = "Engine RPM"
        '
        'lblSpeed
        '
        Me.lblSpeed.AutoSize = True
        Me.lblSpeed.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSpeed.ForeColor = System.Drawing.Color.Green
        Me.lblSpeed.Location = New System.Drawing.Point(14, 128)
        Me.lblSpeed.Name = "lblSpeed"
        Me.lblSpeed.Size = New System.Drawing.Size(160, 24)
        Me.lblSpeed.TabIndex = 9
        Me.lblSpeed.Text = "Vehicule Speed"
        '
        'gbDataLogger
        '
        Me.gbDataLogger.Controls.Add(Me.cbSpeed)
        Me.gbDataLogger.Controls.Add(Me.cbRPM)
        Me.gbDataLogger.Controls.Add(Me.cbTemp)
        Me.gbDataLogger.Controls.Add(Me.cbRTC)
        Me.gbDataLogger.Controls.Add(Me.btDump)
        Me.gbDataLogger.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDataLogger.Location = New System.Drawing.Point(18, 205)
        Me.gbDataLogger.Name = "gbDataLogger"
        Me.gbDataLogger.Size = New System.Drawing.Size(211, 228)
        Me.gbDataLogger.TabIndex = 11
        Me.gbDataLogger.TabStop = False
        Me.gbDataLogger.Text = "Data Logger"
        '
        'cbSpeed
        '
        Me.cbSpeed.AutoSize = True
        Me.cbSpeed.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSpeed.Location = New System.Drawing.Point(21, 129)
        Me.cbSpeed.Name = "cbSpeed"
        Me.cbSpeed.Size = New System.Drawing.Size(121, 20)
        Me.cbSpeed.TabIndex = 4
        Me.cbSpeed.Text = "Vehicule speed"
        Me.cbSpeed.UseVisualStyleBackColor = True
        '
        'cbRPM
        '
        Me.cbRPM.AutoSize = True
        Me.cbRPM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbRPM.Location = New System.Drawing.Point(21, 99)
        Me.cbRPM.Name = "cbRPM"
        Me.cbRPM.Size = New System.Drawing.Size(102, 20)
        Me.cbRPM.TabIndex = 3
        Me.cbRPM.Text = "Engine RPM"
        Me.cbRPM.UseVisualStyleBackColor = True
        '
        'cbTemp
        '
        Me.cbTemp.AutoSize = True
        Me.cbTemp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTemp.Location = New System.Drawing.Point(20, 69)
        Me.cbTemp.Name = "cbTemp"
        Me.cbTemp.Size = New System.Drawing.Size(154, 20)
        Me.cbTemp.TabIndex = 2
        Me.cbTemp.Text = "Coolant Temperature"
        Me.cbTemp.UseVisualStyleBackColor = True
        '
        'cbRTC
        '
        Me.cbRTC.AutoSize = True
        Me.cbRTC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbRTC.Location = New System.Drawing.Point(20, 39)
        Me.cbRTC.Name = "cbRTC"
        Me.cbRTC.Size = New System.Drawing.Size(121, 20)
        Me.cbRTC.TabIndex = 1
        Me.cbRTC.Text = "RTC Date Time"
        Me.cbRTC.UseVisualStyleBackColor = True
        '
        'btDump
        '
        Me.btDump.Location = New System.Drawing.Point(20, 160)
        Me.btDump.Name = "btDump"
        Me.btDump.Size = New System.Drawing.Size(116, 48)
        Me.btDump.TabIndex = 0
        Me.btDump.Text = "Dump Collect"
        Me.btDump.UseVisualStyleBackColor = True
        '
        'gbFrequency
        '
        Me.gbFrequency.Controls.Add(Me.rd50ms)
        Me.gbFrequency.Controls.Add(Me.rd1s)
        Me.gbFrequency.Controls.Add(Me.rd500ms)
        Me.gbFrequency.Controls.Add(Me.rd100ms)
        Me.gbFrequency.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbFrequency.Location = New System.Drawing.Point(399, 12)
        Me.gbFrequency.Name = "gbFrequency"
        Me.gbFrequency.Size = New System.Drawing.Size(125, 164)
        Me.gbFrequency.TabIndex = 12
        Me.gbFrequency.TabStop = False
        Me.gbFrequency.Text = "Frequency"
        '
        'rd50ms
        '
        Me.rd50ms.AutoSize = True
        Me.rd50ms.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rd50ms.Location = New System.Drawing.Point(25, 40)
        Me.rd50ms.Name = "rd50ms"
        Me.rd50ms.Size = New System.Drawing.Size(58, 20)
        Me.rd50ms.TabIndex = 3
        Me.rd50ms.TabStop = True
        Me.rd50ms.Text = "50ms"
        Me.rd50ms.UseVisualStyleBackColor = True
        '
        'rd1s
        '
        Me.rd1s.AutoSize = True
        Me.rd1s.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rd1s.Location = New System.Drawing.Point(25, 118)
        Me.rd1s.Name = "rd1s"
        Me.rd1s.Size = New System.Drawing.Size(40, 20)
        Me.rd1s.TabIndex = 2
        Me.rd1s.TabStop = True
        Me.rd1s.Text = "1s"
        Me.rd1s.UseVisualStyleBackColor = True
        '
        'rd500ms
        '
        Me.rd500ms.AutoSize = True
        Me.rd500ms.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rd500ms.Location = New System.Drawing.Point(25, 92)
        Me.rd500ms.Name = "rd500ms"
        Me.rd500ms.Size = New System.Drawing.Size(65, 20)
        Me.rd500ms.TabIndex = 1
        Me.rd500ms.TabStop = True
        Me.rd500ms.Text = "500ms"
        Me.rd500ms.UseVisualStyleBackColor = True
        '
        'rd100ms
        '
        Me.rd100ms.AutoSize = True
        Me.rd100ms.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rd100ms.Location = New System.Drawing.Point(25, 66)
        Me.rd100ms.Name = "rd100ms"
        Me.rd100ms.Size = New System.Drawing.Size(65, 20)
        Me.rd100ms.TabIndex = 0
        Me.rd100ms.TabStop = True
        Me.rd100ms.Text = "100ms"
        Me.rd100ms.UseVisualStyleBackColor = True
        '
        'gbDTC
        '
        Me.gbDTC.Controls.Add(Me.btReset)
        Me.gbDTC.Controls.Add(Me.btDiagn)
        Me.gbDTC.Controls.Add(Me.lblLTC)
        Me.gbDTC.Controls.Add(Me.lblNbrTC)
        Me.gbDTC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDTC.Location = New System.Drawing.Point(264, 205)
        Me.gbDTC.Name = "gbDTC"
        Me.gbDTC.Size = New System.Drawing.Size(260, 228)
        Me.gbDTC.TabIndex = 13
        Me.gbDTC.TabStop = False
        Me.gbDTC.Text = "Diagnostic Trouble Codes"
        '
        'btReset
        '
        Me.btReset.Location = New System.Drawing.Point(75, 199)
        Me.btReset.Name = "btReset"
        Me.btReset.Size = New System.Drawing.Size(116, 23)
        Me.btReset.TabIndex = 3
        Me.btReset.Text = "Reset TC"
        Me.btReset.UseVisualStyleBackColor = True
        '
        'btDiagn
        '
        Me.btDiagn.Location = New System.Drawing.Point(75, 155)
        Me.btDiagn.Name = "btDiagn"
        Me.btDiagn.Size = New System.Drawing.Size(116, 24)
        Me.btDiagn.TabIndex = 2
        Me.btDiagn.Text = "Diagnostic TC"
        Me.btDiagn.UseVisualStyleBackColor = True
        '
        'lblLTC
        '
        Me.lblLTC.AutoSize = True
        Me.lblLTC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLTC.Location = New System.Drawing.Point(16, 69)
        Me.lblLTC.Name = "lblLTC"
        Me.lblLTC.Size = New System.Drawing.Size(124, 13)
        Me.lblLTC.TabIndex = 1
        Me.lblLTC.Text = "List of the Troubles code"
        '
        'lblNbrTC
        '
        Me.lblNbrTC.AutoSize = True
        Me.lblNbrTC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNbrTC.Location = New System.Drawing.Point(16, 39)
        Me.lblNbrTC.Name = "lblNbrTC"
        Me.lblNbrTC.Size = New System.Drawing.Size(128, 13)
        Me.lblNbrTC.TabIndex = 0
        Me.lblNbrTC.Text = "Number of Trouble Codes"
        '
        'Timer2
        '
        '
        'frmOdb2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(536, 507)
        Me.Controls.Add(Me.gbDTC)
        Me.Controls.Add(Me.gbFrequency)
        Me.Controls.Add(Me.gbDataLogger)
        Me.Controls.Add(Me.lblSpeed)
        Me.Controls.Add(Me.lblRPM)
        Me.Controls.Add(Me.lblTemp)
        Me.Controls.Add(Me.lblVolt)
        Me.Controls.Add(Me.lblProtocol)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.btnConnect)
        Me.Name = "frmOdb2"
        Me.Text = "ODB2 Diagnostic Interface"
        Me.gbDataLogger.ResumeLayout(False)
        Me.gbDataLogger.PerformLayout()
        Me.gbFrequency.ResumeLayout(False)
        Me.gbFrequency.PerformLayout()
        Me.gbDTC.ResumeLayout(False)
        Me.gbDTC.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnConnect As System.Windows.Forms.Button
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents lblProtocol As System.Windows.Forms.Label
    Friend WithEvents lblVolt As System.Windows.Forms.Label
    Friend WithEvents lblTemp As System.Windows.Forms.Label
    Friend WithEvents lblRPM As System.Windows.Forms.Label
    Friend WithEvents lblSpeed As System.Windows.Forms.Label
    Friend WithEvents gbDataLogger As System.Windows.Forms.GroupBox
    Friend WithEvents btDump As System.Windows.Forms.Button
    Friend WithEvents gbFrequency As System.Windows.Forms.GroupBox
    Friend WithEvents rd1s As System.Windows.Forms.RadioButton
    Friend WithEvents rd500ms As System.Windows.Forms.RadioButton
    Friend WithEvents rd100ms As System.Windows.Forms.RadioButton
    Friend WithEvents cbSpeed As System.Windows.Forms.CheckBox
    Friend WithEvents cbRPM As System.Windows.Forms.CheckBox
    Friend WithEvents cbTemp As System.Windows.Forms.CheckBox
    Friend WithEvents cbRTC As System.Windows.Forms.CheckBox
    Friend WithEvents gbDTC As System.Windows.Forms.GroupBox
    Friend WithEvents btReset As System.Windows.Forms.Button
    Friend WithEvents btDiagn As System.Windows.Forms.Button
    Friend WithEvents lblLTC As System.Windows.Forms.Label
    Friend WithEvents lblNbrTC As System.Windows.Forms.Label
    Friend WithEvents rd50ms As System.Windows.Forms.RadioButton
    Friend WithEvents Timer2 As System.Windows.Forms.Timer

End Class
