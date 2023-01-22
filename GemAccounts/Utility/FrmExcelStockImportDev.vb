

Imports DevExpress.XtraSplashScreen

Public Class FrmExcelStockImportDev
    Dim GV As New GLOBAL_VARIABLES
    Dim VarCon As New MasterConnection
    Dim dt As New DataTable
    Dim SaveDT As New DataTable
    Dim DF As New DevFunctions
    Dim GF As New GENERAL_FUNCTIONS
    Dim tmpDT As New DataTable
    Dim LabTranslation As New LabTranslation

    Private Sub btnClose_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnClose.ItemClick
        Me.Close()
    End Sub

    Private Sub btnBrowse_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnBrowse.ItemClick
        btnCancel_ItemClick(sender, e)
        SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
        Try
            If OFD.ShowDialog = DialogResult.Cancel Then

            Else
                addExcelColumns()
                addDBColumns()
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
    Private Sub addExcelColumns()
        dt.Columns.Add("Error").ToString()
        dt.Columns.Add("ItemType")
        dt.Columns.Add("MainLot")
        dt.Columns.Add("StockID")
        dt.Columns.Add("Qty", GetType(Integer))
        dt.Columns.Add("Carats", GetType(Double))
        dt.Columns.Add("LabourINR", GetType(Double))
        dt.Columns.Add("Shape")
        dt.Columns.Add("Color")
        dt.Columns.Add("Clarity")
        dt.Columns.Add("Flo")
        dt.Columns.Add("Cut")
        dt.Columns.Add("Polish")
        dt.Columns.Add("Sym")
        dt.Columns.Add("Comment")
        dt.Columns.Add("VideoLink")
        dt.Columns.Add("ImageLink")
    End Sub
    Private Sub addDBColumns()
        With dt.Columns
            .Add("ItemTypeID", GetType(Integer))
            .Add("MainLotID", GetType(Integer))
            .Add("Barcode", GetType(Integer))
            .Add("ShapeID", GetType(Integer))
            .Add("ColorID", GetType(Integer))
            .Add("ClarityID", GetType(Integer))
            .Add("FloID", GetType(Integer))
            .Add("CutID", GetType(Integer))
            .Add("PolishID", GetType(Integer))
            .Add("SymID", GetType(Integer))
        End With
    End Sub
    Private Sub addrows()
        dt.Rows.Clear()
        For i = 0 To tmpDT.Rows.Count - 1
            Dim dr As DataRow = dt.NewRow()
            dr("ItemType") = LabTranslation.LabRemoveNA(tmpDT.Rows(i).Item(0).ToString)
            dr("MainLot") = LabTranslation.LabRemoveNA(tmpDT.Rows(i).Item(1).ToString)
            dr("StockID") = LabTranslation.LabRemoveNA(tmpDT.Rows(i).Item(2).ToString)
            dr("Qty") = LabTranslation.LabValueDouble(tmpDT.Rows(i).Item(3).ToString)
            dr("Carats") = LabTranslation.LabValueDouble(tmpDT.Rows(i).Item(4).ToString)
            dr("LabourINR") = LabTranslation.LabValueDouble(tmpDT.Rows(i).Item(5).ToString)
            dr("Shape") = LabTranslation.LabRemoveNA(tmpDT.Rows(i).Item(6).ToString)
            dr("Color") = LabTranslation.LabRemoveNA(tmpDT.Rows(i).Item(7).ToString)
            dr("Clarity") = LabTranslation.LabRemoveNA(tmpDT.Rows(i).Item(8).ToString)
            dr("Flo") = LabTranslation.LabRemoveNA(tmpDT.Rows(i).Item(9).ToString)
            dr("Cut") = LabTranslation.LabRemoveNA(tmpDT.Rows(i).Item(10).ToString)
            dr("Polish") = LabTranslation.LabRemoveNA(tmpDT.Rows(i).Item(11).ToString)
            dr("Sym") = LabTranslation.LabRemoveNA(tmpDT.Rows(i).Item(12).ToString)
            dr("Comment") = LabTranslation.LabRemoveNA(tmpDT.Rows(i).Item(13).ToString)
            dr("VideoLink") = LabTranslation.LabRemoveNA(tmpDT.Rows(i).Item(14).ToString)
            dr("ImageLink") = LabTranslation.LabRemoveNA(tmpDT.Rows(i).Item(15).ToString)

            dt.Rows.Add(dr.ItemArray)
        Next
    End Sub

    Private Sub btnCancel_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCancel.ItemClick
        dg.DataSource = Nothing
        dt.Columns.Clear()
        dt.Rows.Clear()
    End Sub

    Private Sub BtnSave_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnSave.ItemClick
        SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
        If dt.Rows.Count = 0 Then
            DevFunctions.ErrorMsg("Select Stock Import Excel")
            Exit Sub
        End If
        If SaveData() = True Then
            SplashScreenManager.CloseForm(False)
            DevFunctions.InfoMsg("Stock Imported successfully")
            btnCancel_ItemClick(sender, e)
        Else
            DevFunctions.ErrorMsg("Excel data is not valid." & vbCrLf & "Please Check Error Column")
        End If

    End Sub
    Private Function SaveData() As Boolean

        If Validation() = True Then
            SaveDT = DevFunctions.GetEmptyMainStockDatatable()
            For i = 0 To dt.Rows.Count - 1
                SaveDT.NewRow()
                SaveDT.Rows.Add()
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
    Private Function Validation() As Boolean
        Dim shapeDatatable As DataTable = GENERAL_FUNCTIONS.NFetchDatatable("with tmp(shape_id,shape_name,Shape_Desc)as(select Shape_ID,LEFT(Shape_Desc,charindex(',',Shape_Desc + ',')-1),STUFF(Shape_Desc,1, charindex(',', Shape_Desc + ','),'')from Dia_Shape_Master union all select Shape_ID,LEFT(Shape_Desc,charindex(',',Shape_Desc + ',')-1), STUFF(Shape_Desc,1, charindex(',', Shape_Desc + ','),'')from tmp where Shape_Desc>'')select shape_id,shape_name from tmp where shape_name<>'' union select shape_id,shape_name from dia_shape_Master")
        Dim ColorDataTable As DataTable = GENERAL_FUNCTIONS.NFetchDatatable("with tmp(color_id,color_name,color_desc)as(select color_id,LEFT(color_desc,charindex(',',color_desc + ',')-1),STUFF(color_desc,1, charindex(',', color_desc + ','),'')from Dia_Color_Master union all select color_id,LEFT(color_desc,charindex(',',color_desc + ',')-1), STUFF(color_desc,1, charindex(',', color_desc + ','),'')from tmp where color_desc>'')select color_id,color_name from tmp where color_name<>'' union select color_id,color_name from Dia_Color_Master")
        Dim ClarityDataTable As DataTable = GENERAL_FUNCTIONS.NFetchDatatable("with tmp(clarity_id,clarity_name,clarity_desc)as(select clarity_id,LEFT(clarity_desc,charindex(',',clarity_desc + ',')-1),STUFF(clarity_desc,1, charindex(',', clarity_desc + ','),'')from Dia_clarity_Master union all select clarity_id,LEFT(clarity_desc,charindex(',',clarity_desc + ',')-1), STUFF(clarity_desc,1, charindex(',', clarity_desc + ','),'')from tmp where clarity_desc>'')select clarity_id,clarity_name from tmp where clarity_name<>'' union select clarity_id,clarity_name from Dia_clarity_Master")
        Dim FloDataTable As DataTable = GENERAL_FUNCTIONS.NFetchDatatable("with tmp(flo_id,flo_name,flo_desc)as(select flo_id,LEFT(flo_desc,charindex(',',flo_desc + ',')-1),STUFF(flo_desc,1, charindex(',', flo_desc + ','),'')from Dia_flo_Master union all select flo_id,LEFT(flo_desc,charindex(',',flo_desc + ',')-1), STUFF(flo_desc,1, charindex(',', flo_desc + ','),'')from tmp where flo_desc>'')select flo_id,flo_name from tmp where flo_name<>'' union select flo_id,flo_name from Dia_flo_Master")
        Dim CutDataTable As DataTable = GENERAL_FUNCTIONS.NFetchDatatable("with tmp(cut_id,cut_name,cut_desc)as(select cut_id,LEFT(cut_desc,charindex(',',cut_desc + ',')-1),STUFF(cut_desc,1, charindex(',', cut_desc + ','),'')from Dia_cut_Master union all select cut_id,LEFT(cut_desc,charindex(',',cut_desc + ',')-1), STUFF(cut_desc,1, charindex(',', cut_desc + ','),'')from tmp where cut_desc>'')select cut_id,cut_name from tmp where cut_name<>'' union select cut_id,cut_name from Dia_cut_Master")
        Dim PolishDataTable As DataTable = GENERAL_FUNCTIONS.NFetchDatatable("with tmp(polish_id,polish_name,polish_desc)as(select polish_id,LEFT(polish_desc,charindex(',',polish_desc + ',')-1),STUFF(polish_desc,1, charindex(',', polish_desc + ','),'')from Dia_polish_Master union all select polish_id,LEFT(polish_desc,charindex(',',polish_desc + ',')-1), STUFF(polish_desc,1, charindex(',', polish_desc + ','),'')from tmp where polish_desc>'')select polish_id,polish_name from tmp where polish_name<>'' union select polish_id,polish_name from Dia_polish_Master")
        Dim SymDataTable As DataTable = GENERAL_FUNCTIONS.NFetchDatatable("with tmp(symm_id,symm_name,symm_desc)as(select symm_id,LEFT(symm_desc,charindex(',',symm_desc + ',')-1),STUFF(symm_desc,1, charindex(',', symm_desc + ','),'')from Dia_symm_Master union all select symm_id,LEFT(symm_desc,charindex(',',symm_desc + ',')-1), STUFF(symm_desc,1, charindex(',', symm_desc + ','),'')from tmp where symm_desc>'')select symm_id,symm_name from tmp where symm_name<>'' union select symm_id,symm_name from Dia_symm_Master")
        Dim ItemTypeDataTable As DataTable = GENERAL_FUNCTIONS.NFetchDatatable("with tmp(item_type_id,item_type_name,item_type_desc)as(select item_type_id,LEFT(item_type_desc,charindex(',',item_type_desc + ',')-1),STUFF(item_type_desc,1, charindex(',', item_type_desc + ','),'')from Dia_Item_Type_Master union all select item_type_id,LEFT(item_type_desc,charindex(',',item_type_desc + ',')-1), STUFF(item_type_desc,1, charindex(',', item_type_desc + ','),'')from tmp where item_type_desc>'')select item_type_id,item_type_name from tmp where item_type_name<>'' union select item_type_id,item_type_name from Dia_Item_Type_Master")
        Dim MainLotDataTable As DataTable = GENERAL_FUNCTIONS.NFetchDatatable("select MainPacketID,MainLotName from Dia_Main_Packet_Master")
        Validation = True
        If dt.Rows.Count = 0 Then
            Validation = False
        Else
            For i = 0 To dt.Rows.Count - 1
                Dim msgarray As String = ""
                dt.Rows(i).Item("ShapeID") = DF.GetShapeID(dt.Rows(i).Item("Shape").ToString, shapeDatatable)
                dt.Rows(i).Item("ColorID") = DF.GetColorID(dt.Rows(i).Item("Color").ToString, ColorDataTable)
                dt.Rows(i).Item("ClarityID") = DF.GetClarityID(dt.Rows(i).Item("Clarity").ToString, ClarityDataTable)
                dt.Rows(i).Item("FloID") = DF.GetFloID(dt.Rows(i).Item("Flo").ToString, FloDataTable)
                dt.Rows(i).Item("CutID") = DF.GetCutID(dt.Rows(i).Item("Cut").ToString, CutDataTable)
                dt.Rows(i).Item("PolishID") = DF.GetPolishID(dt.Rows(i).Item("Polish").ToString, PolishDataTable)
                dt.Rows(i).Item("SymID") = DF.GetSymID(dt.Rows(i).Item("Sym").ToString, SymDataTable)
                dt.Rows(i).Item("ItemTypeID") = DF.GetItemType(dt.Rows(i).Item("ItemType").ToString, ItemTypeDataTable)
                dt.Rows(i).Item("MainLotID") = DF.GetMainLot(dt.Rows(i).Item("MainLot").ToString, MainLotDataTable)

                Dim count = GENERAL_FUNCTIONS.NExcuteScaler("Select Count(StockID) from Dia_Mainstock where StockID='" & dt.Rows(i).Item("StockID") & "'")
                If count > 0 Then
                    Validation = False
                    If msgarray = "" Then
                        msgarray = "Duplicate StockID"
                    Else
                        msgarray = msgarray & ",Duplicate StockID"
                    End If
                ElseIf dt.Rows(i).Item("ItemTypeID") = 0 Then
                    Validation = False
                    If msgarray = "" Then
                        msgarray = "Item Type"
                    Else
                        msgarray = msgarray & ",Item Type"
                    End If
                ElseIf dt.Rows(i).Item("MainLotID") = 0 Then
                    Validation = False
                    If msgarray = "" Then
                        msgarray = "Main Lot"
                    Else
                        msgarray = msgarray & ",Main Lot"
                    End If
                ElseIf dt.Rows(i).Item("ShapeID") = 0 Then
                    Validation = False
                    If msgarray = "" Then
                        msgarray = "Shape"
                    Else
                        msgarray = msgarray & ",Shape"
                    End If
                ElseIf dt.Rows(i).Item("ColorID") = 0 Then
                    Validation = False
                    If msgarray = "" Then
                        msgarray = "Color"
                    Else
                        msgarray = msgarray & ",Color"
                    End If
                ElseIf dt.Rows(i).Item("ClarityID") = 0 Then
                    Validation = False
                    If msgarray = "" Then
                        msgarray = "Clarity"
                    Else
                        msgarray = msgarray & ",Clarity"
                    End If
                ElseIf dt.Rows(i).Item("FloID") = 0 Then
                    Validation = False
                    If msgarray = "" Then
                        msgarray = "Flour"
                    Else
                        msgarray = msgarray & ",Flour"
                    End If
                Else
                    If dt.Rows(i).Item("Cut").ToString = String.Empty Then
                    Else
                        If dt.Rows(i).Item("CutID") = 0 Then
                            Validation = False
                            If msgarray = "" Then
                                msgarray = "Cut"
                            Else
                                msgarray = msgarray & ",Cut"
                            End If
                        End If
                    End If
                    If dt.Rows(i).Item("Polish").ToString = String.Empty Then
                    Else
                        If dt.Rows(i).Item("PolishID") = 0 Then
                            Validation = False
                            If msgarray = "" Then
                                msgarray = "Polish"
                            Else
                                msgarray = msgarray & ",Polish"
                            End If
                        End If
                    End If
                    If dt.Rows(i).Item("Sym").ToString = String.Empty Then
                    Else
                        If dt.Rows(i).Item("SymID") = 0 Then
                            Validation = False
                            If msgarray = "" Then
                                msgarray = "Sym"
                            Else
                                msgarray = msgarray & ",Sym"
                            End If
                        End If
                    End If
                End If
                dt.Rows(i).Item("Error") = msgarray
            Next
            dg.DataSource = dt
        End If
        Return Validation
    End Function
    Private Sub UpdateRowFields()
        Dim UnionID As Integer = GENERAL_FUNCTIONS.MaxNo("Select max(UnionID) from Dia_MainStock")
        Dim barcode As Integer = GENERAL_FUNCTIONS.MaxNo("select Max(Barcode) from Dia_MainStock")
        Dim StatusID As Integer = GENERAL_FUNCTIONS.NExcuteScalerInt("Select lot_status_id from Dia_Lot_Status_Master where lot_Status_name='Available'")
        For i = 0 To SaveDT.Rows.Count - 1
            'Lab Resutl fields update here
            SaveDT.Rows(i).Item("ItemTypeID") = dt.Rows(i).Item("ItemTypeID")
            SaveDT.Rows(i).Item("MainLotID") = dt.Rows(i).Item("MainLotID")
            SaveDT.Rows(i).Item("StockID") = dt.Rows(i).Item("StockID")
            SaveDT.Rows(i).Item("Barcode") = barcode + i
            SaveDT.Rows(i).Item("Qty") = dt.Rows(i).Item("Qty")
            SaveDT.Rows(i).Item("Carats") = dt.Rows(i).Item("Carats")
            SaveDT.Rows(i).Item("LabourINR") = dt.Rows(i).Item("LabourINR")
            SaveDT.Rows(i).Item("ShapeID") = dt.Rows(i).Item("ShapeID")
            SaveDT.Rows(i).Item("ColorID") = dt.Rows(i).Item("ColorID")
            SaveDT.Rows(i).Item("ClarityID") = dt.Rows(i).Item("ClarityID")
            SaveDT.Rows(i).Item("FloID") = dt.Rows(i).Item("FloID")
            SaveDT.Rows(i).Item("CutID") = dt.Rows(i).Item("CutID")
            SaveDT.Rows(i).Item("PolishID") = dt.Rows(i).Item("PolishID")
            SaveDT.Rows(i).Item("SymID") = dt.Rows(i).Item("SymID")
            SaveDT.Rows(i).Item("Comment") = dt.Rows(i).Item("Comment")
            SaveDT.Rows(i).Item("VideoLink") = dt.Rows(i).Item("VideoLink")
            SaveDT.Rows(i).Item("ImageLink") = dt.Rows(i).Item("ImageLink")




            ' DB Update Fields Starts from Here


            SaveDT.Rows(i).Item("LabourUSD") = Val(dt.Rows(i).Item("LabourINR") / GLOBAL_VARIABLES.ExRate)
            SaveDT.Rows(i).Item("LabourExRate") = GLOBAL_VARIABLES.ExRate
            SaveDT.Rows(i).Item("HistoryDescription") = "Stock Import"
            SaveDT.Rows(i).Item("UnionID") = UnionID
            SaveDT.Rows(i).Item("ExecutionDateTime") = Now
            SaveDT.Rows(i).Item("ImportDate") = Now
            SaveDT.Rows(i).Item("StatusID") = StatusID
            SaveDT.Rows(i).Item("Certified") = False
            SaveDT.Rows(i).Item("ProcessStatus") = False
            SaveDT.Rows(i).Item("UserID") = GLOBAL_VARIABLES.UID
            SaveDT.Rows(i).Item("CompanyID") = GLOBAL_VARIABLES.CID
            SaveDT.Rows(i).Item("BranchID") = GLOBAL_VARIABLES.BID
            SaveDT.Rows(i).Item("RAP") = DevFunctions.GetRAP(dt.Rows(i).Item("ShapeID"), dt.Rows(i).Item("ColorID"), dt.Rows(i).Item("ClarityID"), dt.Rows(i).Item("Carats"))

        Next
    End Sub

    Private Sub btnSaveClose_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSaveClose.ItemClick
        SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
        If dt.Rows.Count = 0 Then
            DevFunctions.ErrorMsg("Select Stock Import Excel")
            Exit Sub
        End If
        If SaveData() = True Then
            SplashScreenManager.CloseForm(False)
            Me.Close()
        Else
            DevFunctions.ErrorMsg("Excel data is not valid." & vbCrLf & "Please Check Error Column")
        End If
    End Sub
End Class