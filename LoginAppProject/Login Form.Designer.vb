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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.userName = New System.Windows.Forms.TextBox()
        Me.userPassword = New System.Windows.Forms.TextBox()
        Me.loginButton = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.registerButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(83, 80)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(83, 121)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password"
        '
        'userName
        '
        Me.userName.Location = New System.Drawing.Point(160, 76)
        Me.userName.Margin = New System.Windows.Forms.Padding(4)
        Me.userName.Name = "userName"
        Me.userName.Size = New System.Drawing.Size(245, 22)
        Me.userName.TabIndex = 2
        '
        'userPassword
        '
        Me.userPassword.Location = New System.Drawing.Point(160, 117)
        Me.userPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.userPassword.Name = "userPassword"
        Me.userPassword.Size = New System.Drawing.Size(245, 22)
        Me.userPassword.TabIndex = 3
        Me.userPassword.UseSystemPasswordChar = True
        '
        'loginButton
        '
        Me.loginButton.Location = New System.Drawing.Point(307, 162)
        Me.loginButton.Margin = New System.Windows.Forms.Padding(4)
        Me.loginButton.Name = "loginButton"
        Me.loginButton.Size = New System.Drawing.Size(100, 28)
        Me.loginButton.TabIndex = 4
        Me.loginButton.Text = "LOGIN"
        Me.loginButton.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(156, 27)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "LOGIN FORM"
        '
        'registerButton
        '
        Me.registerButton.Location = New System.Drawing.Point(160, 162)
        Me.registerButton.Margin = New System.Windows.Forms.Padding(4)
        Me.registerButton.Name = "registerButton"
        Me.registerButton.Size = New System.Drawing.Size(100, 28)
        Me.registerButton.TabIndex = 7
        Me.registerButton.Text = "Register"
        Me.registerButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(513, 282)
        Me.Controls.Add(Me.registerButton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.loginButton)
        Me.Controls.Add(Me.userPassword)
        Me.Controls.Add(Me.userName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents userName As TextBox
    Friend WithEvents userPassword As TextBox
    Friend WithEvents loginButton As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents registerButton As Button
End Class
