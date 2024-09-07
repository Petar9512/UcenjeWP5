using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.KonzolnaAplikacija
{
    internal class Izbornik
    {

        public ObradaSmjer ObradaSmjer { get; set; }
        public ObradaGrupa ObradaGrupa { get; set; }

        public Izbornik()
        {
            Pomocno.DEV = true;
            ObradaSmjer = new ObradaSmjer();
            ObradaGrupa = new ObradaGrupa(this);
            PrikaziIzbornik();
        }

        private void PrikaziIzbornik()
        {
            Console.WriteLine("Glavni izbornik");
            Console.WriteLine("1. Smjerovi");
            Console.WriteLine("2. Grupe");
            Console.WriteLine("4. Izlaz iz programa");
            OdabirOpcijeIzbornika();
        }

        private void OdabirOpcijeIzbornika()
        {
            switch(E11Metode.UcitajCijeliBroj("Odaberite opciju izbornika", 1, 4))
            {
                case 1:
                    ObradaSmjer.PrikaziIzbornik();
                    Console.Clear();
                    PrikaziIzbornik();
                    break;
                case 2:
                  //  ObradaGrupa.PrikaziIzbornik();
                    Console.Clear();
                    PrikaziIzbornik();
                    break;
                case 4:
                    break;
            }
        }
    }
}
