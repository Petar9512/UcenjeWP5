using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.RandomKlaseObjekti.Random3
{
    internal class Lijecenje
    {
        public Lijecenje(Pacijent pacijent, string lijekovi, DateOnly pocetakLijecenja, DateOnly krajLijecenja)
        {
            this.Pacijent = pacijent;
            this.Lijekovi = lijekovi;
            this.PocetakLijecenja = pocetakLijecenja;
            this.KrajLijecenja = krajLijecenja;
        }

        public Pacijent? Pacijent { get; set; }
        public string? Lijekovi { get; set; }
        public DateOnly? PocetakLijecenja { get; set; }
        public DateOnly? KrajLijecenja { get; set; }

        public override string ToString()
        {
           return Pacijent + ", lijek: " + Lijekovi + ", početak: " + PocetakLijecenja + ", kraj: " + KrajLijecenja;
        }
    }
}
