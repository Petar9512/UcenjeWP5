create database kolokvij_vjezba_19;
use kolokvij_vjezba_19;


create table muskarac (
sifra int not null primary key identity(1,1),
drugiputa datetime not null,
gustoca decimal(16,7),
maraka decimal(16,9),
ogrlica int not null,
svekrva int
);

create table svekrva (
sifra int not null primary key identity(1,1),
ekstroventno bit,
carape varchar(42),
gustoca decimal(13,10) not null,
stilfrizura varchar(34) not null,
punac int not null
);

create table punac (
sifra int not null primary key identity(1,1),
maraka decimal(12,7),
treciputa datetime,
ekstroventno bit,
hlace varchar(32),
punica int not null
);

create table punica (
sifra int not null primary key identity(1,1),
stilfrizura varchar(39),
maraka decimal(15,6) not null,
jmbag char(11)
);

create table ostavljena (
sifra int not null primary key identity(1,1),
hlace varchar(41),
ekstroventno bit not null,
narukvica int,
eura decimal(17,6) not null,
kratkamajica varchar(46)
);

create table punica_ostavljena (
sifra int not null primary key identity(1,1),
punica int not null,
ostavljena int not null
);

create table decko (
sifra int not null primary key identity(1,1),
modelnaocala varchar(42) not null,
gustoca decimal(16,10) not null,
dukserica varchar(47) not null,
stilfrizura varchar(40),
novcica decimal(14,7) not null
);

create table svekar (
sifra int not null primary key identity(1,1),
nausnica int not null,
indiferentno bit not null,
suknja varchar(37) not null,
drugiputa datetime,
kuna decimal(13,6) not null,
decko int
);

alter table svekar add foreign key (decko) references decko(sifra);
alter table muskarac add foreign key (svekrva) references svekrva(sifra);
alter table svekrva add foreign key (punac) references punac(sifra);
alter table punac add foreign key (punica) references punica(sifra);
alter table punica_ostavljena add foreign key (punica) references punica(sifra);
alter table punica_ostavljena add foreign key (ostavljena) references ostavljena(sifra);


insert into punica (stilfrizura,maraka,jmbag) values
('kratka',23.86,'08755668451'),('dugačka',12.98,'47689228657'),('valovita',33.88,'43598182783');
insert into ostavljena (ekstroventno,eura) values
(1,32.64),(0,12.72);
insert into punica_ostavljena (punica,ostavljena) values
(1,2),(2,1),(2,2);
insert into punac (punica) values
(2),(3),(3);
insert into svekrva (gustoca,stilfrizura,punac) values
(33.42,'kratka',1),(35.11,'dugačka',3),(26.72,'valovita',3);

update svekar set indiferentno=0;
delete from muskarac where gustoca=14.92;
select ekstroventno from punac where treciputa is null;

select ostavljena.narukvica, muskarac.ogrlica, svekrva.carape
from ostavljena inner join punica_ostavljena on ostavljena.sifra=punica_ostavljena.ostavljena
inner join punica on punica_ostavljena.punica=punica.sifra
inner join punac on punica.sifra=punac.punica
inner join svekrva on punac.sifra=svekrva.punac
inner join muskarac on svekrva.sifra=muskarac.svekrva
where punac.treciputa is not null and punica.maraka !=21
order by svekrva.carape desc;

select punica.maraka, punica.jmbag 
from punica left join punica_ostavljena on punica.sifra=punica_ostavljena.punica
where punica_ostavljena.punica is null;