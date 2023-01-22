Imports System.Data
Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports GemAccounts.GLOBAL_VARIABLES
Imports GemAccounts.MasterConnection
Public Class BAL_Transactions
    Dim GV = New GLOBAL_VARIABLES
    Public Sub PurchaseCRUD(ByVal CTRL As DevExpress.XtraGrid.GridControl, ByVal diacmd As Integer, ByVal PurchaseID As Integer, ByVal CompanyID As Integer, ByVal BranchID As Integer, ByVal UserID As Integer, ByVal Terms As Integer, ByVal ItemType As Integer, ByVal pcs As Integer, ByVal Carats As Double, ByVal GrossTotalUSD As Double, ByVal AddExpUSD As Double, ByVal TranscationDate As Date, ByVal Remarks As String, ByVal DebitLedger As Integer, ByVal CreditLedger As Integer, ByVal AmountINR As Double, ByVal ExRate As Double, ByVal AmountUSD As Double, ByVal TID As Integer, ByVal Attachment As String)
        Try
            If Attachment = Nothing Then Attachment = ""
            Dim CMD As New SqlCommand
            CMD = New SqlCommand("Puchase_Procedure", VarCon.Connection)
            CMD.CommandType = CommandType.StoredProcedure
            CMD.Parameters.AddWithValue("@CMD", diacmd)
            CMD.Parameters.AddWithValue("@PurchaseID", PurchaseID)
            CMD.Parameters.AddWithValue("@CompanyID", CompanyID)
            CMD.Parameters.AddWithValue("@BranchID", BranchID)
            CMD.Parameters.AddWithValue("@UserID", UserID)
            CMD.Parameters.AddWithValue("@Terms", Terms)
            CMD.Parameters.AddWithValue("@ItemType", ItemType)
            CMD.Parameters.AddWithValue("@Pcs", pcs)
            CMD.Parameters.AddWithValue("@Carats", Carats)
            CMD.Parameters.AddWithValue("@GrossTotalUSD", GrossTotalUSD)
            CMD.Parameters.AddWithValue("@AddExpUSD", AddExpUSD)
            CMD.Parameters.AddWithValue("@TransactionDate", TranscationDate)
            CMD.Parameters.AddWithValue("@Remarks", Remarks)
            CMD.Parameters.AddWithValue("@DebitLedger", DebitLedger)
            CMD.Parameters.AddWithValue("@CreditLedger", CreditLedger)
            CMD.Parameters.AddWithValue("@AmountINR", AmountINR)
            CMD.Parameters.AddWithValue("@ExRate", ExRate)
            CMD.Parameters.AddWithValue("@AmountUSD", AmountUSD)
            CMD.Parameters.AddWithValue("@TID", TID)
            CMD.Parameters.AddWithValue("@Attachment", Attachment)
            If diacmd = 3 Then
                Dim DT As New DataTable
                ADP = New SqlDataAdapter(CMD)
                ADP.Fill(DT)
                CTRL.DataSource = DT
            Else
                CMD.ExecuteNonQuery()
            End If
            VarCon.CloseConnection()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Public Shared Sub PaymentCRUD(CTRL As DevExpress.XtraGrid.GridControl, diacmd As Integer, PaymentID As Integer, PaymentDate As Date, Bank As Integer, Vendor As Integer, PurchaseID As Integer, PayUSD As Double, ExRate As Double, PayINR As Double, ExpID As Integer, ExUSD As Double, ExINR As Double, UserID As Integer, ByVal Attachment As String)
        Try
            Dim CMD As New SqlCommand
            CMD = New SqlCommand("PaymentProcedure", VarCon.Connection)
            CMD.CommandType = CommandType.StoredProcedure
            CMD.Parameters.AddWithValue("@CMD", diacmd)
            CMD.Parameters.AddWithValue("@PaymentID", PaymentID)
            CMD.Parameters.AddWithValue("@PaymentDate", PaymentDate)
            CMD.Parameters.AddWithValue("@Bank", Bank)
            CMD.Parameters.AddWithValue("@Vendor", Vendor)
            CMD.Parameters.AddWithValue("@PurchaseID", PurchaseID)
            CMD.Parameters.AddWithValue("@PayUSD", PayUSD)
            CMD.Parameters.AddWithValue("@ExRate", ExRate)
            CMD.Parameters.AddWithValue("@PayINR", PayINR)
            CMD.Parameters.AddWithValue("@ExpID", ExpID)
            CMD.Parameters.AddWithValue("@ExUSD", ExUSD)
            CMD.Parameters.AddWithValue("@ExINR", ExINR)
            CMD.Parameters.AddWithValue("@UserID", GLOBAL_VARIABLES.UID)
            CMD.Parameters.AddWithValue("@Attachment", Attachment)
            If diacmd = 3 Then
                Dim DT As New DataTable
                ADP = New SqlDataAdapter(CMD)
                ADP.Fill(DT)
                CTRL.DataSource = DT
            Else
                CMD.ExecuteNonQuery()
            End If
            VarCon.CloseConnection()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Public Shared Sub ReceiptCRUD(CTRL As DevExpress.XtraGrid.GridControl, diacmd As Integer, ReceiptID As Integer, ReceiptDate As Date, Bank As Integer, Customer As Integer, SalesMasterID As Integer, RecUSD As Double, ExRate As Double, RecINR As Double)
        Try
            Dim CMD As New SqlCommand
            CMD = New SqlCommand("ReceiptProcedure", VarCon.Connection)
            CMD.CommandType = CommandType.StoredProcedure
            CMD.Parameters.AddWithValue("@CMD", diacmd)
            CMD.Parameters.AddWithValue("@ReceiptID", ReceiptID)
            CMD.Parameters.AddWithValue("@ReceiptDate", ReceiptDate)
            CMD.Parameters.AddWithValue("@Bank", Bank)
            CMD.Parameters.AddWithValue("@Customer", Customer)
            CMD.Parameters.AddWithValue("@SalesMasterID", SalesMasterID)
            CMD.Parameters.AddWithValue("@RecUSD", RecUSD)
            CMD.Parameters.AddWithValue("@ExRate", ExRate)
            CMD.Parameters.AddWithValue("@RecINR", RecINR)
            CMD.Parameters.AddWithValue("@UserID", GLOBAL_VARIABLES.UID)
            If diacmd = 3 Then
                Dim DT As New DataTable
                ADP = New SqlDataAdapter(CMD)
                ADP.Fill(DT)
                CTRL.DataSource = DT
            Else
                CMD.ExecuteNonQuery()
            End If
            VarCon.CloseConnection()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Public Sub SerieCRUD(ByVal CTRL As DevExpress.XtraGrid.GridControl, ByVal diacmd As Integer, ByVal SerieID As Integer, ByVal PurchaseID As Integer, ByVal CompanyID As Integer, ByVal BranchID As Integer, ByVal UserID As Integer, ByVal SerieName As String, ByVal Pcs As Integer, ByVal Carats As Double, ByVal Remarks As String, ByVal USDPerCarat As Double, ByVal TotalUSD As Double)
        Try
            Dim CMD As New SqlCommand
            CMD = New SqlCommand("Serie_Procedure", VarCon.Connection)
            CMD.CommandType = CommandType.StoredProcedure
            CMD.Parameters.AddWithValue("@CMD", diacmd)
            CMD.Parameters.AddWithValue("@SerieID", SerieID)
            CMD.Parameters.AddWithValue("@PurchaseID", PurchaseID)
            CMD.Parameters.AddWithValue("@CompanyID", CompanyID)
            CMD.Parameters.AddWithValue("@BranchID", BranchID)
            CMD.Parameters.AddWithValue("@UserID", UserID)
            CMD.Parameters.AddWithValue("@SerieName", SerieName)
            CMD.Parameters.AddWithValue("@Pcs", Pcs)
            CMD.Parameters.AddWithValue("@Carats", Carats)
            CMD.Parameters.AddWithValue("@Remarks", Remarks)
            CMD.Parameters.AddWithValue("@USDPerCarat", USDPerCarat)
            CMD.Parameters.AddWithValue("@TotalUSD", TotalUSD)


            If diacmd = 3 Then
                Dim DT As New DataTable
                ADP = New SqlDataAdapter(CMD)
                ADP.Fill(DT)
                CTRL.DataSource = DT
            Else
                CMD.ExecuteNonQuery()
            End If
            VarCon.CloseConnection()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Public Sub SaveMainPacketCreation(ByVal CTRL As DevExpress.XtraGrid.GridControl, ByVal diacmd As Integer, ByVal SerieID As Integer, ByVal MainLotName As String, ByVal Pcs As Integer, ByVal Carats As Double, ByVal CreationDate As Date, ByVal PPC As Double, ByVal TotalUSD As Double, ByVal VideoLink As String, ByVal ImageLink As String, ByVal Tender As String, ByVal NetUSD As Double, ByVal LabourUSDPerCarat As Double, ByVal LabourINRPerCarat As Double, ByVal LabourRate As Double)
        Try
            Dim CMD As New SqlCommand
            CMD = New SqlCommand("SaveMainPacketCreation", VarCon.Connection)
            CMD.CommandType = CommandType.StoredProcedure
            CMD.Parameters.AddWithValue("@CMD", diacmd)
            CMD.Parameters.AddWithValue("@CompanyID", GLOBAL_VARIABLES.CID)
            CMD.Parameters.AddWithValue("@BranchID", GLOBAL_VARIABLES.BID)
            CMD.Parameters.AddWithValue("@UserID", GLOBAL_VARIABLES.UID)
            CMD.Parameters.AddWithValue("@SerieID", SerieID)
            CMD.Parameters.AddWithValue("@MainLotName", MainLotName)
            CMD.Parameters.AddWithValue("@Pcs", Pcs)
            CMD.Parameters.AddWithValue("@Carats", Carats)
            CMD.Parameters.AddWithValue("@CreationDate", CreationDate)
            CMD.Parameters.AddWithValue("@PPC", PPC)
            CMD.Parameters.AddWithValue("@TotalUSD", TotalUSD)
            CMD.Parameters.AddWithValue("@VideoLink", VideoLink)
            CMD.Parameters.AddWithValue("@ImageLink", ImageLink)
            CMD.Parameters.AddWithValue("@Tender", Tender)
            CMD.Parameters.AddWithValue("@NetUSD", NetUSD)
            CMD.Parameters.AddWithValue("@LabourUSDPerCarat", LabourUSDPerCarat)
            CMD.Parameters.AddWithValue("@LabourINRPerCarat", LabourINRPerCarat)
            CMD.Parameters.AddWithValue("@LabourRate", LabourRate)

            If diacmd = 3 Then
                Dim DT As New DataTable
                ADP = New SqlDataAdapter(CMD)
                ADP.Fill(DT)
                CTRL.DataSource = DT
            Else

                CMD.ExecuteNonQuery()
            End If
            VarCon.CloseConnection()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Public Sub InternalGradingCRUD(ByVal CTRL As DevExpress.XtraGrid.GridControl, ByVal diacmd As Integer, ByVal GradingID As Integer, ByVal CompanyID As Integer, ByVal BranchID As Integer, ByVal UserID As Integer, ByVal GradingDate As Date, ByVal GraderID As Integer, ByVal LabID As Integer, ByVal Barcode As Integer, ByVal ColorID As Integer, ByVal ClarityID As Integer, ByVal FlourID As Integer, ByVal CutID As Integer, ByVal PolishID As Integer, ByVal SymID As Integer, ByVal TablePercent As String, ByVal TotalDepth As String, ByVal Length As String, ByVal Width As String, ByVal Depth As String, ByVal Ratio As String, ByVal CrHeight As String, ByVal CrAngle As String, ByVal PvDepth As String, ByVal PvAngle As String, ByVal Black As String, ByVal White As String, ByVal Comment As String)
        Try
            Dim CMD As New SqlCommand
            CMD = New SqlCommand("GradingProcedure", VarCon.Connection)
            CMD.CommandType = CommandType.StoredProcedure
            CMD.Parameters.AddWithValue("@CMD", diacmd)
            CMD.Parameters.AddWithValue("@GradingID", GraderID)
            CMD.Parameters.AddWithValue("@CompanyID", GV.CompanyID)
            CMD.Parameters.AddWithValue("@BranchID", GV.BranchID)
            CMD.Parameters.AddWithValue("@UserID", GV.UserID)
            CMD.Parameters.AddWithValue("@GradingDate", GradingDate)
            CMD.Parameters.AddWithValue("@GraderID", GraderID)
            CMD.Parameters.AddWithValue("@LabID", LabID)
            CMD.Parameters.AddWithValue("@Barcode", Barcode)
            CMD.Parameters.AddWithValue("@ColorID", ColorID)
            CMD.Parameters.AddWithValue("@ClarityID", ClarityID)
            CMD.Parameters.AddWithValue("@FlourID", FlourID)
            CMD.Parameters.AddWithValue("@CutID", CutID)
            CMD.Parameters.AddWithValue("@PolishID", PolishID)
            CMD.Parameters.AddWithValue("@SymID", SymID)
            CMD.Parameters.AddWithValue("@TablePercent", TablePercent)
            CMD.Parameters.AddWithValue("@TotalDepth", TotalDepth)
            CMD.Parameters.AddWithValue("@Length", Length)
            CMD.Parameters.AddWithValue("@Width", Width)
            CMD.Parameters.AddWithValue("@Depth", Depth)
            CMD.Parameters.AddWithValue("@Ratio", Ratio)
            CMD.Parameters.AddWithValue("@CrHeight", CrHeight)
            CMD.Parameters.AddWithValue("@CrAngle", CrAngle)
            CMD.Parameters.AddWithValue("@PvDepth", PvDepth)
            CMD.Parameters.AddWithValue("@PvAngle", PvAngle)
            CMD.Parameters.AddWithValue("@Black", Black)
            CMD.Parameters.AddWithValue("@White", White)
            CMD.Parameters.AddWithValue("@Comment", Comment)
            If diacmd = 3 Then
                Dim DT As New DataTable
                ADP = New SqlDataAdapter(CMD)
                ADP.Fill(DT)
                CTRL.DataSource = DT
            Else

                CMD.ExecuteNonQuery()
            End If
            VarCon.CloseConnection()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Public Sub ExcelStockImport(ByVal CTRL As DataGridView, ByVal diacmd As Integer, ByVal TransactionID As Integer, ByVal Barcode As Integer, ByVal CompanyID As Integer, ByVal BranchID As Integer, ByVal UserID As Integer, ByVal ImportDate As DateTime, ByVal ItemTypeID As Integer, ByVal MainLotID As Integer, ByVal StockID As String, ByVal Qty As Integer, ByVal Carats As Double, ByVal LabourINR As Double, ByVal ShapeID As Integer, ByVal ColorID As Integer, ByVal ClarityID As Integer, ByVal RAP As Double, ByVal FloID As Integer, ByVal CutID As Integer, ByVal PolishID As Integer, ByVal SymID As Integer, ByVal Comment As String, ByVal StatusID As Integer, ByVal ImageLink As String, ByVal VideoLink As String, ByVal HistoryDescription As String, ByVal UnionID As Integer)
        Try
            Dim CMD As New SqlCommand
            CMD = New SqlCommand("MainStockProcedure", VarCon.Connection)
            CMD.CommandType = CommandType.StoredProcedure
            CMD.Parameters.AddWithValue("@CMD", diacmd)
            CMD.Parameters.AddWithValue("@TransactionID", TransactionID)
            CMD.Parameters.AddWithValue("@Barcode", Barcode)
            CMD.Parameters.AddWithValue("@CompanyID", CompanyID)
            CMD.Parameters.AddWithValue("@BranchID", BranchID)
            CMD.Parameters.AddWithValue("@UserID", UserID)
            CMD.Parameters.AddWithValue("@ImportDate", ImportDate)
            CMD.Parameters.AddWithValue("@ItemTypeID", ItemTypeID)
            CMD.Parameters.AddWithValue("@MainLotID", MainLotID)
            CMD.Parameters.AddWithValue("@StockID", StockID)
            CMD.Parameters.AddWithValue("@Qty", Qty)
            CMD.Parameters.AddWithValue("@Carats", Carats)
            CMD.Parameters.AddWithValue("@LabourINR", LabourINR)
            CMD.Parameters.AddWithValue("@ShapeID", ShapeID)
            CMD.Parameters.AddWithValue("@ColorID", ColorID)
            CMD.Parameters.AddWithValue("@ClarityID", ClarityID)
            CMD.Parameters.AddWithValue("@RAP", RAP)
            CMD.Parameters.AddWithValue("@FloID", FloID)
            CMD.Parameters.AddWithValue("@CutID", CutID)
            CMD.Parameters.AddWithValue("@PolishID", PolishID)
            CMD.Parameters.AddWithValue("@SymID", SymID)
            CMD.Parameters.AddWithValue("@Comment", Comment)
            CMD.Parameters.AddWithValue("@StatusID", StatusID)
            CMD.Parameters.AddWithValue("@ImageLink", ImageLink)
            CMD.Parameters.AddWithValue("@VideoLink", VideoLink)
            CMD.Parameters.AddWithValue("@HistoryDescription", HistoryDescription)
            CMD.Parameters.AddWithValue("@UnionID", UnionID)
            If diacmd = 3 Then
                Dim DT As New DataTable
                ADP = New SqlDataAdapter(CMD)
                ADP.Fill(DT)
                CTRL.DataSource = DT
            Else
                CMD.ExecuteNonQuery()
            End If
            VarCon.CloseConnection()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Public Sub MainStockCRUD(ByVal CTRL As DevExpress.XtraGrid.GridControl, ByVal diacmd As Integer, ByVal TransactionID As Integer, ByVal Barcode As Integer, ByVal CompanyID As Integer, ByVal BranchID As Integer, ByVal UserID As Integer, ByVal ImportDate As DateTime, ByVal ItemTypeID As Integer, ByVal MainLotID As Integer, ByVal StockID As String, ByVal Qty As Integer, ByVal Carats As Double, ByVal LabourINR As Double, ByVal ShapeID As Integer, ByVal ColorID As Integer, ByVal ClarityID As Integer, ByVal RAP As Double, ByVal FloID As Integer, ByVal CutID As Integer, ByVal PolishID As Integer, ByVal SymID As Integer, ByVal Comment As String, ByVal StatusID As Integer, ByVal ImageLink As String, ByVal VideoLink As String, ByVal HistoryDescription As String, ByVal UnionID As Integer)
        Try
            Dim CMD As New SqlCommand
            CMD = New SqlCommand("MainStockProcedure", VarCon.Connection)
            CMD.CommandType = CommandType.StoredProcedure
            CMD.Parameters.AddWithValue("@CMD", diacmd)
            CMD.Parameters.AddWithValue("@TransactionID", TransactionID)
            CMD.Parameters.AddWithValue("@Barcode", Barcode)
            CMD.Parameters.AddWithValue("@CompanyID", CompanyID)
            CMD.Parameters.AddWithValue("@BranchID", BranchID)
            CMD.Parameters.AddWithValue("@UserID", UserID)
            CMD.Parameters.AddWithValue("@ImportDate", ImportDate)
            CMD.Parameters.AddWithValue("@ItemTypeID", ItemTypeID)
            CMD.Parameters.AddWithValue("@MainLotID", MainLotID)
            CMD.Parameters.AddWithValue("@StockID", StockID)
            CMD.Parameters.AddWithValue("@Qty", Qty)
            CMD.Parameters.AddWithValue("@Carats", Carats)
            CMD.Parameters.AddWithValue("@LabourINR", LabourINR)
            CMD.Parameters.AddWithValue("@ShapeID", ShapeID)
            CMD.Parameters.AddWithValue("@ColorID", ColorID)
            CMD.Parameters.AddWithValue("@ClarityID", ClarityID)
            CMD.Parameters.AddWithValue("@RAP", RAP)
            CMD.Parameters.AddWithValue("@FloID", FloID)
            CMD.Parameters.AddWithValue("@CutID", CutID)
            CMD.Parameters.AddWithValue("@PolishID", PolishID)
            CMD.Parameters.AddWithValue("@SymID", SymID)
            CMD.Parameters.AddWithValue("@Comment", Comment)
            CMD.Parameters.AddWithValue("@StatusID", StatusID)
            CMD.Parameters.AddWithValue("@ImageLink", ImageLink)
            CMD.Parameters.AddWithValue("@VideoLink", VideoLink)
            CMD.Parameters.AddWithValue("@HistoryDescription", HistoryDescription)
            CMD.Parameters.AddWithValue("@UnionID", UnionID)

            If diacmd = 3 Then
                Dim DT As New DataTable
                ADP = New SqlDataAdapter(CMD)
                ADP.Fill(DT)
                CTRL.DataSource = DT
            Else
                CMD.ExecuteNonQuery()
            End If
            VarCon.CloseConnection()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Public Sub GradingCRUD(ByVal CTRL As DevExpress.XtraGrid.GridControl, ByVal diacmd As Integer, ByVal GradingID As Integer, ByVal CompanyID As Integer, ByVal BranchID As Integer, ByVal UserID As Integer, ByVal GradingDate As Date, ByVal GraderID As Integer, ByVal LabID As Integer, ByVal Barcode As Integer, ByVal Qty As Integer, ByVal Carats As Double, ByVal ShapeID As Integer, ByVal ColorID As Integer, ByVal ClarityID As Integer, ByVal FlourID As Integer, ByVal CutID As Integer, ByVal PolishID As Integer, ByVal SymID As Integer, ByVal TablePercent As String, ByVal TotalDepth As String, ByVal Length As String, ByVal Width As String, ByVal Depth As String, ByVal Ratio As String, ByVal CrHeight As String, ByVal CrAngle As String, ByVal PvDepth As String, ByVal PvAngle As String, ByVal Black As String, ByVal White As String, ByVal Comment As String)
        Try
            Dim CMD As New SqlCommand
            CMD = New SqlCommand("GradingProcedure", VarCon.Connection)
            CMD.CommandType = CommandType.StoredProcedure
            CMD.Parameters.AddWithValue("@CMD", diacmd)
            CMD.Parameters.AddWithValue("@GradingID", GradingID)
            CMD.Parameters.AddWithValue("@CompanyID", CompanyID)
            CMD.Parameters.AddWithValue("@BranchID", BranchID)
            CMD.Parameters.AddWithValue("@UserID", UserID)
            CMD.Parameters.AddWithValue("@GradingDate", GradingDate)
            CMD.Parameters.AddWithValue("@GraderID", GraderID)
            CMD.Parameters.AddWithValue("@LabID", LabID)
            CMD.Parameters.AddWithValue("@Barcode", Barcode)
            CMD.Parameters.AddWithValue("@Qty", Qty)
            CMD.Parameters.AddWithValue("@Carats", Carats)
            CMD.Parameters.AddWithValue("@ShapeID", ShapeID)
            CMD.Parameters.AddWithValue("@ColorID", ColorID)
            CMD.Parameters.AddWithValue("@ClarityID", ClarityID)
            CMD.Parameters.AddWithValue("@FlourID", FlourID)
            CMD.Parameters.AddWithValue("@CutID", CutID)
            CMD.Parameters.AddWithValue("@PolishID", PolishID)
            CMD.Parameters.AddWithValue("@SymID", SymID)
            CMD.Parameters.AddWithValue("@TablePercent", TablePercent)
            CMD.Parameters.AddWithValue("@TotalDepth", TotalDepth)
            CMD.Parameters.AddWithValue("@Length", Length)
            CMD.Parameters.AddWithValue("@Width", Width)
            CMD.Parameters.AddWithValue("@Depth", Depth)
            CMD.Parameters.AddWithValue("@Ratio", Ratio)
            CMD.Parameters.AddWithValue("@CrHeight", CrHeight)
            CMD.Parameters.AddWithValue("@CrAngle", CrAngle)
            CMD.Parameters.AddWithValue("@PvDepth", PvDepth)
            CMD.Parameters.AddWithValue("@PvAngle", PvAngle)
            CMD.Parameters.AddWithValue("@Black", Black)
            CMD.Parameters.AddWithValue("@White", White)
            CMD.Parameters.AddWithValue("@Comment", Comment)


            If diacmd = 3 Then
                Dim DT As New DataTable
                ADP = New SqlDataAdapter(CMD)
                ADP.Fill(DT)
                CTRL.DataSource = DT
            Else
                CMD.ExecuteNonQuery()
            End If
            VarCon.CloseConnection()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Public Sub SendToProcessCRUD(ByVal CTRL As DevExpress.XtraGrid.GridControl, ByVal diacmd As String,
ByVal Barcode As Integer,
ByVal CompanyID As Integer,
ByVal BranchID As Integer,
ByVal UserID As Integer,
ByVal ImportDate As DateTime,
ByVal ItemTypeID As Integer,
ByVal MainLotID As Integer,
ByVal StockID As String,
ByVal Qty As Integer,
ByVal Carats As Double,
ByVal LabourINR As Double,
ByVal ShapeID As Integer,
ByVal ColorID As Integer,
ByVal ClarityID As Integer,
ByVal RAP As Double,
ByVal FloID As Integer,
ByVal CutID As Integer,
ByVal PolishID As Integer,
ByVal SymID As Integer,
ByVal Comment As String,
ByVal StatusID As Integer,
ByVal AskingPercent As Double,
ByVal AskingPPC As Double,
ByVal AskingTotal As Double,
ByVal WebPercent As Double,
ByVal WebPPC As Double,
ByVal WebTotal As Double,
ByVal WholesalePercent As Double,
ByVal WholesalePPC As Double,
ByVal WholesaleTotal As Double,
ByVal Certified As Boolean,
ByVal DepartmentID As Integer,
ByVal LabID As Integer,
ByVal SaleID As Integer,
ByVal ImageLink As String,
ByVal VideoLink As String,
ByVal HeartImage As String,
ByVal ArrowImage As String,
ByVal LDocumentNo As String,
ByVal LReportDate As Date,
ByVal LCertificateNo As String,
ByVal LShapeID As Integer,
ByVal LCarats As Double,
ByVal LQty As Integer,
ByVal LDescription As String,
ByVal LLengh As Double,
ByVal LWidth As Double,
ByVal LDepth As Double,
ByVal LTable As String,
ByVal LTotalDepth As String,
ByVal LCrownHeight As String,
ByVal LCrownAngle As String,
ByVal LPavillionDepth As String,
ByVal LPavillionAngle As String,
ByVal LCuletSize As String,
ByVal LCuletCondition As String,
ByVal LGirdlePercent As String,
ByVal LGirdleName As String,
ByVal LCut As String,
ByVal LPolish As String,
ByVal LSym As String,
ByVal LColorID As Integer,
ByVal LClarityID As Integer,
ByVal LFloID As Integer,
ByVal LCommentsConsulation As String,
ByVal LSpecialComments As String,
ByVal LReportComments As String,
ByVal LLabiscribe As String,
ByVal LControlNo As String,
ByVal LColorDescription As String,
ByVal LClarityStatus As String,
ByVal LFloColor As String,
ByVal LGirdleCondition As String,
ByVal LStarLength As String,
ByVal LLowerHalf As String,
ByVal LPainting As String,
ByVal LProportion As String,
ByVal LPaintComment As String,
ByVal LKeytoSymbols As String,
ByVal LSyntheticIndicator As String,
ByVal LPolishFeatures As String,
ByVal LSymFeatrues As String,
ByVal LReportType As String,
ByVal LCountryofOrigin As String,
ByVal LRoughReportNo As String,
ByVal LDiamondType As String,
ByVal Black As String,
ByVal White As String,
ByVal BGM As String,
ByVal Mcomment As String,
ByVal AComment As String,
ByVal HistoryDescription As String,
ByVal ProcessStatus As Boolean,
ByVal LedgerID As Integer,
ByVal ProcessID As Integer)
        Try
            Dim CMD As New SqlCommand
            CMD = New SqlCommand("SendToProcessProcedure", VarCon.Connection)
            CMD.CommandType = CommandType.StoredProcedure
            CMD.Parameters.AddWithValue("@Barcode", Barcode)
            CMD.Parameters.AddWithValue("@CompanyID", CompanyID)
            CMD.Parameters.AddWithValue("@BranchID", BranchID)
            CMD.Parameters.AddWithValue("@UserID", UserID)
            CMD.Parameters.AddWithValue("@ImportDate", ImportDate)
            CMD.Parameters.AddWithValue("@ItemTypeID", ItemTypeID)
            CMD.Parameters.AddWithValue("@MainLotID", MainLotID)
            CMD.Parameters.AddWithValue("@StockID", StockID)
            CMD.Parameters.AddWithValue("@Qty", Qty)
            CMD.Parameters.AddWithValue("@Carats", Carats)
            CMD.Parameters.AddWithValue("@LabourINR", LabourINR)
            CMD.Parameters.AddWithValue("@ShapeID", ShapeID)
            CMD.Parameters.AddWithValue("@ColorID", ColorID)
            CMD.Parameters.AddWithValue("@ClarityID", ClarityID)
            CMD.Parameters.AddWithValue("@RAP", RAP)
            CMD.Parameters.AddWithValue("@FloID", FloID)
            CMD.Parameters.AddWithValue("@CutID", CutID)
            CMD.Parameters.AddWithValue("@PolishID", PolishID)
            CMD.Parameters.AddWithValue("@SymID", SymID)
            CMD.Parameters.AddWithValue("@Comment", Comment)
            CMD.Parameters.AddWithValue("@StatusID", StatusID)
            CMD.Parameters.AddWithValue("@AskingPercent", AskingPercent)
            CMD.Parameters.AddWithValue("@AskingPPC", AskingPPC)
            CMD.Parameters.AddWithValue("@AskingTotal", AskingTotal)
            CMD.Parameters.AddWithValue("@WebPercent", WebPercent)
            CMD.Parameters.AddWithValue("@WebPPC", WebPPC)
            CMD.Parameters.AddWithValue("@WebTotal", WebTotal)
            CMD.Parameters.AddWithValue("@WholesalePercent", WholesalePercent)
            CMD.Parameters.AddWithValue("@WholesalePPC", WholesalePPC)
            CMD.Parameters.AddWithValue("@WholesaleTotal", WholesaleTotal)
            CMD.Parameters.AddWithValue("@Certified", Certified)
            CMD.Parameters.AddWithValue("@DepartmentID", DepartmentID)
            CMD.Parameters.AddWithValue("@LabID", LabID)
            CMD.Parameters.AddWithValue("@SaleID", SaleID)
            CMD.Parameters.AddWithValue("@ImageLink", ImageLink)
            CMD.Parameters.AddWithValue("@VideoLink", VideoLink)
            CMD.Parameters.AddWithValue("@HeartImage", HeartImage)
            CMD.Parameters.AddWithValue("@ArrowImage", ArrowImage)
            CMD.Parameters.AddWithValue("@LDocumentNo", LDocumentNo)
            CMD.Parameters.AddWithValue("@LReportDate", LReportDate)
            CMD.Parameters.AddWithValue("@LCertificateNo", LCertificateNo)
            CMD.Parameters.AddWithValue("@LShapeID", LShapeID)
            CMD.Parameters.AddWithValue("@LCarats", LCarats)
            CMD.Parameters.AddWithValue("@LQty", LQty)
            CMD.Parameters.AddWithValue("@LDescription", LDescription)
            CMD.Parameters.AddWithValue("@LLengh", LLengh)
            CMD.Parameters.AddWithValue("@LWidth", LWidth)
            CMD.Parameters.AddWithValue("@LDepth", LDepth)
            CMD.Parameters.AddWithValue("@LTable", LTable)
            CMD.Parameters.AddWithValue("@LTotalDepth", LTotalDepth)
            CMD.Parameters.AddWithValue("@LCrownHeight", LCrownHeight)
            CMD.Parameters.AddWithValue("@LCrownAngle", LCrownAngle)
            CMD.Parameters.AddWithValue("@LPavillionDepth", LPavillionDepth)
            CMD.Parameters.AddWithValue("@LPavillionAngle", LPavillionAngle)
            CMD.Parameters.AddWithValue("@LCuletSize", LCuletSize)
            CMD.Parameters.AddWithValue("@LCuletCondition", LCuletCondition)
            CMD.Parameters.AddWithValue("@LGirdlePercent", LGirdlePercent)
            CMD.Parameters.AddWithValue("@LGirdleName", LGirdleName)
            CMD.Parameters.AddWithValue("@LCut", LCut)
            CMD.Parameters.AddWithValue("@LPolish", LPolish)
            CMD.Parameters.AddWithValue("@LSym", LSym)
            CMD.Parameters.AddWithValue("@LColorID", LColorID)
            CMD.Parameters.AddWithValue("@LClarityID", LClarityID)
            CMD.Parameters.AddWithValue("@LFloID", LFloID)
            CMD.Parameters.AddWithValue("@LCommentsConsulation", LCommentsConsulation)
            CMD.Parameters.AddWithValue("@LSpecialComments", LSpecialComments)
            CMD.Parameters.AddWithValue("@LReportComments", LReportComments)
            CMD.Parameters.AddWithValue("@LLabiscribe", LLabiscribe)
            CMD.Parameters.AddWithValue("@LControlNo", LControlNo)
            CMD.Parameters.AddWithValue("@LColorDescription", LColorDescription)
            CMD.Parameters.AddWithValue("@LClarityStatus", LClarityStatus)
            CMD.Parameters.AddWithValue("@LFloColor", LFloColor)
            CMD.Parameters.AddWithValue("@LGirdleCondition", LGirdleCondition)
            CMD.Parameters.AddWithValue("@LStarLength", LStarLength)
            CMD.Parameters.AddWithValue("@LLowerHalf", LLowerHalf)
            CMD.Parameters.AddWithValue("@LPainting", LPainting)
            CMD.Parameters.AddWithValue("@LProportion", LProportion)
            CMD.Parameters.AddWithValue("@LPaintComment", LPaintComment)
            CMD.Parameters.AddWithValue("@LKeytoSymbols", LKeytoSymbols)
            CMD.Parameters.AddWithValue("@LSyntheticIndicator", LSyntheticIndicator)
            CMD.Parameters.AddWithValue("@LPolishFeatures", LPolishFeatures)
            CMD.Parameters.AddWithValue("@LSymFeatrues", LSymFeatrues)
            CMD.Parameters.AddWithValue("@LReportType", LReportType)
            CMD.Parameters.AddWithValue("@LCountryofOrigin", LCountryofOrigin)
            CMD.Parameters.AddWithValue("@LRoughReportNo", LRoughReportNo)
            CMD.Parameters.AddWithValue("@LDiamondType", LDiamondType)
            CMD.Parameters.AddWithValue("@Black", Black)
            CMD.Parameters.AddWithValue("@White", White)
            CMD.Parameters.AddWithValue("@BGM", BGM)
            CMD.Parameters.AddWithValue("@Mcomment", Mcomment)
            CMD.Parameters.AddWithValue("@AComment", AComment)
            CMD.Parameters.AddWithValue("@HistoryDescription", HistoryDescription)
            CMD.Parameters.AddWithValue("@ProcessStatus", ProcessStatus)
            CMD.Parameters.AddWithValue("@LedgerID", LedgerID)
            CMD.Parameters.AddWithValue("@ProcessID", ProcessID)

            If diacmd = "select" Then
                Dim DT As New DataTable
                ADP = New SqlDataAdapter(CMD)
                ADP.Fill(DT)
                CTRL.DataSource = DT
            Else
                CMD.ExecuteNonQuery()
            End If
            VarCon.CloseConnection()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Public Sub DataTable_to_SqlTable_Copy(ByVal dt As DataTable, ByVal sqlTableName As String)
        VarCon.Connection()
        Using copy As New SqlBulkCopy(con)
            copy.DestinationTableName = sqlTableName
            copy.WriteToServer(dt)
        End Using
        VarCon.CloseConnection()
    End Sub
    Public Shared Sub SalesMaster_INSERT(ByVal diaCMD As Integer, ByVal SaleDate As DateTime, ByVal LedgerID As Integer, ByVal TermsID As Integer, ByVal ExRate As Double, ByVal Qty As Integer, ByVal Carats As Double, ByVal SaleUSD As Double, ByVal SaleINR As Double, ByVal AddUSD As Double, ByVal AddINR As Double, ByVal BrokerUSD As Double, ByVal BrokerINR As Double, ByVal NetUSD As Double, ByVal NetINR As Double, ByVal Attachment As String)
        If GLOBAL_VARIABLES.SalesEditFlag = False Then
            FrmInvoiceList.SalesMasterID = GENERAL_FUNCTIONS.MaxNo("SELECT Max(SalesMasterID) from Dia_SalesMaster")
        End If
        Try
            Dim CMD As New SqlCommand
            CMD = New SqlCommand("SalesMasterProcedure", VarCon.Connection)
            CMD.CommandType = CommandType.StoredProcedure
            CMD.Parameters.AddWithValue("@CMD", diaCMD)
            CMD.Parameters.AddWithValue("@SalesMasterID", FrmInvoiceList.SalesMasterID)
            CMD.Parameters.AddWithValue("@SaleDate", SaleDate)
            CMD.Parameters.AddWithValue("@LedgerID", LedgerID)
            CMD.Parameters.AddWithValue("@TermsID", TermsID)
            CMD.Parameters.AddWithValue("@ExRate", ExRate)
            CMD.Parameters.AddWithValue("@Qty", Qty)
            CMD.Parameters.AddWithValue("@Carats", Carats)
            CMD.Parameters.AddWithValue("@SaleUSD", SaleUSD)
            CMD.Parameters.AddWithValue("@SaleINR", SaleINR)
            CMD.Parameters.AddWithValue("@AddUSD", AddUSD)
            CMD.Parameters.AddWithValue("@AddINR", AddINR)
            CMD.Parameters.AddWithValue("@BrokerUSD", BrokerUSD)
            CMD.Parameters.AddWithValue("@BrokerINR", BrokerINR)
            CMD.Parameters.AddWithValue("@NetUSD", NetUSD)
            CMD.Parameters.AddWithValue("@NetINR", NetINR)
            CMD.Parameters.AddWithValue("@UserID", UID)
            CMD.Parameters.AddWithValue("@BranchID", BID)
            CMD.Parameters.AddWithValue("@CompanyID", CID)
            CMD.Parameters.AddWithValue("@Attachment", Attachment)
            CMD.ExecuteNonQuery()
            VarCon.CloseConnection()
        Catch ex As Exception
            DevFunctions.ErrorMsg(ex.Message)
        End Try

    End Sub
    Public Shared Sub SalesDetails_INSERT(ByVal diaCMD As Integer, ByVal SalesDetailID As Integer, ByVal SalesMasterID As Integer, ByVal Barcode As Integer, ByVal RAP As Double, ByVal Discount As Double, ByVal PPCUSD As Double, ByVal TotalUSD As Double, ByVal PPCINR As Double, ByVal TotalINR As Double)
        Try
            Dim CMD As New SqlCommand
            CMD = New SqlCommand("SalesMasterProcedure", VarCon.Connection)
            CMD.CommandType = CommandType.StoredProcedure
            CMD.Parameters.AddWithValue("@CMD", diaCMD)
            CMD.Parameters.AddWithValue("@SalesDetailID", SalesDetailID)
            CMD.Parameters.AddWithValue("@SalesMasterID", SalesMasterID)
            CMD.Parameters.AddWithValue("@Barcode", Barcode)
            CMD.Parameters.AddWithValue("@RAP", RAP)
            CMD.Parameters.AddWithValue("@Discount", Discount)
            CMD.Parameters.AddWithValue("@PPCUSD", PPCUSD)
            CMD.Parameters.AddWithValue("@TotalUSD", TotalUSD)
            CMD.Parameters.AddWithValue("@PPCINR", PPCINR)
            CMD.Parameters.AddWithValue("@TotalINR", TotalINR)
            CMD.ExecuteNonQuery()
            VarCon.CloseConnection()
        Catch ex As Exception
            DevFunctions.ErrorMsg(ex.Message)
        End Try
    End Sub
    Public Shared Sub SalesBrokerage_INSERT(ByVal diaCMD As Integer, ByVal SalesBrokerageID As Integer, ByVal SalesMasterID As Integer, ByVal BrokerLedgerID As Integer, ByVal BrokeragePercent As Double, ByVal BrokerageUSD As Double, ByVal BrokerageINR As Double)
        Try
            Dim CMD As New SqlCommand
            CMD = New SqlCommand("SalesMasterProcedure", VarCon.Connection)
            CMD.CommandType = CommandType.StoredProcedure
            CMD.Parameters.AddWithValue("@CMD", diaCMD)
            CMD.Parameters.AddWithValue("@SalesBrokerageID", SalesBrokerageID)
            CMD.Parameters.AddWithValue("@SalesMasterID", SalesMasterID)
            CMD.Parameters.AddWithValue("@BrokerLedgerID", BrokerLedgerID)
            CMD.Parameters.AddWithValue("@BrokeragePercent", BrokeragePercent)
            CMD.Parameters.AddWithValue("@BrokerageUSD", BrokerageUSD)
            CMD.Parameters.AddWithValue("@BrokerageINR", BrokerageINR)
            CMD.ExecuteNonQuery()
            VarCon.CloseConnection()
        Catch ex As Exception
            DevFunctions.ErrorMsg(ex.Message)
        End Try
    End Sub
    Public Shared Sub SalesAdditional_INSERT(ByVal diaCMD As Integer, ByVal SalesAdditionalID As Integer, ByVal SalesMasterID As Integer, ByVal ExpenseLedgerID As Integer, ByVal ExpensePercent As Double, ByVal ExpenseUSD As Double, ByVal ExpenseINR As Double)
        Try
            Dim CMD As New SqlCommand
            CMD = New SqlCommand("SalesMasterProcedure", VarCon.Connection)
            CMD.CommandType = CommandType.StoredProcedure
            CMD.Parameters.AddWithValue("@CMD", diaCMD)
            CMD.Parameters.AddWithValue("@SalesAdditionalID", SalesAdditionalID)
            CMD.Parameters.AddWithValue("@SalesMasterID", SalesMasterID)
            CMD.Parameters.AddWithValue("@ExpenseLedgerID", ExpenseLedgerID)
            CMD.Parameters.AddWithValue("@ExpensePercent", ExpensePercent)
            CMD.Parameters.AddWithValue("@ExpenseUSD", ExpenseUSD)
            CMD.Parameters.AddWithValue("@ExpenseINR", ExpenseINR)
            CMD.ExecuteNonQuery()
            VarCon.CloseConnection()
        Catch ex As Exception
            DevFunctions.ErrorMsg(ex.Message)
        End Try
    End Sub
End Class

