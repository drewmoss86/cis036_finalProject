CREATE TABLE [dbo].[Fit_User] (
    [Id]        INT           NOT NULL IDENTITY,
    [Username]  NVARCHAR (50) NOT NULL,
    [Name]      NVARCHAR (50) NOT NULL,
    [Password]  NVARCHAR (50) NOT NULL,
    [Age]       INT           NOT NULL,
    [Zip]       INT           NOT NULL,
    [Height]    INT           NOT NULL,
    [Init_wt]   INT           NOT NULL,
    [Target_wt] INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

