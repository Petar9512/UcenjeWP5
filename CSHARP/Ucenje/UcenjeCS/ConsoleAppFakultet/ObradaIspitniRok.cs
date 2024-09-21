using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using UcenjeCS.ConsoleAppFakultet.Model;
using UcenjeCS.KonzolnaAplikacija;

namespace UcenjeCS.ConsoleAppFakultet
{
    internal class ObradaIspitniRok
    {

        public List<IspitniRok> Rokovi { get; set; }
        public Izbornik Izbornik { get; set; }

        public ObradaIspitniRok(Izbornik izbornik)
        {
            this.Izbornik = izbornik;
            Rokovi = new List<IspitniRok>();
            if (Pomocno.DEV)
            {
                UcitajTestnePodatke();
            }
        }

        private void UcitajTestnePodatke()
        {
            Rokovi.Add(new(1, Izbornik.ObradaKolegij.Kolegiji[5], "pismeni", new DateTime(2024, 6, 10, 12, 0, 0)));
            Rokovi.Add(new(2, Izbornik.ObradaKolegij.Kolegiji[6], "usmeni", new DateTime(2024, 6, 14, 10, 0, 0)));
            Rokovi.Add(new(3, Izbornik.ObradaKolegij.Kolegiji[0], "pismeni", new DateTime(2024, 6, 10, 9, 0, 0)));
            Rokovi.Add(new(4, Izbornik.ObradaKolegij.Kolegiji[1], "pismeni", new DateTime(2024, 6, 12, 10, 30, 0)));
            Rokovi.Add(new(5, Izbornik.ObradaKolegij.Kolegiji[2], "pismeni", new DateTime(2024, 6, 17, 14, 0, 0)));
            Rokovi.Add(new(6, Izbornik.ObradaKolegij.Kolegiji[4], "pismeni", new DateTime(2024, 6, 18, 16, 0, 0)));
        }

        public void PrikaziIzbornik()
        {
            Console.WriteLine("\nIzbornik - ispitni rokovi");
            Console.WriteLine("1. Prikaži sve ispitne rokove");
            Console.WriteLine("2. Pregled detalja ispitnog roka");
            Console.WriteLine("3. Dodaj novi ispitni rok");
            Console.WriteLine("4. Promijeni podatke ispitnog roka");
            Console.WriteLine("5. Brisanje ispitnog roka");
            Console.WriteLine("6. Dodaj / obriši pristupnike");
            Console.WriteLine("7. Povratak na glavni izbornik");
            OdabirOpcijeIzbornika();
        }

        private void OdabirOpcijeIzbornika()
        {
            switch(Pomocno.UcitajRasponBroja("Odaberite opciju izbornika", 1, 7))
            {
                case 1:
                    PrikaziRokove();
                    PrikaziIzbornik();
                    break;
                case 2:
                    PregledRoka();
                    PrikaziIzbornik();
                    break;
                case 3:
                    DodajRok();
                    PrikaziIzbornik();
                    break;
                case 4:
                    PromijeniRok();
                    PrikaziIzbornik();
                    break;
                case 5:
                    ObrisiRok();
                    PrikaziIzbornik();
                    break;
                case 6:
                    var r = Rokovi[Pomocno.UcitajRasponBroja("Unesite redni broj ispitnog roka za unos/brisanje pristupnika", 1, Rokovi.Count) - 1];
                    if (Pomocno.UcitajBool("1 - dodati \n2 - obrisati", "1"))
                    {
                        UcitajPristupnike(r, r.Studenti);
                    }
                    else
                    {
                        ObrisiPristupnike(r, r.Studenti);
                    }
                    PrikaziIzbornik();
                    break;
                case 7:
                    break;
            }
        }

        private void ObrisiPristupnike(IspitniRok r, List<Student> listaPristupnika)
        {
            if (listaPristupnika.Count != 0)
            {                
                do
                {
                    var rbs = 1;
                    foreach (var e in listaPristupnika)
                    {
                        Console.WriteLine(rbs++ + ". " + e.Ime + " " + e.Prezime);
                    }
                    var s = listaPristupnika[Pomocno.UcitajRasponBroja("Unesite redni broj pristupnika za brisanje", 1, listaPristupnika.Count) - 1];
                    if (Pomocno.UcitajBool("Obrisati pristupnika " + s.Ime + " " + s.Prezime + "? (DA / NE)", "da"))
                    {
                        listaPristupnika.Remove(s);
                    }
                }
                while (listaPristupnika.Count != 0 && Pomocno.UcitajBool("Želite li obrisati još jednog pristupnika? (DA / NE)", "da"));
            }

            if (listaPristupnika.Count == 0)
            {
                Console.WriteLine("Nema više pristupnika u ovom ispitnom roku");
            }
        }

