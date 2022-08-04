'created by: Perez, John Patrick A.
'BSIT-2I
'FDBMS
Public Class adminform
    'add vote
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        checkin.Show()
        Me.Hide()
    End Sub

    'update vote
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

    'view result
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

    End Sub

    Private Sub FormMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class