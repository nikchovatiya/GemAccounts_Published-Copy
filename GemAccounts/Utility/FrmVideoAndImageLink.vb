Imports DevExpress.XtraSplashScreen

Public Class FrmVideoAndImageLink
    Dim tmpDT As New DataTable
    Dim dt As New DataTable
    Dim SaveDT As New DataTable
    Dim DF As New DevFunctions
    Private Sub BtnBrowse_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnBrowse.ItemClick
        Cancel()
        SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
        Try
            If OFD.ShowDialog = DialogResult.Cancel Then

            Else
                dt.Columns.Add("Error").ToString()
                dt.Columns.Add("StockID")
                dt.Columns.Add("VideoLink")
                dt.Columns.Add("ImageLink")
                dt.Columns.Add("Barcode", GetType(Integer))
                GLOBAL_VARIABLES.filepath = System.IO.Path.GetFullPath(OFD.FileName)
                tmpDT = DevFunctions.ExcelToDatatable(DevFunctions.GetExcelDataSouce)
                addrows()
                dg.DataSource = dt
            End If
        Catch ex As Exception
            DevFunctions.ErrorMsg(ex.Message)
        Finally
            SplashScreenManager.CloseForm(False)
        End Try
    End Sub
    Private Sub Cancel()
        dg.DataSource = Nothing
        dt.Columns.Clear()
        dt.Rows.Clear()
    End Sub
    Private Sub addExcelColumns()
        dt.Columns.Add("Error").ToString()
        dt.Columns.Add("StockID")
        dt.Columns.Add("VideoLink")
        dt.Columns.Add("ImageLink")
    End Sub
    Private Sub addrows()
        dt.Rows.Clear()
        For i = 0 To tmpDT.Rows.Count - 1
            Dim dr As DataRow = dt.NewRow()
            dr("StockID") = tmpDT.Rows(i).Item(0).ToString().Trim()
            dr("VideoLink") = tmpDT.Rows(i).Item(1).ToString().Trim()
            If tmpDT.Columns.Count > 2 Then
                dr("ImageLink") = tmpDT.Rows(i).Item(2).ToString().Trim()
            End If
            dt.Rows.Add(dr.ItemArray)
        Next
    End Sub

    Private Sub BtnSave_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnSave.ItemClick
        SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
        If SaveData() = True Then
            SplashScreenManager.CloseForm(False)
            DevFunctions.InfoMsg("Excel Imported successfully")
            Cancel()
        Else
            SplashScreenManager.CloseForm(False)
            DevFunctions.ErrorMsg("Excel data is not valid." & vbCrLf & "Please Check Error Column")
        End If

    End Sub
    Private Function Validation() As Boolean
        Validation = True
        If dt.Rows.Count = 0 Then
            Validation = False
        End If
        For i = 0 To dt.Rows.Count - 1
            Dim msgarray As String = ""
            dt.Rows(i).Item("Barcode") = DF.GetBarcode(dt.Rows(i).Item("StockID"))
            If dt.Rows(i).Item("Barcode") = 0 Or dt.Rows(i).Item("Barcode") Is Nothing Then
                Validation = False
                If msgarray = "" Then
                    msgarray = "StockID"
                Else
                    msgarray = msgarray & ",StockID"
                End If
            End If
            If dt.Rows(i).Item("VideoLink") Is Nothing Or IsDBNull(dt.Rows(i).Item("VideoLink")) = True Then
            Else
                If dt.Rows(i).Item("VideoLink") <> "" Then
                    If DevFunctions.ValidateUrl(dt.Rows(i).Item("VideoLink")) = False Then
                        Validation = False
                        If msgarray = "" Then
                            msgarray = "Video Link"
                        Else
                            msgarray = msgarray & ",Video Link"
                        End If
                    End If
                End If
            End If
            If dt.Rows(i).Item("ImageLink") Is Nothing Or IsDBNull(dt.Rows(i).Item("ImageLink")) = True Then
            Else
                If dt.Rows(i).Item("ImageLink") <> "" Then
                    If DevFunctions.ValidateUrl(dt.Rows(i).Item("ImageLink")) = False Then
                        Validation = False
                        If msgarray = "" Then
                            msgarray = "Image Link"
                        Else
                            msgarray = msgarray & ",Image Link"
                        End If
                    End If
                End If
            End If

            dt.Rows(i).Item("Error") = msgarray
        Next
        dg.DataSource = dt
        Return Validation
    End Function
    Private Function SaveData() As Boolean
        If Validation() = True Then
            For i = 0 To dt.Rows.Count - 1
                Dim TrasactionID As Integer = Nothing
                TrasactionID = GENERAL_FUNCTIONS.NExcuteScalerInt("Select top(1) TransactionID from Dia_MainStock where Barcode=" & dt.Rows(i).Item("Barcode") & " Order by TransactionID Desc")
                GENERAL_FUNCTIONS.NExcuteQuery("Update Dia_MainStock Set ImageLink='" & dt.Rows(i).Item("ImageLink").ToString & "',VideoLink='" & dt.Rows(i).Item("VideoLink").ToString & "' Where TransactionID=" & TrasactionID)
            Next
            SaveData = True
            FrmStock.MainStock_Grid_Bind()
        Else
            SaveData = False
        End If
        Return SaveData
    End Function

    Private Sub BtnCancel_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnCancel.ItemClick
        Cancel()
    End Sub

    Private Sub BtnClose_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnClose.ItemClick
        Me.Close()
    End Sub

    Private Sub BtnSavenClose_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnSavenClose.ItemClick
        SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
        If SaveData() = True Then
            SplashScreenManager.CloseForm(False)
            Me.Close()
        Else
            SplashScreenManager.CloseForm(False)
            DevFunctions.ErrorMsg("Excel data is not valid." & vbCrLf & "Please Check Error Column")
        End If

    End Sub

    Private Sub FrmVideoAndImageLink_Load(sender As Object, e As EventArgs) Handles Me.Load
        Cancel()
    End Sub
End Class