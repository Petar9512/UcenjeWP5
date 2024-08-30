using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.RandomKlaseObjekti.Random5
{
    internal class Nastup : Entitet
    {
        public Nastup(int sifra, Mjesto mjesto, string naziv, DateTime vrijeme)
        {
            base.Sifra = sifra;
            this.Mjesto = mjesto;
            base.Naziv = naziv;
            base.Datum = vrijeme;
        }

        public Mjesto? Mjesto { get; set; }

        public override string ToString()
        {
            return Naziv + " - " + Datum + ", " + Mjesto;
        }
    }
}
