create database kolokvij_vjezba_21;
use kolokvij_vjezba_21;


create table djevojka (
sifra int not null primary key identity(1,1),
bojakose varchar(31),
maraka decimal(18,7),
indiferentno bit not null,
kratkamajica varchar(30),
ogrlica int not null,
mladic int not null
);

create table mladic (
sifra int not null primary key identity(1,1),
modelnaocala varchar(40) not null,
treciputa datetime not null,
asocijalno bit not null,
majica varchar(34) not null
);

create table svekrva (
sifra int not null primary key identity(1,1),
treciputa datetime,
jmbag char(11),
gustoca decimal(18,9) not null,
ostavljen int not null
);

create table ostavljen (
sifra int not null primary key identity(1,1),
bojakose varchar(50),
ekstroventno bit not null,
kratkamajica varchar(34) not null,
kuna decimal(13,5) not null,
maraka decimal(18,9),
vesta varchar(38),
cura int
);

create table cura (
sifra int not null primary key identity(1,1),
modelnaocala varchar(45),
bojakose varchar(35),
nausnica int not null,
ogrlica int,
dukserica varchar(43) not null,
stilfrizura varchar(39) not null,
zena int not null
);

create table zena (
sifra int not null primary key identity(1,1),
kuna decimal(12,7) not null,
drugiputa datetime,
asocijalno bit not null,
jmbag char(11),
prviputa datetime,
maraka decimal(17,5)
);

create table brat (
sifra int not null primary key identity(1,1),
gustoca decimal(14,10),
prviputa datetime not null,
hlace varchar(31) not null,
stilfrizura varchar(38),
novcica decimal(13,5),
indiferentno bit
);

create table zena_brat (
sifra int not null primary key identity(1,1),
zena int not null,
brat int not null
);

alter table djevojka add foreign key (mladic) references mladic(sifra);
alter table svekrva add foreign key (ostavljen) references ostavljen(sifra);
alter table ostavljen add foreign key (cura) references cura(sifra);
alter table cura add foreign key (zena) references zena(sifra);
alter table zena_brat add foreign key (zena) references zena(sifra);
alter table zena_brat add foreign key (brat) references brat(sifra);


insert into zena (kuna,asocijalno) values
(2.86,0),(54.12,1),(21.73,0);
insert into brat (prviputa,hlace) values
('2024-03-16','ananas'),('2024-05-25','banana');
insert into zena_brat (zena,brat) values
(1,1),(3,1),(3,2);
insert into cura (nausnica,dukserica,stilfrizura,zena) values
(2,'plava','kratka',3),(1,'zelena','dugačka',2),(0,'crvena','valovita',1);
insert into ostavljen (ekstroventno,kratkamajica,kuna) values
(1,'narančasta',45.67),(0,'ljubičasta',77.21);

update djevojka set maraka=15.74;
delete from svekrva where jmbag='00000000007';
select nausnica from cura where bojakose like '%ana%';

select brat.hlace, svekrva.ostavljen, ostavljen.ekstroventno
from brat inner join zena_brat on brat.sifra=zena_brat.brat
inner join zena on zena_brat.zena=zena.sifra
inner join cura on zena.sifra=cura.zena
inner join ostavljen on cura.sifra=ostavljen.cura
inner join svekrva on ostavljen.sifra=svekrva.ostavljen
where cura.bojakose like 'a%' and zena.drugiputa is not null
order by ostavljen.ekstroventno desc;

select zena.drugiputa, zena.asocijalno
from zena left join zena_brat on zena.sifra=zena_brat.zena
where zena_brat.zena is null;