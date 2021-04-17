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

            MainForm = mainForm;
            Dock = DockStyle.Fill;

        }

        private void buttonZaloguj_Click(object sender, EventArgs e)
        {
            MainForm.PokazTasksControl();
        }

        private void buttonUtworzKonto_Click(object sender, EventArgs e)
        {
            MainForm.PokazRegisterControl();
        }
    }
}
