create database kolokvij_vjezba_4;
use kolokvij_vjezba_4;


create table punac (
sifra int not null primary key identity(1,1),
treciputa datetime,
majica varchar(46),
jmbag char(11) not null,
novcica decimal(18,7) not null,
maraka decimal(12,6) not null,
ostavljen int not null
);

create table ostavljen (
sifra int not null primary key identity(1,1),
modelnaocala varchar(43),
introvertno bit,
kuna decimal(14,10)
);

create table snasa (
sifra int not null primary key identity(1,1),
introvertno bit,
treciputa datetime,
haljina varchar(44) not null,
zena int not null
);

create table becar (
sifra int not null primary key identity(1,1),
novcica decimal(14,8),
kratkamajica varchar(48) not null,
bojaociju varchar(36) not null,
snasa int not null
);

create table prijatelj (
sifra int not null primary key identity(1,1),
eura decimal(16,9),
prstena int not null,
gustoca decimal(16,5),
jmbag char(11) not null,
suknja varchar(47) not null,
becar int not null
);

create table zena (
sifra int not null primary key identity(1,1),
suknja varchar(39) not null,
lipa decimal(18,7),
prstena int not null
);

create table zena_mladic (
sifra int not null primary key identity(1,1),
zena int not null,
mladic int not null
);

create table mladic (
sifra int not null primary key identity(1,1),
kuna decimal(15,9),
lipa decimal(18,5),
nausnica int,
stilfrizura varchar(49),
vesta varchar(34) not null
);

alter table punac add foreign key (ostavljen) references ostavljen(sifra);
alter table prijatelj add foreign key (becar) references becar(sifra);
alter table becar add foreign key (snasa) references snasa(sifra);
alter table snasa add foreign key (zena) references zena(sifra);
alter table zena_mladic add foreign key (zena) references zena(sifra);
alter table zena_mladic add foreign key (mladic) references mladic(sifra);


insert into zena (suknja,prstena) values
('nešto',2),('štogod',3);
insert into mladic (vesta) values
('bilošto'),('ništa');
insert into zena_mladic (zena,mladic) values
(1,2),(1,1),(2,2);
insert into snasa (haljina,zena) values
('blitva',1),('kupus',1),('ananas',2);
insert into becar (kratkamajica,bojaociju,snasa) values
('krumpir','plava',2),('naranèa','crna',2),('mrkva','zelena',3);

update punac set majica='Osijek';
delete from prijatelj where prstena>17;
select haljina from snasa where treciputa is null;

select mladic.nausnica, prijatelj.jmbag, becar.kratkamajica 
from mladic inner join zena_mladic on mladic.sifra=zena_mladic.mladic
inner join zena on zena_mladic.zena=zena.sifra
inner join snasa on zena.sifra=snasa.zena
inner join becar on snasa.sifra=becar.snasa
inner join prijatelj on becar.sifra=prijatelj.becar
where snasa.treciputa is not null and zena.lipa !=29
order by becar.kratkamajica desc;

select lipa, prstena from zena where sifra not in (select zena from zena_mladic);