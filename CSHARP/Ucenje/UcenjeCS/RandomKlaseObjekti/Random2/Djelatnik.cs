using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.RandomKlaseObjekti.Random2
{
    internal class Djelatnik : Entitet
    {
        public Djelatnik(int sifra, string ime, string prezime, string brojTelefona)
        {
            base.Sifra = sifra;
            base.Ime = ime;
            base.Prezime = prezime;
            this.BrojTelefona = brojTelefona;
        }

        public string? BrojTelefona { get; set; }

        public override string ToString()
        {
            return "djelatnik: " + Ime + " " + Prezime;
        }

    }
}
