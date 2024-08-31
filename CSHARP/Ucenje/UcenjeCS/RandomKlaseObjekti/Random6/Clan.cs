using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.RandomKlaseObjekti.Random6
{
    internal class Clan
    {
        public Clan(Skupina skupina, Dijete dijete, DateOnly datumPristupanja)
        {
            this.Skupina = skupina;
            this.Dijete = dijete;
            this.DatumPristupanja = datumPristupanja;
        }

        public Skupina? Skupina { get; set; }
        public Dijete? Dijete { get; set; }
        public DateOnly? DatumPristupanja { get; set; }

        public override string ToString()
        {
            return Dijete + ", " + Skupina + ", pristupio/la: " + DatumPristupanja;
        }
    }
}
