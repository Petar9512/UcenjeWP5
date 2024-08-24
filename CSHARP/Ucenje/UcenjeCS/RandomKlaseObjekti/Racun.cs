using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.RandomKlaseObjekti
{
    internal class Racun : Entitet
    {
        public Racun(int sifra, int redniBroj, DateTime datum, string kupac, bool placeno)
        {
            base.Sifra = sifra;
            this.RedniBroj = redniBroj;
            base.Datum = datum;
            this.Kupac = kupac;
            this.Placeno = placeno;
        }

        public int? RedniBroj { get; set; }
        public string? Kupac { get; set; }
        public bool Placeno { get; set; }

        public override string ToString()
        {
            return "šifra: " + Sifra + ", vrijeme: " + Datum + ", kupac: " + Kupac;
        }

    }
}
