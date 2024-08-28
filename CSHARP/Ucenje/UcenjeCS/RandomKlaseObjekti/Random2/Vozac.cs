﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.RandomKlaseObjekti.Random2
{
    internal class Vozac : Entitet
    {

        public Vozac(int sifra, string ime, string prezime, string kontakt)
        {
            base.Sifra = sifra;
            base.Ime = ime;
            base.Prezime = prezime;
            base.Kontakt = kontakt;
        }

        public override string ToString()
        {
            return "vozač: " + Ime + " " + Prezime;
        }

    }
}