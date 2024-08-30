using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.RandomKlaseObjekti.Random5
{
    internal class Izdanje
    {
        public Izdanje(Nakladnik nakladnik, Djelo djelo, string godinaIzdanja)
        {
            this.Nakladnik = nakladnik;
            this.Djelo = djelo;
            this.GodinaIzdanja = godinaIzdanja;
        }

        public Nakladnik? Nakladnik { get; set; }
        public Djelo? Djelo { get; set; }
        public string? GodinaIzdanja { get; set; }

        public override string ToString()
        {
            return Djelo + " - " + Nakladnik + " - godina: " + GodinaIzdanja + ".";
        }
    }
}
