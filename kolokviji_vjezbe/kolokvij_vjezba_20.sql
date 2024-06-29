create database kolokvij_vjezba_20;
use kolokvij_vjezba_20;


create table neprijateljica (
sifra int not null primary key identity(1,1),
introvertno bit not null,
nausnica int,
gustoca decimal(17,8),
lipa decimal(17,8),
jmbag char(11) not null,
zena int
);

create table zena (
sifra int not null primary key identity(1,1),
asocijalno bit not null,
nausnica int,
jmbag char(11) not null,
bojaociju varchar(41),
kratkamajica varchar(30)
);

create table zarucnica (
sifra int not null primary key identity(1,1),
modelnaocala varchar(50),
suknja varchar(49) not null,
prviputa datetime,
treciputa datetime,
decko int
);

create table decko (
sifra int not null primary key identity(1,1),
kuna decimal(14,5),
novcica decimal(15,7),
indiferentno bit not null,
maraka decimal(16,9) not null,
punica int not null
);

create table punica (
sifra int not null primary key identity(1,1),
ogrlica int,
prviputa datetime,
drugiputa datetime not null,
introvertno bit,
treciputa datetime,
mladic int not null
);

create table mladic (
sifra int not null primary key identity(1,1),
hlace varchar(47),
suknja varchar(50),
haljina varchar(50) not null,
prstena int not null,
treciputa datetime not null,
introvertno bit not null
);

create table zarucnik (
sifra int not null primary key identity(1,1),
suknja varchar(31),
prstena int not null,
modelnaocala varchar(46) not null,
novcica decimal(17,5) not null,
gustoca decimal(17,8)
);

create table mladic_zarucnik (
sifra int not null primary key identity(1,1),
mladic int not null,
zarucnik int not null
);

alter table neprijateljica add foreign key (zena) references zena(sifra);
alter table zarucnica add foreign key (decko) references decko(sifra);
alter table decko add foreign key (punica) references punica(sifra);
alter table punica add foreign key (mladic) references mladic(sifra);
alter table mladic_zarucnik add foreign key (mladic) references mladic(sifra);
alter table mladic_zarucnik add foreign key (zarucnik) references zarucnik(sifra);


insert into mladic (haljina,prstena,treciputa,introvertno) values
('ananas',2,'2024-03-23',0),('banana',1,'2024-05-10',0),('avokado',0,'2024-01-28',1);
insert into zarucnik (prstena,modelnaocala,novcica) values
(1,'banana',24.97),(0,'ananas',16.54);
insert into mladic_zarucnik (mladic,zarucnik) values
(1,1),(2,1),(2,2);
insert into punica (drugiputa,mladic) values
('2024-01-10',2),('2024-02-18',3),('2024-04-21',3);
insert into decko (indiferentno,maraka,punica) values
(0,28.81,2),(0,33.41,2),(1,75.23,3);

update neprijateljica set nausnica=10;
delete from zarucnica where suknja < 'AB';
select drugiputa from punica where prviputa is null;

select zarucnik.modelnaocala, zarucnica.treciputa, decko.novcica
from zarucnik inner join mladic_zarucnik on zarucnik.sifra=mladic_zarucnik.zarucnik
inner join mladic on mladic_zarucnik.mladic=mladic.sifra
inner join punica on mladic.sifra=punica.mladic
inner join decko on punica.sifra=decko.punica
inner join zarucnica on decko.sifra=zarucnica.decko
where punica.prviputa is not null and mladic.suknja like '%ba%'
order by decko.novcica desc;

select suknja, haljina from mladic where sifra not in (select mladic from mladic_zarucnik);