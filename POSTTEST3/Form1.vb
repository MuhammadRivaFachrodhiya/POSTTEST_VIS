Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
        openFileDialog.Title = "Pilih Gambar"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(openFileDialog.FileName)
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Char.IsLetter(e.KeyChar) OrElse Char.IsWhiteSpace(e.KeyChar) OrElse Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim isHobbyChecked = False
        Dim daftarHobi = ""
        For Each ctrl As Control In GroupBox2.Controls
            If TypeOf ctrl Is CheckBox Then
                Dim chk = DirectCast(ctrl, CheckBox)
                If chk.Checked Then
                    isHobbyChecked = True
                    daftarHobi &= chk.Text & ", "
                End If
            End If
        Next
        If TextBox1.Text.Trim = "" OrElse TextBox2.Text.Trim = "" OrElse TextBox3.Text.Trim = "" OrElse TextBox4.Text.Trim = "" OrElse PictureBox1.Image Is Nothing OrElse Not RadioButton1.Checked AndAlso Not RadioButton2.Checked OrElse Not isHobbyChecked Then
            MessageBox.Show("Inputan tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Dim frm2 As New Form2
        frm2.PictureBox1.Image = PictureBox1.Image
        frm2.PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        frm2.Label1.Text = TextBox1.Text
        frm2.Label2.Text = TextBox2.Text
        frm2.Label3.Text = TextBox3.Text
        frm2.Label4.Text = TextBox4.Text
        frm2.Label5.Text = DateTimePicker1.Value.ToString("dd MMMM yyyy")
        Dim jenisKelamin = ""
        If RadioButton1.Checked Then jenisKelamin = RadioButton1.Text
        If RadioButton2.Checked Then jenisKelamin = RadioButton2.Text
        frm2.Label6.Text = jenisKelamin
        If daftarHobi.EndsWith(", ") Then
            daftarHobi = daftarHobi.Substring(0, daftarHobi.Length - 2)
        End If
        frm2.Label7.Text = daftarHobi
        frm2.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class