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


update Mjesto set naziv='Smokovljani' where sifra=10;
update Mjesto set naziv='Stupa' where sifra=11;
update Mjesto set naziv='Èepikuæe' where sifra=12;
update Mjesto set naziv='Donja Suvaja' where sifra=1;
update Mjesto set naziv='Sreser' where sifra=7;

delete from Opcina where sifra=4;
delete from Opcina where sifra=5;


create table Zaposlenici (
sifra int not null primary key identity(1,1),
ime varchar(30) not null,
prezime varchar(30) not null,
datumRodenja date not null,
placa decimal(10,2),
invalid bit not null
);

create table Slike (
sifra int not null primary key identity(1,1),
zaposlenik int not null,
redniBroj int not null,
putanja varchar(150) not null
);

alter table Slike add foreign key (zaposlenik) references Zaposlenici(sifra);


insert into Zaposlenici (ime,prezime,datumRodenja,placa,invalid) values
('Ivan','Iviæ','1976-05-10',null,0),
('Goran','Grkiæ','1978-06-15',null,0),
('Hajdi','Hajdiæ','1988-03-05',null,0);

insert into Slike (zaposlenik,redniBroj,putanja) values
(1,1,'https://www.pexels.com/photo/two-deer-grazing-in-a-field-with-trees-in-the-background-21820922/'),
(1,2,'https://www.pexels.com/photo/kiz-kulesi-in-istanbul-at-sunset-23731698/'),
(2,3,'https://www.pexels.com/photo/a-mountain-with-trees-and-clouds-in-the-background-20875403/'),
(2,4,'https://www.pexels.com/video/sunflower-in-rural-setting-at-sunset-in-summer-20712217/'),
(3,5,'https://www.pexels.com/photo/diamond-cut-24778046/'),
(3,6,'https://www.pexels.com/video/light-city-man-love-25559507/');

