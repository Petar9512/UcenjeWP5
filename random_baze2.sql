use master;
go
drop database if exists randomvjezbe2;
go
create database randomvjezbe2;
go
use randomvjezbe2;

create table Djelatnici(
djelatnikID int not null primary key identity(1,1),
ime varchar(30) not null,
prezime varchar(30) not null,
brojTelefona varchar(30)
);

create table Korisnici(
korisnikID int not null primary key identity(1,1),
ime varchar(30) not null,
prezime varchar(30) not null,
spol varchar(10) not null,
tipKose varchar(50) not null
);

create table Usluge(
uslugaID int not null primary key identity(1,1),
naziv varchar(50) not null,
opis varchar(100),
cijena decimal(10,2) not null
);

create table Posjet(
djelatnikID int not null,
korisnikID int not null,
uslugaID int not null,
vrijeme datetime
);

alter table Posjet add foreign key (djelatnikID) references Djelatnici(djelatnikID);
alter table Posjet add foreign key (korisnikID) references Korisnici(korisnikID);
alter table Posjet add foreign key (uslugaID) references Usluge(uslugaID);


create table Zaposlenici(
zaposlenikID int not null primary key identity(1,1),
ime varchar(30) not null,
prezime varchar(30) not null,
brojTelefona varchar(30),
email varchar(50)
);

create table Sticenici(
sticenikID int not null primary key identity(1,1),
zaposlenikID int not null,
prostorID int not null,
ime varchar(30),
vrsta varchar (50) not null,
prehrana varchar(50) not null
);

create table Prostori(
prostorID int not null primary key identity(1,1),
tip varchar(50) not null,
visina varchar(20),
duzina varchar(20),
sirina varchar(20)
);

alter table Sticenici add foreign key (zaposlenikID) references Zaposlenici(zaposlenikID);
alter table Sticenici add foreign key (prostorID) references Prostori(prostorID);


create table OdgojneSkupine(
odgojnaSkupinaID int not null primary key identity(1,1),
odgajateljicaID int not null,
naziv varchar(10) not null,
brojDjece int
);

create table Djeca(
ime varchar(30) not null,
prezime varchar(30) not null,
dob int not null,
kontaktRoditelja varchar(30) not null,
odgojnaSkupinaID int not null
);

create table Odgajateljice(
odgajateljicaID int not null primary key identity(1,1),
ime varchar(30) not null,
prezime varchar(30) not null,
brojTelefona varchar(30),
strucnaSpremaID int not null
);

create table StrucnaSprema(
strucnaSpremaID int not null primary key identity(1,1),
naziv varchar(50) not null,
opis varchar(50) not null
);

alter table OdgojneSkupine add foreign key (odgajateljicaID) references Odgajateljice(odgajateljicaID);
alter table Djeca add foreign key (odgojnaSkupinaID) references OdgojneSkupine(odgojnaSkupinaID);
alter table Odgajateljice add foreign key (strucnaSpremaID) references StrucnaSprema(strucnaSpremaID);


create table Izlozbe(
izlozbaID int not null primary key identity(1,1),
naziv varchar(50) not null,
brojDjela int,
vrijemePocetka datetime,
sponzorID int not null
);

create table Djela(
naziv varchar(50) not null,
autor varchar(50) not null,
stil varchar(30),
izlozbaID int not null
);

create table Kustosi(
ime varchar(30) not null,
prezime varchar(30) not null,
brojTelefona varchar(30),
izlozbaID int not null
);

create table Sponzori(
sponzorID int not null primary key identity(1,1),
naziv varchar(50) not null,
kontakt varchar(50),
donacija varchar(50)
);

alter table Djela add foreign key (izlozbaID) references Izlozbe(izlozbaID);
alter table Kustosi add foreign key (izlozbaID) references Izlozbe(izlozbaID);
alter table Izlozbe add foreign key (sponzorID) references Sponzori(sponzorID);


create table Svecenici(
svecenikID int not null primary key identity(1,1),
ime varchar(30) not null,
dob int,
nadredeni int
);

create table Poslovi(
posaoID int not null primary key identity(1,1),
opis varchar(100) not null,
vrijemePocetka datetime,
vrijemeZavrsetka datetime
);

create table Raspored(
svecenikID int not null,
posaoID int not null,
vrijeme datetime not null
);

alter table Svecenici add foreign key (nadredeni) references Svecenici(svecenikID);
alter table Raspored add foreign key (svecenikID) references Svecenici(svecenikID);
alter table Raspored add foreign key (posaoID) references Poslovi(posaoID);


create table Vozila(
voziloID int not null primary key identity(1,1),
naziv varchar(20) not null,
registracija varchar(20) not null,
vozacID int not null
);

create table Vozaci(
vozacID int not null primary key identity(1,1),
ime varchar(30) not null,
prezime varchar(30) not null,
kontakt varchar(50)
);

create table Putnici(
putnikID int not null primary key identity(1,1),
ime varchar(30) not null,
prezime varchar(30) not null,
cijenaVoznje decimal(10,2) not null
);

create table Voznja(
voznjaID int not null primary key identity(1,1),
voziloID int not null,
brojPutnika int,
vrijemePocetka datetime not null,
vrijemeZavrsetka datetime not null
);

create table VoznjaPutnika(
voznjaID int not null,
putnikID int not null
);

alter table Vozila add foreign key (vozacID) references Vozaci(vozacID);
alter table Voznja add foreign key (voziloID) references Vozila(voziloID);
alter table VoznjaPutnika add foreign key (voznjaID) references Voznja(voznjaID);
alter table VoznjaPutnika add foreign key (putnikID) references Putnici(putnikID);