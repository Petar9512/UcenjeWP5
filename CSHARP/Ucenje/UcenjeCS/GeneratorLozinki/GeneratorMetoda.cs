using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.GeneratorLozinki
{
    internal class GeneratorMetoda
    {

        public static void Generator(int duljinaLozinke, int[] pozUvjeti, int prviZnak, int zadnjiZnak)
        {
            string lozinka = "";

            Random rnd = new Random();
            int x;
            int y;
            char prvi;                               // u nizovima ispod su ASCII brojevi za znakove za lozinke
            char zadnji;

            int[] velikaSlova = new int[] { 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90 };
            int[] malaSlova = new int[] { 97, 98, 99, 100, 101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122 };
            int[] brojevi = new int[] { 48, 49, 50, 51, 52, 53, 54, 55, 56, 57 };
            int[] znakovi = new int[] { 33, 44, 46, 58, 63, 64 };


            for (int i = 0; i < duljinaLozinke; i++)
            {
                y = pozUvjeti[rnd.Next(0, pozUvjeti.Length)];         // y će u svakoj iteraciji biti nasumičan broj iz pozUvjeti niza

                if (y == 1)                                           // svaki broj u pozUvjeti predstavlja grupu znakova koje je korisnik odabrao za lozinke
                {
                    x = rnd.Next(0, velikaSlova.Length);              // u uvjetnom grananju bira se nasumični broj iz jedne grupe znakova koja je također nasumično odabrana kroz y
                    lozinka += (char)velikaSlova[x];                  // broj se mora pretvoriti u char kako bi se u lozinku dodao znak
                }

                else if (y == 2)
                {
                    x = rnd.Next(0, malaSlova.Length);
                    lozinka += (char)malaSlova[x];
                }

                else if (y == 3)
                {
                    x = rnd.Next(0, brojevi.Length);
                    lozinka += (char)brojevi[x];
                }

                else if (y == 4)
                {
                    x = rnd.Next(0, znakovi.Length);
                    lozinka += (char)znakovi[x];
                }
            }


            if (prviZnak == 1)                                        // ovaj dio služi za postavljanje broja ili interpunk znaka na početak ili kraj lozinke ako je korisnik prethodno odabrao tu opciju
            {
                prvi = (char)brojevi[rnd.Next(0, brojevi.Length)];
                lozinka = prvi + lozinka.Substring(1);
            }

            else if (prviZnak == 2)
            {
                prvi = (char)znakovi[rnd.Next(0, znakovi.Length)];
                lozinka = prvi + lozinka.Substring(1);
            }


            if (zadnjiZnak == 1)
            {
                zadnji = (char)brojevi[rnd.Next(0, brojevi.Length)];
                lozinka = lozinka.Substring(0, lozinka.Length - 1) + zadnji;
            }

            else if (zadnjiZnak == 2)
            {
                zadnji = (char)znakovi[rnd.Next(0, znakovi.Length)];
                lozinka = lozinka.Substring(0, lozinka.Length - 1) + zadnji;
            }


            Console.WriteLine(lozinka);
        }



        public static void GeneratorBezPonavljajucihZnakova(int duljinaLozinke, string dopusteniZnakovi)
        {

            string lozinka = "";
            int y;
            char c;

            Random rnd = new Random();


            while (duljinaLozinke > 0)
            {
                y = rnd.Next(0, dopusteniZnakovi.Length);
                c = dopusteniZnakovi[y];                          // c će uvijek biti nasumični znak iz stringa s dopuštenim znakovima


                if (lozinka.Contains(c))                          // ako lozinka već sadrži taj znak, on će se izbaciti iz stringa
                {
                    dopusteniZnakovi.Remove(y, 1);
                }

                else
                {
                    lozinka += c;                                 // u suprotnom će znak biti dodan u lozinku, a preostala duljina se smanjiti za 1
                    duljinaLozinke--;
                }
            }

            Console.WriteLine(lozinka);
        }
    }
}
