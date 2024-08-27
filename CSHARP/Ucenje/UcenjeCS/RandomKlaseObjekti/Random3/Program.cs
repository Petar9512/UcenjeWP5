using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.RandomKlaseObjekti.Random3
{
    internal class Program
    {

        public Program()
        {
            var k1 = new Korisnik(1, "Ivan", "Ivić", "0987775556");
            var k2 = new Korisnik(2, "Goran", "Grgić", "0957778887");
            var k3 = new Korisnik(3, "Hajdi", "Hajdić", "0913332224");
            var k4 = new Korisnik(4, "Ivan", "Ivičević", "0914443335");

            var o1 = new Obuca(1, k4, "jedan par cipela", "42");
            var o2 = new Obuca(2, k4, "jedan par sandala", "42");
            var o3 = new Obuca(3, k3, "desna čizma", "30");
            var o4 = new Obuca(4, k2, "jedan par cipela", "43");
            var o5 = new Obuca(5, k2, "jedan par papuča", "43");

            var p1 = new Popravak(1, k4, "jedan par cipela i jedan par sandala");
            var p2 = new Popravak(2, k2, "jedan par cipela i jedan par papuča");
            var p3 = new Popravak(3, k3, "desna čizma");

            var po1 = new PopravakObuce(p1, o2, new DateTime(2024, 6, 1, 10, 0, 0), "popravio desnu sandalu", 5.50, false);
            var po2 = new PopravakObuce(p1, o2, new DateTime(2024, 6, 1, 17, 25, 0), "popravio lijevu sandalu", 5.50, false);
            var po3 = new PopravakObuce(p2, o5, new DateTime(2024, 6, 3, 9, 0, 0), "popravio papuče", 10.00, true);
            var po4 = new PopravakObuce(p2, o4, new DateTime(2024, 6, 4, 10, 20, 0), "popravio cipele", 12.00, true);

            var popravci = new PopravakObuce[4];
            popravci[0] = po1;
            popravci[1] = po2;
            popravci[2] = po3;
            popravci[3] = po4;

            foreach (var p in popravci)
            {
                Console.WriteLine(p);
            }


            var pc1 = new Pacijent(1, "Ivan", "Ivičević", 33, "prehlada");
            var pc2 = new Pacijent(2, "Goran", "Grkić", 43, "upala grla");
            var pc3 = new Pacijent(3, "Marko", "Markić", 38, "gastritis");
            var pc4 = new Pacijent(4, "Ivan", "Ivičević", 33, "gastritis");

            var l1 = new Lijecenje(pc1, "sirup za kašalj", new DateOnly(2024, 3, 1), new DateOnly(2024, 3, 8));
            var l2 = new Lijecenje(pc2, "sirup za kašalj", new DateOnly(2024, 3, 20), new DateOnly(2024, 3, 25));
            var l3 = new Lijecenje(pc3, "antiobiotik", new DateOnly(2024, 4, 10), new DateOnly(2024, 4, 15));
            var l4 = new Lijecenje(pc4, "antiobiotik", new DateOnly(2024, 5, 22), new DateOnly(2024, 5, 29));

            var lijecenja = new Lijecenje[4];
            lijecenja[0] = l1;
            lijecenja[1] = l2;
            lijecenja[2] = l3;
            lijecenja[3] = l4;

            foreach (var l in lijecenja)
            {
                Console.WriteLine(l);
            }
        }

    }
}
