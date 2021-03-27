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

        // zmienne do metody BtnClicked sprawdzające ile kart jest odkrytych oraz czy są parą
        private MemoryCard pierwszaKarta = null;
        private MemoryCard drugaKarta = null;

        // "Main"
        public MemoryForm()
        {
            InitializeComponent();

            StartGry();
        }

        private void StartGry()
        {
            _settings = new GameSettings();

            UstawKontrolki();

            GenerujKarty();

            // włączenie timera
            timerCzasPodgladu.Start();

            pierwszaKarta = drugaKarta = null;
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

            // dopóki liczba pól na karty jest większa niż ilość plikó (kart) zmniejsz liczbę kolumn
            while(_settings.Kolumny * _settings.Wiersze / 2 > memories.Length)
            {
                _settings.Kolumny--;
            }

            // tworzymy listę na karty do gry
            var cards = new List<MemoryCard>();

            // dla każdego z obrazka tworzymy po dwie karty
            for(int i = 0; i < _settings.Kolumny * _settings.Wiersze / 2; i++)
            {
                // wczytujemy ścieżkę do grafiki
                string memory = memories[i];

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

            // Czyścimy zawartość panelu kart, w przypadku gdy np resetujemy grę
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

                    // dodajemy naszą metodę btn clicked żeby połączyć kartę z met
                    karta.Click += BtnClicked;

                    // domyślnie odkrywamy kartę
                    karta.Odkryj();

                    // dodajemy przygotowaną kartę do panelu gry
                    panelMemory.Controls.Add(karta);
                }
            }

        }

        // metoda timera CzasPodglądu - uruchamia się co 1 sekundę
        // jej zadaniem jest zmniejszenie czasu podglądu
        // oraz, gdy czas się skończy zakrycie wszystkich kart i wystartowanie gry
        private void timerCzasPodgladu_Tick(object sender, EventArgs e)
        {
            // zmniejszamy czas podglądu o 1 co sekundę
            _settings.CzasPodgladu--;

            // aktualizujemy tekst
            labelPoczatekGry.Text = $"Początek gry za {_settings.CzasPodgladu} sekund.";

            if (_settings.CzasPodgladu <= 0)
            {
                // zatrzymujemy timer
                timerCzasPodgladu.Stop();

                // "znikamy" label 
                labelPoczatekGry.Visible = false;

                // zakrywanie wszystkich kart
                // dla każdego elementu typu MemoryCard (dla każdej karty) w panelu
                foreach(MemoryCard karta in panelMemory.Controls)
                {
                    // zakryj kartę
                    karta.Zakryj();
                }

                // aktywowanie licznika czasu gry
                timerCzasGry.Start();
            }
        }

        private void BtnClicked(object sender, EventArgs e)
        {
            // sender to kontrolka, która wywołała zdarzenie
            // ponieważ metoda jest podpięta tylko pod karty do gry
            // możemy zrzutować object na MemoryCard, bo wiemy, że nie może to być nic innego
            MemoryCard karta = (MemoryCard) sender;

            karta.Odkryj();

            // jeżeli nie otwarto jeszcze żadnej karty (obecna jest pierwsza)
            if (pierwszaKarta == null)
            {
                pierwszaKarta = karta;
            }
            // else oznacza że obecna karta jest drugą, teraz musimy sprawdzić czy są takie same
            else
            {
                drugaKarta = karta;

                // żeby użytkownik nie mógł otworzyć trzeciej karty
                panelMemory.Enabled = false;

                // jeżeli karty są parą to
                if (pierwszaKarta.Id == drugaKarta.Id)
                {
                    // dodajemy punkty
                    _settings.AktualnePunkty++;

                    // aktualizujemy label
                    labelPunktyWartosc.Text = _settings.AktualnePunkty.ToString();

                    // notujemy że obie karty są otwarte, i że pierwsza jest "pusta" - można znowu otwierać
                    pierwszaKarta = null;
                    drugaKarta = null;

                    // odblokowujemy możliwość klikania w karty
                    panelMemory.Enabled = true;
                }
                else
                {
                    timerZakrywacz.Start();
                }
            }
        }

        // po sekundzie od odkrycia drugiej karty nie do pary, zakryj karty i odblokuj panel
        private void timerZakrywacz_Tick(object sender, EventArgs e)
        {
            // zakryj karty
            pierwszaKarta.Zakryj();
            drugaKarta.Zakryj();

            // wyczyść zmienne pomocnicze
            pierwszaKarta = drugaKarta = null;

            // odblokowujemy możliwość klikania w karty
            panelMemory.Enabled = true;

            timerZakrywacz.Stop();
        }

        private void timerCzasGry_Tick(object sender, EventArgs e)
        {
            // to samo co z timerem początku gry
            _settings.CzasGry--;
            labelCzasWartosc.Text = _settings.CzasGry.ToString();

            // sprawdzamy czy nie nastąpił koniec gry z jednego z dwóch powodów
            // - skończył się czas gry
            // lub odkryliśmy wszystkie karty - czyli zostały zdobyte wszystkie możliwe punkty
            if (_settings.CzasGry <= 0 || _settings.AktualnePunkty == _settings.MaxPunkty)
            {
                // jeżeli tak to zatrzymujemy timer CzasGry oraz timer Zakrywacz
                timerCzasGry.Stop();
                timerZakrywacz.Stop();

                // wyświetlamy MessageBox z wynikiem i zapytaniem czy rozpocząć grę od nowa
                // wynik, który z przycisków został kliknięty zapisujemy do zmiennej
                var yesno = MessageBox.Show($"Zdobyte punkty: {_settings.AktualnePunkty}",
                                                                    "Koniec Gry", MessageBoxButtons.YesNo);
                // jeżeli tak to zaczynamy grę od nowa
                if(yesno == DialogResult.Yes)
                {
                    StartGry();
                }
                else
                {
                    // jeżeli użytkownik wybierze "nie" to wyłączamy grę
                    Application.Exit();
                }
            }
        }
    }
}
