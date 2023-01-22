Imports System.ComponentModel
Imports System.IO
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

Public Class FrmStockLayout
    Dim GF As New GENERAL_FUNCTIONS
    Dim DF As New DevFunctions
    Dim flag As Boolean
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub FrmStockLayout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListboxFetch()
        NewLayoutGroup.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
    End Sub
    Sub ListboxFetch()
        Dim Dt As DataTable = GENERAL_FUNCTIONS.NFetchDatatable("Select LayoutID,LayoutName from Dia_Layouts where UserID=" & GLOBAL_VARIABLES.UID & " or Isdefault=1 Order by LayoutName")
        Listbox.DataSource = Dt
        Listbox.DisplayMember = "LayoutName"
        Listbox.ValueMember = "LayoutID"
        Listbox.SelectedValue = GLOBAL_VARIABLES.TempStockLayoutID
    End Sub

    Private Sub Listbox_DrawItem(sender As Object, e As ListBoxDrawItemEventArgs) Handles Listbox.DrawItem
        e.Handled = False
        If e.Item = GLOBAL_VARIABLES.TempStockLayoutID Then e.Appearance.BackColor = Color.Blue

    End Sub

    Private Sub Listbox_SelectedValueChanged(sender As Object, e As EventArgs) Handles Listbox.SelectedValueChanged
        txtRenameTemplate.EditValue = Listbox.Text
        NewLayoutGroup.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        RenameLayoutGroup.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        flag = True
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        NewLayoutGroup.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        RenameLayoutGroup.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        flag = False
    End Sub

    Private Sub Listbox_Click(sender As Object, e As EventArgs) Handles Listbox.Click
        If Listbox.Text = Nothing Then
        Else
            txtRenameTemplate.EditValue = Listbox.Text
            NewLayoutGroup.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            RenameLayoutGroup.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            flag = True
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click


        Dim str As Stream = New System.IO.MemoryStream()
        FrmStock.dgview.SaveLayoutToStream(str)
        str.Seek(0, System.IO.SeekOrigin.Begin)
        Dim reader As StreamReader = New StreamReader(str)
        Dim text As String = reader.ReadToEnd()

        If flag = False Then
            If txtNewTemplate.EditValue = Nothing Then
                DevFunctions.ErrorMsg("Please enter Layout Name")
                Exit Sub
            End If
            Dim LayoutID As Integer = GENERAL_FUNCTIONS.MaxNo("Select Max(LayoutID) from Dia_Layouts")

            DevFunctions.SaveGridLayout(0, LayoutID, txtNewTemplate.EditValue, text, 0)
            DevFunctions.InfoMsg(txtNewTemplate.Text & " template has been saved.")
            txtNewTemplate.EditValue = Nothing
            txtRenameTemplate.EditValue = Nothing
            ListboxFetch()
        ElseIf flag = True Then
            If Listbox.SelectedValue = 1111 Then
                DevFunctions.ErrorMsg("You cannot save this layout because it is system default")
                Exit Sub
            End If
            If txtRenameTemplate.EditValue = Nothing Then
                DevFunctions.ErrorMsg("Please enter Layout Name")
                Exit Sub
            End If
            GENERAL_FUNCTIONS.NExcuteQuery("UPDATE Dia_Layouts SET LayoutName='" & txtRenameTemplate.EditValue & "' WHERE LayoutID=" & Listbox.SelectedValue & "")
            DevFunctions.SaveGridLayout(1, Listbox.SelectedValue, txtRenameTemplate.EditValue, text, 0)
            DevFunctions.InfoMsg(Listbox.Text & " has been updated as " & txtRenameTemplate.EditValue)
            txtNewTemplate.EditValue = Nothing
            txtRenameTemplate.EditValue = Nothing
            ListboxFetch()
        End If
    End Sub

    Private Sub btnSetAsDefault_Click(sender As Object, e As EventArgs) Handles btnSetAsDefault.Click
        GENERAL_FUNCTIONS.NExcuteQuery("UPDATE Dia_User_Master SET StockLayoutID=" & Listbox.SelectedValue & " WHERE user_id=" & GLOBAL_VARIABLES.UID & "")
        GLOBAL_VARIABLES.StockLayoutID = Listbox.SelectedValue
        DevFunctions.InfoMsg(Listbox.Text & " as set to default")
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If Listbox.SelectedValue = GENERAL_FUNCTIONS.NExcuteScaler("SELECT StockLayoutID from Dia_User_Master where User_id=" & GLOBAL_VARIABLES.UID & "") Then
            DevFunctions.ErrorMsg("You can not delete this template because it's default.")
            Exit Sub
        End If
        If GENERAL_FUNCTIONS.NExcuteScaler("SELECT IsDefault from Dia_Layouts where LayoutID=" & Listbox.SelectedValue & "") = True Then
            DevFunctions.ErrorMsg("You can not delete this template because it's default.")
            Exit Sub
        End If
        GENERAL_FUNCTIONS.NExcuteQuery("DELETE FROM Dia_Layouts WHERE LayoutID=" & Listbox.SelectedValue & "")
        DevFunctions.InfoMsg(Listbox.Text & " has been deleted.")
        txtNewTemplate.EditValue = Nothing
        txtRenameTemplate.EditValue = Nothing
        ListboxFetch()
    End Sub

    Private Sub FrmStockLayout_Closed(sender As Object, e As EventArgs) Handles Me.Closed

    End Sub

    Private Sub FrmStockLayout_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        FrmStock.MainStock_Grid_Bind()
        FrmStock.SetDefaultLayout()
    End Sub
End Class