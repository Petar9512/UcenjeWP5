using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.RandomKlaseObjekti.Random6
{
    internal class Knjiga : Entitet
    {
        public Knjiga(int sifra, string naziv, string autor, Citatelj vlasnik)
        {
            base.Sifra = sifra;
            base.Naziv = naziv;
            this.Autor = autor;
            this.Vlasnik = vlasnik;
        }

        public string? Autor { get; set; }
        public Citatelj? Vlasnik { get; set; }

        public override string ToString()
        {
            return Naziv + ", vlasnik: " + Vlasnik.Ime + " " + Vlasnik.Prezime;
        }
    }
}
