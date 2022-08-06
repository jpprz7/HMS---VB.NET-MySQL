'created by: Perez, John Patrick A.
'BSIT-2I

Imports MySql.Data.MySqlClient

Public Class UpdateEmp
    Dim connect As MySqlConnection
    Dim constring As String = "DATA SOURCE = localhost; USER id = root; DATABASE = hms"
    Dim cmd As MySqlCommand
    Dim itemcol(999) As String
    Dim da As MySqlDataAdapter
    Dim ds As DataSet
    Public Sub EmpInfo()
        Try
            ListView1.Items.Clear()
            connect = New MySqlConnection(constring)
            connect.Open()
            Dim sql As String = "SELECT * from emp_record"
            cmd = New MySqlCommand(sql, connect)
            da = New MySqlDataAdapter(cmd)
            ds = New DataSet
            da.Fill(ds, "Tables")
            For r = 0 To ds.Tables(0).Rows.Count - 1
                For c = 0 To ds.Tables(0).Columns.Count - 1
                    itemcol(c) = ds.Tables(0).Rows(r)(c).ToString
                Next
                Dim lvitm As New ListViewItem(itemcol)
                ListView1.Items.Add(lvitm)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        connect.Close()
    End Sub

    'clear form
    Public Sub Clearinfo()
        empID.Clear()
        firstname.Clear()
        lastname.Clear()
        gender.Clear()
        contactNum.Clear()
        email.Clear()
    End Sub

    'call db
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call EmpInfo()
    End Sub

    'return button
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        adminform.Show()
        Me.Hide()
        Call EmpInfo()
        Call Clearinfo()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count > 0 Then
            empID.Text = ListView1.SelectedItems(0).SubItems(0).Text
            firstname.Text = ListView1.SelectedItems(0).SubItems(1).Text
            lastname.Text = ListView1.SelectedItems(0).SubItems(2).Text
            gender.Text = ListView1.SelectedItems(0).SubItems(3).Text
            contactNum.Text = ListView1.SelectedItems(0).SubItems(4).Text
            email.Text = ListView1.SelectedItems(0).SubItems(5).Text
        End If
    End Sub

    'add button
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            connect = New MySqlConnection(constring)
            connect.Open()
            Dim SQL As String =
                "INSERT INTO emp_record (efirstname, elastname, gender, contact_num, email, salary) 
                values('" & firstname.Text & "',
                '" & lastname.Text & "',
                '" & gender.Text & "',
                '" & contactNum.Text & "',
                '" & email.Text & "',
                '0');
                "
            cmd = New MySqlCommand(SQL, connect)
            Dim i As Integer = cmd.ExecuteNonQuery

            If i <> 0 Then
                MsgBox("Employee info updated!", vbInformation, "Admin")
            Else
                MsgBox("Employee info update failed!", vbCritical, "Admin")
            End If
            Call EmpInfo()
            Call Clearinfo()
            connect.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'update button
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            connect = New MySqlConnection(constring)
            connect.Open()
            Dim SQL As String =
                "UPDATE emp_record SET efirstname = '" & firstname.Text & "',
                elastname = '" & lastname.Text & "',
                gender = '" & gender.Text & "',
                contact_num= '" & contactNum.Text & "',
                email ='" & email.Text & "'
               WHERE emp_id = '" & empID.Text & "'"
            cmd = New MySqlCommand(SQL, connect)
            Dim i As Integer = cmd.ExecuteNonQuery

            If i <> 0 Then
                MsgBox("Employee info updated!", vbInformation, "Admin")
            Else
                MsgBox("Employee info update failed!", vbCritical, "Admin")
            End If
            Call EmpInfo()
            Call Clearinfo()
            connect.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'delete button
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            connect = New MySqlConnection(constring)
            connect.Open()
            Dim SQL As String = "DELETE FROM emp_record WHERE emp_id = '" & empID.Text & "' "
            cmd = New MySqlCommand(SQL, connect)
            Dim i As Integer = cmd.ExecuteNonQuery

            If i <> 0 Then
                MsgBox("Employee info deleted!", vbInformation, "Admin")
            Else
                MsgBox("Employee info deletion failed!", vbCritical, "Admin")
            End If
            Call EmpInfo()
            Call Clearinfo()
            connect.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class