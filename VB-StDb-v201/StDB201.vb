Public Class StDB201
    Public unitCount As Integer
    Public feeEnrol As Single
    Public feePerUnit As Single
    Public feeTotalCalc As Single
    Public subjectcount As Integer

    'set up a record or "class" for a student
    Class STUDENT
        Public firstname As String
        Public lastname As String
        Public DOB As Date
        Public gender As String
        Public avMk As Single
        Public stYear As Integer
        Public subMath2U As Boolean
        Public subMathExt1U As Boolean
        Public subEng As Boolean
        Public subSci As Boolean
        Public subPho As Boolean
        Public feeTotalPaid As Single
        Public feePaid As Boolean
        Public AmountPaid As String
        Public Hours As String
        Public Minutes As String


    End Class

    Dim students(9) As STUDENT
    Dim studentCount As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'allocate memory
        For i = 0 To 9
            students(i) = New STUDENT
        Next
        'Load default unit values:
        txtUnitMath.Text = 2
        txtUnitMathExt.Text = 1
        txtUnitEng.Text = 2
        txtUnitSci.Text = 2
        txtUnitPho.Text = 1

        'set unit count to 0
        unitCount = 0
        feeEnrol = 1000
        feePerUnit = 50
        feeTotalCalc = 0
        txtUnitCountCalc.Text = unitCount
        txtFeeEnrol.Text = feeEnrol
        txtFeePerUnit.Text = feePerUnit


        'load 4 test records
        students(0).firstname = "Johnny"
        students(0).lastname = "Depp"
        students(0).DOB = "9/6/63 12:00PM"
        students(0).gender = "m"
        students(0).avMk = 78.2
        students(0).AmountPaid = "4000"

        students(1).firstname = "Jennifer"
        students(1).lastname = "Lawrence"
        students(1).DOB = "15/8/90 11:00AM"
        students(1).gender = "f"
        students(1).avMk = 88.2

        students(2).firstname = "George"
        students(2).lastname = "Clooney"
        students(2).DOB = "6/5/61 1:00PM"
        students(2).gender = "f"
        students(2).avMk = 68.2

        students(3).firstname = "Scarlett"
        students(3).lastname = "Johansson"
        students(3).DOB = "22/11/84 3:00PM"
        students(3).gender = "f"
        students(3).avMk = 72.2

        students(4).firstname = "Blackwattle"
        students(4).lastname = "Bay"
        students(4).DOB = "28/2/2000 10:00AM"
        students(4).gender = "m"
        students(4).avMk = 25
        'set the student count to the number of students which have been entered
        studentCount = 5    'be sure to change this if you add extras

        displayList()

    End Sub
    Private Sub btnAddStud_Click(sender As Object, e As EventArgs) Handles btnAddStud.Click

        txtFirstName.Focus()

        'place text from text boxes into the array - first students(0), then students(1), students(2) etc
        students(studentCount).firstname = txtFirstName.Text
        students(studentCount).lastname = txtLastName.Text
        students(studentCount).DOB = dteGraduation.Text & " " & cboGradHr.Text & ":" & cboGradMin.Text

        students(studentCount).gender = txtGender.Text
        students(studentCount).avMk = txtAvMk.Text
        students(studentCount).AmountPaid = txtFeeTotalPaid.Text


        studentCount = studentCount + 1

        'return text boxes to blank ready for next entry
        txtFirstName.Text = ""
        txtLastName.Text = ""
        txtDOB.Text = ""
        txtGender.Text = ""
        txtAvMk.Text = ""


        If subjectcount > 3 Or subjectcount = 0 Then
            MsgBox("Please enter the right amount of subjects: 1 - 3. ", MsgBoxStyle.Critical, "Subject Validation")
            txtFeeTotalPaid.Focus()
            Exit Sub

        End If

        displayList()

    End Sub

    Private Sub displayList()

        'clear the list box as it keeps the earlier loop
        lstStud.Items.Clear()
        'loop through the array to print all rows
        For i = 0 To studentCount - 1
            students(studentCount).subPho = vbYes
            lstStud.Items.Add(students(i).firstname & ", " & students(i).lastname & ", " & students(i).DOB & ", " & students(i).gender & ", " & students(i).avMk & ", Yr" & students(i).stYear & ", Sci " & students(i).subSci & ", Pho " & students(i).subPho & ".")
        Next
    End Sub
    Private Sub calcUnitTotal()
        txtUnitCountCalc.Text = unitCount
        txtFeeTotalCalc.Text = feeEnrol + unitCount * feePerUnit
    End Sub

    Private Sub txtFirstName_TextChanged(sender As Object, e As EventArgs) Handles txtFirstName.Leave
        If txtFirstName.Text = "" Then
            MsgBox("Please enter a First Name", MsgBoxStyle.Critical, "First name Validation")
            txtFirstName.Focus()  'put cursor here
            Exit Sub
        End If
        If Len(txtFirstName.Text) > 30 Then
            MsgBox("Please shorten the First Name " & txtFirstName.Text & " " & Len(txtFirstName.Text), MsgBoxStyle.Critical, "First name Validation")
            txtFirstName.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub txtLastName_TextChanged(sender As Object, e As EventArgs) Handles txtLastName.Leave
        'VALIDATION of Last Name
        If txtLastName.Text = "" Then
            MsgBox("Please enter a Last Name", MsgBoxStyle.Critical, "Name validation")
            txtLastName.Focus()
            Exit Sub
        End If
        If Len(txtLastName.Text) > 30 Then
            MsgBox("Please shorten the Last Name " & txtFirstName.Text & " " & Len(txtFirstName.Text), MsgBoxStyle.Critical, "Name validation")
            txtLastName.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub txtGender_TextChanged(sender As Object, e As EventArgs) Handles txtGender.Leave
        'VALIDATION of Gender
        If txtGender.Text = "" Then
            MsgBox("Please enter 'm' of 'f'!", MsgBoxStyle.Critical, "Gender validation")
            txtGender.Focus()
            Exit Sub
        End If
        'Note the syntax necessary to make this work
        If Not (txtGender.Text = "m" Or txtGender.Text = "f" Or txtGender.Text = "M" Or txtGender.Text = "F") Then
            MsgBox("Please enter 'm' of 'f'!", MsgBoxStyle.Critical, "Gender Validation")
            txtGender.Focus()
            Exit Sub
        End If

        'Alternative code from Johan
        ''''If txtGender.Text = "m" Then
        ''''ElseIf txtGender.Text = "M" Then
        ''''ElseIf txtGender.Text = "f" Then
        ''''ElseIf txtGender.Text = "F" Then
        ''''Else MsgBox("Please enter 'm' of 'f'!", MsgBoxStyle.Critical)
        ''''    txtGender.Focus()
        ''''    Exit Sub
        ''''End If
    End Sub

    Private Sub txtAvMk_TextChanged(sender As Object, e As EventArgs) Handles txtAvMk.Leave
        If txtAvMk.Text = "" Then
            MsgBox("Please enter a mark", MsgBoxStyle.Critical, "Mark Validation")
            txtAvMk.Focus()
            Exit Sub
        End If
        If IsNumeric(txtAvMk.Text) = False Then
            MsgBox("Please enter a number", MsgBoxStyle.Critical, "Mark Validation")
            txtAvMk.Focus()
            Exit Sub
        End If
        If txtAvMk.Text > 100 Then
            MsgBox("Please enter a number below 100", MsgBoxStyle.Critical, "Mark Validation")
            txtAvMk.Focus()
            Exit Sub
        End If
        If txtAvMk.Text < 0 Then
            MsgBox("Please enter a mark between 1 and 100", MsgBoxStyle.Critical)
            txtAvMk.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub dteGraduation_ValueChanged(sender As Object, e As EventArgs) Handles dteGraduation.ValueChanged
        'VALIDATION of Grad Date - not really necessary with a picker!!!
        If Not IsDate(dteGraduation.Text) Then
            MsgBox("Please enter a date in the format 'dd/mm/yy' format!", MsgBoxStyle.Critical, "Date validation")
            dteGraduation.Focus()
            Exit Sub
        End If
    End Sub


    Private Sub chkSubjMaths2U_CheckedChanged(sender As Object, e As EventArgs) Handles chkSubjMaths2U.CheckedChanged
        If chkSubjMaths2U.Checked Then
            unitCount = unitCount + Convert.ToInt16(txtUnitMath.Text)
            subjectcount = subjectcount + 1
        Else
            unitCount = unitCount - Convert.ToInt16(txtUnitMath.Text)
            subjectcount = subjectcount - 1
        End If
        calcUnitTotal()
        chkSubjMaths2U.Focus()
    End Sub



    Private Sub chkSubjMathsExt1U_CheckedChanged(sender As Object, e As EventArgs) Handles chkSubjMathsExt1U.CheckedChanged
        If chkSubjMathsExt1U.Checked Then
            unitCount = unitCount + Convert.ToInt16(txtUnitMathExt.Text)
            subjectcount = subjectcount + 1
        Else
            unitCount = unitCount - Convert.ToInt16(txtUnitMathExt.Text)
            subjectcount = subjectcount - 1
        End If
        calcUnitTotal()
        chkSubjMathsExt1U.Focus()
    End Sub

    Private Sub chkSubjEng2U_CheckedChanged(sender As Object, e As EventArgs) Handles chkSubjEng2U.CheckedChanged
        If chkSubjEng2U.Checked Then
            unitCount = unitCount + Convert.ToInt16(txtUnitEng.Text)
            subjectcount = subjectcount + 1
        Else
            unitCount = unitCount - Convert.ToInt16(txtUnitEng.Text)
            subjectcount = subjectcount - 1
        End If
        calcUnitTotal()
        chkSubjEng2U.Focus()
    End Sub

    Private Sub chkSubjSci2U_CheckedChanged(sender As Object, e As EventArgs) Handles chkSubjSci2U.CheckedChanged
        If chkSubjSci2U.Checked Then
            unitCount = unitCount + Convert.ToInt16(txtUnitSci.Text)
            subjectcount = subjectcount + 1
        Else
            unitCount = unitCount - Convert.ToInt16(txtUnitSci.Text)
            subjectcount = subjectcount - 1
        End If
        calcUnitTotal()
        chkSubjSci2U.Focus()
    End Sub

    Private Sub chkSubjPho1U_CheckedChanged(sender As Object, e As EventArgs) Handles chkSubjPho1U.CheckedChanged
        If chkSubjPho1U.Checked Then
            unitCount = unitCount + Convert.ToInt16(txtUnitPho.Text)
            subjectcount = subjectcount + 1
        Else
            unitCount = unitCount - Convert.ToInt16(txtUnitPho.Text)
            subjectcount = subjectcount - 1
        End If
        calcUnitTotal()
        chkSubjPho1U.Focus()
    End Sub


    Private Sub radYr10_CheckedChanged(sender As Object, e As EventArgs) Handles radYr10.CheckedChanged
        If radYr10.Checked Then
            students(studentCount).stYear = 10
        End If
    End Sub

    Private Sub radYr11_CheckedChanged(sender As Object, e As EventArgs) Handles radYr11.CheckedChanged
        If radYr11.Checked Then
            students(studentCount).stYear = 11
        End If
    End Sub

    Private Sub radYr12_CheckedChanged(sender As Object, e As EventArgs) Handles radYr12.CheckedChanged
        If radYr12.Checked Then
            students(studentCount).stYear = 12
        End If
    End Sub

    Private Sub btnFindStudent_Click(sender As Object, e As EventArgs) Handles btnFindStudent.Click
        Dim foundName = False
        Dim searchCount As Integer = 0

        'MsgBox("Test upper function " & UCase(txtLastName.Text))

        While searchCount < studentCount And foundName = False

            If UCase(students(searchCount).lastname) = UCase(txtFind.Text) Then

                foundName = True
            Else
                searchCount = searchCount + 1
            End If

        End While

        If foundName Then
            lstStud.Items.Add("Your student is " & students(searchCount).firstname & " - " & students(searchCount).lastname & " - " & students(searchCount).DOB & " - " & students(searchCount).gender & " - " & students(searchCount).avMk & ".")
        Else
            lstStud.Items.Add("This student cannot be found! ")
        End If
    End Sub

    Private Sub txtFeeTotalPaid_Leave(sender As Object, e As EventArgs) Handles txtFeeTotalPaid.Leave
        If IsNumeric(txtFeeTotalPaid.Text) = False Then
            MsgBox("Please enter a number", MsgBoxStyle.Critical, "Mark validation")
            txtFeeTotalPaid.Focus()
            Exit Sub
        End If
        If txtFeeTotalPaid.Text = txtFeeTotalCalc.Text Then
            Exit Sub
        Else MsgBox("Please enter the correct ammount", MsgBoxStyle.Critical, "Mark validation")
            txtFeeTotalPaid.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub txtFeeTotalPaid_TextChanged(sender As Object, e As EventArgs) Handles txtFeeTotalPaid.TextChanged

    End Sub
End Class
