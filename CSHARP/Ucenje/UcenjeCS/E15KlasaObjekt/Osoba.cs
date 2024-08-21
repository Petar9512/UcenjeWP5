using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E15KlasaObjekt
{
    internal class Osoba
    {

        public int? Sifra { get; set; }
        public string? Ime { get; set; }
        public string? Prezime { get; set; }
        public Mjesto? Mjesto { get; set; }

        public string ImePrezime()
        {
            return Ime + " " + Prezime;
        }

    }
}
