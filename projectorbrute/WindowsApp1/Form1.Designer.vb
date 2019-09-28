<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.SP = New System.IO.Ports.SerialPort(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtcom = New System.Windows.Forms.TextBox()
        Me.txtbaud = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.txt4 = New System.Windows.Forms.TextBox()
        Me.txt3 = New System.Windows.Forms.TextBox()
        Me.txt2 = New System.Windows.Forms.TextBox()
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SP
        '
        Me.SP.PortName = "COM5"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "COM PORT"
        '
        'txtcom
        '
        Me.txtcom.Location = New System.Drawing.Point(82, 6)
        Me.txtcom.Name = "txtcom"
        Me.txtcom.Size = New System.Drawing.Size(75, 20)
        Me.txtcom.TabIndex = 1
        Me.txtcom.Text = "COM5"
        '
        'txtbaud
        '
        Me.txtbaud.Location = New System.Drawing.Point(82, 32)
        Me.txtbaud.Name = "txtbaud"
        Me.txtbaud.Size = New System.Drawing.Size(75, 20)
        Me.txtbaud.TabIndex = 3
        Me.txtbaud.Text = "19200"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "BAUDRATE"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(163, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(122, 45)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "OPEN PORT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(17, 61)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(128, 26)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "PROJECTOR ON"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(17, 93)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(128, 26)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "PROJECTOR OFF"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(17, 157)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(61, 26)
        Me.Button4.TabIndex = 7
        Me.Button4.Text = "UP"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(82, 157)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(63, 26)
        Me.Button5.TabIndex = 8
        Me.Button5.Text = "DOWN"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(82, 189)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(63, 26)
        Me.Button6.TabIndex = 10
        Me.Button6.Text = "RIGHT"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(17, 189)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(61, 26)
        Me.Button7.TabIndex = 9
        Me.Button7.Text = "LEFT"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(17, 221)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(128, 26)
        Me.Button8.TabIndex = 11
        Me.Button8.Text = "ENTER"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(17, 125)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(128, 26)
        Me.Button9.TabIndex = 12
        Me.Button9.Text = "MENU"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button11)
        Me.GroupBox1.Controls.Add(Me.Button10)
        Me.GroupBox1.Controls.Add(Me.txt4)
        Me.GroupBox1.Controls.Add(Me.txt3)
        Me.GroupBox1.Controls.Add(Me.txt2)
        Me.GroupBox1.Controls.Add(Me.txt1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(151, 67)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(134, 149)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Brute force sequence"
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(13, 111)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(101, 24)
        Me.Button11.TabIndex = 9
        Me.Button11.Text = "stop"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(12, 78)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(101, 24)
        Me.Button10.TabIndex = 8
        Me.Button10.Text = "start"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'txt4
        '
        Me.txt4.Location = New System.Drawing.Point(93, 46)
        Me.txt4.Name = "txt4"
        Me.txt4.Size = New System.Drawing.Size(21, 20)
        Me.txt4.TabIndex = 7
        Me.txt4.Text = "0"
        Me.txt4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt3
        '
        Me.txt3.Location = New System.Drawing.Point(66, 46)
        Me.txt3.Name = "txt3"
        Me.txt3.Size = New System.Drawing.Size(21, 20)
        Me.txt3.TabIndex = 6
        Me.txt3.Text = "0"
        Me.txt3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt2
        '
        Me.txt2.Location = New System.Drawing.Point(39, 46)
        Me.txt2.Name = "txt2"
        Me.txt2.Size = New System.Drawing.Size(21, 20)
        Me.txt2.TabIndex = 5
        Me.txt2.Text = "0"
        Me.txt2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt1
        '
        Me.txt1.Location = New System.Drawing.Point(12, 46)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(21, 20)
        Me.txt1.TabIndex = 4
        Me.txt1.Text = "0"
        Me.txt1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Current status:"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Enabled = False
        Me.Label4.Location = New System.Drawing.Point(187, 233)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "-kefcom- 2019"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(296, 255)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtbaud)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtcom)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "PROJECTOR BRUTE"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SP As IO.Ports.SerialPort
    Friend WithEvents Label1 As Label
    Friend WithEvents txtcom As TextBox
    Friend WithEvents txtbaud As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txt1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt4 As TextBox
    Friend WithEvents txt3 As TextBox
    Friend WithEvents txt2 As TextBox
    Friend WithEvents Button11 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label4 As Label
End Class
