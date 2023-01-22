Imports GemAccounts.GENERAL_FUNCTIONS
Imports GemAccounts.DevFunctions
Imports GemAccounts.GLOBAL_VARIABLES
Public Class FrmHold
    Dim dt As DataTable = GetEmptyMainStockDatatable()

    Private Sub btnClose_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnClose.ItemClick
        Me.Close()
    End Sub

    Private Sub dtp_KeyDown(sender As Object, e As KeyEventArgs) Handles dtp.KeyDown, cmbCustomer.KeyDown
        FocusNext(sender, e)
    End Sub

    Private Sub FrmHold_Load(sender As Object, e As EventArgs) Handles Me.Load
        FillCustomersCombo(cmbCustomer)
    End Sub

    Private Sub txtBarcode_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBarcode.KeyDown
        If e.KeyCode = Keys.Enter OrElse e.KeyCode = Keys.Tab Then
            'If txtBarcode.EditValue = Nothing Then
            '    txtStockID.Focus()
            'Else
            '    Dim dr As DataRow = NFetchDataRow("SELECT TOP(1)* FROM Dia_MainStock where Barcode=" & txtBarcode.EditValue)
            '    If dr Is Nothing Then
            '        ErrorMsg("Barcode Wrong")
            '        Return
            '    ElseIf dr("ProcessStatus") = True OrElse dr("SalesMasterID") <> 0 OrElse dr("ItemTypeID") <> NExcuteScaler("Select lot_status_id FROM Dia_Lot_Status_Master WHERE lot_status_name='Available'") Then
            '        ErrorMsg("You cannot hold this Lot")
            '    Else
            '        dt.NewRow()s
            '        dt.Rows.Add(dr.ItemArray)
            '        dg.DataSource = dt
            '    End If
            'End If
        End If
    End Sub
End Class