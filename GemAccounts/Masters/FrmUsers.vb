Imports GemAccounts.GENERAL_FUNCTIONS
Imports GemAccounts.BAL_COMPANY
Imports DevExpress.XtraEditors
Public Class FrmUsers
    Dim GF As New GENERAL_FUNCTIONS
    Dim user_id As Integer = 0
    Dim edf As Integer = 0
    Dim BL As New BAL_COMPANY
    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        edf = 0
        user_id = 0
        txtpassword.Text = ""
        txtusername.Text = ""
        cmbbranch.Text = ""
        cmbcompany.Text = ""

        BL.DIACRUDUSER(dg, 3, 0, 0, 0, "", "")
        GF.NFillCombo("select cmp_id,cmp_name from Dia_Company_Master", "cmp_id", "cmp_name", cmbcompany)

    End Sub

    Private Sub FrmUsers_Load(sender As Object, e As EventArgs) Handles Me.Load
        btncancel_Click(sender, e)
    End Sub
    Private Sub cmbcompany_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbcompany.SelectionChangeCommitted
        GF.NFillCombo("select br_id,br_name from Dia_Branch_Master where cmp_id='" & cmbcompany.SelectedValue & "'", "br_id", "br_name", cmbbranch)
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If edf = 0 Then
            BL.DIACRUDUSER(dg, 0, 0, cmbcompany.SelectedValue, cmbbranch.SelectedValue, txtusername.Text, txtpassword.Text)
            XtraMessageBox.Show("User has been saved.", "GemAccounts", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            BL.DIACRUDUSER(dg, 1, user_id, cmbcompany.SelectedValue, cmbbranch.SelectedValue, txtusername.Text, txtpassword.Text)
            XtraMessageBox.Show("User has been updated.", "GemAccounts", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

        btncancel_Click(sender, e)
    End Sub
    Private Sub dg_DoubleClick(sender As Object, e As EventArgs) Handles dg.DoubleClick
        If XtraMessageBox.Show("Do you want to update User?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

            edf = 1
            user_id = TryCast(dg.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("user_id")
            txtusername.Text = TryCast(dg.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("user_name")

            txtpassword.Text = TryCast(dg.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("password")
            cmbcompany.SelectedValue = TryCast(dg.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("cmp_id")
            cmbcompany_SelectionChangeCommitted(sender, e)
            cmbbranch.SelectedValue = TryCast(dg.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("br_id")

        Else

        End If
    End Sub

    Private Sub dg_KeyDown(sender As Object, e As KeyEventArgs) Handles dg.KeyDown
        If e.KeyCode = Keys.Delete Then
            If XtraMessageBox.Show("Do you want to delete this User?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                user_id = TryCast(dg.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("user_id")
                BL.DIACRUDUSER(dg, 2, user_id, 0, 0, "", "")
                XtraMessageBox.Show("User has been deleted.", "GemAccounts", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                btncancel_Click(sender, e)
            Else
                Exit Sub
            End If
        Else

        End If
    End Sub
End Class