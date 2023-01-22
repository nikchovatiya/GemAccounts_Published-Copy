<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLabResults
    Inherits DevExpress.XtraEditors.XtraForm

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
        Me.dg = New DevExpress.XtraGrid.GridControl()
        Me.dgview = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.riShape = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.DiaShapeMasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Dia_MasterDataset = New GemAccounts.Dia_MasterDataset()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.riColor = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.DiaColorMasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DoubeMask = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.riClarity = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.DiaClarityMasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.riFlo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.DiaFloMasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.riCut = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.DiaCutMasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.riPolish = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.DiaPolishMasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.riSym = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.DiaSymmMasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.riLab = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.DIaLabMasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.riUser = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.DiaUserMasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Dia_Shape_MasterTableAdapter = New GemAccounts.Dia_MasterDatasetTableAdapters.Dia_Shape_MasterTableAdapter()
        Me.Dia_Color_MasterTableAdapter = New GemAccounts.Dia_MasterDatasetTableAdapters.Dia_Color_MasterTableAdapter()
        Me.Dia_Clarity_MasterTableAdapter = New GemAccounts.Dia_MasterDatasetTableAdapters.Dia_Clarity_MasterTableAdapter()
        Me.Dia_Flo_MasterTableAdapter = New GemAccounts.Dia_MasterDatasetTableAdapters.Dia_Flo_MasterTableAdapter()
        Me.Dia_Cut_MasterTableAdapter = New GemAccounts.Dia_MasterDatasetTableAdapters.Dia_Cut_MasterTableAdapter()
        Me.Dia_Polish_MasterTableAdapter = New GemAccounts.Dia_MasterDatasetTableAdapters.Dia_Polish_MasterTableAdapter()
        Me.Dia_Symm_MasterTableAdapter = New GemAccounts.Dia_MasterDatasetTableAdapters.Dia_Symm_MasterTableAdapter()
        Me.DIa_Lab_MasterTableAdapter = New GemAccounts.Dia_MasterDatasetTableAdapters.DIa_Lab_MasterTableAdapter()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.Dia_User_MasterTableAdapter = New GemAccounts.Dia_MasterDatasetTableAdapters.Dia_User_MasterTableAdapter()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgview, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.riShape, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiaShapeMasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dia_MasterDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.riColor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiaColorMasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DoubeMask, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.riClarity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiaClarityMasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.riFlo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiaFloMasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.riCut, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiaCutMasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.riPolish, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiaPolishMasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.riSym, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiaSymmMasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.riLab, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DIaLabMasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.riUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiaUserMasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dg
        '
        Me.dg.Location = New System.Drawing.Point(12, 12)
        Me.dg.MainView = Me.dgview
        Me.dg.Name = "dg"
        Me.dg.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.riShape, Me.riColor, Me.riClarity, Me.riFlo, Me.riCut, Me.riPolish, Me.riSym, Me.riLab, Me.DoubeMask, Me.riUser})
        Me.dg.Size = New System.Drawing.Size(845, 343)
        Me.dg.TabIndex = 0
        Me.dg.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.dgview})
        '
        'dgview
        '
        Me.dgview.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.dgview.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.dgview.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.dgview.Appearance.Row.Options.UseTextOptions = True
        Me.dgview.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.dgview.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
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
        Me.GridColumn1.Caption = "Transaction ID"
        Me.GridColumn1.FieldName = "TransactionID"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Shape"
        Me.GridColumn2.ColumnEdit = Me.riShape
        Me.GridColumn2.FieldName = "ShapeID"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 3
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
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Color"
        Me.GridColumn3.ColumnEdit = Me.riColor
        Me.GridColumn3.FieldName = "ColorID"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 4
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
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Qty"
        Me.GridColumn4.DisplayFormat.FormatString = "n0"
        Me.GridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn4.FieldName = "Qty"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 1
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Carats"
        Me.GridColumn5.ColumnEdit = Me.DoubeMask
        Me.GridColumn5.FieldName = "Carats"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 2
        '
        'DoubeMask
        '
        Me.DoubeMask.AutoHeight = False
        Me.DoubeMask.Mask.EditMask = "n2"
        Me.DoubeMask.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.DoubeMask.Mask.UseMaskAsDisplayFormat = True
        Me.DoubeMask.Name = "DoubeMask"
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Clartiy"
        Me.GridColumn6.ColumnEdit = Me.riClarity
        Me.GridColumn6.FieldName = "ClarityID"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 5
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
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Flo"
        Me.GridColumn7.ColumnEdit = Me.riFlo
        Me.GridColumn7.FieldName = "FloID"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 6
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
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Cut"
        Me.GridColumn8.ColumnEdit = Me.riCut
        Me.GridColumn8.FieldName = "CutID"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 7
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
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Polish"
        Me.GridColumn9.ColumnEdit = Me.riPolish
        Me.GridColumn9.FieldName = "PolishID"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 8
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
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Sym"
        Me.GridColumn10.ColumnEdit = Me.riSym
        Me.GridColumn10.FieldName = "SymID"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 9
        '
        'riSym
        '
        Me.riSym.AutoHeight = False
        Me.riSym.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.riSym.DataSource = Me.DiaSymmMasterBindingSource
        Me.riSym.DisplayMember = "symm_name"
        Me.riSym.Name = "riSym"
        Me.riSym.NullText = ""
        Me.riSym.ValueMember = "symm_name"
        '
        'DiaSymmMasterBindingSource
        '
        Me.DiaSymmMasterBindingSource.DataMember = "Dia_Symm_Master"
        Me.DiaSymmMasterBindingSource.DataSource = Me.Dia_MasterDataset
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "Lab"
        Me.GridColumn11.ColumnEdit = Me.riLab
        Me.GridColumn11.FieldName = "LabID"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 10
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
        'GridColumn12
        '
        Me.GridColumn12.Caption = "Report No."
        Me.GridColumn12.FieldName = "LCertificateNo"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 11
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "Date"
        Me.GridColumn13.DisplayFormat.FormatString = "dd-MM-yyyy hh:mm:ss"
        Me.GridColumn13.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn13.FieldName = "ExecutionDateTime"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 12
        '
        'GridColumn14
        '
        Me.GridColumn14.Caption = "User"
        Me.GridColumn14.ColumnEdit = Me.riUser
        Me.GridColumn14.FieldName = "UserID"
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.Visible = True
        Me.GridColumn14.VisibleIndex = 13
        '
        'riUser
        '
        Me.riUser.AutoHeight = False
        Me.riUser.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.riUser.DataSource = Me.DiaUserMasterBindingSource
        Me.riUser.DisplayMember = "user_name"
        Me.riUser.Name = "riUser"
        Me.riUser.ValueMember = "user_id"
        '
        'DiaUserMasterBindingSource
        '
        Me.DiaUserMasterBindingSource.DataMember = "Dia_User_Master"
        Me.DiaUserMasterBindingSource.DataSource = Me.Dia_MasterDataset
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
        'DIa_Lab_MasterTableAdapter
        '
        Me.DIa_Lab_MasterTableAdapter.ClearBeforeFill = True
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.dg)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(869, 367)
        Me.LayoutControl1.TabIndex = 1
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(869, 367)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.dg
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(849, 347)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'Dia_User_MasterTableAdapter
        '
        Me.Dia_User_MasterTableAdapter.ClearBeforeFill = True
        '
        'frmLabResults
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(869, 367)
        Me.Controls.Add(Me.LayoutControl1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLabResults"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lab Results"
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgview, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.riShape, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiaShapeMasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dia_MasterDataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.riColor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiaColorMasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DoubeMask, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.riClarity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiaClarityMasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.riFlo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiaFloMasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.riCut, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiaCutMasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.riPolish, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiaPolishMasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.riSym, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiaSymmMasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.riLab, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DIaLabMasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.riUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiaUserMasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dg As DevExpress.XtraGrid.GridControl
    Friend WithEvents dgview As DevExpress.XtraGrid.Views.Grid.GridView
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
    Friend WithEvents riShape As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents riColor As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents riClarity As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents riFlo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents riCut As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents riPolish As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents riSym As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Dia_MasterDataset As Dia_MasterDataset
    Friend WithEvents DiaShapeMasterBindingSource As BindingSource
    Friend WithEvents Dia_Shape_MasterTableAdapter As Dia_MasterDatasetTableAdapters.Dia_Shape_MasterTableAdapter
    Friend WithEvents DiaColorMasterBindingSource As BindingSource
    Friend WithEvents Dia_Color_MasterTableAdapter As Dia_MasterDatasetTableAdapters.Dia_Color_MasterTableAdapter
    Friend WithEvents DiaClarityMasterBindingSource As BindingSource
    Friend WithEvents Dia_Clarity_MasterTableAdapter As Dia_MasterDatasetTableAdapters.Dia_Clarity_MasterTableAdapter
    Friend WithEvents DiaFloMasterBindingSource As BindingSource
    Friend WithEvents Dia_Flo_MasterTableAdapter As Dia_MasterDatasetTableAdapters.Dia_Flo_MasterTableAdapter
    Friend WithEvents DiaCutMasterBindingSource As BindingSource
    Friend WithEvents Dia_Cut_MasterTableAdapter As Dia_MasterDatasetTableAdapters.Dia_Cut_MasterTableAdapter
    Friend WithEvents DiaPolishMasterBindingSource As BindingSource
    Friend WithEvents Dia_Polish_MasterTableAdapter As Dia_MasterDatasetTableAdapters.Dia_Polish_MasterTableAdapter
    Friend WithEvents DiaSymmMasterBindingSource As BindingSource
    Friend WithEvents Dia_Symm_MasterTableAdapter As Dia_MasterDatasetTableAdapters.Dia_Symm_MasterTableAdapter
    Friend WithEvents riLab As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents DIaLabMasterBindingSource As BindingSource
    Friend WithEvents DIa_Lab_MasterTableAdapter As Dia_MasterDatasetTableAdapters.DIa_Lab_MasterTableAdapter
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DoubeMask As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents riUser As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents DiaUserMasterBindingSource As BindingSource
    Friend WithEvents Dia_User_MasterTableAdapter As Dia_MasterDatasetTableAdapters.Dia_User_MasterTableAdapter
End Class
