using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class CiklicnaTablicaNeparniBroj
    {

        public static void Izvedi()
        {

            Console.WriteLine("Unesite neparni broj: ");

            int x = int.Parse(Console.ReadLine());
            int y = x * x;

            int[,] tablica = new int[x, x];
            int m = x / 2;
            int k = 0;

            int brojOkretaja = x / 2;
            tablica[m, m] = y--;
            


            do
            {
                for (int i = m + k; i > m - (k + 2); i--)
                {
                    for (int j = m + (k + 1); j > m - (k + 1); j--)
                    {
                        tablica[i, j] = y--;
                    }
                }

                for (int i = m - (k + 1); i > m - (k + 2); i--)
                {
                    for (int j = m + k; j > m - (k + 2); j--)
                    {
                        tablica[i, j] = y--;
                    }
                }

                for (int i = m - k; i < m + (k + 2); i++)
                {
                    for (int j = m - (k + 1); j < m + k; j++)
                    {
                        tablica[i, j] = y--;
                    }
                }

                for (int i = m + (k + 1); i > m + k; i--)
                {
                    for (int j = m - k; j < m + (k + 2); j++)
                    {
                        tablica[i, j] = y--;
                    }


                    brojOkretaja--;
                    k++;
                }
            } while (brojOkretaja > 0);

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
