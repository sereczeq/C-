using GraRpgMateusz.KlasyBohaterow;
using System;
using System.Collections.Generic;
using System.Text;

namespace GraRpgMateusz.KlasyBroni
{
    class Bron
    {
        public string Nazwa;
        public int Atak;
        public int Obrona;
        public int Krwawienie;

        public Bron(string nazwa, int atak, int obrona, int krwawienie)
        {
            Nazwa = nazwa;
            Atak = atak;
            Obrona = obrona;
            Krwawienie = krwawienie;
        }

        public virtual string Statystyki()
        {
            return $"{Nazwa}: \n" +
                $"{Atak}\t ataku \n" +
                $"{Obrona}\t obrony \n" +
                $"{Krwawienie}\t krwawienia\n";
        }
    }
    
}
