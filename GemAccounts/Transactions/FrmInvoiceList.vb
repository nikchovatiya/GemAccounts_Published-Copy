Imports System.IO
Imports DevExpress.Export
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraSplashScreen
Imports GemAccounts.DevFunctions
Imports GemAccounts.GLOBAL_VARIABLES
Public Class FrmInvoiceList
    Public Shared tmpAttachmentPath As String = ""
    Public Shared SalesMasterID As Integer = 0
    Private Sub dgview_DoubleClick(sender As Object, e As EventArgs) Handles dgview.DoubleClick


        If IsDBNull(dgview.GetFocusedRowCellValue("Attachment")) = False Then
            tmpAttachmentPath = dgview.GetFocusedRowCellValue("Attachment")
            GLOBAL_VARIABLES.TmpFileName = dgview.GetFocusedRowCellValue("Attachment")
        Else
            tmpAttachmentPath = ""
            GLOBAL_VARIABLES.TmpFileName = ""
        End If

        SalesEditFlag = True
        FrmInvoiceList.SalesMasterID = dgview.GetFocusedRowCellValue("SalesMasterID")
        setform(FrmInvoice)
    End Sub

    Public Sub FrmInvoiceList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dg.DataSource = FetchDataTableFromStoredProcedure("InvoiceListProcedure")
        dgview.BestFitColumns()
    End Sub
    Private Sub setform(ByVal ctrl As Form)
        Dim child As Form = Nothing
        For Each child In MdiChildren
            child = ctrl
        Next
        If child Is Nothing Then
            child = ctrl
            child.MdiParent = Me.MdiParent
            SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
            Try
                child.Show()
            Finally
                SplashScreenManager.CloseForm(False)
            End Try
        Else
            child = ctrl
            child.MdiParent = Me.MdiParent
            SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
            Try
                child.Show()
            Finally
                SplashScreenManager.CloseForm(False)
            End Try
            child.Activate()
        End If
    End Sub

    Private Sub btnExportExcel_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExportExcel.ItemClick
        ExportGrid(dgview)
    End Sub
    Private Function CheckValidation(ByVal SaleID As Integer) As Boolean
        Dim empty As Boolean = False
        Dim SalesMasterDR As DataRow = GENERAL_FUNCTIONS.NFetchDataRow("Select * from Dia_SalesMaster where SalesMasterID=" & SaleID)
        If SalesMasterDR("PaymentFlag") = True Then
            DevFunctions.ErrorMsg("Sorry You cannot delete this invoice because is settled against Invoice#" & SaleID)
        Else
            If IsDBNull(dgview.GetFocusedRowCellValue("Attachment")) = False Then
                If System.IO.File.Exists(dgview.GetFocusedRowCellValue("Attachment")) = True Then
                    System.IO.File.Delete(dgview.GetFocusedRowCellValue("Attachment"))
                End If
            End If


            GENERAL_FUNCTIONS.NExcuteQuery("DELETE  from Dia_SalesMaster where SalesMasterID=" & SaleID)
            GENERAL_FUNCTIONS.NExcuteQuery("DELETE  from Dia_SalesDetails where SalesMasterID=" & SaleID)
            GENERAL_FUNCTIONS.NExcuteQuery("DELETE  from Dia_SalesAdditional where SalesMasterID=" & SaleID)
            GENERAL_FUNCTIONS.NExcuteQuery("DELETE  from Dia_SalesBrokerage where SalesMasterID=" & SaleID)
            GENERAL_FUNCTIONS.NExcuteQuery("DELETE  from Dia_MainStock where SalesMasterID=" & SaleID)
            empty = True
        End If
        Return empty
    End Function

    Private Sub riDelete_OpenLink(sender As Object, e As OpenLinkEventArgs) Handles riDelete.OpenLink
        If XtraMessageBox.Show("Do you want to delete this Row?", "Mauni Diamond", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

            If CheckValidation(dgview.GetFocusedRowCellValue("SalesMasterID")) = True Then
                DevFunctions.InfoMsg("Invoice deleted successfully")
                FrmInvoiceList_Load(sender, e)
            End If
        Else
            Return
        End If
    End Sub

    Private Sub dgview_RowCellClick(sender As Object, e As RowCellClickEventArgs) Handles dgview.RowCellClick
        If e.Column.FieldName = "Delete" Then
            riDelete_OpenLink(sender, New DevExpress.XtraEditors.Controls.OpenLinkEventArgs(e.CellValue))
        ElseIf e.Column.FieldName = "Print" Then
            riPrint_OpenLink(sender, New DevExpress.XtraEditors.Controls.OpenLinkEventArgs(e.CellValue))
        ElseIf e.Column.FieldName = "PDF" Then
            If IsDBNull(dgview.GetFocusedRowCellValue("Attachment")) = False Then
                Dim path As String = dgview.GetFocusedRowCellValue("Attachment")
                If path Is Nothing Or path Is String.Empty Then Return
                Try
                    With FrmPDFViewer
                        .Show()
                        .Focus()
                        .PdfViewer1.DocumentFilePath = path
                    End With
                Catch ex As Exception
                    DevFunctions.ErrorMsg(ex.Message)
                End Try
            End If

        Else
                Return
        End If
    End Sub
    Private Sub OpenReport()
        Dim ds As DataSet = New TmpData
        Dim dt As DataTable = ds.Tables("TblPrintInvoice")
        Dim dr As DataRow
        Dim dtdetail As DataTable = GENERAL_FUNCTIONS.NFetchDatatable("SELECT 
D.SalesMasterID,
D.Barcode,
D.RAP,
D.Discount,
D.PPCUSD,
D.TotalUSD,
D.PPCINR,
D.TotalINR
,M.StockID
,M.Qty
,M.Carats
,S.Shape_Name as Shape
,C.color_name as Color
,CLA.clarity_name as Clarity
,FLO.flo_name as Flo
,LAB.lab_name AS Lab
,M.LCertificateNo as ReportNo
,SM.ExRate 
,L.LedgerName AS Customer
,L.LAddress AS C_Address
,L.LCountry as C_Country
,L.LState As C_State
,L.LCity As C_City
,L.LMobile As C_Mobile
,L.LEmail As C_Email
,SM.SaleDate AS SaleDate
,DATEADD(DAY,cast(TERMS.terms_desc as int),SM.SaleDate) as DueDate
,CMP.*


FROM Dia_SalesDetails D
LEFT JOIN Dia_MainStock M ON M.SalesMasterID=D.SalesMasterID AND M.Barcode=D.Barcode
LEFT JOIN Dia_Shape_Master S ON M.ShapeID=S.Shape_ID
LEFT JOIN Dia_Color_Master C ON M.ColorID=C.color_id
LEFT JOIN Dia_Clarity_Master CLA ON M.ClarityID=CLA.clarity_id 
LEFT JOIN Dia_Flo_Master FLO ON M.FloID=FLO.flo_id
LEFT JOIN DIa_Lab_Master LAB ON M.LabID=LAB.lab_id
LEFT JOIN Dia_SalesMaster SM ON SM.SalesMasterID=D.SalesMasterID
LEFT JOIN Dia_Ledger_Master L ON L.LedgerID=SM.LedgerID
LEFT JOIN Dia_Terms_Master TERMS ON TERMS.terms_id=SM.TermsID
LEFT JOIN Dia_Company_Master CMP ON CMP.cmp_id =SM.CompanyID
 where D.SalesMasterID=" & dgview.GetFocusedRowCellValue("SalesMasterID"))
        For i = 0 To dtdetail.Rows.Count - 1
            dr = dt.NewRow
            dr("SalesMasterID") = dtdetail.Rows(i).Item("SalesMasterID")
            dr("Barcode") = dtdetail.Rows(i).Item("Barcode")
            dr("RAP") = dtdetail.Rows(i).Item("RAP")
            dr("Discount") = dtdetail.Rows(i).Item("Discount")
            dr("PPCUSD") = dtdetail.Rows(i).Item("PPCUSD")
            dr("TotalUSD") = dtdetail.Rows(i).Item("TotalUSD")
            dr("PPCINR") = dtdetail.Rows(i).Item("PPCINR")
            dr("TotalINR") = dtdetail.Rows(i).Item("TotalINR")
            dr("StockID") = dtdetail.Rows(i).Item("StockID")
            dr("Qty") = dtdetail.Rows(i).Item("Qty")
            dr("Carats") = dtdetail.Rows(i).Item("Carats")
            dr("Shape") = dtdetail.Rows(i).Item("Shape")
            dr("Color") = dtdetail.Rows(i).Item("Color")
            dr("Clarity") = dtdetail.Rows(i).Item("Clarity")
            dr("Flo") = dtdetail.Rows(i).Item("Flo")
            dr("Lab") = dtdetail.Rows(i).Item("Lab")
            dr("ReportNo") = dtdetail.Rows(i).Item("ReportNo")
            dr("ExRate") = dtdetail.Rows(i).Item("ExRate")
            dr("Customer") = dtdetail.Rows(i).Item("Customer")
            dr("C_Address") = dtdetail.Rows(i).Item("C_Address")
            dr("C_Country") = dtdetail.Rows(i).Item("C_Country")
            dr("C_State") = dtdetail.Rows(i).Item("C_State")
            dr("C_City") = dtdetail.Rows(i).Item("C_City")
            dr("C_Mobile") = dtdetail.Rows(i).Item("C_Mobile")
            dr("C_Email") = dtdetail.Rows(i).Item("C_Email")

            dr("cmp_name") = dtdetail.Rows(i).Item("cmp_name")
            dr("cmp_address") = dtdetail.Rows(i).Item("cmp_address")
            dr("cmp_country") = dtdetail.Rows(i).Item("cmp_country")
            dr("cmp_state") = dtdetail.Rows(i).Item("cmp_state")
            dr("cmp_city") = dtdetail.Rows(i).Item("cmp_city")
            dr("cmp_mobile") = dtdetail.Rows(i).Item("cmp_mobile")
            dr("cmp_phone") = dtdetail.Rows(i).Item("cmp_phone")
            dr("cmp_email") = dtdetail.Rows(i).Item("cmp_email")
            dr("cmp_gst") = dtdetail.Rows(i).Item("cmp_gst")
            dr("cmp_pan") = dtdetail.Rows(i).Item("cmp_pan")
            dr("cmp_bank") = dtdetail.Rows(i).Item("cmp_bank")
            dr("cmp_branch") = dtdetail.Rows(i).Item("cmp_branch")
            dr("cmp_acno") = dtdetail.Rows(i).Item("cmp_acno")
            dr("cmp_ifc") = dtdetail.Rows(i).Item("cmp_ifc")
            dr("cmp_swift") = dtdetail.Rows(i).Item("cmp_swift")
            dr("cmp_routing") = dtdetail.Rows(i).Item("cmp_routing")
            dr("SaleDate") = dtdetail.Rows(i).Item("SaleDate")
            dr("DueDate") = dtdetail.Rows(i).Item("DueDate")
            dt.Rows.Add(dr)
        Next
        Dim report = New RptInvoice
        report.DataSource = ds
        PrintReport.Dviewer.DocumentSource = report
        report.CreateDocument()
        setform(PrintReport)
    End Sub

    Private Sub riPrint_OpenLink(sender As Object, e As OpenLinkEventArgs) Handles riPrint.OpenLink
        OpenReport()
    End Sub

    Private Sub riBtnPrint_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles riBtnPrint.ButtonClick
        OpenReport()
    End Sub
End Class