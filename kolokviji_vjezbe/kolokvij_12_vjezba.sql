﻿create database kolokvij_vjezba_12;
use kolokvij_vjezba_12;


create table zena (
sifra int not null primary key identity(1,1),
eura decimal(16,6) not null,
indiferentno bit,
novcica decimal(15,5),
);

create table decko (
sifra int not null primary key identity(1,1),
hlace varchar(46),
asocijalno bit,
stilfrizura varchar(43) not null,
indiferentno bit not null,
ogrlica int,
zena int not null
);

create table svekrva (
sifra int not null primary key identity(1,1),
maraka decimal(14,7),
kuna decimal(15,8),
vesta varchar(44),
asocijalno bit not null,
ekstroventno bit,
zarucnica int
);

create table djevojka (
sifra int not null primary key identity(1,1),
modelnaocala varchar(34) not null,
vesta varchar(40) not null,
kratkamajica varchar(39) not null,
suknja varchar(36) not null,
bojaociju varchar(32) not null,
prstena int not null,
svekrva int not null
);

create table prijatelj (
sifra int not null primary key identity(1,1),
lipa decimal(16,10),
asocijalno bit,
stilfrizura varchar(37),
kuna decimal(14,6),
modelnaocala varchar(38),
djevojka int
);

create table zarucnica (
sifra int not null primary key identity(1,1),
hlace varchar(48) not null,
kratkamajica varchar(46) not null,
jmbag char(11),
nausnica int
);

create table sestra (
sifra int not null primary key identity(1,1),
lipa decimal(15,9),
ogrlica int,
kratkamajica varchar(43) not null
);

create table zarucnica_sestra (
sifra int not null primary key identity(1,1),
zarucnica int not null,
sestra int not null
);

alter table decko add foreign key (zena) references zena(sifra);
alter table zarucnica_sestra add foreign key (zarucnica) references zarucnica(sifra);
alter table zarucnica_sestra add foreign key (sestra) references sestra(sifra);
alter table svekrva add foreign key (zarucnica) references zarucnica(sifra);
alter table djevojka add foreign key (svekrva) references svekrva(sifra);
alter table prijatelj add foreign key (djevojka) references djevojka(sifra);


insert into zarucnica (hlace,kratkamajica) values
('dugačke','zelena'),('kratke','plava'),('srednje','crvena');
insert into sestra (kratkamajica) values
('ananas'),('banana');
insert into zarucnica_sestra (zarucnica,sestra) values
(1,1),(1,2),(2,1);
insert into svekrva (asocijalno) values
(0),(0),(1);
insert into djevojka (modelnaocala,vesta,kratkamajica,suknja,bojaociju,prstena,svekrva) values
('blabla','narančasta','zelena','adf','smeđa',2,3),('blablabla','crna','plava','fgh','crna',1,2),
('blablabli','ljubičasta','žuta','rtz','plava',1,1);
insert into prijatelj (kuna) values
(13.56),(23.67);

update decko set asocijalno=0;
delete from prijatelj where asocijalno=0;
select vesta from svekrva where kuna not in (8,13,20,28,35);

select sestra.kratkamajica, prijatelj.kuna, djevojka.vesta 
from sestra left join zarucnica_sestra on sestra.sifra=zarucnica_sestra.sestra
left join zarucnica on zarucnica_sestra.zarucnica=zarucnica.sifra
left join svekrva on zarucnica.sifra=svekrva.zarucnica
left join djevojka on svekrva.sifra=djevojka.svekrva
left join prijatelj on djevojka.sifra=prijatelj.djevojka
--where svekrva.kuna > 87 and zarucnica.kratkamajica like '%ba%'
order by djevojka.vesta desc;

select kratkamajica, jmbag from zarucnica where sifra not in (select zarucnica from zarucnica_sestra);