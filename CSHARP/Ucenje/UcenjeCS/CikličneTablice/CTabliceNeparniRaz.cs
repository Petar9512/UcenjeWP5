using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.CikličneTablice
{
    internal class CTabliceNeparniRaz
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
                if (x > y)
                {
                    tablica[m + a, m] = z--;
                }
                else if (x < y)
                {
                    tablica[m, m + a] = z--;
                }
            }

            if (x > y)
            {

                for (int b = brojOkretaja; b > 0; b--)
                {
                    for (int i = n + k; i > m - 2 - k; i--)
                    {
                        for (int j = m + 1 + k; j > m + k; j--)
                        {
                            tablica[i, j] = z--;
                        }
                    }
                    for (int i = m - 1 - k; i > m - 2 - k; i--)
                    {
                        for (int j = m + k; j > m - 2 - k; j--)
                        {
                            tablica[i, j] = z--;
                        }
                    }
                    for (int i = m - k; i < n + 2 + k; i++)
                    {
                        for (int j = m - 1 - k; j > m - 2 - k; j--)
                        {
                            tablica[i, j] = z--;
                        }
                    }
                    for (int i = n + 1 + k; i > n + k; i--)
                    {
                        for (int j = m - k; j < m + 2 + k; j++)
                        {
                            tablica[i, j] = z--;
                        }
                    }
                    ++k;
                }
            }

            else if (x < y)
            {
                for (int b = brojOkretaja; b > 0; b--)
                {
                    for (int i = m + k; i > m - 2 - k; i--)
                    {
                        for (int j = n + 1 + k; j > n + k; j--)
                        {
                            tablica[i, j] = z--;
                        }
                    }
                    for (int i = m - 1 - k; i > m - 2 - k; i--)
                    {
                        for (int j = n + k; j > m - 2 - k; j--)
                        {
                            tablica[i, j] = z--;
                        }
                    }
                    for (int i = m - k; i < m + 2 + k; i++)
                    {
                        for (int j = m - 1 - k; j > m - 2 - k; j--)
                        {
                            tablica[i, j] = z--;
                        }
                    }
                    for (int i = m + 1 + k; i > m + k; i--)
                    {
                        for (int j = m - k; j < n + 2 + k; j++)
                        {
                            tablica[i, j] = z--;
                        }
                    }
                    ++k;
                }
            }

            FunkcijaZaPrikazTablice.Tablica(tablica);

        }


        public static void NeparniRazDDCos(int x, int y)
        {
            int z = 1;
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
                if (x > y)
                {
                    tablica[m + a, m] = z++;
                }
                else if (x < y)
                {
                    tablica[m, m + a] = z++;
                }
            }

            if (x > y)
            {

                for (int b = brojOkretaja; b > 0; b--)
                {
                    for (int i = n + k; i > m - 2 - k; i--)
                    {
                        for (int j = m + 1 + k; j > m + k; j--)
                        {
                            tablica[i, j] = z++;
                        }
                    }
                    for (int i = m - 1 - k; i > m - 2 - k; i--)
                    {
                        for (int j = m + k; j > m - 2 - k; j--)
                        {
                            tablica[i, j] = z++;
                        }
                    }
                    for (int i = m - k; i < n + 2 + k; i++)
                    {
                        for (int j = m - 1 - k; j > m - 2 - k; j--)
                        {
                            tablica[i, j] = z++;
                        }
                    }
                    for (int i = n + 1 + k; i > n + k; i--)
                    {
                        for (int j = m - k; j < m + 2 + k; j++)
                        {
                            tablica[i, j] = z++;
                        }
                    }
                    ++k;
                }
            }

            else if (x < y)
            {
                for (int b = brojOkretaja; b > 0; b--)
                {
                    for (int i = m + k; i > m - 2 - k; i--)
                    {
                        for (int j = n + 1 + k; j > n + k; j--)
                        {
                            tablica[i, j] = z++;
                        }
                    }
                    for (int i = m - 1 - k; i > m - 2 - k; i--)
                    {
                        for (int j = n + k; j > m - 2 - k; j--)
                        {
                            tablica[i, j] = z++;
                        }
                    }
                    for (int i = m - k; i < m + 2 + k; i++)
                    {
                        for (int j = m - 1 - k; j > m - 2 - k; j--)
                        {
                            tablica[i, j] = z++;
                        }
                    }
                    for (int i = m + 1 + k; i > m + k; i--)
                    {
                        for (int j = m - k; j < n + 2 + k; j++)
                        {
                            tablica[i, j] = z++;
                        }
                    }
                    ++k;
                }
            }

            FunkcijaZaPrikazTablice.Tablica(tablica);

        }



        public static void NeparniRazDDAC(int x, int y)
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
                if (x > y)
                {
                    tablica[m + a, m] = z--;
                }
                else if (x < y)
                {
                    tablica[m, m + a] = z--;
                }
            }


            if (x > y)
            {
                for (int b = brojOkretaja; b > 0; b--)
                {
                    for (int i = n + 1 + k; i > n + k; i--)
                    {
                        for (int j = m + k; j > m - 2 - k; j--)
                        {
                            tablica[i, j] = z--;
                        }
                    }
                    for (int i = n + k; i > m - 2 - k; i--)
                    {
                        for (int j = m - 1 - k; j > m - 2 - k; j--)
                        {
                            tablica[i, j] = z--;
                        }
                    }
                    for (int i = m - 1 - k; i > m - 2 - k; i--)
                    {
                        for (int j = m - k; j < m + 2 + k; j++)
                        {
                            tablica[i, j] = z--;
                        }
                    }
                    for (int i = m - k; i < n + 2 + k; i++)
                    {
                        for (int j = m + 1 + k; j > m + k; j--)
                        {
                            tablica[i, j] = z--;
                        }
                    }
                    ++k;
                }
            }
            else if (x < y)
            {
                for (int b = brojOkretaja; b > 0; b--)
                {
                    for (int i = m + 1 + k; i > m + k; i--)
                    {
                        for (int j = n + k; j > m - 2 - k; j--)
                        {
                            tablica[i, j] = z--;
                        }
                    }
                    for (int i = m + k; i > m - 2 - k; i--)
                    {
                        for (int j = m - 1 - k; j > m - 2 - k; j--)
                        {
                            tablica[i, j] = z--;
                        }
                    }
                    for (int i = m - 1 - k; i > m - 2 - k; i--)
                    {
                        for (int j = m - k; j < n + 2 + k; j++)
                        {
                            tablica[i, j] = z--;
                        }
                    }
                    for (int i = m - k; i < m + 2 + k; i++)
                    {
                        for (int j = n + 1 + k; j > n + k; j--)
                        {
                            tablica[i, j] = z--;
                        }
                    }
                    ++k;
                }
            }
            FunkcijaZaPrikazTablice.Tablica(tablica);
        }


        public static void NeparniRazDDACos(int x, int y)
        {
            int z = 1;
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
                if (x > y)
                {
                    tablica[m + a, m] = z++;
                }
                else if (x < y)
                {
                    tablica[m, m + a] = z++;
                }
            }


            if (x > y)
            {
                for (int b = brojOkretaja; b > 0; b--)
                {
                    for (int i = n + 1 + k; i > n + k; i--)
                    {
                        for (int j = m + k; j > m - 2 - k; j--)
                        {
                            tablica[i, j] = z++;
                        }
                    }
                    for (int i = n + k; i > m - 2 - k; i--)
                    {
                        for (int j = m - 1 - k; j > m - 2 - k; j--)
                        {
                            tablica[i, j] = z++;
                        }
                    }
                    for (int i = m - 1 - k; i > m - 2 - k; i--)
                    {
                        for (int j = m - k; j < m + 2 + k; j++)
                        {
                            tablica[i, j] = z++;
                        }
                    }
                    for (int i = m - k; i < n + 2 + k; i++)
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
                for (int b = brojOkretaja; b > 0; b--)
                {
                    for (int i = m + 1 + k; i > m + k; i--)
                    {
                        for (int j = n + k; j > m - 2 - k; j--)
                        {
                            tablica[i, j] = z++;
                        }
                    }
                    for (int i = m + k; i > m - 2 - k; i--)
                    {
                        for (int j = m - 1 - k; j > m - 2 - k; j--)
                        {
                            tablica[i, j] = z++;
                        }
                    }
                    for (int i = m - 1 - k; i > m - 2 - k; i--)
                    {
                        for (int j = m - k; j < n + 2 + k; j++)
                        {
                            tablica[i, j] = z++;
                        }
                    }
                    for (int i = m - k; i < m + 2 + k; i++)
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


        public static void NeparniRazDLC(int x, int y)
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


            if (x > y)
            {
                for (int a = 0; a < brojPrveIteracije; a++)
                {


                    tablica[m + a, m] = z--;


                }



                for (int b = brojOkretaja; b > 0; b--)
                {
                    for (int i = n + 1 + k; i > n + k; i--)
                    {
                        for (int j = m - k; j < m + 2 + k; j++)
                        {
                            tablica[i, j] = z--;
                        }
                    }
                    for (int i = n + k; i > m - 2 - k; i--)
                    {
                        for (int j = m + 1 + k; j > m + k; j--)
                        {
                            tablica[i, j] = z--;
                        }
                    }
                    for (int i = m - 1 - k; i > m - 2 - k; i--)
                    {
                        for (int j = m + k; j > m - 2 - k; j--)
                        {
                            tablica[i, j] = z--;
                        }
                    }
                    for (int i = m - k; i < n + 2 + k; i++)
                    {
                        for (int j = m - 1 - k; j > m - 2 - k; j--)
                        {
                            tablica[i, j] = z--;
                        }
                    }
                    ++k;
                }
            }
            else if (x < y)
            {
                for (int a = brojPrveIteracije - 1; a > -1; a--)
                {
                    tablica[m, m + a] = z--;
                }

                for (int b = brojOkretaja; b > 0; b--)
                {
                    for (int i = m + 1 + k; i > m + k; i--)
                    {
                        for (int j = m - k; j < n + 2 + k; j++)
                        {
                            tablica[i, j] = z--;
                        }
                    }
                    for (int i = m + k; i > m - 2 - k; i--)
                    {
                        for (int j = n + 1 + k; j > n + k; j--)
                        {
                            tablica[i, j] = z--;
                        }
                    }
                    for (int i = m - 1 - k; i > m - 2 - k; i--)
                    {
                        for (int j = n + k; j > m - 2 - k; j--)
                        {
                            tablica[i, j] = z--;
                        }
                    }
                    for (int i = m - k; i < m + 2 + k; i++)
                    {
                        for (int j = m - 1 - k; j > m - 2 - k; j--)
                        {
                            tablica[i, j] = z--;
                        }
                    }
                    ++k;
                }
            }
            FunkcijaZaPrikazTablice.Tablica(tablica);
        }


        public static void NeparniRazDLCos(int x, int y)
        {
            int z = 1;
            int min = x > y ? y : x;
            int max = x > y ? x : y;
            int m = min / 2;
            int brojOkretaja = min / 2;
            int brojPrveIteracije = max - min + 1;
            int n = m + max - min;
            int[,] tablica = new int[x, y];
            int k = 0;


            if (x > y)
            {
                for (int a = 0; a < brojPrveIteracije; a++)
                {


                    tablica[m + a, m] = z++;


                }



                for (int b = brojOkretaja; b > 0; b--)
                {
                    for (int i = n + 1 + k; i > n + k; i--)
                    {
                        for (int j = m - k; j < m + 2 + k; j++)
                        {
                            tablica[i, j] = z++;
                        }
                    }
                    for (int i = n + k; i > m - 2 - k; i--)
                    {
                        for (int j = m + 1 + k; j > m + k; j--)
                        {
                            tablica[i, j] = z++;
                        }
                    }
                    for (int i = m - 1 - k; i > m - 2 - k; i--)
                    {
                        for (int j = m + k; j > m - 2 - k; j--)
                        {
                            tablica[i, j] = z++;
                        }
                    }
                    for (int i = m - k; i < n + 2 + k; i++)
                    {
                        for (int j = m - 1 - k; j > m - 2 - k; j--)
                        {
                            tablica[i, j] = z++;
                        }
                    }
                    ++k;
                }
            }
            else if (x < y)
            {
                for (int a = brojPrveIteracije - 1; a > -1; a--)
                {
                    tablica[m, m + a] = z++;
                }

                for (int b = brojOkretaja; b > 0; b--)
                {
                    for (int i = m + 1 + k; i > m + k; i--)
                    {
                        for (int j = m - k; j < n + 2 + k; j++)
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
                    for (int i = m - 1 - k; i > m - 2 - k; i--)
                    {
                        for (int j = n + k; j > m - 2 - k; j--)
                        {
                            tablica[i, j] = z++;
                        }
                    }
                    for (int i = m - k; i < m + 2 + k; i++)
                    {
                        for (int j = m - 1 - k; j > m - 2 - k; j--)
                        {
                            tablica[i, j] = z++;
                        }
                    }
                    ++k;
                }
            }
            FunkcijaZaPrikazTablice.Tablica(tablica);
        }


        public static void NeparniRazDLAC(int x, int y)
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


            if (x > y)
            {
                for (int a = 0; a < brojPrveIteracije; a++)
                {
                    tablica[m + a, m] = z--;
                }




                for (int b = brojOkretaja; b > 0; b--)
                {
                    for (int i = n + k; i > m - 2 - k; i--)
                    {
                        for (int j = m - 1 - k; j > m - 2 - k; j--)
                        {
                            tablica[i, j] = z--;
                        }
                    }
                    for (int i = m - 1 - k; i > m - 2 - k; i--)
                    {
                        for (int j = m - k; j < m + 2 + k; j++)
                        {
                            tablica[i, j] = z--;
                        }
                    }
                    for (int i = m - k; i < n + 2 + k; i++)
                    {
                        for (int j = m + 1 + k; j > m + k; j--)
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
                    ++k;
                }
            }
            else if (x < y)
            {
                for (int a = brojPrveIteracije - 1; a > -1; a--)
                {
                    tablica[m, m + a] = z--;
                }

                for (int b = brojOkretaja; b > 0; b--)
                {
                    for (int i = m + k; i > m - 2 - k; i--)
                    {
                        for (int j = m - 1 - k; j > m - 2 - k; j--)
                        {
                            tablica[i, j] = z--;
                        }
                    }
                    for (int i = m - 1 - k; i > m - 2 - k; i--)
                    {
                        for (int j = m - k; j < n + 2 + k; j++)
                        {
                            tablica[i, j] = z--;
                        }
                    }
                    for (int i = m - k; i < m + 2 + k; i++)
                    {
                        for (int j = n + 1 + k; j > n + k; j--)
                        {
                            tablica[i, j] = z--;
                        }
                    }
                    for (int i = m + 1 + k; i > m + k; i--)
                    {
                        for (int j = n + k; j > m - 2 - k; j--)
                        {
                            tablica[i, j] = z--;
                        }
                    }
                    ++k;
                }
            }
            FunkcijaZaPrikazTablice.Tablica(tablica);
        }


        public static void NeparniRazDLACos(int x, int y)
        {
            int z = 1;
            int min = x > y ? y : x;
            int max = x > y ? x : y;
            int m = min / 2;
            int brojOkretaja = min / 2;
            int brojPrveIteracije = max - min + 1;
            int n = m + max - min;
            int[,] tablica = new int[x, y];
            int k = 0;


            if (x > y)
            {
                for (int a = 0; a < brojPrveIteracije; a++)
                {
                    tablica[m + a, m] = z++;
                }




                for (int b = brojOkretaja; b > 0; b--)
                {
                    for (int i = n + k; i > m - 2 - k; i--)
                    {
                        for (int j = m - 1 - k; j > m - 2 - k; j--)
                        {
                            tablica[i, j] = z++;
                        }
                    }
                    for (int i = m - 1 - k; i > m - 2 - k; i--)
                    {
                        for (int j = m - k; j < m + 2 + k; j++)
                        {
                            tablica[i, j] = z++;
                        }
                    }
                    for (int i = m - k; i < n + 2 + k; i++)
                    {
                        for (int j = m + 1 + k; j > m + k; j--)
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
                    ++k;
                }
            }
            else if (x < y)
            {
                for (int a = brojPrveIteracije - 1; a > -1; a--)
                {
                    tablica[m, m + a] = z++;
                }

                for (int b = brojOkretaja; b > 0; b--)
                {
                    for (int i = m + k; i > m - 2 - k; i--)
                    {
                        for (int j = m - 1 - k; j > m - 2 - k; j--)
                        {
                            tablica[i, j] = z++;
                        }
                    }
                    for (int i = m - 1 - k; i > m - 2 - k; i--)
                    {
                        for (int j = m - k; j < n + 2 + k; j++)
                        {
                            tablica[i, j] = z++;
                        }
                    }
                    for (int i = m - k; i < m + 2 + k; i++)
                    {
                        for (int j = n + 1 + k; j > n + k; j--)
                        {
                            tablica[i, j] = z++;
                        }
                    }
                    for (int i = m + 1 + k; i > m + k; i--)
                    {
                        for (int j = n + k; j > m - 2 - k; j--)
                        {
                            tablica[i, j] = z++;
                        }
                    }
                    ++k;
                }
            }
            FunkcijaZaPrikazTablice.Tablica(tablica);
        }


        public static void NeparniRazGLC(int x, int y)
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


            if (x > y)
            {
                for (int a = brojPrveIteracije - 1; a > -1; a--)
                {
                    tablica[m + a, m] = z--;
                }

                for (int b = brojOkretaja; b > 0; b--)
                {
                    for (int i = m - k; i < n + 2 + k; i++)
                    {
                        for (int j = m - 1 - k; j > m - 2 - k; j--)
                        {
                            tablica[i, j] = z--;
                        }
                    }
                    for (int i = n + 1 + k; i > n + k; i--)
                    {
                        for (int j = m - k; j < m + 2 + k; j++)
                        {
                            tablica[i, j] = z--;
                        }
                    }
                    for (int i = n + k; i > m - 2 - k; i--)
                    {
                        for (int j = m + 1 + k; j > m + k; j--)
                        {
                            tablica[i, j] = z--;
                        }
                    }
                    for (int i = m - 1 - k; i > m - 2 - k; i--)
                    {
                        for (int j = m + k; j > m - 2 - k; j--)
                        {
                            tablica[i, j] = z--;
                        }
                    }
                    ++k;
                }
            }
            else if (x < y)
            {
                for (int a = brojPrveIteracije - 1; a > -1; a--)
                {
                    tablica[m, m + a] = z--;
                }

                for (int b = brojOkretaja; b > 0; b--)
                {
                    for (int i = m - k; i < m + 2 + k; i++)
                    {
                        for (int j = m - 1 - k; j > m - 2 - k; j--)
                        {
                            tablica[i, j] = z--;
                        }
                    }
                    for (int i = m + 1 + k; i > m + k; i--)
                    {
                        for (int j = m - k; j < n + 2 + k; j++)
                        {
                            tablica[i, j] = z--;
                        }
                    }
                    for (int i = m + k; i > m - 2 - k; i--)
                    {
                        for (int j = n + 1 + k; j > n + k; j--)
                        {
                            tablica[i, j] = z--;
                        }
                    }
                    for (int i = m - 1 - k; i > m - 2 - k; i--)
                    {
                        for (int j = n + k; j > m - 2 - k; j--)
                        {
                            tablica[i, j] = z--;
                        }
                    }
                    ++k;
                }
            }
            FunkcijaZaPrikazTablice.Tablica(tablica);
        }


        public static void NeparniRazGLCos(int x, int y)
        {
            int z = 1;
            int min = x > y ? y : x;
            int max = x > y ? x : y;
            int m = min / 2;
            int brojOkretaja = min / 2;
            int brojPrveIteracije = max - min + 1;
            int n = m + max - min;
            int[,] tablica = new int[x, y];
            int k = 0;


            if (x > y)
            {
                for (int a = brojPrveIteracije - 1; a > -1; a--)
                {
                    tablica[m + a, m] = z++;
                }

                for (int b = brojOkretaja; b > 0; b--)
                {
                    for (int i = m - k; i < n + 2 + k; i++)
                    {
                        for (int j = m - 1 - k; j > m - 2 - k; j--)
                        {
                            tablica[i, j] = z++;
                        }
                    }
                    for (int i = n + 1 + k; i > n + k; i--)
                    {
                        for (int j = m - k; j < m + 2 + k; j++)
                        {
                            tablica[i, j] = z++;
                        }
                    }
                    for (int i = n + k; i > m - 2 - k; i--)
                    {
                        for (int j = m + 1 + k; j > m + k; j--)
                        {
                            tablica[i, j] = z++;
                        }
                    }
                    for (int i = m - 1 - k; i > m - 2 - k; i--)
                    {
                        for (int j = m + k; j > m - 2 - k; j--)
                        {
                            tablica[i, j] = z++;
                        }
                    }
                    ++k;
                }
            }
            else if (x < y)
            {
                for (int a = brojPrveIteracije - 1; a > -1; a--)
                {
                    tablica[m, m + a] = z++;
                }

                for (int b = brojOkretaja; b > 0; b--)
                {
                    for (int i = m - k; i < m + 2 + k; i++)
                    {
                        for (int j = m - 1 - k; j > m - 2 - k; j--)
                        {
                            tablica[i, j] = z++;
                        }
                    }
                    for (int i = m + 1 + k; i > m + k; i--)
                    {
                        for (int j = m - k; j < n + 2 + k; j++)
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
                    for (int i = m - 1 - k; i > m - 2 - k; i--)
                    {
                        for (int j = n + k; j > m - 2 - k; j--)
                        {
                            tablica[i, j] = z++;
                        }
                    }
                    ++k;
                }
            }
            FunkcijaZaPrikazTablice.Tablica(tablica);
        }


        public static void NeparniRazGLAC(int x, int y)
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


            if (x > y)
            {
                for (int a = brojPrveIteracije - 1; a > -1; a--)
                {
                    tablica[m + a, m] = z--;
                }

                for (int b = brojOkretaja; b > 0; b--)
                {
                    for (int i = m - 1 - k; i > m - 2 - k; i--)
                    {
                        for (int j = m - k; j < m + 2 + k; j++)
                        {
                            tablica[i, j] = z--;
                        }
                    }
                    for (int i = m - k; i < n + 2 + k; i++)
                    {
                        for (int j = m + 1 + k; j > m + k; j--)
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
                    for (int i = n + k; i > m - 2 - k; i--)
                    {
                        for (int j = m - 1 - k; j > m - 2 - k; j--)
                        {
                            tablica[i, j] = z--;
                        }
                    }
                    ++k;
                }
            }
            else if (x < y)
            {
                for (int a = brojPrveIteracije - 1; a > -1; a--)
                {
                    tablica[m, m + a] = z--;
                }

                for (int b = brojOkretaja; b > 0; b--)
                {
                    for (int i = m - 1 - k; i > m - 2 - k; i--)
                    {
                        for (int j = m - k; j < n + 2 + k; j++)
                        {
                            tablica[i, j] = z--;
                        }
                    }
                    for (int i = m - k; i < m + 2 + k; i++)
                    {
                        for (int j = n + 1 + k; j > n + k; j--)
                        {
                            tablica[i, j] = z--;
                        }
                    }
                    for (int i = m + 1 + k; i > m + k; i--)
                    {
                        for (int j = n + k; j > m - 2 - k; j--)
                        {
                            tablica[i, j] = z--;
                        }
                    }
                    for (int i = m + k; i > m - 2 - k; i--)
                    {
                        for (int j = m - 1 - k; j > m - 2 - k; j--)
                        {
                            tablica[i, j] = z--;
                        }
                    }
                    ++k;
                }
            }
            FunkcijaZaPrikazTablice.Tablica(tablica);
        }


        public static void NeparniRazGLACos(int x, int y)
        {
            int z = 1;
            int min = x > y ? y : x;
            int max = x > y ? x : y;
            int m = min / 2;
            int brojOkretaja = min / 2;
            int brojPrveIteracije = max - min + 1;
            int n = m + max - min;
            int[,] tablica = new int[x, y];
            int k = 0;


            if (x > y)
            {
                for (int a = brojPrveIteracije - 1; a > -1; a--)
                {
                    tablica[m + a, m] = z++;
                }

                for (int b = brojOkretaja; b > 0; b--)
                {
                    for (int i = m - 1 - k; i > m - 2 - k; i--)
                    {
                        for (int j = m - k; j < m + 2 + k; j++)
                        {
                            tablica[i, j] = z++;
                        }
                    }
                    for (int i = m - k; i < n + 2 + k; i++)
                    {
                        for (int j = m + 1 + k; j > m + k; j--)
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
                    for (int i = n + k; i > m - 2 - k; i--)
                    {
                        for (int j = m - 1 - k; j > m - 2 - k; j--)
                        {
                            tablica[i, j] = z++;
                        }
                    }
                    ++k;
                }
            }
            else if (x < y)
            {
                for (int a = brojPrveIteracije - 1; a > -1; a--)
                {
                    tablica[m, m + a] = z++;
                }

                for (int b = brojOkretaja; b > 0; b--)
                {
                    for (int i = m - 1 - k; i > m - 2 - k; i--)
                    {
                        for (int j = m - k; j < n + 2 + k; j++)
                        {
                            tablica[i, j] = z++;
                        }
                    }
                    for (int i = m - k; i < m + 2 + k; i++)
                    {
                        for (int j = n + 1 + k; j > n + k; j--)
                        {
                            tablica[i, j] = z++;
                        }
                    }
                    for (int i = m + 1 + k; i > m + k; i--)
                    {
                        for (int j = n + k; j > m - 2 - k; j--)
                        {
                            tablica[i, j] = z++;
                        }
                    }
                    for (int i = m + k; i > m - 2 - k; i--)
                    {
                        for (int j = m - 1 - k; j > m - 2 - k; j--)
                        {
                            tablica[i, j] = z++;
                        }
                    }
                    ++k;
                }
            }
            FunkcijaZaPrikazTablice.Tablica(tablica);
        }


        public static void NeparniRazGDC(int x, int y)
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


            if (x > y)
            {
                for (int a = brojPrveIteracije - 1; a > -1; a--)
                {
                    tablica[m + a, m] = z--;
                }


                for (int b = brojOkretaja; b > 0; b--)
                {
                    for (int i = m - 1 - k; i > m - 2 - k; i--)
                    {
                        for (int j = m + k; j > m - 2 - k; j--)
                        {
                            tablica[i, j] = z--;
                        }
                    }
                    for (int i = m - k; i < n + 2 + k; i++)
                    {
                        for (int j = m - 1 - k; j > m - 2 - k; j--)
                        {
                            tablica[i, j] = z--;
                        }
                    }
                    for (int i = n + 1 + k; i > n + k; i--)
                    {
                        for (int j = m - k; j < m + 2 + k; j++)
                        {
                            tablica[i, j] = z--;
                        }
                    }
                    for (int i = n + k; i > m - 2 - k; i--)
                    {
                        for (int j = m + 1 + k; j > m + k; j--)
                        {
                            tablica[i, j] = z--;
                        }
                    }
                    ++k;
                }
            }
            else if (x < y)
            {
                for (int a = 0; a < brojPrveIteracije; a++)
                {
                    tablica[m, m + a] = z--;
                }

                for (int b = brojOkretaja; b > 0; b--)
                {
                    for (int i = m - 1 - k; i > m - 2 - k; i--)
                    {
                        for (int j = n + k; j > m - 2 - k; j--)
                        {
                            tablica[i, j] = z--;
                        }
                    }
                    for (int i = m - k; i < m + 2 + k; i++)
                    {
                        for (int j = m - 1 - k; j > m - 2 - k; j--)
                        {
                            tablica[i, j] = z--;
                        }
                    }
                    for (int i = m + 1 + k; i > m + k; i--)
                    {
                        for (int j = m - k; j < n + 2 + k; j++)
                        {
                            tablica[i, j] = z--;
                        }
                    }
                    for (int i = m + k; i > m - 2 - k; i--)
                    {
                        for (int j = n + 1 + k; j > n + k; j--)
                        {
                            tablica[i, j] = z--;
                        }
                    }
                    ++k;
                }
            }
            FunkcijaZaPrikazTablice.Tablica(tablica);
        }


        public static void NeparniRazGDCos(int x, int y)
        {
            int z = 1;
            int min = x > y ? y : x;
            int max = x > y ? x : y;
            int m = min / 2;
            int brojOkretaja = min / 2;
            int brojPrveIteracije = max - min + 1;
            int n = m + max - min;
            int[,] tablica = new int[x, y];
            int k = 0;


            if (x > y)
            {
                for (int a = brojPrveIteracije - 1; a > -1; a--)
                {
                    tablica[m + a, m] = z++;
                }


                for (int b = brojOkretaja; b > 0; b--)
                {
                    for (int i = m - 1 - k; i > m - 2 - k; i--)
                    {
                        for (int j = m + k; j > m - 2 - k; j--)
                        {
                            tablica[i, j] = z++;
                        }
                    }
                    for (int i = m - k; i < n + 2 + k; i++)
                    {
                        for (int j = m - 1 - k; j > m - 2 - k; j--)
                        {
                            tablica[i, j] = z++;
                        }
                    }
                    for (int i = n + 1 + k; i > n + k; i--)
                    {
                        for (int j = m - k; j < m + 2 + k; j++)
                        {
                            tablica[i, j] = z++;
                        }
                    }
                    for (int i = n + k; i > m - 2 - k; i--)
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
                for (int a = 0; a < brojPrveIteracije; a++)
                {
                    tablica[m, m + a] = z++;
                }

                for (int b = brojOkretaja; b > 0; b--)
                {
                    for (int i = m - 1 - k; i > m - 2 - k; i--)
                    {
                        for (int j = n + k; j > m - 2 - k; j--)
                        {
                            tablica[i, j] = z++;
                        }
                    }
                    for (int i = m - k; i < m + 2 + k; i++)
                    {
                        for (int j = m - 1 - k; j > m - 2 - k; j--)
                        {
                            tablica[i, j] = z++;
                        }
                    }
                    for (int i = m + 1 + k; i > m + k; i--)
                    {
                        for (int j = m - k; j < n + 2 + k; j++)
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


        public static void NeparniRazGDAC(int x, int y)
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


            if (x > y)
            {
                for (int a = brojPrveIteracije - 1; a > -1; a--)
                {
                    tablica[m + a, m] = z--;
                }

                for (int b = brojOkretaja; b > 0; b--)
                {
                    for (int i = m - k; i < n + 2 + k; i++)
                    {
                        for (int j = m + 1 + k; j > m + k; j--)
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
                    for (int i = n + k; i > m - 2 - k; i--)
                    {
                        for (int j = m - 1 - k; j > m - 2 - k; j--)
                        {
                            tablica[i, j] = z--;
                        }
                    }
                    for (int i = m - 1 - k; i > m - 2 - k; i--)
                    {
                        for (int j = m - k; j < m + 2 + k; j++)
                        {
                            tablica[i, j] = z--;
                        }
                    }
                    ++k;
                }
            }

            else if (x < y)
            {
                for (int a = 0; a < brojPrveIteracije; a++)
                {
                    tablica[m, m + a] = z--;
                }

                for (int b = brojOkretaja; b > 0; b--)
                {
                    for (int i = m - k; i < m + 2 + k; i++)
                    {
                        for (int j = n + 1 + k; j > n + k; j--)
                        {
                            tablica[i, j] = z--;
                        }
                    }
                    for (int i = m + 1 + k; i > m + k; i--)
                    {
                        for (int j = n + k; j > m - 2 - k; j--)
                        {
                            tablica[i, j] = z--;
                        }
                    }
                    for (int i = m + k; i > m - 2 - k; i--)
                    {
                        for (int j = m - 1 - k; j > m - 2 - k; j--)
                        {
                            tablica[i, j] = z--;
                        }
                    }
                    for (int i = m - 1 - k; i > m - 2 - k; i--)
                    {
                        for (int j = m - k; j < n + 2 + k; j++)
                        {
                            tablica[i, j] = z--;
                        }
                    }
                    ++k;
                }
            }
            FunkcijaZaPrikazTablice.Tablica(tablica);
        }


        public static void NeparniRazGDACos(int x, int y)
        {
            int z = 1;
            int min = x > y ? y : x;
            int max = x > y ? x : y;
            int m = min / 2;
            int brojOkretaja = min / 2;
            int brojPrveIteracije = max - min + 1;
            int n = m + max - min;
            int[,] tablica = new int[x, y];
            int k = 0;


            if (x > y)
            {
                for (int a = brojPrveIteracije - 1; a > -1; a--)
                {
                    tablica[m + a, m] = z++;
                }

                for (int b = brojOkretaja; b > 0; b--)
                {
                    for (int i = m - k; i < n + 2 + k; i++)
                    {
                        for (int j = m + 1 + k; j > m + k; j--)
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
                    for (int i = n + k; i > m - 2 - k; i--)
                    {
                        for (int j = m - 1 - k; j > m - 2 - k; j--)
                        {
                            tablica[i, j] = z++;
                        }
                    }
                    for (int i = m - 1 - k; i > m - 2 - k; i--)
                    {
                        for (int j = m - k; j < m + 2 + k; j++)
                        {
                            tablica[i, j] = z++;
                        }
                    }
                    ++k;
                }
            }

            else if (x < y)
            {
                for (int a = 0; a < brojPrveIteracije; a++)
                {
                    tablica[m, m + a] = z++;
                }

                for (int b = brojOkretaja; b > 0; b--)
                {
                    for (int i = m - k; i < m + 2 + k; i++)
                    {
                        for (int j = n + 1 + k; j > n + k; j--)
                        {
                            tablica[i, j] = z++;
                        }
                    }
                    for (int i = m + 1 + k; i > m + k; i--)
                    {
                        for (int j = n + k; j > m - 2 - k; j--)
                        {
                            tablica[i, j] = z++;
                        }
                    }
                    for (int i = m + k; i > m - 2 - k; i--)
                    {
                        for (int j = m - 1 - k; j > m - 2 - k; j--)
                        {
                            tablica[i, j] = z++;
                        }
                    }
                    for (int i = m - 1 - k; i > m - 2 - k; i--)
                    {
                        for (int j = m - k; j < n + 2 + k; j++)
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
