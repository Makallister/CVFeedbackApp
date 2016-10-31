CREATE TABLE [dbo].[Applicant] (
    [ApplicantId]    INT  IDENTITY (1, 1) NOT NULL,
    [Applicant Name] VARCHAR(50) NULL,
    [E-mail address] TEXT NULL,
    PRIMARY KEY CLUSTERED ([ApplicantId] ASC)
);

