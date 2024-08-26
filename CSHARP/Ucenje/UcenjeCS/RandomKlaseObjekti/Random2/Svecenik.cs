using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.RandomKlaseObjekti.Random2
{
    internal class Svecenik : Entitet
    {
        public Svecenik() { }
        public Svecenik(int sifra, string ime, int dob, Svecenik nadredeni)
        {
            base.Sifra = sifra;
            base.Ime = ime;
            this.Dob = dob;
            this.Nadredeni = nadredeni;
        }

        public int? Dob { get; set; }
        public Svecenik? Nadredeni { get; set; }

        public override string ToString()
        {
            return "ime: " + Ime + ", dob: " + Dob;
        }
    }
}
