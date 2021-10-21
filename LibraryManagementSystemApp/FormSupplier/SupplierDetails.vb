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
        Guna2DataGridView1.Columns(0).Width = 80
        Guna2DataGridView1.Columns(1).Width = 100
        Guna2DataGridView1.Columns(2).Width = 180
        Guna2DataGridView1.Columns(3).Width = 110
        Guna2DataGridView1.Columns(4).Width = 100
        Guna2DataGridView1.Columns(5).Width = 200
        conn.Close()
    End Sub

    Private Sub SupplierDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        loadData()
    End Sub

    Private Sub Guna2ControlBox1_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If txtname.Text = "" Or txtbooks.Text = "" Or txtcontact.Text = "" Or txtstock.Text = "" Or txtaddress.Text = "" Then
            MessageBox.Show("Please Fill The Missing Information!!", "", MessageBoxButtons.OK)
        Else
            Try
                Dim query As String
                conn.Open()
                query = "INSERT INTO `librarydb`.`tblsupplier` (`Sname`, `Sbooks`,`Scontact`,`Sstock`,`Saddress`) VALUES ('" & txtname.Text & "', '" & txtbooks.Text & "', '" & txtcontact.Text & "','" & txtstock.Text & "','" & txtaddress.Text & "');"
                COMMAND = New MySqlCommand(query, conn)
                RENDER = COMMAND.ExecuteReader
                conn.Close()
                txtid.Clear()
                txtbooks.Clear()
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

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        If txtname.Text = "" Or txtbooks.Text = "" Or txtcontact.Text = "" Or txtstock.Text = "" Or txtaddress.Text = "" Then
            MessageBox.Show("Missing Information!!", "", MessageBoxButtons.OK)
        Else
            Try
                Dim query As String
                conn.Open()
                query = "UPDATE `librarydb`.`tblsupplier` SET `Sname` = '" & txtname.Text & "', `Sbooks` = '" & txtbooks.Text & "', `Scontact` = '" & txtcontact.Text & "', `Saddress` = '" & txtaddress.Text & "' WHERE (`Sid` = '" & txtid.Text & "');"
                COMMAND = New MySqlCommand(query, conn)
                RENDER = COMMAND.ExecuteReader
                conn.Close()
                txtid.Clear()
                txtbooks.Clear()
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

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        If txtid.Text <> "" Then
            MessageBox.Show("Are you want to delete this supplier detail?? ", "Delete confirmation", MessageBoxButtons.YesNo)
            If Windows.Forms.DialogResult.Yes Then
                Try
                    Dim query As String
                    conn.Open()
                    query = "DELETE FROM `librarydb`.`tblsupplier` WHERE (`Sid` = '" & txtid.Text & "');"
                    COMMAND = New MySqlCommand(query, conn)
                    RENDER = COMMAND.ExecuteReader
                    conn.Close()
                    txtid.Clear()
                    txtbooks.Clear()
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

    Private Sub btnreset_Click(sender As Object, e As EventArgs) Handles btnreset.Click
        If txtname.Text = "" Then
            MessageBox.Show("Missing Information!!", "", MessageBoxButtons.OK)
        Else
            txtid.Clear()
            txtbooks.Clear()
            txtstock.Clear()
            txtcontact.Clear()
            txtaddress.Clear()
            txtname.Select()
        End If
    End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
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
        txtid.Text = Guna2DataGridView1.Rows(a).Cells(0).Value.ToString
        txtname.Text = Guna2DataGridView1.Rows(a).Cells(1).Value.ToString
        txtbooks.Text = Guna2DataGridView1.Rows(a).Cells(2).Value.ToString
        txtcontact.Text = Guna2DataGridView1.Rows(a).Cells(3).Value.ToString
        txtstock.Text = Guna2DataGridView1.Rows(a).Cells(3).Value.ToString
        txtaddress.Text = Guna2DataGridView1.Rows(a).Cells(5).Value.ToString
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label10.Text = Date.Now.ToString("dd-MM-yyyy  hh:mm:ss")
    End Sub
End Class