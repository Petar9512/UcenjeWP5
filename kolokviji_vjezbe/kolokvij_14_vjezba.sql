create database kolokvij_vjezba_14;
use kolokvij_vjezba_14;


create table ostavljena (
sifra int not null primary key identity(1,1),
kuna decimal(17,7),
hlace varchar(45),
suknja varchar(36),
dukserica varchar(36),
kratkamajica varchar(47) not null,
gustoca decimal(12,10) not null,
ostavljen int
);

create table ostavljen (
sifra int not null primary key identity(1,1),
majica varchar(39),
drugiputa datetime not null,
asocijalno bit not null,
brat int not null
);

create table brat (
sifra int not null primary key identity(1,1),
eura decimal(15,10) not null,
gustoca decimal(14,5) not null,
kuna decimal(15,6),
haljina varchar(38) not null,
bojakose varchar(39),
prstena int,
neprijatelj int not null
);

create table neprijatelj (
sifra int not null primary key identity(1,1),
prstena int not null,
gustoca decimal(17,7),
bojakose varchar(48) not null,
ogrlica int not null,
stilfrizura varchar(47) not null
);

create table muskarac (
sifra int not null primary key identity(1,1),
carape varchar(36),
ogrlica int not null,
vesta varchar(44) not null,
ekstroventno bit
);

create table neprijatelj_muskarac (
sifra int not null primary key identity(1,1),
neprijatelj int not null,
muskarac int not null
);

--drop table nepriatelj_muskarac;

create table mladic (
sifra int not null primary key identity(1,1),
drugiputa datetime not null,
narukvica int,
bojaociju varchar(49) not null,
modelnaocala varchar(41)
);

create table prijatelj (
sifra int not null primary key identity(1,1),
stilfrizura varchar(39) not null,
kratkamajica varchar(32),
treciputa datetime,
modelnaocala varchar(32) not null,
prviputa datetime,
mladic int not null
);

alter table ostavljena add foreign key (ostavljen) references ostavljen(sifra);
alter table ostavljen add foreign key (brat) references brat(sifra);
alter table brat add foreign key (neprijatelj) references neprijatelj(sifra);
alter table neprijatelj_muskarac add foreign key (neprijatelj) references neprijatelj(sifra);
alter table neprijatelj_muskarac add foreign key (muskarac) references muskarac(sifra);
alter table prijatelj add foreign key (mladic) references mladic(sifra);


insert into neprijatelj (prstena,bojakose,ogrlica,stilfrizura) values
(2,'crna',1,'kratka'),(1,'smeđa',0,'ananas'),(0,'crna',1,'banana');
insert into muskarac (ogrlica,vesta) values
(2,'plava'),(1,'žuta');
insert into neprijatelj_muskarac (neprijatelj,muskarac) values
(1,1),(1,2),(2,2);
insert into brat (eura,gustoca,haljina,neprijatelj) values
(34.67,12.52,'zelena',2),(4.87,35.91,'narančasta',2),(25.75,15.98,'crvena',3);
insert into ostavljen (drugiputa,asocijalno,brat) values
('2024-03-21',0,1),('2024-02-26',0,2),('2024-01-30',1,2);

update prijatelj set kratkamajica='Osijek';
delete from ostavljena where hlace !='AB';
select kuna from brat where gustoca not in (6,10,16,25,36);

select muskarac.vesta, ostavljena.dukserica, ostavljen.drugiputa
from muskarac inner join neprijatelj_muskarac on muskarac.sifra=neprijatelj_muskarac.muskarac
inner join neprijatelj on neprijatelj_muskarac.neprijatelj=neprijatelj.sifra
inner join brat on neprijatelj.sifra=brat.neprijatelj
inner join ostavljen on brat.sifra=ostavljen.brat
inner join ostavljena on ostavljen.sifra=ostavljena.ostavljen
where brat.gustoca > 100 and neprijatelj.gustoca !=22
order by ostavljen.drugiputa desc;

select gustoca, bojakose from neprijatelj where sifra not in (select neprijatelj from neprijatelj_muskarac);