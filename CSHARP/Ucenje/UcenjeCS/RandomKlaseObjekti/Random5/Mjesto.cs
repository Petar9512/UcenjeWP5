using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.RandomKlaseObjekti.Random5
{
    internal class Mjesto : Entitet
    {
        public Mjesto(int sifra, string ime, string broj, string drzava)
        {
            base.Sifra = sifra;
            base.Ime = ime;
            this.Broj = broj;
            this.Drzava = drzava;
        }

        public string? Broj { get; set; }
        public string? Drzava { get; set; }

        public override string ToString()
        {
            return Broj + " " + Ime + ", " + Drzava;
        }
    }
}
