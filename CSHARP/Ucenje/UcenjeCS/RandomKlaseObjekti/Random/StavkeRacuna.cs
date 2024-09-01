using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.RandomKlaseObjekti.Random
{
    internal class StavkeRacuna
    {
        public StavkeRacuna(Racun racun, string artikl, double cijena, string kolicina, string popust)
        {
            Racun = racun;
            Artikl = artikl;
            Cijena = cijena;
            Kolicina = kolicina;
            Popust = popust;
        }

        public Racun? Racun { get; set; }
        public string? Artikl { get; set; }
        public double? Cijena { get; set; }
        public string? Kolicina { get; set; }
        public string? Popust { get; set; }

        public override string ToString()
        {
            return Racun + ", artikl: " + Artikl + ", količina: " + Kolicina + ", cijena: " + Cijena + ", popust: " + Popust + ", plaćeno: " + (Racun.Placeno ? "da" : "ne");
        }

    }
}
