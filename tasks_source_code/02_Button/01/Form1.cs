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

            //----------------------------------------------->
            // validation code start:
            //----------------------------------------------->
            //форма:
            if (f is Form)
            {
                cls_output_controller._add_validation_ok("Form  присутня!", 20);
            }
            else
            {
                cls_output_controller._add_validation_failed("Form відсутня!", 0);
            }

            //розміри:
            if ((f.Width == 400) && (f.Height == 300))
            {
                cls_output_controller._add_validation_ok("Розміри форми вірні!", 20);
            }
            else
            {
                cls_output_controller._add_validation_failed("Розміри форми невірні!", 0);
            }

            //колір:
            if (f.BackColor.Name == "Silver")
            {
                cls_output_controller._add_validation_ok("Form.BackColor вірний!", 20);
            }
            else
            {
                cls_output_controller._add_validation_ok("Form.BackColor невірний!", 0);
            }

            //заголовок:
            if (f.Text == "Знайомство з кнопкою Button")
            {
                cls_output_controller._add_validation_ok("Form.Text true!", 20);
            }
            else
            {
                cls_output_controller._add_validation_failed("Form.Text false!", 0);
            }

            //положення:
            if (f.StartPosition == FormStartPosition.CenterScreen)
            {
                cls_output_controller._add_validation_ok("FormStartPosition.CenterScreen true!", 20);
            }
            else
            {
                cls_output_controller._add_validation_failed("FormStartPosition.CenterScreen false!", 0);
            }


            //Button  via reflection test:
            Control c = f.Controls.Find("btn_Hello", true)[0];
            Button btn1 = (Button)c;

            if (btn1 is Button)
            {
                cls_output_controller._add_validation_ok("Кнопка Button присутня!", 20);
            }
            else
            {
                cls_output_controller._add_validation_failed("Кнопка Button відсутня!", 0);
            }

            //Name
            if (btn1.Name == "btn_Hello")
            {
                cls_output_controller._add_validation_ok("Button.Name true!", 20);
            }
            else
            {
                cls_output_controller._add_validation_failed("Button.Name false!", 20);
            }

            //Color:
            if (btn1.BackColor.Name == "LimeGreen")
            {
                cls_output_controller._add_validation_ok("Button.BackColor true!", 20);
            }
            else
            {
                cls_output_controller._add_validation_ok("Button.BackColor false!", 0);
            }

            //Font.Name:
            if (btn1.Font.Name == "Verdana")
            {
                cls_output_controller._add_validation_ok("Button.Font.Name true!", 20);
            }
            else
            {
                cls_output_controller._add_validation_ok("Button.Font.Name false!", 0);
            }

            //Font.Size:
            if (btn1.Font.Size == 12)
            {
                cls_output_controller._add_validation_ok("Button.Font.Size true!", 20);
            }
            else
            {
                cls_output_controller._add_validation_ok("Button.Font.Size false!", 0);
            }

            //Font.Style:
            if (btn1.Font.Bold)
            {
                cls_output_controller._add_validation_ok("Button.Font.Bold true!", 20);
            }
            else
            {
                cls_output_controller._add_validation_ok("Button.Font.Bold false!", 0);
            }

            //Button.Width:
            if (btn1.Width == 100)
            {
                cls_output_controller._add_validation_ok("Button.Width true!", 20);
            }
            else
            {
                cls_output_controller._add_validation_ok("Button.Width false!", 0);
            }

            //Button.Height:
            if (btn1.Height == 50)
            {
                cls_output_controller._add_validation_ok("Button.Height true!", 20);
            }
            else
            {
                cls_output_controller._add_validation_ok("Button.Height false!", 0);
            }

            //Button.Location.X
            if (btn1.Location.X == 140)
            {
                cls_output_controller._add_validation_ok("Button.Location.X true!", 20);
            }
            else
            {
                cls_output_controller._add_validation_ok("Button.Location.X false!", 0);
            }

            //Button.Location.Y
            if (btn1.Location.Y == 115)
            {
                cls_output_controller._add_validation_ok("Button.Location.Y true!", 20);
            }
            else
            {
                cls_output_controller._add_validation_ok("Button.Location.Y false!", 0);
            }

            //Button.Text
            if (btn1.Text == "Hello")
            {
                cls_output_controller._add_validation_ok("Button.Text true!", 20);
            }
            else
            {
                cls_output_controller._add_validation_ok("Button.Text false!", 0);
            }

            //ContentAlignment.MiddleCenter
            if (btn1.TextAlign == ContentAlignment.MiddleCenter)
            {
                cls_output_controller._add_validation_ok("ContentAlignment.MiddleCenter true!", 20);
            }
            else
            {
                cls_output_controller._add_validation_ok("ContentAlignment.MiddleCenter false!", 0);
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
