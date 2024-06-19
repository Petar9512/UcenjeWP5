create database kolokvij_vjezba_1;
use kolokvij_vjezba_1;


create table punac (
sifra int not null primary key identity(1,1),
ogrlica int,
gustoca decimal(14,9),
hlace varchar(41) not null
);

create table cura (
sifra int not null primary key identity(1,1),
novcica decimal(16,5) not null,
gustoca decimal(18,6) not null,
lipa decimal(13,10),
ogrlica int not null,
bojakose varchar(38),
suknja varchar(36),
punac int
);

create table sestra (
sifra int not null primary key identity(1,1),
introvertno bit,
haljina varchar(31) not null,
maraka decimal(16,6),
hlace varchar(46) not null,
narukvica int not null
);

create table zena (
sifra int not null primary key identity(1,1),
treciputa datetime,
hlace varchar(46),
kratkamajica varchar(31) not null,
jmbag char(11) not null,
bojaociju varchar(39) not null,
haljina varchar(44),
sestra int not null
);

create table muskarac (
sifra int not null primary key identity(1,1),
bojaociju varchar(50) not null,
hlace varchar(30),
modelnaocala varchar(43),
maraka decimal(14,5) not null,
zena int not null
);

create table mladic (
sifra int not null primary key identity(1,1),
suknja varchar(50) not null,
kuna decimal(16,8) not null,
drugiputa datetime,
asocijalno bit,
ekstrovertno bit not null,
dukserica varchar(48) not null,
muskarac int
);

create table svekar (
sifra int not null primary key identity(1,1),
bojaociju varchar(40) not null,
prstena int,
dukserica varchar(41),
lipa decimal(13,8),
eura decimal(12,7),
majica varchar(35)
);

create table sestra_svekar (
sifra int not null primary key identity(1,1),
sestra int not null,
svekar int not null
);

alter table sestra_svekar add foreign key (sestra) references sestra(sifra);
alter table sestra_svekar add foreign key (svekar) references svekar(sifra);
alter table zena add foreign key (sestra) references sestra(sifra);
alter table muskarac add foreign key (zena) references zena(sifra);
alter table mladic add foreign key (muskarac) references muskarac(sifra);
alter table cura add foreign key (punac) references punac(sifra);


insert into muskarac (bojaociju,maraka,zena) values
('plava',14.56,3),('zelena',16.78,2),('crna',12.44,1);

insert into zena (kratkamajica,jmbag,bojaociju,sestra) values
('stogod','23456787654','crna',2),('neznam','12345678987','plava',1),('bilosto','45678987654','zelena',3);

insert into sestra_svekar (sestra,svekar) values
(1,2),(2,4),(3,4);

update cura set gustoca=15.77;

delete from mladic where kuna>15.78;

select kratkamajica from zena where hlace like '%ana%';

select svekar.dukserica, mladic.asocijalno, muskarac.hlace 
from muskarac inner join mladic on muskarac.sifra=mladic.muskarac
inner join zena on muskarac.zena=zena.sifra
inner join sestra on zena.sestra=sestra.sifra
inner join sestra_svekar on sestra_svekar.sestra=sestra.sifra
inner join svekar on sestra_svekar.svekar=svekar.sifra
where zena.hlace like 'a%' and sestra.haljina like '%ba%'
order by muskarac.hlace desc;

select haljina, maraka 
from sestra where sestra.sifra not in (select sestra from sestra_svekar);