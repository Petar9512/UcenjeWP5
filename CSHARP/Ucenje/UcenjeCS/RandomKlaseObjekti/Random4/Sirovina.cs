using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.RandomKlaseObjekti.Random4
{
    internal class Sirovina : Entitet
    {
        public Sirovina(int sifra, string naziv, string vrsta, string kolicina)
        {
            base.Sifra = sifra;
            base.Naziv = naziv;
            this.Vrsta = vrsta;
            this.Kolicina = kolicina;
        }

        public string? Vrsta { get; set; }
        public string? Kolicina { get; set; }

        public override string ToString()
        {
            return Naziv + ", " + Kolicina;
        }
    }
}
