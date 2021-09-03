<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lstComments = New System.Windows.Forms.ListBox()
        Me.txtExam = New System.Windows.Forms.TextBox()
        Me.txtCat2 = New System.Windows.Forms.TextBox()
        Me.txtCat1 = New System.Windows.Forms.TextBox()
        Me.txtRegno = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnDetermine = New System.Windows.Forms.Button()
        Me.rdbtnSem2 = New System.Windows.Forms.RadioButton()
        Me.rdbtnSem1 = New System.Windows.Forms.RadioButton()
        Me.cmbxUnits = New System.Windows.Forms.ComboBox()
        Me.cmbxCourses = New System.Windows.Forms.ComboBox()
        Me.cmbxCollege = New System.Windows.Forms.ComboBox()
        Me.cmbxYear = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.errProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.errorRegno = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.errorCat2 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.errorExam = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnExit = New System.Windows.Forms.Button()
        Me.errorCat1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.errProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errorRegno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errorCat2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errorExam, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errorCat1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.lstComments)
        Me.GroupBox1.Controls.Add(Me.txtExam)
        Me.GroupBox1.Controls.Add(Me.txtCat2)
        Me.GroupBox1.Controls.Add(Me.txtCat1)
        Me.GroupBox1.Controls.Add(Me.txtRegno)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.btnDetermine)
        Me.GroupBox1.Controls.Add(Me.rdbtnSem2)
        Me.GroupBox1.Controls.Add(Me.rdbtnSem1)
        Me.GroupBox1.Controls.Add(Me.cmbxUnits)
        Me.GroupBox1.Controls.Add(Me.cmbxCourses)
        Me.GroupBox1.Controls.Add(Me.cmbxCollege)
        Me.GroupBox1.Controls.Add(Me.cmbxYear)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(41, 71)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(803, 454)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(467, 283)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(74, 17)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Comments"
        '
        'lstComments
        '
        Me.lstComments.FormattingEnabled = True
        Me.lstComments.ItemHeight = 16
        Me.lstComments.Location = New System.Drawing.Point(478, 325)
        Me.lstComments.Name = "lstComments"
        Me.lstComments.Size = New System.Drawing.Size(300, 100)
        Me.lstComments.TabIndex = 18
        '
        'txtExam
        '
        Me.txtExam.Location = New System.Drawing.Point(163, 225)
        Me.txtExam.Name = "txtExam"
        Me.txtExam.Size = New System.Drawing.Size(100, 22)
        Me.txtExam.TabIndex = 17
        '
        'txtCat2
        '
        Me.txtCat2.Location = New System.Drawing.Point(163, 162)
        Me.txtCat2.Name = "txtCat2"
        Me.txtCat2.Size = New System.Drawing.Size(100, 22)
        Me.txtCat2.TabIndex = 16
        '
        'txtCat1
        '
        Me.txtCat1.Location = New System.Drawing.Point(163, 102)
        Me.txtCat1.Name = "txtCat1"
        Me.txtCat1.Size = New System.Drawing.Size(100, 22)
        Me.txtCat1.TabIndex = 15
        '
        'txtRegno
        '
        Me.txtRegno.Location = New System.Drawing.Point(163, 45)
        Me.txtRegno.Name = "txtRegno"
        Me.txtRegno.Size = New System.Drawing.Size(100, 22)
        Me.txtRegno.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.Info
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(31, 225)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(102, 20)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "MAIN EXAM"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.Info
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(31, 162)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 20)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "CAT 2"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.Info
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(31, 102)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 20)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "CAT 1"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Info
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(31, 45)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 20)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "REG NO"
        '
        'btnDetermine
        '
        Me.btnDetermine.Location = New System.Drawing.Point(228, 283)
        Me.btnDetermine.Name = "btnDetermine"
        Me.btnDetermine.Size = New System.Drawing.Size(120, 23)
        Me.btnDetermine.TabIndex = 9
        Me.btnDetermine.Text = "DETERMINE"
        Me.btnDetermine.UseVisualStyleBackColor = True
        '
        'rdbtnSem2
        '
        Me.rdbtnSem2.AutoSize = True
        Me.rdbtnSem2.Location = New System.Drawing.Point(582, 241)
        Me.rdbtnSem2.Name = "rdbtnSem2"
        Me.rdbtnSem2.Size = New System.Drawing.Size(101, 21)
        Me.rdbtnSem2.TabIndex = 8
        Me.rdbtnSem2.TabStop = True
        Me.rdbtnSem2.Text = "Semester 2"
        Me.rdbtnSem2.UseVisualStyleBackColor = True
        '
        'rdbtnSem1
        '
        Me.rdbtnSem1.AutoSize = True
        Me.rdbtnSem1.Location = New System.Drawing.Point(453, 241)
        Me.rdbtnSem1.Name = "rdbtnSem1"
        Me.rdbtnSem1.Size = New System.Drawing.Size(101, 21)
        Me.rdbtnSem1.TabIndex = 1
        Me.rdbtnSem1.TabStop = True
        Me.rdbtnSem1.Text = "Semester 1"
        Me.rdbtnSem1.UseVisualStyleBackColor = True
        '
        'cmbxUnits
        '
        Me.cmbxUnits.FormattingEnabled = True
        Me.cmbxUnits.Location = New System.Drawing.Point(478, 196)
        Me.cmbxUnits.Name = "cmbxUnits"
        Me.cmbxUnits.Size = New System.Drawing.Size(205, 24)
        Me.cmbxUnits.TabIndex = 7
        '
        'cmbxCourses
        '
        Me.cmbxCourses.FormattingEnabled = True
        Me.cmbxCourses.Location = New System.Drawing.Point(478, 129)
        Me.cmbxCourses.Name = "cmbxCourses"
        Me.cmbxCourses.Size = New System.Drawing.Size(205, 24)
        Me.cmbxCourses.TabIndex = 6
        '
        'cmbxCollege
        '
        Me.cmbxCollege.FormattingEnabled = True
        Me.cmbxCollege.Location = New System.Drawing.Point(478, 79)
        Me.cmbxCollege.Name = "cmbxCollege"
        Me.cmbxCollege.Size = New System.Drawing.Size(205, 24)
        Me.cmbxCollege.TabIndex = 5
        '
        'cmbxYear
        '
        Me.cmbxYear.FormattingEnabled = True
        Me.cmbxYear.Location = New System.Drawing.Point(478, 29)
        Me.cmbxYear.Name = "cmbxYear"
        Me.cmbxYear.Size = New System.Drawing.Size(205, 24)
        Me.cmbxYear.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(349, 196)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Unit"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(347, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Course"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(347, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "College"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(344, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Year"
        '
        'errProvider
        '
        Me.errProvider.ContainerControl = Me
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(290, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(277, 29)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "STUDENT DATABASE"
        '
        'errorRegno
        '
        Me.errorRegno.ContainerControl = Me
        '
        'errorCat2
        '
        Me.errorCat2.ContainerControl = Me
        '
        'errorExam
        '
        Me.errorExam.ContainerControl = Me
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(744, 531)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'errorCat1
        '
        Me.errorCat1.ContainerControl = Me
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(769, 24)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Reports"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(856, 570)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.errProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errorRegno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errorCat2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errorExam, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errorCat1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbxUnits As ComboBox
    Friend WithEvents cmbxCourses As ComboBox
    Friend WithEvents cmbxCollege As ComboBox
    Friend WithEvents cmbxYear As ComboBox
    Friend WithEvents rdbtnSem2 As RadioButton
    Friend WithEvents rdbtnSem1 As RadioButton
    Friend WithEvents errProvider As ErrorProvider
    Friend WithEvents btnDetermine As Button
    Friend WithEvents txtExam As TextBox
    Friend WithEvents txtCat2 As TextBox
    Friend WithEvents txtCat1 As TextBox
    Friend WithEvents txtRegno As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents errorRegno As ErrorProvider
    Friend WithEvents errorCat2 As ErrorProvider
    Friend WithEvents errorExam As ErrorProvider
    Friend WithEvents Label10 As Label
    Friend WithEvents lstComments As ListBox
    Friend WithEvents btnExit As Button
    Friend WithEvents errorCat1 As ErrorProvider
    Friend WithEvents Button1 As Button
End Class
