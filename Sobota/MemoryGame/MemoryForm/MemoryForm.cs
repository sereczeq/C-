using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    }
}
