﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.ConsoleAppFakultet.Model
{
    internal class Student : Entitet
    {

        public Smjer? Smjer { get; set; }
        public string? Ime { get; set; }
        public string? Prezime { get; set; }
        public string? Oib { get; set; }

    }
}
