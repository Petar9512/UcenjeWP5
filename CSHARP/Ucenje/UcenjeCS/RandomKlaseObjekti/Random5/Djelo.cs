using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.RandomKlaseObjekti.Random5
{
    internal class Djelo : Entitet
    {
        public Djelo(int sifra, string naziv, string autor, string zanr)
        {
            base.Sifra = sifra;
            base.Naziv = naziv;
            this.Autor = autor;
            this.Zanr = zanr;
        }

        public string? Autor { get; set; }
        public string? Zanr { get; set; }

        public override string ToString()
        {
            return Autor + ", " + Naziv;
        }
    }
}
