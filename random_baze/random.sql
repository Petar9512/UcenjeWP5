use master;
go
drop database if exists random;
go
create database random;
go
use random;

create table IspitniRok(
sifra int not null primary key identity(1,1),
predmet varchar(50) not null,
vrstaIspita varchar(50) not null,
datum datetime
);

create table Pristupnici(
ispitniRok int not null,
student varchar(50) not null,
brojBodova int not null,
ocjena int not null
);

create table odjel(
sifra int not null primary key identity(1,1),
naziv varchar(45) not null
);

create table zaposlenik(
sifra int not null primary key identity(1,1),
nadredeni int,
ime varchar(45) not null,
prezime varchar(45) not null,
datumrodenja date not null,
placa decimal(18,2),
odjel int not null
);

create table projekt(
sifra int not null primary key identity(1,1),
naziv varchar(45) not null,
datumpocetka date,
datumkraja date
);

create table sudjeluje(
zaposlenik int not null,
projekt int not null,
datumpristupanja date
);

create table Racun(
sifra int not null primary key identity(1,1),
redniBroj int not null,
datum datetime,
kupac varchar(50) not null,
placeno bit not null
);

create table StavkeRacuna(
racun int not null,
artikl varchar(50) not null,
cijena decimal(18,2) not null,
kolicina varchar(20) not null,
popust varchar(20)
);

create table radnik(
sifra int not null primary key identity(1,1),
Ime nvarchar(50) not null,
Prezime nvarchar(50) not null,
nadredeni int
);


alter table Pristupnici add foreign key (ispitniRok) references IspitniRok(sifra);

alter table zaposlenik add foreign key (odjel) references odjel(sifra);
alter table zaposlenik add foreign key (nadredeni) references zaposlenik(sifra);
alter table sudjeluje add foreign key (zaposlenik) references zaposlenik(sifra);
alter table sudjeluje add foreign key (projekt) references projekt(sifra);

alter table StavkeRacuna add foreign key (racun) references Racun(sifra);

alter table radnik add foreign key (nadredeni) references radnik(sifra);


insert into IspitniRok (predmet,vrstaIspita,datum) values
('matematika','pismeni','2024-03-01 10:00'),
('fizika','pismeni','2024-03-03 12:00'),
('kemija','pismeni','2024-03-07 10:00'),
('biologija','pismeni','2024-03-09 9:00'),
('logika','pismeni','2024-03-11 9:00');

insert into Pristupnici (ispitniRok,student,brojBodova,ocjena) values
(1,'Ivan Iviæ',46,5),
(3,'Hajdi Hajdiæ',42,4),
(4,'Pero Periæ',20,3),
(2,'Ivan Ivièeviæ',33,3),
(5,'Goran Grgiæ', 16,2);



insert into odjel (naziv) values
('Kemija'),
('Fizika'),
('Matematika'),
('Logika'),
('Biologija');

insert into zaposlenik (nadredeni,ime,prezime,datumrodenja,placa,odjel) values
(3,'Pero','Periæ','1980-02-03',null,1),
(null,'Hajdi','Hajdiæ','1984-03-17',750.75,5),
(null,'Ivan','Ivièeviæ','1977-11-05',null,1),
(2,'Goran','Grgiæ','1988-01-10',650.25,5),
(3,'Ivan','Iviæ','1987-07-05',680.89,1);

insert into projekt (naziv,datumpocetka,datumkraja) values
('Predavanja u OŠ','2024-04-16','2024-04-23'),
('Seminari fakultet','2024-03-27','2024-04-10'),
('Istraživanje kakvoæe mora','2024-06-05','2024-06-10'),
('Ljetni kamp','2024-07-16','2024-07-30'),
('Mikroskopska analiza','2024-05-10','2024-05-11');

insert into sudjeluje (zaposlenik,projekt,datumpristupanja) values
(2,1,null), (4,1,null), (1,2,null), (3,2,null), (2,3,null), (4,3,null), (3,4,null), (5,4,'2024-07-23'), (2,5,'2024-05-10');



insert into Racun (redniBroj,datum,kupac,placeno) values
(1,'2024-06-01 08:02','Ivan Iviæ',1),
(2,'2024-06-01 08:33','Hajdi Hajdiæ',1),
(3,'2024-06-01 08:42','Pero Periæ',1),
(4,'2024-06-01 09:07','Goran Grgiæ',1),
(5,'2024-06-01 09:32','Ivan Ivièeviæ',1);

insert into StavkeRacuna (racun,artikl,cijena,kolicina,popust) values
(2,'Banane',2.25,'7',null),
(2,'Naranèe',1.32,'5',null),
(1,'Èokolada Dorina',3.98,'2',null),
(1,'Èips Pringles',3.25,'1',null),
(1,'Jabuke',1.77,'5', null);



insert into radnik (Ime,Prezime,nadredeni) values
('Hajdi','Hajdiæ', null),
('Ivan','Ivièeviæ',null),
('Pero','Periæ',2),
('Ivan','Iviæ',2),
('Goran','Grgiæ',1);

