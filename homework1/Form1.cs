using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework1
{
    public partial class Form1 : Form
    {
        string result;
        double a;
        double b;
        double c;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            result = textBox1.Text;
            a = Convert.ToDouble(result);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            result = textBox1.Text;
            b = Convert.ToDouble(result);
        }

        private void textBox3_MouseClick(object sender, MouseEventArgs e)
        {
            c = a + b;
            textBox3.Text = Convert.ToString(c);
        }
    }
}
