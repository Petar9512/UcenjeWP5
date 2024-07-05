using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E07Z1
    {

        public static void Izvedi()
        {

            int broj;

            while (true)
            {
                Console.Write("Upišite cijeli broj: ");

                try
                {
                    broj = int.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Niste unijeli ispravan broj");
                }
            }

            int suma = 0;
            
            while (broj > 0)
            {
                if (broj % 2 == 0)
                {
                    suma += broj;
                }
                broj--;
            }
            Console.WriteLine(suma);





            int x;
            int[] brojevi = new int[10];
            int suma2 = 0;

            for (int i = 0; i < 10; i++)
            {
                while (true)
                {

                 Console.Write("Unesite broj: ");
                 try
                 {
                 x = int.Parse(Console.ReadLine());
                 brojevi[i] = x;
                 suma2 += brojevi[i];
                 break;
                 }
                    catch
                    {
                        Console.WriteLine("Niste unijeli ispravan broj");
                    }
                 
                }
            }
            Console.WriteLine(suma2);

            for (int i = 0; i < brojevi.Length; i++)
            {
                Console.WriteLine(brojevi[i]);
            }
        }

    }
}
