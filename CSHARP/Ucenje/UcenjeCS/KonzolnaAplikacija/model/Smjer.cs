using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.KonzolnaAplikacija.model
{
    internal class Smjer : Entitet
    {
        public Smjer() 
        {
        }
        public Smjer(int sifra, string naziv, string trajanje, DateOnly izvodiseod, double cijena, bool vaucer)
        {
            base.Sifra = sifra;
            this.Naziv = naziv;
            this.Trajanje = trajanje;
            this.IzvodiSeOd = izvodiseod;
            this.Cijena = cijena;
            this.Vaucer = vaucer;
        }

        public string? Naziv { get; set; } 
        public string? Trajanje { get; set; } 
        public DateOnly? IzvodiSeOd { get; set; } 
        public double? Cijena { get; set; }
        public bool Vaucer { get; set; }

        public override string ToString()
        {
            return Naziv + "\ntrajanje: " + Trajanje + "\npočetak: " + IzvodiSeOd + "\ncijena: " + Cijena + "\nvaučer: " + (Vaucer ? "da" : "ne");
        }
    }
}
