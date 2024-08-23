using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.RandomKlaseObjekti
{
    internal class Pristupnik
    {
        public Pristupnik(IspitniRok ispitniRok, string student, int brojBodova, int ocjena)
        {
            this.IspitniRok = ispitniRok;
            this.Student = student;
            this.BrojBodova = brojBodova;
            this.Ocjena = ocjena;
        }

        public IspitniRok? IspitniRok { get; set; }
        public string? Student { get; set; }
        public int? BrojBodova { get; set; }
        public int? Ocjena { get; set; }

        public override string ToString()
        {
            return "ime: " + Student + ", ispit: " + IspitniRok + ", rezultat: " + BrojBodova + ", ocjena: " + Ocjena;
        }

    }
}
