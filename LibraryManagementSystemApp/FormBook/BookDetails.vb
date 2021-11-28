Imports MySql.Data.MySqlClient
Public Class BookDetails

    Dim command As MySqlCommand
    Dim render As MySqlDataReader
    Private Sub LoadData()

        conn.Open()
        Dim bindSource As New BindingSource
        'this class shows the specific table in the database
        Dim table As New DataTable()
        'Dim adapter As New MySqlDataAdapter("SELECT * FROM library_ms.books_table", conn)
        'this adapter code works as a bridge between the dataset and database for saving and output the data from the table.
        Dim adapter As New MySqlDataAdapter("SELECT * FROM librarydb.tblbooks", conn)
        adapter.Fill(table)
        bindSource.DataSource = table
        Guna2DataGridView1.DataSource = table
        conn.Close()

    End Sub
    Private Sub BookDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        LoadData()
    End Sub
    Private Sub btnhome_Click(sender As Object, e As EventArgs) Handles btnhome.Click
        FormMain.Show()
        Me.Hide()
    End Sub

    Private Sub btnmembers_Click(sender As Object, e As EventArgs) Handles btnmembers.Click
        MemberDetails.Show()
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
        If (txtname.Text <> "" And txtauthor.Text <> "" And txtcategory.Text <> "" And txtedition.Text <> "" And txtprice.Text <> "" And txtpublisher.Text <> "" And txtqty.Text <> "") Then
            Try
                Dim insertQuery As String
                conn.Open()
                'insertQuery = "INSERT INTO `library_ms`.`books_table` (`bookID`, `bookName`, `bookAuthor`, `bookCategory`, `bookEdition`, `bookPrice`, `bookPublisher`, `bookQuantity`) VALUES ('" & txtBookID.Text & "', '" & txtBookName.Text & "', '" & txtAuthor.Text & "', '" & txtCategory.Text & "', '" & txtBookEdition.Text & "', '" & txtPrice.Text & "', '" & txtPublisher.Text & "', '" & txtQuantity.Text & "');"
                insertQuery = "INSERT INTO `librarydb`.`tblbooks` ( `bookTitle`, `bookAuthor`, `bookCategory`, `bookEdition`, `bookPublisher`, `bookPrice`, `bookQuantity`) VALUES ('" & txtname.Text & "', '" & txtauthor.Text & "', '" & txtcategory.Text & "', '" & txtedition.Text & "', '" & txtpublisher.Text & "', '" & txtprice.Text & "', '" & txtqty.Text & "');"
                command = New MySqlCommand(insertQuery, conn)
                render = command.ExecuteReader
                conn.Close()
                txtbookid.Clear()
                txtname.Clear()
                txtauthor.Clear()
                txtcategory.Clear()
                txtedition.Clear()
                txtprice.Clear()
                txtpublisher.Clear()
                txtqty.Clear()
                LoadData()
                MsgBox("A new book is added.!")
                txtname.Select()
            Catch ex As Exception
                MsgBox(ex.Message)
                conn.Close()
            End Try
        Else
            MsgBox("Please fill all the text fields!!!")
            txtbookid.Select()
        End If
    End Sub

    Private Sub Guna2Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel4.Paint

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label10.Text = Date.Now.ToString("dd-MM-yyyy  hh:mm:ss")
    End Sub

    Private Sub btnreset_Click(sender As Object, e As EventArgs) Handles btnreset.Click
        txtbookid.Clear()
        txtname.Clear()
        txtauthor.Clear()
        txtcategory.Clear()
        txtedition.Clear()
        txtprice.Clear()
        txtpublisher.Clear()
        txtqty.Clear()
        txtname.Select()
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        Try
            Dim updateQuery As String
            conn.Open()
            'updateQuery = "UPDATE `library_ms`.`books_table` SET `bookName` = '" & txtBookName.Text & "', `bookAuthor` = '" & txtAuthor.Text & "', `bookCategory` = '" & txtCategory.Text & "', `bookEdition` = '" & txtBookEdition.Text & "', `bookPrice` = '" & txtPrice.Text & "', `bookPublisher` = '" & txtPublisher.Text & "', `bookQuantity` = '" & txtQuantity.Text & "' WHERE (`bookID` = '" & txtBookID.Text & "');"
            updateQuery = "UPDATE `librarydb`.`tblbooks` SET `bookTitle` = '" & txtname.Text & "', `bookAuthor` = '" & txtauthor.Text & "', `bookCategory` = '" & txtcategory.Text & "', `bookEdition` = '" & txtedition.Text & "', `bookPublisher` = '" & txtpublisher.Text & "', `bookPrice` = '" & txtprice.Text & "', `bookQuantity` = '" & txtqty.Text & "' WHERE (`bookid` = '" & txtbookid.Text & "');"
            command = New MySqlCommand(updateQuery, conn)
            render = command.ExecuteReader
            conn.Close()
            txtbookid.Clear()
            txtname.Clear()
            txtauthor.Clear()
            txtcategory.Clear()
            txtedition.Clear()
            txtprice.Clear()
            txtpublisher.Clear()
            txtqty.Clear()
            LoadData()
            MsgBox("The book record is updated.!")
            txtbookid.Select()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        If txtbookid.Text <> "" Then

            If MsgBox("Do you want to delete this record?", MsgBoxStyle.YesNo, "Delete record") = MsgBoxResult.Yes Then
                Try
                    Dim deleteQuery As String
                    conn.Open()
                    'deleteQuery = "DELETE FROM `library_ms`.`books_table` WHERE (`bookID` = '" & txtBookID.Text & "');"
                    deleteQuery = "DELETE FROM `librarydb`.`tblbooks` WHERE (`bookid` = '" & txtbookid.Text & "');"
                    command = New MySqlCommand(deleteQuery, conn)
                    render = command.ExecuteReader
                    conn.Close()
                    txtbookid.Clear()
                    txtauthor.Clear()
                    txtname.Clear()
                    txtcategory.Clear()
                    txtedition.Clear()
                    txtprice.Clear()
                    txtpublisher.Clear()
                    txtqty.Clear()
                    txtbookid.Select()
                    LoadData()
                    MsgBox("This record is deleted...!")

                Catch ex As Exception
                    MsgBox(ex.Message)
                    conn.Close()
                End Try
            Else

            End If
        Else
            MsgBox("Please select an item to delete!")
        End If
    End Sub

    Private Sub Guna2DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DataGridView1.CellClick
        Dim a As Integer = Guna2DataGridView1.CurrentRow.Index
        txtbookid.Text = Guna2DataGridView1.Rows(a).Cells(0).Value.ToString
        txtname.Text = Guna2DataGridView1.Rows(a).Cells(1).Value.ToString
        txtauthor.Text = Guna2DataGridView1.Rows(a).Cells(2).Value.ToString
        txtcategory.Text = Guna2DataGridView1.Rows(a).Cells(3).Value.ToString
        txtedition.Text = Guna2DataGridView1.Rows(a).Cells(4).Value.ToString
        txtpublisher.Text = Guna2DataGridView1.Rows(a).Cells(5).Value.ToString
    End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        'data loading part- from database
        conn.Open()
        Dim bindSource As New BindingSource
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("SELECT * FROM librarydb.tblbooks", conn)
        adapter.Fill(table)
        bindSource.DataSource = table
        Guna2DataGridView1.DataSource = table
        ' search part - with sql command
        Dim srch As New DataView(table)
        srch.RowFilter = String.Format("bookTitle Like '%{0}%'", txtsearch.Text)
        Guna2DataGridView1.DataSource = srch
        'close database connection
        conn.Close()
    End Sub

    Private Sub Guna2DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DataGridView1.CellContentClick

    End Sub

    Private Sub txtbookid_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbookid.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtname.Select()
        End If
    End Sub

    Private Sub txtname_KeyDown(sender As Object, e As KeyEventArgs) Handles txtname.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtauthor.Select()
        End If
    End Sub

    Private Sub txtauthor_KeyDown(sender As Object, e As KeyEventArgs) Handles txtauthor.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtcategory.Select()
        End If
    End Sub

    Private Sub txtcategory_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcategory.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtedition.Select()
        End If
    End Sub

    Private Sub txtedition_KeyDown(sender As Object, e As KeyEventArgs) Handles txtedition.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtpublisher.Select()
        End If
    End Sub

    Private Sub txtpublisher_KeyDown(sender As Object, e As KeyEventArgs) Handles txtpublisher.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtprice.Select()
        End If
    End Sub

    Private Sub txtprice_KeyDown(sender As Object, e As KeyEventArgs) Handles txtprice.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtqty.Select()
        End If
    End Sub

    Private Sub txtqty_KeyDown(sender As Object, e As KeyEventArgs) Handles txtqty.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnsave.PerformClick()
        End If
    End Sub

    Private Sub txtbookid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbookid.KeyPress
        'accept only numbers
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MsgBox("Please insert numbers only")
        End If
        'book count limit
        'check this piece of code
        'some thing extra
        If txtbookid.Text.Length > 4 Then
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

    Private Sub txtauthor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtauthor.KeyPress
        'accept only letters
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Enter) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MsgBox("You can't insert numbers in this field")
        End If
    End Sub

    Private Sub txtcategory_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcategory.KeyPress
        'accept only letters
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Enter) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MsgBox("You can't insert numbers in this field")
        End If
    End Sub

    Private Sub txtedition_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtedition.KeyPress
        'accept only letters
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Enter) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MsgBox("You can't insert numbers in this field")
        End If
    End Sub

    Private Sub txtpublisher_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpublisher.KeyPress
        'accept only letters
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Enter) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MsgBox("You can't insert numbers in this field")
        End If
    End Sub

    Private Sub txtprice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtprice.KeyPress
        'accept only numbers
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Enter) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MsgBox("Please insert numbers only")
        End If
        'max price limit
        If txtprice.Text.Length > 3 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
                MsgBox("Maximum value of a book is 9999.00")
            End If
        End If
    End Sub

    Private Sub txtqty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtqty.KeyPress
        'limit the books count
        If txtqty.Text.Length > 2 Then
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
        ReportBook.Show()
    End Sub

    Private Sub btnsettings_Click(sender As Object, e As EventArgs) Handles btnsettings.Click
        FormAbout.Show()
    End Sub

    Private Sub Guna2ControlBox1_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox1.Click
        Application.Exit()
    End Sub
End Class


