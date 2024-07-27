using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class LKalkFunkcijaDvaSusjedna
    {

        public static void Kalkulator2(int[] brojeviSlova, string brojSlova)
        {

            
            int duljinaBrojaSlova = brojSlova.Length;    



            while (duljinaBrojaSlova > 2)                
            {
                Console.WriteLine(brojSlova);             


                for (int i = 0; i < duljinaBrojaSlova - 1; i+=2)         // isto kao i druga funkcija, osim što zbraja dva susjedna broja
                {
                    int b = brojeviSlova[i] + brojeviSlova[i + 1];
                    brojSlova += b;                                       
                }                                                       

                if (duljinaBrojaSlova % 2 == 1)
                {
                    char ostatak = brojSlova[duljinaBrojaSlova - 1];     // ostatak će u tom slučaju biti zadnji broj
                    brojSlova = brojSlova.Substring(duljinaBrojaSlova); 
                    brojSlova += ostatak;                                 
                }

                else if (duljinaBrojaSlova % 2 == 0)
                {
                    brojSlova = brojSlova.Substring(duljinaBrojaSlova);   
                }

                Array.Clear(brojeviSlova, 0, brojeviSlova.Length);        
                Array.Resize(ref brojeviSlova, brojSlova.Length);         

                duljinaBrojaSlova = brojSlova.Length;                     

                for (int i = 0; i < duljinaBrojaSlova; i++)               
                {
                    brojeviSlova[i] = int.Parse(brojSlova[i].ToString()); 
                }
            }

            Console.WriteLine(brojSlova);                                
            Console.WriteLine("Šansa: {0}%", brojSlova);


        }

    }
}
