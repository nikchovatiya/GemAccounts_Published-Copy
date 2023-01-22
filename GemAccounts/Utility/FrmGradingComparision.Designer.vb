<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGradingComparision
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
        Me.components = New System.ComponentModel.Container()
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar1 = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.btnLoad = New DevExpress.XtraEditors.SimpleButton()
        Me.txtStockID = New DevExpress.XtraEditors.TextEdit()
        Me.vGrid = New DevExpress.XtraVerticalGrid.VGridControl()
        Me.rowGradingID = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowCompanyID = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowBranchID = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowUserID = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowGradingDate = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowGraderID = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowLabID = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowBarcode = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowQty = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowCarats = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowShapeID = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowColorID = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowClarityID = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowFlourID = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowCutID = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowPolishID = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowSymID = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowTablePercent = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowTotalDepth = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowLength = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowWidth = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowDepth = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowRatio = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowCrHeight = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowCrAngle = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowPvDepth = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowPvAngle = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowBlack = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowWhite = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowComment = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.SvgImageCollection1 = New DevExpress.Utils.SvgImageCollection(Me.components)
        Me.cmblab = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.txtStockID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SvgImageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmblab.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.RibbonControl1.SearchEditItem})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 1
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.Size = New System.Drawing.Size(953, 143)
        Me.RibbonControl1.StatusBar = Me.RibbonStatusBar1
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "Actions"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        '
        'RibbonStatusBar1
        '
        Me.RibbonStatusBar1.Location = New System.Drawing.Point(0, 510)
        Me.RibbonStatusBar1.Name = "RibbonStatusBar1"
        Me.RibbonStatusBar1.Ribbon = Me.RibbonControl1
        Me.RibbonStatusBar1.Size = New System.Drawing.Size(953, 31)
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Text = "RibbonPage2"
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.cmblab)
        Me.LayoutControl1.Controls.Add(Me.btnLoad)
        Me.LayoutControl1.Controls.Add(Me.txtStockID)
        Me.LayoutControl1.Controls.Add(Me.vGrid)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 143)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(953, 367)
        Me.LayoutControl1.TabIndex = 2
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(385, 12)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(69, 22)
        Me.btnLoad.StyleController = Me.LayoutControl1
        Me.btnLoad.TabIndex = 4
        Me.btnLoad.Text = "Load"
        '
        'txtStockID
        '
        Me.txtStockID.Location = New System.Drawing.Point(55, 12)
        Me.txtStockID.MenuManager = Me.RibbonControl1
        Me.txtStockID.Name = "txtStockID"
        Me.txtStockID.Size = New System.Drawing.Size(150, 20)
        Me.txtStockID.StyleController = Me.LayoutControl1
        Me.txtStockID.TabIndex = 3
        '
        'vGrid
        '
        Me.vGrid.Cursor = System.Windows.Forms.Cursors.Default
        Me.vGrid.Location = New System.Drawing.Point(12, 49)
        Me.vGrid.MenuManager = Me.RibbonControl1
        Me.vGrid.Name = "vGrid"
        Me.vGrid.OptionsView.AllowHtmlText = True
        Me.vGrid.Rows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.rowGradingID, Me.rowCompanyID, Me.rowBranchID, Me.rowUserID, Me.rowGradingDate, Me.rowGraderID, Me.rowLabID, Me.rowBarcode, Me.rowQty, Me.rowCarats, Me.rowShapeID, Me.rowColorID, Me.rowClarityID, Me.rowFlourID, Me.rowCutID, Me.rowPolishID, Me.rowSymID, Me.rowTablePercent, Me.rowTotalDepth, Me.rowLength, Me.rowWidth, Me.rowDepth, Me.rowRatio, Me.rowCrHeight, Me.rowCrAngle, Me.rowPvDepth, Me.rowPvAngle, Me.rowBlack, Me.rowWhite, Me.rowComment})
        Me.vGrid.Size = New System.Drawing.Size(929, 306)
        Me.vGrid.TabIndex = 0
        '
        'rowGradingID
        '
        Me.rowGradingID.Name = "rowGradingID"
        Me.rowGradingID.Properties.Caption = "Grading ID"
        Me.rowGradingID.Properties.FieldName = "GradingID"
        '
        'rowCompanyID
        '
        Me.rowCompanyID.Name = "rowCompanyID"
        Me.rowCompanyID.Properties.Caption = "Company ID"
        Me.rowCompanyID.Properties.FieldName = "CompanyID"
        '
        'rowBranchID
        '
        Me.rowBranchID.Name = "rowBranchID"
        Me.rowBranchID.Properties.Caption = "Branch ID"
        Me.rowBranchID.Properties.FieldName = "BranchID"
        '
        'rowUserID
        '
        Me.rowUserID.Name = "rowUserID"
        Me.rowUserID.Properties.Caption = "User ID"
        Me.rowUserID.Properties.FieldName = "UserID"
        '
        'rowGradingDate
        '
        Me.rowGradingDate.Name = "rowGradingDate"
        Me.rowGradingDate.Properties.Caption = "Grading Date"
        Me.rowGradingDate.Properties.FieldName = "GradingDate"
        '
        'rowGraderID
        '
        Me.rowGraderID.Name = "rowGraderID"
        Me.rowGraderID.Properties.Caption = "Grader ID"
        Me.rowGraderID.Properties.FieldName = "GraderID"
        '
        'rowLabID
        '
        Me.rowLabID.Height = 16
        Me.rowLabID.Name = "rowLabID"
        Me.rowLabID.Properties.Caption = "Lab ID"
        Me.rowLabID.Properties.FieldName = "LabID"
        '
        'rowBarcode
        '
        Me.rowBarcode.Name = "rowBarcode"
        Me.rowBarcode.Properties.Caption = "Barcode"
        Me.rowBarcode.Properties.FieldName = "Barcode"
        '
        'rowQty
        '
        Me.rowQty.Name = "rowQty"
        Me.rowQty.Properties.Caption = "Qty"
        Me.rowQty.Properties.FieldName = "Qty"
        '
        'rowCarats
        '
        Me.rowCarats.Name = "rowCarats"
        Me.rowCarats.Properties.Caption = "Carats"
        Me.rowCarats.Properties.FieldName = "Carats"
        '
        'rowShapeID
        '
        Me.rowShapeID.Name = "rowShapeID"
        Me.rowShapeID.Properties.Caption = "Shape ID"
        Me.rowShapeID.Properties.FieldName = "ShapeID"
        '
        'rowColorID
        '
        Me.rowColorID.Name = "rowColorID"
        Me.rowColorID.Properties.Caption = "Color ID"
        Me.rowColorID.Properties.FieldName = "ColorID"
        '
        'rowClarityID
        '
        Me.rowClarityID.Name = "rowClarityID"
        Me.rowClarityID.Properties.Caption = "Clarity ID"
        Me.rowClarityID.Properties.FieldName = "ClarityID"
        '
        'rowFlourID
        '
        Me.rowFlourID.Name = "rowFlourID"
        Me.rowFlourID.Properties.Caption = "Flour ID"
        Me.rowFlourID.Properties.FieldName = "FlourID"
        '
        'rowCutID
        '
        Me.rowCutID.Name = "rowCutID"
        Me.rowCutID.Properties.Caption = "Cut ID"
        Me.rowCutID.Properties.FieldName = "CutID"
        '
        'rowPolishID
        '
        Me.rowPolishID.Name = "rowPolishID"
        Me.rowPolishID.Properties.Caption = "Polish ID"
        Me.rowPolishID.Properties.FieldName = "PolishID"
        '
        'rowSymID
        '
        Me.rowSymID.Name = "rowSymID"
        Me.rowSymID.Properties.Caption = "Sym ID"
        Me.rowSymID.Properties.FieldName = "SymID"
        '
        'rowTablePercent
        '
        Me.rowTablePercent.Name = "rowTablePercent"
        Me.rowTablePercent.Properties.Caption = "Table Percent"
        Me.rowTablePercent.Properties.FieldName = "TablePercent"
        '
        'rowTotalDepth
        '
        Me.rowTotalDepth.Name = "rowTotalDepth"
        Me.rowTotalDepth.Properties.Caption = "Total Depth"
        Me.rowTotalDepth.Properties.FieldName = "TotalDepth"
        '
        'rowLength
        '
        Me.rowLength.Name = "rowLength"
        Me.rowLength.Properties.Caption = "Length"
        Me.rowLength.Properties.FieldName = "Length"
        '
        'rowWidth
        '
        Me.rowWidth.Name = "rowWidth"
        Me.rowWidth.Properties.Caption = "Width"
        Me.rowWidth.Properties.FieldName = "Width"
        '
        'rowDepth
        '
        Me.rowDepth.Name = "rowDepth"
        Me.rowDepth.Properties.Caption = "Depth"
        Me.rowDepth.Properties.FieldName = "Depth"
        '
        'rowRatio
        '
        Me.rowRatio.Name = "rowRatio"
        Me.rowRatio.Properties.Caption = "Ratio"
        Me.rowRatio.Properties.FieldName = "Ratio"
        '
        'rowCrHeight
        '
        Me.rowCrHeight.Name = "rowCrHeight"
        Me.rowCrHeight.Properties.Caption = "Cr Height"
        Me.rowCrHeight.Properties.FieldName = "CrHeight"
        '
        'rowCrAngle
        '
        Me.rowCrAngle.Name = "rowCrAngle"
        Me.rowCrAngle.Properties.Caption = "Cr Angle"
        Me.rowCrAngle.Properties.FieldName = "CrAngle"
        '
        'rowPvDepth
        '
        Me.rowPvDepth.Name = "rowPvDepth"
        Me.rowPvDepth.Properties.Caption = "Pv Depth"
        Me.rowPvDepth.Properties.FieldName = "PvDepth"
        '
        'rowPvAngle
        '
        Me.rowPvAngle.Name = "rowPvAngle"
        Me.rowPvAngle.Properties.Caption = "Pv Angle"
        Me.rowPvAngle.Properties.FieldName = "PvAngle"
        '
        'rowBlack
        '
        Me.rowBlack.Name = "rowBlack"
        Me.rowBlack.Properties.Caption = "Black"
        Me.rowBlack.Properties.FieldName = "Black"
        '
        'rowWhite
        '
        Me.rowWhite.Name = "rowWhite"
        Me.rowWhite.Properties.Caption = "White"
        Me.rowWhite.Properties.FieldName = "White"
        '
        'rowComment
        '
        Me.rowComment.Name = "rowComment"
        Me.rowComment.Properties.Caption = "Comment"
        Me.rowComment.Properties.FieldName = "Comment"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.EmptySpaceItem1, Me.EmptySpaceItem2, Me.LayoutControlItem3, Me.EmptySpaceItem3, Me.LayoutControlItem4})
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(953, 367)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.vGrid
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 37)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(933, 310)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.txtStockID
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.MaxSize = New System.Drawing.Size(197, 24)
        Me.LayoutControlItem2.MinSize = New System.Drawing.Size(197, 24)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(197, 26)
        Me.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem2.Text = "Stock ID"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(40, 13)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 26)
        Me.EmptySpaceItem1.MaxSize = New System.Drawing.Size(844, 11)
        Me.EmptySpaceItem1.MinSize = New System.Drawing.Size(844, 11)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(933, 11)
        Me.EmptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(334, 0)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(39, 26)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.btnLoad
        Me.LayoutControlItem3.Location = New System.Drawing.Point(373, 0)
        Me.LayoutControlItem3.MaxSize = New System.Drawing.Size(73, 26)
        Me.LayoutControlItem3.MinSize = New System.Drawing.Size(73, 26)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(73, 26)
        Me.LayoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(446, 0)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(487, 26)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'SvgImageCollection1
        '
        Me.SvgImageCollection1.Add("security_warningcircled2", "image://svgimages/icon builder/security_warningcircled2.svg")
        '
        'cmblab
        '
        Me.cmblab.Location = New System.Drawing.Point(252, 12)
        Me.cmblab.MenuManager = Me.RibbonControl1
        Me.cmblab.Name = "cmblab"
        Me.cmblab.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmblab.Size = New System.Drawing.Size(90, 20)
        Me.cmblab.StyleController = Me.LayoutControl1
        Me.cmblab.TabIndex = 5
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.cmblab
        Me.LayoutControlItem4.Location = New System.Drawing.Point(197, 0)
        Me.LayoutControlItem4.MaxSize = New System.Drawing.Size(137, 26)
        Me.LayoutControlItem4.MinSize = New System.Drawing.Size(137, 26)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(137, 26)
        Me.LayoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem4.Text = "Lab"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(40, 13)
        '
        'FrmGradingComparision
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(953, 541)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.RibbonStatusBar1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.Name = "FrmGradingComparision"
        Me.Ribbon = Me.RibbonControl1
        Me.StatusBar = Me.RibbonStatusBar1
        Me.Text = "Grading Comparision"
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.txtStockID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SvgImageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmblab.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonStatusBar1 As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents vGrid As DevExpress.XtraVerticalGrid.VGridControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents btnLoad As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtStockID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents rowGradingID As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowCompanyID As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowBranchID As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowUserID As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowGradingDate As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowGraderID As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowLabID As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowBarcode As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowQty As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowCarats As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowShapeID As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowColorID As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowClarityID As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowFlourID As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowCutID As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowPolishID As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowSymID As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowTablePercent As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowTotalDepth As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowLength As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowWidth As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowDepth As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowRatio As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowCrHeight As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowCrAngle As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowPvDepth As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowPvAngle As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowBlack As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowWhite As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowComment As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents SvgImageCollection1 As DevExpress.Utils.SvgImageCollection
    Friend WithEvents cmblab As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
End Class
