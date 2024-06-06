use master;
go
drop database if exists random_baze3;
go
create database random_baze3;
go
use random_baze3;

create table Korisnici(
korisnikID int not null primary key identity(1,1),
ime varchar(30) not null,
prezime varchar(30) not null,
kontakt varchar(30) not null
);

create table Obuca(
obucaID int not null primary key identity(1,1),
korisnikID int not null,
vrsta varchar(30) not null,
broj varchar(10) not null,
opisKvara varchar(100)
);

create table Popravci(
popravakID int not null primary key identity(1,1),
korisnikID int not null,
kolicinaObuce varchar(50) not null
);

create table PopravakObuce(
popravakID int not null,
obucaID int not null,
vrijemePopravka datetime not null,
opisPopravka varchar(200) not null,
cijena decimal(10,2) not null,
segrt bit
);

alter table Obuca add foreign key (korisnikID) references Korisnici(korisnikID);
alter table Popravci add foreign key (korisnikID) references Korisnici(korisnikID);
alter table PopravakObuce add foreign key (popravakID) references Popravci(popravakID);
alter table PopravakObuce add foreign key (obucaID) references Obuca(obucaID);


create table Pacijenti(
pacijentID int not null primary key identity(1,1),
ime varchar(30) not null,
prezime varchar(30) not null,
dob int not null,
opisBolesti varchar(300) not null
);

create table Lijecenje(
pacijentID int not null,
opisTretmana varchar(300) not null,
lijekovi varchar(100),
pocetakLijecenja date not null,
krajLijecenja date not null,
medicinskeSestre varchar(100)
);

alter table Lijecenje add foreign key (pacijentID) references Pacijenti(pacijentID);

insert into Pacijenti (ime,prezime,dob,opisBolesti) values
('Ivan','Ivi�evi�',33,'prehlada'),
('Goran','Grki�',43,'upala grla'),
('Marko','Marki�',38,'gastritis'),
('Ivan','Ivi�evi�',33,'gastritis');

insert into Lijecenje (pacijentID,opisTretmana,lijekovi,pocetakLijecenja,krajLijecenja,medicinskeSestre) values
(1,'sirup za ka�alj',null,'2024-03-01','2024-03-08',null),
(2,'sirup za ka�alj',null,'2024-03-20','2024-03-25',null),
(3,'antibiotik',null,'2024-04-10','2024-04-15',null),
(4,'antibiotik',null,'2024-05-22','2024-05-29',null);



create table Studenti(
studentID int not null primary key identity(1,1),
ime varchar(30) not null,
prezime varchar(30) not null,
oib char(11),
datumRodenja date,
smjer varchar(50)
);

create table IspitniRokovi(
ispitniRokID int not null primary key identity(1,1),
kolegij varchar(50) not null,
vrstaIspita varchar(30) not null,
vrijeme datetime not null
);

create table Prijava(
studentID int not null,
ispitniRokID int not null,
pristupio bit
);

alter table Prijava add foreign key (studentID) references Studenti(studentID);
alter table Prijava add foreign key (ispitniRokID) references IspitniRokovi(ispitniRokID);

insert into Studenti (ime,prezime,oib,datumRodenja,smjer) values
('Marko','Marki�',null,null,'Germanistika'),
('Hajdi','Hajdi�',null,null,'Kroatistika'),
('Ivan','Ivi�',null,null,'Talijanistika');

insert into IspitniRokovi (kolegij,vrstaIspita,vrijeme) values
('Jezi�ne vje�be 1','pismeni','2024-07-07 10:00'),
('Uvod u lingvistiku','pismeni','2024-06-28 13:00'),
('Staroslavenski jezik','pismeni','2024-06-30 12:00'),
('Fonetika','usmeni','2024-07-02 10:00'),
('Jezi�ne vje�be 2','pismeni','2024-07-07 14:00');

insert into Prijava (studentID,ispitniRokID,pristupio) values
(2,3,1),(2,1,1),(1,2,0),(3,5,1);



create table Radionice(
radionicaID int not null primary key identity(1,1),
naziv varchar(50) not null,
vrijemePocetka datetime not null,
brojDjece int,
uciteljicaID int not null
);

create table Uciteljice(
uciteljicaID int not null primary key identity(1,1),
ime varchar(30) not null,
prezime varchar(30) not null,
datumRodenja datetime,
kontakt varchar(30)
);

create table Djeca(
dijeteID int not null primary key identity(1,1),
ime varchar(30) not null,
prezime varchar(30) not null,
datumRodenja datetime,
razred varchar(10)
);

create table Sudionici(
dijeteID int not null,
radionicaID int not null,
datumPristupanja datetime
);

alter table Radionice add foreign key (uciteljicaID) references Uciteljice(uciteljicaID);
alter table Sudionici add foreign key (dijeteID) references Djeca(dijeteID);
alter table Sudionici add foreign key (radionicaID) references Radionice(radionicaID);