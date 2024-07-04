using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E05Nizovi
    {

        public static void Izvedi()
        {

            int[] temperature = new int[12];

            temperature[0] = -1;
            temperature[1] = 0;
            temperature[10] = 0;

            temperature[temperature.Length - 1] = -3;

            Console.WriteLine(temperature.Length);
            Console.WriteLine(temperature[1]);
            Console.WriteLine(string.Join(", ", temperature));


            int[] niz = { 2, 4, 6, 4, 5, 23, 4, 34, 1 };
            Console.WriteLine(niz[4]);

            string[] gradovi = { "Osijek", "Donji Miholjac", "Valpovo", "Belišće" };
            Console.WriteLine(gradovi[gradovi.Length - 1]);


            int[,] tablica =
            {
                { 1, 2, 3
                },
                { 4, 5, 6
                },
                { 7, 8, 9
                }
            };

            Console.WriteLine(tablica[1, 2]);
            Console.WriteLine(tablica[2, 2]);

        }
    }
}
