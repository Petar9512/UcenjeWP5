using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.KonzolnaAplikacija
{
    internal class Pomocno
    {

        public static bool DEV = false;

        public static string UcitajString(string poruka, int max, bool b)
        {
            string s;
            while (true)
            {
                Console.WriteLine(poruka);
                s = Console.ReadLine().Trim();
                if ((b && s.Length == 0) || s.Length > max)
                {
                    Console.WriteLine("Obavezan unos, maksimalan broj znakova - {0}", max);
                    continue;
                }
                return s;
            }
        }

        public static string UcitajString(string stari, string poruka, int max, bool b)
        {
            string s;
            while (true)
            {
                Console.WriteLine(poruka + " (" + stari + ") ");
                s = Console.ReadLine().Trim();
                if (s.Length == 0)
                {
                    return stari;
                }
                if ((b && s.Length == 0) || s.Length > max)
                {
                    Console.WriteLine("Obavezan unos, maksimalan broj znakova {0}", max);
                    continue;
                }
                return s;
            }
        }

        public static int UcitajRasponBroja(string poruka, int min, int max)
        {
            int broj;
            while (true)
            {
                Console.WriteLine(poruka);
                try
                {
                    broj = int.Parse(Console.ReadLine());
                    if (broj < min || broj > max)
                    {
                        Console.WriteLine("Broj mora biti u rasponu od {0} do {1}", min, max);
                        continue;
                    }
                    return broj;
                }
                catch
                {
                    Console.WriteLine("Morate unijeti broj");
                }
            }
        }

        public static double UcitajDecimalniBroj(string poruka, int min, int max)
        {
            double broj;
            while (true)
            {
                Console.WriteLine(poruka);
                try
                {
                    broj = double.Parse(Console.ReadLine());
                    if (broj < min || broj > max)
                    {
                        Console.WriteLine("Broj mora biti u rasponu od {0} do {1}", min, max);
                        continue;
                    }
                    return broj;
                }
                catch
                {
                    Console.WriteLine("Morate unijeti broj");
                }
            }
        }

        public static DateTime UcitajDatum(bool kontrolaDatuma)
        {
            DateTime datum;
            while (true)
            {
                Console.WriteLine("Unesite datum (format unosa je yyyy-MM-dd H:mm:ss): ");
                if (kontrolaDatuma)
                {
                    Console.WriteLine("Datum ne smije biti prije današnjeg");
                }

                try
                {
                    datum = DateTime.Parse(Console.ReadLine());
                    if (kontrolaDatuma && datum < DateTime.Now)
                    {
                        Console.WriteLine("Datum ne smije biti prije današnjeg");
                    }
                    return datum;
                }
                catch
                {
                    Console.WriteLine("Morate unijeti ispravan datum");
                }
            }
        }

        public static bool UcitajBool(string poruka, string b)
        {
            Console.WriteLine(poruka);
            return Console.ReadLine().Trim().ToLower() == b;
        }
    }
}
