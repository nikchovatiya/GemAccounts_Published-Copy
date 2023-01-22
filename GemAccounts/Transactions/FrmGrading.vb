Imports System.Data.SqlClient
Imports DevExpress.XtraBars.Docking
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports GemAccounts.GLOBAL_VARIABLES

Public Class FrmGrading
    Dim GF As New GENERAL_FUNCTIONS
    Dim GV As GLOBAL_VARIABLES
    Dim DF As New DevFunctions
    Dim BL As New BAL_Transactions
    Dim dt As DataTable
    Dim dr As DataRow
    Dim devE As DevExpress.XtraBars.ItemClickEventArgs
    Dim EditFlag As Integer
    Dim GradingID As Integer = 0


    Private Sub FrmGrading_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadcombo()
        btnCancel_ItemClick(sender, devE)
    End Sub
    Private Sub loadcombo()
        GF.FillGraderCombo(cmbGrader)
        GF.FillLabCombo(cmbLab)
        GF.FillShapeCombo(cmbshape)
        GF.FillColorCombo(cmbcolor)
        GF.FillClarityCombo(cmbclarity)
        GF.FillFlourCombo(cmbflour)
        GF.FillCutCombo(cmbCut)
        GF.FillpolishCombo(cmbPolish)
        GF.FillSymmCombo(cmbSymm)
    End Sub

    Private Sub dtp_KeyDown(sender As Object, e As KeyEventArgs) Handles dtp.KeyDown, cmbGrader.KeyDown, cmbLab.KeyDown, txtQty.KeyDown, cmbshape.KeyDown, cmbcolor.KeyDown, cmbclarity.KeyDown, cmbflour.KeyDown, cmbCut.KeyDown, cmbPolish.KeyDown, cmbSymm.KeyDown, txtBlack.KeyDown, txtTablePercent.KeyDown, txtDepthPercent.KeyDown, txtLength.KeyDown, txtWidth.KeyDown, txtDepth.KeyDown, txtCrHeight.KeyDown, txtCrAngle.KeyDown, txtPvAngle.KeyDown, txtPvDepth.KeyDown, txtWhite.KeyDown, chckbarcode.KeyDown
        GENERAL_FUNCTIONS.FocusNext(sender, e)
    End Sub

    Private Sub chckbarcode_CheckedChanged(sender As Object, e As EventArgs) Handles chckbarcode.CheckedChanged
        If chckbarcode.CheckState = CheckState.Checked Then
            txtStockID.Enabled = False
            txtBarcode.Enabled = True
        Else
            txtBarcode.Enabled = False
            txtStockID.Enabled = True
        End If
    End Sub

    Private Sub txtBarcode_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles txtBarcode.PreviewKeyDown
        If e.KeyCode = Keys.Tab Or e.KeyCode = Keys.Enter Then
            Dim dt As DataTable
            dt = GENERAL_FUNCTIONS.NFetchDatatable("select Barcode,StockID,Qty,Carats,ShapeID,ColorID,ClarityID,FloID,CutID,PolishID,SymID from Dia_MainStock Where Barcode='" & txtBarcode.Text & "'")
            If dt.Rows.Count = 0 Then
                XtraMessageBox.Show("Barcode Wrong", "Mauni Diamond", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtBarcode.Focus()
                Exit Sub
            Else
                txtStockID.Text = dt.Rows(0).Item("StockID")
                txtQty.Text = dt.Rows(0).Item("Qty")
                txtCarats.EditValue = dt.Rows(0).Item("Carats")
                cmbshape.SelectedValue = dt.Rows(0).Item("ShapeID")
                cmbcolor.SelectedValue = dt.Rows(0).Item("ColorID")
                cmbclarity.SelectedValue = dt.Rows(0).Item("ClarityID")
                cmbflour.SelectedValue = dt.Rows(0).Item("FloID")
                cmbCut.SelectedValue = dt.Rows(0).Item("CutID")
                cmbPolish.SelectedValue = dt.Rows(0).Item("PolishID")
                cmbSymm.SelectedValue = dt.Rows(0).Item("SymID")
                txtQty.Focus()
            End If
        Else

        End If
    End Sub

    Private Sub txtStockID_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles txtStockID.PreviewKeyDown
        If e.KeyCode = Keys.Tab Or e.KeyCode = Keys.Enter Then
            Dim dt As DataTable
            dt = GENERAL_FUNCTIONS.NFetchDatatable("select Barcode,StockID,Qty,Carats,ShapeID,ColorID,ClarityID,FloID,CutID,PolishID,SymID from Dia_MainStock Where StockID='" & txtStockID.Text & "'")
            If dt.Rows.Count = 0 Then
                XtraMessageBox.Show("Stock ID Wrong", "Mauni Diamond", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            Else
                txtBarcode.Text = dt.Rows(0).Item("Barcode")
                txtQty.Text = dt.Rows(0).Item("Qty")
                txtCarats.EditValue = dt.Rows(0).Item("Carats")
                cmbshape.SelectedValue = dt.Rows(0).Item("ShapeID")
                cmbcolor.SelectedValue = dt.Rows(0).Item("ColorID")
                cmbclarity.SelectedValue = dt.Rows(0).Item("ClarityID")
                cmbflour.SelectedValue = dt.Rows(0).Item("FloID")
                cmbCut.SelectedValue = dt.Rows(0).Item("CutID")
                cmbPolish.SelectedValue = dt.Rows(0).Item("PolishID")
                cmbSymm.SelectedValue = dt.Rows(0).Item("SymID")
                txtQty.Focus()
            End If
        End If
    End Sub

    Private Sub btnClose_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnClose.ItemClick
        Me.Dispose()
    End Sub

    Private Sub btnCancel_ItemClick(sender As Object, devE As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCancel.ItemClick
        EditFlag = 0
        clearall()
        cmbGrader.Focus()
        BL.GradingCRUD(dg, 3, 0, 0, 0, 0, dtp.Value, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "", "", "", "", "", "", "", "", "", "", "", "", "")
    End Sub
    Private Sub clearall()
        GF.NClearingControl(Me)
        txtLength.EditValue = Nothing
        txtWidth.EditValue = Nothing
        txtDepth.EditValue = Nothing
        txtTablePercent.EditValue = Nothing
        txtDepthPercent.EditValue = Nothing
        txtRatio.EditValue = Nothing
        txtCrAngle.EditValue = Nothing
        txtCrHeight.EditValue = Nothing
        txtCrAngle.EditValue = Nothing
        txtPvAngle.EditValue = Nothing
        txtPvDepth.EditValue = Nothing
    End Sub

    Private Sub btnSave_ItemClick(sender As Object, devE As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSave.ItemClick
        If isvalid() = True Then
            If EditFlag = 0 Then
                BL.GradingCRUD(dg, 0, 0, CID, BID, UID, dtp.Value, cmbGrader.SelectedValue, cmbLab.SelectedValue, txtBarcode.Text, txtQty.Text, txtCarats.Text, cmbshape.SelectedValue, cmbcolor.SelectedValue, cmbclarity.SelectedValue, cmbflour.SelectedValue, cmbCut.SelectedValue, cmbPolish.SelectedValue, cmbSymm.SelectedValue, txtTablePercent.Text, txtDepthPercent.Text, txtLength.Text, txtWidth.Text, txtDepth.Text, txtRatio.Text, txtCrHeight.Text, txtCrAngle.Text, txtPvDepth.Text, txtPvAngle.Text, txtBlack.Text, txtWhite.Text, txtComment.Text)
                XtraMessageBox.Show("Grading has been Saved.", "Mauni Diamond", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                BL.GradingCRUD(dg, 1, GradingID, CID, BID, UID, dtp.Value, cmbGrader.SelectedValue, cmbLab.SelectedValue, txtBarcode.Text, txtQty.Text, txtCarats.EditValue, cmbshape.SelectedValue, cmbcolor.SelectedValue, cmbclarity.SelectedValue, cmbflour.SelectedValue, cmbCut.SelectedValue, cmbPolish.SelectedValue, cmbSymm.SelectedValue, txtTablePercent.Text, txtDepthPercent.Text, txtLength.Text, txtWidth.Text, txtDepth.Text, txtRatio.Text, txtCrHeight.Text, txtCrAngle.Text, txtPvDepth.Text, txtPvAngle.Text, txtBlack.Text, txtWhite.Text, txtComment.Text)
                XtraMessageBox.Show("Grading has been updated.", "Mauni Diamond", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            btnCancel_ItemClick(sender, devE)
        Else
            Return
        End If
    End Sub

    Private Function isvalid() As Boolean
        isvalid = True
        If EditFlag = 0 Then
            Dim IsGradingAvailable As Integer = GENERAL_FUNCTIONS.NExcuteScalerInt("SELECT COUNT(Barcode) FROM Dia_Grading WHERE LabID=" & cmbLab.SelectedValue & " and GraderID=" & cmbGrader.SelectedValue & " and Barcode=" & txtBarcode.Text & "")
            If IsGradingAvailable <> 0 Then
                DevFunctions.ErrorMsg("Grading already available for this Grader and Lab")
                isvalid = False
                Exit Function
            End If
        End If

        If GF.checkComboisValid(cmbGrader) = False Then
            DevFunctions.ErrorMsg("Select Grader")
            isvalid = False
            Exit Function
        End If
        If GF.checkComboisValid(cmbLab) = False Then
            DevFunctions.ErrorMsg("Select Lab")
            isvalid = False
            Exit Function
        End If
        If txtBarcode.Enabled = True Then
            If GF.CheckTextBoxisValid(txtBarcode) = False Then
                DevFunctions.ErrorMsg("Enter Barcode")
                isvalid = False
                Exit Function
            End If
        End If
        If txtStockID.Enabled = True Then
            If GF.CheckTextBoxisValid(txtStockID) = False Then
                DevFunctions.ErrorMsg("Enter Stock ID")
                isvalid = False
                Exit Function
            End If
        End If
        If GF.checkComboisValid(cmbGrader) = False Then
            DevFunctions.ErrorMsg("Select Grader")
            isvalid = False
            Exit Function
        End If
        If GF.checkComboisValid(cmbcolor) = False Then
            DevFunctions.ErrorMsg("Select Color")
            isvalid = False
            Exit Function
        End If
        If GF.checkComboisValid(cmbclarity) = False Then
            DevFunctions.ErrorMsg("Select Clarity")
            isvalid = False
            Exit Function
        End If
        If GF.checkComboisValid(cmbflour) = False Then
            DevFunctions.ErrorMsg("Select Flourescense")
            isvalid = False
            Exit Function
        End If
        If GF.checkComboisValid(cmbCut) = False Then
            DevFunctions.ErrorMsg("Select Cut")
            isvalid = False
            Exit Function
        End If
        If GF.checkComboisValid(cmbPolish) = False Then
            DevFunctions.ErrorMsg("Select Polish")
            isvalid = False
            Exit Function
        End If
        Return isvalid
    End Function

    Private Sub txtComment_KeyDown(sender As Object, e As KeyEventArgs) Handles txtComment.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnSave_ItemClick(sender, devE)
        End If
    End Sub


    Private Sub txtWidth_KeyUp(sender As Object, e As KeyEventArgs) Handles txtWidth.KeyUp, txtLength.KeyUp
        Dim result As Double = Format(Val(txtLength.Text) / Val(txtWidth.Text), "#.##")
        If Double.IsNaN(result) Or Double.IsInfinity(result) Then
            txtRatio.EditValue = 0
        Else
            txtRatio.EditValue = result
        End If
    End Sub

    Private Sub dgview_DoubleClick(sender As Object, e As EventArgs) Handles dgview.DoubleClick
        If XtraMessageBox.Show("Do you want to update Grading?", "Mauni Diamond", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            EditFlag = 1

            GradingID = TryCast(dg.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("GradingID")
            dtp.Value = TryCast(dg.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("GradingDate")
            cmbGrader.SelectedValue = TryCast(dg.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("GraderID")
            cmbLab.SelectedValue = TryCast(dg.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("LabID")
            txtBarcode.Text = TryCast(dg.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("Barcode")
            txtStockID.Text = TryCast(dg.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("StockID")
            txtQty.Text = TryCast(dg.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("Qty")
            txtCarats.Text = TryCast(dg.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("Carats")
            cmbshape.SelectedValue = TryCast(dg.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("ShapeID")
            cmbcolor.SelectedValue = TryCast(dg.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("ColorID")
            cmbclarity.SelectedValue = TryCast(dg.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("ClarityID")
            cmbflour.SelectedValue = TryCast(dg.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("FloID")
            cmbCut.SelectedValue = TryCast(dg.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("CutID")
            cmbPolish.SelectedValue = TryCast(dg.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("PolishID")
            cmbSymm.SelectedValue = TryCast(dg.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("SymID")
            txtTablePercent.EditValue = TryCast(dg.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("TablePercent")
            txtDepthPercent.EditValue = TryCast(dg.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("TotalDepth")
            txtLength.EditValue = TryCast(dg.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("Length")
            txtWidth.EditValue = TryCast(dg.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("Width")
            txtDepth.EditValue = TryCast(dg.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("Depth")
            txtRatio.EditValue = TryCast(dg.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("Ratio")
            txtCrHeight.EditValue = TryCast(dg.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("CrHeight")
            txtCrAngle.EditValue = TryCast(dg.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("CrAngle")
            txtPvDepth.EditValue = TryCast(dg.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("PvDepth")
            txtPvAngle.EditValue = TryCast(dg.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("PvAngle")
            txtBlack.Text = TryCast(dg.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("Black")
            txtWhite.Text = TryCast(dg.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("White")
            txtComment.Text = TryCast(dg.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("Comment")

        Else

        End If
    End Sub

    Private Sub txtCarats_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCarats.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            cmbshape.Focus()
        End If
    End Sub

    Private Sub dgview_CustomUnboundColumnData(sender As Object, e As CustomColumnDataEventArgs) Handles dgview.CustomUnboundColumnData
        If e.IsGetData Then e.Value = Convert.ToDouble((TryCast(e.Row, DataRowView)).Row("Length").ToString())
    End Sub

    Private Sub dg_KeyDown(sender As Object, e As KeyEventArgs) Handles dg.KeyDown
        If e.KeyCode = Keys.Delete Then
            If XtraMessageBox.Show("Do you want to delete this Grading?", "Mauni Diamond", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                GradingID = TryCast(dg.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("GradingID")
                BL.GradingCRUD(dg, 2, GradingID, 0, 0, 0, dtp.Value, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "", "", "", "", "", "", "", "", "", "", "", "", "")

                XtraMessageBox.Show("Grading has been deleted.", "Mauni Diamond", MessageBoxButtons.OK, MessageBoxIcon.Error)
                btnCancel_ItemClick(sender, devE)
            Else
                Exit Sub
            End If
        Else

        End If
    End Sub

    Private Sub MnuFinal_Click(sender As Object, e As EventArgs) Handles MnuFinal.Click
        Dim dr As DataRow = GENERAL_FUNCTIONS.NFetchDataRow("Select top(1) * from Dia_MainStock Where Barcode=" & dgview.GetFocusedRowCellValue("Barcode") & " Order by TransactionID Desc")
        If dr("SalesMasterID") > 0 Or dr("ProcessStatus") = 1 Then
            DevFunctions.ErrorMsg("Can not set grading as final")
            Return
        End If

        dr("UserID") = GLOBAL_VARIABLES.UID
        dr("ImportDate") = GENERAL_FUNCTIONS.NExcuteScaler("select GETDATE()")
        dr("LabourUSD") = 0
        dr("LabourINR") = 0
        dr("ShapeID") = dgview.GetFocusedRowCellValue("ShapeID")
        dr("ColorID") = dgview.GetFocusedRowCellValue("ColorID")
        dr("ClarityID") = dgview.GetFocusedRowCellValue("ClarityID")
        dr("FloID") = dgview.GetFocusedRowCellValue("FloID")
        dr("RAP") = DevFunctions.GetRAP(dgview.GetFocusedRowCellValue("ShapeID"), dgview.GetFocusedRowCellValue("ColorID"), dgview.GetFocusedRowCellValue("ClarityID"), dgview.GetFocusedRowCellValue("Carats"))
        dr("CutID") = dgview.GetFocusedRowCellValue("CutID")
        dr("PolishID") = dgview.GetFocusedRowCellValue("PolishID")
        dr("SymID") = dgview.GetFocusedRowCellValue("SymID")
        dr("Comment") = dgview.GetFocusedRowCellValue("Comment")
        dr("LLength") = dgview.GetFocusedRowCellValue("Length")
        dr("LWidth") = dgview.GetFocusedRowCellValue("Width")
        dr("LDepth") = dgview.GetFocusedRowCellValue("Depth")
        dr("LTable") = dgview.GetFocusedRowCellValue("TablePercent")
        dr("LTotalDepth") = dgview.GetFocusedRowCellValue("TotalDepth")
        dr("LCrownHeight") = dgview.GetFocusedRowCellValue("CrHeight")
        dr("LCrownAngle") = dgview.GetFocusedRowCellValue("CrAngle")
        dr("LPavillionDepth") = dgview.GetFocusedRowCellValue("PvDepth")
        dr("LPavillionAngle") = dgview.GetFocusedRowCellValue("PvAngle")
        dr("Black") = dgview.GetFocusedRowCellValue("Black")
        dr("White") = dgview.GetFocusedRowCellValue("White")
        dr("HistoryDescription") = "Set Final Grading"
        dr("ExecutionDateTime") = GENERAL_FUNCTIONS.NExcuteScaler("select GETDATE()")

        Dim dt As DataTable = DevFunctions.GetEmptyMainStockDatatable()
        dt.Rows.Add(dr.ItemArray)

        GENERAL_FUNCTIONS.DataTable_to_SqlTable_Copy(dt, "Dia_MainStock")
        DevFunctions.InfoMsg("Grading has been Saved Successfully")
    End Sub
End Class