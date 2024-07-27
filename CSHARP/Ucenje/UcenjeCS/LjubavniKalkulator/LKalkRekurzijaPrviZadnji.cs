using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.LjubavniKalkulator
{
    internal class LKalkRekurzijaPrviZadnji
    {


        public static string Zbrajanje(string y)
        {
            Console.WriteLine(y);

            int duljinaBrojaSlova = y.Length;

            if (duljinaBrojaSlova <= 2)
            {
                Console.WriteLine("Šansa: {0}%", y);
                return y;
            }

            for (int i = 0; i < duljinaBrojaSlova / 2; i++)
            {
                int b = int.Parse(y[i].ToString()) + int.Parse(y[duljinaBrojaSlova - 1 - i].ToString());
                y += b;
            }

            if (duljinaBrojaSlova % 2 == 1)
            {
                char ostatak = y[duljinaBrojaSlova / 2];
                y = y.Substring(duljinaBrojaSlova);
                y += ostatak;
            }

            else if (duljinaBrojaSlova % 2 == 0)
            {
                y = y.Substring(duljinaBrojaSlova);
            }


            duljinaBrojaSlova = y.Length;


            return Zbrajanje(y);
        }

    }
}
