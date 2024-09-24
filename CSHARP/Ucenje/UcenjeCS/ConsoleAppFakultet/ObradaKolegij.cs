using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcenjeCS.ConsoleAppFakultet.Model;
using UcenjeCS.KonzolnaAplikacija;

namespace UcenjeCS.ConsoleAppFakultet
{
    internal class ObradaKolegij
    {

        public List<Kolegij> Kolegiji { get; set; }
        public Izbornik Izbornik { get; set; }

        public ObradaKolegij(Izbornik izbornik)
        {
            this.Izbornik = izbornik;
            Kolegiji = new List<Kolegij>();
            if (Pomocno.DEV)
            {
                UcitajTestnePodatke();
            }
        }

        private void UcitajTestnePodatke()
        {
            Kolegiji.Add(new()
            {
                Sifra = 1,
                Smjer = Izbornik.ObradaSmjer.Smjerovi[0],
                Naziv = "Uvod u englesku književnost",
                Obavezni = true
            });
            Kolegiji.Add(new()
            {
                Sifra = 2,
                Smjer = Izbornik.ObradaSmjer.Smjerovi[0],
                Naziv = "Suvremeni engleski jezik",
                Obavezni = true
            });
            Kolegiji.Add(new()
            {
                Sifra = 3,
                Smjer = Izbornik.ObradaSmjer.Smjerovi[1],
                Naziv = "Jezične vježbe 1",
                Obavezni = true
            });
            Kolegiji.Add(new()
            {
                Sifra = 4,
                Smjer = Izbornik.ObradaSmjer.Smjerovi[1],
                Naziv = "Povijest njemačkog jezika",
                Obavezni = false
            });
            Kolegiji.Add(new()
            {
                Sifra = 5,
                Smjer = Izbornik.ObradaSmjer.Smjerovi[2],
                Naziv = "Jezične vježbe 1",
                Obavezni = true
            });
            Kolegiji.Add(new()
            {
                Sifra = 6,
                Smjer = Izbornik.ObradaSmjer.Smjerovi[3],
                Naziv = "Staroslavenski jezik",
                Obavezni = true
            });
            Kolegiji.Add(new()
            {
                Sifra = 7,
                Smjer = Izbornik.ObradaSmjer.Smjerovi[3],
                Naziv = "Teorija jezika",
                Obavezni = true
            });
        }

        public void PrikaziIzbornik()
        {
            Console.WriteLine("\nIzbornik - kolegiji");
            Console.WriteLine("1. Prikaži sve kolegije");
            Console.WriteLine("2. Pregled detalja kolegija");
            Console.WriteLine("3. Dodaj novi kolegij");
            Console.WriteLine("4. Promijeni podatke kolegija");
            Console.WriteLine("5. Brisanje kolegija");
            Console.WriteLine("6. Povratak na glavni izbornik");
            OdabirOpcijeIzbornika();
        }

        private void OdabirOpcijeIzbornika()
        {
            switch(Pomocno.UcitajRasponBroja("Odaberite opciju izbornika: ", 1, 6))
            {
                case 1:
                    PrikaziKolegije();
                    PrikaziIzbornik();
                    break;
                case 2:
                    PregledKolegija();
                    PrikaziIzbornik();
                    break;
                case 3:
                    DodajKolegij();
                    PrikaziIzbornik();
                    break;
                case 4:
                    PromijeniKolegij();
                    PrikaziIzbornik();
                    break;
                case 5:
                    ObrisiKolegij();
                    PrikaziIzbornik();
                    break;
                case 6:
                    break;
            }
        }

        private void ObrisiKolegij()
        {
            PrikaziKolegije();
            var k = Kolegiji[Pomocno.UcitajRasponBroja("Unesite redni broj kolegija za brisanje", 1, Kolegiji.Count) - 1];
            if (Pomocno.UcitajRasponBroja("1 - obriši kolegij\n2 - odustani", 1, 2) == 1)
            {
                Kolegiji.Remove(k);
            }            
        }

