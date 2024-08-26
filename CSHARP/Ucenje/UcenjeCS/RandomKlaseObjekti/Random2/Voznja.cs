using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.RandomKlaseObjekti.Random2
{
    internal class Voznja : Entitet
    {
        public Voznja(int sifra, Vozilo vozilo, int brojPutnika, DateTime vrijemePocetka, DateTime vrijemeZavrsetka)
        {
            base.Sifra = sifra;
            this.Vozilo = vozilo;
            this.BrojPutnika = brojPutnika;
            this.VrijemePocetka = vrijemePocetka;
            this.VrijemeZavrsetka = vrijemeZavrsetka;
        }

        public Vozilo? Vozilo { get; set; }
        public int? BrojPutnika { get; set; }
        public DateTime? VrijemePocetka { get; set; }
        public DateTime? VrijemeZavrsetka { get; set; }

        public override string ToString()
        {
            return Vozilo + ", broj putnika: " + BrojPutnika + ", vrijeme: " + VrijemePocetka + " - " + VrijemeZavrsetka;
        }

    }
}
