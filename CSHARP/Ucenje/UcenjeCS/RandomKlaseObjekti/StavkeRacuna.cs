using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.RandomKlaseObjekti
{
    internal class StavkeRacuna
    {
        public StavkeRacuna(Racun racun, string artikl, double cijena, string kolicina, string popust)
        {
            this.Racun = racun;
            this.Artikl = artikl;
            this.Cijena = cijena;
            this.Kolicina = kolicina;
            this.Popust = popust;
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
