CREATE PROCEDURE [dbo].[AddSection]
	@SectionId INT,
	@SectionName VARCHAR(50)
AS
	SELECT @SectionId, @SectionName FROM Section

