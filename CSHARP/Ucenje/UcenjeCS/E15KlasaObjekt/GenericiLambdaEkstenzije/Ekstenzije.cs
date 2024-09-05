using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E15KlasaObjekt.GenericiLambdaEkstenzije
{
    internal static class Ekstenzije
    {

        public static void OdradiPosao(this Entitet e)
        {
            Console.WriteLine(e.Sifra);
        }

        public static void PrikazRadaSaSuceljem(this ISucelje sucelje)
        {
            sucelje.Posao();
        }
    }
}
