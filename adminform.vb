'created by: Perez, John Patrick A.
'BSIT-2I
Public Class adminform

    'checkin
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        checkin.Show()
        Me.Hide()
    End Sub

    'employee record
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        UpdateEmp.Show()
        Me.Hide()
    End Sub

    'logout button
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Login.Show()
        Me.Hide()
    End Sub

    'about button
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        About.Show()
        Me.Hide()
    End Sub

    'cashier posting
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

    End Sub

    Private Sub FormMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    'transaction history
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

    End Sub

    'payroll
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

    End Sub
End Class