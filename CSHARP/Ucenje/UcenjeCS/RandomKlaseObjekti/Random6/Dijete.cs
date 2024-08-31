using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.RandomKlaseObjekti.Random6
{
    internal class Dijete : Entitet
    {
        public Dijete(int sifra, string ime, string prezime, string kontakt, DateOnly datumRodenja)
        {
            base.Sifra = sifra;
            base.Ime = ime;
            base.Prezime = prezime;
            base.Kontakt = kontakt;
            this.DatumRodenja = datumRodenja;
        }

        public DateOnly? DatumRodenja { get; set; }

        public override string ToString()
        {
            return Ime + " " + Prezime + ", kontakt roditelja: " + Kontakt;
        }
    }
}
