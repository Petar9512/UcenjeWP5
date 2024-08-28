using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.RandomKlaseObjekti.Random4
{
    internal class Profesor : Entitet
    {

        public Profesor(int sifra, string ime, string prezime, string kontakt)
        {
            base.Sifra = sifra;
            base.Ime = ime;
            base.Prezime = prezime;
            base.Kontakt = kontakt;
        }

        public override string ToString()
        {
            return "ime: " + Ime + " " + Prezime + ", kontakt: " + Kontakt;
        }

    }
}
