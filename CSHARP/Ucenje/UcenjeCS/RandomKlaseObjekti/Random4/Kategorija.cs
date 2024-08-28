using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.RandomKlaseObjekti.Random4
{
    internal class Kategorija : Entitet
    {

        public Kategorija(int sifra, string naziv)
        {
            base.Sifra = sifra;
            base.Naziv = naziv;
        }

        public override string ToString()
        {
            return "kategorija: " + Naziv;
        }
    }
}
