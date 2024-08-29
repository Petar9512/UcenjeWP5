using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.RandomKlaseObjekti.Random5
{
    internal class Kvar : Entitet
    {
        public Kvar(int sifra, string naziv, string opisKvara, string tipInstalacije)
        {
            base.Sifra = sifra;
            base.Naziv = naziv;
            this.OpisKvara = opisKvara;
            this.TipInstalacije = tipInstalacije;
        }

        public string? OpisKvara { get; set; }
        public string? TipInstalacije { get; set; }

        public override string ToString()
        {
            return "kvar: " + OpisKvara + " - " + TipInstalacije;
        }
    }
}
