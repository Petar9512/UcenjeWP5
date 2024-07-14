using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class FunkcijaZaPrikazTablice
    {

        public static void Tablica(int[,] x)
        {
            Console.WriteLine();

            for (int i = 0; i < x.GetLength(0); i++)
            {
                for (int j = 0; j < x.GetLength(1); j++)
                {
                    Console.Write(x[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

    }
}
