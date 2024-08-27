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


            var s1 = new Student(1, "Marko", "Markić", "55476834587", new DateOnly(1999, 7, 31), "Germanistika");
            var s2 = new Student(2, "Hajdi", "Hajdić", "91436778453", new DateOnly(2000, 1, 16), "Kroatistika");
            var s3 = new Student(3, "Ivan", "Ivić", "35499872335", new DateOnly(2002, 3, 21), "Talijanistika");

            var is1 = new IspitniRok(1, "Jezične vježbe 1", "pismeni", new DateTime(2024, 7, 7, 10, 0, 0));
            var is2 = new IspitniRok(2, "Uvod u lingvistiku", "pismeni", new DateTime(2024, 6, 28, 13, 0, 0));
            var is3 = new IspitniRok(3, "Staroslavenski jezik", "pismeni", new DateTime(2024, 6, 30, 12, 0, 0));
            var is4 = new IspitniRok(4, "Fonetika", "usmeni", new DateTime(2024, 7, 2, 10, 0, 0));
            var is5 = new IspitniRok(5, "Jezične vježbe 2", "pismeni", new DateTime(2024, 7, 7, 14, 0, 0));

            Console.WriteLine(s2);
            Console.WriteLine(is4);


            var u1 = new Uciteljica(1, "Sonja", "Sonjić", new DateOnly(1980, 6, 10), "0915558887");
            var u2 = new Uciteljica(2, "Hajdi", "Hajdić", new DateOnly(1988, 3, 7), "0912225556");
            var u3 = new Uciteljica(3, "Ivana", "Ivić", new DateOnly(1968, 10, 27), "0984445553");

            var r1 = new Radionica(1, "Izrada božićnih ukrasa", new DateTime(2024, 12, 5, 14, 0, 0), 20, u2);
            var r2 = new Radionica(2, "Vrtna radionica", new DateTime(2024, 5, 10, 9, 0, 0), 10, u3);
            var r3 = new Radionica(3, "Informatička radionica", new DateTime(2024, 4, 22, 10, 0, 0), 15, u2);

            var dij1 = new Dijete(1, "Ivan", "Ivičević", new DateOnly(2009, 11, 22), "3.A");
            var dij2 = new Dijete(2, "Pero", "Perić", new DateOnly(2010, 2, 6), "3.B");
            var dij3 = new Dijete(3, "Goran", "Grkić", new DateOnly(2010, 1, 21), "3.A");
            var dij4 = new Dijete(4, "Marko", "Markić", new DateOnly(2008, 9, 17), "4.A");
            var dij5 = new Dijete(5, "Ivan", "Ivić", new DateOnly(2008, 10, 10), "4.C");

            var sud1 = new Sudionik(dij1, r3, new DateOnly(2024, 4, 24));
            var sud2 = new Sudionik(dij1, r2, new DateOnly(2024, 5, 10));
            var sud3 = new Sudionik(dij3, r3, new DateOnly(2024, 4, 22));
            var sud4 = new Sudionik(dij2, r1, new DateOnly(2024, 12, 8));
            var sud5 = new Sudionik(dij4, r1, new DateOnly(2024, 12, 6));

            var sudionici = new Sudionik[5];
            sudionici[0] = sud1;
            sudionici[1] = sud2;
            sudionici[2] = sud3;
            sudionici[3] = sud4;
            sudionici[4] = sud5;

            foreach (var s in sudionici)
            {
                Console.WriteLine(s);
            }
        }
    }
}
