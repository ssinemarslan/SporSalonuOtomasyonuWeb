
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/05/2023 18:29:03
-- Generated from EDMX file: C:\Users\sinem\OneDrive\Masaüstü\siteyapımı\SporcuWeb\SporcuWeb\Models\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [SporcuWeb];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'SporcularBilgiSet'
CREATE TABLE [dbo].[SporcularBilgiSet] (
    [SporcuNo] int IDENTITY(1,1) NOT NULL,
    [AdSoyad] nvarchar(max)  NOT NULL,
    [Yas] nvarchar(max)  NOT NULL,
    [Boy] nvarchar(max)  NOT NULL,
    [Kilo] nvarchar(max)  NOT NULL,
    [Adres] nvarchar(max)  NOT NULL,
    [Telefon] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'EgitmenlerBilgiSet'
CREATE TABLE [dbo].[EgitmenlerBilgiSet] (
    [EgitmenNo] int IDENTITY(1,1) NOT NULL,
    [AdSoyad] nvarchar(max)  NOT NULL,
    [Adres] nvarchar(max)  NOT NULL,
    [Telefon] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'SalonlarBilgiSet'
CREATE TABLE [dbo].[SalonlarBilgiSet] (
    [SalonNo] int IDENTITY(1,1) NOT NULL,
    [SalonAdi] nvarchar(max)  NOT NULL,
    [Salonm2] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [SporcuNo] in table 'SporcularBilgiSet'
ALTER TABLE [dbo].[SporcularBilgiSet]
ADD CONSTRAINT [PK_SporcularBilgiSet]
    PRIMARY KEY CLUSTERED ([SporcuNo] ASC);
GO

-- Creating primary key on [EgitmenNo] in table 'EgitmenlerBilgiSet'
ALTER TABLE [dbo].[EgitmenlerBilgiSet]
ADD CONSTRAINT [PK_EgitmenlerBilgiSet]
    PRIMARY KEY CLUSTERED ([EgitmenNo] ASC);
GO

-- Creating primary key on [SalonNo] in table 'SalonlarBilgiSet'
ALTER TABLE [dbo].[SalonlarBilgiSet]
ADD CONSTRAINT [PK_SalonlarBilgiSet]
    PRIMARY KEY CLUSTERED ([SalonNo] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------