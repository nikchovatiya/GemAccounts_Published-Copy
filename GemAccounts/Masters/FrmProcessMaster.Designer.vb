<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProcessMaster
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmProcessMaster))
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnSave = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCancel = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.cmbDefaultLotStatus = New System.Windows.Forms.ComboBox()
        Me.cmbDefaultItemType = New System.Windows.Forms.ComboBox()
        Me.dg = New DevExpress.XtraGrid.GridControl()
        Me.dgView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColProcessID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColProcessName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDefaultLotStatusID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDefaultItemTypeID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtProcessName = New DevExpress.XtraEditors.TextEdit()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProcessName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl
        '
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.RibbonControl.SearchEditItem, Me.btnSave, Me.btnCancel})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 3
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl.Size = New System.Drawing.Size(775, 158)
        Me.RibbonControl.StatusBar = Me.RibbonStatusBar
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
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 551)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(775, 24)
        Me.RibbonStatusBar.Visible = False
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.cmbDefaultLotStatus)
        Me.LayoutControl1.Controls.Add(Me.cmbDefaultItemType)
        Me.LayoutControl1.Controls.Add(Me.dg)
        Me.LayoutControl1.Controls.Add(Me.txtProcessName)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 158)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(775, 393)
        Me.LayoutControl1.TabIndex = 3
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'cmbDefaultLotStatus
        '
        Me.cmbDefaultLotStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbDefaultLotStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbDefaultLotStatus.FormattingEnabled = True
        Me.cmbDefaultLotStatus.Location = New System.Drawing.Point(315, 45)
        Me.cmbDefaultLotStatus.Name = "cmbDefaultLotStatus"
        Me.cmbDefaultLotStatus.Size = New System.Drawing.Size(161, 21)
        Me.cmbDefaultLotStatus.TabIndex = 10
        '
        'cmbDefaultItemType
        '
        Me.cmbDefaultItemType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbDefaultItemType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbDefaultItemType.FormattingEnabled = True
        Me.cmbDefaultItemType.Location = New System.Drawing.Point(570, 45)
        Me.cmbDefaultItemType.Name = "cmbDefaultItemType"
        Me.cmbDefaultItemType.Size = New System.Drawing.Size(181, 21)
        Me.cmbDefaultItemType.TabIndex = 9
        '
        'dg
        '
        Me.dg.Location = New System.Drawing.Point(24, 94)
        Me.dg.MainView = Me.dgView
        Me.dg.MenuManager = Me.RibbonControl
        Me.dg.Name = "dg"
        Me.dg.Size = New System.Drawing.Size(727, 275)
        Me.dg.TabIndex = 7
        Me.dg.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.dgView})
        '
        'dgView
        '
        Me.dgView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColProcessID, Me.ColProcessName, Me.ColDefaultLotStatusID, Me.ColDefaultItemTypeID, Me.GridColumn1, Me.GridColumn2})
        Me.dgView.GridControl = Me.dg
        Me.dgView.Name = "dgView"
        Me.dgView.OptionsBehavior.Editable = False
        Me.dgView.OptionsView.ShowGroupPanel = False
        '
        'ColProcessID
        '
        Me.ColProcessID.Caption = "Process ID"
        Me.ColProcessID.FieldName = "ProcessID"
        Me.ColProcessID.Name = "ColProcessID"
        Me.ColProcessID.Visible = True
        Me.ColProcessID.VisibleIndex = 0
        '
        'ColProcessName
        '
        Me.ColProcessName.Caption = "Process Name"
        Me.ColProcessName.FieldName = "ProcessName"
        Me.ColProcessName.Name = "ColProcessName"
        Me.ColProcessName.Visible = True
        Me.ColProcessName.VisibleIndex = 1
        '
        'ColDefaultLotStatusID
        '
        Me.ColDefaultLotStatusID.Caption = "Default Lot Status ID"
        Me.ColDefaultLotStatusID.FieldName = "DefaultLotStatus"
        Me.ColDefaultLotStatusID.Name = "ColDefaultLotStatusID"
        '
        'ColDefaultItemTypeID
        '
        Me.ColDefaultItemTypeID.Caption = "Default Item Type ID"
        Me.ColDefaultItemTypeID.FieldName = "DefaultItemType"
        Me.ColDefaultItemTypeID.Name = "ColDefaultItemTypeID"
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Default Lot Status"
        Me.GridColumn1.FieldName = "lstatus"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 2
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Default Item Type"
        Me.GridColumn2.FieldName = "itype"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 3
        '
        'txtProcessName
        '
        Me.txtProcessName.Location = New System.Drawing.Point(114, 45)
        Me.txtProcessName.MenuManager = Me.RibbonControl
        Me.txtProcessName.Name = "txtProcessName"
        Me.txtProcessName.Size = New System.Drawing.Size(107, 20)
        Me.txtProcessName.StyleController = Me.LayoutControl1
        Me.txtProcessName.TabIndex = 4
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup1, Me.LayoutControlGroup2})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(775, 393)
        Me.Root.TextVisible = False
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem6, Me.LayoutControlItem3})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(755, 70)
        Me.LayoutControlGroup1.Text = "Process Master"
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.txtProcessName
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(201, 25)
        Me.LayoutControlItem1.Text = "Process Name"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(87, 13)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.cmbDefaultItemType
        Me.LayoutControlItem6.Location = New System.Drawing.Point(456, 0)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(275, 25)
        Me.LayoutControlItem6.Text = "Default Item Type"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(87, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.cmbDefaultLotStatus
        Me.LayoutControlItem3.Location = New System.Drawing.Point(201, 0)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(255, 25)
        Me.LayoutControlItem3.Text = "Default Lot Status"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(87, 13)
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem4})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 70)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(755, 303)
        Me.LayoutControlGroup2.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.dg
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(731, 279)
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'FrmProcessMaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(775, 575)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl)
        Me.Name = "FrmProcessMaster"
        Me.Ribbon = Me.RibbonControl
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "Process Master"
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProcessName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents btnSave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCancel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents dg As DevExpress.XtraGrid.GridControl
    Friend WithEvents dgView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtProcessName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents ColProcessID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColProcessName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDefaultLotStatusID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDefaultItemTypeID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmbDefaultLotStatus As ComboBox
    Friend WithEvents cmbDefaultItemType As ComboBox
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
End Class
