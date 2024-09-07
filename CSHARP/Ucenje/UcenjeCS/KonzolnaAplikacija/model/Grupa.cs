using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.KonzolnaAplikacija.model
{
    internal class Grupa : Entitet
    {

        public string? Naziv { get; set; }
        public Smjer? Smjer { get; set; }

    }
}
