Public Class FrmKCPESelection

    Private Sub BtnEnterMarks_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEnterMarks.Click
        TxtMaths.Text = InputBox("Enter Marks For Maths")
        TxtEnglish.Text = InputBox("Enter Marks For English")
        TxtSwa.Text = InputBox("Enter Marks For Kiswahili")
        TxtTotalMarks.Text = Val(TxtMaths.Text) + Val(TxtEnglish.Text) + Val(TxtSwa.Text)
    End Sub

    Private Sub FrmKCPESelection_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CmbStatus.Items.Add("Private")
        CmbStatus.Items.Add("Public")
    End Sub

    Private Sub BtnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSubmit.Click
        Dim Marks As Integer
        Marks = Val(TxtTotalMarks.Text)

        If CmbStatus.SelectedItem = "Private" Then
            Select Case Marks
                Case 175 To 215
                    MsgBox("Congratulations  You Qualify for SubCounty School, Give Your Preferred Two choices")
                    FrmDashBoard.BtnCounty.Enabled = False
                    FrmDashBoard.BtnNational.Enabled = False
                    Me.Hide()
                    FrmDashBoard.Show()
                Case 216 To 265
                    MsgBox("Congratulations, You Qualify for County School, Give Your Preferred Three Choices")
                    FrmDashBoard.BtnSubCounty.Enabled = False
                    FrmDashBoard.BtnNational.Enabled = False
                    Me.Hide()
                    FrmDashBoard.Show()

                Case 266 To 300
                    MsgBox("Congratulations, You Qualify for National School, Give Your Preferred Four Choices")
                    FrmDashBoard.BtnSubCounty.Enabled = False
                    FrmDashBoard.BtnCounty.Enabled = False
                    Me.Hide()
                    FrmDashBoard.Show()

                Case Else
                    MsgBox("Marks Are Invalid")
            End Select
        ElseIf CmbStatus.SelectedItem = "Public" Then
            Select Case Marks
                Case 150 To 200
                    MsgBox("Congratulations  You Qualify for SubCounty School, Give Your Preferred Two choices")
                    FrmDashBoard.BtnCounty.Enabled = False
                    FrmDashBoard.BtnNational.Enabled = False
                    Me.Hide()
                    FrmDashBoard.Show()

                Case 201 To 250
                    MsgBox("Congratulations, You Qualify for County School, Give Your Preferred Three Choices")
                    FrmDashBoard.BtnSubCounty.Enabled = False
                    FrmDashBoard.BtnNational.Enabled = False
                    Me.Hide()
                    FrmDashBoard.Show()

                Case 251 To 300
                    MsgBox("Congratulations, You Qualify for National School, Give Your Preferred Four Choices")
                    FrmDashBoard.BtnSubCounty.Enabled = False
                    FrmDashBoard.BtnCounty.Enabled = False
                    Me.Hide()
                    FrmDashBoard.Show()
                Case Else
                    MsgBox("Invalid Marks")
            End Select
        End If

    End Sub
End Class