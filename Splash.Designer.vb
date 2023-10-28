<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Splash
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Splash))
        Timer1 = New Timer(components)
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        Label1 = New Label()
        MyProgressBar = New ProgressBar()
        Label14 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Timer1
        ' 
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BorderStyle = BorderStyle.FixedSingle
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(12, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(475, 379)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 18
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.White
        Label2.Font = New Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(285, 321)
        Label2.Name = "Label2"
        Label2.Size = New Size(32, 30)
        Label2.TabIndex = 22
        Label2.Text = "%"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.White
        Label1.Font = New Font("Century Gothic", 9.75F, FontStyle.Italic, GraphicsUnit.Point)
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(194, 335)
        Label1.Name = "Label1"
        Label1.Size = New Size(76, 16)
        Label1.TabIndex = 21
        Label1.Text = "Loading...."
        ' 
        ' MyProgressBar
        ' 
        MyProgressBar.Location = New Point(61, 356)
        MyProgressBar.Name = "MyProgressBar"
        MyProgressBar.Size = New Size(374, 10)
        MyProgressBar.TabIndex = 20
        ' 
        ' Label14
        ' 
        Label14.BackColor = Color.PaleTurquoise
        Label14.Dock = DockStyle.Bottom
        Label14.Font = New Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label14.Location = New Point(0, 394)
        Label14.Name = "Label14"
        Label14.Size = New Size(498, 27)
        Label14.TabIndex = 19
        Label14.Text = "Copyright 2023 Black Matata Studios"
        Label14.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Splash
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.PaleTurquoise
        ClientSize = New Size(498, 421)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(MyProgressBar)
        Controls.Add(Label14)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Splash"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Splash"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents MyProgressBar As ProgressBar
    Friend WithEvents Label14 As Label
End Class
