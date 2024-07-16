﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class CTablicaParniDL
    {

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
                for (int i = m+1+k; i > m+k; i--)
                {
                    for (int j = m-1-k; j < m+2+k; j++)
                    {
                        tablica[i, j] = y--;
                    }
                }
                for (int i = m+k; i > m-3-k; i--)
                {
                    for (int j = m+1+k; j > m+k; j--)
                    {
                        tablica[i, j] = y--;
                    }                
                }
                for (int i = m-2-k; i > m-3-k; i--)
                {
                    for (int j = m+k; j > m-3-k; j--)
                    {
                        tablica[i, j] = y--;
                    }
                }
                for (int i = m-1-k; i < m+2+k; i++)
                {
                    for (int j = m-2-k; j > m-3-k; j--)
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
                for (int i = m+k; i > m-3-k; i--)
                {
                    for (int j = m-2-k; j > m-3-k; j--)
                    {
                        tablica[i, j] = y--;
                    }
                }
                for (int i = m-2-k; i > m-3-k; i--)
                {
                    for (int j = m-1-k; j < m+2+k; j++)
                    {
                        tablica[i, j] = y--;
                    }
                }
                for (int i = m-1-k; i < m+2+k; i++)
                {
                    for (int j = m+1+k; j > m+k; j--)
                    {
                        tablica[i, j] = y--;
                    }
                }
                for (int i = m+1+k; i > m+k; i--)
                {
                    for (int j = m+k; j > m-3-k; j--)
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

    }
}
