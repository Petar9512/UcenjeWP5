using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.RandomKlaseObjekti.Random5
{
    internal class Nakladnik : Entitet
    {
        public Nakladnik(int sifra, Mjesto mjesto, string naziv, string adresa, string kontakt)
        {
            base.Sifra = sifra;
            this.Mjesto = mjesto;
            base.Naziv = naziv;
            this.Adresa = adresa;
            base.Kontakt = kontakt;
        }

        public Mjesto? Mjesto { get; set; }
        public string? Adresa { get; set; }

        public override string ToString()
        {
            return Naziv + ", " + Adresa + ", " + Mjesto;
        }
    }
}
