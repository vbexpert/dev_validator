using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Black__White
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Black_Click(object sender, EventArgs e)
        {
            pb_Target.BackColor = Color.Black;
        }

        private void btn_White_Click(object sender, EventArgs e)
        {
            pb_Target.BackColor = Color.White;
        }
    }
}
