using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.ConsoleAppFakultet.Model
{
    internal class IspitniRok : Entitet
    {
        public IspitniRok() { }

        public IspitniRok(int sifra, Kolegij kolegij, string vrstaIspita, DateTime datum, List<Student> studenti)
        {
            base.Sifra = sifra;
            this.Kolegij = kolegij;
            this.VrstaIspita = vrstaIspita;
            this.Datum = datum;
            this.Studenti = studenti;
        }

        public Kolegij? Kolegij { get; set; }
        public string? VrstaIspita { get; set; }
        public DateTime? Datum { get; set; }
        public List<Student> Studenti { get; set; }

    }
}
