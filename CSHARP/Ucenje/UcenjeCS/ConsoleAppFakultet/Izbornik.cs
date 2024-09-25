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
        public ObradaIspitniRok ObradaIspitniRok { get; set; }

        public Izbornik() 
        {
            Pomocno.DEV = true;
            ObradaSmjer = new ObradaSmjer(this);
            ObradaKolegij = new ObradaKolegij(this);
            ObradaStudent = new ObradaStudent(this);
            ObradaIspitniRok = new ObradaIspitniRok(this);
            PrikaziIzbornik();
        }

        private void PrikaziIzbornik()
        {
            Console.WriteLine("\nGlavni izbornik");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("1. Smjerovi");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("2. Kolegiji");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("3. Studenti");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("4. IspitniRokovi");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("5. Izlaz iz programa");
            OdabirOpcijeIzbornika();
        }

        private void OdabirOpcijeIzbornika()
        {
            switch(KonzolnaAplikacija.Pomocno.UcitajRasponBroja("\nOdaberite opciju izbornika", 1, 5))
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
                    ObradaIspitniRok.PrikaziIzbornik();
                    Console.Clear();
                    PrikaziIzbornik();
                    break;
                case 5:
                    break;
            }
        }
    }
}
