Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports GemAccounts.GLOBAL_VARIABLES
Imports DevExpress.DataAccess.Excel
Imports System.ComponentModel
Imports Newtonsoft.Json
Imports System.Net
Imports Newtonsoft.Json.Linq
Imports DevExpress.XtraPrinting
Imports System.IO
Imports DevExpress.Export
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraBars.Docking
Imports DevExpress.XtraGrid.Menu
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraSplashScreen
Imports DevExpress.Utils
Imports DevExpress.Utils.Svg

Public Class DevFunctions
    Public Shared Sub Nfill_Ledgers_by_Group_GridLookupEdit(ByVal LedgerTypes As String(), Table As String, Display As String, Value As String, ByVal ctrl As DevExpress.XtraEditors.GridLookUpEdit)
        Dim dt As New DataTable
        Dim queryadd As String = ""
        Dim Query As String = "SELECT " & Value & "," & Display & " From Dia_Ledger_Master Where "
        If Query = Nothing Then Exit Sub
        For i = 0 To LedgerTypes.Length - 1
            If queryadd = "" Then
                queryadd = "LUnderGroup = (Select group_id From Dia_Group_Master Where group_name =  '" & LedgerTypes(i) & "' "
            Else
                queryadd = queryadd + ") or LUnderGroup = (Select group_id From Dia_Group_Master Where group_name =  '" & LedgerTypes(i) & "' "
            End If
        Next
        Query = Query + queryadd & " )"

        Dim dtp As New DataSet
        ADP = New SqlDataAdapter(Query, VarCon.Connection)
        ADP.Fill(dtp)
        dt = dtp.Tables(0)
        VarCon.CloseConnection()

        ctrl.Properties.DataSource = dt
        ctrl.Properties.PopulateViewColumns()
        ctrl.Properties.View.Columns(Value).Visible = False
        ctrl.Properties.DisplayMember = Display
        ctrl.Properties.ValueMember = Value
        ctrl.Properties.PopupView.OptionsView.ShowFilterPanelMode = False
        ctrl.Text = ""
    End Sub
    Public Shared Sub NFillComboDev(ByVal str As String, ByVal NDisplay As String, ByVal ctrl As DevExpress.XtraEditors.ComboBoxEdit)
        GLOBAL_VARIABLES.DS = New DataSet
        ADP = New SqlDataAdapter(str, VarCon.Connection)

        ADP.Fill(GLOBAL_VARIABLES.DS)

        Dim dr As DataRow = DS.Tables(0).NewRow
        dr(NDisplay) = ""
        DS.Tables(0).Rows.InsertAt(dr, 0)
        For Each Row As DataRow In GLOBAL_VARIABLES.DS.Tables(0).Rows
            ctrl.Properties.Items.Add(Row(NDisplay))
        Next

        ctrl.EditValue = Nothing
        VarCon.CloseConnection()
    End Sub
    Public Shared Sub NFill_GridLookupEdit(Table As String, Display As String, Value As String, ByVal ctrl As DevExpress.XtraEditors.GridLookUpEdit)
        Dim dt As New DataTable
        Dim query As String = "SELECT " & Value & "," & Display & " From " & Table
        Dim dtp As New DataSet
        ADP = New SqlDataAdapter(query, VarCon.Connection)
        ADP.Fill(dtp)
        dt = dtp.Tables(0)
        VarCon.CloseConnection()
        ctrl.Properties.DataSource = dt
        ctrl.Properties.PopulateViewColumns()
        ctrl.Properties.View.Columns(Value).Visible = False
        ctrl.Properties.DisplayMember = Display
        ctrl.Properties.ValueMember = Value
        ctrl.Properties.PopupView.OptionsView.ShowFilterPanelMode = False
        ctrl.Text = ""
    End Sub
    Public Shared Sub NFetchSearchLookupEdit(Str As String, ByVal ctrl As DevExpress.XtraEditors.SearchLookUpEdit)
        'Try
        '    Dim dvMainLot As DataView
        '    Dim ds As DataSet = New DataSet
        '    Dim DataAdp = New SqlDataAdapter(Str, VarCon.Connection)
        '    If DataAdp.TableMappings.Count = 0 Then Return
        '    DataAdp.Fill(ds, 0)
        '    Dim dvm As DataViewManager = New DataViewManager(ds)
        '    dvMainLot = dvm.CreateDataView(ds.Tables(0))
        '    ctrl.Properties.DataSource = dvMainLot
        'Catch ex As Exception
        '    XtraMessageBox.Show(ex.Message, "Mauni Diamond", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try

        Dim dt As DataTable = GENERAL_FUNCTIONS.NFetchDatatable(Str)
        If dt Is Nothing Then Return
        If dt.Rows.Count = 0 Then Return
        ctrl.Properties.DataSource = dt
        ctrl.Properties.PopulateViewColumns()
    End Sub
    Public Sub FetchBarEditItem(Str As String, ByVal ctrl As Repository.RepositoryItemLookUpEdit)
        Try
            Dim dvMainLot As DataView
            Dim ds As DataSet = New DataSet
            Dim DataAdp = New SqlDataAdapter(Str, VarCon.Connection)
            DataAdp.Fill(ds, 0)
            Dim dvm As DataViewManager = New DataViewManager(ds)
            dvMainLot = dvm.CreateDataView(ds.Tables(0))
            ctrl.DataSource = dvMainLot
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "Mauni Diamond", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Shared Function SUMPRODUCT(ByVal a() As Double, ByVal b() As Double) As Double
        Dim Result As Double = 0
        For I As Integer = 0 To a.Count - 1
            Result += (a(I) * b(I))
        Next
        Return Result
    End Function
    Public Shared Function GetRAP(ByVal ShapeID As Integer, ByVal ColorID As Integer, ByVal ClarityID As Integer, ByVal Weight As String) As Double
        Dim ShapeName As String = GENERAL_FUNCTIONS.NExcuteScaler("Select RAP_Shape from Dia_Shape_Master where Shape_ID=" & ShapeID & "")
        Dim ColorName As String = GENERAL_FUNCTIONS.NExcuteScaler("select rap_color from Dia_Color_Master where color_id=" & ColorID & "")
        Dim ClarityName As String = GENERAL_FUNCTIONS.NExcuteScaler("select rap_clarity from Dia_Clarity_Master where clarity_id=" & ClarityID & "")
        If ShapeName = String.Empty OrElse ColorName = String.Empty OrElse ClarityName = String.Empty Then
            GetRAP = 0
        Else
            If Weight <= 4.99 Then
                GetRAP = Convert.ToDecimal(GENERAL_FUNCTIONS.NExcuteScaler("SELECT caratprice from Dia_UpdateRapaport where low_size<='" & Weight & "' and high_size>='" & Weight & "' and color='" & ColorName & "' and clarity='" & ClarityName & "' and shape='" & ShapeName & "'"))
            Else
                GetRAP = Convert.ToDouble(GENERAL_FUNCTIONS.NExcuteScaler("SELECT caratprice from Dia_UpdateRapaport where low_size<='5' and high_size>='5.99' and color='" & ColorName & "' and clarity='" & ClarityName & "' and shape='" & ShapeName & "'"))
            End If
        End If
        Return GetRAP
    End Function


    Public Sub AcceptNumer(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim clickedCtrl As System.Windows.Forms.Control
        If TypeOf sender Is System.Windows.Forms.Control Then
            clickedCtrl = DirectCast(sender, System.Windows.Forms.Control)
            If TypeOf clickedCtrl Is TextBox Then
                If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Asc(e.KeyChar) <> 46 AndAlso Not IsNumeric(e.KeyChar) Then
                    XtraMessageBox.Show("Enter only numbers", "Mauni Diamond", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    e.Handled = True
                End If
            End If
        Else
        End If
    End Sub
    Public Shared Sub ErrorMsg(ByVal msg As String)
        XtraMessageBox.Show(msg, "Mauni Diamond", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub
    Public Shared Sub InfoMsg(ByVal msg As String)
        XtraMessageBox.Show(msg, "Mauni Diamond", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Public Sub NFillGridLookupEdit(ByVal str As String, ByVal Nvalue As String, ByVal NDisplay As String, ByVal ctrl As DevExpress.XtraEditors.GridLookUpEdit)
        GLOBAL_VARIABLES.DS = New DataSet
        ADP = New SqlDataAdapter(str, VarCon.Connection)

        ADP.Fill(GLOBAL_VARIABLES.DS)
        GLOBAL_VARIABLES.DS.Tables(0).Columns(Nvalue).ColumnMapping = MappingType.Hidden
        ctrl.Properties.DataSource = GLOBAL_VARIABLES.DS.Tables(0)
        ctrl.Properties.ValueMember = Nvalue
        ctrl.Properties.DisplayMember = NDisplay

        ctrl.EditValue = Nothing
        VarCon.CloseConnection()
    End Sub
    Public Sub NFillCombo(ByVal str As String, ByVal NDisplay As String, ByVal ctrl As DevExpress.XtraEditors.ComboBoxEdit)
        GLOBAL_VARIABLES.DS = New DataSet
        ADP = New SqlDataAdapter(str, VarCon.Connection)

        ADP.Fill(GLOBAL_VARIABLES.DS)
        For Each Row As DataRow In GLOBAL_VARIABLES.DS.Tables(0).Rows
            ctrl.Properties.Items.Add(Row(NDisplay))
        Next

        ctrl.EditValue = Nothing
        VarCon.CloseConnection()
    End Sub
    Public Function GetShapeID(ByVal ShapeName As String, ByVal dt As DataTable) As Integer
        Dim dr As DataRow() = dt.Select("shape_name in ('" & ShapeName & "')")
        If dr.Count = Nothing Then
        Else
            GetShapeID = dr(0).Item("shape_ID")
        End If
        Return GetShapeID
    End Function
    Public Function GetColorID(ByVal ColorName As String, ByVal dt As DataTable) As Integer
        Dim dr As DataRow() = dt.Select("color_name in ('" & ColorName & "')")
        If dr.Count = Nothing Then
        Else
            GetColorID = dr(0).Item("color_id")
        End If
        Return GetColorID
    End Function
    Public Function GetClarityID(ByVal ClarityName As String, ByVal dt As DataTable) As Integer
        Dim dr As DataRow() = dt.Select("clarity_name in ('" & ClarityName & "')")
        If dr.Count = Nothing Then
        Else
            GetClarityID = dr(0).Item("clarity_id")
        End If
        Return GetClarityID
    End Function
    Public Function GetFloID(ByVal FloName As String, ByVal dt As DataTable) As Integer
        Dim dr As DataRow() = dt.Select("flo_name in ('" & FloName & "')")
        If dr.Count = Nothing Then
        Else
            GetFloID = dr(0).Item("flo_id")
        End If
        Return GetFloID
    End Function
    Public Function GetCutID(ByVal Cut As String, ByVal dt As DataTable) As Integer
        Dim dr As DataRow() = dt.Select("cut_name in ('" & Cut & "')")
        If dr.Count = Nothing Then
        Else
            GetCutID = dr(0).Item("cut_id")
        End If
        Return GetCutID
    End Function
    Public Function GetPolishID(ByVal Polish As String, ByVal dt As DataTable) As Integer
        Dim dr As DataRow() = dt.Select("polish_name in ('" & Polish & "')")
        If dr.Count = Nothing Then
        Else
            GetPolishID = dr(0).Item("polish_id")
        End If
        Return GetPolishID
    End Function
    Public Function GetSymID(ByVal Symmetry As String, ByVal dt As DataTable) As Integer
        Dim dr As DataRow() = dt.Select("symm_name in ('" & Symmetry & "')")
        If dr.Count = Nothing Then
        Else
            GetSymID = dr(0).Item("symm_id")
        End If
        Return GetSymID
    End Function

    Public Function GetGirdleID(ByVal GirdleName As String, ByVal dt As DataTable) As Integer
        Dim dr As DataRow() = dt.Select("GirdleName in ('" & GirdleName & "')")
        If dr.Count = Nothing Then
        Else
            GetGirdleID = dr(0).Item("GirdleID")
        End If
        Return GetGirdleID
    End Function
    Public Function GetGirdleConditionID(ByVal GirdleConditionName As String, ByVal dt As DataTable) As Integer
        Dim dr As DataRow() = dt.Select("GirdleConditionName in ('" & GirdleConditionName & "')")
        If dr.Count = Nothing Then
        Else
            GetGirdleConditionID = dr(0).Item("GirdleConditionID")
        End If
        Return GetGirdleConditionID
    End Function
    Public Function GetCuletID(ByVal CuletName As String, ByVal dt As DataTable) As Integer
        Dim dr As DataRow() = dt.Select("CuletName in ('" & CuletName & "')")
        If dr.Count = Nothing Then
        Else
            GetCuletID = dr(0).Item("CuletID")
        End If
        Return GetCuletID
    End Function
    Public Function GetItemType(ByVal ItemTypeName As String, ByVal dt As DataTable) As Integer
        Dim dr As DataRow() = dt.Select("item_type_name in ('" & ItemTypeName & "')")
        If dr.Count = Nothing Then
        Else
            GetItemType = dr(0).Item("item_type_id")
        End If
        Return GetItemType
    End Function
    Public Function GetMainLot(ByVal MainLot As String, ByVal dt As DataTable) As Integer
        Dim dr As DataRow() = dt.Select("MainLotName in ('" & MainLot & "')")
        If dr.Count = Nothing Then
        Else
            GetMainLot = dr(0).Item("MainPacketID")
        End If
        Return GetMainLot
    End Function
    Public Function GetBarcode(ByVal StockID As String) As Integer
        GetBarcode = GENERAL_FUNCTIONS.NExcuteScalerInt("Select top(1) Barcode from Dia_MainStock where StockID='" & StockID & "' order by TransactionID desc")
        Return GetBarcode
    End Function
    Public Shared Function ExcelToDatatable(ByVal exceldatasource As ExcelDataSource) As DataTable
        Dim list As IList = (CType(exceldatasource, IListSource)).GetList()
        Dim dataview As DevExpress.DataAccess.Native.Excel.DataView = CType(list, DevExpress.DataAccess.Native.Excel.DataView)
        Dim props As List(Of DevExpress.DataAccess.Native.Excel.ViewColumn) = dataview.Columns
        Dim table As New DataTable()
        For i = 0 To props.Count - 1
            Dim prop As PropertyDescriptor = props(i)
            table.Columns.Add(prop.Name, prop.PropertyType)
        Next
        Dim values(props.Count - 1) As Object
        For Each item As DevExpress.DataAccess.Native.Excel.ViewRow In list
            For i = 0 To values.Length - 1
                values(i) = props(i).GetValue(item)
            Next i
            table.Rows.Add(values)
        Next item
        Return table

    End Function
    Public Shared Function GetSheetNameByIndex(ByVal p As Integer, ByVal filepath As String) As String
        Dim worksheetname As String = ""
        Using spreadsheetsource As DevExpress.SpreadsheetSource.ISpreadsheetSource = DevExpress.SpreadsheetSource.SpreadsheetSourceFactory.CreateSource(filepath)
            Dim worksheetcollection As DevExpress.SpreadsheetSource.IWorksheetCollection = spreadsheetsource.Worksheets
            worksheetname = worksheetcollection(p).Name
        End Using
        Return worksheetname
    End Function
    Public Shared Function GetExcelDataSouce() As ExcelDataSource
        Dim ds As New ExcelDataSource
        ds.FileName = filepath
        Dim excelsourceopt As New ExcelSourceOptions
        Dim worksheetSettings As New ExcelWorksheetSettings
        worksheetSettings.WorksheetName = GetSheetNameByIndex(0, filepath)
        excelsourceopt.SkipEmptyRows = True
        excelsourceopt.UseFirstRowAsHeader = True
        excelsourceopt.ImportSettings = worksheetSettings
        ds.SourceOptions = excelsourceopt
        ds.Fill()
        Return ds
    End Function
    Public Shared Function GetEmptyMainStockDatatable() As DataTable
        Dim cols As DataTable = GENERAL_FUNCTIONS.NFetchDatatable("select COLUMN_NAME from Information_Schema.columns where table_name='Dia_MainStock'")
        Dim dt As New DataTable
        For i = 0 To cols.Rows.Count - 1
            dt.Columns.Add(cols.Rows(i).Item(0).ToString)
        Next
        Return dt
    End Function
    Public Shared Sub SaveGridLayout(ByVal Diacmd As Integer, ByVal LayoutID As Integer, ByVal LayoutName As String, ByVal LayoutData As String, ByVal IsDefault As Boolean)
        Try

            Dim CMD As New SqlCommand
            CMD = New SqlCommand("SaveLayout", VarCon.Connection)
            CMD.CommandType = CommandType.StoredProcedure
            CMD.Parameters.AddWithValue("@CMD", Diacmd)
            CMD.Parameters.AddWithValue("@LayoutID", LayoutID)
            CMD.Parameters.AddWithValue("@UserID", GLOBAL_VARIABLES.UID)
            CMD.Parameters.AddWithValue("@LayoutName", LayoutName)
            CMD.Parameters.AddWithValue("@LayoutData", LayoutData)
            CMD.Parameters.AddWithValue("@IsDefault", IsDefault)
            If Diacmd = 3 Then
                Dim DT As New DataTable
                ADP = New SqlDataAdapter(CMD)
                ADP.Fill(DT)
                ' CTRL.DataSource = DT
            Else

                CMD.ExecuteNonQuery()
            End If
            VarCon.CloseConnection()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Public Shared Function GetLiveRate() As Double
        Dim res As Double
        ServicePointManager.Expect100Continue = True
        ServicePointManager.SecurityProtocol = CType(3072, SecurityProtocolType)
        Try
            Dim Result As String = (New WebClient).DownloadString("https://api.exchangerate-api.com/v4/latest/USD")

            Dim jObj = CType(JsonConvert.DeserializeObject(Result, New JsonSerializerSettings() With {
            .DateParseHandling = DateParseHandling.None
        }), JObject)

            If jObj.GetValue("rates").HasValues Then
                Dim rating = CStr(jObj("rates")("INR"))
                res = rating
            Else
                MsgBox("something wen't wrong !!!")
            End If
        Catch ex As Exception
            MsgBox("something wen't wrong !!!")
        End Try

        Return res
    End Function
    Public Shared Function GetCustomLedgerDataTable(ByVal LedgerTypes As String())
        Dim dt As New DataTable
        Dim queryadd As String = ""
        Dim Query As String = "SELECT LedgerID=0,LedgerName='' UNION SELECT LedgerID,LedgerName FROM Dia_Ledger_Master WHERE LUnderGroup=(SELECT group_id FROM Dia_Group_Master WHERE group_name=" & queryadd
        For i = 0 To LedgerTypes.Length - 1
            If queryadd = "" Then
                queryadd = " '" & LedgerTypes(i) & "' "
            Else
                queryadd = queryadd + " or group_name= '" & LedgerTypes(i) & "' "
            End If
        Next
        Query = Query + queryadd & ") order by LedgerName"

        Dim dtp As New DataSet
        ADP = New SqlDataAdapter(Query, VarCon.Connection)
        ADP.Fill(dtp)
        dt = dtp.Tables(0)
        VarCon.CloseConnection()
        Return dt
    End Function
    Public Shared Function FetchDataTableFromStoredProcedure(ByVal Procedure As String) As DataTable
        Dim x As New DataTable
        Try
            Dim CMD As New SqlCommand
            CMD = New SqlCommand(Procedure, VarCon.Connection)
            CMD.CommandType = CommandType.StoredProcedure
            Using ADP = New SqlDataAdapter(CMD)
                ADP.Fill(x)
            End Using
            VarCon.CloseConnection()
        Catch ex As Exception
            ErrorMsg(ex.Message)
        End Try
        Return x
    End Function
    Public Shared Function SelectStockDataTable(ByVal Diacmd As String, ByVal Barcode As Integer) As DataTable
        Dim tmpdt As New DataTable
        Try
            Dim CMD As New SqlCommand
            CMD = New SqlCommand("SelectStock", VarCon.Connection)
            CMD.CommandType = CommandType.StoredProcedure
            CMD.Parameters.AddWithValue("@CMD", Diacmd)
            CMD.Parameters.AddWithValue("@Barcode", Barcode)

            If Diacmd = "SelectLotHistory" Then
                Using ADP = New SqlDataAdapter(CMD)
                    ADP.Fill(tmpdt)
                End Using
            End If
            VarCon.CloseConnection()
        Catch ex As Exception
            ErrorMsg(ex.Message)
        End Try
        Return tmpdt
    End Function
    Public Shared Function SelectMainStockDataTable() As DataTable
        Dim tmpdt As New DataTable
        Try
            Dim CMD As New SqlCommand
            CMD = New SqlCommand("SelectStock", VarCon.Connection)
            CMD.CommandType = CommandType.StoredProcedure
            CMD.CommandTimeout = 0
            CMD.Parameters.AddWithValue("@CMD", "SelectMainStock")
            ADP = New SqlDataAdapter(CMD)
            ADP.Fill(tmpdt)
        Catch ex As Exception
            ErrorMsg(ex.Message)
        Finally
            VarCon.CloseConnection()
        End Try
        Return tmpdt
    End Function
    Public Shared Function SelectDetailRow() As DataTable
        Dim tmpdt As New DataTable
        Try
            Dim CMD As New SqlCommand
            CMD = New SqlCommand("SelectStock", VarCon.Connection)
            CMD.CommandType = CommandType.StoredProcedure
            CMD.Parameters.AddWithValue("@CMD", "DetailRow")
            Using ADP = New SqlDataAdapter(CMD)
                ADP.Fill(tmpdt)
            End Using
            VarCon.CloseConnection()
        Catch ex As Exception
            ErrorMsg(ex.Message)
        End Try
        Return tmpdt
    End Function
    Public Shared Sub ExportGrid(ByVal GridView As DevExpress.XtraGrid.Views.Grid.GridView)
        Dim filename As String
        Dim SaveFileDialog As New SaveFileDialog()
        SaveFileDialog.Filter = "xlsx files (*.xlsx)|*.xlsx"
        SaveFileDialog.FilterIndex = 2
        SaveFileDialog.FileName = "GemAccounts Export"
        SaveFileDialog.RestoreDirectory = True
        If SaveFileDialog.ShowDialog() = DialogResult.OK Then
            ''This is required so that excel doesn't make all the grids very small. This will export all grids space out evenly  
            GridView.OptionsPrint.AutoWidth = False

            'Set the selected file as the filename  
            filename = SaveFileDialog.FileName

            'Export the file via inbuild function  
            Dim op As New XlsxExportOptionsEx()
            op.ExportType = ExportType.WYSIWYG
            GridView.ExportToXlsx(filename, op)

            'If the file exists (i.e. export worked), then open it  
            If File.Exists(filename) Then
                Dim DialogResult As DialogResult = XtraMessageBox.Show("File has been exported to " & filename & vbNewLine & "Did you want to open the file now?", "Export...", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If DialogResult = DialogResult.Yes Then
                    Process.Start(filename)
                End If
            End If
        End If
    End Sub
    Public Shared Sub FreezeUnfreezeColumnLeft(ByVal sender As Object, ByVal e As EventArgs)
        Dim item As DXMenuCheckItem = sender
        Dim info As GridColumn = CType(item.Tag, GridColumn)
        If info Is Nothing Then Return
        If info.Fixed = FixedStyle.Left Then
            info.Fixed = FixedStyle.None
        Else
            info.Fixed = FixedStyle.Left
        End If
    End Sub

    Public Shared Sub FreezeUnfreezeColumnRight(ByVal sender As Object, ByVal e As EventArgs)
        Dim item As DXMenuCheckItem = sender
        Dim info As GridColumn = CType(item.Tag, GridColumn)
        If info Is Nothing Then Return
        If info.Fixed = FixedStyle.Right Then
            info.Fixed = FixedStyle.None
        Else
            info.Fixed = FixedStyle.Right
        End If
    End Sub
    Public Shared Sub GridContextMenu(sender As Object, e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs)

        If e.MenuType = GridMenuType.Column Then
            Dim menu As GridViewColumnMenu = e.Menu

            If Not menu.Column Is Nothing Then
                Dim myMenu As New DXMenuCheckItem("Freeze/un-freeze column on left", (menu.Column.Fixed = FixedStyle.Left), Nothing, New EventHandler(AddressOf FreezeUnfreezeColumnLeft))
                ' myMenu.Image = My.Resources._16table_column_before ' use your own icon here  
                myMenu.BeginGroup = True
                myMenu.Enabled = True
                myMenu.Tag = menu.Column
                e.Menu.Items.Add(myMenu)


                Dim myMenu2 As New DXMenuCheckItem("Freeze/un-freeze column on right", (menu.Column.Fixed = FixedStyle.Right), Nothing, New EventHandler(AddressOf FreezeUnfreezeColumnRight))
                ' myMenu2.Image = My.Resources._16table_column_after ' use your own icon here  
                myMenu2.BeginGroup = False
                myMenu2.Enabled = True
                myMenu2.Tag = menu.Column
                e.Menu.Items.Add(myMenu2)
            End If
        End If
    End Sub
    Public Shared Function QuestionMsg(msg As String) As Boolean
        If XtraMessageBox.Show(msg, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            QuestionMsg = True
        Else
            QuestionMsg = False
        End If
        Return QuestionMsg
    End Function
    Public Shared Function ValidateUrl(url As String) As Boolean
        Dim validatedUri As Uri = Nothing
        If (Uri.TryCreate(url, UriKind.Absolute, validatedUri)) Then
            Return (validatedUri.Scheme = Uri.UriSchemeHttp Or validatedUri.Scheme = Uri.UriSchemeHttps)
        End If
        Return False
    End Function
    Public Shared Function GetMaxFileNumber() As Integer
        If Not Directory.Exists(GLOBAL_VARIABLES.AttachmentPath) Then
            Directory.CreateDirectory(GLOBAL_VARIABLES.AttachmentPath)
        End If
        GetMaxFileNumber = Directory.GetFiles(GLOBAL_VARIABLES.AttachmentPath, "*.*", SearchOption.AllDirectories).Length + 1
        Return GetMaxFileNumber
    End Function
    Public Shared Function GetFullPath_of_PDF() As String
        Dim OFD As New System.Windows.Forms.OpenFileDialog
        Dim filepath As String
        Try
            OFD.Filter = "PDF | *.pdf"
            If OFD.ShowDialog = DialogResult.OK Then
                filepath = OFD.FileName
            Else
                filepath = Nothing
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            filepath = Nothing
        End Try
        Return filepath
    End Function
    Public Shared Sub CopY_PDF_to_Server(ByVal path As String, ByVal Prefix As String, ByVal ID As Integer)
        'GLOBAL_VARIABLES.Filename = prefix & "-" & DevFunctions.GetMaxFileNumber() & ".pdf"
        If path Is Nothing Or path = String.Empty Then
            GLOBAL_VARIABLES.Filename = ""
        Else
            GLOBAL_VARIABLES.Filename = Prefix & "-" & ID & ".pdf"
            Try
                If Not Directory.Exists(GLOBAL_VARIABLES.AttachmentPath) Then
                    Directory.CreateDirectory(GLOBAL_VARIABLES.AttachmentPath)
                End If
                If GLOBAL_VARIABLES.TmpFileName = path Then
                Else
                    If System.IO.File.Exists(GLOBAL_VARIABLES.AttachmentPath & Prefix & "-" & ID & ".pdf") = True Then
                        System.IO.File.Delete(GLOBAL_VARIABLES.AttachmentPath & Prefix & "-" & ID & ".pdf")
                    End If
                End If
                File.Copy(path, GLOBAL_VARIABLES.AttachmentPath & Prefix & "-" & ID & ".pdf")
            Catch ex As Exception

            End Try
        End If
    End Sub
End Class


