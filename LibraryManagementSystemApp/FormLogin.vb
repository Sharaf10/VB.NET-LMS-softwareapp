Imports MySql.Data.MySqlClient
Public Class FormLogin

    Dim COMMAND As MySqlCommand
    Public Sub Login_data()

        Dim READER As MySqlDataReader
        Try
            conn.Open()
            Dim Query As String
            Query = "select * from tbllogin where username='" & txtusername.Text & "' and password='" & txtpassword.Text & "' "
            COMMAND = New MySqlCommand(Query, conn)
            READER = COMMAND.ExecuteReader
            Dim count As Integer
            count = 0
            While READER.Read
                count = count + 1
            End While
            If count = 1 Then
                conn.Close()
                FormMain.Show()
                Me.Hide()
            Else
                MessageBox.Show("Username or password is not correct!!")
            End If
            conn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub
    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Login_data()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Application.Exit()
    End Sub

    Private Sub txtusername_KeyDown(sender As Object, e As KeyEventArgs) Handles txtusername.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtpassword.Select()
            e.SuppressKeyPress = True
        End If
    End Sub
    Private Sub txtpassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtpassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnlogin.PerformClick()
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub Guna2ControlBox1_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox1.Click
        Application.Exit()
    End Sub
    Private Sub Guna2CustomCheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2CustomCheckBox1.CheckedChanged
        If Guna2CustomCheckBox1.Checked = True Then
            txtpassword.UseSystemPasswordChar = False
        Else
            txtpassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub txtpassword_TextChanged(sender As Object, e As EventArgs) Handles txtpassword.TextChanged
        If Guna2CustomCheckBox1.Checked = True Then
            txtpassword.UseSystemPasswordChar = False
        Else
            txtpassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub txtusername_TextChanged(sender As Object, e As EventArgs) Handles txtusername.TextChanged

    End Sub
End Class