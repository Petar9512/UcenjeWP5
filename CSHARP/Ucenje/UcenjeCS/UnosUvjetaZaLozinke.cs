using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class UnosUvjetaZaLozinke
    {

        public static void Uvjeti()
        {

            string velikaSlova = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";         // stringovi koji se koriste za generiranje lozinki bez ponavljajućih znakova
            string malaSlova = "abcdefghijklmnopqrstuvwxyz";
            string brojevi = "0123456789";
            string znakovi = "!,.:?@";
            string dopusteniZnakovi = "";


            int duljinaLozinke;                                        // varijable čija vrijednost ovisi o korisničkom inputu za uvjete generiranja lozinki
            int brojLozinki;
            int k;
            int k2 = 0;
            int prviZnak = 0;
            int zadnjiZnak = 0;
            bool jedan = false;
            string uvjet = "";


            while (true)
            {
                Console.WriteLine("Unesite duljinu lozinke: ");

                try
                {
                    duljinaLozinke = int.Parse(Console.ReadLine());

                    if (duljinaLozinke < 10 || duljinaLozinke > 60)
                    {
                        Console.WriteLine("Mora biti između 10 i 60");
                        continue;
                    }
                    break;
                }

                catch
                {
                    Console.WriteLine("Mora biti cijeli broj");
                }
            }

            while (true)
            {
                Console.WriteLine("\n Želite li da lozinka sadrži velika slova? \n 1 - DA \n 2 - NE");

                try
                {
                    k = int.Parse(Console.ReadLine());

                    if (k != 1 && k != 2)
                    {
                        Console.WriteLine("Niste unijeli 1 ili 2");
                        continue;
                    }

                    if (k == 1)                                              // ako korisnik unese DA za određenu grupu znakova, ti znakovi se dodaju u string dopusteniZnakovi
                    {                                                        // također broj 1 ili 2 se dodaje u string uvjet koji se koristi za generiranje lozinki s ponavljajućim znakovima
                        dopusteniZnakovi += velikaSlova;
                    }

                    uvjet += k;
                    break;
                }

                catch
                {
                    Console.WriteLine("Niste unijeli 1 ili 2");
                }
            }

            while (true)
            {
                Console.WriteLine("\n Želite li da lozinka sadrži mala slova? \n 1 - DA \n 2 - NE");

                try
                {
                    k = int.Parse(Console.ReadLine());

                    if (k != 1 && k != 2)
                    {
                        Console.WriteLine("Niste unijeli 1 ili 2");
                        continue;
                    }

                    if (k == 1)
                    {
                        dopusteniZnakovi += malaSlova;
                    }

                    uvjet += k;
                    break;
                }

                catch
                {
                    Console.WriteLine("Niste unijeli 1 ili 2");
                }
            }

            while (true)
            {
                Console.WriteLine("\n Želite li da lozinka sadrži brojeve? \n 1 - DA \n 2 - NE");

                try
                {
                    k = int.Parse(Console.ReadLine());

                    if (k != 1 && k != 2)
                    {
                        Console.WriteLine("Niste unijeli 1 ili 2");
                        continue;
                    }
                    uvjet += k;

                    if (k == 1)
                    {
                        dopusteniZnakovi += brojevi;
                        jedan = true;
                    } 
                    
                    break;
                }

                catch
                {
                    Console.WriteLine("Niste unijeli 1 ili 2");
                }
            }

            while (true)
            {
                Console.WriteLine("\n Želite li da lozinka sadrži interpunkcijske znakove? \n 1 - DA \n 2 - NE");

                try
                {
                    k = int.Parse(Console.ReadLine());

                    if (k != 1 && k != 2)
                    {
                        Console.WriteLine("Niste unijeli 1 ili 2");
                        continue;
                    }
                    uvjet += k;

                    if (k == 1)
                    {
                        dopusteniZnakovi += znakovi;
                        jedan = true;
                    }

                    break;
                }

                catch
                {
                    Console.WriteLine("Niste unijeli 1 ili 2");
                }
            }

            if (dopusteniZnakovi.Length >= duljinaLozinke)              // ako je broj dopuštenih znakova veći ili jednak od duljine lozinke, postavlja se upit o mogućnosti da lozinka ne sadrži ponavljajuće znakove
            {
                while (true)
                {
                    Console.WriteLine("\n Smije li lozinka imati ponavljajuće znakove? \n 1 - DA \n 2 - NE");

                    try
                    {
                        k2 = int.Parse(Console.ReadLine());

                        if (k2 != 1 && k2 != 2)
                        {
                            Console.WriteLine("Niste unijeli 1 ili 2");
                            continue;
                        }
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Niste unijeli 1 ili 2");
                    }
                }
            }
           
            while (jedan && k2 != 2)           // upit o mogućnosti da lozinka počne ili završi s brojem ili interpunkcijskim znakom postavit će se ako je korisnik dopustio brojeve ili znakove u lozinki i ako lozinka može sadržavati ponavljajuće znakove 
            {
                Console.WriteLine("\n Želite li da lozinka počne s brojem ili interpunkcijskim znakom? \n 1 - brojem \n 2 - interpunkcijskim znakom \n 3 - ne / svejedno");

                try
                {
                    prviZnak = int.Parse(Console.ReadLine());

                    if (prviZnak != 1 && prviZnak != 2 && prviZnak != 3)
                    {
                        Console.WriteLine("Niste unijeli opciju 1, 2 ili 3");
                        continue;
                    }
                    break;
                }
                catch
                {
                    Console.WriteLine("Niste unijeli opciju 1, 2 ili 3");
                }
            }

            while (jedan && k2 != 2)
            {
                Console.WriteLine("\n Želite li da lozinka završi s brojem ili interpunkcijskim znakom? \n 1 - brojem \n 2 - interpunkcijskim znakom \n 3 - ne / svejedno");

                try
                {
                    zadnjiZnak = int.Parse(Console.ReadLine());

                    if (zadnjiZnak != 1 && zadnjiZnak != 2 && zadnjiZnak != 3)
                    {
                        Console.WriteLine("Niste unijeli opciju 1, 2 ili 3");
                        continue;
                    }
                    break;
                }
                catch
                {
                    Console.WriteLine("Niste unijeli opciju 1, 2 ili 3");
                }
            }

            while (true)
            {
                Console.WriteLine("\n Unesite broj lozinki koje želite generirati: ");

                try
                {
                    brojLozinki = int.Parse(Console.ReadLine());

                    if (brojLozinki < 1)
                    {
                        Console.WriteLine("Broj mora biti veći od nule");
                        continue;
                    }
                    break;
                }

                catch
                {
                    Console.WriteLine("Niste unijeli cijeli broj");
                }               
            }


            int brojDA = 0;

            for (int i = 0; i < uvjet.Length; i++)
            {
                if (int.Parse(uvjet[i].ToString()) == 1)
                {
                    brojDA += 1;
                }
            }

            int[] pozUvjeti = new int[brojDA];           // niz pozUvjeti ima onoliko brojeva koliko je korisnik omogućio različitih vrsta znakova

            if (uvjet == "1111")                         // brojevi u nizu bit će postavljeni ovisno o stringu uvjet
            {
                pozUvjeti[0] = 1;
                pozUvjeti[1] = 2;
                pozUvjeti[2] = 3;
                pozUvjeti[3] = 4;
            }

            else if (uvjet == "1211")
            {
                pozUvjeti[0] = 1;
                pozUvjeti[1] = 3;
                pozUvjeti[2] = 4;
            }

            else if (uvjet == "1221")
            {
                pozUvjeti[0] = 1;
                pozUvjeti[1] = 4;
            }

            else if (uvjet == "1222")
            {
                pozUvjeti[0] = 1;
            }

            else if (uvjet == "1212")
            {
                pozUvjeti[0] = 1;
                pozUvjeti[1] = 3;
            }

            else if (uvjet == "1122")
            {
                pozUvjeti[0] = 1;
                pozUvjeti[1] = 2;
            }

            else if (uvjet == "1121")
            {
                pozUvjeti[0] = 1;
                pozUvjeti[1] = 2;
                pozUvjeti[2] = 4;
            }

            else if (uvjet == "1112")
            {
                pozUvjeti[0] = 1;
                pozUvjeti[1] = 2;
                pozUvjeti[2] = 3;
            }

            else if (uvjet == "2111")
            {
                pozUvjeti[0] = 2;
                pozUvjeti[1] = 3;
                pozUvjeti[2] = 4;
            }

            else if (uvjet == "2122")
            {
                pozUvjeti[0] = 2;
            }

            else if (uvjet == "2112")
            {
                pozUvjeti[0] = 2;
                pozUvjeti[1] = 3;
            }

            else if (uvjet == "2121")
            {
                pozUvjeti[0] = 2;
                pozUvjeti[1] = 4;
            }

            else if (uvjet == "2211")
            {
                pozUvjeti[0] = 3;
                pozUvjeti[1] = 4;
            }

            else if (uvjet == "2212")
            {
                pozUvjeti[0] = 3;
            }

            else if (uvjet == "2221")
            {
                pozUvjeti[0] = 4;
            }


            if (k2 == 2)
            {
                while (brojLozinki > 0)
                {
                    GeneratorLozinki.GeneratorBezPonavljajucihZnakova(duljinaLozinke, dopusteniZnakovi);
                    brojLozinki--;
                }
            }

            else
            {
                try                                         
                {
                    while (brojLozinki > 0)
                    {
                        GeneratorLozinki.Generator(duljinaLozinke, pozUvjeti, prviZnak, zadnjiZnak);
                        brojLozinki--;
                    }
                }
                catch
                {
                    Console.WriteLine("Morate unijeti barem jedan pozitivan uvjet \n");
                    Uvjeti();
                }
            }
            
        }
    }
}
