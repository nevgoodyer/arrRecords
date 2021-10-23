<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pizza102
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
        Me.txtStList = New System.Windows.Forms.ListBox()
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
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
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(36, 51)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(100, 20)
        Me.txtFirstName.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Enter Order Details"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "First Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(142, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Last Name"
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(142, 51)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(100, 20)
        Me.txtLastName.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(372, 117)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Delivery date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(248, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Postcode"
        '
        'txtPostcode
        '
        Me.txtPostcode.Location = New System.Drawing.Point(248, 87)
        Me.txtPostcode.Name = "txtPostcode"
        Me.txtPostcode.Size = New System.Drawing.Size(100, 20)
        Me.txtPostcode.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(469, 73)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Quantity"
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(469, 87)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(100, 20)
        Me.txtQuantity.TabIndex = 15
        Me.txtQuantity.Text = "1"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(485, 196)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(104, 23)
        Me.btnAdd.TabIndex = 20
        Me.btnAdd.Text = "Add Order"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtStList
        '
        Me.txtStList.FormattingEnabled = True
        Me.txtStList.Location = New System.Drawing.Point(36, 225)
        Me.txtStList.Name = "txtStList"
        Me.txtStList.Size = New System.Drawing.Size(533, 160)
        Me.txtStList.TabIndex = 15
        Me.txtStList.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(39, 206)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "List of Orders"
        '
        'radThin
        '
        Me.radThin.AutoSize = True
        Me.radThin.Checked = True
        Me.radThin.Location = New System.Drawing.Point(40, 135)
        Me.radThin.Name = "radThin"
        Me.radThin.Size = New System.Drawing.Size(46, 17)
        Me.radThin.TabIndex = 7
        Me.radThin.TabStop = True
        Me.radThin.Text = "Thin"
        Me.radThin.UseVisualStyleBackColor = True
        '
        'radCrispy
        '
        Me.radCrispy.AutoSize = True
        Me.radCrispy.Location = New System.Drawing.Point(40, 158)
        Me.radCrispy.Name = "radCrispy"
        Me.radCrispy.Size = New System.Drawing.Size(53, 17)
        Me.radCrispy.TabIndex = 8
        Me.radCrispy.Text = "Crispy"
        Me.radCrispy.UseVisualStyleBackColor = True
        '
        'radFat
        '
        Me.radFat.AutoSize = True
        Me.radFat.Location = New System.Drawing.Point(40, 181)
        Me.radFat.Name = "radFat"
        Me.radFat.Size = New System.Drawing.Size(40, 17)
        Me.radFat.TabIndex = 9
        Me.radFat.Text = "Fat"
        Me.radFat.UseVisualStyleBackColor = True
        '
        'chkTop1
        '
        Me.chkTop1.AutoSize = True
        Me.chkTop1.Location = New System.Drawing.Point(153, 117)
        Me.chkTop1.Name = "chkTop1"
        Me.chkTop1.Size = New System.Drawing.Size(76, 17)
        Me.chkTop1.TabIndex = 10
        Me.chkTop1.Text = "Anchovies"
        Me.chkTop1.UseVisualStyleBackColor = True
        '
        'chkTop2
        '
        Me.chkTop2.AutoSize = True
        Me.chkTop2.Location = New System.Drawing.Point(153, 139)
        Me.chkTop2.Name = "chkTop2"
        Me.chkTop2.Size = New System.Drawing.Size(55, 17)
        Me.chkTop2.TabIndex = 11
        Me.chkTop2.Text = "Olives"
        Me.chkTop2.UseVisualStyleBackColor = True
        '
        'chkTop3
        '
        Me.chkTop3.AutoSize = True
        Me.chkTop3.Location = New System.Drawing.Point(153, 161)
        Me.chkTop3.Name = "chkTop3"
        Me.chkTop3.Size = New System.Drawing.Size(75, 17)
        Me.chkTop3.TabIndex = 12
        Me.chkTop3.Text = "Cabanossi"
        Me.chkTop3.UseVisualStyleBackColor = True
        '
        'chkTop4
        '
        Me.chkTop4.AutoSize = True
        Me.chkTop4.Location = New System.Drawing.Point(153, 182)
        Me.chkTop4.Name = "chkTop4"
        Me.chkTop4.Size = New System.Drawing.Size(73, 17)
        Me.chkTop4.TabIndex = 13
        Me.chkTop4.Text = "Parmesan"
        Me.chkTop4.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(35, 119)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 13)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Pizza Base"
        '
        'cboHour
        '
        Me.cboHour.AutoCompleteCustomSource.AddRange(New String() {"10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20"})
        Me.cboHour.FormattingEnabled = True
        Me.cboHour.Items.AddRange(New Object() {"10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22"})
        Me.cboHour.Location = New System.Drawing.Point(375, 172)
        Me.cboHour.Name = "cboHour"
        Me.cboHour.Size = New System.Drawing.Size(69, 21)
        Me.cboHour.TabIndex = 17
        Me.cboHour.Text = "01"
        '
        'cboMinute
        '
        Me.cboMinute.FormattingEnabled = True
        Me.cboMinute.Items.AddRange(New Object() {"00", "15", "30", "45"})
        Me.cboMinute.Location = New System.Drawing.Point(477, 172)
        Me.cboMinute.Name = "cboMinute"
        Me.cboMinute.Size = New System.Drawing.Size(76, 21)
        Me.cboMinute.TabIndex = 18
        Me.cboMinute.Text = "00"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(372, 159)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 13)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Hour (24 hr time)"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(474, 159)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(39, 13)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "Minute"
        '
        'dteDelivery
        '
        Me.dteDelivery.Location = New System.Drawing.Point(375, 133)
        Me.dteDelivery.Name = "dteDelivery"
        Me.dteDelivery.Size = New System.Drawing.Size(200, 20)
        Me.dteDelivery.TabIndex = 16
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(142, 74)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(38, 13)
        Me.Label11.TabIndex = 33
        Me.Label11.Text = "Subub"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(142, 87)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 5
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(36, 74)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(75, 13)
        Me.Label12.TabIndex = 31
        Me.Label12.Text = "Street address"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(36, 87)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 4
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(248, 51)
        Me.txtPhone.Mask = "0000-000-000"
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(97, 20)
        Me.txtPhone.TabIndex = 2
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(248, 36)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(38, 13)
        Me.Label13.TabIndex = 35
        Me.Label13.Text = "Phone"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(489, 10)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(86, 13)
        Me.Label14.TabIndex = 37
        Me.Label14.Text = "Base Pizza Price"
        '
        'txtBasePrice
        '
        Me.txtBasePrice.Location = New System.Drawing.Point(489, 25)
        Me.txtBasePrice.Name = "txtBasePrice"
        Me.txtBasePrice.ReadOnly = True
        Me.txtBasePrice.Size = New System.Drawing.Size(100, 20)
        Me.txtBasePrice.TabIndex = 36
        Me.txtBasePrice.TabStop = False
        '
        'txtTop1
        '
        Me.txtTop1.Location = New System.Drawing.Point(111, 111)
        Me.txtTop1.Name = "txtTop1"
        Me.txtTop1.ReadOnly = True
        Me.txtTop1.Size = New System.Drawing.Size(39, 20)
        Me.txtTop1.TabIndex = 38
        Me.txtTop1.TabStop = False
        '
        'txtTop2
        '
        Me.txtTop2.Location = New System.Drawing.Point(111, 133)
        Me.txtTop2.Name = "txtTop2"
        Me.txtTop2.ReadOnly = True
        Me.txtTop2.Size = New System.Drawing.Size(39, 20)
        Me.txtTop2.TabIndex = 38
        Me.txtTop2.TabStop = False
        '
        'txtTop3
        '
        Me.txtTop3.Location = New System.Drawing.Point(111, 155)
        Me.txtTop3.Name = "txtTop3"
        Me.txtTop3.ReadOnly = True
        Me.txtTop3.Size = New System.Drawing.Size(39, 20)
        Me.txtTop3.TabIndex = 38
        Me.txtTop3.TabStop = False
        '
        'txtTop4
        '
        Me.txtTop4.Location = New System.Drawing.Point(111, 177)
        Me.txtTop4.Name = "txtTop4"
        Me.txtTop4.ReadOnly = True
        Me.txtTop4.Size = New System.Drawing.Size(39, 20)
        Me.txtTop4.TabIndex = 38
        Me.txtTop4.TabStop = False
        '
        'txtToppedPrice
        '
        Me.txtToppedPrice.Location = New System.Drawing.Point(251, 132)
        Me.txtToppedPrice.Name = "txtToppedPrice"
        Me.txtToppedPrice.ReadOnly = True
        Me.txtToppedPrice.Size = New System.Drawing.Size(100, 20)
        Me.txtToppedPrice.TabIndex = 36
        Me.txtToppedPrice.TabStop = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(251, 117)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(70, 13)
        Me.Label15.TabIndex = 37
        Me.Label15.Text = "Topped price"
        '
        'txtTotalPrice
        '
        Me.txtTotalPrice.Location = New System.Drawing.Point(251, 172)
        Me.txtTotalPrice.Name = "txtTotalPrice"
        Me.txtTotalPrice.ReadOnly = True
        Me.txtTotalPrice.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalPrice.TabIndex = 36
        Me.txtTotalPrice.TabStop = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(251, 157)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(57, 13)
        Me.Label16.TabIndex = 37
        Me.Label16.Text = "Total price"
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.Location = New System.Drawing.Point(252, 201)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(47, 17)
        Me.CheckBox5.TabIndex = 19
        Me.CheckBox5.Text = "Paid"
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'Pizza102
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(611, 391)
        Me.Controls.Add(Me.CheckBox5)
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
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TextBox2)
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
        Me.Controls.Add(Me.txtStList)
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
        Me.Name = "Pizza102"
        Me.Text = "v1.02 Pizza ordering app"
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


    Friend WithEvents txtStList As ListBox
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
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBox2 As TextBox
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
    Friend WithEvents CheckBox5 As CheckBox
End Class
