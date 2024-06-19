select sifra, ime, prezime, datumRodenja from autor
where sifra=2;

select naziv, aktivan from izdavac
where sifra=2;

select ime, prezime from autor;

select naslov from katalog where naslov like '%ljub%';

select * from mjesto where postanskiBroj is not null;

select naziv from mjesto where sifra not between 2000 and 3000;

select * from mjesto where naziv like 'Y%';

select * from izdavac where aktivan=1 and naziv like '%.';

select * from izdavac where aktivan=0 and sifra not in (346,234,589);

select * from katalog where sifra>3000 or naslov like '%ljubav%';

select katalog.naslov, mjesto.naziv
from katalog inner join mjesto on mjesto.sifra = katalog.mjesto
inner join autor on autor.sifra = katalog.autor
inner join izdavac on izdavac.sifra = katalog.izdavac
where autor.datumRodenja between '1973-01-01' and '1974-01-01' and izdavac.aktivan=1;

SELECT b.naslov, d.naziv
FROM autor a 
INNER JOIN katalog b on a.sifra = b.autor 
INNER JOIN izdavac c on b.izdavac = c.sifra 
INNER JOIN mjesto d on b.mjesto = d.sifra
WHERE
a.datumrodenja between '1973-01-01' and '1974-01-01'
and c.aktivan=1;

select autor.sifra, autor.ime, autor.prezime
from autor inner join katalog on autor.sifra = katalog.autor
inner join mjesto on katalog.mjesto = mjesto.sifra
where autor.datumRodenja between '1970-01-01' and '1979-12-31' and mjesto.naziv like 'Z%';

select autor.sifra, autor.ime, autor.prezime, katalog.naslov, mjesto.naziv
from katalog inner join mjesto on katalog.mjesto = mjesto.sifra
inner join autor on katalog.autor = autor.sifra
where katalog.autor in (15187, 15331, 15411, 15605, 15698, 15817, 16011, 16292);

select naslov from katalog where autor=16292;