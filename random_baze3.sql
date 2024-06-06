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

insert into Korisnici (ime,prezime,kontakt) values
('Ivan','Iviæ','0987775556'),
('Goran','Grgiæ','0957778887'),
('Hajdi','Hajdiæ','0913332224'),
('Ivan','Ivièeviæ','0914443335');

insert into Obuca (korisnikID,vrsta,broj,opisKvara) values
(4,'jedan par cipela','42','probušeno dno'),
(4,'jedan par sandala','42',null),
(3,'desna èizma','30',null),
(2,'jedan par cipela','43',null),
(2,'jedan par papuèa','43',null);

insert into Popravci (korisnikID,kolicinaObuce) values
(4,'jedan par cipela i jedan par sandala'),
(2,'jedan par cipela i jedan par papuèa'),
(3,'desna èizma');

insert into PopravakObuce (popravakID,obucaID,vrijemePopravka,opisPopravka,cijena,segrt) values
(1,2,'2024-06-01 10:00','popravio desnu sandalu',5.50,0),
(1,2,'2024-06-01 17:25','popravio lijevu sandalu',5.50,0),
(2,5,'2024-06-03 9:00','popravio papuèe',10.00,1),
(2,4,'2024-06-04 10:20','popravio cipele',12.00,1);



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
('Ivan','Ivièeviæ',33,'prehlada'),
('Goran','Grkiæ',43,'upala grla'),
('Marko','Markiæ',38,'gastritis'),
('Ivan','Ivièeviæ',33,'gastritis');

insert into Lijecenje (pacijentID,opisTretmana,lijekovi,pocetakLijecenja,krajLijecenja,medicinskeSestre) values
(1,'sirup za kašalj',null,'2024-03-01','2024-03-08',null),
(2,'sirup za kašalj',null,'2024-03-20','2024-03-25',null),
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
('Marko','Markiæ',null,null,'Germanistika'),
('Hajdi','Hajdiæ',null,null,'Kroatistika'),
('Ivan','Iviæ',null,null,'Talijanistika');

insert into IspitniRokovi (kolegij,vrstaIspita,vrijeme) values
('Jeziène vježbe 1','pismeni','2024-07-07 10:00'),
('Uvod u lingvistiku','pismeni','2024-06-28 13:00'),
('Staroslavenski jezik','pismeni','2024-06-30 12:00'),
('Fonetika','usmeni','2024-07-02 10:00'),
('Jeziène vježbe 2','pismeni','2024-07-07 14:00');

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
datumRodenja date,
kontakt varchar(30)
);

create table Djeca(
dijeteID int not null primary key identity(1,1),
ime varchar(30) not null,
prezime varchar(30) not null,
datumRodenja date,
razred varchar(10)
);

create table Sudionici(
dijeteID int not null,
radionicaID int not null,
datumPristupanja date
);

alter table Radionice add foreign key (uciteljicaID) references Uciteljice(uciteljicaID);
alter table Sudionici add foreign key (dijeteID) references Djeca(dijeteID);
alter table Sudionici add foreign key (radionicaID) references Radionice(radionicaID);

insert into Uciteljice (ime,prezime,datumRodenja,kontakt) values
('Sonja','Sonjiæ','1980-06-10','0915558887'),
('Hajdi','Hajdiæ','1988-03-07','0912225556'),
('Ivana','Iviæ','1968-10-27','0984445553');

insert into Radionice (naziv,vrijemePocetka,brojDjece,uciteljicaID) values
('Izrada božiænih ukrasa','2024-12-05 14:00',20,2),
('Vrtna radionica','2024-05-10 9:00',10,3),
('Informatièka radionica','2024-04-22 10:00',15,2);

insert into Djeca (ime,prezime,datumRodenja,razred) values
('Ivan','Ivièeviæ',null,'3.A'),
('Pero','Periæ',null,'3.B'),
('Goran','Grkiæ',null,'3.A'),
('Marko','Markiæ',null,'4.A'),
('Ivan','Iviæ',null,'4.C');

insert into Sudionici (dijeteID,radionicaID,datumPristupanja) values
(1,3,'2024-04-24'),(1,2,'2024-05-10'),(3,3,'2024-04-22'),(2,1,'2024-12-08'),(4,1,'2024-12-06');

