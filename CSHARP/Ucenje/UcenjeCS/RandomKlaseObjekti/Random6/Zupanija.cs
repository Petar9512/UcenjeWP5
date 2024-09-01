using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.RandomKlaseObjekti.Random6
{
    internal class Zupanija : Entitet
    {
        public Zupanija(int sifra, string naziv, Zupan zupan)
        {
            base.Sifra = sifra;
            base.Naziv = naziv;
            this.Zupan = zupan;
        }

        public Zupan? Zupan { get; set; }

        public override string ToString()
        {
            return "županija: " + Naziv + ", " + Zupan;
        }
    }
}
