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
        }
    }
}
