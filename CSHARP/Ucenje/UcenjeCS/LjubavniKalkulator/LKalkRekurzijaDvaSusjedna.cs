using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.LjubavniKalkulator
{
    internal class LKalkRekurzijaDvaSusjedna
    {

        public static string Zbrajanje2(string y)
        {
            Console.WriteLine(y);

            int duljinaBrojaSlova = y.Length;


            if (duljinaBrojaSlova <= 2)
            {
                Console.WriteLine("Šansa: {0}%", y);
                return y;
            }

            for (int i = 0; i < duljinaBrojaSlova - 1; i += 2)
            {
                int b = int.Parse(y[i].ToString()) + int.Parse(y[i + 1].ToString());
                y += b;
            }

            if (duljinaBrojaSlova % 2 == 1)
            {
                char ostatak = y[duljinaBrojaSlova - 1];
                y = y.Substring(duljinaBrojaSlova);
                y += ostatak;
            }

            else if (duljinaBrojaSlova % 2 == 0)
            {
                y = y.Substring(duljinaBrojaSlova);
            }


            duljinaBrojaSlova = y.Length;


            return Zbrajanje2(y);
        }

    }
}
