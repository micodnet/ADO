CREATE PROCEDURE [dbo].[DeleteStudent]
	@id int
AS
	DELETE FROM Student WHERE Id = @id 
