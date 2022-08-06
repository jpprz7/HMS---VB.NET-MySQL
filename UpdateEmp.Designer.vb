<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UpdateEmp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UpdateEmp))
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.email = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lastname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.firstname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.empID = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.contactNum = New System.Windows.Forms.TextBox()
        Me.gender = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Goldenrod
        Me.Button2.Location = New System.Drawing.Point(12, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(70, 26)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Return"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(494, 376)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(95, 23)
        Me.Label15.TabIndex = 44
        Me.Label15.Text = "Gender:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(494, 511)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(78, 23)
        Me.Label13.TabIndex = 40
        Me.Label13.Text = "Email:"
        '
        'email
        '
        Me.email.BackColor = System.Drawing.Color.White
        Me.email.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.email.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.email.Location = New System.Drawing.Point(498, 537)
        Me.email.MaxLength = 50
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(261, 31)
        Me.email.TabIndex = 36
        Me.email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(494, 445)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(191, 23)
        Me.Label12.TabIndex = 38
        Me.Label12.Text = "Contact number:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(153, 516)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(130, 23)
        Me.Label11.TabIndex = 37
        Me.Label11.Text = "Last name:"
        '
        'lastname
        '
        Me.lastname.BackColor = System.Drawing.Color.White
        Me.lastname.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lastname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.lastname.Location = New System.Drawing.Point(157, 542)
        Me.lastname.MaxLength = 50
        Me.lastname.Name = "lastname"
        Me.lastname.Size = New System.Drawing.Size(269, 31)
        Me.lastname.TabIndex = 33
        Me.lastname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(155, 445)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 23)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "First name:"
        '
        'firstname
        '
        Me.firstname.BackColor = System.Drawing.Color.White
        Me.firstname.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.firstname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.firstname.Location = New System.Drawing.Point(157, 471)
        Me.firstname.MaxLength = 50
        Me.firstname.Name = "firstname"
        Me.firstname.Size = New System.Drawing.Size(269, 31)
        Me.firstname.TabIndex = 31
        Me.firstname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(153, 376)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(212, 23)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Employee number:"
        '
        'empID
        '
        Me.empID.BackColor = System.Drawing.Color.White
        Me.empID.Enabled = False
        Me.empID.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.empID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.empID.Location = New System.Drawing.Point(157, 402)
        Me.empID.MaxLength = 20
        Me.empID.Name = "empID"
        Me.empID.ReadOnly = True
        Me.empID.Size = New System.Drawing.Size(220, 31)
        Me.empID.TabIndex = 30
        Me.empID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Goldenrod
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(401, 600)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(130, 42)
        Me.Button1.TabIndex = 37
        Me.Button1.Text = "Update"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'contactNum
        '
        Me.contactNum.BackColor = System.Drawing.Color.White
        Me.contactNum.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.contactNum.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.contactNum.Location = New System.Drawing.Point(498, 471)
        Me.contactNum.MaxLength = 50
        Me.contactNum.Name = "contactNum"
        Me.contactNum.Size = New System.Drawing.Size(263, 31)
        Me.contactNum.TabIndex = 35
        Me.contactNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'gender
        '
        Me.gender.BackColor = System.Drawing.Color.White
        Me.gender.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gender.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.gender.Location = New System.Drawing.Point(498, 402)
        Me.gender.MaxLength = 1
        Me.gender.Name = "gender"
        Me.gender.Size = New System.Drawing.Size(101, 31)
        Me.gender.TabIndex = 34
        Me.gender.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Goldenrod
        Me.Button3.Location = New System.Drawing.Point(552, 600)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(130, 42)
        Me.Button3.TabIndex = 38
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Emp_ID"
        Me.ColumnHeader1.Width = 93
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "First name"
        Me.ColumnHeader2.Width = 118
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Gender"
        Me.ColumnHeader4.Width = 74
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Last name"
        Me.ColumnHeader3.Width = 135
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Contact_num"
        Me.ColumnHeader5.Width = 131
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Email"
        Me.ColumnHeader6.Width = 154
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Salary"
        Me.ColumnHeader7.Width = 119
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.Color.White
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.ListView1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(53, 82)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(828, 276)
        Me.ListView1.TabIndex = 29
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Goldenrod
        Me.Button4.Location = New System.Drawing.Point(246, 600)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(130, 42)
        Me.Button4.TabIndex = 47
        Me.Button4.Text = "Add"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Verdana", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(253, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(420, 38)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "Employee Information"
        '
        'UpdateEmp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(934, 672)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.gender)
        Me.Controls.Add(Me.contactNum)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.email)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lastname)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.firstname)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.empID)
        Me.Controls.Add(Me.Button2)
        Me.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "UpdateEmp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HMS Employee Information"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents email As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lastname As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents firstname As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents empID As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents contactNum As TextBox
    Friend WithEvents gender As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Button4 As Button
    Friend WithEvents Label4 As Label
End Class
