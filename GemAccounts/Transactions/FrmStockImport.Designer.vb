<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmStockImport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmStockImport))
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.txtvideolink = New System.Windows.Forms.TextBox()
        Me.dg = New DevExpress.XtraGrid.GridControl()
        Me.dgview = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Col_Barcode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CompanyID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BranchID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.UserID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ImportDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ItemTypeID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.MainLotID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.StockID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Qty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabourINR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ShapeID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColorID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ClarityID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RAP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FloID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CutID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PolishID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SymID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Comment = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Carats = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColShape = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColColor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColClarity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColFlour = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColCut = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColPolish = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColSymm = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColItemType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColMainLotName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColMainLotCarats = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColVideoLink = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColImageLink = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColRoughImage = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColRoughVideo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColTransactionID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LNK = New DevExpress.XtraEditors.Repository.RepositoryItemHypertextLabel()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.VBN = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.dtp = New System.Windows.Forms.DateTimePicker()
        Me.cmbshape = New System.Windows.Forms.ComboBox()
        Me.txtStockID = New System.Windows.Forms.TextBox()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.txtCarats = New System.Windows.Forms.TextBox()
        Me.txtLabourINR = New System.Windows.Forms.TextBox()
        Me.cmbcolor = New System.Windows.Forms.ComboBox()
        Me.cmbclarity = New System.Windows.Forms.ComboBox()
        Me.cmbflour = New System.Windows.Forms.ComboBox()
        Me.cmbcut = New System.Windows.Forms.ComboBox()
        Me.cmbpolish = New System.Windows.Forms.ComboBox()
        Me.cmbsymm = New System.Windows.Forms.ComboBox()
        Me.cmbItemType = New System.Windows.Forms.ComboBox()
        Me.txtcomment = New System.Windows.Forms.TextBox()
        Me.txtrap = New System.Windows.Forms.TextBox()
        Me.txtimagelink = New System.Windows.Forms.TextBox()
        Me.cmbMainLotName = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SearchLookUpEdit2View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem22 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem18 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem23 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem20 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.hideContainerRight = New DevExpress.XtraBars.Docking.AutoHideContainer()
        Me.DP1 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.PropertyGridControl1 = New DevExpress.XtraVerticalGrid.PropertyGridControl()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.row = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.row1 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.row2 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.row3 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.row4 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.row5 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.row6 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.row7 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.row8 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.row9 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.row10 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.row11 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.row12 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnSave = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCancel = New DevExpress.XtraBars.BarButtonItem()
        Me.btnPrint = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDelete = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar1 = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.btnReftesh = New DevExpress.XtraBars.BarButtonItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgview, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LNK, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VBN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbMainLotName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit2View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.hideContainerRight.SuspendLayout()
        Me.DP1.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        CType(Me.PropertyGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.txtvideolink)
        Me.LayoutControl1.Controls.Add(Me.dg)
        Me.LayoutControl1.Controls.Add(Me.dtp)
        Me.LayoutControl1.Controls.Add(Me.cmbshape)
        Me.LayoutControl1.Controls.Add(Me.txtStockID)
        Me.LayoutControl1.Controls.Add(Me.txtQty)
        Me.LayoutControl1.Controls.Add(Me.txtCarats)
        Me.LayoutControl1.Controls.Add(Me.txtLabourINR)
        Me.LayoutControl1.Controls.Add(Me.cmbcolor)
        Me.LayoutControl1.Controls.Add(Me.cmbclarity)
        Me.LayoutControl1.Controls.Add(Me.cmbflour)
        Me.LayoutControl1.Controls.Add(Me.cmbcut)
        Me.LayoutControl1.Controls.Add(Me.cmbpolish)
        Me.LayoutControl1.Controls.Add(Me.cmbsymm)
        Me.LayoutControl1.Controls.Add(Me.cmbItemType)
        Me.LayoutControl1.Controls.Add(Me.txtcomment)
        Me.LayoutControl1.Controls.Add(Me.txtrap)
        Me.LayoutControl1.Controls.Add(Me.txtimagelink)
        Me.LayoutControl1.Controls.Add(Me.cmbMainLotName)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 143)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(630, 349, 650, 400)
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(837, 423)
        Me.LayoutControl1.TabIndex = 1
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'txtvideolink
        '
        Me.txtvideolink.Location = New System.Drawing.Point(103, 133)
        Me.txtvideolink.Name = "txtvideolink"
        Me.txtvideolink.Size = New System.Drawing.Size(310, 20)
        Me.txtvideolink.TabIndex = 13
        '
        'dg
        '
        Me.dg.Location = New System.Drawing.Point(20, 174)
        Me.dg.MainView = Me.dgview
        Me.dg.Name = "dg"
        Me.dg.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.LNK, Me.RepositoryItemTextEdit1, Me.VBN})
        Me.dg.Size = New System.Drawing.Size(797, 229)
        Me.dg.TabIndex = 11
        Me.dg.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.dgview})
        '
        'dgview
        '
        Me.dgview.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Col_Barcode, Me.CompanyID, Me.BranchID, Me.UserID, Me.ImportDate, Me.ItemTypeID, Me.MainLotID, Me.StockID, Me.Qty, Me.LabourINR, Me.ShapeID, Me.ColorID, Me.ClarityID, Me.RAP, Me.FloID, Me.CutID, Me.PolishID, Me.SymID, Me.Comment, Me.Carats, Me.ColShape, Me.ColColor, Me.ColClarity, Me.ColFlour, Me.ColCut, Me.ColPolish, Me.ColSymm, Me.ColItemType, Me.ColMainLotName, Me.ColMainLotCarats, Me.ColVideoLink, Me.ColImageLink, Me.ColRoughImage, Me.ColRoughVideo, Me.ColTransactionID})
        Me.dgview.GridControl = Me.dg
        Me.dgview.Name = "dgview"
        Me.dgview.OptionsBehavior.Editable = False
        Me.dgview.OptionsSelection.CheckBoxSelectorColumnWidth = 28
        Me.dgview.OptionsSelection.MultiSelect = True
        Me.dgview.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        Me.dgview.OptionsView.ColumnAutoWidth = False
        Me.dgview.OptionsView.ShowFooter = True
        '
        'Col_Barcode
        '
        Me.Col_Barcode.Caption = "Barcode"
        Me.Col_Barcode.FieldName = "Barcode"
        Me.Col_Barcode.Name = "Col_Barcode"
        Me.Col_Barcode.Width = 90
        '
        'CompanyID
        '
        Me.CompanyID.Caption = "Company ID"
        Me.CompanyID.FieldName = "CompanyID"
        Me.CompanyID.Name = "CompanyID"
        Me.CompanyID.Width = 77
        '
        'BranchID
        '
        Me.BranchID.Caption = "Branch ID"
        Me.BranchID.FieldName = "BranchID"
        Me.BranchID.Name = "BranchID"
        Me.BranchID.Width = 31
        '
        'UserID
        '
        Me.UserID.Caption = "User ID"
        Me.UserID.FieldName = "UserID"
        Me.UserID.Name = "UserID"
        Me.UserID.Width = 31
        '
        'ImportDate
        '
        Me.ImportDate.Caption = "Import Date"
        Me.ImportDate.DisplayFormat.FormatString = "d"
        Me.ImportDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.ImportDate.FieldName = "ImportDate"
        Me.ImportDate.Name = "ImportDate"
        Me.ImportDate.Visible = True
        Me.ImportDate.VisibleIndex = 13
        Me.ImportDate.Width = 96
        '
        'ItemTypeID
        '
        Me.ItemTypeID.Caption = "Item Type ID"
        Me.ItemTypeID.FieldName = "ItemTypeID"
        Me.ItemTypeID.Name = "ItemTypeID"
        Me.ItemTypeID.Width = 73
        '
        'MainLotID
        '
        Me.MainLotID.Caption = "Main Lot ID"
        Me.MainLotID.FieldName = "MainLotID"
        Me.MainLotID.Name = "MainLotID"
        Me.MainLotID.Width = 73
        '
        'StockID
        '
        Me.StockID.Caption = "Stock ID"
        Me.StockID.FieldName = "StockID"
        Me.StockID.Name = "StockID"
        Me.StockID.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "StockID", "{0}")})
        Me.StockID.Visible = True
        Me.StockID.VisibleIndex = 2
        Me.StockID.Width = 98
        '
        'Qty
        '
        Me.Qty.Caption = "Qty"
        Me.Qty.FieldName = "Qty"
        Me.Qty.Name = "Qty"
        Me.Qty.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Qty", "{0}")})
        Me.Qty.Visible = True
        Me.Qty.VisibleIndex = 3
        Me.Qty.Width = 46
        '
        'LabourINR
        '
        Me.LabourINR.Caption = "Labour INR"
        Me.LabourINR.DisplayFormat.FormatString = "n2"
        Me.LabourINR.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.LabourINR.FieldName = "LabourINR"
        Me.LabourINR.Name = "LabourINR"
        Me.LabourINR.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "LabourINR", "{0:n2}")})
        Me.LabourINR.Visible = True
        Me.LabourINR.VisibleIndex = 14
        Me.LabourINR.Width = 99
        '
        'ShapeID
        '
        Me.ShapeID.Caption = "Shape ID"
        Me.ShapeID.FieldName = "ShapeID"
        Me.ShapeID.Name = "ShapeID"
        Me.ShapeID.Width = 54
        '
        'ColorID
        '
        Me.ColorID.Caption = "Color ID"
        Me.ColorID.FieldName = "ColorID"
        Me.ColorID.Name = "ColorID"
        Me.ColorID.Width = 49
        '
        'ClarityID
        '
        Me.ClarityID.Caption = "Clarity ID"
        Me.ClarityID.FieldName = "ClarityID"
        Me.ClarityID.Name = "ClarityID"
        Me.ClarityID.Width = 55
        '
        'RAP
        '
        Me.RAP.Caption = "RAP"
        Me.RAP.FieldName = "RAP"
        Me.RAP.Name = "RAP"
        Me.RAP.Visible = True
        Me.RAP.VisibleIndex = 12
        Me.RAP.Width = 87
        '
        'FloID
        '
        Me.FloID.Caption = "Flour. ID"
        Me.FloID.FieldName = "FloID"
        Me.FloID.Name = "FloID"
        Me.FloID.Width = 52
        '
        'CutID
        '
        Me.CutID.Caption = "Cut ID"
        Me.CutID.FieldName = "CutID"
        Me.CutID.Name = "CutID"
        Me.CutID.Width = 41
        '
        'PolishID
        '
        Me.PolishID.Caption = "Polish ID"
        Me.PolishID.FieldName = "PolishID"
        Me.PolishID.Name = "PolishID"
        Me.PolishID.Width = 51
        '
        'SymID
        '
        Me.SymID.Caption = "Sym. ID"
        Me.SymID.FieldName = "SymID"
        Me.SymID.Name = "SymID"
        Me.SymID.Width = 48
        '
        'Comment
        '
        Me.Comment.Caption = "Comment"
        Me.Comment.FieldName = "Comment"
        Me.Comment.Name = "Comment"
        Me.Comment.Visible = True
        Me.Comment.VisibleIndex = 15
        Me.Comment.Width = 131
        '
        'Carats
        '
        Me.Carats.Caption = "Carats"
        Me.Carats.DisplayFormat.FormatString = "n2"
        Me.Carats.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Carats.FieldName = "Carats"
        Me.Carats.Name = "Carats"
        Me.Carats.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Carats", "{0:n2}")})
        Me.Carats.Visible = True
        Me.Carats.VisibleIndex = 4
        '
        'ColShape
        '
        Me.ColShape.Caption = "Shape"
        Me.ColShape.FieldName = "Shape"
        Me.ColShape.Name = "ColShape"
        Me.ColShape.Visible = True
        Me.ColShape.VisibleIndex = 5
        Me.ColShape.Width = 97
        '
        'ColColor
        '
        Me.ColColor.Caption = "Color"
        Me.ColColor.FieldName = "Color"
        Me.ColColor.Name = "ColColor"
        Me.ColColor.Visible = True
        Me.ColColor.VisibleIndex = 6
        '
        'ColClarity
        '
        Me.ColClarity.Caption = "Clarity"
        Me.ColClarity.FieldName = "Clarity"
        Me.ColClarity.Name = "ColClarity"
        Me.ColClarity.Visible = True
        Me.ColClarity.VisibleIndex = 7
        '
        'ColFlour
        '
        Me.ColFlour.Caption = "Flour"
        Me.ColFlour.FieldName = "Flour"
        Me.ColFlour.Name = "ColFlour"
        Me.ColFlour.Visible = True
        Me.ColFlour.VisibleIndex = 8
        Me.ColFlour.Width = 84
        '
        'ColCut
        '
        Me.ColCut.Caption = "Cut"
        Me.ColCut.FieldName = "Cut"
        Me.ColCut.Name = "ColCut"
        Me.ColCut.Visible = True
        Me.ColCut.VisibleIndex = 9
        '
        'ColPolish
        '
        Me.ColPolish.Caption = "Polish"
        Me.ColPolish.FieldName = "Polish"
        Me.ColPolish.Name = "ColPolish"
        Me.ColPolish.Visible = True
        Me.ColPolish.VisibleIndex = 10
        '
        'ColSymm
        '
        Me.ColSymm.Caption = "Symm"
        Me.ColSymm.FieldName = "Symm"
        Me.ColSymm.Name = "ColSymm"
        Me.ColSymm.Visible = True
        Me.ColSymm.VisibleIndex = 11
        '
        'ColItemType
        '
        Me.ColItemType.Caption = "Item Type"
        Me.ColItemType.FieldName = "ItemType"
        Me.ColItemType.Name = "ColItemType"
        Me.ColItemType.Visible = True
        Me.ColItemType.VisibleIndex = 1
        '
        'ColMainLotName
        '
        Me.ColMainLotName.Caption = "MainL Lot"
        Me.ColMainLotName.FieldName = "MainLotName"
        Me.ColMainLotName.Name = "ColMainLotName"
        Me.ColMainLotName.Visible = True
        Me.ColMainLotName.VisibleIndex = 16
        '
        'ColMainLotCarats
        '
        Me.ColMainLotCarats.Caption = "Main Lot Carats"
        Me.ColMainLotCarats.FieldName = "RoughCts"
        Me.ColMainLotCarats.Name = "ColMainLotCarats"
        Me.ColMainLotCarats.Visible = True
        Me.ColMainLotCarats.VisibleIndex = 17
        Me.ColMainLotCarats.Width = 97
        '
        'ColVideoLink
        '
        Me.ColVideoLink.Caption = "Polish Video"
        Me.ColVideoLink.FieldName = "VideoLink"
        Me.ColVideoLink.Name = "ColVideoLink"
        Me.ColVideoLink.Visible = True
        Me.ColVideoLink.VisibleIndex = 18
        Me.ColVideoLink.Width = 173
        '
        'ColImageLink
        '
        Me.ColImageLink.Caption = "Polish Image"
        Me.ColImageLink.FieldName = "ImageLink"
        Me.ColImageLink.Name = "ColImageLink"
        Me.ColImageLink.Visible = True
        Me.ColImageLink.VisibleIndex = 19
        Me.ColImageLink.Width = 151
        '
        'ColRoughImage
        '
        Me.ColRoughImage.Caption = "Rough Image"
        Me.ColRoughImage.FieldName = "RoughImage"
        Me.ColRoughImage.Name = "ColRoughImage"
        Me.ColRoughImage.Visible = True
        Me.ColRoughImage.VisibleIndex = 20
        Me.ColRoughImage.Width = 167
        '
        'ColRoughVideo
        '
        Me.ColRoughVideo.Caption = "Rough Video"
        Me.ColRoughVideo.FieldName = "RoughVideo"
        Me.ColRoughVideo.Name = "ColRoughVideo"
        Me.ColRoughVideo.Visible = True
        Me.ColRoughVideo.VisibleIndex = 21
        Me.ColRoughVideo.Width = 180
        '
        'ColTransactionID
        '
        Me.ColTransactionID.Caption = "Transaction ID"
        Me.ColTransactionID.FieldName = "TransactionID"
        Me.ColTransactionID.Name = "ColTransactionID"
        '
        'LNK
        '
        Me.LNK.Name = "LNK"
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'VBN
        '
        Me.VBN.AutoHeight = False
        Me.VBN.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(), New DevExpress.XtraEditors.Controls.EditorButton(), New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.VBN.Name = "VBN"
        '
        'dtp
        '
        Me.dtp.CustomFormat = "dd-MM-yyyy"
        Me.dtp.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp.Location = New System.Drawing.Point(21, 55)
        Me.dtp.Name = "dtp"
        Me.dtp.Size = New System.Drawing.Size(88, 21)
        Me.dtp.TabIndex = 9
        '
        'cmbshape
        '
        Me.cmbshape.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbshape.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbshape.FormattingEnabled = True
        Me.cmbshape.Location = New System.Drawing.Point(21, 102)
        Me.cmbshape.Name = "cmbshape"
        Me.cmbshape.Size = New System.Drawing.Size(79, 21)
        Me.cmbshape.TabIndex = 8
        '
        'txtStockID
        '
        Me.txtStockID.Location = New System.Drawing.Point(468, 55)
        Me.txtStockID.Name = "txtStockID"
        Me.txtStockID.Size = New System.Drawing.Size(79, 20)
        Me.txtStockID.TabIndex = 6
        '
        'txtQty
        '
        Me.txtQty.Location = New System.Drawing.Point(557, 55)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(79, 20)
        Me.txtQty.TabIndex = 6
        '
        'txtCarats
        '
        Me.txtCarats.Location = New System.Drawing.Point(646, 55)
        Me.txtCarats.Name = "txtCarats"
        Me.txtCarats.Size = New System.Drawing.Size(79, 20)
        Me.txtCarats.TabIndex = 6
        '
        'txtLabourINR
        '
        Me.txtLabourINR.Location = New System.Drawing.Point(735, 55)
        Me.txtLabourINR.Name = "txtLabourINR"
        Me.txtLabourINR.Size = New System.Drawing.Size(81, 20)
        Me.txtLabourINR.TabIndex = 6
        '
        'cmbcolor
        '
        Me.cmbcolor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbcolor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbcolor.FormattingEnabled = True
        Me.cmbcolor.Location = New System.Drawing.Point(110, 102)
        Me.cmbcolor.Name = "cmbcolor"
        Me.cmbcolor.Size = New System.Drawing.Size(79, 21)
        Me.cmbcolor.TabIndex = 8
        '
        'cmbclarity
        '
        Me.cmbclarity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbclarity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbclarity.FormattingEnabled = True
        Me.cmbclarity.Location = New System.Drawing.Point(199, 102)
        Me.cmbclarity.Name = "cmbclarity"
        Me.cmbclarity.Size = New System.Drawing.Size(79, 21)
        Me.cmbclarity.TabIndex = 8
        '
        'cmbflour
        '
        Me.cmbflour.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbflour.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbflour.FormattingEnabled = True
        Me.cmbflour.Location = New System.Drawing.Point(377, 102)
        Me.cmbflour.Name = "cmbflour"
        Me.cmbflour.Size = New System.Drawing.Size(79, 21)
        Me.cmbflour.TabIndex = 8
        '
        'cmbcut
        '
        Me.cmbcut.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbcut.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbcut.FormattingEnabled = True
        Me.cmbcut.Location = New System.Drawing.Point(466, 102)
        Me.cmbcut.Name = "cmbcut"
        Me.cmbcut.Size = New System.Drawing.Size(79, 21)
        Me.cmbcut.TabIndex = 8
        '
        'cmbpolish
        '
        Me.cmbpolish.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbpolish.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbpolish.FormattingEnabled = True
        Me.cmbpolish.Location = New System.Drawing.Point(555, 102)
        Me.cmbpolish.Name = "cmbpolish"
        Me.cmbpolish.Size = New System.Drawing.Size(81, 21)
        Me.cmbpolish.TabIndex = 8
        '
        'cmbsymm
        '
        Me.cmbsymm.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbsymm.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbsymm.FormattingEnabled = True
        Me.cmbsymm.Location = New System.Drawing.Point(646, 102)
        Me.cmbsymm.Name = "cmbsymm"
        Me.cmbsymm.Size = New System.Drawing.Size(79, 21)
        Me.cmbsymm.TabIndex = 8
        '
        'cmbItemType
        '
        Me.cmbItemType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbItemType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbItemType.FormattingEnabled = True
        Me.cmbItemType.Location = New System.Drawing.Point(119, 55)
        Me.cmbItemType.Name = "cmbItemType"
        Me.cmbItemType.Size = New System.Drawing.Size(87, 21)
        Me.cmbItemType.TabIndex = 5
        '
        'txtcomment
        '
        Me.txtcomment.Location = New System.Drawing.Point(735, 102)
        Me.txtcomment.Name = "txtcomment"
        Me.txtcomment.Size = New System.Drawing.Size(81, 20)
        Me.txtcomment.TabIndex = 6
        '
        'txtrap
        '
        Me.txtrap.Location = New System.Drawing.Point(288, 102)
        Me.txtrap.Name = "txtrap"
        Me.txtrap.ReadOnly = True
        Me.txtrap.Size = New System.Drawing.Size(79, 20)
        Me.txtrap.TabIndex = 6
        Me.txtrap.TabStop = False
        '
        'txtimagelink
        '
        Me.txtimagelink.Location = New System.Drawing.Point(505, 133)
        Me.txtimagelink.Name = "txtimagelink"
        Me.txtimagelink.Size = New System.Drawing.Size(311, 20)
        Me.txtimagelink.TabIndex = 13
        '
        'cmbMainLotName
        '
        Me.cmbMainLotName.EditValue = "a"
        Me.cmbMainLotName.Location = New System.Drawing.Point(216, 55)
        Me.cmbMainLotName.Name = "cmbMainLotName"
        Me.cmbMainLotName.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbMainLotName.Properties.DisplayMember = "MainLotName"
        Me.cmbMainLotName.Properties.NullText = ""
        Me.cmbMainLotName.Properties.NullValuePrompt = "Enter Lot Name to search..."
        Me.cmbMainLotName.Properties.PopupView = Me.SearchLookUpEdit2View
        Me.cmbMainLotName.Size = New System.Drawing.Size(242, 20)
        Me.cmbMainLotName.StyleController = Me.LayoutControl1
        Me.cmbMainLotName.TabIndex = 15
        '
        'SearchLookUpEdit2View
        '
        Me.SearchLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit2View.Name = "SearchLookUpEdit2View"
        Me.SearchLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit2View.OptionsView.ShowGroupPanel = False
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup1, Me.LayoutControlGroup2})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(837, 423)
        Me.Root.TextVisible = False
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem15, Me.LayoutControlItem8, Me.LayoutControlItem22, Me.LayoutControlItem16, Me.LayoutControlItem9, Me.LayoutControlItem10, Me.LayoutControlItem18, Me.LayoutControlItem11, Me.LayoutControlItem1, Me.LayoutControlItem12, Me.LayoutControlItem13, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem14, Me.LayoutControlItem7, Me.LayoutControlItem17, Me.LayoutControlItem23, Me.LayoutControlItem2})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(817, 154)
        Me.LayoutControlGroup1.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.LayoutControlGroup1.Text = "Stock Import"
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.Control = Me.dtp
        Me.LayoutControlItem15.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem15.Name = "LayoutControlItem15"
        Me.LayoutControlItem15.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.LayoutControlItem15.Size = New System.Drawing.Size(98, 47)
        Me.LayoutControlItem15.Text = "Date"
        Me.LayoutControlItem15.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(79, 13)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.cmbshape
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 47)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.LayoutControlItem8.Size = New System.Drawing.Size(89, 47)
        Me.LayoutControlItem8.Text = "Shape"
        Me.LayoutControlItem8.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(79, 13)
        '
        'LayoutControlItem22
        '
        Me.LayoutControlItem22.Control = Me.txtvideolink
        Me.LayoutControlItem22.Location = New System.Drawing.Point(0, 94)
        Me.LayoutControlItem22.Name = "LayoutControlItem22"
        Me.LayoutControlItem22.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.LayoutControlItem22.Size = New System.Drawing.Size(402, 30)
        Me.LayoutControlItem22.Text = "Video Link"
        Me.LayoutControlItem22.TextSize = New System.Drawing.Size(79, 13)
        '
        'LayoutControlItem16
        '
        Me.LayoutControlItem16.Control = Me.cmbItemType
        Me.LayoutControlItem16.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem16.CustomizationFormText = "Main Lot Name"
        Me.LayoutControlItem16.Location = New System.Drawing.Point(98, 0)
        Me.LayoutControlItem16.Name = "LayoutControlItem16"
        Me.LayoutControlItem16.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.LayoutControlItem16.Size = New System.Drawing.Size(97, 47)
        Me.LayoutControlItem16.Text = "Item Type"
        Me.LayoutControlItem16.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem16.TextSize = New System.Drawing.Size(79, 13)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.cmbcolor
        Me.LayoutControlItem9.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem9.CustomizationFormText = "Shape"
        Me.LayoutControlItem9.Location = New System.Drawing.Point(89, 47)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.LayoutControlItem9.Size = New System.Drawing.Size(89, 47)
        Me.LayoutControlItem9.Text = "Color"
        Me.LayoutControlItem9.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(79, 13)
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.cmbclarity
        Me.LayoutControlItem10.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem10.CustomizationFormText = "Shape"
        Me.LayoutControlItem10.Location = New System.Drawing.Point(178, 47)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.LayoutControlItem10.Size = New System.Drawing.Size(89, 47)
        Me.LayoutControlItem10.Text = "Clarity"
        Me.LayoutControlItem10.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(79, 13)
        '
        'LayoutControlItem18
        '
        Me.LayoutControlItem18.Control = Me.txtrap
        Me.LayoutControlItem18.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem18.CustomizationFormText = "Stock ID"
        Me.LayoutControlItem18.Location = New System.Drawing.Point(267, 47)
        Me.LayoutControlItem18.Name = "LayoutControlItem18"
        Me.LayoutControlItem18.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.LayoutControlItem18.Size = New System.Drawing.Size(89, 47)
        Me.LayoutControlItem18.Text = "RAP"
        Me.LayoutControlItem18.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem18.TextSize = New System.Drawing.Size(79, 13)
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.cmbflour
        Me.LayoutControlItem11.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem11.CustomizationFormText = "Shape"
        Me.LayoutControlItem11.Location = New System.Drawing.Point(356, 47)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.LayoutControlItem11.Size = New System.Drawing.Size(89, 47)
        Me.LayoutControlItem11.Text = "Flour"
        Me.LayoutControlItem11.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(79, 13)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.txtStockID
        Me.LayoutControlItem1.Location = New System.Drawing.Point(447, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.LayoutControlItem1.Size = New System.Drawing.Size(89, 47)
        Me.LayoutControlItem1.Text = "Stock ID"
        Me.LayoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(79, 13)
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.cmbcut
        Me.LayoutControlItem12.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem12.CustomizationFormText = "Shape"
        Me.LayoutControlItem12.Location = New System.Drawing.Point(445, 47)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.LayoutControlItem12.Size = New System.Drawing.Size(89, 47)
        Me.LayoutControlItem12.Text = "Cut"
        Me.LayoutControlItem12.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(79, 13)
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.cmbpolish
        Me.LayoutControlItem13.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem13.CustomizationFormText = "Shape"
        Me.LayoutControlItem13.Location = New System.Drawing.Point(534, 47)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.LayoutControlItem13.Size = New System.Drawing.Size(91, 47)
        Me.LayoutControlItem13.Text = "Polish"
        Me.LayoutControlItem13.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(79, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.txtQty
        Me.LayoutControlItem5.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem5.CustomizationFormText = "Stock ID"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(536, 0)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.LayoutControlItem5.Size = New System.Drawing.Size(89, 47)
        Me.LayoutControlItem5.Text = "Qty"
        Me.LayoutControlItem5.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(79, 13)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.txtCarats
        Me.LayoutControlItem6.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem6.CustomizationFormText = "Stock ID"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(625, 0)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.LayoutControlItem6.Size = New System.Drawing.Size(89, 47)
        Me.LayoutControlItem6.Text = "Carats"
        Me.LayoutControlItem6.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(79, 13)
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.cmbsymm
        Me.LayoutControlItem14.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem14.CustomizationFormText = "Shape"
        Me.LayoutControlItem14.Location = New System.Drawing.Point(625, 47)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.LayoutControlItem14.Size = New System.Drawing.Size(89, 47)
        Me.LayoutControlItem14.Text = "Symmetry"
        Me.LayoutControlItem14.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(79, 13)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.txtLabourINR
        Me.LayoutControlItem7.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem7.CustomizationFormText = "Stock ID"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(714, 0)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.LayoutControlItem7.Size = New System.Drawing.Size(91, 47)
        Me.LayoutControlItem7.Text = "Labour Cost INR"
        Me.LayoutControlItem7.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(79, 13)
        '
        'LayoutControlItem17
        '
        Me.LayoutControlItem17.Control = Me.txtcomment
        Me.LayoutControlItem17.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem17.CustomizationFormText = "Stock ID"
        Me.LayoutControlItem17.Location = New System.Drawing.Point(714, 47)
        Me.LayoutControlItem17.Name = "LayoutControlItem17"
        Me.LayoutControlItem17.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.LayoutControlItem17.Size = New System.Drawing.Size(91, 47)
        Me.LayoutControlItem17.Text = "Comment Mauni"
        Me.LayoutControlItem17.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem17.TextSize = New System.Drawing.Size(79, 13)
        '
        'LayoutControlItem23
        '
        Me.LayoutControlItem23.Control = Me.txtimagelink
        Me.LayoutControlItem23.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem23.CustomizationFormText = "Polish Video Link"
        Me.LayoutControlItem23.Location = New System.Drawing.Point(402, 94)
        Me.LayoutControlItem23.Name = "LayoutControlItem23"
        Me.LayoutControlItem23.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.LayoutControlItem23.Size = New System.Drawing.Size(403, 30)
        Me.LayoutControlItem23.Text = "Image Link"
        Me.LayoutControlItem23.TextSize = New System.Drawing.Size(79, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.cmbMainLotName
        Me.LayoutControlItem2.Location = New System.Drawing.Point(195, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.LayoutControlItem2.Size = New System.Drawing.Size(252, 47)
        Me.LayoutControlItem2.Text = "Main Lot Name"
        Me.LayoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(79, 13)
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem20})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 154)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(817, 249)
        Me.LayoutControlGroup2.TextVisible = False
        '
        'LayoutControlItem20
        '
        Me.LayoutControlItem20.Control = Me.dg
        Me.LayoutControlItem20.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem20.Name = "LayoutControlItem20"
        Me.LayoutControlItem20.Size = New System.Drawing.Size(801, 233)
        Me.LayoutControlItem20.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem20.TextVisible = False
        '
        'DockManager1
        '
        Me.DockManager1.AutoHideContainers.AddRange(New DevExpress.XtraBars.Docking.AutoHideContainer() {Me.hideContainerRight})
        Me.DockManager1.Form = Me
        Me.DockManager1.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "System.Windows.Forms.StatusBar", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane", "DevExpress.XtraBars.TabFormControl", "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl", "DevExpress.XtraBars.ToolbarForm.ToolbarFormControl"})
        '
        'hideContainerRight
        '
        Me.hideContainerRight.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.hideContainerRight.Controls.Add(Me.DP1)
        Me.hideContainerRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.hideContainerRight.Location = New System.Drawing.Point(837, 143)
        Me.hideContainerRight.Name = "hideContainerRight"
        Me.hideContainerRight.Size = New System.Drawing.Size(19, 423)
        '
        'DP1
        '
        Me.DP1.Controls.Add(Me.DockPanel1_Container)
        Me.DP1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
        Me.DP1.ID = New System.Guid("1916d486-155e-4267-ae0e-226b475b4bbc")
        Me.DP1.Location = New System.Drawing.Point(0, 0)
        Me.DP1.Name = "DP1"
        Me.DP1.OriginalSize = New System.Drawing.Size(200, 200)
        Me.DP1.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Right
        Me.DP1.SavedIndex = 0
        Me.DP1.Size = New System.Drawing.Size(200, 597)
        Me.DP1.Text = "Columns Layout"
        Me.DP1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.PropertyGridControl1)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(4, 26)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(193, 568)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'PropertyGridControl1
        '
        Me.PropertyGridControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PropertyGridControl1.Cursor = System.Windows.Forms.Cursors.Default
        Me.PropertyGridControl1.CustomizationFormBounds = New System.Drawing.Rectangle(433, 152, 214, 258)
        Me.PropertyGridControl1.DefaultEditors.AddRange(New DevExpress.XtraVerticalGrid.Rows.DefaultEditor() {New DevExpress.XtraVerticalGrid.Rows.DefaultEditor(GetType(Boolean), Me.RepositoryItemCheckEdit1)})
        Me.PropertyGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PropertyGridControl1.Location = New System.Drawing.Point(0, 0)
        Me.PropertyGridControl1.Name = "PropertyGridControl1"
        Me.PropertyGridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.PropertyGridControl1.Rows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.row, Me.row1, Me.row2, Me.row3, Me.row4, Me.row5, Me.row6, Me.row7, Me.row8, Me.row9, Me.row10, Me.row11, Me.row12})
        Me.PropertyGridControl1.Size = New System.Drawing.Size(193, 568)
        Me.PropertyGridControl1.TabIndex = 0
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.CheckBoxOptions.Style = DevExpress.XtraEditors.Controls.CheckBoxStyle.SvgToggle1
        Me.RepositoryItemCheckEdit1.CheckBoxOptions.SvgColorChecked = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Information
        Me.RepositoryItemCheckEdit1.CheckBoxOptions.SvgColorUnchecked = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Critical
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'row
        '
        Me.row.Name = "row"
        Me.row.Properties.Caption = "row"
        Me.row.Properties.RowEdit = Me.RepositoryItemCheckEdit1
        '
        'row1
        '
        Me.row1.Name = "row1"
        Me.row1.Properties.Caption = "row1"
        Me.row1.Properties.RowEdit = Me.RepositoryItemCheckEdit1
        '
        'row2
        '
        Me.row2.Name = "row2"
        Me.row2.Properties.Caption = "row2"
        Me.row2.Properties.RowEdit = Me.RepositoryItemCheckEdit1
        '
        'row3
        '
        Me.row3.Name = "row3"
        Me.row3.Properties.Caption = "row3"
        Me.row3.Properties.RowEdit = Me.RepositoryItemCheckEdit1
        '
        'row4
        '
        Me.row4.Name = "row4"
        Me.row4.Properties.Caption = "row4"
        Me.row4.Properties.RowEdit = Me.RepositoryItemCheckEdit1
        '
        'row5
        '
        Me.row5.Name = "row5"
        Me.row5.Properties.Caption = "row5"
        Me.row5.Properties.RowEdit = Me.RepositoryItemCheckEdit1
        '
        'row6
        '
        Me.row6.Name = "row6"
        Me.row6.Properties.Caption = "row6"
        Me.row6.Properties.RowEdit = Me.RepositoryItemCheckEdit1
        '
        'row7
        '
        Me.row7.Name = "row7"
        Me.row7.Properties.Caption = "row7"
        Me.row7.Properties.RowEdit = Me.RepositoryItemCheckEdit1
        '
        'row8
        '
        Me.row8.Name = "row8"
        Me.row8.Properties.Caption = "row8"
        Me.row8.Properties.RowEdit = Me.RepositoryItemCheckEdit1
        '
        'row9
        '
        Me.row9.Name = "row9"
        Me.row9.Properties.Caption = "row9"
        Me.row9.Properties.RowEdit = Me.RepositoryItemCheckEdit1
        '
        'row10
        '
        Me.row10.Name = "row10"
        Me.row10.Properties.Caption = "row10"
        Me.row10.Properties.RowEdit = Me.RepositoryItemCheckEdit1
        '
        'row11
        '
        Me.row11.Name = "row11"
        Me.row11.Properties.Caption = "row11"
        Me.row11.Properties.RowEdit = Me.RepositoryItemCheckEdit1
        '
        'row12
        '
        Me.row12.Name = "row12"
        Me.row12.Properties.Caption = "row12"
        Me.row12.Properties.RowEdit = Me.RepositoryItemCheckEdit1
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.RibbonControl1.SearchEditItem, Me.btnSave, Me.btnCancel, Me.btnPrint, Me.btnDelete, Me.btnReftesh})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 6
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.Size = New System.Drawing.Size(856, 143)
        Me.RibbonControl1.StatusBar = Me.RibbonStatusBar1
        '
        'btnSave
        '
        Me.btnSave.Caption = "Save"
        Me.btnSave.Id = 1
        Me.btnSave.ImageOptions.SvgImage = CType(resources.GetObject("btnSave.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btnSave.Name = "btnSave"
        '
        'btnCancel
        '
        Me.btnCancel.Caption = "Cancel"
        Me.btnCancel.Id = 2
        Me.btnCancel.ImageOptions.SvgImage = CType(resources.GetObject("btnCancel.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btnCancel.Name = "btnCancel"
        '
        'btnPrint
        '
        Me.btnPrint.Caption = "Print Barcode"
        Me.btnPrint.Id = 3
        Me.btnPrint.ImageOptions.SvgImage = CType(resources.GetObject("btnPrint.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btnPrint.Name = "btnPrint"
        '
        'btnDelete
        '
        Me.btnDelete.Caption = "Delete"
        Me.btnDelete.Id = 4
        Me.btnDelete.ImageOptions.SvgImage = CType(resources.GetObject("btnDelete.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btnDelete.Name = "btnDelete"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1, Me.RibbonPageGroup2})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "Actions"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnSave)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnCancel)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnDelete)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnReftesh)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnPrint)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        '
        'RibbonStatusBar1
        '
        Me.RibbonStatusBar1.Location = New System.Drawing.Point(0, 566)
        Me.RibbonStatusBar1.Name = "RibbonStatusBar1"
        Me.RibbonStatusBar1.Ribbon = Me.RibbonControl1
        Me.RibbonStatusBar1.Size = New System.Drawing.Size(856, 31)
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Text = "RibbonPage2"
        '
        'btnReftesh
        '
        Me.btnReftesh.Caption = "Refresh"
        Me.btnReftesh.Id = 5
        Me.btnReftesh.ImageOptions.SvgImage = CType(resources.GetObject("BarButtonItem1.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btnReftesh.Name = "btnReftesh"
        '
        'FrmStockImport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(856, 597)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.hideContainerRight)
        Me.Controls.Add(Me.RibbonStatusBar1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.Name = "FrmStockImport"
        Me.Ribbon = Me.RibbonControl1
        Me.StatusBar = Me.RibbonStatusBar1
        Me.Text = "Stock Import"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgview, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LNK, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VBN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbMainLotName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit2View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hideContainerRight.ResumeLayout(False)
        Me.DP1.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        CType(Me.PropertyGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents txtStockID As TextBox
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtQty As TextBox
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtCarats As TextBox
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtLabourINR As TextBox
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cmbshape As ComboBox
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cmbcolor As ComboBox
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cmbclarity As ComboBox
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cmbflour As ComboBox
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cmbcut As ComboBox
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cmbpolish As ComboBox
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents dtp As DateTimePicker
    Friend WithEvents cmbsymm As ComboBox
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cmbItemType As ComboBox
    Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtcomment As TextBox
    Friend WithEvents LayoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents dg As DevExpress.XtraGrid.GridControl
    Friend WithEvents dgview As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtrap As TextBox
    Friend WithEvents LayoutControlItem18 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem20 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtvideolink As TextBox
    Friend WithEvents LayoutControlItem22 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtimagelink As TextBox
    Friend WithEvents LayoutControlItem23 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cmbMainLotName As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit2View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LNK As DevExpress.XtraEditors.Repository.RepositoryItemHypertextLabel
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents VBN As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents Col_Barcode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CompanyID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BranchID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents UserID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ImportDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ItemTypeID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MainLotID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents StockID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabourINR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ShapeID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColorID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ClarityID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RAP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FloID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CutID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PolishID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SymID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Comment As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Carats As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColShape As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColColor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColClarity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColFlour As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColCut As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColPolish As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColSymm As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColItemType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColMainLotName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColMainLotCarats As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColVideoLink As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColImageLink As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColRoughImage As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColRoughVideo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents hideContainerRight As DevExpress.XtraBars.Docking.AutoHideContainer
    Friend WithEvents DP1 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents PropertyGridControl1 As DevExpress.XtraVerticalGrid.PropertyGridControl
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents row As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents row1 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents row2 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents row3 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents row4 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents row5 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents row6 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents row7 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents row8 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents row9 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents row10 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents row11 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents row12 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonStatusBar1 As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents btnSave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCancel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnPrint As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ColTransactionID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnDelete As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnReftesh As DevExpress.XtraBars.BarButtonItem
End Class
