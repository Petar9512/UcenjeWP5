create database kolokvij_vjezba_2;
use kolokvij_vjezba_2;


create table prijatelj (
sifra int not null primary key identity(1,1),
modelnaocala varchar(37),
treciputa datetime not null,
ekstrovertno bit not null,
prviputa datetime,
svekar int not null
);

create table svekar (
sifra int not null primary key identity(1,1),
stilfrizura varchar(48),
ogrlica int not null,
asocijalno bit not null
);

create table decko (
sifra int not null primary key identity(1,1),
indiferentno bit,
vesta varchar(34),
asocijalno bit not null
);

create table decko_zarucnica (
sifra int not null primary key identity(1,1),
decko int not null,
zarucnica int not null
);

create table zarucnica (
sifra int not null primary key identity(1,1),
narukvica int,
bojakose varchar(37) not null,
novcica decimal(15,9),
lipa decimal(15,8) not null,
indiferentno bit not null
);

create table cura (
sifra int not null primary key identity(1,1),
haljina varchar(33) not null,
drugiputa datetime not null,
suknja varchar(38),
narukvica int,
introvertno bit,
majica varchar(40) not null,
decko int
);

create table neprijatelj (
sifra int not null primary key identity(1,1),
majica varchar(32),
haljina varchar(43) not null,
lipa decimal(16,8),
modelnaocala varchar(49) not null,
kuna decimal(12,6) not null,
jmbag char(11),
cura int
);

create table brat (
sifra int not null primary key identity(1,1),
suknja varchar(47),
ogrlica int not null,
asocijalno bit not null,
neprijatelj int not null
);

alter table prijatelj add foreign key (svekar) references svekar(sifra);
alter table decko_zarucnica add foreign key (decko) references decko(sifra);
alter table decko_zarucnica add foreign key (zarucnica) references zarucnica(sifra);
alter table cura add foreign key (decko) references decko(sifra);
alter table neprijatelj add foreign key (cura) references cura(sifra);
alter table brat add foreign key (neprijatelj) references neprijatelj(sifra);


insert into neprijatelj (haljina,modelnaocala,kuna) values
('nešto','blabla',13.56),('štogod','blablabla',16.55),('opet','blablablu',12.78);
insert into cura (haljina,drugiputa,majica) values
('štogod','2024-01-05','blabla'),('nešto','2024-02-06','blablabli'),('blitva','2024-05-04','blablabla');
insert into decko (asocijalno) values
(0),(1),(0);
insert into zarucnica (bojakose,lipa,indiferentno) values
('plava',13.45,0),('crna',17.65,1);
insert into decko_zarucnica (decko,zarucnica) values
(1,2),(1,1),(2,2);

update prijatelj set treciputa='2020-04-30';

delete from brat where ogrlica != 14;

select suknja from cura where drugiputa is null;

select zarucnica.novcica, brat.neprijatelj, neprijatelj.haljina 
from zarucnica inner join decko_zarucnica on zarucnica.sifra=decko_zarucnica.zarucnica
inner join decko on decko_zarucnica.decko=decko.sifra
inner join cura on decko.sifra=cura.decko
inner join neprijatelj on cura.sifra=neprijatelj.cura
inner join brat on neprijatelj.sifra=brat.neprijatelj
where cura.drugiputa is null and decko.vesta like '%ba%'
order by neprijatelj.haljina desc;

select decko.vesta, decko.asocijalno 
from decko left join decko_zarucnica
on decko.sifra=decko_zarucnica.decko
where decko_zarucnica.decko is null;