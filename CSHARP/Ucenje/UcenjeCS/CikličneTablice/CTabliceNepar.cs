using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.CikličneTablice
{
    internal class CTabliceNepar
    {



        public static void NeparniDDC(int x)
        {

            int y = x * x;

            int[,] tablica = new int[x, x];
            int m = x / 2;
            int k = 0;

            int brojOkretaja = x / 2;
            tablica[m, m] = y--;



            for (int a = brojOkretaja; a > 0; a--)
            {
                for (int i = m + k; i > m - 2 - k; i--)
                {
                    for (int j = m + 1 + k; j > m + k; j--)
                    {
                        tablica[i, j] = y--;
                    }
                }
                for (int i = m - 1 - k; i > m - 2 - k; i--)
                {
                    for (int j = m + k; j > m - 2 - k; j--)
                    {
                        tablica[i, j] = y--;
                    }
                }
                for (int i = m - k; i < m + 2 + k; i++)
                {
                    for (int j = m - 1 - k; j > m - 2 - k; j--)
                    {
                        tablica[i, j] = y--;
                    }
                }
                for (int i = m + 1 + k; i > m + k; i--)
                {
                    for (int j = m - k; j < m + 2 + k; j++)
                    {
                        tablica[i, j] = y--;
                    }
                }
                ++k;
            }

            FunkcijaZaPrikazTablice.Tablica(tablica);

        }


        public static void NeparniDDAC(int x)
        {
            int y = x * x;
            int[,] tablica = new int[x, x];
            int m = x / 2;
            int k = 0;

            int brojOkretaja = x / 2;
            tablica[m, m] = y--;



            for (int a = brojOkretaja; a > 0; a--)
            {
                for (int i = m + 1 + k; i > m + k; i--)
                {
                    for (int j = m + k; j > m - 2 - k; j--)
                    {
                        tablica[i, j] = y--;
                    }
                }
                for (int i = m + k; i > m - 2 - k; i--)
                {
                    for (int j = m - 1 - k; j > m - 2 - k; j--)
                    {
                        tablica[i, j] = y--;
                    }
                }
                for (int i = m - 1 - k; i > m - 2 - k; i--)
                {
                    for (int j = m - k; j < m + 2 + k; j++)
                    {
                        tablica[i, j] = y--;
                    }
                }
                for (int i = m - k; i < m + 2 + k; i++)
                {
                    for (int j = m + 1 + k; j > m + k; j--)
                    {
                        tablica[i, j] = y--;
                    }
                }
                ++k;
            }

            FunkcijaZaPrikazTablice.Tablica(tablica);

        }

        public static void NeparniDDCos(int x)
        {

            int y = 1;

            int[,] tablica = new int[x, x];
            int m = x / 2;
            int k = 0;

            int brojOkretaja = x / 2;
            tablica[m, m] = y++;



            for (int a = brojOkretaja; a > 0; a--)
            {
                for (int i = m + k; i > m - 2 - k; i--)
                {
                    for (int j = m + 1 + k; j > m + k; j--)
                    {
                        tablica[i, j] = y++;
                    }
                }
                for (int i = m - 1 - k; i > m - 2 - k; i--)
                {
                    for (int j = m + k; j > m - 2 - k; j--)
                    {
                        tablica[i, j] = y++;
                    }
                }
                for (int i = m - k; i < m + 2 + k; i++)
                {
                    for (int j = m - 1 - k; j > m - 2 - k; j--)
                    {
                        tablica[i, j] = y++;
                    }
                }
                for (int i = m + 1 + k; i > m + k; i--)
                {
                    for (int j = m - k; j < m + 2 + k; j++)
                    {
                        tablica[i, j] = y++;
                    }
                }
                ++k;
            }

            FunkcijaZaPrikazTablice.Tablica(tablica);

        }

        public static void NeparniDDACos(int x)
        {
            int y = 1;
            int[,] tablica = new int[x, x];
            int m = x / 2;
            int k = 0;

            int brojOkretaja = x / 2;
            tablica[m, m] = y++;



            for (int a = brojOkretaja; a > 0; a--)
            {
                for (int i = m + 1 + k; i > m + k; i--)
                {
                    for (int j = m + k; j > m - 2 - k; j--)
                    {
                        tablica[i, j] = y++;
                    }
                }
                for (int i = m + k; i > m - 2 - k; i--)
                {
                    for (int j = m - 1 - k; j > m - 2 - k; j--)
                    {
                        tablica[i, j] = y++;
                    }
                }
                for (int i = m - 1 - k; i > m - 2 - k; i--)
                {
                    for (int j = m - k; j < m + 2 + k; j++)
                    {
                        tablica[i, j] = y++;
                    }
                }
                for (int i = m - k; i < m + 2 + k; i++)
                {
                    for (int j = m + 1 + k; j > m + k; j--)
                    {
                        tablica[i, j] = y++;
                    }
                }
                ++k;
            }

            FunkcijaZaPrikazTablice.Tablica(tablica);

        }


        public static void NeparniDLC(int x)
        {
            int y = x * x;

            int[,] tablica = new int[x, x];
            int m = x / 2;
            int k = 0;

            int brojOkretaja = x / 2;
            tablica[m, m] = y--;



            for (int a = brojOkretaja; a > 0; a--)
            {
                for (int i = m + 1 + k; i > m + k; i--)
                {
                    for (int j = m - k; j < m + 2 + k; j++)
                    {
                        tablica[i, j] = y--;
                    }
                }
                for (int i = m + k; i > m - 2 - k; i--)
                {
                    for (int j = m + 1 + k; j > m + k; j--)
                    {
                        tablica[i, j] = y--;
                    }
                }
                for (int i = m - 1 - k; i > m - 2 - k; i--)
                {
                    for (int j = m + k; j > m - 2 - k; j--)
                    {
                        tablica[i, j] = y--;
                    }
                }
                for (int i = m - k; i < m + 2 + k; i++)
                {
                    for (int j = m - 1 - k; j > m - 2 - k; j--)
                    {
                        tablica[i, j] = y--;
                    }
                }
                ++k;
            }

            FunkcijaZaPrikazTablice.Tablica(tablica);

        }

        public static void NeparniDLAC(int x)
        {
            int y = x * x;

            int[,] tablica = new int[x, x];
            int m = x / 2;
            int k = 0;

            int brojOkretaja = x / 2;
            tablica[m, m] = y--;



            for (int a = brojOkretaja; a > 0; a--)
            {
                for (int i = m + k; i > m - 2 - k; i--)
                {
                    for (int j = m - 1 - k; j > m - 2 - k; j--)
                    {
                        tablica[i, j] = y--;
                    }
                }
                for (int i = m - 1 - k; i > m - 2 - k; i--)
                {
                    for (int j = m - k; j < m + 2 + k; j++)
                    {
                        tablica[i, j] = y--;
                    }
                }
                for (int i = m - k; i < m + 2 + k; i++)
                {
                    for (int j = m + 1 + k; j > m + k; j--)
                    {
                        tablica[i, j] = y--;
                    }
                }
                for (int i = m + 1 + k; i > m + k; i--)
                {
                    for (int j = m + k; j > m - 2 - k; j--)
                    {
                        tablica[i, j] = y--;
                    }
                }
                ++k;
            }

            FunkcijaZaPrikazTablice.Tablica(tablica);

        }

        public static void NeparniDLACos(int x)
        {
            int y = 1;

            int[,] tablica = new int[x, x];
            int m = x / 2;
            int k = 0;

            int brojOkretaja = x / 2;
            tablica[m, m] = y++;



            for (int a = brojOkretaja; a > 0; a--)
            {
                for (int i = m + k; i > m - 2 - k; i--)
                {
                    for (int j = m - 1 - k; j > m - 2 - k; j--)
                    {
                        tablica[i, j] = y++;
                    }
                }
                for (int i = m - 1 - k; i > m - 2 - k; i--)
                {
                    for (int j = m - k; j < m + 2 + k; j++)
                    {
                        tablica[i, j] = y++;
                    }
                }
                for (int i = m - k; i < m + 2 + k; i++)
                {
                    for (int j = m + 1 + k; j > m + k; j--)
                    {
                        tablica[i, j] = y++;
                    }
                }
                for (int i = m + 1 + k; i > m + k; i--)
                {
                    for (int j = m + k; j > m - 2 - k; j--)
                    {
                        tablica[i, j] = y++;
                    }
                }
                ++k;
            }

            FunkcijaZaPrikazTablice.Tablica(tablica);

        }

        public static void NeparniDLCos(int x)
        {
            int y = 1;

            int[,] tablica = new int[x, x];
            int m = x / 2;
            int k = 0;

            int brojOkretaja = x / 2;
            tablica[m, m] = y++;



            for (int a = brojOkretaja; a > 0; a--)
            {
                for (int i = m + 1 + k; i > m + k; i--)
                {
                    for (int j = m - k; j < m + 2 + k; j++)
                    {
                        tablica[i, j] = y++;
                    }
                }
                for (int i = m + k; i > m - 2 - k; i--)
                {
                    for (int j = m + 1 + k; j > m + k; j--)
                    {
                        tablica[i, j] = y++;
                    }
                }
                for (int i = m - 1 - k; i > m - 2 - k; i--)
                {
                    for (int j = m + k; j > m - 2 - k; j--)
                    {
                        tablica[i, j] = y++;
                    }
                }
                for (int i = m - k; i < m + 2 + k; i++)
                {
                    for (int j = m - 1 - k; j > m - 2 - k; j--)
                    {
                        tablica[i, j] = y++;
                    }
                }
                ++k;
            }

            FunkcijaZaPrikazTablice.Tablica(tablica);

        }


        public static void NeparniGLC(int x)
        {
            int y = x * x;

            int[,] tablica = new int[x, x];
            int m = x / 2;
            int k = 0;

            int brojOkretaja = x / 2;
            tablica[m, m] = y--;



            for (int a = brojOkretaja; a > 0; a--)
            {
                for (int i = m - k; i < m + 2 + k; i++)
                {
                    for (int j = m - 1 - k; j > m - 2 - k; j--)
                    {
                        tablica[i, j] = y--;
                    }
                }
                for (int i = m + 1 + k; i > m + k; i--)
                {
                    for (int j = m - k; j < m + 2 + k; j++)
                    {
                        tablica[i, j] = y--;
                    }
                }
                for (int i = m + k; i > m - 2 - k; i--)
                {
                    for (int j = m + 1 + k; j > m + k; j--)
                    {
                        tablica[i, j] = y--;
                    }
                }
                for (int i = m - 1 - k; i > m - 2 - k; i--)
                {
                    for (int j = m + k; j > m - 2 - k; j--)
                    {
                        tablica[i, j] = y--;
                    }
                }
                ++k;
            }

            FunkcijaZaPrikazTablice.Tablica(tablica);

        }

        public static void NeparniGLAC(int x)
        {
            int y = x * x;

            int[,] tablica = new int[x, x];
            int m = x / 2;
            int k = 0;

            int brojOkretaja = x / 2;
            tablica[m, m] = y--;



            for (int a = brojOkretaja; a > 0; a--)
            {
                for (int i = m - 1 - k; i > m - 2 - k; i--)
                {
                    for (int j = m - k; j < m + 2 + k; j++)
                    {
                        tablica[i, j] = y--;
                    }
                }
                for (int i = m - k; i < m + 2 + k; i++)
                {
                    for (int j = m + 1 + k; j > m + k; j--)
                    {
                        tablica[i, j] = y--;
                    }
                }
                for (int i = m + 1 + k; i > m + k; i--)
                {
                    for (int j = m + k; j > m - 2 - k; j--)
                    {
                        tablica[i, j] = y--;
                    }
                }
                for (int i = m + k; i > m - 2 - k; i--)
                {
                    for (int j = m - 1 - k; j > m - 2 - k; j--)
                    {
                        tablica[i, j] = y--;
                    }
                }
                ++k;
            }

            FunkcijaZaPrikazTablice.Tablica(tablica);

        }

        public static void NeparniGLCos(int x)
        {
            int y = 1;

            int[,] tablica = new int[x, x];
            int m = x / 2;
            int k = 0;

            int brojOkretaja = x / 2;
            tablica[m, m] = y++;



            for (int a = brojOkretaja; a > 0; a--)
            {
                for (int i = m - k; i < m + 2 + k; i++)
                {
                    for (int j = m - 1 - k; j > m - 2 - k; j--)
                    {
                        tablica[i, j] = y++;
                    }
                }
                for (int i = m + 1 + k; i > m + k; i--)
                {
                    for (int j = m - k; j < m + 2 + k; j++)
                    {
                        tablica[i, j] = y++;
                    }
                }
                for (int i = m + k; i > m - 2 - k; i--)
                {
                    for (int j = m + 1 + k; j > m + k; j--)
                    {
                        tablica[i, j] = y++;
                    }
                }
                for (int i = m - 1 - k; i > m - 2 - k; i--)
                {
                    for (int j = m + k; j > m - 2 - k; j--)
                    {
                        tablica[i, j] = y++;
                    }
                }
                ++k;
            }

            FunkcijaZaPrikazTablice.Tablica(tablica);

        }

        public static void NeparniGLACos(int x)
        {
            int y = 1;

            int[,] tablica = new int[x, x];
            int m = x / 2;
            int k = 0;

            int brojOkretaja = x / 2;
            tablica[m, m] = y++;



            for (int a = brojOkretaja; a > 0; a--)
            {
                for (int i = m - 1 - k; i > m - 2 - k; i--)
                {
                    for (int j = m - k; j < m + 2 + k; j++)
                    {
                        tablica[i, j] = y++;
                    }
                }
                for (int i = m - k; i < m + 2 + k; i++)
                {
                    for (int j = m + 1 + k; j > m + k; j--)
                    {
                        tablica[i, j] = y++;
                    }
                }
                for (int i = m + 1 + k; i > m + k; i--)
                {
                    for (int j = m + k; j > m - 2 - k; j--)
                    {
                        tablica[i, j] = y++;
                    }
                }
                for (int i = m + k; i > m - 2 - k; i--)
                {
                    for (int j = m - 1 - k; j > m - 2 - k; j--)
                    {
                        tablica[i, j] = y++;
                    }
                }
                ++k;
            }

            FunkcijaZaPrikazTablice.Tablica(tablica);

        }


        public static void NeparniGDC(int x)
        {
            int y = x * x;

            int[,] tablica = new int[x, x];
            int m = x / 2;
            int k = 0;

            int brojOkretaja = x / 2;
            tablica[m, m] = y--;



            for (int a = brojOkretaja; a > 0; a--)
            {
                for (int i = m - 1 - k; i > m - 2 - k; i--)
                {
                    for (int j = m + k; j > m - 2 - k; j--)
                    {
                        tablica[i, j] = y--;
                    }
                }
                for (int i = m - k; i < m + 2 + k; i++)
                {
                    for (int j = m - 1 - k; j > m - 2 - k; j--)
                    {
                        tablica[i, j] = y--;
                    }
                }
                for (int i = m + 1 + k; i > m + k; i--)
                {
                    for (int j = m - k; j < m + 2 + k; j++)
                    {
                        tablica[i, j] = y--;
                    }
                }
                for (int i = m + k; i > m - 2 - k; i--)
                {
                    for (int j = m + 1 + k; j > m + k; j--)
                    {
                        tablica[i, j] = y--;
                    }
                }
                ++k;
            }

            FunkcijaZaPrikazTablice.Tablica(tablica);
        }

        public static void NeparniGDAC(int x)
        {
            int y = x * x;

            int[,] tablica = new int[x, x];
            int m = x / 2;
            int k = 0;

            int brojOkretaja = x / 2;
            tablica[m, m] = y--;



            for (int a = brojOkretaja; a > 0; a--)
            {
                for (int i = m - k; i < m + 2 + k; i++)
                {
                    for (int j = m + 1 + k; j > m + k; j--)
                    {
                        tablica[i, j] = y--;
                    }
                }
                for (int i = m + 1 + k; i > m + k; i--)
                {
                    for (int j = m + k; j > m - 2 - k; j--)
                    {
                        tablica[i, j] = y--;
                    }
                }
                for (int i = m + k; i > m - 2 - k; i--)
                {
                    for (int j = m - 1 - k; j > m - 2 - k; j--)
                    {
                        tablica[i, j] = y--;
                    }
                }
                for (int i = m - 1 - k; i > m - 2 - k; i--)
                {
                    for (int j = m - k; j < m + 2 + k; j++)
                    {
                        tablica[i, j] = y--;
                    }
                }
                ++k;
            }

            FunkcijaZaPrikazTablice.Tablica(tablica);

        }

        public static void NeparniGDCos(int x)
        {
            int y = 1;

            int[,] tablica = new int[x, x];
            int m = x / 2;
            int k = 0;

            int brojOkretaja = x / 2;
            tablica[m, m] = y++;



            for (int a = brojOkretaja; a > 0; a--)
            {
                for (int i = m - 1 - k; i > m - 2 - k; i--)
                {
                    for (int j = m + k; j > m - 2 - k; j--)
                    {
                        tablica[i, j] = y++;
                    }
                }
                for (int i = m - k; i < m + 2 + k; i++)
                {
                    for (int j = m - 1 - k; j > m - 2 - k; j--)
                    {
                        tablica[i, j] = y++;
                    }
                }
                for (int i = m + 1 + k; i > m + k; i--)
                {
                    for (int j = m - k; j < m + 2 + k; j++)
                    {
                        tablica[i, j] = y++;
                    }
                }
                for (int i = m + k; i > m - 2 - k; i--)
                {
                    for (int j = m + 1 + k; j > m + k; j--)
                    {
                        tablica[i, j] = y++;
                    }
                }
                ++k;
            }

            FunkcijaZaPrikazTablice.Tablica(tablica);

        }

        public static void NeparniGDACos(int x)
        {
            int y = 1;

            int[,] tablica = new int[x, x];
            int m = x / 2;
            int k = 0;

            int brojOkretaja = x / 2;
            tablica[m, m] = y++;



            for (int a = brojOkretaja; a > 0; a--)
            {
                for (int i = m - k; i < m + 2 + k; i++)
                {
                    for (int j = m + 1 + k; j > m + k; j--)
                    {
                        tablica[i, j] = y++;
                    }
                }
                for (int i = m + 1 + k; i > m + k; i--)
                {
                    for (int j = m + k; j > m - 2 - k; j--)
                    {
                        tablica[i, j] = y++;
                    }
                }
                for (int i = m + k; i > m - 2 - k; i--)
                {
                    for (int j = m - 1 - k; j > m - 2 - k; j--)
                    {
                        tablica[i, j] = y++;
                    }
                }
                for (int i = m - 1 - k; i > m - 2 - k; i--)
                {
                    for (int j = m - k; j < m + 2 + k; j++)
                    {
                        tablica[i, j] = y++;
                    }
                }
                ++k;
            }

            FunkcijaZaPrikazTablice.Tablica(tablica);

        }

    }
}
