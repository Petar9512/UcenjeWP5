using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E03Z1
    {

        public static void Izvedi()
        {

            Console.Write("Unesite svoju dob (broj godina): ");
            int godina = int.Parse(Console.ReadLine());
            Console.WriteLine(godina);

            if (godina < 0 || godina > 117)
            {
                Console.WriteLine("GREŠKA");
            }
            else if (godina >= 18)
            {
                Console.WriteLine("Punoljetan");
            }
            else
            {
                Console.WriteLine("Nije punoljetan");
            }

        }

    }
}
