using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.RandomKlaseObjekti.Random2
{
    internal class Korisnik : Entitet
    {
        public Korisnik(int sifra, string ime, string prezime, string spol, string tipKose)
        {
            base.Sifra = sifra;
            base.Ime = ime;
            base.Prezime = prezime;
            this.Spol = spol;
            this.TipKose = tipKose;
        }

        public string? Spol { get; set; }
        public string? TipKose { get; set; }

        public override string ToString()
        {
            return "korisnik: " + Ime + " " + Prezime + ", spol: " + Spol + ", kosa: " + TipKose;
        }

    }
}
