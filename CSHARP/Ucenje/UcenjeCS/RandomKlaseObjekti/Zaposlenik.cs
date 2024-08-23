using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.RandomKlaseObjekti
{
    internal class Zaposlenik : Entitet
    {
        public Zaposlenik() { }

        public Zaposlenik(int sifra, Zaposlenik nadredeni, string ime, string prezime, DateTime datumrodenja, double placa, Odjel odjel)
        {
            base.Sifra = sifra;
            this.Nadredeni = nadredeni;
            base.Ime = ime;
            base.Prezime = prezime;
            base.Datum = datumrodenja;
            this.Placa = placa;
            this.Odjel = odjel;
        }

        public Zaposlenik? Nadredeni { get; set; }
        public double? Placa { get; set; }
        public Odjel? Odjel { get; set; }

    }
}
