CREATE TABLE [dbo].[Items] (
    [Id]         INT        IDENTITY (1, 1) NOT NULL,
    [Name]       NCHAR (10) NOT NULL,
    [CategoryId] INT        NOT NULL,
    CONSTRAINT [PK_Items] PRIMARY KEY CLUSTERED ([Id] ASC)
);

