using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.RandomKlaseObjekti.Random5
{
    internal class Popravak : Entitet
    {
        public Popravak(int sifra, DateTime vrijeme, int brojPopravljenihKvarova)
        {
            base.Sifra = sifra;
            base.Datum = vrijeme;
            this.BrojPopravljenihKvarova = brojPopravljenihKvarova;
        }

        public int? BrojPopravljenihKvarova { get; set; }

        public override string ToString()
        {
            return "vrijeme: " + Datum;
        }
    }
}
