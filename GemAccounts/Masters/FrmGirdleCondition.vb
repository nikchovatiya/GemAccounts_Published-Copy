Imports DevExpress.XtraEditors

Public Class FrmGirdleCondition
    Dim GF As New GENERAL_FUNCTIONS
    Dim GirdleConditionID As Integer = 0
    Dim edf As Integer = 0
    Dim BL As New BAL_COMPANY
    Dim DF As New DevFunctions
    Dim devE As DevExpress.XtraBars.ItemClickEventArgs
    Private Sub FrmProcessMaster_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        btnCancel_ItemClick(sender, devE)
    End Sub

    Private Sub btnCancel_ItemClick(sender As Object, devE As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCancel.ItemClick
        edf = 0
        GirdleConditionID = 0
        txtGirdleName.EditValue = Nothing
        txtGirldeDesc.EditValue = Nothing

        BL.GirdleConditionCRUD(dg, 3, 0, "", "")
    End Sub


    Private Sub btnSave_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSave.ItemClick
        If edf = 0 Then
            BL.GirdleConditionCRUD(dg, 0, 0, txtGirdleName.EditValue, txtGirldeDesc.EditValue)
            XtraMessageBox.Show("Girdle Condition has been saved.", "Mauni Diamond", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            BL.GirdleConditionCRUD(dg, 1, GirdleConditionID, txtGirdleName.EditValue, txtGirldeDesc.EditValue)
            XtraMessageBox.Show("Girdle Condition has been updated.", "Mauni Diamond", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

        btnCancel_ItemClick(sender, devE)
    End Sub

    Private Sub dg_KeyDown(sender As Object, e As KeyEventArgs) Handles dg.KeyDown
        If e.KeyCode = Keys.Delete Then
            If XtraMessageBox.Show("Do you want to delete this Girdle Condition?", "Mauni Diamond", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                GirdleConditionID = TryCast(dg.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("GirdleConditionID")
                BL.GirdleConditionCRUD(dg, 2, GirdleConditionID, "", "")
                XtraMessageBox.Show("Girdle Condition has been deleted.", "Mauni Diamond", MessageBoxButtons.OK, MessageBoxIcon.Error)
                btnCancel_ItemClick(sender, devE)
            Else
                Exit Sub
            End If
        End If
    End Sub

    Private Sub dgView_DoubleClick(sender As Object, e As EventArgs) Handles dgView.DoubleClick
        If XtraMessageBox.Show("Do you want to update Girdle Condition?", "Mauni Diamond", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            edf = 1
            GirdleConditionID = TryCast(dg.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("GirdleConditionID")
            txtGirdleName.EditValue = TryCast(dg.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("GirdleConditionName")
            txtGirldeDesc.EditValue = TryCast(dg.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("GirdleConditionDesc")
        End If
    End Sub

    Private Sub txtGirdleName_KeyDown(sender As Object, e As KeyEventArgs) Handles txtGirdleName.KeyDown, txtGirldeDesc.KeyDown
        GENERAL_FUNCTIONS.FocusNext(sender, e)
    End Sub

End Class