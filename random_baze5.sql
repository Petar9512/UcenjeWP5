use master;
go
drop database if exists random_baze5;
go
create database random_baze5;
go
use random_baze5;

create table Kvarovi(
kvarID int not null primary key identity(1,1),
naziv varchar(30),
opisKvara varchar(100) not null,
tipInstalacije varchar(50) not null
);

create table Popravci(
popravakID int not null primary key identity(1,1),
vrijeme datetime not null,
brojPopravljenihKvarova int not null
);

create table PopravakKvara(
popravakID int not null,
kvarID int not null,
opisPopravka varchar(100),
cijena decimal(10,2) not null,
segrt bit
);

alter table PopravakKvara add foreign key (popravakID) references Popravci(popravakID);
alter table PopravakKvara add foreign key (kvarID) references Kvarovi(kvarID);

insert into Kvarovi ( naziv,opisKvara,tipInstalacije) values
(null,'probušena cijev','klasièna vodovodna cijev'),
(null,'pokvaren ventil','ventil'),
(null,'pokvaren brojaè','vodovodni brojaè');

insert into Popravci (vrijeme,brojPopravljenihKvarova) values
('2024-06-02 10:00',2),
('2024-06-04 11:00',1);

insert into PopravakKvara (popravakID,kvarID,opisPopravka,cijena,segrt) values
(1,2,'popravio ventil',7.99,0),
(1,3,'popravio brojaè',6.99,0),
(2,1,'popravio cijev',5.99,1);



create table Klijenti(
klijentID int not null primary key identity(1,1),
ime varchar(30) not null,
prezime varchar(30) not null,
kontakt varchar(50) not null,
);

create table Suradnici(
suradnikID int not null primary key identity(1,1),
ime varchar(30) not null,
prezime varchar(30) not null,
kontakt varchar(50) not null
);

create table Obrane(
obranaID int not null primary key identity(1,1),
klijentID int not null,
nazivSlucaja varchar(50) not null,
nazivSuda varchar(50)
);

create table SuradniciUObranama(
obranaID int not null,
suradnikID int not null
);

alter table Obrane add foreign key (klijentID) references Klijenti(klijentID);
alter table SuradniciUObranama add foreign key (obranaID) references Obrane(obranaID);
alter table SuradniciUObranama add foreign key (suradnikID) references Suradnici(suradnikID);

insert into Klijenti (ime,prezime,kontakt) values
('Goran','Grkiæ','0987774445'),
('Hajdi','Hajdiæ','0912225553'),
('Ivan','Iviæ','0985554447');

insert into Suradnici (ime,prezime,kontakt) values
('Sonja','Sonjiæ','0912225553'),
('Ivan','Iviæeviæ','0987773334'),
('Marko','Markiæ','0914445553');

insert into Obrane (klijentID,nazivSlucaja,nazivSuda) values
(1,'Prometni prekršaj 1','Županijski sud Dubrovnik'),
(1,'Prometni prekršaj 2','Županijski sud Dubrovnik'),
(3,'Vožnja u alkoholiziranom stanju',null),
(2,'Porezni postupak',null);

insert into SuradniciUObranama (obranaID,suradnikID) values
(1,1),(1,3),(2,3),(3,1),(4,2);



create table Nakladnici(
nakladnikID int not null primary key identity(1,1),
mjestoID int not null,
naziv varchar(50) not null,
adresa varchar(50),
kontakt varchar(50)
);

create table Mjesto(
mjestoID int not null primary key identity(1,1),
ime varchar(30) not null,
broj varchar(10),
drzava varchar(20)
);

create table Djela(
djeloID int not null primary key identity(1,1),
naziv varchar(50) not null,
autor varchar(50) not null,
zanr varchar(20)
);

create table Izdanje(
nakladnikID int not null,
djeloID int not null,
godinaIzdanja date not null
);

alter table Nakladnici add foreign key (mjestoID) references Mjesto(mjestoID);
alter table Izdanje add foreign key (nakladnikID) references Nakladnici(nakladnikID);
alter table Izdanje add foreign key (djeloID) references Djela(djeloID);

insert into Mjesto (ime,broj,drzava) values
('Dubrovnik','20000','Hrvatska'),
('Zagreb','10000','Hrvatska'),
('Zadar','23000','Hrvatska');

insert into Nakladnici (mjestoID,naziv,adresa,kontakt) values
(2,'Nakladnik Zagreb',null,null),
(3,'Nakladnik Zadar',null,null),
(1,'Nakladnik Dubrovnik',null,null);

insert into Djela (naziv,autor,zanr) values
('Prièe iz davnine','I. Brliæ Mažuraniæ','bajke'),
('20000 milja pod morem','Jules Verne','roman'),
('Povratak Filipa Latinovicza','M. Krleža','roman');

insert into Izdanje (nakladnikID,djeloID,godinaIzdanja) values
(1,1,'2002'),(1,3,'1998'),(2,1,'2000'),(3,2,'1990'),(3,3,'1999');



create table Clanovi(
clanID int not null primary key identity(1,1),
ime varchar(30) not null,
prezime varchar(30) not null,
oib char(11)
);

create table Nastupi(
nastupID int not null primary key identity(1,1),
mjestoID int not null,
naziv varchar(50) not null,
vrijeme datetime not null
);

create table Mjesta(
mjestoID int not null primary key identity(1,1),
ime varchar(30) not null,
broj varchar(10),
drzava varchar(20)
);

create table SudioniciNastupa(
nastupID int not null,
clanID int not null
);

alter table Nastupi add foreign key (mjestoID) references Mjesta(mjestoID);
alter table SudioniciNastupa add foreign key (clanID) references Clanovi(clanID);
alter table SudioniciNastupa add foreign key (nastupID) references Nastupi(nastupID);

insert into Mjesta (ime,broj,drzava) values
('Split','21000','Hrvatska'),
('Šibenik','22000','Hrvatska'),
('Pula','52100','Hrvatska');

insert into Clanovi (ime,prezime,oib) values
('Hajdi','Hajdiæ',null),
('Ivan','Ivièeviæ',null),
('Marko','Markiæ',null),
('Sonja','Sonjiæ',null),
('Goran','Grgiæ',null);

insert into Nastupi (mjestoID,naziv,vrijeme) values
(3,'Nastup plesne skupine','2024-06-10 18:00'),
(2,'Nastup plesne skupine 2','2024-06-12 18:00'),
(1,'Nastup plesne skupine 3','2024-06-14 18:00');

insert into SudioniciNastupa (nastupID,clanID) values
(1,1),(1,3),(1,4),(2,1),(2,3),(2,4),(2,5),(3,1),(3,2),(3,3),(3,4),(3,5);

