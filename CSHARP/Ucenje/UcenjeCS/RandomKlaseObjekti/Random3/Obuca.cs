using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.RandomKlaseObjekti.Random3
{
    internal class Obuca : Entitet
    {
        public Obuca(int sifra, Korisnik korisnik, string vrsta, string broj)
        {
            base.Sifra = sifra;
            this.Korisnik = korisnik;
            this.Vrsta = vrsta;
            this.Broj = broj;
        }

        public Korisnik? Korisnik { get; set; }
        public string? Vrsta { get; set; }
        public string? Broj { get; set; }
        public string? OpisKvara { get; set; }

        public override string ToString()
        {
            return Korisnik + ", vrsta obuće: " + Vrsta + ", broj: " + Broj;
        }

    }
}
