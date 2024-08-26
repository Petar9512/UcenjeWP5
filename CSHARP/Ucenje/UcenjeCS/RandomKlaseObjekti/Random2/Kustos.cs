using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.RandomKlaseObjekti.Random2
{
    internal class Kustos : Entitet
    {
        public Kustos(int sifra, string ime, string prezime, string brojTelefona, Izlozba izlozba)
        {
            base.Sifra = sifra;
            base.Ime = ime;
            base.Prezime = prezime;
            this.BrojTelefona = brojTelefona;
            this.Izlozba = izlozba;
        }

        public string? BrojTelefona { get; set; }
        public Izlozba? Izlozba { get; set; }

        public override string ToString()
        {
            return "ime: " + Ime + " " + Prezime + ", kontakt: " + BrojTelefona;
        }

    }
}
