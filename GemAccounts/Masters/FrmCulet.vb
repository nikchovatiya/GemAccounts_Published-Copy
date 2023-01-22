Imports DevExpress.XtraEditors

Public Class FrmCulet
    Dim GF As New GENERAL_FUNCTIONS
    Dim CuletID As Integer = 0
    Dim edf As Integer = 0
    Dim BL As New BAL_COMPANY
    Dim DF As New DevFunctions
    Dim devE As DevExpress.XtraBars.ItemClickEventArgs
    Private Sub FrmProcessMaster_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        btnCancel_ItemClick(sender, devE)
    End Sub

    Private Sub btnCancel_ItemClick(sender As Object, devE As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCancel.ItemClick
        edf = 0
        CuletID = 0
        txtCulet.EditValue = Nothing
        txtCuletDesc.EditValue = Nothing

        BL.CuletCRUD(dg, 3, 0, "", "")
    End Sub


    Private Sub btnSave_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSave.ItemClick
        If edf = 0 Then
            BL.CuletCRUD(dg, 0, 0, txtCulet.EditValue, txtCuletDesc.EditValue)
            XtraMessageBox.Show("Culet has been saved.", "Mauni Diamond", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            BL.CuletCRUD(dg, 1, CuletID, txtCulet.EditValue, txtCuletDesc.EditValue)
            XtraMessageBox.Show("Culet has been updated.", "Mauni Diamond", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

        btnCancel_ItemClick(sender, devE)
    End Sub

    Private Sub dg_KeyDown(sender As Object, e As KeyEventArgs) Handles dg.KeyDown
        If e.KeyCode = Keys.Delete Then
            If XtraMessageBox.Show("Do you want to delete this Culet?", "Mauni Diamond", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                CuletID = TryCast(dg.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("CuletID")
                BL.CuletCRUD(dg, 2, CuletID, "", "")
                XtraMessageBox.Show("Culet has been deleted.", "Mauni Diamond", MessageBoxButtons.OK, MessageBoxIcon.Error)
                btnCancel_ItemClick(sender, devE)
            Else
                Exit Sub
            End If
        End If
    End Sub

    Private Sub dgView_DoubleClick(sender As Object, e As EventArgs) Handles dgView.DoubleClick
        If XtraMessageBox.Show("Do you want to update Culet?", "Mauni Diamond", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            edf = 1
            CuletID = TryCast(dg.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("CuletID")
            txtCulet.EditValue = TryCast(dg.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("CuletName")
            txtCuletDesc.EditValue = TryCast(dg.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("CuletDesc")
        End If
    End Sub

    Private Sub txtGirdleName_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCulet.KeyDown, txtCuletDesc.KeyDown
        GENERAL_FUNCTIONS.FocusNext(sender, e)
    End Sub

End Class