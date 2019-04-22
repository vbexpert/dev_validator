using System;
using System.Windows.Forms;
namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        { InitializeComponent(); }
        private void Form1_Load(object sender, EventArgs e)
        {
            //
        }

        private void btn_Doubling_Click(object sender, EventArgs e)
        {
            int a = int.Parse(tb_Input.Text);
            int b = a * 2;
            lb_Result.Text = b.ToString();
        }
    }
}
