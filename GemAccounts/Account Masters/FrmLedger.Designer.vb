<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmLedger
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLedger))
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.cmbdrcr = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtopening = New System.Windows.Forms.TextBox()
        Me.dg = New DevExpress.XtraGrid.GridControl()
        Me.view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Col_Ledger_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Col_LedgerName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Col_LUnderGroup = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Col_UnderGroupID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Col_CID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Col_LBID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Col_UID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Col_LAddress = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Col_LCountry = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Col_LState = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Col_LCity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Col_LMobile = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Col_LPhone = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Col_LEmail = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Col_LGSTIN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Col_LPAN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Col_LBank = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Col_LBranch = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Col_LAcNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Col_LIFSC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Col_LRouting = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Col_LSwift = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Col_LOpeningBalance = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cmbgroup = New System.Windows.Forms.ComboBox()
        Me.txtledger = New System.Windows.Forms.TextBox()
        Me.txtadd = New System.Windows.Forms.TextBox()
        Me.cmbcounty = New System.Windows.Forms.ComboBox()
        Me.cmbstate = New System.Windows.Forms.ComboBox()
        Me.cmbcity = New System.Windows.Forms.ComboBox()
        Me.txtmobile = New System.Windows.Forms.TextBox()
        Me.txtphone = New System.Windows.Forms.TextBox()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.txtgst = New System.Windows.Forms.TextBox()
        Me.txtbank = New System.Windows.Forms.TextBox()
        Me.txtacno = New System.Windows.Forms.TextBox()
        Me.txtifsc = New System.Windows.Forms.TextBox()
        Me.txtpan = New System.Windows.Forms.TextBox()
        Me.txtbranch = New System.Windows.Forms.TextBox()
        Me.txtrouting = New System.Windows.Forms.TextBox()
        Me.txtswift = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CmdSave = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem18 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem23 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem24 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem25 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup5 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem21 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem19 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem20 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem22 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.cmbdrcr)
        Me.LayoutControl1.Controls.Add(Me.Label1)
        Me.LayoutControl1.Controls.Add(Me.txtopening)
        Me.LayoutControl1.Controls.Add(Me.dg)
        Me.LayoutControl1.Controls.Add(Me.cmbgroup)
        Me.LayoutControl1.Controls.Add(Me.txtledger)
        Me.LayoutControl1.Controls.Add(Me.txtadd)
        Me.LayoutControl1.Controls.Add(Me.cmbcounty)
        Me.LayoutControl1.Controls.Add(Me.cmbstate)
        Me.LayoutControl1.Controls.Add(Me.cmbcity)
        Me.LayoutControl1.Controls.Add(Me.txtmobile)
        Me.LayoutControl1.Controls.Add(Me.txtphone)
        Me.LayoutControl1.Controls.Add(Me.txtemail)
        Me.LayoutControl1.Controls.Add(Me.txtgst)
        Me.LayoutControl1.Controls.Add(Me.txtbank)
        Me.LayoutControl1.Controls.Add(Me.txtacno)
        Me.LayoutControl1.Controls.Add(Me.txtifsc)
        Me.LayoutControl1.Controls.Add(Me.txtpan)
        Me.LayoutControl1.Controls.Add(Me.txtbranch)
        Me.LayoutControl1.Controls.Add(Me.txtrouting)
        Me.LayoutControl1.Controls.Add(Me.txtswift)
        Me.LayoutControl1.Controls.Add(Me.Label3)
        Me.LayoutControl1.Controls.Add(Me.CmdSave)
        Me.LayoutControl1.Controls.Add(Me.cmdCancel)
        Me.LayoutControl1.Controls.Add(Me.Label2)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(999, 596)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'cmbdrcr
        '
        Me.cmbdrcr.FormattingEnabled = True
        Me.cmbdrcr.Items.AddRange(New Object() {"Dr", "Cr"})
        Me.cmbdrcr.Location = New System.Drawing.Point(352, 272)
        Me.cmbdrcr.Name = "cmbdrcr"
        Me.cmbdrcr.Size = New System.Drawing.Size(160, 21)
        Me.cmbdrcr.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(516, 272)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(459, 21)
        Me.Label1.TabIndex = 4
        '
        'txtopening
        '
        Me.txtopening.Location = New System.Drawing.Point(107, 272)
        Me.txtopening.Name = "txtopening"
        Me.txtopening.Size = New System.Drawing.Size(158, 20)
        Me.txtopening.TabIndex = 17
        '
        'dg
        '
        Me.dg.Location = New System.Drawing.Point(12, 375)
        Me.dg.MainView = Me.view
        Me.dg.Name = "dg"
        Me.dg.Size = New System.Drawing.Size(975, 209)
        Me.dg.TabIndex = 21
        Me.dg.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.view})
        '
        'view
        '
        Me.view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Col_Ledger_ID, Me.Col_LedgerName, Me.Col_LUnderGroup, Me.Col_UnderGroupID, Me.Col_CID, Me.Col_LBID, Me.Col_UID, Me.Col_LAddress, Me.Col_LCountry, Me.Col_LState, Me.Col_LCity, Me.Col_LMobile, Me.Col_LPhone, Me.Col_LEmail, Me.Col_LGSTIN, Me.Col_LPAN, Me.Col_LBank, Me.Col_LBranch, Me.Col_LAcNo, Me.Col_LIFSC, Me.Col_LRouting, Me.Col_LSwift, Me.Col_LOpeningBalance})
        Me.view.GridControl = Me.dg
        Me.view.Name = "view"
        Me.view.OptionsBehavior.Editable = False
        Me.view.OptionsMenu.EnableFooterMenu = False
        Me.view.OptionsView.ShowFooter = True
        Me.view.OptionsView.ShowGroupPanel = False
        '
        'Col_Ledger_ID
        '
        Me.Col_Ledger_ID.Caption = "Ledger ID"
        Me.Col_Ledger_ID.FieldName = "LedgerID"
        Me.Col_Ledger_ID.Name = "Col_Ledger_ID"
        '
        'Col_LedgerName
        '
        Me.Col_LedgerName.Caption = "Ledge rName"
        Me.Col_LedgerName.FieldName = "LedgerName"
        Me.Col_LedgerName.Name = "Col_LedgerName"
        Me.Col_LedgerName.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "LedgerName", "{0}")})
        Me.Col_LedgerName.Visible = True
        Me.Col_LedgerName.VisibleIndex = 0
        '
        'Col_LUnderGroup
        '
        Me.Col_LUnderGroup.Caption = "Under Group"
        Me.Col_LUnderGroup.FieldName = "LUnderGroupName"
        Me.Col_LUnderGroup.Name = "Col_LUnderGroup"
        Me.Col_LUnderGroup.Visible = True
        Me.Col_LUnderGroup.VisibleIndex = 1
        '
        'Col_UnderGroupID
        '
        Me.Col_UnderGroupID.Caption = "Under Group ID"
        Me.Col_UnderGroupID.FieldName = "LUnderGroup"
        Me.Col_UnderGroupID.Name = "Col_UnderGroupID"
        '
        'Col_CID
        '
        Me.Col_CID.Caption = "Company ID"
        Me.Col_CID.FieldName = "LCID"
        Me.Col_CID.Name = "Col_CID"
        '
        'Col_LBID
        '
        Me.Col_LBID.Caption = "Branch ID"
        Me.Col_LBID.FieldName = "LBID"
        Me.Col_LBID.Name = "Col_LBID"
        '
        'Col_UID
        '
        Me.Col_UID.Caption = "User ID"
        Me.Col_UID.FieldName = "LUID"
        Me.Col_UID.Name = "Col_UID"
        '
        'Col_LAddress
        '
        Me.Col_LAddress.Caption = "Address"
        Me.Col_LAddress.FieldName = "LAddress"
        Me.Col_LAddress.Name = "Col_LAddress"
        '
        'Col_LCountry
        '
        Me.Col_LCountry.Caption = "Country"
        Me.Col_LCountry.FieldName = "LCountry"
        Me.Col_LCountry.Name = "Col_LCountry"
        Me.Col_LCountry.Visible = True
        Me.Col_LCountry.VisibleIndex = 2
        '
        'Col_LState
        '
        Me.Col_LState.Caption = "State"
        Me.Col_LState.FieldName = "LState"
        Me.Col_LState.Name = "Col_LState"
        Me.Col_LState.Visible = True
        Me.Col_LState.VisibleIndex = 3
        '
        'Col_LCity
        '
        Me.Col_LCity.Caption = "City"
        Me.Col_LCity.FieldName = "LCity"
        Me.Col_LCity.Name = "Col_LCity"
        Me.Col_LCity.Visible = True
        Me.Col_LCity.VisibleIndex = 4
        '
        'Col_LMobile
        '
        Me.Col_LMobile.Caption = "Mobile"
        Me.Col_LMobile.FieldName = "LMobile"
        Me.Col_LMobile.Name = "Col_LMobile"
        Me.Col_LMobile.Visible = True
        Me.Col_LMobile.VisibleIndex = 5
        '
        'Col_LPhone
        '
        Me.Col_LPhone.Caption = "Phone"
        Me.Col_LPhone.FieldName = "LPhone"
        Me.Col_LPhone.Name = "Col_LPhone"
        Me.Col_LPhone.Visible = True
        Me.Col_LPhone.VisibleIndex = 6
        '
        'Col_LEmail
        '
        Me.Col_LEmail.Caption = "Email"
        Me.Col_LEmail.FieldName = "LEmail"
        Me.Col_LEmail.Name = "Col_LEmail"
        '
        'Col_LGSTIN
        '
        Me.Col_LGSTIN.Caption = "GSTIN"
        Me.Col_LGSTIN.FieldName = "LGSTIN"
        Me.Col_LGSTIN.Name = "Col_LGSTIN"
        Me.Col_LGSTIN.Visible = True
        Me.Col_LGSTIN.VisibleIndex = 7
        '
        'Col_LPAN
        '
        Me.Col_LPAN.Caption = "PAN"
        Me.Col_LPAN.FieldName = "LPAN"
        Me.Col_LPAN.Name = "Col_LPAN"
        Me.Col_LPAN.Visible = True
        Me.Col_LPAN.VisibleIndex = 8
        '
        'Col_LBank
        '
        Me.Col_LBank.Caption = "Bank"
        Me.Col_LBank.FieldName = "LBank"
        Me.Col_LBank.Name = "Col_LBank"
        '
        'Col_LBranch
        '
        Me.Col_LBranch.Caption = "Bank Branch"
        Me.Col_LBranch.FieldName = "LBranch"
        Me.Col_LBranch.Name = "Col_LBranch"
        '
        'Col_LAcNo
        '
        Me.Col_LAcNo.Caption = "Account #"
        Me.Col_LAcNo.FieldName = "LAcNo"
        Me.Col_LAcNo.Name = "Col_LAcNo"
        '
        'Col_LIFSC
        '
        Me.Col_LIFSC.Caption = "IFSC"
        Me.Col_LIFSC.FieldName = "LIFSC"
        Me.Col_LIFSC.Name = "Col_LIFSC"
        '
        'Col_LRouting
        '
        Me.Col_LRouting.Caption = "Routing #"
        Me.Col_LRouting.FieldName = "LRouting"
        Me.Col_LRouting.Name = "Col_LRouting"
        '
        'Col_LSwift
        '
        Me.Col_LSwift.Caption = "Swift #"
        Me.Col_LSwift.FieldName = "LSwift"
        Me.Col_LSwift.Name = "Col_LSwift"
        '
        'Col_LOpeningBalance
        '
        Me.Col_LOpeningBalance.Caption = "Opening Balance"
        Me.Col_LOpeningBalance.DisplayFormat.FormatString = "0.00"
        Me.Col_LOpeningBalance.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.Col_LOpeningBalance.FieldName = "LOpeningBalance"
        Me.Col_LOpeningBalance.Name = "Col_LOpeningBalance"
        Me.Col_LOpeningBalance.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "LOpeningBalance", "Diff in Opening={0:0.00}")})
        Me.Col_LOpeningBalance.Visible = True
        Me.Col_LOpeningBalance.VisibleIndex = 9
        '
        'cmbgroup
        '
        Me.cmbgroup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbgroup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbgroup.FormattingEnabled = True
        Me.cmbgroup.Location = New System.Drawing.Point(508, 43)
        Me.cmbgroup.Name = "cmbgroup"
        Me.cmbgroup.Size = New System.Drawing.Size(467, 21)
        Me.cmbgroup.TabIndex = 1
        '
        'txtledger
        '
        Me.txtledger.Location = New System.Drawing.Point(107, 43)
        Me.txtledger.Name = "txtledger"
        Me.txtledger.Size = New System.Drawing.Size(314, 20)
        Me.txtledger.TabIndex = 0
        '
        'txtadd
        '
        Me.txtadd.Location = New System.Drawing.Point(107, 68)
        Me.txtadd.Name = "txtadd"
        Me.txtadd.Size = New System.Drawing.Size(868, 26)
        Me.txtadd.TabIndex = 2
        '
        'cmbcounty
        '
        Me.cmbcounty.FormattingEnabled = True
        Me.cmbcounty.Location = New System.Drawing.Point(107, 98)
        Me.cmbcounty.Name = "cmbcounty"
        Me.cmbcounty.Size = New System.Drawing.Size(224, 21)
        Me.cmbcounty.TabIndex = 3
        '
        'cmbstate
        '
        Me.cmbstate.FormattingEnabled = True
        Me.cmbstate.Location = New System.Drawing.Point(418, 98)
        Me.cmbstate.Name = "cmbstate"
        Me.cmbstate.Size = New System.Drawing.Size(241, 21)
        Me.cmbstate.TabIndex = 4
        '
        'cmbcity
        '
        Me.cmbcity.FormattingEnabled = True
        Me.cmbcity.Location = New System.Drawing.Point(746, 98)
        Me.cmbcity.Name = "cmbcity"
        Me.cmbcity.Size = New System.Drawing.Size(229, 21)
        Me.cmbcity.TabIndex = 5
        '
        'txtmobile
        '
        Me.txtmobile.Location = New System.Drawing.Point(107, 128)
        Me.txtmobile.Name = "txtmobile"
        Me.txtmobile.Size = New System.Drawing.Size(224, 26)
        Me.txtmobile.TabIndex = 6
        '
        'txtphone
        '
        Me.txtphone.Location = New System.Drawing.Point(418, 128)
        Me.txtphone.Name = "txtphone"
        Me.txtphone.Size = New System.Drawing.Size(241, 26)
        Me.txtphone.TabIndex = 7
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(746, 128)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(229, 26)
        Me.txtemail.TabIndex = 8
        '
        'txtgst
        '
        Me.txtgst.Location = New System.Drawing.Point(107, 182)
        Me.txtgst.Name = "txtgst"
        Me.txtgst.Size = New System.Drawing.Size(404, 26)
        Me.txtgst.TabIndex = 9
        '
        'txtbank
        '
        Me.txtbank.Location = New System.Drawing.Point(107, 212)
        Me.txtbank.Name = "txtbank"
        Me.txtbank.Size = New System.Drawing.Size(404, 26)
        Me.txtbank.TabIndex = 11
        '
        'txtacno
        '
        Me.txtacno.Location = New System.Drawing.Point(107, 242)
        Me.txtacno.Name = "txtacno"
        Me.txtacno.Size = New System.Drawing.Size(158, 26)
        Me.txtacno.TabIndex = 13
        '
        'txtifsc
        '
        Me.txtifsc.Location = New System.Drawing.Point(352, 242)
        Me.txtifsc.Name = "txtifsc"
        Me.txtifsc.Size = New System.Drawing.Size(160, 26)
        Me.txtifsc.TabIndex = 14
        '
        'txtpan
        '
        Me.txtpan.Location = New System.Drawing.Point(598, 182)
        Me.txtpan.Name = "txtpan"
        Me.txtpan.Size = New System.Drawing.Size(377, 26)
        Me.txtpan.TabIndex = 10
        '
        'txtbranch
        '
        Me.txtbranch.Location = New System.Drawing.Point(598, 212)
        Me.txtbranch.Name = "txtbranch"
        Me.txtbranch.Size = New System.Drawing.Size(377, 26)
        Me.txtbranch.TabIndex = 12
        '
        'txtrouting
        '
        Me.txtrouting.Location = New System.Drawing.Point(599, 242)
        Me.txtrouting.Name = "txtrouting"
        Me.txtrouting.Size = New System.Drawing.Size(143, 26)
        Me.txtrouting.TabIndex = 15
        '
        'txtswift
        '
        Me.txtswift.Location = New System.Drawing.Point(829, 242)
        Me.txtswift.Name = "txtswift"
        Me.txtswift.Size = New System.Drawing.Size(146, 26)
        Me.txtswift.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(24, 321)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(430, 38)
        Me.Label3.TabIndex = 3
        '
        'CmdSave
        '
        Me.CmdSave.ImageOptions.Image = CType(resources.GetObject("CmdSave.ImageOptions.Image"), System.Drawing.Image)
        Me.CmdSave.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.CmdSave.Location = New System.Drawing.Point(458, 321)
        Me.CmdSave.Name = "CmdSave"
        Me.CmdSave.Size = New System.Drawing.Size(40, 38)
        Me.CmdSave.StyleController = Me.LayoutControl1
        Me.CmdSave.TabIndex = 19
        '
        'cmdCancel
        '
        Me.cmdCancel.ImageOptions.Image = CType(resources.GetObject("cmdCancel.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdCancel.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.cmdCancel.Location = New System.Drawing.Point(502, 321)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(40, 38)
        Me.cmdCancel.StyleController = Me.LayoutControl1
        Me.cmdCancel.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(546, 321)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(429, 38)
        Me.Label2.TabIndex = 2
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2, Me.LayoutControlGroup4, Me.LayoutControlGroup5, Me.LayoutControlItem22})
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(999, 596)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AppearanceGroup.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlGroup2.AppearanceGroup.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LayoutControlGroup2.AppearanceGroup.Options.UseFont = True
        Me.LayoutControlGroup2.AppearanceGroup.Options.UseForeColor = True
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem3, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem4, Me.LayoutControlItem7, Me.LayoutControlItem2, Me.LayoutControlItem18, Me.LayoutControlItem8})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(979, 158)
        Me.LayoutControlGroup2.Text = "Ledger Master"
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.txtledger
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(401, 25)
        Me.LayoutControlItem1.Text = "Ledger Name"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(80, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.txtadd
        Me.LayoutControlItem3.CustomizationFormText = "Name"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 25)
        Me.LayoutControlItem3.MaxSize = New System.Drawing.Size(0, 30)
        Me.LayoutControlItem3.MinSize = New System.Drawing.Size(124, 30)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(955, 30)
        Me.LayoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem3.Text = "Address"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(80, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.cmbcounty
        Me.LayoutControlItem5.CustomizationFormText = "Country"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 55)
        Me.LayoutControlItem5.MaxSize = New System.Drawing.Size(0, 30)
        Me.LayoutControlItem5.MinSize = New System.Drawing.Size(124, 30)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(311, 30)
        Me.LayoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem5.Text = "Country"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(80, 13)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.txtmobile
        Me.LayoutControlItem6.CustomizationFormText = "Name"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 85)
        Me.LayoutControlItem6.MaxSize = New System.Drawing.Size(0, 30)
        Me.LayoutControlItem6.MinSize = New System.Drawing.Size(124, 30)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(311, 30)
        Me.LayoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem6.Text = "Mobile"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(80, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.cmbstate
        Me.LayoutControlItem4.CustomizationFormText = "Country"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(311, 55)
        Me.LayoutControlItem4.MaxSize = New System.Drawing.Size(0, 30)
        Me.LayoutControlItem4.MinSize = New System.Drawing.Size(124, 30)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(328, 30)
        Me.LayoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem4.Text = "State"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(80, 13)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.txtphone
        Me.LayoutControlItem7.CustomizationFormText = "Name"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(311, 85)
        Me.LayoutControlItem7.MaxSize = New System.Drawing.Size(0, 30)
        Me.LayoutControlItem7.MinSize = New System.Drawing.Size(124, 30)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(328, 30)
        Me.LayoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem7.Text = "Phone"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(80, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.cmbgroup
        Me.LayoutControlItem2.Location = New System.Drawing.Point(401, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(554, 25)
        Me.LayoutControlItem2.Text = "Under Group"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(80, 13)
        '
        'LayoutControlItem18
        '
        Me.LayoutControlItem18.Control = Me.cmbcity
        Me.LayoutControlItem18.CustomizationFormText = "Country"
        Me.LayoutControlItem18.Location = New System.Drawing.Point(639, 55)
        Me.LayoutControlItem18.MaxSize = New System.Drawing.Size(0, 30)
        Me.LayoutControlItem18.MinSize = New System.Drawing.Size(124, 30)
        Me.LayoutControlItem18.Name = "LayoutControlItem18"
        Me.LayoutControlItem18.Size = New System.Drawing.Size(316, 30)
        Me.LayoutControlItem18.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem18.Text = "City"
        Me.LayoutControlItem18.TextSize = New System.Drawing.Size(80, 13)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.txtemail
        Me.LayoutControlItem8.CustomizationFormText = "Name"
        Me.LayoutControlItem8.Location = New System.Drawing.Point(639, 85)
        Me.LayoutControlItem8.MaxSize = New System.Drawing.Size(0, 30)
        Me.LayoutControlItem8.MinSize = New System.Drawing.Size(124, 30)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(316, 30)
        Me.LayoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem8.Text = "E-mail"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(80, 13)
        '
        'LayoutControlGroup4
        '
        Me.LayoutControlGroup4.CustomizationFormText = "LayoutControlGroup3"
        Me.LayoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem9, Me.LayoutControlItem11, Me.LayoutControlItem13, Me.LayoutControlItem14, Me.LayoutControlItem10, Me.LayoutControlItem12, Me.LayoutControlItem16, Me.LayoutControlItem15, Me.LayoutControlItem23, Me.LayoutControlItem24, Me.LayoutControlItem25})
        Me.LayoutControlGroup4.Location = New System.Drawing.Point(0, 158)
        Me.LayoutControlGroup4.Name = "LayoutControlGroup4"
        Me.LayoutControlGroup4.Size = New System.Drawing.Size(979, 139)
        Me.LayoutControlGroup4.Text = "LayoutControlGroup3"
        Me.LayoutControlGroup4.TextVisible = False
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.txtgst
        Me.LayoutControlItem9.CustomizationFormText = "Name"
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem9.MaxSize = New System.Drawing.Size(0, 30)
        Me.LayoutControlItem9.MinSize = New System.Drawing.Size(124, 30)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(491, 30)
        Me.LayoutControlItem9.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem9.Text = "GST"
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(80, 13)
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.txtbank
        Me.LayoutControlItem11.CustomizationFormText = "Name"
        Me.LayoutControlItem11.Location = New System.Drawing.Point(0, 30)
        Me.LayoutControlItem11.MaxSize = New System.Drawing.Size(0, 30)
        Me.LayoutControlItem11.MinSize = New System.Drawing.Size(124, 30)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(491, 30)
        Me.LayoutControlItem11.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem11.Text = "Bank"
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(80, 13)
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.txtacno
        Me.LayoutControlItem13.CustomizationFormText = "Name"
        Me.LayoutControlItem13.Location = New System.Drawing.Point(0, 60)
        Me.LayoutControlItem13.MaxSize = New System.Drawing.Size(0, 30)
        Me.LayoutControlItem13.MinSize = New System.Drawing.Size(124, 30)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(245, 30)
        Me.LayoutControlItem13.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem13.Text = "A/C No"
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(80, 13)
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.txtifsc
        Me.LayoutControlItem14.CustomizationFormText = "Name"
        Me.LayoutControlItem14.Location = New System.Drawing.Point(245, 60)
        Me.LayoutControlItem14.MaxSize = New System.Drawing.Size(0, 30)
        Me.LayoutControlItem14.MinSize = New System.Drawing.Size(124, 30)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(247, 30)
        Me.LayoutControlItem14.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem14.Text = "IFSC Code"
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(80, 13)
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.txtpan
        Me.LayoutControlItem10.CustomizationFormText = "Name"
        Me.LayoutControlItem10.Location = New System.Drawing.Point(491, 0)
        Me.LayoutControlItem10.MaxSize = New System.Drawing.Size(0, 30)
        Me.LayoutControlItem10.MinSize = New System.Drawing.Size(124, 30)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(464, 30)
        Me.LayoutControlItem10.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem10.Text = "PAN"
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(80, 13)
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.txtbranch
        Me.LayoutControlItem12.CustomizationFormText = "Name"
        Me.LayoutControlItem12.Location = New System.Drawing.Point(491, 30)
        Me.LayoutControlItem12.MaxSize = New System.Drawing.Size(0, 30)
        Me.LayoutControlItem12.MinSize = New System.Drawing.Size(124, 30)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(464, 30)
        Me.LayoutControlItem12.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem12.Text = "Branch"
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(80, 13)
        '
        'LayoutControlItem16
        '
        Me.LayoutControlItem16.Control = Me.txtrouting
        Me.LayoutControlItem16.CustomizationFormText = "Name"
        Me.LayoutControlItem16.Location = New System.Drawing.Point(492, 60)
        Me.LayoutControlItem16.MaxSize = New System.Drawing.Size(0, 30)
        Me.LayoutControlItem16.MinSize = New System.Drawing.Size(124, 30)
        Me.LayoutControlItem16.Name = "LayoutControlItem16"
        Me.LayoutControlItem16.Size = New System.Drawing.Size(230, 30)
        Me.LayoutControlItem16.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem16.Text = "Routing"
        Me.LayoutControlItem16.TextSize = New System.Drawing.Size(80, 13)
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.Control = Me.txtswift
        Me.LayoutControlItem15.CustomizationFormText = "Name"
        Me.LayoutControlItem15.Location = New System.Drawing.Point(722, 60)
        Me.LayoutControlItem15.MaxSize = New System.Drawing.Size(0, 30)
        Me.LayoutControlItem15.MinSize = New System.Drawing.Size(124, 30)
        Me.LayoutControlItem15.Name = "LayoutControlItem15"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(233, 30)
        Me.LayoutControlItem15.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem15.Text = "Swift"
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(80, 13)
        '
        'LayoutControlItem23
        '
        Me.LayoutControlItem23.Control = Me.txtopening
        Me.LayoutControlItem23.Location = New System.Drawing.Point(0, 90)
        Me.LayoutControlItem23.Name = "LayoutControlItem23"
        Me.LayoutControlItem23.Size = New System.Drawing.Size(245, 25)
        Me.LayoutControlItem23.Text = "Opening Balance"
        Me.LayoutControlItem23.TextSize = New System.Drawing.Size(80, 13)
        '
        'LayoutControlItem24
        '
        Me.LayoutControlItem24.Control = Me.Label1
        Me.LayoutControlItem24.Location = New System.Drawing.Point(492, 90)
        Me.LayoutControlItem24.Name = "LayoutControlItem24"
        Me.LayoutControlItem24.Size = New System.Drawing.Size(463, 25)
        Me.LayoutControlItem24.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem24.TextVisible = False
        '
        'LayoutControlItem25
        '
        Me.LayoutControlItem25.Control = Me.cmbdrcr
        Me.LayoutControlItem25.Location = New System.Drawing.Point(245, 90)
        Me.LayoutControlItem25.Name = "LayoutControlItem25"
        Me.LayoutControlItem25.Size = New System.Drawing.Size(247, 25)
        Me.LayoutControlItem25.Text = "Dr/Cr"
        Me.LayoutControlItem25.TextSize = New System.Drawing.Size(80, 13)
        '
        'LayoutControlGroup5
        '
        Me.LayoutControlGroup5.CustomizationFormText = "LayoutControlGroup4"
        Me.LayoutControlGroup5.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem21, Me.LayoutControlItem17, Me.LayoutControlItem19, Me.LayoutControlItem20})
        Me.LayoutControlGroup5.Location = New System.Drawing.Point(0, 297)
        Me.LayoutControlGroup5.Name = "LayoutControlGroup5"
        Me.LayoutControlGroup5.Size = New System.Drawing.Size(979, 66)
        Me.LayoutControlGroup5.Text = "LayoutControlGroup4"
        Me.LayoutControlGroup5.TextVisible = False
        '
        'LayoutControlItem21
        '
        Me.LayoutControlItem21.Control = Me.Label3
        Me.LayoutControlItem21.CustomizationFormText = "LayoutControlItem21"
        Me.LayoutControlItem21.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem21.MinSize = New System.Drawing.Size(24, 35)
        Me.LayoutControlItem21.Name = "LayoutControlItem21"
        Me.LayoutControlItem21.Size = New System.Drawing.Size(434, 42)
        Me.LayoutControlItem21.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem21.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem21.TextVisible = False
        '
        'LayoutControlItem17
        '
        Me.LayoutControlItem17.Control = Me.CmdSave
        Me.LayoutControlItem17.CustomizationFormText = "LayoutControlItem3"
        Me.LayoutControlItem17.Location = New System.Drawing.Point(434, 0)
        Me.LayoutControlItem17.Name = "LayoutControlItem17"
        Me.LayoutControlItem17.Size = New System.Drawing.Size(44, 42)
        Me.LayoutControlItem17.Text = "LayoutControlItem3"
        Me.LayoutControlItem17.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem17.TextVisible = False
        '
        'LayoutControlItem19
        '
        Me.LayoutControlItem19.Control = Me.cmdCancel
        Me.LayoutControlItem19.CustomizationFormText = "LayoutControlItem19"
        Me.LayoutControlItem19.Location = New System.Drawing.Point(478, 0)
        Me.LayoutControlItem19.Name = "LayoutControlItem19"
        Me.LayoutControlItem19.Size = New System.Drawing.Size(44, 42)
        Me.LayoutControlItem19.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem19.TextVisible = False
        '
        'LayoutControlItem20
        '
        Me.LayoutControlItem20.Control = Me.Label2
        Me.LayoutControlItem20.CustomizationFormText = "LayoutControlItem20"
        Me.LayoutControlItem20.Location = New System.Drawing.Point(522, 0)
        Me.LayoutControlItem20.Name = "LayoutControlItem20"
        Me.LayoutControlItem20.Size = New System.Drawing.Size(433, 42)
        Me.LayoutControlItem20.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem20.TextVisible = False
        '
        'LayoutControlItem22
        '
        Me.LayoutControlItem22.Control = Me.dg
        Me.LayoutControlItem22.Location = New System.Drawing.Point(0, 363)
        Me.LayoutControlItem22.Name = "LayoutControlItem22"
        Me.LayoutControlItem22.Size = New System.Drawing.Size(979, 213)
        Me.LayoutControlItem22.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem22.TextVisible = False
        '
        'FrmLedger
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(999, 596)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "FrmLedger"
        Me.Text = "Ledger"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents cmbgroup As ComboBox
    Friend WithEvents txtledger As TextBox
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtadd As TextBox
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cmbcounty As ComboBox
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cmbstate As ComboBox
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cmbcity As ComboBox
    Friend WithEvents LayoutControlItem18 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtmobile As TextBox
    Friend WithEvents txtphone As TextBox
    Friend WithEvents txtemail As TextBox
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents txtgst As TextBox
    Friend WithEvents txtbank As TextBox
    Friend WithEvents txtacno As TextBox
    Friend WithEvents txtifsc As TextBox
    Friend WithEvents txtpan As TextBox
    Friend WithEvents txtbranch As TextBox
    Friend WithEvents txtrouting As TextBox
    Friend WithEvents txtswift As TextBox
    Friend WithEvents LayoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Label3 As Label
    Friend WithEvents CmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label2 As Label
    Friend WithEvents LayoutControlGroup5 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem21 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem19 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem20 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents dg As DevExpress.XtraGrid.GridControl
    Friend WithEvents view As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem22 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cmbdrcr As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtopening As TextBox
    Friend WithEvents LayoutControlItem23 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem24 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem25 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Col_Ledger_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Col_LedgerName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Col_LUnderGroup As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Col_UnderGroupID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Col_CID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Col_LBID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Col_UID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Col_LAddress As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Col_LCountry As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Col_LState As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Col_LCity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Col_LMobile As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Col_LPhone As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Col_LEmail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Col_LGSTIN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Col_LPAN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Col_LBank As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Col_LBranch As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Col_LAcNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Col_LIFSC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Col_LRouting As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Col_LSwift As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Col_LOpeningBalance As DevExpress.XtraGrid.Columns.GridColumn
End Class
