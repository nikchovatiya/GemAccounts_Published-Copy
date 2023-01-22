Imports System.Data
Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports GemAccounts.GLOBAL_VARIABLES
Imports GemAccounts.MasterConnection

Public Class BAL_PURCHSE
    Public Sub DIACRUD(ByVal CTRL As DevExpress.XtraGrid.GridControl, ByVal diacmd As Integer, ByVal cmpid As Integer, ByVal cmpname As String, ByVal cmpadd As String, ByVal cmpcontry As String, ByVal cmpstate As String, ByVal cmpcity As String, ByVal cmpmobile As String, ByVal cmpphone As String, ByVal cmpemail As String, ByVal cmpgst As String, ByVal cmppan As String, ByVal cmpbank As String, ByVal cmpbankbrach As String, ByVal cmpbanlacno As String, ByVal cmpifc As String, ByVal swift As String, ByVal routing As String)
        Try
            Dim CMD As New SqlCommand
            CMD = New SqlCommand("COMPANY_MASTER", VarCon.Connection)
            CMD.CommandType = CommandType.StoredProcedure
            CMD.Parameters.AddWithValue("@CMD", diacmd)
            CMD.Parameters.AddWithValue("@cmp_id", cmpid)
            CMD.Parameters.AddWithValue("@cmp_name", cmpname)
            CMD.Parameters.AddWithValue("@cmp_address", cmpadd)
            CMD.Parameters.AddWithValue("@cmp_country", cmpcontry)
            CMD.Parameters.AddWithValue("@cmp_state", cmpstate)
            CMD.Parameters.AddWithValue("@cmp_city", cmpcity)
            CMD.Parameters.AddWithValue("@cmp_mobile", cmpmobile)
            CMD.Parameters.AddWithValue("@cmp_phone", cmpphone)
            CMD.Parameters.AddWithValue("@cmp_email", cmpemail)
            CMD.Parameters.AddWithValue("@cmp_gst", cmpgst)
            CMD.Parameters.AddWithValue("@cmp_pan", cmppan)
            CMD.Parameters.AddWithValue("@cmp_bank", cmpbank)
            CMD.Parameters.AddWithValue("@cmp_branch", cmpbankbrach)
            CMD.Parameters.AddWithValue("@cmp_acno", cmpbanlacno)
            CMD.Parameters.AddWithValue("@cmp_ifc", cmpifc)
            CMD.Parameters.AddWithValue("@cmp_swift", swift)
            CMD.Parameters.AddWithValue("@cmp_routing", routing)

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

        End Try

    End Sub

    Public Sub DIACRUDBRANCH(ByVal CTRL As DevExpress.XtraGrid.GridControl, ByVal diacmd As Integer, ByVal br_id As Integer, ByVal cmp_id As Integer, ByVal br_name As String, ByVal br_address As String, ByVal br_country As String, ByVal br_state As String, ByVal br_city As String, ByVal br_mobile As String, ByVal br_phone As String, ByVal br_email As String, ByVal br_gst As String, ByVal br_pan As String, ByVal br_bank As String, ByVal br_branch As String, ByVal br_acno As String, ByVal br_ifc As String, ByVal br_swift As String, ByVal br_routing As String)
        Dim CMD As New SqlCommand
        CMD = New SqlCommand("BRANCH_MASTER", VarCon.Connection)
        CMD.CommandType = CommandType.StoredProcedure
        CMD.Parameters.AddWithValue("@CMD", diacmd)
        CMD.Parameters.AddWithValue("@br_id", br_id)
        CMD.Parameters.AddWithValue("@cmp_id", cmp_id)
        CMD.Parameters.AddWithValue("@br_name", br_name)
        CMD.Parameters.AddWithValue("@br_address", br_address)
        CMD.Parameters.AddWithValue("@br_country", br_country)
        CMD.Parameters.AddWithValue("@br_state", br_state)
        CMD.Parameters.AddWithValue("@br_city", br_city)
        CMD.Parameters.AddWithValue("@br_mobile", br_mobile)
        CMD.Parameters.AddWithValue("@br_phone", br_phone)
        CMD.Parameters.AddWithValue("@br_email", br_email)
        CMD.Parameters.AddWithValue("@br_gst", br_gst)
        CMD.Parameters.AddWithValue("@br_pan", br_pan)
        CMD.Parameters.AddWithValue("@br_bank", br_bank)
        CMD.Parameters.AddWithValue("@br_branch", br_branch)
        CMD.Parameters.AddWithValue("@br_acno", br_acno)
        CMD.Parameters.AddWithValue("@br_ifc", br_ifc)
        CMD.Parameters.AddWithValue("@br_swift", br_swift)
        CMD.Parameters.AddWithValue("@br_routing", br_routing)

        If diacmd = 3 Then
            Dim DT As New DataTable
            ADP = New SqlDataAdapter(CMD)
            ADP.Fill(DT)
            CTRL.DataSource = DT
        Else
            CMD.ExecuteNonQuery()
        End If
        VarCon.CloseConnection()
    End Sub
    Public Sub DIACRUDSHAPE(ByVal CTRL As DevExpress.XtraGrid.GridControl, ByVal diacmd As Integer, ByVal shape_id As Integer, ByVal shape_name As String, ByVal shape_desc As String, ByVal rap_shape As String)
        Dim CMD As New SqlCommand
        CMD = New SqlCommand("SHAPE_MASTER", VarCon.Connection)
        CMD.CommandType = CommandType.StoredProcedure
        CMD.Parameters.AddWithValue("@CMD", diacmd)
        CMD.Parameters.AddWithValue("@shape_id", shape_id)
        CMD.Parameters.AddWithValue("@shape_name", shape_name)
        CMD.Parameters.AddWithValue("@shape_desc", shape_desc)
        CMD.Parameters.AddWithValue("@rap_shape", rap_shape)

        If diacmd = 3 Then
            Dim DT As New DataTable
            ADP = New SqlDataAdapter(CMD)
            ADP.Fill(DT)
            CTRL.DataSource = DT
        Else
            CMD.ExecuteNonQuery()
        End If
        VarCon.CloseConnection()
    End Sub
    Public Sub DIACRUDCOLOR(ByVal CTRL As DevExpress.XtraGrid.GridControl, ByVal diacmd As Integer, ByVal color_id As Integer, ByVal color_name As String, ByVal color_desc As String, ByVal rap_color As String, ByVal is_fancy_color As Boolean, ByVal fancy_color As String, ByVal intensity As String, ByVal overtone As String)
        Dim CMD As New SqlCommand
        CMD = New SqlCommand("COLOR_MASTER", VarCon.Connection)
        CMD.CommandType = CommandType.StoredProcedure
        CMD.Parameters.AddWithValue("@CMD", diacmd)
        CMD.Parameters.AddWithValue("@color_id", color_id)
        CMD.Parameters.AddWithValue("@color_name", color_name)
        CMD.Parameters.AddWithValue("@color_desc", color_desc)
        CMD.Parameters.AddWithValue("@rap_color", rap_color)
        CMD.Parameters.AddWithValue("@is_fancy_color", is_fancy_color)
        CMD.Parameters.AddWithValue("@fancy_color", fancy_color)
        CMD.Parameters.AddWithValue("@intensity", intensity)
        CMD.Parameters.AddWithValue("@overtone", overtone)
        If diacmd = 3 Then
            Dim DT As New DataTable
            ADP = New SqlDataAdapter(CMD)
            ADP.Fill(DT)
            CTRL.DataSource = DT
        Else
            CMD.ExecuteNonQuery()

        End If
        VarCon.CloseConnection()
    End Sub
    Public Sub DIACRUDCLARITY(ByVal CTRL As DevExpress.XtraGrid.GridControl, ByVal diacmd As Integer, ByVal clarity_id As Integer, ByVal clarity_name As String, ByVal clarity_desc As String, ByVal rap_clarity As String)
        Dim CMD As New SqlCommand
        CMD = New SqlCommand("CLARITY_MASTER", VarCon.Connection)
        CMD.CommandType = CommandType.StoredProcedure
        CMD.Parameters.AddWithValue("@CMD", diacmd)
        CMD.Parameters.AddWithValue("@clarity_id", clarity_id)
        CMD.Parameters.AddWithValue("@clarity_name", clarity_name)
        CMD.Parameters.AddWithValue("@clarity_desc", clarity_desc)
        CMD.Parameters.AddWithValue("@rap_clarity", rap_clarity)

        If diacmd = 3 Then
            Dim DT As New DataTable
            ADP = New SqlDataAdapter(CMD)
            ADP.Fill(DT)
            CTRL.DataSource = DT
        Else
            CMD.ExecuteNonQuery()
        End If
        VarCon.CloseConnection()
    End Sub
    Public Sub DIACRUDCUT(ByVal CTRL As DevExpress.XtraGrid.GridControl, ByVal diacmd As Integer, ByVal cut_id As Integer, ByVal cut_name As String, ByVal cut_desc As String)
        Dim CMD As New SqlCommand
        CMD = New SqlCommand("CUT_MASTER", VarCon.Connection)
        CMD.CommandType = CommandType.StoredProcedure
        CMD.Parameters.AddWithValue("@CMD", diacmd)
        CMD.Parameters.AddWithValue("@cut_id", cut_id)
        CMD.Parameters.AddWithValue("@cut_name", cut_name)
        CMD.Parameters.AddWithValue("@cut_desc", cut_desc)

        If diacmd = 3 Then
            Dim DT As New DataTable
            ADP = New SqlDataAdapter(CMD)
            ADP.Fill(DT)
            CTRL.DataSource = DT
        Else
            CMD.ExecuteNonQuery()
        End If
        VarCon.CloseConnection()
    End Sub
    Public Sub DIACRUDPOLISH(ByVal CTRL As DevExpress.XtraGrid.GridControl, ByVal diacmd As Integer, ByVal polish_id As Integer, ByVal polish_name As String, ByVal polish_desc As String)
        Dim CMD As New SqlCommand
        CMD = New SqlCommand("POLISH_MASTER", VarCon.Connection)
        CMD.CommandType = CommandType.StoredProcedure
        CMD.Parameters.AddWithValue("@CMD", diacmd)
        CMD.Parameters.AddWithValue("@polish_id", polish_id)
        CMD.Parameters.AddWithValue("@polish_name", polish_name)
        CMD.Parameters.AddWithValue("@polish_desc", polish_desc)

        If diacmd = 3 Then
            Dim DT As New DataTable
            ADP = New SqlDataAdapter(CMD)
            ADP.Fill(DT)
            CTRL.DataSource = DT
        Else
            CMD.ExecuteNonQuery()
        End If
        VarCon.CloseConnection()
    End Sub
    Public Sub DIACRUDsymm(ByVal CTRL As DevExpress.XtraGrid.GridControl, ByVal diacmd As Integer, ByVal symm_id As Integer, ByVal symm_name As String, ByVal symm_desc As String)
        Dim CMD As New SqlCommand
        CMD = New SqlCommand("symm_MASTER", VarCon.Connection)
        CMD.CommandType = CommandType.StoredProcedure
        CMD.Parameters.AddWithValue("@CMD", diacmd)
        CMD.Parameters.AddWithValue("@symm_id", symm_id)
        CMD.Parameters.AddWithValue("@symm_name", symm_name)
        CMD.Parameters.AddWithValue("@symm_desc", symm_desc)

        If diacmd = 3 Then
            Dim DT As New DataTable
            ADP = New SqlDataAdapter(CMD)
            ADP.Fill(DT)
            CTRL.DataSource = DT
        Else
            CMD.ExecuteNonQuery()
        End If
        VarCon.CloseConnection()
    End Sub
    Public Sub DIACRUDflo(ByVal CTRL As DevExpress.XtraGrid.GridControl, ByVal diacmd As Integer, ByVal flo_id As Integer, ByVal flo_name As String, ByVal flo_desc As String)
        Dim CMD As New SqlCommand
        CMD = New SqlCommand("flo_MASTER", VarCon.Connection)
        CMD.CommandType = CommandType.StoredProcedure
        CMD.Parameters.AddWithValue("@CMD", diacmd)
        CMD.Parameters.AddWithValue("@flo_id", flo_id)
        CMD.Parameters.AddWithValue("@flo_name", flo_name)
        CMD.Parameters.AddWithValue("@flo_desc", flo_desc)

        If diacmd = 3 Then
            Dim DT As New DataTable
            ADP = New SqlDataAdapter(CMD)
            ADP.Fill(DT)
            CTRL.DataSource = DT
        Else
            CMD.ExecuteNonQuery()
        End If
        VarCon.CloseConnection()
    End Sub
    Public Sub DIACRUDlab(ByVal CTRL As DevExpress.XtraGrid.GridControl, ByVal diacmd As Integer, ByVal lab_id As Integer, ByVal lab_name As String, ByVal lab_desc As String)
        Dim CMD As New SqlCommand
        CMD = New SqlCommand("lab_MASTER", VarCon.Connection)
        CMD.CommandType = CommandType.StoredProcedure
        CMD.Parameters.AddWithValue("@CMD", diacmd)
        CMD.Parameters.AddWithValue("@lab_id", lab_id)
        CMD.Parameters.AddWithValue("@lab_name", lab_name)
        CMD.Parameters.AddWithValue("@lab_desc", lab_desc)

        If diacmd = 3 Then
            Dim DT As New DataTable
            ADP = New SqlDataAdapter(CMD)
            ADP.Fill(DT)
            CTRL.DataSource = DT
        Else
            CMD.ExecuteNonQuery()
        End If
        VarCon.CloseConnection()
    End Sub
    Public Sub DIACRUDUSER(ByVal CTRL As DevExpress.XtraGrid.GridControl, ByVal diacmd As Integer, ByVal user_id As Integer, ByVal cmp_id As Integer, ByVal br_id As Integer, ByVal user_name As String, ByVal password As String)
        Dim CMD As New SqlCommand
        CMD = New SqlCommand("USER_MASTER", VarCon.Connection)
        CMD.CommandType = CommandType.StoredProcedure
        CMD.Parameters.AddWithValue("@CMD", diacmd)
        CMD.Parameters.AddWithValue("@user_id", user_id)
        CMD.Parameters.AddWithValue("@cmp_id", cmp_id)
        CMD.Parameters.AddWithValue("@br_id", br_id)
        CMD.Parameters.AddWithValue("@user_name", user_name)
        CMD.Parameters.AddWithValue("@password", password)
        If diacmd = 3 Then
            Dim DT As New DataTable
            ADP = New SqlDataAdapter(CMD)
            ADP.Fill(DT)
            CTRL.DataSource = DT
        Else
            CMD.ExecuteNonQuery()
        End If
        VarCon.CloseConnection()
    End Sub
    Public Sub DIACRUDTERMS(ByVal CTRL As DevExpress.XtraGrid.GridControl, ByVal diacmd As Integer, ByVal terms_id As Integer, ByVal terms_name As String, ByVal terms_desc As String)
        Dim CMD As New SqlCommand
        CMD = New SqlCommand("terms_MASTER", VarCon.Connection)
        CMD.CommandType = CommandType.StoredProcedure
        CMD.Parameters.AddWithValue("@CMD", diacmd)
        CMD.Parameters.AddWithValue("@terms_id", terms_id)
        CMD.Parameters.AddWithValue("@terms_name", terms_name)
        CMD.Parameters.AddWithValue("@terms_desc", terms_desc)

        If diacmd = 3 Then
            Dim DT As New DataTable
            ADP = New SqlDataAdapter(CMD)
            ADP.Fill(DT)
            CTRL.DataSource = DT
        Else
            CMD.ExecuteNonQuery()
        End If
        VarCon.CloseConnection()
    End Sub
    Public Sub DIACRUDitem_type(ByVal CTRL As DevExpress.XtraGrid.GridControl, ByVal diacmd As Integer, ByVal item_type_id As Integer, ByVal item_type_name As String, ByVal item_type_desc As String)
        Dim CMD As New SqlCommand
        CMD = New SqlCommand("item_type_MASTER", VarCon.Connection)
        CMD.CommandType = CommandType.StoredProcedure
        CMD.Parameters.AddWithValue("@CMD", diacmd)
        CMD.Parameters.AddWithValue("@item_type_id", item_type_id)
        CMD.Parameters.AddWithValue("@item_type_name", item_type_name)
        CMD.Parameters.AddWithValue("@item_type_desc", item_type_desc)

        If diacmd = 3 Then
            Dim DT As New DataTable
            ADP = New SqlDataAdapter(CMD)
            ADP.Fill(DT)
            CTRL.DataSource = DT
        Else
            CMD.ExecuteNonQuery()
        End If
        VarCon.CloseConnection()
    End Sub
    Public Sub DIACRUDlot_status(ByVal CTRL As DevExpress.XtraGrid.GridControl, ByVal diacmd As Integer, ByVal lot_status_id As Integer, ByVal lot_status_name As String, ByVal lot_status_desc As String)
        Dim CMD As New SqlCommand
        CMD = New SqlCommand("lot_status_MASTER", VarCon.Connection)
        CMD.CommandType = CommandType.StoredProcedure
        CMD.Parameters.AddWithValue("@CMD", diacmd)
        CMD.Parameters.AddWithValue("@lot_status_id", lot_status_id)
        CMD.Parameters.AddWithValue("@lot_status_name", lot_status_name)
        CMD.Parameters.AddWithValue("@lot_status_desc", lot_status_desc)

        If diacmd = 3 Then
            Dim DT As New DataTable
            ADP = New SqlDataAdapter(CMD)
            ADP.Fill(DT)
            CTRL.DataSource = DT
        Else
            CMD.ExecuteNonQuery()
        End If
        VarCon.CloseConnection()
    End Sub
    Public Sub DIACRUD_Account_Main_Group(ByVal CTRL As DevExpress.XtraGrid.GridControl, ByVal diacmd As Integer, ByVal main_group_id As Integer, ByVal main_gorup_name As String, ByVal is_deletable As Boolean)
        Dim CMD As New SqlCommand
        CMD = New SqlCommand("MAIN_ACCOUNT_GROUP_MASTER", VarCon.Connection)
        CMD.CommandType = CommandType.StoredProcedure
        CMD.Parameters.AddWithValue("@CMD", diacmd)
        CMD.Parameters.AddWithValue("@main_group_id", main_group_id)
        CMD.Parameters.AddWithValue("@main_group_name", main_gorup_name)
        CMD.Parameters.AddWithValue("@is_deletable", is_deletable)

        If diacmd = 3 Then
            Dim DT As New DataTable
            ADP = New SqlDataAdapter(CMD)
            ADP.Fill(DT)
            CTRL.DataSource = DT
        Else
            CMD.ExecuteNonQuery()
        End If
        VarCon.CloseConnection()
    End Sub
    Public Sub DIACRUD_GROUP(ByVal CTRL As DevExpress.XtraGrid.GridControl, ByVal diacmd As Integer, ByVal group_id As Integer, ByVal group_name As String, ByVal main_group_id As Integer, ByVal is_default As Boolean, ByVal under_group As Integer)
        Dim CMD As New SqlCommand
        CMD = New SqlCommand("GROUP_MASTER", VarCon.Connection)
        CMD.CommandType = CommandType.StoredProcedure
        CMD.Parameters.AddWithValue("@CMD", diacmd)
        CMD.Parameters.AddWithValue("@gorup_id", group_id)
        CMD.Parameters.AddWithValue("@group_name", group_name)
        CMD.Parameters.AddWithValue("@main_group_id", main_group_id)
        CMD.Parameters.AddWithValue("@under_group", under_group)
        CMD.Parameters.AddWithValue("@is_default", is_default)

        If diacmd = 3 Then
            Dim DT As New DataTable
            ADP = New SqlDataAdapter(CMD)
            ADP.Fill(DT)
            CTRL.DataSource = DT
        Else
            CMD.ExecuteNonQuery()
        End If
        VarCon.CloseConnection()
    End Sub
    Public Sub LedgerCRUD(ByVal CTRL As DevExpress.XtraGrid.GridControl, ByVal diacmd As Integer, ByVal LedgerID As Integer, ByVal CID As Integer, ByVal BID As Integer, ByVal UID As Integer, ByVal LedgerName As String, ByVal UnderGroup As Integer, ByVal Address As String, ByVal Country As String, ByVal State As String, ByVal City As String, ByVal Mobile As String, ByVal Phone As String, ByVal Email As String, ByVal GSTIN As String, ByVal PAN As String, ByVal Bank As String, ByVal AcNo As String, ByVal IFSC As String, ByVal Routing As String, ByVal Swift As String, ByVal OpeningBalance As Double)
        Try
            Dim CMD As New SqlCommand
            CMD = New SqlCommand("LEDGER_MASTER", VarCon.Connection)
            CMD.CommandType = CommandType.StoredProcedure
            CMD.Parameters.AddWithValue("@CMD", diacmd)
            CMD.Parameters.AddWithValue("@LedgerID", LedgerID)
            CMD.Parameters.AddWithValue("@CID", CID)
            CMD.Parameters.AddWithValue("@BID", BID)
            CMD.Parameters.AddWithValue("@UID", UID)
            CMD.Parameters.AddWithValue("@LedgerName", LedgerName)
            CMD.Parameters.AddWithValue("@UnderGroup", UnderGroup)
            CMD.Parameters.AddWithValue("@Address", Address)
            CMD.Parameters.AddWithValue("@Country", Country)
            CMD.Parameters.AddWithValue("@State", State)
            CMD.Parameters.AddWithValue("@City", City)
            CMD.Parameters.AddWithValue("@Mobile", Mobile)
            CMD.Parameters.AddWithValue("@Phone", Phone)
            CMD.Parameters.AddWithValue("@Email", Email)
            CMD.Parameters.AddWithValue("@GSTIN", GSTIN)
            CMD.Parameters.AddWithValue("@PAN", PAN)
            CMD.Parameters.AddWithValue("@Bank", Bank)
            CMD.Parameters.AddWithValue("@AcNo", AcNo)
            CMD.Parameters.AddWithValue("@IFSC", IFSC)
            CMD.Parameters.AddWithValue("@Routing", Routing)
            CMD.Parameters.AddWithValue("@Swift", Swift)
            CMD.Parameters.AddWithValue("@OpeningBalance", OpeningBalance)


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

        End Try

    End Sub
End Class
