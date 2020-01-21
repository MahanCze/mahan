using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kalkulacka_test
{
    public partial class kalkulacka : Form
    {
        public kalkulacka()
        {
            InitializeComponent();
            zadaniTextBox.Text = "0";
        }

        int cislo1;
        int cislo2;
        string funkce;
        int c = 0;

        private void kalkulacka_Load(object sender, EventArgs e)
        {

        }

        private void button06_Click(object sender, EventArgs e)
        {

        }

        private void button09_Click(object sender, EventArgs e)
        {

        }

        private void button01_Click(object sender, EventArgs e)
        {
            if (zadaniTextBox.Text != "0")
            {
                zadaniTextBox.Text = zadaniTextBox.Text + ((Button)sender).Text;
            }
            else
            {
                zadaniTextBox.Text = ((Button)sender).Text;
            }
        }
    }
}
