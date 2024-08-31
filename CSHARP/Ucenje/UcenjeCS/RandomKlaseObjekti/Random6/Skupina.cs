using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.RandomKlaseObjekti.Random6
{
    internal class Skupina : Entitet
    {
        public Skupina(int sifra, Teta teta, string naziv, int brojDjece)
        {
            base.Sifra = sifra;
            this.Teta = teta;
            base.Naziv = naziv;
            this.BrojDjece = brojDjece;
        }

        public Teta? Teta { get; set; }
        public int? BrojDjece { get; set; }

        public override string ToString()
        {
            return Naziv + ", teta: " + Teta;
        }
    }
}
