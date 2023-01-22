Imports GemAccounts.GENERAL_FUNCTIONS
Imports GemAccounts.BAL_COMPANY
Imports DevExpress.XtraEditors

Public Class FrmBranch
    Dim GF As New GENERAL_FUNCTIONS
    Dim br_id As Integer = 0
    Dim edf As Integer = 0
    Dim BL As New BAL_COMPANY
    Private Sub CmdSave_Click(sender As Object, e As EventArgs) Handles CmdSave.Click
        If edf = 0 Then
            BL.DIACRUDBRANCH(Dgbranch, 0, 0, cmbcompany.SelectedValue, txtbrname.Text, txtadd.Text, cmbcounty.Text, cmbstate.Text, cmbcity.Text, txtmobile.Text, txtphone.Text, txtemail.Text, txtgst.Text, txtpan.Text, txtbank.Text, txtbank.Text, txtacno.Text, txtifc.Text, txtswift.Text, txtrouting.Text)
            XtraMessageBox.Show("Branch has been saved.", "GemAccounts", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            BL.DIACRUDBRANCH(Dgbranch, 1, br_id, cmbcompany.SelectedValue, txtbrname.Text, txtadd.Text, cmbcounty.Text, cmbstate.Text, cmbcity.Text, txtmobile.Text, txtphone.Text, txtemail.Text, txtgst.Text, txtpan.Text, txtbank.Text, txtbank.Text, txtacno.Text, txtifc.Text, txtswift.Text, txtrouting.Text)
            XtraMessageBox.Show("Branch has been updated.", "GemAccounts", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

        btnCancel_click(sender, e)
    End Sub

    Private Sub FrmCompany_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        btnCancel_click(sender, e)
    End Sub
    Private Sub DgCompany_DoubleClick(sender As Object, e As EventArgs) Handles Dgbranch.DoubleClick
        If XtraMessageBox.Show("Do you want to update Branch?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            edf = 1
            br_id = TryCast(Dgbranch.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("br_id")
            txtbrname.Text = TryCast(Dgbranch.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("br_name")
            cmbcompany.SelectedValue = TryCast(Dgbranch.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("cmp_id")
            txtadd.Text = TryCast(Dgbranch.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("br_address")
            cmbcounty.Text = TryCast(Dgbranch.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("br_country")
            cmbstate.Text = TryCast(Dgbranch.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("br_state")
            cmbcity.Text = TryCast(Dgbranch.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("br_city")
            txtmobile.Text = TryCast(Dgbranch.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("br_mobile")
            txtphone.Text = TryCast(Dgbranch.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("br_phone")
            txtemail.Text = TryCast(Dgbranch.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("br_email")
            txtgst.Text = TryCast(Dgbranch.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("br_gst")
            txtpan.Text = TryCast(Dgbranch.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("br_pan")
            txtbank.Text = TryCast(Dgbranch.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("br_bank")
            txtbranch.Text = TryCast(Dgbranch.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("br_branch")
            txtacno.Text = TryCast(Dgbranch.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("br_acno")
            txtifc.Text = TryCast(Dgbranch.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("br_ifc")
            txtswift.Text = TryCast(Dgbranch.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("br_swift")
            txtrouting.Text = TryCast(Dgbranch.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("br_routing")
        Else

        End If
    End Sub
    Private Sub btnCancel_click(sender As Object, e As EventArgs) Handles btnCancel.Click
        edf = 0
        br_id = 0
        txtbrname.Text = ""
        cmbcompany.Text = ""
        txtadd.Text = ""
        cmbcounty.Text = ""
        cmbstate.Text = ""
        cmbcity.Text = ""
        txtmobile.Text = ""
        txtphone.Text = ""
        txtemail.Text = ""
        txtgst.Text = ""
        txtpan.Text = ""
        txtbank.Text = ""
        txtbranch.Text = ""
        txtacno.Text = ""
        txtifc.Text = ""
        txtswift.Text = ""
        txtrouting.Text = ""
        BL.DIACRUDBRANCH(Dgbranch, 3, 0, 0, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "")
        GF.NFillCombo("select cmp_id,cmp_name from Dia_Company_Master", "cmp_id", "cmp_name", cmbcompany)
    End Sub

    Private Sub DgCompany_KeyDown(sender As Object, e As KeyEventArgs) Handles Dgbranch.KeyDown
        If e.KeyCode = Keys.Delete Then
            If XtraMessageBox.Show("Do you want to delete this Branch?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                br_id = TryCast(Dgbranch.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("br_id")
                BL.DIACRUDBRANCH(Dgbranch, 2, br_id, 0, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "")
                XtraMessageBox.Show("Branch has been deleted.", "GemAccounts", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                btnCancel_click(sender, e)
            Else
                Exit Sub
            End If
        Else

        End If
    End Sub
End Class