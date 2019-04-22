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

        private void Form1_Load(object sender, EventArgs e)
        {
            ControlBox = false;
        }

        private void btn_Calculate_Click(object sender, EventArgs e)
        {
            double x, y;
            x = double.Parse(tb_Input.Text);
            y = (Math.Sqrt(x + 2) - Math.Pow(x, 5)) / (Math.Pow(x, 2) - 7 * x + 4) + 2019;
            tb_Result.Text = y.ToString();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            tb_Input.Clear();
            tb_Result.Clear();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
