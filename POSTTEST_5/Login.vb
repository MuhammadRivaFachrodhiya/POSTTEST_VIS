Public Class Login

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = GTBusn.Text
        Dim password As String = GTBpw.Text
        If username = "MPLID" And password = "Season17" Then
            MessageBox.Show("Login Berhasil! Selamat datang.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Admin.Show()
            Me.Hide()
        Else
            ' Jika salah, tampilkan pesan error
            MessageBox.Show("Username atau Password salah!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            GTBpw.Clear()
            GTBusn.Focus()
        End If
    End Sub

    Private Sub btnGuest_Click(sender As Object, e As EventArgs) Handles btnGuest.Click
        landingPage.Show()
        Me.Hide()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

End Class