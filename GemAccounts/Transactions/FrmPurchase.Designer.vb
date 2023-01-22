<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPurchase
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPurchase))
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.LayoutControl2 = New DevExpress.XtraLayout.LayoutControl()
        Me.LayoutControl3 = New DevExpress.XtraLayout.LayoutControl()
        Me.btnAttachment = New DevExpress.XtraEditors.SimpleButton()
        Me.txtAttachment = New DevExpress.XtraEditors.TextEdit()
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnSave = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCancel = New DevExpress.XtraBars.BarButtonItem()
        Me.btnClose = New DevExpress.XtraBars.BarButtonItem()
        Me.btnExport = New DevExpress.XtraBars.BarButtonItem()
        Me.btnRefresh = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar1 = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.lblExpPercent = New System.Windows.Forms.Label()
        Me.cmbPurchaseLedger = New System.Windows.Forms.ComboBox()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.txtNetINR = New System.Windows.Forms.TextBox()
        Me.cmbVendorName = New System.Windows.Forms.ComboBox()
        Me.cmbterms = New System.Windows.Forms.ComboBox()
        Me.dtp = New System.Windows.Forms.DateTimePicker()
        Me.txtExRate = New System.Windows.Forms.TextBox()
        Me.DtpDue = New System.Windows.Forms.DateTimePicker()
        Me.txtNetUSD = New System.Windows.Forms.TextBox()
        Me.txtAddExpUSD = New System.Windows.Forms.TextBox()
        Me.cmbItemType = New System.Windows.Forms.ComboBox()
        Me.txtGrossUSD = New System.Windows.Forms.TextBox()
        Me.txtPcs = New System.Windows.Forms.TextBox()
        Me.txtCts = New System.Windows.Forms.TextBox()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem20 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem21 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.dg = New DevExpress.XtraGrid.GridControl()
        Me.view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Col_PurchaseID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Col_CompanyID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Col_BranchID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Col_UserID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Col_PurchaseDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Col_VendorID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Col_Terms = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Col_ItemType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Col_Pcs = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Col_Carats = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Col_GrossTotalUSD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Col_AddExpUSD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Col_ExchangeRate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Col_NetUSD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Col_NetINR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Col_Remarks = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Col_SerieStatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
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
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.riAttachementCheckEdit = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteMenu = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl2.SuspendLayout()
        CType(Me.LayoutControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl3.SuspendLayout()
        CType(Me.txtAttachment.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.riAttachementCheckEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenu1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.SplitContainerControl1)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 143)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(1004, 459)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Location = New System.Drawing.Point(12, 12)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.LayoutControl2)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.dg)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(980, 435)
        Me.SplitContainerControl1.SplitterPosition = 300
        Me.SplitContainerControl1.TabIndex = 15
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'LayoutControl2
        '
        Me.LayoutControl2.Controls.Add(Me.LayoutControl3)
        Me.LayoutControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl2.Name = "LayoutControl2"
        Me.LayoutControl2.Root = Me.LayoutControlGroup4
        Me.LayoutControl2.Size = New System.Drawing.Size(300, 435)
        Me.LayoutControl2.TabIndex = 0
        Me.LayoutControl2.Text = "LayoutControl2"
        '
        'LayoutControl3
        '
        Me.LayoutControl3.Controls.Add(Me.btnAttachment)
        Me.LayoutControl3.Controls.Add(Me.txtAttachment)
        Me.LayoutControl3.Controls.Add(Me.lblExpPercent)
        Me.LayoutControl3.Controls.Add(Me.cmbPurchaseLedger)
        Me.LayoutControl3.Controls.Add(Me.txtRemarks)
        Me.LayoutControl3.Controls.Add(Me.txtNetINR)
        Me.LayoutControl3.Controls.Add(Me.cmbVendorName)
        Me.LayoutControl3.Controls.Add(Me.cmbterms)
        Me.LayoutControl3.Controls.Add(Me.dtp)
        Me.LayoutControl3.Controls.Add(Me.txtExRate)
        Me.LayoutControl3.Controls.Add(Me.DtpDue)
        Me.LayoutControl3.Controls.Add(Me.txtNetUSD)
        Me.LayoutControl3.Controls.Add(Me.txtAddExpUSD)
        Me.LayoutControl3.Controls.Add(Me.cmbItemType)
        Me.LayoutControl3.Controls.Add(Me.txtGrossUSD)
        Me.LayoutControl3.Controls.Add(Me.txtPcs)
        Me.LayoutControl3.Controls.Add(Me.txtCts)
        Me.LayoutControl3.Location = New System.Drawing.Point(12, 12)
        Me.LayoutControl3.Name = "LayoutControl3"
        Me.LayoutControl3.Root = Me.Root
        Me.LayoutControl3.Size = New System.Drawing.Size(276, 411)
        Me.LayoutControl3.TabIndex = 4
        Me.LayoutControl3.Text = "LayoutControl3"
        '
        'btnAttachment
        '
        Me.btnAttachment.ImageOptions.Image = CType(resources.GetObject("btnAttachment.ImageOptions.Image"), System.Drawing.Image)
        Me.btnAttachment.Location = New System.Drawing.Point(12, 362)
        Me.btnAttachment.Name = "btnAttachment"
        Me.btnAttachment.Size = New System.Drawing.Size(95, 22)
        Me.btnAttachment.StyleController = Me.LayoutControl3
        Me.btnAttachment.TabIndex = 17
        Me.btnAttachment.Text = "Attach PDF"
        '
        'txtAttachment
        '
        Me.txtAttachment.Enabled = False
        Me.txtAttachment.Location = New System.Drawing.Point(111, 362)
        Me.txtAttachment.MenuManager = Me.RibbonControl1
        Me.txtAttachment.Name = "txtAttachment"
        Me.txtAttachment.Size = New System.Drawing.Size(153, 20)
        Me.txtAttachment.StyleController = Me.LayoutControl3
        Me.txtAttachment.TabIndex = 16
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.RibbonControl1.SearchEditItem, Me.btnSave, Me.btnCancel, Me.btnClose, Me.btnExport, Me.btnRefresh})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 6
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.Size = New System.Drawing.Size(1004, 143)
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
        'btnClose
        '
        Me.btnClose.Caption = "Close"
        Me.btnClose.Id = 3
        Me.btnClose.ImageOptions.SvgImage = CType(resources.GetObject("btnClose.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btnClose.Name = "btnClose"
        '
        'btnExport
        '
        Me.btnExport.Caption = "Export"
        Me.btnExport.Id = 4
        Me.btnExport.ImageOptions.SvgImage = CType(resources.GetObject("btnExport.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btnExport.Name = "btnExport"
        '
        'btnRefresh
        '
        Me.btnRefresh.Caption = "Refresh"
        Me.btnRefresh.Id = 5
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
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnSave)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnCancel)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnClose)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnExport)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnRefresh)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        '
        'RibbonStatusBar1
        '
        Me.RibbonStatusBar1.Location = New System.Drawing.Point(0, 602)
        Me.RibbonStatusBar1.Name = "RibbonStatusBar1"
        Me.RibbonStatusBar1.Ribbon = Me.RibbonControl1
        Me.RibbonStatusBar1.Size = New System.Drawing.Size(1004, 31)
        '
        'lblExpPercent
        '
        Me.lblExpPercent.Location = New System.Drawing.Point(197, 232)
        Me.lblExpPercent.Name = "lblExpPercent"
        Me.lblExpPercent.Size = New System.Drawing.Size(67, 20)
        Me.lblExpPercent.TabIndex = 15
        Me.lblExpPercent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbPurchaseLedger
        '
        Me.cmbPurchaseLedger.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbPurchaseLedger.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbPurchaseLedger.FormattingEnabled = True
        Me.cmbPurchaseLedger.Location = New System.Drawing.Point(110, 36)
        Me.cmbPurchaseLedger.Name = "cmbPurchaseLedger"
        Me.cmbPurchaseLedger.Size = New System.Drawing.Size(154, 21)
        Me.cmbPurchaseLedger.TabIndex = 1
        '
        'txtRemarks
        '
        Me.txtRemarks.Location = New System.Drawing.Point(110, 328)
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(154, 20)
        Me.txtRemarks.TabIndex = 11
        '
        'txtNetINR
        '
        Me.txtNetINR.Location = New System.Drawing.Point(110, 304)
        Me.txtNetINR.Name = "txtNetINR"
        Me.txtNetINR.Size = New System.Drawing.Size(154, 20)
        Me.txtNetINR.TabIndex = 10
        Me.txtNetINR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmbVendorName
        '
        Me.cmbVendorName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbVendorName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbVendorName.FormattingEnabled = True
        Me.cmbVendorName.Location = New System.Drawing.Point(110, 61)
        Me.cmbVendorName.Name = "cmbVendorName"
        Me.cmbVendorName.Size = New System.Drawing.Size(154, 21)
        Me.cmbVendorName.TabIndex = 2
        '
        'cmbterms
        '
        Me.cmbterms.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbterms.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbterms.FormattingEnabled = True
        Me.cmbterms.Location = New System.Drawing.Point(110, 86)
        Me.cmbterms.Name = "cmbterms"
        Me.cmbterms.Size = New System.Drawing.Size(154, 21)
        Me.cmbterms.TabIndex = 3
        '
        'dtp
        '
        Me.dtp.CustomFormat = "dd-MM-yyyy"
        Me.dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp.Location = New System.Drawing.Point(110, 12)
        Me.dtp.Name = "dtp"
        Me.dtp.Size = New System.Drawing.Size(154, 21)
        Me.dtp.TabIndex = 0
        '
        'txtExRate
        '
        Me.txtExRate.Location = New System.Drawing.Point(110, 280)
        Me.txtExRate.Name = "txtExRate"
        Me.txtExRate.Size = New System.Drawing.Size(154, 20)
        Me.txtExRate.TabIndex = 9
        Me.txtExRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DtpDue
        '
        Me.DtpDue.CustomFormat = "dd-MM-yyyy"
        Me.DtpDue.Enabled = False
        Me.DtpDue.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtpDue.Location = New System.Drawing.Point(110, 111)
        Me.DtpDue.Name = "DtpDue"
        Me.DtpDue.Size = New System.Drawing.Size(154, 21)
        Me.DtpDue.TabIndex = 1
        '
        'txtNetUSD
        '
        Me.txtNetUSD.Location = New System.Drawing.Point(110, 256)
        Me.txtNetUSD.Name = "txtNetUSD"
        Me.txtNetUSD.Size = New System.Drawing.Size(154, 20)
        Me.txtNetUSD.TabIndex = 9
        Me.txtNetUSD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtAddExpUSD
        '
        Me.txtAddExpUSD.Enabled = False
        Me.txtAddExpUSD.Location = New System.Drawing.Point(110, 232)
        Me.txtAddExpUSD.Name = "txtAddExpUSD"
        Me.txtAddExpUSD.Size = New System.Drawing.Size(83, 20)
        Me.txtAddExpUSD.TabIndex = 8
        Me.txtAddExpUSD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmbItemType
        '
        Me.cmbItemType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbItemType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbItemType.FormattingEnabled = True
        Me.cmbItemType.Location = New System.Drawing.Point(110, 135)
        Me.cmbItemType.Name = "cmbItemType"
        Me.cmbItemType.Size = New System.Drawing.Size(154, 21)
        Me.cmbItemType.TabIndex = 4
        '
        'txtGrossUSD
        '
        Me.txtGrossUSD.Location = New System.Drawing.Point(110, 208)
        Me.txtGrossUSD.Name = "txtGrossUSD"
        Me.txtGrossUSD.Size = New System.Drawing.Size(154, 20)
        Me.txtGrossUSD.TabIndex = 7
        Me.txtGrossUSD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPcs
        '
        Me.txtPcs.Location = New System.Drawing.Point(110, 160)
        Me.txtPcs.Name = "txtPcs"
        Me.txtPcs.Size = New System.Drawing.Size(154, 20)
        Me.txtPcs.TabIndex = 5
        Me.txtPcs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCts
        '
        Me.txtCts.Location = New System.Drawing.Point(110, 184)
        Me.txtCts.Name = "txtCts"
        Me.txtCts.Size = New System.Drawing.Size(154, 20)
        Me.txtCts.TabIndex = 6
        Me.txtCts.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.LayoutControlItem8, Me.LayoutControlItem9, Me.LayoutControlItem10, Me.LayoutControlItem11, Me.LayoutControlItem13, Me.LayoutControlItem14, Me.LayoutControlItem15, Me.LayoutControlItem16, Me.LayoutControlItem17, Me.LayoutControlItem20, Me.LayoutControlItem21, Me.EmptySpaceItem1, Me.EmptySpaceItem2})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(276, 411)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.dtp
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(256, 24)
        Me.LayoutControlItem2.Text = "Purchase Date"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(95, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.cmbVendorName
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 49)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(256, 25)
        Me.LayoutControlItem3.Text = "Vendor"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(95, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.cmbterms
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 74)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(256, 25)
        Me.LayoutControlItem4.Text = "Terms"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(95, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.DtpDue
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 99)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(256, 24)
        Me.LayoutControlItem5.Text = "Due Date"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(95, 13)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.cmbItemType
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 123)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(256, 25)
        Me.LayoutControlItem6.Text = "Item Type"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(95, 13)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.txtPcs
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 148)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(256, 24)
        Me.LayoutControlItem7.Text = "Pieces"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(95, 13)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.txtCts
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 172)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(256, 24)
        Me.LayoutControlItem8.Text = "Carats"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(95, 13)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.txtGrossUSD
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 196)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(256, 24)
        Me.LayoutControlItem9.Text = "Gross Total USD"
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(95, 13)
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.txtAddExpUSD
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 220)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(185, 24)
        Me.LayoutControlItem10.Text = "Additional Exp. USD"
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(95, 13)
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.txtNetUSD
        Me.LayoutControlItem11.Location = New System.Drawing.Point(0, 244)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(256, 24)
        Me.LayoutControlItem11.Text = "Net Total USD"
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(95, 13)
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.txtExRate
        Me.LayoutControlItem13.Location = New System.Drawing.Point(0, 268)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(256, 24)
        Me.LayoutControlItem13.Text = "Exchange Rate"
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(95, 13)
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.txtNetINR
        Me.LayoutControlItem14.Location = New System.Drawing.Point(0, 292)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(256, 24)
        Me.LayoutControlItem14.Text = "Net Total INR"
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(95, 13)
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.Control = Me.txtRemarks
        Me.LayoutControlItem15.Location = New System.Drawing.Point(0, 316)
        Me.LayoutControlItem15.Name = "LayoutControlItem15"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(256, 24)
        Me.LayoutControlItem15.Text = "Remarks"
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(95, 13)
        '
        'LayoutControlItem16
        '
        Me.LayoutControlItem16.Control = Me.cmbPurchaseLedger
        Me.LayoutControlItem16.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem16.Name = "LayoutControlItem16"
        Me.LayoutControlItem16.Size = New System.Drawing.Size(256, 25)
        Me.LayoutControlItem16.Text = "Purchase Ledger"
        Me.LayoutControlItem16.TextSize = New System.Drawing.Size(95, 13)
        '
        'LayoutControlItem17
        '
        Me.LayoutControlItem17.Control = Me.lblExpPercent
        Me.LayoutControlItem17.Location = New System.Drawing.Point(185, 220)
        Me.LayoutControlItem17.Name = "LayoutControlItem17"
        Me.LayoutControlItem17.Size = New System.Drawing.Size(71, 24)
        Me.LayoutControlItem17.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem17.TextVisible = False
        '
        'LayoutControlItem20
        '
        Me.LayoutControlItem20.Control = Me.txtAttachment
        Me.LayoutControlItem20.Location = New System.Drawing.Point(99, 350)
        Me.LayoutControlItem20.Name = "LayoutControlItem20"
        Me.LayoutControlItem20.Size = New System.Drawing.Size(157, 26)
        Me.LayoutControlItem20.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem20.TextVisible = False
        '
        'LayoutControlItem21
        '
        Me.LayoutControlItem21.Control = Me.btnAttachment
        Me.LayoutControlItem21.Location = New System.Drawing.Point(0, 350)
        Me.LayoutControlItem21.MaxSize = New System.Drawing.Size(99, 26)
        Me.LayoutControlItem21.MinSize = New System.Drawing.Size(99, 26)
        Me.LayoutControlItem21.Name = "LayoutControlItem21"
        Me.LayoutControlItem21.Size = New System.Drawing.Size(99, 26)
        Me.LayoutControlItem21.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem21.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem21.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 340)
        Me.EmptySpaceItem1.MaxSize = New System.Drawing.Size(239, 10)
        Me.EmptySpaceItem1.MinSize = New System.Drawing.Size(239, 10)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(256, 10)
        Me.EmptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(0, 376)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(256, 15)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlGroup4
        '
        Me.LayoutControlGroup4.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup4.GroupBordersVisible = False
        Me.LayoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1})
        Me.LayoutControlGroup4.Name = "LayoutControlGroup4"
        Me.LayoutControlGroup4.Size = New System.Drawing.Size(300, 435)
        Me.LayoutControlGroup4.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.LayoutControl3
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(280, 415)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'dg
        '
        Me.dg.ContextMenuStrip = Me.ContextMenu1
        Me.dg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dg.Location = New System.Drawing.Point(0, 0)
        Me.dg.MainView = Me.view
        Me.dg.Name = "dg"
        Me.dg.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.riAttachementCheckEdit})
        Me.dg.Size = New System.Drawing.Size(675, 435)
        Me.dg.TabIndex = 14
        Me.dg.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.view})
        '
        'view
        '
        Me.view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Col_PurchaseID, Me.Col_CompanyID, Me.Col_BranchID, Me.Col_UserID, Me.Col_PurchaseDate, Me.Col_VendorID, Me.Col_Terms, Me.Col_ItemType, Me.Col_Pcs, Me.Col_Carats, Me.Col_GrossTotalUSD, Me.Col_AddExpUSD, Me.Col_ExchangeRate, Me.Col_NetUSD, Me.Col_NetINR, Me.Col_Remarks, Me.Col_SerieStatus, Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.GridColumn10, Me.GridColumn11, Me.GridColumn12, Me.GridColumn13, Me.GridColumn14})
        Me.view.GridControl = Me.dg
        Me.view.Name = "view"
        Me.view.OptionsBehavior.Editable = False
        Me.view.OptionsView.ColumnAutoWidth = False
        Me.view.OptionsView.ShowFooter = True
        '
        'Col_PurchaseID
        '
        Me.Col_PurchaseID.Caption = "Purchase ID"
        Me.Col_PurchaseID.FieldName = "PurchaseID"
        Me.Col_PurchaseID.Name = "Col_PurchaseID"
        Me.Col_PurchaseID.Visible = True
        Me.Col_PurchaseID.VisibleIndex = 1
        '
        'Col_CompanyID
        '
        Me.Col_CompanyID.Caption = "Company ID"
        Me.Col_CompanyID.FieldName = "Company"
        Me.Col_CompanyID.Name = "Col_CompanyID"
        Me.Col_CompanyID.OptionsColumn.AllowShowHide = False
        '
        'Col_BranchID
        '
        Me.Col_BranchID.Caption = "Branch ID"
        Me.Col_BranchID.FieldName = "Branch"
        Me.Col_BranchID.Name = "Col_BranchID"
        Me.Col_BranchID.OptionsColumn.AllowShowHide = False
        '
        'Col_UserID
        '
        Me.Col_UserID.Caption = "User"
        Me.Col_UserID.FieldName = "UserName"
        Me.Col_UserID.Name = "Col_UserID"
        Me.Col_UserID.Visible = True
        Me.Col_UserID.VisibleIndex = 15
        '
        'Col_PurchaseDate
        '
        Me.Col_PurchaseDate.Caption = "Date"
        Me.Col_PurchaseDate.DisplayFormat.FormatString = "dd-MM-yyyy"
        Me.Col_PurchaseDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.Col_PurchaseDate.FieldName = "PurchaseDate"
        Me.Col_PurchaseDate.Name = "Col_PurchaseDate"
        Me.Col_PurchaseDate.Visible = True
        Me.Col_PurchaseDate.VisibleIndex = 2
        '
        'Col_VendorID
        '
        Me.Col_VendorID.Caption = "Vendor ID"
        Me.Col_VendorID.FieldName = "VendorID"
        Me.Col_VendorID.Name = "Col_VendorID"
        Me.Col_VendorID.OptionsColumn.AllowShowHide = False
        '
        'Col_Terms
        '
        Me.Col_Terms.Caption = "Terms ID"
        Me.Col_Terms.FieldName = "TermsID"
        Me.Col_Terms.Name = "Col_Terms"
        Me.Col_Terms.OptionsColumn.AllowShowHide = False
        '
        'Col_ItemType
        '
        Me.Col_ItemType.Caption = "Item Type ID"
        Me.Col_ItemType.FieldName = "ItemTypeID"
        Me.Col_ItemType.Name = "Col_ItemType"
        Me.Col_ItemType.OptionsColumn.AllowShowHide = False
        '
        'Col_Pcs
        '
        Me.Col_Pcs.Caption = "Pcs"
        Me.Col_Pcs.DisplayFormat.FormatString = "n0"
        Me.Col_Pcs.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Col_Pcs.FieldName = "Pcs"
        Me.Col_Pcs.Name = "Col_Pcs"
        Me.Col_Pcs.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Pcs", "{0:n0}")})
        Me.Col_Pcs.Visible = True
        Me.Col_Pcs.VisibleIndex = 8
        Me.Col_Pcs.Width = 42
        '
        'Col_Carats
        '
        Me.Col_Carats.Caption = "Carats"
        Me.Col_Carats.DisplayFormat.FormatString = "n2"
        Me.Col_Carats.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Col_Carats.FieldName = "Carats"
        Me.Col_Carats.Name = "Col_Carats"
        Me.Col_Carats.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Carats", "{0:n2}")})
        Me.Col_Carats.Visible = True
        Me.Col_Carats.VisibleIndex = 9
        '
        'Col_GrossTotalUSD
        '
        Me.Col_GrossTotalUSD.Caption = "Gross USD"
        Me.Col_GrossTotalUSD.DisplayFormat.FormatString = "n2"
        Me.Col_GrossTotalUSD.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Col_GrossTotalUSD.FieldName = "GrossTotalUSD"
        Me.Col_GrossTotalUSD.Name = "Col_GrossTotalUSD"
        Me.Col_GrossTotalUSD.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "GrossTotalUSD", "{0:n2}")})
        Me.Col_GrossTotalUSD.Visible = True
        Me.Col_GrossTotalUSD.VisibleIndex = 10
        Me.Col_GrossTotalUSD.Width = 91
        '
        'Col_AddExpUSD
        '
        Me.Col_AddExpUSD.Caption = "Add Ex. USD"
        Me.Col_AddExpUSD.DisplayFormat.FormatString = "n2"
        Me.Col_AddExpUSD.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Col_AddExpUSD.FieldName = "AddExpUSD"
        Me.Col_AddExpUSD.Name = "Col_AddExpUSD"
        Me.Col_AddExpUSD.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "AddExpUSD", "{0:n2}")})
        Me.Col_AddExpUSD.Visible = True
        Me.Col_AddExpUSD.VisibleIndex = 11
        Me.Col_AddExpUSD.Width = 109
        '
        'Col_ExchangeRate
        '
        Me.Col_ExchangeRate.Caption = "Rate"
        Me.Col_ExchangeRate.DisplayFormat.FormatString = "n2"
        Me.Col_ExchangeRate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Col_ExchangeRate.FieldName = "ExchangeRate"
        Me.Col_ExchangeRate.Name = "Col_ExchangeRate"
        Me.Col_ExchangeRate.Visible = True
        Me.Col_ExchangeRate.VisibleIndex = 12
        Me.Col_ExchangeRate.Width = 91
        '
        'Col_NetUSD
        '
        Me.Col_NetUSD.Caption = "Net USD"
        Me.Col_NetUSD.DisplayFormat.FormatString = "n2"
        Me.Col_NetUSD.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Col_NetUSD.FieldName = "NetUSD"
        Me.Col_NetUSD.Name = "Col_NetUSD"
        Me.Col_NetUSD.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NetUSD", "{0:n2}")})
        Me.Col_NetUSD.Visible = True
        Me.Col_NetUSD.VisibleIndex = 13
        '
        'Col_NetINR
        '
        Me.Col_NetINR.Caption = "Net INR"
        Me.Col_NetINR.DisplayFormat.FormatString = "n2"
        Me.Col_NetINR.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Col_NetINR.FieldName = "NetINR"
        Me.Col_NetINR.Name = "Col_NetINR"
        Me.Col_NetINR.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NetINR", "{0:n2}")})
        Me.Col_NetINR.Visible = True
        Me.Col_NetINR.VisibleIndex = 14
        '
        'Col_Remarks
        '
        Me.Col_Remarks.Caption = "Remarks"
        Me.Col_Remarks.FieldName = "Remarks"
        Me.Col_Remarks.Name = "Col_Remarks"
        Me.Col_Remarks.Visible = True
        Me.Col_Remarks.VisibleIndex = 16
        Me.Col_Remarks.Width = 115
        '
        'Col_SerieStatus
        '
        Me.Col_SerieStatus.Caption = "SerieStatus"
        Me.Col_SerieStatus.FieldName = "SerieStatus"
        Me.Col_SerieStatus.Name = "Col_SerieStatus"
        Me.Col_SerieStatus.OptionsColumn.AllowShowHide = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Vendor"
        Me.GridColumn1.FieldName = "Vendor"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 4
        Me.GridColumn1.Width = 91
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Terms"
        Me.GridColumn2.FieldName = "Terms"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 5
        Me.GridColumn2.Width = 57
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Item Type"
        Me.GridColumn3.FieldName = "ItemType"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 7
        Me.GridColumn3.Width = 59
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Due Date"
        Me.GridColumn4.DisplayFormat.FormatString = "dd-MM-yyyy"
        Me.GridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn4.FieldName = "DueDate"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 6
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "TID"
        Me.GridColumn5.FieldName = "TID"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.AllowShowHide = False
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Purchase Ledger ID"
        Me.GridColumn6.FieldName = "PurchaseLedgerID"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsColumn.AllowShowHide = False
        Me.GridColumn6.Width = 102
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Purchase Ledger"
        Me.GridColumn7.FieldName = "PurchaseLedger"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 3
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Payment USD"
        Me.GridColumn8.DisplayFormat.FormatString = "n2"
        Me.GridColumn8.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn8.FieldName = "PaymentUSD"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PaymentUSD", "{0:n2}")})
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 17
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Avg. Rate"
        Me.GridColumn9.DisplayFormat.FormatString = "n8"
        Me.GridColumn9.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn9.FieldName = "AverageRate"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 18
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Payment INR"
        Me.GridColumn10.DisplayFormat.FormatString = "n2"
        Me.GridColumn10.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn10.FieldName = "PaymentINR"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PaymentINR", "{0:n2}")})
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 19
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "Balance USD"
        Me.GridColumn11.DisplayFormat.FormatString = "n2"
        Me.GridColumn11.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn11.FieldName = "BalanceUSD"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "BalanceUSD", "{0:n2}")})
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 20
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "Balance INR"
        Me.GridColumn12.DisplayFormat.FormatString = "n2"
        Me.GridColumn12.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn12.FieldName = "BalanceINR"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "BalanceINR", "{0:n2}")})
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 21
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "Attachment"
        Me.GridColumn13.FieldName = "Attachment"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.OptionsColumn.AllowShowHide = False
        '
        'GridColumn14
        '
        Me.GridColumn14.Caption = "PDF"
        Me.GridColumn14.ColumnEdit = Me.riAttachementCheckEdit
        Me.GridColumn14.FieldName = "PDF"
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.UnboundExpression = "Iif(IsNullOrEmpty([Attachment]), False, True)"
        Me.GridColumn14.UnboundType = DevExpress.Data.UnboundColumnType.[Boolean]
        Me.GridColumn14.Visible = True
        Me.GridColumn14.VisibleIndex = 0
        Me.GridColumn14.Width = 31
        '
        'riAttachementCheckEdit
        '
        Me.riAttachementCheckEdit.AutoHeight = False
        Me.riAttachementCheckEdit.CheckBoxOptions.Style = DevExpress.XtraEditors.Controls.CheckBoxStyle.Custom
        Me.riAttachementCheckEdit.ImageOptions.ImageChecked = CType(resources.GetObject("riAttachementCheckEdit.ImageOptions.ImageChecked"), System.Drawing.Image)
        Me.riAttachementCheckEdit.Name = "riAttachementCheckEdit"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem12})
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1004, 459)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.SplitContainerControl1
        Me.LayoutControlItem12.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(984, 439)
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem12.TextVisible = False
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Text = "RibbonPage2"
        '
        'ContextMenu1
        '
        Me.ContextMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditMenu, Me.DeleteMenu})
        Me.ContextMenu1.Name = "ContextMenu1"
        Me.ContextMenu1.Size = New System.Drawing.Size(108, 48)
        '
        'EditMenu
        '
        Me.EditMenu.Name = "EditMenu"
        Me.EditMenu.Size = New System.Drawing.Size(107, 22)
        Me.EditMenu.Text = "Edit"
        '
        'DeleteMenu
        '
        Me.DeleteMenu.Name = "DeleteMenu"
        Me.DeleteMenu.Size = New System.Drawing.Size(107, 22)
        Me.DeleteMenu.Text = "Delete"
        '
        'FrmPurchase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1004, 633)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.RibbonStatusBar1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.Name = "FrmPurchase"
        Me.Ribbon = Me.RibbonControl1
        Me.StatusBar = Me.RibbonStatusBar1
        Me.Text = "Purchase"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl2.ResumeLayout(False)
        CType(Me.LayoutControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl3.ResumeLayout(False)
        CType(Me.txtAttachment.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.riAttachementCheckEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenu1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents dg As DevExpress.XtraGrid.GridControl
    Friend WithEvents view As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtRemarks As TextBox
    Friend WithEvents cmbItemType As ComboBox
    Friend WithEvents cmbVendorName As ComboBox
    Friend WithEvents dtp As DateTimePicker
    Friend WithEvents cmbterms As ComboBox
    Friend WithEvents txtPcs As TextBox
    Friend WithEvents txtCts As TextBox
    Friend WithEvents txtExRate As TextBox
    Friend WithEvents txtAddExpUSD As TextBox
    Friend WithEvents txtGrossUSD As TextBox
    Friend WithEvents txtNetUSD As TextBox
    Friend WithEvents txtNetINR As TextBox
    Friend WithEvents DtpDue As DateTimePicker
    Friend WithEvents Col_PurchaseID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Col_CompanyID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Col_BranchID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Col_UserID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Col_PurchaseDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Col_VendorID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Col_Terms As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Col_ItemType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Col_Pcs As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Col_Carats As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Col_GrossTotalUSD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Col_AddExpUSD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Col_ExchangeRate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Col_NetUSD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Col_NetINR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Col_Remarks As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Col_SerieStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents LayoutControl2 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControl3 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonStatusBar1 As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents btnSave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCancel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmbPurchaseLedger As ComboBox
    Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnClose As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnExport As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnRefresh As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents lblExpPercent As Label
    Friend WithEvents LayoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents btnAttachment As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtAttachment As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem20 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem21 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents riAttachementCheckEdit As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents ContextMenu1 As ContextMenuStrip
    Friend WithEvents EditMenu As ToolStripMenuItem
    Friend WithEvents DeleteMenu As ToolStripMenuItem
End Class
