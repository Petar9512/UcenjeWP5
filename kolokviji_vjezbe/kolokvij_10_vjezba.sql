create database kolokvij_vjezba_10;
use kolokvij_vjezba_10;


create table zarucnica (
sifra int not null primary key identity(1,1),
treciputa datetime,
prviputa datetime,
suknja varchar(32) not null,
eura decimal(16,10)
);

create table sestra (
sifra int not null primary key identity(1,1),
suknja varchar(46) not null,
bojaociju varchar(49),
indiferentno bit,
dukserica varchar(32) not null,
drugiputa datetime,
prviputa datetime not null,
zarucnica int
);

create table mladic (
sifra int not null primary key identity(1,1),
hlace varchar(48) not null,
lipa decimal(18,6),
stilfrizura varchar(35) not null,
prstena int,
maraka decimal(12,6) not null,
svekrva int
);

create table zena (
sifra int not null primary key identity(1,1),
bojaociju varchar(49) not null,
maraka decimal(13,9) not null,
majica varchar(45),
indiferentno bit,
prviputa datetime,
mladic int
);

create table svekrva (
sifra int not null primary key identity(1,1),
eura decimal(17,9),
carape varchar(43),
kuna decimal(13,9),
majica varchar(30),
introvertno bit not null,
punac int
);

create table punac (
sifra int not null primary key identity(1,1),
lipa decimal(15,9),
eura decimal(15,10) not null,
stilfrizura varchar(37)
);

create table neprijatelj (
sifra int not null primary key identity(1,1),
gustoca decimal(15,10) not null,
dukserica varchar(32) not null,
maraka decimal(15,7),
stilfrizura varchar(49) not null
);

create table punac_neprijatelj (
sifra int not null primary key identity(1,1),
punac int not null,
neprijatelj int not null
);

alter table sestra add foreign key (zarucnica) references zarucnica(sifra);
alter table zena add foreign key (mladic) references mladic(sifra);
alter table mladic add foreign key (svekrva) references svekrva(sifra);
alter table svekrva add foreign key (punac) references punac(sifra);
alter table punac_neprijatelj add foreign key (punac) references punac(sifra);
alter table punac_neprijatelj add foreign key (neprijatelj) references neprijatelj(sifra);


insert into punac (eura) values
(13.56),(21.22),(14.32);
insert into neprijatelj (gustoca,dukserica,stilfrizura) values
(15.67,'plava','kratka'),(17.78,'zelena','valovita');
insert into punac_neprijatelj (punac,neprijatelj) values
(1,1),(1,2),(2,1);
insert into svekrva (introvertno) values
(0),(0),(1);
insert into mladic (hlace,stilfrizura,maraka) values
('ananas','kratka',6.89),('banana','dugačka',17.78),('blitva','valovita',23.43);

update sestra set bojaociju='Osijek';
delete from zena where maraka != 14.81;
select kuna from svekrva where carape like '%ana%';

select neprijatelj.maraka, zena.indiferentno, mladic.lipa
from neprijatelj inner join punac_neprijatelj on neprijatelj.sifra=punac_neprijatelj.neprijatelj
inner join punac on punac_neprijatelj.punac=punac.sifra
inner join svekrva on punac.sifra=svekrva.punac
inner join mladic on svekrva.sifra=mladic.svekrva
inner join zena on mladic.sifra=zena.mladic
where svekrva.carape like 'a%' and punac.eura != 22
order by mladic.lipa desc;

select eura, stilfrizura from punac where sifra not in (select punac from punac_neprijatelj);