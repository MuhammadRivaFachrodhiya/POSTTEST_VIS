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
        txtIPS = New TextBox()
        txtIPK = New TextBox()
        btnTambah = New Button()
        btnReset = New Button()
        Label1 = New Label()
        Label2 = New Label()
        lblKet = New Label()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' txtIPS
        ' 
        txtIPS.Location = New Point(358, 175)
        txtIPS.Name = "txtIPS"
        txtIPS.Size = New Size(170, 23)
        txtIPS.TabIndex = 0
        ' 
        ' txtIPK
        ' 
        txtIPK.Location = New Point(358, 233)
        txtIPK.Name = "txtIPK"
        txtIPK.ReadOnly = True
        txtIPK.Size = New Size(170, 23)
        txtIPK.TabIndex = 1
        ' 
        ' btnTambah
        ' 
        btnTambah.Font = New Font("Adobe Heiti Std R", 9F)
        btnTambah.Location = New Point(358, 204)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(75, 23)
        btnTambah.TabIndex = 2
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' btnReset
        ' 
        btnReset.Font = New Font("Adobe Heiti Std R", 9F)
        btnReset.Location = New Point(453, 204)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(75, 23)
        btnReset.TabIndex = 3
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Adobe Heiti Std R", 9F)
        Label1.Location = New Point(239, 183)
        Label1.Name = "Label1"
        Label1.Size = New Size(71, 15)
        Label1.TabIndex = 4
        Label1.Text = "IP Semester"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Adobe Heiti Std R", 9F)
        Label2.Location = New Point(239, 241)
        Label2.Name = "Label2"
        Label2.Size = New Size(72, 15)
        Label2.TabIndex = 5
        Label2.Text = "IP Kumulatif"
        ' 
        ' lblKet
        ' 
        lblKet.AutoSize = True
        lblKet.Font = New Font("Adobe Heiti Std R", 9F)
        lblKet.Location = New Point(358, 273)
        lblKet.Name = "lblKet"
        lblKet.Size = New Size(0, 15)
        lblKet.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top
        Label3.AutoSize = True
        Label3.Font = New Font("Imprint MT Shadow", 20.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(267, 120)
        Label3.Name = "Label3"
        Label3.Size = New Size(240, 32)
        Label3.TabIndex = 7
        Label3.Text = "PREDIKAT IPK"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(800, 450)
        Controls.Add(Label3)
        Controls.Add(lblKet)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnReset)
        Controls.Add(btnTambah)
        Controls.Add(txtIPK)
        Controls.Add(txtIPS)
        Name = "Form1"
        Text = "Tebak Predikat IPK"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtIPS As TextBox
    Friend WithEvents txtIPK As TextBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblKet As Label
    Friend WithEvents Label3 As Label

End Class
