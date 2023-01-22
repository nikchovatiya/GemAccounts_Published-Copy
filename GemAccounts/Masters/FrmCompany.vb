Imports GemAccounts.GENERAL_FUNCTIONS
Imports GemAccounts.BAL_COMPANY
Imports DevExpress.XtraEditors

Public Class FrmCompany
    Dim GF As New GENERAL_FUNCTIONS
    Dim cmpid As Integer = 0
    Dim edf As Integer = 0
    Dim BL As New BAL_COMPANY
    Private Sub CmdSave_Click(sender As Object, e As EventArgs) Handles CmdSave.Click
        If edf = 0 Then
            BL.DIACRUD(DgCompany, 0, 0, txtcname.Text, txtadd.Text, cmbcounty.Text, cmbstate.Text, cmbcity.Text, txtmobile.Text, txtphone.Text, txtemail.Text, txtgst.Text, txtpan.Text, txtbank.Text, txtbank.Text, txtacno.Text, txtifc.Text, txtswift.Text, txtrouting.Text)
            XtraMessageBox.Show("Company has been Saved.", "GemAccounts", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            BL.DIACRUD(DgCompany, 1, cmpid, txtcname.Text, txtadd.Text, cmbcounty.Text, cmbstate.Text, cmbcity.Text, txtmobile.Text, txtphone.Text, txtemail.Text, txtgst.Text, txtpan.Text, txtbank.Text, txtbank.Text, txtacno.Text, txtifc.Text, txtswift.Text, txtrouting.Text)
            XtraMessageBox.Show("Company has been updated.", "GemAccounts", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        SimpleButton2_Click(sender, e)
    End Sub

    Private Sub FrmCompany_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SimpleButton2_Click(sender, e)
    End Sub
    Private Sub DgCompany_DoubleClick(sender As Object, e As EventArgs) Handles DgCompany.DoubleClick
        If XtraMessageBox.Show("Do you want to update Company?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            edf = 1
            cmpid = TryCast(DgCompany.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("cmp_id")
            txtcname.Text = TryCast(DgCompany.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("cmp_name")
            txtadd.Text = TryCast(DgCompany.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("cmp_address")
            cmbcounty.Text = TryCast(DgCompany.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("cmp_country")
            cmbstate.Text = TryCast(DgCompany.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("cmp_state")
            cmbcity.Text = TryCast(DgCompany.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("cmp_city")
            txtmobile.Text = TryCast(DgCompany.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("cmp_mobile")
            txtphone.Text = TryCast(DgCompany.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("cmp_phone")
            txtemail.Text = TryCast(DgCompany.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("cmp_email")
            txtgst.Text = TryCast(DgCompany.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("cmp_gst")
            txtpan.Text = TryCast(DgCompany.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("cmp_pan")
            txtbank.Text = TryCast(DgCompany.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("cmp_bank")
            txtbranch.Text = TryCast(DgCompany.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("cmp_branch")
            txtacno.Text = TryCast(DgCompany.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("cmp_acno")
            txtifc.Text = TryCast(DgCompany.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("cmp_ifc")
            txtswift.Text = TryCast(DgCompany.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("cmp_swift")
            txtrouting.Text = TryCast(DgCompany.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("cmp_routing")
        Else

        End If
    End Sub
    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        edf = 0
        cmpid = 0
        txtcname.Text = ""
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
        BL.DIACRUD(DgCompany, 3, 0, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "")
    End Sub

    Private Sub DgCompany_KeyDown(sender As Object, e As KeyEventArgs) Handles DgCompany.KeyDown
        If e.KeyCode = Keys.Delete Then
            If XtraMessageBox.Show("Do you want to delete this company?", "GemAccounts", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                cmpid = TryCast(DgCompany.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("cmp_id")
                BL.DIACRUD(DgCompany, 2, cmpid, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "")
                XtraMessageBox.Show("Company has been deleted.", "GemAccounts", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                SimpleButton2_Click(sender, e)
            Else
                Exit Sub
            End If
        Else

        End If
    End Sub
End Class