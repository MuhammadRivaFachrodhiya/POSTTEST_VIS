Public Class Form1
    Private Sub TampilkanDataKeGrid()
        DataGridView1.Rows.Clear()

        For i As Integer = 0 To jumlahBuku - 1
            Dim teksTampilan As String = DaftarBuku(i, 0) & " (" & DaftarBuku(i, 1) & ")"
            DataGridView1.Rows.Add(teksTampilan)
        Next
    End Sub
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If txtJdltambah.Text = "" Or txtGtambah.Text = "" Then
            MessageBox.Show("Judul dan Genre tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        TambahDataBuku(txtJdltambah.Text, txtGtambah.Text)
        TampilkanDataKeGrid()
        txtJdltambah.Clear()
        txtGtambah.Clear()
        txtJdltambah.Focus()
    End Sub
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If txtJdlhapus.Text = "" Then
            MessageBox.Show("Masukkan judul buku yang ingin dihapus!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Dim berhasilHapus As Boolean = HapusDataBuku(txtJdlhapus.Text)
        If berhasilHapus Then
            TampilkanDataKeGrid()
            txtJdlhapus.Clear()
            MessageBox.Show("Buku berhasil dihapus.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Buku dengan judul itu ngga ada wok", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub lblJdltambah_Click(sender As Object, e As EventArgs) Handles lblJdltambah.Click

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub lblGtambah_Click(sender As Object, e As EventArgs) Handles lblGtambah.Click

    End Sub

    Private Sub txtGtambah_TextChanged(sender As Object, e As EventArgs) Handles txtGtambah.TextChanged

    End Sub
End Class