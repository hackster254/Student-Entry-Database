
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Public Class Form1

    Dim sqlConn As New MySqlConnection
    ' Public conn As New MySqlConnection("host=localhost;user=root;password=;port=3306;")
    Dim sqlCmd As New MySqlCommand
    Dim sqlRd As MySqlDataReader
    Dim sqlQuery As String
    Dim sqlQuery1 As String

    Dim sqlDt As New DataTable
    Dim DtA As New MySqlDataAdapter

    Dim server As String = "127.0.0.1"
    'Dim server As String = "localhost"

    Dim username As String = "root"
    Dim password As String = ""
    Dim database As String = "mydb"

    Dim mark As Double

    Dim validatedInput As Boolean = False
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub populateCollege()
        sqlConn.ConnectionString = "server=" & server & ";user id=" & username & ";" &
    "password=" & password & ";database=" & database & ""


        Dim connStr As String = "Server=127.0.1;Database=mydb;Uid=root;Pwd=;SslMode=none"
        Dim conn As New MySqlConnection(connStr)
        Try
            Dim strSQL As String = "Select * from college"
            Dim da As New MySqlDataAdapter(strSQL, conn)
            Dim ds As New DataSet
            da.Fill(ds, "college")



            With cmbxCollege
                .DataSource = ds.Tables("college")
                .DisplayMember = "college_name"
                .ValueMember = "college_id"
                .SelectedIndex = 0
            End With

        Catch ex As Exception
            MsgBox("could not populate combobox College", ex.Message, MsgBoxStyle.Exclamation)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub populateCourse()
        sqlConn.ConnectionString = "server=" & server & ";user id=" & username & ";" &
