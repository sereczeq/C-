using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TODOList.Klasy;
using TODOList.Kontrolki;

namespace TODOList
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            PokazLoginControl();

            UserManager userManager = new UserManager();
            
            if (userManager.WyszukajUzytkownika("test1", "test2") != null)
            {
                // using System.Diagnostics
                Debug.WriteLine("jej");
            }
            else
            {
                Debug.WriteLine("O nie :(");
            }
        }

        public void PokazLoginControl()
        {
            Controls.Clear();
            Controls.Add(new LoginControl(this));
        }

        public void PokazRegisterControl()
        {
            Controls.Clear();
            Controls.Add(new RegisterControl(this));
        }
        public void PokazTasksControl()
        {
            Controls.Clear();
            Controls.Add(new TasksControl(this));
        }


    }
}
