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
    }
}
