SELECT        S.SerieName AS SerieName, 
S.Pcs AS SeriePcs, 
S.Carats AS SerieCarats, 
S.TotalUSD AS SerieTotalUSD, 
MP.MainLotName AS MainLotName, 
MP.Pcs AS MainLotPcs, 
MP.Carats AS MainLotCarats, 
mp.TotalUSD MainTotalUSD, mp.Tender,
MS.TransactionID AS TID,
MS.Barcode AS Barcode, 
mS.StockID AS StockID,
LOT.lot_status_name AS Status,
mS.Qty AS Qty, 
mS.Carats AS Carats,
SHAPE.Shape_Name AS Shape,
CLR.color_name AS Color,
CLA.clarity_name AS Clarity,
F.flo_name AS Flo,
LAB.lab_name AS Lab,
MS.LCertificateNo AS ReportNo,
SD.RAP AS RAP,
SM.SaleDate AS SalesDate,
SD.Discount AS SalesDiscount,
SD.PPCUSD AS SalesPPCUSD,
SD.TotalUSD AS SalesTotalUSD,
SM.ExRate AS SalesRate,
SD.PPCINR AS SalesPPCINR,
SD.TotalINR AS SalesTotalINR,
(((SM.BrokerINR)+(SM.AddINR )) / SM.Carats) * MS.Carats AS SaleExpense
,(SD.TotalINR) +((((SM.BrokerINR)+(SM.AddINR )) / SM.Carats) * MS.Carats)  AS NetSaleINR



FROM  Dia_Serie S 
LEFT JOIN Dia_Main_Packet_Master MP ON MP.SerieID = S.SerieID
JOIN (SELECT *,        
             ROW_NUMBER() OVER(PARTITION BY Barcode ORDER BY TransactionID DESC) rn
      FROM dbo.Dia_MainStock )MS ON MS.MainLotID=MP.MainPacketID 

LEFT JOIN Dia_Shape_Master SHAPE ON SHAPE.Shape_ID = MS.ShapeID
LEFT JOIN Dia_Color_Master CLR ON CLR.color_id = MS.ColorID
LEFT JOIN Dia_Clarity_Master CLA ON CLA.clarity_id = MS.ClarityID
LEFT JOIN Dia_Flo_Master F ON F.flo_id = MS.FloID
LEFT JOIN DIa_Lab_Master LAB ON LAB.lab_id=MS.LabID
LEFT JOIN Dia_Lot_Status_Master LOT ON LOT.lot_status_id=MS.StatusID 
LEFT JOIN Dia_SalesDetails SD ON SD.Barcode=MS.Barcode
LEFT JOIN Dia_SalesMaster SM ON SM.SalesMasterID=SD.SalesMasterID





WHERE 
 MS.rn = 1 ORDER BY MS.TransactionID, SerieName, MainLotName, StockID DESC



