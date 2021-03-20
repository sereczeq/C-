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

namespace MemoryForm
{
    public partial class MemoryForm : Form
    {

        private GameSettings _settings;

        // "Main"
        public MemoryForm()
        {
            InitializeComponent();

            _settings = new GameSettings();

            UstawKontrolki();

            GenerujKarty();
        }

        private void UstawKontrolki()
        {
            // żeby nie przejmować się dopasowywaniem okna w designerze,
            // obliczymy, ile miejsca potrzeba na wszystkie karty na podstawie właściwości,
            // które przechowujemy w obiekcie settings
            // obliczamy długość i szerokość dla panelu z kartami
            panelMemory.Width = _settings.Bok * _settings.Wiersze;
            panelMemory.Height = _settings.Bok * _settings.Kolumny;

            // panel znajduje sie na formularzu, więc też musimy go powiększyć
            // dodając dodatkowe kilkadziesiąd pikseli merginesu (metodą prób i błędów)
            Width = panelMemory.Width + 40;
            Height = panelMemory.Height + 100;

            // ustawiamy teksty na labelkach
            labelPoczatekGry.Text = $"Początek gry za {_settings.CzasPodgladu} sekund.";
            labelPunktyWartosc.Text = _settings.AktualnePunkty.ToString();
            labelCzasWartosc.Text = _settings.CzasGry.ToString();

            // oraz widoczność labelki na odliczanie dopoczątku gry
            // gdy gra się rozpocznie będziemy ją ukrywać
            labelPoczatekGry.Visible = true;
        }

        private void GenerujKarty()
        {
            // wczytywanie ścieżek do plików
            // using System.IO
            string[] memories = Directory.GetFiles(_settings.FolderObrazki);

            // w zależności ile jest obrazków, tyle ma być max punktów
            // TODO: dać możliwośc wyboru ilości obrazków
            _settings.MaxPunkty = memories.Length;

            // tworzymy listę na karty do gry
            var cards = new List<MemoryCard>();

            // dla każdego z obrazka tworzymy po dwie karty
            foreach (string memory in memories)
            {
                // tworzymy unikalny identyfikator dla karty
                Guid id = Guid.NewGuid();

                // tworzymy parę kart z tym samym obrazkiem
                var karta1 = new MemoryCard(id, _settings.PlikLogo, memory);
                var karta2 = new MemoryCard(id, _settings.PlikLogo, memory);
                
                // dodajemy obie karty do listy kart
                cards.Add(karta1);
                cards.Add(karta2);
            }

            // generator liczb pseudolosowych
            Random random = new Random();

            // Czyścimy zawartość panelu kart, w przypadku gdgy np resetujemy grę
            // i są tam jeszcze stare karty.
            panelMemory.Controls.Clear();

            for(int x = 0; x < _settings.Wiersze; x++)
            {
                for(int y = 0; y < _settings.Kolumny; y++)
                {
                    // tworzymy losową liczbę od 0 do ilości kart (żeby nie wyjść poza index)
                    int index = random.Next(0, cards.Count());

                    // wybieranie losowej karty z listy naszych kart
                    MemoryCard karta = cards[index];

                    // usuwanie wybranej karty z listy aby się nie powtórzyła
                    cards.Remove(karta);

                    // dla "upięknienia" aplikacj, margines doda odstępy między kartami
                    int margines = 2;

                    // obliczamy pozycję x i y na panelu, pod którą zostanie umieszona karta
                    // x wyznaczamy mnożąc wiersz w którym jesteśmy przez długość boku
                    // dodając dwa razy margines (po lewej i po prawej)
                    // y wyznaczamy mnożąc kolumnę w której jesteśmy przez długość boku
                    // dodając dwa razy margines (u góry i u dołu)
                    karta.Location = new Point((x * _settings.Bok) + (margines * x),
                                               (y * _settings.Bok) + (margines * y));

                    // ustawiamy wielkość karty
                    karta.Width = _settings.Bok;
                    karta.Height = _settings.Bok;

                    // domyślnie odkrywamy kartę
                    karta.Odkryj();

                    // dodajemy przygotowaną kartę do panelu gry
                    panelMemory.Controls.Add(karta);
                }
            }

        }
    }
}
