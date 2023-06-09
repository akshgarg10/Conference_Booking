/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [user_id]
      ,[username]
      ,[password]
      ,[f_name]
      ,[l_name]
      ,[number]
  FROM [Login_conference].[dbo].[login]