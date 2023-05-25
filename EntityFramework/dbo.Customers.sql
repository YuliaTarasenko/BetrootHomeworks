CREATE TABLE [dbo].[Customers] (
    [CustomerId] INT            NOT NULL,
    [LastName]   NVARCHAR (100) NOT NULL,
    [FirstName]  NVARCHAR (100) NOT NULL,
    [Address]    NVARCHAR (100) NOT NULL,
    [Gender]     NVARCHAR (20)  NOT NULL,
    [Age]        INT            NOT NULL,
    PRIMARY KEY CLUSTERED ([CustomerId] ASC)
);

