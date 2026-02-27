Public Class Form1
    Dim totalIP As Double = 0
    Dim jumlahSemester As Integer = 0
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim ipInput As Double
        If Double.TryParse(txtIPS.Text, ipInput) Then
            If ipInput > 4 Or ipInput < 0 Then
                MessageBox.Show("Nilai IP Semester tidak valid! Silahkan isi dari rentang 0-4")
                txtIPS.Text = ""
                Return
            End If
            totalIP = totalIP + ipInput
            jumlahSemester = jumlahSemester + 1
            Dim ipk As Double = totalIP / jumlahSemester
            txtIPK.Text = ipk.ToString("F2")
            txtIPS.Text = ""
            If ipk >= 3.01 Then
                lblKet.Text = "Sangat Memuaskan"
            ElseIf ipk >= 2.76 And ipk <= 3.0 Then
                lblKet.Text = "Memuaskan"
            ElseIf ipk >= 2.0 And ipk <= 2.75 Then
                lblKet.Text = "Cukup"
            Else
                lblKet.Text = "Kurang"
            End If
        Else
            MessageBox.Show("Input harus angka!")
            txtIPS.Text = ""
        End If
    End Sub
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        totalIP = 0
        jumlahSemester = 0
        txtIPS.Text = ""
        txtIPK.Text = ""
        lblKet.Text = ""
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub txtIPS_TextChanged(sender As Object, e As EventArgs) Handles txtIPS.TextChanged

    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub
End Class