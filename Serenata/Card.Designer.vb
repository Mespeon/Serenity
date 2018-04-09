<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Card
    Inherits MetroFramework.Forms.MetroForm

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
        Me.lblCardNumber = New MetroFramework.Controls.MetroLabel()
        Me.txtCardNumber = New MetroFramework.Controls.MetroTextBox()
        Me.txtCardOwnerName = New MetroFramework.Controls.MetroTextBox()
        Me.lblCardOwnerName = New MetroFramework.Controls.MetroLabel()
        Me.txtCSCNumber = New MetroFramework.Controls.MetroTextBox()
        Me.lblCSCNumber = New MetroFramework.Controls.MetroLabel()
        Me.lblExpiryYear = New MetroFramework.Controls.MetroLabel()
        Me.txtExpiryYear = New MetroFramework.Controls.MetroTextBox()
        Me.btnAddCard = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblCardNumberError = New MetroFramework.Controls.MetroLabel()
        Me.lblCardOwnerError = New MetroFramework.Controls.MetroLabel()
        Me.lblExpiryError = New MetroFramework.Controls.MetroLabel()
        Me.lblCSCError = New MetroFramework.Controls.MetroLabel()
        Me.SuspendLayout()
        '
        'lblCardNumber
        '
        Me.lblCardNumber.AutoSize = True
        Me.lblCardNumber.Location = New System.Drawing.Point(19, 91)
        Me.lblCardNumber.Margin = New System.Windows.Forms.Padding(3, 5, 5, 5)
        Me.lblCardNumber.Name = "lblCardNumber"
        Me.lblCardNumber.Size = New System.Drawing.Size(91, 19)
        Me.lblCardNumber.Style = MetroFramework.MetroColorStyle.Yellow
        Me.lblCardNumber.TabIndex = 6
        Me.lblCardNumber.Text = "Card Number"
        Me.lblCardNumber.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'txtCardNumber
        '
        '
        '
        '
        Me.txtCardNumber.CustomButton.Image = Nothing
        Me.txtCardNumber.CustomButton.Location = New System.Drawing.Point(232, 1)
        Me.txtCardNumber.CustomButton.Name = ""
        Me.txtCardNumber.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtCardNumber.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtCardNumber.CustomButton.TabIndex = 1
        Me.txtCardNumber.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtCardNumber.CustomButton.UseSelectable = True
        Me.txtCardNumber.CustomButton.Visible = False
        Me.txtCardNumber.Location = New System.Drawing.Point(23, 63)
        Me.txtCardNumber.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.txtCardNumber.MaxLength = 20
        Me.txtCardNumber.Name = "txtCardNumber"
        Me.txtCardNumber.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCardNumber.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtCardNumber.SelectedText = ""
        Me.txtCardNumber.SelectionLength = 0
        Me.txtCardNumber.SelectionStart = 0
        Me.txtCardNumber.Size = New System.Drawing.Size(254, 23)
        Me.txtCardNumber.Style = MetroFramework.MetroColorStyle.Yellow
        Me.txtCardNumber.TabIndex = 7
        Me.txtCardNumber.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.txtCardNumber.UseSelectable = True
        Me.txtCardNumber.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtCardNumber.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtCardOwnerName
        '
        '
        '
        '
        Me.txtCardOwnerName.CustomButton.Image = Nothing
        Me.txtCardOwnerName.CustomButton.Location = New System.Drawing.Point(232, 1)
        Me.txtCardOwnerName.CustomButton.Name = ""
        Me.txtCardOwnerName.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtCardOwnerName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtCardOwnerName.CustomButton.TabIndex = 1
        Me.txtCardOwnerName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtCardOwnerName.CustomButton.UseSelectable = True
        Me.txtCardOwnerName.CustomButton.Visible = False
        Me.txtCardOwnerName.Location = New System.Drawing.Point(23, 125)
        Me.txtCardOwnerName.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.txtCardOwnerName.MaxLength = 50
        Me.txtCardOwnerName.Name = "txtCardOwnerName"
        Me.txtCardOwnerName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCardOwnerName.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtCardOwnerName.SelectedText = ""
        Me.txtCardOwnerName.SelectionLength = 0
        Me.txtCardOwnerName.SelectionStart = 0
        Me.txtCardOwnerName.Size = New System.Drawing.Size(254, 23)
        Me.txtCardOwnerName.Style = MetroFramework.MetroColorStyle.Yellow
        Me.txtCardOwnerName.TabIndex = 9
        Me.txtCardOwnerName.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.txtCardOwnerName.UseSelectable = True
        Me.txtCardOwnerName.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtCardOwnerName.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lblCardOwnerName
        '
        Me.lblCardOwnerName.AutoSize = True
        Me.lblCardOwnerName.Location = New System.Drawing.Point(19, 153)
        Me.lblCardOwnerName.Margin = New System.Windows.Forms.Padding(3, 5, 5, 5)
        Me.lblCardOwnerName.Name = "lblCardOwnerName"
        Me.lblCardOwnerName.Size = New System.Drawing.Size(123, 19)
        Me.lblCardOwnerName.Style = MetroFramework.MetroColorStyle.Yellow
        Me.lblCardOwnerName.TabIndex = 8
        Me.lblCardOwnerName.Text = "Cardholder's Name"
        Me.lblCardOwnerName.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'txtCSCNumber
        '
        '
        '
        '
        Me.txtCSCNumber.CustomButton.Image = Nothing
        Me.txtCSCNumber.CustomButton.Location = New System.Drawing.Point(92, 1)
        Me.txtCSCNumber.CustomButton.Name = ""
        Me.txtCSCNumber.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtCSCNumber.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtCSCNumber.CustomButton.TabIndex = 1
        Me.txtCSCNumber.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtCSCNumber.CustomButton.UseSelectable = True
        Me.txtCSCNumber.CustomButton.Visible = False
        Me.txtCSCNumber.Location = New System.Drawing.Point(19, 187)
        Me.txtCSCNumber.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.txtCSCNumber.MaxLength = 3
        Me.txtCSCNumber.Name = "txtCSCNumber"
        Me.txtCSCNumber.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCSCNumber.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtCSCNumber.SelectedText = ""
        Me.txtCSCNumber.SelectionLength = 0
        Me.txtCSCNumber.SelectionStart = 0
        Me.txtCSCNumber.Size = New System.Drawing.Size(114, 23)
        Me.txtCSCNumber.Style = MetroFramework.MetroColorStyle.Yellow
        Me.txtCSCNumber.TabIndex = 11
        Me.txtCSCNumber.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.txtCSCNumber.UseSelectable = True
        Me.txtCSCNumber.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtCSCNumber.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lblCSCNumber
        '
        Me.lblCSCNumber.AutoSize = True
        Me.lblCSCNumber.Location = New System.Drawing.Point(15, 215)
        Me.lblCSCNumber.Margin = New System.Windows.Forms.Padding(3, 5, 5, 5)
        Me.lblCSCNumber.Name = "lblCSCNumber"
        Me.lblCSCNumber.Size = New System.Drawing.Size(118, 19)
        Me.lblCSCNumber.Style = MetroFramework.MetroColorStyle.Yellow
        Me.lblCSCNumber.TabIndex = 10
        Me.lblCSCNumber.Text = "CSC/CVC Number"
        Me.lblCSCNumber.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'lblExpiryYear
        '
        Me.lblExpiryYear.AutoSize = True
        Me.lblExpiryYear.Location = New System.Drawing.Point(158, 215)
        Me.lblExpiryYear.Margin = New System.Windows.Forms.Padding(3, 5, 5, 0)
        Me.lblExpiryYear.Name = "lblExpiryYear"
        Me.lblExpiryYear.Size = New System.Drawing.Size(74, 19)
        Me.lblExpiryYear.Style = MetroFramework.MetroColorStyle.Yellow
        Me.lblExpiryYear.TabIndex = 12
        Me.lblExpiryYear.Text = "Expiry Year"
        Me.lblExpiryYear.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'txtExpiryYear
        '
        '
        '
        '
        Me.txtExpiryYear.CustomButton.Image = Nothing
        Me.txtExpiryYear.CustomButton.Location = New System.Drawing.Point(92, 1)
        Me.txtExpiryYear.CustomButton.Name = ""
        Me.txtExpiryYear.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtExpiryYear.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtExpiryYear.CustomButton.TabIndex = 1
        Me.txtExpiryYear.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtExpiryYear.CustomButton.UseSelectable = True
        Me.txtExpiryYear.CustomButton.Visible = False
        Me.txtExpiryYear.Location = New System.Drawing.Point(163, 187)
        Me.txtExpiryYear.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.txtExpiryYear.MaxLength = 4
        Me.txtExpiryYear.Name = "txtExpiryYear"
        Me.txtExpiryYear.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtExpiryYear.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtExpiryYear.SelectedText = ""
        Me.txtExpiryYear.SelectionLength = 0
        Me.txtExpiryYear.SelectionStart = 0
        Me.txtExpiryYear.Size = New System.Drawing.Size(114, 23)
        Me.txtExpiryYear.Style = MetroFramework.MetroColorStyle.Yellow
        Me.txtExpiryYear.TabIndex = 13
        Me.txtExpiryYear.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.txtExpiryYear.UseSelectable = True
        Me.txtExpiryYear.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtExpiryYear.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btnAddCard
        '
        Me.btnAddCard.BackColor = System.Drawing.Color.Transparent
        Me.btnAddCard.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.btnAddCard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAddCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddCard.ForeColor = System.Drawing.Color.Gold
        Me.btnAddCard.Location = New System.Drawing.Point(121, 270)
        Me.btnAddCard.Name = "btnAddCard"
        Me.btnAddCard.Size = New System.Drawing.Size(75, 23)
        Me.btnAddCard.TabIndex = 14
        Me.btnAddCard.Text = "Add Card"
        Me.btnAddCard.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Crimson
        Me.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.ForeColor = System.Drawing.Color.Crimson
        Me.btnCancel.Location = New System.Drawing.Point(202, 270)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 15
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'lblCardNumberError
        '
        Me.lblCardNumberError.AutoSize = True
        Me.lblCardNumberError.ForeColor = System.Drawing.Color.Crimson
        Me.lblCardNumberError.Location = New System.Drawing.Point(149, 91)
        Me.lblCardNumberError.Margin = New System.Windows.Forms.Padding(3, 5, 5, 5)
        Me.lblCardNumberError.Name = "lblCardNumberError"
        Me.lblCardNumberError.Size = New System.Drawing.Size(126, 19)
        Me.lblCardNumberError.Style = MetroFramework.MetroColorStyle.Yellow
        Me.lblCardNumberError.TabIndex = 16
        Me.lblCardNumberError.Text = "Invalid card number"
        Me.lblCardNumberError.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.lblCardNumberError.Visible = False
        '
        'lblCardOwnerError
        '
        Me.lblCardOwnerError.AutoSize = True
        Me.lblCardOwnerError.ForeColor = System.Drawing.Color.Crimson
        Me.lblCardOwnerError.Location = New System.Drawing.Point(192, 153)
        Me.lblCardOwnerError.Margin = New System.Windows.Forms.Padding(3, 5, 5, 5)
        Me.lblCardOwnerError.Name = "lblCardOwnerError"
        Me.lblCardOwnerError.Size = New System.Drawing.Size(83, 19)
        Me.lblCardOwnerError.Style = MetroFramework.MetroColorStyle.Yellow
        Me.lblCardOwnerError.TabIndex = 17
        Me.lblCardOwnerError.Text = "Invalid name"
        Me.lblCardOwnerError.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.lblCardOwnerError.Visible = False
        '
        'lblExpiryError
        '
        Me.lblExpiryError.AutoSize = True
        Me.lblExpiryError.ForeColor = System.Drawing.Color.Crimson
        Me.lblExpiryError.Location = New System.Drawing.Point(158, 237)
        Me.lblExpiryError.Margin = New System.Windows.Forms.Padding(3, 3, 5, 5)
        Me.lblExpiryError.Name = "lblExpiryError"
        Me.lblExpiryError.Size = New System.Drawing.Size(75, 19)
        Me.lblExpiryError.Style = MetroFramework.MetroColorStyle.Yellow
        Me.lblExpiryError.TabIndex = 18
        Me.lblExpiryError.Text = "Invalid year"
        Me.lblExpiryError.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.lblExpiryError.Visible = False
        '
        'lblCSCError
        '
        Me.lblCSCError.AutoSize = True
        Me.lblCSCError.ForeColor = System.Drawing.Color.Crimson
        Me.lblCSCError.Location = New System.Drawing.Point(16, 237)
        Me.lblCSCError.Margin = New System.Windows.Forms.Padding(3, 3, 5, 5)
        Me.lblCSCError.Name = "lblCSCError"
        Me.lblCSCError.Size = New System.Drawing.Size(125, 19)
        Me.lblCSCError.Style = MetroFramework.MetroColorStyle.Yellow
        Me.lblCSCError.TabIndex = 19
        Me.lblCSCError.Text = "Invalid CSC number"
        Me.lblCSCError.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.lblCSCError.Visible = False
        '
        'Card
        '
        Me.AcceptButton = Me.btnAddCard
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(300, 316)
        Me.Controls.Add(Me.lblCSCError)
        Me.Controls.Add(Me.lblExpiryError)
        Me.Controls.Add(Me.lblCardOwnerError)
        Me.Controls.Add(Me.lblCardNumberError)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAddCard)
        Me.Controls.Add(Me.txtExpiryYear)
        Me.Controls.Add(Me.lblExpiryYear)
        Me.Controls.Add(Me.txtCSCNumber)
        Me.Controls.Add(Me.lblCSCNumber)
        Me.Controls.Add(Me.txtCardOwnerName)
        Me.Controls.Add(Me.lblCardOwnerName)
        Me.Controls.Add(Me.txtCardNumber)
        Me.Controls.Add(Me.lblCardNumber)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Card"
        Me.Resizable = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Style = MetroFramework.MetroColorStyle.Yellow
        Me.Text = "Card"
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCardNumber As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtCardNumber As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtCardOwnerName As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblCardOwnerName As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtCSCNumber As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblCSCNumber As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblExpiryYear As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtExpiryYear As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnAddCard As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents lblCardNumberError As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblCardOwnerError As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblExpiryError As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblCSCError As MetroFramework.Controls.MetroLabel
End Class
