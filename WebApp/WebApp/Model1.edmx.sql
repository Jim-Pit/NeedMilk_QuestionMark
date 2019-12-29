
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/20/2019 22:35:55
-- Generated from EDMX file: C:\Users\Spiridoula\Desktop\V\WebApp\WebApp\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [ordcus];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_CustomerOrdItm]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[OrdItmSet] DROP CONSTRAINT [FK_CustomerOrdItm];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[CustomerSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CustomerSet];
GO
IF OBJECT_ID(N'[dbo].[OrdItmSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[OrdItmSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'CustomerSet'
CREATE TABLE [dbo].[CustomerSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Address] nvarchar(max)  NOT NULL,
    [TK] int  NOT NULL
);
GO

-- Creating table 'OrdItmSet'
CREATE TABLE [dbo].[OrdItmSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Quanti] int  NOT NULL,
    [Cus_ID] int  NOT NULL,
    [Customer_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'CustomerSet'
ALTER TABLE [dbo].[CustomerSet]
ADD CONSTRAINT [PK_CustomerSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'OrdItmSet'
ALTER TABLE [dbo].[OrdItmSet]
ADD CONSTRAINT [PK_OrdItmSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Customer_Id] in table 'OrdItmSet'
ALTER TABLE [dbo].[OrdItmSet]
ADD CONSTRAINT [FK_CustomerOrdItm]
    FOREIGN KEY ([Customer_Id])
    REFERENCES [dbo].[CustomerSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CustomerOrdItm'
CREATE INDEX [IX_FK_CustomerOrdItm]
ON [dbo].[OrdItmSet]
    ([Customer_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------