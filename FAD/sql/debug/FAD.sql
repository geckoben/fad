/*
Deployment script for FAD
*/

GO
SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER ON;

SET NUMERIC_ROUNDABORT OFF;


GO
:setvar DatabaseName "FAD"
:setvar DefaultDataPath ""
:setvar DefaultLogPath ""

GO
:on error exit
GO
USE [master]
GO
IF (DB_ID(N'$(DatabaseName)') IS NOT NULL
    AND DATABASEPROPERTYEX(N'$(DatabaseName)','Status') <> N'ONLINE')
BEGIN
    RAISERROR(N'The state of the target database, %s, is not set to ONLINE. To deploy to this database, its state must be set to ONLINE.', 16, 127,N'$(DatabaseName)') WITH NOWAIT
    RETURN
END

GO
IF (DB_ID(N'$(DatabaseName)') IS NOT NULL) 
BEGIN
    ALTER DATABASE [$(DatabaseName)]
    SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE [$(DatabaseName)];
END

GO
PRINT N'Creating $(DatabaseName)...'
GO
CREATE DATABASE [$(DatabaseName)]
    ON 
    PRIMARY(NAME = [FAD2], FILENAME = '$(DefaultDataPath)$(DatabaseName)2.mdf', FILEGROWTH = 1024 KB)
    LOG ON (NAME = [FAD2_log], FILENAME = '$(DefaultLogPath)$(DatabaseName)2_1.ldf', MAXSIZE = 2097152 MB, FILEGROWTH = 10 %) COLLATE French_CI_AS
GO
EXECUTE sp_dbcmptlevel [$(DatabaseName)], 100;


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET ANSI_NULLS ON,
                ANSI_PADDING ON,
                ANSI_WARNINGS ON,
                ARITHABORT ON,
                CONCAT_NULL_YIELDS_NULL ON,
                NUMERIC_ROUNDABORT OFF,
                QUOTED_IDENTIFIER ON,
                ANSI_NULL_DEFAULT ON,
                CURSOR_DEFAULT LOCAL,
                RECOVERY FULL,
                CURSOR_CLOSE_ON_COMMIT OFF,
                AUTO_CREATE_STATISTICS ON,
                AUTO_SHRINK OFF,
                AUTO_UPDATE_STATISTICS ON,
                RECURSIVE_TRIGGERS OFF 
            WITH ROLLBACK IMMEDIATE;
        ALTER DATABASE [$(DatabaseName)]
            SET AUTO_CLOSE OFF 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET ALLOW_SNAPSHOT_ISOLATION OFF;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET READ_COMMITTED_SNAPSHOT OFF;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET AUTO_UPDATE_STATISTICS_ASYNC OFF,
                PAGE_VERIFY NONE,
                DATE_CORRELATION_OPTIMIZATION OFF,
                DISABLE_BROKER,
                PARAMETERIZATION SIMPLE,
                SUPPLEMENTAL_LOGGING OFF 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF IS_SRVROLEMEMBER(N'sysadmin') = 1
    BEGIN
        IF EXISTS (SELECT 1
                   FROM   [master].[dbo].[sysdatabases]
                   WHERE  [name] = N'$(DatabaseName)')
            BEGIN
                EXECUTE sp_executesql N'ALTER DATABASE [$(DatabaseName)]
    SET TRUSTWORTHY OFF,
        DB_CHAINING OFF 
    WITH ROLLBACK IMMEDIATE';
            END
    END
ELSE
    BEGIN
        PRINT N'The database settings cannot be modified. You must be a SysAdmin to apply these settings.';
    END


GO
IF IS_SRVROLEMEMBER(N'sysadmin') = 1
    BEGIN
        IF EXISTS (SELECT 1
                   FROM   [master].[dbo].[sysdatabases]
                   WHERE  [name] = N'$(DatabaseName)')
            BEGIN
                EXECUTE sp_executesql N'ALTER DATABASE [$(DatabaseName)]
    SET HONOR_BROKER_PRIORITY OFF 
    WITH ROLLBACK IMMEDIATE';
            END
    END
ELSE
    BEGIN
        PRINT N'The database settings cannot be modified. You must be a SysAdmin to apply these settings.';
    END


GO
USE [$(DatabaseName)]
GO
IF fulltextserviceproperty(N'IsFulltextInstalled') = 1
    EXECUTE sp_fulltext_database 'enable';


