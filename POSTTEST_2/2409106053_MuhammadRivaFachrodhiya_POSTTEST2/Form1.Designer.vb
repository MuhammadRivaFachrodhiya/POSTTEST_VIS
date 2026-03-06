<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        lblGtambah = New Label()
        lblJdltambah = New Label()
        txtGtambah = New TextBox()
        txtJdltambah = New TextBox()
        btnTambah = New Button()
        Label1 = New Label()
        Panel2 = New Panel()
        lblJdlhapus = New Label()
        txtJdlhapus = New TextBox()
        btnHapus = New Button()
        Label4 = New Label()
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Panel3 = New Panel()
        Panel4 = New Panel()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Silver
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(lblGtambah)
        Panel1.Controls.Add(lblJdltambah)
        Panel1.Controls.Add(txtGtambah)
        Panel1.Controls.Add(txtJdltambah)
        Panel1.Controls.Add(btnTambah)
        Panel1.Location = New Point(12, 22)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(570, 247)
        Panel1.TabIndex = 0
        ' 
        ' lblGtambah
        ' 
        lblGtambah.AutoSize = True
        lblGtambah.BackColor = Color.Transparent
        lblGtambah.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        lblGtambah.Location = New Point(265, 131)
        lblGtambah.Name = "lblGtambah"
        lblGtambah.Size = New Size(51, 20)
        lblGtambah.TabIndex = 4
        lblGtambah.Text = "Genre"
        ' 
        ' lblJdltambah
        ' 
        lblJdltambah.AutoSize = True
        lblJdltambah.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        lblJdltambah.Location = New Point(253, 82)
        lblJdltambah.Name = "lblJdltambah"
        lblJdltambah.Size = New Size(87, 20)
        lblJdltambah.TabIndex = 3
        lblJdltambah.Text = "Judul Buku"
        ' 
        ' txtGtambah
        ' 
        txtGtambah.Location = New Point(3, 158)
        txtGtambah.Name = "txtGtambah"
        txtGtambah.Size = New Size(562, 23)
        txtGtambah.TabIndex = 2
        txtGtambah.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtJdltambah
        ' 
        txtJdltambah.Location = New Point(3, 105)
        txtJdltambah.Name = "txtJdltambah"
        txtJdltambah.Size = New Size(562, 23)
        txtJdltambah.TabIndex = 1
        txtJdltambah.TextAlign = HorizontalAlignment.Center
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(253, 200)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(75, 23)
        btnTambah.TabIndex = 0
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI Black", 18.0F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(189, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(201, 32)
        Label1.TabIndex = 7
        Label1.Text = "TAMBAH BUKU" & vbCrLf
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Silver
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(lblJdlhapus)
        Panel2.Controls.Add(txtJdlhapus)
        Panel2.Controls.Add(btnHapus)
        Panel2.Location = New Point(12, 286)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(570, 188)
        Panel2.TabIndex = 1
        ' 
        ' lblJdlhapus
        ' 
        lblJdlhapus.AutoSize = True
        lblJdlhapus.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        lblJdlhapus.Location = New Point(253, 74)
        lblJdlhapus.Name = "lblJdlhapus"
        lblJdlhapus.Size = New Size(87, 20)
        lblJdlhapus.TabIndex = 5
        lblJdlhapus.Text = "Judul Buku"
        ' 
        ' txtJdlhapus
        ' 
        txtJdlhapus.Location = New Point(3, 97)
        txtJdlhapus.Name = "txtJdlhapus"
        txtJdlhapus.Size = New Size(562, 23)
        txtJdlhapus.TabIndex = 3
        txtJdlhapus.TextAlign = HorizontalAlignment.Center
        ' 
        ' btnHapus
        ' 
        btnHapus.Location = New Point(253, 137)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(75, 23)
        btnHapus.TabIndex = 1
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Black", 18.0F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.White
        Label4.Location = New Point(214, 14)
        Label4.Name = "Label4"
        Label4.Size = New Size(176, 32)
        Label4.TabIndex = 6
        Label4.Text = "HAPUS BUKU"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1})
        DataGridView1.Location = New Point(598, 22)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(469, 452)
        DataGridView1.TabIndex = 2
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Judul Buku (Genre)"
        Column1.Name = "Column1"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Green
        Panel3.Controls.Add(Label1)
        Panel3.Location = New Point(12, 22)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(570, 75)
        Panel3.TabIndex = 8
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        Panel4.Controls.Add(Label4)
        Panel4.Location = New Point(12, 287)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(570, 61)
        Panel4.TabIndex = 7
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonFace
        ClientSize = New Size(1079, 486)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(DataGridView1)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "Form1"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblJdlhapus As Label
    Friend WithEvents lblGtambah As Label
    Friend WithEvents lblJdltambah As Label
    Friend WithEvents txtGtambah As TextBox
    Friend WithEvents txtJdltambah As TextBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents txtJdlhapus As TextBox
    Friend WithEvents btnHapus As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel

End Class
