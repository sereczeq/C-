using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryForm
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
        public int AktualnePunkty;

        // ścieżka do naszych grafik
        public string PlikLogo = $@"{AppDomain.CurrentDomain.BaseDirectory}\img\logo.jpg";
        public string FolderObrazki= $@"{AppDomain.CurrentDomain.BaseDirectory}\img\memory";
    
        public GameSettings()
        {
            UstawStartowe();
        }

        public void UstawStartowe()
        {
            CzasGry = 60;
            CzasPodgladu = 10;
            // Max punkty będziemy ustalać głebiej w kodzie na podstawie ilości kart
            MaxPunkty = 0;
            // TODO: upewnić się że rozmiar jest zawsze mniejszy niż 24
            Wiersze = 6;
            Kolumny = 4;
            Bok = 150;
            AktualnePunkty = 0;
        }
    }
}
