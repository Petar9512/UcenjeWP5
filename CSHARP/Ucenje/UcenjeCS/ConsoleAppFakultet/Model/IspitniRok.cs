using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.ConsoleAppFakultet.Model
{
    internal class IspitniRok : Entitet
    {

        public Kolegij? Kolegij { get; set; }
        public string? VrstaIspita { get; set; }
        public DateTime? Datum { get; set; }
        public List<Student> Studenti { get; set; }

    }
}
