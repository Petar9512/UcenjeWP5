using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E06ForPetlja
    {

        public static void Izvedi()
        {

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Osijek");
            }


            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i + 1);
            }


            int suma = 0;
            for (int i = 0; i <= 100; i++)
            {
                suma += i;
            }

            Console.WriteLine(suma);


            for (int i = 0; i <= 50; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }


            int brojOd = 40;
            int brojDo = 20;

            for (int i = brojOd; i > brojDo; i--)
            {
                Console.WriteLine(i);
            }


            int[] niz = { 2, 6, 7, 12, 23, 3, 5, 2, 24 };
            for (int i = 0; i < niz.Length; i++)
            {
                if (niz[i] % 2 == 0)
                {
                    Console.WriteLine(niz[i]);
                }
            }

        }

    }
}
