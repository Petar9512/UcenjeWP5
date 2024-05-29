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
datum datetime,
pristupio bit not null
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
datumrodenja datetime not null,
placa decimal(18,2),
odjel int not null
);

create table projekt(
sifra int not null primary key identity(1,1),
naziv varchar(45) not null,
datumpocetka datetime,
datumkraja datetime
);

create table sudjeluje(
zaposlenik int not null,
projekt int not null,
datumpristupanja datetime
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