using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.RandomKlaseObjekti.Random4
{
    internal class Proizvod : Entitet
    {
        public Proizvod(int sifra, Djelatnik djelatnik, string naziv, string opis)
        {
            base.Sifra = sifra;
            this.Djelatnik = djelatnik;
            base.Naziv = naziv;
            this.Opis = opis;
        }

        public Djelatnik? Djelatnik { get; set; }
        public string? Opis { get; set; }

        public override string ToString()
        {
            return Djelatnik + ", proizvod: " + Naziv + " - " + Opis;
        }
    }
}
