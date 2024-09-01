using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.RandomKlaseObjekti.Random6
{
    internal class Program
    {

        public Program()
        {
            var t1 = new Teta(1, "Sonja", "Sonjić", "0981112224", 42);
            var t2 = new Teta(2, "Ivana", "Ivić", "0983335556", 38);

            var d1 = new Dijete(1, "Ivana", "Ivičević", "0912224443", new DateOnly(2018, 9, 30));
            var d2 = new Dijete(2, "Goran", "Grkić", "0985557778", new DateOnly(2019, 3, 10));
            var d3 = new Dijete(3, "Pero", "Perić", "0912227775", new DateOnly(2018, 6, 22));
            var d4 = new Dijete(4, "Hajdi", "Hajdić", "0914447776", new DateOnly(2019, 4, 12));
            var d5 = new Dijete(5, "Marko", "Markić", "0987772223", new DateOnly(2019, 3, 27));

            var s1 = new Skupina(1, t1, "Skupina 1", 17);
            var s2 = new Skupina(2, t1, "Skupina 2", 16);
            var s3 = new Skupina(3, t2, "Skupina 3", 17);

            var c1 = new Clan(s1, d2, new DateOnly(2024, 4, 10));
            var c2 = new Clan(s1, d4, new DateOnly(2024, 4, 10));
            var c3 = new Clan(s1, d5, new DateOnly(2024, 4, 12));
            var c4 = new Clan(s2, d1, new DateOnly(2024, 4, 18));
            var c5 = new Clan(s2, d3, new DateOnly(2024, 4, 19));
            var c6 = new Clan(s2, d5, new DateOnly(2024, 4, 21));
            var c7 = new Clan(s3, d1, new DateOnly(2024, 5, 13));
            var c8 = new Clan(s3, d2, new DateOnly(2024, 5, 13));
            var c9 = new Clan(s3, d4, new DateOnly(2024, 5, 14));

            var clanovi = new Clan[9];
            clanovi[0] = c1;
            clanovi[1] = c2;
            clanovi[2] = c3;
            clanovi[3] = c4;
            clanovi[4] = c5;
            clanovi[5] = c6;
            clanovi[6] = c7;
            clanovi[7] = c8;
            clanovi[8] = c9;

            foreach (var clan in clanovi)
            {
                Console.WriteLine(clan);
            }


            var cit1 = new Citatelj(1, "Ivan", "Ivić", "0985557776", "75863348698");
            var cit2 = new Citatelj(2, "Hajdi", "Hajdić", "0912224443", "91345873345");
            var cit3 = new Citatelj(3, "Marko", "Markić", "markomarkic@gmail.com", "06787979453");
            var cit4 = new Citatelj(4, "Pero", "Perić", "0912227778", "24658498712");
            var cit5 = new Citatelj(5, "Ivana", "Ivić", "ivanaivic@gmail.com", "5735545879");

            var k1 = new Knjiga(1, "20000 milja pod morem", "Jules Verne", cit2);
            var k2 = new Knjiga(2, "Hobit", "J.R.R.Tolkien", cit3);
            var k3 = new Knjiga(3, "Eragon", "Christopher Paolini", cit5);

            var p1 = new Posudba(cit1, k2, new DateOnly(2024, 2, 3), new DateOnly(2024, 2, 17));
            var p2 = new Posudba(cit5, k2, new DateOnly(2024, 3, 12), new DateOnly(2024, 3, 30));
            var p3 = new Posudba(cit4, k1, new DateOnly(2024, 3, 1), new DateOnly(2024, 3, 22));
            var p4 = new Posudba(cit5, k3, new DateOnly(2024, 5, 30), new DateOnly(2024, 6, 14));

            var posudbe = new Posudba[4];
            posudbe[0] = p1;
            posudbe[1] = p2;
            posudbe[2] = p3;
            posudbe[3] = p4;

            foreach (var p in posudbe)
            {
                Console.WriteLine(p);
            }


            var z1 = new Zupan(1, "Nikola", "Dobroslavić");
            var z2 = new Zupan(2, "Blaženko", "Boban");
            var z3 = new Zupan(3, "Božidar", "Longin");

            var zup1 = new Zupanija(1, "Zadarska", z3);
            var zup2 = new Zupanija(2, "Splitsko-dalmatinska", z2);
            var zup3 = new Zupanija(3, "Dubrovačko-neretvanska", z1);

            var o1 = new Opcina(1, "Dubrovačko Primorje", zup3);
            var o2 = new Opcina(2, "Janjina", zup3);
            var o3 = new Opcina(3, "Baška Voda", zup2);
            var o4 = new Opcina(4, "Zmijavci", zup2);
            var o5 = new Opcina(5, "Bibinje", zup1);
            var o6 = new Opcina(6, "Gračac", zup1);

            var m1 = new Mjesto(1, "Cerovac", o6);
            var m2 = new Mjesto(2, "Dugopolje", o6);
            var m3 = new Mjesto(3, "Promajna", o3);
            var m4 = new Mjesto(4, "Bratuš", o3);
            var m5 = new Mjesto(5, "Krvavica", o3);
            var m6 = new Mjesto(6, "Bast", o3);
            var m7 = new Mjesto(7, "Drače", o2);
            var m8 = new Mjesto(8, "Osobjava", o2);
            var m9 = new Mjesto(9, "Popova Luka", o2);
            var m10 = new Mjesto(10, "Topolo", o1);
            var m11 = new Mjesto(11, "Imotica", o1);
            var m12 = new Mjesto(12, "Visočani", o1);

            var mjesta = new Mjesto[12];
            mjesta[0] = m1;
            mjesta[1] = m2;
            mjesta[2] = m3;
            mjesta[3] = m4;
            mjesta[4] = m5;
            mjesta[5] = m6;
            mjesta[6] = m7;
            mjesta[7] = m8;
            mjesta[8] = m9;
            mjesta[9] = m10;
            mjesta[10] = m11;
            mjesta[11] = m12;

            foreach (var m in mjesta)
            {
                Console.WriteLine(m);
            }


            var zap1 = new Zaposlenik(1, "Ivan", "Ivić", new DateOnly(1976, 5, 10), false);
            var zap2 = new Zaposlenik(2, "Goran", "Grkić", new DateOnly(1978, 6, 15), false);
            var zap3 = new Zaposlenik(3, "Hajdi", "Hajidć", new DateOnly(1988, 3, 5), false);

            var sl1 = new Slika(1, zap1, 1, "https://www.pexels.com/photo/two-deer-grazing-in-a-field-with-trees-in-the-background-21820922/");
            var sl2 = new Slika(2, zap1, 2, "https://www.pexels.com/photo/kiz-kulesi-in-istanbul-at-sunset-23731698/");
            var sl3 = new Slika(3, zap2, 3, "https://www.pexels.com/photo/a-mountain-with-trees-and-clouds-in-the-background-20875403/");
            var sl4 = new Slika(4, zap2, 4, "https://www.pexels.com/video/sunflower-in-rural-setting-at-sunset-in-summer-20712217/");
            var sl5 = new Slika(5, zap3, 5, "https://www.pexels.com/photo/diamond-cut-24778046/");
            var sl6 = new Slika(6, zap3, 6, "https://www.pexels.com/video/light-city-man-love-25559507/");

            var slike = new Slika[6];
            slike[0] = sl1;
            slike[1] = sl2;
            slike[2] = sl3;
            slike[3] = sl4;
            slike[4] = sl5;
            slike[5] = sl6;

            foreach (var s in slike)
            {
                Console.WriteLine(s);
            }
        }
    }
}
