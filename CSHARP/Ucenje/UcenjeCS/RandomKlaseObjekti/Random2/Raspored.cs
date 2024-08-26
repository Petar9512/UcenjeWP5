using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.RandomKlaseObjekti.Random2
{
    internal class Raspored : Entitet
    {
        public Raspored(Svecenik svecenik, Posao posao, DateTime vrijeme)
        {
            this.Svecenik = svecenik;
            this.Posao = posao;
            base.Datum = vrijeme;
        }

        public Svecenik? Svecenik { get; set; }
        public Posao? Posao { get; set; }

        public override string ToString()
        {
            return Svecenik + ", " + Posao + ", vrijeme: " + Datum;
        }

    }
}
