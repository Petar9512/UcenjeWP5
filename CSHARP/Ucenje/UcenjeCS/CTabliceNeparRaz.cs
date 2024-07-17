using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class CTabliceNeparRaz
    {

        public static void NeparniRazDDC(int x, int y)
        {
            int z = x * y;
            int min = x > y ? y : x;
            int max = x > y ? x : y;
            int m = min / 2;
            int brojOkretaja = min / 2;
            int brojPrveIteracije = max - min + 1;
            int n = m + max - min;
            int[,] tablica = new int[x, y];
            int k = 0;

          

               for (int a = 0; a < brojPrveIteracije; a++)
               {
                   tablica[m + a, m] = z--;
               }
      
            

            for (int b = brojOkretaja; b > 0; b--)
            {
                for (int i = n+k; i > m-2-k; i--)
                {
                    for (int j = m+1+k; j > m+k; j--)
                    {
                        tablica[i, j] = z--;
                    }
                }
                for (int i = m-1-k; i > m-2-k; i--)
                {
                    for (int j = m+k; j > m-2-k; j--)
                    {
                        tablica[i, j] = z--;
                    }
                }
                for (int i = m-k; i < n+2+k; i++)
                {
                    for (int j = m-1-k; j > m-2-k; j--)
                    {
                        tablica[i, j] = z--;
                    }
                }
                for (int i = n+1+k; i > n+k; i--)
                {
                    for (int j = m-k; j < m+2+k; j++)
                    {
                        tablica[i, j] = z--;
                    }
                }
                ++k;
            }

            FunkcijaZaPrikazTablice.Tablica(tablica); 

        }

    }
}
