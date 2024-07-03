using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E03Z3
    {

        public static void Izvedi()
        {
            Console.Write("Unesite broj: ");
            int broj1 = int.Parse(Console.ReadLine());

            Console.Write("Unesite drugi broj: ");
            int broj2 = int.Parse(Console.ReadLine());

            Console.Write("Unesite treći broj: ");
            int broj3 = int.Parse(Console.ReadLine());

            if (broj1 < broj2 && broj1 < broj3)
            {
                Console.WriteLine(broj1);
            }
            else if (broj2 < broj1 && broj2 < broj3)
            {
                Console.WriteLine(broj2);
            }
            else if (broj3 < broj1 && broj3 < broj2)
            {
                Console.WriteLine(broj3);
            }
            else
            {
                Console.WriteLine("Pogrešan unos");
            }

            Console.Write("Unesite broj: ");
            int k1 = int.Parse(Console.ReadLine());

            Console.Write("Unesite drugi broj: ");
            int k2 = int.Parse(Console.ReadLine());

            if (k1 < k2)
            {
                Console.WriteLine(k1);
            }
            else if (k2 < k1)
            {
                Console.WriteLine(k2);
            }
            else
            {
                Console.WriteLine("Pogrešan unos");
            }

        }

    }
}
