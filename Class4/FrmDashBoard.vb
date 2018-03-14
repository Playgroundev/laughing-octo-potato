Public Class FrmDashBoard
    Dim Count As Integer

    Private Sub FrmDashBoard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CmbSubCounties.Items.Add("Lukenya Boys")
        CmbSubCounties.Items.Add("Machakos Boys")
        CmbSubCounties.Items.Add("Kitui Boys")
        CmbCounty.Items.Add("Anestar Boys")
        CmbCounty.Items.Add("Kiambu Boys")
        CmbCounty.Items.Add("Chevakali Boys")
        CmbNational.Items.Add("Alliance Boys")
        CmbNational.Items.Add("Nairobi School")
        CmbNational.Items.Add("TumuTumu Boys")
        CmbNational.Items.Add("Bahati Girls")
        Count = 1
    End Sub

    Private Sub BtnSubCounty_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSubCounty.Click

        LstSelected.Items.Add(CmbSubCounties.Text)
        Count = Count + 1
        If (Count > 2) Then
            MsgBox("You are Required to Choose 2 Choices")
            BtnSubCounty.Enabled = False

        End If

    End Sub

    Private Sub BtnCounty_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCounty.Click
        LstSelected.Items.Add(CmbCounty.Text)
        Count = Count + 1
        If (Count > 3) Then
            MsgBox("You are Required to Choose 3 Choices")
            BtnCounty.Enabled = False
        End If
    End Sub

    Private Sub BtnNational_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNational.Click
        LstSelected.Items.Add(CmbNational.Text)
        Count = Count + 1
        If (Count > 4) Then
            MsgBox("You are Required to Choose 4 Choices")
            BtnNational.Enabled = False
        End If
    End Sub
End Class