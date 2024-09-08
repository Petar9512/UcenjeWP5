using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcenjeCS.E15KlasaObjekt.fakultet;

namespace UcenjeCS.KonzolnaAplikacija
{
    internal class ObradaSmjer
    {

        public List<model.Smjer> Smjerovi { get; set; }

        public ObradaSmjer()
        {
            Smjerovi = new List<model.Smjer>();
            if (Pomocno.DEV)
            {
                UcitajTestnePodatke();
            }
        }

        private void UcitajTestnePodatke()
        {
            Smjerovi.Add(new(1, "Web programiranje", "6 mjeseci", new DateOnly(2024, 5, 14), 1340.55, true));
            Smjerovi.Add(new(2, "Web dizajn", "5 mjeseci", new DateOnly(2024, 5, 12), 960.77, true));
            Smjerovi.Add(new(3, "Online marketing", "7 mjeseci", new DateOnly(2024, 4, 1), 1510, true));
            Smjerovi.Add(new(4, "Grafički dizajn", "6 mjeseci", new DateOnly(2024, 5, 14), 1040.33, true));
            Smjerovi.Add(new(5, "Odnosi s javnošću", "5 mjeseci", new DateOnly(2024, 6, 1), 960.55, true));
        }

        public void PrikaziIzbornik()
        {
            Console.WriteLine("Rad sa smjerovima");
            Console.WriteLine("1. Prikaži sve smjerove");
            Console.WriteLine("2. Dodaj novi smjer");
            Console.WriteLine("3. Promijeni podatke smjera");
            Console.WriteLine("4. Brisanje smjera");
            Console.WriteLine("5. Povratak na glavni izbornik");
            OdabirOpcijeIzbornika();
        }

        private void OdabirOpcijeIzbornika()
        {
            switch(E11Metode.UcitajCijeliBroj("Odaberite stavku izbornika", 1, 5))
            {
                case 1:
                    PrikaziSveSmjerove();
                    PrikaziIzbornik();
                    break;
                case 2:
                    DodajNoviSmjer();
                    PrikaziIzbornik();
                    break;
                case 3:
                    PromijeniSmjer();
                    PrikaziIzbornik();
                    break;
                case 4:
                    ObrisiSmjer();
                    PrikaziIzbornik();
                    break;
                case 5:
                    break;
            }
        }

        private void ObrisiSmjer()
        {
            PrikaziSveSmjerove();
            Smjerovi.RemoveAt(E11Metode.UcitajCijeliBroj("Odaberite redni broj smjera za brisanje", 1, int.MaxValue) - 1);
        }

        private void PromijeniSmjer()
        {
            PrikaziSveSmjerove();
            var s = Smjerovi[E11Metode.UcitajCijeliBroj("Odaberite redni broj smjera", 1, Smjerovi.Count) - 1];

            s.Sifra = E11Metode.UcitajCijeliBroj("Unesite novu vrijednost šifre (" + s.Sifra + ")", 1, int.MaxValue);
            s.Naziv = Pomocno.UcitajString("Unesite novu vrijednost naziva (" + s.Naziv + ")", 50, true);
        }

        private void DodajNoviSmjer()
        {
            Smjerovi.Add(new()
            {
                Sifra = E11Metode.UcitajCijeliBroj("Unesite šifru smjera", 1, int.MaxValue),
                Naziv = Pomocno.UcitajString("Unesite naziv smjera", 50, true)
            });
        }

        private void PrikaziSveSmjerove()
        {
            if (Smjerovi.Count == 0)
            {
                Console.WriteLine("Nema smjerova u bazi");
            }

            var rb = 1;
            foreach (var s in Smjerovi)
            {
                Console.WriteLine(rb++ + ". " + s.Naziv);
            }
        }
    }
}
