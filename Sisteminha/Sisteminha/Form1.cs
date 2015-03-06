using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sisteminha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double num;
        double result;

        public double rec(double var)
        {
            if (var == 0)
                return 1;

            return var*rec(var - 1);
        }

        private void iteracao(object sender, EventArgs e)
        {
            num = Convert.ToDouble(texto.Text);
            result = num;
            for (int i = 0; i < (num - 1); i++) {
                result = result * (num - (i + 1));
            }
            lbl.Text = Convert.ToString(result);
        }

        private void recursao(object sender, EventArgs e)
        {
            num = Convert.ToDouble(texto.Text);
            lbl.Text = Convert.ToString(rec(num));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
