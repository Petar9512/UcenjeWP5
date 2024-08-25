using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.RandomKlaseObjekti.Random2
{
    internal class Sponzor : Entitet
    {

        public Sponzor(int sifra, string naziv, string kontakt)
        {
            base.Sifra = sifra;
            base.Naziv = naziv;
            base.Kontakt = kontakt;
        }

    }
}
