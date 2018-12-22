using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Theory_of_Probability_LAB3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Plain_Click(object sender, EventArgs e)
        {
            Plain P = new Plain();
            P.ShowDialog();
        }

        private void Normal_Click(object sender, EventArgs e)
        {
            Normal N = new Normal();
            N.ShowDialog();
        }

        private void Exp_Click(object sender, EventArgs e)
        {
            Exp E = new Exp();
            E.ShowDialog();
        }
    }
}
