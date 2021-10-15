
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 10/14/2021 20:17:02
-- Generated from EDMX file: E:\Documentos\dbClass\ORM2\ORMPrac2\Model\DB2Entity.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [DB2];
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

-- Creating table 'AGENTS'
CREATE TABLE [dbo].[AGENTS] (
    [AGENT_CODE] int  NOT NULL,
    [AGENT_NAME] nvarchar(max)  NOT NULL,
    [WORKING_AREA] nvarchar(max)  NOT NULL,
    [COMISSION] decimal(18,3)  NOT NULL,
    [PHONE_NO] nvarchar(max)  NOT NULL,
    [COUNTRY] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'CUSTOMERS'
CREATE TABLE [dbo].[CUSTOMERS] (
    [CUST_CODE] int IDENTITY(1,1) NOT NULL,
    [CUST_NAME] nvarchar(max)  NOT NULL,
    [CUST_CITY] nvarchar(max)  NOT NULL,
    [WORKING_AREA] nvarchar(max)  NOT NULL,
    [CUST_COUNTRY] nvarchar(max)  NOT NULL,
    [GRADE] int  NOT NULL,
    [OPENING_AMT] decimal(18,3)  NOT NULL,
    [RECEIVE_AMT] decimal(18,3)  NOT NULL,
    [PAYMENT_AMT] decimal(18,3)  NOT NULL,
    [OUTSTANDING_AMT] decimal(18,3)  NOT NULL,
    [PHONE_NO] nvarchar(max)  NOT NULL,
    [AGENTS_CODE] int  NOT NULL
);
GO

-- Creating table 'ODER_NUM'
CREATE TABLE [dbo].[ODER_NUM] (
    [ORD_NUM] int IDENTITY(1,1) NOT NULL,
    [ORD_AMOUNT] decimal(18,3)  NOT NULL,
    [ADVANCE_AMOUNT] decimal(18,3)  NOT NULL,
    [ORD_DATE] datetime  NOT NULL,
    [ORD_DESCRIPTION] nvarchar(max)  NOT NULL,
    [AGENT_CODE] int  NOT NULL,
    [CUST_CODE] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [AGENT_CODE] in table 'AGENTS'
ALTER TABLE [dbo].[AGENTS]
ADD CONSTRAINT [PK_AGENTS]
    PRIMARY KEY CLUSTERED ([AGENT_CODE] ASC);
GO

-- Creating primary key on [CUST_CODE] in table 'CUSTOMERS'
ALTER TABLE [dbo].[CUSTOMERS]
ADD CONSTRAINT [PK_CUSTOMERS]
    PRIMARY KEY CLUSTERED ([CUST_CODE] ASC);
GO

-- Creating primary key on [ORD_NUM] in table 'ODER_NUM'
ALTER TABLE [dbo].[ODER_NUM]
ADD CONSTRAINT [PK_ODER_NUM]
    PRIMARY KEY CLUSTERED ([ORD_NUM] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [AGENTS_CODE] in table 'CUSTOMERS'
ALTER TABLE [dbo].[CUSTOMERS]
ADD CONSTRAINT [FK_AGENTSCUSTOMER]
    FOREIGN KEY ([AGENTS_CODE])
    REFERENCES [dbo].[AGENTS]
        ([AGENT_CODE])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AGENTSCUSTOMER'
CREATE INDEX [IX_FK_AGENTSCUSTOMER]
ON [dbo].[CUSTOMERS]
    ([AGENTS_CODE]);
GO

-- Creating foreign key on [AGENT_CODE] in table 'ODER_NUM'
ALTER TABLE [dbo].[ODER_NUM]
ADD CONSTRAINT [FK_AGENTSORDER]
    FOREIGN KEY ([AGENT_CODE])
    REFERENCES [dbo].[AGENTS]
        ([AGENT_CODE])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AGENTSORDER'
CREATE INDEX [IX_FK_AGENTSORDER]
ON [dbo].[ODER_NUM]
    ([AGENT_CODE]);
GO

-- Creating foreign key on [CUST_CODE] in table 'ODER_NUM'
ALTER TABLE [dbo].[ODER_NUM]
ADD CONSTRAINT [FK_CUSTOMERORDER]
    FOREIGN KEY ([CUST_CODE])
    REFERENCES [dbo].[CUSTOMERS]
        ([CUST_CODE])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CUSTOMERORDER'
CREATE INDEX [IX_FK_CUSTOMERORDER]
ON [dbo].[ODER_NUM]
    ([CUST_CODE]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------