GO
/*
 Pre-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be executed before the build script.	
 Use SQLCMD syntax to include a file in the pre-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the pre-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

GO
PRINT N'Creating [dbo].[CoachComments]...';


GO
CREATE TABLE [dbo].[CoachComments] (
    [id]          INT            NOT NULL,
    [CléCoaching] INT            NOT NULL,
    [CléGroupe]   INT            NOT NULL,
    [Comment]     NVARCHAR (400) NOT NULL,
    [Date]        DATETIME       NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);


GO
PRINT N'Creating [dbo].[Coaches]...';


GO
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


GO
PRINT N'Creating [dbo].[CoachingComments]...';


GO
CREATE TABLE [dbo].[CoachingComments] (
    [id]         INT             NOT NULL,
    [CléSession] NVARCHAR (10)   NULL,
    [CléGroupe]  INT             NULL,
    [Comment]    NVARCHAR (4000) NOT NULL,
    [Date]       DATETIME        NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);


GO
PRINT N'Creating [dbo].[Coachings]...';


GO
CREATE TABLE [dbo].[Coachings] (
    [CléOld]                     INT            NULL,
    [Clé]                        INT            NOT NULL,
    [CléSession]                 NVARCHAR (10)  NOT NULL,
    [CléCoach]                   INT            NOT NULL,
    [OccurenceWebCT]             NVARCHAR (60)  NULL,
    [URN]                        NVARCHAR (60)  NULL,
    [EstCloture]                 NVARCHAR (50)  NULL,
    [Syllabus]                   NVARCHAR (255) NULL,
    [Attestation]                NVARCHAR (255) NULL,
    [Facturation]                NVARCHAR (60)  NULL,
    [EstAvecPAC]                 BIT            NOT NULL,
    [DateVérificationPAC]        DATETIME       NULL,
    [NumBonCommandeCoach]        NVARCHAR (30)  NULL,
    [NumBonCommandeSyllabi]      NVARCHAR (30)  NULL,
    [NumBonCommandeAttestations] NVARCHAR (30)  NULL,
    [NumFactureCoach]            NVARCHAR (30)  NULL,
    [ValidationFacture]          NVARCHAR (30)  NULL,
    [EncodageBDD]                NVARCHAR (60)  NULL,
    [DateBackup]                 NVARCHAR (255) NULL,
    [DateEnvoiForem]             DATETIME       NULL,
    [Remarque]                   NVARCHAR (255) NULL,
    [dateBdc]                    DATETIME       NULL,
    [Commentaire]                NVARCHAR (255) NULL,
    [SyllabusAImprimer]          BIT            NOT NULL,
    [SyllabusAEnvoyer]           BIT            NOT NULL,
    [GestionSyllabusCloture]     BIT            NOT NULL,
    [Cloture]                    BIT            NOT NULL,
    [Imprime]                    BIT            NOT NULL,
    [NePasImprimer]              BIT            NOT NULL,
    [Envoye]                     BIT            NOT NULL,
    [NePasEnvoyer]               BIT            NOT NULL,
    [BonCommande]                VARCHAR (MAX)  NULL,
    [ClotureSyllabus]            BIT            NOT NULL,
    [dateImprime]                DATETIME       NULL,
    [NePasImprime]               BIT            NULL,
    [CommentSyllabus]            TEXT           NULL,
    PRIMARY KEY CLUSTERED ([Clé] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);


GO
PRINT N'Creating [dbo].[Cours]...';


GO
CREATE TABLE [dbo].[Cours] (
    [Clé]         NVARCHAR (10)  NOT NULL,
    [Intitulé]    NVARCHAR (100) NULL,
    [Modules]     INT            NULL,
    [DuréeModule] INT            NULL,
    [Facteur]     INT            NULL,
    PRIMARY KEY CLUSTERED ([Clé] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);


GO
PRINT N'Creating [dbo].[Etablissements]...';


GO
CREATE TABLE [dbo].[Etablissements] (
    [Cle]          INT            NOT NULL,
    [Nom]          NVARCHAR (100) NOT NULL,
    [Implantation] NVARCHAR (100) NULL,
    [Adresse]      NVARCHAR (100) NULL,
    [CodePostal]   NVARCHAR (100) NULL,
    [Localite]     NVARCHAR (100) NULL,
    [CTELH]        BIT            NOT NULL,
    [FASE]         NVARCHAR (100) NULL,
    PRIMARY KEY CLUSTERED ([Cle] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);


GO
PRINT N'Creating [dbo].[Groupes]...';


GO
CREATE TABLE [dbo].[Groupes] (
    [Clé]                INT            NOT NULL,
    [CléSession]         NVARCHAR (10)  NOT NULL,
    [Etablissement]      NVARCHAR (255) NOT NULL,
    [SousGroupe]         VARCHAR (1)    NULL,
    [Spécialisation]     NVARCHAR (255) NULL,
    [Année]              NVARCHAR (255) NULL,
    [NomContact]         NVARCHAR (255) NULL,
    [PrénomContact]      NVARCHAR (255) NULL,
    [AdresseContact]     NVARCHAR (255) NULL,
    [CodePostalContact]  NVARCHAR (4)   NULL,
    [LocalitéContact]    NVARCHAR (255) NULL,
    [TéléphoneContact]   NVARCHAR (255) NULL,
    [HeuresContact]      NVARCHAR (MAX) NULL,
    [EmailContact]       NVARCHAR (255) NULL,
    [PlageHoraire]       NVARCHAR (50)  NULL,
    [NuméroConvention]   NVARCHAR (255) NULL,
    [Trimestre]          SMALLINT       NULL,
    [Source]             NVARCHAR (255) NULL,
    [AutresInfos]        NVARCHAR (MAX) NULL,
    [Tarif]              NVARCHAR (255) NULL,
    [Suivi]              NVARCHAR (MAX) NULL,
    [SSMA_TimeStamp]     VARBINARY (1)  NOT NULL,
    [Fase]               NVARCHAR (10)  NULL,
    [Imprime]            BIT            NOT NULL,
    [NePasImprimer]      BIT            NOT NULL,
    [Envoye]             BIT            NOT NULL,
    [NePasEnvoyer]       BIT            NOT NULL,
    [NePasImprime]       BIT            NULL,
    [CommentSyllabus]    TEXT           NULL,
    [IFC]                BIT            NOT NULL,
    [EnvoiAdressePrivee] BIT            NOT NULL,
    [CléEtablissement]   INT            NULL,
    PRIMARY KEY CLUSTERED ([Clé] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);


GO
PRINT N'Creating [dbo].[Inscrits]...';


GO
CREATE TABLE [dbo].[Inscrits] (
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
    [PAC]                 BIT            NOT NULL,
    [EnvoiAdressePrivee]  BIT            NOT NULL,
    [CléEtablissement]    INT            NULL,
    PRIMARY KEY CLUSTERED ([Clé] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);


GO
PRINT N'Creating [dbo].[Membres]...';


GO
CREATE TABLE [dbo].[Membres] (
    [Clé]                     INT            NOT NULL,
    [CléInscrit]              INT            NOT NULL,
    [CléGroupe]               INT            NOT NULL,
    [CléCoachingOld]          INT            NULL,
    [CléCoaching]             INT            NULL,
    [NbModulesSuivis]         INT            NULL,
    [RemarqueCoach]           NVARCHAR (MAX) NULL,
    [DateInscription]         DATETIME       NULL,
    [Tarif]                   NVARCHAR (255) NULL,
    [Syllabus]                NVARCHAR (255) NULL,
    [Attestation]             NVARCHAR (255) NULL,
    [IDWebCT]                 NVARCHAR (50)  NULL,
    [MotPasseWebCT]           NVARCHAR (50)  NULL,
    [AutresInfos]             NVARCHAR (MAX) NULL,
    [EstEmailDémarrageEnvoyé] BIT            NOT NULL,
    [Commentaire]             NVARCHAR (MAX) NULL,
    [SSMA_TimeStamp]          VARBINARY (1)  NOT NULL,
    [Imprime]                 BIT            NOT NULL,
    [NePasImprimer]           BIT            NOT NULL,
    [Envoye]                  BIT            NOT NULL,
    [NePasEnvoyer]            BIT            NOT NULL,
    [ClotureSyllabus]         BIT            NOT NULL,
    [DateClotureSyllabus]     DATETIME       NULL,
    [NePasImprime]            BIT            NULL,
    [CommentSyllabus]         TEXT           NULL,
    PRIMARY KEY CLUSTERED ([Clé] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);


GO
PRINT N'Creating [dbo].[Modules]...';


GO
CREATE TABLE [dbo].[Modules] (
    [Clé]              INT           NOT NULL,
    [CléMembre]        INT           NOT NULL,
    [NuméroModule]     NVARCHAR (10) NOT NULL,
    [DateModification] DATETIME      NOT NULL,
    PRIMARY KEY CLUSTERED ([Clé] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);


GO
PRINT N'Creating [dbo].[Nationalite]...';


GO
CREATE TABLE [dbo].[Nationalite] (
    [idNationalite] BIGINT        NOT NULL,
    [Valeur]        NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([idNationalite] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);


GO
PRINT N'Creating [dbo].[NiveauxEtudes]...';


GO
CREATE TABLE [dbo].[NiveauxEtudes] (
    [Clé]          NVARCHAR (2)   NOT NULL,
    [Dénomination] NVARCHAR (255) NOT NULL,
    PRIMARY KEY CLUSTERED ([Clé] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);


GO
PRINT N'Creating [dbo].[Parametre]...';


GO
CREATE TABLE [dbo].[Parametre] (
    [idParam]   BIGINT NOT NULL,
    [idSession] BIGINT NOT NULL,
    PRIMARY KEY CLUSTERED ([idParam] ASC, [idSession] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);


GO
PRINT N'Creating [dbo].[Sessions]...';


GO
CREATE TABLE [dbo].[Sessions] (
    [Clé]             NVARCHAR (10)  NOT NULL,
    [CléCours]        NVARCHAR (10)  NOT NULL,
    [DateDébut]       DATETIME       NULL,
    [DateFin]         DATETIME       NULL,
    [AutresInfos]     NVARCHAR (MAX) NULL,
    [SSMA_TimeStamp]  VARBINARY (1)  NOT NULL,
    [Imprime]         BIT            NOT NULL,
    [NePasImprimer]   BIT            NOT NULL,
    [Envoye]          BIT            NOT NULL,
    [NePasEnvoyer]    BIT            NOT NULL,
    [NePasImprime]    BIT            NULL,
    [CommentSyllabus] TEXT           NULL,
    PRIMARY KEY CLUSTERED ([Clé] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);


GO
PRINT N'Creating [dbo].[Statuts]...';


GO
CREATE TABLE [dbo].[Statuts] (
    [Clé]          NVARCHAR (11) NOT NULL,
    [Dénomination] NVARCHAR (30) NOT NULL,
    PRIMARY KEY CLUSTERED ([Clé] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);


GO
PRINT N'Creating [dbo].[SuiviConvention]...';


GO
CREATE TABLE [dbo].[SuiviConvention] (
    [NumeroConvention] NVARCHAR (255) NOT NULL,
    [Envoye]           BIT            NULL,
    [recu]             BIT            NULL,
    [commentaires]     TEXT           NULL
);


GO
PRINT N'Creating [dbo].[Suivis]...';


GO
CREATE TABLE [dbo].[Suivis] (
    [Clé]         INT            NOT NULL,
    [CléCoaching] INT            NOT NULL,
    [TypeSuivi]   NVARCHAR (50)  NOT NULL,
    [DateSuivi]   DATETIME       NOT NULL,
    [Commentaire] NVARCHAR (MAX) NULL,
    [Auteur]      NVARCHAR (50)  NULL,
    PRIMARY KEY CLUSTERED ([Clé] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);


GO
PRINT N'Creating [dbo].[sysdiagrams]...';


GO
CREATE TABLE [dbo].[sysdiagrams] (
    [name]         NVARCHAR (128)  NOT NULL,
    [principal_id] INT             NOT NULL,
    [diagram_id]   INT             NOT NULL,
    [version]      INT             NULL,
    [definition]   VARBINARY (MAX) NULL
);


GO
PRINT N'Creating [dbo].[Tarifs]...';


GO
CREATE TABLE [dbo].[Tarifs] (
    [Clé]           INT             NOT NULL,
    [CléCoach]      INT             NOT NULL,
    [CléCours]      NVARCHAR (10)   NOT NULL,
    [DateDébut]     DATETIME        NOT NULL,
    [DateFin]       DATETIME        NOT NULL,
    [NumAppelOffre] NTEXT           NULL,
    [TarifHoraire]  DECIMAL (10, 2) NULL,
    PRIMARY KEY CLUSTERED ([Clé] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);


GO
PRINT N'Creating [dbo].[TempTable]...';


GO
CREATE TABLE [dbo].[TempTable] (
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
    [PAC]                 BIT            NOT NULL,
    [EnvoiAdressePrivee]  BIT            NOT NULL,
    [CléEtablissement]    INT            NULL
);


GO
PRINT N'Creating [dbo].[Utilisateur]...';


GO
CREATE TABLE [dbo].[Utilisateur] (
    [idUtilisateur] INT           NOT NULL,
    [eMail]         NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([idUtilisateur] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);


GO
PRINT N'Creating On column: Cloture...';


GO
ALTER TABLE [dbo].[Coachings]
    ADD DEFAULT ((0)) FOR [Cloture];


GO
PRINT N'Creating On column: Imprime...';


GO
ALTER TABLE [dbo].[Coachings]
    ADD DEFAULT ((0)) FOR [Imprime];


GO
PRINT N'Creating On column: NePasImprimer...';


GO
ALTER TABLE [dbo].[Coachings]
    ADD DEFAULT ((0)) FOR [NePasImprimer];


GO
PRINT N'Creating On column: Envoye...';


GO
ALTER TABLE [dbo].[Coachings]
    ADD DEFAULT ((0)) FOR [Envoye];


GO
PRINT N'Creating On column: NePasEnvoyer...';


GO
ALTER TABLE [dbo].[Coachings]
    ADD DEFAULT ((0)) FOR [NePasEnvoyer];


GO
PRINT N'Creating On column: ClotureSyllabus...';


GO
ALTER TABLE [dbo].[Coachings]
    ADD DEFAULT ((0)) FOR [ClotureSyllabus];


GO
PRINT N'Creating On column: CTELH...';


GO
ALTER TABLE [dbo].[Etablissements]
    ADD DEFAULT ((0)) FOR [CTELH];


GO
PRINT N'Creating On column: Imprime...';


GO
ALTER TABLE [dbo].[Groupes]
    ADD DEFAULT ((0)) FOR [Imprime];


GO
PRINT N'Creating On column: NePasImprimer...';


GO
ALTER TABLE [dbo].[Groupes]
    ADD DEFAULT ((0)) FOR [NePasImprimer];


GO
PRINT N'Creating On column: Envoye...';


GO
ALTER TABLE [dbo].[Groupes]
    ADD DEFAULT ((0)) FOR [Envoye];


GO
PRINT N'Creating On column: NePasEnvoyer...';


GO
ALTER TABLE [dbo].[Groupes]
    ADD DEFAULT ((0)) FOR [NePasEnvoyer];


GO
PRINT N'Creating On column: IFC...';


GO
ALTER TABLE [dbo].[Groupes]
    ADD DEFAULT ((0)) FOR [IFC];


GO
PRINT N'Creating On column: EnvoiAdressePrivee...';


GO
ALTER TABLE [dbo].[Groupes]
    ADD DEFAULT ((0)) FOR [EnvoiAdressePrivee];


GO
PRINT N'Creating On column: PAC...';


GO
ALTER TABLE [dbo].[Inscrits]
    ADD DEFAULT ((0)) FOR [PAC];


GO
PRINT N'Creating On column: EnvoiAdressePrivee...';


GO
ALTER TABLE [dbo].[Inscrits]
    ADD DEFAULT ((0)) FOR [EnvoiAdressePrivee];


GO
PRINT N'Creating On column: Imprime...';


GO
ALTER TABLE [dbo].[Membres]
    ADD DEFAULT ((0)) FOR [Imprime];


GO
PRINT N'Creating On column: NePasImprimer...';


GO
ALTER TABLE [dbo].[Membres]
    ADD DEFAULT ((0)) FOR [NePasImprimer];


GO
PRINT N'Creating On column: Envoye...';


GO
ALTER TABLE [dbo].[Membres]
    ADD DEFAULT ((0)) FOR [Envoye];


GO
PRINT N'Creating On column: NePasEnvoyer...';


GO
ALTER TABLE [dbo].[Membres]
    ADD DEFAULT ((0)) FOR [NePasEnvoyer];


GO
PRINT N'Creating On column: ClotureSyllabus...';


GO
ALTER TABLE [dbo].[Membres]
    ADD DEFAULT ((0)) FOR [ClotureSyllabus];


GO
PRINT N'Creating On column: Imprime...';


GO
ALTER TABLE [dbo].[Sessions]
    ADD DEFAULT ((0)) FOR [Imprime];


GO
PRINT N'Creating On column: NePasImprimer...';


GO
ALTER TABLE [dbo].[Sessions]
    ADD DEFAULT ((0)) FOR [NePasImprimer];


GO
PRINT N'Creating On column: Envoye...';


GO
ALTER TABLE [dbo].[Sessions]
    ADD DEFAULT ((0)) FOR [Envoye];


GO
PRINT N'Creating On column: NePasEnvoyer...';


GO
ALTER TABLE [dbo].[Sessions]
    ADD DEFAULT ((0)) FOR [NePasEnvoyer];


GO
PRINT N'Creating On table: CoachComments...';


GO
ALTER TABLE [dbo].[CoachComments] WITH NOCHECK
    ADD FOREIGN KEY ([CléCoaching]) REFERENCES [dbo].[Coachings] ([Clé]) ON DELETE NO ACTION ON UPDATE NO ACTION;


GO
PRINT N'Creating On table: CoachComments...';


GO
ALTER TABLE [dbo].[CoachComments] WITH NOCHECK
    ADD FOREIGN KEY ([CléGroupe]) REFERENCES [dbo].[Groupes] ([Clé]) ON DELETE NO ACTION ON UPDATE NO ACTION;


GO
PRINT N'Creating On table: CoachingComments...';


GO
ALTER TABLE [dbo].[CoachingComments] WITH NOCHECK
    ADD FOREIGN KEY ([CléGroupe]) REFERENCES [dbo].[Groupes] ([Clé]) ON DELETE NO ACTION ON UPDATE NO ACTION;


GO
PRINT N'Creating On table: CoachingComments...';


GO
ALTER TABLE [dbo].[CoachingComments] WITH NOCHECK
    ADD FOREIGN KEY ([CléSession]) REFERENCES [dbo].[Sessions] ([Clé]) ON DELETE CASCADE ON UPDATE NO ACTION;


GO
PRINT N'Creating On table: Coachings...';


GO
ALTER TABLE [dbo].[Coachings] WITH NOCHECK
    ADD FOREIGN KEY ([CléCoach]) REFERENCES [dbo].[Coaches] ([Clé]) ON DELETE NO ACTION ON UPDATE NO ACTION;


GO
PRINT N'Creating On table: Coachings...';


GO
ALTER TABLE [dbo].[Coachings] WITH NOCHECK
    ADD FOREIGN KEY ([CléSession]) REFERENCES [dbo].[Sessions] ([Clé]) ON DELETE NO ACTION ON UPDATE NO ACTION;


GO
PRINT N'Creating On table: Groupes...';


GO
ALTER TABLE [dbo].[Groupes] WITH NOCHECK
    ADD FOREIGN KEY ([CléEtablissement]) REFERENCES [dbo].[Etablissements] ([Cle]) ON DELETE NO ACTION ON UPDATE NO ACTION;


GO
PRINT N'Creating On table: Groupes...';


GO
ALTER TABLE [dbo].[Groupes] WITH NOCHECK
    ADD FOREIGN KEY ([CléSession]) REFERENCES [dbo].[Sessions] ([Clé]) ON DELETE CASCADE ON UPDATE NO ACTION;


GO
PRINT N'Creating On table: Inscrits...';


GO
ALTER TABLE [dbo].[Inscrits] WITH NOCHECK
    ADD FOREIGN KEY ([CléEtablissement]) REFERENCES [dbo].[Etablissements] ([Cle]) ON DELETE SET NULL ON UPDATE NO ACTION;


GO
PRINT N'Creating On table: Inscrits...';


GO
ALTER TABLE [dbo].[Inscrits] WITH NOCHECK
    ADD FOREIGN KEY ([Nationalite]) REFERENCES [dbo].[Nationalite] ([idNationalite]) ON DELETE NO ACTION ON UPDATE NO ACTION;


GO
PRINT N'Creating On table: Inscrits...';


GO
ALTER TABLE [dbo].[Inscrits] WITH NOCHECK
    ADD FOREIGN KEY ([CléNiveauEtude]) REFERENCES [dbo].[NiveauxEtudes] ([Clé]) ON DELETE NO ACTION ON UPDATE NO ACTION;


GO
PRINT N'Creating On table: Inscrits...';


GO
ALTER TABLE [dbo].[Inscrits] WITH NOCHECK
    ADD FOREIGN KEY ([CléStatut]) REFERENCES [dbo].[Statuts] ([Clé]) ON DELETE NO ACTION ON UPDATE NO ACTION;


GO
PRINT N'Creating On table: Membres...';


GO
ALTER TABLE [dbo].[Membres] WITH NOCHECK
    ADD FOREIGN KEY ([CléInscrit]) REFERENCES [dbo].[Inscrits] ([Clé]) ON DELETE CASCADE ON UPDATE NO ACTION;


GO
PRINT N'Creating On table: Membres...';


GO
ALTER TABLE [dbo].[Membres] WITH NOCHECK
    ADD FOREIGN KEY ([CléCoaching]) REFERENCES [dbo].[Coachings] ([Clé]) ON DELETE NO ACTION ON UPDATE NO ACTION;


GO
PRINT N'Creating On table: Membres...';


GO
ALTER TABLE [dbo].[Membres] WITH NOCHECK
    ADD FOREIGN KEY ([CléGroupe]) REFERENCES [dbo].[Groupes] ([Clé]) ON DELETE CASCADE ON UPDATE NO ACTION;


GO
PRINT N'Creating On table: Sessions...';


GO
ALTER TABLE [dbo].[Sessions] WITH NOCHECK
    ADD FOREIGN KEY ([CléCours]) REFERENCES [dbo].[Cours] ([Clé]) ON DELETE NO ACTION ON UPDATE NO ACTION;


GO
PRINT N'Creating On table: Suivis...';


GO
ALTER TABLE [dbo].[Suivis] WITH NOCHECK
    ADD FOREIGN KEY ([CléCoaching]) REFERENCES [dbo].[Coachings] ([Clé]) ON DELETE NO ACTION ON UPDATE NO ACTION;


GO
PRINT N'Creating [dbo].[SetCloture]...';


GO
CREATE TRIGGER [SetCloture]
ON [Coachings]
AFTER INSERT, UPDATE
AS

BEGIN
	if(update(EstCloture))
	begin
		print 'ok'
		update Coachings set Cloture=1 where Clé=(select Clé from inserted)
	end
END
GO
PRINT N'Creating [dbo].[Coachings].[Cloture].[MS_Description]...';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'La table coaching dispose actuellement d’un champ intitulé ‘EstCloturé’. Ce champ prend la valeur ‘ok’ lorsqu’un coaching est clôturé. (Attention, la valeur du champ peut également être complétée avec les valeurs ‘Ok’, ‘OK’ ou d’autres valeurs suivies d’un texte. Il s’agit d’un champ de type texte. Ce champ n’est pas rempli lorsque le coaching n’est pas clôturé. Ce champ est fonctionnel, cependant, il n’est pas optimal pour les opérations de recherche et de filtre car il impose une comparaison de String plutôt qu’une comparaison de bit. Afin d’améliorer les requêtes, un champ ‘Cloture’ de type boolean va être ajouté à la base de données. Ce champ ne va pas remplacer l’ancien champ (ce qui impliquerait de trop grosses modifications dans l’application Access actuelle). Un trigger va être ajouté à la base de données de manière à ce que le champ ‘Cloture’ soit rempli à ‘true’ lorsque le champ ‘EstCloture’ est fixé à ‘ok’.', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Coachings', @level2type = N'COLUMN', @level2name = N'Cloture';


GO
PRINT N'Creating [dbo].[Coachings].[Imprime].[MS_Description]...';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Le champ permet d’indiquer manuellement que les syllabus pour le coaching ont été traités manuellement (en dehors de l’impression automatique).', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Coachings', @level2type = N'COLUMN', @level2name = N'Imprime';


GO
PRINT N'Creating [dbo].[Coachings].[NePasImprimer].[MS_Description]...';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Le champ permet d’indiquer manuellement que les syllabus pour le coaching ne doivent pas être imprimés.', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Coachings', @level2type = N'COLUMN', @level2name = N'NePasImprimer';


GO
PRINT N'Creating [dbo].[Coachings].[Envoye].[MS_Description]...';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Le champ permet d’indiquer manuellement que les syllabus pour le coaching ont été envoyés manuellement (en dehors de l’envoi automatique).', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Coachings', @level2type = N'COLUMN', @level2name = N'Envoye';


GO
PRINT N'Creating [dbo].[Coachings].[NePasEnvoyer].[MS_Description]...';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Le champ permet d’indiquer manuellement que les syllabus pour le coaching ne doivent pas être envoyés.', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Coachings', @level2type = N'COLUMN', @level2name = N'NePasEnvoyer';


GO
PRINT N'Creating [dbo].[Coachings].[BonCommande].[MS_Description]...';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Le champ permet d’indiquer manuellement le bon de commande lié au coaching', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Coachings', @level2type = N'COLUMN', @level2name = N'BonCommande';


GO
PRINT N'Creating [dbo].[Coachings].[ClotureSyllabus].[MS_Description]...';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Le champ ‘ClotureSyllabus’ va permettre d’indiquer que le traitement d’impression et d’envoi des syllabus est finalisé pour le coaching. A partir de ce moment, il n’est plus possible de modifier les informations concernant les syllabus pour le coaching.', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Coachings', @level2type = N'COLUMN', @level2name = N'ClotureSyllabus';


GO
PRINT N'Creating [dbo].[Groupes].[Imprime].[MS_Description]...';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Le champ permet d’indiquer manuellement que les syllabus pour le groupe ont été traités manuellement (en dehors de l’impression automatique).', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Groupes', @level2type = N'COLUMN', @level2name = N'Imprime';


GO
PRINT N'Creating [dbo].[Groupes].[NePasImprimer].[MS_Description]...';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Le champ permet d’indiquer manuellement que les syllabus pour le groupe ne doivent pas être imprimés', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Groupes', @level2type = N'COLUMN', @level2name = N'NePasImprimer';


GO
PRINT N'Creating [dbo].[Groupes].[Envoye].[MS_Description]...';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Le champ permet d’indiquer manuellement que les syllabus pour le groupe ont été envoyés manuellement (en dehors de l’envoi automatique).', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Groupes', @level2type = N'COLUMN', @level2name = N'Envoye';


GO
PRINT N'Creating [dbo].[Groupes].[NePasEnvoyer].[MS_Description]...';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Le champ permet d’indiquer manuellement que les syllabus pour le groupe ne doivent pas être envoyés.', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Groupes', @level2type = N'COLUMN', @level2name = N'NePasEnvoyer';


GO
PRINT N'Creating [dbo].[Membres].[ClotureSyllabus].[MS_Description]...';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Le champ ‘ClotureSyllabus’ va permettre d’indiquer que le traitement d’impression et d’envoi des syllabus est finalisé pour le membre. A partir de ce moment, il n’est plus possible de modifier les informations concernant le syllabus pour le membre', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Membres', @level2type = N'COLUMN', @level2name = N'ClotureSyllabus';


GO
PRINT N'Creating [dbo].[Membres].[DateClotureSyllabus].[MS_Description]...';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Le champ ‘DateClotureSyllabus’ va permettre d’indiquer la date à laquelle l’impression et l’envoi des syllabus a été finalisée pour le membre.', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Membres', @level2type = N'COLUMN', @level2name = N'DateClotureSyllabus';


GO
-- Refactoring step to update target server with deployed transaction logs
CREATE TABLE  [dbo].[__RefactorLog] (OperationKey UNIQUEIDENTIFIER NOT NULL PRIMARY KEY)
GO
sp_addextendedproperty N'microsoft_database_tools_support', N'refactoring log', N'schema', N'dbo', N'table', N'__RefactorLog'
GO

GO
/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

GO
PRINT N'Checking existing data against newly created constraints';


GO
USE [$(DatabaseName)];


GO

GO
CREATE TABLE [#__checkStatus] (
    [Table]      NVARCHAR (270),
    [Constraint] NVARCHAR (270),
    [Where]      NVARCHAR (MAX)
);

SET NOCOUNT ON;


GO
INSERT INTO [#__checkStatus]
EXECUTE (N'DBCC CHECKCONSTRAINTS (N''[dbo].[CoachComments]'')
    WITH NO_INFOMSGS');

IF @@ROWCOUNT > 0
    BEGIN
        DROP TABLE [#__checkStatus];
        RAISERROR (N'An error occured while verifying constraints on table [dbo].[CoachComments]', 16, 127);
    END


GO
INSERT INTO [#__checkStatus]
EXECUTE (N'DBCC CHECKCONSTRAINTS (N''[dbo].[CoachingComments]'')
    WITH NO_INFOMSGS');

IF @@ROWCOUNT > 0
    BEGIN
        DROP TABLE [#__checkStatus];
        RAISERROR (N'An error occured while verifying constraints on table [dbo].[CoachingComments]', 16, 127);
    END


GO
INSERT INTO [#__checkStatus]
EXECUTE (N'DBCC CHECKCONSTRAINTS (N''[dbo].[Coachings]'')
    WITH NO_INFOMSGS');

IF @@ROWCOUNT > 0
    BEGIN
        DROP TABLE [#__checkStatus];
        RAISERROR (N'An error occured while verifying constraints on table [dbo].[Coachings]', 16, 127);
    END


GO
INSERT INTO [#__checkStatus]
EXECUTE (N'DBCC CHECKCONSTRAINTS (N''[dbo].[Groupes]'')
    WITH NO_INFOMSGS');

IF @@ROWCOUNT > 0
    BEGIN
        DROP TABLE [#__checkStatus];
        RAISERROR (N'An error occured while verifying constraints on table [dbo].[Groupes]', 16, 127);
    END


GO
INSERT INTO [#__checkStatus]
EXECUTE (N'DBCC CHECKCONSTRAINTS (N''[dbo].[Inscrits]'')
    WITH NO_INFOMSGS');

IF @@ROWCOUNT > 0
    BEGIN
        DROP TABLE [#__checkStatus];
        RAISERROR (N'An error occured while verifying constraints on table [dbo].[Inscrits]', 16, 127);
    END


GO
INSERT INTO [#__checkStatus]
EXECUTE (N'DBCC CHECKCONSTRAINTS (N''[dbo].[Membres]'')
    WITH NO_INFOMSGS');

IF @@ROWCOUNT > 0
    BEGIN
        DROP TABLE [#__checkStatus];
        RAISERROR (N'An error occured while verifying constraints on table [dbo].[Membres]', 16, 127);
    END


GO
INSERT INTO [#__checkStatus]
EXECUTE (N'DBCC CHECKCONSTRAINTS (N''[dbo].[Sessions]'')
    WITH NO_INFOMSGS');

IF @@ROWCOUNT > 0
    BEGIN
        DROP TABLE [#__checkStatus];
        RAISERROR (N'An error occured while verifying constraints on table [dbo].[Sessions]', 16, 127);
    END


GO
INSERT INTO [#__checkStatus]
EXECUTE (N'DBCC CHECKCONSTRAINTS (N''[dbo].[Suivis]'')
    WITH NO_INFOMSGS');

IF @@ROWCOUNT > 0
    BEGIN
        DROP TABLE [#__checkStatus];
        RAISERROR (N'An error occured while verifying constraints on table [dbo].[Suivis]', 16, 127);
    END


GO
SET NOCOUNT OFF;

DROP TABLE [#__checkStatus];


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        DECLARE @VarDecimalSupported AS BIT;
        SELECT @VarDecimalSupported = 0;
        IF ((ServerProperty(N'EngineEdition') = 3)
            AND (((@@microsoftversion / power(2, 24) = 9)
                  AND (@@microsoftversion & 0xffff >= 3024))
                 OR ((@@microsoftversion / power(2, 24) = 10)
                     AND (@@microsoftversion & 0xffff >= 1600))))
            SELECT @VarDecimalSupported = 1;
        IF (@VarDecimalSupported > 0)
            BEGIN
                EXECUTE sp_db_vardecimal_storage_format N'$(DatabaseName)', 'ON';
            END
    END


GO
ALTER DATABASE [$(DatabaseName)]
    SET MULTI_USER 
    WITH ROLLBACK IMMEDIATE;


GO
