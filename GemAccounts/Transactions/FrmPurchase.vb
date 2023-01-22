Imports System.ComponentModel
Imports System.IO
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid

Public Class FrmPurchase
    Dim tmpdt As New DataTable
    Dim GF As New GENERAL_FUNCTIONS
    Dim BL As New BAL_Transactions
    Dim mc As New MasterConnection
    Dim EditFlag As Integer
    Dim PID As Integer = 0
    Dim TID As Integer = 0
    Dim m As DevExpress.XtraBars.ItemClickEventArgs



    Private Sub FrmPurchase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btncancel_itemclick(sender, m)
    End Sub
    Private Sub txtPcs_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtGrossUSD.KeyPress, txtAddExpUSD.KeyPress, txtNetUSD.KeyPress, txtNetUSD.KeyPress, txtCts.KeyPress, txtPcs.KeyPress, txtExRate.KeyPress, txtNetINR.KeyPress
        GF.AcceptNumer(sender, e)
    End Sub


    Private Sub txtPcs_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPcs.KeyDown, dtp.KeyDown, cmbVendorName.KeyDown, cmbPurchaseLedger.KeyDown, cmbterms.KeyDown, cmbItemType.KeyDown, txtCts.KeyDown, txtGrossUSD.KeyDown, txtAddExpUSD.KeyDown, txtNetUSD.KeyDown, txtExRate.KeyDown, txtNetINR.KeyDown, txtRemarks.KeyDown
        GENERAL_FUNCTIONS.FocusNext(sender, e)
    End Sub


    Private Function validation() As Boolean
        If cmbPurchaseLedger.SelectedValue = 0 Then
            DevFunctions.ErrorMsg("Please select Purchase Legder")
            cmbPurchaseLedger.Focus()
            validation = False
            Exit Function
        ElseIf cmbVendorName.SelectedValue = 0 Then
            DevFunctions.ErrorMsg("Please select Vendor Name")
            cmbVendorName.Focus()
            validation = False
            Exit Function
        ElseIf cmbterms.SelectedValue = 0 Then
            DevFunctions.ErrorMsg("Please select Terms")
            cmbterms.Focus()
            validation = False
            Exit Function
        ElseIf cmbItemType.SelectedValue = 0 Then
            DevFunctions.ErrorMsg("Please select Item Type")
            cmbItemType.Focus()
            validation = False
            Exit Function
        ElseIf Len(Trim(txtPcs.Text)) = 0 Then
            DevFunctions.ErrorMsg("Please enter Pcs")
            txtPcs.Focus()
            validation = False
            Exit Function
        ElseIf Len(Trim(txtCts.Text)) = 0 Then
            DevFunctions.ErrorMsg("Please enter Carats")
            txtCts.Focus()
            validation = False
            Exit Function
        ElseIf Len(Trim(txtGrossUSD.Text)) = 0 Then
            DevFunctions.ErrorMsg("Please enter Gross Total USD")
            txtGrossUSD.Focus()
            validation = False
            Exit Function
        End If

        If Len(Trim(txtGrossUSD.Text)) = 0 Then
            txtGrossUSD.Text = 0
        End If
        If Len(Trim(txtAddExpUSD.Text)) = 0 Then
            txtAddExpUSD.Text = 0
        End If
        If Len(Trim(txtNetUSD.Text)) = 0 Then
            txtNetUSD.Text = 0
        End If
        If Len(Trim(txtExRate.Text)) = 0 Then
            txtExRate.Text = 0
        End If
        If Len(Trim(txtNetINR.Text)) = 0 Then
            txtNetINR.Text = 0
        End If
        validation = True
        Return validation
    End Function
    Private Sub txtGrossUSD_TextChanged(sender As Object, e As EventArgs) Handles txtGrossUSD.TextChanged, txtNetUSD.TextChanged
        If txtGrossUSD.Text = "" Then txtGrossUSD.Text = 0
        If txtAddExpUSD.Text = "" Then txtAddExpUSD.Text = 0
        If txtNetUSD.Text = "" Then txtNetUSD.Text = 0
        'txtNetUSD.Text = Val(txtGrossUSD.Text) + Val(txtAddExpUSD.Text)
        txtAddExpUSD.Text = Val(txtNetUSD.Text) - Val(txtGrossUSD.Text)
        lblExpPercent.Text = Format((Val(txtAddExpUSD.Text) * 100) / txtGrossUSD.Text, "n2") & " %"
    End Sub

    Private Sub txtNetINR_KeyUp(sender As Object, e As KeyEventArgs) Handles txtNetINR.KeyUp
        txtExRate.Text = Val(txtNetINR.Text) / Val(txtNetUSD.Text)
    End Sub

    Private Sub txtExRate_KeyUp(sender As Object, e As KeyEventArgs) Handles txtExRate.KeyUp
        txtNetINR.Text = Val(txtNetUSD.Text) * Val(txtExRate.Text)
    End Sub

    Private Sub cmbterms_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbterms.SelectionChangeCommitted
        Dim termsdays As Integer = Integer.Parse(GENERAL_FUNCTIONS.NExcuteScalerInt("select terms_desc from Dia_Terms_Master where terms_id=" & cmbterms.SelectedValue & ""))
        DtpDue.Value = dtp.Value.AddDays(termsdays)
    End Sub

    Private Sub dtp_ValueChanged(sender As Object, e As EventArgs) Handles dtp.ValueChanged
        If cmbterms.SelectedValue = Nothing Then
        Else
            cmbterms_SelectionChangeCommitted(sender, e)
        End If
    End Sub




    Private Sub txtNetUSD_TextChanged(sender As Object, e As EventArgs) Handles txtNetUSD.TextChanged, txtExRate.TextChanged
        txtNetINR.Text = Val(txtNetUSD.Text) * Val(txtExRate.Text)
    End Sub

    Private Sub btnsave_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSave.ItemClick
        If validation() = False Then
            Exit Sub
        Else
            GLOBAL_VARIABLES.Filename = ""
            If EditFlag = 0 Then
                DevFunctions.CopY_PDF_to_Server(txtAttachment.EditValue, "Purchase", GENERAL_FUNCTIONS.MaxNo("Select Max(PurchaseID) from Dia_Purchase"))
                FullFileName()
                BL.PurchaseCRUD(dg, 0, 0, GLOBAL_VARIABLES.CID, GLOBAL_VARIABLES.BID, GLOBAL_VARIABLES.UID, cmbterms.SelectedValue, cmbItemType.SelectedValue, txtPcs.Text, txtCts.Text, txtGrossUSD.Text, txtAddExpUSD.Text, dtp.Value, txtRemarks.Text, cmbPurchaseLedger.SelectedValue, cmbVendorName.SelectedValue, txtNetINR.Text, txtExRate.Text, txtNetUSD.Text, TID, GLOBAL_VARIABLES.Filename)
                DevFunctions.InfoMsg("Purchase has been Saved.")
            Else
                DevFunctions.CopY_PDF_to_Server(txtAttachment.EditValue, "Purchase", PID)
                FullFileName()
                BL.PurchaseCRUD(dg, 1, PID, GLOBAL_VARIABLES.CID, GLOBAL_VARIABLES.BID, GLOBAL_VARIABLES.UID, cmbterms.SelectedValue, cmbItemType.SelectedValue, txtPcs.Text, txtCts.Text, txtGrossUSD.Text, txtAddExpUSD.Text, dtp.Value, txtRemarks.Text, cmbPurchaseLedger.SelectedValue, cmbVendorName.SelectedValue, txtNetINR.Text, txtExRate.Text, txtNetUSD.Text, TID, GLOBAL_VARIABLES.Filename)
                DevFunctions.InfoMsg("Purchase has been updated.")
            End If
            btncancel_itemclick(sender, m)
        End If
    End Sub
    Private Sub FullFileName()
        If txtAttachment.EditValue = Nothing Then
            GLOBAL_VARIABLES.Filename = ""
        Else
            If EditFlag = False Then
                GLOBAL_VARIABLES.Filename = GLOBAL_VARIABLES.AttachmentPath & "Purchase-" & GENERAL_FUNCTIONS.MaxNo("Select Max(PurchaseID) from Dia_Purchase") & ".pdf"
            Else
                GLOBAL_VARIABLES.Filename = GLOBAL_VARIABLES.AttachmentPath & "Purchase-" & PID & ".pdf"
            End If

        End If
    End Sub

    Private Sub btncancel_itemclick(sender As Object, M As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCancel.ItemClick
        EditFlag = 0
        txtPcs.Enabled = True
        txtCts.Enabled = True
        txtGrossUSD.Enabled = True
        txtNetUSD.Enabled = True
        lblExpPercent.Text = ""
        GENERAL_FUNCTIONS.FillVendorsCombo(cmbVendorName)
        GF.FillTermsCombo(cmbterms)
        GF.FillItemTypeCombo(cmbItemType)
        GENERAL_FUNCTIONS.FillPurchaseLedgers(cmbPurchaseLedger)
        txtPcs.Text = ""
        txtCts.Text = ""
        txtGrossUSD.Text = ""
        txtAddExpUSD.Text = ""
        txtNetUSD.Text = ""
        txtExRate.Text = ""
        txtNetINR.Text = ""
        txtRemarks.Text = ""
        txtAttachment.EditValue = Nothing
        dtp.Focus()
        BL.PurchaseCRUD(dg, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, dtp.Value, "", 0, 0, 0, 0, 0, 0, "")
        view.BestFitColumns()
        cmbVendorName.SelectedValue = 0
        cmbterms.SelectedValue = 0
        cmbItemType.SelectedValue = 0
    End Sub

    Private Sub btnClose_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnClose.ItemClick
        Me.Close()
    End Sub

    Private Sub btnExport_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExport.ItemClick
        DevFunctions.ExportGrid(view)
    End Sub

    Private Sub btnRefresh_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRefresh.ItemClick
        btncancel_itemclick(sender, m)
    End Sub

    Private Sub btnAttachment_Click(sender As Object, e As EventArgs) Handles btnAttachment.Click
        txtAttachment.EditValue = DevFunctions.GetFullPath_of_PDF()
    End Sub

    Private Sub view_RowCellClick(sender As Object, e As RowCellClickEventArgs) Handles view.RowCellClick
        If e.Column.FieldName = "PDF" Then
            Dim path As String = view.GetFocusedRowCellValue("Attachment")
            If path Is Nothing Or path Is String.Empty Then Return
            Try
                With FrmPDFViewer
                    .Show()
                    .Focus()
                    .PdfViewer1.DocumentFilePath = path
                End With
            Catch ex As Exception
                DevFunctions.ErrorMsg(ex.Message)
            End Try
        Else
            Return
        End If
    End Sub

    Private Sub DeleteMenu_Click(sender As Object, e As EventArgs) Handles DeleteMenu.Click
        If view.GetFocusedRowCellValue("PurchaseID") Is Nothing Or view.GetFocusedRowCellValue("PurchaseID") Is String.Empty Then Return
        If XtraMessageBox.Show("Do you want to delete this Purchase?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim tmp As Integer = GENERAL_FUNCTIONS.NExcuteScaler("Select Count(PurchaseID) from Dia_Serie where PurchaseID=" & view.GetFocusedRowCellValue("PurchaseID"))
            If tmp > 0 Then
                DevFunctions.ErrorMsg("You cannot delete this purchase")
                Exit Sub
            End If

            If System.IO.File.Exists(view.GetFocusedRowCellValue("Attachment")) = True Then
                System.IO.File.Delete(view.GetFocusedRowCellValue("Attachment"))
            End If
            TID = view.GetFocusedRowCellValue("TID")

            BL.PurchaseCRUD(dg, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, dtp.Value, "", 0, 0, 0, 0, 0, TID, "")
            DevFunctions.ErrorMsg("Purchase has been deleted.")
            btncancel_itemclick(sender, m)
        Else
            Exit Sub
        End If
    End Sub

    Private Sub EditMenu_Click(sender As Object, e As EventArgs) Handles EditMenu.Click
        If view.GetFocusedRowCellValue("PurchaseID") Is Nothing Or view.GetFocusedRowCellValue("PurchaseID") Is String.Empty Then Return
        Dim tmp As Integer = GENERAL_FUNCTIONS.NExcuteScaler("Select Count(PurchaseID) from Dia_Serie where PurchaseID=" & view.GetFocusedRowCellValue("PurchaseID"))
        If tmp > 0 Then
            txtPcs.Enabled = False
            txtCts.Enabled = False
            txtGrossUSD.Enabled = False
            txtNetUSD.Enabled = False
        End If
        EditFlag = 1
        PID = view.GetFocusedRowCellValue("PurchaseID")
        cmbVendorName.SelectedValue = view.GetFocusedRowCellValue("VendorID")
        cmbterms.SelectedValue = view.GetFocusedRowCellValue("TermsID")
        cmbPurchaseLedger.SelectedValue = view.GetFocusedRowCellValue("PurchaseLedgerID")
        dtp.Value = Now()
        dtp.Value = view.GetFocusedRowCellValue("PurchaseDate")
        cmbItemType.SelectedValue = view.GetFocusedRowCellValue("ItemTypeID")
        txtPcs.Text = view.GetFocusedRowCellValue("Pcs")
        txtCts.Text = view.GetFocusedRowCellValue("Carats")
        txtGrossUSD.Text = view.GetFocusedRowCellValue("GrossTotalUSD")
        txtAddExpUSD.Text = view.GetFocusedRowCellValue("AddExpUSD")
        txtExRate.Text = view.GetFocusedRowCellValue("ExchangeRate")
        txtNetUSD.Text = view.GetFocusedRowCellValue("NetUSD")
        txtNetINR.Text = view.GetFocusedRowCellValue("NetINR")
        txtRemarks.Text = view.GetFocusedRowCellValue("Remarks")
        If IsDBNull(view.GetFocusedRowCellValue("Attachment")) = False Then
            txtAttachment.EditValue = view.GetFocusedRowCellValue("Attachment")
            GLOBAL_VARIABLES.TmpFileName = view.GetFocusedRowCellValue("Attachment")
        End If
        TID = view.GetFocusedRowCellValue("TID")
    End Sub
End Class