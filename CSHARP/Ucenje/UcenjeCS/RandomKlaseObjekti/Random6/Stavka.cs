using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.RandomKlaseObjekti.Random6
{
    internal class Stavka
    {
        public Stavka(Racun racun, Proizvod proizvod, int kolicina, double cijena)
        {
            this.Racun = racun;
            this.Proizvod = proizvod;
            this.Kolicina = kolicina;
            this.Cijena = cijena;
        }

        public Racun? Racun { get; set; }
        public Proizvod? Proizvod { get; set; }
        public int? Kolicina { get; set; }
        public double? Cijena { get; set; }

        public override string ToString()
        {
            return Racun + ", proizvod: " + Proizvod + ", količina: " + Kolicina + ", cijena: " + Cijena;
        }
    }
}
