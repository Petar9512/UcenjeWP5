create database kolokvij_vjezba_18;
use kolokvij_vjezba_18;


create table zarucnica (
sifra int not null primary key identity(1,1),
carape varchar(43),
treciputa datetime not null,
eura decimal(16,8),
sestra int
);

create table sestra (
sifra int not null primary key identity(1,1),
eura decimal(14,10),
indiferentno bit,
maraka decimal(13,8),
ogrlica int,
haljina varchar(31) not null,
introvertno bit,
mladic int
);

create table mladic (
sifra int not null primary key identity(1,1),
carape varchar(50) not null,
jmbag char(11),
hlace varchar(50) not null,
treciputa datetime,
drugiputa datetime not null,
muskarac int
);

create table muskarac (
sifra int not null primary key identity(1,1),
treciputa datetime,
nausnica int not null,
drugiputa datetime not null,
prstena int not null,
modelnaocala varchar(34)
);

create table prijatelj (
sifra int not null primary key identity(1,1),
novcica decimal(15,9),
ekstroventno bit not null,
bojakose varchar(30) not null,
haljina varchar(37),
narukvica int
);

create table muskarac_prijatelj (
sifra int not null primary key identity(1,1),
muskarac int not null,
prijatelj int not null
);

create table djevojka (
sifra int not null primary key identity(1,1),
bojaociju varchar(43) not null,
treciputa datetime not null,
carape varchar(32) not null
);

create table ostavljena (
sifra int not null primary key identity(1,1),
novcica decimal(18,9),
drugiputa datetime not null,
dukserica varchar(35),
kratkamajica varchar(34),
djevojka int not null
);

alter table ostavljena add foreign key (djevojka) references djevojka(sifra);
alter table zarucnica add foreign key (sestra) references sestra(sifra);
alter table sestra add foreign key (mladic) references mladic(sifra);
alter table mladic add foreign key (muskarac) references muskarac(sifra);
alter table muskarac_prijatelj add foreign key (muskarac) references muskarac(sifra);
alter table muskarac_prijatelj add foreign key (prijatelj) references prijatelj(sifra);


insert into prijatelj (ekstroventno,bojakose) values
(1,'crna'),(0,'smeđa');
insert into muskarac (nausnica,drugiputa,prstena) values
(2,'2024-03-17',1),(1,'2024-02-12',0),(0,'2024-01-11',1);
insert into muskarac_prijatelj (muskarac,prijatelj) values
(1,1),(2,1),(2,2);
insert into mladic (carape,hlace,drugiputa) values
('ananas','blabla','2024-01-21'),('banana','blabli','2024-01-24'),('avokado','blablu','2024-03-29');
insert into sestra (haljina) values
('crvena'),('žuta'),('ljubičasta');

update ostavljena set drugiputa='2016-04-07';
delete from zarucnica where treciputa='2015-04-18';
select hlace from mladic where jmbag is null;

select prijatelj.bojakose, zarucnica.sestra, sestra.indiferentno
from prijatelj inner join muskarac_prijatelj on prijatelj.sifra=muskarac_prijatelj.prijatelj
inner join muskarac on muskarac_prijatelj.muskarac=muskarac.sifra
inner join mladic on muskarac.sifra=mladic.muskarac
inner join sestra on mladic.sifra=sestra.mladic
inner join zarucnica on sestra.sifra=zarucnica.sestra
where mladic.jmbag is not null and muskarac.nausnica=213
order by sestra.indiferentno desc;

select nausnica, drugiputa from muskarac where sifra not in (select muskarac from muskarac_prijatelj);