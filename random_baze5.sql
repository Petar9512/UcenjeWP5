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
godinaIzdanja datetime not null
);

alter table Nakladnici add foreign key (mjestoID) references Mjesto(mjestoID);
alter table Izdanje add foreign key (nakladnikID) references Nakladnici(nakladnikID);
alter table Izdanje add foreign key (djeloID) references Djela(djeloID);


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
clanID int not null,
nastupID int not null
);

alter table Nastupi add foreign key (mjestoID) references Mjesta(mjestoID);
alter table SudioniciNastupa add foreign key (clanID) references Clanovi(clanID);
alter table SudioniciNastupa add foreign key (nastupID) references Nastupi(nastupID);