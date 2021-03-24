using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGame
{
    public partial class MemoryForm : Form
    {
        // Przed settings stawiam "_" - dlaczego?
        private GameSettings _settings;
        // Ja to będę nazywać Main
        public MemoryForm()
        {
            InitializeComponent();

            _settings = new GameSettings();

            UstawKontrolki();

            GenerujKarty();

            // startujemy pierwszy timer, którego zadaniem jest odliczanie
            // do rozpoczęcia gry
            timerCzasPodlagu.Start();
        }

        // Metoda ustawiająca ustawienia startowe formularza
        // wykorzystamy ją podczas pierwszego uruchomienia
        // oraz przy restartowaniu gry od nowa.
        private void UstawKontrolki()
        {

            // żeby nie przejmować się dopasowywaniem okna w designerze,
            // obliczymy, ile miejsca potrzeba na wszystkie karty na podstawie właściwości,
            // które przechowujemy w obiekcie settings
            // obliczamy długość i szerokość dla panelu z kartami
            panelMemory.Width = _settings.Wiersze * _settings.Bok;
            panelMemory.Height = _settings.Kolumny * _settings.Bok;

            // Panel znajduje sie na formularzu, więc też musimy go powiększyć
            // dodając dodatkowe kilkadziesiąd pikseli merginesu (metodą prób i błędów)
            Width = panelMemory.Width + 40;
            Height = panelMemory.Height + 100;

            // ustawiamy teksty na labelkach
            labelPoczatekGry.Text = $"Początek gry za: {_settings.CzasPodgladu}";
            labelPunktyWartosc.Text = _settings.AktualnePuntky.ToString();
            labelCzasWartosc.Text = _settings.CzasGry.ToString();

            // oraz widoczność labelki na odliczanie dopoczątku gry
            // gdy gra się rozpocznie będziemy ją ukrywać
            labelPoczatekGry.Visible = true;
        }

        private void GenerujKarty()
        {
            /* 1. Wczytać obrazki z folderu z grafikami
             * 2. Stworzyć obiekt klasy MemoryCard z grafiką
             * 3. Stworzyć parę obiektów
             * 4. Dodać obiekty do listy
             * 5. Wybierać losowy element z listy
             * 6. Wstawić losowy element w odpowiednim miejscu w programie
             */

            // 1 - wczytanie obrazków
            // using System.IO;
            string[] memoryPaths = Directory.GetFiles(_settings.FolderObrazki);

            _settings.MaxPunkty = memoryPaths.Length;

            // 2.5 - tworzenie listy na karty
            List<MemoryCard> karty = new List<MemoryCard>();

            // 2 - Stworzyć obiekty kart
            // dla każdego z obrazka tworzymy po dwie karty
            foreach(string path in memoryPaths)
            {
                // tworzymy nowe unikalne ID do rozróżniania kart
                Guid id = Guid.NewGuid();

                // 3 - tworzenie pary kart
                // tworzymy dwie takie same karty (parę)
                MemoryCard karta1 = new MemoryCard(id, _settings.PlikLogo, path);
                MemoryCard karta2 = new MemoryCard(id, _settings.PlikLogo, path);

                // 4 - i dodajemy je do listy
                karty.Add(karta1);
                karty.Add(karta2);
            }

            Random random = new Random();

            // W momencie gdy resetujemy grę, panel będzie mieć w sobie karty,
            // dlatego przed dodaniem nowych kart, musimy usunąć z niego stare.
            panelMemory.Controls.Clear();

            // pętla do przejścia przez każdy wiersz
            for(int x = 0; x < _settings.Wiersze; x++)
            {
                // pętla do przejścia przez każdą kolumnę
                // w ten sposób stworzymy siatkę 2D z naczymi kartami
                for(int y = 0; y < _settings.Kolumny; y++)
                {
                    // 5 - wybranie losowej karty z listy
                    // tworzenie losowej liczby z zakresu od 0 do długości
                    // listy kart (wyłącznie)
                    int indeks = random.Next(0, karty.Count());

                    // pobieramy kartę z losowym indeksem z listy kart
                    MemoryCard karta = karty[indeks];

                    // !!!!! USUWAMY KARTĘ PO WYLOSOWANIU !!!!!
                    karty.Remove(karta);

                    // 6 - dodanie karty w odpowienim miejscu w formie
                    // stworzymy dwu pikselowy margines, żeby karty miały odstęp
                    int margines = 2;

                    // zmieniamy kontrolki naszej karty, ponieważ dziedziczy z label
                    // ustalamy pozycje, biorąc pod uwagę Bok jednej karty oraz margines
                    // x i y to koordynaty naszej karty
                    // przemnożone przez bok i margines dadzą odpowiednią pozycję
                    karta.Location = new Point(x * _settings.Bok + x * margines,
                                               y * _settings.Bok + y * margines);

                    // zmieniamy wielkość karty
                    karta.Width = karta.Height = _settings.Bok;

                    // domyślnie odkrywamy kartę
                    karta.Odkryj();

                    // dodajemy kartę do panelu
                    panelMemory.Controls.Add(karta);
                }
            }
        }

        // metoda timera CzasPodglądu - uruchamia się co 1 sekundę
        // jej zadaniem jest zmniejszenie czasu podglądu
        // oraz, gdy czas się skończy zakrycie wszystkich kart i wystartowanie gry
        private void timerCzasPodlagu_Tick(object sender, EventArgs e)
        {
            // zmniejszanie czasu podglądu o sekundę
            _settings.CzasPodgladu--;

            // aktualizujemy nasz label
            labelPoczatekGry.Text = $"Początek gry za {_settings.CzasPodgladu}";

            // jeżeli czas upłynął to zaktyj karty
            if(_settings.CzasPodgladu <= 0)
            {

            }
        }
    }
}
