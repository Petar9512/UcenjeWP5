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
            int brojR;
            int brojS;
            int smjer;
            int odSredine;
            int mjesto;

            while (true)
            {
                Console.WriteLine("Unesite broj redaka: ");

                try
                {
                    brojR = int.Parse(Console.ReadLine());

                    if (brojR < 0)
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
                Console.WriteLine("Unesite broj stupaca: ");

                try
                {
                    brojS = int.Parse(Console.ReadLine());

                    if (brojS < 0)
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

            if (brojR == brojS && brojR % 2 == 1)
            {
                if (mjesto == 1)
                {
                    if (smjer == 1)
                    {
                        switch (odSredine)
                        {
                            case 1:
                                CTabliceNepar.NeparniDDACos(brojR);
                                break;
                            case 2:
                                CTabliceNepar.NeparniDDC(brojR);
                                break;
                        }
                    }
                    else if (smjer == 2)
                    {
                        switch (odSredine)
                        {
                            case 1:
                                CTabliceNepar.NeparniDDCos(brojR);
                                break;
                            case 2:
                                CTabliceNepar.NeparniDDAC(brojR);
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
                                CTabliceNepar.NeparniDLACos(brojR);
                                break;
                            case 2:
                                CTabliceNepar.NeparniDLC(brojR);
                                break;
                        }
                    }
                    else if (smjer == 2)
                    {
                        switch (odSredine)
                        {
                            case 1:
                                CTabliceNepar.NeparniDLCos(brojR);
                                break;
                            case 2:
                                CTabliceNepar.NeparniDLAC(brojR);
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
                                CTabliceNepar.NeparniGLACos(brojR);
                                break;
                            case 2:
                                CTabliceNepar.NeparniGLC(brojR);
                                break;
                        }
                    }
                    else if (smjer == 2)
                    {
                        switch (odSredine)
                        {
                            case 1:
                                CTabliceNepar.NeparniGLCos(brojR);
                                break;
                            case 2:
                                CTabliceNepar.NeparniGLAC(brojR);
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
                                CTabliceNepar.NeparniGDACos(brojR);
                                break;
                            case 2:
                                CTabliceNepar.NeparniGDC(brojR);
                                break;
                        }
                    }
                    else if (smjer == 2)
                    {
                        switch (odSredine)
                        {
                            case 1:
                                CTabliceNepar.NeparniGDCos(brojR);
                                break;
                            case 2:
                                CTabliceNepar.NeparniGDAC(brojR);
                                break;
                        }
                    }
                }
            }
            else if (brojR == brojS && brojR % 2 == 0)
            {
                if (mjesto == 1)
                {
                    if (smjer == 1)
                    {
                        switch (odSredine)
                        {
                            case 1:
                                CTablicePar.ParniDDACos(brojR);
                                break;
                            case 2:
                                CTablicePar.ParniDDC(brojR);
                                break;
                        }
                    }
                    else if (smjer == 2)
                    {
                        switch (odSredine)
                        {
                            case 1:
                                CTablicePar.ParniDDCos(brojR);
                                break;
                            case 2:
                                CTablicePar.ParniDDAC(brojR);
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
                                CTablicePar.ParniDLACos(brojR);
                                break;
                            case 2:
                                CTablicePar.ParniDLC(brojR);
                                break;
                        }
                    }
                    else if (smjer == 2)
                    {
                        switch (odSredine)
                        {
                            case 1:
                                CTablicePar.ParniDLCos(brojR);
                                break;
                            case 2:
                                CTablicePar.ParniDLAC(brojR);
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
                                CTablicePar.ParniGLACos(brojR);
                                break;
                            case 2:
                                CTablicePar.ParniGLC(brojR);
                                break;
                        }
                    }
                    else if (smjer == 2)
                    {
                        switch (odSredine)
                        {
                            case 1:
                                CTablicePar.ParniGLCos(brojR);
                                break;
                            case 2:
                                CTablicePar.ParniGLAC(brojR);
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
                                CTablicePar.ParniGDACos(brojR);
                                break;
                            case 2:
                                CTablicePar.ParniGDC(brojR);
                                break;
                        }
                    }
                    else if (smjer == 2)
                    {
                        switch (odSredine)
                        {
                            case 1:
                                CTablicePar.ParniGDCos(brojR);
                                break;
                            case 2:
                                CTablicePar.ParniGDAC(brojR);
                                break;
                        }
                    }
                }
            }

            else if ((brojR % 2 == 1 && brojS % 2 == 1) || (brojR % 2 == 1 && brojS % 2 == 0 && brojR < brojS) || (brojR % 2 == 0 && brojS % 2 == 1 && brojR > brojS))
            {
                if (mjesto == 1)
                {
                    if (smjer == 1)
                    {
                        switch (odSredine)
                        {
                            case 1:
                                CTabliceNeparniRaz.NeparniRazDDACos(brojR, brojS);
                                break;
                            case 2:
                                CTabliceNeparniRaz.NeparniRazDDC(brojR, brojS);
                                break;
                        }
                    }
                    else if (smjer == 2)
                    {
                        switch (odSredine)
                        {
                            case 1:
                                CTabliceNeparniRaz.NeparniRazDDCos(brojR, brojS);
                                break;
                            case 2:
                                CTabliceNeparniRaz.NeparniRazDDAC(brojR, brojS);
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
                                CTabliceNeparniRaz.NeparniRazDLACos(brojR, brojS);
                                break;
                            case 2:
                                CTabliceNeparniRaz.NeparniRazDLC(brojR, brojS);
                                break;
                        }
                    }
                    else if (smjer == 2)
                    {
                        switch (odSredine)
                        {
                            case 1:
                                CTabliceNeparniRaz.NeparniRazDLCos(brojR, brojS);
                                break;
                            case 2:
                                CTabliceNeparniRaz.NeparniRazDLAC(brojR, brojS);
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
                                CTabliceNeparniRaz.NeparniRazGLACos(brojR, brojS);
                                break;
                            case 2:
                                CTabliceNeparniRaz.NeparniRazGLC(brojR, brojS);
                                break;
                        }
                    }
                    else if (smjer == 2)
                    {
                        switch (odSredine)
                        {
                            case 1:
                                CTabliceNeparniRaz.NeparniRazGLCos(brojR, brojS);
                                break;
                            case 2:
                                CTabliceNeparniRaz.NeparniRazGLAC(brojR, brojS);
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
                                CTabliceNeparniRaz.NeparniRazGDACos(brojR, brojS);
                                break;
                            case 2:
                                CTabliceNeparniRaz.NeparniRazGDC(brojR, brojS);
                                break;
                        }
                    }
                    else if (smjer == 2)
                    {
                        switch (odSredine)
                        {
                            case 1:
                                CTabliceNeparniRaz.NeparniRazGDCos(brojR, brojS);
                                break;
                            case 2:
                                CTabliceNeparniRaz.NeparniRazGDAC(brojR, brojS);
                                break;
                        }
                    }
                }
            }

            else if ((brojR % 2 == 0 && brojS % 2 == 0) || (brojR % 2 == 0 && brojS % 2 == 1 && brojR < brojS) || (brojR % 2 == 1 && brojS % 2 == 0 && brojR > brojS))
            {
                if (mjesto == 1)
                {
                    if (smjer == 1)
                    {
                        switch (odSredine)
                        {
                            case 1:
                                CTabliceParniRaz.ParniRazDDACos(brojR, brojS);
                                break;
                            case 2:
                                CTabliceParniRaz.ParniRazDDC(brojR, brojS);
                                break;
                        }
                    }
                    else if (smjer == 2)
                    {
                        switch (odSredine)
                        {
                            case 1:
                                CTabliceParniRaz.ParniRazDDCos(brojR, brojS);
                                break;
                            case 2:
                                CTabliceParniRaz.ParniRazDDAC(brojR, brojS);
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
                                CTabliceParniRaz.ParniRazDLACos(brojR, brojS);
                                break;
                            case 2:
                                CTabliceParniRaz.ParniRazDLC(brojR, brojS);
                                break;
                        }
                    }
                    else if (smjer == 2)
                    {
                        switch (odSredine)
                        {
                            case 1:
                                CTabliceParniRaz.ParniRazDLCos(brojR, brojS);
                                break;
                            case 2:
                                CTabliceParniRaz.ParniRazDLAC(brojR, brojS);
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
                                CTabliceParniRaz.ParniRazGLACos(brojR, brojS);
                                break;
                            case 2:
                                CTabliceParniRaz.ParniRazGLC(brojR, brojS);
                                break;
                        }
                    }
                    else if (smjer == 2)
                    {
                        switch (odSredine)
                        {
                            case 1:
                                CTabliceParniRaz.ParniRazGLCos(brojR, brojS);
                                break;
                            case 2:
                                CTabliceParniRaz.ParniRazGLAC(brojR, brojS);
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
                                CTabliceParniRaz.ParniRazGDACos(brojR, brojS);
                                break;
                            case 2:
                                CTabliceParniRaz.ParniRazGDC(brojR, brojS);
                                break;
                        }
                    }
                    else if (smjer == 2)
                    {
                        switch (odSredine)
                        {
                            case 1:
                                CTabliceParniRaz.ParniRazGDCos(brojR, brojS);
                                break;
                            case 2:
                                CTabliceParniRaz.ParniRazGDAC(brojR, brojS);
                                break;
                        }
                    }
                }
            }
        }



    }
}
