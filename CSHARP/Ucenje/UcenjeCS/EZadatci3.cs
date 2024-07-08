using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class EZadatci3
    {

        public static void Izvedi()
        {

            int x;
            int y;

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
            if (x < y)
            {
                for (int i = x + 1; i < y; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else if (x > y)
            {
                for (int i = x - 1; i > y; i--)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine("");
            }


            Console.WriteLine();
            int z;
            int suma = 0;

            while (true)
            {
                Console.WriteLine("Unesite broj: ");

                try
                {
                    z = int.Parse(Console.ReadLine());
                    if (z != -1)
                    {
                        suma += z;
                        continue;
                    }
                    else
                    {
                        suma += z;
                    }
                    break;
                }
                catch
                {
                    Console.WriteLine("Niste unijeli broj");
                }
            }

            Console.WriteLine();
            Console.WriteLine(suma);
        }

    }
}
