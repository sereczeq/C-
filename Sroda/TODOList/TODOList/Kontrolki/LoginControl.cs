using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TODOList.Kontrolki
{
    public partial class LoginControl : UserControl
    {
        private MainForm MainForm;
        public LoginControl(MainForm mainForm)
        {
            InitializeComponent();

            // ustalamy główny formularz, bo będziemy wywoływac w nim metody
            MainForm = mainForm;
            // ustalamy dokowanie aby ładnie się wszystko wyświetlało (Mateusz nie musi)
            Dock = DockStyle.Fill;
        }

        private void buttonZaloguj_Click(object sender, EventArgs e)
        {
            MainForm.PokazTaskControl();
        }

        private void buttonZarejestruj_Click(object sender, EventArgs e)
        {
            MainForm.PokazRegisterControl();
        }
    }
}
