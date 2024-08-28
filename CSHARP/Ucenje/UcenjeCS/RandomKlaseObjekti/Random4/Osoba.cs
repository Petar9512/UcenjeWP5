﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.RandomKlaseObjekti.Random4
{
    internal class Osoba : Entitet
    {
        public Osoba(int sifra, string ime, string prezime, DateOnly datumRodenja, string kontakt)
        {
            base.Sifra = sifra;
            base.Ime = ime;
            base.Prezime = prezime;
            this.DatumRodenja = datumRodenja;
            base.Kontakt = kontakt;
        }

        public DateOnly? DatumRodenja { get; set; }

        public override string ToString()
        {
            return Ime + " " + Prezime + ", kontakt: " + Kontakt;
        }
    }
}
