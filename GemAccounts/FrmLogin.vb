Imports GemAccounts.BAL_LOGIN
Imports GemAccounts.GLOBAL_VARIABLES

Public Class FrmLogin
    Dim N As New BAL_LOGIN
    Dim df As New GENERAL_FUNCTIONS

    Private Sub Btnlogin_Click(sender As Object, e As EventArgs) Handles Btnlogin.Click
        Dim a As RoleData = N.CheckLogin(txtuname, txtpwd, 1, 1)
        If a.Login = True Then
            UROLE = a.Urole
            UNAME = a.Username
            BID = a.BranchID
            CID = a.CompanyID
            UID = a.UserID
            StockLayoutID = a.StockLayoutID

            Dim frm As New FrmMain
            frm.Show()
            Me.Close()
        Else
            DevFunctions.ErrorMsg("Username or Password Incorrect. ")
            txtuname.Focus()
        End If
    End Sub

    Private Sub Btnexit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    Private Sub txtuname_KeyDown(sender As Object, e As KeyEventArgs) Handles txtuname.KeyDown, txtpwd.KeyDown
        GENERAL_FUNCTIONS.FocusNext(sender, e)
    End Sub
End Class