using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.RandomKlaseObjekti.Random2
{
    internal class Sticenik : Entitet
    {
        public Sticenik(int sifra, Zaposlenik zaposlenik, Prostor prostor, string ime, string vrsta, string prehrana)
        {
            base.Sifra = sifra;
            this.Zaposlenik = zaposlenik;
            this.Prostor = prostor;
            base.Ime = ime;
            this.Vrsta = vrsta;
            this.Prehrana = prehrana;
        }

        public Zaposlenik? Zaposlenik { get; set; }
        public Prostor? Prostor { get; set; }
        public string? Vrsta { get; set; }
        public string? Prehrana { get; set; }

        public override string ToString()
        {
            return Zaposlenik + ", " + Prostor + ", štićenik: " + Ime + ", " + Vrsta;
        }

    }
}
