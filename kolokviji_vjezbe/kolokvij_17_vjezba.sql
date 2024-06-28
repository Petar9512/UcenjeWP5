create database kolokvij_vjezba_17;
use kolokvij_vjezba_17;


create table punica (
sifra int not null primary key identity(1,1),
indiferentno bit,
narukvica int,
gustoca decimal(18,10) not null,
prijatelj int
);

create table prijatelj (
sifra int not null primary key identity(1,1),
maraka decimal(13,6),
narukvica int,
nausnica int,
lipa decimal(15,10),
carape varchar(33) not null,
stilfrizura varchar(35)
);

create table prijateljica (
sifra int not null primary key identity(1,1),
lipa decimal(12,9),
haljina varchar(37),
maraka decimal(13,8) not null,
modelnaocala varchar(41) not null,
cura int
);

create table cura (
sifra int not null primary key identity(1,1),
ogrlica int,
kuna decimal(16,8),
indiferentno bit,
jmbag char(11),
maraka decimal(12,7) not null,
ostavljen int not null
);

create table ostavljen (
sifra int not null primary key identity(1,1),
bojaociju varchar(45),
bojakose varchar(33),
novcica decimal(16,7) not null,
brat int not null
);

create table brat (
sifra int not null primary key identity(1,1),
asocijalno bit not null,
dukserica varchar(35),
novcica decimal(15,6) not null,
introvertno bit not null
);

create table becar (
sifra int not null primary key identity(1,1),
narukvica int,
asocijalno bit not null,
vesta varchar(48),
kuna decimal(13,10),
kratkamajica varchar(30) not null
);

create table brat_becar (
sifra int not null primary key identity(1,1),
brat int not null,
becar int not null
);

alter table punica add foreign key (prijatelj) references prijatelj(sifra);
alter table prijateljica add foreign key (cura) references cura(sifra);
alter table cura add foreign key (ostavljen) references ostavljen(sifra);
alter table ostavljen add foreign key (brat) references brat(sifra);
alter table brat_becar add foreign key (brat) references brat(sifra);
alter table brat_becar add foreign key (becar) references becar(sifra);


insert into brat (asocijalno,novcica,introvertno) values
(1,13.47,1),(0,45.32,0),(0,32.34,1);
insert into becar (asocijalno,kratkamajica) values
(0,'ananas'),(1,'banana');
insert into brat_becar (brat,becar) values
(1,1),(2,1),(2,2);
insert into ostavljen (novcica,brat) values
(13.87,1),(54.87,2),(43.92,2);
insert into cura (maraka,ostavljen) values
(26.83,2),(45.91,3),(49.32,3);

update punica set narukvica=11;
delete from prijateljica where haljina !='AB';
select novcica from ostavljen where bojakose like '%ana%';

select becar.vesta, prijateljica.modelnaocala, cura.kuna
from becar inner join brat_becar on becar.sifra=brat_becar.becar
inner join brat on brat_becar.brat=brat.sifra
inner join ostavljen on brat.sifra=ostavljen.brat
inner join cura on ostavljen.sifra=cura.ostavljen
inner join prijateljica on cura.sifra=prijateljica.cura
where ostavljen.bojakose like 'a%' and brat.dukserica like '%ba%'
order by cura.kuna desc;

select brat.dukserica, brat.novcica
from brat left join brat_becar on brat.sifra=brat_becar.brat
where brat_becar.brat is null;