CREATE PROCEDURE [dbo].[AddStudent]
	@LastName VARCHAR(50),
	@FirstName VARCHAR(50),
	@BirthDate dateTime2(7),
	@YearResult INT,
	@SectionId INT,
	@Active BIT = 1
AS
BEGIN
	INSERT INTO Student (LastName, FirstName, BirthDate, YearResult, SectionId, Active )
	VALUES (@lastName, @firstName, @birthDate, @yearResult, @sectionId, @active )
END