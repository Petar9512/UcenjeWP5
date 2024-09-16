using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcenjeCS.ConsoleAppFakultet.Model;
using UcenjeCS.KonzolnaAplikacija;

namespace UcenjeCS.ConsoleAppFakultet
{
    internal class ObradaSmjer
    {

        public List<Smjer> Smjerovi { get; set; }

        public ObradaSmjer()
        {
            Smjerovi = new List<Smjer>();
            if (Pomocno.DEV)
            {
                UcitajTestnePodatke();
            }
        }

        private void UcitajTestnePodatke()
        {
            Smjerovi.Add(new(1, "Anglistika", 50));
            Smjerovi.Add(new(2, "Germanistika", 40));
            Smjerovi.Add(new(3, "Talijanistika", 40));
            Smjerovi.Add(new(4, "Kroatistika", 50));
        }

        public void PrikaziIzbornik()
        {
            Console.WriteLine("\nOdaberite opciju izbornika: ");
            Console.WriteLine("1. Prikaži sve smjerove");
            Console.WriteLine("2. Pregled detalja smjera");
            Console.WriteLine("3. Dodaj novi smjer");
            Console.WriteLine("4. Promijeni podatke smjera");
            Console.WriteLine("5. Brisanje smjera");
            Console.WriteLine("6. Povratak na glavni izbornik");
        }
    }
}
