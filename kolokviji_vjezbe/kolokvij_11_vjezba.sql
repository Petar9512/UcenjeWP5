create database kolokvij_vjezba_11;
use kolokvij_vjezba_11;


create table punica (
sifra int not null primary key identity(1,1),
carape varchar(33) not null,
drugiputa datetime,
majica varchar(40) not null,
haljina varchar(30) not null,
bojakose varchar(37) not null,
djevojka int not null
);

create table djevojka (
sifra int not null primary key identity(1,1),
kratkamajica varchar(45) not null,
prstena int,
ekstroventno bit not null,
majica varchar(42) not null,
introvertno bit not null,
svekrva int
);

create table svekrva (
sifra int not null primary key identity(1,1),
narukvica int not null,
carape varchar(39) not null,
haljina varchar(31),
punac int not null
);

create table punac (
sifra int not null primary key identity(1,1),
jmbag char(11),
kuna decimal(16,5) not null,
vesta varchar(45) not null
);

create table mladic (
sifra int not null primary key identity(1,1),
ogrlica int not null,
stilfrizura varchar(35),
drugiputa datetime not null,
hlace varchar(41) not null
);

create table punac_mladic (
sifra int not null primary key identity(1,1),
punac int not null,
mladic int not null
);

create table muskarac (
sifra int not null primary key identity(1,1),
maraka decimal(16,5),
novcica decimal(13,10),
nausnica int,
narukvica int not null,
gustoca decimal(12,6),
neprijatelj int not null
);

create table neprijatelj (
sifra int not null primary key identity(1,1),
narukvica int not null,
novcica decimal(12,8) not null,
bojakose varchar(39) not null,
gustoca decimal(14,10),
introvertno bit not null,
asocijalno bit
);

alter table punica add foreign key (djevojka) references djevojka(sifra);
alter table djevojka add foreign key (svekrva) references svekrva(sifra);
alter table svekrva add foreign key (punac) references punac(sifra);
alter table punac_mladic add foreign key (punac) references punac(sifra);
alter table punac_mladic add foreign key (mladic) references mladic(sifra);
alter table muskarac add foreign key (neprijatelj) references neprijatelj(sifra);


insert into punac (kuna,vesta) values
(12.57,'plava'),(23.79,'zelena'),(43.87,'narančasta');
insert into mladic (ogrlica,drugiputa,hlace) values
(1,'2024-04-29','dugačke'),(2,'2024-03-10','kratke');
insert into punac_mladic (punac,mladic) values
(1,1),(1,2),(2,2);
insert into svekrva (narukvica,carape,punac) values
(2,'blitva',3),(3,'ananas',2),(1,'banana',1);
insert into djevojka (kratkamajica,ekstroventno,majica,introvertno) values
('plava',1,'zelena',0),('narančasta',1,'plava',0),('zelena',0,'žuta',1);
insert into punica (carape,majica,haljina,bojakose,djevojka) values
('asd','fgh','jkl','dfg',1),('qwe','rtz','uio','ert',3);

update muskarac set novcica=15.70;
delete from punica where drugiputa='2019-04-08';
select haljina from svekrva where carape like '%ana%';

select mladic.drugiputa, punica.haljina, djevojka.prstena
from mladic left join punac_mladic on mladic.sifra=punac_mladic.mladic
left join punac on punac_mladic.punac=punac.sifra
left join svekrva on punac.sifra=svekrva.punac
left join djevojka on svekrva.sifra=djevojka.svekrva
left join punica on djevojka.sifra=punica.djevojka
where svekrva.carape like 'a%' and punac.kuna != 21
order by djevojka.prstena desc;

select punac.kuna, punac.vesta 
from punac left join punac_mladic on punac.sifra=punac_mladic.punac
where punac_mladic.punac is null;