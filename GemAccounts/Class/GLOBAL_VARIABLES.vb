Imports System.Data
Imports System.Data.SqlClient
Imports GemAccounts.GENERAL_FUNCTIONS
Imports GemAccounts.DevFunctions

Public Class GLOBAL_VARIABLES

    Public Shared DT As DataTable
    Public Shared RDR As SqlDataReader
    Public Shared dr As SqlDataReader
    Public Shared ADP As SqlDataAdapter
    Public Shared CMD As SqlCommand
    Public Shared DS As DataSet
    Public Shared VarCon As New MasterConnection
    Public Shared UROLE As String = ""
    Public Shared UNAME As String = ""
    Public Shared BID As Integer = Nothing
    Public Shared UID As Integer = Nothing
    Public Shared CID As Integer = Nothing
    Public Shared StockLayoutID As Integer = Nothing
    Public Shared CompanyID As Integer = 0
    Public Shared BranchID As Integer = 0
    Public Shared UserID As Integer = 0
    Public Shared ReportName As String = Nothing

    Public Shared filepath As String
    Public Shared ExRate As Double = DevFunctions.GetLiveRate()
    ' Public Shared SalesMasterID As Integer = Nothing
    Public Shared SalesEditFlag As Boolean = Nothing
    Public Shared PacketEditFlag As Boolean = Nothing
    Public Shared TempStockLayoutID As Integer = Nothing
    Public Shared Barcode As Integer = Nothing
    Public Shared TransactionID_DataTable As New DataTable
    Public Shared ClipboardFlag As Boolean = Nothing
    Public Shared FilterString As String = Nothing

    Public Shared AttachmentPath As String = Application.StartupPath & "\Attachments\"
    Public Shared Filename As String = ""
    Public Shared TmpFileName As String

End Class
