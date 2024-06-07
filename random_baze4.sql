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

insert into Razredi (naziv,brojUcenika) values
('3.A',20),
('3.B',22),
('3.C',21);

insert into Ucenici (razredID,ime,prezime,oib) values
(3,'Pero','Periæ',null),
(3,'Hajdi','Hajdiæ',null),
(2,'Ivan','Iviæ',null),
(1,'Ivan','Ivièeviæ',null),
(2,'Goran','Grkiæ',null);

insert into Profesori (ime,prezime) values
('Sonja','Sonjiæ'),
('Ivana','Iviæ'),
('Petra','Periæ');

insert into Predavaci (profesorID,razredID) values
(1,3),(2,1),(3,2);



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
datumRodenja date,
kontakt varchar(50)
);

create table Zaposlenici(
osobaID int not null,
trgovinaID int not null,
pocetakRV time,
krajRV time
);

alter table Trgovine add foreign key (sef) references Osoblje(osobaID);
alter table Zaposlenici add foreign key (osobaID) references Osoblje(osobaID);
alter table Zaposlenici add foreign key (trgovinaID) references Trgovine(trgovinaID);

insert into Osoblje (ime,prezime,datumRodenja,kontakt) values
('Hajdi','Hajdiæ',null,'0985557774'),
('Ivan','Iviæ',null,'0913335554'),
('Goran','Grkiæ',null,'0985558884'),
('Marko','Markiæ',null,'0912225553');

insert into Trgovine (naziv,brojZaposlenika,opisDjelatnosti,sef) values
('Interspar',20,null,4),
('ZARA',10,null,1),
('Makromikro',5,null,2),
('Emmezeta',20,null,3);

insert into Zaposlenici (osobaID,trgovinaID,pocetakRV,krajRV) values
(1,2,'7:00','14:00'),
(2,3,'8:00','15:00'),
(3,4,'7:00','7:00'),
(4,1,'7:00','7:00');



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
sastojci varchar(100),
cijena decimal(10,2) not null
);

create table Prilozi(
jeloID int not null,
piceID int not null
);

alter table Jelo add foreign key (kategorijaID) references Kategorije(kategorijaID);
alter table Prilozi add foreign key (jeloID) references Jelo(jeloID);
alter table Prilozi add foreign key (piceID) references Pice(piceID);

insert into Kategorije (naziv,opis) values
('Jela s morskim plodovima',null),
('Tjestenine',null);

insert into Jelo (kategorijaID,naziv,sastojci,cijena) values
(1,'Hobotnica','hobotnica, krumpir, salata',18.99),
(1,'Riblja plata','6 vrsta ribe, krumpir, salata',43.99),
(2,'Spaghetti bolgnese','speghetti, umak',9.99);

insert into Pice (naziv,sastojci,cijena) values
('Coca Cola',null,1.99),
('Sok od naranèe',null,1.99),
('Vino',null,4.99);

insert into Prilozi (jeloID,piceID) values
(1,1),(1,3),(2,1),(2,2),(2,3),(3,2);



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

insert into Djelatnici (ime,prezime,oib) values
('Marko','Markiæ',null),
('Ivan','Iviæ',null),
('Goran','Grkiæ',null);

insert into Proizvodi (djelatnikID,naziv,opis) values
(2,'Stolica',null),
(2,'Stolna lampa',null),
(1,'Televizor',null);

insert into Sirovine (naziv,vrsta,kolicina) values
('Preraðeno drvo','Drvo',null),
('Preraðeno željezo','Željezo',null),
('Aluminij','Aluminij',null),
('Plastika','Plastika',null);

insert into ProizvodiOdSirovina (proizvodID,sirovinaID) values
(1,1),(1,3),(2,2),(2,3),(3,4),(3,3);

