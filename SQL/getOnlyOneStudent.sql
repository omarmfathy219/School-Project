ALTER PROC getOnlyOneStudent
@ID int
AS
SELECT [ID]
      ,[FIRST_NAME]
      ,[LAST_NAME]
      ,[BIRTHDATE]
      ,[ACADEMIC_YEAR]
      ,[CLASS_ID]
      ,[PHONE_NUMBER]
      ,[CITY]
      ,[STUDENT_SUPERVISOR]
      ,[STUDY_FEES]
  FROM [dbo].[STUDENT]
  WHERE ID=@ID

