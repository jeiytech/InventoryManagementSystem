--
-- Table structure for table `spareparts`
--
CREATE TABLE spareparts (
    [id]      INT           IDENTITY (1, 1) NOT NULL,
    [model]   VARCHAR (100) NOT NULL,
    [part]    VARCHAR (100) NOT NULL,
    [type]    VARCHAR (50)  NOT NULL,
    [price]   VARCHAR (50)  NOT NULL,
    [instock] INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);
