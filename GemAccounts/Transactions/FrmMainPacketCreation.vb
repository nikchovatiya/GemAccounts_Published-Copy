Imports DevExpress.DataAccess
Imports DevExpress.XtraEditors
Imports GemAccounts.GENERAL_FUNCTIONS
Imports GemAccounts.BAL_Transactions
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports System.Data.OleDb
Imports System.ComponentModel
Imports DevExpress.XtraSplashScreen

Public Class FrmMainPacketCreation
    Dim GF As New GENERAL_FUNCTIONS
    Dim BL As New BAL_Transactions
    Dim GV As New GLOBAL_VARIABLES
    Dim pktdt As DataTable
    Dim rw As DataRow
    Dim dt As New DataTable
    Dim tmpDT As New DataTable
    Dim count As New DataTable
    Dim rowh As Integer
    Dim ef As Boolean = False
    Private Sub FrmMainPacketCreation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pktdt = New DataTable
        pktdt.Columns.Add("MainLotName")
        pktdt.Columns.Add("Pcs", GetType(Integer))
        pktdt.Columns.Add("Carats", GetType(Double))
        pktdt.Columns.Add("PPC", GetType(Double))
        pktdt.Columns.Add("TotalUSD", GetType(Double))
        pktdt.Columns.Add("VideoLink")
        pktdt.Columns.Add("ImageLink")
        pktdt.Columns.Add("Tender")
        pktdt.Columns.Add("NetUSD", GetType(Double))
        pktdt.Columns.Add("LabourUSDPerCarat", GetType(Double))
        pktdt.Columns.Add("LabourRate", GetType(Double))
        pktdt.Columns.Add("LabourINRPerCarat", GetType(Double))
        Cancel()
        count.Columns.Add("Count", GetType(Integer))

    End Sub
    Private Sub cmbSerie_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbSerie.KeyDown, dtp.KeyDown, ChkLotname.KeyDown, Txtlotname.KeyDown, txtqty.KeyDown, Txtcarats.KeyDown, Txtppc.KeyDown, Txttotusd.KeyDown, txtNetUSD.KeyDown, txtvideolink.KeyDown, txtimagelinlk.KeyDown, txtTender.KeyDown, TxtLabourUSDPerCarat.KeyDown, TxtLabourRate.KeyDown, TxtLabourINRPerCt.KeyDown
        GENERAL_FUNCTIONS.FocusNext(sender, e)
    End Sub

    Private Sub txtqty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtqty.KeyPress, Txtppc.KeyPress, Txttotusd.KeyPress, Txtcarats.KeyPress, txtNetUSD.KeyPress
        GF.AcceptNumer(sender, e)
    End Sub
    Private Sub GetLotName()
        If ef = False Then
            If cmbSerie.Text = "" Then
                Txtlotname.Text = ""
            Else
                If ChkLotname.Checked = True Then
                    Txtlotname.Text = cmbSerie.Text & "-" & pktview.RowCount + 1
                Else

                End If
            End If
        End If
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If cmbSerie.SelectedValue Is Nothing Then
            cmbSerie.Focus()
            XtraMessageBox.Show("Please select serie.", "GemAccounts", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If Val(txtqty.Text) > Val(txtpendingpcs.Text) Then
            txtqty.Text = "1"
            txtqty.Focus()
            XtraMessageBox.Show("Qty shold be less than or equal to pending Pcs", "GemAccounts", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If Val(Txtcarats.Text) > Val(txtpendingcts.Text) Then
            Txtcarats.Text = ""
            Txtcarats.Focus()
            XtraMessageBox.Show("Carats shold be less than or equal to pending Carats", "GemAccounts", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If Val(Txttotusd.Text) > Val(txtpendingsud.Text) Then
            Txttotusd.Text = ""
            Txttotusd.Focus()
            XtraMessageBox.Show("Total USD shold be less than or equal to pending USD", "GemAccounts", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If Len(Trim(Txtlotname.Text)) = 0 Then
            Txtlotname.Focus()
            XtraMessageBox.Show("Please Enter Lot Name", "GemAccounts", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If Val(txtqty.Text) > Val(txtpendingpcs.Text) Then
            txtqty.Text = "1"
            txtqty.Focus()
            XtraMessageBox.Show("Qty must be less than pending pcs", "GemAccounts", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If Val(Txtcarats.Text) > Val(txtpendingcts.Text) Then
            Txtcarats.Text = ""
            Txtcarats.Focus()
            XtraMessageBox.Show("Carats must be less than pending carats", "GemAccounts", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If Val(txtNetUSD.Text) > Val(txtpendingsud.Text) Then
            txtNetUSD.Text = ""
            txtNetUSD.Focus()
            XtraMessageBox.Show("Net Value $ must be less than pending USD", "GemAccounts", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        cmbSerie.Enabled = False
        dtp.Enabled = False
        If ef = True Then
            pktview.SetRowCellValue(rowh, "MainLotName", Txtlotname.Text)
            pktview.SetRowCellValue(rowh, "Pcs", txtqty.Text)
            pktview.SetRowCellValue(rowh, "Carats", Txtcarats.Text)
            pktview.SetRowCellValue(rowh, "PPC", Txtppc.Text)
            pktview.SetRowCellValue(rowh, "TotalUSD", Txttotusd.Text)
            pktview.SetRowCellValue(rowh, "VideoLink", txtvideolink.Text)
            pktview.SetRowCellValue(rowh, "ImageLink", txtimagelinlk.Text)
            pktview.SetRowCellValue(rowh, "Tender", txtTender.Text)
            pktview.SetRowCellValue(rowh, "NetUSD", txtNetUSD.Text)
            pktview.SetRowCellValue(rowh, "LabourUSDPerCarat", TxtLabourUSDPerCarat.EditValue)
            pktview.SetRowCellValue(rowh, "LabourRate", TxtLabourRate.EditValue)
            pktview.SetRowCellValue(rowh, "LabourINRPerCarat", TxtLabourINRPerCt.EditValue)

        Else
            rw = pktdt.NewRow()
            rw("MainLotName") = Txtlotname.Text
            rw("Pcs") = txtqty.Text
            rw("Carats") = Txtcarats.Text
            rw("PPC") = Txtppc.Text
            rw("TotalUSD") = Txttotusd.Text
            rw("VideoLink") = txtvideolink.Text
            rw("ImageLink") = txtimagelinlk.Text
            rw("Tender") = txtTender.Text
            rw("NetUSD") = txtNetUSD.Text
            rw("LabourUSDPerCarat") = TxtLabourUSDPerCarat.EditValue
            rw("LabourRate") = TxtLabourRate.EditValue
            rw("LabourINRPerCarat") = TxtLabourINRPerCt.EditValue

            pktdt.Rows.Add(rw)
        End If

        dgpkt.DataSource = pktdt

        If XtraMessageBox.Show("Do You want to add more lot ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If ChkLotname.Checked = True Then
                txtqty.Focus()
                GetLotName()
            Else
                Txtlotname.Text = ""
                Txtlotname.Focus()
            End If
        Else
        End If
        txtqty.Text = "1"
        Txtcarats.Text = 0
        Txtppc.Text = 0
        Txttotusd.Text = 0
        txtNetUSD.Text = 0
        txtExpUSD.Text = 0
        txtExpPercent.Text = 0 & " %"
        txtvideolink.Text = ""
        txtimagelinlk.Text = ""
        txtTender.Text = ""
        TxtLabourUSDPerCarat.EditValue = 0
        TxtLabourINRPerCt.EditValue = 0
        TxtTotalLabourINR.EditValue = 0
        TxtTotalLabourUSD.EditValue = 0
        ef = False
        pktview.UpdateTotalSummary()
        PendingData()
    End Sub

    Private Sub ChkLotname_CheckedChanged(sender As Object, e As EventArgs) Handles ChkLotname.CheckedChanged
        If ChkLotname.Checked = True Then
            Txtlotname.Enabled = False
        Else
            Txtlotname.Enabled = True
        End If
    End Sub

    Private Sub Txtppc_KeyUp(sender As Object, e As KeyEventArgs) Handles Txtppc.KeyUp
        Txttotusd.Text = Val(Txtppc.Text) * Val(Txtcarats.Text)
        txtNetUSD.Text = Val(Txttotusd.Text) + Val(txtExpUSD.Text)
    End Sub

    Private Sub Txttotusd_KeyUp(sender As Object, e As KeyEventArgs) Handles Txttotusd.KeyUp
        Txtppc.Text = Val(Txttotusd.Text) / Val(Txtcarats.Text)
        txtNetUSD.Text = Val(Txttotusd.Text) + Val(txtExpUSD.Text)
    End Sub

    Private Sub txtqty_LostFocus(sender As Object, e As EventArgs) Handles txtqty.LostFocus
        Txttotusd.Text = Val(Txtppc.Text) * Val(Txtcarats.Text)
    End Sub

    Private Sub cmbSerie_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbSerie.SelectionChangeCommitted
        PendingData()
    End Sub
    Private Sub PendingData()
        Dim TotalPcs As Integer
        Dim TotalCarats As Double
        Dim TotalUSD As Double
        Dim UsedPcs As Integer
        Dim UsedCarats As Double
        Dim UsedTotalUSD As Double
        If cmbSerie.SelectedValue = 0 Then Return
        Dim dr As DataRow = GENERAL_FUNCTIONS.NFetchDataRow("select Pcs,Carats,TotalUSD from Dia_Serie where SerieID=" & cmbSerie.SelectedValue & "")
        If IsDBNull(dr("Pcs")) = True Then
            TotalPcs = 0
        Else
            TotalPcs = (dr("Pcs"))
        End If
        If IsDBNull(dr("Carats")) = True Then
            TotalCarats = 0
        Else
            TotalCarats = (dr("Carats"))
        End If
        If IsDBNull(dr("TotalUSD")) = True Then
            TotalUSD = 0
        Else
            TotalUSD = (dr("TotalUSD"))
        End If

        Dim dr2 As DataRow = GENERAL_FUNCTIONS.NFetchDataRow("select Sum(Pcs) as Pcs,sum(Carats) as Carats,sum(NetUSD) as NetUSD from Dia_Main_Packet_Master where SerieID=" & cmbSerie.SelectedValue & "")
        If IsDBNull(dr2("Pcs")) = True Then
            UsedPcs = 0
        Else
            UsedPcs = (dr2("Pcs"))
        End If
        If IsDBNull(dr2("Carats")) = True Then
            UsedCarats = 0
        Else
            UsedCarats = (dr2("Carats"))
        End If
        If IsDBNull(dr2("NetUSD")) = True Then
            UsedTotalUSD = 0
        Else
            UsedTotalUSD = (dr2("NetUSD"))
        End If

        txtpendingpcs.Text = Format(TotalPcs - UsedPcs - pktview.Columns("Pcs").SummaryItem.SummaryValue, "0")
        txtpendingcts.Text = Format(TotalCarats - UsedCarats - pktview.Columns("Carats").SummaryItem.SummaryValue, "0.00")
        txtpendingsud.Text = Format(TotalUSD - UsedTotalUSD - pktview.Columns("NetUSD").SummaryItem.SummaryValue, "0.00")
    End Sub

    Private Sub txtqty_GotFocus(sender As Object, e As EventArgs) Handles txtqty.GotFocus
        GetLotName()
    End Sub
    Private Sub btnClose_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnClose.ItemClick
        Me.Close()
    End Sub
    Private Sub Cancel() Handles btnCancel2.ItemClick
        ChkLotname.Checked = True
        GF.NFillCombo("Select SerieID,SerieName from Dia_Serie where SerieStatus='0'", "SerieID", "SerieName", cmbSerie)
        cmbSerie.Enabled = True
        ef = False
        cmbSerie.Text = ""
        cmbSerie.Focus()
        dtp.Enabled = True
        Txtlotname.Text = ""
        txtqty.Text = 1
        Txtcarats.Text = 0
        Txtppc.Text = 0
        Txttotusd.Text = 0
        txtNetUSD.Text = 0
        txtExpPercent.Text = 0 & " %"
        txtpendingcts.Text = 0
        txtpendingpcs.Text = 0
        txtpendingsud.Text = 0
        txtTender.Text = ""
        txtvideolink.Text = ""
        txtimagelinlk.Text = ""
        TxtLabourINRPerCt.EditValue = 0
        TxtLabourUSDPerCarat.EditValue = 0
        TxtTotalLabourINR.EditValue = 0
        TxtTotalLabourUSD.EditValue = 0
        TxtLabourRate.EditValue = DevFunctions.GetLiveRate()
        pktdt.Rows.Clear()
        dgpkt.DataSource = Nothing
        pktview.OptionsView.ColumnAutoWidth = True
    End Sub

    Private Sub btnBrowse_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnBrowse.ItemClick
        SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
        Try
            If OFD.ShowDialog = DialogResult.Cancel Then
            Else
                Cancel()
                GLOBAL_VARIABLES.filepath = System.IO.Path.GetFullPath(OFD.FileName)
                tmpDT = DevFunctions.ExcelToDatatable(DevFunctions.GetExcelDataSouce)
                pktdt.Rows.Clear()
                For i = 0 To tmpDT.Rows.Count - 1
                    Dim dr As DataRow = pktdt.NewRow()
                    dr("MainLotName") = tmpDT.Rows(i).Item(0).ToString
                    dr("Pcs") = tmpDT.Rows(i).Item(1).ToString
                    dr("Carats") = tmpDT.Rows(i).Item(2).ToString
                    dr("TotalUSD") = tmpDT.Rows(i).Item(3).ToString
                    dr("PPC") = tmpDT.Rows(i).Item(3).ToString / tmpDT.Rows(i).Item(2).ToString
                    dr("NetUSD") = tmpDT.Rows(i).Item(4).ToString
                    dr("VideoLink") = tmpDT.Rows(i).Item(5).ToString
                    dr("ImageLInk") = tmpDT.Rows(i).Item(6).ToString
                    dr("Tender") = tmpDT.Rows(i).Item(7).ToString
                    dr("LabourUSDPerCarat") = tmpDT.Rows(i).Item(8).ToString
                    dr("LabourRate") = tmpDT.Rows(i).Item(9).ToString
                    dr("LabourINRPerCarat") = tmpDT.Rows(i).Item(10).ToString
                    pktdt.Rows.Add(dr.ItemArray)
                Next
                dgpkt.DataSource = pktdt
            End If
        Catch ex As Exception
            DevFunctions.ErrorMsg(ex.Message)
        Finally
            SplashScreenManager.CloseForm(False)
        End Try
    End Sub

    Private Sub btnSave2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSave2.ItemClick
        If savedata() = True Then
            DevFunctions.InfoMsg("Packet Creation Successfully")
            Cancel()
        End If
    End Sub

    Private Function savedata() As Boolean
        savedata = True
        Dim msg As String = ""
        Dim duplicates = pktdt.AsEnumerable().GroupBy(Function(i) i.Field(Of String)("MainLotName")).Where(Function(g) g.Count() > 1).Select(Function(g) g.Key)

        For Each dup In duplicates
            msg = msg & dup & " Duplicate Found " & vbNewLine
        Next
        If msg = String.Empty Then
        Else
            DevFunctions.ErrorMsg(msg)
            savedata = False
            Exit Function
        End If
        For i = 0 To pktdt.Rows.Count - 1
            Dim recordCount As Integer = GENERAL_FUNCTIONS.NExcuteScalerInt("Select count(MainlotName) from Dia_Main_Packet_Master where MainlotName='" & pktdt.Rows(i).Item("MainLotName").ToString & "'")
            If recordCount > 0 Then
                savedata = False
                DevFunctions.ErrorMsg(pktdt.Rows(i).Item("MainLotName").ToString & " Duplicate Found ")
                Exit Function
            End If
        Next
        If cmbSerie.SelectedValue = 0 Then
            cmbSerie.Select()
            DevFunctions.ErrorMsg("Please select serie.")
            savedata = False
            Exit Function
        End If
        If Val(txtpendingpcs.Text) <> 0 Or Val(txtpendingcts.Text) <> 0 Or Val(txtpendingsud.Text) <> 0 Then
            DevFunctions.ErrorMsg("Qty, Carats and USD not matched with pending data")
            txtqty.Select()
            savedata = False
            Exit Function
        End If
        For i As Integer = 0 To pktview.RowCount - 1
            BL.SaveMainPacketCreation(dgpkt, 0, cmbSerie.SelectedValue, pktview.GetRowCellValue(i, "MainLotName"), pktview.GetRowCellValue(i, "Pcs"), pktview.GetRowCellValue(i, "Carats"), dtp.Value, pktview.GetRowCellValue(i, "PPC"), pktview.GetRowCellValue(i, "TotalUSD"), pktview.GetRowCellValue(i, "ImageLink"), pktview.GetRowCellValue(i, "VideoLink"), pktview.GetRowCellValue(i, "Tender"), pktview.GetRowCellValue(i, "NetUSD"), pktview.GetRowCellValue(i, "LabourUSDPerCarat"), pktview.GetRowCellValue(i, "LabourINRPerCarat"), pktview.GetRowCellValue(i, "LabourRate"))
        Next i
        GENERAL_FUNCTIONS.NExcuteQuery("update Dia_Serie set SerieStatus='1' where SerieID=" & cmbSerie.SelectedValue & "")
        Return savedata
    End Function
    Private Sub btnSaveNClose_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSaveNClose.ItemClick
        If savedata() = True Then
            Me.Close()
        End If
    End Sub

    Private Sub MenuEditLot_Click(sender As Object, e As EventArgs) Handles MenuEditLot.Click
        Txtlotname.Text = pktview.GetFocusedRowCellValue("MainLotName")
        txtqty.Text = pktview.GetFocusedRowCellValue("Pcs")
        Txtcarats.Text = pktview.GetFocusedRowCellValue("Carats")
        Txtppc.Text = pktview.GetFocusedRowCellValue("PPC")
        Txttotusd.Text = pktview.GetFocusedRowCellValue("TotalUSD")
        txtvideolink.Text = pktview.GetFocusedRowCellValue("VideoLink")
        txtimagelinlk.Text = pktview.GetFocusedRowCellValue("ImageLink")
        txtTender.Text = pktview.GetFocusedRowCellValue("Tender")
        txtExpUSD.Text = pktview.GetFocusedRowCellValue("ExpUSD")
        txtNetUSD.Text = pktview.GetFocusedRowCellValue("NetUSD")
        TxtLabourUSDPerCarat.EditValue = pktview.GetFocusedRowCellValue("LabourUSDPerCarat")
        TxtLabourRate.EditValue = pktview.GetFocusedRowCellValue("LabourRate")
        TxtLabourINRPerCt.EditValue = pktview.GetFocusedRowCellValue("LabourINRPerCarat")
        TxtTotalLabourUSD.EditValue = pktview.GetFocusedRowCellValue("LabourUSDPerCarat") * pktview.GetFocusedRowCellValue("Carats")
        TxtTotalLabourINR.EditValue = pktview.GetFocusedRowCellValue("LabourINRPerCarat") * pktview.GetFocusedRowCellValue("Carats")
        rowh = pktview.FocusedRowHandle
        ef = True
        txtpendingpcs.Text = Val(txtpendingpcs.Text + pktview.GetFocusedRowCellValue("Pcs"))
        txtpendingcts.Text = Val(txtpendingcts.Text + pktview.GetFocusedRowCellValue("Carats"))
        txtpendingsud.Text = Val(txtpendingsud.Text + pktview.GetFocusedRowCellValue("TotalUSD"))
        txtqty.Focus()
    End Sub

    Private Sub menuDelete_Click(sender As Object, e As EventArgs) Handles menuDelete.Click
        If DevFunctions.QuestionMsg("Do You want to delete this lot ?") = True Then
            pktview.DeleteRow(pktview.FocusedRowHandle)
            PendingData()
            txtqty.Focus()
        End If
    End Sub

    Private Sub txtNetUSD_KeyUp(sender As Object, e As KeyEventArgs) Handles txtNetUSD.KeyUp
        txtExpUSD.Text = Val(txtNetUSD.Text) - Val(Txttotusd.Text)
    End Sub

    Private Sub txtExpUSD_TextChanged(sender As Object, e As EventArgs) Handles txtExpUSD.TextChanged
        Dim tmp As Double
        tmp = Format((Val(txtExpUSD.Text) * 100) / Val(Txttotusd.Text), "n2")
        If Double.IsNaN(tmp) = True Then tmp = 0
        txtExpPercent.Text = Format((Val(txtExpUSD.Text) * 100) / Val(Txttotusd.Text), "n2") & " %"
    End Sub

    Private Sub TxtLabourUSDPerCarat_KeyUp(sender As Object, e As KeyEventArgs) Handles TxtLabourUSDPerCarat.KeyUp, TxtLabourRate.KeyUp
        TxtLabourINRPerCt.EditValue = TxtLabourUSDPerCarat.EditValue * TxtLabourRate.EditValue
        TxtTotalLabourINR.EditValue = Val(Txtcarats.Text) * (TxtLabourUSDPerCarat.EditValue * TxtLabourRate.EditValue)
        TxtTotalLabourUSD.EditValue = Val(Txtcarats.Text) * TxtLabourUSDPerCarat.EditValue
    End Sub

    Private Sub TxtLabourINRPerCt_KeyUp(sender As Object, e As KeyEventArgs) Handles TxtLabourINRPerCt.KeyUp
        TxtLabourUSDPerCarat.EditValue = TxtLabourINRPerCt.EditValue / TxtLabourRate.EditValue
        TxtTotalLabourINR.EditValue = Val(Txtcarats.Text) * (TxtLabourUSDPerCarat.EditValue * TxtLabourRate.EditValue)
        TxtTotalLabourUSD.EditValue = Val(Txtcarats.Text) * TxtLabourUSDPerCarat.EditValue
    End Sub
End Class