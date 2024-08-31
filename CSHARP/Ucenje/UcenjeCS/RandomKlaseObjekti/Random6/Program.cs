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
        }

    }
}
