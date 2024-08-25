﻿using System;
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
        }

    }
}
