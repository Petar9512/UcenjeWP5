using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.RandomKlaseObjekti.Random4
{
    internal class Zaposlenik
    {
        public Zaposlenik(Osoba osoba, Trgovina trgovina, TimeOnly pocetakRV, TimeOnly krajRV)
        {
            this.Osoba = osoba;
            this.Trgovina = trgovina;
            this.PocetakRV = pocetakRV;
            this.KrajRV = krajRV;
        }

        public Osoba? Osoba { get; set; }
        public Trgovina? Trgovina { get; set; }
        public TimeOnly? PocetakRV { get; set; }
        public TimeOnly? KrajRV { get; set; }

        public override string ToString()
        {
            return Osoba + ", radno vrijeme: " + PocetakRV + "-" + KrajRV + ", " + Trgovina;
        }
    }
}
