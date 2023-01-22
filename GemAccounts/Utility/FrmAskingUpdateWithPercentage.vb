Imports DevExpress.XtraSplashScreen

Public Class FrmAskingUpdateWithPercentage
    Dim dt As New DataTable
    Dim TmpDT As New DataTable
    Dim SaveDT As New DataTable
    Dim df As New DevFunctions
    Private Sub btnClose_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnClose.ItemClick
        Me.Close()
    End Sub

    Private Sub btnBrowse_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnBrowse.ItemClick

        SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
        Try
            If OFD.ShowDialog = DialogResult.Cancel Then

            Else
                cancel()
                dt.Columns.Add("Error").ToString()
                dt.Columns.Add("StockID")
                dt.Columns.Add("AskingPercent", GetType(Double))

                dt.Columns.Add("Barcode", GetType(Integer)) ' DB Column

                GLOBAL_VARIABLES.filepath = System.IO.Path.GetFullPath(OFD.FileName)
                tmpDT = DevFunctions.ExcelToDatatable(DevFunctions.GetExcelDataSouce)
                dt.Rows.Clear()
                Dim dr As DataRow = dt.NewRow()
                For i = 0 To TmpDT.Rows.Count - 1
                    dr("StockID") = TmpDT.Rows(i).Item(0).ToString
                    dr("AskingPercent") = TmpDT.Rows(i).Item(1).ToString
                    dt.Rows.Add(dr.ItemArray)
                Next
                dg.DataSource = dt
            End If
        Catch ex As Exception
            DevFunctions.ErrorMsg(ex.Message)
        Finally
            SplashScreenManager.CloseForm(False)
        End Try

    End Sub
    Private Sub cancel()
        dt.Rows.Clear()
        dt.Columns.Clear()
        dg.DataSource = Nothing
    End Sub

    Private Sub btnCancel_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCancel.ItemClick
        cancel()
    End Sub

    Private Sub BtnSave_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnSave.ItemClick
        SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
        If dt.Rows.Count = 0 Then
            DevFunctions.ErrorMsg("Select Proper Excel")
            Exit Sub
        End If
        If SaveData() = True Then
            DevFunctions.InfoMsg("Result Imported successfully")
            cancel()
        Else
            DevFunctions.ErrorMsg("Excel data is not valid." & vbCrLf & "Please Check Error Column")
        End If
        SplashScreenManager.CloseForm(False)
    End Sub
    Private Function SaveData() As Boolean

        If Validation() = True Then
            SaveDT = DevFunctions.GetEmptyMainStockDatatable()
            For i = 0 To dt.Rows.Count - 1
                Dim dr As DataRow
                dr = GENERAL_FUNCTIONS.NFetchDataRow("select top(1) * from dia_mainstock where Barcode='" & dt.Rows(i).Item("Barcode") & "' order by TransactionID Desc")
                If dr Is Nothing Then
                Else
                    SaveDT.Rows.Add(dr.ItemArray)
                End If
            Next
            UpdateRowFields()
            GENERAL_FUNCTIONS.DataTable_to_SqlTable_Copy(SaveDT, "Dia_MainStock")
            FrmStock.MainStock_Grid_Bind()
            SaveData = True
        Else
            SaveData = False
        End If
        Return SaveData
    End Function
    Private Sub UpdateRowFields()
        Dim UnionID As Integer = GENERAL_FUNCTIONS.MaxNo("Select max(UnionID) from Dia_MainStock")
        For i = 0 To SaveDT.Rows.Count - 1
            If SaveDT.Rows(i).Item("RAP") = 0 Then
            Else
                Dim AskingPercent As Integer = dt.Rows(i).Item("AskingPercent").ToString
                Dim RAP As Integer = SaveDT.Rows(i).Item("RAP").ToString
                SaveDT.Rows(i).Item("AskingPercent") = AskingPercent
                SaveDT.Rows(i).Item("AskingPPC") = RAP + ((RAP * AskingPercent) / 100)
                SaveDT.Rows(i).Item("AskingTotal") = (RAP + ((RAP * AskingPercent) / 100)) * SaveDT.Rows(i).Item("Carats")
                ' DB Update Fields Starts from Here
                SaveDT.Rows(i).Item("LabourINR") = 0
                SaveDT.Rows(i).Item("LabourUSD") = 0
                SaveDT.Rows(i).Item("LabourExRate") = 0
                SaveDT.Rows(i).Item("HistoryDescription") = "Asking Price Update"
                SaveDT.Rows(i).Item("UnionID") = UnionID
                SaveDT.Rows(i).Item("ExecutionDateTime") = GENERAL_FUNCTIONS.NExcuteScalerDate("Select getdate()")
                SaveDT.Rows(i).Item("UserID") = GLOBAL_VARIABLES.UID
            End If

        Next
    End Sub
    Private Function Validation() As Boolean
        Validation = True
        If dt.Rows.Count = 0 Then
            Validation = False
        End If

        For i = 0 To dt.Rows.Count - 1
            Dim msgarray As String = ""
            dt.Rows(i).Item("Barcode") = df.GetBarcode(dt.Rows(i).Item("StockID"))

            If dt.Rows(i).Item("Barcode") = 0 Then
                Validation = False
                If msgarray = "" Then
                    msgarray = "StockID"
                Else
                    msgarray = msgarray & ",StockID"
                End If
            End If
            dt.Rows(i).Item("Error") = msgarray
        Next
        dg.DataSource = dt
        Return Validation
    End Function

    Private Sub btnSaveClose_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSaveClose.ItemClick
        SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
        If dt.Rows.Count = 0 Then
            DevFunctions.ErrorMsg("Select Proper Excel")
            Exit Sub
        End If
        If SaveData() = True Then
            Me.Close()
        Else
            DevFunctions.ErrorMsg("Excel data is not valid." & vbCrLf & "Please Check Error Column")
        End If
        SplashScreenManager.CloseForm(False)
    End Sub
End Class
