using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.RandomKlaseObjekti.Random2
{
    internal class Vozilo : Entitet
    {
        public Vozilo(int sifra, string naziv, string registracija, Vozac vozac)
        {
            base.Sifra = sifra;
            base.Naziv = naziv;
            this.Registracija = registracija;
            this.Vozac = vozac;
        }

        public string? Registracija { get; set; }
        public Vozac? Vozac { get; set; }

        public override string ToString()
        {
            return Naziv + " - " + Registracija + ", " + Vozac;
        }

    }
}
