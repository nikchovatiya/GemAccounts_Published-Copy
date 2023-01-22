Imports GemAccounts.GENERAL_FUNCTIONS
Imports GemAccounts.BAL_COMPANY
Imports GemAccounts.GLOBAL_VARIABLES
Imports DevExpress.XtraEditors
Imports System.ComponentModel
Public Class frmMainGroup
    Dim GF As New GENERAL_FUNCTIONS
    Dim group_id As Integer = 0
    Dim edf As Integer = 0
    Dim BL As New BAL_COMPANY
    Private Sub frmMainGroup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btncancel_Click(sender, e)
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        edf = 0
        group_id = 0
        txtgroupname.Text = ""
        chkdelete.CheckState = CheckState.Unchecked
        BL.DIACRUD_Account_Main_Group(dg, 3, 0, "", False)
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If edf = 0 Then
            BL.DIACRUD_Account_Main_Group(dg, 0, group_id, txtgroupname.Text, chkdelete.CheckState)
            XtraMessageBox.Show("Main Account Group has been Saved.", "GemAccounts", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            BL.DIACRUD_Account_Main_Group(dg, 1, group_id, txtgroupname.Text, chkdelete.CheckState)
            XtraMessageBox.Show("Main Account Group has been Updated.", "GemAccounts", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        btncancel_Click(sender, e)
    End Sub

    Private Sub dg_KeyDown(sender As Object, e As KeyEventArgs) Handles dg.KeyDown
        If e.KeyCode = Keys.Delete Then
            Dim is_del As Boolean = TryCast(dg.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("is_deletable")
            If is_del = False Then
                XtraMessageBox.Show(" You can not Delete this Group", "GemAccounts", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            Else
                If XtraMessageBox.Show("Do you want to delete this Main Acount Group?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    group_id = TryCast(dg.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("main_group_id")
                    BL.DIACRUD_Account_Main_Group(dg, 2, group_id, "", False)

                    XtraMessageBox.Show(" Main Acount Group has been deleted.", "GemAccounts", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    btncancel_Click(sender, e)
                Else
                    Exit Sub
                End If
            End If
        End If
    End Sub

    Private Sub dg_DoubleClick(sender As Object, e As EventArgs) Handles dg.DoubleClick
        If XtraMessageBox.Show("Do you want to update Main Acount Group?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            edf = 1
            group_id = TryCast(dg.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("main_group_id")
            txtgroupname.Text = TryCast(dg.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("main_group_name")

            Dim chkresult As Boolean = TryCast(dg.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("is_deletable")
            If chkresult = True Then
                chkdelete.CheckState = CheckState.Checked
            Else
                chkdelete.CheckState = CheckState.Unchecked
            End If
        Else

        End If
    End Sub

    Private Sub dg_Click(sender As Object, e As EventArgs) Handles dg.Click

    End Sub
End Class