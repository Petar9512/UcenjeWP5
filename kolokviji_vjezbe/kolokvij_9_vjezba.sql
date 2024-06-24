create database kolokvij_vjezba_9;
use kolokvij_vjezba_9;


create table prijateljica (
sifra int not null primary key identity(1,1),
treciputa datetime,
novcica decimal(16,7),
kuna decimal(14,10) not null,
drugiputa datetime,
haljina varchar(45),
kratkamajica varchar(49)
);

create table punac (
sifra int not null primary key identity(1,1),
narukvica int not null,
modelnaocala varchar(30),
kuna decimal(12,8),
bojaociju varchar(33),
suknja varchar(45)
);

create table punac_prijateljica (
sifra int not null primary key identity(1,1),
punac int not null,
prijateljica int not null
);

create table cura (
sifra int not null primary key identity(1,1),
vesta varchar(49) not null,
ekstroventno bit,
carape varchar(37),
suknja varchar(37) not null,
punac int not null
);

create table brat (
sifra int not null primary key identity(1,1),
novcica decimal(18,9) not null,
ekstroventno bit,
vesta varchar(32) not null,
cura int
);

create table zarucnik (
sifra int not null primary key identity(1,1),
gustoca decimal(17,6),
haljina varchar(40),
kratkamajica varchar(48) not null,
nausnica int not null,
brat int not null
);

create table ostavljena (
sifra int not null primary key identity(1,1),
modelnaocala varchar(34) not null,
suknja varchar(32),
eura decimal(18,7) not null,
lipa decimal(15,7) not null,
treciputa datetime not null,
drugiputa datetime not null
);

create table snasa(
sifra int not null primary key identity(1,1),
prstena int,
drugiputa datetime not null,
haljina varchar(38) not null,
ostavljena int
);

alter table snasa add foreign key (ostavljena) references ostavljena(sifra);
alter table zarucnik add foreign key (brat) references brat(sifra);
alter table brat add foreign key (cura) references cura(sifra);
alter table cura add foreign key (punac) references punac(sifra);
alter table punac_prijateljica add foreign key (punac) references punac(sifra);
alter table punac_prijateljica add foreign key (prijateljica) references prijateljica(sifra);


insert into punac (narukvica) values
(2),(2),(3);
insert into prijateljica (kuna) values
(25.34),(13.67);
insert into punac_prijateljica (punac,prijateljica) values
(1,1),(1,2),(2,1);
insert into cura (vesta,suknja,punac) values
('plava','zelena',1),('crvena','lubičasta',2),('narančasta','žuta',2);
insert into brat (novcica,vesta) values
(13.79,'crvena'),(34.56,'plava'),(23.87,'zelena');

update snasa set drugiputa='2020-04-24';
delete from zarucnik where haljina='AB';
select carape from cura where ekstroventno is null;

select prijateljica.kuna, zarucnik.nausnica, brat.ekstroventno 
from prijateljica inner join punac_prijateljica on prijateljica.sifra=punac_prijateljica.prijateljica
inner join punac on punac_prijateljica.punac=punac.sifra
inner join cura on punac.sifra=cura.punac
inner join brat on cura.sifra=brat.cura
inner join zarucnik on brat.sifra=zarucnik.brat
where cura.ekstroventno is not null and punac.modelnaocala like '%ba%'
order by brat.ekstroventno desc;

select punac.modelnaocala, punac.kuna 
from punac left join punac_prijateljica on punac.sifra=punac_prijateljica.punac
where punac_prijateljica.punac is null;

