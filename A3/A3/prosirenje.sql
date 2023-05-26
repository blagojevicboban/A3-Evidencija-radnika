CREATE TABLE [dbo].[Podizvodjac] (
    [PodizvodjacID] INT          NOT NULL,
    [Naziv]         VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([PodizvodjacID] ASC)
);
 
CREATE TABLE [dbo].[Angazovanje_Podizvodjaca] (
    [PodizvodjacID]  INT  NOT NULL,
    [ProjekatID]     INT  NOT NULL,
    [DatumPocetka]   DATE DEFAULT (getdate()) NOT NULL,
    [DatumZavrsetka] DATE DEFAULT (datefromparts(datepart(year,getdate()),(12),(31))) NOT NULL,
    PRIMARY KEY CLUSTERED ([PodizvodjacID] ASC, [ProjekatID] ASC),
    FOREIGN KEY ([PodizvodjacID]) REFERENCES [dbo].[Podizvodjac] ([PodizvodjacID]),
    FOREIGN KEY ([ProjekatID]) REFERENCES [dbo].[Projekat] ([ProjekatID]),
    CHECK ([DatumZavrsetka]>[DatumPocetka])
);