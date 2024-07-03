using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E02VarijableTipoviPodataka
    {
         public static void Izvedi()
        {

            int i;
            i = 7;
            Console.WriteLine(i);


            Console.Write("Upišite cijeli broj veći od nule: ");
            int broj = int.Parse(Console.ReadLine());
            Console.WriteLine(broj + 1);


            Console.Write("Unesite decimalni broj (, je oznaka za decimalni broj): ");
            Console.WriteLine(float.Parse(Console.ReadLine()) + 1);


            int j = 3;
            Console.WriteLine(j == 3);
            Console.WriteLine(j != 6);


            Console.WriteLine("9%2 = {0}", 9%2);
            Console.WriteLine("8%2 = {0}", 8%2);


            int x, y;
            x = 5;
            y = 2;
            Console.WriteLine(x/(float)y);

        }

    }
}
