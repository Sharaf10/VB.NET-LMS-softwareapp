Imports MySql.Data.MySqlClient
Public Class SupplierDetails

    Dim COMMAND As MySqlCommand
    Dim RENDER As MySqlDataReader
    Private Sub loadData()
        conn.Open()
        Dim bsource As New BindingSource
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("SELECT * FROM librarydb.tblsupplier", conn)
        adapter.Fill(table)
        bsource.DataSource = table
        Guna2DataGridView1.DataSource = table
        Guna2DataGridView1.Columns(0).Width = 40
        Guna2DataGridView1.Columns(1).Width = 50
        Guna2DataGridView1.Columns(2).Width = 80
        Guna2DataGridView1.Columns(3).Width = 50
        Guna2DataGridView1.Columns(4).Width = 80
        Guna2DataGridView1.Columns(5).Width = 80
        Guna2DataGridView1.Columns(6).Width = 90
        Guna2DataGridView1.Columns(7).Width = 130
        conn.Close()
    End Sub

    Private Sub SupplierDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        loadData()
    End Sub

    Private Sub Guna2ControlBox1_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)
        Label10.Text = Date.Now.ToString("dd-MM-yyyy  hh:mm:ss")
    End Sub
    Private Sub btnmembers_Click_1(sender As Object, e As EventArgs) Handles btnmembers.Click
        MemberDetails.Show()
        Me.Hide()
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

    Private Sub btnlogout_Click_1(sender As Object, e As EventArgs) Handles btnlogout.Click
        Me.Close()
        FormLogin.Show()
        FormLogin.txtusername.Clear()
        FormLogin.txtpassword.Clear()
    End Sub

    Private Sub Guna2ControlBox1_Click_1(sender As Object, e As EventArgs) Handles Guna2ControlBox1.Click
        Application.Exit()
    End Sub

    Private Sub btnsave_Click_1(sender As Object, e As EventArgs) Handles btnsave.Click
        If txtname.Text = "" Or txtNIC.Text = "" Or txtcontact.Text = "" Or txtstock.Text = "" Or txtaddress.Text = "" Then
            MessageBox.Show("Please Fill The Missing Information!!", "", MessageBoxButtons.OK)
        Else
            Try
                Dim query As String
                conn.Open()
                query = "INSERT INTO `librarydb`.`tblsupplier` (`Sname`, `Sbooks`,`Scontact`,`Sstock`,`Saddress`) VALUES ('" & txtname.Text & "', '" & txtNIC.Text & "', '" & txtcontact.Text & "','" & txtstock.Text & "','" & txtaddress.Text & "');"
                COMMAND = New MySqlCommand(query, conn)
                RENDER = COMMAND.ExecuteReader
                conn.Close()
                txtid1.Clear()
                txtNIC.Clear()
                txtstock.Clear()
                txtcontact.Clear()
                txtaddress.Clear()
                txtname.Select()
                loadData() 'this function for the refresh the data base'
                MessageBox.Show("Supplier details saved successfully!")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                conn.Close()
            End Try
        End If
    End Sub

    Private Sub btnedit_Click_1(sender As Object, e As EventArgs) Handles btnedit.Click
        If txtname.Text = "" Or txtNIC.Text = "" Or txtcontact.Text = "" Or txtstock.Text = "" Or txtaddress.Text = "" Then
            MessageBox.Show("Missing Information!!", "", MessageBoxButtons.OK)
        Else
            Try
                Dim query As String
                conn.Open()
                query = "UPDATE `librarydb`.`tblsupplier` SET `Sname` = '" & txtname.Text & "', `Sbooks` = '" & txtNIC.Text & "', `Scontact` = '" & txtcontact.Text & "', `Saddress` = '" & txtaddress.Text & "' WHERE (`Sid` = '" & txtid1.Text & "');"
                COMMAND = New MySqlCommand(query, conn)
                RENDER = COMMAND.ExecuteReader
                conn.Close()
                txtid1.Clear()
                txtNIC.Clear()
                txtstock.Clear()
                txtcontact.Clear()
                txtaddress.Clear()
                txtname.Select()
                loadData() 'this function for the refresh the data base'
                MessageBox.Show("Supplier details edited successfully!")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                conn.Close()
            End Try
        End If
    End Sub

    Private Sub btndelete_Click_1(sender As Object, e As EventArgs) Handles btndelete.Click
        If txtid1.Text <> "" Then
            If MsgBox("Do you want to delete this record?", MsgBoxStyle.YesNo, "Delete record") = MsgBoxResult.Yes Then
                Try
                    Dim query As String
                    conn.Open()
                    query = "DELETE FROM `librarydb`.`tblsupplier` WHERE (`Sid` = '" & txtid1.Text & "');"
                    COMMAND = New MySqlCommand(query, conn)
                    RENDER = COMMAND.ExecuteReader
                    conn.Close()
                    txtid1.Clear()
                    txtNIC.Clear()
                    txtcontact.Clear()
                    txtstock.Clear()
                    txtaddress.Clear()
                    txtname.Select()
                    loadData() 'this function for the refresh the data base'
                    MessageBox.Show("Supplier details have been deleted successfully!")
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                    conn.Close()
                End Try


            End If
        Else
            MessageBox.Show("Plese Select Or Add The Item And Try Again!!")
        End If
    End Sub

    Private Sub btnreset_Click_1(sender As Object, e As EventArgs) Handles btnreset.Click
        If txtname.Text = "" Then
            MessageBox.Show("Missing Information!!", "", MessageBoxButtons.OK)
        Else
            txtid1.Clear()
            txtNIC.Clear()
            txtstock.Clear()
            txtcontact.Clear()
            txtaddress.Clear()
            txtname.Select()
        End If
    End Sub

    Private Sub txtsearch_TextChanged_1(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        conn.Open()
        Dim bsource As New BindingSource
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("SELECT * FROM librarydb.tblsupplier", conn)
        adapter.Fill(table)
        bsource.DataSource = table
        Guna2DataGridView1.DataSource = table
        Dim dv As New DataView(table)
        dv.RowFilter = String.Format("Sname Like '%{0}%'", txtsearch.Text)
        Guna2DataGridView1.DataSource = dv
        conn.Close()
    End Sub
    Private Sub Guna2DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DataGridView1.CellClick
        Dim a As Integer = Guna2DataGridView1.CurrentRow.Index
        txtid1.Text = Guna2DataGridView1.Rows(a).Cells(0).Value.ToString
        txtname.Text = Guna2DataGridView1.Rows(a).Cells(1).Value.ToString
        txtNIC.Text = Guna2DataGridView1.Rows(a).Cells(2).Value.ToString
        txtcontact.Text = Guna2DataGridView1.Rows(a).Cells(3).Value.ToString
        txtstock.Text = Guna2DataGridView1.Rows(a).Cells(3).Value.ToString
        txtaddress.Text = Guna2DataGridView1.Rows(a).Cells(5).Value.ToString
    End Sub

    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label10.Text = Date.Now.ToString("dd-MM-yyyy  hh:mm:ss")
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
    Private Sub txtbook_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbook.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtbookid.Select()
        End If
    End Sub

    Private Sub txtbookid_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbookid.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtcontact.Select()
        End If
    End Sub

    Private Sub txtcontact_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcontact.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtstock.Select()
        End If
    End Sub

    Private Sub txtstock_KeyDown(sender As Object, e As KeyEventArgs) Handles txtstock.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtaddress.Select()
        End If
    End Sub

    Private Sub txtaddress_KeyDown(sender As Object, e As KeyEventArgs) Handles txtaddress.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtemail.Select()
        End If
    End Sub

    Private Sub txtemail_KeyDown(sender As Object, e As KeyEventArgs) Handles txtemail.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnsave.PerformClick()
        End If
    End Sub

    Private Sub txtid1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtid1.KeyPress
        'accept only numbers
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MsgBox("Please insert numbers only")
        End If
        If txtid1.Text.Length > 4 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
                MsgBox("the allowed maximum quantity of books are 99999 - data base is full")
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

    Private Sub txtNIC_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNIC.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtbook.Select()
        End If
    End Sub

    Private Sub txtbook_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbook.KeyPress
        'accept only letters
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Enter) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MsgBox("You can't insert numbers in this field")
        End If
    End Sub

    Private Sub txtbookid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbookid.KeyPress
        'accept only numbers
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MsgBox("Please insert numbers only")
        End If
        If txtid1.Text.Length > 4 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
                MsgBox("the allowed maximum quantity of books are 99999 - data base is full")
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

    Private Sub txtstock_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtstock.KeyPress
        'limit the books count
        If txtstock.Text.Length > 2 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
                MsgBox("You can insert 999 books at a time")
            End If
        End If
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Enter) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MsgBox("Please insert numbers only")
        End If
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        ReportSupplier.Show()
    End Sub

    Private Sub btnsettings_Click(sender As Object, e As EventArgs) Handles btnsettings.Click
        FormAbout.Show()
    End Sub
End Class