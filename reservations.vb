Imports MySql.Data.MySqlClient

Public Class reservations
    Dim connect As MySqlConnection
    Dim constring As String = "DATA SOURCE = localhost; USER id = root; DATABASE = hms"
    Dim cmd As MySqlCommand
    Dim itemcol(999) As String
    Dim da As MySqlDataAdapter
    Dim ds As DataSet
    Private Sub reservations_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ListView1.Items.Clear()
            connect = New MySqlConnection(constring)
            connect.Open()
            Dim sql As String = "SELECT CONCAT(customers.firstname, ' ', customers.lastname) AS 'customer',
                                room_type.room_type_name,
                                bill.room_price,
                                booking.checkin_date,
                                booking.checkout_date
                                FROM customers
                                JOIN booking ON booking.customer_id = customers.customer_id
                                JOIN bill ON bill.booking_id = booking.booking_id
                                JOIN room ON room.room_id = booking.room_id
                                JOIN room_type ON room_type.room_type_id = room.room_type_id;"
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        staff.Show()
        Me.Hide()
    End Sub
End Class