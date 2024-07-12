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
            


            for (int a = brojOkretaja; a > 0; a--)
            {
                for (int i = 2+k; i > 0-k; i--)
                {
                    for (int j = 3+k; j > 2+k; j--)
                    {
                        tablica[i, j] = y--;
                    }
                }
                for (int i = 1-k; i > 0-k; i--)
                {
                    for (int j = 2+k; j > 0-k; j--)
                    {
                        tablica[i, j] = y--;
                    }
                }
                for (int i = 2-k; i < 4+k; i++)
                {
                    for (int j = 1-k; j > 0-k; j--)
                    {
                        tablica[i, j] = y--;
                    }
                }
                for (int i = 3+k; i > 2+k; i--)
                {
                    for (int j = 2-k; j < 4+k; j++)
                    {
                        tablica[i, j] = y--;
                    }
                }
                ++k;
            }

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    Console.Write(tablica[i,j] + "\t");
                }
                Console.WriteLine();
            }
        }



    }
}
