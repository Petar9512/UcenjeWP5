use master;
go
drop database if exists ZupanijeITvrtke;
go
create database ZupanijeITvrtke;
go
use ZupanijeITvrtke;

create table Zupan (
sifra int not null primary key identity(1,1),
ime varchar(30) not null,
prezime varchar(30) not null
);

create table Zupanija (
sifra int not null primary key identity(1,1),
naziv varchar(40) not null,
zupan int not null
);

create table Opcina (
sifra int not null primary key identity(1,1),
zupanija int not null,
naziv varchar(40) not null
);

create table Mjesto (
sifra int not null primary key identity(1,1),
opcina int not null,
naziv varchar(40) not null
);

alter table Zupanija add foreign key (zupan) references Zupan(sifra);
alter table Opcina add foreign key (zupanija) references Zupanija(sifra);
alter table Mjesto add foreign key (opcina) references Opcina(sifra);


insert into Zupan (ime,prezime) values
('Nikola','Dobroslaviæ'),('Blaženko','Boban'),('Božidar','Longin');

insert into Zupanija (naziv,zupan) values
('Zadarska',3),('Splitsko-dalmatinska',2),('Dubrovaèko-neretvanska',1);

insert into Opcina (zupanija,naziv) values
(3,'Dubrovaèko Primorje'),(3,'Janjina'),
(2,'Baška Voda'),(2,'Zmijavci'),
(1,'Bibinje'),(1,'Graèac');

insert into Mjesto (opcina,naziv) values
(6,'Cerovac'),(6,'Dugopolje'),
(3,'Promajna'),(3,'Bratuš'),(3,'Krvavica'),(3,'Bast'),
(2,'Draèe'),(2,'Osobjava'),(2,'Popova Luka'),
(1,'Topolo'),(1,'Imotica'),(1,'Visoèani');

