using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class LKalkRekurzijaDvaSusjedna
    {

        public static string Zbrajanje2(int[] x, string y)
        {
            Console.WriteLine(y);

            int duljinaBrojaSlova = y.Length;

            if (duljinaBrojaSlova <= 2)
            {
                Console.WriteLine("Šansa: {0}%", y);
                return y;
            }

            for (int i = 0; i < duljinaBrojaSlova - 1; i+=2)
            {
                int b = x[i] + x[i + 1];
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

            Array.Clear(x, 0, x.Length);
            Array.Resize(ref x, y.Length);

            duljinaBrojaSlova = y.Length;

            for (int i = 0; i < duljinaBrojaSlova; i++)
            {
                x[i] = int.Parse(y[i].ToString());
            }

            return Zbrajanje2(x, y);
        }

    }
}
