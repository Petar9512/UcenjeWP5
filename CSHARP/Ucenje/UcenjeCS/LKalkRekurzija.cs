using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class LKalkRekurzija
    {


        public static string Zbrajanje(int[] x, string y)
        {
            int duljinaBrojaSlova = y.Length;

            if (duljinaBrojaSlova <= 2)
            {
                return y;
            }

            for (int i = 0; i < duljinaBrojaSlova / 2; i++)
            {
                int b = x[i] + x[duljinaBrojaSlova - 1 - i];
                y += b;                                       
            }

            if (duljinaBrojaSlova % 2 == 1)
            {
                char ostatak = y[duljinaBrojaSlova / 2];      
                y = y.Substring(duljinaBrojaSlova);   
                y += ostatak;                                 
            }

            else if (duljinaBrojaSlova % 2 == 0)
            {
                y = y.Substring(duljinaBrojaSlova);   
            }

            Array.Clear(x, 0, x.Length);        
            Array.Resize(ref x, y.Length);         

            duljinaBrojaSlova = y.Length;                     

            for (int i = 0; i < duljinaBrojaSlova; i++)               
            {
                x[i] = int.Parse(y[i].ToString()); 
            }

            return Zbrajanje(x, y);
        }

    }
}
