using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class GeneratorLozinki
    {

        public static void Generator(int duljina)
        {
            string lozinka = "";

            Random rnd = new Random();
            int x;
            int y;

            int[] velikaSlova = new int[] { 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90 };
            int[] malaSlova = new int[] { 97, 98, 99, 100, 101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122 };
            int[] brojevi = new int[] { 48, 49, 50, 51, 52, 53, 54, 55, 56, 57 };
            int[] znakovi = new int[] { 33, 44, 46, 58, 63, 64 };

            
            for (int i = 0; i < duljina; i++)
            {
                y = rnd.Next(1, 5);

                if (y == 1)
                {
                    x = rnd.Next(0, velikaSlova.Length);
                    lozinka += (Char)velikaSlova[x];
                }

                else if (y == 2)
                {
                    x = rnd.Next(0, malaSlova.Length);
                    lozinka += (Char)malaSlova[x];
                }

                else if (y == 3)
                {
                    x = rnd.Next(0, brojevi.Length);
                    lozinka += (Char)brojevi[x];
                                   
                }

                else if (y == 4)
                {
                    x = rnd.Next(0, znakovi.Length);
                    lozinka += (Char)znakovi[x];
                }
            }

            Console.WriteLine(lozinka);
        }

    }
}
