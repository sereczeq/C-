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

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }

        private void buttonZaloguj_Click(object sender, EventArgs e)
        {

            Uzytkownik jan = new Uzytkownik();

            //zmienne na poprawne dane logowania
            string poprawnyLogin = "gigant";
            string poprawneHaslo = "Gigant123";

            //sprawdzenie czy login i hasło z textBoxów są takie same jak zadeklarowane
            if(poprawnyLogin == textBoxLogin.Text && poprawneHaslo == textBoxHaslo.Text)
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