        private void UcitajPristupnike(IspitniRok r, List<Student> listaPristupnika)
        {
            Izbornik.ObradaStudent.PrikaziStudente();
            do
            {
                var opcija = Pomocno.UcitajRasponBroja("Izaberite redni broj pristupnika za unos ili 0 za povratak na izbornik", 0, Izbornik.ObradaStudent.Studenti.Count);
                if (opcija == 0)
                {
                    break;
                }
                else
                {
                    listaPristupnika.Add(Izbornik.ObradaStudent.Studenti[opcija - 1]);
                }                
            }
            while (Pomocno.UcitajBool("Unos još jednog pristupnika? (DA / NE)", "da"));
        }

        private void ObrisiRok()
        {
            PrikaziRokove();
            var r = Rokovi[Pomocno.UcitajRasponBroja("Unesite redni broj ispitnog roka za brisanje", 1, Rokovi.Count) - 1];
            if (Pomocno.UcitajBool("1 - obriši rok\n2 - odustani", "1"))
            {
                Rokovi.Remove(r);
            }           
        }

        private void PromijeniRok()
        {
            PrikaziRokove();
            var r = Rokovi[Pomocno.UcitajRasponBroja("Unesite redni broj roka za promjenu", 1, Rokovi.Count) - 1];
            if (Pomocno.UcitajBool("1 - promijeniti sve parametre\n2 - promijeniti pojedinačno", "1"))
            {
                r.Sifra = Pomocno.UcitajRasponBroja("Unesite novu šifru (" + r.Sifra + ")", 1, int.MaxValue);
                r.Kolegij = Izbornik.ObradaKolegij.Kolegiji[Pomocno.UcitajRasponBroja("Unesite redni broj kolegija", 1, Izbornik.ObradaKolegij.Kolegiji.Count) - 1];
                r.VrstaIspita = Pomocno.UcitajString("Unesite vrstu ispita", 30, true);
                r.Datum = Pomocno.UcitajDatum(false);
                if (Pomocno.UcitajBool("Želite li dodati pristupnike u ovaj ispitni rok? (DA / NE)", "da"))
                {
                    UcitajPristupnike(r, r.Studenti);
                }
                if (Pomocno.UcitajBool("Želite li obrisati pristupnike iz ovog ispitnog roka? (DA / NE)", "da"))
                {
                    ObrisiPristupnike(r, r.Studenti);
                }
            }
            else
            {
                switch(Pomocno.UcitajRasponBroja("Unesite broj parametra za promjenu \n1 - šifra\n2 - kolegij\n3 - vrsta ispita\n4 - vrijeme\n5 - dodaj/obriši pristupnike", 1, 5))
                {
                    case 1:
                        r.Sifra = Pomocno.UcitajRasponBroja("Unesite novu šifru (" + r.Sifra + ")", 1, int.MaxValue);
                        break;
                    case 2:
                        r.Kolegij = Izbornik.ObradaKolegij.Kolegiji[Pomocno.UcitajRasponBroja("Unesite redni broj kolegija", 1, Izbornik.ObradaKolegij.Kolegiji.Count) - 1];
                        break;
                    case 3:
                        r.VrstaIspita = Pomocno.UcitajString("Unesite vrstu ispita", 30, true);
                        break;
                    case 4:
                        r.Datum = Pomocno.UcitajDatum(false);
                        break;
                    case 5:
                        if (Pomocno.UcitajBool("1 - dodati \n2 - obrisati", "1"))
                        {
                            UcitajPristupnike(r, r.Studenti);
                        }
                        else
                        {
                            ObrisiPristupnike(r, r.Studenti);
                        }
                        break;
                }
            }
        }

        private void DodajRok()
        {
            var r = new IspitniRok();
            r.Sifra = Pomocno.UcitajRasponBroja("Unesite šifru", 1, int.MaxValue);
            r.Kolegij = Izbornik.ObradaKolegij.Kolegiji[Pomocno.UcitajRasponBroja("Unesite redni broj kolegija", 1, Izbornik.ObradaKolegij.Kolegiji.Count) - 1];
            r.VrstaIspita = Pomocno.UcitajString("Unesite vrstu ispita", 30, true);
            r.Datum = Pomocno.UcitajDatum(false);
            if (Pomocno.UcitajBool("Želite li dodati pristupnike u ovaj ispitni rok? (DA / NE)", "da"))
            {
                UcitajPristupnike(r, r.Studenti);
            }
            Rokovi.Add(r);
        }

        private void PregledRoka()
        {
            var r = Rokovi[Pomocno.UcitajRasponBroja("Unesite redni broj ispitnog roka za prikaz", 1, Rokovi.Count) - 1];
            Console.WriteLine(r.Kolegij.Naziv + " - " + r.Datum + ", " + r.VrstaIspita + "\nPrijavljeni: ");
            if (r.Studenti.Count != 0)
            {
                foreach (var p in r.Studenti)
                {
                    Console.WriteLine(p.Ime + " " + p.Prezime);
                }               
            }
            else
            {
                Console.WriteLine("Nema prijavljenih");
            }            
        }

        private void PrikaziRokove()
        {
            var rbis = 1;
            foreach (var r in Rokovi)
            {
                Console.WriteLine(rbis++ + ". " + r.Kolegij.Naziv + " (" + r.Kolegij.Smjer.Naziv + ") - " + r.Datum + ", " + r.VrstaIspita);
            }
        }
    }
}
