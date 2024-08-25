using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.RandomKlaseObjekti.Random2
{
    internal class Usluga : Entitet
    {
        public Usluga() { }

        public Usluga(int sifra, string naziv, string opis, double cijena)
        {
            base.Sifra = sifra;
            base.Naziv = naziv;
            this.Opis = opis;
            this.Cijena = cijena;
        }

        public string? Opis { get; set; }
        public double? Cijena { get; set; }

        public override string ToString()
        {
            return "usluga: " + Naziv + ", cijena: " + Cijena;
        }

    }
}
