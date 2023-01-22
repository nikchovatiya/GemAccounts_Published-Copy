<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVideoAndImageLink
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmVideoAndImageLink))
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.BtnBrowse = New DevExpress.XtraBars.BarButtonItem()
        Me.BtnSavenClose = New DevExpress.XtraBars.BarButtonItem()
        Me.BtnSave = New DevExpress.XtraBars.BarButtonItem()
        Me.BtnCancel = New DevExpress.XtraBars.BarButtonItem()
        Me.BtnClose = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar1 = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.dg = New DevExpress.XtraGrid.GridControl()
        Me.dgView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.OFD = New System.Windows.Forms.OpenFileDialog()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.RibbonControl1.SearchEditItem, Me.BtnBrowse, Me.BtnSavenClose, Me.BtnSave, Me.BtnCancel, Me.BtnClose})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 6
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.Size = New System.Drawing.Size(938, 143)
        Me.RibbonControl1.StatusBar = Me.RibbonStatusBar1
        '
        'BtnBrowse
        '
        Me.BtnBrowse.Caption = "Browse"
        Me.BtnBrowse.Id = 1
        Me.BtnBrowse.ImageOptions.SvgImage = CType(resources.GetObject("BtnBrowse.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.BtnBrowse.Name = "BtnBrowse"
        '
        'BtnSavenClose
        '
        Me.BtnSavenClose.Caption = "Save && Close"
        Me.BtnSavenClose.Id = 2
        Me.BtnSavenClose.ImageOptions.SvgImage = CType(resources.GetObject("BtnSavenClose.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.BtnSavenClose.Name = "BtnSavenClose"
        '
        'BtnSave
        '
        Me.BtnSave.Caption = "Save"
        Me.BtnSave.Id = 3
        Me.BtnSave.ImageOptions.SvgImage = CType(resources.GetObject("BtnSave.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.BtnSave.Name = "BtnSave"
        '
        'BtnCancel
        '
        Me.BtnCancel.Caption = "Cancel"
        Me.BtnCancel.Id = 4
        Me.BtnCancel.ImageOptions.SvgImage = CType(resources.GetObject("BtnCancel.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.BtnCancel.Name = "BtnCancel"
        '
        'BtnClose
        '
        Me.BtnClose.Caption = "Close"
        Me.BtnClose.Id = 5
        Me.BtnClose.ImageOptions.SvgImage = CType(resources.GetObject("BtnClose.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.BtnClose.Name = "BtnClose"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "Actions"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BtnBrowse)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BtnSavenClose)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BtnSave)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BtnCancel)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BtnClose)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        '
        'RibbonStatusBar1
        '
        Me.RibbonStatusBar1.Location = New System.Drawing.Point(0, 500)
        Me.RibbonStatusBar1.Name = "RibbonStatusBar1"
        Me.RibbonStatusBar1.Ribbon = Me.RibbonControl1
        Me.RibbonStatusBar1.Size = New System.Drawing.Size(938, 31)
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Text = "RibbonPage2"
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.dg)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 143)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(938, 357)
        Me.LayoutControl1.TabIndex = 2
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'dg
        '
        Me.dg.Location = New System.Drawing.Point(12, 12)
        Me.dg.MainView = Me.dgView
        Me.dg.MenuManager = Me.RibbonControl1
        Me.dg.Name = "dg"
        Me.dg.Size = New System.Drawing.Size(914, 333)
        Me.dg.TabIndex = 4
        Me.dg.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.dgView})
        '
        'dgView
        '
        Me.dgView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4})
        Me.dgView.GridControl = Me.dg
        Me.dgView.Name = "dgView"
        Me.dgView.OptionsBehavior.Editable = False
        Me.dgView.OptionsView.ColumnAutoWidth = False
        Me.dgView.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Error"
        Me.GridColumn1.FieldName = "Error"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 145
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Stock ID"
        Me.GridColumn2.FieldName = "StockID"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 114
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Video Link"
        Me.GridColumn3.FieldName = "VideoLink"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        Me.GridColumn3.Width = 307
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Image Link"
        Me.GridColumn4.FieldName = "ImageLink"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 3
        Me.GridColumn4.Width = 328
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1})
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(938, 357)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.dg
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(918, 337)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'OFD
        '
        Me.OFD.FileName = "OpenFileDialog1"
        '
        'FrmVideoAndImageLink
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(938, 531)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.RibbonStatusBar1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.Name = "FrmVideoAndImageLink"
        Me.Ribbon = Me.RibbonControl1
        Me.StatusBar = Me.RibbonStatusBar1
        Me.Text = "Video and Image Link Upload"
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonStatusBar1 As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents BtnBrowse As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BtnSavenClose As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BtnSave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BtnCancel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BtnClose As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents dg As DevExpress.XtraGrid.GridControl
    Friend WithEvents dgView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OFD As OpenFileDialog
End Class
