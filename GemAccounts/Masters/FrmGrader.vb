Imports GemAccounts.GENERAL_FUNCTIONS
Imports GemAccounts.BAL_COMPANY
Imports DevExpress.XtraEditors
Public Class frmGrader
    Dim GF As New GENERAL_FUNCTIONS
    Dim GraderID As Integer = 0
    Dim edf As Integer = 0
    Dim BL As New BAL_COMPANY
    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        edf = 0
        GraderID = 0
        txtGraderName.Text = ""

        BL.GraderCRUD(dg, 3, 0, "")
    End Sub

    Private Sub FrmUsers_Load(sender As Object, e As EventArgs) Handles Me.Load
        btncancel_Click(sender, e)
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If edf = 0 Then
            BL.GraderCRUD(dg, 0, 0, txtGraderName.Text)
            XtraMessageBox.Show("Grader has been saved.", "Mauni Diamond", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            BL.GraderCRUD(dg, 1, GraderID, txtGraderName.Text)
            XtraMessageBox.Show("Grader has been updated.", "Mauni Diamond", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

        btncancel_Click(sender, e)
    End Sub
    Private Sub dg_DoubleClick(sender As Object, e As EventArgs) Handles dg.DoubleClick
        If XtraMessageBox.Show("Do you want to update Grader?", "Mauni Diamond", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

            edf = 1
            GraderID = TryCast(dg.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("GraderID")
            txtGraderName.Text = TryCast(dg.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("GraderName")

        Else

        End If
    End Sub

    Private Sub dg_KeyDown(sender As Object, e As KeyEventArgs) Handles dg.KeyDown
        If e.KeyCode = Keys.Delete Then
            If XtraMessageBox.Show("Do you want to delete this Grader?", "Mauni Diamond", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                GraderID = TryCast(dg.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("GraderID")
                BL.GraderCRUD(dg, 2, GraderID, "")
                XtraMessageBox.Show("Grader has been deleted.", "GemAccounts", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                btncancel_Click(sender, e)
            Else
                Exit Sub
            End If
        Else

        End If
    End Sub
End Class