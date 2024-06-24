create database kolokvij_vjezba_8;
use kolokvij_vjezba_8;

create table prijateljica (
sifra int not null primary key identity(1,1),
vesta varchar(50),
nausnica int not null,
introvertno bit not null
);

create table cura (
sifra int not null primary key identity(1,1),
nausnica int not null,
indiferentno bit,
ogrlica int not null,
gustoca decimal(12,6),
drugiputa datetime,
vesta varchar(33),
prijateljica int
);

create table neprijatelj (
sifra int not null primary key identity(1,1),
kratkamajica varchar(44),
introvertno bit,
indiferentno bit,
ogrlica int not null,
becar int not null
);

create table brat (
sifra int not null primary key identity(1,1),
introvertno bit,
novcica decimal(14,7) not null,
treciputa datetime,
neprijatelj int
);

create table becar (
sifra int not null primary key identity(1,1),
eura decimal(15,10) not null,
treciputa datetime,
prviputa datetime,
muskarac int not null
);

create table muskarac (
sifra int not null primary key identity(1,1),
haljina varchar(47),
drugiputa datetime not null,
treciputa datetime
);

create table decko (
sifra int not null primary key identity(1,1),
kuna decimal(12,10),
lipa decimal(17,10),
bojakose varchar(44),
treciputa datetime not null,
ogrlica int not null,
ekstroventno bit not null
);

create table muskarac_decko (
sifra int not null primary key identity(1,1),
muskarac int not null,
decko int not null
);

alter table cura add foreign key (prijateljica) references prijateljica(sifra);
alter table brat add foreign key (neprijatelj) references neprijatelj(sifra);
alter table neprijatelj add foreign key (becar) references becar(sifra);
alter table becar add foreign key (muskarac) references muskarac(sifra);
alter table muskarac_decko add foreign key (muskarac) references muskarac(sifra);
alter table muskarac_decko add foreign key (decko) references decko(sifra);


insert into muskarac (drugiputa) values
('2024-02-07'),('2024-05-13');
insert into decko (treciputa,ogrlica,ekstroventno) values
('2024-04-10',1,1),('2024-03-28',2,0);
insert into muskarac_decko (muskarac,decko) values
(1,1),(1,2),(2,1);
insert into becar (eura,muskarac) values
(12.12,1),(13.15,1),(16.57,2);
insert into neprijatelj (ogrlica,becar) values
(1,1),(2,1),(0,2);

update cura set indiferentno=0;
delete from brat where novcica != 12.75;
select prviputa from becar where treciputa is null;

select decko.bojakose, brat.neprijatelj, neprijatelj.introvertno
from decko inner join muskarac_decko on decko.sifra=muskarac_decko.decko
inner join muskarac on muskarac_decko.muskarac=muskarac.sifra
inner join becar on muskarac.sifra=becar.muskarac
inner join neprijatelj on becar.sifra=neprijatelj.becar
inner join brat on neprijatelj.sifra=brat.neprijatelj
where becar.treciputa is not null and muskarac.drugiputa is not null
order by neprijatelj.introvertno desc;

select drugiputa, treciputa from muskarac where sifra not in (select muskarac from muskarac_decko);