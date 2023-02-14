using System;
using System.Windows.Forms;
namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        { InitializeComponent(); }

        private void btn_Close_Click(object sender, EventArgs e)
        {
             Close();
        }

        private void btn_CopyText_Click(object sender, EventArgs e)
        {           
            lb_Result.Text = tb_Input.Text;
        }
    }
}
