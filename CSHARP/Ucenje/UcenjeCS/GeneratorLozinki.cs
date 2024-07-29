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

            int[] interpunkZnakovi = new int[] { 33, 44, 46, 58, 63, 64 };

            
            for (int i = 0; i < duljina; i++)
            {
                y = rnd.Next(1, 5);

                if (y == 1)
                {
                    x = rnd.Next(65, 91);
                    lozinka += (Char)x;
                }

                else if (y == 2)
                {
                    x = rnd.Next(97, 123);
                    lozinka += (Char)x;
                }

                else if (y == 3)
                {
                    x = rnd.Next(48, 58);
                    lozinka += (Char)x;
                                   
                }

                else if (y == 4)
                {
                    x = rnd.Next(0, 6);
                    lozinka += (Char)interpunkZnakovi[x];
                }
            }

            Console.WriteLine(lozinka);
        }

    }
}
