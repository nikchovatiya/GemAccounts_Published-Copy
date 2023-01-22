<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmInvoice
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmInvoice))
        Dim EditorButtonImageOptions1 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.txtAttachment = New DevExpress.XtraEditors.TextEdit()
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnSaveClose = New DevExpress.XtraBars.BarButtonItem()
        Me.BtnSave = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCancel = New DevExpress.XtraBars.BarButtonItem()
        Me.btnClose = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.btnRefresh = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.btnAttachment = New DevExpress.XtraEditors.SimpleButton()
        Me.txtNetINR = New DevExpress.XtraEditors.TextEdit()
        Me.txtNetUSD = New DevExpress.XtraEditors.TextEdit()
        Me.txtStockID = New DevExpress.XtraEditors.TextEdit()
        Me.txtBarcode = New DevExpress.XtraEditors.TextEdit()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.dgLot = New DevExpress.XtraGrid.GridControl()
        Me.ViewLot = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.riShape = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.DiaShapeMasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Dia_MasterDataset = New GemAccounts.Dia_MasterDataset()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.riColor = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.DiaColorMasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.riClarity = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.DiaClarityMasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.riFlo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.DiaFloMasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.riLab = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.DIaLabMasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn17 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn18 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn19 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn20 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn21 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn22 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn31 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.dgAdditional = New DevExpress.XtraGrid.GridControl()
        Me.ViewAdditional = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn23 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.riExp = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.GridColumn25 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.riExpPercent = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GridColumn26 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn27 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn32 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage()
        Me.dgBroker = New DevExpress.XtraGrid.GridControl()
        Me.ViewBroker = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn24 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.riBroker = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.GridColumn28 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.riBrokerPercent = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GridColumn29 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn30 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn33 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtExRate = New DevExpress.XtraEditors.TextEdit()
        Me.dtpDueDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.cmbTerms = New System.Windows.Forms.ComboBox()
        Me.cmbCustomer = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem5 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.Dia_Shape_MasterTableAdapter = New GemAccounts.Dia_MasterDatasetTableAdapters.Dia_Shape_MasterTableAdapter()
        Me.Dia_Color_MasterTableAdapter = New GemAccounts.Dia_MasterDatasetTableAdapters.Dia_Color_MasterTableAdapter()
        Me.Dia_Clarity_MasterTableAdapter = New GemAccounts.Dia_MasterDatasetTableAdapters.Dia_Clarity_MasterTableAdapter()
        Me.Dia_Flo_MasterTableAdapter = New GemAccounts.Dia_MasterDatasetTableAdapters.Dia_Flo_MasterTableAdapter()
        Me.DIa_Lab_MasterTableAdapter = New GemAccounts.Dia_MasterDatasetTableAdapters.DIa_Lab_MasterTableAdapter()
        Me.DxValidationProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.txtAttachment.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNetINR.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNetUSD.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStockID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBarcode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.dgLot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewLot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.riShape, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiaShapeMasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dia_MasterDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.riColor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiaColorMasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.riClarity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiaClarityMasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.riFlo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiaFloMasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.riLab, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DIaLabMasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.dgAdditional, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewAdditional, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.riExp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.riExpPercent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage3.SuspendLayout()
        CType(Me.dgBroker, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewBroker, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.riBroker, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.riBrokerPercent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtExRate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.txtAttachment)
        Me.LayoutControl1.Controls.Add(Me.btnAttachment)
        Me.LayoutControl1.Controls.Add(Me.txtNetINR)
        Me.LayoutControl1.Controls.Add(Me.txtNetUSD)
        Me.LayoutControl1.Controls.Add(Me.txtStockID)
        Me.LayoutControl1.Controls.Add(Me.txtBarcode)
        Me.LayoutControl1.Controls.Add(Me.XtraTabControl1)
        Me.LayoutControl1.Controls.Add(Me.txtExRate)
        Me.LayoutControl1.Controls.Add(Me.dtpDueDate)
        Me.LayoutControl1.Controls.Add(Me.dtpDate)
        Me.LayoutControl1.Controls.Add(Me.cmbTerms)
        Me.LayoutControl1.Controls.Add(Me.cmbCustomer)
        Me.LayoutControl1.Controls.Add(Me.Label1)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 158)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(836, 428)
        Me.LayoutControl1.TabIndex = 3
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'txtAttachment
        '
        Me.txtAttachment.Enabled = False
        Me.txtAttachment.Location = New System.Drawing.Point(256, 384)
        Me.txtAttachment.MenuManager = Me.RibbonControl1
        Me.txtAttachment.Name = "txtAttachment"
        Me.txtAttachment.Size = New System.Drawing.Size(235, 20)
        Me.txtAttachment.StyleController = Me.LayoutControl1
        Me.txtAttachment.TabIndex = 19
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.RibbonControl1.SearchEditItem, Me.btnSaveClose, Me.BtnSave, Me.btnCancel, Me.btnClose, Me.BarButtonItem1, Me.btnRefresh})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 8
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.Size = New System.Drawing.Size(836, 158)
        '
        'btnSaveClose
        '
        Me.btnSaveClose.Caption = "Save && Close"
        Me.btnSaveClose.Id = 2
        Me.btnSaveClose.ImageOptions.SvgImage = CType(resources.GetObject("btnSaveClose.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btnSaveClose.Name = "btnSaveClose"
        '
        'BtnSave
        '
        Me.BtnSave.Caption = "Save"
        Me.BtnSave.Id = 3
        Me.BtnSave.ImageOptions.SvgImage = CType(resources.GetObject("BtnSave.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.BtnSave.Name = "BtnSave"
        '
        'btnCancel
        '
        Me.btnCancel.Caption = "Cancel"
        Me.btnCancel.Id = 4
        Me.btnCancel.ImageOptions.SvgImage = CType(resources.GetObject("btnCancel.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btnCancel.Name = "btnCancel"
        '
        'btnClose
        '
        Me.btnClose.Caption = "Close"
        Me.btnClose.Id = 5
        Me.btnClose.ImageOptions.SvgImage = CType(resources.GetObject("btnClose.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btnClose.Name = "btnClose"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "BarButtonItem1"
        Me.BarButtonItem1.Id = 6
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'btnRefresh
        '
        Me.btnRefresh.Caption = "Refresh"
        Me.btnRefresh.Id = 7
        Me.btnRefresh.ImageOptions.SvgImage = CType(resources.GetObject("btnRefresh.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btnRefresh.Name = "btnRefresh"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "Actions"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnSaveClose)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BtnSave)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnCancel)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnClose)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnRefresh)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        '
        'btnAttachment
        '
        Me.btnAttachment.ImageOptions.Image = CType(resources.GetObject("btnAttachment.ImageOptions.Image"), System.Drawing.Image)
        Me.btnAttachment.Location = New System.Drawing.Point(256, 358)
        Me.btnAttachment.Name = "btnAttachment"
        Me.btnAttachment.Size = New System.Drawing.Size(80, 22)
        Me.btnAttachment.StyleController = Me.LayoutControl1
        Me.btnAttachment.TabIndex = 18
        Me.btnAttachment.Text = "Attach PDF"
        '
        'txtNetINR
        '
        Me.txtNetINR.EditValue = "0"
        Me.txtNetINR.Location = New System.Drawing.Point(676, 382)
        Me.txtNetINR.MenuManager = Me.RibbonControl1
        Me.txtNetINR.Name = "txtNetINR"
        Me.txtNetINR.Properties.Appearance.Options.UseTextOptions = True
        Me.txtNetINR.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtNetINR.Properties.Mask.EditMask = "n2"
        Me.txtNetINR.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtNetINR.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtNetINR.Size = New System.Drawing.Size(136, 20)
        Me.txtNetINR.StyleController = Me.LayoutControl1
        Me.txtNetINR.TabIndex = 13
        '
        'txtNetUSD
        '
        Me.txtNetUSD.EditValue = "0"
        Me.txtNetUSD.Location = New System.Drawing.Point(676, 358)
        Me.txtNetUSD.MenuManager = Me.RibbonControl1
        Me.txtNetUSD.Name = "txtNetUSD"
        Me.txtNetUSD.Properties.Appearance.Options.UseTextOptions = True
        Me.txtNetUSD.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtNetUSD.Properties.Mask.EditMask = "n2"
        Me.txtNetUSD.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtNetUSD.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtNetUSD.Size = New System.Drawing.Size(136, 20)
        Me.txtNetUSD.StyleController = Me.LayoutControl1
        Me.txtNetUSD.TabIndex = 12
        '
        'txtStockID
        '
        Me.txtStockID.Location = New System.Drawing.Point(136, 377)
        Me.txtStockID.MenuManager = Me.RibbonControl1
        Me.txtStockID.Name = "txtStockID"
        Me.txtStockID.Size = New System.Drawing.Size(103, 20)
        Me.txtStockID.StyleController = Me.LayoutControl1
        Me.txtStockID.TabIndex = 5
        '
        'txtBarcode
        '
        Me.txtBarcode.Location = New System.Drawing.Point(27, 377)
        Me.txtBarcode.MenuManager = Me.RibbonControl1
        Me.txtBarcode.Name = "txtBarcode"
        Me.txtBarcode.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.txtBarcode.Properties.ValidateOnEnterKey = True
        Me.txtBarcode.Size = New System.Drawing.Size(99, 20)
        Me.txtBarcode.StyleController = Me.LayoutControl1
        Me.txtBarcode.TabIndex = 4
        '
        'XtraTabControl1
        '
        EditorButtonImageOptions1.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        EditorButtonImageOptions1.SvgImage = CType(resources.GetObject("EditorButtonImageOptions1.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        EditorButtonImageOptions1.SvgImageSize = New System.Drawing.Size(16, 16)
        Me.XtraTabControl1.CustomHeaderButtons.AddRange(New DevExpress.XtraTab.Buttons.CustomHeaderButton() {New DevExpress.XtraTab.Buttons.CustomHeaderButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Refresh", -1, True, True, EditorButtonImageOptions1, SerializableAppearanceObject1, "", Nothing, Nothing)})
        Me.XtraTabControl1.Location = New System.Drawing.Point(24, 140)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(788, 214)
        Me.XtraTabControl1.TabIndex = 11
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2, Me.XtraTabPage3})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.dgLot)
        Me.XtraTabPage1.ImageOptions.SvgImage = CType(resources.GetObject("XtraTabPage1.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.XtraTabPage1.ImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(786, 186)
        Me.XtraTabPage1.Text = "Lot Details"
        '
        'dgLot
        '
        Me.dgLot.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgLot.Location = New System.Drawing.Point(0, 0)
        Me.dgLot.MainView = Me.ViewLot
        Me.dgLot.MenuManager = Me.RibbonControl1
        Me.dgLot.Name = "dgLot"
        Me.dgLot.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.riShape, Me.riColor, Me.riClarity, Me.riFlo, Me.riLab, Me.RepositoryItemTextEdit1})
        Me.dgLot.Size = New System.Drawing.Size(786, 186)
        Me.dgLot.TabIndex = 0
        Me.dgLot.TabStop = False
        Me.dgLot.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.ViewLot})
        '
        'ViewLot
        '
        Me.ViewLot.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.GridColumn10, Me.GridColumn11, Me.GridColumn12, Me.GridColumn13, Me.GridColumn14, Me.GridColumn15, Me.GridColumn16, Me.GridColumn17, Me.GridColumn18, Me.GridColumn19, Me.GridColumn20, Me.GridColumn21, Me.GridColumn22, Me.GridColumn31})
        Me.ViewLot.GridControl = Me.dgLot
        Me.ViewLot.Name = "ViewLot"
        Me.ViewLot.OptionsView.ColumnAutoWidth = False
        Me.ViewLot.OptionsView.ShowFooter = True
        Me.ViewLot.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Barcode"
        Me.GridColumn1.FieldName = "Barcode"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Stock ID"
        Me.GridColumn2.FieldName = "StockID"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Qty"
        Me.GridColumn3.DisplayFormat.FormatString = "#############0"
        Me.GridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn3.FieldName = "Qty"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        Me.GridColumn3.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Qty", "{0:0}")})
        Me.GridColumn3.UnboundType = DevExpress.Data.UnboundColumnType.[Integer]
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Carats"
        Me.GridColumn4.DisplayFormat.FormatString = "###########0.00"
        Me.GridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn4.FieldName = "Carats"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.AllowEdit = False
        Me.GridColumn4.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Carats", "{0:0.##}")})
        Me.GridColumn4.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 3
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Shape"
        Me.GridColumn5.ColumnEdit = Me.riShape
        Me.GridColumn5.FieldName = "ShapeID"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.AllowEdit = False
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 4
        '
        'riShape
        '
        Me.riShape.AutoHeight = False
        Me.riShape.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.riShape.DataSource = Me.DiaShapeMasterBindingSource
        Me.riShape.DisplayMember = "Shape_Name"
        Me.riShape.Name = "riShape"
        Me.riShape.NullText = ""
        Me.riShape.ValueMember = "Shape_ID"
        '
        'DiaShapeMasterBindingSource
        '
        Me.DiaShapeMasterBindingSource.DataMember = "Dia_Shape_Master"
        Me.DiaShapeMasterBindingSource.DataSource = Me.Dia_MasterDataset
        '
        'Dia_MasterDataset
        '
        Me.Dia_MasterDataset.DataSetName = "Dia_MasterDataset"
        Me.Dia_MasterDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Color"
        Me.GridColumn6.ColumnEdit = Me.riColor
        Me.GridColumn6.FieldName = "ColorID"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsColumn.AllowEdit = False
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 5
        '
        'riColor
        '
        Me.riColor.AutoHeight = False
        Me.riColor.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.riColor.DataSource = Me.DiaColorMasterBindingSource
        Me.riColor.DisplayMember = "color_name"
        Me.riColor.Name = "riColor"
        Me.riColor.NullText = ""
        Me.riColor.ValueMember = "color_id"
        '
        'DiaColorMasterBindingSource
        '
        Me.DiaColorMasterBindingSource.DataMember = "Dia_Color_Master"
        Me.DiaColorMasterBindingSource.DataSource = Me.Dia_MasterDataset
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Clarity"
        Me.GridColumn7.ColumnEdit = Me.riClarity
        Me.GridColumn7.FieldName = "ClarityID"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.OptionsColumn.AllowEdit = False
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 6
        '
        'riClarity
        '
        Me.riClarity.AutoHeight = False
        Me.riClarity.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.riClarity.DataSource = Me.DiaClarityMasterBindingSource
        Me.riClarity.DisplayMember = "clarity_name"
        Me.riClarity.Name = "riClarity"
        Me.riClarity.NullText = ""
        Me.riClarity.ValueMember = "clarity_id"
        '
        'DiaClarityMasterBindingSource
        '
        Me.DiaClarityMasterBindingSource.DataMember = "Dia_Clarity_Master"
        Me.DiaClarityMasterBindingSource.DataSource = Me.Dia_MasterDataset
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Flour"
        Me.GridColumn8.ColumnEdit = Me.riFlo
        Me.GridColumn8.FieldName = "FloID"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.OptionsColumn.AllowEdit = False
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 7
        '
        'riFlo
        '
        Me.riFlo.AutoHeight = False
        Me.riFlo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.riFlo.DataSource = Me.DiaFloMasterBindingSource
        Me.riFlo.DisplayMember = "flo_name"
        Me.riFlo.Name = "riFlo"
        Me.riFlo.NullText = ""
        Me.riFlo.ValueMember = "flo_id"
        '
        'DiaFloMasterBindingSource
        '
        Me.DiaFloMasterBindingSource.DataMember = "Dia_Flo_Master"
        Me.DiaFloMasterBindingSource.DataSource = Me.Dia_MasterDataset
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Lab"
        Me.GridColumn9.ColumnEdit = Me.riLab
        Me.GridColumn9.FieldName = "LabID"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.OptionsColumn.AllowEdit = False
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 8
        '
        'riLab
        '
        Me.riLab.AutoHeight = False
        Me.riLab.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.riLab.DataSource = Me.DIaLabMasterBindingSource
        Me.riLab.DisplayMember = "lab_name"
        Me.riLab.Name = "riLab"
        Me.riLab.NullText = "Non Cert"
        Me.riLab.ValueMember = "lab_id"
        '
        'DIaLabMasterBindingSource
        '
        Me.DIaLabMasterBindingSource.DataMember = "DIa_Lab_Master"
        Me.DIaLabMasterBindingSource.DataSource = Me.Dia_MasterDataset
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Report No."
        Me.GridColumn10.FieldName = "LCertificateNo"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.OptionsColumn.AllowEdit = False
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 9
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "RAP"
        Me.GridColumn11.DisplayFormat.FormatString = "###############0"
        Me.GridColumn11.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn11.FieldName = "RAP"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.OptionsColumn.AllowEdit = False
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 10
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "Sale %"
        Me.GridColumn12.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.GridColumn12.DisplayFormat.FormatString = "##0.00"
        Me.GridColumn12.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn12.FieldName = "SaleDiscount"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom, "SaleDiscount", "{0:n2}", "avgdis")})
        Me.GridColumn12.Tag = "avgdis"
        Me.GridColumn12.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 11
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Mask.EditMask = "n2"
        Me.RepositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit1.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        Me.RepositoryItemTextEdit1.NullText = "0"
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "Sale Price/Ct $"
        Me.GridColumn13.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.GridColumn13.DisplayFormat.FormatString = "#############0.00"
        Me.GridColumn13.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn13.FieldName = "SalePPCUSD"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 12
        '
        'GridColumn14
        '
        Me.GridColumn14.Caption = "Sale Total $"
        Me.GridColumn14.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.GridColumn14.DisplayFormat.FormatString = "#################0.00"
        Me.GridColumn14.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn14.FieldName = "SaleTotalUSD"
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SaleTotalUSD", "{0:n2}")})
        Me.GridColumn14.Visible = True
        Me.GridColumn14.VisibleIndex = 13
        '
        'GridColumn15
        '
        Me.GridColumn15.Caption = "Sale Price/Ct ₹"
        Me.GridColumn15.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.GridColumn15.DisplayFormat.FormatString = "################0.00"
        Me.GridColumn15.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn15.FieldName = "SalePPCINR"
        Me.GridColumn15.Name = "GridColumn15"
        Me.GridColumn15.Visible = True
        Me.GridColumn15.VisibleIndex = 14
        '
        'GridColumn16
        '
        Me.GridColumn16.Caption = "Sale Total ₹"
        Me.GridColumn16.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.GridColumn16.DisplayFormat.FormatString = "##################0.00"
        Me.GridColumn16.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn16.FieldName = "SaleTotalINR"
        Me.GridColumn16.Name = "GridColumn16"
        Me.GridColumn16.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SaleTotalINR", "{0:n2}")})
        Me.GridColumn16.Visible = True
        Me.GridColumn16.VisibleIndex = 15
        '
        'GridColumn17
        '
        Me.GridColumn17.Caption = "Cost %"
        Me.GridColumn17.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.GridColumn17.DisplayFormat.FormatString = "##0.00"
        Me.GridColumn17.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn17.FieldName = "CostDiscount"
        Me.GridColumn17.Name = "GridColumn17"
        Me.GridColumn17.OptionsColumn.AllowEdit = False
        Me.GridColumn17.Visible = True
        Me.GridColumn17.VisibleIndex = 16
        '
        'GridColumn18
        '
        Me.GridColumn18.Caption = "Cost Price/Ct $"
        Me.GridColumn18.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.GridColumn18.DisplayFormat.FormatString = "##########0.00"
        Me.GridColumn18.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn18.FieldName = "CostPPCUSD"
        Me.GridColumn18.Name = "GridColumn18"
        Me.GridColumn18.OptionsColumn.AllowEdit = False
        Me.GridColumn18.Visible = True
        Me.GridColumn18.VisibleIndex = 17
        '
        'GridColumn19
        '
        Me.GridColumn19.Caption = "Cost Total $"
        Me.GridColumn19.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.GridColumn19.DisplayFormat.FormatString = "##############0.00"
        Me.GridColumn19.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn19.FieldName = "CostTotalUSD"
        Me.GridColumn19.Name = "GridColumn19"
        Me.GridColumn19.OptionsColumn.AllowEdit = False
        Me.GridColumn19.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "CostTotalUSD", "{0:n2}")})
        Me.GridColumn19.Visible = True
        Me.GridColumn19.VisibleIndex = 18
        '
        'GridColumn20
        '
        Me.GridColumn20.Caption = "Asking %"
        Me.GridColumn20.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.GridColumn20.DisplayFormat.FormatString = "##0.00"
        Me.GridColumn20.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn20.FieldName = "AskingDiscount"
        Me.GridColumn20.Name = "GridColumn20"
        Me.GridColumn20.OptionsColumn.AllowEdit = False
        Me.GridColumn20.Visible = True
        Me.GridColumn20.VisibleIndex = 19
        '
        'GridColumn21
        '
        Me.GridColumn21.Caption = "Asking Price/Ct"
        Me.GridColumn21.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.GridColumn21.DisplayFormat.FormatString = "############0.00"
        Me.GridColumn21.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn21.FieldName = "AskingPPCUSD"
        Me.GridColumn21.Name = "GridColumn21"
        Me.GridColumn21.OptionsColumn.AllowEdit = False
        Me.GridColumn21.Visible = True
        Me.GridColumn21.VisibleIndex = 20
        '
        'GridColumn22
        '
        Me.GridColumn22.Caption = "Asking Total $"
        Me.GridColumn22.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.GridColumn22.DisplayFormat.FormatString = "###########0.00"
        Me.GridColumn22.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn22.FieldName = "AskingTotalUSD"
        Me.GridColumn22.Name = "GridColumn22"
        Me.GridColumn22.OptionsColumn.AllowEdit = False
        Me.GridColumn22.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "AskingTotalUSD", "{0:n2}")})
        Me.GridColumn22.Visible = True
        Me.GridColumn22.VisibleIndex = 21
        '
        'GridColumn31
        '
        Me.GridColumn31.Caption = "SalesDetailID"
        Me.GridColumn31.FieldName = "SalesDetailID"
        Me.GridColumn31.Name = "GridColumn31"
        Me.GridColumn31.OptionsColumn.AllowShowHide = False
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.dgAdditional)
        Me.XtraTabPage2.ImageOptions.SvgImage = CType(resources.GetObject("XtraTabPage2.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.XtraTabPage2.ImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(786, 186)
        Me.XtraTabPage2.Text = "Additional"
        '
        'dgAdditional
        '
        Me.dgAdditional.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgAdditional.Location = New System.Drawing.Point(0, 0)
        Me.dgAdditional.MainView = Me.ViewAdditional
        Me.dgAdditional.MenuManager = Me.RibbonControl1
        Me.dgAdditional.Name = "dgAdditional"
        Me.dgAdditional.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.riExp, Me.riExpPercent})
        Me.dgAdditional.Size = New System.Drawing.Size(786, 186)
        Me.dgAdditional.TabIndex = 0
        Me.dgAdditional.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.ViewAdditional})
        '
        'ViewAdditional
        '
        Me.ViewAdditional.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn23, Me.GridColumn25, Me.GridColumn26, Me.GridColumn27, Me.GridColumn32})
        Me.ViewAdditional.GridControl = Me.dgAdditional
        Me.ViewAdditional.Name = "ViewAdditional"
        Me.ViewAdditional.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.ViewAdditional.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.ViewAdditional.OptionsView.ShowFooter = True
        Me.ViewAdditional.OptionsView.ShowGroupPanel = False
        '
        'GridColumn23
        '
        Me.GridColumn23.Caption = "Expnese Account"
        Me.GridColumn23.ColumnEdit = Me.riExp
        Me.GridColumn23.FieldName = "LedgerIDExp"
        Me.GridColumn23.Name = "GridColumn23"
        Me.GridColumn23.UnboundType = DevExpress.Data.UnboundColumnType.[Integer]
        Me.GridColumn23.Visible = True
        Me.GridColumn23.VisibleIndex = 0
        '
        'riExp
        '
        Me.riExp.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.riExp.AutoHeight = False
        Me.riExp.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.DropDown)})
        Me.riExp.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("LedgerID", "", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("LedgerName", "")})
        Me.riExp.DisplayMember = "LedgerName"
        Me.riExp.Name = "riExp"
        Me.riExp.NullText = ""
        Me.riExp.ValueMember = "LedgerID"
        '
        'GridColumn25
        '
        Me.GridColumn25.Caption = "%"
        Me.GridColumn25.ColumnEdit = Me.riExpPercent
        Me.GridColumn25.FieldName = "ExpPercent"
        Me.GridColumn25.Name = "GridColumn25"
        Me.GridColumn25.Visible = True
        Me.GridColumn25.VisibleIndex = 1
        '
        'riExpPercent
        '
        Me.riExpPercent.AutoHeight = False
        Me.riExpPercent.Mask.EditMask = "n2"
        Me.riExpPercent.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.riExpPercent.Mask.UseMaskAsDisplayFormat = True
        Me.riExpPercent.Name = "riExpPercent"
        Me.riExpPercent.NullText = "0"
        '
        'GridColumn26
        '
        Me.GridColumn26.Caption = "Expense USD"
        Me.GridColumn26.ColumnEdit = Me.riExpPercent
        Me.GridColumn26.FieldName = "ExpUSD"
        Me.GridColumn26.Name = "GridColumn26"
        Me.GridColumn26.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ExpUSD", "{0:0.##}")})
        Me.GridColumn26.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        Me.GridColumn26.Visible = True
        Me.GridColumn26.VisibleIndex = 2
        '
        'GridColumn27
        '
        Me.GridColumn27.Caption = "Expense INR"
        Me.GridColumn27.ColumnEdit = Me.riExpPercent
        Me.GridColumn27.FieldName = "ExpINR"
        Me.GridColumn27.Name = "GridColumn27"
        Me.GridColumn27.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ExpINR", "{0:0.##}")})
        Me.GridColumn27.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        Me.GridColumn27.Visible = True
        Me.GridColumn27.VisibleIndex = 3
        '
        'GridColumn32
        '
        Me.GridColumn32.Caption = "SalesAdditionalID"
        Me.GridColumn32.FieldName = "SalesAdditionalID"
        Me.GridColumn32.Name = "GridColumn32"
        Me.GridColumn32.OptionsColumn.AllowShowHide = False
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Controls.Add(Me.dgBroker)
        Me.XtraTabPage3.ImageOptions.SvgImage = CType(resources.GetObject("XtraTabPage3.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.XtraTabPage3.ImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Size = New System.Drawing.Size(786, 186)
        Me.XtraTabPage3.Text = "Broker"
        '
        'dgBroker
        '
        Me.dgBroker.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgBroker.Location = New System.Drawing.Point(0, 0)
        Me.dgBroker.MainView = Me.ViewBroker
        Me.dgBroker.MenuManager = Me.RibbonControl1
        Me.dgBroker.Name = "dgBroker"
        Me.dgBroker.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.riBroker, Me.riBrokerPercent})
        Me.dgBroker.Size = New System.Drawing.Size(786, 186)
        Me.dgBroker.TabIndex = 0
        Me.dgBroker.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.ViewBroker})
        '
        'ViewBroker
        '
        Me.ViewBroker.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn24, Me.GridColumn28, Me.GridColumn29, Me.GridColumn30, Me.GridColumn33})
        Me.ViewBroker.GridControl = Me.dgBroker
        Me.ViewBroker.Name = "ViewBroker"
        Me.ViewBroker.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.ViewBroker.OptionsView.ShowFooter = True
        Me.ViewBroker.OptionsView.ShowGroupPanel = False
        '
        'GridColumn24
        '
        Me.GridColumn24.Caption = "Broker"
        Me.GridColumn24.ColumnEdit = Me.riBroker
        Me.GridColumn24.FieldName = "LedgerID"
        Me.GridColumn24.Name = "GridColumn24"
        Me.GridColumn24.Visible = True
        Me.GridColumn24.VisibleIndex = 0
        '
        'riBroker
        '
        Me.riBroker.AutoHeight = False
        Me.riBroker.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.riBroker.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("LedgerID", "Name1", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("LedgerName", "")})
        Me.riBroker.DisplayMember = "LedgerName"
        Me.riBroker.Name = "riBroker"
        Me.riBroker.NullText = ""
        Me.riBroker.ValueMember = "LedgerID"
        '
        'GridColumn28
        '
        Me.GridColumn28.Caption = "%"
        Me.GridColumn28.ColumnEdit = Me.riBrokerPercent
        Me.GridColumn28.FieldName = "BrokerPercent"
        Me.GridColumn28.Name = "GridColumn28"
        Me.GridColumn28.Visible = True
        Me.GridColumn28.VisibleIndex = 1
        '
        'riBrokerPercent
        '
        Me.riBrokerPercent.AutoHeight = False
        Me.riBrokerPercent.Mask.EditMask = "n2"
        Me.riBrokerPercent.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.riBrokerPercent.Mask.UseMaskAsDisplayFormat = True
        Me.riBrokerPercent.Name = "riBrokerPercent"
        Me.riBrokerPercent.NullText = "0"
        '
        'GridColumn29
        '
        Me.GridColumn29.Caption = "Brokerage USD"
        Me.GridColumn29.ColumnEdit = Me.riBrokerPercent
        Me.GridColumn29.FieldName = "BrokerageUSD"
        Me.GridColumn29.Name = "GridColumn29"
        Me.GridColumn29.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "BrokerageUSD", "{0:0.##}")})
        Me.GridColumn29.Visible = True
        Me.GridColumn29.VisibleIndex = 2
        '
        'GridColumn30
        '
        Me.GridColumn30.Caption = "Brokerage INR"
        Me.GridColumn30.ColumnEdit = Me.riBrokerPercent
        Me.GridColumn30.FieldName = "BrokerageINR"
        Me.GridColumn30.Name = "GridColumn30"
        Me.GridColumn30.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "BrokerageINR", "{0:0.##}")})
        Me.GridColumn30.Visible = True
        Me.GridColumn30.VisibleIndex = 3
        '
        'GridColumn33
        '
        Me.GridColumn33.Caption = "SalesBrokerageID"
        Me.GridColumn33.FieldName = "SalesBrokerageID"
        Me.GridColumn33.Name = "GridColumn33"
        Me.GridColumn33.OptionsColumn.AllowShowHide = False
        '
        'txtExRate
        '
        Me.txtExRate.Location = New System.Drawing.Point(665, 88)
        Me.txtExRate.MenuManager = Me.RibbonControl1
        Me.txtExRate.Name = "txtExRate"
        Me.txtExRate.Properties.Mask.EditMask = "##########0.00000000000000"
        Me.txtExRate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtExRate.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtExRate.Size = New System.Drawing.Size(144, 20)
        Me.txtExRate.StyleController = Me.LayoutControl1
        Me.txtExRate.TabIndex = 3
        '
        'dtpDueDate
        '
        Me.dtpDueDate.CustomFormat = "dd-MM-yyyy"
        Me.dtpDueDate.Enabled = False
        Me.dtpDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDueDate.Location = New System.Drawing.Point(514, 88)
        Me.dtpDueDate.Name = "dtpDueDate"
        Me.dtpDueDate.Size = New System.Drawing.Size(141, 21)
        Me.dtpDueDate.TabIndex = 8
        Me.dtpDueDate.TabStop = False
        '
        'dtpDate
        '
        Me.dtpDate.CustomFormat = "dd-MM-yyyy"
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDate.Location = New System.Drawing.Point(27, 88)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(153, 21)
        Me.dtpDate.TabIndex = 0
        '
        'cmbTerms
        '
        Me.cmbTerms.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbTerms.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbTerms.FormattingEnabled = True
        Me.cmbTerms.Location = New System.Drawing.Point(403, 88)
        Me.cmbTerms.Name = "cmbTerms"
        Me.cmbTerms.Size = New System.Drawing.Size(101, 21)
        Me.cmbTerms.TabIndex = 2
        '
        'cmbCustomer
        '
        Me.cmbCustomer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbCustomer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCustomer.FormattingEnabled = True
        Me.cmbCustomer.Location = New System.Drawing.Point(190, 88)
        Me.cmbCustomer.Name = "cmbCustomer"
        Me.cmbCustomer.Size = New System.Drawing.Size(203, 21)
        Me.cmbCustomer.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(0, 10, 0, 10)
        Me.Label1.Size = New System.Drawing.Size(731, 39)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "New Invoice"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem6, Me.LayoutControlGroup1, Me.LayoutControlGroup2})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(836, 428)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.Label1
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem6.MaxSize = New System.Drawing.Size(735, 43)
        Me.LayoutControlItem6.MinSize = New System.Drawing.Size(735, 43)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(816, 43)
        Me.LayoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem4, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem5, Me.LayoutControlItem7})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 43)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(816, 73)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.dtpDate
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.LayoutControlItem4.Size = New System.Drawing.Size(163, 49)
        Me.LayoutControlItem4.Text = "Date"
        Me.LayoutControlItem4.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem4.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(23, 13)
        Me.LayoutControlItem4.TextToControlDistance = 5
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.cmbCustomer
        Me.LayoutControlItem2.Location = New System.Drawing.Point(163, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.LayoutControlItem2.Size = New System.Drawing.Size(213, 49)
        Me.LayoutControlItem2.Text = "Customer"
        Me.LayoutControlItem2.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(46, 13)
        Me.LayoutControlItem2.TextToControlDistance = 5
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.cmbTerms
        Me.LayoutControlItem3.Location = New System.Drawing.Point(376, 0)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.LayoutControlItem3.Size = New System.Drawing.Size(111, 49)
        Me.LayoutControlItem3.Text = "Terms"
        Me.LayoutControlItem3.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(29, 13)
        Me.LayoutControlItem3.TextToControlDistance = 5
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.dtpDueDate
        Me.LayoutControlItem5.Location = New System.Drawing.Point(487, 0)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.LayoutControlItem5.Size = New System.Drawing.Size(151, 49)
        Me.LayoutControlItem5.Text = "Due Date"
        Me.LayoutControlItem5.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem5.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(45, 13)
        Me.LayoutControlItem5.TextToControlDistance = 5
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.txtExRate
        Me.LayoutControlItem7.Location = New System.Drawing.Point(638, 0)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.LayoutControlItem7.Size = New System.Drawing.Size(154, 49)
        Me.LayoutControlItem7.Text = "Rate"
        Me.LayoutControlItem7.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem7.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(23, 13)
        Me.LayoutControlItem7.TextToControlDistance = 5
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem8, Me.LayoutControlItem1, Me.LayoutControlItem9, Me.LayoutControlItem10, Me.LayoutControlItem11, Me.LayoutControlItem13, Me.LayoutControlItem14, Me.EmptySpaceItem2, Me.EmptySpaceItem3, Me.EmptySpaceItem4, Me.EmptySpaceItem5})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 116)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(816, 292)
        Me.LayoutControlGroup2.TextVisible = False
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.XtraTabControl1
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(792, 218)
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlItem1.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem1.Control = Me.txtBarcode
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 218)
        Me.LayoutControlItem1.MaxSize = New System.Drawing.Size(109, 46)
        Me.LayoutControlItem1.MinSize = New System.Drawing.Size(109, 46)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.LayoutControlItem1.Size = New System.Drawing.Size(109, 50)
        Me.LayoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem1.Text = "Barcode"
        Me.LayoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(69, 13)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlItem9.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem9.Control = Me.txtStockID
        Me.LayoutControlItem9.Location = New System.Drawing.Point(109, 218)
        Me.LayoutControlItem9.MaxSize = New System.Drawing.Size(113, 46)
        Me.LayoutControlItem9.MinSize = New System.Drawing.Size(113, 46)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.LayoutControlItem9.Size = New System.Drawing.Size(113, 50)
        Me.LayoutControlItem9.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem9.Text = "Stock ID"
        Me.LayoutControlItem9.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(69, 13)
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.txtNetUSD
        Me.LayoutControlItem10.Location = New System.Drawing.Point(580, 218)
        Me.LayoutControlItem10.MaxSize = New System.Drawing.Size(212, 24)
        Me.LayoutControlItem10.MinSize = New System.Drawing.Size(212, 24)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(212, 24)
        Me.LayoutControlItem10.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem10.Text = "Net Value USD"
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(69, 13)
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.txtNetINR
        Me.LayoutControlItem11.Location = New System.Drawing.Point(580, 242)
        Me.LayoutControlItem11.MaxSize = New System.Drawing.Size(212, 24)
        Me.LayoutControlItem11.MinSize = New System.Drawing.Size(212, 24)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(212, 26)
        Me.LayoutControlItem11.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem11.Text = "Net Value INR"
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(69, 13)
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.btnAttachment
        Me.LayoutControlItem13.Location = New System.Drawing.Point(232, 218)
        Me.LayoutControlItem13.MaxSize = New System.Drawing.Size(84, 26)
        Me.LayoutControlItem13.MinSize = New System.Drawing.Size(84, 26)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(84, 26)
        Me.LayoutControlItem13.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem13.TextVisible = False
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.txtAttachment
        Me.LayoutControlItem14.Location = New System.Drawing.Point(232, 244)
        Me.LayoutControlItem14.MaxSize = New System.Drawing.Size(239, 24)
        Me.LayoutControlItem14.MinSize = New System.Drawing.Size(239, 24)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(239, 24)
        Me.LayoutControlItem14.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem14.TextVisible = False
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(222, 218)
        Me.EmptySpaceItem2.MaxSize = New System.Drawing.Size(10, 26)
        Me.EmptySpaceItem2.MinSize = New System.Drawing.Size(10, 26)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(10, 26)
        Me.EmptySpaceItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(316, 218)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(264, 26)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem4
        '
        Me.EmptySpaceItem4.AllowHotTrack = False
        Me.EmptySpaceItem4.Location = New System.Drawing.Point(222, 244)
        Me.EmptySpaceItem4.MaxSize = New System.Drawing.Size(10, 24)
        Me.EmptySpaceItem4.MinSize = New System.Drawing.Size(10, 24)
        Me.EmptySpaceItem4.Name = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Size = New System.Drawing.Size(10, 24)
        Me.EmptySpaceItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem5
        '
        Me.EmptySpaceItem5.AllowHotTrack = False
        Me.EmptySpaceItem5.Location = New System.Drawing.Point(471, 244)
        Me.EmptySpaceItem5.Name = "EmptySpaceItem5"
        Me.EmptySpaceItem5.Size = New System.Drawing.Size(109, 24)
        Me.EmptySpaceItem5.TextSize = New System.Drawing.Size(0, 0)
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Text = "RibbonPage2"
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem12.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LayoutControlItem12.Location = New System.Drawing.Point(0, 49)
        Me.LayoutControlItem12.MinSize = New System.Drawing.Size(50, 25)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(711, 24)
        Me.LayoutControlItem12.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem12.Text = "Barcode"
        Me.LayoutControlItem12.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem12.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(39, 13)
        Me.LayoutControlItem12.TextToControlDistance = 6
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
        'DIa_Lab_MasterTableAdapter
        '
        Me.DIa_Lab_MasterTableAdapter.ClearBeforeFill = True
        '
        'FrmInvoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(836, 586)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.Name = "FrmInvoice"
        Me.Ribbon = Me.RibbonControl1
        Me.Text = "New Invoice"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.txtAttachment.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNetINR.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNetUSD.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStockID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBarcode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.dgLot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViewLot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.riShape, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiaShapeMasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dia_MasterDataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.riColor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiaColorMasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.riClarity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiaClarityMasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.riFlo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiaFloMasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.riLab, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DIaLabMasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.dgAdditional, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViewAdditional, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.riExp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.riExpPercent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage3.ResumeLayout(False)
        CType(Me.dgBroker, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViewBroker, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.riBroker, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.riBrokerPercent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtExRate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents btnSaveClose As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BtnSave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCancel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnClose As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents dgLot As DevExpress.XtraGrid.GridControl
    Friend WithEvents ViewLot As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents txtExRate As DevExpress.XtraEditors.TextEdit
    Friend WithEvents dtpDueDate As DateTimePicker
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents cmbTerms As ComboBox
    Friend WithEvents cmbCustomer As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtStockID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtBarcode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents dgAdditional As DevExpress.XtraGrid.GridControl
    Friend WithEvents ViewAdditional As DevExpress.XtraGrid.Views.Grid.GridView
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
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn16 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn17 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn18 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn19 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn20 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn21 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn22 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents riShape As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Dia_MasterDataset As Dia_MasterDataset
    Friend WithEvents DiaShapeMasterBindingSource As BindingSource
    Friend WithEvents Dia_Shape_MasterTableAdapter As Dia_MasterDatasetTableAdapters.Dia_Shape_MasterTableAdapter
    Friend WithEvents riColor As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents DiaColorMasterBindingSource As BindingSource
    Friend WithEvents Dia_Color_MasterTableAdapter As Dia_MasterDatasetTableAdapters.Dia_Color_MasterTableAdapter
    Friend WithEvents riClarity As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents DiaClarityMasterBindingSource As BindingSource
    Friend WithEvents Dia_Clarity_MasterTableAdapter As Dia_MasterDatasetTableAdapters.Dia_Clarity_MasterTableAdapter
    Friend WithEvents riFlo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents DiaFloMasterBindingSource As BindingSource
    Friend WithEvents Dia_Flo_MasterTableAdapter As Dia_MasterDatasetTableAdapters.Dia_Flo_MasterTableAdapter
    Friend WithEvents riLab As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents DIaLabMasterBindingSource As BindingSource
    Friend WithEvents DIa_Lab_MasterTableAdapter As Dia_MasterDatasetTableAdapters.DIa_Lab_MasterTableAdapter
    Friend WithEvents GridColumn23 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents riExp As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridColumn25 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn26 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn27 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DxValidationProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents dgBroker As DevExpress.XtraGrid.GridControl
    Friend WithEvents ViewBroker As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn24 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents riBroker As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridColumn28 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn29 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn30 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents riBrokerPercent As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents riExpPercent As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txtNetINR As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNetUSD As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents GridColumn31 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn32 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn33 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnRefresh As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnAttachment As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtAttachment As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem5 As DevExpress.XtraLayout.EmptySpaceItem
End Class
