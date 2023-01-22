Imports DevExpress.XtraSplashScreen

Public Class FrmClipboard
    Dim clipboardDT As New DataTable
    Public Shared dt As New DataTable
    Dim dupdt As New DataTable
    Dim DR As DataRow
    Dim clname As String
    Public Shared LayoutID As Integer = GLOBAL_VARIABLES.StockLayoutID
    Private Sub FrmClipboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        clipboardDT.Rows.Clear()
        clipboardDT.Columns.Clear()
        dt.Rows.Clear()
        dt.Columns.Clear()
        dupdt.Rows.Clear()
        dupdt.Columns.Clear()

        clipboardDT.Columns.Add("TransactionID")
        dt.Columns.Add("TransactionID", GetType(Integer))
        dt.Columns.Add("Barcode", GetType(Integer))
        dt.Columns.Add("StockID")
        dt.Columns.Add("Status")
        dt.Columns.Add("Qty")
        dt.Columns.Add("Carats")
        dt.Columns.Add("Shape")
        dt.Columns.Add("Color")
        dt.Columns.Add("Clarity")
        dt.Columns.Add("Flo")
        dt.Columns.Add("Lab")
        dt.Columns.Add("ReportNo")
        DevFunctions.NFillComboDev("Select LayoutName from Dia_Layouts order by LayoutName", "LayoutName", cmbTemplate)
        cmbTemplate.EditValue = GENERAL_FUNCTIONS.NExcuteScaler("SELECT LayoutName from Dia_Layouts where LayoutID=" & LayoutID)
        txtStockID.Focus()
    End Sub

    Private Sub txtBarcode_GotFocus(sender As Object, e As EventArgs) Handles txtBarcode.GotFocus
        clname = "Barcode"
    End Sub

    Private Sub txtStockID_GotFocus(sender As Object, e As EventArgs) Handles txtStockID.GotFocus
        clname = "StockID"
    End Sub

    Private Sub txtReportNo_GotFocus(sender As Object, e As EventArgs)
        clname = "LCertificateNo"
    End Sub
    Private Property ClipboardData As String
        Get
            Dim iData As IDataObject = Clipboard.GetDataObject()
            If iData Is Nothing Then Return ""
            If iData.GetDataPresent(DataFormats.Text) Then Return CStr(iData.GetData(DataFormats.Text))
            Return ""
        End Get
        Set(ByVal value As String)
            Clipboard.SetDataObject(value)
        End Set
    End Property
    Private Sub AddRow(ByVal data As String)
        If data = String.Empty Then Return
        Dim rowData As String() = data.Split(New Char() {vbCr, vbTab})
        Dim newRow As DataRow = clipboardDT.NewRow()

        For i As Integer = 0 To rowData.Length - 1
            If i >= clipboardDT.Columns.Count Then Exit For
            newRow(i) = rowData(i)
        Next
        clipboardDT.Rows.Add(newRow)
        dupdt = clipboardDT.DefaultView.ToTable(True)
    End Sub

    Private Sub btnLoadExternal_Click(sender As Object, e As EventArgs) Handles btnLoadExternal.Click
        dt.Rows.Clear()
        clipboardDT.Rows.Clear()
        dupdt.Rows.Clear()
        Dim data As String() = ClipboardData.Split(vbLf)
        If data.Length < 1 Then Return

        For Each row As String In data
            AddRow(row)
        Next
        Dim msg As String = ""

        For i = 0 To dupdt.Rows.Count - 1
            If clname = "Barcode" And Integer.TryParse(dupdt.Rows(i).Item(0).ToString, 0) = False Then
                msg = msg & dupdt.Rows(i).Item(0).ToString & " ----- is not loaded" & vbCrLf
            Else
                DR = GENERAL_FUNCTIONS.NFetchDataRow("SELECT TOP(1) M.TransactionID AS TransactionID,
M.Barcode AS Barcode,
M.StockID AS StockID,
STATUS.lot_status_name AS Status,
M.Qty as Qty,
M.Carats as Carats,
S.Shape_Name AS Shape,
C.color_name as Color,
CL.clarity_name as Clarity,
F.flo_name as Flo,
L.lab_name as Lab,
M.LCertificateNo as ReportNo

FROM DIA_MAINSTOCK M
LEFT JOIN Dia_Lot_Status_Master STATUS ON STATUS.lot_status_id=M.StatusID
LEFT JOIN Dia_Shape_Master S ON S.Shape_ID=M.ShapeID
LEFT JOIN Dia_Color_Master C ON C.color_id=M.ColorID
LEFT JOIN Dia_Clarity_Master CL ON CL.clarity_id=M.ClarityID
LEFT JOIN Dia_Flo_Master F ON F.flo_id=M.FloID
LEFT JOIN DIa_Lab_Master L ON L.lab_id=M.LabID where " & clname & "='" & dupdt.Rows(i).Item(0).ToString & "' ORDER BY TRANSACTIONID DESC")
                If DR Is Nothing Then
                    msg = msg & dupdt.Rows(i).Item(0).ToString & " ----- is not loaded" & vbCrLf
                Else
                    dt.Rows.Add(DR.ItemArray)
                End If
            End If

        Next
        If msg = String.Empty Then
            DevFunctions.InfoMsg("All Items Loaded Successfully Without Error")
        Else
            DevFunctions.ErrorMsg(msg)
        End If
        dg.DataSource = dt
    End Sub

    Private Sub cmbTemplate_EditValueChanged(sender As Object, e As EventArgs) Handles cmbTemplate.EditValueChanged
        If cmbTemplate.EditValue = "" Or cmbTemplate.EditValue = Nothing Then
            LayoutID = Nothing
            Return
        Else
            LayoutID = GENERAL_FUNCTIONS.NExcuteScalerInt("SELECT LayoutID from Dia_Layouts where LayoutName='" & cmbTemplate.EditValue & "'")
        End If
    End Sub

    Private Sub btnShowLots_Click(sender As Object, e As EventArgs) Handles btnShowLots.Click
        GLOBAL_VARIABLES.ClipboardFlag = False
        If cmbTemplate.EditValue = "" Or cmbTemplate.EditValue = Nothing Then
            LayoutID = Nothing
            Return
        Else
            GLOBAL_VARIABLES.FilterString = Nothing
            For i = 0 To dt.Rows.Count - 1
                If GLOBAL_VARIABLES.FilterString = Nothing Then
                    GLOBAL_VARIABLES.FilterString = "[Barcode] = " & dt.Rows(i).Item("Barcode")
                Else
                    GLOBAL_VARIABLES.FilterString = GLOBAL_VARIABLES.FilterString + " or [Barcode] = " & dt.Rows(i).Item("Barcode")
                End If
            Next
            'GLOBAL_VARIABLES.FilterString = "[Barcode] = 1111 or [Barcode] = 1112"
            GLOBAL_VARIABLES.ClipboardFlag = True
            setform(FrmStock)

        End If
    End Sub
    Private Sub setform(ByVal ctrl As Form)
        Dim child As Form = Nothing
        For Each child In MdiChildren
            child = ctrl
        Next
        If child Is Nothing Then
            child = ctrl
            child.MdiParent = Me.MdiParent
            Try
                SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
                child.Show()
            Catch ex As Exception
                DevFunctions.ErrorMsg(ex.Message)
            Finally
                SplashScreenManager.CloseForm(False)
            End Try
            'child.Show()

        Else
            child = ctrl
            child.MdiParent = Me.MdiParent
            Try
                SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
                child.Show()
            Catch ex As Exception
                DevFunctions.ErrorMsg(ex.Message)
            Finally
                SplashScreenManager.CloseForm(False)
            End Try
            'child.Show()
            child.Activate()
        End If
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        LoadSingleLot()
    End Sub
    Private Sub LoadSingleLot()
        Dim msg As String = ""
        Dim val As String = ""
        If clname = "Barcode" Then
            If Integer.TryParse(txtBarcode.EditValue, 0) = False Then
                val = 0
            Else
                val = txtBarcode.EditValue
            End If
        ElseIf clname = "StockID" Then
            val = txtStockID.EditValue
        ElseIf clname = "LCertificateNo" Then
            val = txtReportNo.EditValue
        End If

        DR = GENERAL_FUNCTIONS.NFetchDataRow("SELECT TOP(1) M.TransactionID AS TransactionID,
M.Barcode AS Barcode,
M.StockID AS StockID,
STATUS.lot_status_name AS Status,
M.Qty as Qty,
M.Carats as Carats,
S.Shape_Name AS Shape,
C.color_name as Color,
CL.clarity_name as Clarity,
F.flo_name as Flo,
L.lab_name as Lab,
M.LCertificateNo as ReportNo

FROM DIA_MAINSTOCK M
LEFT JOIN Dia_Lot_Status_Master STATUS ON STATUS.lot_status_id=M.StatusID
LEFT JOIN Dia_Shape_Master S ON S.Shape_ID=M.ShapeID
LEFT JOIN Dia_Color_Master C ON C.color_id=M.ColorID
LEFT JOIN Dia_Clarity_Master CL ON CL.clarity_id=M.ClarityID
LEFT JOIN Dia_Flo_Master F ON F.flo_id=M.FloID
LEFT JOIN DIa_Lab_Master L ON L.lab_id=M.LabID where " & clname & "='" & val & "' ORDER BY TRANSACTIONID DESC")
        If DR Is Nothing Then
            DevFunctions.ErrorMsg(val & " ----- is not loaded")
        Else
            dt.Rows.Add(DR.ItemArray)
        End If

        dg.DataSource = dt
        If clname = "Barcode" Then
            txtBarcode.EditValue = Nothing
            txtBarcode.Focus()
        ElseIf clname = "StockID" Then
            txtStockID.EditValue = Nothing
            txtStockID.Focus()
        ElseIf clname = "LCertificateNo" Then
            txtReportNo.EditValue = Nothing
            txtReportNo.Focus()
        End If

    End Sub

    Private Sub txtBarcode_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBarcode.KeyDown, txtStockID.KeyDown, txtReportNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            LoadSingleLot()
        Else
            Return
        End If
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        RemoveSingleRow()
    End Sub
    Private Sub RemoveSingleRow()
        Dim dr As DataRow
        dr = dgview.GetDataRow(dgview.FocusedRowHandle)
        If dr Is Nothing Then Return
        dt.Rows.Remove(dr)
        dg.DataSource = dt
    End Sub

    Private Sub dgview_KeyDown(sender As Object, e As KeyEventArgs) Handles dgview.KeyDown
        If e.KeyCode = Keys.Enter Then
            RemoveSingleRow()
        Else
            Return
        End If
    End Sub

    Private Sub btnRemoveAll_Click(sender As Object, e As EventArgs) Handles btnRemoveAll.Click
        dt.Rows.Clear()
        clipboardDT.Rows.Clear()
        dupdt.Rows.Clear()
        dg.DataSource = Nothing
    End Sub
End Class