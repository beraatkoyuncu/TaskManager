CREATE TABLE [dbo].[Manager] (
    [ID]                   INT             IDENTITY (1, 1) NOT NULL,
    [ActivityName]         NVARCHAR (MAX)  NULL,
    [ActivityDate]         NVARCHAR (MAX)  NULL,
    [ActivityHour]         TIME  NULL,
    [ActivityDesctription] NVARCHAR (MAX)  NULL,
    [ReleaseDate]          DATETIME2 (7)   NOT NULL,
    [Genre]                NVARCHAR (MAX)  NULL,
    [Price]                DECIMAL (18, 2) NOT NULL,
    CONSTRAINT [PK_Manager] PRIMARY KEY CLUSTERED ([ID] ASC)
);

