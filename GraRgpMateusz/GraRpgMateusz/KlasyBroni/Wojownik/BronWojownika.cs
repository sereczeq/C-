using System;
using System.Collections.Generic;
using System.Text;

namespace GraRpgMateusz.KlasyBroni.Wojownik
{
    class BronWojownika : Bron
    {
        public BronWojownika(string nazwa, int atak, int obrona) :
            base(nazwa, atak, obrona, 0)
        {

        }
    }
}
