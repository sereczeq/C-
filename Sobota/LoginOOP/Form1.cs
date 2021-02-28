using LoginOOP.Klasy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginOOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnZaloguj_Click(object sender, EventArgs e)
        {
            // tworzymy obiekt typu Uzytkownik 
            Uzytkownik u = new Uzytkownik();
            // ustawiamy w obiekcie własności 
            u.Login = "gigant";
            u.Haslo = "gigant123";
            u.Email = "gigant@gmail.com";
            u.Wiek = 20;
            // sprawdzamy czy login i hasło z textboxów są takie same jak zadeklarowane wyżej
            if (u.Login == txtLogin.Text && u.Haslo == txtHaslo.Text) 
            {
                MessageBox.Show($"Zalogowano poprawnie. {u.PrzedstawSie()}", "Komunikat", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Login lub hasło niepoprawne", "Błąd", MessageBoxButtons.OK);
            }
        }

    }
}
