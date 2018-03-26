
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/09/2018 11:17:26
-- Generated from EDMX file: C:\Users\leona\source\repos\Lab3WinForm\Lab3Datalayer\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [osu1812];
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

-- Creating table 'Heroes'
CREATE TABLE [dbo].[Heroes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [SuperName] nvarchar(max)  NOT NULL,
    [RealName] nvarchar(max)  NOT NULL,
    [Age] int  NOT NULL,
    [City] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Abilities'
CREATE TABLE [dbo].[Abilities] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Cooldown] int  NOT NULL,
    [Damage] int  NOT NULL,
    [Description] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Jobs1'
CREATE TABLE [dbo].[Jobs1] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Location] nvarchar(max)  NOT NULL,
    [StartDate] datetime  NOT NULL,
    [EndDate] datetime  NOT NULL
);
GO

-- Creating table 'HeroAbility'
CREATE TABLE [dbo].[HeroAbility] (
    [Heroes_Id] int  NOT NULL,
    [Abilities_Id] int  NOT NULL
);
GO

-- Creating table 'HeroJob'
CREATE TABLE [dbo].[HeroJob] (
    [Heroes_Id] int  NOT NULL,
    [Jobs_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Heroes'
ALTER TABLE [dbo].[Heroes]
ADD CONSTRAINT [PK_Heroes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Abilities'
ALTER TABLE [dbo].[Abilities]
ADD CONSTRAINT [PK_Abilities]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Jobs1'
ALTER TABLE [dbo].[Jobs1]
ADD CONSTRAINT [PK_Jobs1]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Heroes_Id], [Abilities_Id] in table 'HeroAbility'
ALTER TABLE [dbo].[HeroAbility]
ADD CONSTRAINT [PK_HeroAbility]
    PRIMARY KEY CLUSTERED ([Heroes_Id], [Abilities_Id] ASC);
GO

-- Creating primary key on [Heroes_Id], [Jobs_Id] in table 'HeroJob'
ALTER TABLE [dbo].[HeroJob]
ADD CONSTRAINT [PK_HeroJob]
    PRIMARY KEY CLUSTERED ([Heroes_Id], [Jobs_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Heroes_Id] in table 'HeroAbility'
ALTER TABLE [dbo].[HeroAbility]
ADD CONSTRAINT [FK_HeroAbility_Hero]
    FOREIGN KEY ([Heroes_Id])
    REFERENCES [dbo].[Heroes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Abilities_Id] in table 'HeroAbility'
ALTER TABLE [dbo].[HeroAbility]
ADD CONSTRAINT [FK_HeroAbility_Ability]
    FOREIGN KEY ([Abilities_Id])
    REFERENCES [dbo].[Abilities]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_HeroAbility_Ability'
CREATE INDEX [IX_FK_HeroAbility_Ability]
ON [dbo].[HeroAbility]
    ([Abilities_Id]);
GO

-- Creating foreign key on [Heroes_Id] in table 'HeroJob'
ALTER TABLE [dbo].[HeroJob]
ADD CONSTRAINT [FK_HeroJob_Hero]
    FOREIGN KEY ([Heroes_Id])
    REFERENCES [dbo].[Heroes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Jobs_Id] in table 'HeroJob'
ALTER TABLE [dbo].[HeroJob]
ADD CONSTRAINT [FK_HeroJob_Job]
    FOREIGN KEY ([Jobs_Id])
    REFERENCES [dbo].[Jobs1]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_HeroJob_Job'
CREATE INDEX [IX_FK_HeroJob_Job]
ON [dbo].[HeroJob]
    ([Jobs_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------