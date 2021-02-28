using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            int wynik = 1;
            int liczba = int.Parse(textBox1.Text);
            int potega = int.Parse(textBox2.Text);
            for(int licznik = 0; licznik < potega; licznik++)
            {
                wynik *= liczba;
            }
            textBox3.Text = wynik.ToString();
        }

    }
}
