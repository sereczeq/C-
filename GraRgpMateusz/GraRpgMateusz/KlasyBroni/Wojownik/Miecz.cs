using GraRpgMateusz.KlasyBohaterow;
using System;
using System.Collections.Generic;
using System.Text;

namespace GraRpgMateusz.KlasyBroni.Wojownik
{
    class Miecz : BronWojownika
    {
        public Miecz(string nazwa, int atak, int obrona, int krwawienie) :
            base(nazwa, atak, obrona)
        {
        }
    }
}