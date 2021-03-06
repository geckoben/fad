﻿CREATE TABLE [dbo].[Inscrits] (
    [Clé]                 INT            NOT NULL,
    [Nom]                 NVARCHAR (255) NOT NULL,
    [NomSansAccent]       NVARCHAR (255) NULL,
    [Prénom]              NVARCHAR (255) NOT NULL,
    [Etablissement]       NVARCHAR (255) NULL,
    [CléStatut]           NVARCHAR (11)  NOT NULL,
    [Sexe]                NVARCHAR (1)   NULL,
    [Adresse]             NVARCHAR (255) NULL,
    [CodePostal]          NVARCHAR (255) NULL,
    [Localité]            NVARCHAR (255) NULL,
    [Pays]                NVARCHAR (255) NULL,
    [Téléphone]           NVARCHAR (255) NULL,
    [Fax]                 NVARCHAR (255) NULL,
    [Email]               NVARCHAR (255) NULL,
    [DateNaissance]       DATETIME       NULL,
    [NumTVA]              NVARCHAR (255) NULL,
    [NumRegistreNational] NVARCHAR (20)  NULL,
    [CléNiveauEtude]      NVARCHAR (2)   NULL,
    [AncienTarif]         NVARCHAR (255) NULL,
    [DateInscription]     DATETIME       NULL,
    [DateModifEmail]      DATETIME       NULL,
    [Source]              NVARCHAR (255) NULL,
    [DemandeDocs]         NVARCHAR (255) NULL,
    [AncienID]            INT            NULL,
    [AutresInfos]         NVARCHAR (MAX) NULL,
    [EmailPromo]          BIT            NOT NULL,
    [SSMA_TimeStamp]      VARBINARY (1)  NOT NULL,
    [PrénomSansAccent]    NVARCHAR (255) NULL,
    [Nationalite]         BIGINT         NULL,
    [PAC]                 BIT            DEFAULT ((0)) NOT NULL,
    [EnvoiAdressePrivee]  BIT            DEFAULT ((0)) NOT NULL,
    [CléEtablissement]    INT            NULL,
    PRIMARY KEY CLUSTERED ([Clé] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF),
    FOREIGN KEY ([CléEtablissement]) REFERENCES [dbo].[Etablissements] ([Cle]) ON DELETE SET NULL ON UPDATE NO ACTION,
    FOREIGN KEY ([Nationalite]) REFERENCES [dbo].[Nationalite] ([idNationalite]) ON DELETE NO ACTION ON UPDATE NO ACTION,
    FOREIGN KEY ([CléNiveauEtude]) REFERENCES [dbo].[NiveauxEtudes] ([Clé]) ON DELETE NO ACTION ON UPDATE NO ACTION,
    FOREIGN KEY ([CléStatut]) REFERENCES [dbo].[Statuts] ([Clé]) ON DELETE NO ACTION ON UPDATE NO ACTION
);

