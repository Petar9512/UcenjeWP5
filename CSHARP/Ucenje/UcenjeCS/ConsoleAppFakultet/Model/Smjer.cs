﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.ConsoleAppFakultet.Model
{
    internal class Smjer : Entitet
    {
        public Smjer() 
        {
            Studenti = new List<Student>();
        }

        public Smjer(int sifra, string naziv, int brojStudenata)
        {
            base.Sifra = sifra;
            this.Naziv = naziv;
            this.BrojStudenata = brojStudenata;
            Studenti = new List<Student>();
        }

        public string? Naziv { get; set; }
        public int? BrojStudenata { get; set; }
        public List<Student> Studenti { get; set; }
    }
}
