using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.RandomKlaseObjekti.Random4
{
    internal class Razred : Entitet
    {
        public Razred(int sifra, string naziv, int brojUcenika)
        {
            base.Sifra = sifra;
            base.Naziv = naziv;
            this.BrojUcenika = brojUcenika;
        }

        public int? BrojUcenika { get; set; }

        public override string ToString()
        {
            return "razred: " + Naziv;
        }

    }
}
