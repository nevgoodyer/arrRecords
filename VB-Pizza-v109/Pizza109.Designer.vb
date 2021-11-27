<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pizza109
    Inherits System.Windows.Forms.Form

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
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPostcode = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.radThin = New System.Windows.Forms.RadioButton()
        Me.radCrispy = New System.Windows.Forms.RadioButton()
        Me.radFat = New System.Windows.Forms.RadioButton()
        Me.chkTop1 = New System.Windows.Forms.CheckBox()
        Me.chkTop2 = New System.Windows.Forms.CheckBox()
        Me.chkTop3 = New System.Windows.Forms.CheckBox()
        Me.chkTop4 = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboHour = New System.Windows.Forms.ComboBox()
        Me.cboMinute = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dteDelivery = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtSuburb = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtStreet = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.MaskedTextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtBasePrice = New System.Windows.Forms.TextBox()
        Me.txtTop1 = New System.Windows.Forms.TextBox()
        Me.txtTop2 = New System.Windows.Forms.TextBox()
        Me.txtTop3 = New System.Windows.Forms.TextBox()
        Me.txtTop4 = New System.Windows.Forms.TextBox()
        Me.txtToppedPrice = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtTotalPrice = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.chkPaid = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.lsvOrders = New System.Windows.Forms.ListView()
        Me.Order_ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.First_Name = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Last_Name = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Phone = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Street = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Suburb = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Postcode = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DeliveryDateTime = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Quantity = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Base = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Top1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Top2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Top3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Top4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Paid = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(29, 122)
        Me.txtFirstName.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(260, 38)
        Me.txtFirstName.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 24)
        Me.Label1.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(257, 32)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Enter Order Details"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 86)
        Me.Label2.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(152, 32)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "First Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(312, 86)
        Me.Label3.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(151, 32)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Last Name"
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(312, 122)
        Me.txtLastName.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(260, 38)
        Me.txtLastName.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(925, 279)
        Me.Label4.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(181, 32)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Delivery date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(595, 176)
        Me.Label5.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(134, 32)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Postcode"
        '
        'txtPostcode
        '
        Me.txtPostcode.Location = New System.Drawing.Point(595, 207)
        Me.txtPostcode.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.txtPostcode.Name = "txtPostcode"
        Me.txtPostcode.Size = New System.Drawing.Size(260, 38)
        Me.txtPostcode.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(1184, 174)
        Me.Label6.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(122, 32)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Quantity"
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(1184, 207)
        Me.txtQuantity.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(260, 38)
        Me.txtQuantity.TabIndex = 15
        Me.txtQuantity.Text = "1"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(1227, 467)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(277, 55)
        Me.btnAdd.TabIndex = 20
        Me.btnAdd.Text = "Add Order"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(37, 503)
        Me.Label8.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(184, 32)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "List of Orders"
        '
        'radThin
        '
        Me.radThin.AutoSize = True
        Me.radThin.Location = New System.Drawing.Point(40, 322)
        Me.radThin.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.radThin.Name = "radThin"
        Me.radThin.Size = New System.Drawing.Size(108, 36)
        Me.radThin.TabIndex = 7
        Me.radThin.TabStop = True
        Me.radThin.Text = "Thin"
        Me.radThin.UseVisualStyleBackColor = True
        '
        'radCrispy
        '
        Me.radCrispy.AutoSize = True
        Me.radCrispy.Location = New System.Drawing.Point(40, 377)
        Me.radCrispy.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.radCrispy.Name = "radCrispy"
        Me.radCrispy.Size = New System.Drawing.Size(132, 36)
        Me.radCrispy.TabIndex = 8
        Me.radCrispy.TabStop = True
        Me.radCrispy.Text = "Crispy"
        Me.radCrispy.UseVisualStyleBackColor = True
        '
        'radFat
        '
        Me.radFat.AutoSize = True
        Me.radFat.Location = New System.Drawing.Point(40, 432)
        Me.radFat.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.radFat.Name = "radFat"
        Me.radFat.Size = New System.Drawing.Size(93, 36)
        Me.radFat.TabIndex = 9
        Me.radFat.TabStop = True
        Me.radFat.Text = "Fat"
        Me.radFat.UseVisualStyleBackColor = True
        '
        'chkTop1
        '
        Me.chkTop1.AutoSize = True
        Me.chkTop1.Location = New System.Drawing.Point(341, 279)
        Me.chkTop1.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.chkTop1.Name = "chkTop1"
        Me.chkTop1.Size = New System.Drawing.Size(185, 36)
        Me.chkTop1.TabIndex = 10
        Me.chkTop1.Text = "Anchovies"
        Me.chkTop1.UseVisualStyleBackColor = True
        '
        'chkTop2
        '
        Me.chkTop2.AutoSize = True
        Me.chkTop2.Location = New System.Drawing.Point(341, 331)
        Me.chkTop2.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.chkTop2.Name = "chkTop2"
        Me.chkTop2.Size = New System.Drawing.Size(133, 36)
        Me.chkTop2.TabIndex = 11
        Me.chkTop2.Text = "Olives"
        Me.chkTop2.UseVisualStyleBackColor = True
        '
        'chkTop3
        '
        Me.chkTop3.AutoSize = True
        Me.chkTop3.Location = New System.Drawing.Point(341, 384)
        Me.chkTop3.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.chkTop3.Name = "chkTop3"
        Me.chkTop3.Size = New System.Drawing.Size(188, 36)
        Me.chkTop3.TabIndex = 12
        Me.chkTop3.Text = "Cabanossi"
        Me.chkTop3.UseVisualStyleBackColor = True
        '
        'chkTop4
        '
        Me.chkTop4.AutoSize = True
        Me.chkTop4.Location = New System.Drawing.Point(341, 434)
        Me.chkTop4.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.chkTop4.Name = "chkTop4"
        Me.chkTop4.Size = New System.Drawing.Size(182, 36)
        Me.chkTop4.TabIndex = 13
        Me.chkTop4.Text = "Parmesan"
        Me.chkTop4.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(27, 284)
        Me.Label7.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(157, 32)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Pizza Base"
        '
        'cboHour
        '
        Me.cboHour.AutoCompleteCustomSource.AddRange(New String() {"10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20"})
        Me.cboHour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboHour.FormattingEnabled = True
        Me.cboHour.Items.AddRange(New Object() {"10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22"})
        Me.cboHour.Location = New System.Drawing.Point(933, 410)
        Me.cboHour.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.cboHour.Name = "cboHour"
        Me.cboHour.Size = New System.Drawing.Size(177, 39)
        Me.cboHour.TabIndex = 17
        '
        'cboMinute
        '
        Me.cboMinute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMinute.FormattingEnabled = True
        Me.cboMinute.Items.AddRange(New Object() {"00", "15", "30", "45"})
        Me.cboMinute.Location = New System.Drawing.Point(1205, 410)
        Me.cboMinute.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.cboMinute.Name = "cboMinute"
        Me.cboMinute.Size = New System.Drawing.Size(196, 39)
        Me.cboMinute.TabIndex = 18
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(925, 379)
        Me.Label9.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(226, 32)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Hour (24 hr time)"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(1197, 379)
        Me.Label10.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(101, 32)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "Minute"
        '
        'dteDelivery
        '
        Me.dteDelivery.Location = New System.Drawing.Point(933, 317)
        Me.dteDelivery.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.dteDelivery.MaxDate = New Date(2021, 12, 21, 6, 35, 50, 843)
        Me.dteDelivery.MinDate = New Date(2021, 11, 21, 6, 35, 50, 843)
        Me.dteDelivery.Name = "dteDelivery"
        Me.dteDelivery.Size = New System.Drawing.Size(527, 38)
        Me.dteDelivery.TabIndex = 16
        Me.dteDelivery.Value = New Date(2021, 11, 21, 6, 35, 50, 843)
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(312, 176)
        Me.Label11.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(98, 32)
        Me.Label11.TabIndex = 33
        Me.Label11.Text = "Subub"
        '
        'txtSuburb
        '
        Me.txtSuburb.Location = New System.Drawing.Point(312, 207)
        Me.txtSuburb.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.txtSuburb.Name = "txtSuburb"
        Me.txtSuburb.Size = New System.Drawing.Size(260, 38)
        Me.txtSuburb.TabIndex = 4
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(29, 176)
        Me.Label12.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(199, 32)
        Me.Label12.TabIndex = 31
        Me.Label12.Text = "Street address"
        '
        'txtStreet
        '
        Me.txtStreet.Location = New System.Drawing.Point(29, 207)
        Me.txtStreet.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.txtStreet.Name = "txtStreet"
        Me.txtStreet.Size = New System.Drawing.Size(260, 38)
        Me.txtStreet.TabIndex = 3
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(595, 122)
        Me.txtPhone.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.txtPhone.Mask = "0000-000-000"
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(252, 38)
        Me.txtPhone.TabIndex = 2
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(595, 86)
        Me.Label13.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(98, 32)
        Me.Label13.TabIndex = 35
        Me.Label13.Text = "Phone"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(1237, 24)
        Me.Label14.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(229, 32)
        Me.Label14.TabIndex = 37
        Me.Label14.Text = "Pizza Base Price"
        '
        'txtBasePrice
        '
        Me.txtBasePrice.Location = New System.Drawing.Point(1237, 60)
        Me.txtBasePrice.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.txtBasePrice.Name = "txtBasePrice"
        Me.txtBasePrice.ReadOnly = True
        Me.txtBasePrice.Size = New System.Drawing.Size(260, 38)
        Me.txtBasePrice.TabIndex = 36
        Me.txtBasePrice.TabStop = False
        '
        'txtTop1
        '
        Me.txtTop1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTop1.Location = New System.Drawing.Point(229, 281)
        Me.txtTop1.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.txtTop1.Name = "txtTop1"
        Me.txtTop1.ReadOnly = True
        Me.txtTop1.Size = New System.Drawing.Size(104, 31)
        Me.txtTop1.TabIndex = 38
        Me.txtTop1.TabStop = False
        Me.txtTop1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTop2
        '
        Me.txtTop2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTop2.Location = New System.Drawing.Point(229, 334)
        Me.txtTop2.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.txtTop2.Name = "txtTop2"
        Me.txtTop2.ReadOnly = True
        Me.txtTop2.Size = New System.Drawing.Size(104, 31)
        Me.txtTop2.TabIndex = 38
        Me.txtTop2.TabStop = False
        Me.txtTop2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTop3
        '
        Me.txtTop3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTop3.Location = New System.Drawing.Point(229, 386)
        Me.txtTop3.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.txtTop3.Name = "txtTop3"
        Me.txtTop3.ReadOnly = True
        Me.txtTop3.Size = New System.Drawing.Size(104, 31)
        Me.txtTop3.TabIndex = 38
        Me.txtTop3.TabStop = False
        Me.txtTop3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTop4
        '
        Me.txtTop4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTop4.Location = New System.Drawing.Point(229, 439)
        Me.txtTop4.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.txtTop4.Name = "txtTop4"
        Me.txtTop4.ReadOnly = True
        Me.txtTop4.Size = New System.Drawing.Size(104, 31)
        Me.txtTop4.TabIndex = 38
        Me.txtTop4.TabStop = False
        Me.txtTop4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtToppedPrice
        '
        Me.txtToppedPrice.Location = New System.Drawing.Point(603, 315)
        Me.txtToppedPrice.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.txtToppedPrice.Name = "txtToppedPrice"
        Me.txtToppedPrice.ReadOnly = True
        Me.txtToppedPrice.Size = New System.Drawing.Size(260, 38)
        Me.txtToppedPrice.TabIndex = 36
        Me.txtToppedPrice.TabStop = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(603, 279)
        Me.Label15.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(181, 32)
        Me.Label15.TabIndex = 37
        Me.Label15.Text = "Topped price"
        '
        'txtTotalPrice
        '
        Me.txtTotalPrice.Location = New System.Drawing.Point(603, 410)
        Me.txtTotalPrice.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.txtTotalPrice.Name = "txtTotalPrice"
        Me.txtTotalPrice.ReadOnly = True
        Me.txtTotalPrice.Size = New System.Drawing.Size(260, 38)
        Me.txtTotalPrice.TabIndex = 36
        Me.txtTotalPrice.TabStop = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(603, 374)
        Me.Label16.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(148, 32)
        Me.Label16.TabIndex = 37
        Me.Label16.Text = "Total price"
        '
        'chkPaid
        '
        Me.chkPaid.AutoSize = True
        Me.chkPaid.Location = New System.Drawing.Point(605, 479)
        Me.chkPaid.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.chkPaid.Name = "chkPaid"
        Me.chkPaid.Size = New System.Drawing.Size(111, 36)
        Me.chkPaid.TabIndex = 19
        Me.chkPaid.Text = "Paid"
        Me.chkPaid.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(2611, 453)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(198, 36)
        Me.CheckBox1.TabIndex = 39
        Me.CheckBox1.Text = "CheckBox1"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'lsvOrders
        '
        Me.lsvOrders.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Order_ID, Me.First_Name, Me.Last_Name, Me.Phone, Me.Street, Me.Suburb, Me.Postcode, Me.DeliveryDateTime, Me.Quantity, Me.Base, Me.Top1, Me.Top2, Me.Top3, Me.Top4, Me.Paid})
        Me.lsvOrders.HideSelection = False
        Me.lsvOrders.Location = New System.Drawing.Point(27, 537)
        Me.lsvOrders.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.lsvOrders.Name = "lsvOrders"
        Me.lsvOrders.Size = New System.Drawing.Size(2255, 762)
        Me.lsvOrders.TabIndex = 40
        Me.lsvOrders.TabStop = False
        Me.lsvOrders.UseCompatibleStateImageBehavior = False
        Me.lsvOrders.View = System.Windows.Forms.View.Details
        '
        'Order_ID
        '
        Me.Order_ID.Text = "ID"
        Me.Order_ID.Width = 23
        '
        'First_Name
        '
        Me.First_Name.Text = "First Name"
        Me.First_Name.Width = 65
        '
        'Last_Name
        '
        Me.Last_Name.Text = "Last Name"
        Me.Last_Name.Width = 65
        '
        'Phone
        '
        Me.Phone.Text = "Phone"
        Me.Phone.Width = 85
        '
        'Street
        '
        Me.Street.Text = "Street"
        Me.Street.Width = 90
        '
        'Suburb
        '
        Me.Suburb.Text = "Suburb"
        '
        'Postcode
        '
        Me.Postcode.Text = "Pcode"
        '
        'DeliveryDateTime
        '
        Me.DeliveryDateTime.Text = "Delivery time"
        Me.DeliveryDateTime.Width = 130
        '
        'Quantity
        '
        Me.Quantity.Text = "Qty"
        Me.Quantity.Width = 30
        '
        'Base
        '
        Me.Base.Text = "Base"
        Me.Base.Width = 40
        '
        'Top1
        '
        Me.Top1.Text = "T1"
        Me.Top1.Width = 25
        '
        'Top2
        '
        Me.Top2.Text = "T2"
        Me.Top2.Width = 25
        '
        'Top3
        '
        Me.Top3.Text = "T3"
        Me.Top3.Width = 25
        '
        'Top4
        '
        Me.Top4.Text = "T4"
        Me.Top4.Width = 25
        '
        'Paid
        '
        Me.Paid.Text = "Paid"
        Me.Paid.Width = 20
        '
        'Pizza109
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(2320, 1374)
        Me.Controls.Add(Me.lsvOrders)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.chkPaid)
        Me.Controls.Add(Me.txtTop4)
        Me.Controls.Add(Me.txtTop3)
        Me.Controls.Add(Me.txtTop2)
        Me.Controls.Add(Me.txtTop1)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtTotalPrice)
        Me.Controls.Add(Me.txtToppedPrice)
        Me.Controls.Add(Me.txtBasePrice)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtSuburb)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtStreet)
        Me.Controls.Add(Me.dteDelivery)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cboMinute)
        Me.Controls.Add(Me.cboHour)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.chkTop4)
        Me.Controls.Add(Me.chkTop3)
        Me.Controls.Add(Me.chkTop2)
        Me.Controls.Add(Me.chkTop1)
        Me.Controls.Add(Me.radFat)
        Me.Controls.Add(Me.radCrispy)
        Me.Controls.Add(Me.radThin)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtPostcode)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtFirstName)
        Me.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.Name = "Pizza109"
        Me.Text = "v1.09 Pizza ordering app"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPostcode As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents btnAdd As Button

    Friend WithEvents Label8 As Label
    Friend WithEvents radThin As RadioButton
    Friend WithEvents radCrispy As RadioButton
    Friend WithEvents radFat As RadioButton
    Friend WithEvents chkTop1 As CheckBox
    Friend WithEvents chkTop2 As CheckBox
    Friend WithEvents chkTop3 As CheckBox
    Friend WithEvents chkTop4 As CheckBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cboHour As ComboBox
    Friend WithEvents cboMinute As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents dteDelivery As DateTimePicker
    Friend WithEvents Label11 As Label
    Friend WithEvents txtSuburb As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtStreet As TextBox
    Friend WithEvents txtPhone As MaskedTextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtBasePrice As TextBox
    Friend WithEvents txtTop1 As TextBox
    Friend WithEvents txtTop2 As TextBox
    Friend WithEvents txtTop3 As TextBox
    Friend WithEvents txtTop4 As TextBox
    Friend WithEvents txtToppedPrice As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtTotalPrice As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents chkPaid As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents lsvOrders As ListView
    Friend WithEvents Order_ID As ColumnHeader
    Friend WithEvents First_Name As ColumnHeader
    Friend WithEvents Last_Name As ColumnHeader
    Friend WithEvents Street As ColumnHeader
    Friend WithEvents Suburb As ColumnHeader
    Friend WithEvents Postcode As ColumnHeader
    Friend WithEvents DeliveryDateTime As ColumnHeader
    Friend WithEvents Base As ColumnHeader
    Friend WithEvents Top1 As ColumnHeader
    Friend WithEvents Top2 As ColumnHeader
    Friend WithEvents Top3 As ColumnHeader
    Friend WithEvents Top4 As ColumnHeader
    Friend WithEvents Paid As ColumnHeader
    Friend WithEvents Phone As ColumnHeader
    Friend WithEvents Quantity As ColumnHeader
End Class
