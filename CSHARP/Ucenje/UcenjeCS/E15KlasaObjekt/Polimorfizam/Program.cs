using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E15KlasaObjekt.Polimorfizam
{
    internal class Program
    {

        public Program()
        {
            var obrade = new Obrada[2];

            obrade[0] = new ObradaIzlaznihRacuna();
            obrade[1] = new ObradaUlaznihRacuna();

            foreach (var o in obrade)
            {
                o.Procesuiraj();
            }
        }

    }
}
