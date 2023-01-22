<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAskingUpdateWithPercentage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAskingUpdateWithPercentage))
        Me.OFD = New System.Windows.Forms.OpenFileDialog()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.dg = New DevExpress.XtraGrid.GridControl()
        Me.dgview = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn49 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnBrowse = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSaveClose = New DevExpress.XtraBars.BarButtonItem()
        Me.BtnSave = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCancel = New DevExpress.XtraBars.BarButtonItem()
        Me.btnClose = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar1 = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.ExcelDataSource1 = New DevExpress.DataAccess.Excel.ExcelDataSource()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgview, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OFD
        '
        Me.OFD.FileName = "OpenFileDialog1"
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.dg)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 143)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(908, 296)
        Me.LayoutControl1.TabIndex = 3
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'dg
        '
        Me.dg.Location = New System.Drawing.Point(12, 12)
        Me.dg.MainView = Me.dgview
        Me.dg.MenuManager = Me.RibbonControl1
        Me.dg.Name = "dg"
        Me.dg.Size = New System.Drawing.Size(884, 272)
        Me.dg.TabIndex = 4
        Me.dg.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.dgview})
        '
        'dgview
        '
        Me.dgview.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn49, Me.GridColumn1, Me.GridColumn2})
        Me.dgview.GridControl = Me.dg
        Me.dgview.Name = "dgview"
        Me.dgview.OptionsBehavior.Editable = False
        Me.dgview.OptionsView.ColumnAutoWidth = False
        Me.dgview.OptionsView.ShowFooter = True
        Me.dgview.OptionsView.ShowGroupPanel = False
        '
        'GridColumn49
        '
        Me.GridColumn49.Caption = "Error"
        Me.GridColumn49.FieldName = "Error"
        Me.GridColumn49.Name = "GridColumn49"
        Me.GridColumn49.Visible = True
        Me.GridColumn49.VisibleIndex = 0
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Stock ID"
        Me.GridColumn1.FieldName = "StockID"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "StockID", "{0}")})
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 1
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Asking %"
        Me.GridColumn2.FieldName = "AskingPercent"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 2
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.RibbonControl1.SearchEditItem, Me.btnBrowse, Me.btnSaveClose, Me.BtnSave, Me.btnCancel, Me.btnClose})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 6
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.Size = New System.Drawing.Size(908, 143)
        Me.RibbonControl1.StatusBar = Me.RibbonStatusBar1
        '
        'btnBrowse
        '
        Me.btnBrowse.Caption = "Browse"
        Me.btnBrowse.Id = 1
        Me.btnBrowse.ImageOptions.SvgImage = CType(resources.GetObject("btnBrowse.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btnBrowse.Name = "btnBrowse"
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
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "Actions"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnBrowse)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnSaveClose)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BtnSave)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnCancel)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnClose)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        '
        'RibbonStatusBar1
        '
        Me.RibbonStatusBar1.Location = New System.Drawing.Point(0, 439)
        Me.RibbonStatusBar1.Name = "RibbonStatusBar1"
        Me.RibbonStatusBar1.Ribbon = Me.RibbonControl1
        Me.RibbonStatusBar1.Size = New System.Drawing.Size(908, 31)
        Me.RibbonStatusBar1.Visible = False
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(908, 296)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.dg
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(888, 276)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Text = "RibbonPage2"
        '
        'ExcelDataSource1
        '
        Me.ExcelDataSource1.Name = "ExcelDataSource1"
        '
        'FrmAskingUpdateWithPercentage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(908, 470)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.RibbonStatusBar1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.Name = "FrmAskingUpdateWithPercentage"
        Me.Ribbon = Me.RibbonControl1
        Me.StatusBar = Me.RibbonStatusBar1
        Me.Text = "Asking Update with Percentage"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgview, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OFD As OpenFileDialog
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonStatusBar1 As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents btnBrowse As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSaveClose As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BtnSave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCancel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnClose As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents dg As DevExpress.XtraGrid.GridControl
    Friend WithEvents dgview As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ExcelDataSource1 As DevExpress.DataAccess.Excel.ExcelDataSource
    Friend WithEvents GridColumn49 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
End Class
