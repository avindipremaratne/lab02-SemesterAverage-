'Program:       SemesterAverage

'Author:        Avindi Premaratne
'Date:          February 02th 2019  
'Description:   A program which calculates the semester average with the letter grade by taking the input for each of the six courses, 
'               displaying the letter grade and finally calculating the semester average with the letter grade.
Option Strict On
Public Class frmSemesterGrades

    ''' <summary>
    '''     Resets form to initial state
    ''' </summary>
    ''' 

    Const MINNUMGRADE = 0                   'stores the minimum value for grade
    Const MAXIMUMGRADE = 100                'stores the maximum value for grade
    Dim courseOne As Double = 0             'stores the grade for course one
    Dim courseTwo As Double = 0             'stores the grade for course two
    Dim courseThree As Double = 0           'stores the grade for course three
    Dim courseFour As Double = 0            'stores the grade for course four    
    Dim courseFive As Double = 0            'stores the grade for course five
    Dim courseSix As Double = 0             'stores the grade for course six
    'Dim totalGrades As Double = 0           
    Dim courseGrades(5) As Double           'declaring the array to store the grades of all the courses


    'Subroutine to reset all the values and enables all the controls for the reset button
    Sub resetForm()
        tbCourse1.Clear()
        tbCourse2.Clear()
        tbCourse3.Clear()
        tbCourse4.Clear()
        tbCourse5.Clear()
        tbCourse6.Clear()
        tbSemester.Clear()

        tbCourse1.Enabled = True
        tbCourse2.Enabled = True
        tbCourse3.Enabled = True
        tbCourse4.Enabled = True
        tbCourse5.Enabled = True
        tbCourse6.Enabled = True

        lbCourse1Output.Text = ""
        lbCourse2Output.Text = ""
        lbCourse3Output.Text = ""
        lbCourse4Output.Text = ""
        lbCourse5Output.Text = ""
        lbCourse6Output.Text = ""
        lbSemesterOutput.Text = ""
        lbOutput.Text = ""

        tbCourse1.Focus()
        btnCalculate.Enabled = True
        tbSemester.Enabled = False
        lbSemesterOutput.Enabled = False

    End Sub

    'Disables the Semester textbox and its label and set forcus on course one textbox.
    Private Sub frmSemesterGrades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbSemester.Enabled = False
        lbSemesterOutput.Enabled = False
        tbCourse1.Focus()
    End Sub



    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lbCourse3Output.Click

    End Sub

    'Exixts the application
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()

    End Sub

    'Calling the resetForm()
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        resetForm()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click


        'stores the total grades for all the courses
        Dim gradeTotal As Double
        'stores the average of all the courses
        Dim semesterAverage As Double

        'Each And every textbox is checked whether it has a numeric value. If it is true it displays an error message.
        If (validateInput(tbCourse1, lbCourse1Output) And validateInput(tbCourse2, lbCourse2Output) And validateInput(tbCourse3, lbCourse3Output) And
        validateInput(tbCourse4, lbCourse4Output) And validateInput(tbCourse5, lbCourse5Output) And validateInput(tbCourse6, lbCourse6Output)) Then


            'Else it would load the values to the array 
            courseGrades(0) = CDbl(tbCourse1.Text)
            courseGrades(1) = CDbl(tbCourse2.Text)
            courseGrades(2) = CDbl(tbCourse3.Text)
            courseGrades(3) = CDbl(tbCourse4.Text)
            courseGrades(4) = CDbl(tbCourse5.Text)
            courseGrades(5) = CDbl(tbCourse6.Text)

            'For each loop to calculate the sum of all the grades
            For Each grade In courseGrades
                gradeTotal += grade
            Next

            'Calculates the semester average and round off to two decimal places
            semesterAverage = Math.Round(gradeTotal / courseGrades.Length, 2)
            'Assign the value to the semester textbox
            tbSemester.Text = semesterAverage.ToString
            'Displays the letter grade for the semester grade
            lbSemesterOutput.Text = convertGrade(semesterAverage)

            'Enable the semester textbox and it's letter grade label
            tbSemester.Enabled = True
            lbSemesterOutput.Enabled = True

            tbCourse1.Enabled = False
            tbCourse2.Enabled = False
            tbCourse3.Enabled = False
            tbCourse4.Enabled = False
            tbCourse5.Enabled = False
            tbCourse6.Enabled = False
            btnCalculate.Enabled = False
            'Set forcus to the reset button
            btnReset.Focus()
        End If


    End Sub

    'Function to determine the letter grade for each course grade input by the user
    Function convertGrade(ByVal grade As Double) As String
        Dim letterGrade As String = ""

        Select Case grade
            Case >= 90
                letterGrade = "A+"
            Case >= 85
                letterGrade = "A"
            Case >= 80
                letterGrade = "A-"
            Case >= 77
                letterGrade = "B+"
            Case >= 73
                letterGrade = "B"
            Case >= 70
                letterGrade = "B-"
            Case >= 67
                letterGrade = "C+"
            Case >= 63
                letterGrade = "C"
            Case >= 60
                letterGrade = "C-"
            Case >= 57
                letterGrade = "D+"
            Case >= 53
                letterGrade = "D"
            Case >= 50
                letterGrade = "D-"
            Case Else
                letterGrade = "F"
        End Select

        Return letterGrade
    End Function

    'Calling the validateInput fuction to each and every textbox and labels in the lost forcus event
    Private Sub tbCourses_Leave(sender As Object, e As EventArgs) Handles tbCourse1.Leave, tbCourse2.Leave, tbCourse3.Leave, tbCourse4.Leave, tbCourse5.Leave, tbCourse6.Leave
        validateInput(tbCourse1, lbCourse1Output)
        validateInput(tbCourse2, lbCourse2Output)
        validateInput(tbCourse3, lbCourse3Output)
        validateInput(tbCourse4, lbCourse4Output)
        validateInput(tbCourse5, lbCourse5Output)
        validateInput(tbCourse6, lbCourse6Output)
    End Sub

    'validateInput function to check the text box value is empty , has a numeric value and between 0 and 100
    Function validateInput(ByRef userGrade As TextBox, ByRef lbletterGrade As Label) As Boolean
        'Holds the user input
        Dim courseGrade As Double
        'Checks whether the textboxes are empty
        If userGrade.Text <> "" Then
            'Checks whether the input in each textbox is numeric
            If Double.TryParse(userGrade.Text, courseGrade) Then
                'Checks whether the input in each textbox is between 0 and 100
                If (courseGrade >= MINNUMGRADE And courseGrade <= MAXIMUMGRADE) Then
                    'Assigns the letter grade for each grade by calling the convertGrade function
                    lbletterGrade.Text = convertGrade(courseGrade)
                    'return boolean value true
                    Return True

                    'Else display the error message 
                Else
                    lbOutput.Text += "Input must be between 0 and 100. Please try again." & vbCrLf

                    'set forcus to the textbox which has the invalid value
                    userGrade.Focus()
                    'selects the text in the textbox which has the invalid value
                    userGrade.SelectAll()
                    'return boolean value false
                    Return False
                End If

                'Else display the error message
            Else
                lbOutput.Text += "Input must be a number. Please try again." & vbCrLf
                'set forcus to the textbox which has the invalid value
                userGrade.Focus()
                'selects the text in the textbox which has the invalid value
                userGrade.SelectAll()
                'return boolean value false
                Return False
            End If
        Else

            'return boolean value false
            Return False
        End If

    End Function

    'Private Sub tbCourse2_Leave(sender As Object, e As EventArgs) Handles 


    'End Sub

    'Private Sub tbCourse3_Leave(sender As Object, e As EventArgs) Handles 


    'End Sub

    'Private Sub tbCourse4_Leave(sender As Object, e As EventArgs) Handles 


    'End Sub

    Private Sub tbCourse5_TextChanged(sender As Object, e As EventArgs) Handles tbCourse5.TextChanged

    End Sub

    Private Sub tbCourse5_Leave(sender As Object, e As EventArgs) Handles tbCourse5.Leave


    End Sub

    Private Sub tbCourse6_Leave(sender As Object, e As EventArgs) Handles tbCourse6.Leave


    End Sub


End Class
