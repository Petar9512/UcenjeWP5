create database kolokvij_vjezba_16;
use kolokvij_vjezba_16;


create table zena (
sifra int not null primary key identity(1,1),
gustoca decimal(12,8),
lipa decimal(16,6),
ogrlica int,
carape varchar(32),
nausnica int not null,
modelnaocala varchar(46) not null,
prijatelj int
);

create table prijatelj (
sifra int not null primary key identity(1,1),
treciputa datetime,
majica varchar(49),
asocijalno bit not null,
hlace varchar(42)
);

create table svekrva (
sifra int not null primary key identity(1,1),
jmbag char(11),
ogrlica int,
bojakose varchar(40) not null,
drugiputa datetime not null,
mladic int not null
);

create table mladic (
sifra int not null primary key identity(1,1),
haljina varchar(30),
lipa decimal(12,8),
kratkamajica varchar(33),
kuna decimal(12,10),
treciputa datetime not null,
brat int not null
);

create table brat (
sifra int not null primary key identity(1,1),
vesta varchar(44) not null,
dukserica varchar(34),
prstena int,
majica varchar(36) not null,
punac int not null
);

create table punac (
sifra int not null primary key identity(1,1),
kratkamajica varchar(45),
bojakose varchar(41),
novcica decimal(16,8),
treciputa datetime not null
);

create table zarucnik (
sifra int not null primary key identity(1,1),
novcica decimal(13,9) not null,
bojakose varchar(41) not null,
kuna decimal(16,8) not null,
prstena int not null,
kratkamajica varchar(44) not null,
nausnica int not null
);

create table punac_zarucnik (
sifra int not null primary key identity(1,1),
punac int not null,
zarucnik int not null
);

alter table zena add foreign key (prijatelj) references prijatelj(sifra);
alter table svekrva add foreign key (mladic) references mladic(sifra);
alter table mladic add foreign key (brat) references brat(sifra);
alter table brat add foreign key (punac) references punac(sifra);
alter table punac_zarucnik add foreign key (punac) references punac(sifra);
alter table punac_zarucnik add foreign key (zarucnik) references zarucnik(sifra);


insert into punac (treciputa) values
('2024-03-17'),('2024-02-22'),('2024-01-10');
insert into zarucnik (novcica,bojakose,kuna,prstena,kratkamajica,nausnica) values
(23.57,'crna',12.87,2,'ananas',2),(12.65,'smeđa',24.82,1,'banana',0);
insert into punac_zarucnik (punac,zarucnik) values
(1,1),(1,2),(2,2);
insert into brat (vesta,majica,punac) values
('plava','blabla',2),('žuta','blablabla',2),('narančasta','blablabli',3);
insert into mladic (treciputa,brat) values
('2024-04-30',1),('2024-03-02',3),('2024-03-31',3);

update zena set lipa=13.77;
delete from svekrva where ogrlica !=18;
select prstena from brat where dukserica like '%ana%';

select zarucnik.kuna, svekrva.drugiputa, mladic.lipa
from zarucnik inner join punac_zarucnik on zarucnik.sifra=punac_zarucnik.zarucnik
inner join punac on punac_zarucnik.punac=punac.sifra
inner join brat on punac.sifra=brat.punac
inner join mladic on brat.sifra=mladic.brat
inner join svekrva on mladic.sifra=svekrva.mladic
where brat.dukserica like 'a%' and punac.bojakose like '%ba%'
order by mladic.lipa desc;

select bojakose, novcica from punac where sifra not in (select punac from punac_zarucnik);