using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.RandomKlaseObjekti.Random6
{
    internal class Teta : Entitet
    {
        public Teta(int sifra, string ime, string prezime, string kontakt, int dob)
        {
            base.Sifra = sifra;
            base.Ime = ime;
            base.Prezime = prezime;
            base.Kontakt = kontakt;
            this.Dob = dob;
        }

        public int? Dob { get; set; }

        public override string ToString()
        {
            return Ime + " " + Prezime + ", kontakt: " + Kontakt;
        }
    }
}
