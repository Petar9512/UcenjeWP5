using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class EZadatci2
    {

        public static void Izvedi()
        {

            string grad;
            string grad2 = "";

            while (true)
            {
                Console.WriteLine("Unesite grad: ");

                try
                {
                    grad = Console.ReadLine().Trim();

                    if (grad.Length == 0)
                    {
                        Console.WriteLine("Niste unijeli grad");
                        Console.WriteLine();
                        continue;
                    }

                    for (int i = 0; i < grad.Length; i++)
                    {
                        if (Char.IsLetterOrDigit(grad[i]) && !Char.IsDigit(grad[i]))
                        {
                            grad2 += grad[i];
                        }
                    }

                    if (grad.Length != grad2.Length)
                    {
                        grad2 = "";
                        Console.WriteLine("Grad mora sadržavati samo slova");
                        Console.WriteLine();
                        continue;
                    }
                    break;
                }
                catch
                {
                    Console.WriteLine("Niste unijeli grad");
                }
            }
            Console.WriteLine();
            Console.WriteLine(grad2);

        }
    }
}
