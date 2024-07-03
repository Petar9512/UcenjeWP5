using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E01UlazIzlaz
    {

        public static void Izvedi()
        {

            Console.WriteLine("Hello");

            Console.Write("Upiši svoje ime: ");

            string ime = Console.ReadLine();

            Console.WriteLine("Unijeli ste " + ime);

            Console.Write("Unesite adresu: ");
            string adresa = Console.ReadLine();

            Console.Write("Unesite grad: ");
            string grad = Console.ReadLine();

            Console.WriteLine(adresa);
            Console.WriteLine(grad);

        }

    }
}
