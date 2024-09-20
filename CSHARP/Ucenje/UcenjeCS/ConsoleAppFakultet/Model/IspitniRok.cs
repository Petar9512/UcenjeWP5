using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.ConsoleAppFakultet.Model
{
    internal class IspitniRok : Entitet
    {
        public IspitniRok() 
        {
            Studenti = new List<Student>();
        }

        public IspitniRok(int sifra, Kolegij kolegij, string vrstaIspita, DateTime datum)
        {
            base.Sifra = sifra;
            this.Kolegij = kolegij;
            this.VrstaIspita = vrstaIspita;
            this.Datum = datum;
            Studenti = new List<Student>();
        }

        public Kolegij? Kolegij { get; set; }
        public string? VrstaIspita { get; set; }
        public DateTime? Datum { get; set; }
        public List<Student> Studenti { get; set; }

    }
}
