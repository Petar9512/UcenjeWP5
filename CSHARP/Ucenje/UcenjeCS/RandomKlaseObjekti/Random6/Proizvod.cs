using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.RandomKlaseObjekti.Random6
{
    internal class Proizvod : Entitet
    {
        public Proizvod(int sifra, string naziv, DateOnly datumNabave, double cijena, bool aktivan)
        {
            base.Sifra = sifra;
            base.Naziv = naziv;
            this.DatumNabave = datumNabave;
            this.Cijena = cijena;
            this.Aktivan = aktivan;
        }

        public DateOnly? DatumNabave { get; set; }
        public double? Cijena { get; set; }
        public bool Aktivan { get; set; }

        public override string ToString()
        {
            return Naziv + ", cijena: " + Cijena + ", datum nabave: " + DatumNabave + ", aktivan: " + (Aktivan ? "da" : "ne");
        }
    }
}
