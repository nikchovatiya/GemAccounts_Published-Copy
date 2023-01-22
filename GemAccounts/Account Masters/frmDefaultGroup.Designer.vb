<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDefaultGroup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDefaultGroup))
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.cmbmainacc = New System.Windows.Forms.ComboBox()
        Me.cmbundergroup = New System.Windows.Forms.ComboBox()
        Me.dg = New DevExpress.XtraGrid.GridControl()
        Me.view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_gorup_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_group_name = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_under_group = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_main_group_name = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_is_default = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_under_group_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_main_group_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btncancel = New DevExpress.XtraEditors.SimpleButton()
        Me.btnsave = New DevExpress.XtraEditors.SimpleButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkdefault = New DevExpress.XtraEditors.CheckEdit()
        Me.txtgroupname = New System.Windows.Forms.TextBox()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkdefault.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.cmbmainacc)
        Me.LayoutControl1.Controls.Add(Me.cmbundergroup)
        Me.LayoutControl1.Controls.Add(Me.dg)
        Me.LayoutControl1.Controls.Add(Me.btncancel)
        Me.LayoutControl1.Controls.Add(Me.btnsave)
        Me.LayoutControl1.Controls.Add(Me.Label1)
        Me.LayoutControl1.Controls.Add(Me.chkdefault)
        Me.LayoutControl1.Controls.Add(Me.txtgroupname)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(956, 607)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'cmbmainacc
        '
        Me.cmbmainacc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbmainacc.FormattingEnabled = True
        Me.cmbmainacc.Location = New System.Drawing.Point(623, 43)
        Me.cmbmainacc.Name = "cmbmainacc"
        Me.cmbmainacc.Size = New System.Drawing.Size(124, 21)
        Me.cmbmainacc.TabIndex = 30
        '
        'cmbundergroup
        '
        Me.cmbundergroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbundergroup.FormattingEnabled = True
        Me.cmbundergroup.Location = New System.Drawing.Point(377, 43)
        Me.cmbundergroup.Name = "cmbundergroup"
        Me.cmbundergroup.Size = New System.Drawing.Size(143, 21)
        Me.cmbundergroup.TabIndex = 29
        '
        'dg
        '
        Me.dg.Location = New System.Drawing.Point(12, 97)
        Me.dg.MainView = Me.view
        Me.dg.Name = "dg"
        Me.dg.Size = New System.Drawing.Size(932, 498)
        Me.dg.TabIndex = 28
        Me.dg.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.view})
        '
        'view
        '
        Me.view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_gorup_id, Me.col_group_name, Me.col_under_group, Me.col_main_group_name, Me.col_is_default, Me.col_under_group_id, Me.col_main_group_id})
        Me.view.GridControl = Me.dg
        Me.view.Name = "view"
        Me.view.OptionsBehavior.Editable = False
        '
        'col_gorup_id
        '
        Me.col_gorup_id.Caption = "ID"
        Me.col_gorup_id.FieldName = "gorup_id"
        Me.col_gorup_id.Name = "col_gorup_id"
        '
        'col_group_name
        '
        Me.col_group_name.Caption = "Group Name"
        Me.col_group_name.FieldName = "group_name"
        Me.col_group_name.Name = "col_group_name"
        Me.col_group_name.Visible = True
        Me.col_group_name.VisibleIndex = 0
        '
        'col_under_group
        '
        Me.col_under_group.Caption = "Under Group"
        Me.col_under_group.FieldName = "under_group_name"
        Me.col_under_group.Name = "col_under_group"
        Me.col_under_group.Visible = True
        Me.col_under_group.VisibleIndex = 1
        '
        'col_main_group_name
        '
        Me.col_main_group_name.Caption = "Main Group Name"
        Me.col_main_group_name.FieldName = "main_group_name"
        Me.col_main_group_name.Name = "col_main_group_name"
        Me.col_main_group_name.Visible = True
        Me.col_main_group_name.VisibleIndex = 3
        '
        'col_is_default
        '
        Me.col_is_default.Caption = "Is Default"
        Me.col_is_default.FieldName = "is_default"
        Me.col_is_default.Name = "col_is_default"
        Me.col_is_default.Visible = True
        Me.col_is_default.VisibleIndex = 2
        '
        'col_under_group_id
        '
        Me.col_under_group_id.Caption = "Under Group ID"
        Me.col_under_group_id.FieldName = "under_group"
        Me.col_under_group_id.Name = "col_under_group_id"
        '
        'col_main_group_id
        '
        Me.col_main_group_id.Caption = "Main Group ID"
        Me.col_main_group_id.FieldName = "main_group_id"
        Me.col_main_group_id.Name = "col_main_group_id"
        '
        'btncancel
        '
        Me.btncancel.ImageOptions.Image = CType(resources.GetObject("btncancel.ImageOptions.Image"), System.Drawing.Image)
        Me.btncancel.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btncancel.Location = New System.Drawing.Point(868, 43)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(40, 38)
        Me.btncancel.StyleController = Me.LayoutControl1
        Me.btncancel.TabIndex = 27
        '
        'btnsave
        '
        Me.btnsave.ImageOptions.Image = CType(resources.GetObject("btnsave.ImageOptions.Image"), System.Drawing.Image)
        Me.btnsave.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnsave.Location = New System.Drawing.Point(824, 43)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(40, 38)
        Me.btnsave.StyleController = Me.LayoutControl1
        Me.btnsave.TabIndex = 26
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(924, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 81)
        Me.Label1.TabIndex = 7
        '
        'chkdefault
        '
        Me.chkdefault.Location = New System.Drawing.Point(751, 43)
        Me.chkdefault.Name = "chkdefault"
        Me.chkdefault.Properties.Caption = "Is Default"
        Me.chkdefault.Size = New System.Drawing.Size(69, 19)
        Me.chkdefault.StyleController = Me.LayoutControl1
        Me.chkdefault.TabIndex = 6
        Me.chkdefault.Visible = False
        '
        'txtgroupname
        '
        Me.txtgroupname.Location = New System.Drawing.Point(123, 43)
        Me.txtgroupname.Name = "txtgroupname"
        Me.txtgroupname.Size = New System.Drawing.Size(151, 20)
        Me.txtgroupname.TabIndex = 4
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2, Me.LayoutControlItem6, Me.LayoutControlGroup2})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(956, 607)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.Label1
        Me.LayoutControlItem2.Location = New System.Drawing.Point(912, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(24, 85)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.dg
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 85)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(936, 502)
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AppearanceGroup.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlGroup2.AppearanceGroup.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LayoutControlGroup2.AppearanceGroup.Options.UseFont = True
        Me.LayoutControlGroup2.AppearanceGroup.Options.UseForeColor = True
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem3, Me.LayoutControlItem5, Me.LayoutControlItem4, Me.LayoutControlItem7, Me.LayoutControlItem8})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(912, 85)
        Me.LayoutControlGroup2.Text = "Group Master"
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.txtgroupname
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(254, 42)
        Me.LayoutControlItem1.Text = "Group Name"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(96, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.chkdefault
        Me.LayoutControlItem3.Location = New System.Drawing.Point(727, 0)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(73, 42)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        Me.LayoutControlItem3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.btnsave
        Me.LayoutControlItem5.Location = New System.Drawing.Point(800, 0)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(44, 42)
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.btncancel
        Me.LayoutControlItem4.Location = New System.Drawing.Point(844, 0)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(44, 42)
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.cmbundergroup
        Me.LayoutControlItem7.Location = New System.Drawing.Point(254, 0)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(246, 42)
        Me.LayoutControlItem7.Text = "Under Group"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(96, 13)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.cmbmainacc
        Me.LayoutControlItem8.Location = New System.Drawing.Point(500, 0)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(227, 42)
        Me.LayoutControlItem8.Text = "Main Account Group"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(96, 13)
        '
        'frmDefaultGroup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(956, 607)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "frmDefaultGroup"
        Me.Text = "Default Groups"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkdefault.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Label1 As Label
    Friend WithEvents chkdefault As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtgroupname As TextBox
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents dg As DevExpress.XtraGrid.GridControl
    Friend WithEvents view As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_gorup_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_main_group_name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btncancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnsave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents col_group_name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmbundergroup As ComboBox
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents col_under_group As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmbmainacc As ComboBox
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents col_is_default As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_under_group_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_main_group_id As DevExpress.XtraGrid.Columns.GridColumn
End Class
