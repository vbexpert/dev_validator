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

        private void btn_Close_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_ChangeText_Click(object sender, EventArgs e)
        {
            btn_ChangeText.Text = "Напис на кнопці змінено!!!";
        }
    }
}
