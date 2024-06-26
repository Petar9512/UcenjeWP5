create database fakultet;


create table Smjerovi(
	smjerID serial primary key,
	naziv varchar(100) not null,
	brojStudenata int
);

create table Kolegiji(
	kolegijID serial primary key,
	smjerID int not null,
	naziv varchar(100) not null,
	predavac varchar(50),
	obavezni bit
);

create table Studenti(
	studentID serial primary key,
	smjerID int not null,
	ime varchar(30) not null,
	prezime varchar(30) not null,
	oib char(11)
);

create table IspitniRok(
	ispitniRokID serial primary key,
	kolegijID int not null,
	vrstaIspita varchar(50) not null,
	datum date not null,
	vrijeme time not null
);

create table Prijava(
	studentID int not null,
	ispitniRokID int not null,
	pristupio bit
);

alter table Kolegiji add constraint fk_smjer foreign key (smjerID) references Smjerovi(smjerID);
alter table Studenti add constraint fk_smjer2 foreign key (smjerID) references Smjerovi(smjerID);
alter table IspitniRok add constraint fk_kolegij foreign key (kolegijID) references Kolegiji(kolegijID);
alter table Prijava add constraint fk_student foreign key (studentID) references Studenti(studentID);
alter table Prijava add constraint fk_ispitniRok foreign key (ispitniRokID) references IspitniRok(ispitniRokID);


insert into Smjerovi (naziv,brojStudenata) values
('Anglistika',50),
('Germanistika',40),
('Talijanistika',40),
('Kroatistika',50);

insert into Kolegiji (smjerID,naziv,predavac,obavezni) values
(1,'Uvod u englesku književnost',null,'1'),
(1,'Suvremeni engleski jezik',null,'1'),
(2,'Jezične vježbe 1',null,'1'),
(2,'Povijest njemačkog jezika',null,'0'),
(3,'Jezične vježbe 1',null,'1'),
(4,'Staroslavenski jezik',null,'1'),
(4,'Teorija jezika',null,'1');

insert into Studenti (smjerID,ime,prezime,oib) values
(4,'Ivan','Ivić','47457409385'),
(4,'Hajdi','Hajdić','15797970162'),
(1,'Goran','Grkić','20437329240'),
(1,'Marko','Markić','22353796851'),
(2,'Ivan','Ivičević','24088017749');

insert into ispitniRok (kolegijID,vrstaIspita,datum,vrijeme) values
(6,'pismeni','2024-06-10','12:00'),
(7,'usmeni','2024-06-14','10:00'),
(1,'pismeni','2024-06-10','9:00'),
(2,'pismeni','2024-06-12','10:30'),
(3,'pismeni','2024-06-17','14:00'),
(5,'pismeni','2024-06-18','16:00');

insert into Prijava (studentID,ispitniRokID,pristupio) values
(2,1,'1'),(2,2,'1'),(1,1,'1'),(1,2,'0'),(3,3,'1'),(3,4,'0'),(4,3,'1'),(4,4,'1'),(5,5,null);

