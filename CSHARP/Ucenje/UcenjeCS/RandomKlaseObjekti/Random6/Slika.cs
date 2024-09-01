using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.RandomKlaseObjekti.Random6
{
    internal class Slika : Entitet
    {
        public Slika(int sifra, Zaposlenik zaposlenik, int redniBroj, string putanja)
        {
            base.Sifra = sifra;
            this.Zaposlenik = zaposlenik;
            this.RedniBroj = redniBroj;
            this.Putanja = putanja;
        }

        public Zaposlenik? Zaposlenik { get; set; }
        public int? RedniBroj { get; set; }
        public string? Putanja { get; set; }

        public override string ToString()
        {
            return Zaposlenik + ", slika: " + Putanja;
        }
    }
}
