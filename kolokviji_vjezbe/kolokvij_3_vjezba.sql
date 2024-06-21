create database kolokvij_vjezba_3;
use kolokvij_vjezba_3;

create table svekar (
sifra int not null primary key identity(1,1),
novcica decimal(16,8) not null,
suknja varchar(44) not null,
bojakose varchar(36),
prstena int,
narukvica int not null,
cura int not null
);

create table cura (
sifra int not null primary key identity(1,1),
dukserica varchar(49),
maraka decimal (13,7),
drugiputa datetime,
majica varchar(49),
novcica decimal(15,8),
ogrlica int not null
);

create table snasa (
sifra int not null primary key identity(1,1),
introvertno bit,
kuna decimal(15,6) not null,
eura decimal(12,9) not null,
treciputa datetime,
ostavljena int not null
);

create table punica (
sifra int not null primary key identity(1,1),
asocijalno bit,
kratkamajica varchar(44),
kuna decimal(13,8) not null,
vesta varchar(32) not null,
snasa int
);

create table ostavljena (
sifra int not null primary key identity(1,1),
kuna decimal(17,5),
lipa decimal(15,6),
majica varchar(36),
modelnaocala varchar(31) not null,
prijatelj int
);

create table prijatelj (
sifra int not null primary key identity(1,1),
kuna decimal(16,10),
haljina varchar(37),
lipa decimal(13,10),
dukserica varchar(31),
indiferentno bit not null
);

create table prijatelj_brat (
sifra int not null primary key identity(1,1),
prijatelj int not null,
brat int not null
);

create table brat (
sifra int not null primary key identity(1,1),
jmbag char(11),
ogrlica int not null,
ekstroventno bit not null
);

alter table svekar add foreign key (cura) references cura(sifra);
alter table punica add foreign key (snasa) references snasa(sifra);
alter table snasa add foreign key (ostavljena) references ostavljena(sifra);
alter table ostavljena add foreign key (prijatelj) references prijatelj(sifra);
alter table prijatelj_brat add foreign key (prijatelj) references prijatelj(sifra);
alter table prijatelj_brat add foreign key (brat) references brat(sifra);


insert into ostavljena (modelnaocala) values
('blabla'),('blablablu'),('blablabli');
insert into snasa (kuna,eura,ostavljena) values
(14.56,2.56,1),(13.78,34.23,1),(45.32,12.35,2);
insert into prijatelj (indiferentno) values
(0),(1),(0);
insert into brat (ogrlica,ekstroventno) values
(7,1),(3,0);
insert into prijatelj_brat (prijatelj,brat) values
(1,2),(2,1),(3,1);

update svekar set suknja='Osijek';
delete from punica where kratkamajica like 'AB';
select majica from ostavljena where lipa not in (9,10,20,30,35);

select brat.ekstroventno, punica.vesta, snasa.kuna
from brat inner join prijatelj_brat on brat.sifra=prijatelj_brat.brat
inner join prijatelj on prijatelj_brat.prijatelj=prijatelj.sifra
inner join ostavljena on prijatelj.sifra=ostavljena.prijatelj
inner join snasa on ostavljena.sifra=snasa.ostavljena
inner join punica on snasa.sifra=punica.snasa
where ostavljena.lipa !=91 and prijatelj.haljina like '%ba%'
order by snasa.kuna desc;

select haljina, lipa from prijatelj where sifra not in (select prijatelj from prijatelj_brat);
select prijatelj.haljina, prijatelj.lipa from prijatelj
left join prijatelj_brat on prijatelj.sifra=prijatelj_brat.prijatelj
where prijatelj_brat.prijatelj is null;