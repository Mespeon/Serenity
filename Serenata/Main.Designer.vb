<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlMain = New MetroFramework.Controls.MetroPanel()
        Me.tabctrlMain = New MetroFramework.Controls.MetroTabControl()
        Me.tabRegistry = New MetroFramework.Controls.MetroTabPage()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.pnlPaymentMethods = New MetroFramework.Controls.MetroPanel()
        Me.pnlCashEntry = New MetroFramework.Controls.MetroPanel()
        Me.btn20 = New System.Windows.Forms.Button()
        Me.btn50 = New System.Windows.Forms.Button()
        Me.btn500 = New System.Windows.Forms.Button()
        Me.btn100 = New System.Windows.Forms.Button()
        Me.txtCash = New MetroFramework.Controls.MetroTextBox()
        Me.btn1000 = New System.Windows.Forms.Button()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.btnClearPayment = New System.Windows.Forms.Button()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.txtChange = New MetroFramework.Controls.MetroTextBox()
        Me.lblPaymentStatus = New MetroFramework.Controls.MetroLabel()
        Me.rbtnCardMethod = New MetroFramework.Controls.MetroRadioButton()
        Me.rbtnCashMethod = New MetroFramework.Controls.MetroRadioButton()
        Me.lblPaymentMethodsHeader = New MetroFramework.Controls.MetroLabel()
        Me.pnlReservationDetails = New MetroFramework.Controls.MetroPanel()
        Me.btnUpdateTotal = New System.Windows.Forms.Button()
        Me.lblGrandTotal = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.lblActualDaysOfStay = New MetroFramework.Controls.MetroLabel()
        Me.lblDaysofStay = New MetroFramework.Controls.MetroLabel()
        Me.lblActualRoomCost = New MetroFramework.Controls.MetroLabel()
        Me.lblRoomRate = New MetroFramework.Controls.MetroLabel()
        Me.rbtnFamilyRoom = New MetroFramework.Controls.MetroRadioButton()
        Me.rbtnDoubleRoom = New MetroFramework.Controls.MetroRadioButton()
        Me.rbtnSingleRoom = New MetroFramework.Controls.MetroRadioButton()
        Me.lblRoom = New MetroFramework.Controls.MetroLabel()
        Me.cbxRooms = New MetroFramework.Controls.MetroComboBox()
        Me.dtpCheckout = New MetroFramework.Controls.MetroDateTime()
        Me.lblCheckout = New MetroFramework.Controls.MetroLabel()
        Me.dtpArrival = New MetroFramework.Controls.MetroDateTime()
        Me.lblArrival = New MetroFramework.Controls.MetroLabel()
        Me.lblReservationDetailsHeader = New MetroFramework.Controls.MetroLabel()
        Me.pnlCustomerDetails = New MetroFramework.Controls.MetroPanel()
        Me.txtContactNumber = New MetroFramework.Controls.MetroTextBox()
        Me.lblContactNumber = New MetroFramework.Controls.MetroLabel()
        Me.txtAddress = New MetroFramework.Controls.MetroTextBox()
        Me.lblAddress = New MetroFramework.Controls.MetroLabel()
        Me.txtMiddleInitial = New MetroFramework.Controls.MetroTextBox()
        Me.lblMiddleInitial = New MetroFramework.Controls.MetroLabel()
        Me.txtFirstName = New MetroFramework.Controls.MetroTextBox()
        Me.lblFirstName = New MetroFramework.Controls.MetroLabel()
        Me.txtLastName = New MetroFramework.Controls.MetroTextBox()
        Me.lblLastName = New MetroFramework.Controls.MetroLabel()
        Me.customerDetailPanelHeader = New MetroFramework.Controls.MetroLabel()
        Me.tabReservations = New MetroFramework.Controls.MetroTabPage()
        Me.btnValidate = New System.Windows.Forms.Button()
        Me.lblNameError = New System.Windows.Forms.Label()
        Me.lblAddressError = New System.Windows.Forms.Label()
        Me.lblContactError = New System.Windows.Forms.Label()
        Me.lblRoomError = New System.Windows.Forms.Label()
        Me.lblPaymentError = New System.Windows.Forms.Label()
        Me.lblReservationError = New System.Windows.Forms.Label()
        Me.dgvReservations = New MetroFramework.Controls.MetroGrid()
        Me.pnlMain.SuspendLayout()
        Me.tabctrlMain.SuspendLayout()
        Me.tabRegistry.SuspendLayout()
        Me.pnlPaymentMethods.SuspendLayout()
        Me.pnlCashEntry.SuspendLayout()
        Me.pnlReservationDetails.SuspendLayout()
        Me.pnlCustomerDetails.SuspendLayout()
        Me.tabReservations.SuspendLayout()
        CType(Me.dgvReservations, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlMain
        '
        Me.pnlMain.Controls.Add(Me.tabctrlMain)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.HorizontalScrollbarBarColor = True
        Me.pnlMain.HorizontalScrollbarHighlightOnWheel = False
        Me.pnlMain.HorizontalScrollbarSize = 10
        Me.pnlMain.Location = New System.Drawing.Point(20, 60)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(760, 620)
        Me.pnlMain.Style = MetroFramework.MetroColorStyle.Yellow
        Me.pnlMain.TabIndex = 0
        Me.pnlMain.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.pnlMain.VerticalScrollbarBarColor = True
        Me.pnlMain.VerticalScrollbarHighlightOnWheel = False
        Me.pnlMain.VerticalScrollbarSize = 10
        '
        'tabctrlMain
        '
        Me.tabctrlMain.Controls.Add(Me.tabRegistry)
        Me.tabctrlMain.Controls.Add(Me.tabReservations)
        Me.tabctrlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabctrlMain.FontWeight = MetroFramework.MetroTabControlWeight.Regular
        Me.tabctrlMain.Location = New System.Drawing.Point(0, 0)
        Me.tabctrlMain.Name = "tabctrlMain"
        Me.tabctrlMain.SelectedIndex = 0
        Me.tabctrlMain.Size = New System.Drawing.Size(760, 620)
        Me.tabctrlMain.Style = MetroFramework.MetroColorStyle.Yellow
        Me.tabctrlMain.TabIndex = 2
        Me.tabctrlMain.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.tabctrlMain.UseSelectable = True
        '
        'tabRegistry
        '
        Me.tabRegistry.AutoScroll = True
        Me.tabRegistry.Controls.Add(Me.btnValidate)
        Me.tabRegistry.Controls.Add(Me.btnSave)
        Me.tabRegistry.Controls.Add(Me.btnCancel)
        Me.tabRegistry.Controls.Add(Me.pnlPaymentMethods)
        Me.tabRegistry.Controls.Add(Me.pnlReservationDetails)
        Me.tabRegistry.Controls.Add(Me.pnlCustomerDetails)
        Me.tabRegistry.HorizontalScrollbar = True
        Me.tabRegistry.HorizontalScrollbarBarColor = True
        Me.tabRegistry.HorizontalScrollbarHighlightOnWheel = False
        Me.tabRegistry.HorizontalScrollbarSize = 10
        Me.tabRegistry.Location = New System.Drawing.Point(4, 38)
        Me.tabRegistry.Name = "tabRegistry"
        Me.tabRegistry.Size = New System.Drawing.Size(752, 578)
        Me.tabRegistry.Style = MetroFramework.MetroColorStyle.Yellow
        Me.tabRegistry.TabIndex = 0
        Me.tabRegistry.Text = "Registry"
        Me.tabRegistry.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.tabRegistry.UseStyleColors = True
        Me.tabRegistry.VerticalScrollbar = True
        Me.tabRegistry.VerticalScrollbarBarColor = True
        Me.tabRegistry.VerticalScrollbarHighlightOnWheel = False
        Me.tabRegistry.VerticalScrollbarSize = 10
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Transparent
        Me.btnSave.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSave.Enabled = False
        Me.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.ForeColor = System.Drawing.Color.Gold
        Me.btnSave.Location = New System.Drawing.Point(505, 470)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(3, 3, 3, 10)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(244, 46)
        Me.btnSave.TabIndex = 17
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Crimson
        Me.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.ForeColor = System.Drawing.Color.Crimson
        Me.btnCancel.Location = New System.Drawing.Point(505, 529)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(244, 46)
        Me.btnCancel.TabIndex = 16
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'pnlPaymentMethods
        '
        Me.pnlPaymentMethods.Controls.Add(Me.lblPaymentError)
        Me.pnlPaymentMethods.Controls.Add(Me.pnlCashEntry)
        Me.pnlPaymentMethods.Controls.Add(Me.lblPaymentStatus)
        Me.pnlPaymentMethods.Controls.Add(Me.rbtnCardMethod)
        Me.pnlPaymentMethods.Controls.Add(Me.rbtnCashMethod)
        Me.pnlPaymentMethods.Controls.Add(Me.lblPaymentMethodsHeader)
        Me.pnlPaymentMethods.HorizontalScrollbarBarColor = True
        Me.pnlPaymentMethods.HorizontalScrollbarHighlightOnWheel = False
        Me.pnlPaymentMethods.HorizontalScrollbarSize = 10
        Me.pnlPaymentMethods.Location = New System.Drawing.Point(3, 404)
        Me.pnlPaymentMethods.Margin = New System.Windows.Forms.Padding(3, 10, 3, 3)
        Me.pnlPaymentMethods.Name = "pnlPaymentMethods"
        Me.pnlPaymentMethods.Size = New System.Drawing.Size(496, 171)
        Me.pnlPaymentMethods.Style = MetroFramework.MetroColorStyle.Yellow
        Me.pnlPaymentMethods.TabIndex = 5
        Me.pnlPaymentMethods.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.pnlPaymentMethods.VerticalScrollbarBarColor = True
        Me.pnlPaymentMethods.VerticalScrollbarHighlightOnWheel = False
        Me.pnlPaymentMethods.VerticalScrollbarSize = 10
        '
        'pnlCashEntry
        '
        Me.pnlCashEntry.Controls.Add(Me.btn20)
        Me.pnlCashEntry.Controls.Add(Me.btn50)
        Me.pnlCashEntry.Controls.Add(Me.btn500)
        Me.pnlCashEntry.Controls.Add(Me.btn100)
        Me.pnlCashEntry.Controls.Add(Me.txtCash)
        Me.pnlCashEntry.Controls.Add(Me.btn1000)
        Me.pnlCashEntry.Controls.Add(Me.MetroLabel1)
        Me.pnlCashEntry.Controls.Add(Me.btnClearPayment)
        Me.pnlCashEntry.Controls.Add(Me.MetroLabel2)
        Me.pnlCashEntry.Controls.Add(Me.txtChange)
        Me.pnlCashEntry.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlCashEntry.HorizontalScrollbarBarColor = True
        Me.pnlCashEntry.HorizontalScrollbarHighlightOnWheel = False
        Me.pnlCashEntry.HorizontalScrollbarSize = 10
        Me.pnlCashEntry.Location = New System.Drawing.Point(0, 59)
        Me.pnlCashEntry.Name = "pnlCashEntry"
        Me.pnlCashEntry.Size = New System.Drawing.Size(496, 112)
        Me.pnlCashEntry.Style = MetroFramework.MetroColorStyle.Yellow
        Me.pnlCashEntry.TabIndex = 27
        Me.pnlCashEntry.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.pnlCashEntry.VerticalScrollbarBarColor = True
        Me.pnlCashEntry.VerticalScrollbarHighlightOnWheel = False
        Me.pnlCashEntry.VerticalScrollbarSize = 10
        Me.pnlCashEntry.Visible = False
        '
        'btn20
        '
        Me.btn20.BackColor = System.Drawing.Color.Transparent
        Me.btn20.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn20.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed
        Me.btn20.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn20.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn20.ForeColor = System.Drawing.Color.OrangeRed
        Me.btn20.Location = New System.Drawing.Point(376, 81)
        Me.btn20.Name = "btn20"
        Me.btn20.Size = New System.Drawing.Size(85, 28)
        Me.btn20.TabIndex = 27
        Me.btn20.Text = "20"
        Me.btn20.UseVisualStyleBackColor = False
        '
        'btn50
        '
        Me.btn50.BackColor = System.Drawing.Color.Transparent
        Me.btn50.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn50.FlatAppearance.BorderColor = System.Drawing.Color.Crimson
        Me.btn50.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn50.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn50.ForeColor = System.Drawing.Color.Crimson
        Me.btn50.Location = New System.Drawing.Point(285, 81)
        Me.btn50.Name = "btn50"
        Me.btn50.Size = New System.Drawing.Size(85, 28)
        Me.btn50.TabIndex = 26
        Me.btn50.Text = "50"
        Me.btn50.UseVisualStyleBackColor = False
        '
        'btn500
        '
        Me.btn500.BackColor = System.Drawing.Color.Transparent
        Me.btn500.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn500.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.btn500.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn500.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn500.ForeColor = System.Drawing.Color.Gold
        Me.btn500.Location = New System.Drawing.Point(103, 81)
        Me.btn500.Name = "btn500"
        Me.btn500.Size = New System.Drawing.Size(85, 28)
        Me.btn500.TabIndex = 24
        Me.btn500.Text = "500"
        Me.btn500.UseVisualStyleBackColor = False
        '
        'btn100
        '
        Me.btn100.BackColor = System.Drawing.Color.Transparent
        Me.btn100.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn100.FlatAppearance.BorderColor = System.Drawing.Color.MediumVioletRed
        Me.btn100.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn100.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn100.ForeColor = System.Drawing.Color.MediumVioletRed
        Me.btn100.Location = New System.Drawing.Point(194, 81)
        Me.btn100.Name = "btn100"
        Me.btn100.Size = New System.Drawing.Size(85, 28)
        Me.btn100.TabIndex = 25
        Me.btn100.Text = "100"
        Me.btn100.UseVisualStyleBackColor = False
        '
        'txtCash
        '
        '
        '
        '
        Me.txtCash.CustomButton.Image = Nothing
        Me.txtCash.CustomButton.Location = New System.Drawing.Point(140, 1)
        Me.txtCash.CustomButton.Name = ""
        Me.txtCash.CustomButton.Size = New System.Drawing.Size(33, 33)
        Me.txtCash.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtCash.CustomButton.TabIndex = 1
        Me.txtCash.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtCash.CustomButton.UseSelectable = True
        Me.txtCash.CustomButton.Visible = False
        Me.txtCash.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtCash.Lines = New String() {"0"}
        Me.txtCash.Location = New System.Drawing.Point(12, 14)
        Me.txtCash.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.txtCash.MaxLength = 5
        Me.txtCash.Name = "txtCash"
        Me.txtCash.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCash.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtCash.SelectedText = ""
        Me.txtCash.SelectionLength = 0
        Me.txtCash.SelectionStart = 0
        Me.txtCash.Size = New System.Drawing.Size(174, 35)
        Me.txtCash.Style = MetroFramework.MetroColorStyle.Yellow
        Me.txtCash.TabIndex = 19
        Me.txtCash.Text = "0"
        Me.txtCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtCash.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.txtCash.UseSelectable = True
        Me.txtCash.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtCash.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btn1000
        '
        Me.btn1000.BackColor = System.Drawing.Color.Transparent
        Me.btn1000.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn1000.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue
        Me.btn1000.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn1000.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn1000.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.btn1000.Location = New System.Drawing.Point(12, 81)
        Me.btn1000.Name = "btn1000"
        Me.btn1000.Size = New System.Drawing.Size(85, 28)
        Me.btn1000.TabIndex = 23
        Me.btn1000.Text = "1000"
        Me.btn1000.UseVisualStyleBackColor = False
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(9, 54)
        Me.MetroLabel1.Margin = New System.Windows.Forms.Padding(3, 5, 5, 5)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(37, 19)
        Me.MetroLabel1.Style = MetroFramework.MetroColorStyle.Yellow
        Me.MetroLabel1.TabIndex = 20
        Me.MetroLabel1.Text = "Cash"
        Me.MetroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'btnClearPayment
        '
        Me.btnClearPayment.BackColor = System.Drawing.Color.Transparent
        Me.btnClearPayment.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClearPayment.FlatAppearance.BorderColor = System.Drawing.Color.Crimson
        Me.btnClearPayment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnClearPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearPayment.ForeColor = System.Drawing.Color.Crimson
        Me.btnClearPayment.Location = New System.Drawing.Point(389, 14)
        Me.btnClearPayment.Name = "btnClearPayment"
        Me.btnClearPayment.Size = New System.Drawing.Size(85, 35)
        Me.btnClearPayment.TabIndex = 18
        Me.btnClearPayment.Text = "X"
        Me.btnClearPayment.UseVisualStyleBackColor = False
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(204, 54)
        Me.MetroLabel2.Margin = New System.Windows.Forms.Padding(3, 5, 5, 5)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(54, 19)
        Me.MetroLabel2.Style = MetroFramework.MetroColorStyle.Yellow
        Me.MetroLabel2.TabIndex = 21
        Me.MetroLabel2.Text = "Change"
        Me.MetroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'txtChange
        '
        '
        '
        '
        Me.txtChange.CustomButton.Image = Nothing
        Me.txtChange.CustomButton.Location = New System.Drawing.Point(140, 1)
        Me.txtChange.CustomButton.Name = ""
        Me.txtChange.CustomButton.Size = New System.Drawing.Size(33, 33)
        Me.txtChange.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtChange.CustomButton.TabIndex = 1
        Me.txtChange.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtChange.CustomButton.UseSelectable = True
        Me.txtChange.CustomButton.Visible = False
        Me.txtChange.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtChange.Lines = New String() {"0"}
        Me.txtChange.Location = New System.Drawing.Point(209, 14)
        Me.txtChange.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.txtChange.MaxLength = 5
        Me.txtChange.Name = "txtChange"
        Me.txtChange.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtChange.ReadOnly = True
        Me.txtChange.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtChange.SelectedText = ""
        Me.txtChange.SelectionLength = 0
        Me.txtChange.SelectionStart = 0
        Me.txtChange.Size = New System.Drawing.Size(174, 35)
        Me.txtChange.Style = MetroFramework.MetroColorStyle.Yellow
        Me.txtChange.TabIndex = 22
        Me.txtChange.Text = "0"
        Me.txtChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtChange.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.txtChange.UseSelectable = True
        Me.txtChange.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtChange.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lblPaymentStatus
        '
        Me.lblPaymentStatus.AutoSize = True
        Me.lblPaymentStatus.Location = New System.Drawing.Point(133, 32)
        Me.lblPaymentStatus.Margin = New System.Windows.Forms.Padding(3, 5, 5, 5)
        Me.lblPaymentStatus.Name = "lblPaymentStatus"
        Me.lblPaymentStatus.Size = New System.Drawing.Size(162, 19)
        Me.lblPaymentStatus.Style = MetroFramework.MetroColorStyle.Yellow
        Me.lblPaymentStatus.TabIndex = 18
        Me.lblPaymentStatus.Text = "Payment Status goes here."
        Me.lblPaymentStatus.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.lblPaymentStatus.Visible = False
        '
        'rbtnCardMethod
        '
        Me.rbtnCardMethod.AutoSize = True
        Me.rbtnCardMethod.Location = New System.Drawing.Point(75, 35)
        Me.rbtnCardMethod.Margin = New System.Windows.Forms.Padding(20, 3, 3, 3)
        Me.rbtnCardMethod.Name = "rbtnCardMethod"
        Me.rbtnCardMethod.Size = New System.Drawing.Size(48, 15)
        Me.rbtnCardMethod.Style = MetroFramework.MetroColorStyle.Yellow
        Me.rbtnCardMethod.TabIndex = 12
        Me.rbtnCardMethod.Text = "Card"
        Me.rbtnCardMethod.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.rbtnCardMethod.UseSelectable = True
        '
        'rbtnCashMethod
        '
        Me.rbtnCashMethod.AutoSize = True
        Me.rbtnCashMethod.Location = New System.Drawing.Point(3, 35)
        Me.rbtnCashMethod.Margin = New System.Windows.Forms.Padding(3, 10, 3, 3)
        Me.rbtnCashMethod.Name = "rbtnCashMethod"
        Me.rbtnCashMethod.Size = New System.Drawing.Size(49, 15)
        Me.rbtnCashMethod.Style = MetroFramework.MetroColorStyle.Yellow
        Me.rbtnCashMethod.TabIndex = 11
        Me.rbtnCashMethod.Text = "Cash"
        Me.rbtnCashMethod.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.rbtnCashMethod.UseSelectable = True
        '
        'lblPaymentMethodsHeader
        '
        Me.lblPaymentMethodsHeader.AutoSize = True
        Me.lblPaymentMethodsHeader.BackColor = System.Drawing.Color.Transparent
        Me.lblPaymentMethodsHeader.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblPaymentMethodsHeader.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.lblPaymentMethodsHeader.Location = New System.Drawing.Point(0, 0)
        Me.lblPaymentMethodsHeader.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.lblPaymentMethodsHeader.Name = "lblPaymentMethodsHeader"
        Me.lblPaymentMethodsHeader.Size = New System.Drawing.Size(150, 25)
        Me.lblPaymentMethodsHeader.TabIndex = 4
        Me.lblPaymentMethodsHeader.Text = "Payment Details"
        Me.lblPaymentMethodsHeader.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'pnlReservationDetails
        '
        Me.pnlReservationDetails.Controls.Add(Me.lblReservationError)
        Me.pnlReservationDetails.Controls.Add(Me.lblRoomError)
        Me.pnlReservationDetails.Controls.Add(Me.btnUpdateTotal)
        Me.pnlReservationDetails.Controls.Add(Me.lblGrandTotal)
        Me.pnlReservationDetails.Controls.Add(Me.MetroLabel3)
        Me.pnlReservationDetails.Controls.Add(Me.lblActualDaysOfStay)
        Me.pnlReservationDetails.Controls.Add(Me.lblDaysofStay)
        Me.pnlReservationDetails.Controls.Add(Me.lblActualRoomCost)
        Me.pnlReservationDetails.Controls.Add(Me.lblRoomRate)
        Me.pnlReservationDetails.Controls.Add(Me.rbtnFamilyRoom)
        Me.pnlReservationDetails.Controls.Add(Me.rbtnDoubleRoom)
        Me.pnlReservationDetails.Controls.Add(Me.rbtnSingleRoom)
        Me.pnlReservationDetails.Controls.Add(Me.lblRoom)
        Me.pnlReservationDetails.Controls.Add(Me.cbxRooms)
        Me.pnlReservationDetails.Controls.Add(Me.dtpCheckout)
        Me.pnlReservationDetails.Controls.Add(Me.lblCheckout)
        Me.pnlReservationDetails.Controls.Add(Me.dtpArrival)
        Me.pnlReservationDetails.Controls.Add(Me.lblArrival)
        Me.pnlReservationDetails.Controls.Add(Me.lblReservationDetailsHeader)
        Me.pnlReservationDetails.HorizontalScrollbarBarColor = True
        Me.pnlReservationDetails.HorizontalScrollbarHighlightOnWheel = False
        Me.pnlReservationDetails.HorizontalScrollbarSize = 10
        Me.pnlReservationDetails.Location = New System.Drawing.Point(3, 224)
        Me.pnlReservationDetails.Margin = New System.Windows.Forms.Padding(3, 10, 3, 3)
        Me.pnlReservationDetails.Name = "pnlReservationDetails"
        Me.pnlReservationDetails.Size = New System.Drawing.Size(727, 174)
        Me.pnlReservationDetails.Style = MetroFramework.MetroColorStyle.Yellow
        Me.pnlReservationDetails.TabIndex = 4
        Me.pnlReservationDetails.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.pnlReservationDetails.VerticalScrollbarBarColor = True
        Me.pnlReservationDetails.VerticalScrollbarHighlightOnWheel = False
        Me.pnlReservationDetails.VerticalScrollbarSize = 10
        '
        'btnUpdateTotal
        '
        Me.btnUpdateTotal.BackColor = System.Drawing.Color.Transparent
        Me.btnUpdateTotal.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnUpdateTotal.FlatAppearance.BorderColor = System.Drawing.Color.MediumSpringGreen
        Me.btnUpdateTotal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnUpdateTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdateTotal.ForeColor = System.Drawing.Color.MediumSpringGreen
        Me.btnUpdateTotal.Location = New System.Drawing.Point(570, 103)
        Me.btnUpdateTotal.Name = "btnUpdateTotal"
        Me.btnUpdateTotal.Size = New System.Drawing.Size(129, 39)
        Me.btnUpdateTotal.TabIndex = 24
        Me.btnUpdateTotal.Text = "Update Total"
        Me.btnUpdateTotal.UseVisualStyleBackColor = False
        '
        'lblGrandTotal
        '
        Me.lblGrandTotal.AutoSize = True
        Me.lblGrandTotal.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblGrandTotal.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.lblGrandTotal.Location = New System.Drawing.Point(570, 35)
        Me.lblGrandTotal.Margin = New System.Windows.Forms.Padding(3, 5, 5, 5)
        Me.lblGrandTotal.Name = "lblGrandTotal"
        Me.lblGrandTotal.Size = New System.Drawing.Size(22, 25)
        Me.lblGrandTotal.Style = MetroFramework.MetroColorStyle.Yellow
        Me.lblGrandTotal.TabIndex = 19
        Me.lblGrandTotal.Text = "0"
        Me.lblGrandTotal.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(570, 69)
        Me.MetroLabel3.Margin = New System.Windows.Forms.Padding(3, 5, 5, 5)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(76, 19)
        Me.MetroLabel3.Style = MetroFramework.MetroColorStyle.Yellow
        Me.MetroLabel3.TabIndex = 18
        Me.MetroLabel3.Text = "Grand Total"
        Me.MetroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'lblActualDaysOfStay
        '
        Me.lblActualDaysOfStay.AutoSize = True
        Me.lblActualDaysOfStay.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblActualDaysOfStay.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.lblActualDaysOfStay.Location = New System.Drawing.Point(392, 35)
        Me.lblActualDaysOfStay.Margin = New System.Windows.Forms.Padding(3, 5, 5, 5)
        Me.lblActualDaysOfStay.Name = "lblActualDaysOfStay"
        Me.lblActualDaysOfStay.Size = New System.Drawing.Size(22, 25)
        Me.lblActualDaysOfStay.Style = MetroFramework.MetroColorStyle.Yellow
        Me.lblActualDaysOfStay.TabIndex = 17
        Me.lblActualDaysOfStay.Text = "0"
        Me.lblActualDaysOfStay.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'lblDaysofStay
        '
        Me.lblDaysofStay.AutoSize = True
        Me.lblDaysofStay.Location = New System.Drawing.Point(392, 69)
        Me.lblDaysofStay.Margin = New System.Windows.Forms.Padding(3, 5, 5, 5)
        Me.lblDaysofStay.Name = "lblDaysofStay"
        Me.lblDaysofStay.Size = New System.Drawing.Size(85, 19)
        Me.lblDaysofStay.Style = MetroFramework.MetroColorStyle.Yellow
        Me.lblDaysofStay.TabIndex = 16
        Me.lblDaysofStay.Text = "Day/s of Stay"
        Me.lblDaysofStay.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'lblActualRoomCost
        '
        Me.lblActualRoomCost.AutoSize = True
        Me.lblActualRoomCost.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblActualRoomCost.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.lblActualRoomCost.Location = New System.Drawing.Point(392, 103)
        Me.lblActualRoomCost.Margin = New System.Windows.Forms.Padding(3, 5, 5, 5)
        Me.lblActualRoomCost.Name = "lblActualRoomCost"
        Me.lblActualRoomCost.Size = New System.Drawing.Size(22, 25)
        Me.lblActualRoomCost.Style = MetroFramework.MetroColorStyle.Yellow
        Me.lblActualRoomCost.TabIndex = 15
        Me.lblActualRoomCost.Text = "0"
        Me.lblActualRoomCost.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'lblRoomRate
        '
        Me.lblRoomRate.AutoSize = True
        Me.lblRoomRate.Location = New System.Drawing.Point(392, 137)
        Me.lblRoomRate.Margin = New System.Windows.Forms.Padding(3, 5, 5, 5)
        Me.lblRoomRate.Name = "lblRoomRate"
        Me.lblRoomRate.Size = New System.Drawing.Size(75, 19)
        Me.lblRoomRate.Style = MetroFramework.MetroColorStyle.Yellow
        Me.lblRoomRate.TabIndex = 14
        Me.lblRoomRate.Text = "Room Rate"
        Me.lblRoomRate.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'rbtnFamilyRoom
        '
        Me.rbtnFamilyRoom.AutoSize = True
        Me.rbtnFamilyRoom.Location = New System.Drawing.Point(3, 145)
        Me.rbtnFamilyRoom.Name = "rbtnFamilyRoom"
        Me.rbtnFamilyRoom.Size = New System.Drawing.Size(93, 15)
        Me.rbtnFamilyRoom.Style = MetroFramework.MetroColorStyle.Yellow
        Me.rbtnFamilyRoom.TabIndex = 13
        Me.rbtnFamilyRoom.Text = "Family Room"
        Me.rbtnFamilyRoom.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.rbtnFamilyRoom.UseSelectable = True
        '
        'rbtnDoubleRoom
        '
        Me.rbtnDoubleRoom.AutoSize = True
        Me.rbtnDoubleRoom.Location = New System.Drawing.Point(3, 124)
        Me.rbtnDoubleRoom.Name = "rbtnDoubleRoom"
        Me.rbtnDoubleRoom.Size = New System.Drawing.Size(96, 15)
        Me.rbtnDoubleRoom.Style = MetroFramework.MetroColorStyle.Yellow
        Me.rbtnDoubleRoom.TabIndex = 12
        Me.rbtnDoubleRoom.Text = "Double Room"
        Me.rbtnDoubleRoom.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.rbtnDoubleRoom.UseSelectable = True
        '
        'rbtnSingleRoom
        '
        Me.rbtnSingleRoom.AutoSize = True
        Me.rbtnSingleRoom.Location = New System.Drawing.Point(3, 103)
        Me.rbtnSingleRoom.Margin = New System.Windows.Forms.Padding(3, 10, 3, 3)
        Me.rbtnSingleRoom.Name = "rbtnSingleRoom"
        Me.rbtnSingleRoom.Size = New System.Drawing.Size(90, 15)
        Me.rbtnSingleRoom.Style = MetroFramework.MetroColorStyle.Yellow
        Me.rbtnSingleRoom.TabIndex = 11
        Me.rbtnSingleRoom.Text = "Single Room"
        Me.rbtnSingleRoom.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.rbtnSingleRoom.UseSelectable = True
        '
        'lblRoom
        '
        Me.lblRoom.AutoSize = True
        Me.lblRoom.Location = New System.Drawing.Point(128, 137)
        Me.lblRoom.Margin = New System.Windows.Forms.Padding(3, 5, 5, 5)
        Me.lblRoom.Name = "lblRoom"
        Me.lblRoom.Size = New System.Drawing.Size(45, 19)
        Me.lblRoom.Style = MetroFramework.MetroColorStyle.Yellow
        Me.lblRoom.TabIndex = 10
        Me.lblRoom.Text = "Room"
        Me.lblRoom.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'cbxRooms
        '
        Me.cbxRooms.FormattingEnabled = True
        Me.cbxRooms.ItemHeight = 23
        Me.cbxRooms.Items.AddRange(New Object() {" "})
        Me.cbxRooms.Location = New System.Drawing.Point(133, 103)
        Me.cbxRooms.Margin = New System.Windows.Forms.Padding(20, 3, 3, 0)
        Me.cbxRooms.Name = "cbxRooms"
        Me.cbxRooms.Size = New System.Drawing.Size(241, 29)
        Me.cbxRooms.Style = MetroFramework.MetroColorStyle.Yellow
        Me.cbxRooms.TabIndex = 9
        Me.cbxRooms.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.cbxRooms.UseSelectable = True
        '
        'dtpCheckout
        '
        Me.dtpCheckout.Location = New System.Drawing.Point(200, 35)
        Me.dtpCheckout.Margin = New System.Windows.Forms.Padding(20, 10, 3, 0)
        Me.dtpCheckout.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtpCheckout.Name = "dtpCheckout"
        Me.dtpCheckout.Size = New System.Drawing.Size(174, 29)
        Me.dtpCheckout.Style = MetroFramework.MetroColorStyle.Yellow
        Me.dtpCheckout.TabIndex = 8
        Me.dtpCheckout.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'lblCheckout
        '
        Me.lblCheckout.AutoSize = True
        Me.lblCheckout.Location = New System.Drawing.Point(195, 69)
        Me.lblCheckout.Margin = New System.Windows.Forms.Padding(3, 5, 5, 5)
        Me.lblCheckout.Name = "lblCheckout"
        Me.lblCheckout.Size = New System.Drawing.Size(94, 19)
        Me.lblCheckout.Style = MetroFramework.MetroColorStyle.Yellow
        Me.lblCheckout.TabIndex = 7
        Me.lblCheckout.Text = "Checkout Date"
        Me.lblCheckout.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'dtpArrival
        '
        Me.dtpArrival.Location = New System.Drawing.Point(3, 35)
        Me.dtpArrival.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.dtpArrival.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtpArrival.Name = "dtpArrival"
        Me.dtpArrival.Size = New System.Drawing.Size(174, 29)
        Me.dtpArrival.Style = MetroFramework.MetroColorStyle.Yellow
        Me.dtpArrival.TabIndex = 6
        Me.dtpArrival.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'lblArrival
        '
        Me.lblArrival.AutoSize = True
        Me.lblArrival.Location = New System.Drawing.Point(0, 69)
        Me.lblArrival.Margin = New System.Windows.Forms.Padding(3, 5, 5, 5)
        Me.lblArrival.Name = "lblArrival"
        Me.lblArrival.Size = New System.Drawing.Size(78, 19)
        Me.lblArrival.Style = MetroFramework.MetroColorStyle.Yellow
        Me.lblArrival.TabIndex = 5
        Me.lblArrival.Text = "Arrival Date"
        Me.lblArrival.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'lblReservationDetailsHeader
        '
        Me.lblReservationDetailsHeader.AutoSize = True
        Me.lblReservationDetailsHeader.BackColor = System.Drawing.Color.Transparent
        Me.lblReservationDetailsHeader.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblReservationDetailsHeader.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.lblReservationDetailsHeader.Location = New System.Drawing.Point(0, 0)
        Me.lblReservationDetailsHeader.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.lblReservationDetailsHeader.Name = "lblReservationDetailsHeader"
        Me.lblReservationDetailsHeader.Size = New System.Drawing.Size(177, 25)
        Me.lblReservationDetailsHeader.TabIndex = 4
        Me.lblReservationDetailsHeader.Text = "Reservation Details"
        Me.lblReservationDetailsHeader.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'pnlCustomerDetails
        '
        Me.pnlCustomerDetails.Controls.Add(Me.lblContactError)
        Me.pnlCustomerDetails.Controls.Add(Me.lblAddressError)
        Me.pnlCustomerDetails.Controls.Add(Me.lblNameError)
        Me.pnlCustomerDetails.Controls.Add(Me.txtContactNumber)
        Me.pnlCustomerDetails.Controls.Add(Me.lblContactNumber)
        Me.pnlCustomerDetails.Controls.Add(Me.txtAddress)
        Me.pnlCustomerDetails.Controls.Add(Me.lblAddress)
        Me.pnlCustomerDetails.Controls.Add(Me.txtMiddleInitial)
        Me.pnlCustomerDetails.Controls.Add(Me.lblMiddleInitial)
        Me.pnlCustomerDetails.Controls.Add(Me.txtFirstName)
        Me.pnlCustomerDetails.Controls.Add(Me.lblFirstName)
        Me.pnlCustomerDetails.Controls.Add(Me.txtLastName)
        Me.pnlCustomerDetails.Controls.Add(Me.lblLastName)
        Me.pnlCustomerDetails.Controls.Add(Me.customerDetailPanelHeader)
        Me.pnlCustomerDetails.HorizontalScrollbarBarColor = True
        Me.pnlCustomerDetails.HorizontalScrollbarHighlightOnWheel = False
        Me.pnlCustomerDetails.HorizontalScrollbarSize = 10
        Me.pnlCustomerDetails.Location = New System.Drawing.Point(3, 10)
        Me.pnlCustomerDetails.Margin = New System.Windows.Forms.Padding(3, 10, 3, 3)
        Me.pnlCustomerDetails.Name = "pnlCustomerDetails"
        Me.pnlCustomerDetails.Size = New System.Drawing.Size(727, 209)
        Me.pnlCustomerDetails.Style = MetroFramework.MetroColorStyle.Yellow
        Me.pnlCustomerDetails.TabIndex = 3
        Me.pnlCustomerDetails.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.pnlCustomerDetails.VerticalScrollbarBarColor = True
        Me.pnlCustomerDetails.VerticalScrollbarHighlightOnWheel = False
        Me.pnlCustomerDetails.VerticalScrollbarSize = 10
        '
        'txtContactNumber
        '
        '
        '
        '
        Me.txtContactNumber.CustomButton.Image = Nothing
        Me.txtContactNumber.CustomButton.Location = New System.Drawing.Point(135, 1)
        Me.txtContactNumber.CustomButton.Name = ""
        Me.txtContactNumber.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtContactNumber.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtContactNumber.CustomButton.TabIndex = 1
        Me.txtContactNumber.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtContactNumber.CustomButton.UseSelectable = True
        Me.txtContactNumber.CustomButton.Visible = False
        Me.txtContactNumber.Lines = New String(-1) {}
        Me.txtContactNumber.Location = New System.Drawing.Point(467, 97)
        Me.txtContactNumber.Margin = New System.Windows.Forms.Padding(20, 10, 3, 0)
        Me.txtContactNumber.MaxLength = 11
        Me.txtContactNumber.Name = "txtContactNumber"
        Me.txtContactNumber.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtContactNumber.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtContactNumber.SelectedText = ""
        Me.txtContactNumber.SelectionLength = 0
        Me.txtContactNumber.SelectionStart = 0
        Me.txtContactNumber.Size = New System.Drawing.Size(157, 23)
        Me.txtContactNumber.Style = MetroFramework.MetroColorStyle.Yellow
        Me.txtContactNumber.TabIndex = 14
        Me.txtContactNumber.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.txtContactNumber.UseSelectable = True
        Me.txtContactNumber.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtContactNumber.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lblContactNumber
        '
        Me.lblContactNumber.AutoSize = True
        Me.lblContactNumber.Location = New System.Drawing.Point(464, 125)
        Me.lblContactNumber.Margin = New System.Windows.Forms.Padding(3, 5, 5, 5)
        Me.lblContactNumber.Name = "lblContactNumber"
        Me.lblContactNumber.Size = New System.Drawing.Size(107, 19)
        Me.lblContactNumber.Style = MetroFramework.MetroColorStyle.Yellow
        Me.lblContactNumber.TabIndex = 13
        Me.lblContactNumber.Text = "Contact Number"
        Me.lblContactNumber.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'txtAddress
        '
        '
        '
        '
        Me.txtAddress.CustomButton.Image = Nothing
        Me.txtAddress.CustomButton.Location = New System.Drawing.Point(361, 1)
        Me.txtAddress.CustomButton.Name = ""
        Me.txtAddress.CustomButton.Size = New System.Drawing.Size(79, 79)
        Me.txtAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtAddress.CustomButton.TabIndex = 1
        Me.txtAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtAddress.CustomButton.UseSelectable = True
        Me.txtAddress.CustomButton.Visible = False
        Me.txtAddress.Lines = New String(-1) {}
        Me.txtAddress.Location = New System.Drawing.Point(3, 97)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(20, 10, 3, 0)
        Me.txtAddress.MaxLength = 500
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAddress.SelectedText = ""
        Me.txtAddress.SelectionLength = 0
        Me.txtAddress.SelectionStart = 0
        Me.txtAddress.Size = New System.Drawing.Size(441, 81)
        Me.txtAddress.Style = MetroFramework.MetroColorStyle.Yellow
        Me.txtAddress.TabIndex = 12
        Me.txtAddress.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.txtAddress.UseSelectable = True
        Me.txtAddress.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtAddress.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(0, 183)
        Me.lblAddress.Margin = New System.Windows.Forms.Padding(3, 5, 5, 5)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(56, 19)
        Me.lblAddress.Style = MetroFramework.MetroColorStyle.Yellow
        Me.lblAddress.TabIndex = 11
        Me.lblAddress.Text = "Address"
        Me.lblAddress.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'txtMiddleInitial
        '
        '
        '
        '
        Me.txtMiddleInitial.CustomButton.Image = Nothing
        Me.txtMiddleInitial.CustomButton.Location = New System.Drawing.Point(59, 1)
        Me.txtMiddleInitial.CustomButton.Name = ""
        Me.txtMiddleInitial.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtMiddleInitial.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtMiddleInitial.CustomButton.TabIndex = 1
        Me.txtMiddleInitial.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtMiddleInitial.CustomButton.UseSelectable = True
        Me.txtMiddleInitial.CustomButton.Visible = False
        Me.txtMiddleInitial.Lines = New String(-1) {}
        Me.txtMiddleInitial.Location = New System.Drawing.Point(363, 35)
        Me.txtMiddleInitial.Margin = New System.Windows.Forms.Padding(20, 10, 3, 0)
        Me.txtMiddleInitial.MaxLength = 2
        Me.txtMiddleInitial.Name = "txtMiddleInitial"
        Me.txtMiddleInitial.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMiddleInitial.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtMiddleInitial.SelectedText = ""
        Me.txtMiddleInitial.SelectionLength = 0
        Me.txtMiddleInitial.SelectionStart = 0
        Me.txtMiddleInitial.Size = New System.Drawing.Size(81, 23)
        Me.txtMiddleInitial.Style = MetroFramework.MetroColorStyle.Yellow
        Me.txtMiddleInitial.TabIndex = 10
        Me.txtMiddleInitial.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.txtMiddleInitial.UseSelectable = True
        Me.txtMiddleInitial.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtMiddleInitial.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lblMiddleInitial
        '
        Me.lblMiddleInitial.AutoSize = True
        Me.lblMiddleInitial.Location = New System.Drawing.Point(360, 63)
        Me.lblMiddleInitial.Margin = New System.Windows.Forms.Padding(3, 5, 5, 5)
        Me.lblMiddleInitial.Name = "lblMiddleInitial"
        Me.lblMiddleInitial.Size = New System.Drawing.Size(84, 19)
        Me.lblMiddleInitial.Style = MetroFramework.MetroColorStyle.Yellow
        Me.lblMiddleInitial.TabIndex = 9
        Me.lblMiddleInitial.Text = "Middle Initial"
        Me.lblMiddleInitial.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'txtFirstName
        '
        '
        '
        '
        Me.txtFirstName.CustomButton.Image = Nothing
        Me.txtFirstName.CustomButton.Location = New System.Drawing.Point(135, 1)
        Me.txtFirstName.CustomButton.Name = ""
        Me.txtFirstName.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtFirstName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtFirstName.CustomButton.TabIndex = 1
        Me.txtFirstName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtFirstName.CustomButton.UseSelectable = True
        Me.txtFirstName.CustomButton.Visible = False
        Me.txtFirstName.Lines = New String(-1) {}
        Me.txtFirstName.Location = New System.Drawing.Point(183, 35)
        Me.txtFirstName.Margin = New System.Windows.Forms.Padding(20, 10, 3, 0)
        Me.txtFirstName.MaxLength = 30
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFirstName.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtFirstName.SelectedText = ""
        Me.txtFirstName.SelectionLength = 0
        Me.txtFirstName.SelectionStart = 0
        Me.txtFirstName.Size = New System.Drawing.Size(157, 23)
        Me.txtFirstName.Style = MetroFramework.MetroColorStyle.Yellow
        Me.txtFirstName.TabIndex = 8
        Me.txtFirstName.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.txtFirstName.UseSelectable = True
        Me.txtFirstName.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtFirstName.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(180, 63)
        Me.lblFirstName.Margin = New System.Windows.Forms.Padding(3, 5, 5, 5)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(73, 19)
        Me.lblFirstName.Style = MetroFramework.MetroColorStyle.Yellow
        Me.lblFirstName.TabIndex = 7
        Me.lblFirstName.Text = "First Name"
        Me.lblFirstName.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'txtLastName
        '
        '
        '
        '
        Me.txtLastName.CustomButton.Image = Nothing
        Me.txtLastName.CustomButton.Location = New System.Drawing.Point(135, 1)
        Me.txtLastName.CustomButton.Name = ""
        Me.txtLastName.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtLastName.CustomButton.Style = MetroFramework.MetroColorStyle.Yellow
        Me.txtLastName.CustomButton.TabIndex = 1
        Me.txtLastName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.txtLastName.CustomButton.UseSelectable = True
        Me.txtLastName.CustomButton.Visible = False
        Me.txtLastName.Lines = New String(-1) {}
        Me.txtLastName.Location = New System.Drawing.Point(3, 35)
        Me.txtLastName.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.txtLastName.MaxLength = 30
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLastName.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtLastName.SelectedText = ""
        Me.txtLastName.SelectionLength = 0
        Me.txtLastName.SelectionStart = 0
        Me.txtLastName.ShowClearButton = True
        Me.txtLastName.Size = New System.Drawing.Size(157, 23)
        Me.txtLastName.Style = MetroFramework.MetroColorStyle.Yellow
        Me.txtLastName.TabIndex = 6
        Me.txtLastName.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.txtLastName.UseSelectable = True
        Me.txtLastName.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtLastName.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(0, 63)
        Me.lblLastName.Margin = New System.Windows.Forms.Padding(3, 5, 5, 5)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(71, 19)
        Me.lblLastName.Style = MetroFramework.MetroColorStyle.Yellow
        Me.lblLastName.TabIndex = 5
        Me.lblLastName.Text = "Last Name"
        Me.lblLastName.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'customerDetailPanelHeader
        '
        Me.customerDetailPanelHeader.AutoSize = True
        Me.customerDetailPanelHeader.BackColor = System.Drawing.Color.Transparent
        Me.customerDetailPanelHeader.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.customerDetailPanelHeader.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.customerDetailPanelHeader.Location = New System.Drawing.Point(0, 0)
        Me.customerDetailPanelHeader.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.customerDetailPanelHeader.Name = "customerDetailPanelHeader"
        Me.customerDetailPanelHeader.Size = New System.Drawing.Size(156, 25)
        Me.customerDetailPanelHeader.TabIndex = 4
        Me.customerDetailPanelHeader.Text = "Customer Details"
        Me.customerDetailPanelHeader.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'tabReservations
        '
        Me.tabReservations.AutoScroll = True
        Me.tabReservations.Controls.Add(Me.dgvReservations)
        Me.tabReservations.HorizontalScrollbar = True
        Me.tabReservations.HorizontalScrollbarBarColor = True
        Me.tabReservations.HorizontalScrollbarHighlightOnWheel = False
        Me.tabReservations.HorizontalScrollbarSize = 10
        Me.tabReservations.Location = New System.Drawing.Point(4, 38)
        Me.tabReservations.Name = "tabReservations"
        Me.tabReservations.Size = New System.Drawing.Size(752, 578)
        Me.tabReservations.Style = MetroFramework.MetroColorStyle.Yellow
        Me.tabReservations.TabIndex = 1
        Me.tabReservations.Text = "Reservations"
        Me.tabReservations.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.tabReservations.VerticalScrollbar = True
        Me.tabReservations.VerticalScrollbarBarColor = True
        Me.tabReservations.VerticalScrollbarHighlightOnWheel = False
        Me.tabReservations.VerticalScrollbarSize = 10
        '
        'btnValidate
        '
        Me.btnValidate.BackColor = System.Drawing.Color.Transparent
        Me.btnValidate.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnValidate.FlatAppearance.BorderColor = System.Drawing.Color.MediumSpringGreen
        Me.btnValidate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnValidate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnValidate.ForeColor = System.Drawing.Color.MediumSpringGreen
        Me.btnValidate.Location = New System.Drawing.Point(505, 411)
        Me.btnValidate.Margin = New System.Windows.Forms.Padding(3, 3, 3, 10)
        Me.btnValidate.Name = "btnValidate"
        Me.btnValidate.Size = New System.Drawing.Size(244, 46)
        Me.btnValidate.TabIndex = 18
        Me.btnValidate.Text = "Validate Form"
        Me.btnValidate.UseVisualStyleBackColor = False
        '
        'lblNameError
        '
        Me.lblNameError.AutoSize = True
        Me.lblNameError.BackColor = System.Drawing.Color.Transparent
        Me.lblNameError.ForeColor = System.Drawing.Color.Crimson
        Me.lblNameError.Location = New System.Drawing.Point(464, 42)
        Me.lblNameError.Name = "lblNameError"
        Me.lblNameError.Size = New System.Drawing.Size(130, 16)
        Me.lblNameError.TabIndex = 15
        Me.lblNameError.Text = "Please check name."
        Me.lblNameError.Visible = False
        '
        'lblAddressError
        '
        Me.lblAddressError.AutoSize = True
        Me.lblAddressError.BackColor = System.Drawing.Color.Transparent
        Me.lblAddressError.ForeColor = System.Drawing.Color.Crimson
        Me.lblAddressError.Location = New System.Drawing.Point(64, 186)
        Me.lblAddressError.Name = "lblAddressError"
        Me.lblAddressError.Size = New System.Drawing.Size(146, 16)
        Me.lblAddressError.TabIndex = 16
        Me.lblAddressError.Text = "Please check address."
        Me.lblAddressError.Visible = False
        '
        'lblContactError
        '
        Me.lblContactError.AutoSize = True
        Me.lblContactError.BackColor = System.Drawing.Color.Transparent
        Me.lblContactError.ForeColor = System.Drawing.Color.Crimson
        Me.lblContactError.Location = New System.Drawing.Point(464, 149)
        Me.lblContactError.Name = "lblContactError"
        Me.lblContactError.Size = New System.Drawing.Size(187, 16)
        Me.lblContactError.TabIndex = 17
        Me.lblContactError.Text = "Please check contact number."
        Me.lblContactError.Visible = False
        '
        'lblRoomError
        '
        Me.lblRoomError.AutoSize = True
        Me.lblRoomError.BackColor = System.Drawing.Color.Transparent
        Me.lblRoomError.ForeColor = System.Drawing.Color.Crimson
        Me.lblRoomError.Location = New System.Drawing.Point(181, 140)
        Me.lblRoomError.Name = "lblRoomError"
        Me.lblRoomError.Size = New System.Drawing.Size(135, 16)
        Me.lblRoomError.TabIndex = 25
        Me.lblRoomError.Text = "Please select a room"
        Me.lblRoomError.Visible = False
        '
        'lblPaymentError
        '
        Me.lblPaymentError.AutoSize = True
        Me.lblPaymentError.BackColor = System.Drawing.Color.Transparent
        Me.lblPaymentError.ForeColor = System.Drawing.Color.Crimson
        Me.lblPaymentError.Location = New System.Drawing.Point(156, 11)
        Me.lblPaymentError.Name = "lblPaymentError"
        Me.lblPaymentError.Size = New System.Drawing.Size(172, 16)
        Me.lblPaymentError.TabIndex = 26
        Me.lblPaymentError.Text = "Incomplete payment details"
        Me.lblPaymentError.Visible = False
        '
        'lblReservationError
        '
        Me.lblReservationError.AutoSize = True
        Me.lblReservationError.BackColor = System.Drawing.Color.Transparent
        Me.lblReservationError.ForeColor = System.Drawing.Color.Crimson
        Me.lblReservationError.Location = New System.Drawing.Point(183, 9)
        Me.lblReservationError.Name = "lblReservationError"
        Me.lblReservationError.Size = New System.Drawing.Size(187, 16)
        Me.lblReservationError.TabIndex = 26
        Me.lblReservationError.Text = "Incomplete reservation details"
        Me.lblReservationError.Visible = False
        '
        'dgvReservations
        '
        Me.dgvReservations.AllowUserToAddRows = False
        Me.dgvReservations.AllowUserToDeleteRows = False
        Me.dgvReservations.AllowUserToResizeRows = False
        Me.dgvReservations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvReservations.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.dgvReservations.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvReservations.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvReservations.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(37, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(57, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvReservations.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(57, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvReservations.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvReservations.EnableHeadersVisualStyles = False
        Me.dgvReservations.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgvReservations.GridColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.dgvReservations.Location = New System.Drawing.Point(3, 3)
        Me.dgvReservations.MultiSelect = False
        Me.dgvReservations.Name = "dgvReservations"
        Me.dgvReservations.ReadOnly = True
        Me.dgvReservations.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(37, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(57, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvReservations.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvReservations.RowHeadersVisible = False
        Me.dgvReservations.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvReservations.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvReservations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvReservations.Size = New System.Drawing.Size(746, 466)
        Me.dgvReservations.Style = MetroFramework.MetroColorStyle.Yellow
        Me.dgvReservations.TabIndex = 2
        Me.dgvReservations.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'Main
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(800, 700)
        Me.Controls.Add(Me.pnlMain)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Main"
        Me.Resizable = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Yellow
        Me.Text = "Serenata Reservations"
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.pnlMain.ResumeLayout(False)
        Me.tabctrlMain.ResumeLayout(False)
        Me.tabRegistry.ResumeLayout(False)
        Me.pnlPaymentMethods.ResumeLayout(False)
        Me.pnlPaymentMethods.PerformLayout()
        Me.pnlCashEntry.ResumeLayout(False)
        Me.pnlCashEntry.PerformLayout()
        Me.pnlReservationDetails.ResumeLayout(False)
        Me.pnlReservationDetails.PerformLayout()
        Me.pnlCustomerDetails.ResumeLayout(False)
        Me.pnlCustomerDetails.PerformLayout()
        Me.tabReservations.ResumeLayout(False)
        CType(Me.dgvReservations, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlMain As MetroFramework.Controls.MetroPanel
    Friend WithEvents tabctrlMain As MetroFramework.Controls.MetroTabControl
    Friend WithEvents tabRegistry As MetroFramework.Controls.MetroTabPage
    Friend WithEvents tabReservations As MetroFramework.Controls.MetroTabPage
    Friend WithEvents pnlCustomerDetails As MetroFramework.Controls.MetroPanel
    Friend WithEvents customerDetailPanelHeader As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblLastName As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtLastName As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtFirstName As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblFirstName As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtMiddleInitial As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblMiddleInitial As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtAddress As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblAddress As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtContactNumber As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblContactNumber As MetroFramework.Controls.MetroLabel
    Friend WithEvents pnlReservationDetails As MetroFramework.Controls.MetroPanel
    Friend WithEvents lblArrival As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblReservationDetailsHeader As MetroFramework.Controls.MetroLabel
    Friend WithEvents dtpArrival As MetroFramework.Controls.MetroDateTime
    Friend WithEvents dtpCheckout As MetroFramework.Controls.MetroDateTime
    Friend WithEvents lblCheckout As MetroFramework.Controls.MetroLabel
    Friend WithEvents cbxRooms As MetroFramework.Controls.MetroComboBox
    Friend WithEvents lblRoom As MetroFramework.Controls.MetroLabel
    Friend WithEvents rbtnFamilyRoom As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents rbtnDoubleRoom As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents rbtnSingleRoom As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents lblActualRoomCost As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblRoomRate As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblActualDaysOfStay As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblDaysofStay As MetroFramework.Controls.MetroLabel
    Friend WithEvents pnlPaymentMethods As MetroFramework.Controls.MetroPanel
    Friend WithEvents rbtnCardMethod As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents rbtnCashMethod As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents lblPaymentMethodsHeader As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblPaymentStatus As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents txtCash As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtChange As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnClearPayment As Button
    Friend WithEvents btn50 As Button
    Friend WithEvents btn100 As Button
    Friend WithEvents btn500 As Button
    Friend WithEvents btn1000 As Button
    Friend WithEvents pnlCashEntry As MetroFramework.Controls.MetroPanel
    Friend WithEvents btn20 As Button
    Friend WithEvents lblGrandTotal As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnUpdateTotal As Button
    Friend WithEvents btnValidate As Button
    Friend WithEvents lblAddressError As Label
    Friend WithEvents lblNameError As Label
    Friend WithEvents lblContactError As Label
    Friend WithEvents lblRoomError As Label
    Friend WithEvents lblPaymentError As Label
    Friend WithEvents lblReservationError As Label
    Friend WithEvents dgvReservations As MetroFramework.Controls.MetroGrid
End Class
