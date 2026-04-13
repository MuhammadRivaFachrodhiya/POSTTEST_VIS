<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        components = New ComponentModel.Container()
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(components)
        Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(components)
        Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        GTBusn = New Guna.UI2.WinForms.Guna2TextBox()
        GTBpw = New Guna.UI2.WinForms.Guna2TextBox()
        btnLogin = New Guna.UI2.WinForms.Guna2GradientButton()
        Label1 = New Label()
        Label2 = New Label()
        btnGuest = New Guna.UI2.WinForms.Guna2GradientButton()
        Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(components)
        Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        CType(Guna2PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Guna2Elipse1
        ' 
        Guna2Elipse1.BorderRadius = 10
        Guna2Elipse1.TargetControl = Me
        ' 
        ' Guna2ShadowForm1
        ' 
        Guna2ShadowForm1.TargetForm = Me
        ' 
        ' Guna2PictureBox1
        ' 
        Guna2PictureBox1.CustomizableEdges = CustomizableEdges11
        Guna2PictureBox1.Image = My.Resources.Resources.formLogin2
        Guna2PictureBox1.ImageRotate = 0F
        Guna2PictureBox1.Location = New Point(0, -1)
        Guna2PictureBox1.Name = "Guna2PictureBox1"
        Guna2PictureBox1.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        Guna2PictureBox1.Size = New Size(478, 481)
        Guna2PictureBox1.TabIndex = 0
        Guna2PictureBox1.TabStop = False
        ' 
        ' GTBusn
        ' 
        GTBusn.BorderRadius = 8
        GTBusn.CustomizableEdges = CustomizableEdges9
        GTBusn.DefaultText = ""
        GTBusn.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        GTBusn.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        GTBusn.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        GTBusn.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        GTBusn.FillColor = Color.Gainsboro
        GTBusn.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        GTBusn.Font = New Font("Malgun Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GTBusn.ForeColor = Color.Black
        GTBusn.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        GTBusn.Location = New Point(548, 144)
        GTBusn.Margin = New Padding(4)
        GTBusn.Name = "GTBusn"
        GTBusn.PlaceholderForeColor = Color.Gray
        GTBusn.PlaceholderText = "Username"
        GTBusn.SelectedText = ""
        GTBusn.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        GTBusn.Size = New Size(244, 37)
        GTBusn.TabIndex = 2
        ' 
        ' GTBpw
        ' 
        GTBpw.BorderRadius = 8
        GTBpw.CustomizableEdges = CustomizableEdges7
        GTBpw.DefaultText = ""
        GTBpw.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        GTBpw.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        GTBpw.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        GTBpw.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        GTBpw.FillColor = Color.Gainsboro
        GTBpw.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        GTBpw.Font = New Font("Malgun Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GTBpw.ForeColor = Color.Black
        GTBpw.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        GTBpw.Location = New Point(548, 207)
        GTBpw.Margin = New Padding(4)
        GTBpw.Name = "GTBpw"
        GTBpw.PlaceholderForeColor = Color.Gray
        GTBpw.PlaceholderText = "Password"
        GTBpw.SelectedText = ""
        GTBpw.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        GTBpw.Size = New Size(244, 37)
        GTBpw.TabIndex = 3
        ' 
        ' btnLogin
        ' 
        btnLogin.BorderRadius = 10
        btnLogin.CustomizableEdges = CustomizableEdges5
        btnLogin.DisabledState.BorderColor = Color.DarkGray
        btnLogin.DisabledState.CustomBorderColor = Color.DarkGray
        btnLogin.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnLogin.DisabledState.FillColor2 = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnLogin.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnLogin.FillColor = Color.FromArgb(CByte(102), CByte(2), CByte(2))
        btnLogin.FillColor2 = Color.FromArgb(CByte(178), CByte(0), CByte(0))
        btnLogin.Font = New Font("Malgun Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogin.ForeColor = Color.White
        btnLogin.Location = New Point(548, 262)
        btnLogin.Name = "btnLogin"
        btnLogin.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        btnLogin.Size = New Size(244, 45)
        btnLogin.TabIndex = 4
        btnLogin.Text = "MASUK"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Malgun Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.AppWorkspace
        Label1.Location = New Point(650, 310)
        Label1.Name = "Label1"
        Label1.Size = New Size(43, 20)
        Label1.TabIndex = 6
        Label1.Text = "Atau"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Malgun Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(589, 94)
        Label2.Name = "Label2"
        Label2.Size = New Size(165, 32)
        Label2.TabIndex = 7
        Label2.Text = "LOGIN AKUN"
        ' 
        ' btnGuest
        ' 
        btnGuest.BorderRadius = 10
        btnGuest.CustomizableEdges = CustomizableEdges3
        btnGuest.DisabledState.BorderColor = Color.DarkGray
        btnGuest.DisabledState.CustomBorderColor = Color.DarkGray
        btnGuest.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnGuest.DisabledState.FillColor2 = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnGuest.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnGuest.FillColor = Color.FromArgb(CByte(102), CByte(2), CByte(2))
        btnGuest.FillColor2 = Color.FromArgb(CByte(178), CByte(0), CByte(0))
        btnGuest.Font = New Font("Malgun Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnGuest.ForeColor = Color.White
        btnGuest.Location = New Point(548, 333)
        btnGuest.Name = "btnGuest"
        btnGuest.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        btnGuest.Size = New Size(244, 45)
        btnGuest.TabIndex = 5
        btnGuest.Text = "TAMU"
        ' 
        ' Guna2AnimateWindow1
        ' 
        Guna2AnimateWindow1.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_SLIDE
        Guna2AnimateWindow1.TargetForm = Me
        ' 
        ' Guna2ControlBox1
        ' 
        Guna2ControlBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Guna2ControlBox1.BorderColor = Color.White
        Guna2ControlBox1.BorderRadius = 10
        Guna2ControlBox1.BorderThickness = 2
        Guna2ControlBox1.CustomizableEdges = CustomizableEdges1
        Guna2ControlBox1.FillColor = Color.White
        Guna2ControlBox1.HoverState.FillColor = Color.Black
        Guna2ControlBox1.HoverState.IconColor = Color.White
        Guna2ControlBox1.IconColor = Color.Black
        Guna2ControlBox1.Location = New Point(806, 12)
        Guna2ControlBox1.Name = "Guna2ControlBox1"
        Guna2ControlBox1.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2ControlBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Guna2ControlBox1.Size = New Size(45, 29)
        Guna2ControlBox1.TabIndex = 8
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(863, 476)
        Controls.Add(Guna2ControlBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnGuest)
        Controls.Add(btnLogin)
        Controls.Add(GTBpw)
        Controls.Add(GTBusn)
        Controls.Add(Guna2PictureBox1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        CType(Guna2PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents GTBpw As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents GTBusn As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnLogin As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnGuest As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox

End Class
