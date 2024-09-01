using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.RandomKlaseObjekti.Random6
{
    internal class Zaposlenik : Entitet
    {
        public Zaposlenik(int sifra, string ime, string prezime, DateOnly datumRodenja, bool invalid)
        {
            base.Sifra = sifra;
            base.Ime = ime;
            base.Prezime = prezime;
            this.DatumRodenja = datumRodenja;
            this.Invalid = invalid;
        }

        public DateOnly? DatumRodenja { get; set; }
        public bool Invalid { get; set; }

        public override string ToString()
        {
            return Ime + " " + Prezime + ", rođen/a: " + DatumRodenja;
        }
    }
}
