using System;
using System.Collections.Generic;
using System.Linq;
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
            Console.WriteLine("6. Dodaj pristupnike");
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
                    var e = Rokovi[Pomocno.UcitajRasponBroja("Unesite redni broj ispitnog roka za unos pristupnika", 1, Rokovi.Count) - 1];
                    UcitajPristupnike2(e, e.Studenti);
                    PrikaziIzbornik();
                    break;
                case 7:
                    break;
            }
        }

        private void UcitajPristupnike(IspitniRok r, List<Student> listaPristupnika)
        {
            while (Pomocno.UcitajBool("Unos novog pristupnika? (DA / NE)", "da"))
            {
                Izbornik.ObradaStudent.PrikaziStudente();
                var opcija = Pomocno.UcitajRasponBroja("Izaberite redni broj pristupnika za unos", 1, Izbornik.ObradaStudent.Studenti.Count);
                listaPristupnika.Add(Izbornik.ObradaStudent.Studenti[opcija - 1]);
            }
            r.Studenti = listaPristupnika;
        }

        private void UcitajPristupnike2(IspitniRok e, List<Student> lista)
        {           
            while (Pomocno.UcitajBool("Unos novog pristupnika? (DA / NE)", "da"))
            {
                Izbornik.ObradaStudent.PrikaziStudente();
                var opcija = Pomocno.UcitajRasponBroja("Izaberite redni broj pristupnika za unos", 1, Izbornik.ObradaStudent.Studenti.Count);
                lista.Add(Izbornik.ObradaStudent.Studenti[opcija - 1]);
            }
            e.Studenti = lista;
        }

        private void ObrisiRok()
        {
            PrikaziRokove();
            var r = Rokovi[Pomocno.UcitajRasponBroja("Unesite redni broj ispitnog roka za brisanje", 1, Rokovi.Count) - 1];
            Rokovi.Remove(r);
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
            }
            else
            {
                switch(Pomocno.UcitajRasponBroja("Unesite broj parametra za promjenu \n1 - šifra\n2 - kolegij\n3 - vrsta ispita\n4 - vrijeme\n5 - dodaj pristupnike", 1, 5))
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
                        UcitajPristupnike(r, r.Studenti);
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
            var rbp = 1;
            foreach (var r in Rokovi)
            {
                Console.WriteLine(rbis++ + ". " + r.Kolegij.Naziv + " - " + r.Datum + ", " + r.VrstaIspita);
            }
        }
    }
}
