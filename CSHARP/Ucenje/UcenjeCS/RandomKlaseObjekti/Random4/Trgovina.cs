using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcenjeCS.E15KlasaObjekt;

namespace UcenjeCS.RandomKlaseObjekti.Random4
{
    internal class Trgovina : Entitet
    {
        public Trgovina(int sifra, string naziv, int brojZaposlenika, string opisDjelatnosti, Osoba sef)
        {
            base.Sifra = sifra;
            base.Naziv = naziv;
            this.BrojZaposlenika = brojZaposlenika;
            this.OpisDjelatnosti = opisDjelatnosti;
            this.Sef = sef;
        }

        public int? BrojZaposlenika { get; set; }
        public string? OpisDjelatnosti { get; set; }
        public Osoba? Sef { get; set; }

        public override string ToString()
        {
            return "trgovina: " + Naziv + " - " + OpisDjelatnosti + ", šef: " + Sef;
        }

    }
}
