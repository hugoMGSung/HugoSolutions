CREATE TABLE [dbo].[myTable](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[title] [varchar](255) NOT NULL,
	[parentID] [int] NULL,
 CONSTRAINT [PK_myTable] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

SET IDENTITY_INSERT myTable ON
GO

INSERT INTO myTable(ID, title, parentID) VALUES(1,'Microsoft', NULL)
INSERT INTO myTable(ID, title, parentID) VALUES(2,'C#', 1)
INSERT INTO myTable(ID, title, parentID) VALUES(3,'VB.net', 1)
INSERT INTO myTable(ID, title, parentID) VALUES(4,'Open Source', NULL)
INSERT INTO myTable(ID, title, parentID) VALUES(5,'Python',	4)
INSERT INTO myTable(ID, title, parentID) VALUES(6,'Ruby', 4)
INSERT INTO myTable(ID, title, parentID) VALUES(7,'PHP', 4)
INSERT INTO myTable(ID, title, parentID) VALUES(8,'Perl', 4)
INSERT INTO myTable(ID, title, parentID) VALUES(9,'Java', 4)
INSERT INTO myTable(ID, title, parentID) VALUES(10,'LinQ', 2)
INSERT INTO myTable(ID, title, parentID) VALUES(11,'5.2', 7)
INSERT INTO myTable(ID, title, parentID) VALUES(12,'4.4', 7)

GO
SET IDENTITY_INSERT myTable OFF
GO


ALTER TABLE [dbo].[myTable]  WITH CHECK ADD  CONSTRAINT [FK_myTable_myTable] FOREIGN KEY([parentID])
REFERENCES [dbo].[myTable] ([ID])
GO
ALTER TABLE [dbo].[myTable] CHECK CONSTRAINT [FK_myTable_myTable]