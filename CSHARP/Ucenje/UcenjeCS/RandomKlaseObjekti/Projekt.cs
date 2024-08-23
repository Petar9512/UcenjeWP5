using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.RandomKlaseObjekti
{
    internal class Projekt : Entitet
    {

        public Projekt(int sifra, string naziv, DateTime datumpocetka, DateTime datumkraja)
        {
            base.Sifra = sifra;
            base.Naziv = naziv;
            base.Datum = datumpocetka;
            base.Datum = datumkraja;
        }

    }
}
