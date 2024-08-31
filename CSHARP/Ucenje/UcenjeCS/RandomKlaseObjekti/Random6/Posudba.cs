using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.RandomKlaseObjekti.Random6
{
    internal class Posudba
    {
        public Posudba(Citatelj citatelj, Knjiga knjiga, DateOnly pocetakPosudbe, DateOnly krajPosudbe)
        {
            this.Citatelj = citatelj;
            this.Knjiga = knjiga;
            this.PocetakPosudbe = pocetakPosudbe;
            this.KrajPosudbe = krajPosudbe;
        }

        public Citatelj? Citatelj { get; set; }
        public Knjiga? Knjiga { get; set; }
        public DateOnly? PocetakPosudbe { get; set; }
        public DateOnly? KrajPosudbe { get; set; }

        public override string ToString()
        {
            return Citatelj + ", posudio/la: " + Knjiga + ", od: " + PocetakPosudbe + ", do: " + KrajPosudbe;
        }
    }
}
