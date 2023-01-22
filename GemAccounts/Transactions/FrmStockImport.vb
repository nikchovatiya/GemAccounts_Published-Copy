Imports System.Data.SqlClient
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraReports.UserDesigner
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraVerticalGrid
Imports GemAccounts.GLOBAL_VARIABLES

Public Class FrmStockImport
    Dim GF As New GENERAL_FUNCTIONS
    Dim DF As New DevFunctions
    Dim BL As New BAL_Transactions
    Dim EditFlag As Integer
    Dim barcode As Integer
    Dim TransactionID As Integer
    Dim UnionID As Integer
    Dim devE As DevExpress.XtraBars.ItemClickEventArgs
    Private Sub FrmStockImport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btncancel_itemclick(sender, devE)
        LoadCombo()

        Dim Lstbox As CheckedListBoxControl = New CheckedListBoxControl
        For Each col As GridColumn In dgview.Columns
            Lstbox.Items.Add(col.FieldName, col.Caption, CheckState.Checked, True)
        Next col
        DP1.ControlContainer.Controls.Add(Lstbox)
        Lstbox.Dock = DockStyle.Fill
        Lstbox.CheckOnClick = True


        'Dim propertyGridControl1 As PropertyGridControl = New PropertyGridControl()

        'Dim propertyDescriptionControl1 As PropertyDescriptionControl = New PropertyDescriptionControl()

        'propertyGridControl1.Parent = panelControl1
        'propertyGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        'propertyGridControl1.SelectedObject = dgview.Columns.View.VisibleColumns
        'propertyDescriptionControl1.Parent = panelControl1
        'propertyDescriptionControl1.AutoHeight = True
        'propertyDescriptionControl1.Dock = DockStyle.Bottom
        'propertyDescriptionControl1.PropertyGrid = propertyGridControl1

    End Sub

    Private Sub SearchLookUpEdit1_EditValueChanged(sender As Object, e As EventArgs) Handles cmbMainLotName.EditValueChanged
        cmbMainLotName.Properties.DisplayMember = "MainLotName"
        cmbMainLotName.Properties.ValueMember = "MainPacketID"
    End Sub

    Private Sub dtp_KeyDown(sender As Object, e As KeyEventArgs) Handles dtp.KeyDown, cmbItemType.KeyDown, cmbMainLotName.KeyDown, txtStockID.KeyDown, txtQty.KeyDown, txtCarats.KeyDown, txtLabourINR.KeyDown, cmbshape.KeyDown, cmbcolor.KeyDown, cmbclarity.KeyDown, txtrap.KeyDown, cmbflour.KeyDown, cmbcut.KeyDown, cmbpolish.KeyDown, cmbsymm.KeyDown, txtcomment.KeyDown, txtvideolink.KeyDown, txtimagelink.KeyDown
        GENERAL_FUNCTIONS.FocusNext(sender, e)
    End Sub
    Private Sub LoadCombo()
        DevFunctions.NFetchSearchLookupEdit("SELECT M.MainPacketID,M.MainLotName,M.Pcs,M.Carats,S.SerieName FROM Dia_Main_Packet_Master M, Dia_Serie S where S.SerieID=M.SerieID", cmbMainLotName)
        GF.FillItemTypeCombo(cmbItemType)
        GF.FillShapeCombo(cmbshape)
        GF.FillColorCombo(cmbcolor)
        GF.FillClarityCombo(cmbclarity)
        GF.FillCutCombo(cmbcut)
        GF.FillpolishCombo(cmbpolish)
        GF.FillSymmCombo(cmbsymm)
        GF.FillFlourCombo(cmbflour)
    End Sub

    Private Sub txtCarats_TextChanged(sender As Object, e As EventArgs) Handles txtCarats.TextChanged, cmbshape.TextChanged, cmbcolor.TextChanged, cmbclarity.TextChanged
        If Len(Trim(txtCarats.Text)) = 0 Then
            txtrap.Text = "0"
            Exit Sub
        End If
        If cmbshape.SelectedValue = 0 Then
            txtrap.Text = "0"
            Exit Sub
        End If
        If cmbcolor.SelectedValue = 0 Then
            txtrap.Text = "0"
            Exit Sub
        End If
        If cmbclarity.SelectedValue = 0 Then
            txtrap.Text = "0"
            Exit Sub
        End If
        txtrap.Text = DevFunctions.GetRAP(cmbshape.SelectedValue, cmbcolor.SelectedValue, cmbclarity.SelectedValue, Val(txtCarats.Text))
    End Sub

    Private Function validation() As Boolean
        If Len(Trim(txtLabourINR.Text)) = 0 Then
            txtLabourINR.Text = 0
        End If
        If cmbItemType.SelectedValue = 0 Then
            DevFunctions.ErrorMsg("Please select Item Type")
            cmbItemType.Focus()
            validation = False
            Exit Function
        ElseIf cmbMainLotName.EditValue = Nothing Then
            DevFunctions.ErrorMsg("Please select Main Lot")
            cmbMainLotName.Focus()
            validation = False
            Exit Function
        ElseIf cmbshape.SelectedValue = 0 Then
            DevFunctions.ErrorMsg("Please select Shape")
            cmbshape.Focus()
            validation = False
            Exit Function
        ElseIf cmbcolor.SelectedValue = 0 Then
            DevFunctions.ErrorMsg("Please select Color")
            cmbcolor.Focus()
            validation = False
            Exit Function
        ElseIf cmbclarity.SelectedValue = 0 Then
            DevFunctions.ErrorMsg("Please select Clarity")
            cmbclarity.Focus()
            validation = False
            Exit Function
        ElseIf len(trim(txtStockID.text)) = 0 Then
            DevFunctions.ErrorMsg("Please Enter StockID")
            txtStockID.Focus()
            validation = False
            Exit Function
        ElseIf len(trim(txtQty.text)) = 0 Then
            DevFunctions.ErrorMsg("Please Enter Qty")
            txtQty.Focus()
            validation = False
            Exit Function
        ElseIf len(trim(txtCarats.text)) = 0 Then
            DevFunctions.ErrorMsg("Please Enter Carats")
            txtCarats.Focus()
            validation = False
            Exit Function
        ElseIf len(trim(txtLabourINR.text)) = 0 Then
            txtLabourINR.Text = 0
        End If
        If EditFlag = 1 Then

        Else
            Dim DupRecord As Integer = GENERAL_FUNCTIONS.NExcuteScalerInt("SELECT COUNT(STOCKID) FROM DIA_MAINSTOCK WHERE STOCKID='" & txtStockID.Text & "'")
            If DupRecord > 0 Then
                DevFunctions.ErrorMsg("StockID already added.")
                validation = False
                Exit Function
            End If
        End If
        validation = True
        Return validation
    End Function
    Private Sub dg_DoubleClick(sender As Object, e As EventArgs) Handles dg.DoubleClick
        If XtraMessageBox.Show("Do you want to update Lot?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            EditFlag = 1
            TransactionID = TryCast(dg.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("TransactionID")
            barcode = TryCast(dg.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("Barcode")
            dtp.Value = TryCast(dg.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("ImportDate")
            cmbItemType.SelectedValue = TryCast(dg.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("ItemTypeID")
            txtStockID.Text = TryCast(dg.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("StockID")
            txtQty.Text = TryCast(dg.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("Qty")
            txtCarats.Text = TryCast(dg.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("Carats")
            txtLabourINR.Text = TryCast(dg.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("LabourINR")
            cmbshape.SelectedValue = TryCast(dg.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("ShapeID")
            cmbcolor.SelectedValue = TryCast(dg.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("ColorID")
            cmbclarity.SelectedValue = TryCast(dg.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("ClarityID")
            txtrap.Text = TryCast(dg.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("RAP")
            cmbflour.SelectedValue = TryCast(dg.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("FloID")
            cmbcut.SelectedValue = TryCast(dg.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("CutID")
            cmbpolish.SelectedValue = TryCast(dg.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("PolishID")
            cmbsymm.SelectedValue = TryCast(dg.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("SymID")
            txtcomment.Text = TryCast(dg.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("Comment")
            txtvideolink.Text = TryCast(dg.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("VideoLink")
            txtimagelink.Text = TryCast(dg.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("ImageLink")
            cmbMainLotName.EditValue = TryCast(dg.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("MainLotID")

        End If
    End Sub

    Public Sub setform(ByVal ctrl As Form)
        Dim child As Form = Nothing
        For Each child In MdiChildren
            child = ctrl
        Next
        If child Is Nothing Then
            child = ctrl
            child.MdiParent = Me.MdiParent
            SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
            Try
                child.Show()
            Finally
                SplashScreenManager.CloseForm(False)
            End Try
            'child.Show()
        Else
            child = ctrl
            child.MdiParent = Me.MdiParent
            SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
            Try
                child.Show()
            Finally
                SplashScreenManager.CloseForm(False)
            End Try
            'child.Show()
            child.Activate()
        End If
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, devE As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSave.ItemClick

        If validation() = False Then
            Exit Sub
        End If
        Dim LotStatus As Integer = GENERAL_FUNCTIONS.NExcuteScaler("select lot_status_id from Dia_Lot_Status_Master WHERE ((',' + lot_status_name + ',') LIKE '%,'+ 'Available' +',%') or ((',' + lot_status_name + ',') LIKE '%,' + 'Available' +',%') ")
        If EditFlag = 0 Then
            UnionID = GENERAL_FUNCTIONS.MaxNo("select max(UnionID) from Dia_MainStock")
            barcode = GENERAL_FUNCTIONS.MaxNo("select max(barcode) from Dia_MainStock")
            BL.MainStockCRUD(dg, 0, 0, barcode, CID, BID, UID, dtp.Value, cmbItemType.SelectedValue, cmbMainLotName.EditValue, txtStockID.Text, txtQty.Text, txtCarats.Text, txtLabourINR.Text, cmbshape.SelectedValue, cmbcolor.SelectedValue, cmbclarity.SelectedValue, DevFunctions.GetRAP(cmbshape.SelectedValue, cmbcolor.SelectedValue, cmbclarity.SelectedValue, txtCarats.Text), cmbflour.SelectedValue, cmbcut.SelectedValue, cmbpolish.SelectedValue, cmbsymm.SelectedValue, txtcomment.Text, LotStatus, txtimagelink.Text, txtvideolink.Text, "Stock Import", UnionID)
            XtraMessageBox.Show("Lot has been Saved.", "Mauni Diamond", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            BL.MainStockCRUD(dg, 1, TransactionID, barcode, CID, BID, UID, dtp.Value, cmbItemType.SelectedValue, cmbMainLotName.EditValue, txtStockID.Text, txtQty.Text, txtCarats.Text, txtLabourINR.Text, cmbshape.SelectedValue, cmbcolor.SelectedValue, cmbclarity.SelectedValue, txtrap.Text, cmbflour.SelectedValue, cmbcut.SelectedValue, cmbpolish.SelectedValue, cmbsymm.SelectedValue, txtcomment.Text, LotStatus, txtimagelink.Text, txtvideolink.Text, "Stock Import", UnionID)

            XtraMessageBox.Show("Lot has been updated.", "Mauni Diamond", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        btncancel_itemclick(sender, devE)
    End Sub

    Private Sub btncancel_itemclick(sender As Object, devE As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCancel.ItemClick
        EditFlag = 0
        barcode = 0
        txtStockID.Text = ""
        txtQty.Text = ""
        txtCarats.Text = ""
        txtLabourINR.Text = ""
        txtcomment.Text = ""
        txtvideolink.Text = ""
        txtimagelink.Text = ""
        dtp.Focus()
        cmbMainLotName.EditValue = Nothing
        cmbItemType.SelectedValue = 0
        cmbshape.SelectedValue = 0
        cmbcolor.SelectedValue = 0
        cmbclarity.SelectedValue = 0
        cmbflour.SelectedValue = 0
        cmbcut.SelectedValue = 0
        cmbpolish.SelectedValue = 0
        cmbsymm.SelectedValue = 0
        BL.MainStockCRUD(dg, 3, 0, 0, 0, 0, 0, dtp.Value, 0, 0, "", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "", 0, "", "", "", 0)
    End Sub

    Private Sub BarButtonItem3_ItemClick(sender As Object, devE As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPrint.ItemClick
        Dim ds As DataSet = New TmpData
        Dim dt As DataTable = ds.Tables("TblBarcode")
        Dim dr As DataRow
        Dim srh As Integer() = dgview.GetSelectedRows()
        For i = 0 To srh.Length - 1
            dr = dt.NewRow
            dr("Stockid") = dgview.GetRowCellValue(srh(i), "StockID")
            dr("Barcode") = dgview.GetRowCellValue(srh(i), "Barcode")
            dr("Qty") = dgview.GetRowCellValue(srh(i), "Qty")
            dr("Carats") = dgview.GetRowCellValue(srh(i), "Carats")
            dr("Shape") = dgview.GetRowCellValue(srh(i), "Shape")
            dr("Color") = dgview.GetRowCellValue(srh(i), "Color")
            dr("Clarity") = dgview.GetRowCellValue(srh(i), "Clarity")
            dr("ImportDate") = dgview.GetRowCellValue(srh(i), "ImportDate")
            dt.Rows.Add(dr)
        Next
        Dim report = New RptBarcode
        report.DataSource = ds
        PrintReport.Dviewer.DocumentSource = report
        report.CreateDocument()
        FrmMain.MainMenu.MdiMergeStyle = RibbonMdiMergeStyle.Always
        setform(PrintReport)
    End Sub

    Private Sub btnReftesh_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnReftesh.ItemClick
        LoadCombo()
    End Sub
End Class