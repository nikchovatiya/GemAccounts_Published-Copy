Imports DevExpress.XtraSplashScreen

Public Class FrmExcelGIAResultImport
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
        dt.Columns.Add("StockID")
        dt.Columns.Add("LCertificateNo")
        dt.Columns.Add("LReportDate", GetType(Date))
        dt.Columns.Add("Carats", GetType(Double))
        dt.Columns.Add("Shape")
        dt.Columns.Add("Color")
        dt.Columns.Add("Clarity")
        dt.Columns.Add("Flo")
        dt.Columns.Add("Cut")
        dt.Columns.Add("Polish")
        dt.Columns.Add("Sym")
        dt.Columns.Add("Llength", GetType(Double))
        dt.Columns.Add("LWidth", GetType(Double))
        dt.Columns.Add("LDepth", GetType(Double))
        dt.Columns.Add("LTotalDepth", GetType(Double))
        dt.Columns.Add("LTable", GetType(Double))
        dt.Columns.Add("LCrownHeight", GetType(Double))
        dt.Columns.Add("LCrownAngle", GetType(Double))
        dt.Columns.Add("LPavillionDepth", GetType(Double))
        dt.Columns.Add("LPavillionAngle", GetType(Double))
        dt.Columns.Add("Girdle")
        dt.Columns.Add("GirdleCondition")
        dt.Columns.Add("LGirdlePercent", GetType(Double))
        dt.Columns.Add("Culet")
        dt.Columns.Add("LFloColor")
        dt.Columns.Add("LLabiscribe")
        dt.Columns.Add("LDocumentNo")
        dt.Columns.Add("LReportComments")
        dt.Columns.Add("LCountryofOrigin")
        dt.Columns.Add("LClarityStatus")
        dt.Columns.Add("GIAPainting")
        dt.Columns.Add("LProportion")
        dt.Columns.Add("LReportType")
        dt.Columns.Add("LabMemoNo")
        dt.Columns.Add("GIADiamondDossier")
        dt.Columns.Add("GIAColorDescriptions")
        dt.Columns.Add("GIAStrLn", GetType(Double))
        dt.Columns.Add("GIALrHalf", GetType(Double))
        dt.Columns.Add("GIAPaintComm")
        dt.Columns.Add("GIAKeytoSymbols")
        dt.Columns.Add("GIASyntheticIndicator")
        dt.Columns.Add("GIAPolishFeatures")
        dt.Columns.Add("GIASymmetryFeatures")
        dt.Columns.Add("GIAJobNo")
        dt.Columns.Add("GIASorting")
        dt.Columns.Add("GIABasketStatus")
        dt.Columns.Add("GIADiamondType")
        dt.Columns.Add("GIAShape")

    End Sub
    Private Sub addDBColumns()
        With dt.Columns
            .Add("ShapeID", GetType(Integer))
            .Add("ColorID", GetType(Integer))
            .Add("ClarityID", GetType(Integer))
            .Add("FloID", GetType(Integer))
            .Add("CutID", GetType(Integer))
            .Add("PolishID", GetType(Integer))
            .Add("SymID", GetType(Integer))
            .Add("Barcode", GetType(Integer))
            .Add("Certified", GetType(Boolean))
            .Add("LabID", GetType(Integer))
            .Add("HistoryDescription", GetType(String))
            .Add("UnionID", GetType(Integer))
            .Add("ExecutionDateTime", GetType(DateTime))
            .Add("GirdleID", GetType(Integer))
            .Add("GirdleConditionID", GetType(Integer))
            .Add("CuletID", GetType(Integer)) '.ColumnMapping = MappingType.Hidden
        End With

    End Sub
    Private Sub addrows()
        dt.Rows.Clear()
        For i = 0 To tmpDT.Rows.Count - 1
            Dim dr As DataRow = dt.NewRow()
            dr("GIAJobNo") = LabTranslation.LabRemoveNA(tmpDT.Rows(i).Item(0).ToString)
            dr("LDocumentNo") = LabTranslation.LabRemoveNA(tmpDT.Rows(i).Item(1).ToString)
            dr("GIADiamondDossier") = LabTranslation.LabRemoveNA(tmpDT.Rows(i).Item(2).ToString)
            dr("LCertificateNo") = LabTranslation.LabRemoveNA(tmpDT.Rows(i).Item(3).ToString)
            dr("LReportDate") = LabTranslation.LabValueDate(tmpDT.Rows(i).Item(4).ToString)
            dr("StockID") = LabTranslation.LabRemoveNA(tmpDT.Rows(i).Item(5).ToString)
            dr("LabMemoNo") = LabTranslation.LabRemoveNA(tmpDT.Rows(i).Item(6).ToString)
            dr("Shape") = LabTranslation.LabRemoveNA(tmpDT.Rows(i).Item(7).ToString)
            dr("Llength") = LabTranslation.LabValueDouble(tmpDT.Rows(i).Item(8).ToString)
            dr("LWidth") = LabTranslation.LabValueDouble(tmpDT.Rows(i).Item(9).ToString)
            dr("LDepth") = LabTranslation.LabValueDouble(tmpDT.Rows(i).Item(10).ToString)
            dr("Carats") = LabTranslation.LabValueDouble(tmpDT.Rows(i).Item(11).ToString)
            dr("Color") = LabTranslation.LabRemoveNA(tmpDT.Rows(i).Item(12).ToString)
            dr("GIAColorDescriptions") = LabTranslation.LabRemoveNA(tmpDT.Rows(i).Item(13).ToString)
            dr("Clarity") = LabTranslation.LabRemoveNA(tmpDT.Rows(i).Item(14).ToString)
            dr("LClarityStatus") = LabTranslation.LabRemoveNA(tmpDT.Rows(i).Item(15).ToString)
            dr("Cut") = LabTranslation.LabRemoveNA(tmpDT.Rows(i).Item(16).ToString)
            dr("Polish") = LabTranslation.LabRemoveNA(tmpDT.Rows(i).Item(17).ToString)
            dr("Sym") = LabTranslation.LabRemoveNA(tmpDT.Rows(i).Item(18).ToString)
            dr("Flo") = LabTranslation.LabRemoveNA(tmpDT.Rows(i).Item(19).ToString)
            dr("LFloColor") = LabTranslation.LabRemoveNA(tmpDT.Rows(i).Item(20).ToString)
            dr("Girdle") = LabTranslation.LabRemoveNA(tmpDT.Rows(i).Item(21).ToString)
            dr("GirdleCondition") = LabTranslation.LabRemoveNA(tmpDT.Rows(i).Item(22).ToString)
            dr("Culet") = LabTranslation.LabRemoveNA(tmpDT.Rows(i).Item(23).ToString)
            dr("LTotalDepth") = LabTranslation.LabValueDouble(tmpDT.Rows(i).Item(24).ToString)
            dr("LTable") = LabTranslation.LabValueDouble(tmpDT.Rows(i).Item(25).ToString)
            dr("LCrownAngle") = LabTranslation.LabValueDouble(tmpDT.Rows(i).Item(26).ToString)
            dr("LCrownHeight") = Val(LabTranslation.LabValueDouble(tmpDT.Rows(i).Item(27).ToString) * 100)
            dr("LPavillionAngle") = LabTranslation.LabValueDouble(tmpDT.Rows(i).Item(28).ToString)
            dr("LPavillionDepth") = Val(LabTranslation.LabValueDouble(tmpDT.Rows(i).Item(29).ToString) * 100)
            dr("GIAStrLn") = Val(LabTranslation.LabValueDouble(tmpDT.Rows(i).Item(30).ToString) * 100)
            dr("GIALrHalf") = Val(LabTranslation.LabValueDouble(tmpDT.Rows(i).Item(31).ToString) * 100)
            dr("GIAPainting") = LabTranslation.LabRemoveNA(tmpDT.Rows(i).Item(32).ToString)
            dr("LProportion") = LabTranslation.LabRemoveNA(tmpDT.Rows(i).Item(33).ToString)
            dr("GIAPaintComm") = LabTranslation.LabRemoveNA(tmpDT.Rows(i).Item(34).ToString)
            dr("GIAKeytoSymbols") = LabTranslation.LabRemoveNA(tmpDT.Rows(i).Item(35).ToString)
            dr("LReportComments") = LabTranslation.LabRemoveNA(tmpDT.Rows(i).Item(36).ToString)
            dr("LLabiscribe") = LabTranslation.LabRemoveNA(tmpDT.Rows(i).Item(37).ToString)
            dr("GIASyntheticIndicator") = LabTranslation.LabRemoveNA(tmpDT.Rows(i).Item(38).ToString)
            dr("LGirdlePercent") = Val(LabTranslation.LabValueDouble(tmpDT.Rows(i).Item(39).ToString) * 100)
            dr("GIAPolishFeatures") = LabTranslation.LabRemoveNA(tmpDT.Rows(i).Item(40).ToString)
            dr("GIASymmetryFeatures") = LabTranslation.LabRemoveNA(tmpDT.Rows(i).Item(41).ToString)
            dr("GIAShape") = LabTranslation.LabRemoveNA(tmpDT.Rows(i).Item(42).ToString)
            dr("LReportType") = LabTranslation.LabRemoveNA(tmpDT.Rows(i).Item(43).ToString)
            dr("GIASorting") = LabTranslation.LabRemoveNA(tmpDT.Rows(i).Item(44).ToString)
            dr("GIABasketStatus") = LabTranslation.LabRemoveNA(tmpDT.Rows(i).Item(45).ToString)
            dr("LCountryofOrigin") = LabTranslation.LabRemoveNA(tmpDT.Rows(i).Item(46).ToString)
            dr("GIADiamondType") = LabTranslation.LabRemoveNA(tmpDT.Rows(i).Item(47).ToString)

            dt.Rows.Add(dr.ItemArray)
        Next
    End Sub

    Private Sub BtnSave_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnSave.ItemClick
        SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
        If dt.Rows.Count = 0 Then
            DevFunctions.ErrorMsg("Select Lab Result Excel")
            Exit Sub
        End If
        If SaveData() = True Then
            DevFunctions.InfoMsg("Result Imported successfully")
            btnCancel_ItemClick(sender, e)
        Else
            DevFunctions.ErrorMsg("Excel data is not valid." & vbCrLf & "Please Check Error Column")
        End If
        SplashScreenManager.CloseForm(False)
    End Sub
    Private Function Validation() As Boolean
        Validation = True
        If dt.Rows.Count = 0 Then
            Validation = False
        End If
        Dim shapeDatatable As DataTable = GENERAL_FUNCTIONS.NFetchDatatable("with tmp(shape_id,shape_name,Shape_Desc)as(select Shape_ID,LEFT(Shape_Desc,charindex(',',Shape_Desc + ',')-1),STUFF(Shape_Desc,1, charindex(',', Shape_Desc + ','),'')from Dia_Shape_Master union all select Shape_ID,LEFT(Shape_Desc,charindex(',',Shape_Desc + ',')-1), STUFF(Shape_Desc,1, charindex(',', Shape_Desc + ','),'')from tmp where Shape_Desc>'')select shape_id,shape_name from tmp where shape_name<>'' union select shape_id,shape_name from dia_shape_Master")
        Dim ColorDataTable As DataTable = GENERAL_FUNCTIONS.NFetchDatatable("with tmp(color_id,color_name,color_desc)as(select color_id,LEFT(color_desc,charindex(',',color_desc + ',')-1),STUFF(color_desc,1, charindex(',', color_desc + ','),'')from Dia_Color_Master union all select color_id,LEFT(color_desc,charindex(',',color_desc + ',')-1), STUFF(color_desc,1, charindex(',', color_desc + ','),'')from tmp where color_desc>'')select color_id,color_name from tmp where color_name<>'' union select color_id,color_name from Dia_Color_Master")
        Dim ClarityDataTable As DataTable = GENERAL_FUNCTIONS.NFetchDatatable("with tmp(clarity_id,clarity_name,clarity_desc)as(select clarity_id,LEFT(clarity_desc,charindex(',',clarity_desc + ',')-1),STUFF(clarity_desc,1, charindex(',', clarity_desc + ','),'')from Dia_clarity_Master union all select clarity_id,LEFT(clarity_desc,charindex(',',clarity_desc + ',')-1), STUFF(clarity_desc,1, charindex(',', clarity_desc + ','),'')from tmp where clarity_desc>'')select clarity_id,clarity_name from tmp where clarity_name<>'' union select clarity_id,clarity_name from Dia_clarity_Master")
        Dim FloDataTable As DataTable = GENERAL_FUNCTIONS.NFetchDatatable("with tmp(flo_id,flo_name,flo_desc)as(select flo_id,LEFT(flo_desc,charindex(',',flo_desc + ',')-1),STUFF(flo_desc,1, charindex(',', flo_desc + ','),'')from Dia_flo_Master union all select flo_id,LEFT(flo_desc,charindex(',',flo_desc + ',')-1), STUFF(flo_desc,1, charindex(',', flo_desc + ','),'')from tmp where flo_desc>'')select flo_id,flo_name from tmp where flo_name<>'' union select flo_id,flo_name from Dia_flo_Master")
        Dim CutDataTable As DataTable = GENERAL_FUNCTIONS.NFetchDatatable("with tmp(cut_id,cut_name,cut_desc)as(select cut_id,LEFT(cut_desc,charindex(',',cut_desc + ',')-1),STUFF(cut_desc,1, charindex(',', cut_desc + ','),'')from Dia_cut_Master union all select cut_id,LEFT(cut_desc,charindex(',',cut_desc + ',')-1), STUFF(cut_desc,1, charindex(',', cut_desc + ','),'')from tmp where cut_desc>'')select cut_id,cut_name from tmp where cut_name<>'' union select cut_id,cut_name from Dia_cut_Master")
        Dim PolishDataTable As DataTable = GENERAL_FUNCTIONS.NFetchDatatable("with tmp(polish_id,polish_name,polish_desc)as(select polish_id,LEFT(polish_desc,charindex(',',polish_desc + ',')-1),STUFF(polish_desc,1, charindex(',', polish_desc + ','),'')from Dia_polish_Master union all select polish_id,LEFT(polish_desc,charindex(',',polish_desc + ',')-1), STUFF(polish_desc,1, charindex(',', polish_desc + ','),'')from tmp where polish_desc>'')select polish_id,polish_name from tmp where polish_name<>'' union select polish_id,polish_name from Dia_polish_Master")
        Dim SymDataTable As DataTable = GENERAL_FUNCTIONS.NFetchDatatable("with tmp(symm_id,symm_name,symm_desc)as(select symm_id,LEFT(symm_desc,charindex(',',symm_desc + ',')-1),STUFF(symm_desc,1, charindex(',', symm_desc + ','),'')from Dia_symm_Master union all select symm_id,LEFT(symm_desc,charindex(',',symm_desc + ',')-1), STUFF(symm_desc,1, charindex(',', symm_desc + ','),'')from tmp where symm_desc>'')select symm_id,symm_name from tmp where symm_name<>'' union select symm_id,symm_name from Dia_symm_Master")
        Dim GirdleDataTable As DataTable = GENERAL_FUNCTIONS.NFetchDatatable("with tmp(GirdleID,GirdleName,GirdleDesc)as(select GirdleID,LEFT(GirdleDesc,charindex(',',GirdleDesc + ',')-1),STUFF(GirdleDesc,1, charindex(',', GirdleDesc + ','),'')from Dia_Girdle_Master union all select GirdleID,LEFT(GirdleDesc,charindex(',',GirdleDesc + ',')-1), STUFF(GirdleDesc,1, charindex(',', GirdleDesc + ','),'')from tmp where GirdleDesc>'')select GirdleID,GirdleName from tmp where GirdleName<>'' union select GirdleID,GirdleName from Dia_Girdle_Master")
        Dim GirdleConditionDataTable As DataTable = GENERAL_FUNCTIONS.NFetchDatatable("with tmp(GirdleConditionID,GirdleConditionName,GirdleConditionDesc)as(select GirdleConditionID,LEFT(GirdleConditionDesc,charindex(',',GirdleConditionDesc + ',')-1),STUFF(GirdleConditionDesc,1, charindex(',', GirdleConditionDesc + ','),'')from Dia_GirdleCondition_Master union all select GirdleConditionID,LEFT(GirdleConditionDesc,charindex(',',GirdleConditionDesc + ',')-1), STUFF(GirdleConditionDesc,1, charindex(',', GirdleConditionDesc + ','),'')from tmp where GirdleConditionDesc>'')select GirdleConditionID,GirdleConditionName from tmp where GirdleConditionName<>'' union select GirdleConditionID,GirdleConditionName from Dia_GirdleCondition_Master")
        Dim CuletDataTable As DataTable = GENERAL_FUNCTIONS.NFetchDatatable("with tmp(CuletID,CuletName,CuletDesc)as(select CuletID,LEFT(CuletDesc,charindex(',',CuletDesc + ',')-1),STUFF(CuletDesc,1, charindex(',', CuletDesc + ','),'')from Dia_Culet_Master union all select CuletID,LEFT(CuletDesc,charindex(',',CuletDesc + ',')-1), STUFF(CuletDesc,1, charindex(',', CuletDesc + ','),'')from tmp where CuletDesc>'')select CuletID,CuletName from tmp where CuletName<>'' union select CuletID,CuletName from Dia_Culet_Master")


        For i = 0 To dt.Rows.Count - 1
            Dim msgarray As String = ""
            dt.Rows(i).Item("ShapeID") = DF.GetShapeID(dt.Rows(i).Item("Shape").ToString, shapeDatatable)
            dt.Rows(i).Item("ColorID") = DF.GetColorID(dt.Rows(i).Item("Color").ToString, ColorDataTable)
            dt.Rows(i).Item("ClarityID") = DF.GetClarityID(dt.Rows(i).Item("Clarity").ToString, ClarityDataTable)
            dt.Rows(i).Item("FloID") = DF.GetFloID(dt.Rows(i).Item("Flo").ToString, FloDataTable)
            dt.Rows(i).Item("CutID") = DF.GetCutID(dt.Rows(i).Item("Cut").ToString, CutDataTable)
            dt.Rows(i).Item("PolishID") = DF.GetPolishID(dt.Rows(i).Item("Polish").ToString, PolishDataTable)
            dt.Rows(i).Item("SymID") = DF.GetSymID(dt.Rows(i).Item("Sym").ToString, SymDataTable)
            dt.Rows(i).Item("Barcode") = DF.GetBarcode(dt.Rows(i).Item("StockID"))
            dt.Rows(i).Item("GirdleID") = DF.GetGirdleID(dt.Rows(i).Item("Girdle").ToString, GirdleDataTable)
            dt.Rows(i).Item("GirdleConditionID") = DF.GetGirdleConditionID(dt.Rows(i).Item("GirdleCondition").ToString, GirdleConditionDataTable)
            dt.Rows(i).Item("CuletID") = DF.GetCuletID(dt.Rows(i).Item("Culet").ToString, CuletDataTable)
            If dt.Rows(i).Item("ShapeID") = 0 Then
                Validation = False
                If msgarray = "" Then
                    msgarray = "Shape"
                Else
                    msgarray = msgarray & ",Shape"
                End If
            End If
            If dt.Rows(i).Item("ColorID") = 0 Then
                Validation = False
                If msgarray = "" Then
                    msgarray = "Color"
                Else
                    msgarray = msgarray & ",Color"
                End If
            End If
            If dt.Rows(i).Item("ClarityID") = 0 Then
                Validation = False
                If msgarray = "" Then
                    msgarray = "Clarity"
                Else
                    msgarray = msgarray & ",Clarity"
                End If
            End If
            If dt.Rows(i).Item("FloID") = 0 Then
                Validation = False
                If msgarray = "" Then
                    msgarray = "Flour"
                Else
                    msgarray = msgarray & ",Flour"
                End If
            End If
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
            If dt.Rows(i).Item("PolishID") = 0 Then
                Validation = False
                If msgarray = "" Then
                    msgarray = "Polish"
                Else
                    msgarray = msgarray & ",Polish"
                End If
            End If
            If dt.Rows(i).Item("SymID") = 0 Then
                Validation = False
                If msgarray = "" Then
                    msgarray = "Sym"
                Else
                    msgarray = msgarray & ",Sym"
                End If
            End If
            If dt.Rows(i).Item("Barcode") = 0 Then
                Validation = False
                If msgarray = "" Then
                    msgarray = "StockID"
                Else
                    msgarray = msgarray & ",StockID"
                End If
            End If
            If dt.Rows(i).Item("Girdle").ToString = String.Empty Then
            Else
                If dt.Rows(i).Item("GirdleID") = 0 Then
                    Validation = False
                    If msgarray = "" Then
                        msgarray = "Girdle"
                    Else
                        msgarray = msgarray & ",Girdle"
                    End If
                End If
            End If
            If dt.Rows(i).Item("GirdleCondition").ToString = String.Empty Then
            Else
                If dt.Rows(i).Item("GirdleConditionID") = 0 Then
                    Validation = False
                    If msgarray = "" Then
                        msgarray = "Girdle Condition"
                    Else
                        msgarray = msgarray & ",Girdle Condition"
                    End If
                End If
            End If
            If dt.Rows(i).Item("Culet").ToString = String.Empty Then
            Else
                If dt.Rows(i).Item("CuletID") = 0 Then
                    Validation = False
                    If msgarray = "" Then
                        msgarray = "Culet"
                    Else
                        msgarray = msgarray & ",Culet"
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
            SaveDT = DevFunctions.GetEmptyMainStockDatatable()
            For i = 0 To dt.Rows.Count - 1
                Dim dr As DataRow
                dr = GENERAL_FUNCTIONS.NFetchDataRow("select top(1) * from dia_mainstock where Barcode='" & dt.Rows(i).Item("Barcode") & "' order by TransactionID Desc")
                If dr Is Nothing Then
                Else
                    SaveDT.NewRow()
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
        Dim LabID As Integer = GENERAL_FUNCTIONS.NExcuteScalerInt("Select lab_id from Dia_Lab_Master where lab_name='GIA'")
        Dim UnionID As Integer = GENERAL_FUNCTIONS.MaxNo("Select max(UnionID) from Dia_MainStock")
        For i = 0 To SaveDT.Rows.Count - 1
            'Lab Resutl fields update here
            SaveDT.Rows(i).Item("GIAJobNo") = dt.Rows(i).Item("GIAJobNo")
            SaveDT.Rows(i).Item("LDocumentNo") = dt.Rows(i).Item("LDocumentNo")
            SaveDT.Rows(i).Item("GIADiamondDossier") = dt.Rows(i).Item("GIADiamondDossier")
            SaveDT.Rows(i).Item("LCertificateNo") = dt.Rows(i).Item("LCertificateNo")
            SaveDT.Rows(i).Item("LReportDate") = dt.Rows(i).Item("LReportDate")
            SaveDT.Rows(i).Item("LabMemoNo") = dt.Rows(i).Item("LabMemoNo")
            SaveDT.Rows(i).Item("Llength") = dt.Rows(i).Item("Llength")
            SaveDT.Rows(i).Item("LWidth") = dt.Rows(i).Item("LWidth")
            SaveDT.Rows(i).Item("LDepth") = dt.Rows(i).Item("LDepth")
            SaveDT.Rows(i).Item("Carats") = dt.Rows(i).Item("Carats")
            SaveDT.Rows(i).Item("GIAColorDescriptions") = dt.Rows(i).Item("GIAColorDescriptions")
            SaveDT.Rows(i).Item("LClarityStatus") = dt.Rows(i).Item("LClarityStatus")
            SaveDT.Rows(i).Item("LFloColor") = dt.Rows(i).Item("LFloColor")
            SaveDT.Rows(i).Item("LTotalDepth") = dt.Rows(i).Item("LTotalDepth")
            SaveDT.Rows(i).Item("LTable") = dt.Rows(i).Item("LTable")
            SaveDT.Rows(i).Item("LCrownAngle") = dt.Rows(i).Item("LCrownAngle")
            SaveDT.Rows(i).Item("LCrownHeight") = dt.Rows(i).Item("LCrownHeight")
            SaveDT.Rows(i).Item("LPavillionAngle") = dt.Rows(i).Item("LPavillionAngle")
            SaveDT.Rows(i).Item("LPavillionDepth") = dt.Rows(i).Item("LPavillionDepth")
            SaveDT.Rows(i).Item("GIAStrLn") = dt.Rows(i).Item("GIAStrLn")
            SaveDT.Rows(i).Item("GIALrHalf") = dt.Rows(i).Item("GIALrHalf")
            SaveDT.Rows(i).Item("GIAPainting") = dt.Rows(i).Item("GIAPainting")
            SaveDT.Rows(i).Item("LProportion") = dt.Rows(i).Item("LProportion")
            SaveDT.Rows(i).Item("GIAPaintComm") = dt.Rows(i).Item("GIAPaintComm")
            SaveDT.Rows(i).Item("GIAKeytoSymbols") = dt.Rows(i).Item("GIAKeytoSymbols")
            SaveDT.Rows(i).Item("LReportComments") = dt.Rows(i).Item("LReportComments")
            SaveDT.Rows(i).Item("LLabiscribe") = dt.Rows(i).Item("LLabiscribe")
            SaveDT.Rows(i).Item("GIASyntheticIndicator") = dt.Rows(i).Item("GIASyntheticIndicator")
            SaveDT.Rows(i).Item("LGirdlePercent") = dt.Rows(i).Item("LGirdlePercent")
            SaveDT.Rows(i).Item("GIAPolishFeatures") = dt.Rows(i).Item("GIAPolishFeatures")
            SaveDT.Rows(i).Item("GIASymmetryFeatures") = dt.Rows(i).Item("GIASymmetryFeatures")
            SaveDT.Rows(i).Item("LReportType") = dt.Rows(i).Item("LReportType")
            SaveDT.Rows(i).Item("GIASorting") = dt.Rows(i).Item("GIASorting")
            SaveDT.Rows(i).Item("GIABasketStatus") = dt.Rows(i).Item("GIABasketStatus")
            SaveDT.Rows(i).Item("LCountryofOrigin") = dt.Rows(i).Item("LCountryofOrigin")
            SaveDT.Rows(i).Item("GIADiamondType") = dt.Rows(i).Item("GIADiamondType")



            ' DB Update Fields Starts from Here
            SaveDT.Rows(i).Item("ShapeID") = dt.Rows(i).Item("ShapeID")
            SaveDT.Rows(i).Item("ColorID") = dt.Rows(i).Item("ColorID")
            SaveDT.Rows(i).Item("ClarityID") = dt.Rows(i).Item("ClarityID")
            SaveDT.Rows(i).Item("FloID") = dt.Rows(i).Item("FloID")
            SaveDT.Rows(i).Item("CutID") = dt.Rows(i).Item("CutID")
            SaveDT.Rows(i).Item("PolishID") = dt.Rows(i).Item("PolishID")
            SaveDT.Rows(i).Item("SymID") = dt.Rows(i).Item("SymID")
            SaveDT.Rows(i).Item("Barcode") = dt.Rows(i).Item("Barcode")
            SaveDT.Rows(i).Item("GirdleID") = dt.Rows(i).Item("GirdleID")
            SaveDT.Rows(i).Item("GirdleConditionID") = dt.Rows(i).Item("GirdleConditionID")
            SaveDT.Rows(i).Item("CuletID") = dt.Rows(i).Item("CuletID")
            SaveDT.Rows(i).Item("Certified") = True
            SaveDT.Rows(i).Item("LabourINR") = 0
            SaveDT.Rows(i).Item("LabourUSD") = 0
            SaveDT.Rows(i).Item("LabourExRate") = 0
            SaveDT.Rows(i).Item("LabID") = LabID
            SaveDT.Rows(i).Item("HistoryDescription") = "GIA Result Import"
            SaveDT.Rows(i).Item("UnionID") = UnionID
            SaveDT.Rows(i).Item("ExecutionDateTime") = Now
            SaveDT.Rows(i).Item("UserID") = GLOBAL_VARIABLES.UID
            SaveDT.Rows(i).Item("RAP") = DevFunctions.GetRAP(dt.Rows(i).Item("ShapeID"), dt.Rows(i).Item("ColorID"), dt.Rows(i).Item("ClarityID"), dt.Rows(i).Item("Carats"))


            ' Other Lab Fields Goes Blank
            SaveDT.Rows(i).Item("IGILabPrefix") = LabTranslation.IGILabPrefix
            SaveDT.Rows(i).Item("IGILabOtherReportNumber") = LabTranslation.IGILabOtherReportNumber
            SaveDT.Rows(i).Item("IGILabNumberStones") = LabTranslation.IGILabNumberStones
            SaveDT.Rows(i).Item("IGILabDescription") = LabTranslation.IGILabDescription
            SaveDT.Rows(i).Item("IGILabReportFormatI") = LabTranslation.IGILabReportFormatI
            SaveDT.Rows(i).Item("IGILabColorShort") = LabTranslation.IGILabColorShort
            SaveDT.Rows(i).Item("IGILabReportTypeII") = LabTranslation.IGILabReportTypeII
            SaveDT.Rows(i).Item("IGILabReportFormatII") = LabTranslation.IGILabReportFormatII
            SaveDT.Rows(i).Item("IGILabCommentsConsultation") = LabTranslation.IGILabCommentsConsultation
            SaveDT.Rows(i).Item("IGILabSpecialComments") = LabTranslation.IGILabSpecialComments
            SaveDT.Rows(i).Item("IGILabFaxComments") = LabTranslation.IGILabFaxComments
            SaveDT.Rows(i).Item("HRDValidUntil") = LabTranslation.HRDValidUntil
            SaveDT.Rows(i).Item("HRDWeightC") = LabTranslation.HRDWeightC
            SaveDT.Rows(i).Item("HRDWeightlossClarity") = LabTranslation.HRDWeightlossClarity
            SaveDT.Rows(i).Item("HRDECG") = LabTranslation.HRDECG
            SaveDT.Rows(i).Item("HRDCuletDescription") = LabTranslation.HRDCuletDescription
            SaveDT.Rows(i).Item("HRDCuletSizePercent") = LabTranslation.HRDCuletSizePercent
            SaveDT.Rows(i).Item("HRDCAPA") = LabTranslation.HRDCAPA
            SaveDT.Rows(i).Item("HRDLengthHalvesCr") = LabTranslation.HRDLengthHalvesCr
            SaveDT.Rows(i).Item("HRDLengthHalvesPv") = LabTranslation.HRDLengthHalvesPv
            SaveDT.Rows(i).Item("HRDPotentialMake") = LabTranslation.HRDPotentialMake
            SaveDT.Rows(i).Item("HeartArrow") = LabTranslation.HeartArrow
            SaveDT.Rows(i).Item("HRDExtraInfo") = LabTranslation.HRDExtraInfo
            SaveDT.Rows(i).Item("HRDFancycolour") = LabTranslation.HRDFancycolour
            SaveDT.Rows(i).Item("HRDFin") = LabTranslation.HRDFin
            SaveDT.Rows(i).Item("HRDAfm") = LabTranslation.HRDAfm
            SaveDT.Rows(i).Item("HRDScSampletype") = LabTranslation.HRDScSampletype
            SaveDT.Rows(i).Item("HRDPremiumIdealCut") = LabTranslation.HRDPremiumIdealCut

        Next
    End Sub

    Private Sub btnCancel_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCancel.ItemClick
        dg.DataSource = Nothing
        dt.Columns.Clear()
        dt.Rows.Clear()
    End Sub

    Private Sub btnSaveClose_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSaveClose.ItemClick
        SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
        If SaveData() = True Then
            Me.Close()
        Else
            DevFunctions.ErrorMsg("Not Validated")
        End If
        SplashScreenManager.CloseForm(False)
    End Sub

End Class
