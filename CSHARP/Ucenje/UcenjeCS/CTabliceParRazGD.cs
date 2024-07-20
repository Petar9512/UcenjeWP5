using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class CTabliceParRazGD
    {

        public static void ParniRazGDC(int x, int y)
        {
            int z = x * y;
            int min = x > y ? y : x;
            int max = x > y ? x : y;
            int m = min / 2;
            int brojOkretaja = min / 2;
            int n = m + max - min - 1;
            int[,] tablica = new int[x, y];
            int k = 0;


            if (x > y)
            {
                for (int i = m-1; i < n+2; i++)
                {
                    for (int j = m-1; j > m-2; j--)
                    {
                        tablica[i, j] = z--;
                    }
                }
                for (int i = n+1; i > m-2; i--)
                {
                    for (int j = m; j > m-1; j--)
                    {
                        tablica[i, j] = z--;
                    }
                }


                for (int a = brojOkretaja - 1; a > 0; a--)
                {
                    for (int i = m-2-k; i > m-3-k; i--)
                    {
                        for (int j = m+k; j > m-2-k; j--)
                        {
                            tablica[i, j] = z--;
                        }
                    }
                    for (int i = m-2-k; i < n+3+k; i++)
                    {
                        for (int j = m-2-k; j > m-3-k; j--)
                        {
                            tablica[i, j] = z--;
                        }
                    }
                    for (int i = n+2+k; i > n+1+k; i--)
                    {
                        for (int j = m-1-k; j < m+1+k; j++)
                        {
                            tablica[i, j] = z--;
                        }
                    }
                    for (int i = n+2+k; i > m-3-k; i--)
                    {
                        for (int j = m+1+k; j > m+k; j--)
                        {
                            tablica[i, j] = z--;
                        }
                    }
                    ++k;
                }
            }

            else if (x < y)
            {
                for (int a = brojOkretaja; a > 0; a--)
                {
                    for (int i = m-1-k; i > m-2-k; i--)
                    {
                        for (int j = n+k; j > m-1-k; j--)
                        {
                            tablica[i, j] = z--;
                        }
                    }
                    for (int i = m-1-k; i < m+1+k; i++)
                    {
                        for (int j = m-1-k; j > m-2-k; j--)
                        {
                            tablica[i, j] = z--;
                        }
                    }
                    for (int i = m+k; i > m-1+k; i--)
                    {
                        for (int j = m-k; j < n+1+k; j++)
                        {
                            tablica[i, j] = z--;
                        }
                    }
                    for (int i = m+k; i > m-2-k; i--)
                    {
                        for (int j = n+1+k; j > n+k; j--)
                        {
                            tablica[i, j] = z--;
                        }
                    }
                    ++k;
                }
            }

            FunkcijaZaPrikazTablice.Tablica(tablica);
        }


        public static void ParniRazGDCos(int x, int y)
        {
            int z = 1;
            int min = x > y ? y : x;
            int max = x > y ? x : y;
            int m = min / 2;
            int brojOkretaja = min / 2;
            int n = m + max - min - 1;
            int[,] tablica = new int[x, y];
            int k = 0;


            if (x > y)
            {
                for (int i = m - 1; i < n + 2; i++)
                {
                    for (int j = m - 1; j > m - 2; j--)
                    {
                        tablica[i, j] = z++;
                    }
                }
                for (int i = n + 1; i > m - 2; i--)
                {
                    for (int j = m; j > m - 1; j--)
                    {
                        tablica[i, j] = z++;
                    }
                }


                for (int a = brojOkretaja - 1; a > 0; a--)
                {
                    for (int i = m - 2 - k; i > m - 3 - k; i--)
                    {
                        for (int j = m + k; j > m - 2 - k; j--)
                        {
                            tablica[i, j] = z++;
                        }
                    }
                    for (int i = m - 2 - k; i < n + 3 + k; i++)
                    {
                        for (int j = m - 2 - k; j > m - 3 - k; j--)
                        {
                            tablica[i, j] = z++;
                        }
                    }
                    for (int i = n + 2 + k; i > n + 1 + k; i--)
                    {
                        for (int j = m - 1 - k; j < m + 1 + k; j++)
                        {
                            tablica[i, j] = z++;
                        }
                    }
                    for (int i = n + 2 + k; i > m - 3 - k; i--)
                    {
                        for (int j = m + 1 + k; j > m + k; j--)
                        {
                            tablica[i, j] = z++;
                        }
                    }
                    ++k;
                }
            }

            else if (x < y)
            {
                for (int a = brojOkretaja; a > 0; a--)
                {
                    for (int i = m - 1 - k; i > m - 2 - k; i--)
                    {
                        for (int j = n + k; j > m - 1 - k; j--)
                        {
                            tablica[i, j] = z++;
                        }
                    }
                    for (int i = m - 1 - k; i < m + 1 + k; i++)
                    {
                        for (int j = m - 1 - k; j > m - 2 - k; j--)
                        {
                            tablica[i, j] = z++;
                        }
                    }
                    for (int i = m + k; i > m - 1 + k; i--)
                    {
                        for (int j = m - k; j < n + 1 + k; j++)
                        {
                            tablica[i, j] = z++;
                        }
                    }
                    for (int i = m + k; i > m - 2 - k; i--)
                    {
                        for (int j = n + 1 + k; j > n + k; j--)
                        {
                            tablica[i, j] = z++;
                        }
                    }
                    ++k;
                }
            }

            FunkcijaZaPrikazTablice.Tablica(tablica);
        }



        public static void ParniRazGDAC(int x, int y)
        {
            int z = x * y;
            int min = x > y ? y : x;
            int max = x > y ? x : y;
            int m = min / 2;
            int brojOkretaja = min / 2;
            int n = m + max - min - 1;
            int[,] tablica = new int[x, y];
            int k = 0;


            if (x > y)
            {
                for (int a = brojOkretaja; a > 0; a--)
                {

                    for (int i = m - k; i < n + 1 + k; i++)
                    {
                        for (int j = m + k; j > m - 1 + k; j--)
                        {
                            tablica[i, j] = z--;
                        }
                    }
                    for (int i = n + 1 + k; i > n + k; i--)
                    {
                        for (int j = m + k; j > m - 2 - k; j--)
                        {
                            tablica[i, j] = z--;
                        }
                    }
                    for (int i = n + k; i > m - 1 - k; i--)
                    {
                        for (int j = m - 1 - k; j > m - 2 - k; j--)
                        {
                            tablica[i, j] = z--;
                        }
                    }
                    for (int i = m - 1 - k; i > m - 2 - k; i--)
                    {
                        for (int j = m - 1 - k; j < m + 1 + k; j++)
                        {
                            tablica[i, j] = z--;
                        }
                    }
                    ++k;
                } 
            }

            else if (x < y)
            {
                for (int i = m; i > m-1; i--)
                {
                    for (int j = n+1; j > m-2; j--)
                    {
                        tablica[i, j] = z--;
                    }
                }
                for (int i = m-1; i > m-2; i--)
                {
                    for (int j = m-1; j < n+2; j++)
                    {
                        tablica[i, j] = z--;
                    }
                }


                for (int a = brojOkretaja - 1; a > 0; a--)
                {
                    for (int i = m-1-k; i < m+1+k; i++)
                    {
                        for (int j = n+2+k; j > n+1+k; j--)
                        {
                            tablica[i, j] = z--;
                        }
                    }
                    for (int i = m+1+k; i > m+k; i--)
                    {
                        for (int j = n+2+k; j > m-3-k; j--)
                        {
                            tablica[i, j] = z--;
                        }
                    }
                    for (int i = m+k; i > m-2-k; i--)
                    {
                        for (int j = m-2-k; j > m-3-k; j--)
                        {
                            tablica[i, j] = z--;
                        }
                    }
                    for (int i = m-2-k; i > m-3-k; i--)
                    {
                        for (int j = m-2-k; j < n+3+k; j++)
                        {
                            tablica[i, j] = z--;
                        }
                    }
                    ++k;
                }
            }

            FunkcijaZaPrikazTablice.Tablica(tablica);
        }


        public static void ParniRazGDACos(int x, int y)
        {
            int z = 1;
            int min = x > y ? y : x;
            int max = x > y ? x : y;
            int m = min / 2;
            int brojOkretaja = min / 2;
            int n = m + max - min - 1;
            int[,] tablica = new int[x, y];
            int k = 0;


            if (x > y)
            {
                for (int a = brojOkretaja; a > 0; a--)
                {

                    for (int i = m - k; i < n + 1 + k; i++)
                    {
                        for (int j = m + k; j > m - 1 + k; j--)
                        {
                            tablica[i, j] = z++;
                        }
                    }
                    for (int i = n + 1 + k; i > n + k; i--)
                    {
                        for (int j = m + k; j > m - 2 - k; j--)
                        {
                            tablica[i, j] = z++;
                        }
                    }
                    for (int i = n + k; i > m - 1 - k; i--)
                    {
                        for (int j = m - 1 - k; j > m - 2 - k; j--)
                        {
                            tablica[i, j] = z++;
                        }
                    }
                    for (int i = m - 1 - k; i > m - 2 - k; i--)
                    {
                        for (int j = m - 1 - k; j < m + 1 + k; j++)
                        {
                            tablica[i, j] = z++;
                        }
                    }
                    ++k;
                }
            }

            else if (x < y)
            {
                for (int i = m; i > m - 1; i--)
                {
                    for (int j = n + 1; j > m - 2; j--)
                    {
                        tablica[i, j] = z++;
                    }
                }
                for (int i = m - 1; i > m - 2; i--)
                {
                    for (int j = m - 1; j < n + 2; j++)
                    {
                        tablica[i, j] = z++;
                    }
                }


                for (int a = brojOkretaja - 1; a > 0; a--)
                {
                    for (int i = m - 1 - k; i < m + 1 + k; i++)
                    {
                        for (int j = n + 2 + k; j > n + 1 + k; j--)
                        {
                            tablica[i, j] = z++;
                        }
                    }
                    for (int i = m + 1 + k; i > m + k; i--)
                    {
                        for (int j = n + 2 + k; j > m - 3 - k; j--)
                        {
                            tablica[i, j] = z++;
                        }
                    }
                    for (int i = m + k; i > m - 2 - k; i--)
                    {
                        for (int j = m - 2 - k; j > m - 3 - k; j--)
                        {
                            tablica[i, j] = z++;
                        }
                    }
                    for (int i = m - 2 - k; i > m - 3 - k; i--)
                    {
                        for (int j = m - 2 - k; j < n + 3 + k; j++)
                        {
                            tablica[i, j] = z++;
                        }
                    }
                    ++k;
                }
            }

            FunkcijaZaPrikazTablice.Tablica(tablica);
        }

    }
}
