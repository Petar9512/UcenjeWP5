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
            char c = Char.ToUpper(grad2[0]);
            grad2 = c + grad2.Substring(1);
            Console.WriteLine();
            
            switch (grad2)
            {
                case "Osijek":
                    Console.WriteLine("Slavonija");
                    break;
                case "Zadar":
                    Console.WriteLine("Dalmacija");
                    break;
                case "Čakovec":
                    Console.WriteLine("Međimurje");
                    break;
                case "Pula":
                    Console.WriteLine("Istra");
                    break;
                default:
                    Console.WriteLine("Ne znam koja je to regija");
                    break;
            }



            Console.WriteLine();
            string x;
            string y = "";

            Console.WriteLine("Unesite riječ: ");
            x = Console.ReadLine().Trim().ToLower();

            for (int i = x.Length - 1; i > -1; i--)
            {
                y += x[i];
            }

            Console.WriteLine(y);
            Console.WriteLine();

            if (x == y)
            {
                Console.WriteLine("Palindrom");
            }
            else
            {
                Console.WriteLine("Nije palindrom");
            }
        }
    }
}
