'created by: Perez, John Patrick A.
'BSIT-2I

Imports MySql.Data.MySqlClient

Public Class payroll
    Dim connect As MySqlConnection
    Dim constring As String = "DATA SOURCE = localhost; USER id = root; DATABASE = hms"
    Dim cmd As MySqlCommand
    Dim itemcol(999) As String
    Dim da As MySqlDataAdapter
    Dim ds As DataSet
    Dim oras, hrate, sahod As Double

    Public Sub EmpSalary()
        Try
            ListView1.Items.Clear()
            connect = New MySqlConnection(constring)
            connect.Open()
            Dim sql As String = "SELECT emp_id, efirstname, elastname, salary from emp_record"
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
        salary.Clear()
        rate.Clear()
        hrs.Clear()
    End Sub

    Private Sub payroll_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call EmpSalary()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count > 0 Then
            empID.Text = ListView1.SelectedItems(0).SubItems(0).Text
            firstname.Text = ListView1.SelectedItems(0).SubItems(1).Text
            lastname.Text = ListView1.SelectedItems(0).SubItems(2).Text
            salary.Text = ListView1.SelectedItems(0).SubItems(3).Text
        End If
    End Sub

    Private Sub hrs_TextChanged(sender As Object, e As EventArgs) Handles hrs.TextChanged
        oras = Val(hrs.Text)
        hrate = Val(rate.Text)
        sahod = oras * hrate
        salary.Text = sahod
    End Sub

    'update
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            connect = New MySqlConnection(constring)
            connect.Open()
            Dim SQL As String =
                "UPDATE emp_record SET salary = '" & salary.Text & "'
                WHERE emp_id = '" & empID.Text & "'
                "
            cmd = New MySqlCommand(SQL, connect)
            Dim i As Integer = cmd.ExecuteNonQuery

            If i <> 0 Then
                MsgBox("Employee salary updated!", vbInformation, "Admin")
            Else
                MsgBox("Employee salary update failed!", vbCritical, "Admin")
            End If
            Call EmpSalary()
            Call Clearinfo()
            connect.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'return
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        adminform.Show()
        Me.Hide()
    End Sub
End Class