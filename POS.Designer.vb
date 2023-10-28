<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class POS
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(POS))
        Panel1 = New Panel()
        Button10 = New Button()
        Button11 = New Button()
        Button12 = New Button()
        Button7 = New Button()
        Button8 = New Button()
        BtnDot = New Button()
        Button4 = New Button()
        Button5 = New Button()
        Button6 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        Panel2 = New Panel()
        Panel5 = New Panel()
        Button16 = New Button()
        Button14 = New Button()
        Button13 = New Button()
        Button15 = New Button()
        Panel6 = New Panel()
        CashLbl = New Label()
        ChangeLbl = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        PaymentCb = New ComboBox()
        Panel4 = New Panel()
        TotalLbl = New Label()
        Label12 = New Label()
        SubtotalLbl = New Label()
        TaxLbl = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Panel3 = New Panel()
        OmoTuobtn = New Button()
        Fufubtn = New Button()
        Bankubtn = New Button()
        Ricebtn = New Button()
        Waakyebtn = New Button()
        Jollofbtn = New Button()
        PurchaseDGV = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        BarcodeLbl = New Label()
        Label14 = New Label()
        PrintDocument1 = New Printing.PrintDocument()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel5.SuspendLayout()
        Panel6.SuspendLayout()
        Panel4.SuspendLayout()
        Panel3.SuspendLayout()
        CType(PurchaseDGV, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Teal
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(Button10)
        Panel1.Controls.Add(Button11)
        Panel1.Controls.Add(Button12)
        Panel1.Controls.Add(Button7)
        Panel1.Controls.Add(Button8)
        Panel1.Controls.Add(BtnDot)
        Panel1.Controls.Add(Button4)
        Panel1.Controls.Add(Button5)
        Panel1.Controls.Add(Button6)
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button1)
        Panel1.Location = New Point(3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(305, 484)
        Panel1.TabIndex = 0
        ' 
        ' Button10
        ' 
        Button10.BackColor = Color.WhiteSmoke
        Button10.Font = New Font("Arial Narrow", 30F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Button10.Location = New Point(205, 245)
        Button10.Name = "Button10"
        Button10.Size = New Size(91, 107)
        Button10.TabIndex = 11
        Button10.Text = "3"
        Button10.UseVisualStyleBackColor = False
        ' 
        ' Button11
        ' 
        Button11.BackColor = Color.WhiteSmoke
        Button11.Font = New Font("Arial Narrow", 30F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Button11.Location = New Point(105, 245)
        Button11.Name = "Button11"
        Button11.Size = New Size(91, 107)
        Button11.TabIndex = 10
        Button11.Text = "2"
        Button11.UseVisualStyleBackColor = False
        ' 
        ' Button12
        ' 
        Button12.BackColor = Color.WhiteSmoke
        Button12.Font = New Font("Arial Narrow", 30F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Button12.Location = New Point(5, 245)
        Button12.Name = "Button12"
        Button12.Size = New Size(91, 107)
        Button12.TabIndex = 9
        Button12.Text = "1"
        Button12.UseVisualStyleBackColor = False
        ' 
        ' Button7
        ' 
        Button7.BackColor = Color.WhiteSmoke
        Button7.Font = New Font("Arial Narrow", 30F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Button7.Location = New Point(205, 358)
        Button7.Name = "Button7"
        Button7.Size = New Size(91, 107)
        Button7.TabIndex = 8
        Button7.Text = "C"
        Button7.UseVisualStyleBackColor = False
        ' 
        ' Button8
        ' 
        Button8.BackColor = Color.WhiteSmoke
        Button8.Font = New Font("Arial Narrow", 30F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Button8.Location = New Point(105, 358)
        Button8.Name = "Button8"
        Button8.Size = New Size(91, 107)
        Button8.TabIndex = 7
        Button8.Text = "0"
        Button8.UseVisualStyleBackColor = False
        ' 
        ' BtnDot
        ' 
        BtnDot.BackColor = Color.WhiteSmoke
        BtnDot.Font = New Font("Arial Narrow", 30F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        BtnDot.Location = New Point(5, 358)
        BtnDot.Name = "BtnDot"
        BtnDot.Size = New Size(91, 107)
        BtnDot.TabIndex = 6
        BtnDot.Text = "."
        BtnDot.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.WhiteSmoke
        Button4.Font = New Font("Arial Narrow", 30F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Button4.Location = New Point(205, 132)
        Button4.Name = "Button4"
        Button4.Size = New Size(91, 107)
        Button4.TabIndex = 5
        Button4.Text = "6"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.WhiteSmoke
        Button5.Font = New Font("Arial Narrow", 30F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Button5.Location = New Point(105, 132)
        Button5.Name = "Button5"
        Button5.Size = New Size(91, 107)
        Button5.TabIndex = 4
        Button5.Text = "5"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.WhiteSmoke
        Button6.Font = New Font("Arial Narrow", 30F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Button6.Location = New Point(5, 132)
        Button6.Name = "Button6"
        Button6.Size = New Size(91, 107)
        Button6.TabIndex = 3
        Button6.Text = "4"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.WhiteSmoke
        Button3.Font = New Font("Arial Narrow", 30F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Button3.Location = New Point(205, 19)
        Button3.Name = "Button3"
        Button3.Size = New Size(91, 107)
        Button3.TabIndex = 2
        Button3.Text = "9"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.WhiteSmoke
        Button2.Font = New Font("Arial Narrow", 30F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Button2.Location = New Point(105, 19)
        Button2.Name = "Button2"
        Button2.Size = New Size(91, 107)
        Button2.TabIndex = 1
        Button2.Text = "8"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.WhiteSmoke
        Button1.Font = New Font("Arial Narrow", 30F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Button1.Location = New Point(5, 19)
        Button1.Name = "Button1"
        Button1.Size = New Size(91, 107)
        Button1.TabIndex = 0
        Button1.Text = "7"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Teal
        Panel2.BorderStyle = BorderStyle.Fixed3D
        Panel2.Controls.Add(Panel5)
        Panel2.Controls.Add(Panel6)
        Panel2.Controls.Add(Panel4)
        Panel2.Location = New Point(3, 492)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1364, 227)
        Panel2.TabIndex = 1
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.WhiteSmoke
        Panel5.BorderStyle = BorderStyle.Fixed3D
        Panel5.Controls.Add(Button16)
        Panel5.Controls.Add(Button14)
        Panel5.Controls.Add(Button13)
        Panel5.Controls.Add(Button15)
        Panel5.Location = New Point(931, 16)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(422, 189)
        Panel5.TabIndex = 3
        ' 
        ' Button16
        ' 
        Button16.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Button16.Font = New Font("Baskerville Old Face", 24.75F, FontStyle.Bold, GraphicsUnit.Point)
        Button16.Location = New Point(7, 95)
        Button16.Name = "Button16"
        Button16.Size = New Size(201, 86)
        Button16.TabIndex = 14
        Button16.Text = "PRINT"
        Button16.UseVisualStyleBackColor = False
        ' 
        ' Button14
        ' 
        Button14.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Button14.Font = New Font("Baskerville Old Face", 24.75F, FontStyle.Bold, GraphicsUnit.Point)
        Button14.Location = New Point(7, 3)
        Button14.Name = "Button14"
        Button14.Size = New Size(201, 86)
        Button14.TabIndex = 13
        Button14.Text = "PAY"
        Button14.UseVisualStyleBackColor = False
        ' 
        ' Button13
        ' 
        Button13.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Button13.Font = New Font("Baskerville Old Face", 24.75F, FontStyle.Bold, GraphicsUnit.Point)
        Button13.Location = New Point(214, 3)
        Button13.Name = "Button13"
        Button13.Size = New Size(201, 86)
        Button13.TabIndex = 12
        Button13.Text = "RESET"
        Button13.UseVisualStyleBackColor = False
        ' 
        ' Button15
        ' 
        Button15.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Button15.Font = New Font("Baskerville Old Face", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Button15.Location = New Point(214, 95)
        Button15.Name = "Button15"
        Button15.Size = New Size(201, 86)
        Button15.TabIndex = 11
        Button15.Text = "REMOVE ITEM"
        Button15.UseVisualStyleBackColor = False
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.WhiteSmoke
        Panel6.BorderStyle = BorderStyle.Fixed3D
        Panel6.Controls.Add(CashLbl)
        Panel6.Controls.Add(ChangeLbl)
        Panel6.Controls.Add(Label4)
        Panel6.Controls.Add(Label3)
        Panel6.Controls.Add(Label2)
        Panel6.Controls.Add(Label1)
        Panel6.Controls.Add(PaymentCb)
        Panel6.Location = New Point(392, 16)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(533, 189)
        Panel6.TabIndex = 3
        ' 
        ' CashLbl
        ' 
        CashLbl.BackColor = SystemColors.ButtonHighlight
        CashLbl.BorderStyle = BorderStyle.Fixed3D
        CashLbl.Font = New Font("Baskerville Old Face", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        CashLbl.Location = New Point(266, 79)
        CashLbl.Name = "CashLbl"
        CashLbl.Size = New Size(248, 31)
        CashLbl.TabIndex = 6
        CashLbl.Text = "0"
        ' 
        ' ChangeLbl
        ' 
        ChangeLbl.BackColor = SystemColors.ButtonHighlight
        ChangeLbl.BorderStyle = BorderStyle.Fixed3D
        ChangeLbl.Font = New Font("Baskerville Old Face", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        ChangeLbl.Location = New Point(266, 142)
        ChangeLbl.Name = "ChangeLbl"
        ChangeLbl.Size = New Size(248, 31)
        ChangeLbl.TabIndex = 5
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Baskerville Old Face", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(268, 79)
        Label4.Name = "Label4"
        Label4.Size = New Size(0, 31)
        Label4.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Baskerville Old Face", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(3, 142)
        Label3.Name = "Label3"
        Label3.Size = New Size(101, 31)
        Label3.TabIndex = 3
        Label3.Text = "Change"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Baskerville Old Face", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(3, 79)
        Label2.Name = "Label2"
        Label2.Size = New Size(72, 31)
        Label2.TabIndex = 2
        Label2.Text = "Cash"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Baskerville Old Face", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(3, 11)
        Label1.Name = "Label1"
        Label1.Size = New Size(246, 31)
        Label1.TabIndex = 1
        Label1.Text = "Method of Payment"
        ' 
        ' PaymentCb
        ' 
        PaymentCb.Font = New Font("Baskerville Old Face", 18F, FontStyle.Bold, GraphicsUnit.Point)
        PaymentCb.FormattingEnabled = True
        PaymentCb.Location = New Point(266, 15)
        PaymentCb.Name = "PaymentCb"
        PaymentCb.Size = New Size(248, 35)
        PaymentCb.TabIndex = 0
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.WhiteSmoke
        Panel4.BorderStyle = BorderStyle.Fixed3D
        Panel4.Controls.Add(TotalLbl)
        Panel4.Controls.Add(Label12)
        Panel4.Controls.Add(SubtotalLbl)
        Panel4.Controls.Add(TaxLbl)
        Panel4.Controls.Add(Label9)
        Panel4.Controls.Add(Label10)
        Panel4.Location = New Point(7, 16)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(379, 189)
        Panel4.TabIndex = 2
        ' 
        ' TotalLbl
        ' 
        TotalLbl.BackColor = SystemColors.ButtonHighlight
        TotalLbl.BorderStyle = BorderStyle.Fixed3D
        TotalLbl.Font = New Font("Baskerville Old Face", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        TotalLbl.Location = New Point(152, 142)
        TotalLbl.Name = "TotalLbl"
        TotalLbl.Size = New Size(199, 31)
        TotalLbl.TabIndex = 12
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Baskerville Old Face", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label12.Location = New Point(3, 142)
        Label12.Name = "Label12"
        Label12.Size = New Size(78, 31)
        Label12.TabIndex = 11
        Label12.Text = "Total"
        ' 
        ' SubtotalLbl
        ' 
        SubtotalLbl.BackColor = SystemColors.ButtonHighlight
        SubtotalLbl.BorderStyle = BorderStyle.Fixed3D
        SubtotalLbl.Font = New Font("Baskerville Old Face", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        SubtotalLbl.Location = New Point(152, 8)
        SubtotalLbl.Name = "SubtotalLbl"
        SubtotalLbl.Size = New Size(199, 31)
        SubtotalLbl.TabIndex = 10
        ' 
        ' TaxLbl
        ' 
        TaxLbl.BackColor = SystemColors.ButtonHighlight
        TaxLbl.BorderStyle = BorderStyle.Fixed3D
        TaxLbl.Font = New Font("Baskerville Old Face", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        TaxLbl.Location = New Point(152, 71)
        TaxLbl.Name = "TaxLbl"
        TaxLbl.Size = New Size(199, 31)
        TaxLbl.TabIndex = 9
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Baskerville Old Face", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.Location = New Point(3, 71)
        Label9.Name = "Label9"
        Label9.Size = New Size(60, 31)
        Label9.TabIndex = 8
        Label9.Text = "Tax"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Baskerville Old Face", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label10.Location = New Point(3, 6)
        Label10.Name = "Label10"
        Label10.Size = New Size(131, 31)
        Label10.TabIndex = 7
        Label10.Text = "Sub Total"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Teal
        Panel3.BorderStyle = BorderStyle.Fixed3D
        Panel3.Controls.Add(OmoTuobtn)
        Panel3.Controls.Add(Fufubtn)
        Panel3.Controls.Add(Bankubtn)
        Panel3.Controls.Add(Ricebtn)
        Panel3.Controls.Add(Waakyebtn)
        Panel3.Controls.Add(Jollofbtn)
        Panel3.Location = New Point(668, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(702, 486)
        Panel3.TabIndex = 1
        ' 
        ' OmoTuobtn
        ' 
        OmoTuobtn.BackColor = Color.WhiteSmoke
        OmoTuobtn.Font = New Font("Arial Narrow", 30F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        OmoTuobtn.Location = New Point(481, 250)
        OmoTuobtn.Name = "OmoTuobtn"
        OmoTuobtn.Size = New Size(198, 202)
        OmoTuobtn.TabIndex = 17
        OmoTuobtn.Text = "OMO TUO"
        OmoTuobtn.UseVisualStyleBackColor = False
        ' 
        ' Fufubtn
        ' 
        Fufubtn.BackColor = Color.WhiteSmoke
        Fufubtn.Font = New Font("Arial Narrow", 30F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Fufubtn.Location = New Point(19, 250)
        Fufubtn.Name = "Fufubtn"
        Fufubtn.Size = New Size(198, 202)
        Fufubtn.TabIndex = 16
        Fufubtn.Text = "FUFU"
        Fufubtn.UseVisualStyleBackColor = False
        ' 
        ' Bankubtn
        ' 
        Bankubtn.BackColor = Color.WhiteSmoke
        Bankubtn.Font = New Font("Arial Narrow", 30F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Bankubtn.Location = New Point(249, 24)
        Bankubtn.Name = "Bankubtn"
        Bankubtn.Size = New Size(198, 202)
        Bankubtn.TabIndex = 15
        Bankubtn.Text = "BANKU"
        Bankubtn.UseVisualStyleBackColor = False
        ' 
        ' Ricebtn
        ' 
        Ricebtn.BackColor = Color.WhiteSmoke
        Ricebtn.Font = New Font("Arial Narrow", 30F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Ricebtn.Location = New Point(481, 24)
        Ricebtn.Name = "Ricebtn"
        Ricebtn.Size = New Size(198, 202)
        Ricebtn.TabIndex = 14
        Ricebtn.Text = "RICE"
        Ricebtn.UseVisualStyleBackColor = False
        ' 
        ' Waakyebtn
        ' 
        Waakyebtn.BackColor = Color.WhiteSmoke
        Waakyebtn.Font = New Font("Arial Narrow", 30F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Waakyebtn.Location = New Point(249, 250)
        Waakyebtn.Name = "Waakyebtn"
        Waakyebtn.Size = New Size(198, 202)
        Waakyebtn.TabIndex = 13
        Waakyebtn.Text = "WAAKYE"
        Waakyebtn.UseVisualStyleBackColor = False
        ' 
        ' Jollofbtn
        ' 
        Jollofbtn.BackColor = Color.WhiteSmoke
        Jollofbtn.Font = New Font("Arial Narrow", 30F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Jollofbtn.Location = New Point(19, 24)
        Jollofbtn.Name = "Jollofbtn"
        Jollofbtn.Size = New Size(198, 202)
        Jollofbtn.TabIndex = 12
        Jollofbtn.Text = "JOLLOF"
        Jollofbtn.UseVisualStyleBackColor = False
        ' 
        ' PurchaseDGV
        ' 
        PurchaseDGV.BackgroundColor = Color.White
        PurchaseDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        PurchaseDGV.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3})
        PurchaseDGV.Location = New Point(314, 2)
        PurchaseDGV.Name = "PurchaseDGV"
        PurchaseDGV.RowTemplate.Height = 25
        PurchaseDGV.Size = New Size(345, 403)
        PurchaseDGV.TabIndex = 2
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Item"
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Quantity"
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Amount"
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        ' 
        ' BarcodeLbl
        ' 
        BarcodeLbl.BackColor = SystemColors.ButtonHighlight
        BarcodeLbl.BorderStyle = BorderStyle.Fixed3D
        BarcodeLbl.Font = New Font("Code39", 40F, FontStyle.Regular, GraphicsUnit.Point)
        BarcodeLbl.Location = New Point(314, 408)
        BarcodeLbl.Name = "BarcodeLbl"
        BarcodeLbl.Size = New Size(345, 78)
        BarcodeLbl.TabIndex = 11
        BarcodeLbl.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label14
        ' 
        Label14.BackColor = Color.PaleTurquoise
        Label14.Dock = DockStyle.Bottom
        Label14.Font = New Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label14.Location = New Point(0, 722)
        Label14.Name = "Label14"
        Label14.Size = New Size(1370, 27)
        Label14.TabIndex = 13
        Label14.Text = "Copyright 2023 Black Matata Studios"
        Label14.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PrintDocument1
        ' 
        ' 
        ' PrintPreviewDialog1
        ' 
        PrintPreviewDialog1.AutoScrollMargin = New Size(0, 0)
        PrintPreviewDialog1.AutoScrollMinSize = New Size(0, 0)
        PrintPreviewDialog1.ClientSize = New Size(400, 300)
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.Enabled = True
        PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), Icon)
        PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        PrintPreviewDialog1.Visible = False
        ' 
        ' POS
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.PaleTurquoise
        ClientSize = New Size(1370, 749)
        Controls.Add(Label14)
        Controls.Add(BarcodeLbl)
        Controls.Add(PurchaseDGV)
        Controls.Add(Panel2)
        Controls.Add(Panel3)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.SizableToolWindow
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "POS"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ADDOWAA POS"
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel5.ResumeLayout(False)
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel3.ResumeLayout(False)
        CType(PurchaseDGV, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PurchaseDGV As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button15 As Button
    Friend WithEvents Button16 As Button
    Friend WithEvents Button14 As Button
    Friend WithEvents Button13 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents BtnDot As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents ChangeLbl As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PaymentCb As ComboBox
    Friend WithEvents CashLbl As Label
    Friend WithEvents TotalLbl As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents SubtotalLbl As Label
    Friend WithEvents TaxLbl As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents BarcodeLbl As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Jollofbtn As Button
    Friend WithEvents OmoTuobtn As Button
    Friend WithEvents Fufubtn As Button
    Friend WithEvents Bankubtn As Button
    Friend WithEvents Ricebtn As Button
    Friend WithEvents Waakyebtn As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
End Class
