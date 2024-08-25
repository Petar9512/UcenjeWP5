﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.RandomKlaseObjekti.Random2
{
    internal class Djelo : Entitet
    {
        public Djelo(int sifra, string autor, string stil, Izlozba izlozba)
        {
            base.Sifra = sifra;
            this.Autor = autor;
            this.Stil = stil;
            this.Izlozba = izlozba;
        }

        public string? Autor { get; set; }
        public string? Stil { get; set; }
        public Izlozba? Izlozba { get; set; }

    }
}
