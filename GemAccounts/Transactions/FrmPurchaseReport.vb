Imports DevExpress.XtraEditors
Imports GemAccounts.GENERAL_FUNCTIONS
Imports GemAccounts.BAL_Transactions
Imports GemAccounts.MasterConnection

Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class FrmPurchaseReport

    Dim GF As New GENERAL_FUNCTIONS
    Dim BL As New BAL_Transactions
    Dim mc As New MasterConnection




    Private Sub FrmPurchase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Purchase Report Code

        'Dim mr As New SqlDataAdapter("select PurchaseID,CompanyID,BranchID,UserID,PurchaseDate,VendorID,Terms,ItemType,Pcs,Carats,GrossTotalUSD,AddExpUSD,ExchangeRate,NetUSD,NetINR,Remarks,DueDate from Dia_purchase", mc.Connection)
        'Dim ct As New SqlDataAdapter("select SerieID,CompanyID,BranchID,UserID,PurchaseID,SerieName,Pcs,Carats,Remarks,USDPerCarat,TotalUSD from Dia_serie", mc.Connection)

        'Dim dataSet11 As New DataSet()
        'mr.Fill(dataSet11, "Dia_purchase")
        'ct.Fill(dataSet11, "Dia_serie")

        'Dim keyColumn As DataColumn = dataSet11.Tables("Dia_purchase").Columns("PurchaseId")
        'Dim foreignKeyColumn As DataColumn = dataSet11.Tables("Dia_serie").Columns("PurchaseId")
        'dataSet11.Relations.Add("rel1", keyColumn, foreignKeyColumn)


        'dg.DataSource = dataSet11.Tables("Dia_purchase")
        'dg.ForceInitialize()


    End Sub

End Class