Imports System.ComponentModel
Imports System.Data.SqlClient
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraEditors
Imports DevExpress.XtraSplashScreen
Imports GemAccounts.GLOBAL_VARIABLES
Public Class FrmMain
    Dim GF As New GENERAL_FUNCTIONS
    Dim rap As New Rapaport

    Public Sub setform(ByVal ctrl As Form)
        Dim child As Form = Nothing
        For Each child In MdiChildren
            child = ctrl
        Next
        If child Is Nothing Then
            child = ctrl
            child.MdiParent = Me
            Try
                SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
                child.Show()
            Catch ex As Exception
                DevFunctions.ErrorMsg(ex.Message)
            Finally
                SplashScreenManager.CloseForm(False)
            End Try
            'child.Show()

        Else
            child = ctrl
            child.MdiParent = Me
            Try
                SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
                child.Show()
            Catch ex As Exception
                DevFunctions.ErrorMsg(ex.Message)
            Finally
                SplashScreenManager.CloseForm(False)
            End Try
            'child.Show()
            child.Activate()
        End If
    End Sub
    Private Sub BtnCompany_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnCompany.ItemClick
        setform(FrmCompany)
    End Sub

    Private Sub BtnShape_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnShape.ItemClick
        setform(FrmSCC)
    End Sub

    Private Sub BtnBranch_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnBranch.ItemClick
        setform(FrmBranch)
    End Sub

    Private Sub BtnUser_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnUser.ItemClick
        setform(FrmUsers)
    End Sub

    Private Sub BtnCPS_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnCPS.ItemClick
        setform(frmcps)
    End Sub

    Private Sub BtnFloro_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnFloro.ItemClick
        setform(frmflolab)
    End Sub

    Private Sub btnPurchase_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPurchase.ItemClick
        Me.MainMenu.MdiMergeStyle = RibbonMdiMergeStyle.Always
        setform(FrmPurchase)
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        setform(FrmTerms_ItemType_LotStatus)
    End Sub

    Private Sub btnAccounts_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAccounts.ItemClick
        setform(FrmLedger)
    End Sub

    Private Sub btnMainGroups_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnMainGroups.ItemClick
        setform(frmMainGroup)
    End Sub

    Private Sub btnDefaultGroup_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDefaultGroup.ItemClick
        setform(frmDefaultGroup)
    End Sub

    Private Sub btnSerie_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSerie.ItemClick
        setform(FrmSerie)
    End Sub

    Private Sub BarButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)
        setform(FrmPurchaseReport)
    End Sub

    Private Sub BarButtonItem4_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick

    End Sub

    Private Sub BarButtonItem5_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        Me.MainMenu.MdiMergeStyle = RibbonMdiMergeStyle.Always
        setform(FrmStockImport)
    End Sub

    Private Sub BarButtonItem6_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        If GF.CheckForInternetConnection = False Then
            XtraMessageBox.Show("Internet Not Working...", "Mauni Diamond", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
        Try
            rap.getrapaport()
        Finally
            'Close Wait Form
            SplashScreenManager.CloseForm(False)
            XtraMessageBox.Show("Rapaport Prices has been updated.", "Mauni Diamond", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

    Private Sub BarButtonItem7_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnImportExcel.ItemClick

    End Sub

    Private Sub BarButtonItem8_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem8.ItemClick
        setform(frmGrader)
    End Sub

    Private Sub BarButtonItem3_ItemClick_1(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        setform(FrmGrading)
    End Sub

    Private Sub MainMenu_Merge(sender As Object, e As RibbonMergeEventArgs) Handles MainMenu.Merge
        MainMenu.SelectedPage = MainMenu.MergedPages(0)
    End Sub

    Private Sub BarButtonItem7_ItemClick_2(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem7.ItemClick
        setform(FrmExcelStockImportDev)
    End Sub

    Private Sub BarButtonItem11_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem11.ItemClick
        setform(FrmProcessMaster)
    End Sub

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = UNAME
    End Sub
    Private Sub BarButtonItem14_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem14.ItemClick
        setform(FrmSendtoProcess)
    End Sub
    Private Sub btnIGIExcelImport_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnIGIExcelImport.ItemClick
        setform(FrmExcelIGIResultImport)
    End Sub

    Private Sub btnGIAResultImport_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnGIAResultImport.ItemClick
        setform(FrmExcelGIAResultImport)
    End Sub

    Private Sub btnGirdle_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnGirdle.ItemClick
        setform(FrmGirdle)
    End Sub

    Private Sub btnGirdleCondition_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnGirdleCondition.ItemClick
        setform(FrmGirdleCondition)
    End Sub

    Private Sub btnCulet_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCulet.ItemClick
        setform(FrmCulet)
    End Sub

    Private Sub btnHRDResultImport_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnHRDResultImport.ItemClick
        setform(FrmExcelHRDResultImport)
    End Sub

    Private Sub btnReturnChange_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnReturnChange.ItemClick
        setform(FrmReturnChange)
    End Sub
    Private Sub btnInvoice_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnInvoice.ItemClick
        setform(FrmInvoice)
    End Sub

    Private Sub FrmMain_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Application.Exit()
    End Sub

    Private Sub btnInvoiceList_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnInvoiceList.ItemClick
        setform(FrmInvoiceList)
    End Sub

    Private Sub btnLotHistory_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnLotHistory.ItemClick
        setform(FrmLotHistory)
    End Sub

    Private Sub btnHold_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnHold.ItemClick
        setform(FrmHold)
    End Sub

    Private Sub btnPayment_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPayment.ItemClick
        setform(frmPayment)
    End Sub

    Private Sub btnPaymentReport_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPaymentReport.ItemClick
        setform(frmPaymentReport)

    End Sub

    Private Sub btnReceipt_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnReceipt.ItemClick
        setform(frmReceipt)
    End Sub

    Private Sub btnReceiptReport_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnReceiptReport.ItemClick
        setform(frmReceiptReport)
    End Sub
    Private Sub btnMainStock_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnMainStock.ItemClick
        setform(FrmStock)
    End Sub

    Private Sub BarButtonItem21_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem21.ItemClick
        'Dim ds As DataSet = New TmpData
        'Dim dtp As New DataSet
        'ADP = New SqlDataAdapter("SELECT SerieID,SerieName from Dia_Serie", VarCon.Connection)
        'ADP.Fill(ds.Tables("DT_SerieCombo"))
        'VarCon.CloseConnection()

        'Dim report = New RptSerieWiseReport
        'report.DataSource = ds
        'PrintReport.Dviewer.DocumentSource = report
        'report.CreateDocument()
        'setform(PrintReport)
        GLOBAL_VARIABLES.ReportName = "1001-SerieWiseReport"
        setform(FrmRptViewer)
    End Sub

    Private Sub btnNewPacketCreation_CheckedChanged(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNewPacketCreation.CheckedChanged
        setform(FrmMainPacketCreation)
    End Sub

    Private Sub btnPacketCreationList_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPacketCreationList.ItemClick
        setform(FrmPacketList)
    End Sub

    Private Sub btnNewD2dTransfer_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNewD2dTransfer.ItemClick
        setform(FrmD2dTransferNew)
    End Sub

    Private Sub btnD2dTransferList_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnD2dTransferList.ItemClick
        setform(FrmD2dTransferList)
    End Sub

    Private Sub btnAskingUpdatePercentage_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAskingUpdatePercentage.ItemClick
        setform(FrmAskingUpdateWithPercentage)
    End Sub

    Private Sub btnAskingUpdatePPC_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAskingUpdatePPC.ItemClick
        setform(FrmAskingUpdateWithPPC)
    End Sub

    Private Sub btnClipBoard_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnClipBoard.ItemClick
        setform(FrmClipboard)
    End Sub

    Private Sub btnVideoLink_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnVideoLink.ItemClick
        setform(FrmVideoAndImageLink)
    End Sub

    Private Sub BtnRoughVideoImage_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnRoughVideoImage.ItemClick
        setform(FrmRoughVideoAndImageLink)
    End Sub

    Private Sub btnGradingComparision_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnGradingComparision.ItemClick
        setform(FrmGradingComparision)
    End Sub
End Class
