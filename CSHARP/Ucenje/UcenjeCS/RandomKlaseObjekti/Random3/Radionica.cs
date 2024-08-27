using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.RandomKlaseObjekti.Random3
{
    internal class Radionica : Entitet
    {
        public Radionica(int sifra, string naziv, DateTime vrijemePocetka, int brojDjece, Uciteljica uciteljica)
        {
            base.Sifra = sifra;
            base.Naziv = naziv;
            base.Datum = vrijemePocetka;
            this.BrojDjece = brojDjece;
            this.Uciteljica = uciteljica;
        }

        public int? BrojDjece { get; set; }
        public Uciteljica? Uciteljica { get; set; }

        public override string ToString()
        {
            return "radionica: " + Naziv + ", početak: " + Datum + ", " + Uciteljica;
        }
    }
}
