'created by: Perez, John Patrick A.
'BSIT-2I
'FDBMS
Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    'show/hide passworf
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.CheckState = CheckState.Checked Then
            pass.UseSystemPasswordChar = False
        Else
            pass.UseSystemPasswordChar = True
        End If
    End Sub

    'username: admin
    'password: admin
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If user.Text = "admin" And pass.Text = "admin" Then
            adminform.Show()
            Me.Hide()
            user.Clear()
            pass.Clear()
            CheckBox1.CheckState = False
        Else
            MsgBox("Wrong username/password!", vbCritical, "Login failed")
        End If
    End Sub
End Class
