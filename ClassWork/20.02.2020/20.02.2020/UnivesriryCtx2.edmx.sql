
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/20/2020 11:10:50
-- Generated from EDMX file: E:\EntityFramework\ClassWork\20.02.2020\20.02.2020\UnivesriryCtx2.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [university2];
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

-- Creating table 'Specializations'
CREATE TABLE [dbo].[Specializations] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [StudentsId] int  NOT NULL,
    [SubjectsId] int  NOT NULL
);
GO

-- Creating table 'StudentsSet'
CREATE TABLE [dbo].[StudentsSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Surname] nvarchar(max)  NOT NULL,
    [Address] nvarchar(max)  NOT NULL,
    [Phone] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'SubjectsSet'
CREATE TABLE [dbo].[SubjectsSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [AmountOfHour] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Specializations'
ALTER TABLE [dbo].[Specializations]
ADD CONSTRAINT [PK_Specializations]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'StudentsSet'
ALTER TABLE [dbo].[StudentsSet]
ADD CONSTRAINT [PK_StudentsSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'SubjectsSet'
ALTER TABLE [dbo].[SubjectsSet]
ADD CONSTRAINT [PK_SubjectsSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [StudentsId] in table 'Specializations'
ALTER TABLE [dbo].[Specializations]
ADD CONSTRAINT [FK_StudentsSpecializations]
    FOREIGN KEY ([StudentsId])
    REFERENCES [dbo].[StudentsSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_StudentsSpecializations'
CREATE INDEX [IX_FK_StudentsSpecializations]
ON [dbo].[Specializations]
    ([StudentsId]);
GO

-- Creating foreign key on [SubjectsId] in table 'Specializations'
ALTER TABLE [dbo].[Specializations]
ADD CONSTRAINT [FK_SubjectsSpecializations]
    FOREIGN KEY ([SubjectsId])
    REFERENCES [dbo].[SubjectsSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SubjectsSpecializations'
CREATE INDEX [IX_FK_SubjectsSpecializations]
ON [dbo].[Specializations]
    ([SubjectsId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------