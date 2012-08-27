CREATE TABLE [dbo].[Modules] (
    [Clé]              INT           NOT NULL,
    [CléMembre]        INT           NOT NULL,
    [NuméroModule]     NVARCHAR (10) NOT NULL,
    [DateModification] DATETIME      NOT NULL,
    PRIMARY KEY CLUSTERED ([Clé] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);

