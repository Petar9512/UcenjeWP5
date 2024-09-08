using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.KonzolnaAplikacija.model
{
    internal class Polaznik : Entitet
    {
        public Polaznik() { }
        public Polaznik(int sifra, string ime, string prezime, string email, string oib) 
        {
            base.Sifra = sifra;
            this.Ime = ime;
            this.Prezime = prezime;
            this.Email = email;
            this.Oib = oib;
        }

        public string? Ime { get; set; }
        public string? Prezime { get; set; }
        public string? Email { get; set; }
        public string? Oib { get; set; }

    }
}
