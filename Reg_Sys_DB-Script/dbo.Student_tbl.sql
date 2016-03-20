USE [Reg_Db]
GO

/****** Object: Table [dbo].[Student_tbl] Script Date: 3/18/2016 6:16:05 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Student_tbl] (
    [Id]        INT          IDENTITY (1, 1) NOT NULL,
    [RollNo]    NCHAR (7)    NOT NULL,
    [FirstName] VARCHAR (20) NOT NULL,
    [LastName]  VARCHAR (20) NULL,
    [Batch]     INT          NOT NULL,
    [Dept]      VARCHAR (50) NOT NULL
);


