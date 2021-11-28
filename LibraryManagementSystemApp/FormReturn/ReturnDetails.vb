Imports MySql.Data.MySqlClient
Public Class ReturnDetails
    Dim command As MySqlCommand
    Dim render As MySqlDataReader
    Private Sub LoadIssueData()
        conn.Open()
        Dim bsource As New BindingSource
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("SELECT * FROM librarydb.tblissue", conn)
        adapter.Fill(table)
        bsource.DataSource = table
        Guna2DataGridView1.DataSource = table
        conn.Close()
    End Sub

    Private Sub LoadReturnData()
        conn.Open()
        Dim bsource As New BindingSource
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("SELECT * FROM librarydb.tblreturn", conn)
        adapter.Fill(table)
        bsource.DataSource = table
        Guna2DataGridView2.DataSource = table
        conn.Close()
    End Sub

    Dim key = 0
    Private Sub removeFromIssue()
        Try
            Dim insertQuery As String
            conn.Open()
            insertQuery = "DELETE FROM `librarydb`.`tblissue` WHERE `IssueId` = " & key & ""
            command = New MySqlCommand(insertQuery, conn)
            render = command.ExecuteReader
            MsgBox("Issue Data removed!")
            conn.Close()
            'displayBook()
            'studentIdCb.Clear()
            'txtStudentName.Clear()
            'bookIdCb.Clear()
            'txtBookName.Clear()
            'issueDate.Clear()

        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

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

    Private Sub ReturnDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        LoadIssueData()
        LoadReturnData()
        FillStudent()
        FillBooks()
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

    Private Sub btnissue_Click(sender As Object, e As EventArgs) Handles btnissue.Click
        IssueDetails.Show()
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


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label10.Text = Date.Now.ToString("dd-MM-yyyy  hh:mm:ss")
    End Sub

    Private Sub txtbooks_TextChanged(sender As Object, e As EventArgs) Handles txtbooks.TextChanged

    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If studentIdCb.Text = "" Or bookIdCb.Text = "" Or txtname.Text = "" Or txtbooks.Text = "" Then
            MsgBox("Please fill all the text fields!!!")
        Else
            Try
                Dim insertQuery As String
                conn.Open()
                insertQuery = "INSERT INTO `librarydb`.`tblreturn`(`MemberId`, `MemberName`, `bookId`, `bookTitle`, `IssueDate`,`ReturnDate`,`Fine`)values(" & studentIdCb.Text & " , '" & txtname.Text & "'," & bookIdCb.Text & ", '" & txtbooks.Text & "' ,'" & issueDate.Text & "','" & returnDate.Text & "', '" & txtfine.Text & "')"
                command = New MySqlCommand(insertQuery, conn)
                render = command.ExecuteReader
                MsgBox("The book is returned.")
                conn.Close()
                removeFromIssue()
                LoadIssueData()
                LoadReturnData()
                Reset()

            Catch ex As Exception
                MsgBox(ex.Message)
                conn.Close()
            End Try
        End If
    End Sub

    Dim fine As Integer
    Private Sub btnCalculateFine_Click(sender As Object, e As EventArgs) Handles btnCalculateFine.Click
        Dim dateDifference As TimeSpan
        dateDifference = returnDate.Value.Date - issueDate.Value.Date
        Dim days = dateDifference.Days
        If days <= 5 Then
            fine = 0
            txtfine.Text = "0.00"
        Else
            fine = days - 5
            txtfine.Text = Convert.ToString(fine * 100)
        End If
    End Sub

    Private Sub reset()
        studentIdCb.SelectedIndex = -1
        bookIdCb.SelectedIndex = -1
        txtname.Text = ""
        txtbooks.Text = ""
        txtfine.Text = ""
    End Sub

    Private Sub btnreset_Click(sender As Object, e As EventArgs) Handles btnreset.Click
        reset()
    End Sub

    Private Sub Guna2DataGridView2_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles Guna2DataGridView2.CellMouseClick
        Dim row As DataGridViewRow = Guna2DataGridView2.Rows(e.RowIndex)
        studentIdCb.SelectedValue = row.Cells(1).Value.ToString
        txtname.Text = row.Cells(2).Value.ToString
        bookIdCb.SelectedValue = row.Cells(3).Value.ToString
        txtbooks.Text = row.Cells(4).Value.ToString
        issueDate.Text = row.Cells(5).Value.ToString
        returnDate.Text = row.Cells(6).Value.ToString
        txtfine.Text = row.Cells(7).Value.ToString
        If txtname.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        ReportReturn.Show()
    End Sub

    Private Sub studentIdCb_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles studentIdCb.SelectionChangeCommitted
        GetMemberName()
    End Sub

    Private Sub bookIdCb_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles bookIdCb.SelectionChangeCommitted
        GetBookName()
    End Sub

    Private Sub Guna2DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles Guna2DataGridView1.CellMouseClick
        Dim row As DataGridViewRow = Guna2DataGridView1.Rows(e.RowIndex)
        studentIdCb.SelectedValue = row.Cells(1).Value.ToString
        txtname.Text = row.Cells(2).Value.ToString
        bookIdCb.SelectedValue = row.Cells(3).Value.ToString
        txtbooks.Text = row.Cells(4).Value.ToString
        issueDate.Text = row.Cells(5).Value.ToString

        If txtname.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub

    Private Sub btnsettings_Click(sender As Object, e As EventArgs) Handles btnsettings.Click
        FormAbout.Show()
    End Sub

    Private Sub Guna2ControlBox1_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox1.Click
        Application.Exit()
    End Sub
End Class



