using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.RandomKlaseObjekti.Random6
{
    internal class Racun : Entitet
    {
        public Racun(int sifra, DateTime datum, Kupac kupac, string status)
        {
            base.Sifra = sifra;
            base.Datum = datum;
            this.Kupac = kupac;
            this.Status = status;
        }

        public Kupac? Kupac { get; set; }
        public string? Status { get; set; }

        public override string ToString()
        {
            return Kupac + ", vrijeme: " + Datum;
        }
    }
}
