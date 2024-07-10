using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E12Rekurzija
    {

        public static void Izvedi()
        {
            Console.WriteLine(Zbroji(120));
        }

        private static int Zbroji(int broj)
        {
            if (broj == 1)
            {
                return 1;
            }
            return broj + Zbroji(broj - 1);
        }
    }
}
