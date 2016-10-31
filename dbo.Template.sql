CREATE TABLE [dbo].[Template] (
    [TemplateId]  INT  IDENTITY (1, 1) NOT NULL,
    [Title]       VARCHAR(50) NULL,
    [Header]      TEXT NOT NULL,
    [Footer]      TEXT NOT NULL,
    [OptionsetID] INT  NULL,
    PRIMARY KEY CLUSTERED ([TemplateId] ASC),
    CONSTRAINT [OptionSetID] FOREIGN KEY ([OptionsetID]) REFERENCES [dbo].[OptionSet] ([OptionSetId]) 
);

