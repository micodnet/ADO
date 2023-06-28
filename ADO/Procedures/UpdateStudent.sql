CREATE PROCEDURE [dbo].[UpdateStudent]
	@sectionId INT,
	@yearResult INT,
	@studentId INT
AS
	UPDATE Student SET SectionId = @sectionId,
					   YearResult = @yearResult
	WHERE Id = @studentId
