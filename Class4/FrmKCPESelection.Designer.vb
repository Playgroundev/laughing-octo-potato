<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmKCPESelection
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnEnterMarks = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtMaths = New System.Windows.Forms.TextBox()
        Me.TxtEnglish = New System.Windows.Forms.TextBox()
        Me.TxtSwa = New System.Windows.Forms.TextBox()
        Me.LblStatus = New System.Windows.Forms.Label()
        Me.CmbStatus = New System.Windows.Forms.ComboBox()
        Me.BtnSubmit = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtTotalMarks = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(279, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Please Enter Your KCPE Marks for the Following Subjects"
        '
        'BtnEnterMarks
        '
        Me.BtnEnterMarks.Location = New System.Drawing.Point(16, 41)
        Me.BtnEnterMarks.Name = "BtnEnterMarks"
        Me.BtnEnterMarks.Size = New System.Drawing.Size(139, 23)
        Me.BtnEnterMarks.TabIndex = 1
        Me.BtnEnterMarks.Text = "Click To Enter Marks"
        Me.BtnEnterMarks.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtSwa)
        Me.GroupBox1.Controls.Add(Me.TxtEnglish)
        Me.GroupBox1.Controls.Add(Me.TxtMaths)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 89)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(179, 127)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Subjects"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Mathematics"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "English"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Kiswahili"
        '
        'TxtMaths
        '
        Me.TxtMaths.Location = New System.Drawing.Point(80, 28)
        Me.TxtMaths.Name = "TxtMaths"
        Me.TxtMaths.Size = New System.Drawing.Size(80, 20)
        Me.TxtMaths.TabIndex = 3
        '
        'TxtEnglish
        '
        Me.TxtEnglish.Location = New System.Drawing.Point(80, 58)
        Me.TxtEnglish.Name = "TxtEnglish"
        Me.TxtEnglish.Size = New System.Drawing.Size(80, 20)
        Me.TxtEnglish.TabIndex = 4
        '
        'TxtSwa
        '
        Me.TxtSwa.Location = New System.Drawing.Point(80, 89)
        Me.TxtSwa.Name = "TxtSwa"
        Me.TxtSwa.Size = New System.Drawing.Size(80, 20)
        Me.TxtSwa.TabIndex = 5
        '
        'LblStatus
        '
        Me.LblStatus.AutoSize = True
        Me.LblStatus.Location = New System.Drawing.Point(248, 75)
        Me.LblStatus.Name = "LblStatus"
        Me.LblStatus.Size = New System.Drawing.Size(73, 13)
        Me.LblStatus.TabIndex = 3
        Me.LblStatus.Text = "School Status"
        '
        'CmbStatus
        '
        Me.CmbStatus.FormattingEnabled = True
        Me.CmbStatus.Location = New System.Drawing.Point(251, 101)
        Me.CmbStatus.Name = "CmbStatus"
        Me.CmbStatus.Size = New System.Drawing.Size(101, 21)
        Me.CmbStatus.TabIndex = 4
        '
        'BtnSubmit
        '
        Me.BtnSubmit.Location = New System.Drawing.Point(251, 159)
        Me.BtnSubmit.Name = "BtnSubmit"
        Me.BtnSubmit.Size = New System.Drawing.Size(101, 23)
        Me.BtnSubmit.TabIndex = 5
        Me.BtnSubmit.Text = "Submit"
        Me.BtnSubmit.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 234)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Total Marks"
        '
        'TxtTotalMarks
        '
        Me.TxtTotalMarks.Location = New System.Drawing.Point(85, 231)
        Me.TxtTotalMarks.Name = "TxtTotalMarks"
        Me.TxtTotalMarks.Size = New System.Drawing.Size(110, 20)
        Me.TxtTotalMarks.TabIndex = 7
        '
        'FrmKCPESelection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 304)
        Me.Controls.Add(Me.TxtTotalMarks)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BtnSubmit)
        Me.Controls.Add(Me.CmbStatus)
        Me.Controls.Add(Me.LblStatus)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnEnterMarks)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmKCPESelection"
        Me.Text = "FrmKCPESelection"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnEnterMarks As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtEnglish As System.Windows.Forms.TextBox
    Friend WithEvents TxtMaths As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtSwa As System.Windows.Forms.TextBox
    Friend WithEvents LblStatus As System.Windows.Forms.Label
    Friend WithEvents CmbStatus As System.Windows.Forms.ComboBox
    Friend WithEvents BtnSubmit As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtTotalMarks As System.Windows.Forms.TextBox
End Class
