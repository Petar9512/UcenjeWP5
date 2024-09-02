using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E15KlasaObjekt.Polimorfizam
{
    internal class ObradaUlaznihRacuna : Obrada
    {

        public override void Procesuiraj()
        {
            Console.WriteLine("obrada ulaznih računa");
        }

    }
}
