using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E10TryCatch
    {

        public static void Izvedi()
        {

            int broj;

            while (true)
            {
                Console.Write("Upišite broj: ");

                try
                {
                    broj = int.Parse(Console.ReadLine());
                    if (broj <= 0 || broj > 1000)
                    {
                        Console.WriteLine("Broj mora biti između 1 i 1000");
                        continue;
                    }
                    break;
                }
                catch
                {
                    Console.WriteLine("Niste unijeli broj");
                }
            }
            Console.WriteLine("Unijeli ste {0}", broj);


            string ime;

            do
            {
                Console.Write("Unesite ime: ");
                ime = Console.ReadLine().Trim();
                if (ime.Length == 0)
                {
                    Console.WriteLine("Niste unijeli ime");
                    continue;
                }
                break;
            } while (true);

            Console.WriteLine("Unijeli ste >{0}<", ime);
        }

    }
}
