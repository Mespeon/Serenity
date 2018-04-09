Imports MySql.Data.MySqlClient

Module Prismriver
    Public sqlConnection As New MySqlConnection
    Public sqlCommand As New MySqlCommand
    Public sqlDataAdapter As New MySqlDataAdapter
    Public sqlDataReader As MySqlDataReader
    Public sqlQuery As String

    Public Sub connect()
        If sqlConnection.State = ConnectionState.Closed Then
            Try
                sqlConnection.ConnectionString = "SERVER = localhost; DATABASE = serenata; UID = root; PWD="
                sqlConnection.Open()
            Catch ex As Exception
                Dim errorPrompt = MessageBox.Show("The attempt to connect to the database failed.\nError:\n" & ex.ToString & "\nRetry to connect?", "Connection Failed", MessageBoxButtons.YesNo, MessageBoxIcon.Error)
                If errorPrompt = MsgBoxResult.Yes Then
                    connect()
                Else
                    End
                End If
            End Try
        End If
    End Sub

    Public Sub disconnect()
        If sqlConnection.State = ConnectionState.Open Then
            Try
                sqlConnection.Close()
            Catch ex As Exception
                End
            End Try
        End If
    End Sub

    Public Sub populateGrid()
        If sqlConnection.State = ConnectionState.Closed Then
            sqlConnection.Open()
        End If

        With sqlCommand
            .Connection = sqlConnection
            .CommandText = "SELECT reservationNumber AS 'Reservation Number', customer AS 'Client', start_date AS 'Start Date', end_date AS 'End Date', stay_days AS 'Stay Duration', cost AS 'Cost', payment_mode AS 'Payment Method', changeCash as 'Change' FROM reservations"
        End With

        Dim sqlDataTable As New DataTable
        sqlDataAdapter.SelectCommand = sqlCommand
        sqlDataTable.Clear()
        sqlDataAdapter.Fill(sqlDataTable)
        Main.dgvReservations.DataSource = sqlDataTable

        sqlCommand.Dispose()
        sqlConnection.Close()
    End Sub

    Public Sub getRooms(ByVal room As String)
        Main.cbxRooms.Items.Clear()

        If sqlConnection.State = ConnectionState.Closed Then
            sqlConnection.Open()
        End If

        Try
            sqlQuery = "SELECT roomNumber, roomRate FROM rooms WHERE isReserved = 0 AND roomType = '" + room + "'"

            With sqlCommand
                .Connection = sqlConnection
                .CommandText = sqlQuery
            End With

            sqlDataReader = sqlCommand.ExecuteReader
            If sqlDataReader.HasRows Then
                While sqlDataReader.Read()
                    Main.cbxRooms.Items.Add(sqlDataReader.Item("roomNumber"))
                End While

                Main.lblActualRoomCost.Text = sqlDataReader.Item("roomRate")
            Else
                Main.cbxRooms.Items.Add("No available rooms for reservation.")
            End If

            sqlCommand.Dispose()
            sqlDataReader.Close()
            sqlConnection.Close()
        Catch ex As Exception
            MessageBox.Show(ErrorToString)
            MessageBox.Show(ex.ToString, "Error Pulling Rooms", MessageBoxButtons.OK, MessageBoxIcon.Error)
            sqlConnection.Close()
        End Try
    End Sub

    Public Sub saveReservations(ByVal fname As String, ByVal lname As String, ByVal minitial As String, ByVal address As String, ByVal contactNum As String, ByVal reservationNumber As String, ByVal startDate As String, ByVal endDate As String, ByVal stayDays As String, ByVal rmType As String, ByVal rmNumber As String,
                                ByVal rmRate As String, ByVal grandTotal As String, ByVal paymentMethod As String, ByVal cash As String, ByVal change As String)
        sqlDataReader.Close()

        If sqlConnection.State = ConnectionState.Closed Then
            sqlConnection.Open()
        End If

        'Push reservation data into database
        Try
            Dim customer As String = fname + " " + minitial + ". " + lname
            sqlQuery = "INSERT INTO reservations(reservationNumber, customer, start_date, end_date, stay_days, cost, payment_mode, changeCash) VALUES('" + reservationNumber + "', '" + customer + "', '" + startDate + "', '" + endDate + "', '" + Integer.Parse(stayDays).ToString + "', " + Decimal.Parse(grandTotal).ToString + ", '" + paymentMethod + "', " + Decimal.Parse(change).ToString + ")"

            With sqlCommand
                .Connection = sqlConnection
                .CommandText = sqlQuery
            End With

            sqlCommand.ExecuteNonQuery()
            sqlCommand.Dispose()
        Catch ex As Exception
            MessageBox.Show(ErrorToString)
            MessageBox.Show(ex.ToString, "Error Saving Reservation - Room Details", MessageBoxButtons.OK, MessageBoxIcon.Error)
            sqlConnection.Close()
        End Try

        'Update room status to isReserved = TRUE
        Try
            sqlQuery = "UPDATE rooms SET isReserved = 1 WHERE roomNumber = " + rmNumber

            With sqlCommand
                .Connection = sqlConnection
                .CommandText = sqlQuery
            End With

            sqlCommand.ExecuteNonQuery()
            sqlCommand.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error Updating Room Data", MessageBoxButtons.OK, MessageBoxIcon.Error)
            sqlConnection.Close()
        End Try

        MessageBox.Show("Successfully saved the reservation form.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
        populateGrid()

        sqlCommand.Dispose()
        sqlDataReader.Close()
        sqlConnection.Close()
    End Sub
End Module
