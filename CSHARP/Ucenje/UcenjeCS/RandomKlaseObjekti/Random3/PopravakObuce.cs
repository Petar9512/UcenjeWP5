using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.RandomKlaseObjekti.Random3
{
    internal class PopravakObuce : Entitet
    {
        public PopravakObuce(Popravak popravak, Obuca obuca, DateTime vrijemePopravka, string opisPopravka, double cijena, bool segrt)
        {
            this.Popravak = popravak;
            this.Obuca = obuca;
            base.Datum = vrijemePopravka;
            this.OpisPopravka = opisPopravka;
            this.Cijena = cijena;
            this.Segrt = segrt;
        }

        public Popravak? Popravak { get; set; }
        public Obuca? Obuca { get; set; }
        public string? OpisPopravka { get; set; }
        public double? Cijena { get; set; }
        public bool Segrt { get; set; }

        public override string ToString()
        {
            return Obuca + ", opis: " + OpisPopravka + ", vrijeme: " + Datum + ", cijena: " + Cijena;
        }
    }
}
