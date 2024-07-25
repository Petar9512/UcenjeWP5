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
            string brojSlova = "";
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
                }
                brojeviSlova[i] = k;
                brojSlova += k;
                k = 0;
            }

            int duljinaBrojaSlova = brojSlova.Length;

                        

            for (int i = 0; i < duljinaBrojaSlova / 2; i++)
            {
                int b = brojeviSlova[i] + brojeviSlova[duljinaBrojaSlova - 1 - i];
                brojSlova += b;
            }

            if (duljinaBrojaSlova % 2 == 1)
            {
                char ostatak = brojSlova[duljinaBrojaSlova / 2];
                brojSlova = brojSlova.Substring(duljinaBrojaSlova);
                brojSlova += ostatak;
            }

            else if (duljinaBrojaSlova % 2 == 0)
            {
                brojSlova = brojSlova.Substring(duljinaBrojaSlova);
            }
            
            Console.WriteLine(brojSlova);

        }

    }
}
