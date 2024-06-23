create database kolokvij_vjezba_5;
use kolokvij_vjezba_5;


create table mladic (
sifra int not null primary key identity(1,1),
kratkamajica varchar(48) not null,
haljina varchar(30) not null,
asocijalno bit,
zarucnik int
);

create table zarucnik (
sifra int not null primary key identity(1,1),
jmbag char(11),
lipa decimal(12,8),
indiferentno bit not null
);

create table punac (
sifra int not null primary key identity(1,1),
dukserica varchar(33),
prviputa datetime not null,
majica varchar(36),
svekar int not null
);

create table punica (
sifra int not null primary key identity(1,1),
hlace varchar(43) not null,
nausnica int not null,
ogrlica int,
vesta varchar(49) not null,
modelnaocala varchar(31) not null,
treciputa datetime not null,
punac int not null
);

create table ostavljena (
sifra int not null primary key identity(1,1),
majica varchar(33),
ogrlica int not null,
carape varchar(44),
stilfrizura varchar(42),
punica int not null
);

create table svekar (
sifra int not null primary key identity(1,1),
bojakose varchar(33),
majica varchar(31),
carape varchar(31) not null,
haljina varchar(43),
narukvica int,
eura decimal(14,5) not null
);

create table svekar_cura (
sifra int not null primary key identity(1,1),
svekar int not null,
cura int not null
);

create table cura (
sifra int not null primary key identity(1,1),
carape varchar(41) not null,
maraka decimal(17,10) not null,
asocijalno bit,
vesta varchar(47) not null
);

alter table mladic add foreign key (zarucnik) references zarucnik(sifra);
alter table ostavljena add foreign key (punica) references punica(sifra);
alter table punica add foreign key (punac) references punac(sifra);
alter table punac add foreign key (svekar) references svekar(sifra);
alter table svekar_cura add foreign key (svekar) references svekar(sifra);
alter table svekar_cura add foreign key (cura) references cura(sifra);


insert into svekar (carape,eura) values
('dugaèke',14.23),('kratke',4.23),('srednje',10.45);
insert into punac (prviputa,svekar) values
('2024-05-02',2),('2024-03-05',1),('2024-02-16',3);
insert into punica (hlace,nausnica,vesta,modelnaocala,treciputa,punac) values
('štogod',2,'bilošto','srednje','2024-05-17',3),('ništa',2,'zašto','velike','2024-04-19',1),('kako',2,'što','male','2024-02-12',2);
insert into cura (carape,maraka,vesta) values
('dugaèke',12.45,'plava'),('kratke',8.76,'zelena');
insert into svekar_cura (svekar,cura) values
(1,2),(2,1),(2,2);

update mladic set haljina='Osijek';
delete from ostavljena where ogrlica=17;
select majica from punac where prviputa is null;

select cura.asocijalno, ostavljena.stilfrizura, punica.nausnica
from cura inner join svekar_cura on cura.sifra=svekar_cura.cura
inner join svekar on svekar_cura.svekar=svekar.sifra
inner join punac on svekar.sifra=punac.svekar
inner join punica on punac.sifra=punica.punac
inner join ostavljena on punica.sifra=ostavljena.punica
where punac.prviputa is not null and svekar.majica like '%ba%'
order by punica.nausnica desc;

select svekar.majica, svekar.carape 
from svekar left join svekar_cura on svekar.sifra=svekar_cura.svekar
where svekar_cura.svekar is null;