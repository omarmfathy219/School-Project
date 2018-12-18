CREATE PROC DeleteStudent
@ID Varchar(50)
AS
DELETE FROM Student WHERE ID=@ID 
