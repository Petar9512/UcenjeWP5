use master;
go
drop database if exists random_baze6;
go
create database random_baze6;
go
use random_baze6;

create table Teta(
tetaID int not null primary key identity(1,1),
ime varchar(30) not null,
prezime varchar(30) not null,
kontakt varchar(50),
dob int
);

create table Djeca(
dijeteID int not null primary key identity(1,1),
ime varchar(30) not null,
prezime varchar(30) not null,
datumRodenja datetime,
kontaktRoditelja varchar(50) not null
);

create table Skupine(
skupinaID int not null primary key identity(1,1),
tetaID int not null,
naziv varchar(30) not null,
brojDjece int
);

create table Clanovi(
dijeteID int not null,
skupinaID int not null,
datumPristupanja datetime
);

alter table Skupine add foreign key (tetaID) references Teta(tetaID);
alter table Clanovi add foreign key (dijeteID) references Djeca(dijeteID);
alter table Clanovi add foreign key (skupinaID) references Skupine(skupinaID);


create table Citatelji(
citateljID int not null primary key identity(1,1),
ime varchar(30) not null,
prezime varchar(30) not null,
kontakt varchar(50),
oib char(11)
);

create table Knjige(
knjigaID int not null primary key identity(1,1),
naziv varchar(50) not null,
autor varchar(50),
vlasnik int not null
);

create table Posudba(
citateljID int not null,
knjigaID int not null,
pocetakPosudbe datetime not null,
krajPosudbe datetime
);

alter table Knjige add foreign key (vlasnik) references Citatelji(citateljID);
alter table Posudba add foreign key (citateljID) references Citatelji(citateljID);
alter table Posudba add foreign key (knjigaID) references Knjige(knjigaID);


create table osobe(
sifra int not null primary key identity(1,1),
ime varchar(50),
prezime varchar(50),
adresa varchar(50),
email varchar(50)
);

create table clan(
sifra int not null primary key identity(1,1),
clbroj int not null
);

create table vlasnik(
sifra int not null primary key identity(1,1),
knjiga int
);

create table knjiga(
sifra int not null primary key identity(1,1),
naslov varchar(50) not null,
pisac varchar(50) not null,
vlasnik int not null,
clan int not null,
datumpos datetime,
datumvrac datetime
);

alter table knjiga add foreign key (vlasnik) references vlasnik(sifra);
alter table knjiga add foreign key (clan) references clan(sifra);