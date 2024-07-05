using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E07WhileDoWhileForeachPetlje
    {

        public static void Izvedi()
        {

            while (true)
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.Write(new Random().Next() + " ");
                }
                Console.WriteLine();
                Thread.Sleep(100);
                break;
            }


            int brojDo = 10;
            while (brojDo-- > 0)
            {
                Console.WriteLine(brojDo);
            }


            brojDo = 0;
            while (brojDo < 10)
            {
                if (++brojDo == 2)
                {
                    continue;
                }
                Console.WriteLine(brojDo);
            }


            brojDo = 1;

            while (brojDo <= 10)
            {
               int j = 1;
               while (j <= 10)
                {
                    Console.Write(brojDo * j++ + "\t");
                }
                Console.WriteLine();
                brojDo++;
            }


            int k = 0;
            do
            {
                Console.WriteLine(k++);
            }
            while (k < 10);


            string grad = "Osijek";

            for (int i = 0; i < grad.Length; i++)
            {
                Console.WriteLine(grad[i]);
            }


            foreach (char znak in grad)
            {
                Console.WriteLine(znak);
            }


            float[] brojevi = { 2, 4, 5.6f, 3, 8, 6, 3.7f };
            float suma = 0;
            foreach (var e in brojevi)
            {
                Console.WriteLine(e);
                suma += e;
            }
            Console.WriteLine(suma);
        }

    }
}
