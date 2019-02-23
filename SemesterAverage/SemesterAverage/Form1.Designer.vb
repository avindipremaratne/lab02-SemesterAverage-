<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSemesterGrades
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lbCourse1 = New System.Windows.Forms.Label()
        Me.lbCourse2 = New System.Windows.Forms.Label()
        Me.lbCourse3 = New System.Windows.Forms.Label()
        Me.lbCourse4 = New System.Windows.Forms.Label()
        Me.lbCourse5 = New System.Windows.Forms.Label()
        Me.lbCourse6 = New System.Windows.Forms.Label()
        Me.lbOutput = New System.Windows.Forms.Label()
        Me.lbSemester = New System.Windows.Forms.Label()
        Me.tbCourse1 = New System.Windows.Forms.TextBox()
        Me.tbCourse2 = New System.Windows.Forms.TextBox()
        Me.tbCourse3 = New System.Windows.Forms.TextBox()
        Me.tbCourse4 = New System.Windows.Forms.TextBox()
        Me.tbCourse5 = New System.Windows.Forms.TextBox()
        Me.tbCourse6 = New System.Windows.Forms.TextBox()
        Me.tbSemester = New System.Windows.Forms.TextBox()
        Me.lbCourse1Output = New System.Windows.Forms.Label()
        Me.lbCourse2Output = New System.Windows.Forms.Label()
        Me.lbCourse3Output = New System.Windows.Forms.Label()
        Me.lbCourse4Output = New System.Windows.Forms.Label()
        Me.lbCourse5Output = New System.Windows.Forms.Label()
        Me.lbCourse6Output = New System.Windows.Forms.Label()
        Me.lbSemesterOutput = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbCourse1
        '
        Me.lbCourse1.Location = New System.Drawing.Point(27, 24)
        Me.lbCourse1.Name = "lbCourse1"
        Me.lbCourse1.Size = New System.Drawing.Size(63, 23)
        Me.lbCourse1.TabIndex = 0
        Me.lbCourse1.Text = "Course &1:"
        Me.lbCourse1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbCourse2
        '
        Me.lbCourse2.Location = New System.Drawing.Point(37, 60)
        Me.lbCourse2.Name = "lbCourse2"
        Me.lbCourse2.Size = New System.Drawing.Size(53, 19)
        Me.lbCourse2.TabIndex = 1
        Me.lbCourse2.Text = "Course &2:"
        Me.lbCourse2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbCourse3
        '
        Me.lbCourse3.Location = New System.Drawing.Point(30, 95)
        Me.lbCourse3.Name = "lbCourse3"
        Me.lbCourse3.Size = New System.Drawing.Size(60, 20)
        Me.lbCourse3.TabIndex = 2
        Me.lbCourse3.Text = "Course &3:"
        Me.lbCourse3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbCourse4
        '
        Me.lbCourse4.Location = New System.Drawing.Point(38, 131)
        Me.lbCourse4.Name = "lbCourse4"
        Me.lbCourse4.Size = New System.Drawing.Size(52, 19)
        Me.lbCourse4.TabIndex = 3
        Me.lbCourse4.Text = "Course &4:"
        Me.lbCourse4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbCourse5
        '
        Me.lbCourse5.Location = New System.Drawing.Point(30, 168)
        Me.lbCourse5.Name = "lbCourse5"
        Me.lbCourse5.Size = New System.Drawing.Size(60, 19)
        Me.lbCourse5.TabIndex = 4
        Me.lbCourse5.Text = "Course &5:"
        Me.lbCourse5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbCourse6
        '
        Me.lbCourse6.Location = New System.Drawing.Point(29, 204)
        Me.lbCourse6.Name = "lbCourse6"
        Me.lbCourse6.Size = New System.Drawing.Size(60, 22)
        Me.lbCourse6.TabIndex = 5
        Me.lbCourse6.Text = "Course &6:"
        Me.lbCourse6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbOutput
        '
        Me.lbOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbOutput.Location = New System.Drawing.Point(2, 262)
        Me.lbOutput.Name = "lbOutput"
        Me.lbOutput.Size = New System.Drawing.Size(324, 161)
        Me.lbOutput.TabIndex = 6
        '
        'lbSemester
        '
        Me.lbSemester.Location = New System.Drawing.Point(34, 235)
        Me.lbSemester.Name = "lbSemester"
        Me.lbSemester.Size = New System.Drawing.Size(54, 23)
        Me.lbSemester.TabIndex = 7
        Me.lbSemester.Text = "&Semester"
        Me.lbSemester.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tbCourse1
        '
        Me.tbCourse1.Location = New System.Drawing.Point(96, 26)
        Me.tbCourse1.Name = "tbCourse1"
        Me.tbCourse1.Size = New System.Drawing.Size(100, 20)
        Me.tbCourse1.TabIndex = 8
        Me.tbCourse1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbCourse2
        '
        Me.tbCourse2.Location = New System.Drawing.Point(96, 60)
        Me.tbCourse2.Name = "tbCourse2"
        Me.tbCourse2.Size = New System.Drawing.Size(100, 20)
        Me.tbCourse2.TabIndex = 9
        Me.tbCourse2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbCourse3
        '
        Me.tbCourse3.Location = New System.Drawing.Point(97, 94)
        Me.tbCourse3.Name = "tbCourse3"
        Me.tbCourse3.Size = New System.Drawing.Size(100, 20)
        Me.tbCourse3.TabIndex = 10
        Me.tbCourse3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbCourse4
        '
        Me.tbCourse4.Location = New System.Drawing.Point(97, 129)
        Me.tbCourse4.Name = "tbCourse4"
        Me.tbCourse4.Size = New System.Drawing.Size(100, 20)
        Me.tbCourse4.TabIndex = 11
        Me.tbCourse4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbCourse5
        '
        Me.tbCourse5.Location = New System.Drawing.Point(97, 166)
        Me.tbCourse5.Name = "tbCourse5"
        Me.tbCourse5.Size = New System.Drawing.Size(100, 20)
        Me.tbCourse5.TabIndex = 12
        Me.tbCourse5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbCourse6
        '
        Me.tbCourse6.Location = New System.Drawing.Point(96, 204)
        Me.tbCourse6.Name = "tbCourse6"
        Me.tbCourse6.Size = New System.Drawing.Size(100, 20)
        Me.tbCourse6.TabIndex = 13
        Me.tbCourse6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbSemester
        '
        Me.tbSemester.Location = New System.Drawing.Point(96, 237)
        Me.tbSemester.Name = "tbSemester"
        Me.tbSemester.Size = New System.Drawing.Size(100, 20)
        Me.tbSemester.TabIndex = 14
        Me.tbSemester.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbCourse1Output
        '
        Me.lbCourse1Output.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbCourse1Output.Location = New System.Drawing.Point(203, 26)
        Me.lbCourse1Output.Name = "lbCourse1Output"
        Me.lbCourse1Output.Size = New System.Drawing.Size(123, 23)
        Me.lbCourse1Output.TabIndex = 15
        Me.lbCourse1Output.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbCourse2Output
        '
        Me.lbCourse2Output.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbCourse2Output.Location = New System.Drawing.Point(202, 58)
        Me.lbCourse2Output.Name = "lbCourse2Output"
        Me.lbCourse2Output.Size = New System.Drawing.Size(123, 23)
        Me.lbCourse2Output.TabIndex = 16
        Me.lbCourse2Output.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbCourse3Output
        '
        Me.lbCourse3Output.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbCourse3Output.Location = New System.Drawing.Point(203, 91)
        Me.lbCourse3Output.Name = "lbCourse3Output"
        Me.lbCourse3Output.Size = New System.Drawing.Size(123, 23)
        Me.lbCourse3Output.TabIndex = 17
        Me.lbCourse3Output.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbCourse4Output
        '
        Me.lbCourse4Output.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbCourse4Output.Location = New System.Drawing.Point(202, 127)
        Me.lbCourse4Output.Name = "lbCourse4Output"
        Me.lbCourse4Output.Size = New System.Drawing.Size(123, 23)
        Me.lbCourse4Output.TabIndex = 18
        Me.lbCourse4Output.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbCourse5Output
        '
        Me.lbCourse5Output.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbCourse5Output.Location = New System.Drawing.Point(203, 164)
        Me.lbCourse5Output.Name = "lbCourse5Output"
        Me.lbCourse5Output.Size = New System.Drawing.Size(123, 23)
        Me.lbCourse5Output.TabIndex = 19
        Me.lbCourse5Output.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbCourse6Output
        '
        Me.lbCourse6Output.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbCourse6Output.Location = New System.Drawing.Point(202, 204)
        Me.lbCourse6Output.Name = "lbCourse6Output"
        Me.lbCourse6Output.Size = New System.Drawing.Size(123, 23)
        Me.lbCourse6Output.TabIndex = 20
        Me.lbCourse6Output.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbSemesterOutput
        '
        Me.lbSemesterOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbSemesterOutput.Location = New System.Drawing.Point(202, 235)
        Me.lbSemesterOutput.Name = "lbSemesterOutput"
        Me.lbSemesterOutput.Size = New System.Drawing.Size(123, 23)
        Me.lbSemesterOutput.TabIndex = 21
        Me.lbSemesterOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(33, 426)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 22
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(133, 425)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 23
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(227, 425)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 24
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmSemesterGrades
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(330, 461)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lbSemesterOutput)
        Me.Controls.Add(Me.lbCourse6Output)
        Me.Controls.Add(Me.lbCourse5Output)
        Me.Controls.Add(Me.lbCourse4Output)
        Me.Controls.Add(Me.lbCourse3Output)
        Me.Controls.Add(Me.lbCourse2Output)
        Me.Controls.Add(Me.lbCourse1Output)
        Me.Controls.Add(Me.tbSemester)
        Me.Controls.Add(Me.tbCourse6)
        Me.Controls.Add(Me.tbCourse5)
        Me.Controls.Add(Me.tbCourse4)
        Me.Controls.Add(Me.tbCourse3)
        Me.Controls.Add(Me.tbCourse2)
        Me.Controls.Add(Me.tbCourse1)
        Me.Controls.Add(Me.lbSemester)
        Me.Controls.Add(Me.lbOutput)
        Me.Controls.Add(Me.lbCourse6)
        Me.Controls.Add(Me.lbCourse5)
        Me.Controls.Add(Me.lbCourse4)
        Me.Controls.Add(Me.lbCourse3)
        Me.Controls.Add(Me.lbCourse2)
        Me.Controls.Add(Me.lbCourse1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSemesterGrades"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Semester Grades"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbCourse1 As Label
    Friend WithEvents lbCourse2 As Label
    Friend WithEvents lbCourse3 As Label
    Friend WithEvents lbCourse4 As Label
    Friend WithEvents lbCourse5 As Label
    Friend WithEvents lbCourse6 As Label
    Friend WithEvents lbOutput As Label
    Friend WithEvents lbSemester As Label
    Friend WithEvents tbCourse1 As TextBox
    Friend WithEvents tbCourse2 As TextBox
    Friend WithEvents tbCourse3 As TextBox
    Friend WithEvents tbCourse4 As TextBox
    Friend WithEvents tbCourse5 As TextBox
    Friend WithEvents tbCourse6 As TextBox
    Friend WithEvents tbSemester As TextBox
    Friend WithEvents lbCourse1Output As Label
    Friend WithEvents lbCourse2Output As Label
    Friend WithEvents lbCourse3Output As Label
    Friend WithEvents lbCourse4Output As Label
    Friend WithEvents lbCourse5Output As Label
    Friend WithEvents lbCourse6Output As Label
    Friend WithEvents lbSemesterOutput As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
End Class
