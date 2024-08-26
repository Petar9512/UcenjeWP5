using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.RandomKlaseObjekti.Random2
{
    internal class Izlozba : Entitet
    {
        public Izlozba(int sifra, string naziv, int brojDjela, DateTime vrijemePocetka, Sponzor sponzor)
        {
            base.Sifra = sifra;
            base.Naziv = naziv;
            this.BrojDjela = brojDjela;
            base.Datum = vrijemePocetka;
            this.Sponzor = sponzor;
        }

        public int? BrojDjela { get; set; }
        public Sponzor? Sponzor { get; set; }

        public override string ToString()
        {
            return "izložba: " + Naziv + ", početak: " + Datum;
        }

    }
}
