ALTER PROC StudentSearch
@ID int
AS

SELECT [ID] AS 'ID'
      ,[FIRST_NAME] AS 'First Name'
      ,[LAST_NAME] AS 'Last Name'
      ,[BIRTHDATE] AS 'BirthDate'
	  ,[ACADEMIC_YEAR] AS 'Academic Year'
      ,[CLASS_ID] AS 'Class'
      ,[PHONE_NUMBER] AS 'Phone Number'
      ,[CITY] AS 'City'
      ,[STUDENT_SUPERVISOR] AS 'SUPERVISOR'
      ,[STUDY_FEES] AS 'Fees'

  FROM [Student]
  WHERE 
  Convert(varchar,[ID])+
  [FIRST_NAME]+
  [CLASS_ID]+
  [ACADEMIC_YEAR]
  LIKE '%'+@ID+'%'
GO

