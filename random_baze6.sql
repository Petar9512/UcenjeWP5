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
skupinaID int not null,
dijeteID int not null,
datumPristupanja date
);

alter table Skupine add foreign key (tetaID) references Teta(tetaID);
alter table Clanovi add foreign key (dijeteID) references Djeca(dijeteID);
alter table Clanovi add foreign key (skupinaID) references Skupine(skupinaID);

insert into Teta (ime,prezime,kontakt,dob) values
('Sonja','Sonjiæ','0981112224',42),
('Ivana','Iviæ','0983335556',38);

insert into Djeca (ime,prezime,datumRodenja,kontaktRoditelja) values
('Ivan','Ivièeviæ',null,'0912224443'),
('Goran','Grkiæ',null,'0985557778'),
('Pero','Periæ',null,'0912227775'),
('Hajdi','Hajdiæ',null,'0914447776'),
('Marko','Markiæ',null,'0987772223');

insert into Skupine (tetaID,naziv,brojDjece) values
(1,'Skupina 1',17),
(1,'Skupina 2',16),
(2,'Skupina3',17);

insert into Clanovi (skupinaID,dijeteID,datumPristupanja) values
(1,2,'2024-04-10'),(1,4,'2024-04-10'),(1,5,'2024-04-12'),(2,1,'2024-04-18'),(2,3,'2024-04-19'),(2,5,'2024-04-21'),
(3,1,'2024-05-13'),(3,2,'2024-05-13'),(3,4,'2024-05-14');



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
pocetakPosudbe date not null,
krajPosudbe date
);

alter table Knjige add foreign key (vlasnik) references Citatelji(citateljID);
alter table Posudba add foreign key (citateljID) references Citatelji(citateljID);
alter table Posudba add foreign key (knjigaID) references Knjige(knjigaID);

insert into Citatelji (ime,prezime,kontakt,oib) values
('Ivan','Iviæ','0985557776',null),
('Hajdi','Hajdiæ','0912224443',null),
('Marko','Markiæ',null,null),
('Pero','Periæ','0912227778',null),
('Ivana','Iviæ',null,null);

insert into Knjige (naziv,autor,vlasnik) values
('20000 milja pod morem','Jules Verne',2),
('Hobit','J.R.R.Tolkien',3),
('Eragon','Christopher Paolini',5);

insert into Posudba (citateljID,knjigaID,pocetakPosudbe,krajPosudbe) values
(1,2,'2024-02-03','2024-02-17'),(5,2,'2024-03-12','2024-03-30'),
(4,1,'2024-03-01','2024-03-22'),(5,3,'2024-05-30',null);



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
datumpos date,
datumvrac date
);

alter table knjiga add foreign key (vlasnik) references vlasnik(sifra);
alter table knjiga add foreign key (clan) references clan(sifra);