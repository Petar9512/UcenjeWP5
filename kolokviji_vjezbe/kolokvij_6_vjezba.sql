create database kolokvij_vjezba_6;
use kolokvij_vjezba_6;


create table svekrva (
sifra int not null primary key identity(1,1),
hlace varchar(48) not null,
suknja varchar(42) not null,
ogrlica int not null,
treciputa datetime not null,
dukserica varchar(32) not null,
narukvica int not null,
punac int
);

create table punac (
sifra int not null primary key identity(1,1),
ekstroventno bit not null,
suknja varchar(30) not null,
majica varchar(44) not null,
prviputa datetime not null
);

create table brat (
sifra int not null primary key identity(1,1),
nausnica int not null,
treciputa datetime not null,
narukvica int not null,
hlace varchar(31),
prijatelj int
);

create table zena (
sifra int not null primary key identity(1,1),
novcica decimal(14,8) not null,
narukvica int not null,
dukserica varchar(40) not null,
haljina varchar(30),
hlace varchar(32),
brat int not null
);

create table decko (
sifra int not null primary key identity(1,1),
prviputa datetime,
modelnaocala varchar(41),
nausnica int,
zena int not null
);

create table prijatelj (
sifra int not null primary key identity(1,1),
haljina varchar(35),
prstena int not null,
introvertno bit,
stilfrizura varchar(36) not null
);

create table prijatelj_ostavljena (
sifra int not null primary key identity(1,1),
prijatelj int not null,
ostavljena int not null
);

create table ostavljena (
sifra int not null primary key identity(1,1),
prviputa datetime not null,
kratkamajica varchar(39) not null,
drugiputa datetime,
maraka decimal(14,10)
);

alter table svekrva add foreign key (punac) references punac(sifra);
alter table decko add foreign key (zena) references zena(sifra);
alter table zena add foreign key (brat) references brat(sifra);
alter table brat add foreign key (prijatelj) references prijatelj(sifra);
alter table prijatelj_ostavljena add foreign key (prijatelj) references prijatelj(sifra);
alter table prijatelj_ostavljena add foreign key (ostavljena) references ostavljena(sifra);


insert into prijatelj (prstena,stilfrizura) values
(2,'dugaèka'),(3,'valovita');
insert into ostavljena (prviputa,kratkamajica) values
('2024-02-05','blitva'),('2024-03-27','blabla');
insert into prijatelj_ostavljena (prijatelj,ostavljena) values
(1,2),(2,1),(2,2);
insert into brat (nausnica,treciputa,narukvica) values
(2,'2024-04-28',3),(3,'2024-04-10',2),(2,'2024-01-21',1);
insert into zena (novcica,narukvica,dukserica,brat) values
(12.56,2,'plava',2),(13.78,3,'zelena',2),(16.57,1,'crna',3);

update svekrva set suknja='Osijek';
delete from decko where modelnaocala not like 'AB';
select narukvica from brat where treciputa is null;

select ostavljena.drugiputa, decko.zena, zena.narukvica 
from ostavljena inner join prijatelj_ostavljena on ostavljena.sifra=prijatelj_ostavljena.ostavljena
inner join prijatelj on prijatelj_ostavljena.prijatelj=prijatelj.sifra
inner join brat on prijatelj.sifra=brat.prijatelj
inner join zena on brat.sifra=zena.brat
inner join decko on zena.sifra=decko.zena
where brat.treciputa is not null and prijatelj.prstena=219
order by zena.narukvica desc;

select prstena, introvertno from prijatelj where sifra not in (select prijatelj from prijatelj_ostavljena);