using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.KonzolnaAplikacija
{
    internal class Pomocno
    {

        public static bool DEV = false;

        public static string UcitajString(string poruka)
        {
            string s;
            while (true)
            {
                Console.WriteLine(poruka + ": ");
                s = Console.ReadLine().Trim();
                if (s.Length == 0)
                {
                    Console.WriteLine("Morate unijeti naziv");
                    continue;
                }
                return s;
            }
        }
    }
}
