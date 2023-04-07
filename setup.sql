DROP TABLE IF EXISTS [dbo].[UserCredential];

CREATE TABLE UserCredential (
	username NVARCHAR(255) PRIMARY KEY NOT NULL,
	password NVARCHAR(255) NOT NULL,
	roleId INT NOT NULL
);

INSERT INTO [dbo].[UserCredential] (username, password, roleId) VALUES
('admin', 'admin', 1);

DROP TABLE IF EXISTS [dbo].UserRole;

CREATE TABLE UserRole (
	id INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	name NVARCHAR(255) NOT NULL
);

INSERT INTO [dbo].[UserRole] (name) VALUES
('ADMIN');

DROP TABLE IF EXISTS [dbo].Announcement;

CREATE TABLE Announcement (
	id INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	title NVARCHAR(255) NOT NULL,
	description NVARCHAR(255) NOT NULL,
	imgUrl TEXT NOT NULL,
	createdAt DATETIME2 NOT NULL DEFAULT SYSDATETIME()
);

INSERT INTO [dbo].[Announcement] (title, description, imgUrl) VALUES
('Something happened', 'It is very, very important.', 'https://images.dog.ceo/breeds/ridgeback-rhodesian/n02087394_3139.jpg'),
('Another thing happened', 'It is also very, very important.', 'https://images.dog.ceo/breeds/cotondetulear/IMAG1063.jpg');