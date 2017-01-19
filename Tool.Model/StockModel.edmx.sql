
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 01/19/2017 23:23:18
-- Generated from EDMX file: F:\yc\projects\C#\Stock\StockTool\Tool.Model\StockModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Stock];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Base_Stock]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Base_Stock];
GO
IF OBJECT_ID(N'[dbo].[Detail_Stock]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Detail_Stock];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Base_Stock'
CREATE TABLE [dbo].[Base_Stock] (
    [Code] nchar(6)  NOT NULL,
    [Name] nvarchar(50)  NOT NULL,
    [DateOfIPO] datetime  NOT NULL,
    [FK_IndustryId] int  NULL,
    [FK_AreaId] int  NULL
);
GO

-- Creating table 'Detail_Stock'
CREATE TABLE [dbo].[Detail_Stock] (
    [Code] nchar(6)  NOT NULL,
    [ZSZ] decimal(18,0)  NOT NULL,
    [LTSZ] decimal(18,0)  NOT NULL,
    [ZGB] decimal(18,0)  NOT NULL,
    [LTGB] decimal(18,0)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Code] in table 'Base_Stock'
ALTER TABLE [dbo].[Base_Stock]
ADD CONSTRAINT [PK_Base_Stock]
    PRIMARY KEY CLUSTERED ([Code] ASC);
GO

-- Creating primary key on [Code] in table 'Detail_Stock'
ALTER TABLE [dbo].[Detail_Stock]
ADD CONSTRAINT [PK_Detail_Stock]
    PRIMARY KEY CLUSTERED ([Code] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------