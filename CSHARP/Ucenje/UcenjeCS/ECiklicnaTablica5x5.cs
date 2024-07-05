using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace UcenjeCS
{
    internal class ECiklicnaTablica5x5
    {

        public static void Izvedi()
        {

            int x = 5;

            int[,] tablica = new int[x, x];

            int y = x - (x - 1);

            for (int i = x - 1; i < x; i++)
            {
                for (int j = x - 1; j > -1; j--)
                {
                    tablica[i, j] = y++;
                }
            }

            for (int i = x - 2; i > -1; i--)
            {
                for (int j = 0; j < 1; j++)
                {
                    tablica[i, j] = y++;
                }
            }

            for (int i = 0; i < 1; i++)
            {
                for (int j = 1; j < x; j++)
                {
                    tablica[i, j] = y++;
                }
            }

            for (int i = 1; i < x - 1; i++)
            {
              for (int j = x - 1; j < x; j++) {
                    tablica[i, j] = y++;
            }
            }

            for (int i = x - 2; i < x - 1; i++)
            {
                for (int j = x - 2; j > 0; j--)
                {
                    tablica[i, j] = y++;
                }
            }

            for (int i = x - 3; i > 0; i--)
            {
                for (int j = 1; j < 2; j++)
                {
                    tablica[i, j] = y++;
                }
            }

            for (int i = 1; i < 2; i++)
            {
                for (int j = 2; j < x - 1; j++)
                {
                    tablica[i, j] = y++;
                }
            }

            for (int i = x - 3; i < x - 2; i++)
            {
                for (int j = x - 2; j > 1; j--)
                {
                    tablica[i, j] = y++;
                }
            }

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
