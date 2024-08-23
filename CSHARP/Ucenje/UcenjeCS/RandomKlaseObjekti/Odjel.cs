using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.RandomKlaseObjekti
{
    internal class Odjel : Entitet
    {

        public Odjel(int sifra, string naziv)
        {
            base.Sifra = sifra;
            base.Naziv = naziv;
        }

    }
}
