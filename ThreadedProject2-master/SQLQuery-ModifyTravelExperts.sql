USE [TravelExperts]
GO

ALTER TABLE Customers
ADD Username nvarchar(50) null,
 Password nvarchar(50) null;

ALTER TABLE Suppliers
ADD ProdName nvarchar(50) null;

ALTER TABLE Products_Suppliers
ADD ProdName nvarchar(50) null,
 SupName nvarchar(50) null;