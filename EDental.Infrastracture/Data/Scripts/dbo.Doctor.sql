USE [EDentalDb]
GO

/****** Object: Table [dbo].[Doctor] Script Date: 10/20/2024 9:14:23 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

DROP TABLE [dbo].[Doctor];


GO
CREATE TABLE [dbo].[Doctor] (
    [Id]             INT            IDENTITY (1, 1) NOT NULL,
    [FullName]       NVARCHAR (100) NOT NULL,
    [Address]        NVARCHAR (200) NOT NULL,
    [Phone]          VARCHAR (20)   NULL,
    [NDCNumber]      NVARCHAR (100) NULL,
    [Qualification]  VARCHAR (200)  NULL,
    [Specialization] VARCHAR (200)  NULL,
    [Gender]         INT            NULL,
    [DOb]            DATETIME2 (7)  NULL
);
insert into Doctor
values ('Dr. James', 'Kathmandu, Nepal', '9841234563', 'ABC34784FG', 'MDS MS', 'Dental Surgery', 1, '1980/12/12')

select * from Doctor


