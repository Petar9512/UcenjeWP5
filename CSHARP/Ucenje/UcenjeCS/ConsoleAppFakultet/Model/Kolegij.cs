using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.ConsoleAppFakultet.Model
{
    internal class Kolegij : Entitet
    {

        public Smjer? Smjer { get; set; }
        public string? Naziv { get; set; }
        public string? Predavac { get; set; }
        public bool? Obavezni { get; set; }

    }
}
