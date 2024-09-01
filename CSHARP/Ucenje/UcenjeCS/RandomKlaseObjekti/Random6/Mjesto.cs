using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.RandomKlaseObjekti.Random6
{
    internal class Mjesto : Entitet
    {
        public Mjesto(int sifra, string naziv, Opcina opcina)
        {
            base.Sifra = sifra;
            base.Naziv = naziv;
            this.Opcina = opcina;
        }

        public Opcina? Opcina { get; set; }

        public override string ToString()
        {
            return "mjesto: " + Naziv + ", " + Opcina;
        }
    }
}
