using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class EZadatci
    {

        public static void Izvedi()
        {

            int x, y;

            while (true)
            {
                Console.WriteLine("Unesite broj: ");

                try
                {
                    x = int.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Niste unijeli broj");
                }
            }

            Console.WriteLine();

            while (true)
            {
                Console.WriteLine("Unesite drugi broj: ");

                try
                {
                    y = int.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Niste unijeli broj");
                }
            }
            Console.WriteLine();
            Console.WriteLine(x + y);
            Console.WriteLine();


            int k;

            while (true)
            {
                Console.WriteLine("Unesite dvoznamenkasti broj: ");

                try
                {
                    k = int.Parse(Console.ReadLine());
                    if (k < 10 || k > 99)
                    {
                        Console.WriteLine("Broj mora biti dvoznamenkast");
                        Console.WriteLine();
                        continue;
                    }
                    break;
                }
                catch
                {
                    Console.WriteLine("Niste unijeli broj");
                    Console.WriteLine();
                }
            }
           
            Console.WriteLine(k.ToString()[0]);


            string grad;
            int broj;

            while (true)
            {
                Console.WriteLine("Unesite ime grada: ");

                try
                {
                    grad = Console.ReadLine().Trim();

                    for ( int i = 0; i < grad.Length; i++)
                    {
                        if (!Char.IsLetterOrDigit(grad[i]) || Char.IsDigit(grad[i]))
                        {
                            grad = "";
                        }
                    }

                    if (grad.Length == 0)
                    {
                        Console.WriteLine("grad mora sadržavati samo slova");
                        continue;
                    }
                    break;
                }
              catch
                {
                    Console.WriteLine("niste unijeli grad");
                }
            }

            while (true)
            {
                Console.WriteLine("Unesite broj stanovnika: ");

                try
                {
                    broj = int.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Niste unijeli broj");
                }
            }

            Console.WriteLine("U {0}u živi {1} ljudi", grad, broj);
        }

    }
}
