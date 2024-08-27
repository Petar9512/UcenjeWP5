using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.RandomKlaseObjekti.Random3
{
    internal class Pacijent : Entitet
    {
        public Pacijent(int sifra, string ime, string prezime, int dob, string opisBolesti)
        {
            base.Sifra = sifra;
            base.Ime = ime;
            base.Prezime = prezime;
            this.Dob = dob;
            this.OpisBolesti = opisBolesti;
        }

        public int? Dob { get; set; }
        public string? OpisBolesti { get; set; }

        public override string ToString()
        {
            return "pacijent: " + Ime + " " + Prezime + ", dob: " + Dob + ", bolest: " + OpisBolesti;
        }
    }
}
