CREATE PROC Add_Supervisor
@ID int,
@FIRST_NAME Varchar (25),
@LAST_NAME Varchar (25),
@PHONE_NUMBER Varchar (11),
@MAIL Varchar (30),
@CITY Varchar (25),
@SALARY Varchar (25),
@HIRE_DATE Date,
@CLASS Varchar (25)

AS
INSERT INTO SUPERVISOR
           ([ID]
           ,[FIRST_NAME]
           ,[LAST_NAME]
           ,[PHONE_NUMBER]
		   ,[MAIL]
           ,[CITY]
           ,[SALARY]
		   ,[HIRE_DATE]
		   ,[CLASS]
           )
     VALUES
           (@ID,
		   @FIRST_NAME,
		   @LAST_NAME,
		   @PHONE_NUMBER,
		   @MAIL,
		   @CITY,
		   @SALARY,
		   @HIRE_DATE,
		   @CLASS
		   )