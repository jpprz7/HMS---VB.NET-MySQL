'created by: Perez, John Patrick A.
'BSIT-2I

Public Class staff

    'checkin/out
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        checkin.Show()
        Me.Hide()
    End Sub

    'transaction history
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        history.Show()
        Me.Hide()
    End Sub

    'about
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        About.Show()
    End Sub

    'logout
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub staff_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class