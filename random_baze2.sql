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

insert into Djelatnici (ime,prezime,brojTelefona) values
('Hajdi','Hajdi�','0984447773'),
('Ivan','Ivi�',null),
('Goran','Grki�',null),
('Ivan','Ivi�evi�','0917777788'),
('Pero','Peri�',null);

insert into Korisnici (ime,prezime,spol,tipKose) values
('Sonja','Sonji�','�ena','duga�ka'),
('Marko','Marki�','mu�karac','kratka'),
('Ivana','Ivi�','�ena','valovita'),
('Petra','Peri�','�ena','kovr�ava'),
('Ivana','Ivi�evi�','�ena','duga�ka');

insert into Usluge (naziv,opis,cijena) values
('�i�anje',null,7.50),
('pranje kose i �i�anje',null,8.50),
('pranje kose, �i�anje i feniranje',null,9.50);

insert into Posjet (djelatnikID,korisnikID,uslugaID,vrijeme) values
(1,3,3,'2024-05-10 11:00'),
(4,2,1,'2024-05-10 11:33'),
(5,5,3,'2024-05-20 10:48'),
(4,1,1,null),
(1,3,3,'2024-07-16 9:55');



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

insert into Zaposlenici (ime,prezime,brojTelefona,email) values
('Pero','Peri�','0915555558','peroperic@gmail.com'),
('Ivan','Ivi�evi�',null,null),
('Goran','Grgi�','0987775559','gorangrgic@gmail.com'),
('Ivan','Ivi�',null,null),
('Hajdi','Hajdi�',null,null);

insert into Prostori (tip,visina,duzina,sirina) values
('kavez','1m','2m','50cm'),
('krletka','40cm','40cm','40cm'),
('terarij',null,null,null),
('akvarij',null,null,null);

insert into Sticenici (zaposlenikID,prostorID,ime,vrsta,prehrana) values
(4,4,'Nemo','riba','riblji kroketi'),
(2,3,null,'zmija','bilo�to'),
(5,2,'Nevis','papiga','sjemenke'),
(3,1,null,'majmun','vo�e');



create table OdgojneSkupine(
odgojnaSkupinaID int not null primary key identity(1,1),
odgajateljicaID int not null,
naziv varchar(30) not null,
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

insert into StrucnaSprema (naziv,opis) values
('U�iteljski fakultet','zavr�ila u�iteljski fakultet'),
('Odgojno-obrazovni te�aj','zavr�ila odgojno-obrazovni te�aj');

insert into Odgajateljice (ime,prezime,brojTelefona,strucnaSpremaID) values
('Hajdi','Hajdi�','0987775558',1),
('Sonja','Sonji�',null,1),
('Ivana','Ivi�',null,2);

insert into OdgojneSkupine (odgajateljicaID,naziv,brojDjece) values
(3,'odgojna skupina 1',null),
(2,'odgojna skupina 2',null),
(1,'odgojna skupina 3',null);

insert into Djeca (ime,prezime,dob,kontaktRoditelja,odgojnaSkupinaID) values
('Pero','Peri�',7,'0985557778',3),
('Ivan','Ivi�',8,'0912224443',3),
('Ivan','Ivi�evi�',7,'0983334445',3),
('Marko','Marki�',8,'0985554446',3);



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

insert into Sponzori (naziv,kontakt,donacija) values
('Microsoft',null,null),
('Facebook',null,null),
('Amazon',null,null);

insert into Izlozbe (naziv,brojDjela,vrijemePocetka,sponzorID) values
('Renesansna izlo�ba',7,'2024-08-01 10:00',2),
('Srednjovjekovna izlo�ba',5,'2024-08-08 12:00',3),
('Futuristi�ka izlo�ba',7,'2024-08-15 12:00',1);

insert into Kustosi (ime,prezime,brojTelefona,izlozbaID) values
('Ivan','Ivi�','0985557778',3),
('Ivan','Ivi�evi�','091555774',3),
('Hajdi','Hajdi�','0987774445',1);

insert into Djela (naziv,autor,stil,izlozbaID) values
('Mona Lisa','Leonardo da Vinci',null,1),
('Futurizam 2050','Pero Peri�',null,3),
('Srednji vijek 1000','Goran Grki�',null,2);



create table Svecenici(
svecenikID int not null primary key identity(1,1),
ime varchar(30) not null,
dob int,
nadredeni int
);

create table Poslovi(
posaoID int not null primary key identity(1,1),
opis varchar(100) not null,
vrijemePocetka time,
vrijemeZavrsetka time
);

create table Raspored(
svecenikID int not null,
posaoID int not null,
vrijeme datetime not null
);

alter table Svecenici add foreign key (nadredeni) references Svecenici(svecenikID);
alter table Raspored add foreign key (svecenikID) references Svecenici(svecenikID);
alter table Raspored add foreign key (posaoID) references Poslovi(posaoID);

insert into Svecenici (ime,dob,nadredeni) values
('Ivan',48,null),
('Petar',38,null),
('Matej',36,1),
('Marko',33,1);

insert into Poslovi (opis,vrijemePocetka,vrijemeZavrsetka) values
('Kuhanje svaki dan','08:00','12:00'),
('�i��enje svaki dan','18:00','20:00'),
('Vrtlarenje pon-pet','14:00','16:00');

insert into Raspored (svecenikID,posaoID,vrijeme) values
(2,1,'2024-06-01 09:30'),
(2,2,'2024-06-01 19:00'),
(1,1,'2024-06-02 08:30'),
(3,3,'2024-06-02 14:00'),
(4,2,'2024-06-02 18:00');



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

insert into Vozaci (ime,prezime,kontakt) values
('Pero','Peri�',null),
('Goran','Grgi�',null),
('Ivan','Ivi�',null),
('Ivan','Ivi�evi�',null);

insert into Vozila (naziv,registracija,vozacID) values
('Vozilo 1','AB777',4),
('Vozilo 2','SD888',3),
('Vozilo 3','AS555',2),
('Vozilo 4','FG222',1);

insert into Putnici (ime,prezime,cijenaVoznje) values
('Hajdi','Hajdi�',3.99),
('Marko','Marki�',4.99),
('Ivana','Ivi�',4.99),
('Petra','Peri�',4.49);

insert into Voznja (voziloID,brojPutnika,vrijemePocetka,vrijemeZavrsetka) values
(2,2,'2024-06-03 10:23','2024-06-03 10:50'),
(3,1,'2024-06-04 13:05','2024-06-04 13:20'),
(1,1,'2024-06-04 17:17','2024-06-04 17:37');

insert into voznjaPutnika (voznjaID,putnikID) values
(1,2),(1,3),(2,1),(3,4);

