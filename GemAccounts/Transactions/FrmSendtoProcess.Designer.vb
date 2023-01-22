<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmSendtoProcess
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSendtoProcess))
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnSave = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSaveClose = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCancel = New DevExpress.XtraBars.BarButtonItem()
        Me.btnClose = New DevExpress.XtraBars.BarButtonItem()
        Me.btnLoadClipboard = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.LayoutControl2 = New DevExpress.XtraLayout.LayoutControl()
        Me.dgnew = New DevExpress.XtraGrid.GridControl()
        Me.newView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColBarcode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColShape = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.riShape = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.DiaShapeMasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DIA_MASTERDataSet = New GemAccounts.Dia_MasterDataset()
        Me.ColColor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.riColor = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.DiaColorMasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ColClarity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.riClarity = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.DiaClarityMasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ColStockID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColCarats = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.riCarats = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.ColQty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColFloId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.riFlo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.DiaFloMasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtstockid = New DevExpress.XtraEditors.TextEdit()
        Me.txtbarcode = New DevExpress.XtraEditors.TextEdit()
        Me.cmblocation = New System.Windows.Forms.ComboBox()
        Me.cmbProcess = New System.Windows.Forms.ComboBox()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControl3 = New DevExpress.XtraLayout.LayoutControl()
        Me.dgList = New DevExpress.XtraGrid.GridControl()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.menuEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.listView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colTransactionID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBarcode1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUserID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit8 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.DiaUserMasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colItemTypeID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.DiaItemTypeMasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colStockID1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQty1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCarats1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colShapeID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colColorID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colClarityID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colFloID1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit5 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colExecutionDateTime = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.colLedgerID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit6 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.DiaLedgerMasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colProcessID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit7 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.DiaProcessMasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ColUnionID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup5 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControl4 = New DevExpress.XtraLayout.LayoutControl()
        Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.Dia_Shape_MasterTableAdapter = New GemAccounts.Dia_MasterDatasetTableAdapters.Dia_Shape_MasterTableAdapter()
        Me.Dia_Color_MasterTableAdapter = New GemAccounts.Dia_MasterDatasetTableAdapters.Dia_Color_MasterTableAdapter()
        Me.Dia_Clarity_MasterTableAdapter = New GemAccounts.Dia_MasterDatasetTableAdapters.Dia_Clarity_MasterTableAdapter()
        Me.Dia_Flo_MasterTableAdapter = New GemAccounts.Dia_MasterDatasetTableAdapters.Dia_Flo_MasterTableAdapter()
        Me.Dia_Item_Type_MasterTableAdapter = New GemAccounts.Dia_MasterDatasetTableAdapters.Dia_Item_Type_MasterTableAdapter()
        Me.Dia_Ledger_MasterTableAdapter = New GemAccounts.Dia_MasterDatasetTableAdapters.Dia_Ledger_MasterTableAdapter()
        Me.Dia_Process_MasterTableAdapter = New GemAccounts.Dia_MasterDatasetTableAdapters.Dia_Process_MasterTableAdapter()
        Me.Dia_User_MasterTableAdapter = New GemAccounts.Dia_MasterDatasetTableAdapters.Dia_User_MasterTableAdapter()
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl2.SuspendLayout()
        CType(Me.dgnew, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.newView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.riShape, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiaShapeMasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DIA_MASTERDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.riColor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiaColorMasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.riClarity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiaClarityMasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.riCarats, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.riFlo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiaFloMasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtstockid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtbarcode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl3.SuspendLayout()
        CType(Me.dgList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.listView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiaUserMasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiaItemTypeMasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiaLedgerMasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiaProcessMasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl4.SuspendLayout()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl
        '
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.RibbonControl.SearchEditItem, Me.btnSave, Me.btnSaveClose, Me.btnCancel, Me.btnClose, Me.btnLoadClipboard})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 6
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl.Size = New System.Drawing.Size(963, 143)
        Me.RibbonControl.StatusBar = Me.RibbonStatusBar
        '
        'btnSave
        '
        Me.btnSave.Caption = "Save"
        Me.btnSave.Id = 1
        Me.btnSave.ImageOptions.SvgImage = CType(resources.GetObject("btnSave.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btnSave.Name = "btnSave"
        '
        'btnSaveClose
        '
        Me.btnSaveClose.Caption = "Save && Close"
        Me.btnSaveClose.Id = 2
        Me.btnSaveClose.ImageOptions.SvgImage = CType(resources.GetObject("btnSaveClose.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btnSaveClose.Name = "btnSaveClose"
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
        'btnLoadClipboard
        '
        Me.btnLoadClipboard.Caption = "Load Clipboard"
        Me.btnLoadClipboard.Id = 5
        Me.btnLoadClipboard.ImageOptions.SvgImage = CType(resources.GetObject("btnLoadClipboard.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btnLoadClipboard.Name = "btnLoadClipboard"
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
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnSaveClose)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnLoadClipboard)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnCancel)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnClose)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "Actions"
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 602)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(963, 31)
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.SplitContainerControl1)
        Me.LayoutControl1.Location = New System.Drawing.Point(4, 4)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(955, 451)
        Me.LayoutControl1.TabIndex = 2
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Location = New System.Drawing.Point(7, 7)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.LayoutControl2)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.LayoutControl3)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(941, 437)
        Me.SplitContainerControl1.SplitterPosition = 450
        Me.SplitContainerControl1.TabIndex = 10
        '
        'LayoutControl2
        '
        Me.LayoutControl2.Controls.Add(Me.dgnew)
        Me.LayoutControl2.Controls.Add(Me.txtstockid)
        Me.LayoutControl2.Controls.Add(Me.txtbarcode)
        Me.LayoutControl2.Controls.Add(Me.cmblocation)
        Me.LayoutControl2.Controls.Add(Me.cmbProcess)
        Me.LayoutControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl2.Name = "LayoutControl2"
        Me.LayoutControl2.Root = Me.LayoutControlGroup1
        Me.LayoutControl2.Size = New System.Drawing.Size(450, 437)
        Me.LayoutControl2.TabIndex = 0
        Me.LayoutControl2.Text = "LayoutControl2"
        '
        'dgnew
        '
        Me.dgnew.Location = New System.Drawing.Point(8, 100)
        Me.dgnew.MainView = Me.newView
        Me.dgnew.MenuManager = Me.RibbonControl
        Me.dgnew.Name = "dgnew"
        Me.dgnew.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.riShape, Me.riColor, Me.riClarity, Me.riFlo, Me.riCarats})
        Me.dgnew.Size = New System.Drawing.Size(434, 329)
        Me.dgnew.TabIndex = 8
        Me.dgnew.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.newView})
        '
        'newView
        '
        Me.newView.Appearance.FooterPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.newView.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Navy
        Me.newView.Appearance.FooterPanel.Options.UseFont = True
        Me.newView.Appearance.FooterPanel.Options.UseForeColor = True
        Me.newView.Appearance.FooterPanel.Options.UseTextOptions = True
        Me.newView.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.newView.Appearance.FooterPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.newView.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.newView.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.newView.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.newView.Appearance.Row.Options.UseTextOptions = True
        Me.newView.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.newView.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.newView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColBarcode, Me.ColShape, Me.ColColor, Me.ColClarity, Me.ColStockID, Me.ColCarats, Me.ColQty, Me.ColFloId})
        Me.newView.GridControl = Me.dgnew
        Me.newView.Name = "newView"
        Me.newView.OptionsView.ColumnAutoWidth = False
        Me.newView.OptionsView.ShowFooter = True
        Me.newView.OptionsView.ShowGroupPanel = False
        '
        'ColBarcode
        '
        Me.ColBarcode.Caption = "Barcode"
        Me.ColBarcode.FieldName = "Barcode"
        Me.ColBarcode.Name = "ColBarcode"
        '
        'ColShape
        '
        Me.ColShape.Caption = "Shape"
        Me.ColShape.ColumnEdit = Me.riShape
        Me.ColShape.FieldName = "ShapeID"
        Me.ColShape.Name = "ColShape"
        Me.ColShape.Visible = True
        Me.ColShape.VisibleIndex = 3
        '
        'riShape
        '
        Me.riShape.AutoHeight = False
        Me.riShape.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.riShape.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Shape_ID", "", 70, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Shape_Name", "", 73, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.riShape.DataSource = Me.DiaShapeMasterBindingSource
        Me.riShape.DisplayMember = "Shape_Name"
        Me.riShape.Name = "riShape"
        Me.riShape.ShowHeader = False
        Me.riShape.ValueMember = "Shape_ID"
        '
        'DiaShapeMasterBindingSource
        '
        Me.DiaShapeMasterBindingSource.DataMember = "Dia_Shape_Master"
        Me.DiaShapeMasterBindingSource.DataSource = Me.DIA_MASTERDataSet
        '
        'DIA_MASTERDataSet
        '
        Me.DIA_MASTERDataSet.DataSetName = "DIA_MASTERDataSet"
        Me.DIA_MASTERDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ColColor
        '
        Me.ColColor.Caption = "Color"
        Me.ColColor.ColumnEdit = Me.riColor
        Me.ColColor.FieldName = "ColorID"
        Me.ColColor.Name = "ColColor"
        Me.ColColor.Visible = True
        Me.ColColor.VisibleIndex = 4
        Me.ColColor.Width = 42
        '
        'riColor
        '
        Me.riColor.AutoHeight = False
        Me.riColor.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.riColor.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("color_id", "color_id", 60, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("color_name", "color_name", 65, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.riColor.DataSource = Me.DiaColorMasterBindingSource
        Me.riColor.DisplayMember = "color_name"
        Me.riColor.Name = "riColor"
        Me.riColor.ShowHeader = False
        Me.riColor.ValueMember = "color_id"
        '
        'DiaColorMasterBindingSource
        '
        Me.DiaColorMasterBindingSource.DataMember = "Dia_Color_Master"
        Me.DiaColorMasterBindingSource.DataSource = Me.DIA_MASTERDataSet
        '
        'ColClarity
        '
        Me.ColClarity.Caption = "Clarity"
        Me.ColClarity.ColumnEdit = Me.riClarity
        Me.ColClarity.FieldName = "ClarityID"
        Me.ColClarity.Name = "ColClarity"
        Me.ColClarity.Visible = True
        Me.ColClarity.VisibleIndex = 5
        Me.ColClarity.Width = 47
        '
        'riClarity
        '
        Me.riClarity.AutoHeight = False
        Me.riClarity.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.riClarity.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("clarity_id", "clarity_id", 66, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("clarity_name", "clarity_name", 71, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.riClarity.DataSource = Me.DiaClarityMasterBindingSource
        Me.riClarity.DisplayMember = "clarity_name"
        Me.riClarity.Name = "riClarity"
        Me.riClarity.ShowHeader = False
        Me.riClarity.ValueMember = "clarity_id"
        '
        'DiaClarityMasterBindingSource
        '
        Me.DiaClarityMasterBindingSource.DataMember = "Dia_Clarity_Master"
        Me.DiaClarityMasterBindingSource.DataSource = Me.DIA_MASTERDataSet
        '
        'ColStockID
        '
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
        Me.ColCarats.AppearanceHeader.Options.UseTextOptions = True
        Me.ColCarats.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ColCarats.Caption = "Carats"
        Me.ColCarats.ColumnEdit = Me.riCarats
        Me.ColCarats.FieldName = "Carats"
        Me.ColCarats.Name = "ColCarats"
        Me.ColCarats.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Carats", "{0:n2}")})
        Me.ColCarats.Visible = True
        Me.ColCarats.VisibleIndex = 2
        Me.ColCarats.Width = 53
        '
        'riCarats
        '
        Me.riCarats.AutoHeight = False
        Me.riCarats.DisplayFormat.FormatString = "n2"
        Me.riCarats.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.riCarats.Mask.EditMask = "n2"
        Me.riCarats.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.riCarats.Mask.UseMaskAsDisplayFormat = True
        Me.riCarats.Name = "riCarats"
        '
        'ColQty
        '
        Me.ColQty.AppearanceHeader.Options.UseTextOptions = True
        Me.ColQty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ColQty.Caption = "Qty"
        Me.ColQty.FieldName = "Qty"
        Me.ColQty.Name = "ColQty"
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
        Me.riFlo.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("flo_id", "flo_id", 49, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("flo_name", "flo_name", 54, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.riFlo.DataSource = Me.DiaFloMasterBindingSource
        Me.riFlo.DisplayMember = "flo_name"
        Me.riFlo.Name = "riFlo"
        Me.riFlo.ShowHeader = False
        Me.riFlo.ValueMember = "flo_id"
        '
        'DiaFloMasterBindingSource
        '
        Me.DiaFloMasterBindingSource.DataMember = "Dia_Flo_Master"
        Me.DiaFloMasterBindingSource.DataSource = Me.DIA_MASTERDataSet
        '
        'txtstockid
        '
        Me.txtstockid.Location = New System.Drawing.Point(270, 76)
        Me.txtstockid.MenuManager = Me.RibbonControl
        Me.txtstockid.Name = "txtstockid"
        Me.txtstockid.Size = New System.Drawing.Size(172, 20)
        Me.txtstockid.StyleController = Me.LayoutControl2
        Me.txtstockid.TabIndex = 7
        '
        'txtbarcode
        '
        Me.txtbarcode.Location = New System.Drawing.Point(51, 76)
        Me.txtbarcode.MenuManager = Me.RibbonControl
        Me.txtbarcode.Name = "txtbarcode"
        Me.txtbarcode.Size = New System.Drawing.Size(172, 20)
        Me.txtbarcode.StyleController = Me.LayoutControl2
        Me.txtbarcode.TabIndex = 6
        '
        'cmblocation
        '
        Me.cmblocation.FormattingEnabled = True
        Me.cmblocation.Location = New System.Drawing.Point(51, 51)
        Me.cmblocation.Name = "cmblocation"
        Me.cmblocation.Size = New System.Drawing.Size(391, 21)
        Me.cmblocation.TabIndex = 5
        '
        'cmbProcess
        '
        Me.cmbProcess.FormattingEnabled = True
        Me.cmbProcess.Location = New System.Drawing.Point(51, 26)
        Me.cmbProcess.Name = "cmbProcess"
        Me.cmbProcess.Size = New System.Drawing.Size(391, 21)
        Me.cmbProcess.TabIndex = 4
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup4})
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(450, 437)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlGroup4
        '
        Me.LayoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem5, Me.LayoutControlItem4})
        Me.LayoutControlGroup4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup4.Name = "LayoutControlGroup4"
        Me.LayoutControlGroup4.Padding = New DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3)
        Me.LayoutControlGroup4.Size = New System.Drawing.Size(450, 437)
        Me.LayoutControlGroup4.Text = "New Send to Process"
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.cmbProcess
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(438, 25)
        Me.LayoutControlItem1.Text = "Process"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(40, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.cmblocation
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 25)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(438, 25)
        Me.LayoutControlItem2.Text = "Location"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(40, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.txtbarcode
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 50)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(219, 24)
        Me.LayoutControlItem3.Text = "Barcode"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(40, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.dgnew
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 74)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(438, 333)
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.txtstockid
        Me.LayoutControlItem4.Location = New System.Drawing.Point(219, 50)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(219, 24)
        Me.LayoutControlItem4.Text = "Stock ID"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(40, 13)
        '
        'LayoutControl3
        '
        Me.LayoutControl3.Controls.Add(Me.dgList)
        Me.LayoutControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl3.Name = "LayoutControl3"
        Me.LayoutControl3.Root = Me.LayoutControlGroup2
        Me.LayoutControl3.Size = New System.Drawing.Size(486, 437)
        Me.LayoutControl3.TabIndex = 0
        Me.LayoutControl3.Text = "LayoutControl3"
        '
        'dgList
        '
        Me.dgList.ContextMenuStrip = Me.ContextMenuStrip1
        Me.dgList.Location = New System.Drawing.Point(14, 32)
        Me.dgList.MainView = Me.listView
        Me.dgList.MenuManager = Me.RibbonControl
        Me.dgList.Name = "dgList"
        Me.dgList.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1, Me.RepositoryItemLookUpEdit2, Me.RepositoryItemLookUpEdit3, Me.RepositoryItemLookUpEdit4, Me.RepositoryItemLookUpEdit5, Me.RepositoryItemDateEdit1, Me.RepositoryItemLookUpEdit6, Me.RepositoryItemLookUpEdit7, Me.RepositoryItemLookUpEdit8})
        Me.dgList.Size = New System.Drawing.Size(458, 391)
        Me.dgList.TabIndex = 4
        Me.dgList.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.listView})
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuEdit, Me.MenuDelete})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(108, 48)
        '
        'menuEdit
        '
        Me.menuEdit.Name = "menuEdit"
        Me.menuEdit.Size = New System.Drawing.Size(107, 22)
        Me.menuEdit.Text = "Edit"
        '
        'MenuDelete
        '
        Me.MenuDelete.Name = "MenuDelete"
        Me.MenuDelete.Size = New System.Drawing.Size(107, 22)
        Me.MenuDelete.Text = "Delete"
        '
        'listView
        '
        Me.listView.Appearance.FooterPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.listView.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Navy
        Me.listView.Appearance.FooterPanel.Options.UseFont = True
        Me.listView.Appearance.FooterPanel.Options.UseForeColor = True
        Me.listView.Appearance.FooterPanel.Options.UseTextOptions = True
        Me.listView.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.listView.Appearance.FooterPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.listView.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.listView.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.listView.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.listView.Appearance.Row.Options.UseTextOptions = True
        Me.listView.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.listView.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.listView.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.listView.Appearance.SelectedRow.Options.UseBackColor = True
        Me.listView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colTransactionID, Me.colBarcode1, Me.colUserID, Me.colItemTypeID, Me.colStockID1, Me.colQty1, Me.colCarats1, Me.colShapeID, Me.colColorID, Me.colClarityID, Me.colFloID1, Me.colExecutionDateTime, Me.colLedgerID, Me.colProcessID, Me.ColUnionID})
        Me.listView.GridControl = Me.dgList
        Me.listView.Name = "listView"
        Me.listView.OptionsBehavior.Editable = False
        Me.listView.OptionsView.ColumnAutoWidth = False
        Me.listView.OptionsView.ShowFooter = True
        Me.listView.OptionsView.ShowGroupPanel = False
        '
        'colTransactionID
        '
        Me.colTransactionID.Caption = "Trn #"
        Me.colTransactionID.FieldName = "TransactionID"
        Me.colTransactionID.Name = "colTransactionID"
        Me.colTransactionID.Visible = True
        Me.colTransactionID.VisibleIndex = 0
        Me.colTransactionID.Width = 53
        '
        'colBarcode1
        '
        Me.colBarcode1.Caption = "Barcode"
        Me.colBarcode1.FieldName = "Barcode"
        Me.colBarcode1.Name = "colBarcode1"
        Me.colBarcode1.Visible = True
        Me.colBarcode1.VisibleIndex = 3
        '
        'colUserID
        '
        Me.colUserID.Caption = "User"
        Me.colUserID.ColumnEdit = Me.RepositoryItemLookUpEdit8
        Me.colUserID.FieldName = "UserID"
        Me.colUserID.Name = "colUserID"
        Me.colUserID.Visible = True
        Me.colUserID.VisibleIndex = 13
        '
        'RepositoryItemLookUpEdit8
        '
        Me.RepositoryItemLookUpEdit8.AutoHeight = False
        Me.RepositoryItemLookUpEdit8.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit8.DataSource = Me.DiaUserMasterBindingSource
        Me.RepositoryItemLookUpEdit8.DisplayMember = "user_name"
        Me.RepositoryItemLookUpEdit8.Name = "RepositoryItemLookUpEdit8"
        Me.RepositoryItemLookUpEdit8.ValueMember = "user_id"
        '
        'DiaUserMasterBindingSource
        '
        Me.DiaUserMasterBindingSource.DataMember = "Dia_User_Master"
        Me.DiaUserMasterBindingSource.DataSource = Me.DIA_MASTERDataSet
        '
        'colItemTypeID
        '
        Me.colItemTypeID.Caption = "Item Type"
        Me.colItemTypeID.ColumnEdit = Me.RepositoryItemLookUpEdit1
        Me.colItemTypeID.FieldName = "ItemTypeID"
        Me.colItemTypeID.Name = "colItemTypeID"
        Me.colItemTypeID.Visible = True
        Me.colItemTypeID.VisibleIndex = 12
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.DataSource = Me.DiaItemTypeMasterBindingSource
        Me.RepositoryItemLookUpEdit1.DisplayMember = "item_type_name"
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.ValueMember = "item_type_id"
        '
        'DiaItemTypeMasterBindingSource
        '
        Me.DiaItemTypeMasterBindingSource.DataMember = "Dia_Item_Type_Master"
        Me.DiaItemTypeMasterBindingSource.DataSource = Me.DIA_MASTERDataSet
        '
        'colStockID1
        '
        Me.colStockID1.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colStockID1.AppearanceCell.ForeColor = System.Drawing.Color.Green
        Me.colStockID1.AppearanceCell.Options.UseFont = True
        Me.colStockID1.AppearanceCell.Options.UseForeColor = True
        Me.colStockID1.Caption = "Stock ID"
        Me.colStockID1.FieldName = "StockID"
        Me.colStockID1.Name = "colStockID1"
        Me.colStockID1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "StockID", "{0}")})
        Me.colStockID1.Visible = True
        Me.colStockID1.VisibleIndex = 2
        '
        'colQty1
        '
        Me.colQty1.Caption = "Qty"
        Me.colQty1.DisplayFormat.FormatString = "########"
        Me.colQty1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colQty1.FieldName = "Qty"
        Me.colQty1.Name = "colQty1"
        Me.colQty1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Qty", "{0:########}")})
        Me.colQty1.Visible = True
        Me.colQty1.VisibleIndex = 4
        Me.colQty1.Width = 43
        '
        'colCarats1
        '
        Me.colCarats1.Caption = "Carats"
        Me.colCarats1.DisplayFormat.FormatString = "#####.00"
        Me.colCarats1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colCarats1.FieldName = "Carats"
        Me.colCarats1.Name = "colCarats1"
        Me.colCarats1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Carats", "{0:#####.00}")})
        Me.colCarats1.Visible = True
        Me.colCarats1.VisibleIndex = 5
        Me.colCarats1.Width = 52
        '
        'colShapeID
        '
        Me.colShapeID.Caption = "Shape"
        Me.colShapeID.ColumnEdit = Me.RepositoryItemLookUpEdit2
        Me.colShapeID.FieldName = "ShapeID"
        Me.colShapeID.Name = "colShapeID"
        Me.colShapeID.Visible = True
        Me.colShapeID.VisibleIndex = 8
        '
        'RepositoryItemLookUpEdit2
        '
        Me.RepositoryItemLookUpEdit2.AutoHeight = False
        Me.RepositoryItemLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit2.DataSource = Me.DiaShapeMasterBindingSource
        Me.RepositoryItemLookUpEdit2.DisplayMember = "Shape_Name"
        Me.RepositoryItemLookUpEdit2.Name = "RepositoryItemLookUpEdit2"
        Me.RepositoryItemLookUpEdit2.ValueMember = "Shape_ID"
        '
        'colColorID
        '
        Me.colColorID.Caption = "Color"
        Me.colColorID.ColumnEdit = Me.RepositoryItemLookUpEdit3
        Me.colColorID.FieldName = "ColorID"
        Me.colColorID.Name = "colColorID"
        Me.colColorID.Visible = True
        Me.colColorID.VisibleIndex = 9
        '
        'RepositoryItemLookUpEdit3
        '
        Me.RepositoryItemLookUpEdit3.AutoHeight = False
        Me.RepositoryItemLookUpEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit3.DataSource = Me.DiaColorMasterBindingSource
        Me.RepositoryItemLookUpEdit3.DisplayMember = "color_name"
        Me.RepositoryItemLookUpEdit3.Name = "RepositoryItemLookUpEdit3"
        Me.RepositoryItemLookUpEdit3.ValueMember = "color_id"
        '
        'colClarityID
        '
        Me.colClarityID.Caption = "Clarity"
        Me.colClarityID.ColumnEdit = Me.RepositoryItemLookUpEdit4
        Me.colClarityID.FieldName = "ClarityID"
        Me.colClarityID.Name = "colClarityID"
        Me.colClarityID.Visible = True
        Me.colClarityID.VisibleIndex = 10
        '
        'RepositoryItemLookUpEdit4
        '
        Me.RepositoryItemLookUpEdit4.AutoHeight = False
        Me.RepositoryItemLookUpEdit4.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit4.DataSource = Me.DiaClarityMasterBindingSource
        Me.RepositoryItemLookUpEdit4.DisplayMember = "clarity_name"
        Me.RepositoryItemLookUpEdit4.Name = "RepositoryItemLookUpEdit4"
        Me.RepositoryItemLookUpEdit4.ValueMember = "clarity_id"
        '
        'colFloID1
        '
        Me.colFloID1.Caption = "Flour."
        Me.colFloID1.ColumnEdit = Me.RepositoryItemLookUpEdit5
        Me.colFloID1.FieldName = "FloID"
        Me.colFloID1.Name = "colFloID1"
        Me.colFloID1.Visible = True
        Me.colFloID1.VisibleIndex = 11
        '
        'RepositoryItemLookUpEdit5
        '
        Me.RepositoryItemLookUpEdit5.AutoHeight = False
        Me.RepositoryItemLookUpEdit5.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit5.DataSource = Me.DiaFloMasterBindingSource
        Me.RepositoryItemLookUpEdit5.DisplayMember = "flo_name"
        Me.RepositoryItemLookUpEdit5.Name = "RepositoryItemLookUpEdit5"
        Me.RepositoryItemLookUpEdit5.ValueMember = "flo_id"
        '
        'colExecutionDateTime
        '
        Me.colExecutionDateTime.Caption = "Date"
        Me.colExecutionDateTime.ColumnEdit = Me.RepositoryItemDateEdit1
        Me.colExecutionDateTime.DisplayFormat.FormatString = "d"
        Me.colExecutionDateTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colExecutionDateTime.FieldName = "ExecutionDateTime"
        Me.colExecutionDateTime.Name = "colExecutionDateTime"
        Me.colExecutionDateTime.Visible = True
        Me.colExecutionDateTime.VisibleIndex = 1
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        '
        'colLedgerID
        '
        Me.colLedgerID.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colLedgerID.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colLedgerID.AppearanceCell.Options.UseFont = True
        Me.colLedgerID.AppearanceCell.Options.UseForeColor = True
        Me.colLedgerID.Caption = "Party Name"
        Me.colLedgerID.ColumnEdit = Me.RepositoryItemLookUpEdit6
        Me.colLedgerID.FieldName = "LedgerID"
        Me.colLedgerID.Name = "colLedgerID"
        Me.colLedgerID.Visible = True
        Me.colLedgerID.VisibleIndex = 7
        Me.colLedgerID.Width = 116
        '
        'RepositoryItemLookUpEdit6
        '
        Me.RepositoryItemLookUpEdit6.AutoHeight = False
        Me.RepositoryItemLookUpEdit6.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit6.DataSource = Me.DiaLedgerMasterBindingSource
        Me.RepositoryItemLookUpEdit6.DisplayMember = "LedgerName"
        Me.RepositoryItemLookUpEdit6.Name = "RepositoryItemLookUpEdit6"
        Me.RepositoryItemLookUpEdit6.ValueMember = "LedgerID"
        '
        'DiaLedgerMasterBindingSource
        '
        Me.DiaLedgerMasterBindingSource.DataMember = "Dia_Ledger_Master"
        Me.DiaLedgerMasterBindingSource.DataSource = Me.DIA_MASTERDataSet
        '
        'colProcessID
        '
        Me.colProcessID.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colProcessID.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.colProcessID.AppearanceCell.Options.UseFont = True
        Me.colProcessID.AppearanceCell.Options.UseForeColor = True
        Me.colProcessID.Caption = "Process"
        Me.colProcessID.ColumnEdit = Me.RepositoryItemLookUpEdit7
        Me.colProcessID.FieldName = "ProcessID"
        Me.colProcessID.Name = "colProcessID"
        Me.colProcessID.Visible = True
        Me.colProcessID.VisibleIndex = 6
        Me.colProcessID.Width = 103
        '
        'RepositoryItemLookUpEdit7
        '
        Me.RepositoryItemLookUpEdit7.AutoHeight = False
        Me.RepositoryItemLookUpEdit7.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit7.DataSource = Me.DiaProcessMasterBindingSource
        Me.RepositoryItemLookUpEdit7.DisplayMember = "ProcessName"
        Me.RepositoryItemLookUpEdit7.Name = "RepositoryItemLookUpEdit7"
        Me.RepositoryItemLookUpEdit7.ValueMember = "ProcessID"
        '
        'DiaProcessMasterBindingSource
        '
        Me.DiaProcessMasterBindingSource.DataMember = "Dia_Process_Master"
        Me.DiaProcessMasterBindingSource.DataSource = Me.DIA_MASTERDataSet
        '
        'ColUnionID
        '
        Me.ColUnionID.Caption = "Union ID"
        Me.ColUnionID.FieldName = "UnionID"
        Me.ColUnionID.Name = "ColUnionID"
        Me.ColUnionID.Visible = True
        Me.ColUnionID.VisibleIndex = 14
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup5})
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(486, 437)
        Me.LayoutControlGroup2.TextVisible = False
        '
        'LayoutControlGroup5
        '
        Me.LayoutControlGroup5.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem6})
        Me.LayoutControlGroup5.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup5.Name = "LayoutControlGroup5"
        Me.LayoutControlGroup5.Size = New System.Drawing.Size(486, 437)
        Me.LayoutControlGroup5.Text = "Sent to Process List"
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.dgList
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(462, 395)
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem7})
        Me.Root.Name = "Root"
        Me.Root.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.Root.Size = New System.Drawing.Size(955, 451)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.SplitContainerControl1
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(945, 441)
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'LayoutControl4
        '
        Me.LayoutControl4.Controls.Add(Me.LayoutControl1)
        Me.LayoutControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl4.Location = New System.Drawing.Point(0, 143)
        Me.LayoutControl4.Name = "LayoutControl4"
        Me.LayoutControl4.Root = Me.LayoutControlGroup3
        Me.LayoutControl4.Size = New System.Drawing.Size(963, 459)
        Me.LayoutControl4.TabIndex = 5
        Me.LayoutControl4.Text = "LayoutControl4"
        '
        'LayoutControlGroup3
        '
        Me.LayoutControlGroup3.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup3.GroupBordersVisible = False
        Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem8})
        Me.LayoutControlGroup3.Name = "LayoutControlGroup3"
        Me.LayoutControlGroup3.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2)
        Me.LayoutControlGroup3.Size = New System.Drawing.Size(963, 459)
        Me.LayoutControlGroup3.TextVisible = False
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.LayoutControl1
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(959, 455)
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextVisible = False
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
        'Dia_Item_Type_MasterTableAdapter
        '
        Me.Dia_Item_Type_MasterTableAdapter.ClearBeforeFill = True
        '
        'Dia_Ledger_MasterTableAdapter
        '
        Me.Dia_Ledger_MasterTableAdapter.ClearBeforeFill = True
        '
        'Dia_Process_MasterTableAdapter
        '
        Me.Dia_Process_MasterTableAdapter.ClearBeforeFill = True
        '
        'Dia_User_MasterTableAdapter
        '
        Me.Dia_User_MasterTableAdapter.ClearBeforeFill = True
        '
        'FrmSendtoProcess
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(963, 633)
        Me.Controls.Add(Me.LayoutControl4)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl)
        Me.Name = "FrmSendtoProcess"
        Me.Ribbon = Me.RibbonControl
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "Send to Process"
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl2.ResumeLayout(False)
        CType(Me.dgnew, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.newView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.riShape, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiaShapeMasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DIA_MASTERDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.riColor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiaColorMasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.riClarity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiaClarityMasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.riCarats, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.riFlo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiaFloMasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtstockid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtbarcode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl3.ResumeLayout(False)
        CType(Me.dgList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.listView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiaUserMasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiaItemTypeMasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiaLedgerMasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiaProcessMasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl4.ResumeLayout(False)
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControl2 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents dgnew As DevExpress.XtraGrid.GridControl
    Friend WithEvents newView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtstockid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtbarcode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmblocation As ComboBox
    Friend WithEvents cmbProcess As ComboBox
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControl3 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents dgList As DevExpress.XtraGrid.GridControl
    Friend WithEvents listView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup5 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControl4 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ColBarcode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColShape As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColColor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColClarity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColStockID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DIA_MASTERDataSet As DIA_MASTERDataSet
    Friend WithEvents DiaShapeMasterBindingSource As BindingSource
    Friend WithEvents Dia_Shape_MasterTableAdapter As DIA_MASTERDataSetTableAdapters.Dia_Shape_MasterTableAdapter
    Friend WithEvents riShape As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents riColor As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents DiaColorMasterBindingSource As BindingSource
    Friend WithEvents Dia_Color_MasterTableAdapter As DIA_MASTERDataSetTableAdapters.Dia_Color_MasterTableAdapter
    Friend WithEvents riClarity As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents DiaClarityMasterBindingSource As BindingSource
    Friend WithEvents Dia_Clarity_MasterTableAdapter As DIA_MASTERDataSetTableAdapters.Dia_Clarity_MasterTableAdapter
    Friend WithEvents btnSave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSaveClose As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCancel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ColCarats As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColFloId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents riFlo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents DiaFloMasterBindingSource As BindingSource
    Friend WithEvents Dia_Flo_MasterTableAdapter As DIA_MASTERDataSetTableAdapters.Dia_Flo_MasterTableAdapter
    Friend WithEvents riCarats As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents btnClose As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents colTransactionID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBarcode1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUserID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemTypeID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStockID1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQty1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCarats1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colShapeID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colColorID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colClarityID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFloID1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colExecutionDateTime As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLedgerID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProcessID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents DiaItemTypeMasterBindingSource As BindingSource
    Friend WithEvents Dia_Item_Type_MasterTableAdapter As Dia_MasterDatasetTableAdapters.Dia_Item_Type_MasterTableAdapter
    Friend WithEvents RepositoryItemLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit5 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents RepositoryItemLookUpEdit6 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents DiaLedgerMasterBindingSource As BindingSource
    Friend WithEvents Dia_Ledger_MasterTableAdapter As Dia_MasterDatasetTableAdapters.Dia_Ledger_MasterTableAdapter
    Friend WithEvents RepositoryItemLookUpEdit7 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents DiaProcessMasterBindingSource As BindingSource
    Friend WithEvents Dia_Process_MasterTableAdapter As Dia_MasterDatasetTableAdapters.Dia_Process_MasterTableAdapter
    Friend WithEvents ColUnionID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit8 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents DiaUserMasterBindingSource As BindingSource
    Friend WithEvents Dia_User_MasterTableAdapter As Dia_MasterDatasetTableAdapters.Dia_User_MasterTableAdapter
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents menuEdit As ToolStripMenuItem
    Friend WithEvents MenuDelete As ToolStripMenuItem
    Friend WithEvents btnLoadClipboard As DevExpress.XtraBars.BarButtonItem
End Class
