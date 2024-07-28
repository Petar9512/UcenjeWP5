using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.CikličneTablice
{
    internal class CTabliceNepar
    {      

        /* Kratice: DD - dolje desno, DL - dolje lijevo, GL - gore lijevo, GD - gore desno
           C - clockwise, AC - anti-clockwise, os - od sredine  */
        


        public static void NeparniDDC(int x)                    // Ciklične tablice gdje su broj redova i broj stupaca isti neparni broj
        {

            int y = x * x;                                      // y je najveći broj u tablici i jednak je umnošku broja redova i stupaca

            int[,] tablica = new int[x, x];
            int m = x / 2;                                      // varijabla m je bitna za određivanje položaja brojeva u tablici kroz for petlje
            int k = 0;                                          // varijabla k je u početku 0, ali se uvećava za 1 nakon svake vanjske petlje kako bi brojevi nakon prvog okretka bili točno postavljeni

            int brojOkretaja = x / 2;
            tablica[m, m] = y--;                                // najveći broj tablice je uvijek na ovoj poziciji, npr. za tablicu s 5 redova i stupaca broj 25 će biti na poziciji tablica[2,2]
                                                                // također, mora biti umanjen nakon postavljanja kako bi sljedeći broj bio za 1 manji


            for (int a = brojOkretaja; a > 0; a--)              // broj iteracija vanjske petlje jednak je broju okretaja koji je uvijek x/2
            {
                for (int i = m + k; i > m - 2 - k; i--)         // iteracije su izražene kroz m i k kako bi brojevi uvijek bili točno postavljeni za sve neparne x
                {
                    for (int j = m + 1 + k; j > m + k; j--)
                    {
                        tablica[i, j] = y--;                    // y se mora umanjiti nakon svakog postavljanja u unutarnjoj petlji
                    }
                }
                for (int i = m - 1 - k; i > m - 2 - k; i--)     // k se mora dodati ili oduzeti ovisno o tome da li se u sljedećem okretu ta vrijednost povećava ili smanjuje
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
                ++k;                                    // nakon svakog okreta k se uveća za 1 kako bi sljedeći okret bio točan
            }

            FunkcijaZaPrikazTablice.Tablica(tablica);   // obična funkcija za prikaz tablice

        }


        public static void NeparniDDAC(int x)           // funkcija za tablice koje počinju dolje desno obrnuto od kazaljke
        {                                               // odnos m i k varijabli u for petljama je drukčiji za svaki smjer
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

        public static void NeparniDDCos(int x)       // funkcija za tablicu koja počinje od sredine, zato y počinje od 1 i povećava se za 1 nakon svake iteracije
        {                                            // ispod su funkcije za ostale smjerove 

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
