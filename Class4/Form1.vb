Public Class FrmLogin

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Close()
    End Sub

    Private Sub BtnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLogin.Click
        Dim Username As String
        Dim Password As String

        Username = TxtUsername.Text
        Password = TxtPassword.Text

        If Username = "Joe" And Password = "123" Then
            MsgBox("Correct Login")
            Me.Hide()
            FrmKCPESelection.Show()
        Else
            MsgBox("Incorrect Credentials")
            TxtUsername.Text = ""
            TxtPassword.Text = ""
        End If
    End Sub
End Class
