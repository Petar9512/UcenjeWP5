create database kolokvij_vjezba_13;
use kolokvij_vjezba_13;


create table cura (
sifra int not null primary key identity(1,1),
ogrlica int,
hlace varchar(42),
vesta varchar(31) not null,
majica varchar(50),
mladic int
);

create table mladic (
sifra int not null primary key identity(1,1),
drugiputa datetime not null,
carape varchar(48) not null,
ogrlica int,
kratkamajica varchar(42) not null,
introvertno bit not null,
asocijalno bit not null,
ostavljen int
);

create table ostavljen (
sifra int not null primary key identity(1,1),
kratkamajica varchar(34),
drugiputa datetime,
asocijalno bit not null,
stilfrizura varchar(40),
svekrva int not null
);

create table svekrva (
sifra int not null primary key identity(1,1),
hlace varchar(35),
ogrlica int,
ekstroventno bit not null,
narukvica int
);

create table svekar (
sifra int not null primary key identity(1,1),
suknja varchar(40),
stilfrizura varchar(34) not null,
gustoca decimal(15,10) not null,
carape varchar(35) not null
);

create table svekrva_svekar (
sifra int not null primary key identity(1,1),
svekrva int not null,
svekar int not null
);

create table neprijatelj (
sifra int not null primary key identity(1,1),
bojakose varchar(32),
novcica decimal(12,6) not null,
prviputa datetime,
indiferentno bit not null,
suknja varchar(44),
jmbag char(11),
muskarac int not null
);

create table muskarac (
sifra int not null primary key identity(1,1),
dukserica varchar(34),
gustoca decimal(13,10),
haljina varchar(42) not null,
majica varchar(39),
suknja varchar(50) not null,
kuna decimal(17,9) not null
);

alter table cura add foreign key (mladic) references mladic(sifra);
alter table mladic add foreign key (ostavljen) references ostavljen(sifra);
alter table ostavljen add foreign key (svekrva) references svekrva(sifra);
alter table svekrva_svekar add foreign key (svekrva) references svekrva(sifra);
alter table svekrva_svekar add foreign key (svekar) references svekar(sifra);
alter table neprijatelj add foreign key (muskarac) references muskarac(sifra);


insert into svekrva (ekstroventno) values
(1),(1),(0);
insert into svekar (stilfrizura,gustoca,carape) values
('ananas',24.67,'plave'),('banana',12.89,'crne');
insert into svekrva_svekar (svekrva,svekar) values
(1,1),(1,2),(2,2);
insert into ostavljen (asocijalno,svekrva) values
(0,1),(1,3);
insert into mladic (drugiputa,carape,kratkamajica,introvertno,asocijalno) values
('2024-05-31','zelene','blabla',0,0),('2024-03-30','smeđe','blablabla',1,1),
('2024-01-16','crne','blablabli',1,0);

update neprijatelj set novcica=13.77;
delete from cura  where hlace !='AB';
select asocijalno from ostavljen where drugiputa is null;

select svekar.gustoca, cura.majica, mladic.carape
from svekar inner join svekrva_svekar on svekar.sifra=svekrva_svekar.svekar
inner join svekrva on svekrva_svekar.svekrva=svekrva.sifra
inner join ostavljen on svekrva.sifra=ostavljen.svekrva
inner join mladic on ostavljen.sifra=mladic.ostavljen
inner join cura on mladic.sifra=cura.mladic
where ostavljen.drugiputa is not null and svekrva.ogrlica=193
order by mladic.carape desc;

select svekrva.ogrlica, svekrva.ekstroventno
from svekrva left join svekrva_svekar on svekrva.sifra=svekrva_svekar.svekrva
where svekrva_svekar.svekrva is null;