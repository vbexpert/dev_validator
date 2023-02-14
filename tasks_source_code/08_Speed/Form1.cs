using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08_Speed
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Calculate_Click(object sender, EventArgs e)
        {
            int s = int.Parse(tb_Length.Text);
            int t = int.Parse(tb_Time.Text);
            double v = (double)s / t;
            v = Math.Round(v, 2);
            lb_Result.Text = v.ToString();
        }
    }
}
