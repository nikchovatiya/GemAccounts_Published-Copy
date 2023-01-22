<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmInvoiceList
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmInvoiceList))
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnExportExcel = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar1 = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.dg = New DevExpress.XtraGrid.GridControl()
        Me.dgview = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColSalesUSD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColSalesINR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn17 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn18 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn19 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn20 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.riDelete = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
        Me.GridColumn21 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.riPrint = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
        Me.GridColumn22 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn23 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn24 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn25 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn26 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn27 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.riPDF = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.riBtnPrint = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgview, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.riDelete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.riPrint, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.riPDF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.riBtnPrint, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.RibbonControl1.SearchEditItem, Me.btnExportExcel})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 2
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.Size = New System.Drawing.Size(715, 158)
        Me.RibbonControl1.StatusBar = Me.RibbonStatusBar1
        '
        'btnExportExcel
        '
        Me.btnExportExcel.Caption = "Export"
        Me.btnExportExcel.Id = 1
        Me.btnExportExcel.ImageOptions.SvgImage = CType(resources.GetObject("btnExportExcel.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btnExportExcel.Name = "btnExportExcel"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "Actions"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnExportExcel)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        '
        'RibbonStatusBar1
        '
        Me.RibbonStatusBar1.Location = New System.Drawing.Point(0, 359)
        Me.RibbonStatusBar1.Name = "RibbonStatusBar1"
        Me.RibbonStatusBar1.Ribbon = Me.RibbonControl1
        Me.RibbonStatusBar1.Size = New System.Drawing.Size(715, 24)
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Text = "RibbonPage2"
        '
        'dg
        '
        Me.dg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dg.Location = New System.Drawing.Point(0, 158)
        Me.dg.MainView = Me.dgview
        Me.dg.MenuManager = Me.RibbonControl1
        Me.dg.Name = "dg"
        Me.dg.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.riDelete, Me.riPrint, Me.riBtnPrint, Me.riPDF})
        Me.dg.Size = New System.Drawing.Size(715, 201)
        Me.dg.TabIndex = 2
        Me.dg.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.dgview})
        '
        'dgview
        '
        Me.dgview.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.ColSalesUSD, Me.ColSalesINR, Me.GridColumn12, Me.GridColumn13, Me.GridColumn14, Me.GridColumn15, Me.GridColumn16, Me.GridColumn17, Me.GridColumn18, Me.GridColumn19, Me.GridColumn10, Me.GridColumn11, Me.GridColumn20, Me.GridColumn21, Me.GridColumn22, Me.GridColumn23, Me.GridColumn24, Me.GridColumn25, Me.GridColumn26, Me.GridColumn27})
        Me.dgview.GridControl = Me.dg
        Me.dgview.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SalesUSD", Me.ColSalesUSD, "{0:n2}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SalesINR", Me.ColSalesINR, "{0:n2}")})
        Me.dgview.Name = "dgview"
        Me.dgview.OptionsBehavior.Editable = False
        Me.dgview.OptionsMenu.ShowConditionalFormattingItem = True
        Me.dgview.OptionsMenu.ShowFooterItem = True
        Me.dgview.OptionsMenu.ShowGroupSummaryEditorItem = True
        Me.dgview.OptionsView.ColumnAutoWidth = False
        Me.dgview.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
        Me.dgview.OptionsView.ShowFooter = True
        Me.dgview.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Sale ID"
        Me.GridColumn1.FieldName = "SalesMasterID"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 3
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Sale Date"
        Me.GridColumn2.DisplayFormat.FormatString = "dd-MM-yyyy"
        Me.GridColumn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn2.FieldName = "SaleDate"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 4
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "LedgerID"
        Me.GridColumn3.FieldName = "LedgerID"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowShowHide = False
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Party"
        Me.GridColumn4.FieldName = "LedgerName"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 5
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "TermsID"
        Me.GridColumn5.FieldName = "TermsID"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.AllowShowHide = False
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Terms"
        Me.GridColumn6.FieldName = "TermsName"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 6
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Ex. Rate"
        Me.GridColumn7.FieldName = "ExRate"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 8
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Qty"
        Me.GridColumn8.DisplayFormat.FormatString = "n0"
        Me.GridColumn8.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn8.FieldName = "Qty"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Qty", "{0:n0}")})
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 9
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Carats"
        Me.GridColumn9.DisplayFormat.FormatString = "n2"
        Me.GridColumn9.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn9.FieldName = "Carats"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Carats", "{0:n2}")})
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 10
        '
        'ColSalesUSD
        '
        Me.ColSalesUSD.Caption = "Sales USD"
        Me.ColSalesUSD.DisplayFormat.FormatString = "n2"
        Me.ColSalesUSD.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColSalesUSD.FieldName = "SalesUSD"
        Me.ColSalesUSD.Name = "ColSalesUSD"
        Me.ColSalesUSD.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SalesUSD", "{0:n2}")})
        Me.ColSalesUSD.Visible = True
        Me.ColSalesUSD.VisibleIndex = 11
        '
        'ColSalesINR
        '
        Me.ColSalesINR.Caption = "Sales INR"
        Me.ColSalesINR.DisplayFormat.FormatString = "n2"
        Me.ColSalesINR.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColSalesINR.FieldName = "SalesINR"
        Me.ColSalesINR.Name = "ColSalesINR"
        Me.ColSalesINR.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SalesINR", "{0:n2}")})
        Me.ColSalesINR.Visible = True
        Me.ColSalesINR.VisibleIndex = 12
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "Additional USD"
        Me.GridColumn12.DisplayFormat.FormatString = "n2"
        Me.GridColumn12.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn12.FieldName = "AddUSD"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "AddUSD", "{0:n2}")})
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 13
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "Additional INR"
        Me.GridColumn13.DisplayFormat.FormatString = "n2"
        Me.GridColumn13.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn13.FieldName = "AddINR"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "AddINR", "{0:n2}")})
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 14
        '
        'GridColumn14
        '
        Me.GridColumn14.Caption = "Brokerage USD"
        Me.GridColumn14.DisplayFormat.FormatString = "n2"
        Me.GridColumn14.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn14.FieldName = "BrokerUSD"
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "BrokerUSD", "{0:n2}")})
        Me.GridColumn14.Visible = True
        Me.GridColumn14.VisibleIndex = 15
        '
        'GridColumn15
        '
        Me.GridColumn15.Caption = "Brokerage INR"
        Me.GridColumn15.DisplayFormat.FormatString = "n2"
        Me.GridColumn15.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn15.FieldName = "BrokerINR"
        Me.GridColumn15.Name = "GridColumn15"
        Me.GridColumn15.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "BrokerINR", "{0:n2}")})
        Me.GridColumn15.Visible = True
        Me.GridColumn15.VisibleIndex = 16
        '
        'GridColumn16
        '
        Me.GridColumn16.Caption = "UserID"
        Me.GridColumn16.FieldName = "UserID"
        Me.GridColumn16.Name = "GridColumn16"
        Me.GridColumn16.OptionsColumn.AllowShowHide = False
        '
        'GridColumn17
        '
        Me.GridColumn17.Caption = "User"
        Me.GridColumn17.FieldName = "UserName"
        Me.GridColumn17.Name = "GridColumn17"
        Me.GridColumn17.Visible = True
        Me.GridColumn17.VisibleIndex = 17
        '
        'GridColumn18
        '
        Me.GridColumn18.Caption = "Net Sale USD"
        Me.GridColumn18.DisplayFormat.FormatString = "n2"
        Me.GridColumn18.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn18.FieldName = "GridColumn18"
        Me.GridColumn18.Name = "GridColumn18"
        Me.GridColumn18.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "GridColumn18", "{0:n2}")})
        Me.GridColumn18.UnboundExpression = "[SalesUSD] + [AddUSD] + [BrokerUSD]"
        Me.GridColumn18.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        Me.GridColumn18.Visible = True
        Me.GridColumn18.VisibleIndex = 18
        '
        'GridColumn19
        '
        Me.GridColumn19.Caption = "Net Sale INR"
        Me.GridColumn19.DisplayFormat.FormatString = "n2"
        Me.GridColumn19.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn19.FieldName = "GridColumn19"
        Me.GridColumn19.Name = "GridColumn19"
        Me.GridColumn19.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "GridColumn19", "{0:n2}")})
        Me.GridColumn19.UnboundExpression = "[SalesINR] + [BrokerINR] + [AddINR]"
        Me.GridColumn19.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        Me.GridColumn19.Visible = True
        Me.GridColumn19.VisibleIndex = 19
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Terms Days"
        Me.GridColumn10.FieldName = "TermsDays"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.OptionsColumn.AllowShowHide = False
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "Due Date"
        Me.GridColumn11.DisplayFormat.FormatString = "d"
        Me.GridColumn11.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn11.FieldName = "DueDate"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 7
        '
        'GridColumn20
        '
        Me.GridColumn20.Caption = "Delete"
        Me.GridColumn20.ColumnEdit = Me.riDelete
        Me.GridColumn20.FieldName = "Delete"
        Me.GridColumn20.Name = "GridColumn20"
        Me.GridColumn20.Visible = True
        Me.GridColumn20.VisibleIndex = 1
        Me.GridColumn20.Width = 35
        '
        'riDelete
        '
        Me.riDelete.AutoHeight = False
        Me.riDelete.Image = CType(resources.GetObject("riDelete.Image"), System.Drawing.Image)
        Me.riDelete.ImageAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.riDelete.Name = "riDelete"
        '
        'GridColumn21
        '
        Me.GridColumn21.Caption = "Print"
        Me.GridColumn21.ColumnEdit = Me.riPrint
        Me.GridColumn21.FieldName = "Print"
        Me.GridColumn21.Name = "GridColumn21"
        Me.GridColumn21.Visible = True
        Me.GridColumn21.VisibleIndex = 0
        Me.GridColumn21.Width = 38
        '
        'riPrint
        '
        Me.riPrint.AutoHeight = False
        Me.riPrint.Caption = "Print"
        Me.riPrint.Name = "riPrint"
        Me.riPrint.NullText = "Print"
        Me.riPrint.SingleClick = True
        '
        'GridColumn22
        '
        Me.GridColumn22.Caption = "Rec. USD"
        Me.GridColumn22.DisplayFormat.FormatString = "n2"
        Me.GridColumn22.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn22.FieldName = "RecUSD"
        Me.GridColumn22.Name = "GridColumn22"
        Me.GridColumn22.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "RecUSD", "{0:n2}")})
        Me.GridColumn22.Visible = True
        Me.GridColumn22.VisibleIndex = 20
        '
        'GridColumn23
        '
        Me.GridColumn23.Caption = "Rec. INR"
        Me.GridColumn23.DisplayFormat.FormatString = "n2"
        Me.GridColumn23.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn23.FieldName = "RecINR"
        Me.GridColumn23.Name = "GridColumn23"
        Me.GridColumn23.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "RecINR", "{0:n2}")})
        Me.GridColumn23.Visible = True
        Me.GridColumn23.VisibleIndex = 21
        '
        'GridColumn24
        '
        Me.GridColumn24.Caption = "Balance USD"
        Me.GridColumn24.DisplayFormat.FormatString = "n2"
        Me.GridColumn24.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn24.FieldName = "BalanceUSD"
        Me.GridColumn24.Name = "GridColumn24"
        Me.GridColumn24.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "BalanceUSD", "{0:n2}")})
        Me.GridColumn24.Visible = True
        Me.GridColumn24.VisibleIndex = 22
        '
        'GridColumn25
        '
        Me.GridColumn25.Caption = "Balance INR"
        Me.GridColumn25.DisplayFormat.FormatString = "n2"
        Me.GridColumn25.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn25.FieldName = "BalanceINR"
        Me.GridColumn25.Name = "GridColumn25"
        Me.GridColumn25.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "BalanceINR", "{0:n2}")})
        Me.GridColumn25.Visible = True
        Me.GridColumn25.VisibleIndex = 23
        '
        'GridColumn26
        '
        Me.GridColumn26.Caption = "Attachment"
        Me.GridColumn26.FieldName = "Attachment"
        Me.GridColumn26.Name = "GridColumn26"
        Me.GridColumn26.OptionsColumn.AllowShowHide = False
        Me.GridColumn26.Visible = True
        Me.GridColumn26.VisibleIndex = 24
        '
        'GridColumn27
        '
        Me.GridColumn27.Caption = "PDF"
        Me.GridColumn27.ColumnEdit = Me.riPDF
        Me.GridColumn27.FieldName = "PDF"
        Me.GridColumn27.Name = "GridColumn27"
        Me.GridColumn27.UnboundExpression = "Iif(IsNullOrEmpty([Attachment]), False, True)"
        Me.GridColumn27.UnboundType = DevExpress.Data.UnboundColumnType.[Boolean]
        Me.GridColumn27.Visible = True
        Me.GridColumn27.VisibleIndex = 2
        Me.GridColumn27.Width = 30
        '
        'riPDF
        '
        Me.riPDF.AutoHeight = False
        Me.riPDF.CheckBoxOptions.Style = DevExpress.XtraEditors.Controls.CheckBoxStyle.Custom
        Me.riPDF.ImageOptions.ImageChecked = CType(resources.GetObject("riPDF.ImageOptions.ImageChecked"), System.Drawing.Image)
        Me.riPDF.Name = "riPDF"
        '
        'riBtnPrint
        '
        Me.riBtnPrint.AutoHeight = False
        Me.riBtnPrint.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.riBtnPrint.Name = "riBtnPrint"
        '
        'FrmInvoiceList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(715, 383)
        Me.Controls.Add(Me.dg)
        Me.Controls.Add(Me.RibbonStatusBar1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.Name = "FrmInvoiceList"
        Me.Ribbon = Me.RibbonControl1
        Me.StatusBar = Me.RibbonStatusBar1
        Me.Text = "Invoice List"
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgview, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.riDelete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.riPrint, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.riPDF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.riBtnPrint, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonStatusBar1 As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents dg As DevExpress.XtraGrid.GridControl
    Friend WithEvents dgview As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColSalesUSD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColSalesINR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn16 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn17 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn18 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn19 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnExportExcel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents GridColumn20 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents riDelete As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents GridColumn21 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents riPrint As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents riBtnPrint As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents GridColumn22 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn23 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn24 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn25 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn26 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn27 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents riPDF As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
End Class
