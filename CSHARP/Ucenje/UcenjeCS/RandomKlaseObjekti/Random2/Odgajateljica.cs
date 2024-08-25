using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.RandomKlaseObjekti.Random2
{
    internal class Odgajateljica : Entitet
    {
        public Odgajateljica(int sifra, string ime, string prezime, string brojTelefona, StrucnaSprema strucnaSprema)
        {
            base.Sifra = sifra;
            base.Ime = ime;
            base.Prezime = prezime;
            this.BrojTelefona = brojTelefona;
            this.StrucnaSprema = strucnaSprema;
        }

        public string? BrojTelefona { get; set; }
        public StrucnaSprema? StrucnaSprema { get; set; }

        public override string ToString()
        {
            return "odgajateljica: " + Ime + " " + Prezime + ", kontakt: " + BrojTelefona;
        }

    }
}