        private void PromijeniKolegij()
        {
            PrikaziKolegije();
            var k = Kolegiji[Pomocno.UcitajRasponBroja("Unesite redni broj kolegija za promjenu", 1, Kolegiji.Count) - 1];
            if (Pomocno.UcitajRasponBroja("1 - promijeni sve parametre \n2 - promijeni pojedinačno", 1, 2) == 1)
            {
                k.Sifra = Pomocno.UcitajRasponBroja("Unesite novu šifru (" + k.Sifra + ")", 1, Kolegiji.Count);
                Izbornik.ObradaSmjer.PrikaziSmjerove();
                k.Smjer = Izbornik.ObradaSmjer.Smjerovi[Pomocno.UcitajRasponBroja("Unesite redni broj novog smjera", 1, Izbornik.ObradaSmjer.Smjerovi.Count) - 1];
                k.Naziv = Pomocno.UcitajString(k.Naziv, "Unesite novi naziv kolegija", 50, true);
                k.Predavac = Pomocno.UcitajString("Unesite ime novog predavača", 50, true);
                k.Obavezni = Pomocno.UcitajBool("Je li kolegij obavezan? (DA / NE)", "da");
            }
            else
            {
                switch(Pomocno.UcitajRasponBroja("Unesite broj parametra za promjenu: \n1 - šifra\n2 - smjer\n3 - naziv\n4 - predavač\n5 - obavezni", 1, 5))
                {
                    case 1: 
                        k.Sifra = Pomocno.UcitajRasponBroja("Unesite novu šifru (" + k.Sifra + ")", 1, Kolegiji.Count);
                        break;
                    case 2:
                        Izbornik.ObradaSmjer.PrikaziSmjerove();
                        k.Smjer = Izbornik.ObradaSmjer.Smjerovi[Pomocno.UcitajRasponBroja("Unesite redni broj novog smjera", 1, Izbornik.ObradaSmjer.Smjerovi.Count) - 1];
                        break;
                    case 3:
                        k.Naziv = Pomocno.UcitajString(k.Naziv, "Unesite novi naziv kolegija", 50, true);
                        break;
                    case 4:
                        k.Predavac = Pomocno.UcitajString("Unesite ime novog predavača", 50, true);
                        break;
                    case 5:
                        k.Obavezni = Pomocno.UcitajBool("Je li kolegij obavezan? (DA / NE)", "da");
                        break;
                }
            }
        }

        private void DodajKolegij()
        {
            var k = new Kolegij();
            k.Sifra = Pomocno.UcitajRasponBroja("Unesite šifru kolegija", 1, int.MaxValue);
            Izbornik.ObradaSmjer.PrikaziSmjerove();
            k.Smjer = Izbornik.ObradaSmjer.Smjerovi[Pomocno.UcitajRasponBroja("Unesite redni broj smjera", 1, Izbornik.ObradaSmjer.Smjerovi.Count) - 1];
            k.Naziv = Pomocno.UcitajString("Unesite naziv kolegija", 50, true);
            k.Predavac = Pomocno.UcitajString("Unesite ime predavača", 50, true);
            k.Obavezni = Pomocno.UcitajBool("Je li kolegij obavezan? (DA / NE)", "da");
            Kolegiji.Add(k);
        }

        private void PregledKolegija()
        {
            var k = Kolegiji[Pomocno.UcitajRasponBroja("Odaberite redni broj kolegija za pregled", 1, Kolegiji.Count) - 1];
            Console.WriteLine("naziv: " + k.Naziv + ", smjer: " + k.Smjer.Naziv + ", predavač: " + (k.Predavac == null ? "nepoznat" : k.Predavac) + ", obavezni: " + ((bool)k.Obavezni ? "da" : "ne"));
        }

        private void PrikaziKolegije()
        {
            var rbk = 1;
            foreach (var k in Kolegiji)
            {
                Console.WriteLine(rbk++ + ". " + k.Naziv);
            }
        }
    }
}
