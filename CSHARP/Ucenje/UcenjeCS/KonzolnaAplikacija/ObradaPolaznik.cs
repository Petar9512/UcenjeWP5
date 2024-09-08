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
    }

}
