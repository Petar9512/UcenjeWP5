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
('Hajdi','Hajdiæ','0984447773'),
('Ivan','Iviæ',null),
('Goran','Grkiæ',null),
('Ivan','Ivièeviæ','0917777788'),
('Pero','Periæ',null);

insert into Korisnici (ime,prezime,spol,tipKose) values
('Sonja','Sonjiæ','žena','dugaèka'),
('Marko','Markiæ','muškarac','kratka'),
('Ivana','Iviæ','žena','valovita'),
('Petra','Periæ','žena','kovrèava'),
('Ivana','Ivièeviæ','žena','dugaèka');

insert into Usluge (naziv,opis,cijena) values
('šišanje',null,7.50),
('pranje kose i šišanje',null,8.50),
('pranje kose, šišanje i feniranje',null,9.50);

insert into Posjet (djelatnikID,korisnikID,uslugaID,vrijeme) values
(1,3,3,'2024-05-10 11:00'),
(4,2,1,'2024-05-10 11:33'),
(5,5,3,'2024-05-20 10:48'),
(4,1,1,null),
(1,3,3,'2024-07-16 9:55');

--delete from Posjet where djelatnikID=5 and korisnikID=5;
--delete from Djelatnici where djelatnikID=5;
--delete from Korisnici where korisnikID=5;

--update Korisnici set prezime='Ivièeviæ', tipKose ='dugaèka' where korisnikID=3;
--update Djelatnici set brojTelefona='0985558889' where djelatnikID=2;
--update Djelatnici set brojTelefona='0912225557' where djelatnikID=3;


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
('Pero','Periæ','0915555558','peroperic@gmail.com'),
('Ivan','Ivièeviæ',null,null),
('Goran','Grgiæ','0987775559','gorangrgic@gmail.com'),
('Ivan','Iviæ',null,null),
('Hajdi','Hajdiæ',null,null);

insert into Prostori (tip,visina,duzina,sirina) values
('kavez','1m','2m','50cm'),
('krletka','40cm','40cm','40cm'),
('terarij',null,null,null),
('akvarij',null,null,null);

insert into Sticenici (zaposlenikID,prostorID,ime,vrsta,prehrana) values
(4,4,'Nemo','riba','riblji kroketi'),
(2,3,null,'zmija','bilošto'),
(5,2,'Nevis','papiga','sjemenke'),
(3,1,null,'majmun','voæe');

--update Zaposlenici set brojTelefona='0975553334', email='ivanivicevic@gmail.com' where zaposlenikID=2;
--update Zaposlenici set brojTelefona='0974447778', email='hajdihajdic@gmail.com' where zaposlenikID=5;
--delete from Zaposlenici where zaposlenikID=4;

--update Sticenici set zaposlenikID=1 where sticenikID=1;
--delete from Sticenici where sticenikID=2;

--update Prostori set visina='0.7m', duzina='2.5m', sirina='2.5m' where prostorID=3;
--update Prostori set visina='0.5m', duzina='1m', sirina='0.6m' where prostorID=4;


create table OdgojneSkupine(
odgojnaSkupinaID int not null primary key identity(1,1),
odgajateljicaID int not null,
naziv varchar(30) not null,
brojDjece int
);

create table Djeca(
dijeteID int not null primary key identity(1,1),
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
('Uèiteljski fakultet','završila uèiteljski fakultet'),
('Odgojno-obrazovni teèaj','završila odgojno-obrazovni teèaj');

insert into Odgajateljice (ime,prezime,brojTelefona,strucnaSpremaID) values
('Hajdi','Hajdiæ','0987775558',1),
('Sonja','Sonjiæ',null,1),
('Ivana','Iviæ',null,2);

insert into OdgojneSkupine (odgajateljicaID,naziv,brojDjece) values
(3,'odgojna skupina 1',null),
(2,'odgojna skupina 2',null),
(1,'odgojna skupina 3',null);

insert into Djeca (ime,prezime,dob,kontaktRoditelja,odgojnaSkupinaID) values
('Pero','Periæ',7,'0985557778',3),
('Ivan','Iviæ',8,'0912224443',3),
('Ivan','Ivièeviæ',7,'0983334445',3),
('Marko','Markiæ',8,'0985554446',3);

--update Odgajateljice set brojTelefona='0957778882' where odgajateljicaID=2;
--update Odgajateljice set brojTelefona='0954445553' where odgajateljicaID=3;

--update OdgojneSkupine set brojDjece=20 where odgojnaSkupinaID=1;
--update OdgojneSkupine set brojDjece=15 where odgojnaSkupinaID=2;
--update OdgojneSkupine set brojDjece=15 where odgojnaSkupinaID=3;

--update Djeca set odgojnaSkupinaID=2 where dijeteID=2;
--update Djeca set odgojnaSkupinaID=2 where dijeteID=3;



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
('Renesansna izložba',7,'2024-08-01 10:00',2),
('Srednjovjekovna izložba',5,'2024-08-08 12:00',3),
('Futuristièka izložba',7,'2024-08-15 12:00',1);

insert into Kustosi (ime,prezime,brojTelefona,izlozbaID) values
('Ivan','Iviæ','0985557778',3),
('Ivan','Ivièeviæ','091555774',3),
('Hajdi','Hajdiæ','0987774445',1);

insert into Djela (naziv,autor,stil,izlozbaID) values
('Mona Lisa','Leonardo da Vinci',null,1),
('Futurizam 2050','Pero Periæ',null,3),
('Srednji vijek 1000','Goran Grkiæ',null,2);

--update Sponzori set kontakt='www.microsoft.com' where sponzorID=1;
--update Sponzori set kontakt='www.facebook.com' where sponzorID=2;
--update Sponzori set kontakt='www.amazon.com' where sponzorID=3;

--update Djela set stil='renesansa' where naziv='Mona Lisa';
--update Djela set stil='futurizam' where naziv='Futurizam 2050';
--update Djela set stil='gotika' where naziv='Srednji vijek 1000';



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
('Èišæenje svaki dan','18:00','20:00'),
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
('Pero','Periæ',null),
('Goran','Grgiæ',null),
('Ivan','Iviæ',null),
('Ivan','Ivièeviæ',null);

insert into Vozila (naziv,registracija,vozacID) values
('Vozilo 1','AB777',4),
('Vozilo 2','SD888',3),
('Vozilo 3','AS555',2),
('Vozilo 4','FG222',1);

insert into Putnici (ime,prezime,cijenaVoznje) values
('Hajdi','Hajdiæ',3.99),
('Marko','Markiæ',4.99),
('Ivana','Iviæ',4.99),
('Petra','Periæ',4.49);

insert into Voznja (voziloID,brojPutnika,vrijemePocetka,vrijemeZavrsetka) values
(2,2,'2024-06-03 10:23','2024-06-03 10:50'),
(3,1,'2024-06-04 13:05','2024-06-04 13:20'),
(1,1,'2024-06-04 17:17','2024-06-04 17:37');

insert into voznjaPutnika (voznjaID,putnikID) values
(1,2),(1,3),(2,1),(3,4);

--update Vozaci set kontakt='peroperic@gmail.com' where vozacID=1;
--update Vozaci set kontakt='gorangrgic@gmail.com' where vozacID=2;
--update Vozaci set kontakt='ivanivic@gmail.com' where vozacID=3;
--update Vozaci set kontakt='ivanivicevic@gmail.com' where vozacID=4;

