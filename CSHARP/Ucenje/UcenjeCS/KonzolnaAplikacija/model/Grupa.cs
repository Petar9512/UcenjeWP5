using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcenjeCS.E15KlasaObjekt.GenericiLambdaEkstenzije;

namespace UcenjeCS.KonzolnaAplikacija.model
{
    internal class Grupa : Entitet
    {
        public Grupa()
        {
            Polaznici = new List<Polaznik>();
        }

        public string? Naziv { get; set; }
        public Smjer? Smjer { get; set; }
        public string? Predavac { get; set; }
        public int BrojPolaznika { get; set; }
        public List<Polaznik> Polaznici { get; set; }

    }
}
