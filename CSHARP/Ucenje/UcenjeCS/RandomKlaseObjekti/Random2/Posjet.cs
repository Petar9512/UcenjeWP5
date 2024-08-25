using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.RandomKlaseObjekti.Random2
{
    internal class Posjet : Entitet
    {
        public Posjet(Djelatnik djelatnik, Korisnik korisnik, Usluga usluga, DateTime vrijeme)
        {
            this.Djelatnik = djelatnik;
            this.Korisnik = korisnik;
            this.Usluga = usluga;
            base.Datum = vrijeme;
        }

        public Djelatnik? Djelatnik { get; set; }
        public Korisnik? Korisnik { get; set; }
        public Usluga? Usluga { get; set; }

        public override string ToString()
        {
            return Djelatnik + ", " + Korisnik + ", " + Usluga;
        }
    }
}
