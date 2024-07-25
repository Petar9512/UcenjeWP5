using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class LjubavniKalkulator
    {

        public static void Kalkulator(string ime1, string ime2)
        {
            string ime = ime1 + ime2;
            int[] brojeviSlova = new int[ime.Length];
            int k = 0;


            for (int i = 0; i < ime.Length; i++)
            {
                for (int j = 0; j < ime.Length; j++)
                {
                    if (ime[i] == ime[j])
                    {
                        k++;
                    }
                        brojeviSlova[i] = k;
                                        
                }
                k = 0;
            }

            for (int i = 0; i < brojeviSlova.Length; i++)
            {
                Console.WriteLine(brojeviSlova[i]);
            }
        }

    }
}
