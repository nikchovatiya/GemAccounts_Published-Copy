<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmReturnChange
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmReturnChange))
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnSave = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSaveAndClose = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCancel = New DevExpress.XtraBars.BarButtonItem()
        Me.btnClose = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.dtp = New System.Windows.Forms.DateTimePicker()
        Me.dg = New DevExpress.XtraGrid.GridControl()
        Me.dgview = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColBarcode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColStockID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColCarats = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColQty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColFloId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.riFlo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.DiaFloMasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Dia_MasterDataset = New GemAccounts.Dia_MasterDataset()
        Me.ColLedgerID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.riLedger = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.DiaLedgerMasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ColProcessID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.riProcess = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.DiaProcessMasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.riCut = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.DiaCutMasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.riPolish = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.DiaPolishMasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.riSym = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.DiaSymmMasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.riUSD = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.riINR = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.riShapeID = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.DiaShapeMasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridColumn17 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.riColorID = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.DiaColorMasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridColumn18 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.riClarityID = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.DiaClarityMasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridColumn19 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtStockID = New DevExpress.XtraEditors.TextEdit()
        Me.txtBarcode = New DevExpress.XtraEditors.TextEdit()
        Me.txtExRate = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.DiaFloMasterBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Dia_Shape_MasterTableAdapter = New GemAccounts.Dia_MasterDatasetTableAdapters.Dia_Shape_MasterTableAdapter()
        Me.Dia_Color_MasterTableAdapter = New GemAccounts.Dia_MasterDatasetTableAdapters.Dia_Color_MasterTableAdapter()
        Me.Dia_Clarity_MasterTableAdapter = New GemAccounts.Dia_MasterDatasetTableAdapters.Dia_Clarity_MasterTableAdapter()
        Me.Dia_Flo_MasterTableAdapter = New GemAccounts.Dia_MasterDatasetTableAdapters.Dia_Flo_MasterTableAdapter()
        Me.Dia_Process_MasterTableAdapter = New GemAccounts.Dia_MasterDatasetTableAdapters.Dia_Process_MasterTableAdapter()
        Me.Dia_Ledger_MasterTableAdapter = New GemAccounts.Dia_MasterDatasetTableAdapters.Dia_Ledger_MasterTableAdapter()
        Me.Dia_Cut_MasterTableAdapter = New GemAccounts.Dia_MasterDatasetTableAdapters.Dia_Cut_MasterTableAdapter()
        Me.Dia_Polish_MasterTableAdapter = New GemAccounts.Dia_MasterDatasetTableAdapters.Dia_Polish_MasterTableAdapter()
        Me.Dia_Symm_MasterTableAdapter = New GemAccounts.Dia_MasterDatasetTableAdapters.Dia_Symm_MasterTableAdapter()
        Me.btnLoadClipboard = New DevExpress.XtraBars.BarButtonItem()
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgview, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.riFlo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiaFloMasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dia_MasterDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.riLedger, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiaLedgerMasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.riProcess, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiaProcessMasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.riCut, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiaCutMasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.riPolish, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiaPolishMasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.riSym, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiaSymmMasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.riUSD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.riINR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.riShapeID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiaShapeMasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.riColorID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiaColorMasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.riClarityID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiaClarityMasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStockID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBarcode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtExRate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiaFloMasterBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl
        '
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.RibbonControl.SearchEditItem, Me.btnSave, Me.btnSaveAndClose, Me.btnCancel, Me.btnClose, Me.btnLoadClipboard})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 6
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl.Size = New System.Drawing.Size(800, 143)
        Me.RibbonControl.StatusBar = Me.RibbonStatusBar
        '
        'btnSave
        '
        Me.btnSave.Caption = "Save"
        Me.btnSave.Id = 1
        Me.btnSave.ImageOptions.SvgImage = CType(resources.GetObject("btnSave.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btnSave.Name = "btnSave"
        '
        'btnSaveAndClose
        '
        Me.btnSaveAndClose.Caption = "Save && Close"
        Me.btnSaveAndClose.Id = 2
        Me.btnSaveAndClose.ImageOptions.SvgImage = CType(resources.GetObject("btnSaveAndClose.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btnSaveAndClose.Name = "btnSaveAndClose"
        '
        'btnCancel
        '
        Me.btnCancel.Caption = "Cancel"
        Me.btnCancel.Id = 3
        Me.btnCancel.ImageOptions.SvgImage = CType(resources.GetObject("btnCancel.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btnCancel.Name = "btnCancel"
        '
        'btnClose
        '
        Me.btnClose.Caption = "Close"
        Me.btnClose.Id = 4
        Me.btnClose.ImageOptions.SvgImage = CType(resources.GetObject("btnClose.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btnClose.Name = "btnClose"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "Actions"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnSave)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnSaveAndClose)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnCancel)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnClose)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnLoadClipboard)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 446)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(800, 31)
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.dtp)
        Me.LayoutControl1.Controls.Add(Me.dg)
        Me.LayoutControl1.Controls.Add(Me.txtStockID)
        Me.LayoutControl1.Controls.Add(Me.txtBarcode)
        Me.LayoutControl1.Controls.Add(Me.txtExRate)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 143)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(800, 303)
        Me.LayoutControl1.TabIndex = 2
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'dtp
        '
        Me.dtp.CustomFormat = "dd-MM-yyyy"
        Me.dtp.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp.Location = New System.Drawing.Point(69, 42)
        Me.dtp.Name = "dtp"
        Me.dtp.Size = New System.Drawing.Size(166, 21)
        Me.dtp.TabIndex = 0
        '
        'dg
        '
        Me.dg.Location = New System.Drawing.Point(24, 90)
        Me.dg.MainView = Me.dgview
        Me.dg.MenuManager = Me.RibbonControl
        Me.dg.Name = "dg"
        Me.dg.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.riShapeID, Me.riColorID, Me.riClarityID, Me.riFlo, Me.riProcess, Me.riLedger, Me.riCut, Me.riPolish, Me.riSym, Me.riUSD, Me.riINR})
        Me.dg.Size = New System.Drawing.Size(783, 172)
        Me.dg.TabIndex = 9
        Me.dg.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.dgview})
        '
        'dgview
        '
        Me.dgview.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.dgview.Appearance.FocusedRow.Options.UseBackColor = True
        Me.dgview.Appearance.FooterPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.dgview.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Navy
        Me.dgview.Appearance.FooterPanel.Options.UseFont = True
        Me.dgview.Appearance.FooterPanel.Options.UseForeColor = True
        Me.dgview.Appearance.FooterPanel.Options.UseTextOptions = True
        Me.dgview.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.dgview.Appearance.FooterPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.dgview.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.dgview.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.dgview.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.dgview.Appearance.Row.Options.UseTextOptions = True
        Me.dgview.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.dgview.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.dgview.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColBarcode, Me.ColStockID, Me.ColCarats, Me.ColQty, Me.ColFloId, Me.ColLedgerID, Me.ColProcessID, Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.GridColumn10, Me.GridColumn11, Me.GridColumn12, Me.GridColumn13, Me.GridColumn15, Me.GridColumn16, Me.GridColumn17, Me.GridColumn18, Me.GridColumn19})
        Me.dgview.GridControl = Me.dg
        Me.dgview.Name = "dgview"
        Me.dgview.OptionsView.ColumnAutoWidth = False
        Me.dgview.OptionsView.ShowFooter = True
        Me.dgview.OptionsView.ShowGroupPanel = False
        '
        'ColBarcode
        '
        Me.ColBarcode.Caption = "Barcode"
        Me.ColBarcode.FieldName = "Barcode"
        Me.ColBarcode.Name = "ColBarcode"
        Me.ColBarcode.OptionsColumn.AllowEdit = False
        '
        'ColStockID
        '
        Me.ColStockID.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ColStockID.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ColStockID.AppearanceCell.Options.UseBackColor = True
        Me.ColStockID.AppearanceCell.Options.UseFont = True
        Me.ColStockID.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ColStockID.AppearanceHeader.Options.UseFont = True
        Me.ColStockID.Caption = "Stock ID"
        Me.ColStockID.FieldName = "StockID"
        Me.ColStockID.Name = "ColStockID"
        Me.ColStockID.OptionsColumn.AllowEdit = False
        Me.ColStockID.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "StockID", "{0}")})
        Me.ColStockID.Visible = True
        Me.ColStockID.VisibleIndex = 0
        '
        'ColCarats
        '
        Me.ColCarats.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ColCarats.AppearanceCell.Options.UseFont = True
        Me.ColCarats.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ColCarats.AppearanceHeader.Options.UseFont = True
        Me.ColCarats.AppearanceHeader.Options.UseTextOptions = True
        Me.ColCarats.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ColCarats.Caption = "Carats"
        Me.ColCarats.DisplayFormat.FormatString = "####0.00"
        Me.ColCarats.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColCarats.FieldName = "Carats"
        Me.ColCarats.Name = "ColCarats"
        Me.ColCarats.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Carats", "{0:####0.00}")})
        Me.ColCarats.Visible = True
        Me.ColCarats.VisibleIndex = 2
        Me.ColCarats.Width = 53
        '
        'ColQty
        '
        Me.ColQty.AppearanceHeader.Options.UseTextOptions = True
        Me.ColQty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ColQty.Caption = "Qty"
        Me.ColQty.FieldName = "Qty"
        Me.ColQty.Name = "ColQty"
        Me.ColQty.OptionsColumn.AllowEdit = False
        Me.ColQty.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.ColQty.Visible = True
        Me.ColQty.VisibleIndex = 1
        Me.ColQty.Width = 36
        '
        'ColFloId
        '
        Me.ColFloId.Caption = "Flour"
        Me.ColFloId.ColumnEdit = Me.riFlo
        Me.ColFloId.FieldName = "FloID"
        Me.ColFloId.Name = "ColFloId"
        Me.ColFloId.Visible = True
        Me.ColFloId.VisibleIndex = 6
        '
        'riFlo
        '
        Me.riFlo.AutoHeight = False
        Me.riFlo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.riFlo.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("flo_id", "flo_id", 49, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("flo_name", "", 54, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.riFlo.DataSource = Me.DiaFloMasterBindingSource
        Me.riFlo.DisplayMember = "flo_name"
        Me.riFlo.Name = "riFlo"
        Me.riFlo.ValueMember = "flo_id"
        '
        'DiaFloMasterBindingSource
        '
        Me.DiaFloMasterBindingSource.DataMember = "Dia_Flo_Master"
        Me.DiaFloMasterBindingSource.DataSource = Me.Dia_MasterDataset
        '
        'Dia_MasterDataset
        '
        Me.Dia_MasterDataset.DataSetName = "Dia_MasterDataset"
        Me.Dia_MasterDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ColLedgerID
        '
        Me.ColLedgerID.Caption = "Party"
        Me.ColLedgerID.ColumnEdit = Me.riLedger
        Me.ColLedgerID.FieldName = "LedgerID"
        Me.ColLedgerID.Name = "ColLedgerID"
        Me.ColLedgerID.OptionsColumn.AllowEdit = False
        Me.ColLedgerID.Visible = True
        Me.ColLedgerID.VisibleIndex = 7
        '
        'riLedger
        '
        Me.riLedger.AutoHeight = False
        Me.riLedger.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.riLedger.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("LedgerName", "", 73, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("LedgerID", "Ledger ID", 70, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.riLedger.DataSource = Me.DiaLedgerMasterBindingSource
        Me.riLedger.DisplayMember = "LedgerName"
        Me.riLedger.Name = "riLedger"
        Me.riLedger.ValueMember = "LedgerID"
        '
        'DiaLedgerMasterBindingSource
        '
        Me.DiaLedgerMasterBindingSource.DataMember = "Dia_Ledger_Master"
        Me.DiaLedgerMasterBindingSource.DataSource = Me.Dia_MasterDataset
        '
        'ColProcessID
        '
        Me.ColProcessID.Caption = "Process"
        Me.ColProcessID.ColumnEdit = Me.riProcess
        Me.ColProcessID.FieldName = "ProcessID"
        Me.ColProcessID.Name = "ColProcessID"
        Me.ColProcessID.OptionsColumn.AllowEdit = False
        Me.ColProcessID.Visible = True
        Me.ColProcessID.VisibleIndex = 8
        '
        'riProcess
        '
        Me.riProcess.AutoHeight = False
        Me.riProcess.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.riProcess.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ProcessName", "", 77, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ProcessID", "Process ID", 74, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.riProcess.DataSource = Me.DiaProcessMasterBindingSource
        Me.riProcess.DisplayMember = "ProcessName"
        Me.riProcess.Name = "riProcess"
        Me.riProcess.ValueMember = "ProcessID"
        '
        'DiaProcessMasterBindingSource
        '
        Me.DiaProcessMasterBindingSource.DataMember = "Dia_Process_Master"
        Me.DiaProcessMasterBindingSource.DataSource = Me.Dia_MasterDataset
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Cut"
        Me.GridColumn1.ColumnEdit = Me.riCut
        Me.GridColumn1.FieldName = "CutID"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 11
        '
        'riCut
        '
        Me.riCut.AutoHeight = False
        Me.riCut.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.riCut.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("cut_id", "cut_id", 52, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("cut_name", "", 57, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.riCut.DataSource = Me.DiaCutMasterBindingSource
        Me.riCut.DisplayMember = "cut_name"
        Me.riCut.Name = "riCut"
        Me.riCut.ValueMember = "cut_id"
        '
        'DiaCutMasterBindingSource
        '
        Me.DiaCutMasterBindingSource.DataMember = "Dia_Cut_Master"
        Me.DiaCutMasterBindingSource.DataSource = Me.Dia_MasterDataset
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Polish"
        Me.GridColumn2.ColumnEdit = Me.riPolish
        Me.GridColumn2.FieldName = "PolishID"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 12
        '
        'riPolish
        '
        Me.riPolish.AutoHeight = False
        Me.riPolish.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.riPolish.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("polish_id", "polish_id", 64, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("polish_name", "", 69, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.riPolish.DataSource = Me.DiaPolishMasterBindingSource
        Me.riPolish.DisplayMember = "polish_name"
        Me.riPolish.Name = "riPolish"
        Me.riPolish.ValueMember = "polish_id"
        '
        'DiaPolishMasterBindingSource
        '
        Me.DiaPolishMasterBindingSource.DataMember = "Dia_Polish_Master"
        Me.DiaPolishMasterBindingSource.DataSource = Me.Dia_MasterDataset
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Symmetry"
        Me.GridColumn3.ColumnEdit = Me.riSym
        Me.GridColumn3.FieldName = "SymID"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 13
        '
        'riSym
        '
        Me.riSym.AutoHeight = False
        Me.riSym.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.riSym.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("symm_id", "symm_id", 64, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("symm_name", "", 69, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.riSym.DataSource = Me.DiaSymmMasterBindingSource
        Me.riSym.DisplayMember = "symm_name"
        Me.riSym.Name = "riSym"
        Me.riSym.ValueMember = "symm_id"
        '
        'DiaSymmMasterBindingSource
        '
        Me.DiaSymmMasterBindingSource.DataMember = "Dia_Symm_Master"
        Me.DiaSymmMasterBindingSource.DataSource = Me.Dia_MasterDataset
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Table"
        Me.GridColumn4.FieldName = "LTable"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 14
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "TD"
        Me.GridColumn5.FieldName = "LTotalDepth"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 15
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Length"
        Me.GridColumn6.FieldName = "LLength"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 16
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Width"
        Me.GridColumn7.FieldName = "LWidth"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 17
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Depth"
        Me.GridColumn8.FieldName = "LDepth"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 18
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "CH"
        Me.GridColumn9.FieldName = "LCrownHeight"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 19
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "CA"
        Me.GridColumn10.FieldName = "LCrownAngle"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 20
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "PD"
        Me.GridColumn11.FieldName = "LPavillionDepth"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 21
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "PA"
        Me.GridColumn12.FieldName = "LPavillionAngle"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 22
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "Labour $"
        Me.GridColumn13.ColumnEdit = Me.riUSD
        Me.GridColumn13.FieldName = "LabourUSD"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "LabourUSD", "{0:0.##}")})
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 9
        '
        'riUSD
        '
        Me.riUSD.AutoHeight = False
        Me.riUSD.Mask.EditMask = "###,##,##,##0.00"
        Me.riUSD.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.riUSD.Mask.UseMaskAsDisplayFormat = True
        Me.riUSD.Name = "riUSD"
        Me.riUSD.NullText = "0.00"
        '
        'GridColumn15
        '
        Me.GridColumn15.Caption = "Labour INR"
        Me.GridColumn15.ColumnEdit = Me.riINR
        Me.GridColumn15.DisplayFormat.FormatString = "###,##,##,###0.00"
        Me.GridColumn15.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn15.FieldName = "LabourINR"
        Me.GridColumn15.Name = "GridColumn15"
        Me.GridColumn15.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "LabourINR", "{0:0.##}")})
        Me.GridColumn15.Visible = True
        Me.GridColumn15.VisibleIndex = 10
        '
        'riINR
        '
        Me.riINR.AutoHeight = False
        Me.riINR.Mask.EditMask = "###,##,##,##0.00"
        Me.riINR.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.riINR.Mask.UseMaskAsDisplayFormat = True
        Me.riINR.Name = "riINR"
        Me.riINR.NullText = "0.00"
        '
        'GridColumn16
        '
        Me.GridColumn16.Caption = "Shape"
        Me.GridColumn16.ColumnEdit = Me.riShapeID
        Me.GridColumn16.FieldName = "ShapeID"
        Me.GridColumn16.Name = "GridColumn16"
        Me.GridColumn16.Visible = True
        Me.GridColumn16.VisibleIndex = 3
        '
        'riShapeID
        '
        Me.riShapeID.AutoHeight = False
        Me.riShapeID.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.riShapeID.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Shape_ID", "ID", 70, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Shape_Name", "", 73, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.Ascending, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.riShapeID.DataSource = Me.DiaShapeMasterBindingSource
        Me.riShapeID.DisplayMember = "Shape_Name"
        Me.riShapeID.Name = "riShapeID"
        Me.riShapeID.SortColumnIndex = 1
        Me.riShapeID.ValueMember = "Shape_ID"
        '
        'DiaShapeMasterBindingSource
        '
        Me.DiaShapeMasterBindingSource.DataMember = "Dia_Shape_Master"
        Me.DiaShapeMasterBindingSource.DataSource = Me.Dia_MasterDataset
        '
        'GridColumn17
        '
        Me.GridColumn17.Caption = "Color"
        Me.GridColumn17.ColumnEdit = Me.riColorID
        Me.GridColumn17.FieldName = "ColorID"
        Me.GridColumn17.Name = "GridColumn17"
        Me.GridColumn17.Visible = True
        Me.GridColumn17.VisibleIndex = 4
        '
        'riColorID
        '
        Me.riColorID.AutoHeight = False
        Me.riColorID.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.riColorID.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("color_id", "color_id", 60, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("color_name", "", 65, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.Ascending, DevExpress.Utils.DefaultBoolean.[True])})
        Me.riColorID.DataSource = Me.DiaColorMasterBindingSource
        Me.riColorID.DisplayMember = "color_name"
        Me.riColorID.Name = "riColorID"
        Me.riColorID.SortColumnIndex = 1
        Me.riColorID.ValueMember = "color_id"
        '
        'DiaColorMasterBindingSource
        '
        Me.DiaColorMasterBindingSource.DataMember = "Dia_Color_Master"
        Me.DiaColorMasterBindingSource.DataSource = Me.Dia_MasterDataset
        '
        'GridColumn18
        '
        Me.GridColumn18.Caption = "Clarity"
        Me.GridColumn18.ColumnEdit = Me.riClarityID
        Me.GridColumn18.FieldName = "ClarityID"
        Me.GridColumn18.Name = "GridColumn18"
        Me.GridColumn18.Visible = True
        Me.GridColumn18.VisibleIndex = 5
        '
        'riClarityID
        '
        Me.riClarityID.AutoHeight = False
        Me.riClarityID.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.riClarityID.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("clarity_id", "clarity_id", 66, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[False]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("clarity_name", "", 71, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.Ascending, DevExpress.Utils.DefaultBoolean.[True])})
        Me.riClarityID.DataSource = Me.DiaClarityMasterBindingSource
        Me.riClarityID.DisplayMember = "clarity_name"
        Me.riClarityID.Name = "riClarityID"
        Me.riClarityID.ValueMember = "clarity_id"
        '
        'DiaClarityMasterBindingSource
        '
        Me.DiaClarityMasterBindingSource.DataMember = "Dia_Clarity_Master"
        Me.DiaClarityMasterBindingSource.DataSource = Me.Dia_MasterDataset
        '
        'GridColumn19
        '
        Me.GridColumn19.Caption = "Transcation#"
        Me.GridColumn19.FieldName = "TransactionID"
        Me.GridColumn19.Name = "GridColumn19"
        Me.GridColumn19.OptionsColumn.AllowEdit = False
        Me.GridColumn19.OptionsColumn.AllowShowHide = False
        '
        'txtStockID
        '
        Me.txtStockID.Location = New System.Drawing.Point(655, 42)
        Me.txtStockID.MenuManager = Me.RibbonControl
        Me.txtStockID.Name = "txtStockID"
        Me.txtStockID.Size = New System.Drawing.Size(142, 20)
        Me.txtStockID.StyleController = Me.LayoutControl1
        Me.txtStockID.TabIndex = 3
        '
        'txtBarcode
        '
        Me.txtBarcode.Location = New System.Drawing.Point(475, 42)
        Me.txtBarcode.MenuManager = Me.RibbonControl
        Me.txtBarcode.Name = "txtBarcode"
        Me.txtBarcode.Properties.Mask.EditMask = "#########"
        Me.txtBarcode.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtBarcode.Size = New System.Drawing.Size(131, 20)
        Me.txtBarcode.StyleController = Me.LayoutControl1
        Me.txtBarcode.TabIndex = 2
        '
        'txtExRate
        '
        Me.txtExRate.Location = New System.Drawing.Point(284, 42)
        Me.txtExRate.Name = "txtExRate"
        Me.txtExRate.Properties.Appearance.Options.UseTextOptions = True
        Me.txtExRate.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtExRate.Properties.Mask.EditMask = "#######0.000000"
        Me.txtExRate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtExRate.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtExRate.Size = New System.Drawing.Size(142, 20)
        Me.txtExRate.StyleController = Me.LayoutControl1
        Me.txtExRate.TabIndex = 1
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2, Me.LayoutControlGroup3})
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(831, 286)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem7, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.EmptySpaceItem1, Me.LayoutControlItem1})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(811, 66)
        Me.LayoutControlGroup2.Text = "Return From Process"
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.dtp
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem7.MaxSize = New System.Drawing.Size(215, 24)
        Me.LayoutControlItem7.MinSize = New System.Drawing.Size(215, 24)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(215, 24)
        Me.LayoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem7.Text = "Date"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(42, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.txtBarcode
        Me.LayoutControlItem4.Location = New System.Drawing.Point(406, 0)
        Me.LayoutControlItem4.MaxSize = New System.Drawing.Size(180, 24)
        Me.LayoutControlItem4.MinSize = New System.Drawing.Size(180, 24)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(180, 24)
        Me.LayoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem4.Text = "Barcode"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(42, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.txtStockID
        Me.LayoutControlItem5.Location = New System.Drawing.Point(586, 0)
        Me.LayoutControlItem5.MaxSize = New System.Drawing.Size(191, 24)
        Me.LayoutControlItem5.MinSize = New System.Drawing.Size(191, 24)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(191, 24)
        Me.LayoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem5.Text = "Stock ID"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(42, 13)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(777, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(10, 24)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.txtExRate
        Me.LayoutControlItem1.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem1.CustomizationFormText = "Stock ID"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(215, 0)
        Me.LayoutControlItem1.MaxSize = New System.Drawing.Size(191, 24)
        Me.LayoutControlItem1.MinSize = New System.Drawing.Size(191, 24)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(191, 24)
        Me.LayoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem1.Text = "Ex. Rate"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(42, 13)
        '
        'LayoutControlGroup3
        '
        Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem6})
        Me.LayoutControlGroup3.Location = New System.Drawing.Point(0, 66)
        Me.LayoutControlGroup3.Name = "LayoutControlGroup3"
        Me.LayoutControlGroup3.Size = New System.Drawing.Size(811, 200)
        Me.LayoutControlGroup3.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.dg
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(787, 176)
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'DiaFloMasterBindingSource1
        '
        Me.DiaFloMasterBindingSource1.DataMember = "Dia_Flo_Master"
        Me.DiaFloMasterBindingSource1.DataSource = Me.Dia_MasterDataset
        '
        'Dia_Shape_MasterTableAdapter
        '
        Me.Dia_Shape_MasterTableAdapter.ClearBeforeFill = True
        '
        'Dia_Color_MasterTableAdapter
        '
        Me.Dia_Color_MasterTableAdapter.ClearBeforeFill = True
        '
        'Dia_Clarity_MasterTableAdapter
        '
        Me.Dia_Clarity_MasterTableAdapter.ClearBeforeFill = True
        '
        'Dia_Flo_MasterTableAdapter
        '
        Me.Dia_Flo_MasterTableAdapter.ClearBeforeFill = True
        '
        'Dia_Process_MasterTableAdapter
        '
        Me.Dia_Process_MasterTableAdapter.ClearBeforeFill = True
        '
        'Dia_Ledger_MasterTableAdapter
        '
        Me.Dia_Ledger_MasterTableAdapter.ClearBeforeFill = True
        '
        'Dia_Cut_MasterTableAdapter
        '
        Me.Dia_Cut_MasterTableAdapter.ClearBeforeFill = True
        '
        'Dia_Polish_MasterTableAdapter
        '
        Me.Dia_Polish_MasterTableAdapter.ClearBeforeFill = True
        '
        'Dia_Symm_MasterTableAdapter
        '
        Me.Dia_Symm_MasterTableAdapter.ClearBeforeFill = True
        '
        'btnLoadClipboard
        '
        Me.btnLoadClipboard.Caption = "Load Clipboard"
        Me.btnLoadClipboard.Id = 5
        Me.btnLoadClipboard.ImageOptions.SvgImage = CType(resources.GetObject("BarButtonItem1.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btnLoadClipboard.Name = "btnLoadClipboard"
        '
        'FrmReturnChange
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 477)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl)
        Me.Name = "FrmReturnChange"
        Me.Ribbon = Me.RibbonControl
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "Return +  Change"
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgview, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.riFlo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiaFloMasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dia_MasterDataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.riLedger, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiaLedgerMasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.riProcess, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiaProcessMasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.riCut, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiaCutMasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.riPolish, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiaPolishMasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.riSym, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiaSymmMasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.riUSD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.riINR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.riShapeID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiaShapeMasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.riColorID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiaColorMasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.riClarityID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiaClarityMasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStockID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBarcode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtExRate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiaFloMasterBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents btnSave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSaveAndClose As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCancel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnClose As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents dg As DevExpress.XtraGrid.GridControl
    Friend WithEvents dgview As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtStockID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtBarcode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents dtp As DateTimePicker
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ColBarcode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColStockID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColCarats As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColFloId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColLedgerID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColProcessID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn16 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn17 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn18 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents riShapeID As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Dia_MasterDataset As Dia_MasterDataset
    Friend WithEvents DiaShapeMasterBindingSource As BindingSource
    Friend WithEvents Dia_Shape_MasterTableAdapter As Dia_MasterDatasetTableAdapters.Dia_Shape_MasterTableAdapter
    Friend WithEvents riColorID As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents DiaColorMasterBindingSource As BindingSource
    Friend WithEvents Dia_Color_MasterTableAdapter As Dia_MasterDatasetTableAdapters.Dia_Color_MasterTableAdapter
    Friend WithEvents riClarityID As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents DiaClarityMasterBindingSource As BindingSource
    Friend WithEvents Dia_Clarity_MasterTableAdapter As Dia_MasterDatasetTableAdapters.Dia_Clarity_MasterTableAdapter
    Friend WithEvents riFlo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents DiaFloMasterBindingSource As BindingSource
    Friend WithEvents Dia_Flo_MasterTableAdapter As Dia_MasterDatasetTableAdapters.Dia_Flo_MasterTableAdapter
    Friend WithEvents riProcess As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents DiaProcessMasterBindingSource As BindingSource
    Friend WithEvents Dia_Process_MasterTableAdapter As Dia_MasterDatasetTableAdapters.Dia_Process_MasterTableAdapter
    Friend WithEvents riLedger As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents DiaLedgerMasterBindingSource As BindingSource
    Friend WithEvents Dia_Ledger_MasterTableAdapter As Dia_MasterDatasetTableAdapters.Dia_Ledger_MasterTableAdapter
    Friend WithEvents riCut As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents DiaCutMasterBindingSource As BindingSource
    Friend WithEvents Dia_Cut_MasterTableAdapter As Dia_MasterDatasetTableAdapters.Dia_Cut_MasterTableAdapter
    Friend WithEvents riPolish As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents DiaPolishMasterBindingSource As BindingSource
    Friend WithEvents Dia_Polish_MasterTableAdapter As Dia_MasterDatasetTableAdapters.Dia_Polish_MasterTableAdapter
    Friend WithEvents riSym As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents DiaFloMasterBindingSource1 As BindingSource
    Friend WithEvents DiaSymmMasterBindingSource As BindingSource
    Friend WithEvents Dia_Symm_MasterTableAdapter As Dia_MasterDatasetTableAdapters.Dia_Symm_MasterTableAdapter
    Friend WithEvents GridColumn19 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtExRate As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents riUSD As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents riINR As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents btnLoadClipboard As DevExpress.XtraBars.BarButtonItem
End Class
