using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.RandomKlaseObjekti.Random
{
    internal class Projekt : Entitet
    {

        public Projekt(int sifra, string naziv, DateTime datumpocetka, DateTime datumkraja)
        {
            Sifra = sifra;
            Naziv = naziv;
            Datum = datumpocetka;
            Datum = datumkraja;
        }

    }
}
