CREATE TABLE [dbo].[Cours] (
    [Clé]         NVARCHAR (10)  NOT NULL,
    [Intitulé]    NVARCHAR (100) NULL,
    [Modules]     INT            NULL,
    [DuréeModule] INT            NULL,
    [Facteur]     INT            NULL,
    PRIMARY KEY CLUSTERED ([Clé] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);

