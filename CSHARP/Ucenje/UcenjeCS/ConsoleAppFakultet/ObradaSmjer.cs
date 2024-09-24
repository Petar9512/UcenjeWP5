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
            Console.WriteLine("\nIzbornik - smjerovi");
            Console.WriteLine("1. Prikaži sve smjerove");
            Console.WriteLine("2. Pregled detalja smjera");
            Console.WriteLine("3. Dodaj novi smjer");
            Console.WriteLine("4. Promijeni podatke smjera");
            Console.WriteLine("5. Brisanje smjera");
            Console.WriteLine("6. Povratak na glavni izbornik");
            OdabirOpcijeIzbornika();
        }

        private void OdabirOpcijeIzbornika()
        {
            switch (Pomocno.UcitajRasponBroja("Odaberite opciju izbornika", 1, 6))
            {
                case 1:
                    PrikaziSmjerove();
                    PrikaziIzbornik();
                    break;
                case 2:
                    PregledSmjera();
                    PrikaziIzbornik();
                    break;
                case 3:
                    DodajSmjer();
                    PrikaziIzbornik();
                    break;
                case 4:
                    PromijeniSmjer();
                    PrikaziIzbornik();
                    break;
                case 5:
                    ObrisiSmjer();
                    PrikaziIzbornik();
                    break;
                case 6:
                    break;
            }
        }

        private void ObrisiSmjer()
        {
            PrikaziSmjerove();
            var s = Smjerovi[Pomocno.UcitajRasponBroja("Unesite redni broj smjera za brisanje", 1, Smjerovi.Count) - 1];
            if (Pomocno.UcitajRasponBroja("1 - obriši smjer\n2 - odustani", 1, 2) == 1)
            {
                Smjerovi.Remove(s);
            }           
        }

        private void PromijeniSmjer()
        {
            PrikaziSmjerove();
            var s = Smjerovi[Pomocno.UcitajRasponBroja("Unesite redni broj smjera za promjenu", 1, Smjerovi.Count) - 1];

            if (Pomocno.UcitajRasponBroja("1 - promijeni sve parametre \n2 - promijeni pojedinačno", 1, 2) == 1)
            {
                s.Sifra = Pomocno.UcitajRasponBroja("Unesite novu šifru (" + s.Sifra + "):", 1, int.MaxValue);
                s.Naziv = Pomocno.UcitajString(s.Naziv, "Unesite novi naziv smjera", 50, true);
                s.BrojStudenata = Pomocno.UcitajRasponBroja("Unesite novi broj studenata (" + s.BrojStudenata + "):", 10, 60);
            }
            else
            {
                switch(Pomocno.UcitajRasponBroja("Unesite broj parametra za promjenu: \n1. šifra\n2. naziv\n3. broj studenata", 1, 3))
                {
                    case 1:
                        s.Sifra = Pomocno.UcitajRasponBroja("Unesite novu šifru (" + s.Sifra + "):", 1, int.MaxValue);
                        break;
                    case 2:
                        s.Naziv = Pomocno.UcitajString(s.Naziv, "Unesite novi naziv smjera", 50, true);
                        break;
                    case 3:
                        s.BrojStudenata = Pomocno.UcitajRasponBroja("Unesite novi broj studenata (" + s.BrojStudenata + "):", 10, 60);
                        break;
                }
            }
        }

        private void DodajSmjer()
        {
            var s = new Smjer();
            s.Sifra = Pomocno.UcitajRasponBroja("Unesite šifru smjera", 1, int.MaxValue);
            s.Naziv = Pomocno.UcitajString("Unesite naziv smjera", 50, true);
            s.BrojStudenata = Pomocno.UcitajRasponBroja("Unesite broj studenata", 10, 60);
            Smjerovi.Add(s);
        }

        private void PregledSmjera()
        {
            PrikaziSmjerove();
            var s = Smjerovi[Pomocno.UcitajRasponBroja("Odaberite redni broj smjera za prikaz: ", 1, Smjerovi.Count) - 1];
            Console.WriteLine("naziv: " + s.Naziv + ", broj studenata: " + s.BrojStudenata);
        }

        public void PrikaziSmjerove()
        {
            var rbs = 1;
            foreach (var s in Smjerovi)
            {
                Console.WriteLine(rbs++ + ". " + s.Naziv);
            }
        }
    }
}
