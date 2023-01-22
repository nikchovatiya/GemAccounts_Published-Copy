Imports DevExpress.Data
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid

Public Class FrmUpdateAskingManually
    Dim dt2 As New DataTable
    Dim dt As New DataTable
    Dim dt3 As New DataTable
    Dim dr As DataRow
    Dim flag As Boolean
    Dim AverageDiscount As Double
    Private Sub FrmUpdateAskingManually_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dt2 = GLOBAL_VARIABLES.DS.Tables("DataTable_UpdateAskingPrice")

        Dim empty As String = Nothing
        For i = 0 To dt2.Rows.Count - 1
            If empty <> "" Then empty = empty & ","
            empty = empty & "'" & dt2.Rows(i).Item(0).ToString & "'"
        Next

        dt = GENERAL_FUNCTIONS.NFetchDatatable(
        "Select Cast(M.TransactionID as INT) as TransactionID
            ,Cast(M.Barcode as INT) as Barcode
            ,M.StockID as StockID
            ,Cast(M.Carats as float) as Carats
            ,S.Shape_Name as Shape
            ,C.color_name as Color
            ,CL.clarity_name as Clarity
            ,F.flo_name as Flo 
            ,CUT.cut_name as Cut
            ,p.polish_name as Polish
            ,SY.symm_name as Sym
            ,L.lab_name AS Lab
            ,Cast(isnull(M.RAP,0) as float) AS RAP 
            ,Cast(isnull(((isnull(M.AskingPPC,0)*100)/nullif(M.RAP,0))-100,0) as float) AS AskingPercent
            ,Cast(isnull(M.AskingPPC,0) as float) as AskingPPC
            ,Cast(isnull(M.AskingPPC,0) as float)*M.Carats as AskingTotal

            FROM Dia_MainStock M
            LEFT JOIN Dia_Shape_Master S ON S.Shape_ID=M.ShapeID
            LEFT JOIN Dia_Color_Master C ON C.color_id =M.ColorID
            LEFT JOIN Dia_Clarity_Master CL ON CL.clarity_id=M.ClarityID
            LEFT JOIN Dia_Flo_Master F ON F.flo_id=M.FloID
            LEFT JOIN Dia_Cut_Master CUT ON CUT.cut_id =M.CutID
            LEFT JOIN Dia_Polish_Master P ON P.polish_id=M.PolishID
            LEFT JOIN Dia_Symm_Master SY ON SY.symm_id=M.SymID
            LEFT JOIN DIa_Lab_Master L ON L.lab_id=M.LabID
             Where TransactionID in(" & empty & ")")

        dg.DataSource = dt
        dgview.BestFitColumns()
    End Sub

    Private Sub dgview_CellValueChanged(sender As Object, e As CellValueChangedEventArgs) Handles dgview.CellValueChanged
        Dim RAP As Double = 0
        Dim Carats As Double = 0
        Dim AskingPercent As Double = 0
        Dim AskingPPC As Double = 0
        Dim AskingTotal As Double = 0

        RAP = Double.Parse(dgview.GetRowCellValue(e.RowHandle, "RAP"))
        Carats = Double.Parse(dgview.GetRowCellValue(e.RowHandle, "Carats"))

        If e.Column.FieldName = "AskingPercent" AndAlso (Not flag) Then
            If IsDBNull(dgview.GetFocusedRowCellValue("AskingPercent")) = True Then Return
            flag = True
            AskingPercent = Double.Parse(dgview.GetRowCellValue(e.RowHandle, "AskingPercent"))
            dgview.SetRowCellValue(e.RowHandle, "AskingPPC", RAP + ((RAP * AskingPercent) / 100))
            dgview.SetRowCellValue(e.RowHandle, "AskingTotal", Carats * (RAP + ((RAP * AskingPercent) / 100)))
            flag = False
        ElseIf e.Column.FieldName = "AskingPPC" AndAlso (Not flag) Then
            If IsDBNull(dgview.GetFocusedRowCellValue("AskingPPC")) = True Then Return
            flag = True
            AskingPPC = Double.Parse(dgview.GetRowCellValue(e.RowHandle, "AskingPPC"))
            dgview.SetRowCellValue(e.RowHandle, "AskingPercent", ((AskingPPC * 100) / RAP) - 100)
            dgview.SetRowCellValue(e.RowHandle, "AskingTotal", Carats * AskingPPC)
            flag = False
        ElseIf e.Column.FieldName = "AskingTotal" AndAlso (Not flag) Then
            If IsDBNull(dgview.GetFocusedRowCellValue("AskingTotal")) = True Then Return
            flag = True
            AskingTotal = Double.Parse(dgview.GetRowCellValue(e.RowHandle, "AskingTotal"))
            dgview.SetRowCellValue(e.RowHandle, "AskingPercent", (((AskingTotal / Carats) * 100) / RAP) - 100)
            dgview.SetRowCellValue(e.RowHandle, "AskingPPC", AskingTotal / Carats)
            flag = False
        End If
        dgview.UpdateTotalSummary()
        If dgview.PostEditor() Then
            dgview.UpdateCurrentRow()
        End If
    End Sub

    Private Sub dgview_CustomSummaryCalculate(sender As Object, e As CustomSummaryEventArgs) Handles dgview.CustomSummaryCalculate
        Dim view As GridView = TryCast(sender, GridView)
        Try
            If e.IsTotalSummary Then
                Dim item As GridColumnSummaryItem = TryCast(e.Item, GridColumnSummaryItem)
                Dim tag As String = TryCast(item.Tag, String)
                Select Case e.SummaryProcess
                    Case DevExpress.Data.CustomSummaryProcess.Start
                        If item.Tag.ToString() = "avgdis" Then
                            AverageDiscount = 0
                        End If
                    Case DevExpress.Data.CustomSummaryProcess.Calculate
                        If item.Tag.ToString() = "avgdis" Then
                            Dim arry1(dgview.RowCount - 1) As Double
                            Dim arry2(dgview.RowCount - 1) As Double
                            For i = 0 To dgview.RowCount - 1
                                arry1(i) = dgview.GetRowCellValue(i, "RAP")
                                arry2(i) = dgview.GetRowCellValue(i, "Carats")
                            Next
                            Dim RAPMultiplyCarat As Double = DevFunctions.SUMPRODUCT(arry1, arry2)
                            AverageDiscount = (((Format(dgview.Columns("AskingTotal").SummaryItem.SummaryValue / dgview.Columns("Carats").SummaryItem.SummaryValue, "#.##")) * 100) / (RAPMultiplyCarat / dgview.Columns("Carats").SummaryItem.SummaryValue)) - 100
                        End If
                    Case DevExpress.Data.CustomSummaryProcess.Finalize
                        If item.Tag.ToString() = "avgdis" Then
                            e.TotalValue = AverageDiscount
                        End If
                End Select
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub btnSaveAndClose_Click(sender As Object, e As EventArgs) Handles btnSaveAndClose.Click
        Dim SaveDT As DataTable = DevFunctions.GetEmptyMainStockDatatable
        Dim UnionID As Integer = GENERAL_FUNCTIONS.MaxNo("Select max(UnionID) from Dia_MainStock")
        For i = 0 To dt.Rows.Count - 1
            If dt.Rows(i).Item("AskingPercent") = "" Then dt.Rows(i).Item("AskingPercent") = 0
            If dt.Rows(i).Item("AskingPPC") = "" Then dt.Rows(i).Item("AskingPPC") = 0
            If dt.Rows(i).Item("AskingTotal") = "" Then dt.Rows(i).Item("AskingTotal") = 0
            Dim dr As DataRow = GENERAL_FUNCTIONS.NFetchDataRow("Select * from Dia_MainStock where TransactionID=" & dt.Rows(i).Item("TransactionID"))
            dr.BeginEdit()
            dr("AskingPercent") = dt.Rows(i).Item("AskingPercent")
            dr("AskingPPC") = dt.Rows(i).Item("AskingPPC")
            dr("AskingTotal") = dt.Rows(i).Item("AskingTotal")
            dr("UserID") = GLOBAL_VARIABLES.UID
            dr("ImportDate") = GENERAL_FUNCTIONS.NExcuteScalerDate("Select getdate()")
            dr("LabourUSD") = 0
            dr("LabourExRate") = 0
            dr("LabourINR") = 0
            dr("HistoryDescription") = "Asking Price Update"
            dr("ExecutionDateTime") = GENERAL_FUNCTIONS.NExcuteScalerDate("Select getdate()")
            dr("UnionID") = UnionID
            dr.EndEdit()
            SaveDT.Rows.Add(dr.ItemArray)
        Next
        GENERAL_FUNCTIONS.DataTable_to_SqlTable_Copy(SaveDT, "Dia_MainStock")
        FrmStock.MainStock_Grid_Bind()
        Me.Close()
    End Sub
End Class