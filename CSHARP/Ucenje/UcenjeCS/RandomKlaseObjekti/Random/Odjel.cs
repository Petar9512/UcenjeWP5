using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.RandomKlaseObjekti.Random
{
    internal class Odjel : Entitet
    {

        public Odjel(int sifra, string naziv)
        {
            Sifra = sifra;
            Naziv = naziv;
        }

        public override string ToString()
        {
            return "odjel: " + Naziv;
        }

    }
}
