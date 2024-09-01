using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.RandomKlaseObjekti.Random6
{
    internal class Kupac : Entitet
    {
        public Kupac(int sifra, string ime, string prezime, string ulica, string mjesto)
        {
            base.Sifra = sifra;
            base.Ime = ime;
            base.Prezime = prezime;
            this.Ulica = ulica;
            this.Mjesto = mjesto;
        }

        public string? Ulica { get; set; }
        public string? Mjesto { get; set; }

        public override string ToString()
        {
            return Ime + " " + Prezime + ", adresa: " + Ulica + ", " + Mjesto;
        }
    }
}
