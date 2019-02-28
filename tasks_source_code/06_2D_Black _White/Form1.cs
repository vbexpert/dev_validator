using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
namespace WindowsApplication1
{
    public partial class Black_White : Form
    {
        //-Не чіпайте код нижче:------------------------------------------------------>
        public Black_White()
        { InitializeComponent(); }
        

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
