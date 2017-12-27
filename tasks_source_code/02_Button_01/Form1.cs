using System;
using System.Windows.Forms;
namespace WindowsApplication1
{
    public partial class Form1 : Form
    {

        //-Не чіпайте код нижче:------------------------------------------------------>
        public Form1()
        { InitializeComponent(); }
        private void button1_Click(object sender, EventArgs e)
        {
            Control c = this.Controls.Find("button1", true)[0];
            Button btn1 = (Button)c;
            Console.WriteLine(btn1.Name);

        }
    }
}
