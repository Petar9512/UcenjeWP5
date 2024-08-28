using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.RandomKlaseObjekti.Random4
{
    internal class Pice : Entitet
    {
        public Pice() { }
        public Pice(int sifra, string naziv, string sastojci, double cijena)
        {
            base.Sifra = sifra;
            base.Naziv = naziv;
            this.Sastojci = sastojci;
            this.Cijena = cijena;
        }

        public string? Sastojci { get; set; }
        public double? Cijena { get; set; }

        public override string ToString()
        {
            return Naziv + ", cijena: " + Cijena;
        }
    }
}
