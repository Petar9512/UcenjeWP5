using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.RandomKlaseObjekti.Random6
{
    internal class Zupan : Entitet
    {

        public Zupan(int sifra, string ime, string prezime)
        {
            base.Sifra = sifra;
            base.Ime = ime;
            base.Prezime = prezime;
        }

        public override string ToString()
        {
            return "župan: " + Ime + " " + Prezime;
        }

    }
}
