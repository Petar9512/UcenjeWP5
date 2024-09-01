using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.RandomKlaseObjekti.Random
{
    internal class Zaposlenik : Entitet
    {
        public Zaposlenik() { }

        public Zaposlenik(int sifra, Zaposlenik nadredeni, string ime, string prezime, DateTime datumrodenja, double placa, Odjel odjel)
        {
            Sifra = sifra;
            Nadredeni = nadredeni;
            Ime = ime;
            Prezime = prezime;
            Datum = datumrodenja;
            Placa = placa;
            Odjel = odjel;
        }

        public Zaposlenik? Nadredeni { get; set; }
        public double? Placa { get; set; }
        public Odjel? Odjel { get; set; }

        public override string ToString()
        {
            return "zaposlenik: " + Ime + " " + Prezime + ", nadređeni: " + Nadredeni?.Ime + " " + Nadredeni?.Prezime + ", datum rođenja: " + Datum + ", " + Odjel;
        }

    }
}
