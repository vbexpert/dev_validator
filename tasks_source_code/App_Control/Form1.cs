using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Control
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x, y;
            x = double.Parse(textBox1.Text);
            y = (Math.Sqrt(x + 2) - Math.Pow(x, 5)) / (Math.Pow(x, 2) - 7 * x + 4) + 2019;
            textBox2.Text = y.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ControlBox = false;
        }
    }
}
