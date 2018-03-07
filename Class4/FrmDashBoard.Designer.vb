<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDashBoard
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CmbSubCounties = New System.Windows.Forms.ComboBox()
        Me.CmbCounty = New System.Windows.Forms.ComboBox()
        Me.CmbNational = New System.Windows.Forms.ComboBox()
        Me.LstSelected = New System.Windows.Forms.ListBox()
        Me.LblSelected = New System.Windows.Forms.Label()
        Me.BtnSubCounty = New System.Windows.Forms.Button()
        Me.BtnCounty = New System.Windows.Forms.Button()
        Me.BtnNational = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SubCounty Schools"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "County Schools"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "National Schools"
        '
        'CmbSubCounties
        '
        Me.CmbSubCounties.FormattingEnabled = True
        Me.CmbSubCounties.Location = New System.Drawing.Point(118, 12)
        Me.CmbSubCounties.Name = "CmbSubCounties"
        Me.CmbSubCounties.Size = New System.Drawing.Size(181, 21)
        Me.CmbSubCounties.TabIndex = 3
        '
        'CmbCounty
        '
        Me.CmbCounty.FormattingEnabled = True
        Me.CmbCounty.Location = New System.Drawing.Point(118, 49)
        Me.CmbCounty.Name = "CmbCounty"
        Me.CmbCounty.Size = New System.Drawing.Size(181, 21)
        Me.CmbCounty.TabIndex = 4
        '
        'CmbNational
        '
        Me.CmbNational.FormattingEnabled = True
        Me.CmbNational.Location = New System.Drawing.Point(118, 87)
        Me.CmbNational.Name = "CmbNational"
        Me.CmbNational.Size = New System.Drawing.Size(181, 21)
        Me.CmbNational.TabIndex = 5
        '
        'LstSelected
        '
        Me.LstSelected.FormattingEnabled = True
        Me.LstSelected.Location = New System.Drawing.Point(15, 146)
        Me.LstSelected.Name = "LstSelected"
        Me.LstSelected.Size = New System.Drawing.Size(154, 108)
        Me.LstSelected.TabIndex = 6
        '
        'LblSelected
        '
        Me.LblSelected.AutoSize = True
        Me.LblSelected.Location = New System.Drawing.Point(15, 127)
        Me.LblSelected.Name = "LblSelected"
        Me.LblSelected.Size = New System.Drawing.Size(90, 13)
        Me.LblSelected.TabIndex = 7
        Me.LblSelected.Text = "Selected Schools"
        '
        'BtnSubCounty
        '
        Me.BtnSubCounty.Location = New System.Drawing.Point(330, 10)
        Me.BtnSubCounty.Name = "BtnSubCounty"
        Me.BtnSubCounty.Size = New System.Drawing.Size(146, 23)
        Me.BtnSubCounty.TabIndex = 8
        Me.BtnSubCounty.Text = "SELECT SUB-COUNTY"
        Me.BtnSubCounty.UseVisualStyleBackColor = True
        '
        'BtnCounty
        '
        Me.BtnCounty.Location = New System.Drawing.Point(330, 46)
        Me.BtnCounty.Name = "BtnCounty"
        Me.BtnCounty.Size = New System.Drawing.Size(146, 23)
        Me.BtnCounty.TabIndex = 9
        Me.BtnCounty.Text = "SELECT COUNTY"
        Me.BtnCounty.UseVisualStyleBackColor = True
        '
        'BtnNational
        '
        Me.BtnNational.Location = New System.Drawing.Point(330, 85)
        Me.BtnNational.Name = "BtnNational"
        Me.BtnNational.Size = New System.Drawing.Size(146, 23)
        Me.BtnNational.TabIndex = 10
        Me.BtnNational.Text = "SELECT NATIONAL"
        Me.BtnNational.UseVisualStyleBackColor = True
        '
        'FrmDashBoard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(517, 272)
        Me.Controls.Add(Me.BtnNational)
        Me.Controls.Add(Me.BtnCounty)
        Me.Controls.Add(Me.BtnSubCounty)
        Me.Controls.Add(Me.LblSelected)
        Me.Controls.Add(Me.LstSelected)
        Me.Controls.Add(Me.CmbNational)
        Me.Controls.Add(Me.CmbCounty)
        Me.Controls.Add(Me.CmbSubCounties)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmDashBoard"
        Me.Text = "FrmDashBoard"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CmbSubCounties As System.Windows.Forms.ComboBox
    Friend WithEvents CmbCounty As System.Windows.Forms.ComboBox
    Friend WithEvents CmbNational As System.Windows.Forms.ComboBox
    Friend WithEvents LstSelected As System.Windows.Forms.ListBox
    Friend WithEvents LblSelected As System.Windows.Forms.Label
    Friend WithEvents BtnSubCounty As System.Windows.Forms.Button
    Friend WithEvents BtnCounty As System.Windows.Forms.Button
    Friend WithEvents BtnNational As System.Windows.Forms.Button
End Class
