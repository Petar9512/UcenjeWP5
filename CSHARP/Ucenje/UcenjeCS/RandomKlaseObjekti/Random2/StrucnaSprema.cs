using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.RandomKlaseObjekti.Random2
{
    internal class StrucnaSprema : Entitet
    {

        public StrucnaSprema(int sifra, string naziv)
        {
            base.Sifra = sifra;
            base.Naziv = naziv;
        }

        public override string ToString()
        {
            return "stručna sprema: " + Naziv;
        }
    }
}
