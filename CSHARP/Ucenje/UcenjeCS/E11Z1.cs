using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E11Z1
    {

        public static void Izvedi()
        {
            Console.WriteLine(
                E11Metode.UcitajCijeliBroj("Unesite prvi broj: ",0,75) +
                E11Metode.UcitajCijeliBroj("Unesite drugi broj: ",50,100));
        }

    }
}
