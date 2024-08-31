using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.RandomKlaseObjekti.Random6
{
    internal class Citatelj : Entitet
    {
        public Citatelj(int sifra, string ime, string prezime, string kontakt, string oib)
        {
            base.Sifra = sifra;
            base.Ime = ime;
            base.Prezime = prezime;
            base.Kontakt = kontakt;
            this.Oib = oib;
        }

        public string? Oib { get; set; }

        public override string ToString()
        {
            return Ime + " " + Prezime + ", kontakt: " + Kontakt;
        }
    }
}
