Imports GemAccounts.GENERAL_FUNCTIONS
Imports GemAccounts.DevFunctions
Imports GemAccounts.GLOBAL_VARIABLES
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Base
Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class frmPayment
    Private ExpDT As New DataTable
    Public Shared PaymentEditFlag As Boolean
    Public Shared PaymentID As Integer
    Private c As EventArgs
    Private Sender As Object
    Private Sub frmPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ExpDT.Columns.Add("Expense")
        ExpDT.Columns.Add("ExUSD", GetType(Double))
        ExpDT.Columns.Add("ExRate", GetType(Double))
        ExpDT.Columns.Add("ExINR", GetType(Double))
        ExpDT.Columns.Add("ExpID", GetType(Integer))
        btnCancel_ItemClick(sender, q)
        If PaymentEditFlag = True Then
            EditMode_FillData()
        End If
    End Sub
    Private Sub EditMode_FillData()
        Dim DT As DataTable = NFetchDatatable("SELECT d.*,L.LedgerName AS Expense FROM Dia_Payment_Master d LEFT JOIN Dia_Ledger_Master L ON L.LedgerID=D.ExpID where PaymentID=" & PaymentID)
        If DT Is Nothing Then Return
        If DT.Rows.Count = 0 Then Return
        dtp.EditValue = DT.Rows(0).Item("PaymentDate")
        cmbBank.EditValue = DT.Rows(0).Item("Bank").ToString
        cmbSetOffAgainst.EditValue = DT.Rows(0).Item("PurchaseID").ToString
        txtPayUSD.EditValue = DT.Rows(0).Item("PayUSD").ToString
        txtRate.EditValue = DT.Rows(0).Item("ExRate").ToString
        txtPayINR.EditValue = DT.Rows(0).Item("PayINR").ToString
        cmbPayto.EditValue = DT.Rows(0).Item("Vendor").ToString
        cmbPayto_EditValueChanged(Sender, c)

        cmbSetOffAgainst.EditValue = DT.Rows(0).Item("PurchaseID").ToString
        txtAttachment.EditValue = DT.Rows(0).Item("Attachment").ToString

        For i = 0 To DT.Rows.Count - 1
            If DT.Rows(i).Item("ExpID").ToString = 0 Then
                Return
            End If
            Dim dr As DataRow = ExpDT.NewRow()
            dr("ExpID") = DT.Rows(i).Item("ExpID").ToString
            dr("ExUSD") = DT.Rows(i).Item("ExUSD").ToString
            dr("ExRate") = DT.Rows(i).Item("ExRate").ToString
            dr("ExINR") = DT.Rows(i).Item("ExINR").ToString
            dr("Expense") = DT.Rows(i).Item("Expense").ToString
            ExpDT.Rows.Add(dr.ItemArray)
            dg.DataSource = ExpDT
        Next

    End Sub

    Private Sub btnClose_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnClose.ItemClick
        Me.Close()
    End Sub

    Private Sub btnCancel_ItemClick(sender As Object, q As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCancel.ItemClick
        Fill_GridLookupEdit(cmbPayto)
        Nfill_Ledgers_by_Group_GridLookupEdit({"Bank", "Cash"}, "Dia_Ledger_Master", "LedgerName", "LedgerID", cmbBank)
        Nfill_Ledgers_by_Group_GridLookupEdit({"Expenses"}, "Dia_Ledger_Master", "LedgerName", "LedgerID", cmbExpense)
        ExpDT.Rows.Clear()
        dg.DataSource = Nothing
        ClearAll()
        dtp.Focus()
    End Sub
    Private Sub Fill_GridLookupEdit(ctrl As DevExpress.XtraEditors.GridLookUpEdit)
        Dim dt As New DataTable
        Dim queryadd As String = ""
        Dim query As String = "SELECT DISTINCT T.CreditLedger as LedgerID,L.LedgerName as LedgerName FROM Dia_Transcation T
LEFT JOIN Dia_Ledger_Master L ON L.LedgerID=T.CreditLedger
LEFT JOIN Dia_Purchase P ON P.TID=T.TranscationID
WHERE (L.LedgerID<>null or T.CreditLedger<>0) and (L.LedgerID<>null or T.CreditLedger<>0) and P.PaymentFlag=0 ORDER BY LedgerName"

        Dim dtp As New DataSet
        ADP = New SqlDataAdapter(query, VarCon.Connection)
        ADP.Fill(dtp)
        dt = dtp.Tables(0)
        VarCon.CloseConnection()

        ctrl.Properties.DataSource = dt
        ctrl.Properties.PopulateViewColumns()
        ctrl.Properties.View.Columns("LedgerID").Visible = False
        ctrl.Properties.DisplayMember = "LedgerName"
        ctrl.Properties.ValueMember = "LedgerID"
        ctrl.Properties.PopupView.OptionsView.ShowFilterPanelMode = False
        ctrl.Text = ""
    End Sub
    Private Sub ClearAll()
        dtp.EditValue = Now
        cmbBank.EditValue = Nothing
        cmbPayto.EditValue = Nothing
        cmbSetOffAgainst.EditValue = Nothing
        txtPayUSD.Text = 0
        txtPayINR.EditValue = 0
        txtRate.EditValue = GLOBAL_VARIABLES.ExRate
        cmbExpense.EditValue = Nothing
        txtExpUSD.EditValue = 0
        txtExpINR.EditValue = 0
        txtAttachment.EditValue = Nothing
    End Sub

    Private Sub dtp_KeyDown(sender As Object, e As KeyEventArgs) Handles dtp.KeyDown, cmbBank.KeyDown, cmbPayto.KeyDown, cmbSetOffAgainst.KeyDown, txtPayUSD.KeyDown, txtRate.KeyDown, txtPayINR.KeyDown, cmbExpense.KeyDown, txtExpUSD.KeyDown, txtExpINR.KeyDown
        FocusNext(sender, e)
    End Sub

    Private Sub txtPayUSD_KeyUp(sender As Object, e As KeyEventArgs) Handles txtPayUSD.KeyUp
        txtPayINR.EditValue = txtPayUSD.EditValue * txtRate.EditValue
    End Sub

    Private Sub txtRate_KeyUp(sender As Object, e As KeyEventArgs) Handles txtRate.KeyUp
        txtPayUSD_KeyUp(sender, e)
    End Sub

    Private Sub txtPayINR_KeyUp(sender As Object, e As KeyEventArgs) Handles txtPayINR.KeyUp
        txtRate.EditValue = txtPayINR.EditValue / txtPayUSD.EditValue
    End Sub

    Private Sub txtExpUSD_KeyUp(sender As Object, e As KeyEventArgs) Handles txtExpUSD.KeyUp
        txtExpINR.EditValue = txtExpUSD.EditValue * txtRate.EditValue
    End Sub

    Private Sub txtExpINR_KeyUp(sender As Object, e As KeyEventArgs) Handles txtExpINR.KeyUp
        txtExpUSD.EditValue = txtExpINR.EditValue / txtRate.EditValue
    End Sub

    Private q As DevExpress.XtraBars.ItemClickEventArgs

    Private Sub btnAddRow_Click(sender As Object, e As EventArgs) Handles btnAddRow.Click
        If CheckValidation() = True Then
            If cmbExpense.EditValue = Nothing Then
                ErrorMsg("Select Expense")
                cmbExpense.Focus()
                Exit Sub
            End If
            If txtExpUSD.EditValue = Nothing Then
                ErrorMsg("Enter USD")
                txtExpUSD.Focus()
                Exit Sub
            End If
            If txtExpINR.EditValue = Nothing Then
                ErrorMsg("Enter INR")
                txtExpINR.Focus()
                Exit Sub
            End If
            Dim dr As DataRow
            dr = ExpDT.NewRow()
            dr("Expense") = cmbExpense.Text
            dr("ExUSD") = txtExpUSD.EditValue
            dr("ExRate") = txtRate.EditValue
            dr("ExINR") = txtExpINR.EditValue
            dr("ExpID") = cmbExpense.EditValue
            ExpDT.Rows.Add(dr.ItemArray)
            dg.DataSource = ExpDT

            If XtraMessageBox.Show("Do you want to Add another Expense?", "Mauni Diamond", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                cmbExpense.Focus()
            End If
            cmbExpense.Properties.NullText = Nothing
            cmbExpense.EditValue = Nothing
            txtExpUSD.EditValue = Nothing
            txtExpINR.EditValue = Nothing
        End If
    End Sub

    Private Function CheckValidation() As Boolean
        CheckValidation = True
        If cmbBank.EditValue = Nothing Then
            ErrorMsg("Select Bank or Cash")
            CheckValidation = False
            cmbBank.Focus()
            Exit Function
        End If
        If cmbPayto.EditValue = Nothing Then
            ErrorMsg("Select Pay To")
            CheckValidation = False
            cmbPayto.Focus()
            Exit Function
        End If
        If cmbSetOffAgainst.EditValue = Nothing Then
            ErrorMsg("Select Set Off Against")
            CheckValidation = False
            cmbSetOffAgainst.Focus()
            Exit Function
        End If
        If txtPayUSD.EditValue = Nothing Then
            ErrorMsg("Enter USD")
            CheckValidation = False
            txtPayUSD.Focus()
            Exit Function
        End If
        If txtRate.EditValue = Nothing Then
            ErrorMsg("Enter Rate")
            CheckValidation = False
            txtRate.Focus()
            Exit Function
        End If
        If txtPayINR.EditValue = Nothing Then
            ErrorMsg("Enter INR")
            CheckValidation = False
            txtPayINR.Focus()
            Exit Function
        End If
        Return CheckValidation
    End Function

    Private Sub cmbPayto_EditValueChanged(sender As Object, c As EventArgs) Handles cmbPayto.EditValueChanged
        If cmbPayto.EditValue = Nothing Then Return
        If PaymentEditFlag = True Then
            NFetchSearchLookupEdit("SELECT tr.TransactionDate as PurchaseDate
		,P.Pcs,P.Carats,TR.AmountINR AS NetINR,tr.AmountUSD as NetUSD,P.PurchaseID as PurchaseID,
		(TR.AmountUSD - ISNULL(SUM(PAY.PayUSD),0)) AS PendingUSD,(TR.AmountINR - ISNULL(SUM(PAY.PayINR),0)) AS PendingINR
		FROM Dia_Purchase P	LEFT JOIN Dia_Company_Master C ON C.cmp_id=P.CompanyID	LEFT JOIN Dia_Branch_Master B ON B.br_id=P.BranchID
		LEFT JOIN Dia_User_Master U ON U.user_id=P.UserID LEFT JOIN Dia_Terms_Master T ON T.terms_id=P.Terms
		LEFT JOIN Dia_Item_Type_Master I ON I.item_type_id =P.ItemType	LEFT JOIN Dia_Transcation TR ON TR.TranscationID=P.TID
		LEFT JOIN Dia_Ledger_Master CrLedger ON CrLedger.LedgerID=TR.CreditLedger	LEFT JOIN Dia_Ledger_Master DrLedger ON DrLedger.LedgerID=TR.DebitLedger  
		LEFT JOIN (SELECT DISTINCT(PAYMENTID),PAYUSD,PurchaseID,PayINR FROM Dia_Payment_Master) PAY ON PAY.PurchaseID=P.PurchaseID
		WHERE TR.CreditLedger=" & cmbPayto.EditValue & " GROUP BY tr.TransactionDate,P.Pcs,P.Carats,TR.AmountINR,tr.AmountUSD,P.PurchaseID", cmbSetOffAgainst)
        Else
            NFetchSearchLookupEdit("SELECT tr.TransactionDate as PurchaseDate
		,P.Pcs,P.Carats,TR.AmountINR AS NetINR,tr.AmountUSD as NetUSD,P.PurchaseID as PurchaseID,
		(TR.AmountUSD - ISNULL(SUM(PAY.PayUSD),0)) AS PendingUSD,(TR.AmountINR - ISNULL(SUM(PAY.PayINR),0)) AS PendingINR
		FROM Dia_Purchase P	LEFT JOIN Dia_Company_Master C ON C.cmp_id=P.CompanyID	LEFT JOIN Dia_Branch_Master B ON B.br_id=P.BranchID
		LEFT JOIN Dia_User_Master U ON U.user_id=P.UserID LEFT JOIN Dia_Terms_Master T ON T.terms_id=P.Terms
		LEFT JOIN Dia_Item_Type_Master I ON I.item_type_id =P.ItemType	LEFT JOIN Dia_Transcation TR ON TR.TranscationID=P.TID
		LEFT JOIN Dia_Ledger_Master CrLedger ON CrLedger.LedgerID=TR.CreditLedger	LEFT JOIN Dia_Ledger_Master DrLedger ON DrLedger.LedgerID=TR.DebitLedger  
		LEFT JOIN (SELECT DISTINCT(PAYMENTID),PAYUSD,PurchaseID,PayINR FROM Dia_Payment_Master) PAY ON PAY.PurchaseID=P.PurchaseID
		WHERE P.PaymentFlag=0 AND TR.CreditLedger=" & cmbPayto.EditValue & " GROUP BY tr.TransactionDate,P.Pcs,P.Carats,TR.AmountINR,tr.AmountUSD,P.PurchaseID", cmbSetOffAgainst)
        End If

        cmbSetOffAgainst.Properties.DisplayMember = "NetUSD"
        cmbSetOffAgainst.Properties.ValueMember = "PurchaseID"
    End Sub

    Private Sub btnSave_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSave.ItemClick
        If SaveData() = True Then
            btnCancel_ItemClick(sender, q)
            InfoMsg("Payment has been saved successfully")
        End If
    End Sub
    Private Function SaveData() As Boolean
        Dim MaxNo As Integer = GENERAL_FUNCTIONS.MaxNo("SELECT MAX(PaymentID) FROM Dia_Payment_Master")

        If PaymentEditFlag = False Then
            DevFunctions.CopY_PDF_to_Server(txtAttachment.EditValue, "Payment", MaxNo)
            If txtAttachment.EditValue = Nothing Then
                GLOBAL_VARIABLES.Filename = ""
            Else
                GLOBAL_VARIABLES.Filename = GLOBAL_VARIABLES.AttachmentPath & "Payment-" & MaxNo & ".pdf"
            End If
        Else

            DevFunctions.CopY_PDF_to_Server(txtAttachment.EditValue, "Payment", MaxNo)
            If txtAttachment.EditValue = Nothing Then
                GLOBAL_VARIABLES.Filename = ""
            Else
                GLOBAL_VARIABLES.Filename = GLOBAL_VARIABLES.AttachmentPath & "Payment-" & MaxNo & ".pdf"
            End If
            Dim OldPath As String = GENERAL_FUNCTIONS.NExcuteScaler("Select Attachment from Dia_Payment_Master where PaymentID=" & PaymentID)
            If IsDBNull(OldPath) = False Then
                If System.IO.File.Exists(OldPath) = True Then
                    System.IO.File.Delete(OldPath)
                End If
            End If

            NExcuteQuery("DELETE from Dia_Payment_Master where PaymentID=" & PaymentID)
            NExcuteQuery("UPDATE Dia_Purchase SET PaymentFlag=0 WHERE PurchaseID=" & cmbSetOffAgainst.EditValue)
        End If
        If ExpDT.Rows.Count = 0 Then
            BAL_Transactions.PaymentCRUD(dg, 0, MaxNo, dtp.EditValue, cmbBank.EditValue, cmbPayto.EditValue, cmbSetOffAgainst.EditValue, txtPayUSD.EditValue, (txtPayINR.EditValue / txtPayUSD.EditValue), txtPayINR.EditValue, 0, 0, 0, 0, GLOBAL_VARIABLES.Filename)
        Else
            For i = 0 To ExpDT.Rows.Count - 1
                BAL_Transactions.PaymentCRUD(dg, 0, MaxNo, dtp.EditValue, cmbBank.EditValue, cmbPayto.EditValue, cmbSetOffAgainst.EditValue, txtPayUSD.EditValue, (txtPayINR.EditValue / txtPayUSD.EditValue), txtPayINR.EditValue, ExpDT.Rows(i).Item("ExpID"), ExpDT.Rows(i).Item("ExUSD"), ExpDT.Rows(i).Item("ExINR"), 0, GLOBAL_VARIABLES.Filename)
            Next
        End If
        Dim InvoiceUSD As Double = Double.Parse(NExcuteScaler("SELECT T.AmountUSD FROM Dia_Purchase P LEFT JOIN Dia_Transcation T ON T.TranscationID=P.TID WHERE PurchaseID=" & cmbSetOffAgainst.EditValue & ""))
        Dim PayUSD As Double = Double.Parse(NExcuteScaler(" SELECT SUM(P.PAYUSD)AS PayUSD FROM (SELECT DISTINCT(PAYMENTID),PAYUSD,PurchaseID FROM Dia_Payment_Master) P WHERE PurchaseID=" & cmbSetOffAgainst.EditValue & ""))
        If Val(Format(InvoiceUSD, "0.00")) = Val(Format(PayUSD, "0.00")) Then
            Dim TotalINR As Double = Double.Parse(NExcuteScaler("SELECT SUM(P.PayINR) AS TotalINR FROM (SELECT DISTINCT(PAYMENTID),PayINR,PurchaseID  FROM Dia_Payment_Master)P WHERE P.PurchaseID=" & cmbSetOffAgainst.EditValue))
            NExcuteQuery("UPDATE Dia_Transcation SET AmountINR=" & TotalINR & ",ExRate=(" & TotalINR & "/AmountUSD) WHERE TranscationID=(SELECT TID FROM Dia_Purchase WHERE PurchaseID=" & cmbSetOffAgainst.EditValue & " )")
            NExcuteQuery("UPDATE Dia_Purchase SET PaymentFlag=1 WHERE PurchaseID =" & cmbSetOffAgainst.EditValue)
        End If

        frmPaymentReport.LoadFrm()
        SaveData = True
        Return SaveData
    End Function


    Private Sub dgview_KeyDown(sender As Object, e As KeyEventArgs) Handles dgview.KeyDown
        If e.KeyCode = Keys.Delete Then
            dgview.DeleteRow(dgview.FocusedRowHandle)
        Else
            Return
        End If
    End Sub
    Private Sub txtRate_EditValueChanged(sender As Object, e As EventArgs) Handles txtRate.EditValueChanged
        If ExpDT.Rows.Count = 0 Then Return
        For i = 0 To ExpDT.Rows.Count - 1
            ExpDT.Rows(i).Item("ExRate") = txtRate.EditValue
            ExpDT.Rows(i).Item("ExUSD") = Val(ExpDT.Rows(i).Item("ExINR") / txtRate.EditValue)
        Next
    End Sub

    Private Sub frmPayment_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        PaymentEditFlag = False
        PaymentID = Nothing
    End Sub

    Private Sub btnAttachment_Click(sender As Object, e As EventArgs) Handles btnAttachment.Click
        txtAttachment.EditValue = DevFunctions.GetFullPath_of_PDF()
    End Sub

    Private Sub btnSaveNclose_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSaveNclose.ItemClick
        If SaveData() = True Then
            Me.Close()
        End If
    End Sub
End Class