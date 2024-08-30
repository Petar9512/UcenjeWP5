using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.RandomKlaseObjekti.Random5
{
    internal class Program
    {

        public Program()
        {
            var k1 = new Kvar(1, "kvar tip 1", "probušena cijev", "klasična vodovodna cijev");
            var k2 = new Kvar(2, "kvar tip 2", "pokvaren ventil", "ventil");
            var k3 = new Kvar(3, "kvar tip 2", "pokvaren brojač", "vodovodni brojač");

            var p1 = new Popravak(1, new DateTime(2024, 6, 2, 10, 0, 0), 2);
            var p2 = new Popravak(2, new DateTime(2024, 6, 4, 11, 0, 0), 1);

            var pk1 = new PopravakKvara(p1, k2, "popravio ventil", 7.99, false);
            var pk2 = new PopravakKvara(p1, k3, "popravio brojač", 6.99, false);
            var pk3 = new PopravakKvara(p2, k1, "popravio cijev", 5.99, true);

            var popravci = new PopravakKvara[3];
            popravci[0] = pk1;
            popravci[1] = pk2;
            popravci[2] = pk3;

            foreach (var p in popravci)
            {
                Console.WriteLine(p);
            }

            var kl1 = new Klijent(1, "Goran", "Grkić", "0987774445");
            var kl2 = new Klijent(2, "Hajdi", "Hajdić", "0912225553");
            var kl3 = new Klijent(3, "Ivan", "Ivić", "0985554447");

            var s1 = new Suradnik(1, "Sonja", "Sonjić", "0912225553");
            var s2 = new Suradnik(2, "Ivan", "Ivičević", "0987773334");
            var s3 = new Suradnik(3, "Marko", "Markić", "0914445553");

            var o1 = new Obrana(1, kl1, "Prometni prekršaj 1", "Županijski sud Dubrovnik");
            var o2 = new Obrana(2, kl1, "Prometni prekršaj 2", "Županijski sud Dubrovnik");
            var o3 = new Obrana(3, kl3, "Vožnja u alkoholiziranom stanju", "Županijski sud Split");
            var o4 = new Obrana(4, kl2, "Porezni postupak", "Županijski sud Split");

            var obrane = new Obrana[4];
            obrane[0] = o1;
            obrane[1] = o2;
            obrane[2] = o3;
            obrane[3] = o4;

            foreach (var o in obrane)
            {
                Console.WriteLine(o);
            }


            var m1 = new Mjesto(1, "Dubrovnik", "20000", "Hrvatska");
            var m2 = new Mjesto(2, "Zagreb", "10000", "Hrvatska");
            var m3 = new Mjesto(3, "Zadar", "23000", "Hrvatska");

            var n1 = new Nakladnik(1, m2, "Nakladnik Zagreb", "Ilica 36", "0985556667");
            var n2 = new Nakladnik(2, m3, "Nakladnik Zadar", "Savarska 47", "0987774443");
            var n3 = new Nakladnik(3, m1, "Nakladnik Dubrovnik", "Iva Vojnovića 20", "0912225554");

            var d1 = new Djelo(1, "Priče iz davnine", "I. Brlić Mažuranić", "bajke");
            var d2 = new Djelo(2, "20000 milja pod morem", "Jules Verne", "roman");
            var d3 = new Djelo(3, "Povratak Filipa Latinovicza", "M. Krleža", "roman");

            var i1 = new Izdanje(n1, d1, "2002");
            var i2 = new Izdanje(n1, d3, "1998");
            var i3 = new Izdanje(n2, d1, "2000");
            var i4 = new Izdanje(n3, d2, "1990");
            var i5 = new Izdanje(n3, d3, "1999");

            var izdanja = new Izdanje[5];
            izdanja[0] = i1;
            izdanja[1] = i2;
            izdanja[2] = i3;
            izdanja[3] = i4;
            izdanja[4] = i5;

            foreach (var i in izdanja)
            {
                Console.WriteLine(i);
            }


            var m4 = new Mjesto(4, "Split", "21000", "Hrvatska");
            var m5 = new Mjesto(5, "Šibenik", "22000", "Hrvatska");
            var m6 = new Mjesto(6, "Pula", "52100", "Hrvatska");

            var c1 = new Clan(1, "Hajdi", "Hajdić", "01978897564");
            var c2 = new Clan(2, "Ivan", "Ivičević", "88769656136");
            var c3 = new Clan(3, "Marko", "Markić", "54789182937");
            var c4 = new Clan(4, "Sonja", "Sonjić", "29718459234");
            var c5 = new Clan(5, "Goran", "Grgić", "48557623889");

            var na1 = new Nastup(1, m6, "Nastup plesne skupine", new DateTime(2024, 6, 10, 18, 0, 0));
            var na2 = new Nastup(2, m5, "Nastup plesne skupine 2", new DateTime(2024, 6, 12, 18, 0, 0));
            var na3 = new Nastup(3, m4, "Nastup plesne skupine 3", new DateTime(2024, 6, 14, 18, 0, 0));    

            var nastupi = new Nastup[3];
            nastupi[0] = na1;
            nastupi[1] = na2;
            nastupi[2] = na3;

            foreach (var n in nastupi)
            {
                Console.WriteLine(n);
            }
        }
    }
}
