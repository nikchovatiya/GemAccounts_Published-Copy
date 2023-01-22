Public Class frmLabResults
    Dim dt As DataTable = DevFunctions.GetEmptyMainStockDatatable
    Dim dr As DataRow
    Private Sub frmLabResults_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Dia_MasterDataset.Dia_User_Master' table. You can move, or remove it, as needed.
        Me.Dia_User_MasterTableAdapter.Fill(Me.Dia_MasterDataset.Dia_User_Master)
        'TODO: This line of code loads data into the 'Dia_MasterDataset.DIa_Lab_Master' table. You can move, or remove it, as needed.
        Me.DIa_Lab_MasterTableAdapter.Fill(Me.Dia_MasterDataset.DIa_Lab_Master)
        'TODO: This line of code loads data into the 'Dia_MasterDataset.Dia_Symm_Master' table. You can move, or remove it, as needed.
        Me.Dia_Symm_MasterTableAdapter.Fill(Me.Dia_MasterDataset.Dia_Symm_Master)
        'TODO: This line of code loads data into the 'Dia_MasterDataset.Dia_Polish_Master' table. You can move, or remove it, as needed.
        Me.Dia_Polish_MasterTableAdapter.Fill(Me.Dia_MasterDataset.Dia_Polish_Master)
        'TODO: This line of code loads data into the 'Dia_MasterDataset.Dia_Cut_Master' table. You can move, or remove it, as needed.
        Me.Dia_Cut_MasterTableAdapter.Fill(Me.Dia_MasterDataset.Dia_Cut_Master)
        'TODO: This line of code loads data into the 'Dia_MasterDataset.Dia_Flo_Master' table. You can move, or remove it, as needed.
        Me.Dia_Flo_MasterTableAdapter.Fill(Me.Dia_MasterDataset.Dia_Flo_Master)
        'TODO: This line of code loads data into the 'Dia_MasterDataset.Dia_Clarity_Master' table. You can move, or remove it, as needed.
        Me.Dia_Clarity_MasterTableAdapter.Fill(Me.Dia_MasterDataset.Dia_Clarity_Master)
        'TODO: This line of code loads data into the 'Dia_MasterDataset.Dia_Color_Master' table. You can move, or remove it, as needed.
        Me.Dia_Color_MasterTableAdapter.Fill(Me.Dia_MasterDataset.Dia_Color_Master)
        'TODO: This line of code loads data into the 'Dia_MasterDataset.Dia_Shape_Master' table. You can move, or remove it, as needed.
        Me.Dia_Shape_MasterTableAdapter.Fill(Me.Dia_MasterDataset.Dia_Shape_Master)

        LoadGrid()
    End Sub

    Private Sub LoadGrid()
        Dim tmpdt As DataTable = GENERAL_FUNCTIONS.NFetchDatatable("SELECT * FROM Dia_MainStock WHERE LabID>0 AND (HistoryDescription='IGI Result Import' or HistoryDescription='GIA Result Import' or HistoryDescription='HRD Result Import') AND Barcode=" & GLOBAL_VARIABLES.Barcode & " ORDER BY TransactionID DESC")
        If tmpdt Is Nothing Then Return
        For i = 0 To tmpdt.Rows.Count - 1
            dt.NewRow()
            dt.Rows.Add(tmpdt.Rows(i).ItemArray)
        Next
        dg.DataSource = dt
        dgview.BestFitColumns()
    End Sub
End Class