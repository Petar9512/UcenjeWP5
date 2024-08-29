using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.RandomKlaseObjekti.Random5
{
    internal class Obrana : Entitet
    {
        public Obrana(int sifra, Klijent klijent, string nazivSlucaja, string nazivSuda)
        {
            base.Sifra = sifra;
            this.Klijent = klijent;
            this.NazivSlucaja = nazivSlucaja;
            this.NazivSuda = nazivSuda;
        }

        public Klijent? Klijent { get; set; }
        public string? NazivSlucaja { get; set; }
        public string? NazivSuda { get; set; }

        public override string ToString()
        {
            return "slučaj: " + NazivSlucaja + ", " + Klijent + ", sud: " + NazivSuda;
        }
    }
}
