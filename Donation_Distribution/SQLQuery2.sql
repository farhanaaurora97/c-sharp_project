/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP 1000 [rid]
      ,[Email]
      ,[Reason]
      ,[Amount_request]
      ,[Amount_got]
      ,[Amount_need]
  FROM [Donation_Distributions].[dbo].[Receiver_requests]