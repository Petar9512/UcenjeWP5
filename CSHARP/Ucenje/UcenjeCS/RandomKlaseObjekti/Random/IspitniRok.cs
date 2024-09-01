using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.RandomKlaseObjekti.Random
{
    internal class IspitniRok : Entitet
    {
        public IspitniRok(int sifa, string predmet, string vrstaIspita, DateTime datum)
        {
            Sifra = Sifra;
            Predmet = predmet;
            VrstaIspita = vrstaIspita;
            Datum = datum;
        }

        public string? Predmet { get; set; }
        public string? VrstaIspita { get; set; }

        public override string ToString()
        {
            return Predmet + ", " + VrstaIspita + ", " + Datum;
        }

    }
}
