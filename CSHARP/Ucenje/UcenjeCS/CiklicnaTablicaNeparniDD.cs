using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class CiklicnaTablicaNeparniDD
    {

        public static void Izvedi()
        {
            int x;
            int y1;

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


            while (true)
            {
                Console.WriteLine("Unesite smjer tablice: \n 1 - smjer kazaljke na satu \n 2 - suprotno od kazaljke");

                try
                {
                    y1 = int.Parse(Console.ReadLine());

                    if (y1 != 1 && y1 != 2)
                    {
                        Console.WriteLine("Niste unijeli 1 ili 2 za smjer tablice");
                        continue;
                    }
                    break;                       
                }
                catch
                {
                    Console.WriteLine("Niste unijeli smjer");
                }
            }

            switch (y1)
            {
                case 1:
                    NeparniDDC(x);
                    break;
                case 2:
                    NeparniDDAC(x);
                    break;
            }
        }

        public static void NeparniDDC(int x)
        {
           
            int y = x * x;

            int[,] tablica = new int[x, x];
            int m = x / 2;
            int k = 0;

            int brojOkretaja = x / 2;
            tablica[m, m] = y--;



            for (int a = brojOkretaja; a > 0; a--)
            {
                for (int i = m + k; i > m - 2 - k; i--)
                {
                    for (int j = m + 1 + k; j > m + k; j--)
                    {
                        tablica[i, j] = y--;
                    }
                }
                for (int i = m - 1 - k; i > m - 2 - k; i--)
                {
                    for (int j = m + k; j > m - 2 - k; j--)
                    {
                        tablica[i, j] = y--;
                    }
                }
                for (int i = m - k; i < m + 2 + k; i++)
                {
                    for (int j = m - 1 - k; j > m - 2 - k; j--)
                    {
                        tablica[i, j] = y--;
                    }
                }
                for (int i = m + 1 + k; i > m + k; i--)
                {
                    for (int j = m - k; j < m + 2 + k; j++)
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
                    Console.Write(tablica[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }


        public static void NeparniDDAC(int x)
        {
            int y = x * x;
            int[,] tablica = new int[x, x];
            int m = x / 2;
            int k = 0;

            int brojOkretaja = x / 2;
            tablica[m, m] = y--;



            for (int a = brojOkretaja; a > 0; a--)
            {
                for (int i = m+1+k; i > m+k; i--)
                {
                    for (int j = m+k; j > m-2-k; j--)
                    {
                        tablica[i, j] = y--;
                    }
                }
                for (int i = m+k; i > m-2-k; i--)
                {
                    for (int j = m-1-k; j > m-2-k; j--)
                    {
                        tablica[i, j] = y--;
                    }
                }
                for (int i = m-1-k; i > m-2-k; i--)
                {
                    for ( int j = m-k; j < m+2+k; j++)
                    {
                        tablica[i, j] = y--;
                    }
                }
                for (int i = m-k; i < m+2+k; i++)
                {
                    for (int j = m+1+k; j > m+k; j--)
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
                    Console.Write(tablica[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

    }
}
