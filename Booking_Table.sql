/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [user_id]
      ,[booking_id]
      ,[start_date]
      ,[end_date]
      ,[booking_time]
      ,[booked]
  FROM [Login_conference].[dbo].[booking]