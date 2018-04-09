Module Arceus
    Public Sub validateCard(ByVal cardNum As Integer, ByVal cardOwner As String, ByVal cardCSC As Integer, ByVal cardExpiry As Integer)
        Dim hasErrors As Boolean = False

        If IsNumeric(cardNum) = True And Card.txtCardNumber.Text.Length > 0 AndAlso Card.txtCardNumber.Text.Length <= 20 Then
            Card.lblCardNumberError.Visible = False
            hasErrors = False
        Else
            Card.lblCardNumberError.Visible = True
            hasErrors = True
        End If

        If Card.txtCardOwnerName.Text.Length = 0 Then
            Card.lblCardOwnerError.Visible = True
            hasErrors = True
        Else
            Card.lblCardOwnerError.Visible = False
            hasErrors = False
        End If

        If IsNumeric(cardCSC) = True And cardCSC.ToString.Length = 3 Then
            Card.lblCSCError.Visible = False
            hasErrors = False
        Else
            Card.lblCSCError.Visible = True
            hasErrors = True
        End If

        If IsNumeric(cardExpiry) = True And cardExpiry.ToString.Length = 4 AndAlso cardExpiry >= Today.Year Then
            Card.lblExpiryError.Visible = False
            hasErrors = False
        Else
            Card.lblExpiryError.Visible = True
            hasErrors = True
        End If

        If hasErrors = False Then
            MessageBox.Show("Card data is valid.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Main.lblPaymentStatus.Text = "Card accepted"
            Main.lblPaymentStatus.Visible = True
            Card.Close()
        Else
            MessageBox.Show("Card data is invalid.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Public Sub calculateStay(ByVal arrival As Integer, ByVal checkout As Integer)
        If checkout > arrival Then
            Dim stay = checkout - arrival
            Main.lblActualDaysOfStay.Text = stay
        ElseIf checkout = arrival Then
            Main.lblActualDaysOfStay.Text = 1
        Else
            Main.lblActualDaysOfStay.Text = 0
        End If
    End Sub

    Public Sub calculateGrandTotal()
        Dim grandTotal As Decimal = Val(Main.lblActualDaysOfStay.Text) * Val(Main.lblActualRoomCost.Text)
        Main.lblGrandTotal.Text = grandTotal
        Main.txtChange.Clear()
        Main.txtCash.Clear()
    End Sub
End Module
