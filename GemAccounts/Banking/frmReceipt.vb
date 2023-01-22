Imports GemAccounts.GENERAL_FUNCTIONS
Imports GemAccounts.DevFunctions
Imports GemAccounts.GLOBAL_VARIABLES
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Base
Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class frmReceipt

    Public Shared ReceiptEditFlag As Boolean
    Public Shared ReceiptID As Integer
    Private c As EventArgs
    Private Sender As Object
    Private Sub frmReceipt_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        btnCancel_ItemClick(sender, q)
        If ReceiptEditFlag = True Then
            EditMode_FillData()
        End If
    End Sub
    Private Sub EditMode_FillData()
        Dim DT As DataTable = NFetchDatatable("SELECT R.* FROM Dia_Receipt_Master R WHERE ReceiptID=" & ReceiptID)
        If DT Is Nothing Then Return
        If DT.Rows.Count = 0 Then Return
        dtp.EditValue = DT.Rows(0).Item("ReceiptDate").ToString
        cmbBank.EditValue = DT.Rows(0).Item("Bank").ToString
        'cmbSetOffAgainst.EditValue = DT.Rows(0).Item("SalesMasterID").ToString
        txtPayUSD.EditValue = DT.Rows(0).Item("RecUSD").ToString
        txtRate.EditValue = DT.Rows(0).Item("ExRate").ToString
        txtPayINR.EditValue = DT.Rows(0).Item("RecINR").ToString
        cmbRecFrom.EditValue = DT.Rows(0).Item("Customer").ToString
        cmbRecFrom_EditValueChanged(Sender, c)

        cmbSetOffAgainst.EditValue = DT.Rows(0).Item("SalesMasterID").ToString

    End Sub

    Private Sub btnClose_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnClose.ItemClick
        Me.Close()
    End Sub

    Private Sub btnCancel_ItemClick(sender As Object, q As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCancel.ItemClick
        Fill_GridLookupEdit(cmbRecFrom)
        Nfill_Ledgers_by_Group_GridLookupEdit({"Bank", "Cash"}, "Dia_Ledger_Master", "LedgerName", "LedgerID", cmbBank)
        ClearAll()
        dtp.Focus()

    End Sub

    Private Sub Fill_GridLookupEdit(ctrl As DevExpress.XtraEditors.GridLookUpEdit)
        Dim dt As New DataTable
        Dim queryadd As String = ""
        Dim query As String = "SElECT distinct(L.LedgerID),l.LedgerName FROM Dia_SalesMaster s
 
left join dia_ledger_master L on l.ledgerid=s.ledgerid

where (S.LedgerID<>null or s.LedgerID<>0) and (l.LedgerID<>null or l.LedgerID<>0) and s.PaymentFlag=0 ORDER BY LedgerName"

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
        cmbRecFrom.EditValue = Nothing
        cmbSetOffAgainst.EditValue = Nothing
        txtPayUSD.Text = 0
        txtPayINR.EditValue = 0
        cmbSetOffAgainst.Properties.DataSource = Nothing
        txtRate.EditValue = GLOBAL_VARIABLES.ExRate
    End Sub

    Private Sub dtp_KeyDown(sender As Object, e As KeyEventArgs) Handles dtp.KeyDown, cmbBank.KeyDown, cmbRecFrom.KeyDown, cmbSetOffAgainst.KeyDown, txtPayUSD.KeyDown, txtRate.KeyDown, txtPayINR.KeyDown
        FocusNext(sender, e)
    End Sub

    'Private Sub txtPayUSD_KeyUp(sender As Object, e As KeyEventArgs) Handles txtPayUSD.KeyUp
    '    txtPayINR.EditValue = txtPayUSD.EditValue * txtRate.EditValue
    'End Sub

    'Private Sub txtRate_KeyUp(sender As Object, e As KeyEventArgs) Handles txtRate.KeyUp
    '    txtPayUSD_KeyUp(sender, e)
    'End Sub
    Private Sub txtPayINR_KeyUp(sender As Object, e As KeyEventArgs) Handles txtPayINR.KeyUp
        txtPayUSD.EditValue = txtPayINR.EditValue / txtRate.EditValue
    End Sub

    Private q As DevExpress.XtraBars.ItemClickEventArgs
    Private Function CheckValidation() As Boolean
        CheckValidation = True
        If cmbBank.EditValue = Nothing Then
            ErrorMsg("Select Bank or Cash")
            CheckValidation = False
            cmbBank.Focus()
            Exit Function
        End If
        If cmbRecFrom.EditValue = Nothing Then
            ErrorMsg("Select Pay To")
            CheckValidation = False
            cmbRecFrom.Focus()
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

    Private Sub cmbRecFrom_EditValueChanged(sender As Object, c As EventArgs) Handles cmbRecFrom.EditValueChanged
        If cmbRecFrom.EditValue = Nothing Then Return
        cmbSetOffAgainst.Properties.DataSource = Nothing
        If ReceiptEditFlag = True Then
            NFetchSearchLookupEdit("SELECT S.SaleDate AS SaleDate ,S.Qty as Pcs,S.Carats as Carats,S.SaleINR as SaleINR,S.SaleUSD as SaleUSD
,S.SalesMasterID as SaleID,SUM(REC.RecUSD) AS RecUSD,sum(REC.RecINR) as RecINR FROM Dia_SalesMaster S
LEFT JOIN (SELECT DISTINCT(ReceiptID),RecUSD,SalesMasterID,RecINR FROM Dia_Receipt_Master) REC ON REC.SalesMasterID=S.SalesMasterID
where  S.LedgerID=" & cmbRecFrom.EditValue & " group by S.SaleDate ,S.Qty ,S.Carats ,S.SaleINR ,S.SaleUSD ,S.SalesMasterID", cmbSetOffAgainst)
        Else
            NFetchSearchLookupEdit("SELECT S.SaleDate AS SaleDate ,S.Qty as Pcs,S.Carats as Carats,S.SaleINR as SaleINR,S.SaleUSD as SaleUSD
,S.SalesMasterID as SaleID,SUM(REC.RecUSD) AS RecUSD,sum(REC.RecINR) as RecINR FROM Dia_SalesMaster S
LEFT JOIN (SELECT DISTINCT(ReceiptID),RecUSD,SalesMasterID,RecINR FROM Dia_Receipt_Master) REC ON REC.SalesMasterID=S.SalesMasterID
where S.PaymentFlag=0 and S.LedgerID=" & cmbRecFrom.EditValue & " group by S.SaleDate ,S.Qty ,S.Carats ,S.SaleINR ,S.SaleUSD ,S.SalesMasterID", cmbSetOffAgainst)
        End If

        cmbSetOffAgainst.Properties.DisplayMember = "SaleID"
        cmbSetOffAgainst.Properties.ValueMember = "SaleID"
    End Sub

    Private Sub btnSave_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSave.ItemClick
        If SaveData() = True Then
            btnCancel_ItemClick(sender, q)
            ReceiptEditFlag = False
            InfoMsg("Receipt has been saved successfully")
        End If
    End Sub
    Private Function SaveData() As Boolean
        If cmbBank.EditValue = Nothing Then
            DevFunctions.ErrorMsg("Select Bank or Cash")
            cmbBank.Focus()
            SaveData = False
            Exit Function
        ElseIf cmbRecFrom.EditValue = Nothing Then
            DevFunctions.ErrorMsg("Select Party")
            cmbRecFrom.Focus()
            SaveData = False
            Exit Function
        ElseIf cmbSetOffAgainst.EditValue = Nothing Then
            DevFunctions.ErrorMsg("Select Invoice")
            cmbSetOffAgainst.Focus()
            SaveData = False
            Exit Function
        ElseIf txtPayINR.EditValue = Nothing Or txtPayINR.EditValue = 0 Then
            DevFunctions.ErrorMsg("Please Enter Amount")
            txtPayINR.Focus()
            SaveData = False
            Exit Function
        ElseIf txtPayINR.EditValue > GENERAL_FUNCTIONS.NExcuteScaler("SELECT (S.SaleINR - ISNULL(SUM(R.RecINR),0)) AS PendingINR  FROM Dia_SalesMaster S 
LEFT JOIN Dia_Receipt_Master R ON R.SalesMasterID=S.SalesMasterID
WHERE S.SalesMasterID=" & cmbSetOffAgainst.EditValue & " GROUP BY S.SaleINR") Then
            DevFunctions.ErrorMsg("Amount is Greater than Pending Amount")
            txtPayINR.Focus()
            SaveData = False
            Exit Function
        End If


        Dim MaxNo As Integer = GENERAL_FUNCTIONS.MaxNo("SELECT MAX(ReceiptID) FROM Dia_Receipt_Master")

        If ReceiptEditFlag = False Then
        Else
            NExcuteQuery("DELETE from Dia_Receipt_Master where ReceiptID=" & ReceiptID)
            NExcuteQuery("UPDATE Dia_SalesMaster SET PaymentFlag=0 WHERE SalesMasterID=" & cmbSetOffAgainst.EditValue)
        End If

        BAL_Transactions.ReceiptCRUD(New DevExpress.XtraGrid.GridControl, 0, MaxNo, dtp.EditValue, cmbBank.EditValue, cmbRecFrom.EditValue, cmbSetOffAgainst.EditValue, txtPayUSD.EditValue, (txtPayINR.EditValue / txtPayUSD.EditValue), txtPayINR.EditValue)

        Dim InvoiceUSD As Double = Double.Parse(NExcuteScaler("SELECT SaleUSD from Dia_SalesMaster where SalesMasterID=" & cmbSetOffAgainst.EditValue & ""))
        Dim InvoiceINR As Double = Double.Parse(NExcuteScaler("SELECT SaleINR from Dia_SalesMaster where SalesMasterID=" & cmbSetOffAgainst.EditValue & ""))
        Dim RecUSD As Double = Double.Parse(NExcuteScaler(" SELECT isnull(SUM(R.RecUSD),0) AS RecUSD FROM (SELECT DISTINCT(ReceiptID),RecUSD,SalesMasterID FROM Dia_Receipt_Master) R WHERE SalesMasterID=" & cmbSetOffAgainst.EditValue & ""))
        Dim RecINR As Double = Double.Parse(NExcuteScaler(" SELECT isnull(SUM(R.RecINR),0) AS RecINR FROM (SELECT DISTINCT(ReceiptID),RecINR,SalesMasterID FROM Dia_Receipt_Master) R WHERE SalesMasterID=" & cmbSetOffAgainst.EditValue & ""))
        If Val(Format(InvoiceUSD, "0.00")) = Val(Format(RecUSD, "0.00")) Or Val(Format(RecINR, "0.00")) = Val(Format(InvoiceINR, "0.00")) Then
            Dim TotalINR As Double = Double.Parse(NExcuteScaler("SELECT isnull(SUM(r.RecINR),0) AS TotalINR FROM (SELECT DISTINCT(ReceiptID),RecINR,SalesMasterID  FROM Dia_Receipt_Master)r WHERE r.SalesMasterID=" & cmbSetOffAgainst.EditValue))
            NExcuteQuery("UPDATE Dia_SalesMaster SET PaymentFlag=1 WHERE SalesMasterID =" & cmbSetOffAgainst.EditValue)
        End If
        SaveData = True
        Return SaveData
    End Function

    Private Sub frmReceipt_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        ReceiptEditFlag = False
        ReceiptID = Nothing
    End Sub

    Private Sub cmbSetOffAgainst_EditValueChanged(sender As Object, e As EventArgs) Handles cmbSetOffAgainst.EditValueChanged
        If ReceiptEditFlag = False Then
            If cmbSetOffAgainst.EditValue = Nothing Then Return

            Dim InvoiceUSD As Double = Double.Parse(NExcuteScaler("SELECT SaleUSD from Dia_SalesMaster where SalesMasterID=" & cmbSetOffAgainst.EditValue & ""))
            Dim InvoiceINR As Double = Double.Parse(NExcuteScaler("SELECT SaleINR from Dia_SalesMaster where SalesMasterID=" & cmbSetOffAgainst.EditValue & ""))
            Dim RecUSD As Double = Double.Parse(NExcuteScaler(" SELECT isnull(SUM(R.RecUSD),0) AS RecUSD FROM (SELECT DISTINCT(ReceiptID),RecUSD,SalesMasterID FROM Dia_Receipt_Master) R WHERE SalesMasterID=" & cmbSetOffAgainst.EditValue & ""))
            Dim RecINR As Double = Double.Parse(NExcuteScaler(" SELECT isnull(SUM(R.RecINR),0) AS RecINR FROM (SELECT DISTINCT(ReceiptID),RecINR,SalesMasterID FROM Dia_Receipt_Master) R WHERE SalesMasterID=" & cmbSetOffAgainst.EditValue & ""))

            Dim dr As DataRow = NFetchDataRow("Select * from Dia_SalesMaster Where SalesMasterID=" & cmbSetOffAgainst.EditValue)
            If dr Is Nothing Then Return
            txtRate.EditValue = dr("ExRate").ToString
            txtPayUSD.EditValue = InvoiceUSD - RecUSD
            txtPayINR.EditValue = InvoiceINR - RecINR
        End If
    End Sub
End Class