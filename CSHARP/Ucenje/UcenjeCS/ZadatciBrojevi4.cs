using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class ZadatciBrojevi4
    {
        public static void cetveroznamenkastiBrojevi()
        {

            for (int i = 1000; i < 10000; i++)
            {
                int k = i;
                int zbroj = 0;
                int produkt = 1;
                
                while (k >= 100)
                {
                    zbroj += k % 10;
                    produkt *= k % 10;
                    k /= 10;
                }
                zbroj += k % 10;
                zbroj += k / 10;
                produkt *= k % 10;
                produkt *= k / 10;
                
                if (zbroj * zbroj == produkt)
                {
                    Console.WriteLine(i);
                }
            }
        }


        public static void mathRandom1(int k)
        {
            int n = k + 1;

            while(true)
            {
                if (n % 2 == 0 && (n + 1) % 3 == 0 && (n + 2) % 5 == 0 && (n + 3) % 7 == 0)
                {
                    Console.WriteLine(n);
                    break;
                }
                n++;
            }
        }


        public static void najveciBroj()
        {
            string input;
            int broj;
            int max = Int32.MinValue;

            while (true)
            {
                Console.WriteLine("Unesite broj ili KRAJ: ");
                input = Console.ReadLine();

                if (input == "KRAJ")
                {
                    break;
                }

                try
                {
                    broj = int.Parse(input);
                    
                    if (broj > max)
                    {
                        max = broj;
                    }
                }
                catch
                {
                    Console.WriteLine("Nepravilan unos");
                }
            }
            Console.WriteLine(max);
        }


        public static void planinskiVrhovi()
        {
            string input;
            int visina;
            int min = Int32.MaxValue;
            int max = Int32.MinValue;

            while (true)
            {
                Console.WriteLine("Unesite visinu ili KRAJ: ");
                input = Console.ReadLine();

                if (input == "KRAJ")
                {
                    break;
                }

                try
                {
                    visina = int.Parse(input);

                    if (visina > max)
                    {
                        max = visina;
                    }
                    if (visina < min)
                    {
                        min = visina;
                    }
                }
                catch
                {
                    Console.WriteLine("Nepravilan unos");
                }
            }
            Console.WriteLine("Razlika u visini najvišeg i najnižeg vrha: {0}m", max - min);
        }


        public static void Intervali()
        {
            string input;
            int A;
            int B;
            int min = Int32.MaxValue;
            int max = Int32.MinValue;

            while (true)
            {
                Console.WriteLine("Unesite koordinatu a ili KRAJ: ");
                input = Console.ReadLine();

                if (input == "KRAJ")
                {
                    break;
                }

                try
                {
                    A = int.Parse(input);

                    if (A < min)
                    {
                        min = A;
                    }
                    if (A > max)
                    {
                        max = A;
                    }
                }
                catch
                {
                    Console.WriteLine("Nepravilan unos");
                    continue;
                }

                while (true)
                {
                    Console.WriteLine("Unesite koordinatu b: ");

                    try
                    {
                        B = int.Parse(Console.ReadLine());

                        if (B < min)
                        {
                            min = B;
                        }
                        if (B > max)
                        {
                            max = B;
                        }
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Nepravilan unos");
                    }
                }               
            }
            Console.WriteLine("a: {0}, b: {1}", min, max);
        }


        public static void stanjeNaRacunu(double n)
        {
            string input;
            double iznos;

            while (true)
            {
                Console.WriteLine("Unesite iznos uplate/isplate (zarez označava decimalnu točku) ili KRAJ: ");
                input = Console.ReadLine();

                if (input == "KRAJ")
                {
                    break;
                }

                try
                {
                    iznos = double.Parse(input);
                    
                    if (n + iznos >= 0)
                    {
                        n += iznos;
                    }
                    else
                    {
                        Console.WriteLine("Transakcija poništena - nedovoljna vrijednost na računu");
                        continue;
                    }
                }
                catch
                {
                    Console.WriteLine("Nepravilan unos");
                }
            }
            Console.WriteLine("Novo stanje na računu: {0}", n);
        }
    }
}
