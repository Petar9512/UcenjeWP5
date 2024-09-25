using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.ConsoleAppFakultet.Model
{
    internal class Student : Entitet
    {
        public Student() { }

        public Student(int sifra, Smjer smjer, string ime, string prezime, int godina, string oib)
        {
            base.Sifra = sifra;
            this.Smjer = smjer;
            this.Ime = ime;
            this.Prezime = prezime;
            this.GodinaStudiranja = godina;
            this.Oib = oib;
        }

        public Smjer? Smjer { get; set; }
        public string? Ime { get; set; }
        public string? Prezime { get; set; }
        public int? GodinaStudiranja { get; set; }
        public string? Oib { get; set; }

    }
}
