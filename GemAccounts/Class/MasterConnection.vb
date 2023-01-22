Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports GemAccounts.GLOBAL_VARIABLES

Public Class MasterConnection
    Public Shared con As SqlConnection
    Public Function Connection() As SqlConnection
        con = New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("GemAccounts.My.MySettings.DIA_MASTERConnectionString").ConnectionString)
        'con = New SqlConnection("Data Source=NIKUNJ;Initial Catalog=DIA_MASTER;Integrated Security=True")
        'con = New SqlConnection("Data Source=GURU\GURU;Initial Catalog=DIA_MASTER;Integrated Security=True")
        'con = New SqlConnection("Data Source=DREAMCLOUD\DREAMCLOUD;Initial Catalog=DIA_MASTER;Integrated Security=True")

        If con.State = 1 Then con.Close()
        con.Open()
        Return con
    End Function
    Public Function CloseConnection() As SqlConnection
        con.Close()
        Return con
    End Function

    Public Function NFetchDataset(ByVal Query As String) As DataSet
        Dim dtp As New DataSet
        ADP = New SqlDataAdapter(Query, con)
        ADP.Fill(dtp)
        NFetchDataset = dtp
    End Function
End Class
