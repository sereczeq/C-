using System;
using System.Collections.Generic;
using System.Text;

namespace GraRpgMateusz.KlasyBroni.Lucznik
{
    class BronLucznika : Bron
    {
        public int PrzebiciePancerza;
        public BronLucznika(string nazwa, int atak, int obrona, int krwawienie, int przebiciePancerza) :
            base(nazwa, atak, obrona, krwawienie)
        { PrzebiciePancerza = przebiciePancerza; }
    }
}
