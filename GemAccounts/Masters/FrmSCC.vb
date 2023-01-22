Imports GemAccounts.GENERAL_FUNCTIONS
Imports GemAccounts.BAL_COMPANY
Imports GemAccounts.GLOBAL_VARIABLES
Imports DevExpress.XtraEditors
Imports System.ComponentModel

Public Class FrmSCC
    Dim GF As New GENERAL_FUNCTIONS
    Dim shapeid As Integer = 0
    Dim colorid As Integer = 0
    Dim clarityid As Integer = 0
    Dim edf As Integer = 0
    Dim BL As New BAL_COMPANY
    Private Sub btnsaveshape_Click(sender As Object, e As EventArgs) Handles btnsaveshape.Click
        If edf = 0 Then
            BL.DIACRUDSHAPE(dgshape, 0, shapeid, txtshape.Text, txtshapedes.Text, cmbrapshape.Text)
            XtraMessageBox.Show("Shape has been Saved.", "GemAccounts", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            BL.DIACRUDSHAPE(dgshape, 1, shapeid, txtshape.Text, txtshapedes.Text, cmbrapshape.Text)
            XtraMessageBox.Show("Shape has been Updated.", "GemAccounts", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        btncancelshape_Click(sender, e)
    End Sub
    Private Sub btncancelshape_Click(sender As Object, e As EventArgs) Handles btncancelshape.Click
        edf = 0
        shapeid = 0
        txtshape.Text = ""
        txtshapedes.Text = ""
        cmbrapshape.SelectedIndex = 0
        BL.DIACRUDSHAPE(dgshape, 3, 0, "", "", "")
    End Sub

    Private Sub FrmSCC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btncancelshape_Click(sender, e)
        btncancelcolor_Click(sender, e)
        btncancelclarity_Click(sender, e)
    End Sub


    Private Sub dgshape_KeyDown(sender As Object, e As KeyEventArgs) Handles dgshape.KeyDown
        If e.KeyCode = Keys.Delete Then
            If XtraMessageBox.Show("Do you want to delete this Shape?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                shapeid = TryCast(dgshape.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("Shape_ID")
                BL.DIACRUDSHAPE(dgshape, 2, shapeid, "", "", "")

                XtraMessageBox.Show("Shape has been deleted.", "GemAccounts", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                btncancelshape_Click(sender, e)
            Else
                Exit Sub
            End If
        Else

        End If
    End Sub

    Private Sub dgshape_DoubleClick(sender As Object, e As EventArgs) Handles dgshape.DoubleClick
        If XtraMessageBox.Show("Do you want to update Shape?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            edf = 1
            shapeid = TryCast(dgshape.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("Shape_ID")
            txtshape.Text = TryCast(dgshape.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("Shape_Name")
            txtshapedes.Text = TryCast(dgshape.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("Shape_Desc")
            cmbrapshape.Text = TryCast(dgshape.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("RAP_Shape")
        Else

        End If
    End Sub
    Private Sub chkfcolor_CheckedChanged(sender As Object, e As EventArgs) Handles chkfcolor.CheckedChanged
        If chkfcolor.CheckState = CheckState.Checked Then
            LayoutControlItem26.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            LayoutControlItem27.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            LayoutControlItem28.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        Else
            LayoutControlItem26.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            LayoutControlItem27.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            LayoutControlItem28.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        End If
    End Sub

    Private Sub btncancelcolor_Click(sender As Object, e As EventArgs) Handles btncancelcolor.Click
        edf = 0
        colorid = 0
        txtcolor.Text = ""
        txtcolordes.Text = ""
        cmbrapcolor.SelectedIndex = 0
        chkfcolor.CheckState = CheckState.Unchecked
        cmbfcolor.SelectedIndex = 0
        cmbintensity.SelectedIndex = 0
        cmbovertone.SelectedIndex = 0
        BL.DIACRUDCOLOR(dgcolor, 3, 0, "", "", "", 0, "", "", "")
    End Sub

    Private Sub btnsavecolor_Click(sender As Object, e As EventArgs) Handles btnsavecolor.Click
        If edf = 0 Then
            BL.DIACRUDCOLOR(dgcolor, 0, colorid, txtcolor.Text, txtcolordes.Text, cmbrapcolor.Text, chkfcolor.CheckState, cmbfcolor.Text, cmbintensity.Text, cmbovertone.Text)
            XtraMessageBox.Show("Color has been saved.", "GemAccounts", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If chkfcolor.CheckState = CheckState.Checked Then
                BL.DIACRUDCOLOR(dgcolor, 1, colorid, txtcolor.Text, txtcolordes.Text, cmbrapcolor.Text, chkfcolor.CheckState, cmbfcolor.Text, cmbintensity.Text, cmbovertone.Text)
            Else
                BL.DIACRUDCOLOR(dgcolor, 1, colorid, txtcolor.Text, txtcolordes.Text, cmbrapcolor.Text, chkfcolor.CheckState, "", "", "")
            End If
            XtraMessageBox.Show("Color has been updated.", "GemAccounts", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        btncancelcolor_Click(sender, e)
    End Sub


    Private Sub dgcolor_KeyDown(sender As Object, e As KeyEventArgs) Handles dgcolor.KeyDown
        If e.KeyCode = Keys.Delete Then
            If XtraMessageBox.Show("Do you want to delete this Color?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                colorid = TryCast(dgcolor.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("color_id")
                BL.DIACRUDCOLOR(dgcolor, 2, colorid, "", "", "", 0, "", "", "")

                XtraMessageBox.Show("Color has been deleted.", "GemAccounts", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                btncancelcolor_Click(sender, e)
            Else
                Exit Sub
            End If
        Else

        End If
    End Sub

    Private Sub dgcolor_DoubleClick(sender As Object, e As EventArgs) Handles dgcolor.DoubleClick
        If XtraMessageBox.Show("Do you want to update Color?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            edf = 1
            colorid = TryCast(dgcolor.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("color_id")
            txtcolor.Text = TryCast(dgcolor.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("color_name")
            txtcolordes.Text = TryCast(dgcolor.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("color_desk")
            cmbrapcolor.Text = TryCast(dgcolor.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("rap_color")
            cmbfcolor.Text = TryCast(dgcolor.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("fancy_color")
            cmbintensity.Text = TryCast(dgcolor.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("intensity")
            cmbovertone.Text = TryCast(dgcolor.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("overtone")
            Dim chkresult As Boolean = TryCast(dgcolor.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("is_fancy_color")
            If chkresult = True Then
                chkfcolor.CheckState = CheckState.Checked
            Else
                chkfcolor.CheckState = CheckState.Unchecked
            End If
        Else

        End If
    End Sub

    Private Sub btncancelclarity_Click(sender As Object, e As EventArgs) Handles btncancelclarity.Click
        edf = 0
        clarityid = 0
        txtclarity.Text = ""
        txtclaritydes.Text = ""
        cmbrapclarity.SelectedIndex = 0
        BL.DIACRUDCLARITY(dgclarity, 3, 0, "", "", "")
    End Sub

    Private Sub btnsaveclarity_Click(sender As Object, e As EventArgs) Handles btnsaveclarity.Click
        If edf = 0 Then
            BL.DIACRUDCLARITY(dgclarity, 0, clarityid, txtclarity.Text, txtclaritydes.Text, cmbrapclarity.Text)
            XtraMessageBox.Show("Clarity has been Saved.", "GemAccounts", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            BL.DIACRUDCLARITY(dgclarity, 1, clarityid, txtclarity.Text, txtclaritydes.Text, cmbrapclarity.Text)
            XtraMessageBox.Show("Clarity has been Updated.", "GemAccounts", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        btncancelclarity_Click(sender, e)
    End Sub
    Private Sub dgclarity_KeyDown(sender As Object, e As KeyEventArgs) Handles dgclarity.KeyDown
        If e.KeyCode = Keys.Delete Then
            If XtraMessageBox.Show("Do you want to delete this Clarity?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                clarityid = TryCast(dgclarity.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("clarity_id")
                BL.DIACRUDCLARITY(dgclarity, 2, clarityid, "", "", "")
                XtraMessageBox.Show("Clarity has been deleted.", "GemAccounts", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                btncancelclarity_Click(sender, e)
            Else
                Exit Sub
            End If
        Else

        End If
    End Sub

    Private Sub dgclarity_DoubleClick(sender As Object, e As EventArgs) Handles dgclarity.DoubleClick
        If XtraMessageBox.Show("Do you want to update Clarity?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            edf = 1
            clarityid = TryCast(dgclarity.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("clarity_id")
            txtclarity.Text = TryCast(dgclarity.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("clarity_name")
            txtclaritydes.Text = TryCast(dgclarity.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("clarity_desc")
            cmbrapclarity.Text = TryCast(dgclarity.MainView, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRowCellValue("rap_clarity")
        Else

        End If
    End Sub

    Private Sub dgshape_Click(sender As Object, e As EventArgs) Handles dgshape.Click

    End Sub
End Class