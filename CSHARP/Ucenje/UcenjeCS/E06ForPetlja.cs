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
        {  /*

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
            */

            int[,] tablica =
            {
                {1,2,30 },
                {4,5,6},
                {7,8,9 }
            };

            for (int i = 0; i < tablica.GetLength(0); i++)
            {
                for (int j = 0; j < tablica.GetLength(1); j++)
                    if (j == 1 && i != 0)
                    {
                        Console.Write(tablica[i, j] + "  ");
                    }
                    else
                    {
                        Console.Write(tablica[i, j] + " ");
                    }
                Console.WriteLine();
            }
            /*

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write((i + 1) * (j + 1) + "\t");
                }
                Console.WriteLine();
            }  


            int ukupno = 0;
            for (int i = 0; i < 10; i++)
            {
                if (i == 1 || i == 3)
                {
                    continue;
                }
                if (++ukupno > 5)
                {
                    break;
                }
                Console.WriteLine(i);
            }


            int broj = 0;
            for (; ; )
            {
                Console.Write("Unesite broj između 10 i 20: ");
                broj = int.Parse(Console.ReadLine());
                if (broj>=10 && broj <=20)
                {
                    break;
                }
                Console.WriteLine("Neispravan unos");
            }

            Console.WriteLine("Unijeli ste {0}", broj);
            */
        }

    } 
        }
   