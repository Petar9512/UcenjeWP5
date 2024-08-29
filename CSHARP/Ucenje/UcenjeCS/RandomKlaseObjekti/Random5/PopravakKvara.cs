using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.RandomKlaseObjekti.Random5
{
    internal class PopravakKvara
    {
        public PopravakKvara(Popravak popravak, Kvar kvar, string opisPopravka, double cijena, bool segrt)
        {
            this.Popravak = popravak;
            this.Kvar = kvar;
            this.OpisPopravka = opisPopravka;
            this.Cijena = cijena;
            this.Segrt = segrt;
        }

        public Popravak? Popravak { get; set; }
        public Kvar? Kvar { get; set; }
        public string? OpisPopravka { get; set; }
        public double? Cijena { get; set; }
        public bool Segrt { get; set; }

        public override string ToString()
        {
            return Kvar + ", popravak: " + OpisPopravka + ", " + Popravak + ", cijena: " + Cijena;
        }
    }
}
