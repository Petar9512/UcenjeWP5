using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcenjeCS.E15KlasaObjekt.Polimorfizam;

namespace UcenjeCS.E15KlasaObjekt
{
    internal class Program
    {

        public static void Izvedi()
        {
            Osoba osoba = new Osoba();
            osoba.Ime = "Pero";
            osoba.Prezime = "Perić";

            Console.WriteLine(osoba.ImePrezime());

            Osoba ravnatelj = new Osoba()
            {
                Sifra = 1,
                Ime = "Marko",
                Prezime = "Kas"
            };

            var direktor = new Osoba() { Ime = "Edo" };
            Osoba profesor = new Osoba() { Prezime = "Reh", Ime = "Klara" };
            Console.WriteLine(profesor.Ime?.ToUpper());

            var o = new Osoba()
            {
                Ime = "Marija",
                Mjesto = new() { Naziv = "Osijek", PostanskiBroj = "31000" }
            };
            Console.WriteLine(o.Mjesto?.Naziv?.ToUpper());

            Zupanija obz = new Zupanija();
            obz.Naziv = "Osječko-baranjska županija";

            Mjesto os = new Mjesto();
            os.Naziv = "Osijek";
            os.Zupanija = obz;

            Osoba ja = new Osoba();
            ja.Ime = "Tomislav";
            ja.Mjesto = os;

            Console.WriteLine(ja.Mjesto?.Zupanija?.Naziv);
        }
    }
}
