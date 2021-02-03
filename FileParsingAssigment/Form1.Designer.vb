<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAnswerKey = New System.Windows.Forms.TextBox()
        Me.rbtTest1 = New System.Windows.Forms.RadioButton()
        Me.rbtnTest2 = New System.Windows.Forms.RadioButton()
        Me.lstvStudent = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnStudentGrades = New System.Windows.Forms.Button()
        Me.lstAverage = New System.Windows.Forms.ListView()
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnPlacement = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtAverage = New System.Windows.Forms.TextBox()
        Me.txthighestMark = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtLowestMark = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lstTopClass = New System.Windows.Forms.ListView()
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lstNeedsImprove = New System.Windows.Forms.ListView()
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1038, 204)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 216)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(211, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Correct Answer Key :"
        Me.Label1.Visible = False
        '
        'txtAnswerKey
        '
        Me.txtAnswerKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAnswerKey.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnswerKey.Location = New System.Drawing.Point(229, 214)
        Me.txtAnswerKey.Name = "txtAnswerKey"
        Me.txtAnswerKey.Size = New System.Drawing.Size(435, 30)
        Me.txtAnswerKey.TabIndex = 2
        Me.txtAnswerKey.Visible = False
        '
        'rbtTest1
        '
        Me.rbtTest1.AutoSize = True
        Me.rbtTest1.Checked = True
        Me.rbtTest1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtTest1.ForeColor = System.Drawing.Color.White
        Me.rbtTest1.Location = New System.Drawing.Point(16, 254)
        Me.rbtTest1.Name = "rbtTest1"
        Me.rbtTest1.Size = New System.Drawing.Size(72, 22)
        Me.rbtTest1.TabIndex = 3
        Me.rbtTest1.Text = "Test 1"
        Me.rbtTest1.UseVisualStyleBackColor = True
        '
        'rbtnTest2
        '
        Me.rbtnTest2.AutoSize = True
        Me.rbtnTest2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnTest2.ForeColor = System.Drawing.Color.White
        Me.rbtnTest2.Location = New System.Drawing.Point(110, 254)
        Me.rbtnTest2.Name = "rbtnTest2"
        Me.rbtnTest2.Size = New System.Drawing.Size(72, 22)
        Me.rbtnTest2.TabIndex = 4
        Me.rbtnTest2.Text = "Test 2"
        Me.rbtnTest2.UseVisualStyleBackColor = True
        '
        'lstvStudent
        '
        Me.lstvStudent.AllowColumnReorder = True
        Me.lstvStudent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstvStudent.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.lstvStudent.GridLines = True
        Me.lstvStudent.HideSelection = False
        Me.lstvStudent.LabelWrap = False
        Me.lstvStudent.Location = New System.Drawing.Point(16, 285)
        Me.lstvStudent.Name = "lstvStudent"
        Me.lstvStudent.Size = New System.Drawing.Size(345, 349)
        Me.lstvStudent.TabIndex = 5
        Me.lstvStudent.UseCompatibleStateImageBehavior = False
        Me.lstvStudent.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Student Name"
        Me.ColumnHeader1.Width = 200
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Mark"
        Me.ColumnHeader2.Width = 70
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Grade"
        Me.ColumnHeader3.Width = 70
        '
        'btnStudentGrades
        '
        Me.btnStudentGrades.BackColor = System.Drawing.Color.Transparent
        Me.btnStudentGrades.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnStudentGrades.FlatAppearance.BorderSize = 2
        Me.btnStudentGrades.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.btnStudentGrades.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnStudentGrades.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod
        Me.btnStudentGrades.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStudentGrades.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStudentGrades.ForeColor = System.Drawing.Color.White
        Me.btnStudentGrades.Location = New System.Drawing.Point(16, 639)
        Me.btnStudentGrades.Name = "btnStudentGrades"
        Me.btnStudentGrades.Size = New System.Drawing.Size(345, 36)
        Me.btnStudentGrades.TabIndex = 6
        Me.btnStudentGrades.Text = "&Get Student Grade"
        Me.btnStudentGrades.UseVisualStyleBackColor = False
        '
        'lstAverage
        '
        Me.lstAverage.AllowColumnReorder = True
        Me.lstAverage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstAverage.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader4})
        Me.lstAverage.GridLines = True
        Me.lstAverage.HideSelection = False
        Me.lstAverage.LabelWrap = False
        Me.lstAverage.Location = New System.Drawing.Point(367, 285)
        Me.lstAverage.Name = "lstAverage"
        Me.lstAverage.Size = New System.Drawing.Size(205, 349)
        Me.lstAverage.TabIndex = 7
        Me.lstAverage.UseCompatibleStateImageBehavior = False
        Me.lstAverage.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Student Name"
        Me.ColumnHeader4.Width = 200
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(367, 254)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(205, 28)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Relative To Average"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnPlacement
        '
        Me.btnPlacement.BackColor = System.Drawing.Color.Transparent
        Me.btnPlacement.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnPlacement.FlatAppearance.BorderSize = 2
        Me.btnPlacement.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.btnPlacement.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnPlacement.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod
        Me.btnPlacement.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPlacement.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlacement.ForeColor = System.Drawing.Color.White
        Me.btnPlacement.Location = New System.Drawing.Point(367, 639)
        Me.btnPlacement.Name = "btnPlacement"
        Me.btnPlacement.Size = New System.Drawing.Size(205, 36)
        Me.btnPlacement.TabIndex = 9
        Me.btnPlacement.Text = "&Placement"
        Me.btnPlacement.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(580, 254)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(205, 24)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Summary Info"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtLowestMark)
        Me.GroupBox1.Controls.Add(Me.txthighestMark)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtAverage)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(578, 276)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(207, 366)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(13, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(182, 28)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Average Mark"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtAverage
        '
        Me.txtAverage.BackColor = System.Drawing.Color.White
        Me.txtAverage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAverage.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAverage.Location = New System.Drawing.Point(13, 50)
        Me.txtAverage.Name = "txtAverage"
        Me.txtAverage.ReadOnly = True
        Me.txtAverage.Size = New System.Drawing.Size(182, 30)
        Me.txtAverage.TabIndex = 12
        Me.txtAverage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txthighestMark
        '
        Me.txthighestMark.BackColor = System.Drawing.Color.White
        Me.txthighestMark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txthighestMark.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txthighestMark.Location = New System.Drawing.Point(13, 179)
        Me.txthighestMark.Name = "txthighestMark"
        Me.txthighestMark.ReadOnly = True
        Me.txthighestMark.Size = New System.Drawing.Size(182, 30)
        Me.txthighestMark.TabIndex = 14
        Me.txthighestMark.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(13, 151)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(182, 28)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Highest Mark"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtLowestMark
        '
        Me.txtLowestMark.BackColor = System.Drawing.Color.White
        Me.txtLowestMark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLowestMark.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLowestMark.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.txtLowestMark.Location = New System.Drawing.Point(13, 323)
        Me.txtLowestMark.Name = "txtLowestMark"
        Me.txtLowestMark.ReadOnly = True
        Me.txtLowestMark.Size = New System.Drawing.Size(182, 30)
        Me.txtLowestMark.TabIndex = 14
        Me.txtLowestMark.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(13, 295)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(182, 28)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Lowest Mark"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(803, 254)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(204, 28)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Top Of the Class"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lstTopClass
        '
        Me.lstTopClass.AllowColumnReorder = True
        Me.lstTopClass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstTopClass.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader5})
        Me.lstTopClass.GridLines = True
        Me.lstTopClass.HideSelection = False
        Me.lstTopClass.LabelWrap = False
        Me.lstTopClass.Location = New System.Drawing.Point(803, 285)
        Me.lstTopClass.Name = "lstTopClass"
        Me.lstTopClass.Size = New System.Drawing.Size(204, 174)
        Me.lstTopClass.TabIndex = 13
        Me.lstTopClass.UseCompatibleStateImageBehavior = False
        Me.lstTopClass.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Student Name"
        Me.ColumnHeader5.Width = 200
        '
        'Label8
        '
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(803, 464)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(204, 28)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Needs To Improve"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lstNeedsImprove
        '
        Me.lstNeedsImprove.AllowColumnReorder = True
        Me.lstNeedsImprove.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstNeedsImprove.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader6})
        Me.lstNeedsImprove.GridLines = True
        Me.lstNeedsImprove.HideSelection = False
        Me.lstNeedsImprove.LabelWrap = False
        Me.lstNeedsImprove.Location = New System.Drawing.Point(803, 496)
        Me.lstNeedsImprove.Name = "lstNeedsImprove"
        Me.lstNeedsImprove.Size = New System.Drawing.Size(204, 145)
        Me.lstNeedsImprove.TabIndex = 15
        Me.lstNeedsImprove.UseCompatibleStateImageBehavior = False
        Me.lstNeedsImprove.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Student Name"
        Me.ColumnHeader6.Width = 200
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.BorderSize = 2
        Me.Button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(803, 648)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 32)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "&Reset"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button2.FlatAppearance.BorderSize = 2
        Me.Button2.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(918, 648)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(89, 32)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "&Exit"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1038, 684)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lstNeedsImprove)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lstTopClass)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnPlacement)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lstAverage)
        Me.Controls.Add(Me.btnStudentGrades)
        Me.Controls.Add(Me.lstvStudent)
        Me.Controls.Add(Me.rbtnTest2)
        Me.Controls.Add(Me.rbtTest1)
        Me.Controls.Add(Me.txtAnswerKey)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Parse College Student Grades"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtAnswerKey As System.Windows.Forms.TextBox
    Friend WithEvents rbtTest1 As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnTest2 As System.Windows.Forms.RadioButton
    Friend WithEvents lstvStudent As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnStudentGrades As System.Windows.Forms.Button
    Friend WithEvents lstAverage As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnPlacement As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtAverage As System.Windows.Forms.TextBox
    Friend WithEvents txthighestMark As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtLowestMark As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lstTopClass As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lstNeedsImprove As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button

End Class
