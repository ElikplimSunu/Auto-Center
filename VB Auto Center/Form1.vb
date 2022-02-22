Imports System.Drawing.Printing

Public Class Form1
    Dim name As String
    Dim commissionVal As Integer
    Private PrintDialog1 As PrintDialog
    Private PrintDocument1 As PrintDocument
    Const commissionRate = 0.2
    Private Sub calculateBtn_Click(sender As Object, e As EventArgs) Handles calculateBtn.Click
        commissionVal = commissionRate * (Val(sellingPriceBox.Text) - Val(costPriceBox.Text))
        commissionBox.Text = commissionVal
    End Sub

    Private Sub clearBtn_Click(sender As Object, e As EventArgs) Handles clearBtn.Click
        nameBox.Clear()
        sellingPriceBox.Clear()
        costPriceBox.Clear()
        commissionBox.Clear()
    End Sub

    Private Sub printBtn_Click(sender As Object, e As EventArgs) Handles printBtn.Click
        PrintDialog1.Document = PrintDocument1
        PrintDialog1.PrinterSettings = PrintDocument1.PrinterSettings
        PrintDialog1.AllowSomePages = True

        If PrintDialog1.ShowDialog = DialogResult.OK Then
            PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings
            PrintDocument1.Print()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class
