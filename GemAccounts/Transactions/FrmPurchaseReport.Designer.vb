<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPurchaseReport
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
        Me.Col_DueDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Col_SerieStatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.dg = New DevExpress.XtraGrid.GridControl()
        Me.view = New DevExpress.XtraGrid.Views.Grid.GridView()
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
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn17 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn18 = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.view, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.Col_CompanyID.Visible = True
        Me.Col_CompanyID.VisibleIndex = 0
        '
        'Col_BranchID
        '
        Me.Col_BranchID.Caption = "Branch ID"
        Me.Col_BranchID.FieldName = "BranchID"
        Me.Col_BranchID.Name = "Col_BranchID"
        Me.Col_BranchID.Visible = True
        Me.Col_BranchID.VisibleIndex = 1
        '
        'Col_UserID
        '
        Me.Col_UserID.Caption = "User ID"
        Me.Col_UserID.FieldName = "UserID"
        Me.Col_UserID.Name = "Col_UserID"
        Me.Col_UserID.Visible = True
        Me.Col_UserID.VisibleIndex = 2
        '
        'Col_PurchaseDate
        '
        Me.Col_PurchaseDate.Caption = "Purchase Date"
        Me.Col_PurchaseDate.FieldName = "PurchaseDate"
        Me.Col_PurchaseDate.Name = "Col_PurchaseDate"
        Me.Col_PurchaseDate.Visible = True
        Me.Col_PurchaseDate.VisibleIndex = 3
        '
        'Col_VendorID
        '
        Me.Col_VendorID.Caption = "Vendor ID"
        Me.Col_VendorID.FieldName = "VendorID"
        Me.Col_VendorID.Name = "Col_VendorID"
        Me.Col_VendorID.Visible = True
        Me.Col_VendorID.VisibleIndex = 4
        '
        'Col_Terms
        '
        Me.Col_Terms.Caption = "Terms"
        Me.Col_Terms.FieldName = "Terms"
        Me.Col_Terms.Name = "Col_Terms"
        Me.Col_Terms.Visible = True
        Me.Col_Terms.VisibleIndex = 5
        '
        'Col_ItemType
        '
        Me.Col_ItemType.Caption = "Item Type"
        Me.Col_ItemType.FieldName = "ItemType"
        Me.Col_ItemType.Name = "Col_ItemType"
        Me.Col_ItemType.Visible = True
        Me.Col_ItemType.VisibleIndex = 6
        '
        'Col_Pcs
        '
        Me.Col_Pcs.Caption = "Pcs"
        Me.Col_Pcs.FieldName = "Pcs"
        Me.Col_Pcs.Name = "Col_Pcs"
        Me.Col_Pcs.Visible = True
        Me.Col_Pcs.VisibleIndex = 7
        '
        'Col_Carats
        '
        Me.Col_Carats.Caption = "Carats"
        Me.Col_Carats.FieldName = "Carats"
        Me.Col_Carats.Name = "Col_Carats"
        Me.Col_Carats.Visible = True
        Me.Col_Carats.VisibleIndex = 8
        '
        'Col_GrossTotalUSD
        '
        Me.Col_GrossTotalUSD.Caption = "Gross Total USD"
        Me.Col_GrossTotalUSD.FieldName = "GrossTotalUSD"
        Me.Col_GrossTotalUSD.Name = "Col_GrossTotalUSD"
        Me.Col_GrossTotalUSD.Visible = True
        Me.Col_GrossTotalUSD.VisibleIndex = 9
        '
        'Col_AddExpUSD
        '
        Me.Col_AddExpUSD.Caption = "Add Expense USD"
        Me.Col_AddExpUSD.FieldName = "AddExpUSD"
        Me.Col_AddExpUSD.Name = "Col_AddExpUSD"
        Me.Col_AddExpUSD.Visible = True
        Me.Col_AddExpUSD.VisibleIndex = 10
        '
        'Col_ExchangeRate
        '
        Me.Col_ExchangeRate.Caption = "Exchange Rate"
        Me.Col_ExchangeRate.FieldName = "ExchangeRate"
        Me.Col_ExchangeRate.Name = "Col_ExchangeRate"
        Me.Col_ExchangeRate.Visible = True
        Me.Col_ExchangeRate.VisibleIndex = 11
        '
        'Col_NetUSD
        '
        Me.Col_NetUSD.Caption = "Net USD"
        Me.Col_NetUSD.FieldName = "NetUSD"
        Me.Col_NetUSD.Name = "Col_NetUSD"
        Me.Col_NetUSD.Visible = True
        Me.Col_NetUSD.VisibleIndex = 12
        '
        'Col_NetINR
        '
        Me.Col_NetINR.Caption = "Net INR"
        Me.Col_NetINR.FieldName = "NetINR"
        Me.Col_NetINR.Name = "Col_NetINR"
        Me.Col_NetINR.Visible = True
        Me.Col_NetINR.VisibleIndex = 13
        '
        'Col_Remarks
        '
        Me.Col_Remarks.Caption = "Remarks"
        Me.Col_Remarks.FieldName = "Remarks"
        Me.Col_Remarks.Name = "Col_Remarks"
        Me.Col_Remarks.Visible = True
        Me.Col_Remarks.VisibleIndex = 14
        '
        'Col_DueDate
        '
        Me.Col_DueDate.Caption = "Due Date"
        Me.Col_DueDate.FieldName = "DueDate"
        Me.Col_DueDate.Name = "Col_DueDate"
        Me.Col_DueDate.Visible = True
        Me.Col_DueDate.VisibleIndex = 15
        '
        'Col_SerieStatus
        '
        Me.Col_SerieStatus.Caption = "SerieStatus"
        Me.Col_SerieStatus.FieldName = "SerieStatus"
        Me.Col_SerieStatus.Name = "Col_SerieStatus"
        Me.Col_SerieStatus.Visible = True
        Me.Col_SerieStatus.VisibleIndex = 16
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.dg)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(1004, 431)
        Me.SplitContainerControl1.SplitterPosition = 328
        Me.SplitContainerControl1.TabIndex = 0
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'dg
        '
        Me.dg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dg.Location = New System.Drawing.Point(0, 0)
        Me.dg.MainView = Me.view
        Me.dg.Name = "dg"
        Me.dg.Size = New System.Drawing.Size(671, 431)
        Me.dg.TabIndex = 15
        Me.dg.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.view})
        '
        'view
        '
        Me.view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.GridColumn10, Me.GridColumn11, Me.GridColumn12, Me.GridColumn13, Me.GridColumn14, Me.GridColumn15, Me.GridColumn16, Me.GridColumn17, Me.GridColumn18})
        Me.view.GridControl = Me.dg
        Me.view.Name = "view"
        Me.view.OptionsBehavior.Editable = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Purchase ID"
        Me.GridColumn1.FieldName = "PurchaseID"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Company ID"
        Me.GridColumn2.FieldName = "CompanyID"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 0
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Branch ID"
        Me.GridColumn3.FieldName = "BranchID"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 1
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "User ID"
        Me.GridColumn4.FieldName = "UserID"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 2
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Purchase Date"
        Me.GridColumn5.FieldName = "PurchaseDate"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 3
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Vendor ID"
        Me.GridColumn6.FieldName = "VendorID"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 4
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Terms"
        Me.GridColumn7.FieldName = "Terms"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 5
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Item Type"
        Me.GridColumn8.FieldName = "ItemType"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 6
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Pcs"
        Me.GridColumn9.FieldName = "Pcs"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 7
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Carats"
        Me.GridColumn10.FieldName = "Carats"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 8
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "Gross Total USD"
        Me.GridColumn11.FieldName = "GrossTotalUSD"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 9
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "Add Expense USD"
        Me.GridColumn12.FieldName = "AddExpUSD"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 10
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "Exchange Rate"
        Me.GridColumn13.FieldName = "ExchangeRate"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 11
        '
        'GridColumn14
        '
        Me.GridColumn14.Caption = "Net USD"
        Me.GridColumn14.FieldName = "NetUSD"
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.Visible = True
        Me.GridColumn14.VisibleIndex = 12
        '
        'GridColumn15
        '
        Me.GridColumn15.Caption = "Net INR"
        Me.GridColumn15.FieldName = "NetINR"
        Me.GridColumn15.Name = "GridColumn15"
        Me.GridColumn15.Visible = True
        Me.GridColumn15.VisibleIndex = 13
        '
        'GridColumn16
        '
        Me.GridColumn16.Caption = "Remarks"
        Me.GridColumn16.FieldName = "Remarks"
        Me.GridColumn16.Name = "GridColumn16"
        Me.GridColumn16.Visible = True
        Me.GridColumn16.VisibleIndex = 14
        '
        'GridColumn17
        '
        Me.GridColumn17.Caption = "Due Date"
        Me.GridColumn17.FieldName = "DueDate"
        Me.GridColumn17.Name = "GridColumn17"
        Me.GridColumn17.Visible = True
        Me.GridColumn17.VisibleIndex = 15
        '
        'GridColumn18
        '
        Me.GridColumn18.Caption = "SerieStatus"
        Me.GridColumn18.FieldName = "SerieStatus"
        Me.GridColumn18.Name = "GridColumn18"
        Me.GridColumn18.Visible = True
        Me.GridColumn18.VisibleIndex = 16
        '
        'FrmPurchaseReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1004, 431)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Name = "FrmPurchaseReport"
        Me.Text = "FrmPurchase"
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.view, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
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
    Friend WithEvents Col_DueDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Col_SerieStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents dg As DevExpress.XtraGrid.GridControl
    Friend WithEvents view As DevExpress.XtraGrid.Views.Grid.GridView
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
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn16 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn17 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn18 As DevExpress.XtraGrid.Columns.GridColumn
End Class
