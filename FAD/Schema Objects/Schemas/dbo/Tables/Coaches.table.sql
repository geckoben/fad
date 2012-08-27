CREATE TABLE [dbo].[Coaches] (
    [Clé]                     INT            NOT NULL,
    [Prénom]                  NVARCHAR (30)  NOT NULL,
    [Email]                   NVARCHAR (255) NULL,
    [Identifiant]             NVARCHAR (30)  NULL,
    [MotDePasse]              NVARCHAR (30)  NULL,
    [DateDernièreModifModule] DATETIME       NULL,
    [nom]                     NVARCHAR (30)  NULL,
    [societe]                 NVARCHAR (30)  NULL,
    [rue]                     NVARCHAR (50)  NULL,
    [cp]                      NVARCHAR (10)  NULL,
    [ville]                   NVARCHAR (30)  NULL,
    PRIMARY KEY CLUSTERED ([Clé] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);

