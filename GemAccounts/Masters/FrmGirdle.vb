Imports DevExpress.XtraEditors

Public Class FrmGirdle
    Dim GF As New GENERAL_FUNCTIONS
    Dim GirdleID As Integer = 0
    Dim edf As Integer = 0
    Dim BL As New BAL_COMPANY
    Dim DF As New DevFunctions
    Dim devE As DevExpress.XtraBars.ItemClickEventArgs
    Private Sub FrmProcessMaster_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        btnCancel_ItemClick(sender, devE)
    End Sub

    Private Sub btnCancel_ItemClick(sender As Object, devE As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCancel.ItemClick
        edf = 0
        GirdleID = 0
        txtGirdleName.EditValue = Nothing
        txtGirldeDesc.EditValue = Nothing
        cmbGirldeThick.SelectedIndex = -1
        cmbGirldeThin.SelectedIndex = -1
        BL.GirdleCRUD(dg, 3, 0, "", "", "", "")
    End Sub


    Private Sub btnSave_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSave.ItemClick
        If edf = 0 Then
            BL.GirdleCRUD(dg, 0, 0, txtGirdleName.EditValue, txtGirldeDesc.EditValue, cmbGirldeThin.Text, cmbGirldeThick.Text)
            XtraMessageBox.Show("Girdle has been saved.", "Mauni Diamond", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            BL.GirdleCRUD(dg, 1, GirdleID, txtGirdleName.EditValue, txtGirldeDesc.EditValue, cmbGirldeThin.Text, cmbGirldeThick.Text)
            XtraMessageBox.Show("Girdle has been updated.", "Mauni Diamond", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

        btnCancel_ItemClick(sender, devE)
    End Sub

    Private Sub dg_KeyDown(sender As Object, e As KeyEventArgs) Handles dg.KeyDown
        If e.KeyCode = Keys.Delete Then
            If XtraMessageBox.Show("Do you want to delete this Girdle?", "Mauni Diamond", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                GirdleID = TryCast(dg.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("GirdleID")
                BL.GirdleCRUD(dg, 2, GirdleID, "", "", "", "")
                XtraMessageBox.Show("Girdle has been deleted.", "Mauni Diamond", MessageBoxButtons.OK, MessageBoxIcon.Error)
                btnCancel_ItemClick(sender, devE)
            Else
                Exit Sub
            End If
        End If
    End Sub

    Private Sub dgView_DoubleClick(sender As Object, e As EventArgs) Handles dgView.DoubleClick
        If XtraMessageBox.Show("Do you want to update Process?", "Mauni Diamond", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            edf = 1
            GirdleID = TryCast(dg.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("GirdleID")
            txtGirdleName.EditValue = TryCast(dg.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("GirdleName")
            txtGirldeDesc.EditValue = TryCast(dg.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("GirdleDesc")
            cmbGirldeThick.Text = TryCast(dg.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("GirdleThick")
            cmbGirldeThin.Text = TryCast(dg.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("GirdleThin")
        End If
    End Sub

    Private Sub txtGirdleName_KeyDown(sender As Object, e As KeyEventArgs) Handles txtGirdleName.KeyDown, txtGirldeDesc.KeyDown, cmbGirldeThick.KeyDown, cmbGirldeThin.KeyDown
        GENERAL_FUNCTIONS.FocusNext(sender, e)
    End Sub

End Class