"password=" & password & ";database=" & database & ""


        Dim connStr As String = "Server=127.0.0.1;Database=mydb;Uid=root;Pwd=;SslMode=none"
        Dim conn As New MySqlConnection(connStr)
        If cmbxCollege.SelectedIndex > 0 Then
            Try
                Dim sqlCmd1 As New MySqlCommand
                conn.Open()
                'Dim q As String = "select * from units where course_name ='" + cmbxCourses.SelectedValue + "'"
                'Dim q As String = "select * from units"
                ' Dim q As String = "select college_id from courses where college_id ='" + cmbxCollege.Text + "'"
                'Dim q As String = "select * from courses where college_id ='" + cmbxCollege.SelectedValue.ToString + "'"
                Dim q As String = "select course_name, course_id from courses"
                sqlCmd1 = New MySqlCommand(q, conn)

                'Dim dr1 As MySqlDataReader
                ' dr1 = sqlCmd1.ExecuteReader()



                'Dim q1 As String = "select * from courses where college_id ='" + cmbxCollege.SelectedValue.ToString + "'"
                Dim q1 As String = "select * from courses where college_id ='" + cmbxCollege.SelectedValue.ToString + "'"
                Dim sqlCmd2 As MySqlCommand = New MySqlCommand(q1, conn)
                Dim dr2 As MySqlDataReader
                dr2 = sqlCmd2.ExecuteReader




                While dr2.Read
                    cmbxCourses.Items.Clear()
                    cmbxUnits.DisplayMember = String.Empty

                    cmbxCourses.Items.Add(dr2("course_name").ToString)
                    cmbxCourses.ValueMember = (dr2("course_id").ToString)
                    cmbxCourses.DisplayMember = (dr2("course_name").ToString)


                    ' cmbxCourses.SelectedItem = dr2("course_id").ToString


                End While





            Catch ex As Exception
                MsgBox("could not populate combobox College", ex.Message, MsgBoxStyle.Exclamation)
            Finally
                conn.Close()
            End Try
        Else

            cmbxCourses.Items.Add("enter courses")
            'cmbxCourses.SelectedIndex = 1
            cmbxCourses.SelectedValue = "COANRI"
            'cmbxCourses.SelectedText = "COANRI"
            cmbxCourses.Items.Clear()

        End If



    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbxCollege.SelectedIndexChanged
        populateCourse()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populateCollege()
        'populateCourse()

        populateYear()


    End Sub


    Private Sub cmbxCourses_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbxCourses.SelectedIndexChanged
        sqlConn.ConnectionString = "server=" & server & ";user id=" & username & ";" &
 "password=" & password & ";database=" & database & ""


        Dim connStr As String = "Server=127.0.0.1;Database=mydb;Uid=root;Pwd=;SslMode=none"
        Dim conn As New MySqlConnection(connStr)


        Dim sqlCmd1 As New MySqlCommand
        conn.Open()
        'Dim q As String = "select * from units where course_name ='" + cmbxCourses.SelectedValue + "'"
        'Dim q As String = "select * from units"
        ' Dim q As String = "select college_id from courses where college_id ='" + cmbxCollege.Text + "'"

        Dim q As String = "select * from units where course_name ='" + cmbxCourses.SelectedItem.ToString + "'"

        sqlCmd1 = New MySqlCommand(q, conn)

        Dim dr1 As MySqlDataReader
        dr1 = sqlCmd1.ExecuteReader()

        While dr1.Read
            'txtCollege.Text = dr1(0).ToString
            'cmbxUnits.Items.Add(dr1("unit_name").ToString)

            'cmbxUnits.Items.Clear()
            cmbxUnits.DisplayMember = String.Empty
            cmbxUnits.Items.Add(dr1("unit_name").ToString)
            cmbxUnits.ValueMember = (dr1("unit_id").ToString)
            cmbxUnits.DisplayMember = (dr1("unit_name").ToString)
            'cmbxCollege.DisplayMember = (dr1("course_name").ToString)
            'cmbxCourses.ValueMember = (dr1("course_name").ToString)

        End While

        'cmbxUnits.Items.Clear()

        conn.Close()

    End Sub



    Private Sub cmbxYear_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbxYear.SelectedIndexChanged


    End Sub

    Private Sub populateYear()
        Dim years() As String = {"1", "2", "3", "4", "5"}
        cmbxYear.Items.Clear()
        cmbxYear.Items.AddRange(years)
    End Sub

    Private Sub cmbxUnits_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbxUnits.SelectedIndexChanged

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
    Private Sub validateInputs()
        'we need to validate all inputs
        If (cmbxYear.SelectedText = String.Empty) Or (txtRegno.Text = String.Empty) Then
            errProvider.SetError(cmbxYear, "Choose a year")

            validatedInput = False

        End If
        If (txtRegno.Text) = String.Empty Then
            errProvider.SetError(txtRegno, "Cannot be empty")

        ElseIf (txtCat1.Text) = String.Empty Then
            errProvider.SetError(txtCat1, "cannot be empty")
        ElseIf txtCat2.Text = String.Empty Then
            errProvider.SetError(txtCat2, "cannot be empty")

        End If



    End Sub

    Private Sub getStudentinput()
        sqlConn.ConnectionString = "server=" & server & ";user id=" & username & ";" &
    "password=" & password & ";database=" & database & ""


        Dim connStr As String = "Server=127.0.0.1;Database=mydb;Uid=root;Pwd=;SslMode=none"
        Dim conn As New MySqlConnection(connStr)
        Try
            conn.Open()

            Dim command As New MySqlCommand("INSERT INTO student (Regno,Cat1, Cat2, Cat3, college_name, course_name, semester, unit_name, Total, Grade) VALUES (@Regno, @Cat1, @Cat2, @Cat3, @College, @Course, @Semester, @Unit, @Mark, @Grade)", conn)
            Dim semester As Integer
            If rdbtnSem1.Checked Then
                semester = 1
            Else
                semester = 2
            End If

            If (txtRegno.Text IsNot String.Empty And txtCat1.Text IsNot String.Empty And txtCat2 IsNot String.Empty) Then
                command.Parameters.Add("@Regno", MySqlDbType.VarChar).Value = txtRegno.Text
                command.Parameters.Add("@Cat1", MySqlDbType.VarChar).Value = txtCat1.Text
                command.Parameters.Add("@Cat2", MySqlDbType.VarChar).Value = txtCat2.Text
                command.Parameters.Add("@Cat3", MySqlDbType.VarChar).Value = txtExam.Text
                command.Parameters.Add("@College", MySqlDbType.VarChar).Value = cmbxCollege.SelectedValue.ToString
                command.Parameters.Add("@Course", MySqlDbType.VarChar).Value = cmbxCourses.SelectedItem.ToString
                command.Parameters.Add("@Semester", MySqlDbType.VarChar).Value = semester
                command.Parameters.Add("@Unit", MySqlDbType.VarChar).Value = cmbxUnits.SelectedItem.ToString

                calculatemark()
                command.Parameters.Add("@Mark", MySqlDbType.VarChar).Value = mark
                If mark > 0 Then
                    command.Parameters.Add("@Grade", MySqlDbType.VarChar).Value = calculategrade(mark)

                    lstComments.TopIndex = lstComments.Items.Count - 1
                    lstComments.Items.Add(comment)
                End If


                'command.Parameters.Add("@unit_id", MySqlDbType.VarChar).Value = cmbxUnits.SelectedValue.ToString

                If command.ExecuteNonQuery() = 1 Then
                    MessageBox.Show("New Data Record Saved Successfully!!")
                End If
            End If
            conn.Close()
        Catch ex As Exception

            MsgBox("error could Not insert to database " + ex.Message, MsgBoxStyle.Exclamation)

        Finally
            conn.Close()
            'updateTable()
        End Try


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnDetermine.Click
        validateInputs()
        getStudentinput()
        calculatemark()
        calculategrade(mark)
    End Sub

    Private Sub calculatemark()
        Dim cat1 As Integer
        Dim cat2 As Integer
        Dim exam As Integer

        Try


            If (txtCat1.Text = String.Empty Or txtCat2.Text = String.Empty Or txtExam.Text = String.Empty) Then
                cat1 = CInt(0)
                cat2 = CInt(0)
                exam = CInt(0)
            Else
                cat1 = CInt(txtCat1.Text)
                cat2 = CInt(txtCat2.Text)
                exam = CInt(txtExam.Text)
            End If
            mark = CDbl((cat1 + cat2) / 30 + exam)

        Catch ex As Exception
            MsgBox("unable to calculate mark because of", ex.Message)
        End Try

    End Sub
    Dim comment As String
    Public Function calculategrade(ByVal m As Double) As Char
        Dim g As Char

        Select Case m
            Case < 40
                g = "E"
                comment = "Very poor performance in " + cmbxUnits.SelectedItem.ToString
            Case 40 To 50
                g = "D"
                comment = "Poor performance in " + cmbxUnits.SelectedItem.ToString
            Case 50 To 60
                g = "C"
                comment = "Average performance in " + cmbxUnits.SelectedItem.ToString
            Case 60 To 70
                g = "B"
                comment = "Good performance in " + cmbxUnits.SelectedItem.ToString
            Case 70 To 100
                g = "A"
                comment = "Very good performance performance in " + cmbxUnits.SelectedItem.ToString
        End Select
        Return g
    End Function
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        btnExit.ForeColor = Color.Maroon

        Dim iExit As DialogResult
        iExit = MsgBox("Confirm if you want to exit", MsgBoxStyle.YesNo)

        If iExit = vbYes Then
            Application.Exit()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstComments.SelectedIndexChanged

    End Sub

    ' e as event
    Private Sub txtCat1_TextChanged(sender As Object, e As EventArgs) Handles txtCat1.TextChanged

    End Sub

    Private Sub validnumbers(sender As Object, e As KeyPressEventArgs)
        If Not ((Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 46 Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 127) Then
            e.KeyChar = ""
            e.Handled = False
        End If
        'If e.KeyChar <> ControlChars.Back Then
        'e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".")
        'e.Handled = (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".") Then

        '  'Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
        'e.Handled = True
        'errorCat1.SetError(txtCat2, "you can only input a number")
        'errorCat2.SetError(txtCat1, "youc can only input a number")
        'errorExam.SetError(txtExam, "you can only input a number")
        '  End If
    End Sub

    Private Sub maxlengthInputs(sender As Object, e As EventArgs)
        txtCat1.MaxLength = 2
        txtCat2.MaxLength = 2

        txtExam.MaxLength = 2
    End Sub
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        AddHandler txtCat1.KeyPress, AddressOf validnumbers
        AddHandler txtCat2.KeyPress, AddressOf validnumbers
        AddHandler txtExam.KeyPress, AddressOf validnumbers

        AddHandler txtCat1.TextChanged, AddressOf maxlengthInputs
        AddHandler txtCat2.TextChanged, AddressOf maxlengthInputs
        AddHandler txtExam.TextChanged, AddressOf maxlengthInputs
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        frmReportStudent.Show()
    End Sub
End Class
