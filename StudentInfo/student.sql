/****** Object:  Table [dbo].[Student]    Script Date: 2019-10-13 11:57:32 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[Student]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[Student]
GO

/****** Object:  Table [dbo].[Student]    Script Date: 2019-10-13 11:57:32 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[Student]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
CREATE TABLE [dbo].[Student](
	[Code] [varchar](50) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Sex] [varchar](10) NOT NULL,
	[Birth] [smalldatetime] NOT NULL,
 CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED 
(
	[Code] ASC
) ON [PRIMARY]
) ON [PRIMARY]
END
GO


