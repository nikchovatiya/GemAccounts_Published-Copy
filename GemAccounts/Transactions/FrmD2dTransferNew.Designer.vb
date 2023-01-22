<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmD2dTransferNew
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmD2dTransferNew))
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnSave = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSaveNClose = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCancel = New DevExpress.XtraBars.BarButtonItem()
        Me.btnClose = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar1 = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.dg = New DevExpress.XtraGrid.GridControl()
        Me.dgview = New DevExpress.XtraGrid.Views.Grid.GridView()
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
        Me.riCut = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.DiaCutMasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.riPolish = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.DiaPolishMasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.riSym = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.DiaSymmMasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.riBranch = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.DiaBranchMasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmbBranch = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtStockID = New DevExpress.XtraEditors.TextEdit()
        Me.txtBarcode = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.Dia_Shape_MasterTableAdapter = New GemAccounts.Dia_MasterDatasetTableAdapters.Dia_Shape_MasterTableAdapter()
        Me.Dia_Color_MasterTableAdapter = New GemAccounts.Dia_MasterDatasetTableAdapters.Dia_Color_MasterTableAdapter()
        Me.Dia_Clarity_MasterTableAdapter = New GemAccounts.Dia_MasterDatasetTableAdapters.Dia_Clarity_MasterTableAdapter()
        Me.Dia_Flo_MasterTableAdapter = New GemAccounts.Dia_MasterDatasetTableAdapters.Dia_Flo_MasterTableAdapter()
        Me.DIa_Lab_MasterTableAdapter = New GemAccounts.Dia_MasterDatasetTableAdapters.DIa_Lab_MasterTableAdapter()
        Me.Dia_Cut_MasterTableAdapter = New GemAccounts.Dia_MasterDatasetTableAdapters.Dia_Cut_MasterTableAdapter()
        Me.Dia_Polish_MasterTableAdapter = New GemAccounts.Dia_MasterDatasetTableAdapters.Dia_Polish_MasterTableAdapter()
        Me.Dia_Symm_MasterTableAdapter = New GemAccounts.Dia_MasterDatasetTableAdapters.Dia_Symm_MasterTableAdapter()
        Me.Dia_Branch_MasterTableAdapter = New GemAccounts.Dia_MasterDatasetTableAdapters.Dia_Branch_MasterTableAdapter()
        Me.btnLoadClipboard = New DevExpress.XtraBars.BarButtonItem()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgview, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.riCut, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiaCutMasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.riPolish, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiaPolishMasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.riSym, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiaSymmMasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.riBranch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiaBranchMasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbBranch.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStockID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBarcode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.RibbonControl1.SearchEditItem, Me.btnSave, Me.btnSaveNClose, Me.btnCancel, Me.btnClose, Me.btnLoadClipboard})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 7
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.Size = New System.Drawing.Size(991, 143)
        Me.RibbonControl1.StatusBar = Me.RibbonStatusBar1
        '
        'btnSave
        '
        Me.btnSave.Caption = "Save"
        Me.btnSave.Id = 1
        Me.btnSave.ImageOptions.SvgImage = CType(resources.GetObject("btnSave.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btnSave.Name = "btnSave"
        '
        'btnSaveNClose
        '
        Me.btnSaveNClose.Caption = "Save && Close"
        Me.btnSaveNClose.Id = 3
        Me.btnSaveNClose.ImageOptions.SvgImage = CType(resources.GetObject("btnSaveNClose.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btnSaveNClose.Name = "btnSaveNClose"
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
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "Actions"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnSave)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnSaveNClose)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnCancel)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnClose)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnLoadClipboard)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        '
        'RibbonStatusBar1
        '
        Me.RibbonStatusBar1.Location = New System.Drawing.Point(0, 498)
        Me.RibbonStatusBar1.Name = "RibbonStatusBar1"
        Me.RibbonStatusBar1.Ribbon = Me.RibbonControl1
        Me.RibbonStatusBar1.Size = New System.Drawing.Size(991, 31)
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Text = "RibbonPage2"
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.dg)
        Me.LayoutControl1.Controls.Add(Me.cmbBranch)
        Me.LayoutControl1.Controls.Add(Me.txtStockID)
        Me.LayoutControl1.Controls.Add(Me.txtBarcode)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 143)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(991, 355)
        Me.LayoutControl1.TabIndex = 2
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'dg
        '
        Me.dg.Location = New System.Drawing.Point(12, 83)
        Me.dg.MainView = Me.dgview
        Me.dg.MenuManager = Me.RibbonControl1
        Me.dg.Name = "dg"
        Me.dg.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.riShape, Me.riColor, Me.riClarity, Me.riFlo, Me.riLab, Me.riCut, Me.riPolish, Me.riSym, Me.riBranch})
        Me.dg.Size = New System.Drawing.Size(967, 260)
        Me.dg.TabIndex = 7
        Me.dg.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.dgview})
        '
        'dgview
        '
        Me.dgview.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.GridColumn10, Me.GridColumn11, Me.GridColumn12, Me.GridColumn13, Me.GridColumn14})
        Me.dgview.GridControl = Me.dg
        Me.dgview.Name = "dgview"
        Me.dgview.OptionsBehavior.Editable = False
        Me.dgview.OptionsView.ColumnAutoWidth = False
        Me.dgview.OptionsView.ShowFooter = True
        Me.dgview.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Barcode"
        Me.GridColumn1.FieldName = "Barcode"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Stock ID"
        Me.GridColumn2.FieldName = "StockID"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Qty"
        Me.GridColumn3.DisplayFormat.FormatString = "n0"
        Me.GridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn3.FieldName = "Qty"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Qty", "{0:n0}")})
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 3
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Carats"
        Me.GridColumn4.DisplayFormat.FormatString = "n2"
        Me.GridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn4.FieldName = "Carats"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Carats", "{0:n2}")})
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 4
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Shape"
        Me.GridColumn5.ColumnEdit = Me.riShape
        Me.GridColumn5.FieldName = "ShapeID"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 5
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
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 6
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
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 7
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
        Me.GridColumn8.Caption = "Flo"
        Me.GridColumn8.ColumnEdit = Me.riFlo
        Me.GridColumn8.FieldName = "FloID"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 8
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
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 9
        '
        'riLab
        '
        Me.riLab.AutoHeight = False
        Me.riLab.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.riLab.DataSource = Me.DIaLabMasterBindingSource
        Me.riLab.DisplayMember = "lab_name"
        Me.riLab.Name = "riLab"
        Me.riLab.NullText = ""
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
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 10
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "Cut"
        Me.GridColumn11.ColumnEdit = Me.riCut
        Me.GridColumn11.FieldName = "CutID"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 11
        '
        'riCut
        '
        Me.riCut.AutoHeight = False
        Me.riCut.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.riCut.DataSource = Me.DiaCutMasterBindingSource
        Me.riCut.DisplayMember = "cut_name"
        Me.riCut.Name = "riCut"
        Me.riCut.NullText = ""
        Me.riCut.ValueMember = "cut_id"
        '
        'DiaCutMasterBindingSource
        '
        Me.DiaCutMasterBindingSource.DataMember = "Dia_Cut_Master"
        Me.DiaCutMasterBindingSource.DataSource = Me.Dia_MasterDataset
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "Polish"
        Me.GridColumn12.ColumnEdit = Me.riPolish
        Me.GridColumn12.FieldName = "PolishID"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 12
        '
        'riPolish
        '
        Me.riPolish.AutoHeight = False
        Me.riPolish.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.riPolish.DataSource = Me.DiaPolishMasterBindingSource
        Me.riPolish.DisplayMember = "polish_name"
        Me.riPolish.Name = "riPolish"
        Me.riPolish.NullText = ""
        Me.riPolish.ValueMember = "polish_id"
        '
        'DiaPolishMasterBindingSource
        '
        Me.DiaPolishMasterBindingSource.DataMember = "Dia_Polish_Master"
        Me.DiaPolishMasterBindingSource.DataSource = Me.Dia_MasterDataset
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "Sym"
        Me.GridColumn13.ColumnEdit = Me.riSym
        Me.GridColumn13.FieldName = "SymID"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 13
        '
        'riSym
        '
        Me.riSym.AutoHeight = False
        Me.riSym.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.riSym.DataSource = Me.DiaSymmMasterBindingSource
        Me.riSym.DisplayMember = "symm_name"
        Me.riSym.Name = "riSym"
        Me.riSym.NullText = ""
        Me.riSym.ValueMember = "symm_id"
        '
        'DiaSymmMasterBindingSource
        '
        Me.DiaSymmMasterBindingSource.DataMember = "Dia_Symm_Master"
        Me.DiaSymmMasterBindingSource.DataSource = Me.Dia_MasterDataset
        '
        'GridColumn14
        '
        Me.GridColumn14.Caption = "Branch"
        Me.GridColumn14.ColumnEdit = Me.riBranch
        Me.GridColumn14.FieldName = "BranchID"
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.Visible = True
        Me.GridColumn14.VisibleIndex = 2
        '
        'riBranch
        '
        Me.riBranch.AutoHeight = False
        Me.riBranch.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.riBranch.DataSource = Me.DiaBranchMasterBindingSource
        Me.riBranch.DisplayMember = "br_name"
        Me.riBranch.Name = "riBranch"
        Me.riBranch.NullText = ""
        Me.riBranch.ValueMember = "br_id"
        '
        'DiaBranchMasterBindingSource
        '
        Me.DiaBranchMasterBindingSource.DataMember = "Dia_Branch_Master"
        Me.DiaBranchMasterBindingSource.DataSource = Me.Dia_MasterDataset
        '
        'cmbBranch
        '
        Me.cmbBranch.EditValue = ""
        Me.cmbBranch.Location = New System.Drawing.Point(102, 47)
        Me.cmbBranch.MenuManager = Me.RibbonControl1
        Me.cmbBranch.Name = "cmbBranch"
        Me.cmbBranch.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbBranch.Properties.NullText = ""
        Me.cmbBranch.Properties.PopupView = Me.GridLookUpEdit1View
        Me.cmbBranch.Size = New System.Drawing.Size(238, 20)
        Me.cmbBranch.StyleController = Me.LayoutControl1
        Me.cmbBranch.TabIndex = 0
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowColumnHeaders = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'txtStockID
        '
        Me.txtStockID.Location = New System.Drawing.Point(652, 47)
        Me.txtStockID.MenuManager = Me.RibbonControl1
        Me.txtStockID.Name = "txtStockID"
        Me.txtStockID.Size = New System.Drawing.Size(129, 20)
        Me.txtStockID.StyleController = Me.LayoutControl1
        Me.txtStockID.TabIndex = 2
        '
        'txtBarcode
        '
        Me.txtBarcode.Location = New System.Drawing.Point(422, 47)
        Me.txtBarcode.MenuManager = Me.RibbonControl1
        Me.txtBarcode.Name = "txtBarcode"
        Me.txtBarcode.Size = New System.Drawing.Size(148, 20)
        Me.txtBarcode.StyleController = Me.LayoutControl1
        Me.txtBarcode.TabIndex = 1
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2, Me.LayoutControlItem4})
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(991, 355)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AppearanceGroup.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlGroup2.AppearanceGroup.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LayoutControlGroup2.AppearanceGroup.Options.UseFont = True
        Me.LayoutControlGroup2.AppearanceGroup.Options.UseForeColor = True
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.EmptySpaceItem2, Me.LayoutControlItem3})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(971, 71)
        Me.LayoutControlGroup2.Text = "Change Branch D2D"
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.txtBarcode
        Me.LayoutControlItem1.Location = New System.Drawing.Point(320, 0)
        Me.LayoutControlItem1.MaxSize = New System.Drawing.Size(230, 24)
        Me.LayoutControlItem1.MinSize = New System.Drawing.Size(230, 24)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(230, 24)
        Me.LayoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem1.Text = "Barcode"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(75, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.txtStockID
        Me.LayoutControlItem2.Location = New System.Drawing.Point(550, 0)
        Me.LayoutControlItem2.MaxSize = New System.Drawing.Size(211, 24)
        Me.LayoutControlItem2.MinSize = New System.Drawing.Size(211, 24)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(211, 24)
        Me.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem2.Text = "Stock ID"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(75, 13)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(761, 0)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(186, 24)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.cmbBranch
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem3.MaxSize = New System.Drawing.Size(320, 24)
        Me.LayoutControlItem3.MinSize = New System.Drawing.Size(320, 24)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(320, 24)
        Me.LayoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem3.Text = "Send To Branch"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(75, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.dg
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 71)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(971, 264)
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
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
        'Dia_Branch_MasterTableAdapter
        '
        Me.Dia_Branch_MasterTableAdapter.ClearBeforeFill = True
        '
        'btnLoadClipboard
        '
        Me.btnLoadClipboard.Caption = "Load Clipboard"
        Me.btnLoadClipboard.Id = 6
        Me.btnLoadClipboard.ImageOptions.SvgImage = CType(resources.GetObject("BarButtonItem1.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btnLoadClipboard.Name = "btnLoadClipboard"
        '
        'FrmD2dTransferNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(991, 529)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.RibbonStatusBar1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.Name = "FrmD2dTransferNew"
        Me.Ribbon = Me.RibbonControl1
        Me.StatusBar = Me.RibbonStatusBar1
        Me.Text = "Change Branch D2D"
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgview, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.riCut, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiaCutMasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.riPolish, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiaPolishMasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.riSym, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiaSymmMasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.riBranch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiaBranchMasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbBranch.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStockID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBarcode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonStatusBar1 As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents btnSave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSaveNClose As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCancel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnClose As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents cmbBranch As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtStockID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtBarcode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents dg As DevExpress.XtraGrid.GridControl
    Friend WithEvents dgview As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
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
    Friend WithEvents riCut As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents DiaCutMasterBindingSource As BindingSource
    Friend WithEvents Dia_Cut_MasterTableAdapter As Dia_MasterDatasetTableAdapters.Dia_Cut_MasterTableAdapter
    Friend WithEvents riPolish As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents DiaPolishMasterBindingSource As BindingSource
    Friend WithEvents Dia_Polish_MasterTableAdapter As Dia_MasterDatasetTableAdapters.Dia_Polish_MasterTableAdapter
    Friend WithEvents riSym As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents DiaSymmMasterBindingSource As BindingSource
    Friend WithEvents Dia_Symm_MasterTableAdapter As Dia_MasterDatasetTableAdapters.Dia_Symm_MasterTableAdapter
    Friend WithEvents riBranch As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents DiaBranchMasterBindingSource As BindingSource
    Friend WithEvents Dia_Branch_MasterTableAdapter As Dia_MasterDatasetTableAdapters.Dia_Branch_MasterTableAdapter
    Friend WithEvents btnLoadClipboard As DevExpress.XtraBars.BarButtonItem
End Class
