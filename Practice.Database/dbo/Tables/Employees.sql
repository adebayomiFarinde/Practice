CREATE TABLE [Employees]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
	[FirstName] NVARCHAR(50) NOT NULL, 
	[LastName] NVARCHAR(50) NOT NULL, 
	[DateOfBirth] DATETIME NULL, 
	[DateOfEmployment] DATETIME NULL, 
	[Sex] INT NOT NULL, 
	[MaritalStatus] INT NOT NULL, 
	[NumberOfChildren] INT NULL, 
	[IsActive] BIT NOT NULL, 
	[MaximumEducationalQualification] INT NULL, 
    [LastDateOfPromotion] DATETIME NULL 
	
)

