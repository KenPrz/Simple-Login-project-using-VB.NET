Imports MySql.Data.MySqlClient

Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles loginButton.Click
        With Me
            Call Connect_to_DB()
            Dim mycmd As New MySqlCommand


            strSQL = "SELECT COUNT(*) FROM users WHERE userName = '" & .userName.Text & "' AND userPassword = MD5('" & .userPassword.Text & "')"
            mycmd.CommandText = strSQL
            mycmd.Connection = myconn

            Dim count As Integer = CInt(mycmd.ExecuteScalar())

            If count > 0 Then
                MsgBox("Login successful!")
                Form6.Show()
                Me.Hide()
            Else
                MsgBox("Invalid username or password")
            End If

            Call Disconnect_to_DB()
        End With
    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles registerButton.Click
        Form3.Show()
        Me.Hide()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class
