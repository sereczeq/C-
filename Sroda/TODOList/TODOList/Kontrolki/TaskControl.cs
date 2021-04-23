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
    public partial class TaskControl : UserControl
    {
        private MainForm MainForm;
        public TaskControl(MainForm mainForm)
        {
            InitializeComponent();

            MainForm = mainForm;
            Dock = DockStyle.Fill;
        }

        private void buttonWroc_Click(object sender, EventArgs e)
        {
            MainForm.PokazLoginControl();
        }
    }
}
