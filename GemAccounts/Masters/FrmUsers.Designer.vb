<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmUsers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUsers))
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.dg = New DevExpress.XtraGrid.GridControl()
        Me.view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Col_userid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Col_username = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Col_password = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Col_cmp_name = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Col_br_name = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btncancel = New DevExpress.XtraEditors.SimpleButton()
        Me.btnsave = New DevExpress.XtraEditors.SimpleButton()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.cmbcompany = New System.Windows.Forms.ComboBox()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.cmbbranch = New System.Windows.Forms.ComboBox()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.dg)
        Me.LayoutControl1.Controls.Add(Me.btncancel)
        Me.LayoutControl1.Controls.Add(Me.btnsave)
        Me.LayoutControl1.Controls.Add(Me.txtpassword)
        Me.LayoutControl1.Controls.Add(Me.cmbcompany)
        Me.LayoutControl1.Controls.Add(Me.txtusername)
        Me.LayoutControl1.Controls.Add(Me.cmbbranch)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(607, 1, 450, 400)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(759, 357)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'dg
        '
        Me.dg.Location = New System.Drawing.Point(12, 153)
        Me.dg.MainView = Me.view
        Me.dg.Name = "dg"
        Me.dg.Size = New System.Drawing.Size(735, 192)
        Me.dg.TabIndex = 20
        Me.dg.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.view})
        '
        'view
        '
        Me.view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Col_userid, Me.Col_username, Me.Col_password, Me.Col_cmp_name, Me.Col_br_name})
        Me.view.GridControl = Me.dg
        Me.view.Name = "view"
        Me.view.OptionsBehavior.Editable = False
        Me.view.OptionsView.ShowGroupPanel = False
        '
        'Col_userid
        '
        Me.Col_userid.Caption = "ID"
        Me.Col_userid.FieldName = "user_id"
        Me.Col_userid.Name = "Col_userid"
        Me.Col_userid.Visible = True
        Me.Col_userid.VisibleIndex = 0
        '
        'Col_username
        '
        Me.Col_username.Caption = "User Name"
        Me.Col_username.FieldName = "user_name"
        Me.Col_username.Name = "Col_username"
        Me.Col_username.Visible = True
        Me.Col_username.VisibleIndex = 1
        '
        'Col_password
        '
        Me.Col_password.Caption = "Password"
        Me.Col_password.FieldName = "password"
        Me.Col_password.Name = "Col_password"
        Me.Col_password.Visible = True
        Me.Col_password.VisibleIndex = 2
        '
        'Col_cmp_name
        '
        Me.Col_cmp_name.Caption = "Company Name"
        Me.Col_cmp_name.FieldName = "cmp_name"
        Me.Col_cmp_name.Name = "Col_cmp_name"
        Me.Col_cmp_name.Visible = True
        Me.Col_cmp_name.VisibleIndex = 3
        '
        'Col_br_name
        '
        Me.Col_br_name.Caption = "Branch Name"
        Me.Col_br_name.FieldName = "br_name"
        Me.Col_br_name.Name = "Col_br_name"
        Me.Col_br_name.Visible = True
        Me.Col_br_name.VisibleIndex = 4
        '
        'btncancel
        '
        Me.btncancel.ImageOptions.Image = CType(resources.GetObject("btncancel.ImageOptions.Image"), System.Drawing.Image)
        Me.btncancel.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btncancel.Location = New System.Drawing.Point(325, 85)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(40, 38)
        Me.btncancel.StyleController = Me.LayoutControl1
        Me.btncancel.TabIndex = 5
        '
        'btnsave
        '
        Me.btnsave.ImageOptions.Image = CType(resources.GetObject("btnsave.ImageOptions.Image"), System.Drawing.Image)
        Me.btnsave.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnsave.Location = New System.Drawing.Point(325, 43)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(40, 38)
        Me.btnsave.StyleController = Me.LayoutControl1
        Me.btnsave.TabIndex = 4
        '
        'txtpassword
        '
        Me.txtpassword.Location = New System.Drawing.Point(79, 67)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(227, 20)
        Me.txtpassword.TabIndex = 1
        '
        'cmbcompany
        '
        Me.cmbcompany.FormattingEnabled = True
        Me.cmbcompany.Location = New System.Drawing.Point(79, 91)
        Me.cmbcompany.Name = "cmbcompany"
        Me.cmbcompany.Size = New System.Drawing.Size(227, 21)
        Me.cmbcompany.TabIndex = 2
        '
        'txtusername
        '
        Me.txtusername.Location = New System.Drawing.Point(79, 43)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(227, 20)
        Me.txtusername.TabIndex = 0
        '
        'cmbbranch
        '
        Me.cmbbranch.FormattingEnabled = True
        Me.cmbbranch.Location = New System.Drawing.Point(79, 116)
        Me.cmbbranch.Name = "cmbbranch"
        Me.cmbbranch.Size = New System.Drawing.Size(227, 21)
        Me.cmbbranch.TabIndex = 3
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2, Me.LayoutControlItem7})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(759, 357)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AppearanceGroup.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlGroup2.AppearanceGroup.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LayoutControlGroup2.AppearanceGroup.Options.UseFont = True
        Me.LayoutControlGroup2.AppearanceGroup.Options.UseForeColor = True
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem4, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem5, Me.EmptySpaceItem4, Me.LayoutControlItem6, Me.EmptySpaceItem1})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(739, 141)
        Me.LayoutControlGroup2.Text = "User Master"
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.txtusername
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(286, 24)
        Me.LayoutControlItem1.Text = "User Name"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(52, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.txtpassword
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(286, 24)
        Me.LayoutControlItem4.Text = "Password"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(52, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.cmbcompany
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(286, 25)
        Me.LayoutControlItem2.Text = "Company"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(52, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.cmbbranch
        Me.LayoutControlItem3.CustomizationFormText = "LayoutControlItem2"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 73)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(286, 25)
        Me.LayoutControlItem3.Text = "Branch"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(52, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.btnsave
        Me.LayoutControlItem5.Location = New System.Drawing.Point(301, 0)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(44, 42)
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'EmptySpaceItem4
        '
        Me.EmptySpaceItem4.AllowHotTrack = False
        Me.EmptySpaceItem4.Location = New System.Drawing.Point(345, 0)
        Me.EmptySpaceItem4.Name = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Size = New System.Drawing.Size(370, 98)
        Me.EmptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.btncancel
        Me.LayoutControlItem6.Location = New System.Drawing.Point(301, 42)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(44, 56)
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(286, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(15, 98)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.dg
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 141)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(739, 196)
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'FrmUsers
        '
        Me.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(759, 357)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "FrmUsers"
        Me.Text = "User Master"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents cmbcompany As ComboBox
    Friend WithEvents txtusername As TextBox
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents cmbbranch As ComboBox
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents btnsave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btncancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents dg As DevExpress.XtraGrid.GridControl
    Friend WithEvents view As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents Col_userid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Col_username As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Col_password As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Col_cmp_name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Col_br_name As DevExpress.XtraGrid.Columns.GridColumn
End Class
