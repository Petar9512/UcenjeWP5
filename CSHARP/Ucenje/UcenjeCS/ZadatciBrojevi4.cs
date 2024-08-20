using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class ZadatciBrojevi4
    {
        public static void cetveroznamenkastiBrojevi()
        {

            for (int i = 1000; i < 10000; i++)
            {
                int k = i;
                int zbroj = 0;
                int produkt = 1;
                
                while (k >= 100)
                {
                    zbroj += k % 10;
                    produkt *= k % 10;
                    k /= 10;
                }
                zbroj += k % 10;
                zbroj += k / 10;
                produkt *= k % 10;
                produkt *= k / 10;
                
                if (zbroj * zbroj == produkt)
                {
                    Console.WriteLine(i);
                }
            }
        }


        public static void mathRandom1(int k)
        {
            int n = k + 1;

            while(true)
            {
                if (n % 2 == 0 && (n + 1) % 3 == 0 && (n + 2) % 5 == 0 && (n + 3) % 7 == 0)
                {
                    Console.WriteLine(n);
                    break;
                }
                n++;
            }
        }


        public static void najveciBroj()
        {
            string input;
            int broj;
            int max = Int32.MinValue;

            while (true)
            {
                Console.WriteLine("Unesite broj ili KRAJ: ");
                input = Console.ReadLine();

                if (input == "KRAJ")
                {
                    break;
                }

                try
                {
                    broj = int.Parse(input);
                    
                    if (broj > max)
                    {
                        max = broj;
                    }
                }
                catch
                {
                    Console.WriteLine("Nepravilan unos");
                }
            }
            Console.WriteLine(max);
        }


        public static void planinskiVrhovi()
        {
            string input;
            int visina;
            int min = Int32.MaxValue;
            int max = Int32.MinValue;

            while (true)
            {
                Console.WriteLine("Unesite visinu ili KRAJ: ");
                input = Console.ReadLine();

                if (input == "KRAJ")
                {
                    break;
                }

                try
                {
                    visina = int.Parse(input);

                    if (visina > max)
                    {
                        max = visina;
                    }
                    if (visina < min)
                    {
                        min = visina;
                    }
                }
                catch
                {
                    Console.WriteLine("Nepravilan unos");
                }
            }
            Console.WriteLine("Razlika u visini najvišeg i najnižeg vrha: {0}m", max - min);
        }


        public static void Intervali()
        {
            string input;
            int A;
            int B;
            int min = Int32.MaxValue;
            int max = Int32.MinValue;

            while (true)
            {
                Console.WriteLine("Unesite koordinatu a ili KRAJ: ");
                input = Console.ReadLine();

                if (input == "KRAJ")
                {
                    break;
                }

                try
                {
                    A = int.Parse(input);

                    if (A < min)
                    {
                        min = A;
                    }
                    if (A > max)
                    {
                        max = A;
                    }
                }
                catch
                {
                    Console.WriteLine("Nepravilan unos");
                    continue;
                }

                while (true)
                {
                    Console.WriteLine("Unesite koordinatu b: ");

                    try
                    {
                        B = int.Parse(Console.ReadLine());

                        if (B < min)
                        {
                            min = B;
                        }
                        if (B > max)
                        {
                            max = B;
                        }
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Nepravilan unos");
                    }
                }               
            }
            Console.WriteLine("a: {0}, b: {1}", min, max);
        }


        public static void stanjeNaRacunu(double n)
        {
            string input;
            double iznos;

            while (true)
            {
                Console.WriteLine("Unesite iznos uplate/isplate (zarez označava decimalnu točku) ili KRAJ: ");
                input = Console.ReadLine();

                if (input == "KRAJ")
                {
                    break;
                }

                try
                {
                    iznos = double.Parse(input);
                    
                    if (n + iznos >= 0)
                    {
                        n += iznos;
                    }
                    else
                    {
                        Console.WriteLine("Transakcija poništena - nedovoljna vrijednost na računu");
                        continue;
                    }
                }
                catch
                {
                    Console.WriteLine("Nepravilan unos");
                }
            }
            Console.WriteLine("Novo stanje na računu: {0}", n);
        }


        public static void Desifriranje()
        {
            for (int i = 100; i < 1000; i++)
            {
                for (int j = 10000; j < 100000; j++)
                {
                    if (Math.Pow(i, 2) == j && (j / 100) % 10 == 0 && (j / 1000) % 10 == 0)
                    {
                        Console.WriteLine("{0}, {1}", i, j);
                    }
                }
            }
        }


        public static void Desifriranje2()
        {
            for (int i = 10; i < 100; i++)
            {
                for (int j = 10; j < 100; j++)
                {
                    if (i % 10 == j % 10 && i / 10 != j / 10 && i / 10 != i % 10 && j / 10 != j % 10)
                    {
                        int zbroj = i + j;

                        if (zbroj > 99 && (zbroj / 10) % 10 == i % 10 && zbroj % 10 != i / 10 && zbroj % 10 != j / 10 && zbroj / 100 != i / 10 && zbroj / 100 != j / 10 && (zbroj / 10) % 10 != zbroj / 100 && zbroj % 10 != i % 10)
                        {
                            Console.WriteLine("{0} + {1} = {2}", i, j, zbroj);
                        }
                    }
                }
            }
        }


        public static void Desifriranje3()
        {
            for (int i = 100; i < 1000; i++)
            {
                if (i % 10 != (i / 10) % 10 && i % 10 != i / 100 && (i / 10) % 10 != i / 100)
                {
                    int p = i + i;

                    if (p > 999 && p % 10 != (p / 10) % 10 && p % 10 != (p / 100) % 10 && p % 10 != p / 1000 && (p / 10) % 10 != (p / 100) % 10 && (p / 10) % 10 != p / 1000 && (p / 100) % 10 != p / 1000 && p % 10 != i % 10 && p % 10 != (i / 10) % 10 && p % 10 != i / 100 && (p / 10) % 10 != i % 10 && (p / 10) % 10 != (i / 10) % 10 && (p / 10) % 10 != i / 100 && (p / 100) % 10 != i % 10 && (p / 100) % 10 != (i / 10) % 10 && (p / 100) % 10 != i / 100 && p / 1000 != i % 10 && p / 1000 != (i / 10) % 10 && p / 1000 != i / 100)
                    {
                        Console.WriteLine("{0} + {0} = {1}", i, p);
                    }
                }
            }
        }


        public static void Desifriranje4()
        {
            for (int i = 10000; i < 100000; i++)
            {
                if (i % 10 == (i / 100) % 10 && i % 10 != (i / 10) % 10 && i % 10 != (i / 1000) % 10 && i % 10 != i / 10000 && (i / 10) % 10 != (i / 1000) % 10 && (i / 10) % 10 != i / 10000 && (i / 1000) % 10 != i / 10000)
                {
                    int p = i + i + i;

                    if (p < 100000 && (p / 10) % 10 == i % 10 && p % 10 != (i / 10) % 10 && p % 10 != (i / 1000) % 10 && p % 10 != i / 10000 && (p / 100) % 10 != (i / 10) % 10 && (p / 100) % 10 != (i / 1000) % 10 && (p / 100) % 10 != i / 10000 && (p / 1000) % 10 != (i / 10) % 10 && (p / 1000) % 10 != (i / 1000) % 10 && (p / 1000) % 10 != i / 10000 && p / 10000 != (i / 10) % 10 && p / 10000 != (i / 1000) % 10 && p / 10000 != i / 10000 && p % 10 != (p / 10) % 10 && p % 10 != (p / 100) % 10 && p % 10 != (p / 1000) % 10 && p % 10 != p / 10000 && (p / 10) % 10 != (p / 100) % 10 && (p / 10) % 10 != (p / 1000) % 10 && (p / 10) % 10 != p / 10000 && (p / 100) % 10 != (p / 1000) % 10 && (p / 100) % 10 != p / 10000 && (p / 1000) % 10 != p / 10000)
                    {
                        Console.WriteLine("{0} + {0} + {0} = {1}", i, p);
                    }
                }
            }
        }


        public static void zamisljeniBroj()
        {
            int minBroj = 1;
            int maxBroj = 10000;            
            string input;

            Console.WriteLine("Zamislite broj između 1 i 10000");

            while (true)
            {
                var rnd = new Random();
                int zamisljeniBroj = rnd.Next(minBroj, maxBroj);
               
                Console.WriteLine("Je li broj veći od {0}?", zamisljeniBroj);
                input = Console.ReadLine();

                if (input != "da" && input != "ne")
                {
                    Console.WriteLine("Trebate napisati da ili ne");
                    continue;
                }
                else if (input == "da")
                {
                    minBroj = zamisljeniBroj + 1;
                }
                else if (input == "ne")
                {
                    maxBroj = zamisljeniBroj;
                }

                if (minBroj == maxBroj || minBroj == 10000)
                {
                    break;
                }
            }

            Console.WriteLine("Zamislili ste broj {0}", minBroj);
        }


        public static void randomBrojevi()
        {
            int broj;
            int x = 1;

            while (true)
            {
                Console.WriteLine("Unesite broj: ");

                try
                {
                    broj = int.Parse(Console.ReadLine());

                    if (broj < 1)
                    {
                        Console.WriteLine("Broj mora biti veći od 0");
                        continue;
                    }
                    break;
                }
                catch
                {
                    Console.WriteLine("Neispravan unos");
                }
            }

            while (broj > 0)
            {
                Console.WriteLine("Unesite {0}. broj: ", x);

                try
                {
                    int broj2 = int.Parse(Console.ReadLine());

                    if (broj2 < 0)
                    {
                        Console.WriteLine("Broj mora biti pozitivan");
                        continue;
                    }
                    broj--;
                    x++;
                }
                catch
                {
                    Console.WriteLine("Neispravan unos");
                }
            }            
        }


        public static void randomBrojevi2()
        {
            int broj;
            int x = 1;

            while (true)
            {
                Console.WriteLine("Unesite broj: ");

                try
                {
                    broj = int.Parse(Console.ReadLine());

                    if (broj < 1)
                    {
                        Console.WriteLine("Broj mora biti veći od 0");
                        continue;
                    }
                    break;
                }
                catch
                {
                    Console.WriteLine("Neispravan unos");
                }
            }

            int k = broj;
            int uvjet = 0;

            while (k > 0)
            {
                Console.WriteLine("Unesite {0}. broj: ", x);

                try
                {
                    int broj2 = int.Parse(Console.ReadLine());

                    if (broj2 >= 5)
                    {
                        uvjet++;
                    }
                    x++;
                    k--;

                    if (k == 0 && uvjet == 0)
                    {
                        Console.WriteLine("Barem jedan broj mora biti jednak ili veći od 5");
                        k = broj;
                        x = 1;
                    }
                }
                catch
                {
                    Console.WriteLine("Neispravan unos");
                }
            }
        }


        public static void randomBrojevi3()
        {
            int broj;
            int x = 1;

            while(true)
            {
                Console.WriteLine("Unesite broj: ");

                try
                {
                    broj = int.Parse(Console.ReadLine());

                    if (broj < 1)
                    {
                        Console.WriteLine("Broj mora biti pozitivan");
                        continue;
                    }
                    break;
                }
                catch
                {
                    Console.WriteLine("Neispravan unos");
                }
            }
            int uvjet = 0;

            while (broj > 0)
            {
                Console.WriteLine("Unesite {0}. broj: ", x);

                try
                {
                    int broj2 = int.Parse(Console.ReadLine());

                    if (broj2 % 2 != 0)
                    {
                        uvjet++;
                    }
                    broj--;
                    x++;
                }
                catch
                {
                    Console.WriteLine("Neispravan unos");
                }
            }
            Console.WriteLine("Broj neparnih brojeva: {0}", uvjet);
        }


        public static void randomBrojevi4()
        {
            int broj;
            int x = 1;

            while (true)
            {
                Console.WriteLine("Unesite broj: ");

                try
                {
                    broj = int.Parse(Console.ReadLine());

                    if (broj < 1)
                    {
                        Console.WriteLine("Broj mora biti veći od nule");
                        continue;
                    }
                    break;
                }
                catch
                {
                    Console.WriteLine("Neispravan unos");
                }
            }

            int maxBroj = Int32.MinValue;
            int minBroj = Int32.MaxValue;
            int brojPonavljanjaMax = 1;
            int brojPonavljanjaMin = 1;
            int pp = 0;
            int zp = 0;

            while (broj > 0)
            {
                Console.WriteLine("Unesite {0}. broj: ", x);

                try
                {
                    int broj2 = int.Parse(Console.ReadLine());

                    if (broj2 > maxBroj)
                    {
                        maxBroj = broj2;
                        brojPonavljanjaMax = 1;
                        pp = x;
                        zp = x;
                    }
                    else if (broj2 == maxBroj)
                    {
                        brojPonavljanjaMax++;
                        zp = x;
                    }

                    if (broj2 < minBroj)
                    {
                        minBroj = broj2;
                        brojPonavljanjaMin = 1;
                    }
                    else if (broj2 == minBroj)
                    {
                        brojPonavljanjaMin++;
                    }
                    broj--;
                    x++;
                }
                catch
                {
                    Console.WriteLine("Neispravan unos");
                }
            }
            Console.WriteLine("najveći broj: {0}, broj ponavljanja: {1}, prvo pojavljivanje: {2}, zadnje pojavljivanje: {3}, najmanjiBroj: {4}, broj ponavljanja: {5}", maxBroj, brojPonavljanjaMax, pp, zp, minBroj, brojPonavljanjaMin);
        }


        public static void randomBrojevi5()
        {
            int broj;
            int x = 1;

            while (true)
            {
                Console.WriteLine("Unesite broj: ");

                try
                {
                    broj = int.Parse(Console.ReadLine());

                    if (broj < 3)
                    {
                        Console.WriteLine("Broj mora biti veći od 2");
                        continue;
                    }
                    break;
                }
                catch
                {
                    Console.WriteLine("Neispravan unos");
                }
            }

            int[] niz = new int[broj];
            int mjesto = 0;
            int k = 0;
            int pocetniBroj = broj;

            while (broj > 0)
            {
                Console.WriteLine("Unesite {0}. broj: ", x);

                try
                {
                    int broj2 = int.Parse(Console.ReadLine());

                    if (broj2 < 0)
                    {
                        k = 0;
                    }

                    else if (broj2 >= 0)
                    {
                        k++;
                    }
                    niz[mjesto] = broj2;
                    mjesto++;
                    broj--;
                    x++;
                }
                catch
                {
                    Console.WriteLine("Neispravan unos");
                }
            }
            Console.WriteLine("Broj pozitivnih iza zadnjeg negativnog: {0}", k);

            int najduljiRastuciSegment = 1;
            int sljedeciSegment = 1;
            int mjestoPocetka = 1;

            for (int i = 0; i < niz.Length; i++)
            {
                if (i > 0 && niz[i] > niz[i - 1])
                {
                    najduljiRastuciSegment++;                    
                }

                else if (i > 0 && niz[i] <= niz[i - 1])
                {
                    if (najduljiRastuciSegment > sljedeciSegment)
                    {
                        sljedeciSegment = najduljiRastuciSegment;
                        mjestoPocetka = i - sljedeciSegment + 1;
                    }                    
                    najduljiRastuciSegment = 1;
                }
            }

            if (najduljiRastuciSegment > sljedeciSegment)
            {
                mjestoPocetka = pocetniBroj - najduljiRastuciSegment + 1;
            }

            Console.WriteLine("najdulji rastući segment: {0}, mjesto početka: {1}", Math.Max(najduljiRastuciSegment, sljedeciSegment), mjestoPocetka);
        }


        public static void fiksnaTocka()
        {
            int broj;
            int x = 1;

            while (true)
            {
                Console.WriteLine("Unesite broj: ");

                try
                {
                    broj = int.Parse(Console.ReadLine());

                    if (broj < 1)
                    {
                        Console.WriteLine("Broj mora biti veći od 0");
                        continue;
                    }
                    break;
                }
                catch
                {
                    Console.WriteLine("Neispravan unos");
                }
            }
            int fiksneTocke = 0;

            while (broj > 0)
            {
                Console.WriteLine("Unesite {0}. broj: ", x);

                try
                {
                    int broj2 = int.Parse(Console.ReadLine());

                    if (broj2 == x)
                    {
                        fiksneTocke++;
                    }
                    broj--;
                    x++;
                }
                catch
                {
                    Console.WriteLine("Neispravan unos");
                }
            }

            Console.WriteLine("Broj fiksnih točaka: {0}", fiksneTocke);
        }


        public static void KolacovaHipoteza()
        {
            int brojKoraka = 0;
            int max = 0;

            for (int i = 2; i < 100000; i++)
            {
                int k = i;
              //  Console.WriteLine(k);

                while (k != 1)
                {
                    if (k % 2 == 0)
                    {
                        k /= 2;
                        brojKoraka++;
                    }

                    else if (k % 2 != 0)
                    {
                        k *= 3;
                        k += 1;
                        brojKoraka++;
                    }
                }
                if (brojKoraka >= max)
                {
                    max = brojKoraka;
                    Console.WriteLine("{0}: {1}", i, brojKoraka);
                }

              //  Console.WriteLine("broj koraka: {0}", brojKoraka);
                brojKoraka = 0;
            }            
        }


        public static void zabacNaLivadi()
        {
            int broj;

            while (true)
            {
                Console.WriteLine("Unesite broj komandi: ");

                try
                {
                    broj = int.Parse(Console.ReadLine());

                    if (broj < 1)
                    {
                        Console.WriteLine("Broj mora biti pozitivan");
                        continue;
                    }
                    break;
                }
                catch
                {
                    Console.WriteLine("Neispravan unos");
                }
            }

            int x = 0;
            int y = 0;
            Console.WriteLine("Početna pozicija: x:{0}, y:{1}", x, y);

            while (broj > 0)
            {
                Console.WriteLine("Unesite 1 za 1m sjeverno, 2 za 1m istočno, 3 za 1m južno, 4 za 1m zapadno");

                try
                {
                    int broj2 = int.Parse(Console.ReadLine());

                    if (broj2 != 1 && broj2 != 2 && broj2 != 3 && broj2 != 4)
                    {
                        Console.WriteLine("Trebate unijeti 1, 2, 3 ili 4");
                        continue;
                    }
                    else if (broj2 == 1)
                    {
                        y++;
                    }
                    else if (broj2 == 2)
                    {
                        x++;
                    }
                    else if (broj2 == 3)
                    {
                        y--;
                    }
                    else if (broj2 == 4)
                    {
                        x--;
                    }
                    broj--;
                }
                catch
                {
                    Console.WriteLine("Neispravan unos");
                }                
            }
            Console.WriteLine("Završna pozicija: x:{0}, y:{1}", x, y);
        }


        public static void robotNaPlatformi()
        {
            int broj;

            while (true)
            {
                Console.WriteLine("Unesite broj komandi: ");

                try
                {
                    broj = int.Parse(Console.ReadLine());

                    if (broj < 1)
                    {
                        Console.WriteLine("Broj mora biti pozitivan");
                        continue;
                    }
                    break;
                }
                catch
                {
                    Console.WriteLine("Neispravan unos");
                }
            }

            int x = 0;
            int y = 0;
            int smjer = 1;
            Console.WriteLine("Početna pozicija: x:{0}, y:{1}", x, y);

            while (broj > 0)
            {
                Console.WriteLine("Unesite broj: \n1 - okreni se lijevo za 90 stupnjeva \n2 - okreni se desno za 90 stupnjeva \n3 - idi naprijed 1m");

                try
                {
                    int broj2 = int.Parse(Console.ReadLine());

                    if (broj2 != 1 && broj2 != 2 && broj2 != 3)
                    {
                        Console.WriteLine("Trebate unijeti 1, 2 ili 3");
                        continue;
                    }

                    else if (broj2 == 1)
                    {
                        smjer--;
                        if (smjer < 1)
                        {
                            smjer = 4;
                        }
                    }
                    else if (broj2 == 2)
                    {
                        smjer++;
                        if (smjer > 4)
                        {
                            smjer = 1;
                        }
                    }
                    else if (broj2 == 3)
                    {
                        switch (smjer)
                        {
                            case 1:
                                y++;
                                break;
                            case 2:
                                x++;
                                break;
                            case 3:
                                y--;
                                break;
                            case 4:
                                x--;
                                break;
                        }
                    }
                    broj--;
                }
                catch
                {
                    Console.WriteLine("Neispravan unos");
                }
            }
            Console.WriteLine("Završna pozicija: x:{0}, y:{1}", x, y);
        }
    }
}
