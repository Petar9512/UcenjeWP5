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
            string ime1 = "";                      // korisnik unosi dva imena, osigurava se da imaju samo slova
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


            string ime = ime1 + ime2;                     // novi string od oba imena kojima su prethodno smanjena sva slova
            string brojSlova = "";                        // u ovaj string ćemo dodavati vrijednosti ponavljanja svakog slova u ime
            int[] brojeviSlova = new int[ime.Length];     // ovdje ćemo dodavati iste vrijednosti, ali kao intove u niz intova
            int k = 0;

            char x = char.ToUpper(ime1[0]);               // ovo služi samo za ispis unesenih imena s prvim slovom velikim
            ime1 = x + ime1.Substring(1);
            char y = char.ToUpper(ime2[0]);
            ime2 = y + ime2.Substring(1);

            Console.WriteLine(ime1 + ime2);


            for (int i = 0; i < ime.Length; i++)
            {
                for (int j = 0; j < ime.Length; j++)
                {
                    if (ime[i] == ime[j])                 // petlja za dobijanje vrijednosti k za broj ponavljanja svakog slova
                    {
                        k++;
                    }
                }
                brojeviSlova[i] = k;                      // k vrijednosti potom idu u niz brojeva i u string od brojeva
                brojSlova += k;
                k = 0;                                    // k se resetira na kraju svakog vanjskog loopa
            }


            LKalkFunkcijaDvaSusjedna.Kalkulator2(brojeviSlova, brojSlova);
        }

    }
}
