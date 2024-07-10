using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E11Metode
    {

        public static void Izvedi()
        {

            int broj = 10;
            Metoda1(broj);
            Metoda1("Dubrovnik");
            Metoda1("Dubrovnik", 20000);
            Console.WriteLine(Metoda2());

            Console.WriteLine(SlucajniBroj());
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(SlucajnaRijec());
            }

            Console.WriteLine(SumaBrojeva(50,80));
            Console.WriteLine(SumaBrojeva(85,60));
            int[] brojevi = { 5, 4, 8, 5, 12, 7, 5 };
            Console.WriteLine(SumaBrojeva(brojevi));

            int r = UcitajCijeliBroj("Unesite broj redova", 2, 50);
            int s = UcitajCijeliBroj("Unesite broj stupaca", 2, 50);

        }


        private static void Metoda1(int x)
        {
            Console.WriteLine("Parametar {0}", x);
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine(i);
            }
        }

        private static void Metoda1(string ime)
        {
            Console.WriteLine("string vrijednost {0}", ime);
        }

        private static void Metoda1(string ime, int x)
        {
            Console.WriteLine("Parametri {0} i {1}", ime, x);
        }

        static int Metoda2()
        {
            Console.WriteLine("metoda 2");
            return int.MaxValue;
        }

        static int SlucajniBroj()
        {
            return new Random().Next();
        }

        static string SlucajnaRijec()
        {
            char[] niz = new char[8];
            var r = new Random();
            for (int i = 0; i < niz.Length; i++)
            {
                niz[i] = (char)r.Next();
            }
            return string.Join("", niz);
        }

        private static int SumaBrojeva(int a, int b)
        {
            int suma = 0;
            int min = a < b ? a : b;
            int max = a > b ? a : b;
            for ( int i = min; i <= max; i++)
            {
                suma += i;
            }
            return suma;
        }

        private static int SumaBrojeva(int[] niz)
        {
            var suma = 0;
            foreach (var b in niz)
            {
                suma += b;
            }
            return suma;
        }

        public static int UcitajCijeliBroj(string poruka="Unesite broj: ", int min=0, int max=1000)
        {
            int broj = 0;

            while (true)
            {
                Console.WriteLine(poruka);

                try
                {
                    broj = int.Parse(Console.ReadLine());
                    if (broj < min || broj > max)
                    {
                        Console.WriteLine("Broj mora biti između {0} i {1}", min, max);
                        continue;
                    }
                    return broj;
                }
                catch
                {
                    Console.WriteLine("Niste unijeli broj");
                }
            }
        }
    }
}
