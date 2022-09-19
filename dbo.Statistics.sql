CREATE TABLE [dbo].[Statistics] (
    [TI]       NVARCHAR(50)        NULL,
    [Couse]    NVARCHAR(50) NULL,
    [ASDU]     INT NULL,
    [IOA]      INT NULL,
    [Value]    NVARCHAR(50) NULL,
    [Status]   NVARCHAR(50) NULL,
    [Time Tag] DATETIME NULL,
    [Count]    INT NULL,
    [Name]     NVARCHAR(50) NULL,
    PRIMARY KEY CLUSTERED ([Name] ASC)
);

