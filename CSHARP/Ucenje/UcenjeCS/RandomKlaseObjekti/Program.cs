using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.RandomKlaseObjekti
{
    internal class Program
    {

        public Program()
        {
            var is1 = new IspitniRok(1, "matematika", "pismeni", new DateTime(2024, 3, 1, 10, 0, 0));
            var is2 = new IspitniRok(2, "fizika", "pismeni", new DateTime(2024, 3, 3, 12, 0, 0));
            var is3 = new IspitniRok(3, "kemija", "pismeni", new DateTime(2024, 3, 7, 10, 0, 0));
            var is4 = new IspitniRok(4, "biologija", "pismeni", new DateTime(2024, 3, 9, 9, 0, 0));
            var is5 = new IspitniRok(5, "logika", "pismeni", new DateTime(2024, 3, 11, 9, 0, 0));

            var s1 = new Pristupnik(is1, "Ivan Ivić", 46, 5);
            var s2 = new Pristupnik(is3, "Hajdi Hajdić", 42, 4);
            var s3 = new Pristupnik(is4, "Pero Perić", 20, 3);
            var s4 = new Pristupnik(is2, "Ivan Ivičević", 33, 3);
            var s5 = new Pristupnik(is5, "Goran Grgić", 16, 2);

            var pristupnici = new Pristupnik[5];
            pristupnici[0] = s1;
            pristupnici[1] = s2;
            pristupnici[2] = s3;
            pristupnici[3] = s4;
            pristupnici[4] = s5;

            foreach (var pristupnik in pristupnici)
            {
                Console.WriteLine(pristupnik);
            }


            var o1 = new Odjel(1, "Kemija");
            var o2 = new Odjel(2, "Fizika");
            var o3 = new Odjel(3, "Matematika");
            var o4 = new Odjel(4, "Logika");
            var o5 = new Odjel(5, "Biologija");

            var z3 = new Zaposlenik()
            {
                Sifra = 3,
                Ime = "Ivan",
                Prezime = "Ivičević",
                Datum = new DateTime(1977, 11, 5),
                Odjel = o1
            };
            var z1 = new Zaposlenik()
            {
                Sifra = 1,
                Nadredeni = z3,
                Ime = "Pero",
                Prezime = "Perić",
                Datum = new DateTime(1980, 2, 3),
                Odjel = o1
            };
            var z2 = new Zaposlenik()
            {
                Sifra = 2,
                Ime = "Hajdi",
                Prezime = "Hajdić",
                Datum = new DateTime(1984, 17, 3),
                Placa = 750.75,
                Odjel = o5
            };
            var z4 = new Zaposlenik()
            {
                Sifra = 4,
                Nadredeni = z2,
                Ime = "Goran",
                Prezime = "Grkić",
                Datum = new DateTime(1988, 1, 10),
                Placa = 650.25,
                Odjel = o5
            };
            var z5 = new Zaposlenik()
            {
                Sifra = 5,
                Nadredeni = z3,
                Ime = "Ivan",
                Prezime = "Ivić",
                Datum = new DateTime(1987, 7, 5),
                Placa = 680.89,
                Odjel = o1
            };

            var p1 = new Projekt(1, "Predavanja u OŠ", new DateTime(2024, 4, 16), new DateTime(2024, 4, 23));
            var p2 = new Projekt(2, "Seminari fakultet", new DateTime(2024, 3, 27), new DateTime(2024, 4, 10));
            var p3 = new Projekt(3, "Istraživanje kakvoće mora", new DateTime(2024, 6, 5), new DateTime(2024, 6, 10));
            var p4 = new Projekt(4, "Ljetni kamp", new DateTime(2024, 7, 16), new DateTime(2024, 7, 30));
            var p5 = new Projekt(5, "Mikroskopska analiza", new DateTime(2024, 5, 10), new DateTime(2024, 5, 11));
        }
    }
}
