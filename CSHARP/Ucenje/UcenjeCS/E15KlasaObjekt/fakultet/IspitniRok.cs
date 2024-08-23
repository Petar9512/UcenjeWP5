using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E15KlasaObjekt.fakultet
{
    internal class IspitniRok : Entitet
    {
        public IspitniRok(int sifra, Kolegij kolegij, string vrstaIspita, DateTime datum)
        {
            base.Sifra = sifra;
            this.Kolegij = kolegij;
            this.VrstaIspita = vrstaIspita;
            this.Datum = datum;
        }

        public Kolegij? Kolegij { get; set; }
        public string? VrstaIspita { get; set; }
        public DateTime? Datum { get; set; }
        public Student[]? Pristupnici { get; set; }

        public override string ToString()
        {
            return "šifra: " + Sifra + ", vrijeme: " + Datum + ", vrsta: " + VrstaIspita + ", kolegij: " + Kolegij.Naziv;
        }

    }
}
