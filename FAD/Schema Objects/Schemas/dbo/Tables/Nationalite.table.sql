﻿CREATE TABLE [dbo].[Nationalite] (
    [idNationalite] BIGINT        NOT NULL,
    [Valeur]        NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([idNationalite] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);

