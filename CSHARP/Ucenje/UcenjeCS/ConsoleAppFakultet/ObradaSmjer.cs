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
        public Izbornik Izbornik { get; set; }

        public ObradaSmjer(Izbornik izbornik)
        {
            this.Izbornik = izbornik;
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
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nIzbornik - smjerovi");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1. Prikaži sve smjerove");
            Console.WriteLine("2. Pregled detalja smjera");
            Console.WriteLine("3. Dodaj novi smjer");
            Console.WriteLine("4. Promijeni podatke smjera");
            Console.WriteLine("5. Brisanje smjera");
            Console.WriteLine("6. Dodaj / obriši studente");
            Console.WriteLine("7. Povratak na glavni izbornik");
            OdabirOpcijeIzbornika();
        }

        private void OdabirOpcijeIzbornika()
        {
            switch (Pomocno.UcitajRasponBroja("\nOdaberite opciju izbornika", 1, 7))
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
                    PrikaziSmjerove();
                    var s = Smjerovi[Pomocno.UcitajRasponBroja("\nUnesite redni broj smjera za unos/brisanje studenata", 1, Smjerovi.Count) - 1];
                    switch (Pomocno.UcitajRasponBroja("1 - dodati\n2 - obrisati\n3 - povratak na izbornik", 1, 3))
                    {
                        case 1:
                            UcitajStudente(s, s.Studenti);
                            break;
                        case 2:
                            ObrisiStudente(s, s.Studenti);
                            break;
                        case 3:
                            break;
                    }
                    PrikaziIzbornik();
                    break;
                case 7:
                    break;
            }
        }

        private void ObrisiStudente(Smjer s, List<Student> listaStudenata)
        {
            if (listaStudenata.Count != 0)
            {
                do
                {
                    var rbs = 1;
                    foreach (var e in listaStudenata)
                    {
                        Console.WriteLine(rbs++ + ". " + e.Ime + " " + e.Prezime);
                    }
                    var stu = listaStudenata[Pomocno.UcitajRasponBroja("\nUnesite redni broj studenta za brisanje", 1, listaStudenata.Count) - 1];
                    if (Pomocno.UcitajBool("Obrisati studenta " + stu.Ime + " " + stu.Prezime + "? (DA / NE)", "da"))
                    {
                        listaStudenata.Remove(stu);
                    }
                }
                while (listaStudenata.Count != 0 && Pomocno.UcitajBool("Želite li obrisati još jednog studenta? (DA / NE)", "da"));
            }

            if (listaStudenata.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Nema više studenata u ovom smjeru");
                Console.WriteLine("Povratak na izbornik");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        private void UcitajStudente(Smjer s, List<Student> listaStudenata)
        {
            if (listaStudenata.Count < s.BrojStudenata)
            {
                Izbornik.ObradaStudent.PrikaziStudente();
                do
                {
                    var opcija = Pomocno.UcitajRasponBroja("\nIzaberite redni broj studenta za unos ili 0 za povratak na izbornik", 0, Izbornik.ObradaStudent.Studenti.Count);
                    if (opcija == 0)
                    {
                        break;
                    }
                    else
                    {
                        listaStudenata.Add(Izbornik.ObradaStudent.Studenti[opcija - 1]);
                    }
                }
                while (listaStudenata.Count < s.BrojStudenata && Pomocno.UcitajBool("Unos još jednog studenta? (DA / NE)", "da"));
            }

            if (listaStudenata.Count >= s.BrojStudenata)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Dosegnut je maksimalan broj studenata u ovom smjeru");
                Console.WriteLine("Povratak na izbornik");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        private void ObrisiSmjer()
        {
            PrikaziSmjerove();
            var s = Smjerovi[Pomocno.UcitajRasponBroja("\nUnesite redni broj smjera za brisanje", 1, Smjerovi.Count) - 1];
            if (Pomocno.UcitajRasponBroja("1 - obriši smjer\n2 - odustani", 1, 2) == 1)
            {
                Smjerovi.Remove(s);
            }           
        }

        private void PromijeniSmjer()
        {
            PrikaziSmjerove();
            var s = Smjerovi[Pomocno.UcitajRasponBroja("\nUnesite redni broj smjera za promjenu", 1, Smjerovi.Count) - 1];

            switch (Pomocno.UcitajRasponBroja("1 - promijeni sve parametre \n2 - promijeni pojedinačno \n3 - odustani", 1, 3))
            {
                case 1:
                    s.Sifra = Pomocno.UcitajRasponBroja("Unesite novu šifru (" + s.Sifra + "):", 1, int.MaxValue);
                    s.Naziv = Pomocno.UcitajString(s.Naziv, "Unesite novi naziv smjera", 50, true);
                    s.BrojStudenata = Pomocno.UcitajRasponBroja("Unesite novi broj studenata (" + s.BrojStudenata + "):", 10, 60);
                    if (Pomocno.UcitajBool("Želite li dodati studente u ovaj smjer? (DA / NE)", "da"))
                    {
                        UcitajStudente(s, s.Studenti);
                    }
                    if (Pomocno.UcitajBool("Želite li obrisati studente iz ovog smjera? (DA / NE)", "da"))
                    {
                        ObrisiStudente(s, s.Studenti);
                    }
                    break;
                case 2:
                    switch (Pomocno.UcitajRasponBroja("\nUnesite broj parametra za promjenu: \n1 - šifra\n2 - naziv\n3 - broj studenata\n4 - dodaj/obriši studente\n5 - odustani", 1, 5))
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
                        case 4:
                            if (Pomocno.UcitajBool("Želite li dodati studente u ovaj smjer? (DA / NE)", "da"))
                            {
                                UcitajStudente(s, s.Studenti);
                            }
                            if (Pomocno.UcitajBool("Želite li obrisati studente iz ovog smjera? (DA / NE)", "da"))
                            {
                                ObrisiStudente(s, s.Studenti);
                            }
                            break;
                        case 5:
                            break;
                    }
                    break;
                case 3:
                    break;
            }
        }

        private void DodajSmjer()
        {
            var s = new Smjer();
            s.Sifra = Pomocno.UcitajRasponBroja("Unesite šifru smjera", 1, int.MaxValue);
            s.Naziv = Pomocno.UcitajString("Unesite naziv smjera", 50, true);
            s.BrojStudenata = Pomocno.UcitajRasponBroja("Unesite broj studenata", 10, 60);
            if (Pomocno.UcitajBool("Želite li dodati studente u ovaj smjer? (DA / NE)", "da"))
            {
                UcitajStudente(s, s.Studenti);
            }
            Smjerovi.Add(s);
        }

        private void PregledSmjera()
        {
            PrikaziSmjerove();
            var broj = Pomocno.UcitajRasponBroja("\nOdaberite redni broj smjera za prikaz ili 0 za povratak na izbornik", 0, Smjerovi.Count);
            if (broj == 0)
            {
                return;
            }
            else
            {
                var s = Smjerovi[broj - 1];
                Console.WriteLine("naziv: " + s.Naziv + "\nStudenti: ");
                if (s.Studenti.Count != 0)
                {
                    foreach (var e in s.Studenti)
                    {
                        Console.WriteLine("šifra: " + e.Sifra + ", Oib: " + e.Oib);
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Još nema studenata u ovom smjeru");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }           
        }

        public void PrikaziSmjerove()
        {
            var rbs = 1;
            foreach (var s in Smjerovi)
            {
                Console.WriteLine(rbs++ + ". " + s.Naziv + ", broj slobodnih mjesta: " + (s.BrojStudenata - s.Studenti.Count));
            }
        }
    }
}
