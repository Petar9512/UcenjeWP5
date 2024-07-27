using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.LjubavniKalkulator
{
    internal class LKalkFunkcijaPrviZadnji
    {

        public static void Kalkulator(string brojSlova)
        {


            int duljinaBrojaSlova = brojSlova.Length;     


            while (duljinaBrojaSlova > 2)              
            {
                Console.WriteLine(brojSlova);             


                for (int i = 0; i < duljinaBrojaSlova / 2; i++)
                {
                    int b = int.Parse(brojSlova[i].ToString()) + int.Parse(brojSlova[duljinaBrojaSlova - 1 - i].ToString());
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
                      
                duljinaBrojaSlova = brojSlova.Length;                     

            }

            Console.WriteLine(brojSlova);                                 
            Console.WriteLine("Šansa: {0}%", brojSlova);


        }

    }
}
