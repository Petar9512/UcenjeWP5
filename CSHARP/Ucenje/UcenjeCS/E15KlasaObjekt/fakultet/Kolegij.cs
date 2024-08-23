using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E15KlasaObjekt.fakultet
{
    internal class Kolegij : Entitet
    {
        public Kolegij() { }
        public Kolegij(int sifra, Smjer smjer, string naziv, string predavac, bool obavezni)
        {
            base.Sifra = sifra;
            this.Smjer = smjer;
            base.Naziv = naziv;
            this.Predavac = predavac;
            this.Obavezni = obavezni;
        }

        public Smjer? Smjer { get; set; }
        public string? Predavac { get; set; }
        public bool Obavezni { get; set; }

        public override string ToString()
        {
            return "šifra: " + Sifra + ", smjer: " + Smjer.Naziv + ", naziv: " + Naziv + ", status: " + (Obavezni ? "obavezni" : "izborni");
        }

    }
}
