using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcenjeCS.E15KlasaObjekt.GenericiLambdaEkstenzije;

namespace UcenjeCS.KonzolnaAplikacija
{
    internal class ObradaPolaznik
    {

        public List<model.Polaznik> Polaznici { get; set; }

        public ObradaPolaznik()
        {
            Polaznici = new List<model.Polaznik>();
            if (Pomocno.DEV)
            {
                UcitajTestnePodatke();
            }
        }

        private void UcitajTestnePodatke()
        {
            Polaznici.Add(new(1, "Pero", "Perić", "peroperic@gmail.com", "95678334565"));
            Polaznici.Add(new(2, "Hajdi", "Hajdić", "hajdihajdic@gmail.com", "24454337681"));
            Polaznici.Add(new(3, "Goran", "Grgić", "gorangrkic@gmail.com", "64787685543"));
            Polaznici.Add(new(4, "Ivan", "Ivić", "ivanivic@gmail.com", "14653465482"));
            Polaznici.Add(new(5, "Ivan", "Ivičević", "ivanivicevic@gmail.com", "23547849613"));
        }

        public void PrikaziIzbornik()
        {
            Console.WriteLine("\nOdaberite opciju izbornika: ");
            Console.WriteLine("1. Pregled svih polaznika");
            Console.WriteLine("2. Unos novog polaznika");
            Console.WriteLine("3. Promjena podataka postojećeg polaznika");
            Console.WriteLine("4. Brisanje polaznika");
            Console.WriteLine("5. Povratak na glavni izbornika");
            OdabirOpcijeIzbornika();
        }

        private void OdabirOpcijeIzbornika()
        {
            switch(Pomocno.UcitajRasponBroja("Odaberite stavku izbornika: ", 1, 5))
            {
                case 1:
                    PrikazSvihPolaznika();
                    PrikaziIzbornik();
                    break;
                case 2:
                    DodajNovogPolaznika();
                    PrikaziIzbornik();
                    break;
                case 3:
                    PromijeniPodatkePolaznika();
                    PrikaziIzbornik();
                    break;
                case 4:
                    ObrisiPolaznika();
                    PrikaziIzbornik();
                    break;
                case 5:
                    break;
            }
        }

        private void ObrisiPolaznika()
        {
            PrikazSvihPolaznika();
            var p = Polaznici[Pomocno.UcitajRasponBroja("Unesite redni broj polaznika za brisanje", 1, Polaznici.Count) - 1];
            if (Pomocno.UcitajBool("Sigurno obrisati " + p.Ime + " " + p.Prezime + "? (DA / NE)", "da"))
            {
                Polaznici.Remove(p);
            }
        }

        private void PromijeniPodatkePolaznika()
        {
            PrikazSvihPolaznika();
            var p = Polaznici[Pomocno.UcitajRasponBroja("Unesite redni broj polaznika za promjenu", 1, Polaznici.Count) - 1];
            if (Pomocno.UcitajRasponBroja("1.Promijeni sve \n2. Pojedinačna promjena", 1, 2) == 1)
            {
                p.Promijeni(p);
            }

            else
            {
                p.PromijeniOdredeno(p);
            }
        }

        public void DodajNovogPolaznika()
        {
            Polaznici.Add(new()
            {
                Sifra = Pomocno.UcitajRasponBroja("Unesite šifru polaznika", 1, int.MaxValue),
                Ime = Pomocno.UcitajString("Unesite ime", 50, true),
                Prezime = Pomocno.UcitajString("Unesite prezime", 50, true),
                Email = Pomocno.UcitajString("Unesite email", 50, true),
                Oib = Pomocno.UcitajString("Unesite OIB", 11, true)
            });
        }

        public void PrikazSvihPolaznika()
        {
            if (Polaznici.Count == 0)
            {
                Console.WriteLine("Nema polaznika u bazi");
            }
            var rb = 1;
            foreach (var p in Polaznici)
            {
                Console.WriteLine(rb++ + ". " + p);
            }
        }
    }

}
