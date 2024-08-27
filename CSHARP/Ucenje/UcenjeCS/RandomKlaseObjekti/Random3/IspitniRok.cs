using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.RandomKlaseObjekti.Random3
{
    internal class IspitniRok : Entitet
    {
        public IspitniRok(int sifra, string kolegij, string vrstaIspita, DateTime vrijeme)
        {
            base.Sifra = sifra;
            this.Kolegij = kolegij;
            this.VrstaIspita = vrstaIspita;
            base.Datum = vrijeme;
        }

        public string? Kolegij { get; set; }
        public string? VrstaIspita { get; set; }

        public override string ToString()
        {
            return "kolegij: " + Kolegij + ", ispit: " + VrstaIspita + ", " + Datum;
        }
    }
}
