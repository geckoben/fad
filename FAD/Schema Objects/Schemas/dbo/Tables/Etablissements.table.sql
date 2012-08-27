CREATE TABLE [dbo].[Etablissements] (
    [Cle]          INT            NOT NULL,
    [Nom]          NVARCHAR (100) NOT NULL,
    [Implantation] NVARCHAR (100) NULL,
    [Adresse]      NVARCHAR (100) NULL,
    [CodePostal]   NVARCHAR (100) NULL,
    [Localite]     NVARCHAR (100) NULL,
    [CTELH]        BIT            DEFAULT ((0)) NOT NULL,
    [FASE]         NVARCHAR (100) NULL,
    PRIMARY KEY CLUSTERED ([Cle] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);

