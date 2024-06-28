create database fakultetMySQL;
use fakultetMySQL;

create table Smjerovi(
smjerID int not null,
naziv varchar(100) not null,
brojStudenata int,
primary key (smjerID)
);

create table Kolegiji(
kolegijID int not null,
smjerID int not null,
naziv varchar(100) not null,
predavac varchar(50),
obavezni bit,
primary key (kolegijID)
);

create table Studenti(
studentID int not null,
smjerID int not null,
ime varchar(30) not null,
prezime varchar(30) not null,
oib char(11),
primary key (studentID)
);

create table IspitniRok(
ispitniRokID int not null,
kolegijID int not null,
vrstaIspita varchar(50) not null,
datum datetime not null,
primary key (ispitniRokID)
);

create table Prijava(
studentID int not null,
ispitniRokID int not null,
pristupio bit
);

alter table Kolegiji add foreign key (smjerID) references Smjerovi(smjerID);
alter table Studenti add foreign key (smjerID) references Smjerovi(smjerID);
alter table IspitniRok add foreign key (kolegijID) references Kolegiji(kolegijID);
alter table Prijava add foreign key (studentID) references Studenti(studentID);
alter table Prijava add foreign key (ispitniRokID) references IspitniRok(ispitniRokID);


insert into Smjerovi (smjerID,naziv,brojStudenata) values
(1,'Anglistika',50),
(2,'Germanistika',40),
(3,'Talijanistika',40),
(4,'Kroatistika',50);

insert into Kolegiji (kolegijID,smjerID,naziv,predavac,obavezni) values
(1,1,'Uvod u englesku književnost',null,1),
(2,1,'Suvremeni engleski jezik',null,1),
(3,2,'Jeziène vježbe 1',null,1),
(4,2,'Povijest njemaèkog jezika',null,0),
(5,3,'Jeziène vježbe 1',null,1),
(6,4,'Staroslavenski jezik',null,1),
(7,4,'Teorija jezika',null,1);

insert into Studenti (studentID,smjerID,ime,prezime,oib) values
(1,4,'Ivan','Iviæ','47457409385'),
(2,4,'Hajdi','Hajdiæ','15797970162'),
(3,1,'Goran','Grkiæ','20437329240'),
(4,1,'Marko','Markiæ','22353796851'),
(5,2,'Ivan','Ivièeviæ','24088017749');

insert into IspitniRok (ispitniRokID,kolegijID,vrstaIspita,datum) values
(1,6,'pismeni','2024-06-10 12:00'),
(2,7,'usmeni','2024-06-14 10:00'),
(3,1,'pismeni','2024-06-10 9:00'),
(4,2,'pismeni','2024-06-12 10:30'),
(5,3,'pismeni','2024-06-17 14:00'),
(6,5,'pismeni','2024-06-18 16:00');

insert into Prijava (studentID,ispitniRokID,pristupio) values
(2,1,1),(2,2,1),(1,1,1),(1,2,0),(3,3,1),(3,4,0),(4,3,1),(4,4,1),(5,5,null);

