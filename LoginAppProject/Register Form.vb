Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub ReturnToLoginButton_Click(sender As Object, e As EventArgs) Handles ReturnToLoginButton.Click
        Form1.Show()
        Me.Close()
    End Sub
    Private Sub RegisterButton_Click(sender As Object, e As EventArgs) Handles RegisterButton.Click
        Call Connect_to_DB()
        Try
            If String.IsNullOrEmpty(userName.Text) OrElse String.IsNullOrEmpty(firstName.Text) OrElse
               String.IsNullOrEmpty(lastName.Text) OrElse String.IsNullOrEmpty(userEmail.Text) OrElse
               String.IsNullOrEmpty(userPasswordRegister1.Text) OrElse String.IsNullOrEmpty(userPasswordRegister2.Text) Then
                MsgBox("please fill up the form!")
                Exit Sub
                ' Check if the passwords match
            ElseIf userPasswordRegister1.Text = userPasswordRegister2.Text Then

                ' Check if the username already exists in the database
                Using cmd As New MySqlCommand("SELECT COUNT(*) FROM users WHERE userName = ?", myconn)
                    cmd.Parameters.AddWithValue("@userName", userName.Text)
                    Dim count As Integer = CInt(cmd.ExecuteScalar())
                    If count > 0 Then
                        MsgBox("Username already exists!")
                        Exit Sub
                    End If
                End Using
                ' Insert the user information into the database using parameterized queries
                Using cmd As New MySqlCommand("INSERT INTO users (userName, firstName, lastName, userEmail, userPassword) VALUES (?,?,?,?,MD5(?))", myconn)
                    cmd.Parameters.AddWithValue("@userName", userName.Text)
                    cmd.Parameters.AddWithValue("@firstName", firstName.Text)
                    cmd.Parameters.AddWithValue("@lastName", lastName.Text)
                    cmd.Parameters.AddWithValue("@userEmail", userEmail.Text)
                    cmd.Parameters.AddWithValue("@userPassword", userPasswordRegister1.Text)
                    cmd.ExecuteNonQuery()
                End Using
                MsgBox("User registered successfully!")
                Call Disconnect_to_DB()
                Form1.Show()
                Me.Close()
            Else
                MsgBox("Passwords do not match!")
            End If
        Catch ex As Exception
            MsgBox("An error occurred: " & ex.Message)
        End Try
    End Sub
    'INSERT INTO `store`.`users` (`userName`, `userPassword`) VALUES ('username', 'password');
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub
End Class