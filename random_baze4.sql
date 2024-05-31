use master;
go
drop database if exists random_baze4;
go
create database random_baze4;
go
use random_baze4;

create table Razredi(
razredID int not null primary key identity(1,1),
naziv varchar(10) not null,
brojUcenika int
);

create table Ucenici(
ucenikID int not null primary key identity(1,1),
razredID int not null,
ime varchar(30) not null,
prezime varchar(30) not null,
oib char(11)
);

create table Profesori(
profesorID int not null primary key identity(1,1),
ime varchar(30) not null,
prezime varchar(30) not null,
);

create table Predavaci(
profesorID int not null,
razredID int not null
);

alter table Ucenici add foreign key (razredID) references Razredi(razredID);
alter table Predavaci add foreign key (profesorID) references Profesori(profesorID);
alter table Predavaci add foreign key (razredID) references Razredi(razredID);


create table Trgovine(
trgovinaID int not null primary key identity(1,1),
naziv varchar(50) not null,
brojZaposlenika int,
opisDjelatnosti varchar(100),
sef int not null
);

create table Osoblje(
osobaID int not null primary key identity(1,1),
ime varchar(30) not null,
prezime varchar(30) not null,
datumRodenja datetime,
kontakt varchar(50)
);

create table Zaposlenici(
osobaID int not null,
trgovinaID int not null,
pocetakRV datetime,
krajRV datetime
);

alter table Trgovine add foreign key (sef) references Osoblje(osobaID);
alter table Zaposlenici add foreign key (osobaID) references Osoblje(osobaID);
alter table Zaposlenici add foreign key (trgovinaID) references Trgovine(trgovinaID);


create table Kategorije(
kategorijaID int not null primary key identity(1,1),
naziv varchar(50) not null,
opis varchar(100)
);

create table Jelo(
jeloID int not null primary key identity(1,1),
kategorijaID int not null,
naziv varchar(50) not null,
sastojci varchar(100) not null,
cijena decimal(10,2) not null
);

create table Pice(
piceID int not null primary key identity(1,1),
naziv varchar(50) not null,
sastojci varchar(100) not null,
cijena decimal(10,2) not null
);

create table Prilozi(
jeloID int not null,
piceID int not null
);

alter table Jelo add foreign key (kategorijaID) references Kategorije(kategorijaID);
alter table Prilozi add foreign key (jeloID) references Jelo(jeloID);
alter table Prilozi add foreign key (piceID) references Pice(piceID);


create table Djelatnici(
djelatnikID int not null primary key identity(1,1),
ime varchar(30) not null,
prezime varchar(30) not null,
oib char(11)
);

create table Proizvodi(
proizvodID int not null primary key identity(1,1),
djelatnikID int not null,
naziv varchar(50) not null,
opis varchar(100)
);

create table Sirovine(
sirovinaID int not null primary key identity(1,1),
naziv varchar(50) not null,
vrsta varchar(50),
kolicina varchar(30)
);

create table ProizvodiOdSirovina(
proizvodID int not null,
sirovinaID int not null
);

alter table Proizvodi add foreign key (djelatnikID) references Djelatnici(djelatnikID);
alter table ProizvodiOdSirovina add foreign key (proizvodID) references Proizvodi(proizvodID);
alter table ProizvodiOdSirovina add foreign key (sirovinaID) references Sirovine(sirovinaID);