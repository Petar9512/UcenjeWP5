using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.RandomKlaseObjekti
{
    internal abstract class Entitet
    {

        public int? Sifra { get; set; }
        public string? Naziv { get; set; }
        public string? Ime { get; set; }
        public string? Prezime { get; set; }
        public DateTime? Datum { get; set; }

    }
}
