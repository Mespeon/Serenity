Public Class Card
    Private Sub Card_Unload(sender As Object, e As EventArgs) Handles MyBase.Closed
        'Main.lblPaymentStatus.Visible = False
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub

    Private Sub btnAddCard_Click(sender As Object, e As EventArgs) Handles btnAddCard.Click
        Arceus.validateCard(txtCardNumber.Text, txtCardOwnerName.Text, txtCSCNumber.Text, txtExpiryYear.Text)
    End Sub
End Class