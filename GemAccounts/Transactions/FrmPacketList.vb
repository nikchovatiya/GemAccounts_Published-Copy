Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraSplashScreen
Imports GemAccounts.DevFunctions
Imports GemAccounts.GLOBAL_VARIABLES

Public Class FrmPacketList

    Public Sub FrmPacketList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As DataTable = GENERAL_FUNCTIONS.NFetchDatatable("SELECT M.*,s.SerieName,u.user_name FROM Dia_Main_Packet_Master M left join Dia_Serie S on S.SerieID=m.SerieID left join Dia_User_Master U on u.user_id=m.UserID order by MainPacketID desc")
        If dt Is Nothing Then Return
        dg.DataSource = dt
        dgview.BestFitColumns()
    End Sub

    Private Sub btnExportExcel_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExportExcel.ItemClick
        ExportGrid(dgview)
    End Sub
    Private Function CheckValidation() As Boolean
        Dim empty As Boolean = False
        Dim dt As DataTable = GENERAL_FUNCTIONS.NFetchDatatable("Select top(1)* from Dia_MainStock where MainLotID=" & dgview.GetFocusedRowCellValue("MainPacketID"))
        If dt.Rows.Count > 0 = True Then
            DevFunctions.ErrorMsg("Sorry You cannot delete this Lot" & dgview.GetFocusedRowCellValue("MainPacketID"))
        Else
            GENERAL_FUNCTIONS.NExcuteQuery("DELETE  from Dia_Main_Packet_Master where MainPacketID=" & dgview.GetFocusedRowCellValue("MainPacketID"))
            GENERAL_FUNCTIONS.NExcuteQuery("UPDATE Dia_Serie SET SerieStatus =0 WHERE SerieID=" & dgview.GetFocusedRowCellValue("SerieID"))
            empty = True
        End If
        Return empty
    End Function

    Private Sub riDelete_OpenLink(sender As Object, e As OpenLinkEventArgs) Handles riDelete.OpenLink
        If XtraMessageBox.Show("Do you want to delete this Row?", "Mauni Diamond", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If CheckValidation() = True Then
                DevFunctions.InfoMsg("Packet deleted successfully")
                FrmPacketList_Load(sender, e)
            End If
        Else
            Return
        End If
    End Sub

    Private Sub dgview_RowCellClick(sender As Object, e As RowCellClickEventArgs) Handles dgview.RowCellClick
        If e.Column.FieldName = "Delete" Then
            riDelete_OpenLink(sender, New DevExpress.XtraEditors.Controls.OpenLinkEventArgs(e.CellValue))
        Else
            Return
        End If
    End Sub

End Class