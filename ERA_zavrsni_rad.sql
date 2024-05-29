use master;
go
drop database if exists fakultet;
go
create database fakultet;
go
use fakultet;

create table Smjerovi(
smjerID int not null primary key identity(1,1),
naziv varchar(100) not null,
brojStudenata int
);

create table Kolegiji(
kolegijID int not null primary key identity(1,1),
smjerID int not null,
naziv varchar(100) not null,
predavac varchar(50),
obavezni bit
);

create table Studenti(
studentID int not null primary key identity(1,1),
smjerID int not null,
ime varchar(30) not null,
prezime varchar(30) not null,
oib char(11)
);

create table IspitniRok(
ispitniRokID int not null primary key identity(1,1),
kolegijID int not null,
vrstaIspita varchar(50) not null,
datum datetime not null
);

create table Prijava(
studentID int not null,
ispitniRokID int not null,
pristupio bit
);


alter table Kolegiji add foreign key (smjerID) references Smjerovi(smjerID);
alter table Studenti add foreign key (smjerID) references Smjerovi(smjerID);
alter table IspitniRok add foreign key (kolegijID) references Kolegiji(kolegijID);
alter table Prijava add foreign key(studentID) references Studenti(studentID);
alter table Prijava add foreign key(ispitniRokID) references IspitniRok(ispitniRokID);