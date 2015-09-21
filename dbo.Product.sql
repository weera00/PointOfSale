CREATE TABLE [dbo].[product] (
    [Id]     INT          IDENTITY (1, 1) NOT NULL,
    [name]   VARCHAR (50) NULL,
    [mydate] DATETIME     NULL DEFAULT GETDATE(),
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

