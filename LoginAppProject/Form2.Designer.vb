<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Form2Label = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Form2Label
        '
        Me.Form2Label.AutoSize = True
        Me.Form2Label.Location = New System.Drawing.Point(423, 233)
        Me.Form2Label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Form2Label.Name = "Form2Label"
        Me.Form2Label.Size = New System.Drawing.Size(109, 16)
        Me.Form2Label.TabIndex = 0
        Me.Form2Label.Text = "HELLO WORLD!!"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1001, 523)
        Me.Controls.Add(Me.Form2Label)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Form2Label As Label
End Class
