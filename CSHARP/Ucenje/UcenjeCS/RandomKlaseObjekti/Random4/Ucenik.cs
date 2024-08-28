using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.RandomKlaseObjekti.Random4
{
    internal class Ucenik : Entitet
    {
        public Ucenik(int sifra, Razred razred, string ime, string prezime, string oib)
        {
            base.Sifra = sifra;
            this.Razred = razred;
            base.Ime = ime;
            base.Prezime = prezime;
            this.Oib = oib;
        }

        public Razred? Razred { get; set; }
        public string? Oib { get; set; }

        public override string ToString()
        {
            return "ime: " + Ime + " " + Prezime + ", " + Razred;
        }
    }
}
