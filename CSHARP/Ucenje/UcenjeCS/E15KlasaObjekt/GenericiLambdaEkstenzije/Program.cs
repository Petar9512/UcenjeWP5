using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E15KlasaObjekt.GenericiLambdaEkstenzije
{
    internal class Program
    {

        public Program()
        {

            List<int> integeri = new List<int>();

            integeri.Add(1);
            integeri.Add(21);

            Console.WriteLine(integeri[0]);


            List<string> gradovi = new List<string>();

            gradovi.Add("Osijek");
            gradovi.Add("Valpovo");

            Console.WriteLine(gradovi[1]);


            List<Smjer> smjerovi = new List<Smjer>();

            smjerovi.Add(new Smjer() { Sifra = 11, Naziv = "WP" });
            smjerovi.Add(new() { Sifra = 7, Naziv = "RR" });
            smjerovi.Add(new() { Sifra = 9, Naziv = "AA" });

            Console.WriteLine(smjerovi[1].Sifra);


            Obrada<Smjer> o1 = new Obrada<Smjer>();
            o1.ObjektObrade = new Smjer() { Sifra = 1, Naziv = "WP" };

            Obrada<Polaznik> o2 = new Obrada<Polaznik>();
            o2.ObjektObrade = new() { Sifra = 2, Ime = "Pero", Prezime = "Perić" };

            o1.Obradi();
            o2.Obradi();


            List<DateTime> vremena = new List<DateTime>() {
                new DateTime(1980,12,7), DateTime.Now
            };


            var Zbroj = (int x, int y) => x + y;
            Console.WriteLine(Zbroj(2, 3));

            var Algoritam = (int x, int y) =>
            {
                var t = x + 1;
                return t - y;
            };
            Console.WriteLine(Algoritam(2, 3));

            var Parni = (int i) => i % 2 == 0;


            var s = "Osijek";
            Console.WriteLine(s.LastOrDefault());
            Console.WriteLine(gradovi.LastOrDefault());


            smjerovi[0].OdradiPosao();
            o2.ObjektObrade.OdradiPosao();

            o1.PrikazRadaSaSuceljem();
            smjerovi[0].PrikazRadaSaSuceljem();
            o2.ObjektObrade.PrikazRadaSaSuceljem();


            smjerovi.Sort();
            Console.WriteLine(smjerovi.FirstOrDefault()?.Sifra);

            smjerovi.Sort((s1, s2) => s1.Naziv.CompareTo(s2.Naziv));
            Console.WriteLine(smjerovi.FirstOrDefault()?.Naziv);


            o1.ListaZaObradu = smjerovi;
            o1.IspisStavaka(TuMeObradi);

            o1.IspisStavaka(s =>
            {
                Console.WriteLine("I bez poziva metode " + s.Naziv);
            });

            static void TuMeObradi(Smjer s)
            {
                Console.WriteLine("Obrađujem u Programu smjer s pozivom metode " + s.Naziv);
            }
        }
    }
}
