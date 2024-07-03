using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E03UvjetnoGrananjeIf
    {
        public static void Izvedi()
        {

            int i = 8;
            bool uvjet = i == 8;
            
            if (uvjet)
            {
                Console.WriteLine("Vrijednost varijable i je 8");
            }

            if (i > 10)
            {
                Console.WriteLine("i je veći od 10");
            }
            else
            {
                Console.WriteLine("i nije veći od 10");
            }


            int b = 2;
            if (b == 1)
            {
                Console.WriteLine("Ne");
            }
            else if (b > 5) {
                Console.WriteLine("Ok");
            }
            else
            {
                Console.WriteLine("Ostalo");
            }


            int x = 2, y = 1;
            if (x == 1 && y == 1)
            {
                Console.WriteLine("x i y su 1");
            }

            if (x > 1 || y == 0)
            {
                Console.WriteLine("jedan ili oba uvjeta su zadovoljena");
            }


            if (x == 3)
            {
                int k = 9;
                if (k > 0)
                {
                    Console.WriteLine("Zadovoljeno");
                }
            }

            x = 0;

            Console.WriteLine(x == 0 ? "DA" : "NE");
        }

    }
}
