using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class ZadatciBrojevi3
    {

        public static void duljinaSkoka(string a1, string a2, string a3, double s11, double s12, double s13, double s21, double s22, double s23, double s31, double s32, double s33)
        {
            double najduljiSkok1;
            double najduljiSkok2;
            double najduljiSkok3;
            double najduljiSkok;

            if (s11 > s12)
            {
                najduljiSkok1 = Math.Max(s11, s13);
            }
            else
            {
                najduljiSkok1 = Math.Max(s12, s13);
            }

            if (s21 > s22)
            {
                najduljiSkok2 = Math.Max(s21, s23);
            }
            else
            {
                najduljiSkok2 = Math.Max(s22, s23);
            }

            if (s31 > s32)
            {
                najduljiSkok3 = Math.Max(s31, s33);
            }
            else
            {
                najduljiSkok3 = Math.Max(s32, s33);
            }


            if (najduljiSkok1 > najduljiSkok2 && najduljiSkok1 > najduljiSkok3)
            {
                najduljiSkok = najduljiSkok1;
                Console.WriteLine("Najdulji skok: {0}, {1}", a1, najduljiSkok);
            }
            else if (najduljiSkok2 > najduljiSkok1 && najduljiSkok2 > najduljiSkok3)
            {
                najduljiSkok = najduljiSkok2;
                Console.WriteLine("Najdulji skok: {0}, {1}", a2, najduljiSkok);
            }
            else if (najduljiSkok3 > najduljiSkok1 && najduljiSkok3 > najduljiSkok2)
            {
                najduljiSkok = najduljiSkok3;
                Console.WriteLine("Najdulji skok: {0}, {1}", a3, najduljiSkok);
            }
            else
            {
                Console.WriteLine("Izjednačenje");
            }            
        }


        public static void najisplativijaCokolada(string v1, double m1, double c1, string v2, double m2, double c2, string v3, double m3, double c3)
        {
            double omjer1 = m1 / c1;
            double omjer2 = m2 / c2;
            double omjer3 = m3 / c3;

            if (omjer1 > omjer2 && omjer1 > omjer3)
            {
                Console.WriteLine("Najisplativija je {0}", v1);
            }
            else if (omjer2 > omjer1 && omjer2 > omjer3)
            {
                Console.WriteLine("Najisplativija je {0}", v2);
            }
            else if (omjer3 > omjer1 && omjer3 > omjer2)
            {
                Console.WriteLine("Najisplativija je {0}", v3);
            }
        }


        public static void najisplativijeGorivo(string g1, double p1, double c1, string g2, double p2, double c2, string g3, double p3, double c3)
        {
            double omjer1 = p1 / c1;
            double omjer2 = p2 / c2;
            double omjer3 = p3 / c3;

            if (omjer1 > omjer2 && omjer1 > omjer3)
            {
                Console.WriteLine("Najekonomičnije je {0}", g1);
            }
            else if (omjer2 > omjer1 && omjer2 > omjer3)
            {
                Console.WriteLine("Najekonomičnije je {0}", g2);
            }
            else if (omjer3 > omjer1 && omjer3 > omjer2)
            {
                Console.WriteLine("Najekonomičnije je {0}", g3);
            }
        }


        public static void dimenzijePloce(double d1, double d2, double isp1, double isp2)
        {
            double odstupanje1 = d1 * 0.01;
            double odstupanje2 = d2 * 0.01;

            if (Math.Abs(isp1 - d1) <= odstupanje1 && Math.Abs(isp2 - d2) <= odstupanje2)
            {
                Console.WriteLine("Dimenzije su ok");
            }
            else
            {
                Console.WriteLine("Preveliko odstupanje");
            }
        }


        public static void provjeraDatuma(int d, int m, int g)
        {
            if (g < 1582 || g > 9999 || m < 1 || m > 12 || d < 1 || d > 31)
            {
                Console.WriteLine("Netočan datum");
            }
            else if (m == 2 && d > 28 && g % 4 != 0)
            {
                Console.WriteLine("Netočan datum");
            }
            else if (m == 2 && d > 29)
            {
                Console.WriteLine("Netočan datum");
            }
            else if (m == 4 || m == 6 || m == 9 || m == 11 && d > 30)
            {
                Console.WriteLine("Netočan datum");
            }
            else
            {
                Console.WriteLine("Točan datum");
            }
        }


        public static void redniBrojDana(int d, int m, int g)
        {
            int broj = 0;

            if (m == 1)
            {
                broj = d;
            }
            else if (m == 2)
            {
                broj = d + 31;
            }
            else if (m == 3)
            {
                broj = d + 59;
            }
            else if ( m == 4)
            {
                broj = d + 90;
            }
            else if (m == 5)
            {
                broj = d + 120;
            }
            else if (m == 6)
            {
                broj = d + 151;
            }
            else if (m == 7)
            {
                broj = d + 181;
            }
            else if (m == 8)
            {
                broj = d + 212;
            }
            else if (m == 9)
            {
                broj = d + 243;
            }
            else if (m == 10)
            {
                broj = d + 273;
            }
            else if (m == 11)
            {
                broj = d + 304;
            }
            else if (m == 12)
            {
                broj = d + 334;
            }

            if (g % 4 == 0 && m > 2)
            {
                broj += 1;
            }

            Console.WriteLine("Redni broj dana u godini: {0}", broj);
        }


        public static void danUGodini(int n, int g)
        {
            int brojDana = 365; 

            if (g % 4 == 0)
            {
                brojDana += 1;
            }

            int m = 12;
            int d = 31 - (brojDana - n);

            if (n <= 31)
            {
                m = 1;
                d = 31 - (31 - n);
            }
            else if (n <= brojDana - 306)
            {
                m = 2;
                if (g % 4 == 0)
                {
                    d = 29 - (brojDana - 306 - n);
                }
                else
                {
                    d = 28 - (brojDana - 306 - n);
                }                
            }
            else if (n <= brojDana - 275)
            {
                m = 3;
                d = 31 - (brojDana - 275 - n);
            }
            else if (n <= brojDana - 245)
            {
                m = 4;
                d = 30 - (brojDana - 245 - n);
            }
            else if (n <= brojDana - 214)
            {
                m = 5;
                d = 31 - (brojDana - 214 - n);
            }
            else if (n <= brojDana - 184)
            {
                m = 6;
                d = 30 - (brojDana - 184 - n);
            }
            else if (n <= brojDana - 153)
            {
                m = 7;
                d = 31 - (brojDana - 153 - n);
            }
            else if (n <= brojDana - 122)
            {
                m = 8;
                d = 31 - (brojDana - 122 - n);
            }
            else if (n <= brojDana - 92)
            {
                m = 9;
                d = 3 - (brojDana - 92 - n);
            }
            else if (n <= brojDana - 61)
            {
                m = 10;
                d = 31 - (brojDana - 61 - n);
            }
            else if (n <= brojDana - 31) 
            {
                m = 11;
                d = 30 - (brojDana - 31 - n);
            }
            
            Console.WriteLine("Mjesec: {0}, Dan: {1}", m, d);
        }


        public static void prijestupnaGodinaMilankovic(int g)
        {
            int brojVjekova = g / 100;
            int ostatak = brojVjekova % 9;

            if (g % 4 == 0 && g % 100 != 0)
            {
                Console.WriteLine("Prijestupna godina");
            }

            else if (g % 100 == 0 && (ostatak == 2 || ostatak == 6))
            {
                Console.WriteLine("Prijestupna godina");
            }

            else
            {
                Console.WriteLine("Godina nije prijestupna");
            }
        }


        public static void sviPozitivniDjelitelji(int n)
        {
            for (int i = n; i > 0; i--)
            {

                if (n % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }


        public static void randomMath(int d, int n)
        {
            while (n >= 10)
            {
                int zbroj = 0;
                int k = n;

                zbroj += k % 10;
                k /= 10;
                zbroj += k % 10;

                if (zbroj == d)
                {
                    Console.WriteLine(n);
                }
                n--;
            }           
        }


        public static void stranicePravokutnika(int p)
        {
            for (int a = p; a > 0; a--)
            {
                for (int b = a; b > 0; b--)
                {
                    if (a * b == p)
                    {
                        int opseg = 2 * a + 2 * b;
                        Console.WriteLine("a: {0}, b: {1}, opseg: {2}", a, b, opseg);
                    }                    
                }
            }
        }


        public static void mathRandom2(int n)
        {
            int k = 0;

               while (Math.Pow(2, k) <= n)
               {
                   ++k;
               }
               k--;

            Console.WriteLine("{0}, {1}", k, Math.Pow(2, k));
        }


        public static void mathRandom3(double m, double n, int k)
        {
            Console.WriteLine(Math.Round(m / n, k));
        }
    }
}
