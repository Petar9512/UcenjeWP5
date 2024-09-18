using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcenjeCS.KonzolnaAplikacija;

namespace UcenjeCS.ConsoleAppFakultet
{
    internal class Izbornik
    {
        public ObradaSmjer ObradaSmjer { get; set; }
        public ObradaKolegij ObradaKolegij { get; set; }
        public ObradaStudent ObradaStudent { get; set; }

        public Izbornik() 
        {
            Pomocno.DEV = true;
            ObradaSmjer = new ObradaSmjer();
            ObradaKolegij = new ObradaKolegij(this);
            ObradaStudent = new ObradaStudent(this);
            PrikaziIzbornik();
        }

        private void PrikaziIzbornik()
        {
            Console.WriteLine("\nIzbornik");
            Console.WriteLine("1. Smjerovi");
            Console.WriteLine("2. Kolegiji");
            Console.WriteLine("3. Studenti");
            Console.WriteLine("4. IspitniRokovi");
            Console.WriteLine("5. Izlaz iz programa");
            OdabirOpcijeIzbornika();
        }

        private void OdabirOpcijeIzbornika()
        {
            switch(KonzolnaAplikacija.Pomocno.UcitajRasponBroja("Odaberite opciju izbornika", 1, 5))
            {
                case 1:
                    ObradaSmjer.PrikaziIzbornik();
                    Console.Clear();
                    PrikaziIzbornik();
                    break;
                case 2:
                    ObradaKolegij.PrikaziIzbornik();
                    Console.Clear();
                    PrikaziIzbornik();
                    break;
                case 3:
                    ObradaStudent.PrikaziIzbornik();
                    Console.Clear();
                    PrikaziIzbornik();
                    break;
                case 4:
                    break;
                case 5:
                    break;
            }
        }
    }
}
