CREATE PROC Get_All_Students
AS

SELECT [ID] AS 'ID'
      ,[FIRST_NAME] AS 'First Name'
      ,[LAST_NAME] AS 'Last Name'
      ,[BIRTHDATE] AS 'BirthDate'
      ,[ACADEMIC_YEAR] AS 'Academic Year'
      ,[CLASS_ID] AS 'Class'
      ,[PHONE_NUMBER] AS 'Phone Number'
      ,[CITY] AS 'City'
      ,[STUDENT_SUPERVISOR] AS 'Supervisor'
	  ,[STUDY_FEES] AS 'Fees'

  FROM [Student]
GO

