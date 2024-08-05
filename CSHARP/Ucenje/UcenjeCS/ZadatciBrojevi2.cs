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
    }
}
