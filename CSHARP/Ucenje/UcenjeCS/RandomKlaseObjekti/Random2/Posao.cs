using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.RandomKlaseObjekti.Random2
{
    internal class Posao : Entitet
    {
        public Posao(int sifra, string opis, TimeOnly vrijemePocetka, TimeOnly vrijemeZavrsetka)
        {
            base.Sifra = sifra;
            this.Opis = opis;
            this.VrijemePocetka = vrijemePocetka;
            this.VrijemeZavrsetka = vrijemeZavrsetka;
        }

        public string? Opis { get; set; }
        public TimeOnly? VrijemePocetka { get; set; }
        public TimeOnly? VrijemeZavrsetka { get; set; }

        public override string ToString()
        {
            return "posao: " + Opis + " " + VrijemePocetka + " - " + VrijemeZavrsetka;
        }

    }
}
