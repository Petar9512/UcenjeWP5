using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class LKalkulatorUnosImena
    {

        public static void UnosImena()
        {
            string ime1 = "";                 // korisnik unosi dva imena, osigurava se da imaju samo slova
            string ime2 = "";

            while(true)
            {
                Console.WriteLine("Unesite prvo ime: ");

                try
                {
                    ime1 = Console.ReadLine().Trim().ToLower();

                    for (int i = 0; i < ime1.Length; i++)
                    {
                        if (!char.IsLetterOrDigit(ime1[i]) || char.IsDigit(ime1[i]))
                        {
                            ime1 = "";
                        }
                    }

                    if (ime1.Length == 0)
                    {
                        Console.WriteLine("Ime mora sadržavati samo slova i ne smije biti prazno");
                        continue;
                    }
                    break;
                }
                catch
                {
                    Console.WriteLine("Niste unijeli ime");
                }
            }

            while (true)
            {
                Console.WriteLine("Unesite drugo ime: ");

                try
                {
                    ime2 = Console.ReadLine().Trim().ToLower();

                    for (int i = 0; i < ime2.Length; i++)
                    {
                        if (!char.IsLetterOrDigit(ime2[i]) || char.IsDigit(ime2[i]))
                        {
                            ime2 = "";
                        }
                    }

                    if (ime2.Length == 0)
                    {
                        Console.WriteLine("Ime mora sadržavati samo slova i ne smije biti prazno");
                        continue;
                    }
                    break;
                }

                catch
                {
                    Console.WriteLine("Niste unijeli ime");
                }
            }

            LKalkulatorFunkcija2.Kalkulator2(ime1, ime2);
        }

    }
}
