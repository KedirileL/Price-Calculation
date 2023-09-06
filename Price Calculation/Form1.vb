Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnTotal.Click

        Dim Price As Decimal
        Dim Quantity As Integer
        Dim Total As Decimal
        Dim NameOfCustomer As String

        Price = txtPrice.Text
        Quantity = txtQuantity.Text
        NameOfCustomer = txtNameOfCustomer.Text

        Total = Price * Quantity

        MsgBox("Hi " & NameOfCustomer & " , your Total is R" & Total)

    End Sub
End Class
