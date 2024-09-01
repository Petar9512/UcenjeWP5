using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.RandomKlaseObjekti.Random6
{
    internal class Opcina : Entitet
    {
        public Opcina(int sifra, string naziv, Zupanija zupanija)
        {
            base.Sifra = sifra;
            base.Naziv = naziv;
            this.Zupanija = zupanija;
        }

        public Zupanija? Zupanija { get; set; }

        public override string ToString()
        {
            return "općina: " + Naziv + ", " + Zupanija;
        }
    }
}
