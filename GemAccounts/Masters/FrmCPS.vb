Imports GemAccounts.GENERAL_FUNCTIONS
Imports GemAccounts.BAL_COMPANY
Imports GemAccounts.GLOBAL_VARIABLES
Imports DevExpress.XtraEditors
Imports System.ComponentModel
Public Class frmcps
    Dim GF As New GENERAL_FUNCTIONS
    Dim cutid As Integer = 0
    Dim polishid As Integer = 0
    Dim symmid As Integer = 0
    Dim edf As Integer = 0
    Dim BL As New BAL_COMPANY
    Private Sub frmcps_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btncancelcut_Click(sender, e)
        btncancelpolish_Click(sender, e)
        btncancelsymm_Click(sender, e)
    End Sub

    Private Sub btnsavecut_Click(sender As Object, e As EventArgs) Handles btnsavecut.Click
        If edf = 0 Then
            BL.DIACRUDCUT(dgcut, 0, cutid, txtcut.Text, txtcutdes.Text)
            XtraMessageBox.Show("Cut has been Saved.", "GemAccounts", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            BL.DIACRUDCUT(dgcut, 1, cutid, txtcut.Text, txtcutdes.Text)
            XtraMessageBox.Show("Cut has been Updated.", "GemAccounts", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        btncancelcut_Click(sender, e)
    End Sub

    Private Sub btncancelcut_Click(sender As Object, e As EventArgs) Handles btncancelcut.Click
        edf = 0
        cutid = 0
        txtcut.Text = ""
        txtcutdes.Text = ""
        BL.DIACRUDCUT(dgcut, 3, 0, "", "")
    End Sub
    Private Sub dgcut_KeyDown(sender As Object, e As KeyEventArgs) Handles dgcut.KeyDown
        If e.KeyCode = Keys.Delete Then
            If XtraMessageBox.Show("Do you want to delete this Cut?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                cutid = TryCast(dgcut.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("cut_id")
                BL.DIACRUDCUT(dgcut, 2, cutid, "", "")

                XtraMessageBox.Show("Cut has been deleted.", "GemAccounts", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                btncancelcut_Click(sender, e)
            Else
                Exit Sub
            End If
        Else

        End If
    End Sub
    Private Sub dgcut_DoubleClick(sender As Object, e As EventArgs) Handles dgcut.DoubleClick
        If XtraMessageBox.Show("Do you want to update Cut?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            edf = 1
            cutid = TryCast(dgcut.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("cut_id")
            txtcut.Text = TryCast(dgcut.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("cut_name")
            txtcutdes.Text = TryCast(dgcut.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("cut_desc")
        End If
    End Sub

    Private Sub btncancelpolish_Click(sender As Object, e As EventArgs) Handles btncancelpolish.Click
        edf = 0
        polishid = 0
        txtpolish.Text = ""
        txtpolishdes.Text = ""
        BL.DIACRUDPOLISH(dgpolish, 3, 0, "", "")
    End Sub

    Private Sub btnsavepolish_Click(sender As Object, e As EventArgs) Handles btnsavepolish.Click
        If edf = 0 Then
            BL.DIACRUDPOLISH(dgpolish, 0, polishid, txtpolish.Text, txtpolishdes.Text)
            XtraMessageBox.Show("Polish has been Saved.", "GemAccounts", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            BL.DIACRUDPOLISH(dgpolish, 1, polishid, txtpolish.Text, txtpolishdes.Text)
            XtraMessageBox.Show("Polish has been Updated.", "GemAccounts", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        btncancelpolish_Click(sender, e)
    End Sub

    Private Sub dgpolish_KeyDown(sender As Object, e As KeyEventArgs) Handles dgpolish.KeyDown
        If e.KeyCode = Keys.Delete Then
            If XtraMessageBox.Show("Do you want to delete this Polish?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                polishid = TryCast(dgpolish.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("polish_id")
                BL.DIACRUDPOLISH(dgpolish, 2, polishid, "", "")

                XtraMessageBox.Show("Polish has been deleted.", "GemAccounts", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                btncancelpolish_Click(sender, e)
            Else
                Exit Sub
            End If
        Else

        End If
    End Sub

    Private Sub dgpolish_DoubleClick(sender As Object, e As EventArgs) Handles dgpolish.DoubleClick
        If XtraMessageBox.Show("Do you want to update Polish?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            edf = 1
            polishid = TryCast(dgpolish.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("polish_id")
            txtpolish.Text = TryCast(dgpolish.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("polish_name")
            txtpolishdes.Text = TryCast(dgpolish.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("polish_desc")
        End If
    End Sub

    Private Sub btncancelsymm_Click(sender As Object, e As EventArgs) Handles btncancelsymm.Click
        edf = 0
        symmid = 0
        txtsymm.Text = ""
        txtsymmdes.Text = ""
        BL.DIACRUDsymm(dgsymm, 3, 0, "", "")
    End Sub

    Private Sub btnsavesymm_Click(sender As Object, e As EventArgs) Handles btnsavesymm.Click
        If edf = 0 Then
            BL.DIACRUDsymm(dgsymm, 0, symmid, txtsymm.Text, txtsymmdes.Text)
            XtraMessageBox.Show("Symmetry has been Saved.", "GemAccounts", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            BL.DIACRUDsymm(dgsymm, 1, symmid, txtsymm.Text, txtsymmdes.Text)
            XtraMessageBox.Show("Symmetry has been Updated.", "GemAccounts", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        btncancelsymm_Click(sender, e)
    End Sub

    Private Sub dgsymm_Click(sender As Object, e As EventArgs) Handles dgsymm.Click

    End Sub

    Private Sub dgsymm_KeyDown(sender As Object, e As KeyEventArgs) Handles dgsymm.KeyDown
        If e.KeyCode = Keys.Delete Then
            If XtraMessageBox.Show("Do you want to delete this Symmetry?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                symmid = TryCast(dgsymm.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("symm_id")
                BL.DIACRUDsymm(dgsymm, 2, symmid, "", "")

                XtraMessageBox.Show("Symmetry has been deleted.", "GemAccounts", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                btncancelsymm_Click(sender, e)
            Else
                Exit Sub
            End If
        Else

        End If
    End Sub

    Private Sub dgsymm_DoubleClick(sender As Object, e As EventArgs) Handles dgsymm.DoubleClick
        If XtraMessageBox.Show("Do you want to update Symmetry?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            edf = 1
            symmid = TryCast(dgsymm.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("symm_id")
            txtsymm.Text = TryCast(dgsymm.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("symm_name")
            txtsymmdes.Text = TryCast(dgsymm.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("symm_desc")
        End If
    End Sub
End Class