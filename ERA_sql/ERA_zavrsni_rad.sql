use master;
go
drop database if exists fakultet;
go
create database fakultet;
go
use fakultet;

create table Smjerovi(
sifra int not null primary key identity(1,1),
naziv varchar(100) not null,
brojStudenata int
);

create table Kolegiji(
sifra int not null primary key identity(1,1),
smjerID int not null,
naziv varchar(100) not null,
predavac varchar(50),
obavezni bit
);

create table Studenti(
sifra int not null primary key identity(1,1),
smjerID int not null,
ime varchar(30) not null,
prezime varchar(30) not null,
oib char(11)
);

create table IspitniRok(
sifra int not null primary key identity(1,1),
kolegijID int not null,
vrstaIspita varchar(50) not null,
datum datetime not null
);

create table Prijava(
sifra int not null primary key identity(1,1),
studentID int not null,
ispitniRokID int not null,
pristupio bit
);


alter table Kolegiji add foreign key (smjerID) references Smjerovi(sifra);
alter table Studenti add foreign key (smjerID) references Smjerovi(sifra);
alter table IspitniRok add foreign key (kolegijID) references Kolegiji(sifra);
alter table Prijava add foreign key(studentID) references Studenti(sifra);
alter table Prijava add foreign key(ispitniRokID) references IspitniRok(sifra);


insert into Smjerovi (naziv,brojStudenata) values
('Anglistika',50),
('Germanistika',40),
('Talijanistika',40),
('Kroatistika',50);

insert into Kolegiji (smjerID,naziv,predavac,obavezni) values
(1,'Uvod u englesku književnost',null,1),
(1,'Suvremeni engleski jezik',null,1),
(2,'Jezične vježbe 1',null,1),
(2,'Povijest njemačkog jezika',null,0),
(3,'Jezične vježbe 1',null,1),
(4,'Staroslavenski jezik',null,1),
(4,'Teorija jezika',null,1);

insert into Studenti (smjerID,ime,prezime,oib) values
(4,'Ivan','Ivić','47457409385'),
(4,'Hajdi','Hajdić','15797970162'),
(1,'Goran','Grkić','20437329240'),
(1,'Marko','Markić','22353796851'),
(2,'Ivan','Ivičević','24088017749');

insert into ispitniRok (kolegijID,vrstaIspita,datum) values
(6,'pismeni','2024-06-10 12:00'),
(7,'usmeni','2024-06-14 10:00'),
(1,'pismeni','2024-06-10 9:00'),
(2,'pismeni','2024-06-12 10:30'),
(3,'pismeni','2024-06-17 14:00'),
(5,'pismeni','2024-06-18 16:00');

insert into Prijava (studentID,ispitniRokID,pristupio) values
(2,1,1),(2,2,1),(1,1,1),(1,2,0),(3,3,1),(3,4,0),(4,3,1),(4,4,1),(5,5,null);

--select prezime from Studenti where oib like '%1%';

--select kolegijID, naziv from Kolegiji where Kolegiji.kolegijID not in (select kolegijID from IspitniRok);

--select Kolegiji.kolegijID, Kolegiji.naziv
--from Kolegiji left join IspitniRok on Kolegiji.kolegijID=IspitniRok.kolegijID
--where IspitniRok.kolegijID is null;

--select Studenti.ime, Studenti.prezime, Smjerovi.naziv as smjer
--from Studenti inner join Smjerovi 
--on Studenti.smjerID = Smjerovi.smjerID;

--select Smjerovi.naziv as Smjer, count(Studenti.studentID) as BrojStudenata
--from Studenti inner join Smjerovi
--on Studenti.smjerID = Smjerovi.smjerID
--group by Smjerovi.naziv
--order by count(Studenti.studentID) desc;

--select Studenti.ime, Studenti.prezime, Kolegiji.naziv as kolegij, Smjerovi.naziv as smjer, IspitniRok.vrstaIspita, IspitniRok.datum as vrijeme
--from IspitniRok inner join Kolegiji 
--on IspitniRok.kolegijID = Kolegiji.kolegijID inner join Smjerovi
--on Kolegiji.smjerID = Smjerovi.smjerID inner join Studenti 
--on Studenti.smjerID = Smjerovi.smjerID;

--select Kolegiji.naziv as kolegij, Smjerovi.naziv as smjer, IspitniRok.vrstaIspita, IspitniRok.datum as vrijeme
--from Kolegiji inner join Smjerovi
--on Kolegiji.smjerID = Smjerovi.smjerID left join IspitniRok
--on Kolegiji.kolegijID = IspitniRok.kolegijID;

--select Kolegiji.naziv as kolegij, Smjerovi.naziv as smjer
--from Kolegiji inner join Smjerovi
--on Kolegiji.smjerID = Smjerovi.smjerID;