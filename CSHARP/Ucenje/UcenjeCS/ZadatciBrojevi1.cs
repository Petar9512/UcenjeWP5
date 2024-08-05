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


        public static void povecanjeCijene(double cijena)
        {
            double cijenaPlusCarina = cijena * 1.1;
            double cijenaPlusPDV = cijenaPlusCarina * 1.2;
            double razlika = cijenaPlusPDV - cijena;

            Console.WriteLine("S carinom: {0} \nS PDVom: {1} \nUkupno povećanje: {2}", cijenaPlusCarina, cijenaPlusPDV, razlika);
        }


        public static void volumenLopte(double r)
        {
            double volumen = 4 / 3 * Math.Pow(r, 3) * Math.PI;

            Console.WriteLine(Math.Round(volumen, 2));
        }


        public static void Valjak(double r, double H)
        {
            double povrsina = 2 * r * Math.PI * (r + H);
            double volumen = Math.Pow(r, 2) * Math.PI * H;

            Console.WriteLine("Površina: {0} \nVolumen: {1}", Math.Round(povrsina, 3), Math.Round(volumen, 3));
        }


        public static void udaljenostTocaka(double x1, double y1, double x2, double y2)
        {
            double d = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));

            Console.WriteLine("Udaljenost: {0}", d);
        }


        public static void silaPrivlacenja(double m1, double m2, double r)
        {
            double gama = 6.67e-11;
            double F = gama * (m1 * m2) / (r * r);

            Console.WriteLine(F);
        }


        public static void silaPrivlacenja2(double x1, double y1, double m1, double x2, double y2, double m2)
        {
            double r = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
            double gama = 6.67e-11;
            double F = gama * (m1 * m2) / (r * r);

            Console.WriteLine(F);
        }


        public static void vrijednostFunkcije(double x, double y)
        {
            double funk1 = (Math.Min(x, y) + 0.5) / (1 + Math.Pow(Math.Min(x, y), 2));
            double funk2 = (Math.Min(x, y) + 0.5) / (1 + Math.Pow(Math.Max(x, y), 2));

            Console.WriteLine(funk1);
            Console.WriteLine(funk2);
        }


        public static void najveciBroj()
        {

            double x;
            double[] niz = new double[5];

            for (int i = 0; i < 5; i++)
            {
                while (true)
                {
                    Console.WriteLine("Unesite broj: ");

                    try
                    {
                        x = double.Parse(Console.ReadLine());
                        break;
                    }

                    catch
                    {
                        Console.WriteLine("Neispravan unos");
                    }
                }
                Console.WriteLine("\n{0}. broj: {1}", i + 1, x);
                niz[i] = x;
            }


            double maxBroj = niz[0];
            for (int i = 0; i < niz.Length; i++)
            {
                if (niz[i] > maxBroj)
                {
                    maxBroj = niz[i];
                }
            }

            Console.WriteLine("Najveći broj: {0}", maxBroj); 
        }


        public static void Racun(double x, double y)
        {
            double z = x * x + y * y + 1;
            double racun = 1 / ((-x / z) + (y / z)) * Math.Sqrt(z);

            Console.WriteLine(racun);
        }

    }
}
