using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class CTabliceNeparParDDXmanjeodY
    {

        public static void NeparniParniDDC(int x, int y)
        {
            int z = x * y;
            int min = x > y ? y : x;
            int max = x > y ? x : y;
            int m = min / 2;
            int brojOkretaja = min / 2;
            int n = m - 1 + max - min;
            int[,] tablica = new int[x, y];
            int k = 0;


            
            if (x < y)
            {
                for (int i = m; i > m-1; i--)
                {
                    for (int j = m; j < n+2; j++)
                    {
                        tablica[i, j] = z--;
                    }
                }


                for (int a = brojOkretaja; a > 0; a--)
                {
                    for (int i = m+k; i > m-2-k; i--)
                    {
                        for (int j = n+2+k; j > n+1+k; j--)
                        {
                            tablica[i, j] = z--;
                        }
                    }
                    for (int i = m-1-k; i > m-2-k; i--)
                    {
                        for (int j = n+1+k; j > m-2-k; j--)
                        {
                            tablica[i, j] = z--;
                        }
                    }
                    for (int i = m-k; i < m+2+k; i++)
                    {
                        for (int j = m-1-k; j > m-2-k; j--)
                        {
                            tablica[i, j] = z--;
                        }
                    }
                    for (int i = m+1+k; i > m+k; i--)
                    {
                        for (int j = m-k; j < n+3+k; j++)
                        {
                            tablica[i, j] = z--;
                        }
                    }
                    ++k;
                            
                }
            }

            FunkcijaZaPrikazTablice.Tablica(tablica);
        }


        public static void NeparniParniDDAC(int x, int y)
        {
            int z = x * y;
            int min = x > y ? y : x;
            int max = x > y ? x : y;
            int m = min / 2;
            int brojOkretaja = min / 2;
            int n = m - 1 + max - min;
            int[,] tablica = new int[x, y];
            int k = 0;



            if (x < y)
            {
                for (int i = m; i > m - 1; i--)
                {
                    for (int j = m; j < n + 2; j++)
                    {
                        tablica[i, j] = z--;
                    }
                }
            }


            for (int a = brojOkretaja; a > 0; a--)
            {
                for (int i = m+1+k; i > m+k; i--)
                {
                    for (int j = n+1+k; j > m-2-k; j--)
                    {
                        tablica[i, j] = z--;
                    }
                }
                for (int i = m+k; i > m-2-k; i--)
                {
                    for (int j = m-1-k; j > m-2-k; j--)
                    {
                        tablica[i, j] = z--;
                    }
                }
                for (int i = m-1-k; i > m-2-k; i--)
                {
                    for (int j = m-k; j < n+3+k; j++)
                    {
                        tablica[i, j] = z--;
                    }
                }
                for (int i = m-k; i < m+2+k; i++)
                {
                    for (int j = n+2+k; j > n+1+k; j--)
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
