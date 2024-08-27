using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.RandomKlaseObjekti.Random3
{
    internal class Student : Entitet
    {
        public Student(int sifra, string ime, string prezime, string oib, DateOnly datumRodenja, string smjer)
        {
            base.Sifra = sifra;
            base.Ime = ime;
            base.Prezime = prezime;
            this.Oib = oib;
            this.DatumRodenja = datumRodenja;
            this.Smjer = smjer;
        }

        public string? Oib { get; set; }
        public DateOnly? DatumRodenja { get; set; }
        public string? Smjer { get; set; }

        public override string ToString()
        {
            return "student: " + Ime + " " + Prezime + ", rođenje: " + DatumRodenja + ", smjer: " + Smjer;
        }
    }
}
