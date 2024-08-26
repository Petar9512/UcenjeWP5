using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.RandomKlaseObjekti.Random2
{
    internal class Putnik : Entitet
    {
        public Putnik(int sifra, string ime, string prezime, double cijena)
        {
            base.Sifra = sifra;
            base.Ime = ime;
            base.Prezime = prezime;
            this.Cijena = cijena;
        }

        public double? Cijena { get; set; }

        public override string ToString()
        {
            return "putnik: " + Ime + " " + Prezime;
        }

    }
}
