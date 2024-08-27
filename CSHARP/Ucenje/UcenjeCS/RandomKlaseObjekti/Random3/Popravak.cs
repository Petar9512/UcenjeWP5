using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.RandomKlaseObjekti.Random3
{
    internal class Popravak : Entitet
    {
        public Popravak(int sifra, Korisnik korisnik, string kolicinaObuce)
        {
            base.Sifra = sifra;
            this.Korisnik = korisnik;
            this.KolicinaObuce = kolicinaObuce;
        }

        public Korisnik? Korisnik { get; set; }
        public string? KolicinaObuce { get; set; }

        public override string ToString()
        {
            return Korisnik + ", količina: " + KolicinaObuce;
        }
    }
}
