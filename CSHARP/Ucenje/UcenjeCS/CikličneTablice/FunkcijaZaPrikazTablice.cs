using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.CikličneTablice
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
                    Console.Write(String.Format("{0,4}", x[i, j]) + " ");
                }
                Console.WriteLine();
            }
        }

    }
}
