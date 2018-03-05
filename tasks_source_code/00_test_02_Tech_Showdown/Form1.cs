using System;
using System.Windows.Forms;
namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        { InitializeComponent(); }
        private void button1_Click(object sender, EventArgs e)
        {
            //this.Text = this.textBox1.Text;
            int a = Int32.Parse(textBox1.Text);
            a = a * 2;
            this.textBox1.Text = a.ToString();
            //textBox1.Focus();
            // this.textBox1.Text= textBox1.ContainsFocus.ToString();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _v_obj_exists(this.BackgroundImage, "pictureBox1.Image");
        }
        public void _v_obj_exists(object obj, string s_obj_name)
        {
            if (null == obj)
            {
                //_add_v_result(20, true, "");
            }
            else
            {
                //_add_v_result(20, false, obj.ToString());
            }
        }
    }
}
