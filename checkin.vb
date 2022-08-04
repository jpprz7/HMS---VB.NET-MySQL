'created by: Perez, John Patrick A.
'BSIT-2I
'FDBMS

Imports MySql.Data.MySqlClient
Public Class checkin
    Dim connect As MySqlConnection
    Dim constring As String = "DATA SOURCE = localhost; USER id = root; DATABASE = votingsystem_perez"
    Dim cmd As MySqlCommand

    Dim roomtype, price As String


    'pang clear sa form
    Public Sub Clearform()
        customerid.Clear()
        firstname.Clear()
        lastname.Clear()
        connumber.Clear()
        nights.Clear()
        Pricebox.Clear()
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        RadioButton4.Checked = False
        RadioButton5.Checked = False
        RadioButton6.Checked = False
    End Sub

    'submit vote
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            connect = New MySqlConnection(constring)
            connect.Open()
            Dim SQL As String = "INSERT INTO voters (Student_number, First_name, Last_name, Course, Year, Email) 
                values('" & customerid.Text & "','" & firstname.Text & "','" & lastname.Text & "','" & connumber.Text & "','" & nights.Text & "');
                INSERT INTO candidates (full_name, Position) 
                values('" & roomtype & "','" & price & "');
                "
            cmd = New MySqlCommand(SQL, connect)
            Dim i As Integer = cmd.ExecuteNonQuery

            If i <> 0 Then
                MsgBox("Vote successful!", vbInformation, "Admin")
            Else
                MsgBox("Vote failed!", vbCritical, "Admin")
            End If
            Call Clearform()
            connect.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Call Clearform()
    End Sub

    Private Sub connumber_TextChanged(sender As Object, e As EventArgs) Handles connumber.TextChanged

    End Sub

    'return button
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        adminform.Show()
        Me.Hide()
        Call Clearform()
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            roomtype = "Single" 'roomtype
            price = nights.Text * 75 'price
            Pricebox.Text = "$" + price 'display the price
        Else
            Pricebox.Clear()
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            roomtype = "Twin" 'roomtype
            price = nights.Text * 95 'price
            Pricebox.Text = "$ " + price 'display the price
        Else
            Pricebox.Clear()
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked = True Then
            roomtype = "Studio" 'roomtype
            price = nights.Text * 125 'price
            Pricebox.Text = "$ " + price 'display the price
        Else
            Pricebox.Clear()
        End If
    End Sub

    Private Sub RadioButton6_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        If RadioButton6.Checked = True Then
            roomtype = "Presidential" 'roomtype
            price = nights.Text * 520 'price
            Pricebox.Text = "$ " + price 'display the price
        Else
            Pricebox.Clear()
        End If
    End Sub

    Private Sub Price_TextChanged(sender As Object, e As EventArgs) Handles Pricebox.TextChanged

    End Sub

    Private Sub checkin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub RadioButton5_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        If RadioButton5.Checked = True Then
            roomtype = "Penthouse" 'roomtype
            price = nights.Text * 345 'price
            Pricebox.Text = "$ " + price 'display the price
        Else
            Pricebox.Clear()
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked = True Then
            roomtype = "Deluxe" 'roomtype
            price = nights.Text * 237 'price
            Pricebox.Text = "$ " + price 'display the price
        Else
            Pricebox.Clear()
        End If
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

End Class