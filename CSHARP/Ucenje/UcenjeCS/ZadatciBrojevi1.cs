using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class ZadatciBrojevi1
    {

        public static void povrsinaKruga()
        {
            double r;
            double pi = 3.14;

            while (true)
            {
                Console.WriteLine("Unesite vrijednost polumjera: (zarez označava decimalnu točku)");

                try
                {
                    r = double.Parse(Console.ReadLine());
                    break;
                }
               
                catch
                {
                    Console.WriteLine("Neispravan unos");
                }                
            }

            double povrsina = r * r * pi;
            Console.WriteLine("Površina kruga je {0}", povrsina);
        }


        public static void povrsinaPravokutnika()
        {
            double a;
            double b;

            while (true)
            {
                Console.WriteLine("Unesite duljinu stranice a: ");

                try
                {
                    a = double.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Neispravan unos");
                }
            }

            while (true)
            {
                Console.WriteLine("Unesite duljinu stranice b: ");

                try
                {
                    b = double.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Neispravan unos");
                }
            }

            double opseg = 2 * a + 2 * b;
            double povrsina = a * b;

            Console.WriteLine("Opseg: {0} Površina: {1}", opseg, povrsina);
        }


        public static void Temperatura()
        {
            double gama = 1.8;
            double delta = 32;
            double tC;

            while (true)
            {
                Console.WriteLine("Unesite temperaturu u Celzijima: ");

                try
                {
                    tC = double.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Neispravan unos");
                }
            }

            double tF = Math.Round(gama * tC + delta, 2);
            Console.WriteLine("tC = {0}, tF = {1}", tC, tF);
        }


        public static void stolnjakTraka(double x)
        {
            double r = x / 2;
            double r2 = 3 * x / 2;
            double pi = 3.14;

            double povrsina1 = r * r * pi;
            double povrsina2 = r2 * r2 * pi;
            double duljinaTrake = Math.Round(povrsina1 + povrsina2, 3);

            Console.WriteLine(r);
            Console.WriteLine(r2);
            Console.WriteLine(povrsina1);
            Console.WriteLine(povrsina2);
            Console.WriteLine(duljinaTrake);
        }


        public static void futbalskiTeren(double d, double s)
        {
            double opseg = 2 * d + 2 * s;
            double prviTjedan = 10 * opseg;
            double ukupno1 = 7 * prviTjedan / 1000;
            double drugiTjedan = 20 * opseg;
            double ukupno2 = 7 * drugiTjedan / 1000;
            double treciTjedan = 30 * opseg;
            double ukupno3 = 7 * treciTjedan / 1000;

            Console.WriteLine("Prvi tjedan: {0} metara dnevno, ukupno {1}km \nDrugi tjedan: {2} metara dnevno, ukupno {3}km \nTreći tjedan: {4} metara dnevno, ukupno {5}km", prviTjedan, ukupno1, drugiTjedan, ukupno2, treciTjedan, ukupno3);
        }


        public static void cijenaBezPDVa(double cijena)
        {
            // cijena = cijenaBezPDVa + cijenaBezPDVa / 5
            double cijenaBezPDVa = cijena / 1.2;

            Console.WriteLine("Cijena: {0} \nCijena bez PDVa: {1}", cijena, cijenaBezPDVa);
        }


        public static void cijenaPantalona(double cijena, bool gotovina)
        {
            double cijenaNaSnizenju = Math.Round(cijena / 100 * 75, 2);
            double dodatnoSnizenje = Math.Round(cijenaNaSnizenju / 100 * 95, 2);

            if (gotovina)
            {
                Console.WriteLine("Cijena: {0}", dodatnoSnizenje);
            }
            else
            {
                Console.WriteLine("Cijena: {0}", cijenaNaSnizenju);
            }
        }

    }
}
