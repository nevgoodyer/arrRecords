Public Class Pizza108
    'set up a record or "class" for a student
    Class STUDENT
        Public studID As Int16
        Public firstName As String
        Public lastName As String
        Public deliveryDate As Date
        Public postcode As String  'even though postcode is a number, we store it as a string
        Public quantity As Byte    'Max quantity is 255 Pizzas
        Public phoneNo As String   'Phone numbers are NEVER used to calculate, so saved as text
        Public street As String
        Public suburb As String
        Public hour As Byte        '# between 0 and 23 - it can never be > 255
        Public minute As Byte      '# between 0 and 59 - it can never be > 255
        Public pizzaBase As String 'short name for base
        Public paid As Boolean
        Public top1 As Boolean
        Public top2 As Boolean
        Public top3 As Boolean
        Public top4 As Boolean
    End Class

    ReadOnly students(9) As STUDENT
    Dim studentCount As Integer = 0
    Dim basePrice As Single
    Dim top1price As Single
    Dim top2price As Single
    Dim top3price As Single
    Dim top4price As Single
    Dim toppedPrice As Single

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'allocate memory
        For i = 0 To 9
            students(i) = New STUDENT
        Next
        'load default prices
        basePrice = 10
        top1price = 0.3
        top2price = 0.45
        top3price = 0.9
        top4price = 1.3

        'display prices
        txtBasePrice.Text = FormatCurrency(basePrice)
        txtTop1.Text = FormatCurrency(top1price)
        txtTop2.Text = FormatCurrency(top2price)
        txtTop3.Text = FormatCurrency(top3price)
        txtTop4.Text = FormatCurrency(top4price)

        'load 4 test records
        With students(0)
            .studID = 1
            .firstName = "Hungry"
            .lastName = "Harry"
            .deliveryDate = "28/10/21 6:30:00 PM"
            .postcode = "2037"
            .quantity = 2
            .phoneNo = "0243-232-232"
            .paid = True
            .street = "25 Taylor St"
            .suburb = "Glebe"
            .pizzaBase = "Fat"
            .top1 = True
            .top2 = False
            .top3 = True
            .top4 = True
        End With
        students(1).studID = 2
        students(1).firstName = "Bart"
        students(1).lastName = "Simpson"
        students(1).deliveryDate = "29/10/21 8:45:00 PM"
        students(1).postcode = "2037"
        students(1).quantity = 3
        students(1).phoneNo = "0243-444-555"
        students(1).paid = True
        students(1).street = "20 Taylor St"
        students(1).suburb = "Glebe"
        students(1).pizzaBase = "Thin"
        students(1).top1 = False
        students(1).top2 = True
        students(1).top3 = True
        students(1).top4 = True
        students(2).studID = 3
        students(2).firstName = "Homer"
        students(2).lastName = "Simpson"
        students(2).deliveryDate = "29/10/21 7:30:00 PM"
        students(2).postcode = "2037"
        students(2).quantity = 4
        students(2).phoneNo = "0243-666-777"
        students(2).paid = False
        students(2).street = "19 Taylor St"
        students(2).suburb = "Glebe"
        students(2).pizzaBase = "Thin"
        students(2).top1 = False
        students(2).top2 = True
        students(2).top3 = True
        students(2).top4 = True
        students(3).studID = 4
        students(3).firstName = "Lisa"
        students(3).lastName = "Simpson"
        students(3).deliveryDate = "29/10/21 6:00:00 PM"
        students(3).postcode = "2037"
        students(3).quantity = 4
        students(3).phoneNo = "0243-666-777"
        students(3).paid = False
        students(3).street = "20 Taylor St"
        students(3).suburb = "Glebe"
        students(3).pizzaBase = "Thin"
        students(3).top1 = False
        students(3).top2 = True
        students(3).top3 = True
        students(3).top4 = True
        'set defaults for hour and minute as it can't be done with "DropDownLtyle=DropDownList"
        cboHour.Text = "12"
        cboMinute.Text = "00"
        'set the student count to the number of students which have been entered
        studentCount = 4
        DisplayList()
        CalcToppedPrice()
        CalcTotalPrice()
    End Sub

    Private Sub BtnAddStud_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'check FirstName is not blank.
        If CheckBlank(txtFirstName, "First Name") Then Exit Sub

        'check LastName is not blank.
        If CheckBlank(txtLastName, "Last Name") Then Exit Sub

        'check Phone is not blank.
        If Not Len(txtPhone.Text) = 12 Then
            MsgBox("Ensure the phone number has 10 digits", MsgBoxStyle.Exclamation, "Phone # Check")
            txtPhone.Focus()
            Exit Sub
        End If
        'loop through all phone characters and count spaces.
        Dim spaceCount As Integer
        spaceCount = 0
        For Each c As Char In txtPhone.Text
            If c = " " Then
                spaceCount += 1
            End If
        Next
        If spaceCount > 0 Then
            MsgBox("There are " & spaceCount &
                   " spaces in the phone number. Please ensure there are 10 numbers!",
                   MsgBoxStyle.Exclamation, "Phone number Check")
            txtPhone.Focus()
            Exit Sub
        End If

        'Check Street 
        If CheckBlank(txtStreet, "Street") Then Exit Sub

        'Check Suburb 
        If CheckBlank(txtSuburb, "Suburb") Then Exit Sub

        'Check Postcode is a 4 digit number
        If Not IsNumeric(txtPostcode.Text) Then
            MsgBox("Please ensure the Postcode is numeric", MsgBoxStyle.Exclamation, "Postcode Check")
            txtPostcode.Focus()
            Exit Sub
        Else
            If CInt(txtPostcode.Text) < 999 Or CInt(txtPostcode.Text) > 9999 Then
                MsgBox("Please enter a 4 digit Postcode", MsgBoxStyle.Exclamation, "Postcode Check")
                txtPostcode.Focus()
                Exit Sub
            End If
        End If

        'Check quantity is between 0 and 30 
        If CheckBlank(txtQuantity, "Quantity") Then Exit Sub
        If Not IsNumeric(txtQuantity.Text) Then
            MsgBox("Please ensure the 'Quantity' is numeric", MsgBoxStyle.Exclamation, "Quantity Check")
            txtQuantity.Focus()
            Exit Sub
        Else
            If CInt(txtQuantity.Text) < 1 Or CInt(txtQuantity.Text) > 30 Then
                MsgBox("Please enter a Quantity between 1 and 30!", MsgBoxStyle.Exclamation, "Quantity Check")
                txtQuantity.Focus()
                Exit Sub
            End If
        End If

        'Check hour is between 10 and 22 - now done by "DropDownStyle=DropDownList"
        If CheckBlank(cboHour, "Hour") Then Exit Sub
        If cboHour.Text < 10 Or txtQuantity.Text > 22 Then
            MsgBox("Please enter an hour between 10 and 22!", MsgBoxStyle.Exclamation, "Hour Check")
            cboHour.Focus()
            Exit Sub
        End If

        'Check minute is not blank
        If CheckBlank(cboMinute, "Minute") Then Exit Sub

        'Check base is not all unchecked
        If radFat.Checked = False And radCrispy.Checked = False And radThin.Checked = False Then
            MsgBox("Please select a base", MsgBoxStyle.Exclamation, "Base Check")
            radThin.Focus()
            Exit Sub
        End If

        'Check for at least 1 topping
        If chkTop1.Checked = False And chkTop2.Checked = False And chkTop3.Checked =
            False And chkTop4.Checked = False Then
            MsgBox("Please select at least 1 topping", MsgBoxStyle.Exclamation, "Topping Check")
            chkTop1.Focus()
            Exit Sub
        End If

        'increment the student count
        students(studentCount).studID = studentCount + 1 'allocate the new student ID to an incremented value
        'place text from text boxes into the array - first students(0), then students(1), students(2) etc
        students(studentCount).firstName = txtFirstName.Text
        students(studentCount).lastName = txtLastName.Text
        students(studentCount).phoneNo = txtPhone.Text
        students(studentCount).street = txtStreet.Text
        students(studentCount).suburb = txtSuburb.Text
        students(studentCount).postcode = txtPostcode.Text
        students(studentCount).quantity = txtQuantity.Text
        students(studentCount).deliveryDate = dteDelivery.Text & " " & cboHour.Text & ":" & cboMinute.Text
        If radThin.Checked Then students(studentCount).pizzaBase = "Thin"
        If radFat.Checked Then students(studentCount).pizzaBase = "Fat"
        If radCrispy.Checked Then students(studentCount).pizzaBase = "Crispy"
        If chkTop1.Checked Then students(studentCount).top1 = "-1" Else students(studentCount).top1 = "0"
        If chkTop2.Checked Then students(studentCount).top2 = "-1" Else students(studentCount).top2 = "0"
        If chkTop3.Checked Then students(studentCount).top3 = "-1" Else students(studentCount).top3 = "0"
        If chkTop4.Checked Then students(studentCount).top4 = "-1" Else students(studentCount).top4 = "0"
        If chkPaid.Checked Then students(studentCount).paid = "-1" Else students(studentCount).paid = "0"
        studentCount += 1

        'return text boxes to blank ready for next entry
        txtFirstName.Text = ""
        txtLastName.Text = ""
        txtPhone.Text = ""
        txtStreet.Text = ""
        txtSuburb.Text = ""
        txtPostcode.Text = ""
        txtQuantity.Text = 1
        dteDelivery.Text = ""
        'set defaults for hour and minute as it can't be done with "DropDownLtyle=DropDownList"
        cboHour.Text = "12"
        cboMinute.Text = "00"
        radThin.Checked = False
        radCrispy.Checked = False
        radFat.Checked = False
        chkTop1.Checked = False
        chkTop2.Checked = False
        chkTop3.Checked = False
        chkTop4.Checked = False
        DisplayList()
    End Sub

    Private Sub DisplayList()
        'loop through the array to print all rows
        lsvOrders.Items.Clear()
        For i = 0 To studentCount - 1
            lsvOrders.Items.Add(students(i).studID)
            'lsvOrders.Items(i).SubItems.Add(students(i).studID)
            lsvOrders.Items(i).SubItems.Add(students(i).firstName)
            lsvOrders.Items(i).SubItems.Add(students(i).lastName)
            lsvOrders.Items(i).SubItems.Add(students(i).phoneNo)
            lsvOrders.Items(i).SubItems.Add(students(i).street)
            lsvOrders.Items(i).SubItems.Add(students(i).suburb)
            lsvOrders.Items(i).SubItems.Add(students(i).postcode)
            lsvOrders.Items(i).SubItems.Add(students(i).deliveryDate)
            lsvOrders.Items(i).SubItems.Add(students(i).quantity)
            lsvOrders.Items(i).SubItems.Add(students(i).pizzaBase)
            lsvOrders.Items(i).SubItems.Add(students(i).top1)
            lsvOrders.Items(i).SubItems.Add(students(i).top2)
            lsvOrders.Items(i).SubItems.Add(students(i).top3)
            lsvOrders.Items(i).SubItems.Add(students(i).top4)
            lsvOrders.Items(i).SubItems.Add(students(i).paid)
        Next
    End Sub

    Private Sub CalcTotalPrice()
        txtTotalPrice.Text = FormatCurrency(toppedPrice * CInt(txtQuantity.Text))
    End Sub

    Private Sub CalcToppedPrice()
        toppedPrice = basePrice
        If chkTop1.Checked Then 'later theese 4 IF statements could be replaced with a loop
            toppedPrice += top1price
        End If
        If chkTop2.Checked Then
            toppedPrice += top2price
        End If
        If chkTop3.Checked Then
            toppedPrice += top3price
        End If
        If chkTop4.Checked Then
            toppedPrice += top4price
        End If
        txtToppedPrice.Text = FormatCurrency(toppedPrice)
    End Sub

    Private Sub ChkTop1_CheckedChanged(sender As Object, e As EventArgs) Handles chkTop1.CheckedChanged
        CalcToppedPrice()
        CalcTotalPrice()
    End Sub

    Private Sub ChkTop2_CheckedChanged(sender As Object, e As EventArgs) Handles chkTop2.CheckedChanged
        CalcToppedPrice()
        CalcTotalPrice()
    End Sub

    Private Sub ChkTop3_CheckedChanged(sender As Object, e As EventArgs) Handles chkTop3.CheckedChanged
        CalcToppedPrice()
        CalcTotalPrice()
    End Sub

    Private Sub ChkTop4_CheckedChanged(sender As Object, e As EventArgs) Handles chkTop4.CheckedChanged
        CalcToppedPrice()
        CalcTotalPrice()
    End Sub

    Private Sub RadThin_CheckedChanged(sender As Object, e As EventArgs) Handles radThin.CheckedChanged
        If radThin.Checked Then
            students(studentCount).pizzaBase = "Thin"
        End If
    End Sub

    Private Sub RadCrispy_CheckedChanged(sender As Object, e As EventArgs) Handles radCrispy.CheckedChanged
        If radCrispy.Checked Then
            students(studentCount).pizzaBase = "Crispy"
        End If
    End Sub

    Private Sub RadFat_CheckedChanged(sender As Object, e As EventArgs) Handles radFat.CheckedChanged
        If radFat.Checked Then
            students(studentCount).pizzaBase = "Fat"
        End If
    End Sub

    Private Sub TxtQuantity_TextChanged(sender As Object, e As EventArgs) Handles txtQuantity.Validating
        'note the order of the Leave, Validating, Validated, LostFocus at the link below:
        'https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control.leave?view=windowsdesktop-5.0
        If Not IsNumeric(txtQuantity.Text) Then
            MsgBox("Please enter a NUMBER less than 30", MsgBoxStyle.Exclamation, "Problem with Quantity")
            txtQuantity.Focus()
            Exit Sub
        ElseIf CInt(txtQuantity.Text) > 0 And CInt(txtQuantity.Text) < 31 Then
            CalcTotalPrice()
        Else
            MsgBox("Please enter a number less than 30", MsgBoxStyle.Exclamation, "Problem with Quantity")
            txtQuantity.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub TxtPhone_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txtPhone.MaskInputRejected
        'check Phone is not blank.
        If Not Len(txtPhone.Text) = 12 Then
            MsgBox("Ensure the phone number has 10 digits", MsgBoxStyle.Exclamation, "Phone # Check")
            txtPhone.Focus()
            Exit Sub
        End If
        'loop through all phone characters and count spaces.
        Dim spaceCount As Integer
        spaceCount = 0
        For Each c As Char In txtPhone.Text
            If c = " " Then
                spaceCount += 1
            End If
        Next
        If spaceCount > 0 Then
            MsgBox("There are " & spaceCount &
                   " spaces in the phone number. Please ensure there are 10 numbers!",
                   MsgBoxStyle.Exclamation, "Phone number Check")
            txtPhone.Focus()
            Exit Sub
        End If
    End Sub

    Private Function CheckBlank(TxtBoxName, FieldName)
        'check FirstName is not blank.
        If TxtBoxName.Text = "" Then
            MsgBox("Please enter a " & FieldName, MsgBoxStyle.Exclamation, FieldName & " check")
            TxtBoxName.Focus()
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub TxtFirstName_TextChanged(sender As Object, e As EventArgs) Handles txtFirstName.Validating
        'check FirstName is not blank by calling function
        If CheckBlank(txtFirstName, "First Name") Then Exit Sub
    End Sub
    Private Sub TxtLastName_TextChanged(sender As Object, e As EventArgs) Handles txtLastName.Validating
        'check LastName is not blank.
        If CheckBlank(txtLastName, "Last Name") Then Exit Sub
    End Sub

    Private Sub TxtQuantity_TextChanged_1(sender As Object, e As EventArgs) Handles txtQuantity.Validating
        'Check quantity is between 0 and 30 
        If CheckBlank(txtQuantity, "Quantity") Then Exit Sub
        If Not IsNumeric(txtQuantity.Text) Then
            MsgBox("Please ensure the 'Quantity' is numeric", MsgBoxStyle.Exclamation, "Quantity Check")
            txtQuantity.Focus()
            Exit Sub
        Else
            If CInt(txtQuantity.Text) < 1 Or CInt(txtQuantity.Text) > 30 Then
                MsgBox("Please enter a Quantity between 1 and 30!", MsgBoxStyle.Exclamation, "Quantity Check")
                txtQuantity.Focus()
                Exit Sub
            End If
        End If
    End Sub

    Private Sub TxtStreet_TextChanged(sender As Object, e As EventArgs) Handles txtStreet.Validating
        If CheckBlank(txtStreet, "Street") Then Exit Sub
    End Sub

    Private Sub TxtSuburb_TextChanged(sender As Object, e As EventArgs) Handles txtSuburb.Validating
        If CheckBlank(txtSuburb, "Suburb") Then Exit Sub
    End Sub
    Private Sub TxtPostcode_TextChanged(sender As Object, e As EventArgs) Handles txtPostcode.Validating
        'Check Postcode is a 4 digit number
        If Not IsNumeric(txtPostcode.Text) Then
            MsgBox("Please ensure the Postcode is numeric", MsgBoxStyle.Exclamation, "Postcode Check")
            txtPostcode.Focus()
            Exit Sub
        Else
            If CInt(txtPostcode.Text) < 999 Or CInt(txtPostcode.Text) > 9999 Then
                MsgBox("Please enter a 4 digit Postcode", MsgBoxStyle.Exclamation, "Postcode Check")
                txtPostcode.Focus()
                Exit Sub
            End If
        End If
    End Sub
End Class
