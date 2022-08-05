'created by: Perez, John Patrick A.
'BSIT-2I

Public Class adminform

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
    End Sub

    Private Sub FormMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    'employee payroll
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        payroll.Show()
        Me.Hide()
    End Sub
End Class