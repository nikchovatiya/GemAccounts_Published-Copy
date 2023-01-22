Imports GemAccounts.GENERAL_FUNCTIONS
Imports GemAccounts.BAL_COMPANY
Imports GemAccounts.GLOBAL_VARIABLES
Imports DevExpress.XtraEditors
Imports System.ComponentModel
Public Class frmflolab
    Dim GF As New GENERAL_FUNCTIONS
    Dim floid As Integer = 0
    Dim labid As Integer = 0
    Dim edf As Integer = 0
    Dim BL As New BAL_COMPANY
    Private Sub btncancelflo_Click(sender As Object, e As EventArgs) Handles btncancelflo.Click
        edf = 0
        floid = 0
        txtflo.Text = ""
        txtflodes.Text = ""
        BL.DIACRUDflo(dgflo, 3, 0, "", "")
    End Sub

    Private Sub btncancellab_Click(sender As Object, e As EventArgs) Handles btncancellab.Click
        edf = 0
        labid = 0
        txtlab.Text = ""
        txtlabdes.Text = ""
        BL.DIACRUDlab(dglab, 3, 0, "", "")
    End Sub

    Private Sub frmflolab_Load(sender As Object, e As EventArgs) Handles Me.Load
        btncancellab_Click(sender, e)
        btncancelflo_Click(sender, e)
    End Sub

    Private Sub btnsaveflo_Click(sender As Object, e As EventArgs) Handles btnsaveflo.Click
        If edf = 0 Then
            BL.DIACRUDflo(dgflo, 0, floid, txtflo.Text, txtflodes.Text)
            XtraMessageBox.Show("Flourescense has been Saved.", "GemAccounts", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            BL.DIACRUDflo(dgflo, 1, floid, txtflo.Text, txtflodes.Text)
            XtraMessageBox.Show("Flourescense has been Updated.", "GemAccounts", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        btncancelflo_Click(sender, e)
    End Sub

    Private Sub btnsavelab_Click(sender As Object, e As EventArgs) Handles btnsavelab.Click
        If edf = 0 Then
            BL.DIACRUDlab(dglab, 0, labid, txtlab.Text, txtlabdes.Text)
            XtraMessageBox.Show("Lab has been Saved.", "GemAccounts", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            BL.DIACRUDlab(dglab, 1, labid, txtlab.Text, txtlabdes.Text)
            XtraMessageBox.Show("Lab has been Updated.", "GemAccounts", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        btncancellab_Click(sender, e)
    End Sub

    Private Sub dgflo_Click(sender As Object, e As EventArgs) Handles dgflo.Click

    End Sub

    Private Sub dgflo_KeyDown(sender As Object, e As KeyEventArgs) Handles dgflo.KeyDown
        If e.KeyCode = Keys.Delete Then
            If XtraMessageBox.Show("Do you want to delete this Flourescense?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                floid = TryCast(dgflo.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("flo_id")
                BL.DIACRUDflo(dgflo, 2, floid, "", "")

                XtraMessageBox.Show("Flourescense has been deleted.", "GemAccounts", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                btncancelflo_Click(sender, e)
            Else
                Exit Sub
            End If
        Else

        End If
    End Sub

    Private Sub dglab_KeyDown(sender As Object, e As KeyEventArgs) Handles dglab.KeyDown
        If e.KeyCode = Keys.Delete Then
            If XtraMessageBox.Show("Do you want to delete this Lab?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                labid = TryCast(dglab.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("lab_id")
                BL.DIACRUDlab(dglab, 2, labid, "", "")

                XtraMessageBox.Show("Lab has been deleted.", "GemAccounts", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                btncancellab_Click(sender, e)
            Else
                Exit Sub
            End If
        Else

        End If
    End Sub

    Private Sub dgflo_DoubleClick(sender As Object, e As EventArgs) Handles dgflo.DoubleClick
        If XtraMessageBox.Show("Do you want to update Flourescense?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            edf = 1
            floid = TryCast(dgflo.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("flo_id")
            txtflo.Text = TryCast(dgflo.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("flo_name")
            txtflodes.Text = TryCast(dgflo.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("flo_desc")
        End If
    End Sub

    Private Sub dglab_DoubleClick(sender As Object, e As EventArgs) Handles dglab.DoubleClick
        If XtraMessageBox.Show("Do you want to update Lab?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            edf = 1
            labid = TryCast(dglab.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("lab_id")
            txtlab.Text = TryCast(dglab.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("lab_name")
            txtlabdes.Text = TryCast(dglab.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("lab_desc")
        End If
    End Sub
End Class