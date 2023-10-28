Public Class POS

    Private bitmap As Bitmap
    Private Function CostOfItem() As Double
        Dim Sum As Double = 0
        Dim i As Integer = 0

        For i = 0 To PurchaseDGV.Rows.Count - 1
            Sum = Sum + Convert.ToDouble(PurchaseDGV.Rows(i).Cells(2).Value)
        Next i
        Return Sum
    End Function

    Private Sub AddCost()
        Dim tax, q As Double
        tax = 3.9

        If PurchaseDGV.Rows.Count > 0 Then
            TaxLbl.Text = FormatCurrency(((CostOfItem() * tax) / 100).ToString("0.00"))
            SubtotalLbl.Text = FormatCurrency(CostOfItem().ToString("0.00"))
            q = ((CostOfItem() * tax) / 100)
            TotalLbl.Text = FormatCurrency(q + CostOfItem().ToString("0.00"))
            BarcodeLbl.Text = q + CostOfItem().ToString("0.00")
        End If
    End Sub

    Private Sub Change()
        Dim tax, q, c As Double
        tax = 3.9

        If PurchaseDGV.Rows.Count > 0 Then
            q = ((CostOfItem() * tax) / 100) + CostOfItem()
            c = Val(CashLbl.Text)
            ChangeLbl.Text = (c - q).ToString("0.00")
        End If
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        SubtotalLbl.Text = ""
        TaxLbl.Text = ""
        TotalLbl.Text = ""
        CashLbl.Text = "0"
        ChangeLbl.Text = ""
        PaymentCb.Text = ""
        PurchaseDGV.Rows.Clear()
        PurchaseDGV.Refresh()
        BarcodeLbl.Text = ""
    End Sub

    Private Sub NumbersOnly(sender As Object, e As EventArgs) Handles Button10.Click, Button11.Click, Button12.Click, Button8.Click, Button4.Click, Button5.Click, Button6.Click, Button3.Click, Button2.Click, Button1.Click, BtnDot.Click
        Dim b As Button = sender

        If CashLbl.Text = "0" Then
            CashLbl.Text = ""
            CashLbl.Text = b.Text

        ElseIf b.Text = "." Then
            If Not CashLbl.Text.Contains(".") Then
                CashLbl.Text = CashLbl.Text + b.Text
            End If

        Else
            CashLbl.Text = CashLbl.Text + b.Text
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        CashLbl.Text = "0"
        ChangeLbl.Text = ""
        PaymentCb.Text = ""
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PaymentCb.Items.Add("Cash")
        PaymentCb.Items.Add("Mobile Money")
        PaymentCb.Items.Add("Visa Card")
        PaymentCb.Items.Add("Master Card")
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        If PaymentCb.Text = "Cash" Then
            Change()

        Else
            CashLbl.Text = "0"
            ChangeLbl.Text = ""
        End If

    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        For Each row As DataGridViewRow In PurchaseDGV.SelectedRows
            PurchaseDGV.Rows.Remove(row)
        Next
        AddCost()
        If PaymentCb.Text = "Cash" Then
            Change()
        Else
            CashLbl.Text = "0"
            ChangeLbl.Text = ""
        End If
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Dim height As Integer = PurchaseDGV.Height
        PurchaseDGV.Height = (PurchaseDGV.RowCount + 1) * PurchaseDGV.RowTemplate.Height
        bitmap = New Bitmap(Me.PurchaseDGV.Width, Me.PurchaseDGV.Height)
        PurchaseDGV.DrawToBitmap(bitmap, New Rectangle(0, 0, Me.PurchaseDGV.Width, Me.PurchaseDGV.Height))
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
        PrintPreviewDialog1.ShowDialog()
        PurchaseDGV.Height = height
    End Sub

    Private Sub Jollofbtn_Click(sender As Object, e As EventArgs) Handles Jollofbtn.Click
        Dim CostOfItem As Double = 9.99

        For Each row As DataGridViewRow In PurchaseDGV.Rows
            If row.Cells(0).Value = "Jollof Rice" Then
                row.Cells(1).Value = Double.Parse(row.Cells(1).Value + 1)
                row.Cells(2).Value = Double.Parse(row.Cells(1).Value) * CostOfItem
                Exit Sub
            End If
        Next
        PurchaseDGV.Rows.Add("Jollof Rice", "1", CostOfItem)
        AddCost()
    End Sub

    Private Sub Bankubtn_Click(sender As Object, e As EventArgs) Handles Bankubtn.Click
        Dim CostOfItem As Double = 19.99

        For Each row As DataGridViewRow In PurchaseDGV.Rows
            If row.Cells(0).Value = "Banku and Okro" Then
                row.Cells(1).Value = Double.Parse(row.Cells(1).Value) + 1
                row.Cells(2).Value = Double.Parse(row.Cells(1).Value) * CostOfItem
                Exit Sub
            End If
        Next
        PurchaseDGV.Rows.Add("Banku and Okro", "1", CostOfItem)
        AddCost()
    End Sub

    Private Sub Ricebtn_Click(sender As Object, e As EventArgs) Handles Ricebtn.Click
        Dim CostOfItem As Double = 8.99

        For Each row As DataGridViewRow In PurchaseDGV.Rows
            If row.Cells(0).Value = "Rice and Stew" Then
                row.Cells(1).Value = Double.Parse(row.Cells(1).Value) + 1
                row.Cells(2).Value = Double.Parse(row.Cells(1).Value) * CostOfItem
                Exit Sub
            End If
        Next
        PurchaseDGV.Rows.Add("Rice and Stew", "1", CostOfItem)
        AddCost()
    End Sub

    Private Sub Fufubtn_Click(sender As Object, e As EventArgs) Handles Fufubtn.Click
        Dim CostOfItem As Double = 14.99

        For Each row As DataGridViewRow In PurchaseDGV.Rows
            If row.Cells(0).Value = "Fufu and Lightsoup" Then
                row.Cells(1).Value = Double.Parse(row.Cells(1).Value) + 1
                row.Cells(2).Value = Double.Parse(row.Cells(1).Value) * CostOfItem
                Exit Sub
            End If
        Next
        PurchaseDGV.Rows.Add("Fufu and Lightsoup", "1", CostOfItem)
        AddCost()
    End Sub

    Private Sub Waakyebtn_Click(sender As Object, e As EventArgs) Handles Waakyebtn.Click
        Dim CostOfItem As Double = 10.99

        For Each row As DataGridViewRow In PurchaseDGV.Rows
            If row.Cells(0).Value = "Waakye" Then
                row.Cells(1).Value = Double.Parse(row.Cells(1).Value) + 1
                row.Cells(2).Value = Double.Parse(row.Cells(1).Value) * CostOfItem
                Exit Sub
            End If
        Next
        PurchaseDGV.Rows.Add("Waakye", "1", CostOfItem)
        AddCost()
    End Sub

    Private Sub OmoTuobtn_Click(sender As Object, e As EventArgs) Handles OmoTuobtn.Click
        Dim CostOfItem As Double = 11.99

        For Each row As DataGridViewRow In PurchaseDGV.Rows
            If row.Cells(0).Value = "Omo Tuo and Groundnut soup" Then
                row.Cells(1).Value = Double.Parse(row.Cells(1).Value) + 1
                row.Cells(2).Value = Double.Parse(row.Cells(1).Value) * CostOfItem
                Exit Sub
            End If
        Next
        PurchaseDGV.Rows.Add("Omo Tuo and Groundnut soup", "1", CostOfItem)
        AddCost()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawImage(bitmap, 10, 10)
    End Sub
End Class
