using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E15KlasaObjekt.fakultet
{
    internal class Smjer : Entitet
    {
        public Smjer(int sifra, string naziv, int brojStudenata)
        {
            base.Sifra = sifra;
            base.Naziv = naziv;
            this.BrojStudenata = brojStudenata;
        }

        public int? BrojStudenata { get; set; }

        public override string ToString()
        {
            return "šifra: " + Sifra + ", naziv: " + Naziv + ", broj studenata: " + BrojStudenata;
        }

    }
}
