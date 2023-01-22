Imports DevExpress.XtraEditors
Imports GemAccounts.GENERAL_FUNCTIONS
Imports GemAccounts.BAL_COMPANY
Imports GemAccounts.GLOBAL_VARIABLES

Public Class FrmLedger
    Dim GF As New GENERAL_FUNCTIONS
    Dim LedgerID As Integer = 0
    Dim edf As Integer = 0
    Dim BL As New BAL_COMPANY
    Private Sub CmdSave_Click(sender As Object, e As EventArgs) Handles CmdSave.Click
        If validation() = False Then
            Exit Sub
        End If
        If edf = 0 Then
            If cmbdrcr.Text = "Dr" Then
                txtopening.Text = Val(txtopening.Text) * -1
            Else
                txtopening.Text = Val(txtopening.Text) * 1
            End If
            BL.LedgerCRUD(dg, 0, 0, 0, 0, 0, txtledger.Text, cmbgroup.SelectedValue, txtadd.Text, cmbcounty.Text, cmbstate.Text, cmbcity.Text, txtmobile.Text, txtphone.Text, txtemail.Text, txtgst.Text, txtpan.Text, txtbank.Text, txtacno.Text, txtifsc.Text, txtrouting.Text, txtswift.Text, txtopening.Text)
            XtraMessageBox.Show("Ledger has been Saved.", "GemAccounts", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            BL.LedgerCRUD(dg, 1, LedgerID, 0, 0, 0, txtledger.Text, cmbgroup.SelectedValue, txtadd.Text, cmbcounty.Text, cmbstate.Text, cmbcity.Text, txtmobile.Text, txtphone.Text, txtemail.Text, txtgst.Text, txtpan.Text, txtbank.Text, txtacno.Text, txtifsc.Text, txtrouting.Text, txtswift.Text, Val(txtopening.Text))
            XtraMessageBox.Show("Ledger has been updated.", "GemAccounts", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        cmdCancel_Click(sender, e)
    End Sub
    Private Sub FrmLedger_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmdCancel_Click(sender, e)
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        edf = 0
        LedgerID = 0
        txtledger.Text = ""
        cmbgroup.Text = ""
        txtadd.Text = ""
        cmbcounty.Text = ""
        cmbstate.Text = ""
        cmbcity.Text = ""
        txtmobile.Text = ""
        txtemail.Text = ""
        txtphone.Text = ""
        txtgst.Text = ""
        txtpan.Text = ""
        txtbank.Text = ""
        txtbranch.Text = ""
        txtacno.Text = ""
        txtifsc.Text = ""
        txtrouting.Text = ""
        txtswift.Text = ""
        txtopening.Text = ""
        cmbdrcr.Text = ""
        txtledger.Focus()
        BL.LedgerCRUD(dg, 3, 0, 0, 0, 0, "", 0, "", "", "", "", "", "", "", "", "", "", "", "", "", "", 0)
        GF.NFillCombo("select group_id,group_name from Dia_Group_Master", "group_id", "group_name", cmbgroup)
    End Sub

    Private Sub dg_KeyDown(sender As Object, e As KeyEventArgs) Handles dg.KeyDown
        If e.KeyCode = Keys.Delete Then
            If XtraMessageBox.Show("Do you want to delete this Ledger?", "GemAccounts", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                LedgerID = TryCast(dg.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("LedgerID")
                BL.LedgerCRUD(dg, 2, LedgerID, 0, 0, 0, "", 0, "", "", "", "", "", "", "", "", "", "", "", "", "", "", 0)
                XtraMessageBox.Show("Ledger has been deleted.", "GemAccounts", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                cmdCancel_Click(sender, e)
            Else
                Exit Sub
            End If
        End If

    End Sub

    Private Sub dg_DoubleClick(sender As Object, e As EventArgs) Handles dg.DoubleClick
        If XtraMessageBox.Show("Do you want to update this Ledger?", "GemAccounts", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            txtledger.Focus()
            edf = 1
            LedgerID = TryCast(dg.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("LedgerID")
            txtledger.Text = TryCast(dg.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("LedgerName")
            cmbgroup.SelectedValue = TryCast(dg.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("LUnderGroup")
            txtadd.Text = TryCast(dg.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("LAddress")
            cmbcounty.Text = TryCast(dg.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("LCountry")
            cmbstate.Text = TryCast(dg.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("LState")
            cmbcity.Text = TryCast(dg.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("LCity")
            txtmobile.Text = TryCast(dg.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("LMobile")
            txtphone.Text = TryCast(dg.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("LPhone")
            txtemail.Text = TryCast(dg.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("LEmail")
            txtgst.Text = TryCast(dg.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("LGSTIN")
            txtpan.Text = TryCast(dg.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("LPAN")
            txtbank.Text = TryCast(dg.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("LBank")
            txtbranch.Text = TryCast(dg.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("LBranch")
            txtacno.Text = TryCast(dg.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("LAcno")
            txtifsc.Text = TryCast(dg.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("LIFSC")
            txtrouting.Text = TryCast(dg.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("LRouting")
            txtswift.Text = TryCast(dg.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("LSwift")
            'txtopening.Text = TryCast(dg.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("LOpeningBalance")


            If (TryCast(dg.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("LOpeningBalance")) > 0 Then
                txtopening.Text = TryCast(dg.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("LOpeningBalance")
                cmbdrcr.Text = "Cr"
            Else
                txtopening.Text = -(TryCast(dg.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("LOpeningBalance"))
                cmbdrcr.Text = "Dr"
            End If
        Else

        End If
    End Sub

    Private Sub txtopening_TextChanged(sender As Object, e As EventArgs) Handles txtopening.TextChanged

    End Sub

    Private Sub txtopening_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtopening.KeyPress
        GF.AcceptNumer(sender, e)
    End Sub

    Private Sub txtledger_TextChanged(sender As Object, e As EventArgs) Handles txtledger.TextChanged

    End Sub

    Private Sub txtledger_KeyDown(sender As Object, e As KeyEventArgs) Handles txtledger.KeyDown, cmbgroup.KeyDown, txtadd.KeyDown, cmbcounty.KeyDown, cmbstate.KeyDown, cmbcity.KeyDown, txtmobile.KeyDown, txtphone.KeyDown, txtemail.KeyDown, txtgst.KeyDown, txtpan.KeyDown, txtbank.KeyDown, txtbranch.KeyDown, txtacno.KeyDown, txtifsc.KeyDown, txtrouting.KeyDown, txtswift.KeyDown, txtopening.KeyDown, cmbdrcr.KeyDown, CmdSave.KeyDown, cmdCancel.KeyDown
        GENERAL_FUNCTIONS.FocusNext(sender, e)
    End Sub
    Private Function validation() As Boolean
        If Len(Trim(txtledger.Text)) = 0 Then
            XtraMessageBox.Show("Please enter Ledger Name", "GemAccounts", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtledger.Focus()
            validation = False
            Exit Function
        End If

        If cmbgroup.SelectedValue = 0 Then
            XtraMessageBox.Show("Please select group", "GemAccounts", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmbgroup.Focus()
            validation = False
            Exit Function
        End If
        If Val(txtopening.Text) > 0 And cmbdrcr.SelectedIndex < 0 Then
            XtraMessageBox.Show("Select Debit or Credit Balance", "GemAccounts", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmbdrcr.Focus()
            validation = False
            Exit Function
        End If
        If edf = 0 Then
            If txtledger.Text = GENERAL_FUNCTIONS.NExcuteScaler("Select LedgerName from Dia_Ledger_Master Where LedgerName='" & txtledger.Text & "'") Then
                DevFunctions.ErrorMsg("Duplicate Ledger Found")
                validation = False
                txtledger.Focus()
                Exit Function
            End If
        Else
            If txtledger.Text = GENERAL_FUNCTIONS.NExcuteScaler("Select LedgerName from Dia_Ledger_Master Where LedgerName<>(Select LedgerName from Dia_Ledger_Master where LedgerID=" & LedgerID & ") and LedgerName='" & txtledger.Text & "'") Then
                DevFunctions.ErrorMsg("Duplicate Ledger Found")
                validation = False
                txtledger.Focus()
                Exit Function
            End If
        End If
        validation = True

        Return validation
    End Function

End Class