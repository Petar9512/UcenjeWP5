using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.RandomKlaseObjekti.Random4
{
    internal class Djelatnik : Entitet
    {
        public Djelatnik(int sifra, string ime, string prezime, string oib)
        {
            base.Sifra = sifra;
            base.Ime = ime;
            base.Prezime = prezime;
            this.Oib = oib;
        }

        public string? Oib { get; set; }

        public override string ToString()
        {
            return "djelatnik: " + Ime + " " + Prezime;
        }
    }
}
