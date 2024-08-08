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
            double x1 = Math.Round((-b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a), 2);
            double x2 = Math.Round((-b - Math.Sqrt(b * b - 4 * a * c)) / (2 * a), 2);


            if (b*b - 4*a*c < 0)
            {
                Console.WriteLine("Rješenja nisu realna");
            }
            else if (b*b - 4*a*c == 0)
            {
                Console.WriteLine("Rješenja su jednaka: x1 = {0}. x2 = {1}", x1, x2);
            }
            else
            {
                Console.WriteLine("x1 = {0}, x2 = {1}", x1, x2);
            }
           
            
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


        public static void cijenaAutomobila(double pocetna, double prodano)
        {
            double maxOdstupanje = pocetna / 100 * 5;

            if (Math.Abs(prodano - pocetna) <= maxOdstupanje)
            {
                Console.WriteLine("Cijena je ok");
            }
            else
            {
                Console.WriteLine("Preveliko odstupanje od početne cijene");
            }
        }


        public static void cijenaCipela(double d, double c)
        {
            if (d >= c)
            {
                Console.WriteLine("Ima dovoljno novca za kupnju");
            }

            else if (d >= c * 0.9)
            {
                Console.WriteLine("Moći će ih kupiti ako sačeka sniženje");
            }

            else
            {
                Console.WriteLine("Nema dovoljno novca za kupnju");
            }                
        }


        public static void vrijednostFunkcije(int x)
        {
            int y;

            if (x < 0)
            {
                Console.WriteLine("x ne smije biti manji od 0");
            }

            else if (x % 2 == 0)
            {
                y = 0;
                Console.WriteLine("x: {0}, y: {1}", x, y);
            }

            else
            {
                y = 1;
                Console.WriteLine("x: {0}, y: {1}", x, y);
            }
        }


        public static void randomBrojevi(double a, double b)
        {
            double c;
            double d;

            if (a > b)
            {
                c = 1;
                d = 2;
            }
            else
            {
                c = 3;
                d = 4;
            }
            Console.WriteLine("{0}, {1}", c, d);
        }


        public static void BodyMassIndex(double t, double v)
        {
            double BMI = t / Math.Pow(v, 2);

            if (BMI < 18.5)
            {
                Console.WriteLine("Neuhranjenost");
            }
            else if (BMI < 25.0)
            {
                Console.WriteLine("Idealna težina");
            }
            else if (BMI < 30.0)
            {
                Console.WriteLine("Uvećana težina");
            }
            else
            {
                Console.WriteLine("Gojaznost");
            }
        }


        public static void isplataDnevnica(int h, double d)
        {
            int brojDnevnica = h / 24;
            int ostatak = h % 24;
            double kolicina = d * brojDnevnica;

            if (ostatak >= 12)
            {
                kolicina += d;
            }
            else if (ostatak >= 8)
            {
                kolicina += d / 2;
            }

            Console.WriteLine("Za isplatiti: {0}", kolicina);
        }


        public static void mjerenjeKutova(int d1, int m1, int s1, int d2, int m2, int s2)
        {
            if (d1 > d2)
            {
                Console.WriteLine("alfa > beta");
            }
            else if (d1 < d2)
            {
                Console.WriteLine("alfa < beta");
            }
            else if (s1 > s2)
            {
                Console.WriteLine("alfa > beta");
            }
            else if (s1 < s2)
            {
                Console.WriteLine("alfa < beta");
            }
            else if (m1 > m2)
            {
                Console.WriteLine("alfa > beta");
            }
            else if (m1 < m2)
            {
                Console.WriteLine("alfa < beta");
            }
            else
            {
                Console.WriteLine("alfa = beta");
            }

            int d3, m3, s3;

            d3 = d1 - d2;
            m3 = m1 - m2;
            s3 = s1 - s2;

            if (d3 > 0)
            {
                if (m3 < 0)
                {
                    d3 -= 1;
                    m3 = 60 - Math.Abs(m1 - m2);
                }

                if (s3 < 0)
                {
                    m3 -= 1;
                    s3 = 60 - Math.Abs(s1 - s2);
                }

                Console.WriteLine("stupnjevi: {0}, minute: {1}, sekunde: {2}", d3, m3, s3);
            }            
        }


        public static void iznosPoreza(double dgr, double ggr, double nks, double vks, double z)
        {
            double p = 0;

            if (z <= dgr)
            {
                p = 0;
            }
            else if (z > dgr && z <= ggr)
            {
                p = ((z - dgr) * nks) / 100;
            }
            else if (z > ggr)
            {
                p = ((ggr - dgr) * nks + (z - ggr) * vks) / 100;
            }

            Console.WriteLine("Iznos poreza: {0}", p);
        }
    }
}
