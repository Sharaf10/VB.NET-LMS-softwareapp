Imports MySql.Data.MySqlClient
Public Class MemberDetails
    Dim COMMAND As MySqlCommand
    Dim RENDER As MySqlDataReader
    Private Sub loadData()
        conn.Open()
        Dim bsource As New BindingSource
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("SELECT * FROM librarydb.tblmember", conn)
        adapter.Fill(table)
        bsource.DataSource = table
        Guna2DataGridView1.DataSource = table
        conn.Close()
    End Sub
    Private Sub MemberDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        loadData()
    End Sub

    Private Sub btnhome_Click_1(sender As Object, e As EventArgs) Handles btnhome.Click
        FormMain.Show()
        Me.Hide()
    End Sub

    Private Sub btnbooks_Click_1(sender As Object, e As EventArgs) Handles btnbooks.Click
        BookDetails.Show()
        Me.Hide()
    End Sub

    Private Sub btnstaff_Click_1(sender As Object, e As EventArgs) Handles btnstaff.Click
        StaffDetails.Show()
        Me.Hide()
    End Sub

    Private Sub btnissue_Click_1(sender As Object, e As EventArgs) Handles btnissue.Click
        IssueDetails.Show()
        Me.Hide()
    End Sub

    Private Sub btnreturn_Click_1(sender As Object, e As EventArgs) Handles btnreturn.Click
        ReturnDetails.Show()
        Me.Hide()
    End Sub

    Private Sub btnsuppliers_Click_1(sender As Object, e As EventArgs) Handles btnsuppliers.Click
        SupplierDetails.Show()
        Me.Hide()
    End Sub

    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        Me.Close()
        FormLogin.Show()
        FormLogin.txtusername.Clear()
        FormLogin.txtpassword.Clear()
    End Sub

    Private Sub Guna2ControlBox1_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox1.Click
        Application.Exit()
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Try
            Dim query As String
            conn.Open()
            query = "INSERT INTO `librarydb`.`tblmember` (`Name`, `NIC`, `Gender`,`Contact`,`Email`,`Date_Joined`) VALUES ('" & txtname.Text & "', '" & txtNIC.Text & "', '" & txtgender.Text & "','" & txtcontact.Text & "','" & txtemail.Text & "','" & DateTimePicker1.Text & "');"
            COMMAND = New MySqlCommand(query, conn)
            RENDER = Command.ExecuteReader
            conn.Close()
            txtid1.Clear()
            txtname.Clear()
            txtNIC.Clear()
            txtemail.Clear()
            txtcontact.Clear()
            loadData()
            MessageBox.Show("Saved member details succesfully")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label10.Text = Date.Now.ToString("dd-MM-yyyy  hh:mm:ss")
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        Try
            Dim query As String
            conn.Open()
            query = "UPDATE `librarydb`.`tblmember` SET `Name` = '" & txtname.Text & "', `NIC` = '" & txtNIC.Text & "', `Gender` = '" & txtgender.Text & "',`Contact` = '" & txtcontact.Text & "',`Email` = '" & txtemail.Text & "',`Date_Joined` = '" & DateTimePicker1.Text & "' WHERE (`MemberId` = '" & txtid1.Text & "');"
            COMMAND = New MySqlCommand(query, conn)
            RENDER = COMMAND.ExecuteReader
            conn.Close()
            txtid1.Clear()
            txtname.Clear()
            txtNIC.Clear()
            txtemail.Clear()
            txtcontact.Clear()
            loadData() 'this function for the refresh the data base'
            MessageBox.Show("Edit Sucess")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        If txtid1.Text <> "" Then
            If MsgBox("Do you want to delete this record?", MsgBoxStyle.YesNo, "Delete record") = MsgBoxResult.Yes Then
                Try
                    Dim query As String
                    conn.Open()
                    query = "DELETE FROM `librarydb`.`tblmember` WHERE (`MemberId` = '" & txtid1.Text & "');"
                    COMMAND = New MySqlCommand(query, conn)
                    RENDER = COMMAND.ExecuteReader
                    conn.Close()
                    txtid1.Clear()
                    txtname.Clear()
                    txtNIC.Clear()
                    txtemail.Clear()
                    txtcontact.Clear()
                    loadData() 'this function for the refresh the data base'
                    MessageBox.Show("Delete Sucess")
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                    conn.Close()
                End Try
            End If
        Else
                MessageBox.Show("Plese Select The item")
        End If
    End Sub

    Private Sub btnreset_Click(sender As Object, e As EventArgs) Handles btnreset.Click
        txtid1.Clear()
        txtname.Clear()
        txtNIC.Clear()
        txtemail.Clear()
        txtcontact.Clear()
    End Sub

    Private Sub Guna2DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DataGridView1.CellClick
        Dim a As Integer = Guna2DataGridView1.CurrentRow.Index
        txtid1.Text = Guna2DataGridView1.Rows(a).Cells(0).Value.ToString
        txtname.Text = Guna2DataGridView1.Rows(a).Cells(1).Value.ToString
        txtNIC.Text = Guna2DataGridView1.Rows(a).Cells(2).Value.ToString
        txtgender.Text = Guna2DataGridView1.Rows(a).Cells(3).Value.ToString
        txtcontact.Text = Guna2DataGridView1.Rows(a).Cells(4).Value.ToString
        txtemail.Text = Guna2DataGridView1.Rows(a).Cells(5).Value.ToString
    End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        conn.Open()
        Dim bsource As New BindingSource
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("SELECT * FROM librarydb.tblmember", conn)
        adapter.Fill(table)
        bsource.DataSource = table
        Guna2DataGridView1.DataSource = table
        Dim dv As New DataView(table)
        dv.RowFilter = String.Format("Name Like '%{0}%'", txtsearch.Text)
        Guna2DataGridView1.DataSource = dv
        conn.Close()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        ReportMember.Show()
    End Sub

    Private Sub txtid1_KeyDown(sender As Object, e As KeyEventArgs) Handles txtid1.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtname.Select()
        End If
    End Sub

    Private Sub txtname_KeyDown(sender As Object, e As KeyEventArgs) Handles txtname.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtNIC.Select()
        End If
    End Sub

    Private Sub txtNIC_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNIC.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtgender.Select()
        End If
    End Sub

    Private Sub txtgender_KeyDown(sender As Object, e As KeyEventArgs) Handles txtgender.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtcontact.Select()
        End If
    End Sub

    Private Sub txtcontact_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcontact.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtemail.Select()
        End If
    End Sub

    Private Sub txtid1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtid1.KeyPress
        'accept only numbers
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MsgBox("Please insert numbers only")
        End If
        If txtid.Text.Length > 4 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
                MsgBox("The allowed maximum number of members are 99999...")
            End If
        End If
    End Sub

    Private Sub txtname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtname.KeyPress
        'accept only letters
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Enter) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MsgBox("You can't insert numbers in this field")
        End If
    End Sub

    Private Sub txtNIC_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNIC.KeyPress
        'max price limit
        If txtNIC.Text.Length > 10 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
                MsgBox("Maximum number of characters reached!!!")
            End If
        End If
    End Sub

    Private Sub txtgender_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtgender.KeyPress
        If txtgender.Text = "" Then
            MsgBox("Please select the gender..")
            txtgender.Select()
        Else
            If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Enter) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
                e.Handled = True
                MsgBox("You can't insert numbers in this field")
            End If
        End If
    End Sub

    Private Sub txtcontact_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcontact.KeyPress
        If txtcontact.Text.Length >= 10 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
            End If
            MsgBox("Exceeded!!!")
        Else
            If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
                e.Handled = True
                MsgBox("Please insert numbers only")
            End If
        End If
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub btnsettings_Click(sender As Object, e As EventArgs) Handles btnsettings.Click
        FormAbout.Show()
    End Sub
End Class