using Logowanie.Klasy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logowanie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void buttonZaloguj_Click(object sender, EventArgs e)
        {
            Uzytkownik jan = new Uzytkownik();

            Uzytkownik michal = new Uzytkownik();
            michal.Login = "misiu122";
            michal.Wiek = 33;
            michal.Imie = "Michał";

            MessageBox.Show(jan.PrzedstawSie(), "Komunikat", MessageBoxButtons.OK);
            MessageBox.Show(michal.PrzedstawSie(), "Komunikat", MessageBoxButtons.OK);

            //zmienne na poprawne login i hasło
            string poprawnyLogin = "Gigant";
            string poprawneHasło = "Gigant123!";

            //sprawdzenie czy login i hasło są poprawne
            if(jan.Login == textBoxLogin.Text && jan.Haslo == textBoxHaslo.Text)
            {
                MessageBox.Show("Zalogowano poprawnie", "Komunikat", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Login lub hasło niepoprawne", "Błąd", MessageBoxButtons.OK);
            }
        }
    }
}
