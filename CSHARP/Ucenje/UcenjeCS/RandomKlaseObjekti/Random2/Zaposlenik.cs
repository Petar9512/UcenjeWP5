using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.RandomKlaseObjekti.Random2
{
    internal class Zaposlenik : Entitet
    {
        public Zaposlenik(int sifra, string ime, string prezime, string brojTelefona, string email)
        {
            base.Sifra = sifra;
            base.Ime = ime;
            base.Prezime = prezime;
            this.BrojTelefona = brojTelefona;
            this.Email = email;
        }

        public string? BrojTelefona { get; set; }
        public string? Email { get; set; }

        public override string ToString()
        {
            return "zaposlenik: " + Ime + " " + Prezime + ", kontakt: " + BrojTelefona + ", " + Email;
        }

    }
}
