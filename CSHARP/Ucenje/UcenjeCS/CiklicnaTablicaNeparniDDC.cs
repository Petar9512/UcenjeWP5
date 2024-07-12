using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class CiklicnaTablicaNeparniDDC
    {

        public static void Izvedi()
        {

            int x;

            while (true)
            {
                Console.WriteLine("Unesite neparni broj veći od nule: ");

                try
                {
                    x = int.Parse(Console.ReadLine());

                    if (x < 0)
                    {
                        Console.WriteLine("Broj mora biti veći od nule");
                        continue;
                    }

                    if (x % 2 == 0)
                    {
                        Console.WriteLine("Broj mora biti neparan");
                        continue;
                    }
                    break;
                }
                catch
                {
                    Console.WriteLine("Niste unijeli broj");
                }
            }


            int y = x * x;

            int[,] tablica = new int[x, x];
            int m = x / 2;
            int k = 0;

            int brojOkretaja = x / 2;
            tablica[m, m] = y--;
            


            for (int a = brojOkretaja; a > 0; a--)
            {
                for (int i = m+k; i > m-2-k; i--)
                {
                    for (int j = m+1+k; j > m+k; j--)
                    {
                        tablica[i, j] = y--;
                    }
                }
                for (int i = m-1-k; i > m-2-k; i--)
                {
                    for (int j = m+k; j > m-2-k; j--)
                    {
                        tablica[i, j] = y--;
                    }
                }
                for (int i = m-k; i < m+2+k; i++)
                {
                    for (int j = m-1-k; j > m-2-k; j--)
                    {
                        tablica[i, j] = y--;
                    }
                }
                for (int i = m+1+k; i > m+k; i--)
                {
                    for (int j = m-k; j < m+2+k; j++)
                    {
                        tablica[i, j] = y--;
                    }
                }
                ++k;
            }

            Console.WriteLine();

            for (int i = 0; i < tablica.GetLength(0); i++)
            {
                for (int j = 0; j < tablica.GetLength(1); j++)
                {
                    Console.Write(tablica[i,j] + "\t");
                }
                Console.WriteLine();
            }
        }



    }
}
