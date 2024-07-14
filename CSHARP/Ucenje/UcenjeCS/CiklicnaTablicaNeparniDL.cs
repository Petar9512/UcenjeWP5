﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class CiklicnaTablicaNeparniDL
    {
        public static void Izvedi()
        {

            int broj;
            int smjer;
            int odSredine;

            while (true)
            {
                Console.WriteLine("Unesite neparni broj veći od nule: ");

                try
                {
                    broj = int.Parse(Console.ReadLine());

                    if (broj < 0)
                    {
                        Console.WriteLine("Broj mora biti veći od nule");
                        continue;
                    }

                    if (broj % 2 == 0)
                    {
                        Console.WriteLine("Broj mora biti neparan");
                        continue;
                    }
                    break;
                }
                catch
                {
                    Console.WriteLine("Niste unijeli broj");
                }
            }


            while (true)
            {
                Console.WriteLine("Unesite smjer tablice: \n 1 - smjer kazaljke na satu \n 2 - suprotno od kazaljke");

                try
                {
                    smjer = int.Parse(Console.ReadLine());

                    if (smjer != 1 && smjer != 2)
                    {
                        Console.WriteLine("Niste unijeli 1 ili 2 za smjer tablice");
                        continue;
                    }
                    break;
                }
                catch
                {
                    Console.WriteLine("Niste unijeli smjer");
                }
            }

            while (true)
            {
                Console.WriteLine("Želite li da tablica krene od sredine? \n 1 - DA \n 2 - NE");

                try
                {
                    odSredine = int.Parse(Console.ReadLine());

                    if (odSredine != 1 && odSredine != 2)
                    {
                        Console.WriteLine("Niste unijeli 1 ili 2");
                        continue;
                    }
                    break;
                }
                catch
                {
                    Console.WriteLine("Niste unijeli 1 ili 2");
                }
            }

            if (smjer == 1)
            {
                switch (odSredine)
                {
                    case 1:
                        NeparniDLCos(broj);
                        break;
                    case 2:
                        NeparniDLC(broj);
                        break;
                }
            }
            else if (smjer == 2)
            {
                switch (odSredine)
                {
                    case 1:
                        NeparniDLACos(broj);
                        break;
                    case 2:
                        NeparniDLAC(broj);
                        break;
                }
            }
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
                for (int i = m+k; i > m-2-k; i--)
                {
                    for (int j = m-1-k; j > m-2-k; j--)
                    {
                        tablica[i, j] = y--;
                    }
                }
                for (int i = m-1-k; i > m-2-k; i--)
                {
                    for (int j = m-k; j < m+2+k; j++)
                    {
                        tablica[i, j] = y--;
                    }
                }
                for (int i = m-k; i < m+2+k; i++)
                {
                    for (int j = m+1+k; j > m+k; j--)
                    {
                        tablica[i, j] = y--;
                    }
                }
                for (int i = m+1+k; i > m+k; i--)
                {
                    for (int j = m+k; j > m-2-k; j--)
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
    }
}
