using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.RandomKlaseObjekti.Random3
{
    internal class Dijete : Entitet
    {
        public Dijete(int sifra, string ime, string prezime, DateOnly datumRodenja, string razred)
        {
            base.Sifra = sifra;
            base.Ime = ime;
            base.Prezime = prezime;
            this.DatumRodenja = datumRodenja;
            this.Razred = razred;
        }

        public DateOnly? DatumRodenja { get; set; }
        public string? Razred { get; set; }

        public override string ToString()
        {
            return "učenik: " + Ime + " " + Prezime + ", " + Razred;
        }
    }
}
