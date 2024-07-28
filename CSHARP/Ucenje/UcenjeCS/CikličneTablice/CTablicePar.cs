using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.CikličneTablice
{
    internal class CTablicePar
    {

        /* Kratice: DD - dolje desno, DL - dolje lijevo, GL - gore lijevo, GD - gore desno
           C - clockwise, AC - anti-clockwise, os - od sredine  */


        public static void ParniDDC(int x)     // funkcije za tablice s istim parnim brojem redova i stupaca
        {
            int y = x * x;
            int[,] tablica = new int[x, x];
            int m = x / 2;
            int k = 0;
            int brojOkretaja = m - 1;          // ove tablice imaju prediteraciju, tj. prva 4 broja moraju biti "ručno" postavljena
            tablica[m - 1, m] = y--;           // broj okreta kod ovih tablica je m - 1, za tablicu [8,8] bit će jednak 3
            tablica[m - 1, m - 1] = y--;
            tablica[m, m - 1] = y--;
            tablica[m, m] = y--;


            for (int a = brojOkretaja; a > 0; a--)
            {
                for (int i = m + k; i > m - 3 - k; i--)
                {
                    for (int j = m + 1 + k; j > m + k; j--)
                    {
                        tablica[i, j] = y--;
                    }
                }
                for (int i = m - 2 - k; i > m - 3 - k; i--)
                {
                    for (int j = m + k; j > m - 3 - k; j--)
                    {
                        tablica[i, j] = y--;
                    }
                }
                for (int i = m - 1 - k; i < m + 2 + k; i++)
                {
                    for (int j = m - 2 - k; j > m - 3 - k; j--)
                    {
                        tablica[i, j] = y--;
                    }
                }
                for (int i = m + 1 + k; i > m + k; i--)
                {
                    for (int j = m - 1 - k; j < m + 2 + k; j++)
                    {
                        tablica[i, j] = y--;
                    }
                }
                ++k;
            }
            FunkcijaZaPrikazTablice.Tablica(tablica);
        }


        public static void ParniDDAC(int x)
        {
            int y = x * x;
            int[,] tablica = new int[x, x];
            int m = x / 2;
            int k = 0;
            int brojOkretaja = m - 1;
            tablica[m, m - 1] = y--;
            tablica[m - 1, m - 1] = y--;
            tablica[m - 1, m] = y--;
            tablica[m, m] = y--;


            for (int a = brojOkretaja; a > 0; a--)
            {
                for (int i = m + 1 + k; i > m + k; i--)
                {
                    for (int j = m + k; j > m - 3 - k; j--)
                    {
                        tablica[i, j] = y--;
                    }
                }
                for (int i = m + k; i > m - 3 - k; i--)
                {
                    for (int j = m - 2 - k; j > m - 3 - k; j--)
                    {
                        tablica[i, j] = y--;
                    }
                }
                for (int i = m - 2 - k; i > m - 3 - k; i--)
                {
                    for (int j = m - 1 - k; j < m + 2 + k; j++)
                    {
                        tablica[i, j] = y--;
                    }
                }
                for (int i = m - 1 - k; i < m + 2 + k; i++)
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


        public static void ParniDDCos(int x)
        {
            int y = 1;
            int[,] tablica = new int[x, x];
            int m = x / 2;
            int k = 0;
            int brojOkretaja = m - 1;
            tablica[m - 1, m] = y++;
            tablica[m - 1, m - 1] = y++;
            tablica[m, m - 1] = y++;
            tablica[m, m] = y++;


            for (int a = brojOkretaja; a > 0; a--)
            {
                for (int i = m + k; i > m - 3 - k; i--)
                {
                    for (int j = m + 1 + k; j > m + k; j--)
                    {
                        tablica[i, j] = y++;
                    }
                }
                for (int i = m - 2 - k; i > m - 3 - k; i--)
                {
                    for (int j = m + k; j > m - 3 - k; j--)
                    {
                        tablica[i, j] = y++;
                    }
                }
                for (int i = m - 1 - k; i < m + 2 + k; i++)
                {
                    for (int j = m - 2 - k; j > m - 3 - k; j--)
                    {
                        tablica[i, j] = y++;
                    }
                }
                for (int i = m + 1 + k; i > m + k; i--)
                {
                    for (int j = m - 1 - k; j < m + 2 + k; j++)
                    {
                        tablica[i, j] = y++;
                    }
                }
                ++k;
            }
            FunkcijaZaPrikazTablice.Tablica(tablica);
        }


        public static void ParniDDACos(int x)
        {
            int y = 1;
            int[,] tablica = new int[x, x];
            int m = x / 2;
            int k = 0;
            int brojOkretaja = m - 1;
            tablica[m, m - 1] = y++;
            tablica[m - 1, m - 1] = y++;
            tablica[m - 1, m] = y++;
            tablica[m, m] = y++;


            for (int a = brojOkretaja; a > 0; a--)
            {
                for (int i = m + 1 + k; i > m + k; i--)
                {
                    for (int j = m + k; j > m - 3 - k; j--)
                    {
                        tablica[i, j] = y++;
                    }
                }
                for (int i = m + k; i > m - 3 - k; i--)
                {
                    for (int j = m - 2 - k; j > m - 3 - k; j--)
                    {
                        tablica[i, j] = y++;
                    }
                }
                for (int i = m - 2 - k; i > m - 3 - k; i--)
                {
                    for (int j = m - 1 - k; j < m + 2 + k; j++)
                    {
                        tablica[i, j] = y++;
                    }
                }
                for (int i = m - 1 - k; i < m + 2 + k; i++)
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


        public static void ParniDLC(int x)
        {
            int y = x * x;
            int[,] tablica = new int[x, x];
            int m = x / 2;
            int k = 0;
            int brojOkretaja = m - 1;
            tablica[m, m] = y--;
            tablica[m - 1, m] = y--;
            tablica[m - 1, m - 1] = y--;
            tablica[m, m - 1] = y--;


            for (int a = brojOkretaja; a > 0; a--)
            {
                for (int i = m + 1 + k; i > m + k; i--)
                {
                    for (int j = m - 1 - k; j < m + 2 + k; j++)
                    {
                        tablica[i, j] = y--;
                    }
                }
                for (int i = m + k; i > m - 3 - k; i--)
                {
                    for (int j = m + 1 + k; j > m + k; j--)
                    {
                        tablica[i, j] = y--;
                    }
                }
                for (int i = m - 2 - k; i > m - 3 - k; i--)
                {
                    for (int j = m + k; j > m - 3 - k; j--)
                    {
                        tablica[i, j] = y--;
                    }
                }
                for (int i = m - 1 - k; i < m + 2 + k; i++)
                {
                    for (int j = m - 2 - k; j > m - 3 - k; j--)
                    {
                        tablica[i, j] = y--;
                    }
                }
                ++k;
            }
            FunkcijaZaPrikazTablice.Tablica(tablica);
        }


        public static void ParniDLAC(int x)
        {
            int y = x * x;
            int[,] tablica = new int[x, x];
            int m = x / 2;
            int k = 0;
            int brojOkretaja = m - 1;
            tablica[m - 1, m - 1] = y--;
            tablica[m - 1, m] = y--;
            tablica[m, m] = y--;
            tablica[m, m - 1] = y--;


            for (int a = brojOkretaja; a > 0; a--)
            {
                for (int i = m + k; i > m - 3 - k; i--)
                {
                    for (int j = m - 2 - k; j > m - 3 - k; j--)
                    {
                        tablica[i, j] = y--;
                    }
                }
                for (int i = m - 2 - k; i > m - 3 - k; i--)
                {
                    for (int j = m - 1 - k; j < m + 2 + k; j++)
                    {
                        tablica[i, j] = y--;
                    }
                }
                for (int i = m - 1 - k; i < m + 2 + k; i++)
                {
                    for (int j = m + 1 + k; j > m + k; j--)
                    {
                        tablica[i, j] = y--;
                    }
                }
                for (int i = m + 1 + k; i > m + k; i--)
                {
                    for (int j = m + k; j > m - 3 - k; j--)
                    {
                        tablica[i, j] = y--;
                    }
                }
                ++k;
            }
            FunkcijaZaPrikazTablice.Tablica(tablica);
        }


        public static void ParniDLCos(int x)
        {
            int y = 1;
            int[,] tablica = new int[x, x];
            int m = x / 2;
            int k = 0;
            int brojOkretaja = m - 1;
            tablica[m, m] = y++;
            tablica[m - 1, m] = y++;
            tablica[m - 1, m - 1] = y++;
            tablica[m, m - 1] = y++;


            for (int a = brojOkretaja; a > 0; a--)
            {
                for (int i = m + 1 + k; i > m + k; i--)
                {
                    for (int j = m - 1 - k; j < m + 2 + k; j++)
                    {
                        tablica[i, j] = y++;
                    }
                }
                for (int i = m + k; i > m - 3 - k; i--)
                {
                    for (int j = m + 1 + k; j > m + k; j--)
                    {
                        tablica[i, j] = y++;
                    }
                }
                for (int i = m - 2 - k; i > m - 3 - k; i--)
                {
                    for (int j = m + k; j > m - 3 - k; j--)
                    {
                        tablica[i, j] = y++;
                    }
                }
                for (int i = m - 1 - k; i < m + 2 + k; i++)
                {
                    for (int j = m - 2 - k; j > m - 3 - k; j--)
                    {
                        tablica[i, j] = y++;
                    }
                }
                ++k;
            }
            FunkcijaZaPrikazTablice.Tablica(tablica);
        }


        public static void ParniDLACos(int x)
        {
            int y = 1;
            int[,] tablica = new int[x, x];
            int m = x / 2;
            int k = 0;
            int brojOkretaja = m - 1;
            tablica[m - 1, m - 1] = y++;
            tablica[m - 1, m] = y++;
            tablica[m, m] = y++;
            tablica[m, m - 1] = y++;


            for (int a = brojOkretaja; a > 0; a--)
            {
                for (int i = m + k; i > m - 3 - k; i--)
                {
                    for (int j = m - 2 - k; j > m - 3 - k; j--)
                    {
                        tablica[i, j] = y++;
                    }
                }
                for (int i = m - 2 - k; i > m - 3 - k; i--)
                {
                    for (int j = m - 1 - k; j < m + 2 + k; j++)
                    {
                        tablica[i, j] = y++;
                    }
                }
                for (int i = m - 1 - k; i < m + 2 + k; i++)
                {
                    for (int j = m + 1 + k; j > m + k; j--)
                    {
                        tablica[i, j] = y++;
                    }
                }
                for (int i = m + 1 + k; i > m + k; i--)
                {
                    for (int j = m + k; j > m - 3 - k; j--)
                    {
                        tablica[i, j] = y++;
                    }
                }
                ++k;
            }
            FunkcijaZaPrikazTablice.Tablica(tablica);
        }


        public static void ParniGLC(int x)
        {
            int y = x * x;
            int[,] tablica = new int[x, x];
            int m = x / 2;
            int k = 0;
            int brojOkretaja = m - 1;
            tablica[m, m - 1] = y--;
            tablica[m, m] = y--;
            tablica[m - 1, m] = y--;
            tablica[m - 1, m - 1] = y--;


            for (int a = brojOkretaja; a > 0; a--)
            {
                for (int i = m - 1 - k; i < m + 2 + k; i++)
                {
                    for (int j = m - 2 - k; j > m - 3 - k; j--)
                    {
                        tablica[i, j] = y--;
                    }
                }
                for (int i = m + 1 + k; i > m + k; i--)
                {
                    for (int j = m - 1 - k; j < m + 2 + k; j++)
                    {
                        tablica[i, j] = y--;
                    }
                }
                for (int i = m + k; i > m - 3 - k; i--)
                {
                    for (int j = m + 1 + k; j > m + k; j--)
                    {
                        tablica[i, j] = y--;
                    }
                }
                for (int i = m - 2 - k; i > m - 3 - k; i--)
                {
                    for (int j = m + k; j > m - 3 - k; j--)
                    {
                        tablica[i, j] = y--;
                    }
                }
                ++k;
            }
            FunkcijaZaPrikazTablice.Tablica(tablica);
        }


        public static void ParniGLAC(int x)
        {
            int y = x * x;
            int[,] tablica = new int[x, x];
            int m = x / 2;
            int k = 0;
            int brojOkretaja = m - 1;
            tablica[m - 1, m] = y--;
            tablica[m, m] = y--;
            tablica[m, m - 1] = y--;
            tablica[m - 1, m - 1] = y--;


            for (int a = brojOkretaja; a > 0; a--)
            {
                for (int i = m - 2 - k; i > m - 3 - k; i--)
                {
                    for (int j = m - 1 - k; j < m + 2 + k; j++)
                    {
                        tablica[i, j] = y--;
                    }
                }
                for (int i = m - 1 - k; i < m + 2 + k; i++)
                {
                    for (int j = m + 1 + k; j > m + k; j--)
                    {
                        tablica[i, j] = y--;
                    }
                }
                for (int i = m + 1 + k; i > m + k; i--)
                {
                    for (int j = m + k; j > m - 3 - k; j--)
                    {
                        tablica[i, j] = y--;
                    }
                }
                for (int i = m + k; i > m - 3 - k; i--)
                {
                    for (int j = m - 2 - k; j > m - 3 - k; j--)
                    {
                        tablica[i, j] = y--;
                    }
                }
                ++k;
            }
            FunkcijaZaPrikazTablice.Tablica(tablica);
        }


        public static void ParniGLCos(int x)
        {
            int y = 1;
            int[,] tablica = new int[x, x];
            int m = x / 2;
            int k = 0;
            int brojOkretaja = m - 1;
            tablica[m, m - 1] = y++;
            tablica[m, m] = y++;
            tablica[m - 1, m] = y++;
            tablica[m - 1, m - 1] = y++;


            for (int a = brojOkretaja; a > 0; a--)
            {
                for (int i = m - 1 - k; i < m + 2 + k; i++)
                {
                    for (int j = m - 2 - k; j > m - 3 - k; j--)
                    {
                        tablica[i, j] = y++;
                    }
                }
                for (int i = m + 1 + k; i > m + k; i--)
                {
                    for (int j = m - 1 - k; j < m + 2 + k; j++)
                    {
                        tablica[i, j] = y++;
                    }
                }
                for (int i = m + k; i > m - 3 - k; i--)
                {
                    for (int j = m + 1 + k; j > m + k; j--)
                    {
                        tablica[i, j] = y++;
                    }
                }
                for (int i = m - 2 - k; i > m - 3 - k; i--)
                {
                    for (int j = m + k; j > m - 3 - k; j--)
                    {
                        tablica[i, j] = y++;
                    }
                }
                ++k;
            }
            FunkcijaZaPrikazTablice.Tablica(tablica);
        }


        public static void ParniGLACos(int x)
        {
            int y = 1;
            int[,] tablica = new int[x, x];
            int m = x / 2;
            int k = 0;
            int brojOkretaja = m - 1;
            tablica[m - 1, m] = y++;
            tablica[m, m] = y++;
            tablica[m, m - 1] = y++;
            tablica[m - 1, m - 1] = y++;


            for (int a = brojOkretaja; a > 0; a--)
            {
                for (int i = m - 2 - k; i > m - 3 - k; i--)
                {
                    for (int j = m - 1 - k; j < m + 2 + k; j++)
                    {
                        tablica[i, j] = y++;
                    }
                }
                for (int i = m - 1 - k; i < m + 2 + k; i++)
                {
                    for (int j = m + 1 + k; j > m + k; j--)
                    {
                        tablica[i, j] = y++;
                    }
                }
                for (int i = m + 1 + k; i > m + k; i--)
                {
                    for (int j = m + k; j > m - 3 - k; j--)
                    {
                        tablica[i, j] = y++;
                    }
                }
                for (int i = m + k; i > m - 3 - k; i--)
                {
                    for (int j = m - 2 - k; j > m - 3 - k; j--)
                    {
                        tablica[i, j] = y++;
                    }
                }
                ++k;
            }
            FunkcijaZaPrikazTablice.Tablica(tablica);
        }


        public static void ParniGDC(int x)
        {
            int y = x * x;
            int[,] tablica = new int[x, x];
            int m = x / 2;
            int k = 0;
            int brojOkretaja = m - 1;
            tablica[m - 1, m - 1] = y--;
            tablica[m, m - 1] = y--;
            tablica[m, m] = y--;
            tablica[m - 1, m] = y--;


            for (int a = brojOkretaja; a > 0; a--)
            {
                for (int i = m - 2 - k; i > m - 3 - k; i--)
                {
                    for (int j = m + k; j > m - 3 - k; j--)
                    {
                        tablica[i, j] = y--;
                    }
                }
                for (int i = m - 1 - k; i < m + 2 + k; i++)
                {
                    for (int j = m - 2 - k; j > m - 3 - k; j--)
                    {
                        tablica[i, j] = y--;
                    }
                }
                for (int i = m + 1 + k; i > m + k; i--)
                {
                    for (int j = m - 1 - k; j < m + 2 + k; j++)
                    {
                        tablica[i, j] = y--;
                    }
                }
                for (int i = m + k; i > m - 3 - k; i--)
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


        public static void ParniGDAC(int x)
        {
            int y = x * x;
            int[,] tablica = new int[x, x];
            int m = x / 2;
            int k = 0;
            int brojOkretaja = m - 1;
            tablica[m, m] = y--;
            tablica[m, m - 1] = y--;
            tablica[m - 1, m - 1] = y--;
            tablica[m - 1, m] = y--;


            for (int a = brojOkretaja; a > 0; a--)
            {
                for (int i = m - 1 - k; i < m + 2 + k; i++)
                {
                    for (int j = m + 1 + k; j > m + k; j--)
                    {
                        tablica[i, j] = y--;
                    }
                }
                for (int i = m + 1 + k; i > m + k; i--)
                {
                    for (int j = m + k; j > m - 3 - k; j--)
                    {
                        tablica[i, j] = y--;
                    }
                }
                for (int i = m + k; i > m - 3 - k; i--)
                {
                    for (int j = m - 2 - k; j > m - 3 - k; j--)
                    {
                        tablica[i, j] = y--;
                    }
                }
                for (int i = m - 2 - k; i > m - 3 - k; i--)
                {
                    for (int j = m - 1 - k; j < m + 2 + k; j++)
                    {
                        tablica[i, j] = y--;
                    }
                }
                ++k;
            }
            FunkcijaZaPrikazTablice.Tablica(tablica);
        }


        public static void ParniGDCos(int x)
        {
            int y = 1;
            int[,] tablica = new int[x, x];
            int m = x / 2;
            int k = 0;
            int brojOkretaja = m - 1;
            tablica[m - 1, m - 1] = y++;
            tablica[m, m - 1] = y++;
            tablica[m, m] = y++;
            tablica[m - 1, m] = y++;


            for (int a = brojOkretaja; a > 0; a--)
            {
                for (int i = m - 2 - k; i > m - 3 - k; i--)
                {
                    for (int j = m + k; j > m - 3 - k; j--)
                    {
                        tablica[i, j] = y++;
                    }
                }
                for (int i = m - 1 - k; i < m + 2 + k; i++)
                {
                    for (int j = m - 2 - k; j > m - 3 - k; j--)
                    {
                        tablica[i, j] = y++;
                    }
                }
                for (int i = m + 1 + k; i > m + k; i--)
                {
                    for (int j = m - 1 - k; j < m + 2 + k; j++)
                    {
                        tablica[i, j] = y++;
                    }
                }
                for (int i = m + k; i > m - 3 - k; i--)
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


        public static void ParniGDACos(int x)
        {
            int y = 1;
            int[,] tablica = new int[x, x];
            int m = x / 2;
            int k = 0;
            int brojOkretaja = m - 1;
            tablica[m, m] = y++;
            tablica[m, m - 1] = y++;
            tablica[m - 1, m - 1] = y++;
            tablica[m - 1, m] = y++;


            for (int a = brojOkretaja; a > 0; a--)
            {
                for (int i = m - 1 - k; i < m + 2 + k; i++)
                {
                    for (int j = m + 1 + k; j > m + k; j--)
                    {
                        tablica[i, j] = y++;
                    }
                }
                for (int i = m + 1 + k; i > m + k; i--)
                {
                    for (int j = m + k; j > m - 3 - k; j--)
                    {
                        tablica[i, j] = y++;
                    }
                }
                for (int i = m + k; i > m - 3 - k; i--)
                {
                    for (int j = m - 2 - k; j > m - 3 - k; j--)
                    {
                        tablica[i, j] = y++;
                    }
                }
                for (int i = m - 2 - k; i > m - 3 - k; i--)
                {
                    for (int j = m - 1 - k; j < m + 2 + k; j++)
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
