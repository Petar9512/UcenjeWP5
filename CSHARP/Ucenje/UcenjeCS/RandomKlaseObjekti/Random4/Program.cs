using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.RandomKlaseObjekti.Random4
{
    internal class Program
    {

        public Program()
        {
            var r1 = new Razred(1, "3.A", 20);
            var r2 = new Razred(2, "3.B", 22);
            var r3 = new Razred(3, "3.C", 21);

            var u1 = new Ucenik(1, r3, "Pero", "Perić", "22679846557");
            var u2 = new Ucenik(2, r3, "Hajdi", "Hajdić", "68945762476");
            var u3 = new Ucenik(3, r2, "Ivan", "Ivić", "20906879351");
            var u4 = new Ucenik(4, r1, "Ivan", "Ivičević", "40078922682");
            var u5 = new Ucenik(5, r2, "Goran", "Grkić", "98074632514");

            var p1 = new Profesor(1, "Sonja", "Sonjić", "0912225554");
            var p2 = new Profesor(2, "Ivana", "Ivić", "0985557774");
            var p3 = new Profesor(3, "Petra", "Perić", "0982223331");

            Console.WriteLine(u3);
            Console.WriteLine(p1);


            var o1 = new Osoba(1, "Hajdi", "Hajdić", new DateOnly(1988, 3, 16), "0985557774");
            var o2 = new Osoba(2, "Ivan", "Ivić", new DateOnly(1980, 6, 10), "0913335554");
            var o3 = new Osoba(3, "Goran", "Grkić", new DateOnly(1972, 3, 4), "0985558884");
            var o4 = new Osoba(4, "Marko", "Markić", new DateOnly(1987, 5, 21), "0912225553");

            var t1 = new Trgovina(1, "Interspar", 20, "Supermarket", o4);
            var t2 = new Trgovina(2, "ZARA", 10, "Trgovina odjećom", o1);
            var t3 = new Trgovina(3, "Makromikro", 5, "Trgovina uredskim priborom", o2);
            var t4 = new Trgovina(4, "Emmezeta", 20, "Trgovina kućanskim aparatima i elektroničkom opremom", o3);

            var z1 = new Zaposlenik(o1, t2, new TimeOnly(7, 0, 0), new TimeOnly(14, 0, 0));
            var z2 = new Zaposlenik(o2, t3, new TimeOnly(8, 0, 0), new TimeOnly(15, 0, 0));
            var z3 = new Zaposlenik(o3, t4, new TimeOnly(7, 0, 0), new TimeOnly(14, 0, 0));
            var z4 = new Zaposlenik(o4, t1, new TimeOnly(7, 0, 0), new TimeOnly(14, 0, 0));

            var zaposlenici = new Zaposlenik[4];
            zaposlenici[0] = z1;
            zaposlenici[1] = z2;
            zaposlenici[2] = z3;
            zaposlenici[3] = z4;

            foreach (var z in zaposlenici)
            {
                Console.WriteLine(z);
            }


            var k1 = new Kategorija(1, "Jela s morskim plodovima");
            var k2 = new Kategorija(2, "Tjestenine");

            var j1 = new Jelo(1, k1, "Hobotnica", "hobotnica, krumpir, salata", 18.99);
            var j2 = new Jelo(2, k1, "Riblja plata", "6 vrsta ribe, krumpir, salata", 43.99);
            var j3 = new Jelo(3, k2, "Spaghetti bolognese", "spaghetti, umak", 9.99);

            var pi1 = new Pice() { Sifra = 1, Naziv = "Coca Cola", Cijena = 1.99 };
            var pi2 = new Pice() { Sifra = 2, Naziv = "Sok od naranče", Cijena = 1.99 };
            var pi3 = new Pice() { Sifra = 3, Naziv = "Vino", Cijena = 4.99 };

            var jela = new Jelo[3];
            jela[0] = j1;
            jela[1] = j2;
            jela[2] = j3;

            foreach (var j in jela)
            {
                Console.WriteLine(j);
            }
            Console.WriteLine(pi2);


            var d1 = new Djelatnik(1, "Marko", "Markić", "87661143564");
            var d2 = new Djelatnik(2, "Ivan", "Ivić", "38798698453");
            var d3 = new Djelatnik(3, "Goran", "Grkić", "24377895643");

            var pro1 = new Proizvod(1, d2, "Stolica", "obična stolica");
            var pro2 = new Proizvod(2, d2, "Stolna lampa", "aluminijska stolna lampa");
            var pro3 = new Proizvod(3, d1, "Televizor", "televizor 80x50");

            var s1 = new Sirovina(1, "Prerađeno drvo", "drvo", "50kg");
            var s2 = new Sirovina(2, "Prerađeno željezo", "željezo", "20kg");
            var s3 = new Sirovina(3, "Aluminij", "aluminij", "20kg");
            var s4 = new Sirovina(4, "Plastika", "plastika", "30kg");

            var proizvodi = new Proizvod[3];
            proizvodi[0] = pro1;
            proizvodi[1] = pro2;
            proizvodi[2] = pro3;

            foreach (var p in proizvodi)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine(s3);
        }
    }
}
