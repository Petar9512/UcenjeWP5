using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.LjubavniKalkulator
{
    internal class LKalkFunkcijaDvaSusjedna
    {

        public static void Kalkulator2(string brojSlova)
        {


            int duljinaBrojaSlova = brojSlova.Length;



            while (duljinaBrojaSlova > 2)
            {
                Console.WriteLine(brojSlova);


                for (int i = 0; i < duljinaBrojaSlova - 1; i += 2)         // for petlja zbraja 2 susjedna broja
                {
                    int b = int.Parse(brojSlova[i].ToString()) + int.Parse(brojSlova[i + 1].ToString());
                    brojSlova += b;
                }

                if (duljinaBrojaSlova % 2 == 1)
                {
                    char ostatak = brojSlova[duljinaBrojaSlova - 1];       // u tom slučaju ostatak je zadnji broj u stringu
                    brojSlova = brojSlova.Substring(duljinaBrojaSlova);
                    brojSlova += ostatak;
                }

                else if (duljinaBrojaSlova % 2 == 0)
                {
                    brojSlova = brojSlova.Substring(duljinaBrojaSlova);
                }


                duljinaBrojaSlova = brojSlova.Length;
            }

            Console.WriteLine(brojSlova);
            Console.WriteLine("Šansa: {0}%", brojSlova);


        }

    }
}
