using GraRpgMateusz.KlasyBroni.Lucznik;
using System;
using System.Collections.Generic;
using System.Text;

namespace GraRpgMateusz.KlasyBroni.Wlucznik
{
    class BronWlucznika : BronLucznika
    {
        public BronWlucznika(string nazwa, int atak, int obrona, int krwawienie, int przebiciePancerza) :
            base(nazwa, atak, obrona, krwawienie, przebiciePancerza)
        { }
    }
}
