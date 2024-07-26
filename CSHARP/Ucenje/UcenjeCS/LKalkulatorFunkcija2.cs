using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class LKalkulatorFunkcija2
    {

        public static void Kalkulator2(string ime1, string ime2)
        {

            string ime = ime1 + ime2;                     
            string brojSlova = "";                       
            int[] brojeviSlova = new int[ime.Length];    
            int k = 0;

            char x = char.ToUpper(ime1[0]);               
            ime1 = x + ime1.Substring(1);
            char y = char.ToUpper(ime2[0]);
            ime2 = y + ime2.Substring(1);

            Console.WriteLine(ime1 + ime2);


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
