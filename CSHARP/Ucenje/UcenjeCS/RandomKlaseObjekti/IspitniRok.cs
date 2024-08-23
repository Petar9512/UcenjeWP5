using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.RandomKlaseObjekti
{
    internal class IspitniRok : Entitet
    {
        public IspitniRok(int sifa, string predmet, string vrstaIspita, DateTime datum)
        {
            base.Sifra = Sifra;
            this.Predmet = predmet;
            this.VrstaIspita = vrstaIspita;
            base.Datum = datum;
        }

        public string? Predmet { get; set; }
        public string? VrstaIspita { get; set; }

        public override string ToString()
        {
            return Predmet + ", " + VrstaIspita + ", " + Datum;
        }

    }
}
