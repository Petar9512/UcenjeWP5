create database kolokvij_vjezba_15;
use kolokvij_vjezba_15;


create table decko (
sifra int not null primary key identity(1,1),
vesta varchar(37) not null,
bojakose varchar(45),
gustoca decimal(18,7),
prijatelj int not null
);

create table prijatelj (
sifra int not null primary key identity(1,1),
majica varchar(41) not null,
vesta varchar(30),
narukvica int not null,
zarucnica int
);

create table zarucnica (
sifra int not null primary key identity(1,1),
prviputa datetime not null,
bojaociju varchar(31) not null,
modelnaocala varchar(40),
zarucnik int
);

create table zarucnik (
sifra int not null primary key identity(1,1),
kratkamajica varchar(30) not null,
jmbag char(11) not null,
dukserica varchar(45) not null,
indiferentno bit,
treciputa datetime not null
);

create table ostavljena (
sifra int not null primary key identity(1,1),
gustoca decimal(16,7),
stilfrizura varchar(31) not null,
ogrlica int,
maraka decimal(15,10)
);

create table zarucnik_ostavljena (
sifra int not null primary key identity(1,1),
zarucnik int not null,
ostavljena int not null
);

--drop table zarucnik_ostavljena;

create table brat (
sifra int not null primary key identity(1,1),
bojakose varchar(49) not null,
majica varchar(36),
maraka decimal(17,9),
vesta varchar(30) not null
);

create table prijateljica (
sifra int not null primary key identity(1,1),
kratkamajica varchar(30) not null,
bojakose varchar(45),
asocijalno bit not null,
treciputa datetime not null,
jmbag char(11) not null,
vesta varchar(42) not null,
brat int
);

alter table decko add foreign key (prijatelj) references prijatelj(sifra);
alter table prijatelj add foreign key (zarucnica) references zarucnica(sifra);
alter table zarucnica add foreign key (zarucnik) references zarucnik(sifra);
alter table zarucnik_ostavljena add foreign key (zarucnik) references zarucnik(sifra);
alter table zarucnik_ostavljena add foreign key (ostavljena) references ostavljena(sifra);
alter table prijateljica add foreign key (brat) references brat(sifra);


insert into zarucnik (kratkamajica,jmbag,dukserica,treciputa) values
('plava','34657895846','ananas','2024-03-29'),('narančasta','77834567254','banana','2024-01-09'),
('zelena','24759874691','avokado','2024-02-12');
insert into ostavljena (stilfrizura) values
('kratka'),('valovita');
insert into zarucnik_ostavljena (zarucnik,ostavljena) values
(1,1),(1,2),(2,2);
insert into zarucnica (prviputa,bojaociju) values
('2024-04-28','plava'),('2024-01-11','crna'),('2024-03-03','smeđa');
insert into prijatelj (majica,narukvica) values
('ananas',2),('avokado',1),('banana',2);

update prijateljica set bojakose='Osijek';
delete from decko where bojakose='AB';
select modelnaocala from zarucnica where bojaociju like '%ana%';

select ostavljena.ogrlica, decko.prijatelj, prijatelj.vesta 
from ostavljena inner join zarucnik_ostavljena on ostavljena.sifra=zarucnik_ostavljena.ostavljena
inner join zarucnik on zarucnik_ostavljena.zarucnik=zarucnik.sifra
inner join zarucnica on zarucnik.sifra=zarucnica.zarucnik
inner join prijatelj on zarucnica.sifra=prijatelj.zarucnica
inner join decko on prijatelj.sifra=decko.prijatelj
where zarucnica.bojaociju like 'a%' and zarucnik.jmbag is not null
order by prijatelj.vesta desc;

select zarucnik.jmbag, zarucnik.dukserica
from zarucnik left join zarucnik_ostavljena on zarucnik.sifra=zarucnik_ostavljena.zarucnik
where zarucnik_ostavljena.zarucnik is null;