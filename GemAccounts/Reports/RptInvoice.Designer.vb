<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class RptInvoice
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim XrSummary1 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RptInvoice))
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.GroupHeader2 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.customerTable = New DevExpress.XtraReports.UI.XRTable()
        Me.customerNameRow = New DevExpress.XtraReports.UI.XRTableRow()
        Me.billToLabel = New DevExpress.XtraReports.UI.XRTableCell()
        Me.customerName = New DevExpress.XtraReports.UI.XRTableCell()
        Me.customerContactNameRow = New DevExpress.XtraReports.UI.XRTableRow()
        Me.customerTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.customerContactName = New DevExpress.XtraReports.UI.XRTableCell()
        Me.customerAddressRow = New DevExpress.XtraReports.UI.XRTableRow()
        Me.customerTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.customerAddress = New DevExpress.XtraReports.UI.XRTableCell()
        Me.customerCityRow = New DevExpress.XtraReports.UI.XRTableRow()
        Me.customerTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.customerCity = New DevExpress.XtraReports.UI.XRTableCell()
        Me.customerCountryRow = New DevExpress.XtraReports.UI.XRTableRow()
        Me.customerTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.customerCountry = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.vendorTable = New DevExpress.XtraReports.UI.XRTable()
        Me.vendorNameRow = New DevExpress.XtraReports.UI.XRTableRow()
        Me.vendorName = New DevExpress.XtraReports.UI.XRTableCell()
        Me.vendorContactNameRow = New DevExpress.XtraReports.UI.XRTableRow()
        Me.vendorContactName = New DevExpress.XtraReports.UI.XRTableCell()
        Me.vendorAddressRow = New DevExpress.XtraReports.UI.XRTableRow()
        Me.vendorAddress = New DevExpress.XtraReports.UI.XRTableCell()
        Me.vendorCityRow = New DevExpress.XtraReports.UI.XRTableRow()
        Me.vendorCity = New DevExpress.XtraReports.UI.XRTableCell()
        Me.vendorCountryRow = New DevExpress.XtraReports.UI.XRTableRow()
        Me.vendorCountry = New DevExpress.XtraReports.UI.XRTableCell()
        Me.vendorWebsiteRow = New DevExpress.XtraReports.UI.XRTableRow()
        Me.vendorWebsite = New DevExpress.XtraReports.UI.XRTableCell()
        Me.vendorEmailRow = New DevExpress.XtraReports.UI.XRTableRow()
        Me.vendorEmail = New DevExpress.XtraReports.UI.XRTableCell()
        Me.vendorPhoneRow = New DevExpress.XtraReports.UI.XRTableRow()
        Me.vendorPhone = New DevExpress.XtraReports.UI.XRTableCell()
        Me.SubBand1 = New DevExpress.XtraReports.UI.SubBand()
        Me.xrLine1 = New DevExpress.XtraReports.UI.XRLine()
        Me.invoiceNumberTable = New DevExpress.XtraReports.UI.XRTable()
        Me.invoiceNumberRow = New DevExpress.XtraReports.UI.XRTableRow()
        Me.invoiceLabel = New DevExpress.XtraReports.UI.XRTableCell()
        Me.invoiceNumber = New DevExpress.XtraReports.UI.XRTableCell()
        Me.invoiceDatesTable = New DevExpress.XtraReports.UI.XRTable()
        Me.invoiceDateRow = New DevExpress.XtraReports.UI.XRTableRow()
        Me.invoiceDateCaption = New DevExpress.XtraReports.UI.XRTableCell()
        Me.invoiceDate = New DevExpress.XtraReports.UI.XRTableCell()
        Me.invoiceDueDateRow = New DevExpress.XtraReports.UI.XRTableRow()
        Me.invoiceDueDateCaption = New DevExpress.XtraReports.UI.XRTableCell()
        Me.invoiceDueDate = New DevExpress.XtraReports.UI.XRTableCell()
        Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.xrLine3 = New DevExpress.XtraReports.UI.XRLine()
        Me.summariesTable = New DevExpress.XtraReports.UI.XRTable()
        Me.totalRow = New DevExpress.XtraReports.UI.XRTableRow()
        Me.totalCaption = New DevExpress.XtraReports.UI.XRTableCell()
        Me.total = New DevExpress.XtraReports.UI.XRTableCell()
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLine2 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.baseControlStyle = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.TmpData1 = New GemAccounts.TmpData()
        Me.vendorLogo = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel()
        CType(Me.customerTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vendorTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.invoiceNumberTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.invoiceDatesTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.summariesTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TmpData1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel7, Me.XrLabel1, Me.XrLabel8, Me.XrLabel9, Me.XrLabel10})
        Me.Detail.HeightF = 46.0!
        Me.Detail.KeepTogether = True
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.StyleName = "baseControlStyle"
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel7
        '
        Me.XrLabel7.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel7.BorderColor = System.Drawing.Color.Black
        Me.XrLabel7.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrLabel7.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel7.BorderWidth = 1.0!
        Me.XrLabel7.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Qty]")})
        Me.XrLabel7.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.XrLabel7.ForeColor = System.Drawing.Color.Black
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(324.4098!, 0!)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 5, 0, 100.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(50.13614!, 23.0!)
        Me.XrLabel7.StylePriority.UseBackColor = False
        Me.XrLabel7.StylePriority.UseBorderColor = False
        Me.XrLabel7.StylePriority.UseBorderDashStyle = False
        Me.XrLabel7.StylePriority.UseBorders = False
        Me.XrLabel7.StylePriority.UseBorderWidth = False
        Me.XrLabel7.StylePriority.UseFont = False
        Me.XrLabel7.StylePriority.UseForeColor = False
        Me.XrLabel7.StylePriority.UsePadding = False
        Me.XrLabel7.StylePriority.UseTextAlignment = False
        Me.XrLabel7.Text = "$ 0.00"
        Me.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrLabel7.TextFormatString = "{0:n0}"
        '
        'XrLabel1
        '
        Me.XrLabel1.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel1.BorderColor = System.Drawing.Color.Black
        Me.XrLabel1.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrLabel1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel1.BorderWidth = 1.0!
        Me.XrLabel1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Carats]")})
        Me.XrLabel1.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.XrLabel1.ForeColor = System.Drawing.Color.Black
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(374.5459!, 0!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 5, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(76.94397!, 23.0!)
        Me.XrLabel1.StylePriority.UseBackColor = False
        Me.XrLabel1.StylePriority.UseBorderColor = False
        Me.XrLabel1.StylePriority.UseBorderDashStyle = False
        Me.XrLabel1.StylePriority.UseBorders = False
        Me.XrLabel1.StylePriority.UseBorderWidth = False
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseForeColor = False
        Me.XrLabel1.StylePriority.UsePadding = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "$ 0.00"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrLabel1.TextFormatString = "{0:n2}"
        '
        'XrLabel8
        '
        Me.XrLabel8.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel8.BorderColor = System.Drawing.Color.Black
        Me.XrLabel8.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrLabel8.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel8.BorderWidth = 1.0!
        Me.XrLabel8.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Shape] + ' ' + [Color] +  ' ' +[Clarity] + ' ' + [Flo]" & Global.Microsoft.VisualBasic.ChrW(10))})
        Me.XrLabel8.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.XrLabel8.ForeColor = System.Drawing.Color.Black
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(10.00093!, 0!)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 5, 0, 100.0!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(314.4088!, 23.0!)
        Me.XrLabel8.StylePriority.UseBackColor = False
        Me.XrLabel8.StylePriority.UseBorderColor = False
        Me.XrLabel8.StylePriority.UseBorderDashStyle = False
        Me.XrLabel8.StylePriority.UseBorders = False
        Me.XrLabel8.StylePriority.UseBorderWidth = False
        Me.XrLabel8.StylePriority.UseFont = False
        Me.XrLabel8.StylePriority.UseForeColor = False
        Me.XrLabel8.StylePriority.UsePadding = False
        Me.XrLabel8.StylePriority.UseTextAlignment = False
        Me.XrLabel8.Text = "ProductName"
        Me.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel9
        '
        Me.XrLabel9.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel9.BorderColor = System.Drawing.Color.Black
        Me.XrLabel9.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrLabel9.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel9.BorderWidth = 1.0!
        Me.XrLabel9.CanGrow = False
        Me.XrLabel9.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[PPCUSD]")})
        Me.XrLabel9.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.XrLabel9.ForeColor = System.Drawing.Color.Black
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(451.4899!, 0!)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 5, 0, 100.0!)
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(96.42487!, 23.0!)
        Me.XrLabel9.StylePriority.UseBackColor = False
        Me.XrLabel9.StylePriority.UseBorderColor = False
        Me.XrLabel9.StylePriority.UseBorderDashStyle = False
        Me.XrLabel9.StylePriority.UseBorders = False
        Me.XrLabel9.StylePriority.UseBorderWidth = False
        Me.XrLabel9.StylePriority.UseFont = False
        Me.XrLabel9.StylePriority.UseForeColor = False
        Me.XrLabel9.StylePriority.UsePadding = False
        Me.XrLabel9.StylePriority.UseTextAlignment = False
        Me.XrLabel9.Text = "$ 0.00"
        Me.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrLabel9.TextFormatString = "{0:$0.00}"
        Me.XrLabel9.WordWrap = False
        '
        'XrLabel10
        '
        Me.XrLabel10.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel10.BorderColor = System.Drawing.Color.Black
        Me.XrLabel10.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrLabel10.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel10.BorderWidth = 1.0!
        Me.XrLabel10.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[TotalUSD]")})
        Me.XrLabel10.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel10.ForeColor = System.Drawing.Color.Black
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(547.9147!, 0!)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 5, 0, 100.0!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(91.08606!, 23.0!)
        Me.XrLabel10.StylePriority.UseBackColor = False
        Me.XrLabel10.StylePriority.UseBorderColor = False
        Me.XrLabel10.StylePriority.UseBorderDashStyle = False
        Me.XrLabel10.StylePriority.UseBorders = False
        Me.XrLabel10.StylePriority.UseBorderWidth = False
        Me.XrLabel10.StylePriority.UseFont = False
        Me.XrLabel10.StylePriority.UseForeColor = False
        Me.XrLabel10.StylePriority.UsePadding = False
        Me.XrLabel10.StylePriority.UseTextAlignment = False
        Me.XrLabel10.Text = "$ 0.00"
        Me.XrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrLabel10.TextFormatString = "{0:$0.00}"
        '
        'TopMargin
        '
        Me.TopMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel11, Me.vendorLogo})
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.StylePriority.UseBackColor = False
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 75.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'GroupHeader2
        '
        Me.GroupHeader2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLine1, Me.invoiceDatesTable, Me.invoiceNumberTable, Me.customerTable, Me.vendorTable})
        Me.GroupHeader2.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("InvoiceNumber", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.GroupHeader2.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail
        Me.GroupHeader2.HeightF = 295.0!
        Me.GroupHeader2.Level = 1
        Me.GroupHeader2.Name = "GroupHeader2"
        Me.GroupHeader2.StyleName = "baseControlStyle"
        Me.GroupHeader2.StylePriority.UseBackColor = False
        Me.GroupHeader2.SubBands.AddRange(New DevExpress.XtraReports.UI.SubBand() {Me.SubBand1})
        '
        'customerTable
        '
        Me.customerTable.LocationFloat = New DevExpress.Utils.PointFloat(323.9576!, 95.00002!)
        Me.customerTable.Name = "customerTable"
        Me.customerTable.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.customerNameRow, Me.customerContactNameRow, Me.customerAddressRow, Me.customerCityRow, Me.customerCountryRow, Me.XrTableRow1, Me.XrTableRow2})
        Me.customerTable.SizeF = New System.Drawing.SizeF(315.042!, 175.0!)
        '
        'customerNameRow
        '
        Me.customerNameRow.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.billToLabel, Me.customerName})
        Me.customerNameRow.Name = "customerNameRow"
        Me.customerNameRow.Weight = 1.0R
        '
        'billToLabel
        '
        Me.billToLabel.CanShrink = True
        Me.billToLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.billToLabel.Name = "billToLabel"
        Me.billToLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 10, 0, 0, 100.0!)
        Me.billToLabel.StylePriority.UseFont = False
        Me.billToLabel.StylePriority.UsePadding = False
        Me.billToLabel.StylePriority.UseTextAlignment = False
        Me.billToLabel.Text = "BILL TO"
        Me.billToLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.billToLabel.Weight = 0.5027160580423663R
        '
        'customerName
        '
        Me.customerName.CanShrink = True
        Me.customerName.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Customer]")})
        Me.customerName.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.customerName.Name = "customerName"
        Me.customerName.StylePriority.UseFont = False
        Me.customerName.StylePriority.UsePadding = False
        Me.customerName.Text = "CustomerName"
        Me.customerName.Weight = 1.3644067255971617R
        '
        'customerContactNameRow
        '
        Me.customerContactNameRow.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.customerTableCell1, Me.customerContactName})
        Me.customerContactNameRow.Name = "customerContactNameRow"
        Me.customerContactNameRow.Weight = 1.0R
        '
        'customerTableCell1
        '
        Me.customerTableCell1.CanShrink = True
        Me.customerTableCell1.Name = "customerTableCell1"
        Me.customerTableCell1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 10, 0, 0, 100.0!)
        Me.customerTableCell1.StylePriority.UseFont = False
        Me.customerTableCell1.StylePriority.UsePadding = False
        Me.customerTableCell1.StylePriority.UseTextAlignment = False
        Me.customerTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.customerTableCell1.Weight = 0.5027160580423663R
        '
        'customerContactName
        '
        Me.customerContactName.CanShrink = True
        Me.customerContactName.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[C_Address]")})
        Me.customerContactName.Name = "customerContactName"
        Me.customerContactName.StylePriority.UseFont = False
        Me.customerContactName.StylePriority.UsePadding = False
        Me.customerContactName.Text = "CustomerContactName"
        Me.customerContactName.Weight = 1.3644067255971617R
        '
        'customerAddressRow
        '
        Me.customerAddressRow.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.customerTableCell2, Me.customerAddress})
        Me.customerAddressRow.Name = "customerAddressRow"
        Me.customerAddressRow.Weight = 1.0R
        '
        'customerTableCell2
        '
        Me.customerTableCell2.CanShrink = True
        Me.customerTableCell2.Name = "customerTableCell2"
        Me.customerTableCell2.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 10, 0, 0, 100.0!)
        Me.customerTableCell2.StylePriority.UsePadding = False
        Me.customerTableCell2.StylePriority.UseTextAlignment = False
        Me.customerTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.customerTableCell2.Weight = 0.5027160580423663R
        '
        'customerAddress
        '
        Me.customerAddress.CanShrink = True
        Me.customerAddress.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[C_City]")})
        Me.customerAddress.Name = "customerAddress"
        Me.customerAddress.Text = "CustomerAddress"
        Me.customerAddress.Weight = 1.3644067255971617R
        '
        'customerCityRow
        '
        Me.customerCityRow.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.customerTableCell3, Me.customerCity})
        Me.customerCityRow.Name = "customerCityRow"
        Me.customerCityRow.Weight = 1.0R
        '
        'customerTableCell3
        '
        Me.customerTableCell3.CanShrink = True
        Me.customerTableCell3.Name = "customerTableCell3"
        Me.customerTableCell3.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 10, 0, 0, 100.0!)
        Me.customerTableCell3.StylePriority.UsePadding = False
        Me.customerTableCell3.StylePriority.UseTextAlignment = False
        Me.customerTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.customerTableCell3.Weight = 0.5027160580423663R
        '
        'customerCity
        '
        Me.customerCity.CanShrink = True
        Me.customerCity.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[C_State]")})
        Me.customerCity.Name = "customerCity"
        Me.customerCity.Text = "CustomerCity"
        Me.customerCity.Weight = 1.3644067255971617R
        '
        'customerCountryRow
        '
        Me.customerCountryRow.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.customerTableCell4, Me.customerCountry})
        Me.customerCountryRow.Name = "customerCountryRow"
        Me.customerCountryRow.Weight = 1.0R
        '
        'customerTableCell4
        '
        Me.customerTableCell4.CanShrink = True
        Me.customerTableCell4.Name = "customerTableCell4"
        Me.customerTableCell4.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 10, 0, 0, 100.0!)
        Me.customerTableCell4.StylePriority.UsePadding = False
        Me.customerTableCell4.StylePriority.UseTextAlignment = False
        Me.customerTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.customerTableCell4.Weight = 0.5027160580423663R
        '
        'customerCountry
        '
        Me.customerCountry.CanShrink = True
        Me.customerCountry.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[C_Country]")})
        Me.customerCountry.Name = "customerCountry"
        Me.customerCountry.Text = "CustomerCountry"
        Me.customerCountry.Weight = 1.3644067255971617R
        '
        'XrTableRow1
        '
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell1, Me.XrTableCell2})
        Me.XrTableRow1.Name = "XrTableRow1"
        Me.XrTableRow1.Weight = 1.0R
        '
        'XrTableCell1
        '
        Me.XrTableCell1.Multiline = True
        Me.XrTableCell1.Name = "XrTableCell1"
        Me.XrTableCell1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 10, 0, 0, 100.0!)
        Me.XrTableCell1.StylePriority.UsePadding = False
        Me.XrTableCell1.StylePriority.UseTextAlignment = False
        Me.XrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell1.Weight = 0.5027160580423663R
        '
        'XrTableCell2
        '
        Me.XrTableCell2.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[C_Email]")})
        Me.XrTableCell2.Multiline = True
        Me.XrTableCell2.Name = "XrTableCell2"
        Me.XrTableCell2.Text = "XrTableCell2"
        Me.XrTableCell2.Weight = 1.3644067255971617R
        '
        'XrTableRow2
        '
        Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell3, Me.XrTableCell4})
        Me.XrTableRow2.Name = "XrTableRow2"
        Me.XrTableRow2.Weight = 1.0R
        '
        'XrTableCell3
        '
        Me.XrTableCell3.Multiline = True
        Me.XrTableCell3.Name = "XrTableCell3"
        Me.XrTableCell3.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 10, 0, 0, 100.0!)
        Me.XrTableCell3.StylePriority.UsePadding = False
        Me.XrTableCell3.StylePriority.UseTextAlignment = False
        Me.XrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell3.Weight = 0.5027160580423663R
        '
        'XrTableCell4
        '
        Me.XrTableCell4.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[C_Mobile]")})
        Me.XrTableCell4.Multiline = True
        Me.XrTableCell4.Name = "XrTableCell4"
        Me.XrTableCell4.Text = "XrTableCell4"
        Me.XrTableCell4.Weight = 1.3644067255971617R
        '
        'vendorTable
        '
        Me.vendorTable.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 95.0!)
        Me.vendorTable.Name = "vendorTable"
        Me.vendorTable.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.vendorNameRow, Me.vendorContactNameRow, Me.vendorAddressRow, Me.vendorCityRow, Me.vendorCountryRow, Me.vendorWebsiteRow, Me.vendorEmailRow, Me.vendorPhoneRow})
        Me.vendorTable.SizeF = New System.Drawing.SizeF(303.5417!, 200.0!)
        '
        'vendorNameRow
        '
        Me.vendorNameRow.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.vendorName})
        Me.vendorNameRow.Name = "vendorNameRow"
        Me.vendorNameRow.Weight = 1.0R
        '
        'vendorName
        '
        Me.vendorName.CanShrink = True
        Me.vendorName.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[cmp_name]")})
        Me.vendorName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.vendorName.Name = "vendorName"
        Me.vendorName.StylePriority.UseFont = False
        Me.vendorName.StylePriority.UsePadding = False
        Me.vendorName.Text = "VendorName"
        Me.vendorName.Weight = 1.0R
        '
        'vendorContactNameRow
        '
        Me.vendorContactNameRow.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.vendorContactName})
        Me.vendorContactNameRow.Name = "vendorContactNameRow"
        Me.vendorContactNameRow.Weight = 1.0R
        '
        'vendorContactName
        '
        Me.vendorContactName.CanShrink = True
        Me.vendorContactName.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[cmp_address]")})
        Me.vendorContactName.Name = "vendorContactName"
        Me.vendorContactName.StylePriority.UseFont = False
        Me.vendorContactName.StylePriority.UsePadding = False
        Me.vendorContactName.Text = "VendorContactName"
        Me.vendorContactName.Weight = 1.0R
        '
        'vendorAddressRow
        '
        Me.vendorAddressRow.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.vendorAddress})
        Me.vendorAddressRow.Name = "vendorAddressRow"
        Me.vendorAddressRow.Weight = 1.0R
        '
        'vendorAddress
        '
        Me.vendorAddress.CanShrink = True
        Me.vendorAddress.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[cmp_city]")})
        Me.vendorAddress.Name = "vendorAddress"
        Me.vendorAddress.StylePriority.UseFont = False
        Me.vendorAddress.Text = "VendorAddress"
        Me.vendorAddress.Weight = 1.0R
        '
        'vendorCityRow
        '
        Me.vendorCityRow.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.vendorCity})
        Me.vendorCityRow.Name = "vendorCityRow"
        Me.vendorCityRow.Weight = 1.0R
        '
        'vendorCity
        '
        Me.vendorCity.CanShrink = True
        Me.vendorCity.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[cmp_state]")})
        Me.vendorCity.Name = "vendorCity"
        Me.vendorCity.StylePriority.UseFont = False
        Me.vendorCity.Text = "VendorCity"
        Me.vendorCity.Weight = 1.0R
        '
        'vendorCountryRow
        '
        Me.vendorCountryRow.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.vendorCountry})
        Me.vendorCountryRow.Name = "vendorCountryRow"
        Me.vendorCountryRow.Weight = 1.0R
        '
        'vendorCountry
        '
        Me.vendorCountry.CanShrink = True
        Me.vendorCountry.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[cmp_country]")})
        Me.vendorCountry.Name = "vendorCountry"
        Me.vendorCountry.StylePriority.UseFont = False
        Me.vendorCountry.Text = "VendorCountry"
        Me.vendorCountry.Weight = 1.0R
        '
        'vendorWebsiteRow
        '
        Me.vendorWebsiteRow.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.vendorWebsite})
        Me.vendorWebsiteRow.Name = "vendorWebsiteRow"
        Me.vendorWebsiteRow.Weight = 1.0R
        '
        'vendorWebsite
        '
        Me.vendorWebsite.CanShrink = True
        Me.vendorWebsite.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[cmp_mobile]")})
        Me.vendorWebsite.Name = "vendorWebsite"
        Me.vendorWebsite.StylePriority.UseFont = False
        Me.vendorWebsite.Text = "VendorWebsite"
        Me.vendorWebsite.Weight = 1.0R
        '
        'vendorEmailRow
        '
        Me.vendorEmailRow.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.vendorEmail})
        Me.vendorEmailRow.Name = "vendorEmailRow"
        Me.vendorEmailRow.Weight = 1.0R
        '
        'vendorEmail
        '
        Me.vendorEmail.CanShrink = True
        Me.vendorEmail.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[cmp_email]")})
        Me.vendorEmail.Name = "vendorEmail"
        Me.vendorEmail.StylePriority.UseFont = False
        Me.vendorEmail.Text = "VendorEmail"
        Me.vendorEmail.Weight = 1.0R
        '
        'vendorPhoneRow
        '
        Me.vendorPhoneRow.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.vendorPhone})
        Me.vendorPhoneRow.Name = "vendorPhoneRow"
        Me.vendorPhoneRow.Weight = 1.0R
        '
        'vendorPhone
        '
        Me.vendorPhone.CanShrink = True
        Me.vendorPhone.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[cmp_gst]")})
        Me.vendorPhone.Name = "vendorPhone"
        Me.vendorPhone.StylePriority.UseFont = False
        Me.vendorPhone.Text = "VendorPhone"
        Me.vendorPhone.Weight = 1.0R
        '
        'SubBand1
        '
        Me.SubBand1.HeightF = 90.0!
        Me.SubBand1.KeepTogether = True
        Me.SubBand1.Name = "SubBand1"
        '
        'xrLine1
        '
        Me.xrLine1.ForeColor = System.Drawing.Color.Gray
        Me.xrLine1.LocationFloat = New DevExpress.Utils.PointFloat(9.999339!, 83.00002!)
        Me.xrLine1.Name = "xrLine1"
        Me.xrLine1.SizeF = New System.Drawing.SizeF(628.9996!, 10.0!)
        Me.xrLine1.StylePriority.UseForeColor = False
        '
        'invoiceNumberTable
        '
        Me.invoiceNumberTable.LocationFloat = New DevExpress.Utils.PointFloat(10.00093!, 10.00001!)
        Me.invoiceNumberTable.Name = "invoiceNumberTable"
        Me.invoiceNumberTable.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.invoiceNumberRow})
        Me.invoiceNumberTable.SizeF = New System.Drawing.SizeF(303.5414!, 68.99999!)
        Me.invoiceNumberTable.StylePriority.UseTextAlignment = False
        Me.invoiceNumberTable.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'invoiceNumberRow
        '
        Me.invoiceNumberRow.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.invoiceLabel, Me.invoiceNumber})
        Me.invoiceNumberRow.Name = "invoiceNumberRow"
        Me.invoiceNumberRow.Weight = 1.0R
        '
        'invoiceLabel
        '
        Me.invoiceLabel.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.invoiceLabel.ForeColor = System.Drawing.Color.RoyalBlue
        Me.invoiceLabel.Name = "invoiceLabel"
        Me.invoiceLabel.StylePriority.UseFont = False
        Me.invoiceLabel.StylePriority.UseForeColor = False
        Me.invoiceLabel.StylePriority.UseTextAlignment = False
        Me.invoiceLabel.Text = "INVOICE"
        Me.invoiceLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.invoiceLabel.Weight = 0.6867821939207055R
        '
        'invoiceNumber
        '
        Me.invoiceNumber.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[SalesMasterID]")})
        Me.invoiceNumber.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.invoiceNumber.ForeColor = System.Drawing.Color.RoyalBlue
        Me.invoiceNumber.Name = "invoiceNumber"
        Me.invoiceNumber.StylePriority.UseFont = False
        Me.invoiceNumber.StylePriority.UseForeColor = False
        Me.invoiceNumber.StylePriority.UseTextAlignment = False
        Me.invoiceNumber.Text = "#000001"
        Me.invoiceNumber.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.invoiceNumber.TextFormatString = "#{0}"
        Me.invoiceNumber.Weight = 1.2494489388406871R
        '
        'invoiceDatesTable
        '
        Me.invoiceDatesTable.LocationFloat = New DevExpress.Utils.PointFloat(323.9576!, 23.0!)
        Me.invoiceDatesTable.Name = "invoiceDatesTable"
        Me.invoiceDatesTable.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.invoiceDateRow, Me.invoiceDueDateRow})
        Me.invoiceDatesTable.SizeF = New System.Drawing.SizeF(315.0421!, 46.0!)
        '
        'invoiceDateRow
        '
        Me.invoiceDateRow.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.invoiceDateCaption, Me.invoiceDate})
        Me.invoiceDateRow.Name = "invoiceDateRow"
        Me.invoiceDateRow.Weight = 0.92R
        '
        'invoiceDateCaption
        '
        Me.invoiceDateCaption.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.invoiceDateCaption.ForeColor = System.Drawing.Color.RoyalBlue
        Me.invoiceDateCaption.Name = "invoiceDateCaption"
        Me.invoiceDateCaption.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 10, 0, 0, 100.0!)
        Me.invoiceDateCaption.StylePriority.UseFont = False
        Me.invoiceDateCaption.StylePriority.UseForeColor = False
        Me.invoiceDateCaption.StylePriority.UsePadding = False
        Me.invoiceDateCaption.StylePriority.UseTextAlignment = False
        Me.invoiceDateCaption.Text = "INVOICE DATE"
        Me.invoiceDateCaption.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.invoiceDateCaption.Weight = 0.67534864661118454R
        '
        'invoiceDate
        '
        Me.invoiceDate.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[SaleDate]")})
        Me.invoiceDate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.invoiceDate.ForeColor = System.Drawing.Color.RoyalBlue
        Me.invoiceDate.Name = "invoiceDate"
        Me.invoiceDate.StylePriority.UseFont = False
        Me.invoiceDate.StylePriority.UseForeColor = False
        Me.invoiceDate.Text = "InvoiceDate"
        Me.invoiceDate.TextFormatString = "{0:d MMMM, yyyy}"
        Me.invoiceDate.Weight = 1.1892418625891656R
        '
        'invoiceDueDateRow
        '
        Me.invoiceDueDateRow.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.invoiceDueDateCaption, Me.invoiceDueDate})
        Me.invoiceDueDateRow.Name = "invoiceDueDateRow"
        Me.invoiceDueDateRow.Weight = 0.91999999999999993R
        '
        'invoiceDueDateCaption
        '
        Me.invoiceDueDateCaption.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.invoiceDueDateCaption.ForeColor = System.Drawing.Color.RoyalBlue
        Me.invoiceDueDateCaption.Name = "invoiceDueDateCaption"
        Me.invoiceDueDateCaption.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 10, 0, 0, 100.0!)
        Me.invoiceDueDateCaption.StylePriority.UseFont = False
        Me.invoiceDueDateCaption.StylePriority.UseForeColor = False
        Me.invoiceDueDateCaption.StylePriority.UsePadding = False
        Me.invoiceDueDateCaption.StylePriority.UseTextAlignment = False
        Me.invoiceDueDateCaption.Text = "DUE DATE"
        Me.invoiceDueDateCaption.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.invoiceDueDateCaption.Weight = 0.67534864661118454R
        '
        'invoiceDueDate
        '
        Me.invoiceDueDate.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DueDate]")})
        Me.invoiceDueDate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.invoiceDueDate.ForeColor = System.Drawing.Color.RoyalBlue
        Me.invoiceDueDate.Name = "invoiceDueDate"
        Me.invoiceDueDate.StylePriority.UseFont = False
        Me.invoiceDueDate.StylePriority.UseForeColor = False
        Me.invoiceDueDate.Text = "InvoiceDueDate"
        Me.invoiceDueDate.TextFormatString = "{0:d MMMM, yyyy}"
        Me.invoiceDueDate.Weight = 1.1892418625891656R
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel12, Me.xrLine3, Me.summariesTable})
        Me.GroupFooter1.GroupUnion = DevExpress.XtraReports.UI.GroupFooterUnion.WithLastDetail
        Me.GroupFooter1.HeightF = 43.00004!
        Me.GroupFooter1.KeepTogether = True
        Me.GroupFooter1.Name = "GroupFooter1"
        Me.GroupFooter1.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBandExceptLastEntry
        Me.GroupFooter1.StyleName = "baseControlStyle"
        '
        'xrLine3
        '
        Me.xrLine3.ForeColor = System.Drawing.Color.Gray
        Me.xrLine3.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.xrLine3.LocationFloat = New DevExpress.Utils.PointFloat(10.00026!, 0!)
        Me.xrLine3.Name = "xrLine3"
        Me.xrLine3.SizeF = New System.Drawing.SizeF(628.9996!, 10.0!)
        Me.xrLine3.StylePriority.UseForeColor = False
        '
        'summariesTable
        '
        Me.summariesTable.ForeColor = System.Drawing.Color.Black
        Me.summariesTable.LocationFloat = New DevExpress.Utils.PointFloat(323.96!, 10.00004!)
        Me.summariesTable.Name = "summariesTable"
        Me.summariesTable.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.totalRow})
        Me.summariesTable.SizeF = New System.Drawing.SizeF(315.0398!, 33.0!)
        Me.summariesTable.StylePriority.UseForeColor = False
        '
        'totalRow
        '
        Me.totalRow.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.totalCaption, Me.total})
        Me.totalRow.Name = "totalRow"
        Me.totalRow.Weight = 1.3199999999999998R
        '
        'totalCaption
        '
        Me.totalCaption.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.totalCaption.ForeColor = System.Drawing.Color.RoyalBlue
        Me.totalCaption.Name = "totalCaption"
        Me.totalCaption.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 5, 100.0!)
        Me.totalCaption.StylePriority.UseFont = False
        Me.totalCaption.StylePriority.UseForeColor = False
        Me.totalCaption.StylePriority.UsePadding = False
        Me.totalCaption.StylePriority.UseTextAlignment = False
        Me.totalCaption.Text = "TOTAL"
        Me.totalCaption.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.totalCaption.Weight = 1.5060970566200949R
        '
        'total
        '
        Me.total.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Sum([TotalUSD])")})
        Me.total.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.total.ForeColor = System.Drawing.Color.RoyalBlue
        Me.total.Name = "total"
        Me.total.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 5, 100.0!)
        Me.total.StylePriority.UseFont = False
        Me.total.StylePriority.UseForeColor = False
        Me.total.StylePriority.UsePadding = False
        Me.total.StylePriority.UseTextAlignment = False
        XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.total.Summary = XrSummary1
        Me.total.Text = "$ 0.00"
        Me.total.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.total.TextFormatString = "{0:$0.00}"
        Me.total.Weight = 0.80783965162513149R
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel6, Me.XrLabel5, Me.xrLine2, Me.XrLabel2, Me.XrLabel3, Me.XrLabel4})
        Me.GroupHeader1.HeightF = 35.0!
        Me.GroupHeader1.Name = "GroupHeader1"
        Me.GroupHeader1.RepeatEveryPage = True
        Me.GroupHeader1.StyleName = "baseControlStyle"
        '
        'XrLabel6
        '
        Me.XrLabel6.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel6.BorderColor = System.Drawing.Color.Black
        Me.XrLabel6.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrLabel6.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel6.BorderWidth = 1.0!
        Me.XrLabel6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel6.ForeColor = System.Drawing.Color.Black
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(374.5459!, 0!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 5, 0, 100.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(76.94397!, 25.0!)
        Me.XrLabel6.StylePriority.UseBackColor = False
        Me.XrLabel6.StylePriority.UseBorderColor = False
        Me.XrLabel6.StylePriority.UseBorderDashStyle = False
        Me.XrLabel6.StylePriority.UseBorders = False
        Me.XrLabel6.StylePriority.UseBorderWidth = False
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.StylePriority.UseForeColor = False
        Me.XrLabel6.StylePriority.UsePadding = False
        Me.XrLabel6.StylePriority.UseTextAlignment = False
        Me.XrLabel6.Text = "CTS"
        Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel5
        '
        Me.XrLabel5.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel5.BorderColor = System.Drawing.Color.Black
        Me.XrLabel5.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrLabel5.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel5.BorderWidth = 1.0!
        Me.XrLabel5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel5.ForeColor = System.Drawing.Color.Black
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(324.4098!, 0!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 5, 0, 100.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(50.13614!, 25.0!)
        Me.XrLabel5.StylePriority.UseBackColor = False
        Me.XrLabel5.StylePriority.UseBorderColor = False
        Me.XrLabel5.StylePriority.UseBorderDashStyle = False
        Me.XrLabel5.StylePriority.UseBorders = False
        Me.XrLabel5.StylePriority.UseBorderWidth = False
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.StylePriority.UseForeColor = False
        Me.XrLabel5.StylePriority.UsePadding = False
        Me.XrLabel5.StylePriority.UseTextAlignment = False
        Me.XrLabel5.Text = "QTY"
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'xrLine2
        '
        Me.xrLine2.ForeColor = System.Drawing.Color.Gray
        Me.xrLine2.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.xrLine2.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 25.0!)
        Me.xrLine2.Name = "xrLine2"
        Me.xrLine2.SizeF = New System.Drawing.SizeF(628.9989!, 10.0!)
        Me.xrLine2.StylePriority.UseForeColor = False
        '
        'XrLabel2
        '
        Me.XrLabel2.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel2.BorderColor = System.Drawing.Color.Black
        Me.XrLabel2.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrLabel2.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel2.BorderWidth = 1.0!
        Me.XrLabel2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel2.ForeColor = System.Drawing.Color.Black
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 0!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 5, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(314.4098!, 25.0!)
        Me.XrLabel2.StylePriority.UseBackColor = False
        Me.XrLabel2.StylePriority.UseBorderColor = False
        Me.XrLabel2.StylePriority.UseBorderDashStyle = False
        Me.XrLabel2.StylePriority.UseBorders = False
        Me.XrLabel2.StylePriority.UseBorderWidth = False
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UseForeColor = False
        Me.XrLabel2.StylePriority.UsePadding = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.Text = "DESCRIPTION"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel3
        '
        Me.XrLabel3.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel3.BorderColor = System.Drawing.Color.Black
        Me.XrLabel3.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrLabel3.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel3.BorderWidth = 1.0!
        Me.XrLabel3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel3.ForeColor = System.Drawing.Color.Black
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(451.4899!, 0!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 5, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(96.42487!, 25.0!)
        Me.XrLabel3.StylePriority.UseBackColor = False
        Me.XrLabel3.StylePriority.UseBorderColor = False
        Me.XrLabel3.StylePriority.UseBorderDashStyle = False
        Me.XrLabel3.StylePriority.UseBorders = False
        Me.XrLabel3.StylePriority.UseBorderWidth = False
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.StylePriority.UseForeColor = False
        Me.XrLabel3.StylePriority.UsePadding = False
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        Me.XrLabel3.Text = "PRICE"
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel4
        '
        Me.XrLabel4.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel4.BorderColor = System.Drawing.Color.Black
        Me.XrLabel4.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrLabel4.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel4.BorderWidth = 1.0!
        Me.XrLabel4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel4.ForeColor = System.Drawing.Color.Black
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(547.9147!, 0!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 5, 0, 100.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(91.08484!, 25.0!)
        Me.XrLabel4.StylePriority.UseBackColor = False
        Me.XrLabel4.StylePriority.UseBorderColor = False
        Me.XrLabel4.StylePriority.UseBorderDashStyle = False
        Me.XrLabel4.StylePriority.UseBorders = False
        Me.XrLabel4.StylePriority.UseBorderWidth = False
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.StylePriority.UseForeColor = False
        Me.XrLabel4.StylePriority.UsePadding = False
        Me.XrLabel4.StylePriority.UseTextAlignment = False
        Me.XrLabel4.Text = "TOTAL"
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'baseControlStyle
        '
        Me.baseControlStyle.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.baseControlStyle.Name = "baseControlStyle"
        Me.baseControlStyle.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        '
        'TmpData1
        '
        Me.TmpData1.DataSetName = "TmpData"
        Me.TmpData1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'vendorLogo
        '
        Me.vendorLogo.ImageAlignment = DevExpress.XtraPrinting.ImageAlignment.TopLeft
        Me.vendorLogo.ImageSource = New DevExpress.XtraPrinting.Drawing.ImageSource("img", resources.GetString("vendorLogo.ImageSource"))
        Me.vendorLogo.LocationFloat = New DevExpress.Utils.PointFloat(22.50093!, 10.00001!)
        Me.vendorLogo.Name = "vendorLogo"
        Me.vendorLogo.SizeF = New System.Drawing.SizeF(158.7098!, 75.0!)
        Me.vendorLogo.Sizing = DevExpress.XtraPrinting.ImageSizeMode.Squeeze
        Me.vendorLogo.StylePriority.UseBorderColor = False
        Me.vendorLogo.StylePriority.UseBorders = False
        Me.vendorLogo.StylePriority.UsePadding = False
        '
        'XrLabel11
        '
        Me.XrLabel11.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel11.BorderColor = System.Drawing.Color.Black
        Me.XrLabel11.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrLabel11.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel11.BorderWidth = 1.0!
        Me.XrLabel11.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[cmp_name]")})
        Me.XrLabel11.Font = New System.Drawing.Font("Segoe UI Black", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel11.ForeColor = System.Drawing.Color.Black
        Me.XrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(317.6955!, 10.00001!)
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrLabel11.SizeF = New System.Drawing.SizeF(321.3034!, 75.0!)
        Me.XrLabel11.StylePriority.UseBackColor = False
        Me.XrLabel11.StylePriority.UseBorderColor = False
        Me.XrLabel11.StylePriority.UseBorderDashStyle = False
        Me.XrLabel11.StylePriority.UseBorders = False
        Me.XrLabel11.StylePriority.UseBorderWidth = False
        Me.XrLabel11.StylePriority.UseFont = False
        Me.XrLabel11.StylePriority.UseForeColor = False
        Me.XrLabel11.StylePriority.UsePadding = False
        Me.XrLabel11.StylePriority.UseTextAlignment = False
        Me.XrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel12
        '
        Me.XrLabel12.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel12.BorderColor = System.Drawing.Color.Black
        Me.XrLabel12.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrLabel12.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel12.BorderWidth = 1.0!
        Me.XrLabel12.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[TotalUSD]")})
        Me.XrLabel12.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel12.ForeColor = System.Drawing.Color.RoyalBlue
        Me.XrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(26.58118!, 10.00004!)
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 5, 0, 100.0!)
        Me.XrLabel12.SizeF = New System.Drawing.SizeF(91.08606!, 23.0!)
        Me.XrLabel12.StylePriority.UseBackColor = False
        Me.XrLabel12.StylePriority.UseBorderColor = False
        Me.XrLabel12.StylePriority.UseBorderDashStyle = False
        Me.XrLabel12.StylePriority.UseBorders = False
        Me.XrLabel12.StylePriority.UseBorderWidth = False
        Me.XrLabel12.StylePriority.UseFont = False
        Me.XrLabel12.StylePriority.UseForeColor = False
        Me.XrLabel12.StylePriority.UsePadding = False
        Me.XrLabel12.StylePriority.UseTextAlignment = False
        Me.XrLabel12.Text = "$ 0.00"
        Me.XrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrLabel12.TextFormatString = "{0:$0.00}"
        '
        'XtraReport1
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.GroupHeader2, Me.GroupFooter1, Me.GroupHeader1})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.TmpData1})
        Me.DataMember = "TblPrintInvoice"
        Me.DataSource = Me.TmpData1
        Me.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Margins = New System.Drawing.Printing.Margins(101, 100, 100, 75)
        Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.baseControlStyle})
        Me.Version = "20.1"
        CType(Me.customerTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vendorTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.invoiceNumberTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.invoiceDatesTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.summariesTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TmpData1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents GroupHeader2 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents customerTable As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents customerNameRow As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents billToLabel As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents customerName As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents customerContactNameRow As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents customerTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents customerContactName As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents customerAddressRow As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents customerTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents customerAddress As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents customerCityRow As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents customerTableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents customerCity As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents customerCountryRow As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents customerTableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents customerCountry As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents vendorTable As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents vendorNameRow As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents vendorName As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents vendorContactNameRow As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents vendorContactName As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents vendorAddressRow As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents vendorAddress As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents vendorCityRow As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents vendorCity As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents vendorCountryRow As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents vendorCountry As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents vendorWebsiteRow As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents vendorWebsite As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents vendorEmailRow As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents vendorEmail As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents vendorPhoneRow As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents vendorPhone As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents SubBand1 As DevExpress.XtraReports.UI.SubBand
    Friend WithEvents xrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents invoiceNumberTable As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents invoiceNumberRow As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents invoiceLabel As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents invoiceNumber As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents invoiceDatesTable As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents invoiceDateRow As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents invoiceDateCaption As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents invoiceDate As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents invoiceDueDateRow As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents invoiceDueDateCaption As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents invoiceDueDate As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents xrLine3 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents summariesTable As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents totalRow As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents totalCaption As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents total As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents xrLine2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents baseControlStyle As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents TmpData1 As TmpData
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents vendorLogo As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
End Class
