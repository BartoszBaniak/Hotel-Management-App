CREATE TABLE [dbo].[User_Table]
(
	User_ID INT IDENTITY(1, 1) NOT NULL,
	User_Name VARCHAR(150) NOT NULL,
	User_Password VARCHAR(150) NOT NULL, 
    CONSTRAINT [PK_User_Table] PRIMARY KEY ([User_ID])
);