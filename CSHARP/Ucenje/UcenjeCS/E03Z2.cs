using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E03Z2
    {

        public static void Izvedi()
        {

            Console.Write("Unesite cijeli broj: ");
            int broj = int.Parse(Console.ReadLine());

            if (broj%2 == 0)
            {
                Console.WriteLine("paran broj");
            }
            else
            {
                Console.WriteLine("neparan broj");
            }

        }

    }
}
