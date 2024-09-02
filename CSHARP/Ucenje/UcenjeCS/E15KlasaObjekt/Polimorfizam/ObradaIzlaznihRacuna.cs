using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E15KlasaObjekt.Polimorfizam
{
    internal class ObradaIzlaznihRacuna : Obrada
    {

        public override void Procesuiraj()
        {
            Console.WriteLine("obrada izlaznih računa");
            Console.WriteLine("ažuriraj ako je plaćeno");
        }

    }
}
