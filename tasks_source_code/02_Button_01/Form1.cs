using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        private void _test_validate(Form f)
        {
            //------------------------------------------------------------------------>
            //testign dynamic object access:

            //this._v_obj_exists(this.BackgroundImage, "asd");
            //Control c = f.Controls.Find("button1", true)[0];
            //Button btn1 = (Button)c;

            //working 1-liner:
            //Button btn1 = (Button)f.Controls.Find("button1", true)[0];

            //workign via lib func:
            Button btn1 = (Button)this._v_get_obj(this, "button1");
            //------------------------------------------------------------------------>
        }
        public object _v_get_obj(Form f, string s_obj_name)
        {
            return (f.Controls.Find(s_obj_name, true)[0]);
        }

        //-Не чіпайте код нижче:------------------------------------------------------>
        public Form1()
        { InitializeComponent(); }
        private void Form1_Load(object sender, EventArgs e)
        { _test_validate(this); }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("test", "caption", MessageBoxButtons.YesNo);
        }
    }
}
