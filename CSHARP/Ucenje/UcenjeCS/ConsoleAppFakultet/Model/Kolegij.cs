using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.ConsoleAppFakultet.Model
{
    internal class Kolegij : Entitet
    {
        public Kolegij() { }

        public Kolegij(int sifra, Smjer smjer, string naziv, string predavac, bool obavezni)
        {
            base.Sifra = sifra;
            this.Smjer = smjer;
            this.Naziv = naziv;
            this.Predavac = predavac;
            this.Obavezni = obavezni;
        }

        public Smjer? Smjer { get; set; }
        public string? Naziv { get; set; }
        public string? Predavac { get; set; }
        public bool? Obavezni { get; set; }

    }
}
