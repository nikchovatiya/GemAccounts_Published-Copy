Public Class FrmLotHistory
    Private Sub FrmLotHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim dt As DataTable = DevFunctions.SelectStockDataTable("SelectLotHistory", 1111)
        'dg.DataSource = dt
        'dgview.BestFitColumns()
    End Sub

    Private Sub txtbarcode_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbarcode.KeyDown
        If e.KeyCode = Keys.Enter OrElse e.KeyCode = Keys.Tab Then
            If txtbarcode.EditValue = Nothing OrElse txtbarcode.EditValue = String.Empty Then
                txtStockID.Focus()
            Else
                Dim dt As DataTable = DevFunctions.SelectStockDataTable("SelectLotHistory", txtbarcode.EditValue)
                If dt Is Nothing Then
                    DevFunctions.ErrorMsg("Wrong Barcode")
                    Return
                Else
                    dg.DataSource = dt
                    dgview.BestFitColumns()
                End If
            End If
        End If
    End Sub
    Private Sub loadgrid(ByVal barcode As Integer)
        Dim dt As DataTable = DevFunctions.SelectStockDataTable("SelectLotHistory", barcode)
        dg.DataSource = dt
        dgview.BestFitColumns()
    End Sub

    Private Sub txtStockID_KeyDown(sender As Object, e As KeyEventArgs) Handles txtStockID.KeyDown
        If e.KeyCode = Keys.Enter OrElse e.KeyCode = Keys.Tab Then
            If txtStockID.EditValue = Nothing OrElse txtStockID.EditValue = String.Empty Then
                Return
            Else
                Dim barcode As Integer = GENERAL_FUNCTIONS.NExcuteScalerInt("SELECT top(1) Barcode from Dia_MainStock where stockid='" & txtStockID.EditValue & "'")
                If barcode = Nothing Then
                    DevFunctions.ErrorMsg("Wrong StockID")
                    Return
                Else
                    Dim dt As DataTable = DevFunctions.SelectStockDataTable("SelectLotHistory", barcode)
                    dg.DataSource = dt
                    dgview.BestFitColumns()
                End If
            End If
        End If
    End Sub

    Private Sub btnExport_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExport.ItemClick
        DevFunctions.ExportGrid(dgview)
    End Sub
End Class