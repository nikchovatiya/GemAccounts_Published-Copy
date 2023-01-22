<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmSerie
    Inherits DevExpress.XtraEditors.XtraForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSerie))
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.LayoutControl2 = New DevExpress.XtraLayout.LayoutControl()
        Me.LayoutControl3 = New DevExpress.XtraLayout.LayoutControl()
        Me.txtSoldUSD = New System.Windows.Forms.TextBox()
        Me.txtSoldCts = New System.Windows.Forms.TextBox()
        Me.txtUSDPending = New System.Windows.Forms.TextBox()
        Me.txtCtsPending = New System.Windows.Forms.TextBox()
        Me.txtPcsPending = New System.Windows.Forms.TextBox()
        Me.txtTotalPurchaseUSD = New System.Windows.Forms.TextBox()
        Me.txtTotalCts = New System.Windows.Forms.TextBox()
        Me.txtTotalPcs = New System.Windows.Forms.TextBox()
        Me.txtSoldPcs = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.btnsave = New DevExpress.XtraEditors.SimpleButton()
        Me.cmbPurchaseID = New System.Windows.Forms.ComboBox()
        Me.txtTotalUSD = New System.Windows.Forms.TextBox()
        Me.txtUSDperCts = New System.Windows.Forms.TextBox()
        Me.txtCts = New System.Windows.Forms.TextBox()
        Me.txtSerieName = New System.Windows.Forms.TextBox()
        Me.txtPcs = New System.Windows.Forms.TextBox()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.sdd = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem18 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem19 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem20 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem21 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem22 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.dg = New DevExpress.XtraGrid.GridControl()
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Col_SerieID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Col_PurchaseID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Col_CompanyID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Col_BranchID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Col_UserID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Col_Pcs = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Col_Carats = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Col_USDPerCarat = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Col_TotalUSD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Col_Remarks = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Col_VendorID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Col_NetUSD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Col_VendorName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Col_SerieName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl2.SuspendLayout()
        CType(Me.LayoutControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl3.SuspendLayout()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sdd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenu1.SuspendLayout()
        CType(Me.view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.SplitContainerControl1)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(798, 448)
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
        Me.SplitContainerControl1.Size = New System.Drawing.Size(774, 424)
        Me.SplitContainerControl1.SplitterPosition = 320
        Me.SplitContainerControl1.TabIndex = 15
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'LayoutControl2
        '
        Me.LayoutControl2.Controls.Add(Me.LayoutControl3)
        Me.LayoutControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl2.Name = "LayoutControl2"
        Me.LayoutControl2.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(390, 146, 650, 400)
        Me.LayoutControl2.Root = Me.LayoutControlGroup4
        Me.LayoutControl2.Size = New System.Drawing.Size(320, 424)
        Me.LayoutControl2.TabIndex = 0
        Me.LayoutControl2.Text = "LayoutControl2"
        '
        'LayoutControl3
        '
        Me.LayoutControl3.Controls.Add(Me.txtSoldUSD)
        Me.LayoutControl3.Controls.Add(Me.txtSoldCts)
        Me.LayoutControl3.Controls.Add(Me.txtUSDPending)
        Me.LayoutControl3.Controls.Add(Me.txtCtsPending)
        Me.LayoutControl3.Controls.Add(Me.txtPcsPending)
        Me.LayoutControl3.Controls.Add(Me.txtTotalPurchaseUSD)
        Me.LayoutControl3.Controls.Add(Me.txtTotalCts)
        Me.LayoutControl3.Controls.Add(Me.txtTotalPcs)
        Me.LayoutControl3.Controls.Add(Me.txtSoldPcs)
        Me.LayoutControl3.Controls.Add(Me.Label2)
        Me.LayoutControl3.Controls.Add(Me.Label1)
        Me.LayoutControl3.Controls.Add(Me.txtRemarks)
        Me.LayoutControl3.Controls.Add(Me.btnCancel)
        Me.LayoutControl3.Controls.Add(Me.btnsave)
        Me.LayoutControl3.Controls.Add(Me.cmbPurchaseID)
        Me.LayoutControl3.Controls.Add(Me.txtTotalUSD)
        Me.LayoutControl3.Controls.Add(Me.txtUSDperCts)
        Me.LayoutControl3.Controls.Add(Me.txtCts)
        Me.LayoutControl3.Controls.Add(Me.txtSerieName)
        Me.LayoutControl3.Controls.Add(Me.txtPcs)
        Me.LayoutControl3.Location = New System.Drawing.Point(12, 12)
        Me.LayoutControl3.Name = "LayoutControl3"
        Me.LayoutControl3.Root = Me.Root
        Me.LayoutControl3.Size = New System.Drawing.Size(296, 400)
        Me.LayoutControl3.TabIndex = 0
        Me.LayoutControl3.Text = "LayoutControl3"
        '
        'txtSoldUSD
        '
        Me.txtSoldUSD.Location = New System.Drawing.Point(186, 133)
        Me.txtSoldUSD.Name = "txtSoldUSD"
        Me.txtSoldUSD.ReadOnly = True
        Me.txtSoldUSD.Size = New System.Drawing.Size(98, 20)
        Me.txtSoldUSD.TabIndex = 17
        Me.txtSoldUSD.TabStop = False
        Me.txtSoldUSD.Visible = False
        '
        'txtSoldCts
        '
        Me.txtSoldCts.Location = New System.Drawing.Point(97, 133)
        Me.txtSoldCts.Name = "txtSoldCts"
        Me.txtSoldCts.ReadOnly = True
        Me.txtSoldCts.Size = New System.Drawing.Size(85, 20)
        Me.txtSoldCts.TabIndex = 16
        Me.txtSoldCts.TabStop = False
        Me.txtSoldCts.Visible = False
        '
        'txtUSDPending
        '
        Me.txtUSDPending.Location = New System.Drawing.Point(109, 109)
        Me.txtUSDPending.Name = "txtUSDPending"
        Me.txtUSDPending.ReadOnly = True
        Me.txtUSDPending.Size = New System.Drawing.Size(175, 20)
        Me.txtUSDPending.TabIndex = 14
        Me.txtUSDPending.TabStop = False
        '
        'txtCtsPending
        '
        Me.txtCtsPending.Location = New System.Drawing.Point(247, 85)
        Me.txtCtsPending.Name = "txtCtsPending"
        Me.txtCtsPending.ReadOnly = True
        Me.txtCtsPending.Size = New System.Drawing.Size(37, 20)
        Me.txtCtsPending.TabIndex = 13
        Me.txtCtsPending.TabStop = False
        '
        'txtPcsPending
        '
        Me.txtPcsPending.Location = New System.Drawing.Point(109, 85)
        Me.txtPcsPending.Name = "txtPcsPending"
        Me.txtPcsPending.ReadOnly = True
        Me.txtPcsPending.Size = New System.Drawing.Size(37, 20)
        Me.txtPcsPending.TabIndex = 12
        Me.txtPcsPending.TabStop = False
        '
        'txtTotalPurchaseUSD
        '
        Me.txtTotalPurchaseUSD.Location = New System.Drawing.Point(109, 61)
        Me.txtTotalPurchaseUSD.Name = "txtTotalPurchaseUSD"
        Me.txtTotalPurchaseUSD.ReadOnly = True
        Me.txtTotalPurchaseUSD.Size = New System.Drawing.Size(175, 20)
        Me.txtTotalPurchaseUSD.TabIndex = 11
        Me.txtTotalPurchaseUSD.TabStop = False
        '
        'txtTotalCts
        '
        Me.txtTotalCts.Location = New System.Drawing.Point(247, 37)
        Me.txtTotalCts.Name = "txtTotalCts"
        Me.txtTotalCts.ReadOnly = True
        Me.txtTotalCts.Size = New System.Drawing.Size(37, 20)
        Me.txtTotalCts.TabIndex = 10
        Me.txtTotalCts.TabStop = False
        '
        'txtTotalPcs
        '
        Me.txtTotalPcs.Location = New System.Drawing.Point(109, 37)
        Me.txtTotalPcs.Name = "txtTotalPcs"
        Me.txtTotalPcs.ReadOnly = True
        Me.txtTotalPcs.Size = New System.Drawing.Size(37, 20)
        Me.txtTotalPcs.TabIndex = 9
        Me.txtTotalPcs.TabStop = False
        '
        'txtSoldPcs
        '
        Me.txtSoldPcs.Location = New System.Drawing.Point(12, 133)
        Me.txtSoldPcs.Name = "txtSoldPcs"
        Me.txtSoldPcs.ReadOnly = True
        Me.txtSoldPcs.Size = New System.Drawing.Size(81, 20)
        Me.txtSoldPcs.TabIndex = 15
        Me.txtSoldPcs.TabStop = False
        Me.txtSoldPcs.Visible = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(12, 309)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(272, 37)
        Me.Label2.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(100, 350)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(184, 38)
        Me.Label1.TabIndex = 0
        '
        'txtRemarks
        '
        Me.txtRemarks.Location = New System.Drawing.Point(109, 277)
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(175, 28)
        Me.txtRemarks.TabIndex = 6
        '
        'btnCancel
        '
        Me.btnCancel.ImageOptions.Image = CType(resources.GetObject("btnCancel.ImageOptions.Image"), System.Drawing.Image)
        Me.btnCancel.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnCancel.Location = New System.Drawing.Point(56, 350)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(40, 38)
        Me.btnCancel.StyleController = Me.LayoutControl3
        Me.btnCancel.TabIndex = 8
        '
        'btnsave
        '
        Me.btnsave.ImageOptions.Image = CType(resources.GetObject("btnsave.ImageOptions.Image"), System.Drawing.Image)
        Me.btnsave.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnsave.Location = New System.Drawing.Point(12, 350)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(40, 38)
        Me.btnsave.StyleController = Me.LayoutControl3
        Me.btnsave.TabIndex = 7
        '
        'cmbPurchaseID
        '
        Me.cmbPurchaseID.FormattingEnabled = True
        Me.cmbPurchaseID.Location = New System.Drawing.Point(109, 12)
        Me.cmbPurchaseID.Name = "cmbPurchaseID"
        Me.cmbPurchaseID.Size = New System.Drawing.Size(175, 21)
        Me.cmbPurchaseID.TabIndex = 1
        '
        'txtTotalUSD
        '
        Me.txtTotalUSD.Location = New System.Drawing.Point(109, 253)
        Me.txtTotalUSD.Name = "txtTotalUSD"
        Me.txtTotalUSD.Size = New System.Drawing.Size(175, 20)
        Me.txtTotalUSD.TabIndex = 5
        Me.txtTotalUSD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtUSDperCts
        '
        Me.txtUSDperCts.Location = New System.Drawing.Point(109, 229)
        Me.txtUSDperCts.Name = "txtUSDperCts"
        Me.txtUSDperCts.Size = New System.Drawing.Size(175, 20)
        Me.txtUSDperCts.TabIndex = 4
        Me.txtUSDperCts.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCts
        '
        Me.txtCts.Location = New System.Drawing.Point(109, 205)
        Me.txtCts.Name = "txtCts"
        Me.txtCts.Size = New System.Drawing.Size(175, 20)
        Me.txtCts.TabIndex = 3
        Me.txtCts.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSerieName
        '
        Me.txtSerieName.Location = New System.Drawing.Point(109, 157)
        Me.txtSerieName.Name = "txtSerieName"
        Me.txtSerieName.Size = New System.Drawing.Size(175, 20)
        Me.txtSerieName.TabIndex = 2
        Me.txtSerieName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPcs
        '
        Me.txtPcs.Location = New System.Drawing.Point(109, 181)
        Me.txtPcs.Name = "txtPcs"
        Me.txtPcs.Size = New System.Drawing.Size(175, 20)
        Me.txtPcs.TabIndex = 3
        Me.txtPcs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.sdd, Me.LayoutControlItem7, Me.LayoutControlItem8, Me.LayoutControlItem9, Me.LayoutControlItem10, Me.LayoutControlItem11, Me.LayoutControlItem15, Me.LayoutControlItem16, Me.LayoutControlItem17, Me.LayoutControlItem18, Me.LayoutControlItem19, Me.LayoutControlItem3, Me.LayoutControlItem20, Me.LayoutControlItem2, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem13, Me.LayoutControlItem21, Me.LayoutControlItem22})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(296, 400)
        Me.Root.TextVisible = False
        '
        'sdd
        '
        Me.sdd.Control = Me.cmbPurchaseID
        Me.sdd.Location = New System.Drawing.Point(0, 0)
        Me.sdd.Name = "sdd"
        Me.sdd.Size = New System.Drawing.Size(276, 25)
        Me.sdd.Text = "Purchase Vendor"
        Me.sdd.TextSize = New System.Drawing.Size(94, 13)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.txtSerieName
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 145)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(276, 24)
        Me.LayoutControlItem7.Text = "Serie Name"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(94, 13)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.txtPcs
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 169)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(276, 24)
        Me.LayoutControlItem8.Text = "Pcs"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(94, 13)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.txtCts
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 193)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(276, 24)
        Me.LayoutControlItem9.Text = "Carats"
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(94, 13)
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.txtUSDperCts
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 217)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(276, 24)
        Me.LayoutControlItem10.Text = "$ Per Carat"
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(94, 13)
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.txtTotalUSD
        Me.LayoutControlItem11.Location = New System.Drawing.Point(0, 241)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(276, 24)
        Me.LayoutControlItem11.Text = "Total USD"
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(94, 13)
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.Control = Me.txtRemarks
        Me.LayoutControlItem15.Location = New System.Drawing.Point(0, 265)
        Me.LayoutControlItem15.Name = "LayoutControlItem15"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(276, 32)
        Me.LayoutControlItem15.Text = "Remarks"
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(94, 13)
        '
        'LayoutControlItem16
        '
        Me.LayoutControlItem16.Control = Me.btnsave
        Me.LayoutControlItem16.Location = New System.Drawing.Point(0, 338)
        Me.LayoutControlItem16.MaxSize = New System.Drawing.Size(44, 42)
        Me.LayoutControlItem16.MinSize = New System.Drawing.Size(44, 42)
        Me.LayoutControlItem16.Name = "LayoutControlItem16"
        Me.LayoutControlItem16.Size = New System.Drawing.Size(44, 42)
        Me.LayoutControlItem16.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem16.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem16.TextVisible = False
        '
        'LayoutControlItem17
        '
        Me.LayoutControlItem17.Control = Me.btnCancel
        Me.LayoutControlItem17.Location = New System.Drawing.Point(44, 338)
        Me.LayoutControlItem17.MaxSize = New System.Drawing.Size(44, 42)
        Me.LayoutControlItem17.MinSize = New System.Drawing.Size(44, 42)
        Me.LayoutControlItem17.Name = "LayoutControlItem17"
        Me.LayoutControlItem17.Size = New System.Drawing.Size(44, 42)
        Me.LayoutControlItem17.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem17.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem17.TextVisible = False
        '
        'LayoutControlItem18
        '
        Me.LayoutControlItem18.Control = Me.Label1
        Me.LayoutControlItem18.Location = New System.Drawing.Point(88, 338)
        Me.LayoutControlItem18.Name = "LayoutControlItem18"
        Me.LayoutControlItem18.Size = New System.Drawing.Size(188, 42)
        Me.LayoutControlItem18.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem18.TextVisible = False
        '
        'LayoutControlItem19
        '
        Me.LayoutControlItem19.Control = Me.Label2
        Me.LayoutControlItem19.Location = New System.Drawing.Point(0, 297)
        Me.LayoutControlItem19.Name = "LayoutControlItem19"
        Me.LayoutControlItem19.Size = New System.Drawing.Size(276, 41)
        Me.LayoutControlItem19.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem19.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.txtSoldPcs
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 121)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(85, 24)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem20
        '
        Me.LayoutControlItem20.AppearanceItemCaption.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LayoutControlItem20.AppearanceItemCaption.Options.UseForeColor = True
        Me.LayoutControlItem20.Control = Me.txtTotalPcs
        Me.LayoutControlItem20.Location = New System.Drawing.Point(0, 25)
        Me.LayoutControlItem20.Name = "LayoutControlItem20"
        Me.LayoutControlItem20.Size = New System.Drawing.Size(138, 24)
        Me.LayoutControlItem20.Text = "Total Pcs"
        Me.LayoutControlItem20.TextSize = New System.Drawing.Size(94, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.AppearanceItemCaption.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LayoutControlItem2.AppearanceItemCaption.Options.UseForeColor = True
        Me.LayoutControlItem2.Control = Me.txtTotalCts
        Me.LayoutControlItem2.Location = New System.Drawing.Point(138, 25)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(138, 24)
        Me.LayoutControlItem2.Text = "Total Carats"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(94, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.AppearanceItemCaption.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LayoutControlItem4.AppearanceItemCaption.Options.UseForeColor = True
        Me.LayoutControlItem4.Control = Me.txtTotalPurchaseUSD
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 49)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(276, 24)
        Me.LayoutControlItem4.Text = "Total Purchase USD"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(94, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.AppearanceItemCaption.ForeColor = System.Drawing.Color.Red
        Me.LayoutControlItem5.AppearanceItemCaption.Options.UseForeColor = True
        Me.LayoutControlItem5.Control = Me.txtPcsPending
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 73)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.OptionsPrint.AppearanceItem.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlItem5.OptionsPrint.AppearanceItem.ForeColor = System.Drawing.Color.DarkRed
        Me.LayoutControlItem5.OptionsPrint.AppearanceItem.Options.UseFont = True
        Me.LayoutControlItem5.OptionsPrint.AppearanceItem.Options.UseForeColor = True
        Me.LayoutControlItem5.Size = New System.Drawing.Size(138, 24)
        Me.LayoutControlItem5.Text = "Pcs Pending"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(94, 13)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.AppearanceItemCaption.ForeColor = System.Drawing.Color.Red
        Me.LayoutControlItem6.AppearanceItemCaption.Options.UseForeColor = True
        Me.LayoutControlItem6.Control = Me.txtCtsPending
        Me.LayoutControlItem6.Location = New System.Drawing.Point(138, 73)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.OptionsPrint.AppearanceItem.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlItem6.OptionsPrint.AppearanceItem.ForeColor = System.Drawing.Color.DarkRed
        Me.LayoutControlItem6.OptionsPrint.AppearanceItem.Options.UseFont = True
        Me.LayoutControlItem6.OptionsPrint.AppearanceItem.Options.UseForeColor = True
        Me.LayoutControlItem6.Size = New System.Drawing.Size(138, 24)
        Me.LayoutControlItem6.Text = "Carats Pending"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(94, 13)
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.AppearanceItemCaption.ForeColor = System.Drawing.Color.Red
        Me.LayoutControlItem13.AppearanceItemCaption.Options.UseForeColor = True
        Me.LayoutControlItem13.Control = Me.txtUSDPending
        Me.LayoutControlItem13.Location = New System.Drawing.Point(0, 97)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.OptionsPrint.AppearanceItem.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlItem13.OptionsPrint.AppearanceItem.ForeColor = System.Drawing.Color.DarkRed
        Me.LayoutControlItem13.OptionsPrint.AppearanceItem.Options.UseFont = True
        Me.LayoutControlItem13.OptionsPrint.AppearanceItem.Options.UseForeColor = True
        Me.LayoutControlItem13.Size = New System.Drawing.Size(276, 24)
        Me.LayoutControlItem13.Text = "USD Pending"
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(94, 13)
        '
        'LayoutControlItem21
        '
        Me.LayoutControlItem21.Control = Me.txtSoldCts
        Me.LayoutControlItem21.Location = New System.Drawing.Point(85, 121)
        Me.LayoutControlItem21.Name = "LayoutControlItem21"
        Me.LayoutControlItem21.Size = New System.Drawing.Size(89, 24)
        Me.LayoutControlItem21.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem21.TextVisible = False
        '
        'LayoutControlItem22
        '
        Me.LayoutControlItem22.Control = Me.txtSoldUSD
        Me.LayoutControlItem22.Location = New System.Drawing.Point(174, 121)
        Me.LayoutControlItem22.Name = "LayoutControlItem22"
        Me.LayoutControlItem22.Size = New System.Drawing.Size(102, 24)
        Me.LayoutControlItem22.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem22.TextVisible = False
        '
        'LayoutControlGroup4
        '
        Me.LayoutControlGroup4.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup4.GroupBordersVisible = False
        Me.LayoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1})
        Me.LayoutControlGroup4.Name = "Root"
        Me.LayoutControlGroup4.Size = New System.Drawing.Size(320, 424)
        Me.LayoutControlGroup4.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.LayoutControl3
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(300, 404)
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
        Me.dg.Size = New System.Drawing.Size(449, 424)
        Me.dg.TabIndex = 0
        Me.dg.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.view})
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
        'view
        '
        Me.view.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.view.Appearance.FocusedRow.Options.UseBackColor = True
        Me.view.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.view.Appearance.SelectedRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.view.Appearance.SelectedRow.Options.UseBackColor = True
        Me.view.Appearance.SelectedRow.Options.UseFont = True
        Me.view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Col_SerieID, Me.Col_PurchaseID, Me.Col_CompanyID, Me.Col_BranchID, Me.Col_UserID, Me.Col_Pcs, Me.Col_Carats, Me.Col_USDPerCarat, Me.Col_TotalUSD, Me.Col_Remarks, Me.Col_VendorID, Me.Col_NetUSD, Me.Col_VendorName, Me.Col_SerieName})
        Me.view.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.view.GridControl = Me.dg
        Me.view.Name = "view"
        Me.view.OptionsBehavior.Editable = False
        Me.view.OptionsPrint.PrintSelectedRowsOnly = True
        Me.view.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.view.OptionsView.ShowFooter = True
        '
        'Col_SerieID
        '
        Me.Col_SerieID.Caption = "Serie ID"
        Me.Col_SerieID.FieldName = "SerieID"
        Me.Col_SerieID.Name = "Col_SerieID"
        '
        'Col_PurchaseID
        '
        Me.Col_PurchaseID.Caption = "Purchase ID"
        Me.Col_PurchaseID.FieldName = "PurchaseID"
        Me.Col_PurchaseID.Name = "Col_PurchaseID"
        '
        'Col_CompanyID
        '
        Me.Col_CompanyID.Caption = "Company ID"
        Me.Col_CompanyID.FieldName = "CompanyID"
        Me.Col_CompanyID.Name = "Col_CompanyID"
        '
        'Col_BranchID
        '
        Me.Col_BranchID.Caption = "Branch ID"
        Me.Col_BranchID.FieldName = "BranchID"
        Me.Col_BranchID.Name = "Col_BranchID"
        '
        'Col_UserID
        '
        Me.Col_UserID.Caption = "User ID"
        Me.Col_UserID.FieldName = "UserID"
        Me.Col_UserID.Name = "Col_UserID"
        '
        'Col_Pcs
        '
        Me.Col_Pcs.Caption = "Pcs"
        Me.Col_Pcs.FieldName = "Pcs"
        Me.Col_Pcs.Name = "Col_Pcs"
        Me.Col_Pcs.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.Col_Pcs.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.Col_Pcs.Visible = True
        Me.Col_Pcs.VisibleIndex = 2
        '
        'Col_Carats
        '
        Me.Col_Carats.Caption = "Carats"
        Me.Col_Carats.DisplayFormat.FormatString = "0.00"
        Me.Col_Carats.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.Col_Carats.FieldName = "Carats"
        Me.Col_Carats.Name = "Col_Carats"
        Me.Col_Carats.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.Col_Carats.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Carats", "{0:0.00}")})
        Me.Col_Carats.Visible = True
        Me.Col_Carats.VisibleIndex = 3
        '
        'Col_USDPerCarat
        '
        Me.Col_USDPerCarat.Caption = "USD Per Carat"
        Me.Col_USDPerCarat.DisplayFormat.FormatString = "0.00"
        Me.Col_USDPerCarat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.Col_USDPerCarat.FieldName = "USDPerCarat"
        Me.Col_USDPerCarat.Name = "Col_USDPerCarat"
        Me.Col_USDPerCarat.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.Col_USDPerCarat.Visible = True
        Me.Col_USDPerCarat.VisibleIndex = 4
        '
        'Col_TotalUSD
        '
        Me.Col_TotalUSD.Caption = "Total USD"
        Me.Col_TotalUSD.DisplayFormat.FormatString = "0.00"
        Me.Col_TotalUSD.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.Col_TotalUSD.FieldName = "TotalUSD"
        Me.Col_TotalUSD.Name = "Col_TotalUSD"
        Me.Col_TotalUSD.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.Col_TotalUSD.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalUSD", "{0:0.00}")})
        Me.Col_TotalUSD.Visible = True
        Me.Col_TotalUSD.VisibleIndex = 5
        '
        'Col_Remarks
        '
        Me.Col_Remarks.Caption = "Remarks"
        Me.Col_Remarks.FieldName = "Remarks"
        Me.Col_Remarks.Name = "Col_Remarks"
        '
        'Col_VendorID
        '
        Me.Col_VendorID.Caption = "Vendor ID"
        Me.Col_VendorID.FieldName = "VendorID"
        Me.Col_VendorID.Name = "Col_VendorID"
        '
        'Col_NetUSD
        '
        Me.Col_NetUSD.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Col_NetUSD.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.Col_NetUSD.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Col_NetUSD.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Col_NetUSD.AppearanceCell.Options.UseBackColor = True
        Me.Col_NetUSD.AppearanceCell.Options.UseFont = True
        Me.Col_NetUSD.AppearanceCell.Options.UseForeColor = True
        Me.Col_NetUSD.Caption = "Purchase USD"
        Me.Col_NetUSD.DisplayFormat.FormatString = "0.00"
        Me.Col_NetUSD.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.Col_NetUSD.FieldName = "NetUSD"
        Me.Col_NetUSD.Name = "Col_NetUSD"
        Me.Col_NetUSD.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[True]
        Me.Col_NetUSD.Visible = True
        Me.Col_NetUSD.VisibleIndex = 6
        '
        'Col_VendorName
        '
        Me.Col_VendorName.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Col_VendorName.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.Col_VendorName.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Col_VendorName.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Col_VendorName.AppearanceCell.Options.UseBackColor = True
        Me.Col_VendorName.AppearanceCell.Options.UseFont = True
        Me.Col_VendorName.AppearanceCell.Options.UseForeColor = True
        Me.Col_VendorName.Caption = "Vendor Name"
        Me.Col_VendorName.FieldName = "VendorName"
        Me.Col_VendorName.Name = "Col_VendorName"
        Me.Col_VendorName.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[True]
        Me.Col_VendorName.Visible = True
        Me.Col_VendorName.VisibleIndex = 1
        '
        'Col_SerieName
        '
        Me.Col_SerieName.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Col_SerieName.AppearanceCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Col_SerieName.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Col_SerieName.AppearanceCell.Options.UseBackColor = True
        Me.Col_SerieName.AppearanceCell.Options.UseFont = True
        Me.Col_SerieName.Caption = "Serie Name"
        Me.Col_SerieName.FieldName = "SerieName"
        Me.Col_SerieName.Name = "Col_SerieName"
        Me.Col_SerieName.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.Col_SerieName.Visible = True
        Me.Col_SerieName.VisibleIndex = 0
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem12})
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(798, 448)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.SplitContainerControl1
        Me.LayoutControlItem12.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(778, 428)
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem12.TextVisible = False
        '
        'FrmSerie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(798, 448)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "FrmSerie"
        Me.Text = "Serie"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl2.ResumeLayout(False)
        CType(Me.LayoutControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl3.ResumeLayout(False)
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sdd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenu1.ResumeLayout(False)
        CType(Me.view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents txtRemarks As TextBox
    Friend WithEvents cmbPurchaseID As ComboBox
    Friend WithEvents txtSerieName As TextBox
    Friend WithEvents txtPcs As TextBox
    Friend WithEvents txtUSDperCts As TextBox
    Friend WithEvents txtCts As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTotalUSD As TextBox
    Friend WithEvents txtSoldPcs As TextBox
    Friend WithEvents txtSoldUSD As TextBox
    Friend WithEvents txtSoldCts As TextBox
    Friend WithEvents txtUSDPending As TextBox
    Friend WithEvents txtCtsPending As TextBox
    Friend WithEvents txtPcsPending As TextBox
    Friend WithEvents txtTotalPurchaseUSD As TextBox
    Friend WithEvents txtTotalCts As TextBox
    Friend WithEvents txtTotalPcs As TextBox
    Private WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Private WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Private WithEvents dg As DevExpress.XtraGrid.GridControl
    Private WithEvents view As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Private WithEvents btnsave As DevExpress.XtraEditors.SimpleButton
    Private WithEvents Col_PurchaseID As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents Col_CompanyID As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents Col_BranchID As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents Col_UserID As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents Col_Pcs As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents Col_Carats As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents Col_USDPerCarat As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents Col_TotalUSD As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents Col_Remarks As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Private WithEvents LayoutControl2 As DevExpress.XtraLayout.LayoutControl
    Private WithEvents LayoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup
    Private WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Private WithEvents LayoutControl3 As DevExpress.XtraLayout.LayoutControl
    Private WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Private WithEvents sdd As DevExpress.XtraLayout.LayoutControlItem
    Private WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Private WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Private WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Private WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Private WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Private WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Private WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
    Private WithEvents LayoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
    Private WithEvents LayoutControlItem18 As DevExpress.XtraLayout.LayoutControlItem
    Private WithEvents LayoutControlItem19 As DevExpress.XtraLayout.LayoutControlItem
    Private WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Private WithEvents Col_SerieID As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents Col_VendorID As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents Col_NetUSD As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents Col_VendorName As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents Col_SerieName As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Private WithEvents LayoutControlItem20 As DevExpress.XtraLayout.LayoutControlItem
    Private WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Private WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Private WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Private WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Private WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Private WithEvents LayoutControlItem21 As DevExpress.XtraLayout.LayoutControlItem
    Private WithEvents LayoutControlItem22 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ContextMenu1 As ContextMenuStrip
    Friend WithEvents EditMenu As ToolStripMenuItem
    Friend WithEvents DeleteMenu As ToolStripMenuItem
End Class
