Imports System.Globalization

Public Class LabTranslation
    Public Structure SplitStrings
        Public Girdle As String
        Public GirdleCondition As String
    End Structure
    Public Shared Barcode As Integer = 0
    Public Shared Carats As Double = 0
    Public Shared ShapeID As Integer = 0
    Public Shared ColorID As Integer = 0
    Public Shared ClarityID As Integer = 0
    Public Shared FloID As Integer = 0
    Public Shared CutID As Integer = 0
    Public Shared PolishID As Integer = 0
    Public Shared SymID As Integer = 0
    Public Shared LDocumentNo As String = String.Empty
    Public Shared LReportDate As Date = Nothing
    Public Shared LCertificateNo As String = String.Empty
    Public Shared LLength As Double = 0
    Public Shared LWidth As Double = 0
    Public Shared LDepth As Double = 0
    Public Shared LTable As String = String.Empty
    Public Shared LTotalDepth As String = String.Empty
    Public Shared LCrownHeight As String = String.Empty
    Public Shared LCrownAngle As String = String.Empty
    Public Shared LPavillionDepth As String = String.Empty
    Public Shared LPavillionAngle As String = String.Empty
    Public Shared LGirdlePercent As String = String.Empty
    Public Shared LReportComments As String = String.Empty
    Public Shared LLabiscribe As String = String.Empty
    Public Shared GIAColorDescriptions As String = String.Empty
    Public Shared LClarityStatus As String = String.Empty
    Public Shared LFloColor As String = String.Empty
    Public Shared GIAStrLn As String = String.Empty
    Public Shared GIALrHalf As String = String.Empty
    Public Shared GIAPainting As String = String.Empty
    Public Shared LProportion As String = String.Empty
    Public Shared GIAPaintComm As String = String.Empty
    Public Shared GIAKeytoSymbols As String = String.Empty
    Public Shared GIASyntheticIndicator As String = String.Empty
    Public Shared GIAPolishFeatures As String = String.Empty
    Public Shared GIASymmetryFeatures As String = String.Empty
    Public Shared LReportType As String = String.Empty
    Public Shared LCountryofOrigin As String = String.Empty
    Public Shared GIADiamondType As String = String.Empty
    Public Shared GirdleID As Integer = 0
    Public Shared GirdleConditionID As Integer = 0
    Public Shared GIASorting As String = String.Empty
    Public Shared GIABasketStatus As String = String.Empty
    Public Shared GIAJobNo As String = String.Empty
    Public Shared GIADiamondDossier As String = String.Empty
    Public Shared LabMemoNo As String = String.Empty
    Public Shared CuletID As Integer = 0
    Public Shared HRDLengthHalvesCr As String = String.Empty
    Public Shared HRDLengthHalvesPv As String = String.Empty
    Public Shared HRDPotentialMake As String = String.Empty
    Public Shared HeartArrow As String = String.Empty
    Public Shared HRDExtraInfo As String = String.Empty
    Public Shared HRDFancycolour As String = String.Empty
    Public Shared HRDFin As String = String.Empty
    Public Shared HRDAfm As String = String.Empty
    Public Shared HRDScSampletype As String = String.Empty
    Public Shared HRDPremiumIdealCut As String = String.Empty
    Public Shared HRDWeightlossClarity As String = String.Empty
    Public Shared HRDECG As String = String.Empty
    Public Shared HRDValidUntil As String = String.Empty
    Public Shared HRDWeightC As String = String.Empty
    Public Shared HRDCuletDescription As String = String.Empty
    Public Shared HRDCuletSizePercent As String = String.Empty
    Public Shared HRDCAPA As String = String.Empty
    Public Shared IGILabPrefix As String = String.Empty
    Public Shared IGILabOtherReportNumber As String = String.Empty
    Public Shared IGILabNumberStones As String = String.Empty
    Public Shared IGILabDescription As String = String.Empty
    Public Shared IGILabReportFormatI As String = String.Empty
    Public Shared IGILabColorShort As String = String.Empty
    Public Shared IGILabReportTypeII As String = String.Empty
    Public Shared IGILabReportFormatII As String = String.Empty
    Public Shared IGILabCommentsConsultation As String = String.Empty
    Public Shared IGILabSpecialComments As String = String.Empty
    Public Shared IGILabFaxComments As String = String.Empty



    Public Function LabValueDouble(ByVal value As String) As Double
        value = LabRemoveNA(value)
        If value = String.Empty Then
            value = 0
        Else
            value = Replace(value, "N/A", String.Empty)
            value = Replace(Replace(value, " ", String.Empty), "%", String.Empty)
            value = Double.Parse(Val(value.ToString))
            value = Convert.ToDouble(value)
        End If
        Return value
    End Function
    Public Function LabValueString(ByVal value As String)
        value = value.ToString.Trim()
        Return value
    End Function
    Public Function LabRemoveNA(ByVal value As String)
        Dim empty As String
        If Not IsDBNull(value) Then
            If value.Contains("N/A") Then
                value = Replace(value, "N/A", String.Empty).ToString.Trim()
            ElseIf value.Contains("<br>") Then
                value = Replace(value, "<br>", String.Empty).ToString.Trim()
            ElseIf value.Contains("%") Then
                value = Replace(value, "%", String.Empty).ToString.Trim()
            ElseIf value.Contains("[*], ") Then
                value = Replace(value, "[*], ", String.Empty).ToString.Trim()
            ElseIf value.Contains(ChrW(176)) Then
                value = Replace(value, ChrW(176), String.Empty).ToString.Trim()
            End If
        End If
        empty = value.Trim()
        Return empty
    End Function
    Public Function TextToColumns(value As String) As SplitStrings
        value = (value).ToUpper
        Dim strArrays1 As String() = value.Split(New String() {"(", ")"}, StringSplitOptions.RemoveEmptyEntries)
        Dim returnStructure As New SplitStrings
        If (value.Contains("(")) Then

            If (CInt(strArrays1.Length) = 2) Then
                returnStructure.GirdleCondition = String.Format("{0}", strArrays1(1)).Trim()
                returnStructure.Girdle = String.Format("{0}", strArrays1(0)).Trim()
            End If
        Else
            If (CInt(strArrays1.Length) = 1) Then
                returnStructure.GirdleCondition = 0
                returnStructure.Girdle = String.Format("{0}", strArrays1(0)).Trim()
            End If
        End If
        Return returnStructure
    End Function

    Public Function LabValueDate(ByVal value As String) As Date
        Dim format = {"dd/MM/yyyy", "M/d/yyyy", "dd-MM-yyyy", "dd-MM-yyyy hh:mm:ss tt", "dd-MM-yyyy hh:mm:ss"}
        Date.TryParseExact(value, format, CultureInfo.InvariantCulture, DateTimeStyles.None, LabValueDate)
        LabValueDate.ToString("dd-mmm-yyyy")
        Return LabValueDate
    End Function
End Class
