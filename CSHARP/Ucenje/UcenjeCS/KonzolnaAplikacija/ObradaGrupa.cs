using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcenjeCS.KonzolnaAplikacija.model;

namespace UcenjeCS.KonzolnaAplikacija
{
    internal class ObradaGrupa
    {

        public List<Grupa> Grupe { get; set; }
        public Izbornik Izbornik { get; set; }

        public ObradaGrupa(Izbornik izbornik)
        {
            this.Izbornik = izbornik;
            Grupe = new List<Grupa>();

            if (Pomocno.DEV)
            {
                UcitajTestnePodatke();
            }
        }

        private void UcitajTestnePodatke()
        {
            Grupe.Add(new() { Sifra = 1, Naziv = "WP4", Smjer = Izbornik.ObradaSmjer.Smjerovi[0] });
            Grupe.Add(new() { Sifra = 2, Naziv = "WP5", Smjer = Izbornik.ObradaSmjer.Smjerovi[0] });
        }

        public void PrikaziIzbornik()
        {
            Console.WriteLine("Izaberite opciju izbornika: ");
            Console.WriteLine("1. Pregled svih grupa");
            Console.WriteLine("2. Unos nove grupe");
            Console.WriteLine("3. Promjena podataka grupe");
            Console.WriteLine("4. Brisanje grupe");
            Console.WriteLine("5. Povratak na glavni izbornik");
            OdabirOpcijeIzbornika();
        }

        private void OdabirOpcijeIzbornika()
        {
            switch(Pomocno.UcitajRasponBroja("Izaberite stavku izbornika", 1, 5))
            {
                case 1:
                    PrikaziSveGrupe();
                    PrikaziIzbornik();
                    break;
                case 2:
                    UnosNoveGrupe();
                    PrikaziIzbornik();
                    break;
                case 3: 
                    PromjenaPodatakaGrupe();
                    PrikaziIzbornik();
                    break;
                case 4:
                    ObrisiGrupu();
                    PrikaziIzbornik();
                    break;
                case 5:
                    Console.Clear();
                    break;
            }
        }

        private void ObrisiGrupu()
        {
            PrikaziSveGrupe();

            var g = Grupe[Pomocno.UcitajRasponBroja("Unesite redni broj grupe a brisanje", 1, Grupe.Count) - 1];
            if (Pomocno.UcitajBool("Sigurno želite obrisati " + g.Naziv + "? (DA / NE)", "da"))
            {
                Grupe.Remove(g);
            }
        }

        private void PromjenaPodatakaGrupe()
        {
            PrikaziSveGrupe();

            var g = Grupe[Pomocno.UcitajRasponBroja("Unesite redni broj grupe za promjenu", 1, Grupe.Count) - 1];
            g.Sifra = Pomocno.UcitajRasponBroja("Unesite novu šifru grupe", 1, int.MaxValue);
            g.Naziv = Pomocno.UcitajString(g.Naziv, "Unesite novi naziv grupe", 50, true);
            Izbornik.ObradaSmjer.PrikaziSveSmjerove();
            g.Smjer = Izbornik.ObradaSmjer.Smjerovi[Pomocno.UcitajRasponBroja("Unesite redni broj grupe", 1, Izbornik.ObradaSmjer.Smjerovi.Count) - 1];
            g.Predavac = Pomocno.UcitajString(g.Predavac, "Unesite novog predavača", 50, true);
            g.BrojPolaznika = Pomocno.UcitajRasponBroja("Unesite maksimalni broj polaznika", 5, 40);
            g.Polaznici = UcitajPolaznike(g.BrojPolaznika);
        }

        private void UnosNoveGrupe()
        {
            Grupa g = new Grupa();
            g.Sifra = Pomocno.UcitajRasponBroja("Unesite šifru grupe", 1, int.MaxValue);
            g.Naziv = Pomocno.UcitajString("Unesite naziv grupe", 50, true);
            Izbornik.ObradaSmjer.PrikaziSveSmjerove();
            g.Smjer = Izbornik.ObradaSmjer.Smjerovi[Pomocno.UcitajRasponBroja("Unesite redni broj smjera", 1, Izbornik.ObradaSmjer.Smjerovi.Count) - 1];
            g.Predavac = Pomocno.UcitajString("Unesite ime i prezime predavača", 50, true);
            g.BrojPolaznika = Pomocno.UcitajRasponBroja("Unesite maksimalan broj polaznika", 5, 40);
            g.Polaznici = UcitajPolaznike(g.BrojPolaznika);

            Grupe.Add(g);
        }

        private List<Polaznik> UcitajPolaznike(int brojPolaznika)
        {
            List<Polaznik> lista = new List<Polaznik>();
            while (lista.Count < brojPolaznika && Pomocno.UcitajBool("Unos novog polaznika? (DA / NE)", "da"))
            {
                Izbornik.ObradaPolaznik.PrikazSvihPolaznika();
                Console.WriteLine((Izbornik.ObradaPolaznik.Polaznici.Count + 1) + ". Dodaj novog polaznika");
                var opcija = Pomocno.UcitajRasponBroja("Izaberite redni broj polaznika za unos ili zadnji broj za dodavanje novog", 1, Izbornik.ObradaPolaznik.Polaznici.Count + 1);
                if (opcija == Izbornik.ObradaPolaznik.Polaznici.Count + 1)
                {
                    Izbornik.ObradaPolaznik.DodajNovogPolaznika();
                    lista.Add(Izbornik.ObradaPolaznik.Polaznici.LastOrDefault());
                }
                else
                {
                    lista.Add(Izbornik.ObradaPolaznik.Polaznici[opcija]);
                }
            }
            return lista;
        }

        private void PrikaziSveGrupe()
        {
            if (Grupe.Count == 0)
            {
                Console.WriteLine("Nema grupa u bazi");
            }
            var rb = 1;
            var rbp = 1;
            foreach (var g in Grupe)
            {
                Console.WriteLine(rb++ + ". " + g.Naziv + ", smjer: " + g.Smjer.Naziv + ", " + g.Polaznici.Count + " polaznika");
                foreach (var p in g.Polaznici)
                {
                    Console.WriteLine(rbp++ + ". " + p);
                }
            }
        }
    }
}
