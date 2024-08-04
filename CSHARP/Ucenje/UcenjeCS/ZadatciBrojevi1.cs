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

    }
}
