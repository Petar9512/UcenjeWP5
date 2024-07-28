using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.LjubavniKalkulator
{
    internal class LKalkFunkcijaPrviZadnji
    {

        public static void Kalkulator(string brojSlova)
        {


            int duljinaBrojaSlova = brojSlova.Length;                       // ova varijabla je bitna za zbrajanje u for petlji


            while (duljinaBrojaSlova > 2)                                   // budući da tražimo dvoznamenkasti postotak, operacija se ponavlja sve dok brojSlova ima više od 2 znamenke
            {
                Console.WriteLine(brojSlova);                               // ovdje ispisujemo trenutni brojSlova


                for (int i = 0; i < duljinaBrojaSlova / 2; i++)             // petlja za zbrajanje prvog i zadnjeg, drugog i predzadnjeg itd. broja
                {
                    int b = int.Parse(brojSlova[i].ToString()) + int.Parse(brojSlova[duljinaBrojaSlova - 1 - i].ToString());
                    brojSlova += b;                                         // budući da radimo na stringu, moramo koristiti metode za promjenu char u int kako bi se moglo zbrojiti
                }                                                         

                if (duljinaBrojaSlova % 2 == 1)                             // ako je string imao neparan broj znakova, broj u sredini će ostati kao ostatak
                {
                    char ostatak = brojSlova[duljinaBrojaSlova / 2];      
                    brojSlova = brojSlova.Substring(duljinaBrojaSlova);     // izbacimo stare brojeve iz stringa tako da ostanu samo brojevi zadnjeg zbrajanja
                    brojSlova += ostatak;                                   // na novi string dodamo ostatak
                }

                else if (duljinaBrojaSlova % 2 == 0)                        // ako je parni broj znakova, onda nema ostatka
                {
                    brojSlova = brojSlova.Substring(duljinaBrojaSlova);   
                }        
                      
                duljinaBrojaSlova = brojSlova.Length;                       // duljinaBrojaSlova postaje nova duljina od brojSlova

            }

            Console.WriteLine(brojSlova);                                   // ispišemo zadnji brojSlova koji je ujedno i traženi postotak
            Console.WriteLine("Šansa: {0}%", brojSlova);


        }

    }
}
