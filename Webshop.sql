use master;
go
drop database if exists Webshop;
go
create database Webshop;
go
use Webshop;

create table Kupci (
sifra int not null primary key identity(1,1),
ime varchar(30) not null,
prezime varchar(30) not null,
ulica varchar(50),
mjesto varchar(50)
);

create table Proizvodi (
sifra int not null primary key identity(1,1),
naziv varchar(100) not null,
datumNabave date,
cijena decimal(10,2) not null,
aktivan bit not null
);

create table Racuni (
sifra int not null primary key identity(1,1),
datum datetime not null,
kupac int not null,
status varchar(30)
);

create table Stavke (
racun int not null,
proizvod int not null,
kolicina int not null,
cijena decimal(10,2) not null
);

alter table Racuni add foreign key (kupac) references Kupci(sifra);
alter table Stavke add foreign key (racun) references Racuni(sifra);
alter table Stavke add foreign key (proizvod) references Proizvodi(sifra);