create database kolokvij_vjezba_7;
use kolokvij_vjezba_7;


create table cura (
sifra int not null primary key identity(1,1),
lipa decimal(12,9) not null,
introvertno bit,
modelnaocala varchar(40),
narukvica int,
treciputa datetime,
kuna decimal(14,9)
);

create table punica (
sifra int not null primary key identity(1,1),
majica varchar(40),
eura decimal(12,6) not null,
prstena int,
cura int not null
);

create table mladic (
sifra int not null primary key identity(1,1),
prstena int,
lipa decimal(14,5) not null,
narukvica int not null,
drugiputa datetime not null
);

create table zarucnik (
sifra int not null primary key identity(1,1),
vesta varchar(34),
asocijalno bit not null,
modelnaocala varchar(43),
narukvica int not null,
novcica decimal(15,5) not null
);

create table zarucnik_mladic (
sifra int not null primary key identity(1,1),
zarucnik int not null,
mladic int not null
);

create table ostavljen (
sifra int not null primary key identity(1,1),
lipa decimal(14,6),
introvertno bit not null,
kratkamajica varchar(38) not null,
prstena int not null,
zarucnik int
);

create table prijateljica (
sifra int not null primary key identity(1,1),
haljina varchar(45),
gustoca decimal(15,10) not null,
ogrlica int,
novcica decimal(12,5),
ostavljen int
);

create table sestra (
sifra int not null primary key identity(1,1),
bojakose varchar(34) not null,
hlace varchar(36) not null,
lipa decimal(15,6),
stilfrizura varchar(40) not null,
maraka decimal(12,8) not null,
prijateljica int
);

alter table punica add foreign key (cura) references cura(sifra);
alter table sestra add foreign key (prijateljica) references prijateljica(sifra);
alter table prijateljica add foreign key (ostavljen) references ostavljen(sifra);
alter table ostavljen add foreign key (zarucnik) references zarucnik(sifra);
alter table zarucnik_mladic add foreign key (zarucnik) references zarucnik(sifra);
alter table zarucnik_mladic add foreign key (mladic) references mladic(sifra);


insert into zarucnik (asocijalno,narukvica,novcica) values
(0,2,23.45),(1,2,34.33);
insert into mladic (lipa,narukvica,drugiputa) values
(25.24,3,'2024-01-28'),(12.65,2,'2024-05-02');
insert into zarucnik_mladic (zarucnik,mladic) values
(1,1),(1,2),(2,1);
insert into ostavljen (introvertno,kratkamajica,prstena) values
(0,'plava',1),(1,'zelena',2),(0,'crvena',0);
insert into prijateljica (gustoca) values
(21.23),(12.45),(36.87);

update punica set eura=15.77;
delete from sestra where hlace not like 'AB';
select kratkamajica from ostavljen where introvertno is null;

select mladic.narukvica, sestra.stilfrizura, prijateljica.gustoca
from mladic left join zarucnik_mladic on mladic.sifra=zarucnik_mladic.mladic
left join zarucnik on zarucnik_mladic.zarucnik=zarucnik.sifra
left join ostavljen on zarucnik.sifra=ostavljen.zarucnik
left join prijateljica on ostavljen.sifra=prijateljica.ostavljen
left join sestra on prijateljica.sifra=sestra.prijateljica
where ostavljen.introvertno is not null and zarucnik.asocijalno is not null
order by prijateljica.gustoca desc;

select zarucnik.asocijalno, zarucnik.modelnaocala
from zarucnik left join zarucnik_mladic on zarucnik.sifra=zarucnik_mladic.zarucnik
where zarucnik_mladic.zarucnik is null;