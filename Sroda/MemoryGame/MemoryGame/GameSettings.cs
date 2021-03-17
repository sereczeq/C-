using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame
{
    class GameSettings
    {
        // ustawienia gry
        public int CzasGry;
        public int CzasPodgladu;
        public int MaxPunkty;
        public int Wiersze;
        public int Kolumny;
        public int Bok;
        public int AktualnePuntky;

        // ścieżki plików tekstowych
        public string PlikLogo = $@"{AppDomain.CurrentDomain.BaseDirectory}\img\logo.jpg";
        public string FolderObrazki = $@"{AppDomain.CurrentDomain.BaseDirectory}\img\memory";

        public GameSettings()
        {
            UstawStartowe();
        }

        public void UstawStartowe()
        {
            CzasPodgladu = 5;
            CzasGry = 60;
            MaxPunkty = 0;
            // TODO: upewnić się że kolumny * wiersze < 24
            Wiersze = 6;
            Kolumny = 4;
            Bok = 150;
            AktualnePuntky = 0;
        }
    }
}
