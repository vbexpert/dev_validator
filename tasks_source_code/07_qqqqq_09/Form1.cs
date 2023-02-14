using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
           
        }
        


        private void btn_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }

        private void tb_Input_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((number < 48 || number > 57) && number != 8 && number != 45)
            {
                e.Handled = true;
            }
        }
    }
}
