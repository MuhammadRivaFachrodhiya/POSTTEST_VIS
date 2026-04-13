Public Class landingPage
    Private Sub TP_Bigetron_Click(sender As Object, e As EventArgs) Handles TP_Tim.Click

    End Sub

    Private Sub btnLihatSelengkapnya_Click(sender As Object, e As EventArgs) Handles btnLihatSelengkapnya.Click
        Guest.Show()
        Me.Close()
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Login.Show()
        Me.Close()
    End Sub

    Private Sub btnKirim_Click(sender As Object, e As EventArgs) Handles btnKirim.Click
        Dim nama As String = Guna2TextBox1.Text.Trim()
        Dim email As String = Guna2TextBox2.Text.Trim()
        Dim alamat As String = Guna2TextBox3.Text.Trim()
        Dim nomorHP As String = Guna2TextBox4.Text.Trim()
        Dim divisi As String = Guna2ComboBox1.Text
        Dim alasanMelamar As String = Guna2TextBox5.Text.Trim()

        If nama = "" Or email = "" Or alamat = "" Or nomorHP = "" Or divisi = "" Or alasanMelamar = "" Then
            MessageBox.Show("Mohon lengkapi semua data pendaftaran termasuk alasan melamar!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If DataModule.SimpanLamaran(nama, email, alamat, nomorHP, divisi, alasanMelamar) Then
            MessageBox.Show("Lamaran berhasil dikirim! Silakan tunggu konfirmasi dari Admin.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Guna2TextBox1.Clear()
            Guna2TextBox2.Clear()
            Guna2TextBox3.Clear()
            Guna2TextBox4.Clear()
            Guna2ComboBox1.SelectedIndex = -1
            Guna2TextBox5.Clear()
        End If
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub landingPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Guna2TextBox2_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox2.TextChanged

    End Sub
End Class