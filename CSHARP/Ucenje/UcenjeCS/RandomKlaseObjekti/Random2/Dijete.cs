using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.RandomKlaseObjekti.Random2
{
    internal class Dijete : Entitet
    {
        public Dijete(int sifra, string ime, string prezime, int dob, string kontaktRoditelja, Skupina skupina)
        {
            base.Sifra = sifra;
            base.Ime = ime;
            base.Prezime = prezime;
            this.Dob = dob;
            base.Kontakt = kontaktRoditelja;
            this.Skupina = skupina;
        }

        public int? Dob { get; set; }
        public Skupina? Skupina { get; set; }

        public override string ToString()
        {
            return "dijete: " + Ime + " " + Prezime + ", dob: " + Dob + ", " + Skupina;
        }
    }
}
