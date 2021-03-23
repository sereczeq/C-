using GraRpgMateusz.KlasyBohaterow;
using GraRpgMateusz.KlasyBroni.Lucznik;
using GraRpgMateusz.KlasyBroni.Wlucznik;
using GraRpgMateusz.KlasyBroni.Wojownik;
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

        public static Bron[] GenerujBronie(Hero hero)
        {
            Bron[] bronie = new Bron[4];
            if (hero.ToString().Contains("Wojownik"))
            {
                bronie[0] = new BronWojownika("topór", 4, 0);
                bronie[1] = new BronWojownika("miecz", 2, 3);
                bronie[2] = new BronWojownika("topór z tarczą", 3, 3);
                bronie[3] = new BronWojownika("miecz z tarczą", 1, 6);
            }
            else if (hero.ToString().Contains("Wlucznik"))
            {
                bronie[0] = new BronWlucznika("pika", 4, 0, 0, 2);
                bronie[1] = new BronWlucznika("włócznia", 3, 3, 2, 0);
                bronie[2] = new BronWlucznika("młot bojowy", 3, 0, 3, 0);
                bronie[3] = new BronWlucznika("halabarda", 1, 0, 6, 0);
            }
            else if (hero.ToString().Contains("Lucznik"))
            {
                bronie[0] = new BronLucznika("łuk długi", 4, 0, 0, 3);
                bronie[1] = new BronLucznika("łuk krótki", 2, 0, 0, 3);
                bronie[2] = new BronLucznika("długi łuk ze strzałami przebijającymi zbroję", 3, 0, 3, 0);
                bronie[3] = new BronLucznika("krótki łuk ze strzałami przebijającymi zbronę", 1, 0, 6, 0);

            }
            return bronie;
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
