Imports DevExpress.XtraEditors

Public Class FrmProcessMaster
    Dim GF As New GENERAL_FUNCTIONS
    Dim ProcessID As Integer = 0
    Dim edf As Integer = 0
    Dim BL As New BAL_COMPANY
    Dim DF As New DevFunctions
    Dim devE As DevExpress.XtraBars.ItemClickEventArgs
    Private Sub FrmProcessMaster_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadcombo()
        btnCancel_ItemClick(sender, devE)
    End Sub

    Private Sub btnCancel_ItemClick(sender As Object, devE As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCancel.ItemClick
        edf = 0
        ProcessID = 0
        txtProcessName.EditValue = Nothing
        cmbDefaultItemType.SelectedIndex = -1
        cmbDefaultLotStatus.SelectedIndex = -1
        BL.ProcessCRUD(dg, 3, 0, "", 0, 0)
    End Sub
    Private Sub loadcombo()

        GF.NFillCombo("select item_type_id,item_type_name from Dia_item_type_master", "item_type_id", "item_type_name", cmbDefaultItemType)
        GF.NFillCombo("select lot_status_id,Lot_status_name from Dia_lot_status_master", "lot_status_id", "Lot_status_name", cmbDefaultLotStatus)
    End Sub

    Private Sub btnSave_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSave.ItemClick
        If edf = 0 Then
            BL.ProcessCRUD(dg, 0, 0, txtProcessName.EditValue, cmbDefaultLotStatus.SelectedValue, cmbDefaultItemType.SelectedValue)
            XtraMessageBox.Show("Process has been saved.", "Mauni Diamond", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            BL.ProcessCRUD(dg, 1, ProcessID, txtProcessName.EditValue, cmbDefaultLotStatus.SelectedValue, cmbDefaultItemType.SelectedValue)
            XtraMessageBox.Show("Process has been updated.", "Mauni Diamond", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

        btnCancel_ItemClick(sender, devE)
    End Sub

    Private Sub dg_KeyDown(sender As Object, e As KeyEventArgs) Handles dg.KeyDown
        If e.KeyCode = Keys.Delete Then
            If XtraMessageBox.Show("Do you want to delete this Process?", "Mauni Diamond", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                ProcessID = TryCast(dg.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("ProcessID")
                BL.ProcessCRUD(dg, 2, ProcessID, "", 0, 0)
                XtraMessageBox.Show("Process has been deleted.", "Mauni Diamond", MessageBoxButtons.OK, MessageBoxIcon.Error)
                btnCancel_ItemClick(sender, devE)
            Else
                Exit Sub
            End If
        End If
    End Sub

    Private Sub dgView_DoubleClick(sender As Object, e As EventArgs) Handles dgView.DoubleClick
        If XtraMessageBox.Show("Do you want to update Process?", "Mauni Diamond", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            edf = 1
            ProcessID = TryCast(dg.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("ProcessID")
            txtProcessName.EditValue = TryCast(dg.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("ProcessName")
            cmbDefaultItemType.SelectedValue = TryCast(dg.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("DefaultItemType")
            cmbDefaultLotStatus.SelectedValue = TryCast(dg.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("DefaultLotStatus")
        End If
    End Sub
End Class