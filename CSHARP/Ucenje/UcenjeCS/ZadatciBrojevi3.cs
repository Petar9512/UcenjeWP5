using System;
using System.Collections.Generic;
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
    }
}
