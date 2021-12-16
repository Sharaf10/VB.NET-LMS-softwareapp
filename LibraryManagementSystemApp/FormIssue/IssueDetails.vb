Imports MySql.Data.MySqlClient
Public Class IssueDetails
    Dim command As MySqlCommand
    Dim render As MySqlDataReader
    Private Sub loadData()
        conn.Open()
        Dim bsource As New BindingSource
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("SELECT * FROM librarydb.tblissue", conn)
        adapter.Fill(table)
        bsource.DataSource = table
        Guna2DataGridView1.DataSource = table
        conn.Close()
    End Sub

    'this is for select the student ID
    Private Sub FillStudent()
        conn.Open()
        Dim bindSource As New BindingSource
        Dim adapter As New MySqlDataAdapter("SELECT * FROM tblmember", conn)
        Dim table As New DataTable()
        adapter.Fill(table)
        bindSource.DataSource = table
        'DataGridView1.DataSource = table
        studentIdCb.DataSource = table
        studentIdCb.DisplayMember = "MemberId"
        studentIdCb.ValueMember = "MemberId"
        conn.Close()
    End Sub

    'this is for select the book ID
    Private Sub FillBooks()
        conn.Open()
        Dim bindSource As New BindingSource
        Dim adapter As New MySqlDataAdapter("SELECT * FROM tblbooks", conn)
        Dim table As New DataTable()
        adapter.Fill(table)
        bindSource.DataSource = table
        ' DataGridView1.DataSource = table
        bookIdCb.DataSource = table
        bookIdCb.DisplayMember = "bookId"
        bookIdCb.ValueMember = "bookId"
        conn.Close()
    End Sub

    'this is to display the student name
    Private Sub GetMemberName()
        conn.Open()
        Dim Query = "SELECT * from tblmember WHERE MemberId = " & studentIdCb.SelectedValue.ToString() & ""
        Dim cmd = New MySqlCommand(Query, conn)
        Dim dt As MySqlDataAdapter
        render = cmd.ExecuteReader()
        While render.Read
            txtname.Text = "" + render(1).ToString()
        End While
        conn.Close()
    End Sub

    'this is to display the book name
    Private Sub GetBookName()
        conn.Open()
        Dim Query = "SELECT * from tblbooks WHERE bookId = " & bookIdCb.SelectedValue.ToString() & ""
        Dim cmd = New MySqlCommand(Query, conn)
        Dim dt As MySqlDataAdapter
        render = cmd.ExecuteReader()
        While render.Read
            txtbooks.Text = "" + render(1).ToString()
        End While
        conn.Close()
    End Sub
    Private Sub IssueDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        loadData()
        FillStudent()
        FillBooks()
        studentIdCb.SelectedIndex = -1
        txtname.Clear()
        bookIdCb.SelectedIndex = -1
        txtbooks.Clear()
        IssueDate.ResetText()
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

    Private Sub btnstaff_Click(sender As Object, e As EventArgs) Handles btnstaff.Click
        StaffDetails.Show()
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

    'this function is for counting the total amount of book a student can borrow (and the max limit is 5 )
    Dim number = 0
    Private Sub countBook()
        conn.Open()
        Dim Query = "SELECT count(*) FROM tblissue WHERE MemberId = " & studentIdCb.SelectedValue.ToString() & ""
        command = New MySqlCommand(Query, conn)
        number = command.ExecuteScalar
        'render = command.ExecuteReader
        conn.Close()
    End Sub
    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsubmit.Click
        countBook()
        If number = 5 Then
            MsgBox("Student cant borrow more than 5 books!")

        ElseIf (txtname.Text <> "" Or txtbooks.Text <> "") Then
            Try
                Dim insertQuery As String
                conn.Open()
                insertQuery = "INSERT INTO `librarydb`.`tblissue`(`MemberId`, `MemberName`, `bookId`, `bookTitle`, `IssueDate`)values(" & studentIdCb.SelectedValue.ToString() & " , '" & txtname.Text & "'," & bookIdCb.SelectedValue.ToString() & ", '" & txtbooks.Text & "' ,'" & IssueDate.Text & "')"
                command = New MySqlCommand(insertQuery, conn)
                render = command.ExecuteReader()
                conn.Close()
                studentIdCb.ResetText()
                txtname.Clear()
                bookIdCb.ResetText()
                txtbooks.Clear()
                IssueDate.ResetText()
                loadData()
                MsgBox("A book is issued.!")
                txtbooks.Select()

            Catch ex As Exception
                MsgBox(ex.Message)
                conn.Close()
            End Try
        Else
            MsgBox("Please fill all the text fields!!!")
            studentIdCb.Select()
        End If
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label10.Text = Date.Now.ToString("dd-MM-yyyy  hh:mm:ss")
    End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        'conn.Open()
        'Dim bsource As New BindingSource
        'Dim table As New DataTable()
        'Dim adapter As New MySqlDataAdapter("SELECT * FROM librarydb.tblmember", conn)
        'adapter.Fill(table)
        'bsource.DataSource = table
        'Guna2DataGridView1.DataSource = table
        'Dim dv As New DataView(table)
        'dv.RowFilter = String.Format("Name Like '%{0}%'", txtsearch.Text)
        'Guna2DataGridView1.DataSource = dv
        'conn.Close()
        'ctrl + c to comment whole
    End Sub



    Private Sub btnreset_Click(sender As Object, e As EventArgs) Handles btnreset.Click
        studentIdCb.SelectedIndex = -1
        txtname.Clear()
        bookIdCb.SelectedIndex = -1
        txtbooks.Clear()
        IssueDate.ResetText()
    End Sub

    Private Sub Guna2DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DataGridView1.CellClick
        'Dim x As Integer = Guna2DataGridView1.CurrentRow.Index
        'studentIdCb.Text = Guna2DataGridView1.Rows(x).Cells(0).Value.ToString
        'txtname.Text = Guna2DataGridView1.Rows(x).Cells(1).Value.ToString
        'bookIdCb.Text = Guna2DataGridView1.Rows(x).Cells(2).Value.ToString
        'txtbooks.Text = Guna2DataGridView1.Rows(x).Cells(3).Value.ToString

    End Sub

    Dim key = 0
    Private Sub Guna2DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles Guna2DataGridView1.CellMouseClick
        Dim row As DataGridViewRow = Guna2DataGridView1.Rows(e.RowIndex)
        studentIdCb.SelectedValue = row.Cells(1).Value.ToString
        txtname.Text = row.Cells(2).Value.ToString
        bookIdCb.SelectedValue = row.Cells(3).Value.ToString
        txtbooks.Text = row.Cells(4).Value.ToString
        IssueDate.Text = row.Cells(5).Value.ToString

        If txtname.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        Try
            Dim updateQuery As String
            conn.Open()
            updateQuery = "UPDATE `librarydb`.`tblissue` SET `MemberId` = " & studentIdCb.SelectedValue.ToString() & ", `MemberName` = '" & txtname.Text & "', `bookId` = " & bookIdCb.SelectedValue.ToString() & ", `bookTitle` = '" & txtbooks.Text & "', `IssueDate` = '" & IssueDate.Text & "' WHERE  (`IssueId` = '" & key & "');"
            command = New MySqlCommand(updateQuery, conn)
            render = command.ExecuteReader()
            conn.Close()
            studentIdCb.ResetText()
            txtname.Clear()
            bookIdCb.ResetText()
            txtbooks.Clear()
            IssueDate.ResetText()
            loadData()
            MsgBox("The issue record is updated.!")
            loadData()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        ReportIssue.Show()
    End Sub

    Private Sub studentIdCb_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles studentIdCb.SelectionChangeCommitted
        GetMemberName()
    End Sub

    Private Sub bookIdCb_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles bookIdCb.SelectionChangeCommitted
        GetBookName()
    End Sub

    Private Sub btnsettings_Click(sender As Object, e As EventArgs) Handles btnsettings.Click
        FormAbout.Show()
    End Sub

    Private Sub Guna2ControlBox1_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox1.Click
        Application.Exit()
    End Sub

    Private Sub IssueDate_ValueChanged(sender As Object, e As EventArgs) Handles IssueDate.ValueChanged

    End Sub
End Class


