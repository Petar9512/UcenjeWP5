using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E15KlasaObjekt.fakultet
{
    internal class Program
    {

        public Program()
        {
            var anglistika = new Smjer(1, "Anglistika", 50);
            var germanistika = new Smjer(2, "Germanistika", 40);
            var talijanistika = new Smjer(3, "Talijanistika", 40);
            var kroatistika = new Smjer(4, "Kroatistika", 50);

            var smjerovi = new Smjer[4];
            smjerovi[0] = anglistika;
            smjerovi[1] = germanistika;
            smjerovi[2] = talijanistika;
            smjerovi[3] = kroatistika;

            Console.WriteLine("Smjerovi:\n");

            foreach (var smjer in smjerovi)
            {
                Console.WriteLine(smjer);
            }


            var kolegij1 = new Kolegij(1, anglistika, "Uvod u englesku književnost", "Ivan Ivić", true);
            var kolegij2 = new Kolegij()
            {
                Sifra = 2,
                Smjer = anglistika,
                Naziv = "Suvremeni engleski jezik",
                Obavezni = true
            };
            var kolegij3 = new Kolegij()
            {
                Sifra = 3,
                Smjer = germanistika,
                Naziv = "Jezične vježbe 1",
                Obavezni = true
            };
            var kolegij4 = new Kolegij()
            {
                Sifra = 4,
                Smjer = germanistika,
                Naziv = "Povijest njemačkog jezika",
                Obavezni = false
            };
            var kolegij5 = new Kolegij()
            {
                Sifra = 5,
                Smjer = talijanistika,
                Naziv = "Jezične vježbe 1",
                Obavezni = true
            };
            var kolegij6 = new Kolegij()
            {
                Sifra = 6,
                Smjer = kroatistika,
                Naziv = "Staroslavenski jezik",
                Obavezni = true
            };
            var kolegij7 = new Kolegij()
            {
                Sifra = 7,
                Smjer = kroatistika,
                Naziv = "Teorija jezika",
                Obavezni = true
            };

            var kolegiji = new Kolegij[7];
            kolegiji[0] = kolegij1;
            kolegiji[1] = kolegij2;
            kolegiji[2] = kolegij3;
            kolegiji[3] = kolegij4;
            kolegiji[4] = kolegij5;
            kolegiji[5] = kolegij6;
            kolegiji[6] = kolegij7;

            Console.WriteLine("\nKolegiji:\n");

            foreach (var kolegij in kolegiji)
            {
                Console.WriteLine(kolegij);
            }


            var s1 = new Student(1, kroatistika, "Ivan", "Ivić", "47457409385");
            var s2 = new Student(2, kroatistika, "Hajdi", "Hajdić", "15797970162");
            var s3 = new Student(3, anglistika, "Goran", "Grkić", "20437329240");
            var s4 = new Student(4, anglistika, "Marko", "Markić", "22353796851");
            var s5 = new Student(5, germanistika, "Ivan", "Ivičević", "24088017749");

            var studenti = new Student[5];
            studenti[0] = s1;
            studenti[1] = s2;
            studenti[2] = s3;
            studenti[3] = s4;
            studenti[4] = s5;

            Console.WriteLine("\nStudenti:\n");

            foreach (var student in studenti)
            {
                Console.WriteLine(student);
            }


            var isp1 = new IspitniRok(1, kolegij6, "pismeni", new DateTime(2024, 6, 10, 12, 0, 0));
            var isp2 = new IspitniRok(2, kolegij7, "usmeni", new DateTime(2024, 6, 14, 10, 0, 0));
            var isp3 = new IspitniRok(3, kolegij1, "pismeni", new DateTime(2024, 6, 10, 9, 0, 0));
            var isp4 = new IspitniRok(4, kolegij2, "pismeni", new DateTime(2024, 6, 12, 10, 30, 0));
            var isp5 = new IspitniRok(5, kolegij3, "pismeni", new DateTime(2024, 6, 17, 14, 0, 0));
            var isp6 = new IspitniRok(6, kolegij5, "pismeni", new DateTime(2024, 6, 18, 16, 0, 0));

            var rokovi = new IspitniRok[6];
            rokovi[0] = isp1;
            rokovi[1] = isp2;
            rokovi[2] = isp3;
            rokovi[3] = isp4;
            rokovi[4] = isp5;
            rokovi[5] = isp6;

            Console.WriteLine("\nIspitni rokovi:\n");

           foreach (var rok in rokovi)
            {
                Console.WriteLine(rok);
            }
        }
    }
}
