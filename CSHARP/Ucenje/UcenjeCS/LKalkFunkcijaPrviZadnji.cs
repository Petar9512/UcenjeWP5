using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class LKalkFunkcijaPrviZadnji
    {

        public static void Kalkulator(int[] brojeviSlova, string brojSlova)
        {            

            
            int duljinaBrojaSlova = brojSlova.Length;     // ova varijabla se koristi u petljama za zbrajanje brojeva


           
            while (duljinaBrojaSlova > 2)                 // na kraju želimo dobiti dvoznamenkasti postotak, zato se operacija ponavlja sve dok je varijabla veća od 2
            {
                Console.WriteLine(brojSlova);             // ovdje ispisujemo trenutni string od brojeva dobivenih zbrajanjem


                for (int i = 0; i < duljinaBrojaSlova / 2; i++) 
                {
                    int b = brojeviSlova[i] + brojeviSlova[duljinaBrojaSlova - 1 - i];
                    brojSlova += b;                                       // b je produkt zbrajanja prvog i zadnjeg, drugog i predzadnjeg itd. broja i dodaje se u string brojSlova
                }                                                         // ne možemo zbrajati brojeve u stringu, zato zbrajamo u nizu brojeva brojeviSlova koji je isti kao i string, osim što su vrijednosti int

                if (duljinaBrojaSlova % 2 == 1)
                {
                    char ostatak = brojSlova[duljinaBrojaSlova / 2];      // ako niz sadrži neparan broj brojeva, broj u sredini će nakon zbrajanja ostati kao ostatak
                    brojSlova = brojSlova.Substring(duljinaBrojaSlova);   // iz brojSlova izbacimo prijašnje brojeve tako da ostanu samo vrijednosti zadnjeg zbrajanja
                    brojSlova += ostatak;                                 // duljinaBrojaSlova je index početka novih brojeva, na novi brojSlova dodamo ostatak
                }

                else if (duljinaBrojaSlova % 2 == 0)
                {
                    brojSlova = brojSlova.Substring(duljinaBrojaSlova);   // ako je niz imao parni broj brojeva, onda nema ostatka
                }

                Array.Clear(brojeviSlova, 0, brojeviSlova.Length);        // očistimo niz brojeva brojeviSlova
                Array.Resize(ref brojeviSlova, brojSlova.Length);         // promijenimo duljinu tako da bude ista kao i brojSlova

                duljinaBrojaSlova = brojSlova.Length;                     // duljinaBrojaSlova postaje nova duljina od brojSlova

                for (int i = 0; i < duljinaBrojaSlova; i++)               // ovdje brojeve iz stringa brojSlova dodajemo u niz brojeviSlova za sljedeći krug zbrajanja
                {
                    brojeviSlova[i] = int.Parse(brojSlova[i].ToString()); // da bi se to postiglo, potrebno je znakove promijeniti u integere
                }
            }
            
            Console.WriteLine(brojSlova);                                 // napišemo konačni brojSlova koji je i traženi postotak
            Console.WriteLine("Šansa: {0}%", brojSlova);


        }

    }
}
