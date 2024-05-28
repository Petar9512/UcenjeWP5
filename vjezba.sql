--create database vjezba;

--create table IspitniRok(
--sifra int NOT NULL,
--predmet varchar(50) NOT NULL,
--vrstaIspita varchar(50) NOT NULL,
--datum datetime,
--pristupio bit NOT NULL
--);

--create table Pristupnici(
--ispitniRok int NOT NULL,
--student varchar(50) NOT NULL,
--brojBodova int NOT NULL,
--ocjena int NOT NULL
--);

--create table odjel(
--sifra int,
--naziv varchar(45)
--);

--create table zaposlenik(
--sifra int,
--nadredeni int,
--ime varchar(45),
--prezime varchar(45),
--datumrodenja datetime,
--placa decimal(18,2),
--odjel int
--);

--create table projekt(
--sifra int,
--naziv varchar(45),
--datumpocetka datetime,
--datumkraja datetime
--);

--create table sudjeluje(
--zaposlenik int,
--projekt int,
--datumpristupanja datetime
--);

--create table Racun(
--sifra int NOT NULL,
--redniBroj int NOT NULL,
--datum datetime,
--kupac varchar(50) NOT NULL,
--placeno bit NOT NULL
--);

--create table StavkeRacuna(
--racun int NOT NULL,
--artikl varchar(50) NOT NULL,
--cijena decimal(18,2) NOT NULL,
--kolicina varchar(20) NOT NULL,
--popust varchar(20) NOT NULL
--);

--create table radnik(
--sifra int NOT NULL,
--Ime nvarchar(50) NOT NULL,
--Prezime nvarchar(50) NOT NULL,
--nadredeni int NOT NULL
--);