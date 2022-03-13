using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dasha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
            double x = Convert.ToDouble(textBox1.Text);
            textBox4.Text += "X = " + x.ToString() + Environment.NewLine;
            double y = Convert.ToDouble(textBox2.Text);
            textBox4.Text += "Y = " + y.ToString() + Environment.NewLine;
            double z = Convert.ToDouble(textBox3.Text);
            textBox4.Text += "Z = " + z.ToString() + Environment.NewLine;

            


            double result = (Math.Exp(Math.Abs(x - y)) * Math.Pow(Math.Abs(x - y), (x + y))) 
                / 
                (Math.Atan(x) + Math.Atan(z)) + Math.Pow(Math.Pow(x, 6) + Math.Pow(Math.Log(y), 2), 1d / 3d);
            textBox4.Text += "Ответ - " + result.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}

