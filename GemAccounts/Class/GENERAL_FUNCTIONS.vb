Imports GemAccounts.GLOBAL_VARIABLES
Imports System.Data.SqlClient
Imports System.Net
Imports GemAccounts.MasterConnection
Imports DevExpress.XtraSplashScreen

Public Class GENERAL_FUNCTIONS

    Public Sub AcceptNumer(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim clickedCtrl As Control
        If TypeOf sender Is Control Then
            clickedCtrl = DirectCast(sender, Control)
            If TypeOf clickedCtrl Is TextBox Then
                If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Asc(e.KeyChar) <> 46 AndAlso Not IsNumeric(e.KeyChar) Then
                    DevFunctions.ErrorMsg("Please enter numbers only")
                    e.Handled = True
                End If
            End If
        Else
        End If
    End Sub

    Public Shared Sub FocusNext(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Dim clickedCtrl As Control
        If TypeOf sender Is Control Then
            clickedCtrl = DirectCast(sender, Control)
            If TypeOf clickedCtrl Is TextBox Then
                If e.KeyValue = 222 Then
                    SendKeys.Send("{BACKSPACE}")
                End If
            End If
            If TypeOf clickedCtrl Is ComboBox Then
                If e.KeyValue = 13 Or e.KeyValue = 9 Then
                    SendKeys.Send("{TAB}")
                ElseIf e.KeyValue = 27 Then
                    SendKeys.Send("+{TAB}")
                ElseIf e.KeyValue = 46 Then
                    Dim cmbctrl As New ComboBox
                    cmbctrl = DirectCast(clickedCtrl, ComboBox)
                    If cmbctrl.DropDownStyle = ComboBoxStyle.DropDownList Then
                        cmbctrl.SelectedIndex = -1
                    Else
                        cmbctrl.SelectedIndex = -1
                    End If
                End If
            Else
                If e.KeyValue = 13 Or e.KeyValue = 9 Then
                    SendKeys.Send("{TAB}")
                    e.SuppressKeyPress = True
                ElseIf e.KeyValue = 27 Then
                    SendKeys.Send("+{TAB}")
                    e.SuppressKeyPress = True
                Else

                End If
            End If
        End If
    End Sub

    Public Sub NFillRoll(ByVal cmb As ComboBox, ByVal role As String)
        cmb.Items.Clear()
        If role = "SUPERADMIN" Then
            cmb.Items.Add("SUPERADMIN")
            cmb.Items.Add("ADMIN")
            cmb.Items.Add("USER")
        ElseIf role = "ADMIN" Then
            cmb.Items.Add("USER")
        Else

        End If
    End Sub
    Public Shared Sub NExcuteQuery(ByVal str As String)
        CMD = New SqlCommand(str, VarCon.Connection)
        CMD.ExecuteNonQuery()
        VarCon.CloseConnection()
    End Sub


    Public Sub NAutoNumberDropdown(ByVal ctrl As ComboBox, ByVal TableName As String, ByVal Nvalue As String, ByVal NDisplay As String)
        'Dim sql As String = "SELECT " & Nvalue & "," & NDisplay & " FROM " & TableName & " WHERE SID=" & SID & " and UID=" & UID & " ORDER BY " & NDisplay & " "
        'Dim MaxNo As Double = NAutoNumber("SELECT MAX(" & NDisplay & ") FROM " & TableName & " WHERE SID=" & SID & " and UID=" & UID & " ")
        'GLOBAL_VARIABLES.DS = New DataSet
        'ADP = New SqlDataAdapter(sql, VarCon.Connection)
        'ADP.Fill(GLOBAL_VARIABLES.DS)
        'GLOBAL_VARIABLES.DS.Tables(0).Rows.Add(0, MaxNo)
        'ctrl.DataSource = GLOBAL_VARIABLES.DS.Tables(0)
        'ctrl.ValueMember = Nvalue
        'ctrl.DisplayMember = NDisplay
        ''ctrl.SelectedIndex = -1
        'ctrl.Text = MaxNo
        'VarCon.CloseConnection()
    End Sub



    Public Function NAutoNumber(ByVal str As String) As Double
        Dim Id As Double
        Try
            CMD = New SqlCommand(str, VarCon.Connection)
            If IsDBNull(CMD.ExecuteScalar()) Then
                Id = 1
            Else
                Id = CMD.ExecuteScalar() + 1
            End If
            NAutoNumber = Id
        Catch
            NAutoNumber = 1
        End Try
        VarCon.CloseConnection()
    End Function
    Public Shared Function MaxNo(ByVal str As String) As Double
        Dim Id As Double
        Try
            CMD = New SqlCommand(str, VarCon.Connection)
            If IsDBNull(CMD.ExecuteScalar()) Then
                Id = 1111
            Else
                Id = CMD.ExecuteScalar() + 1
            End If
            MaxNo = Id
        Catch
            MaxNo = 1
        End Try
        VarCon.CloseConnection()
    End Function
    Public Function NCheckRecord(ByVal str As String) As Boolean
        'select count(pd) from pada
        Dim r As Integer
        NCheckRecord = False
        CMD = New SqlCommand(str, VarCon.Connection)
        r = CMD.ExecuteScalar
        If r > 0 Then
            NCheckRecord = True
        Else
            NCheckRecord = False
        End If
        VarCon.CloseConnection()
    End Function
    Public Sub NFillCombo(ByVal str As String, ByVal Nvalue As String, ByVal NDisplay As String, ByVal ctrl As ComboBox)
        GLOBAL_VARIABLES.DS = New DataSet
        ADP = New SqlDataAdapter(str, VarCon.Connection)
        ADP.Fill(GLOBAL_VARIABLES.DS)
        Dim dr As DataRow = DS.Tables(0).NewRow
        dr(Nvalue) = 0
        dr(NDisplay) = ""
        DS.Tables(0).Rows.InsertAt(dr, 0)
        ctrl.DataSource = DS.Tables(0)
        ctrl.ValueMember = Nvalue
        ctrl.DisplayMember = NDisplay
        VarCon.CloseConnection()
        ctrl.SelectedValue = 0
    End Sub
    Public Sub NFillComboWithOneListMemberBlank(ByVal str As String, ByVal Nvalue As String, ByVal NDisplay As String, ByVal ctrl As ComboBox)
        DS = New DataSet
        ADP = New SqlDataAdapter(str, VarCon.Connection)
        ADP.Fill(DS)
        Dim dr As DataRow = DS.Tables(0).NewRow
        dr(Nvalue) = 0
        dr(NDisplay) = ""
        DS.Tables(0).Rows.InsertAt(dr, 0)
        ctrl.DataSource = DS.Tables(0)
        ctrl.ValueMember = Nvalue
        ctrl.DisplayMember = NDisplay
        VarCon.CloseConnection()
    End Sub
    Public Function NValid(ByVal ctrl As Control, ByVal str As String) As Boolean
        NValid = True
        If ctrl.Text = "" Then
            MsgBox("Please enter" & str, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Invalid")
            NValid = False
        End If
    End Function
    Public Sub NClearTotalLable(ByVal parent As Control)
        For Each c As Control In parent.Controls
            If (c.Controls.Count > 0) Then
                NClearingControl(c)
            Else
                If TypeOf c Is Label Then
                    If c.Text = "Total" Or c.Text = "Total:" Or c.Text = "Total :" Then
                    Else
                        CType(c, Label).Text = "0"
                    End If
                End If
            End If
        Next
    End Sub
    Public Sub NClearingControl(ByVal parent As Control)
        For Each c As Control In parent.Controls
            If (c.Controls.Count > 0) Then
                NClearingControl(c)
            Else
                If TypeOf c Is TextBox Then
                    CType(c, TextBox).Text = ""
                End If
                If TypeOf c Is ComboBox Then
                    If CType(c, ComboBox).DropDownStyle = ComboBoxStyle.DropDown Then
                        CType(c, ComboBox).Text = ""
                    Else
                        CType(c, ComboBox).SelectedIndex = -1
                    End If
                End If
                If TypeOf c Is DateTimePicker Then
                    CType(c, DateTimePicker).Value = Now
                End If
            End If
        Next
    End Sub
    Public Sub NClearingControlD(ByVal parent As Control)
        For Each c As Control In parent.Controls
            If (c.Controls.Count > 0) Then
                NClearingControlD(c)
            Else
                If TypeOf c Is TextBox Then
                    CType(c, TextBox).Text = ""
                End If
                If TypeOf c Is ComboBox Then
                    If CType(c, ComboBox).DropDownStyle = ComboBoxStyle.DropDown Then
                        CType(c, ComboBox).Text = ""
                    Else
                        CType(c, ComboBox).SelectedIndex = -1
                    End If
                End If
            End If
        Next
    End Sub
    Public Sub NSelectText(ByVal ctrl As Control)
        If TypeOf ctrl Is TextBox Then
            CType(ctrl, TextBox).SelectAll()
        End If
        If TypeOf ctrl Is ComboBox Then
            CType(ctrl, ComboBox).SelectAll()
        End If
    End Sub
    Public Sub NUppercaseControl(ByVal parent As Control)
        For Each c As Control In parent.Controls
            If (c.Controls.Count > 0) Then
                NClearingControl(c)
            Else
                If TypeOf c Is TextBox Then
                    CType(c, TextBox).CharacterCasing = CharacterCasing.Upper
                End If
            End If
        Next
    End Sub
    Public Sub NUnLockControl(ByVal parent As Control)
        For Each c As Control In parent.Controls
            If (c.Controls.Count > 0) Then
                NLockControl(c)
            Else
                If TypeOf c Is TextBox Then
                    CType(c, TextBox).Enabled = True
                End If
                If TypeOf c Is ComboBox Then
                    CType(c, ComboBox).Enabled = True
                End If
                If TypeOf c Is DateTimePicker Then
                    CType(c, DateTimePicker).Enabled = True
                End If
            End If
        Next
    End Sub
    Public Sub NLockControl(ByVal parent As Control)
        For Each c As Control In parent.Controls
            If (c.Controls.Count > 0) Then
                NUnLockControl(c)
            Else
                If TypeOf c Is TextBox Then
                    CType(c, TextBox).Enabled = False
                End If
                If TypeOf c Is ComboBox Then
                    CType(c, ComboBox).Enabled = False
                End If
                If TypeOf c Is DateTimePicker Then
                    CType(c, DateTimePicker).Enabled = False
                End If
            End If
        Next
    End Sub
    Public Sub DisableingControl(ByVal frm As Form, ByVal ctrl As Control)
        For Each ctrl In frm.Controls
            If TypeOf ctrl Is Button Then
                ctrl.Enabled = True
            End If
        Next
    End Sub
    Public Sub NDropDown(ByVal ctrl As ComboBox)
        If TypeOf ctrl Is ComboBox Then
            ctrl.DroppedDown = True
        End If
    End Sub
    Public Sub DisableControl(ByVal a As Integer, ByVal e As Integer, ByVal d As Integer, ByVal f As Integer, ByVal frm As Form, ByVal ctrl As Control)
        For Each ctrl In frm.Controls
            If TypeOf ctrl Is Button Then
                If ctrl.Name = "CmdAdd" And a = 1 Then
                    ctrl.Enabled = False
                Else
                    ctrl.Enabled = True
                End If

                If ctrl.Name = "CmdEdit" And e = 1 Then
                    ctrl.Enabled = False
                Else
                    ctrl.Enabled = True
                End If

                If ctrl.Name = "CmdDelete" And d = 1 Then
                    ctrl.Enabled = False
                Else
                    ctrl.Enabled = True
                End If

                If ctrl.Name = "CmdFind" And f = 1 Then
                    ctrl.Enabled = False
                Else
                    ctrl.Enabled = True
                End If
            End If
        Next
    End Sub
    Public Sub EnableControl(ByVal frm As Form)
        Dim ctrl As Control
        For Each ctrl In frm.Controls
            If TypeOf ctrl Is Button Then
                ctrl.Enabled = True
            End If
        Next
    End Sub
    Public Function NValidNumber(ByVal e As Char) As Char
        Select Case e
            Case Chr(45) To Chr(57)
                NValidNumber = e
            Case Chr(8)
                NValidNumber = e
            Case Chr(190)
                NValidNumber = e
            Case Else
                NValidNumber = Chr(0)
        End Select
    End Function
    Public Sub NChangeColorG(ByVal ctrl As Control)
        If TypeOf ctrl Is TextBox Or TypeOf ctrl Is ComboBox Or TypeOf ctrl Is ListBox Then
            ctrl.BackColor = Color.Chocolate
            ctrl.ForeColor = Color.White
        End If
    End Sub
    Public Sub NChangeColorL(ByVal ctrl As Control)
        If TypeOf ctrl Is TextBox Or TypeOf ctrl Is ComboBox Or TypeOf ctrl Is ListBox Then
            ctrl.BackColor = Color.White
            ctrl.ForeColor = Color.Black
        End If
    End Sub

    Public Sub NValidEmail(ByVal ctrl As Control)
        If Not System.Text.RegularExpressions.Regex.IsMatch(ctrl.Text, "^([\w-]+\.)*?[\w-]+@[\w-]+\.([\w-]+\.)*?[\w]+$") Then
            ctrl.BackColor = Color.Red
        Else
            ctrl.BackColor = Color.White
        End If
    End Sub
    'Public Sub NValidGST(ByVal ctrl As Control)
    '    If Not System.Text.RegularExpressions.Regex.IsMatch(ctrl.Text, "/^[0-9]{2}[A-Z]{5}[0-9]{4}[A-Z]{1}[1-9A-Z]{1}Z[0-9A-Z]{1}$/") Then
    '        ctrl.BackColor = Color.Red
    '    Else
    '        ctrl.BackColor = Color.White
    '    End If
    'End Sub

    Public Sub NSetFocus(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Dim clickedCtrl As Control
        If TypeOf sender Is Control Then
            clickedCtrl = DirectCast(sender, Control)
            If TypeOf clickedCtrl Is TextBox Then
                If e.KeyValue = 222 Then
                    SendKeys.Send("{BACKSPACE}")
                End If
            End If
            If TypeOf clickedCtrl Is ComboBox Then
                If e.KeyValue = 13 Or e.KeyValue = 9 Then
                    SendKeys.Send("{TAB}")
                ElseIf e.KeyValue = 27 Then
                    SendKeys.Send("+{TAB}")
                ElseIf e.KeyValue = 46 Then
                    Dim cmbctrl As New ComboBox
                    cmbctrl = DirectCast(clickedCtrl, ComboBox)
                    If cmbctrl.DropDownStyle = ComboBoxStyle.DropDownList Then
                        cmbctrl.SelectedIndex = -1
                    Else
                        cmbctrl.SelectedIndex = -1
                    End If
                End If
            Else
                If e.KeyValue = 13 Or e.KeyValue = 9 Then
                    SendKeys.Send("{TAB}")
                    e.SuppressKeyPress = True
                ElseIf e.KeyValue = 27 Then
                    SendKeys.Send("+{TAB}")
                    e.SuppressKeyPress = True
                Else

                End If
            End If
        End If
    End Sub
    Public Function NInputNumber(ByVal str As String) As String
        Return System.Text.RegularExpressions.Regex.Replace(str, "[a-zA-Z\b\s-]", "")
    End Function
    Public Function NInputAlphabet(ByVal str As String) As String
        Return System.Text.RegularExpressions.Regex.Replace(str, "[0-9\b\s-.]", "")
    End Function
    Public Function NInputDate(ByVal str As String, ByVal format1 As String) As String
        If format1 = "dd/MM/yyyy" Then
            Return System.Text.RegularExpressions.Regex.Replace(str, "(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)[0-9]{2}(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)[0-9]{2}", "")
        ElseIf format1 = "MM/dd/yyyy" Then
            Return System.Text.RegularExpressions.Regex.Replace(str, "(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)[0-9]{2}(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)[0-9]{2}", "")
        Else
            Return System.Text.RegularExpressions.Regex.Replace(str, "(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)[0-9]{2}(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)[0-9]{2}", "")
        End If
    End Function
    Public Function isEmail(ByVal inputEmail As String) As Boolean
        Dim pattern As String
        pattern = "^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" & "\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" & ".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"
        If System.Text.RegularExpressions.Regex.IsMatch(inputEmail, pattern) = True Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function NCreateFilename() As String
        Dim d As Int16
        Dim m As Int16
        Dim t As Int16
        Dim mm As Int16
        Dim x As New Date
        x = Date.Now
        d = x.Day
        m = x.Month
        t = x.Hour
        mm = x.Minute

        Return "Medi" & d & m & t & mm
    End Function
    Public Sub NShowDialog(ByVal frm As Form)
        frm.ShowInTaskbar = False
        frm.FormBorderStyle = FormBorderStyle.FixedToolWindow
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.Text = "Desai Trading Management System"
        frm.ShowDialog()
    End Sub
    Public Sub NShowDialogNoBorder(ByVal frm As Form)
        frm.ShowInTaskbar = False
        frm.FormBorderStyle = FormBorderStyle.None
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.ShowDialog()
    End Sub
    Public Sub NShowInMdi(ByVal frm As Form, ByVal mdi As Form)
        Try
            frm.Text = ""
            frm.MdiParent = mdi
            frm.MaximizeBox = False
            frm.FormBorderStyle = FormBorderStyle.FixedToolWindow
            frm.StartPosition = FormStartPosition.CenterScreen
            'frm.ShowIcon = False
            frm.Show()
        Catch ex As Exception
        End Try
    End Sub
    Public Sub NDateFormat(ByVal dt As DateTimePicker)
        'dt.Value = Now
        'dt.Format = DateTimePickerFormat.Custom
        'dt.CustomFormat = _DateFormat
        'dt.CalendarFont = New Font("Verdana", 9, FontStyle.Regular)
        'dt.CalendarForeColor = Color.Black
        'dt.CalendarMonthBackground = Color.Bisque
        'dt.CalendarTitleBackColor = Color.SaddleBrown
        'dt.CalendarTitleForeColor = Color.Bisque
        'dt.CalendarTrailingForeColor = Color.Bisque
    End Sub
    Public Sub NDateFormatMonth(ByVal dt As DateTimePicker)
        dt.Value = Now
        dt.Format = DateTimePickerFormat.Custom
        dt.CustomFormat = "MMM/yyyy"
        dt.CalendarFont = New Font("Verdana", 9, FontStyle.Regular)
        dt.CalendarForeColor = Color.Black
        dt.CalendarMonthBackground = Color.Bisque
        dt.CalendarTitleBackColor = Color.SaddleBrown
        dt.CalendarTitleForeColor = Color.Bisque
        dt.CalendarTrailingForeColor = Color.Bisque
    End Sub
    Public Sub NGridFormatingPlain(ByVal DataGrid As DataGridView)
        DataGrid.AllowUserToAddRows = False
        DataGrid.AllowUserToDeleteRows = False
        DataGrid.AllowUserToOrderColumns = False
        DataGrid.AllowUserToResizeRows = False
        DataGrid.ReadOnly = True
        DataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGrid.RowsDefaultCellStyle.SelectionBackColor = Color.White
        DataGrid.RowsDefaultCellStyle.SelectionForeColor = Color.Black
        DataGrid.EnableHeadersVisualStyles = False
        DataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.BurlyWood
        DataGrid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.ColumnHeadersDefaultCellStyle.Font = New Font("Verdana", 8, FontStyle.Bold)
        DataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGrid.ColumnHeadersHeight = 20
        DataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGrid.RowHeadersDefaultCellStyle.BackColor = Color.BurlyWood
        DataGrid.RowHeadersVisible = False

        DataGrid.Font = New Font("Verdana", 8, FontStyle.Regular)
        DataGrid.ForeColor = Color.Black

    End Sub
    Public Sub NGridFormating(ByVal DataGrid As DataGridView)
        DataGrid.AllowUserToAddRows = False
        DataGrid.AllowUserToDeleteRows = False
        DataGrid.AllowUserToOrderColumns = False
        DataGrid.AllowUserToResizeRows = False
        DataGrid.ReadOnly = True
        DataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGrid.RowsDefaultCellStyle.SelectionBackColor = Color.SaddleBrown
        DataGrid.RowsDefaultCellStyle.SelectionForeColor = Color.Bisque
        DataGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.BurlyWood
        DataGrid.EnableHeadersVisualStyles = False
        DataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.BurlyWood
        DataGrid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.ColumnHeadersDefaultCellStyle.Font = New Font("Verdana", 8, FontStyle.Bold)
        DataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGrid.ColumnHeadersHeight = 30
        DataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing

        DataGrid.RowHeadersDefaultCellStyle.BackColor = Color.BurlyWood
        DataGrid.RowHeadersVisible = False

        DataGrid.Font = New Font("Verdana", 8, FontStyle.Regular)
        DataGrid.ForeColor = Color.Black

    End Sub
    Public Sub NGridFormatingSplit(ByVal DataGrid As DataGridView)
        DataGrid.AllowUserToAddRows = False
        DataGrid.AllowUserToDeleteRows = False
        DataGrid.AllowUserToOrderColumns = False
        DataGrid.AllowUserToResizeRows = False
        DataGrid.ReadOnly = True
        DataGrid.BorderStyle = BorderStyle.FixedSingle
        DataGrid.MultiSelect = True
        DataGrid.SelectionMode = DataGridViewSelectionMode.CellSelect
        DataGrid.RowsDefaultCellStyle.SelectionBackColor = Color.SaddleBrown
        DataGrid.RowsDefaultCellStyle.SelectionForeColor = Color.Bisque
        DataGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.BurlyWood
        DataGrid.EnableHeadersVisualStyles = False
        DataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.BurlyWood
        DataGrid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.ColumnHeadersDefaultCellStyle.Font = New Font("Verdana", 8, FontStyle.Bold)
        DataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGrid.ColumnHeadersHeight = 30
        DataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGrid.RowHeadersDefaultCellStyle.BackColor = Color.BurlyWood
        DataGrid.RowHeadersVisible = False
        DataGrid.Font = New Font("Verdana", 8, FontStyle.Regular)
        DataGrid.ForeColor = Color.Black

    End Sub
    Public Sub NGridFormatingChild(ByVal DataGrid As DataGridView)
        DataGrid.AllowUserToAddRows = False
        DataGrid.AllowUserToDeleteRows = True
        DataGrid.AllowUserToOrderColumns = False
        DataGrid.AllowUserToResizeRows = False
        DataGrid.ReadOnly = True
        DataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGrid.RowsDefaultCellStyle.SelectionBackColor = Color.SaddleBrown
        DataGrid.RowsDefaultCellStyle.SelectionForeColor = Color.Bisque
        DataGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.BurlyWood
        DataGrid.EnableHeadersVisualStyles = False
        DataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.BurlyWood
        DataGrid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.ColumnHeadersDefaultCellStyle.Font = New Font("Verdana", 8, FontStyle.Bold)
        DataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGrid.ColumnHeadersHeight = 30
        DataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing

        DataGrid.RowHeadersDefaultCellStyle.BackColor = Color.BurlyWood
        DataGrid.RowHeadersVisible = False

        DataGrid.Font = New Font("Verdana", 8, FontStyle.Regular)

    End Sub
    Public Sub NGridFormatingEdit(ByVal DataGrid As DataGridView)
        DataGrid.AllowUserToAddRows = False
        DataGrid.AllowUserToDeleteRows = True
        DataGrid.AllowUserToOrderColumns = False
        DataGrid.AllowUserToResizeRows = False
        DataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGrid.RowsDefaultCellStyle.SelectionBackColor = Color.SaddleBrown
        DataGrid.RowsDefaultCellStyle.SelectionForeColor = Color.Bisque
        DataGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.BurlyWood
        DataGrid.EnableHeadersVisualStyles = False
        DataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.BurlyWood
        DataGrid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.ColumnHeadersDefaultCellStyle.Font = New Font("Verdana", 8, FontStyle.Bold)
        DataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGrid.ColumnHeadersHeight = 30
        DataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing

        DataGrid.RowHeadersDefaultCellStyle.BackColor = Color.BurlyWood
        DataGrid.RowHeadersVisible = False

        DataGrid.Font = New Font("Verdana", 8, FontStyle.Regular)
    End Sub
    Public Sub NClearGrid(ByVal ctrl As DataGridView)
        Try
            Dim i As Integer
            For i = ctrl.Rows.Count - 1 To 0 Step -1
                ctrl.Rows.RemoveAt(i)
            Next
        Catch ex As Exception
            MsgBox("")
        End Try
    End Sub
    Public Function NsetDateFormat(ByVal dt As Date) As Date
        NsetDateFormat = Format(dt, "MM/dd/yyyy")
    End Function
    Function GetFigures(ByVal X As String) As String

        Dim one(10) As String, two(10) As String, Three(10) As String, Hundred As String, Thousand As String, lakh As String, Crore As String, Billion As String
        one(0) = "Zero" : one(1) = "One" : one(2) = "Two" : one(3) = "Three" : one(4) = "Four" : one(5) = "Five" : one(6) = "Six" : one(7) = "Seven" : one(8) = "Eight" : one(9) = "Nine"
        two(0) = "Ten" : two(1) = "Eleven" : two(2) = "Twelve" : two(3) = "Thirteen" : two(4) = "Fourteen" : two(5) = "Fifteen" : two(6) = "Sixteen" : two(7) = "Seventeen" : two(8) = "Eightteen" : two(9) = "Nineteen"
        Three(2) = "Twenty" : Three(3) = "Thirty" : Three(4) = "Fourty" : Three(5) = "Fifty" : Three(6) = "Sixty" : Three(7) = "Seventy" : Three(8) = "Eighty" : Three(9) = "Ninety"
        Hundred = "Hundred" : Thousand = "Thousand" : lakh = "Lakh" : Crore = "Crore" : Billion = "Billion"

        Dim inp As String, RetVal As String

        inp = Math.Abs(Val(X))

        RetVal = ""
        Select Case Len(inp)
            Case 1
                RetVal = one(X)

            Case 2

                If Int(Right(inp, 1)) > 0 And Left(inp, 1) > 1 Then RetVal = GetFigures(Int(Right(inp, 1))) ' from 20 to 90 step 10

                If Left(inp, 1) > 1 Then RetVal = Three(Left(inp, 1)) + RetVal ' from 20-99
                If Left(inp, 1) = 1 Then RetVal = two(Right(inp, 1)) ' from 11-19 range

            Case 3
                If Int(Right(inp, 2)) > 0 Then RetVal = GetFigures(Int(Right(inp, 2)))
                RetVal = GetFigures(Int(Left(inp, 1))) + Hundred + RetVal

            Case 4
                If Int(Right(inp, 3)) > 0 Then RetVal = GetFigures(Int(Right(inp, 3)))
                RetVal = GetFigures(Int(Left(inp, 1))) + Thousand + RetVal

            Case 5
                If Int(Right(inp, 3)) > 0 Then RetVal = GetFigures(Int(Right(inp, 3)))
                RetVal = GetFigures(Int(Left(inp, 2))) + Thousand + RetVal

            Case 6
                If CLng(Right(inp, 5)) > 0 Then RetVal = GetFigures(CLng(Right(inp, 5)))
                RetVal = GetFigures(Int(Left(inp, 1))) + lakh + RetVal

            Case 7
                If CLng(Right(inp, 5)) > 0 Then RetVal = GetFigures(CLng(Right(inp, 5)))
                RetVal = GetFigures(Int(Left(inp, 2))) + lakh + RetVal

            Case 8
                If CLng(Right(inp, 7)) > 0 Then RetVal = GetFigures(CLng(Right(inp, 7)))
                RetVal = GetFigures(Int(Left(inp, 1))) + Crore + RetVal

            Case 9
                If CLng(Right(inp, 7)) > 0 Then RetVal = GetFigures(CLng(Right(inp, 7)))
                RetVal = GetFigures(Int(Left(inp, 2))) + Crore + RetVal

            Case 10
                If CLng(Right(inp, 9)) > 0 Then RetVal = GetFigures(CLng(Right(inp, 9)))
                RetVal = GetFigures(Int(Left(inp, 1))) + Billion + RetVal

            Case 11
                If CLng(Right(inp, 9)) > 0 Then RetVal = GetFigures(CLng(Right(inp, 9)))
                RetVal = GetFigures(Int(Left(inp, 2))) + Billion + RetVal

            Case 12
                If Val(Right(inp, 11)) > 0 Then RetVal = GetFigures(Right(inp, 11))
                RetVal = GetFigures(Int(Left(inp, 1))) + "Million" + RetVal

            Case 13
                If Val(Right(inp, 11)) > 0 Then RetVal = GetFigures(Right(inp, 11))
                RetVal = GetFigures(Int(Left(inp, 2))) + "Million" + RetVal

            Case 14
                If Val(Right(inp, 13)) > 0 Then RetVal = GetFigures(Right(inp, 13))
                RetVal = GetFigures(Int(Left(inp, 1))) + "Trillion" + RetVal

            Case 15
                If Val(Right(inp, 13)) > 0 Then RetVal = GetFigures(Right(inp, 13))
                RetVal = GetFigures(Int(Left(inp, 2))) + "Trillion" + RetVal

        End Select

        GetFigures = " " + RetVal + " "

        GetFigures = Replace(GetFigures, "  ", " ")

    End Function
    Public Function AmountInWords(ByVal nAmount As String, Optional ByVal wAmount As String = vbNullString, Optional ByVal nSet As Object = Nothing) As String
        'Let's make sure entered value is numeric
        If Not IsNumeric(nAmount) Then Return "Please enter numeric values only."

        Dim tempDecValue As String = String.Empty : If InStr(nAmount, ".") Then _
            tempDecValue = nAmount.Substring(nAmount.IndexOf("."))
        nAmount = Replace(nAmount, tempDecValue, String.Empty)

        Try
            Dim intAmount As Long = nAmount
            If intAmount > 0 Then
                nSet = IIf((intAmount.ToString.Trim.Length / 3) _
                 > (CLng(intAmount.ToString.Trim.Length / 3)),
                  CLng(intAmount.ToString.Trim.Length / 3) + 1,
                   CLng(intAmount.ToString.Trim.Length / 3))
                Dim eAmount As Long = Microsoft.VisualBasic.Left(intAmount.ToString.Trim,
                  (intAmount.ToString.Trim.Length - ((nSet - 1) * 3)))
                Dim multiplier As Long = 10 ^ (((nSet - 1) * 3))

                Dim Ones() As String =
                {"", "One", "Two", "Three",
                  "Four", "Five",
                  "Six", "Seven", "Eight", "Nine"}
                Dim Teens() As String = {"",
                "Eleven", "Twelve", "Thirteen",
                  "Fourteen", "Fifteen",
                  "Sixteen", "Seventeen", "Eighteen", "Nineteen"}
                Dim Tens() As String = {"", "Ten",
                "Twenty", "Thirty",
                  "Forty", "Fifty", "Sixty",
                  "Seventy", "Eighty", "Ninety"}
                Dim HMBT() As String = {"", "",
                "Thousand", "Million",
                  "Billion", "Trillion",
                  "Quadrillion", "Quintillion"}

                intAmount = eAmount

                Dim nHundred As Integer = intAmount \ 100 : intAmount = intAmount Mod 100
                Dim nTen As Integer = intAmount \ 10 : intAmount = intAmount Mod 10
                Dim nOne As Integer = intAmount \ 1

                If nHundred > 0 Then wAmount = wAmount &
                Ones(nHundred) & " Hundred " 'This is for hundreds                
                If nTen > 0 Then 'This is for tens and teens
                    If nTen = 1 And nOne > 0 Then 'This is for teens 
                        wAmount = wAmount & Teens(nOne) & " "
                    Else 'This is for tens, 10 to 90
                        wAmount = wAmount & Tens(nTen) & IIf(nOne > 0, "-", " ")
                        If nOne > 0 Then wAmount = wAmount & Ones(nOne) & " "
                    End If
                Else 'This is for ones, 1 to 9
                    If nOne > 0 Then wAmount = wAmount & Ones(nOne) & " "
                End If
                wAmount = wAmount & HMBT(nSet) & " "
                wAmount = AmountInWords(CStr(CLng(nAmount) -
                  (eAmount * multiplier)).Trim & tempDecValue, wAmount, nSet - 1)
            Else
                If Val(nAmount) = 0 Then nAmount = nAmount &
                tempDecValue : tempDecValue = String.Empty
                If (Math.Round(Val(nAmount), 2) * 100) > 0 Then wAmount =
                  Trim(AmountInWords(CStr(Math.Round(Val(nAmount), 2) * 100),
                  wAmount.Trim & " Ruppes And ", 1)) & " Paisa"
            End If
        Catch ex As Exception
            MessageBox.Show("Error Encountered: " & ex.Message,
              "Convert Numbers To Words",
              MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return "!#ERROR_ENCOUNTERED"
        End Try

        'Trap null values
        If IsNothing(wAmount) = True Then wAmount = String.Empty Else wAmount =
          IIf(InStr(wAmount.Trim.ToLower, "ruppes"),
          wAmount.Trim, wAmount.Trim & " Ruppes")

        'Display the result
        Return wAmount
    End Function
    Public Function IsConnectionAvailable() As Boolean
        Dim objUrl As New System.Uri("http://www.desaisoftware.com/")
        ' Setup WebRequest
        Dim objWebReq As System.Net.WebRequest
        objWebReq = System.Net.WebRequest.Create(objUrl)
        Dim objResp As System.Net.WebResponse
        Try
            ' Attempt to get response and return True
            objResp = objWebReq.GetResponse
            objResp.Close()
            objWebReq = Nothing
            Return True
        Catch ex As Exception
            ' Error, exit and return False
            ' objResp.Close()
            objWebReq = Nothing
            Return False
        End Try
    End Function
    Public Sub NShowNavigate(ByVal Ctrl As DataGridView)
        Dim Nid As Double = Val(Ctrl.CurrentRow.Cells("ColNid").Value)
        Dim Nurl As String = Ctrl.CurrentRow.Cells("ColNurl").Value
        NShowNavigateLink(Nid, Nurl)
    End Sub
    Public Sub NShowNavigateLink(ByVal Nid As Double, ByVal Nurl As String)
        'If Nid = 0 Or IsDBNull(Nid) = True Then Exit Sub
        '_RepName = Nurl
        'If Nid = _Order Then
        '    NShowDialog(FrmTransOrder)
        '    FrmTransOrder.Close()
        'ElseIf Nid = _OrderBill Then
        '    NShowDialog(FrmTransOrderBill)
        '    FrmTransOrderBill.Close()
        'ElseIf Nid = _Purchase Then
        '    NShowDialog(FrmTransPurchase)
        '    FrmTransPurchase.Close()
        'ElseIf Nid = _Payment Then
        '    NShowDialog(FrmTransPaymentBill)
        '    FrmTransPaymentBill.Close()
        'ElseIf Nid = _Sales Then
        '    NShowDialog(FrmTransSale)
        '    FrmTransSale.Close()
        'ElseIf Nid = _Receipt Then
        '    NShowDialog(FrmTransReceiptBill)
        '    FrmTransReceiptBill.Close()
        'ElseIf Nid = _Voucher Then
        '    NShowDialog(FrmTransVoucher)
        '    FrmTransVoucher.Close()
        'Else
        '    Exit Sub
        'End If


    End Sub
    Public Function SaveMessage() As Boolean
        If MsgBox("Are you sure to save data...", MsgBoxStyle.Information + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton1, "Saved...") = MsgBoxResult.Yes Then
            SaveMessage = True
        Else
            SaveMessage = False
        End If
    End Function
    Public Function PrintMessage() As Boolean
        If MsgBox("Are you sure to print data...", MsgBoxStyle.Information + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton1, "Print...") = MsgBoxResult.Yes Then
            PrintMessage = True
        Else
            PrintMessage = False
        End If
    End Function
    Public Sub EditMessage()
        MsgBox("Data is permenent Updated..", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Data Updated")
    End Sub
    Public Function DeleteMessage() As Boolean
        If MsgBox("Data is permenent Deleted..", MsgBoxStyle.Information + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton1, "Delete...") = MsgBoxResult.Yes Then
            DeleteMessage = True
        Else
            DeleteMessage = False
        End If
    End Function
    Public Sub LinkMessage()
        MsgBox("Data is Linked to another Data..", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Data Deleted")
    End Sub
    Public Sub InvalidMessage(ByVal msg As String)
        MsgBox(msg + " must be required..", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Invalid Opration")
    End Sub
    Public Sub NAllreadyMessage(ByVal msg As String)
        MsgBox(msg + " is already exits..", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Invalid Opration")
    End Sub
    Public Function NExitMessage() As Boolean
        If MsgBox("Are you sure quit this application..", MsgBoxStyle.Information + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton1, "Quit...") = MsgBoxResult.Yes Then
            NExitMessage = True
        Else
            NExitMessage = False
        End If
    End Function
    Public Sub ErrorMessage()
        MsgBox(Err.Number & ": " & Err.Description, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Invalid Report")
    End Sub
    Public Function NFetchDataN(ByVal STR As String) As Double
        CMD = New SqlCommand(STR, VarCon.Connection)
        If IsDBNull(CMD.ExecuteScalar()) Then
            NFetchDataN = 0
        Else
            NFetchDataN = CMD.ExecuteScalar()
        End If
        VarCon.CloseConnection()
    End Function
    Public Function NFetchRecords(ByVal STR As String) As Double
        CMD = New SqlCommand(STR, VarCon.Connection)
        If IsDBNull(CMD.ExecuteScalar()) Then
            NFetchRecords = 0
        Else
            NFetchRecords = CMD.ExecuteScalar()
        End If
        VarCon.CloseConnection()
    End Function

    Public Shared Function NFetchDatatable(ByVal Query As String) As DataTable
        Dim dtp As New DataSet
        ADP = New SqlDataAdapter(Query, VarCon.Connection)
        ADP.Fill(dtp)
        NFetchDatatable = dtp.Tables(0)
        VarCon.CloseConnection()
    End Function
    Public Sub FillPayment(ByVal CTRL As ComboBox)
        Dim Dt As New DataTable
        Dt.Columns.Add("SRNO", GetType(Integer))
        Dt.Columns.Add("PTYPE", GetType(String))
        Dt.Rows.Add(0, "CREDIT")
        Dt.Rows.Add(1, "CASH")
        Dim dr As New DataTable
        dr = NFetchDatatable("SELECT SRNO,ANAME FROM MST_AC WHERE AG=2 AND BTYPE IN ('PAYMENT UPI','CREDIT CARD')")
        For I As Integer = 0 To dr.Rows.Count - 1
            Dt.Rows.Add(dr.Rows(I).Item("SRNO"), dr.Rows(I).Item("ANAME"))
        Next
        CTRL.DataSource = Dt
        CTRL.ValueMember = "SRNO"
        CTRL.DisplayMember = "PTYPE"
        CTRL.SelectedValue = 0
    End Sub

    Public Shared Function NFetchDataRow(ByVal Query As String) As DataRow
        Try
            Dim dtp As New DataTable
            ADP = New SqlDataAdapter(Query, VarCon.Connection)
            ADP.Fill(dtp)
            If dtp.Rows.Count = Nothing Then
                NFetchDataRow = Nothing
                Exit Function
            Else
                NFetchDataRow = dtp.Rows(0)
                Return NFetchDataRow
            End If
        Catch ex As Exception
            DevFunctions.ErrorMsg(ex.Message)
            NFetchDataRow = Nothing
        Finally
            VarCon.CloseConnection()
        End Try
    End Function
    Public Sub NFillDataGrid(ByVal Query As String, ByVal ctrl As DataGridView)
        Dim DT As New DataTable
        ADP = New SqlDataAdapter(Query, VarCon.Connection)
        ADP.Fill(DT)
        ctrl.DataSource = DT
        VarCon.CloseConnection()
    End Sub
    Public Shared Function NExcuteScaler(ByVal str As String) As String
        CMD = New SqlCommand(str, VarCon.Connection)
        Try
            NExcuteScaler = CMD.ExecuteScalar()
        Catch
            NExcuteScaler = 0
        End Try
        VarCon.CloseConnection()
    End Function
    Public Shared Function NExcuteScalerDate(ByVal str As String) As DateTime
        CMD = New SqlCommand(str, VarCon.Connection)
        Try
            NExcuteScalerDate = CMD.ExecuteScalar()
        Catch ex As Exception
            DevFunctions.ErrorMsg(ex.Message)
        End Try
        VarCon.CloseConnection()
        Return NExcuteScalerDate
    End Function
    Public Shared Function NExcuteScalerInt(ByVal str As String) As Integer
        CMD = New SqlCommand(str, VarCon.Connection)
        Try
            NExcuteScalerInt = CMD.ExecuteScalar()
        Catch
            NExcuteScalerInt = 0
        End Try
        VarCon.CloseConnection()
    End Function

    Public Function NFetchDataB(ByVal STR As String) As Boolean
        CMD = New SqlCommand(STR, VarCon.Connection)
        If IsDBNull(CMD.ExecuteScalar()) Then
            NFetchDataB = False
        Else
            NFetchDataB = CMD.ExecuteScalar()
        End If
        VarCon.CloseConnection()
    End Function
    Public Function NFetchDataC(ByVal STR As String) As String
        CMD = New SqlCommand(STR, VarCon.Connection)
        If IsDBNull(CMD.ExecuteScalar()) Then
            NFetchDataC = "False"
        Else
            NFetchDataC = CMD.ExecuteScalar()
        End If
        VarCon.CloseConnection()
    End Function
    Public Sub FillParty(ByVal CTRL As ComboBox)
        NFillCombo("SELECT SRNO, ANAME FROM MST_AC WHERE AG IN (3) AND SFLAG='True' ORDER BY ANAME", "SRNO", "ANAME", CTRL)
    End Sub
    Public Sub FillAccount(ByVal CTRL As ComboBox)
        NFillCombo("SELECT SRNO, ANAME FROM MST_AC WHERE AG IN (13) AND SFLAG='True' ORDER BY ANAME", "SRNO", "ANAME", CTRL)
    End Sub
    Public Sub FillIncome(ByVal CTRL As ComboBox)
        NFillCombo("SELECT SRNO, ANAME FROM MST_AC WHERE AG IN (12) AND SFLAG='True' ORDER BY ANAME", "SRNO", "ANAME", CTRL)
    End Sub
    Public Sub FillEmployee(ByVal CTRL As ComboBox)
        NFillCombo("SELECT SRNO, ANAME FROM MST_AC WHERE AG IN (6) AND SFLAG='True' ORDER BY ANAME", "SRNO", "ANAME", CTRL)
    End Sub
    Public Sub FillAgComobo(ByVal ctrl As ComboBox)
        NFillCombo("SELECT SRNO,AG FROM MST_AG WHERE SFLAG ='True'  ORDER BY AG", "SRNO", "AG", ctrl)
    End Sub
    Public Sub FillCustomerGroup(ByVal ctrl As ComboBox)
        NFillCombo("SELECT SRNO,GNAME FROM MST_CGROUP ORDER BY SRNO", "SRNO", "GNAME", ctrl)
    End Sub
    Public Sub FillEmployeeGroup(ByVal ctrl As ComboBox)
        NFillCombo("SELECT SRNO,GNAME FROM MST_EGROUP ORDER BY SRNO", "SRNO", "GNAME", ctrl)
    End Sub
    Public Sub FillAcCombo(ByVal CTRL As ComboBox, ByVal AG As Integer)
        NFillCombo("SELECT SRNO, ANAME FROM MST_AC WHERE AG=" & AG & " AND SFLAG='True' ORDER BY ANAME", "SRNO", "ANAME", CTRL)
    End Sub
    Public Sub FillBank(ByVal CTRL As ComboBox, ByVal AG As Integer)
        NFillCombo("SELECT SRNO, ANAME FROM MST_AC WHERE AG=" & AG & " AND SFLAG='True'AND BTYPE IN ('SAVING','CURRENT') ORDER BY ANAME", "SRNO", "ANAME", CTRL)
    End Sub
    ' ("SELECT SRNO,ANAME FROM MST_AC WHERE AG=2 AND BTYPE IN ('PAYMENT UPI','CREDIT CARD')")
    Public Sub FillBankUpi(ByVal CTRL As ComboBox, ByVal AG As Integer)
        NFillCombo("SELECT SRNO, ANAME FROM MST_AC WHERE AG=" & AG & " AND SFLAG='True' AND BTYPE IN ('PAYMENT UPI','CREDIT CARD') ORDER BY ANAME", "SRNO", "ANAME", CTRL)
    End Sub
    Public Function NFetchData(ByVal STR As String) As String
        CMD = New SqlCommand(STR, VarCon.Connection)
        If IsDBNull(CMD.ExecuteScalar()) Then
            NFetchData = ""
        Else
            NFetchData = CMD.ExecuteScalar()
        End If
        VarCon.CloseConnection()
    End Function
    Public Sub NAutoNumberDropdown(ByVal ctrl As ComboBox, ByVal TableName As String, ByVal FieldName As String)

        Dim sql As String = "SELECT " & FieldName & " FROM " & TableName & " ORDER BY " & FieldName & ""
        CMD = New SqlCommand(sql, VarCon.Connection)
        RDR = CMD.ExecuteReader
        ctrl.Items.Clear()
        While RDR.Read
            ctrl.Items.Add(Trim(RDR.Item(FieldName)))
        End While
        RDR.Close()
        Dim MaxNo As Double = NAutoNumber("SELECT MAX(" & FieldName & ") FROM " & TableName & "")
        ctrl.Items.Add(MaxNo)
        ctrl.Text = MaxNo
        VarCon.CloseConnection()
    End Sub

    ''PRODCUT
    Public Sub FillCategory(ByVal ctrl As ComboBox)
        ' NFillCombo("SELECT SRNO,CNAME FROM MST_CATEGORY WHERE SID=" & SID & " AND ACTIVE='True' ORDER BY CNAME", "SRNO", "CNAME", ctrl)
    End Sub
    Public Sub FillProductAll(ByVal ctrl As ComboBox)
        NFillCombo("SELECT SRNO,PRONAME FROM MST_PRODUCT ORDER BY PRONAME", "SRNO", "PRONAME", ctrl)
    End Sub
    Public Sub FillProduct(ByVal ctrl As ComboBox, ByVal Category As Integer)
        ' NFillCombo("SELECT SRNO,PRONAME FROM MST_PRODUCT WHERE CNAME=" & Category & " AND SID=" & SID & "  ORDER BY PRONAME", "SRNO", "PRONAME", ctrl)
    End Sub
    Public Sub FillMedia(ByVal ctrl As ComboBox)
        NFillCombo("SELECT SRNO,PRONAME FROM MST_PRODUCT WHERE CNAME IN(SELECT SRNO FROM MST_CATEGORY WHERE CTYPE='READY') ORDER BY PRONAME", "SRNO", "PRONAME", ctrl)
    End Sub
    Public Sub FillRequest(ByVal ctrl As DataGridView, ByVal rstatus As String)
        'Dim DT As New DataTable
        'If UROLE = "SUPERADMIN" Then
        '    ' DT = NFetchDatatable("SELECT P.AUTO_ID,P.SUITE_ID,A.ANAME AS SUITENAME,P.USER_ID,U.UNAME AS USERNAME,P.REQUEST_DATE,ISNULL(P.REQUEST_AMT,0)AS REQUEST_AMT,P.REQUEST_NOTE,P.REQUEST_BY,REQUEST_FLAG,'Payment' AS RFOR FROM MST_PAYMENT_REQ P, MST_AC A, MST_USER U WHERE REQUEST_FLAG='" & rstatus & "' AND A.SRNO=P.SUITE_ID AND U.UID=P.USER_ID ")
        '    DT = NFetchDatatable(" WITH REQUESTS AS (SELECT P.AUTO_ID,P.SUITE_ID,A.ANAME AS SUITENAME,P.USER_ID,U.UNAME AS USERNAME,P.REQUEST_DATE,ISNULL(P.REQUEST_AMT,0)AS REQUEST_AMT,P.REQUEST_NOTE,P.REQUEST_BY,REQUEST_FLAG,'Payment' AS RFOR FROM MST_PAYMENT_REQ P, MST_AC A, MST_USER U WHERE REQUEST_FLAG='" & rstatus & "' AND A.SRNO=P.SUITE_ID AND U.UID=P.USER_ID UNION ALL SELECT P.AUTO_ID,P.SUITE_ID,A.ANAME AS SUITENAME,P.USER_ID,U.UNAME AS USERNAME,P.REQUEST_DATE,0 AS REQUEST_AMT,P.REMARK,P.REQUEST_BY,REQUEST_FLAG,'Matirial' AS RFOR FROM MST_MATIRIAL_REQ P, MST_AC A, MST_USER U WHERE REQUEST_FLAG='" & rstatus & "' AND A.SRNO=P.SUITE_ID AND U.UID=P.USER_ID) SELECT *FROM REQUESTS ORDER BY REQUEST_DATE")

        'Else
        '    DT = NFetchDatatable("WITH REQUESTS AS (SELECT P.AUTO_ID,P.SUITE_ID,A.ANAME AS SUITENAME,P.USER_ID,U.UNAME AS USERNAME,P.REQUEST_DATE,ISNULL(P.REQUEST_AMT,0)AS REQUEST_AMT,P.REQUEST_NOTE,P.REQUEST_BY,REQUEST_FLAG,'Payment' AS RFOR FROM MST_PAYMENT_REQ P, MST_AC A, MST_USER U WHERE REQUEST_FLAG='" & rstatus & "' AND A.SRNO=P.SUITE_ID AND U.UID=P.USER_ID AND P.SUITE_ID=" & SID & " AND P.USER_ID=" & UID & " UNION ALL SELECT P.AUTO_ID,P.SUITE_ID,A.ANAME AS SUITENAME,P.USER_ID,U.UNAME AS USERNAME,P.REQUEST_DATE,0 AS REQUEST_AMT,P.REMARK,P.REQUEST_BY,REQUEST_FLAG,'Matirial' AS RFOR FROM MST_MATIRIAL_REQ P, MST_AC A, MST_USER U WHERE REQUEST_FLAG='" & rstatus & "' AND A.SRNO=P.SUITE_ID AND U.UID=P.USER_ID AND P.SUITE_ID=" & SID & " AND P.USER_ID=" & UID & ") SELECT *FROM REQUESTS ORDER BY REQUEST_DATE ")
        'End If
        'ctrl.DataSource = DT
    End Sub
    Public Sub FillBillType(ByVal ctrl As ComboBox)
        NFillCombo("SELECT SRNO,BTYPE FROM VAR_BTYPE ORDER BY BTYPE", "SRNO", "BTYPE", ctrl)
    End Sub
    Public Function NFetchDataReader(ByVal Query As String) As SqlDataReader
        Dim cmd As New SqlCommand(Query, VarCon.Connection)
        NFetchDataReader = cmd.ExecuteReader

    End Function
    Public Sub FillPartyByGroup(ByVal CTRL As ComboBox, ByVal CGroup As Integer)
        NFillCombo("SELECT SRNO, ANAME FROM MST_AC WHERE AG IN (3) AND CGROUP=" & CGroup & " AND SFLAG='True' ORDER BY ANAME", "SRNO", "ANAME", CTRL)
    End Sub
    Public Function PanelVisibel(ByVal rl As String, ByVal cmb As ComboBox) As Boolean
        If rl = "SUPERADMIN" Then
            NFillCombo("SELECT SRNO,ANAME FROM MST_AC WHERE AG=7", "SRNO", "ANAME", cmb)
            PanelVisibel = True
        Else
            PanelVisibel = False
        End If
    End Function

    Public Function LoadImage(ByVal table As String) As String
        LoadImage = ""
        'LoadImage = NFetchData("SELECT BIMAGE FROM " & table & " WHERE AUTO_ID=" & _RepName & "")
        Return LoadImage
    End Function
    Public Shared Sub FillCustomersCombo(ByVal ctrl As ComboBox)
        Dim Dt As DataTable = DevFunctions.GetCustomLedgerDataTable({"Customers"})
        ctrl.DataSource = Dt
        ctrl.ValueMember = "LedgerID"
        ctrl.DisplayMember = "LedgerName"
        VarCon.CloseConnection()
    End Sub
    Public Shared Sub FillVendorsCombo(ByVal ctrl As ComboBox)
        Dim Dt As DataTable = DevFunctions.GetCustomLedgerDataTable({"Vendors"})
        ctrl.DataSource = Dt
        ctrl.ValueMember = "LedgerID"
        ctrl.DisplayMember = "LedgerName"
        VarCon.CloseConnection()
    End Sub
    Public Shared Sub FillPurchaseLedgers(ByVal ctrl As ComboBox)
        Dim Dt As DataTable = DevFunctions.GetCustomLedgerDataTable({"Purchase"})
        ctrl.DataSource = Dt
        ctrl.ValueMember = "LedgerID"
        ctrl.DisplayMember = "LedgerName"
        VarCon.CloseConnection()
    End Sub
    Public Shared Sub FillSunContractors(ByVal ctrl As ComboBox)
        Dim Dt As DataTable = DevFunctions.GetCustomLedgerDataTable({"Sub Contractor"})
        ctrl.DataSource = Dt
        ctrl.ValueMember = "LedgerID"
        ctrl.DisplayMember = "LedgerName"
        VarCon.CloseConnection()
    End Sub
    Public Sub FillTermsCombo(ByVal ctrl As ComboBox)
        NFillCombo("select terms_id,terms_name from Dia_Terms_Master Order by terms_name", "terms_id", "terms_name", ctrl)
    End Sub
    Public Sub FillItemTypeCombo(ByVal ctrl As ComboBox)
        NFillCombo("select item_type_id,item_type_name from Dia_Item_Type_Master", "item_type_id", "item_type_name", ctrl)
    End Sub
    Public Sub FillMainLotNameCombo(ByVal ctrl As ComboBox)
        NFillCombo("select MainPacketID,MainLotName from Dia_Main_Packet_Master", "MainPacketID", "MainLotName", ctrl)
    End Sub
    Public Sub FillShapeCombo(ByVal ctrl As ComboBox)
        NFillComboWithOneListMemberBlank("select Shape_ID,Shape_Name from Dia_Shape_Master", "Shape_ID", "Shape_Name", ctrl)
    End Sub
    Public Sub FillColorCombo(ByVal ctrl As ComboBox)
        NFillComboWithOneListMemberBlank("select color_id,Color_name from Dia_Color_Master", "color_id", "Color_name", ctrl)
    End Sub
    Public Sub FillClarityCombo(ByVal ctrl As ComboBox)
        NFillComboWithOneListMemberBlank("select clarity_id,clarity_name from Dia_Clarity_Master", "clarity_id", "clarity_name", ctrl)
    End Sub
    Public Sub FillGraderCombo(ByVal ctrl As ComboBox)
        NFillCombo("select GraderID,GraderName from Dia_Grader_Master", "GraderID", "GraderName", ctrl)
    End Sub
    Public Sub FillLabCombo(ByVal ctrl As ComboBox)
        NFillCombo("select lab_id,lab_name from DIa_Lab_Master", "lab_id", "lab_name", ctrl)
    End Sub
    Public Sub FillCutCombo(ByVal ctrl As ComboBox)
        NFillComboWithOneListMemberBlank("select cut_id,cut_name from Dia_Cut_Master", "cut_id", "cut_name", ctrl)
    End Sub
    Public Sub FillpolishCombo(ByVal ctrl As ComboBox)
        NFillComboWithOneListMemberBlank("select polish_id,polish_name from Dia_polish_Master", "polish_id", "polish_name", ctrl)
    End Sub
    Public Sub FillSymmCombo(ByVal ctrl As ComboBox)
        NFillComboWithOneListMemberBlank("select Symm_id,Symm_name from Dia_Symm_Master", "Symm_id", "Symm_name", ctrl)
    End Sub
    Public Sub FillFlourCombo(ByVal ctrl As ComboBox)
        NFillComboWithOneListMemberBlank("select flo_id,flo_name from Dia_Flo_Master", "flo_id", "flo_name", ctrl)
    End Sub
    Public Function CheckForInternetConnection() As Boolean
        Try
            Using client = New WebClient()
                Using stream = client.OpenRead("http://www.google.com")
                    Return True
                End Using
            End Using
        Catch
            Return False
        End Try
    End Function

    Public Sub MaskedTextboxHeight(ByVal parent As Control)
        For Each c As Control In parent.Controls
            If (c.Controls.Count > 0) Then
                MaskedTextboxHeight(c)
            Else
                If TypeOf c Is MaskedTextBox Then
                    CType(c, MaskedTextBox).AutoSize = False
                    c.Size = New Size(130, 20)
                End If

            End If
        Next
    End Sub
    Public Function checkComboisValid(ByVal ctrl As ComboBox) As Boolean
        checkComboisValid = True
        If ctrl.SelectedValue Is Nothing Then
            ctrl.Select()
            checkComboisValid = False
            Exit Function
        End If
        Return checkComboisValid
    End Function
    Public Function CheckTextBoxisValid(ByVal ctrl As TextBox) As Boolean
        CheckTextBoxisValid = True
        If Len(Trim(ctrl.Text)) = 0 Then
            ctrl.Select()
            CheckTextBoxisValid = False
            Exit Function
        End If
        Return CheckTextBoxisValid
    End Function
    Public Shared Sub DataTable_to_SqlTable_Copy(ByVal dt As DataTable, ByVal sqlTableName As String)
        VarCon.Connection()
        Using copy As New SqlBulkCopy(con)
            copy.DestinationTableName = sqlTableName
            copy.WriteToServer(dt)
        End Using
        VarCon.CloseConnection()
    End Sub
End Class
