using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class ZadatciBrojevi2
    {

        public static void prveDvijeZnamenke(int x)
        {
            while (x >= 100)
            {
                x /= 10;
            }

            int y = x % 10;
            x /= 10;

            Console.WriteLine("Prva znamenka: {0} \nDruga znamenka: {1}", x, y);
        }


        public static void sudbinskiBroj()
        {
            int godina;
            int ostatak;
            int suma = 0;

            while (true)
            {
                Console.WriteLine("Unesite godinu rođenja: ");

                try
                {
                    godina = int.Parse(Console.ReadLine());

                    if (godina < 1000 || godina > 9999)
                    {
                        Console.WriteLine("Mora biti između 1000 i 9999");
                        continue;
                    } 
                    break;
                }
                catch
                {
                    Console.WriteLine("Neispravan unos");
                }
            } 

            while (godina >= 10)
            {
                ostatak = godina % 10;
                suma += ostatak;
                godina /= 10;

                if (godina < 10)
                {
                    suma += godina;
                    godina = suma;
                    suma = 0;
                }                
            }
            Console.WriteLine("Sudbinski broj: {0}", godina);
        }


        public static void zbrojKutova(int d1, int m1, int s1, int d2, int m2, int s2)
        {
            int d3, m3, s3;

            s3 = s1 + s2;
            m3 = m1 + m2;
            d3 = d1 + d2;

            if (s3 > 59)
            {
                m3 += 1;
                s3 -= 60;
            }

            if (m3 > 59)
            {
                d3 += 1;
                m3 -= 60;
            }

            Console.WriteLine("Stupnjevi: {0} \nMinute: {1} \nSekunde: {2}", d3, m3, s3);
        }


        public static void brojMolekula(int nH, int nS, int nO)
        {
            int H = nH / 2;
            int S = nS;
            int O = nO / 4;

            int min = Math.Min(H, S);
            int brojMolekula = Math.Min(min, O);

            Console.WriteLine("Broj molekula: {0}", brojMolekula);
        }


        public static void brojMolekula2(int nC, int nH, int nO)
        {
            int C = nC / 2;
            int H = nH / 6;
            int O = nO;

            int min = Math.Min(C, H);
            int brojMolekula = Math.Min(min, O);

            Console.WriteLine("Broj molekula: {0}", brojMolekula);
        }


        public static void random(int p, int m)
        {
            if (p > m)
            {
                Console.WriteLine("p je veće od m");
            }
            else
            {
                Console.WriteLine("p je manje ili jednako m");
            }
        }


        public static void pripadnostTocke(double x1, double y1, double x2, double y2, double r)
        {
            double d = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
            Console.WriteLine(d);

            if (d < r)
            {
                Console.WriteLine("Točka pripada krugu");
            }
            else
            {
                Console.WriteLine("Točka ne pripada krugu");
            }
        }


        public static void kvadratnaJednadzba(double a, double b, double c)
        {
            double x1 = (-b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
            double x2 = (-b - Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
           
            if (Double.IsNaN(x1) && Double.IsNaN(x2))
            {
                Console.WriteLine("Ne postoji rješenje");
               
            }
            else
            {
                Console.WriteLine("x1 = {0}, x2 = {1}", x1, x2);
                Console.WriteLine("x1: {0}", a * x1 * x1 + b * x1 + c);
                Console.WriteLine("x2: {0}", a * x2 * x2 + b * x2 + c);
            }
        }


        public static void precnikCijevi(double precnik, double tolerancija, double isporucen)
        {
            if (Math.Abs(isporucen - precnik) <= tolerancija)
            {
                Console.WriteLine("Prečnik odgovara standardu");
            }
            else
            {
                Console.WriteLine("Prečnik ne odgovara standardu");
            }
        }
    }
}
