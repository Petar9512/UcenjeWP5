using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.RandomKlaseObjekti.Random4
{
    internal class Jelo : Entitet
    {
        public Jelo(int sifra, Kategorija kategorija, string naziv, string sastojci, double cijena)
        {
            base.Sifra = sifra;
            this.Kategorija = kategorija;
            base.Naziv = naziv;
            this.Sastojci = sastojci;
            this.Cijena = cijena;
        }

        public Kategorija? Kategorija { get; set; }
        public string? Sastojci { get; set; }
        public double? Cijena { get; set; }

        public override string ToString()
        {
            return Naziv + ", " + Kategorija + ", cijena: " + Cijena;
        }
    }
}
