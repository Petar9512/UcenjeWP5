using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcenjeCS.ConsoleAppFakultet.Model;
using UcenjeCS.KonzolnaAplikacija;

namespace UcenjeCS.ConsoleAppFakultet
{
    internal class ObradaStudent
    {

        public List<Student> Studenti { get; set; }
        public Izbornik Izbornik { get; set; }

        public ObradaStudent(Izbornik izbornik)
        {
            this.Izbornik = izbornik;
            Studenti = new List<Student>();
            if (Pomocno.DEV)
            {
                UcitajTestnePodatke();
            }
        }

        private void UcitajTestnePodatke()
        {
            Studenti.Add(new(1, Izbornik.ObradaSmjer.Smjerovi[3], "Ivan", "Ivić", "47457409385"));
            Studenti.Add(new(2, Izbornik.ObradaSmjer.Smjerovi[3], "Hajdi", "Hajdić", "15797970162"));
            Studenti.Add(new(3, Izbornik.ObradaSmjer.Smjerovi[0], "Goran", "Grkić", "20437329240"));
            Studenti.Add(new(4, Izbornik.ObradaSmjer.Smjerovi[0], "Marko", "Markić", "22353796851"));
            Studenti.Add(new(5, Izbornik.ObradaSmjer.Smjerovi[1], "Ivan", "Ivičević", "24088017749"));
        }

        public void PrikaziIzbornik()
        {
            Console.WriteLine("\nIzbornik - studenti");
            Console.WriteLine("1. Prikaži sve studente");
            Console.WriteLine("2. Pregled detalja studenta");
            Console.WriteLine("3. Dodaj novog studenta");
            Console.WriteLine("4. Promijeni podatke studenta");
            Console.WriteLine("5. Brisanje studenta");
            Console.WriteLine("6. Povratak na glavni izbornik");
            OdabirOpcijeIzbornika();
        }

        private void OdabirOpcijeIzbornika()
        {
            switch(Pomocno.UcitajRasponBroja("Odaberite opciju izbornika", 1, 6))
            {
                case 1:
                    PrikaziStudente();
                    PrikaziIzbornik();
                    break;
                case 2:
                    PregledStudenta();
                    PrikaziIzbornik();
                    break;
                case 3:
                    DodajStudenta();
                    PrikaziIzbornik();
                    break;
                case 4:
                    PromjenaStudenta();
                    PrikaziIzbornik();
                    break;
                case 5:
                    ObrisiStudenta();
                    PrikaziIzbornik();
                    break;
                case 6:
                    break;
            }
        }

        private void ObrisiStudenta()
        {
            PrikaziStudente();
            var s = Studenti[Pomocno.UcitajRasponBroja("Unesite redni broj studenta za brisanje", 1, Studenti.Count) - 1];
            Studenti.Remove(s);
        }

        private void PromjenaStudenta()
        {
            PrikaziStudente();
            var s = Studenti[Pomocno.UcitajRasponBroja("Unesite redni broj studenta za promjenu", 1, Studenti.Count) - 1];
            if (Pomocno.UcitajBool("1 - promijeni sve parametre\n2 - promijeni pojedinačno", "1"))
            {
                s.Sifra = Pomocno.UcitajRasponBroja("Unesite novu šifru (" + s.Sifra + ")", 1, int.MaxValue);
                Izbornik.ObradaSmjer.PrikaziSmjerove();
                s.Smjer = Izbornik.ObradaSmjer.Smjerovi[Pomocno.UcitajRasponBroja("Unesite redni broj novog smjera", 1, Izbornik.ObradaSmjer.Smjerovi.Count) - 1];
                s.Ime = Pomocno.UcitajString(s.Ime, "Unesite novo ime studenta", 30, true);
                s.Prezime = Pomocno.UcitajString(s.Prezime, "Unesite novo prezime studenta", 30, true);
                s.Oib = Pomocno.UcitajString(s.Oib, "Unesite novi OIB", 11, true);
            }
            else
            {
                switch(Pomocno.UcitajRasponBroja("Unesite broj parametra za promjenu: \n1 - šifra\n2 - smjer\n3 - ime\n4 - prezime\n5 - OIB", 1, 5))
                {
                    case 1:
                        s.Sifra = Pomocno.UcitajRasponBroja("Unesite novu šifru (" + s.Sifra + ")", 1, int.MaxValue);
                        break;
                    case 2:
                        Izbornik.ObradaSmjer.PrikaziSmjerove();
                        s.Smjer = Izbornik.ObradaSmjer.Smjerovi[Pomocno.UcitajRasponBroja("Unesite redni broj novog smjera", 1, Izbornik.ObradaSmjer.Smjerovi.Count) - 1];
                        break;
                    case 3:
                        s.Ime = Pomocno.UcitajString(s.Ime, "Unesite novo ime studenta", 30, true);
                        break;
                    case 4:
                        s.Prezime = Pomocno.UcitajString(s.Prezime, "Unesite novo prezime studenta", 30, true);
                        break;
                    case 5:
                        s.Oib = Pomocno.UcitajString(s.Oib, "Unesite novi OIB", 11, true);
                        break;
                }
            }
        }

        private void DodajStudenta()
        {
            var s = new Student();
            s.Sifra = Pomocno.UcitajRasponBroja("Unesite šifru studenta", 1, int.MaxValue);
            Izbornik.ObradaSmjer.PrikaziSmjerove();
            s.Smjer = Izbornik.ObradaSmjer.Smjerovi[Pomocno.UcitajRasponBroja("Unesite redni broj smjera", 1, Izbornik.ObradaSmjer.Smjerovi.Count) - 1];
            s.Ime = Pomocno.UcitajString("Unesite ime studenta", 30, true);
            s.Prezime = Pomocno.UcitajString("Unesite prezime studenta", 30, true);
            s.Oib = Pomocno.UcitajString("Unesite OIB studenta", 11, true);
            Studenti.Add(s);
        }

        private void PregledStudenta()
        {
            var s = Studenti[Pomocno.UcitajRasponBroja("Unesite redni broj studenta za pregled", 1, Studenti.Count) - 1];
            Console.WriteLine("student: " + s.Ime + " " + s.Prezime + ", OIB: " + s.Oib + ", smjer: " + s.Smjer.Naziv);
        }

        private void PrikaziStudente()
        {
            var rbs = 1;
            foreach (var s in Studenti)
            {
                Console.WriteLine(rbs++ + ". " + s.Ime + " " + s.Prezime + ", smjer: " + s.Smjer.Naziv);
            }
        }
    }
}
