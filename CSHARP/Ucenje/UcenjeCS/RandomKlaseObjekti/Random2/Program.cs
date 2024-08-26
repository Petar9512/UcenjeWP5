using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.RandomKlaseObjekti.Random2
{
    internal class Program
    {

        public Program()
        {
            var d1 = new Djelatnik(1, "Hajdi", "Hajdić", "0984447773");
            var d2 = new Djelatnik(2, "Ivan", "Ivić", "0985558889");
            var d3 = new Djelatnik(3, "Goran", "Grkić", "0912225557");
            var d4 = new Djelatnik(4, "Ivan", "Ivičević", "0917777788");

            var k1 = new Korisnik(1, "Sonja", "Sonjić", "žena", "dugačka");
            var k2 = new Korisnik(2, "Marko", "Markić", "muškarac", "kratka");
            var k3 = new Korisnik(3, "Ivana", "Ivić", "žena", "valovita");
            var k4 = new Korisnik(4, "Petra", "Perić", "žena", "kovrčava");

            var u1 = new Usluga() { Sifra = 1, Naziv = "šišanje", Cijena = 7.50 };
            var u2 = new Usluga() { Sifra = 2, Naziv = "pranje kose i šišanje", Cijena = 8.50 };
            var u3 = new Usluga() { Sifra = 3, Naziv = "pranje kose, šišanje i feniranje", Cijena = 9.50 };

            var p1 = new Posjet(d1, k3, u3, new DateTime(2024, 5, 10, 11, 0, 0));
            var p2 = new Posjet(d4, k2, u1, new DateTime(2024, 5, 10, 11, 33, 0));
            var p3 = new Posjet(d4, k1, u1, new DateTime(2024, 5, 20, 10, 48, 0));
            var p4 = new Posjet(d1, k3, u3, new DateTime(2024, 7, 16, 9, 55, 0));

            var posjeti = new Posjet[4];
            posjeti[0] = p1;
            posjeti[1] = p2;
            posjeti[2] = p3;
            posjeti[3] = p4;

            foreach (var p in posjeti)
            {
                Console.WriteLine(p);
            }


            var z1 = new Zaposlenik(1, "Pero", "Perić", "0915555558", "peroperic@gmail.com");
            var z2 = new Zaposlenik(2, "Ivan", "Ivičević", "0975553334", "ivanivicevic@gmail.com");
            var z3 = new Zaposlenik(3, "Goran", "Grgić", "0987775559", "gorangrgic@gmail.com");
            var z4 = new Zaposlenik(4, "Hajdi", "Hajdić", "0984447778", "hajdihajdic@gmail.com");

            var pr1 = new Prostor(1, "kavez", "1", "2", "0.5");
            var pr2 = new Prostor(2, "krletka", "0.4", "0.4", "0.4");
            var pr3 = new Prostor(3, "terarij", "0.7", "2.5", "2.5");
            var pr4 = new Prostor(4, "akvarij", "0.5", "1", "0.6");

            var st1 = new Sticenik(1, z1, pr4, "Nemo", "riba", "riblji kroketi");
            var st2 = new Sticenik(2, z4, pr2, "Nevis", "papiga", "sjemenke");
            var st3 = new Sticenik(3, z3, pr1, "Alf", "majmun", "voće");

            var sticenici = new Sticenik[3];
            sticenici[0] = st1;
            sticenici[1] = st2;
            sticenici[2] = st3;

            foreach (var s in sticenici)
            {
                Console.WriteLine(s);
            }


            var ss1 = new StrucnaSprema(1, "Učiteljski fakultet");
            var ss2 = new StrucnaSprema(2, "Odgojno-obrazovni tečaj");

            var odg1 = new Odgajateljica(1, "Hajdi", "Hajdić", "0987775558", ss1);
            var odg2 = new Odgajateljica(2, "Sonja", "Sonjić", "0957778882", ss1);
            var odg3 = new Odgajateljica(3, "Ivana", "Ivić", "0954445553", ss2);

            var skup1 = new Skupina(1, odg3, "Odgojna skupina 1", 20);
            var skup2 = new Skupina(2, odg2, "Odgojna skupina 2", 15);
            var skup3 = new Skupina(3, odg1, "Odgojna skupina 3", 15);

            var dj1 = new Dijete(1, "Pero", "Perić", 7, "0985557778", skup3);
            var dj2 = new Dijete(2, "Ivan", "Ivić", 8, "0912224443", skup3);
            var dj3 = new Dijete(3, "Ivan", "Ivičević", 7, "0983334445", skup3);
            var dj4 = new Dijete(4, "Marko", "Markić", 8, "0985554446", skup3);

            var djeca = new Dijete[4];
            djeca[0] = dj1;
            djeca[1] = dj2;
            djeca[2] = dj3;
            djeca[3] = dj4;

            foreach (var d in djeca)
            {
                Console.WriteLine(d);
            }


            var sp1 = new Sponzor(1, "Microsoft", "www.microsoft.com");
            var sp2 = new Sponzor(2, "Facebook", "www.facebook.com");
            var sp3 = new Sponzor(3, "Amazon", "www.amazon.com");

            var iz1 = new Izlozba(1, "Renesansna izložba", 7, new DateTime(2024, 8, 1, 10, 0, 0), sp2);
            var iz2 = new Izlozba(2, "Srednjovjekovna izložba", 5, new DateTime(2024, 8, 8, 12, 0, 0), sp3);
            var iz3 = new Izlozba(3, "Futuristička izložba", 7, new DateTime(2024, 8, 15, 12, 0, 0), sp1);

            var kus1 = new Kustos(1, "Ivan", "Ivić", "0985557778", iz3);
            var kus2 = new Kustos(2, "Ivan", "Ivičević", "0915557774", iz3);
            var kus3 = new Kustos(3, "Hajdi", "Hajdić", "0987774445", iz1);

            var djelo1 = new Djelo(1, "Mona Lisa", "Leonardo da Vinci", "renesansa", iz1);
            var djelo2 = new Djelo(2, "Futurizam 2050", "Pero Perić", "futurizam", iz3);
            var djelo3 = new Djelo(3, "Srednji vijek 1000", "Goran Grkić", "gotika", iz2);

            Console.WriteLine(djelo1);
            Console.WriteLine(djelo2);


            var sv1 = new Svecenik() { Sifra = 1, Ime = "Ivan", Dob = 48 };
            var sv2 = new Svecenik() { Sifra = 2, Ime = "Petar", Dob = 38 };
            var sv3 = new Svecenik() { Sifra = 3, Ime = "Matej", Dob = 36, Nadredeni = sv1 };
            var sv4 = new Svecenik() { Sifra = 4, Ime = "Marko", Dob = 33, Nadredeni = sv1 };

            var po1 = new Posao(1, "Kuhanje svaki dan", new TimeOnly(8, 0, 0), new TimeOnly(12, 0, 0));
            var po2 = new Posao(2, "Čišćenje svaki dan", new TimeOnly(18, 0, 0), new TimeOnly(20, 0, 0));
            var po3 = new Posao(3, "Vrtlarenje pon-pet", new TimeOnly(14, 0, 0), new TimeOnly(16, 0, 0));

            var ras1 = new Raspored(sv2, po1, new DateTime(2024, 6, 1, 9, 30, 0));
            var ras2 = new Raspored(sv2, po2, new DateTime(2024, 6, 1, 19, 0, 0));
            var ras3 = new Raspored(sv1, po1, new DateTime(2024, 6, 2, 8, 30, 0));
            var ras4 = new Raspored(sv3, po3, new DateTime(2024, 6, 2, 14, 0, 0));
            var ras5 = new Raspored(sv4, po2, new DateTime(2024, 6, 2, 18, 0, 0));

            var raspored = new Raspored[5];
            raspored[0] = ras1;
            raspored[1] = ras2;
            raspored[2] = ras3;
            raspored[3] = ras4;
            raspored[4] = ras5;

            foreach (var r in raspored)
            {
                Console.WriteLine(r);
            }


            var vozac1 = new Vozac(1, "Pero", "Perić", "peroperic@gmail.com");
            var vozac2 = new Vozac(2, "Goran", "Grgić", "gorangrgic@gmail.com");
            var vozac3 = new Vozac(3, "Ivan", "Ivić", "ivanivic@gmail.com");
            var vozac4 = new Vozac(4, "Ivan", "Ivičević", "ivanivicevic@gmail.com");

            var vozilo1 = new Vozilo(1, "Vozilo 1", "AB777", vozac4);
            var vozilo2 = new Vozilo(2, "Vozilo 2", "SD888", vozac3);
            var vozilo3 = new Vozilo(3, "Vozilo 3", "AS555", vozac2);
            var vozilo4 = new Vozilo(4, "Vozilo 4", "FG222", vozac1);

            var put1 = new Putnik(1, "Hajdi", "Hajdić", 3.99);
            var put2 = new Putnik(2, "Marko", "Markić", 4.99);
            var put3 = new Putnik(3, "Ivana", "Ivić", 4.99);
            var put4 = new Putnik(4, "Petra", "Perić", 4.49);

            var voznja1 = new Voznja(1, vozilo2, 2, new DateTime(2024, 6, 3, 10, 23, 0), new DateTime(2024, 6, 3, 10, 50, 0));
            var voznja2 = new Voznja(2, vozilo3, 1, new DateTime(2024, 6, 4, 13, 5, 0), new DateTime(2024, 6, 4, 13, 20, 0));
            var voznja3 = new Voznja(3, vozilo1, 1, new DateTime(2024, 6, 4, 17, 17, 0), new DateTime(2024, 6, 4, 17, 37, 0));

            var voznje = new Voznja[3];
            voznje[0] = voznja1;
            voznje[1] = voznja2;
            voznje[2] = voznja3;

            foreach (var v in voznje)
            {
                Console.WriteLine(v);
            }
        }

    }
}
