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

        public override string ToString()
        {
            return Ime + " " + Prezime + ", šifra: " + Sifra;
        }

        public Polaznik Promijeni(Polaznik p)
        {
            p.Sifra = Pomocno.UcitajRasponBroja("Unesite novu šifru (" + p.Sifra + ")", 1, int.MaxValue);
            p.Ime = Pomocno.UcitajString(p.Ime, "Unesite novo ime", 50, true);
            p.Prezime = Pomocno.UcitajString(p.Prezime, "Unesite novo prezime", 50, true);
            p.Email = Pomocno.UcitajString(p.Email, "Unesite novi email", 50, true);
            p.Oib = Pomocno.UcitajString(p.Oib, "Unesite novi OIB", 11, true);

            return p;
        }

        public Polaznik PromijeniOdredeno(Polaznik p)
        {
            switch (Pomocno.UcitajRasponBroja("1. Šifra \n2. Ime \n 3.Prezime \n 4. Email \n 5. Oib", 1, 5))
            {
                case 1:
                    p.Sifra = Pomocno.UcitajRasponBroja("Unesite novu šifru", 1, int.MaxValue);
                    break;
                case 2:
                    p.Ime = Pomocno.UcitajString(p.Ime, "Unesite novo ime", 50, true);
                    break;
                case 3:
                    p.Prezime = Pomocno.UcitajString(p.Prezime, "Unesite novo prezime", 50, true);
                    break;
                case 4:
                    p.Email = Pomocno.UcitajString(p.Email, "Unesite novi email", 50, true);
                    break;
                case 5:
                    p.Oib = Pomocno.UcitajString(p.Oib, "Unesite novi OIB", 11, true);
                    break;
            }
            return p;
        }
    }
}
