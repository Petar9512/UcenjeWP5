using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.RandomKlaseObjekti.Random2
{
    internal class Skupina : Entitet
    {
        public Skupina(int sifra, Odgajateljica odgajateljica, string naziv, int brojDjece)
        {
            base.Sifra = sifra;
            this.Odgajateljica = odgajateljica;
            base.Naziv = naziv;
            this.BrojDjece = brojDjece;
        }

        public Odgajateljica? Odgajateljica { get; set; }
        public int? BrojDjece { get; set; }

        public override string ToString()
        {
            return "skupina: " + Naziv + ", " + Odgajateljica;
        }
    }
}
