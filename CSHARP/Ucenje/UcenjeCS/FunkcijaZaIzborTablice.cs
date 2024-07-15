using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class FunkcijaZaIzborTablice
    {

        public static void IzborTablice()
        {
            int broj;
            int smjer;
            int odSredine;
            int mjestoPocetka;

            while (true)
            {
                Console.WriteLine("Unesite neparni broj veći od nule: ");

                try
                {
                    broj = int.Parse(Console.ReadLine());

                    if (broj < 0)
                    {
                        Console.WriteLine("Broj mora biti veći od nule");
                        continue;
                    }

                    if (broj % 2 == 0)
                    {
                        Console.WriteLine("Broj mora biti neparan");
                        continue;
                    }
                    break;
                }
                catch
                {
                    Console.WriteLine("Niste unijeli broj");
                }
            }


            while (true)
            {
                Console.WriteLine("Unesite mjesto početka tablice: \n 1 - dolje desno \n 2 - dolje lijevo \n 3 - gore lijevo \n 4 - gore desno");

                try
                {
                    mjestoPocetka = int.Parse(Console.ReadLine());

                    if (mjestoPocetka != 1 && mjestoPocetka != 2 && mjestoPocetka != 3 && mjestoPocetka != 4)
                    {
                        Console.WriteLine("Niste unijeli 1, 2, 3 ili 4 za mjesto početka");
                        continue;
                    }
                    break;
                }
                catch 
                {
                    Console.WriteLine("Niste unijeli mjesto početka");
                }
            }


            while (true)
            {
                Console.WriteLine("Unesite smjer tablice: \n 1 - smjer kazaljke na satu \n 2 - suprotno od kazaljke");

                try
                {
                    smjer = int.Parse(Console.ReadLine());

                    if (smjer != 1 && smjer != 2)
                    {
                        Console.WriteLine("Niste unijeli 1 ili 2 za smjer tablice");
                        continue;
                    }
                    break;
                }
                catch
                {
                    Console.WriteLine("Niste unijeli smjer");
                }
            }

            while (true)
            {
                Console.WriteLine("Želite li da tablica krene od sredine? \n 1 - DA \n 2 - NE");

                try
                {
                    odSredine = int.Parse(Console.ReadLine());

                    if (odSredine != 1 && odSredine != 2)
                    {
                        Console.WriteLine("Niste unijeli 1 ili 2");
                        continue;
                    }
                    break;
                }
                catch
                {
                    Console.WriteLine("Niste unijeli 1 ili 2");
                }
            }

           if (mjestoPocetka == 1)
            {
                if (smjer == 1)
                {
                    switch (odSredine)
                    {
                        case 1:
                            CTablicaNeparDD.NeparniDDCos(broj);
                            break;
                        case 2:
                            CTablicaNeparDD.NeparniDDC(broj);
                            break;
                    }
                }
                else if (smjer == 2)
                {
                    switch (odSredine) 
                    {
                        case 1:
                            CTablicaNeparDD.NeparniDDACos(broj);
                            break;
                        case 2:
                            CTablicaNeparDD.NeparniDDAC(broj);
                            break;
                    }
                }
            }
           else if (mjestoPocetka == 2)
            {
                if (smjer == 1)
                {
                    switch (odSredine)
                    {
                        case 1:
                            CTablicaNeparDL.NeparniDLCos(broj);
                            break;
                        case 2:
                            CTablicaNeparDL.NeparniDLC(broj);
                            break;
                    }
                }
                else if (smjer == 2)
                {
                    switch (odSredine)
                    {
                        case 1:
                            CTablicaNeparDL.NeparniDLACos(broj);
                            break;
                        case 2:
                            CTablicaNeparDL.NeparniDLAC(broj);
                            break;
                    }
                }
            }
            else if (mjestoPocetka == 3)
            {
                if (smjer == 1)
                {
                    switch (odSredine)
                    {
                        case 1:
                            CTablicaNeparGL.NeparniGLCos(broj);
                            break;
                        case 2:
                            CTablicaNeparGL.NeparniGLC(broj);
                            break;
                    }
                }
                else if (smjer == 2)
                {
                    switch (odSredine)
                    {
                        case 1:
                            CTablicaNeparGL.NeparniGLACos(broj);
                            break;
                        case 2:
                            CTablicaNeparGL.NeparniGLAC(broj);
                            break;
                    }
                }
            }
            else if (mjestoPocetka == 4)
            {
                if (smjer == 1)
                {
                    switch (odSredine)
                    {
                        case 1:
                            CTablicaNeparGD.NeparniGDCos(broj);
                            break;
                        case 2:
                            CTablicaNeparGD.NeparniGDC(broj);
                            break;
                    }
                }
                else if (smjer == 2)
                {
                    switch (odSredine)
                    {
                        case 1:
                            CTablicaNeparGD.NeparniGDACos(broj);
                            break;
                        case 2:
                            CTablicaNeparGD.NeparniGDAC(broj);
                            break;
                    }
                }
            }
            
        }

    }
}
