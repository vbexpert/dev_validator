using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = (Int32.Parse(textBox1.Text) + Int32.Parse(textBox2.Text)).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form f = this;
            if (f.Text != "WindowsApplication1") {
                this.s_echo_vailid("Назва форми вірна!", 50);
            }
            else {
                this.s_echo_vailid("Назва форми Не вірна!", 0);
            }
        }
        private string s_echo_vailid(string s_value, int i_i_score)
        {
            return ("<div class='green'></div>");
        }
        private string s_echo_invalid(string s_value)
        {
            return ("<div class='green'></div>");
        }
        //----------------------------------------------->
    }
}
