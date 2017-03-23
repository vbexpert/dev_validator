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
           //extBox3.Text = (Int32.Parse(textBox1.Text) + Int32.Parse(textBox2.Text)).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _test_validate(this);
        }
        private void _test_validate(Form f)
        {
            cls_output_controller cls_output_controller = new cls_output_controller();


            //test box via reflection test:
            //Control c = f.Controls.Find("textBox1", true)[0];

            //TextBox tbx = (TextBox)c;
            //if (tbx.Text == "1")
            //{
            //    cls_output_controller._add_validation_ok("TextBox містить вірний текст!", 20);
            //}
            //else
            //{
            //    cls_output_controller._add_validation_ok("TextBox містить неправильний текст!", 20);
            //}
            //MessageBox.Show(tbx.Text);


            //----------------------------------------------->
            // validation code start:
            //----------------------------------------------->
            //форма:
            if (f is Form)
            {
                cls_output_controller._add_validation_ok("Форма присутня!", 20);
            }
            else
            {
                cls_output_controller._add_validation_failed("Форма відсутня!", 0);
            }

            //розміри:
            if ((f.Width == 700) && (f.Height == 300))
            {
                cls_output_controller._add_validation_ok("Розміри форми вірні!", 20);
            }
            else
            {
                cls_output_controller._add_validation_failed("Розміри форми неправильні!", 0);
            }

            //колір:
            if (f.BackColor.Name == "IndianRed")
            {
                cls_output_controller._add_validation_ok("Колір форми вірний!", 20);
            }
            else
            {
                cls_output_controller._add_validation_ok("Колір форми неправильний!", 0);
            }

            //заголовок:
            if (f.Text == "TextBox")
            {
                cls_output_controller._add_validation_ok("Заголовок форми вірний!", 20);
            }
            else
            {
                cls_output_controller._add_validation_failed("Заголовок форми неправильний!", 0);
            }

            //положення:
            if (f.StartPosition == FormStartPosition.CenterScreen)
            {
                cls_output_controller._add_validation_ok("Розташування форми вірне!", 20);
            }
            else
            {
                cls_output_controller._add_validation_failed("Розташування форми неправильний!", 0);
            }

            //Прозорість:
            /*if (f.Opacity == .50)
            {
                cls_output_controller._add_validation_ok("Прозорість вірна! ", 20);
            }
            else
            {
                cls_output_controller._add_validation_failed("Прозорість неправильна! ", 0);
            }
            */


            //
            //test box via reflection test:
            Control c = f.Controls.Find("textBox1", true)[0];
            TextBox tbx = (TextBox)c;

            if (tbx is TextBox)
            {
                cls_output_controller._add_validation_ok("Текстове поле TextBox присутнє!", 20);
            }
            else
            {
                cls_output_controller._add_validation_failed("Текстове поле TextBox відсутнє!", 0);
            }


            if (tbx.Text == "")
            {
                cls_output_controller._add_validation_ok("TextBox містить вірний текст!", 20);
            }
            else
            {
                cls_output_controller._add_validation_failed("TextBox містить неправильний текст!", 20);
            }
            //----------------------------------------------->
            // validation code end:
            //----------------------------------------------->
        }
    }

    public class cls_output_controller
    {
        public string s_output_buffer = "";
        public int i_total_score = 0;
        public void _add_validation_ok(string s_value, int i_i_score)
        {
            i_total_score += i_i_score;
            s_output_buffer += "<div class='c_correct'>+ " + s_value + " +" + i_i_score + " балів!</div><br>\r\n";
        }
        public void _add_validation_failed(string s_value, int i_i_score)
        {
            i_total_score += i_i_score;
            //s_output_buffer += "<div class='c_wrong'>- " + s_value + " " + i_i_score + "</div><br>\r\n";
            s_output_buffer += "<div class='c_wrong'>- " + s_value + "</div><br>\r\n";
        }
        public string _final_result() {
            return this.s_output_buffer += "<div class='c_correct'>Всього: " + i_total_score + "</div><br>\r\n";
        }
    }
}
