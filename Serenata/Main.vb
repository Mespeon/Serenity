Public Class Main
    Public reservationTransactions As New Random

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Prismriver.connect()
        Prismriver.populateGrid()
    End Sub

    Private Sub rbtnCardMethod_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnCardMethod.CheckedChanged
        If rbtnCardMethod.Checked = True Then
            Card.Location = New Point(rbtnCardMethod.Location.X + 400, rbtnCardMethod.Location.Y * 11)
            Card.Show()
            lblPaymentStatus.Text = "Awaiting card details..."
            lblPaymentStatus.Visible = True
        Else
            If Card.Visible = True Then
                Card.Close()
                lblPaymentStatus.Visible = False
            End If
        End If
    End Sub

    Private Sub rbtnCardMethod_Clicked(sender As Object, e As EventArgs) Handles rbtnCardMethod.Click
        If Card.Visible = False Then
            Card.Location = New Point(rbtnCardMethod.Location.X + 400, rbtnCardMethod.Location.Y * 11)
            Card.Show()
            lblPaymentStatus.Text = "Awaiting card details..."
            lblPaymentStatus.Visible = True
        End If
    End Sub

    Private Sub rbtnCashMethod_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnCashMethod.CheckedChanged
        If rbtnCashMethod.Checked = True Then
            lblPaymentStatus.Text = "Awaiting complete cash payment details..."
            lblPaymentStatus.Visible = True
            pnlCashEntry.Visible = True
        Else
            lblPaymentStatus.Visible = False
            pnlCashEntry.Visible = False
            txtCash.Clear()
            txtChange.Clear()
        End If

    End Sub

    Private Sub rbtnSingleRoom_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnSingleRoom.CheckedChanged
        Prismriver.getRooms("Single Room")
    End Sub

    Private Sub rbtnDoubleRoom_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnDoubleRoom.CheckedChanged
        Prismriver.getRooms("Double Room")
    End Sub

    Private Sub rbtnFamilyRoom_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnFamilyRoom.CheckedChanged
        Prismriver.getRooms("Family Room")
    End Sub

    Private Sub dtpArrival_ValueChanged(sender As Object, e As EventArgs) Handles dtpArrival.ValueChanged
        If dtpArrival.Value.Date.Day < Today.Day Then
            MessageBox.Show("Cannot select past days.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
            dtpArrival.Value = Today
        Else
            Arceus.calculateStay(dtpArrival.Value.Date.Day, dtpCheckout.Value.Date.Day)
            Arceus.calculateGrandTotal()
        End If
    End Sub

    Private Sub dtpCheckout_ValueChanged(sender As Object, e As EventArgs) Handles dtpCheckout.ValueChanged
        If dtpCheckout.Value.Date.Day < Today.Day Then
            MessageBox.Show("Cannot select past days.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
            dtpCheckout.Value = Today
        Else
            Arceus.calculateStay(dtpArrival.Value.Date.Day, dtpCheckout.Value.Date.Day)
            Arceus.calculateGrandTotal()
        End If
    End Sub

    Private Sub cbxRooms_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxRooms.SelectedIndexChanged
        Arceus.calculateGrandTotal()
    End Sub

    Private Sub btnUpdateTotal_Click(sender As Object, e As EventArgs) Handles btnUpdateTotal.Click
        calculateGrandTotal()
    End Sub

    Private Sub tabReservations_Click(sender As Object, e As EventArgs) Handles tabReservations.Click
        txtFirstName.Clear()
        txtLastName.Clear()
        txtMiddleInitial.Clear()
        txtAddress.Clear()
        txtContactNumber.Clear()
        txtCash.Clear()
        txtChange.Clear()
        lblActualDaysOfStay.ResetText()
        lblActualRoomCost.ResetText()
        lblGrandTotal.ResetText()
    End Sub

    Private Sub btn1000_Click(sender As Object, e As EventArgs) Handles btn1000.Click
        txtCash.Text = Val(txtCash.Text) + 1000
    End Sub

    Private Sub btn500_Click(sender As Object, e As EventArgs) Handles btn500.Click
        txtCash.Text = Val(txtCash.Text) + 500
    End Sub

    Private Sub btn100_Click(sender As Object, e As EventArgs) Handles btn100.Click
        txtCash.Text = Val(txtCash.Text) + 100
    End Sub

    Private Sub btn50_Click(sender As Object, e As EventArgs) Handles btn50.Click
        txtCash.Text = Val(txtCash.Text) + 50
    End Sub

    Private Sub btn20_Click(sender As Object, e As EventArgs) Handles btn20.Click
        txtCash.Text = Val(txtCash.Text) + 20
    End Sub

    Private Sub btnClearPayment_Click(sender As Object, e As EventArgs) Handles btnClearPayment.Click
        txtCash.Clear()
        txtChange.Clear()
    End Sub

    Private Sub txtCash_Change(sender As Object, e As EventArgs) Handles txtCash.TextChanged
        Dim change As Decimal = Val(txtCash.Text) - Val(lblGrandTotal.Text)
        If change > 0 Then
            txtChange.Text = change
        End If
    End Sub

    Private Sub btnValidate_Click(sender As Object, e As EventArgs) Handles btnValidate.Click
        Dim hasErrors As Boolean = False
        If txtFirstName.Text = "" Or txtLastName.Text = "" Or txtMiddleInitial.Text = "" Then
            lblNameError.Visible = True
            hasErrors = True
        Else
            lblNameError.Visible = False
            hasErrors = False
        End If

        If txtAddress.Text = "" Then
            lblAddressError.Visible = True
            hasErrors = True
        Else
            lblAddressError.Visible = False
            hasErrors = False
        End If

        If txtContactNumber.Text = "" Then
            lblContactError.Visible = True
            hasErrors = True
        Else
            lblContactError.Visible = False
            hasErrors = False
        End If

        If lblActualDaysOfStay.Text = 0 Then
            lblReservationError.Visible = True
            hasErrors = True
        Else
            lblReservationError.Visible = False
            hasErrors = False
        End If

        If rbtnSingleRoom.Checked = False And rbtnDoubleRoom.Checked = False And rbtnFamilyRoom.Checked = False Then
            lblRoomError.Visible = True
            hasErrors = True
        Else
            lblRoomError.Visible = False
            hasErrors = False
        End If

        If cbxRooms.SelectedItem.ToString.Equals("") Then
            lblRoomError.Visible = True
            hasErrors = True
        Else
            lblRoomError.Visible = False
            hasErrors = False
        End If

        If rbtnCashMethod.Checked = True Then
            If Val(txtCash.Text) <= 0 Or txtCash.Text = "" Then
                lblPaymentError.Visible = True
                hasErrors = True
            Else
                lblPaymentError.Visible = False
                hasErrors = False
            End If
        End If

        If rbtnCardMethod.Checked = True Then
            If lblPaymentStatus.Text.Equals("Card accepted") = False Then
                lblPaymentError.Visible = True
                hasErrors = True
            Else
                lblPaymentError.Visible = False
                hasErrors = False
            End If
        End If

        If hasErrors = True Then
            MessageBox.Show("Errors have been found in the form.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            btnSave.Enabled = True
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'Customer information
        Dim firstName As String = txtFirstName.Text
        Dim lastName As String = txtLastName.Text
        Dim minitial As String = txtMiddleInitial.Text
        Dim address As String = txtAddress.Text
        Dim contactNumber As String = txtContactNumber.Text

        'Reservation Info
        Dim reservationNumber As String = Today.ToShortDateString & "-" & reservationTransactions.Next(1, 999)
        Dim startDate As String = dtpArrival.Value.ToShortDateString
        Dim endDate As String = dtpCheckout.Value.ToShortDateString
        Dim stayDays As String = lblActualDaysOfStay.Text
        Dim rmType As String
        If rbtnSingleRoom.Checked = True Then
            rmType = "Single Room"
        ElseIf rbtnDoubleRoom.Checked = True
            rmType = "Double Room"
        ElseIf rbtnFamilyRoom.Checked = True
            rmType = "Family Room"
        End If
        Dim rmNumber As String = cbxRooms.SelectedItem
        Dim rmRate As Decimal = Decimal.Parse(Val(lblActualRoomCost.Text))
        Dim grandTotal As Decimal = Decimal.Parse(Val(lblGrandTotal.Text))

        'Payment Info
        Dim paymentMethod As String
        Dim cashPaid As Decimal
        Dim change As Decimal

        If rbtnCashMethod.Checked = True Then
            paymentMethod = "CASH"
            cashPaid = Decimal.Parse(Val(txtCash.Text))
            change = Decimal.Parse(Val(txtChange.Text))
        ElseIf rbtnCardMethod.Checked = True
            paymentMethod = "CARD"
            cashPaid = Decimal.Parse(Val(txtCash.Text))
            change = Decimal.Parse(0)
        End If

        Prismriver.saveReservations(firstName, lastName, minitial, address, contactNumber, reservationNumber, startDate, endDate, stayDays, rmType, rmNumber, rmRate, grandTotal, paymentMethod, cashPaid, change)

        'Clear all fields
        txtFirstName.Clear()
        txtLastName.Clear()
        txtMiddleInitial.Clear()
        txtAddress.Clear()
        txtContactNumber.Clear()
        txtCash.Clear()
        txtChange.Clear()
        lblActualDaysOfStay.Text = ""
        lblActualRoomCost.Text = ""
        lblGrandTotal.Text = ""
        rbtnCardMethod.Checked = False
        rbtnCashMethod.Checked = False
        rbtnSingleRoom.Checked = False
        rbtnDoubleRoom.Checked = False
        rbtnFamilyRoom.Checked = False
        dtpArrival.Value = Today
        dtpCheckout.Value = Today
    End Sub
End Class
