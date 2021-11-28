Imports MySql.Data.MySqlClient
Public Class StaffDetails
    Dim COMMAND As MySqlCommand
    Dim RENDER As MySqlDataReader
    Private Sub loadData()
        conn.Open()
        Dim bsource As New BindingSource
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("SELECT * FROM librarydb.tblstaff", conn)
        adapter.Fill(table)
        bsource.DataSource = table
        Guna2DataGridView1.DataSource = table
        conn.Close()
    End Sub
    Private Sub StaffDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        loadData()
    End Sub

    Private Sub btnhome_Click(sender As Object, e As EventArgs) Handles btnhome.Click
        FormMain.Show()
        Me.Hide()
    End Sub

    Private Sub btnmembers_Click(sender As Object, e As EventArgs) Handles btnmembers.Click
        MemberDetails.Show()
        Me.Hide()
    End Sub

    Private Sub btnbooks_Click(sender As Object, e As EventArgs) Handles btnbooks.Click
        BookDetails.Show()
        Me.Hide()
    End Sub

    Private Sub btnissue_Click(sender As Object, e As EventArgs) Handles btnissue.Click
        IssueDetails.Show()
        Me.Hide()
    End Sub

    Private Sub btnreturn_Click(sender As Object, e As EventArgs) Handles btnreturn.Click
        ReturnDetails.Show()
        Me.Hide()
    End Sub

    Private Sub btnsuppliers_Click(sender As Object, e As EventArgs) Handles btnsuppliers.Click
        SupplierDetails.Show()
        Me.Hide()
    End Sub

    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        Me.Close()
        FormLogin.Show()
        FormLogin.txtusername.Clear()
        FormLogin.txtpassword.Clear()
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Try
            Dim query As String
            conn.Open()
            query = "INSERT INTO `librarydb`.`tblstaff` (`Staffname`, `NIC`, `Designation`,`Contact`,`Email`,`Joined_Date`) VALUES ('" & txtname.Text & "', '" & txtNIC.Text & "', '" & txtdesignation.Text & "','" & txtcontact.Text & "','" & txtemail.Text & "','" & DateTimePicker1.Text & "');"
            COMMAND = New MySqlCommand(query, conn)
            RENDER = Command.ExecuteReader
            conn.Close()
            textid.Clear()
            txtname.Clear()
            txtNIC.Clear()
            txtdesignation.Clear()
            txtemail.Clear()
            txtcontact.Clear()
            loadData()
            MessageBox.Show("Saved staff details succesfully")
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
            query = "UPDATE `librarydb`.`tblstaff` SET `Staffname` = '" & txtname.Text & "', `NIC` = '" & txtNIC.Text & "', `Designation` = '" & txtdesignation.Text & "',`Contact` = '" & txtcontact.Text & "',`Email` = '" & txtemail.Text & "',`Date_Joined` = '" & DateTimePicker1.Text & "' WHERE (`Staffid` = '" & txtid.Text & "');"
            COMMAND = New MySqlCommand(query, conn)
            RENDER = COMMAND.ExecuteReader
            conn.Close()
            textid.Clear()
            txtname.Clear()
            txtNIC.Clear()
            txtdesignation.Clear()
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
        If txtid.Text <> "" Then
            If MsgBox("Do you want to delete this record?", MsgBoxStyle.YesNo, "Delete record") = MsgBoxResult.Yes Then
                Try
                    Dim query As String
                    conn.Open()
                    query = "DELETE FROM `librarydb`.`tblstaff` WHERE (`Staffid` = '" & txtid.Text & "');"
                    COMMAND = New MySqlCommand(query, conn)
                    RENDER = COMMAND.ExecuteReader
                    conn.Close()
                    textid.Clear()
                    txtname.Clear()
                    txtNIC.Clear()
                    txtdesignation.Clear()
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
        textid.Clear()
        txtname.Clear()
        txtNIC.Clear()
        txtdesignation.Clear()
        txtemail.Clear()
        txtcontact.Clear()
    End Sub

    Private Sub Guna2DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DataGridView1.CellClick
        Dim a As Integer = Guna2DataGridView1.CurrentRow.Index
        txtid.Text = Guna2DataGridView1.Rows(a).Cells(0).Value.ToString
        txtname.Text = Guna2DataGridView1.Rows(a).Cells(1).Value.ToString
        txtNIC.Text = Guna2DataGridView1.Rows(a).Cells(2).Value.ToString
        txtdesignation.Text = Guna2DataGridView1.Rows(a).Cells(3).Value.ToString
        txtcontact.Text = Guna2DataGridView1.Rows(a).Cells(4).Value.ToString
        txtemail.Text = Guna2DataGridView1.Rows(a).Cells(5).Value.ToString
    End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        conn.Open()
        Dim bsource As New BindingSource
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("SELECT * FROM librarydb.tblstaff", conn)
        adapter.Fill(table)
        bsource.DataSource = table
        Guna2DataGridView1.DataSource = table
        Dim dv As New DataView(table)
        dv.RowFilter = String.Format("Staffname Like '%{0}%'", txtsearch.Text)
        Guna2DataGridView1.DataSource = dv
        conn.Close()
    End Sub

    Private Sub textid_KeyDown(sender As Object, e As KeyEventArgs) Handles textid.KeyDown
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
            txtdesignation.Select()
        End If
    End Sub

    Private Sub txtdesignation_KeyDown(sender As Object, e As KeyEventArgs) Handles txtdesignation.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtcontact.Select()
        End If
    End Sub

    Private Sub txtcontact_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcontact.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtemail.Select()
        End If
    End Sub

    Private Sub textid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textid.KeyPress
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

    Private Sub txtdesignation_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdesignation.KeyPress
        'accept only letters
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Enter) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MsgBox("You can't insert numbers in this field")
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

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        ReportStaff.Show()
    End Sub

    Private Sub btnsettings_Click(sender As Object, e As EventArgs) Handles btnsettings.Click
        FormAbout.Show()
    End Sub
End Class
