Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraVerticalGrid
Imports DevExpress.XtraVerticalGrid.Events

Public Class FrmGradingComparision
    Private Sub FrmGradingComparision_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DevFunctions.NFillComboDev("Select lab_name from Dia_Lab_Master", "lab_name", cmblab)
    End Sub
    Private Sub a123()
        Dim args As New XtraMessageBoxArgs()
        args.AllowHtmlText = DefaultBoolean.True
        SvgImageCollection1.ImageSize = New Size(48, 48)
        args.HtmlImages = SvgImageCollection1
        args.Text = "<p align=center><image=security_warningcircled2><br>" & "<b>Something went wrong</b><br>" & "You entered a wrong Stock ID<br>" & "Please try with proper Stock ID</p>"
        args.Caption = "Warning"
        args.Buttons = New DialogResult() {DialogResult.OK}
        XtraMessageBox.Show(args)
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        'If txtStockID.EditValue = Nothing Then Return
        'If cmblab.EditValue = Nothing Then Return
        'If cmblab.EditValue = "" Then Return
        'Dim dt As New DataTable=

    End Sub
End Class