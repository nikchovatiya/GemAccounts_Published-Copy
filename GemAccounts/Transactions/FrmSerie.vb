Imports DevExpress.XtraEditors
Imports GemAccounts.GENERAL_FUNCTIONS
Imports GemAccounts.BAL_Transactions

Public Class FrmSerie
    Dim tmpdt As New DataTable
    Dim GF As New GENERAL_FUNCTIONS
    Dim BL As New BAL_Transactions
    Dim EditFlag As Integer
    Dim SerieID As Integer = 0
    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If validation() = False Then
            Exit Sub
        End If
        Dim dupCheck As Integer = 0
        If EditFlag = 0 Then
            dupCheck = GENERAL_FUNCTIONS.NExcuteScalerInt("Select Count(SerieName) from Dia_Serie where SerieName='" & txtSerieName.Text & "'")
            If dupCheck > 0 Then
                DevFunctions.ErrorMsg("Serie name duplicate")
                txtSerieName.Focus()
                Exit Sub
            End If
            BL.SerieCRUD(dg, 0, 0, cmbPurchaseID.SelectedValue, 0, 0, 0, txtSerieName.Text, txtPcs.Text, txtCts.Text, txtRemarks.Text, txtUSDperCts.Text, txtTotalUSD.Text)
            XtraMessageBox.Show("Serie has been Saved.", "GemAccounts", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            dupCheck = GENERAL_FUNCTIONS.NExcuteScalerInt("Select Count(SerieName) from Dia_Serie where SerieName='" & txtSerieName.Text & "' and SerieID<>" & SerieID)
            If dupCheck > 0 Then
                DevFunctions.ErrorMsg("Serie name duplicate")
                txtSerieName.Focus()
                Exit Sub
            End If
            BL.SerieCRUD(dg, 1, SerieID, cmbPurchaseID.SelectedValue, 0, 0, 0, txtSerieName.Text, txtPcs.Text, txtCts.Text, txtRemarks.Text, txtUSDperCts.Text, txtTotalUSD.Text)

            XtraMessageBox.Show("Serie has been updated.", "GemAccounts", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        Dim SeriePurchasePcs As Integer = GENERAL_FUNCTIONS.NExcuteScaler("Select  isnull(SUM(pcs),0) from Dia_Serie where PurchaseID=" & cmbPurchaseID.SelectedValue & " ")
        Dim SeriePurchaseCarats As Double = GENERAL_FUNCTIONS.NExcuteScaler("Select  isnull(SUM(Carats),0) from Dia_Serie where PurchaseID=" & cmbPurchaseID.SelectedValue & " ")
        If SeriePurchasePcs = Val(txtTotalPcs.Text) And SeriePurchaseCarats = Val(txtTotalCts.Text) Then
            GENERAL_FUNCTIONS.NExcuteQuery("Update Dia_Purchase set SerieStatus=0 where PurchaseID=" & cmbPurchaseID.SelectedValue & "")
        Else
            GENERAL_FUNCTIONS.NExcuteQuery("Update Dia_Purchase set SerieStatus=1 where PurchaseID=" & cmbPurchaseID.SelectedValue & "")
        End If
        Cancel()
    End Sub

    Private Sub FrmPurchase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cancel()
    End Sub

    Private Sub Cancel() Handles btnCancel.Click
        EditFlag = 0
        cmbPurchaseID.Enabled = True
        txtPcs.Enabled = True
        txtCts.Enabled = True
        txtUSDperCts.Enabled = True
        txtTotalUSD.Enabled = True
        GF.NFillCombo("select PurchaseID ,L.LedgerName FROM Dia_Purchase P LEFT JOIN Dia_Transcation D ON D.TranscationID=P.TID LEFT JOIN Dia_Ledger_Master L ON L.LedgerID=D.CreditLedger WHERE SerieStatus=1", "PurchaseID", "LedgerName", cmbPurchaseID)
        txtSerieName.Text = ""
        txtPcs.Text = ""
        txtCts.Text = ""
        txtUSDperCts.Text = ""
        txtTotalUSD.Text = ""
        txtRemarks.Text = ""
        txtTotalPcs.Text = ""
        txtTotalCts.Text = ""
        txtTotalPurchaseUSD.Text = ""
        txtSoldPcs.Text = ""
        txtSoldCts.Text = ""
        txtSoldUSD.Text = ""
        cmbPurchaseID.Focus()
        cmbPurchaseID.Text = ""
        BL.SerieCRUD(dg, 3, 0, 0, 0, 0, 0, "", 0, 0, "", 0, 0)
    End Sub

    Private Sub txtPcs_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCts.KeyPress, txtUSDperCts.KeyPress, txtTotalUSD.KeyPress, txtPcs.KeyPress
        GF.AcceptNumer(sender, e)
    End Sub


    Private Sub txtPcs_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSerieName.KeyDown, cmbPurchaseID.KeyDown, txtPcs.KeyDown, txtCts.KeyDown, txtUSDperCts.KeyDown, txtRemarks.KeyDown, txtTotalUSD.KeyDown
        GENERAL_FUNCTIONS.FocusNext(sender, e)
    End Sub
    Private Function validation() As Boolean
        If cmbPurchaseID.SelectedValue = 0 Then
            DevFunctions.ErrorMsg("Please select Purchase")
            cmbPurchaseID.Focus()
            validation = False
            Exit Function

        ElseIf Len(Trim(txtSerieName.Text)) = 0 Then
            DevFunctions.ErrorMsg("Please enter Serie Name")
            txtSerieName.Focus()
            validation = False
            Exit Function
        ElseIf Len(Trim(txtPcs.Text)) = 0 Then
            DevFunctions.ErrorMsg("Please enter Pieces")
            txtPcs.Focus()
            validation = False
            Exit Function
        ElseIf Len(Trim(txtCts.Text)) = 0 Then
            DevFunctions.ErrorMsg("Please enter Carats")
            txtCts.Focus()
            validation = False
            Exit Function
        ElseIf Len(Trim(txtUSDperCts.Text)) = 0 Then
            DevFunctions.ErrorMsg("Please enter USD Per Carat")
            txtUSDperCts.Focus()
            validation = False
            Exit Function
        ElseIf Len(Trim(txtTotalUSD.Text)) = 0 Then
            DevFunctions.ErrorMsg("Please enter Total USD")
            txtCts.Focus()
            validation = False
            Exit Function
        End If

        If Len(Trim(txtCts.Text)) = 0 Then
            txtCts.Text = 0
        End If
        If Len(Trim(txtPcs.Text)) = 0 Then
            txtPcs.Text = 0
        End If
        If Len(Trim(txtUSDperCts.Text)) = 0 Then
            txtUSDperCts.Text = 0
        End If
        If Len(Trim(txtTotalUSD.Text)) = 0 Then
            txtTotalUSD.Text = 0
        End If
        validation = True
        Return validation
    End Function
    Private Sub cmbPurchaseID_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbPurchaseID.SelectionChangeCommitted
        ' Dim pcs As Integer = GF.NFetchDataN("select pcs from Dia_Purchase where PurchaseID='" & cmbPurchaseID.SelectedValue & "'")
        '  Dim ConsumedPcs As Integer = GF.NFetchDataN("select SUM(pcs) from Dia_Serie where PurchaseID='" & cmbPurchaseID.SelectedValue & "'")
        ' Dim carats As Double = Format(GF.NFetchDataN("select Carats from Dia_Purchase where PurchaseID='" & cmbPurchaseID.SelectedValue & "'"), "0.00")
        ' Dim Consumedcarats As Double = Format(GF.NFetchDataN("select SUM(Carats) from Dia_Serie where PurchaseID='" & cmbPurchaseID.SelectedValue & "'"), "0.00")
        '  Dim TotUSD As Double = Format(GF.NFetchDataN("select NetUSD from Dia_Purchase where PurchaseID='" & cmbPurchaseID.SelectedValue & "'"), "0.00")
        ' Dim ConsumedTotUSD As Double = Format(GF.NFetchDataN("select SUM(TotalUSD) from Dia_Serie where PurchaseID='" & cmbPurchaseID.SelectedValue & "'"), "0.00")
        If cmbPurchaseID.SelectedValue = 0 Then Return
        Dim drpur As DataRow = GENERAL_FUNCTIONS.NFetchDataRow("select P.Pcs,P.Carats,T.AmountUSD as NetUSD from Dia_Purchase P left join Dia_Transcation T on P.TID=T.TranscationID where PurchaseID='" & cmbPurchaseID.SelectedValue & "'")
        Dim drkapan As DataRow = GENERAL_FUNCTIONS.NFetchDataRow("select isnull(SUM(pcs),0) as pcs,isnull(SUM(Carats),0) as carats,isnull(SUM(TotalUSD),0) as totusd from Dia_Serie where PurchaseID='" & cmbPurchaseID.SelectedValue & "'")
        txtTotalPcs.Text = drpur("Pcs")
        txtTotalCts.Text = Format(drpur("Carats"), "0.00")
        txtTotalPurchaseUSD.Text = Format(drpur("NetUSD"), "0.00")
        txtPcsPending.Text = drpur("Pcs") - Val(drkapan("pcs"))
        txtCtsPending.Text = Format(drpur("Carats") - drkapan("carats"), "0.00")
        txtUSDPending.Text = Format(drpur("NetUSD") - drkapan("totusd"), "0.00")
    End Sub

    Private Sub txtTotalUSD_KeyUp(sender As Object, e As KeyEventArgs) Handles txtTotalUSD.KeyUp
        txtUSDperCts.Text = Val(txtTotalUSD.Text) / Val(txtCts.Text)
        If EditFlag = 0 Then
            If Val(txtTotalUSD.Text) > Val(txtUSDPending.Text) Then
                XtraMessageBox.Show("USD must be less than Pending USD", "GemAccounts", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtTotalUSD.Text = ""
            End If
        Else
            If Val(txtTotalUSD.Text) + Val(txtSoldUSD.Text) > Val(txtTotalPurchaseUSD.Text) Then
                XtraMessageBox.Show("USD must be less than Pending USD", "GemAccounts", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtCts.Text = ""
            End If
        End If

    End Sub

    Private Sub txtUSDperCts_KeyUp(sender As Object, e As KeyEventArgs) Handles txtUSDperCts.KeyUp
        txtTotalUSD.Text = Val(txtUSDperCts.Text) * Val(txtCts.Text)
    End Sub

    Private Sub txtPcs_KeyUp(sender As Object, e As KeyEventArgs) Handles txtPcs.KeyUp

        If EditFlag = 0 Then
            If Val(txtPcs.Text) > Val(txtPcsPending.Text) Then
                XtraMessageBox.Show("Pcs must be less than Pending Pcs", "GemAccounts", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtPcs.Text = ""
            End If
        Else
            If Val(txtPcs.Text) + Val(txtSoldPcs.Text) > Val(txtTotalPcs.Text) Then
                XtraMessageBox.Show("Pcs must be less than Pending Pcs", "GemAccounts", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtPcs.Text = ""
            End If
        End If
    End Sub

    Private Sub txtCts_KeyUp(sender As Object, e As KeyEventArgs) Handles txtCts.KeyUp
        If EditFlag = 0 Then
            If Val(txtCts.Text) > Val(txtCtsPending.Text) Then
                XtraMessageBox.Show("Carats must be less than Pending Carats", "GemAccounts", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtCts.Text = ""
            End If
        Else
            If Val(txtCts.Text) + Val(txtSoldCts.Text) > Val(txtTotalCts.Text) Then
                XtraMessageBox.Show("Carats must be less than Pending Carats", "GemAccounts", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtCts.Text = ""
            End If
        End If
    End Sub

    Private Sub EditMenu_Click(sender As Object, e As EventArgs) Handles EditMenu.Click
        EditFlag = 1
        Dim tmp As Integer = GENERAL_FUNCTIONS.NExcuteScalerInt("Select Count(SerieID) From Dia_Main_Packet_Master where SerieID=" & view.GetFocusedRowCellValue("SerieID"))
        If tmp > 0 Then
            cmbPurchaseID.Enabled = False
            txtPcs.Enabled = False
            txtCts.Enabled = False
            txtUSDperCts.Enabled = False
            txtTotalUSD.Enabled = False
        End If
        SerieID = view.GetFocusedRowCellValue("SerieID")
        GF.NFillCombo("select PurchaseID ,L.LedgerName FROM Dia_Purchase P LEFT JOIN Dia_Transcation D ON D.TranscationID=P.TID LEFT JOIN Dia_Ledger_Master L ON L.LedgerID=D.CreditLedger WHERE PurchaseID=" & view.GetFocusedRowCellValue("PurchaseID") & "", "PurchaseID", "LedgerName", cmbPurchaseID)
        cmbPurchaseID.SelectedValue = view.GetFocusedRowCellValue("PurchaseID")
        txtSerieName.Text = view.GetFocusedRowCellValue("SerieName")
        txtPcs.Text = view.GetFocusedRowCellValue("Pcs")
        txtCts.Text = view.GetFocusedRowCellValue("Carats")
        txtUSDperCts.Text = view.GetFocusedRowCellValue("USDPerCarat")
        txtTotalUSD.Text = view.GetFocusedRowCellValue("TotalUSD")
        txtRemarks.Text = view.GetFocusedRowCellValue("Remarks")
        txtSoldPcs.Text = GENERAL_FUNCTIONS.NExcuteScalerInt("Select isnull(SUM(pcs),0) from Dia_Serie where PurchaseID=" & cmbPurchaseID.SelectedValue & " and SerieID<>" & SerieID & "")
        txtSoldCts.Text = GENERAL_FUNCTIONS.NExcuteScaler("Select isnull(SUM(Carats),0) from Dia_Serie where PurchaseID=" & cmbPurchaseID.SelectedValue & " and SerieID<>" & SerieID & "")
        txtSoldUSD.Text = GENERAL_FUNCTIONS.NExcuteScaler("Select isnull(SUM(TotalUSD),0) from Dia_Serie where PurchaseID=" & cmbPurchaseID.SelectedValue & " and SerieID<>" & SerieID & "")
        'txtSoldCts.Text = GF.NExcuteScalerInt("Select sum(Carats) from Dia_Serie where PurchaseID=" & cmbPurchaseID.SelectedValue & " and SerieID<>" & SerieID & "")
        cmbPurchaseID_SelectionChangeCommitted(sender, e)
    End Sub

    Private Sub DeleteMenu_Click(sender As Object, e As EventArgs) Handles DeleteMenu.Click
        If XtraMessageBox.Show("Do you want to delete this Serie?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            SerieID = TryCast(dg.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("SerieID")
            Dim tmp As Integer = GENERAL_FUNCTIONS.NExcuteScalerInt("Select Count(SerieID) from Dia_Main_Packet_Master Where SerieID=" & SerieID)
            If tmp > 0 Then
                DevFunctions.ErrorMsg("You cannot delete this Serie")
            Else
                BL.SerieCRUD(dg, 2, SerieID, 0, 0, 0, 0, "", 0, 0, "", 0, 0)
                DevFunctions.ErrorMsg("Serie has been delete.")
                Cancel()
            End If
        Else
            Exit Sub
        End If
    End Sub


End Class