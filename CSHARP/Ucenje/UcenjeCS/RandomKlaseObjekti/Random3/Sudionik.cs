using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.RandomKlaseObjekti.Random3
{
    internal class Sudionik
    {
        public Sudionik(Dijete dijete, Radionica radionica, DateOnly datumPristupanja)
        {
            this.Dijete = dijete;
            this.Radionica = radionica;
            this.DatumPristupanja = datumPristupanja;
        }

        public Dijete? Dijete { get; set; }
        public Radionica? Radionica { get; set; }
        public DateOnly? DatumPristupanja { get; set; }

        public override string ToString()
        {
            return Dijete + ", " + Radionica + ", pristupio: " + DatumPristupanja;
        }
    }
}
