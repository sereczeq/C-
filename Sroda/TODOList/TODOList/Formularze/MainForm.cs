using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TODOList.Kontrolki;

namespace TODOList
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            // Pierwszą kontrolką będzie pokaż login control
            PokazLoginControl();
            // PokazRegisterControl();
            // PokazTaskControl();
        }

        // Metoda do zmiany kontrolki na Login Control
        public void PokazLoginControl()
        {
            // Najpierw usuwa poprzednią kontrolkę
            Controls.Clear();
            // A potem dodaje nową kontrolkę, jako argument podajemy this,
            // czyli odwołanie do głównej formy
            // using TODOList.Kontrolki;
            Controls.Add(new LoginControl(this));
        }

        public void PokazRegisterControl()
        {
            Controls.Clear();
            Controls.Add(new RegisterControl(this));
        }
        public void PokazTaskControl()
        {
            Controls.Clear();
            Controls.Add(new TaskControl(this));
        }
    }
}
