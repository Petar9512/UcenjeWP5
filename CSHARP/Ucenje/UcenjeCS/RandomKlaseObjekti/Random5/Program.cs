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
        }
    }
}
