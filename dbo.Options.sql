CREATE TABLE [dbo].[Options] (
    [OptionId] INT  IDENTITY (1, 1) NOT NULL,
    [Text]     VARCHAR(MAX) NOT NULL,
    [Title]    VARCHAR(50) NOT NULL,
    PRIMARY KEY CLUSTERED ([OptionId] ASC)
);

