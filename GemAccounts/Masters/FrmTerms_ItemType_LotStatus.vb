Imports GemAccounts.GENERAL_FUNCTIONS
Imports GemAccounts.BAL_COMPANY
Imports GemAccounts.GLOBAL_VARIABLES
Imports DevExpress.XtraEditors
Imports System.ComponentModel
Public Class FrmTerms_ItemType_LotStatus
    Dim GF As New GENERAL_FUNCTIONS
    Dim termsid As Integer = 0
    Dim itemtypeid As Integer = 0
    Dim lotstatusid As Integer = 0
    Dim edf As Integer = 0
    Dim BL As New BAL_COMPANY
    Private Sub FrmTerms_ItemType_LotStatus_load(sender As Object, e As EventArgs) Handles MyBase.Load
        btncancelterms_Click(sender, e)
        btncancelitem_type_Click(sender, e)
        btncancellot_status_Click(sender, e)
    End Sub

    Private Sub btnsaveterms_Click(sender As Object, e As EventArgs) Handles btnsaveterms.Click
        If edf = 0 Then
            BL.DIACRUDTERMS(dgterms, 0, termsid, txtterms.Text, txttermsdes.Text)
            XtraMessageBox.Show("Terms has been Saved.", "GemAccounts", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            BL.DIACRUDTERMS(dgterms, 1, termsid, txtterms.Text, txttermsdes.Text)
            XtraMessageBox.Show("Terms has been Updated.", "GemAccounts", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        btncancelterms_Click(sender, e)
    End Sub

    Private Sub btncancelterms_Click(sender As Object, e As EventArgs) Handles btncancelterms.Click
        edf = 0
        termsid = 0
        txtterms.Text = ""
        txttermsdes.Text = ""
        BL.DIACRUDTERMS(dgterms, 3, 0, "", "")
    End Sub
    Private Sub dgterms_KeyDown(sender As Object, e As KeyEventArgs) Handles dgterms.KeyDown
        If e.KeyCode = Keys.Delete Then
            If XtraMessageBox.Show("Do you want to delete this Terms?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                termsid = TryCast(dgterms.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("terms_id")
                BL.DIACRUDTERMS(dgterms, 2, termsid, "", "")

                XtraMessageBox.Show("Terms has been deleted.", "GemAccounts", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                btncancelterms_Click(sender, e)
            Else
                Exit Sub
            End If
        Else

        End If
    End Sub
    Private Sub dgterms_DoubleClick(sender As Object, e As EventArgs) Handles dgterms.DoubleClick
        If XtraMessageBox.Show("Do you want to update Terms?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            edf = 1
            termsid = TryCast(dgterms.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("terms_id")
            txtterms.Text = TryCast(dgterms.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("terms_name")
            txttermsdes.Text = TryCast(dgterms.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("terms_desc")
        End If
    End Sub

    Private Sub btncancelitem_type_Click(sender As Object, e As EventArgs) Handles btncancelitemtype.Click
        edf = 0
        itemtypeid = 0
        txtitemtype.Text = ""
        txtitemdes.Text = ""
        BL.DIACRUDitem_type(dgitemtype, 3, 0, "", "")
    End Sub

    Private Sub btnsaveitem_type_Click(sender As Object, e As EventArgs) Handles btnsaveitemtype.Click
        If edf = 0 Then
            BL.DIACRUDitem_type(dgitemtype, 0, itemtypeid, txtitemtype.Text, txtitemdes.Text)
            XtraMessageBox.Show("Item Type has been Saved.", "GemAccounts", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            BL.DIACRUDitem_type(dgitemtype, 1, itemtypeid, txtitemtype.Text, txtitemdes.Text)
            XtraMessageBox.Show("Item Type has been Updated.", "GemAccounts", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        btncancelitem_type_Click(sender, e)
    End Sub

    Private Sub dgitem_type_KeyDown(sender As Object, e As KeyEventArgs) Handles dgitemtype.KeyDown
        If e.KeyCode = Keys.Delete Then
            If XtraMessageBox.Show("Do you want to delete this Item Type?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                itemtypeid = TryCast(dgitemtype.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("item_type_id")
                BL.DIACRUDitem_type(dgitemtype, 2, itemtypeid, "", "")

                XtraMessageBox.Show("Item Type has been deleted.", "GemAccounts", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                btncancelitem_type_Click(sender, e)
            Else
                Exit Sub
            End If
        Else

        End If
    End Sub

    Private Sub dgitem_type_DoubleClick(sender As Object, e As EventArgs) Handles dgitemtype.DoubleClick
        If XtraMessageBox.Show("Do you want to update Item Type?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            edf = 1
            itemtypeid = TryCast(dgitemtype.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("item_type_id")
            txtitemtype.Text = TryCast(dgitemtype.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("item_type_name")
            txtitemdes.Text = TryCast(dgitemtype.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("item_type_desc")
        End If
    End Sub

    Private Sub btncancellot_status_Click(sender As Object, e As EventArgs) Handles btncancellotstatus.Click
        edf = 0
        lotstatusid = 0
        txtlotstatus.Text = ""
        txtlotstatusdes.Text = ""
        BL.DIACRUDlot_status(dglotstatus, 3, 0, "", "")
    End Sub

    Private Sub btnsavelot_status_Click(sender As Object, e As EventArgs) Handles btnsavelotstatus.Click
        If edf = 0 Then
            BL.DIACRUDlot_status(dglotstatus, 0, lotstatusid, txtlotstatus.Text, txtlotstatusdes.Text)
            XtraMessageBox.Show("Lot Stauts has been Saved.", "GemAccounts", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            BL.DIACRUDlot_status(dglotstatus, 1, lotstatusid, txtlotstatus.Text, txtlotstatusdes.Text)
            XtraMessageBox.Show("Lot Stauts has been Updated.", "GemAccounts", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        btncancellot_status_Click(sender, e)
    End Sub

    Private Sub dglot_status_Click(sender As Object, e As EventArgs) Handles dglotstatus.Click

    End Sub

    Private Sub dglot_status_KeyDown(sender As Object, e As KeyEventArgs) Handles dglotstatus.KeyDown
        If e.KeyCode = Keys.Delete Then
            If XtraMessageBox.Show("Do you want to delete this Lot Stauts?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                lotstatusid = TryCast(dglotstatus.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("lot_status_id")
                BL.DIACRUDlot_status(dglotstatus, 2, lotstatusid, "", "")

                XtraMessageBox.Show("Lot Stauts has been deleted.", "GemAccounts", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                btncancellot_status_Click(sender, e)
            Else
                Exit Sub
            End If
        Else

        End If
    End Sub

    Private Sub dglot_status_DoubleClick(sender As Object, e As EventArgs) Handles dglotstatus.DoubleClick
        If XtraMessageBox.Show("Do you want to update Lot Stauts?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            edf = 1
            lotstatusid = TryCast(dglotstatus.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("lot_status_id")
            txtlotstatus.Text = TryCast(dglotstatus.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("lot_status_name")
            txtlotstatusdes.Text = TryCast(dglotstatus.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("lot_status_desc")
        End If
    End Sub
End Class