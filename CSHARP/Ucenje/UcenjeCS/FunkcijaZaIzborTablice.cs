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
            int mjesto;

            while (true)
            {
                Console.WriteLine("Unesite broj veći od nule: ");

                try
                {
                    broj = int.Parse(Console.ReadLine());

                    if (broj < 0)
                    {
                        Console.WriteLine("Broj mora biti veći od nule");
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
                Console.WriteLine("Unesite mjesto početka/završetka tablice: \n 1 - dolje desno \n 2 - dolje lijevo \n 3 - gore lijevo \n 4 - gore desno");

                try
                {
                    mjesto = int.Parse(Console.ReadLine());

                    if (mjesto != 1 && mjesto != 2 && mjesto!= 3 && mjesto != 4)
                    {
                        Console.WriteLine("Niste unijeli 1, 2, 3 ili 4");
                        continue;
                    }
                    break;
                }
                catch 
                {
                    Console.WriteLine("Niste unijeli mjesto početka/završetka");
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

            if (broj % 2 == 1)
            {
                if (mjesto == 1)
                {
                    if (smjer == 1)
                    {
                        switch (odSredine)
                        {
                            case 1:
                                CTabliceNepar.NeparniDDACos(broj);
                                break;
                            case 2:
                                CTabliceNepar.NeparniDDC(broj);
                                break;
                        }
                    }
                    else if (smjer == 2)
                    {
                        switch (odSredine)
                        {
                            case 1:
                                CTabliceNepar.NeparniDDCos(broj);
                                break;
                            case 2:
                                CTabliceNepar.NeparniDDAC(broj);
                                break;
                        }
                    }
                }
                else if (mjesto == 2)
                {
                    if (smjer == 1)
                    {
                        switch (odSredine)
                        {
                            case 1:
                                CTabliceNepar.NeparniDLACos(broj);
                                break;
                            case 2:
                                CTabliceNepar.NeparniDLC(broj);
                                break;
                        }
                    }
                    else if (smjer == 2)
                    {
                        switch (odSredine)
                        {
                            case 1:
                                CTabliceNepar.NeparniDLCos(broj);
                                break;
                            case 2:
                                CTabliceNepar.NeparniDLAC(broj);
                                break;
                        }
                    }
                }
                else if (mjesto == 3)
                {
                    if (smjer == 1)
                    {
                        switch (odSredine)
                        {
                            case 1:
                                CTabliceNepar.NeparniGLACos(broj);
                                break;
                            case 2:
                                CTabliceNepar.NeparniGLC(broj);
                                break;
                        }
                    }
                    else if (smjer == 2)
                    {
                        switch (odSredine)
                        {
                            case 1:
                                CTabliceNepar.NeparniGLCos(broj);
                                break;
                            case 2:
                                CTabliceNepar.NeparniGLAC(broj);
                                break;
                        }
                    }
                }
                else if (mjesto == 4)
                {
                    if (smjer == 1)
                    {
                        switch (odSredine)
                        {
                            case 1:
                                CTabliceNepar.NeparniGDACos(broj);
                                break;
                            case 2:
                                CTabliceNepar.NeparniGDC(broj);
                                break;
                        }
                    }
                    else if (smjer == 2)
                    {
                        switch (odSredine)
                        {
                            case 1:
                                CTabliceNepar.NeparniGDCos(broj);
                                break;
                            case 2:
                                CTabliceNepar.NeparniGDAC(broj);
                                break;
                        }
                    }
                }
            }
            else if (broj % 2 == 0)
            {
                if (mjesto == 1)
                {
                    if (smjer == 1)
                    {
                        switch (odSredine)
                        {
                            case 1:
                                CTablicePar.ParniDDACos(broj);
                                break;
                            case 2:
                                CTablicePar.ParniDDC(broj);
                                break;
                        }
                    }
                    else if (smjer == 2)
                    {
                        switch (odSredine)
                        {
                            case 1:
                                CTablicePar.ParniDDCos(broj);
                                break;
                            case 2:
                                CTablicePar.ParniDDAC(broj);
                                break;
                        }
                    }
                }
                else if (mjesto == 2)
                {
                    if (smjer == 1)
                    {
                        switch (odSredine)
                        {
                            case 1:
                                CTablicePar.ParniDLACos(broj);
                                break;
                            case 2:
                                CTablicePar.ParniDLC(broj);
                                break;
                        }
                    }
                    else if (smjer == 2)
                    {
                        switch (odSredine)
                        {
                            case 1:
                                CTablicePar.ParniDLCos(broj);
                                break;
                            case 2:
                                CTablicePar.ParniDLAC(broj);
                                break;
                        }
                    }
                }
                else if (mjesto == 3)
                {
                    if (smjer == 1)
                    {
                        switch (odSredine)
                        {
                            case 1:
                                CTablicePar.ParniGLACos(broj);
                                break;
                            case 2:
                                CTablicePar.ParniGLC(broj);
                                break;
                        }
                    }
                    else if (smjer == 2)
                    {
                        switch (odSredine)
                        {
                            case 1:
                                CTablicePar.ParniGLCos(broj);
                                break;
                            case 2:
                                CTablicePar.ParniGLAC(broj);
                                break;
                        }
                    }
                }
                else if (mjesto == 4)
                {
                    if (smjer == 1)
                    {
                        switch (odSredine)
                        {
                            case 1:
                                CTablicePar.ParniGDACos(broj);
                                break;
                            case 2:
                                CTablicePar.ParniGDC(broj);
                                break;
                        }
                    }
                    else if (smjer == 2)
                    {
                        switch (odSredine)
                        {
                            case 1:
                                CTablicePar.ParniGDCos(broj);
                                break;
                            case 2:
                                CTablicePar.ParniGDAC(broj);
                                break;
                        }
                    }
                }
            }
        }

    }
}
