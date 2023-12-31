/*
   06 November 202217:45:29
   User: 
   Server: .\SQLEXPRESS
   Database: 
   Application: 
*/

/* To prevent any potential data loss issues, you should review this script in detail before running it outside the context of the database designer.*/
BEGIN TRANSACTION
SET QUOTED_IDENTIFIER ON
SET ARITHABORT ON
SET NUMERIC_ROUNDABORT OFF
SET CONCAT_NULL_YIELDS_NULL ON
SET ANSI_NULLS ON
SET ANSI_PADDING ON
SET ANSI_WARNINGS ON
COMMIT
BEGIN TRANSACTION
GO
CREATE TABLE dbo.Table3
	(
	ItId int NOT NULL,
	ItName varchar(50) NOT NULL,
	ItQty int NOT NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Table3 ADD CONSTRAINT
	PK_Table3 PRIMARY KEY CLUSTERED 
	(
	ItId
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.Table3 SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
