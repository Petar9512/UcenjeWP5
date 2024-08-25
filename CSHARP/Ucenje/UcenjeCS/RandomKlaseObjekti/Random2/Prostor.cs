using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.RandomKlaseObjekti.Random2
{
    internal class Prostor : Entitet
    {
        public Prostor(int sifra, string tip, string visina, string duzina, string sirina)
        {
            base.Sifra = sifra;
            this.Tip = tip;
            this.Visina = visina;
            this.Duzina = duzina;
            this.Sirina = sirina;
        }

        public string? Tip { get; set; }
        public string? Visina { get; set; }
        public string? Duzina { get; set; }
        public string? Sirina { get; set; }

        public override string ToString()
        {
            return "prostor: " + Tip + ", dimenzije: " + Visina + "x" + Duzina + "x" + Sirina;
        }

    }
}
