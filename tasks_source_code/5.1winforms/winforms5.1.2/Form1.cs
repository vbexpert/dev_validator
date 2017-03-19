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

            //------------------------------------------------------------------------>
            //початок коду валідації:
            //------------------------------------------------------------------------>
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
            if ((f.Width == 500) && (f.Height == 500))
            {
                cls_output_controller._add_validation_ok("Розміри форми вірні!", 20);
            }
            else
            {
                cls_output_controller._add_validation_failed("Розміри форми невірні!", 0);
            }

            //колір:
            if (f.BackColor.Name == "CadetBlue")
            {
                cls_output_controller._add_validation_ok("Колір форми вірний!", 20);
            }
            else
            {
                cls_output_controller._add_validation_failed("Колір форми невірний!", 0);
            }

            //заголовок:
            if (f.Text == "Програма 2")
            {
                cls_output_controller._add_validation_ok("Вірний заголовок форми!", 20);
            }
            else
            {
                cls_output_controller._add_validation_failed("Невірний заголовок форми!", 0);
            }
            //початкова позиція:
            if (f.StartPosition == FormStartPosition.Manual)
            {
                cls_output_controller._add_validation_ok("Вірна початкова позиція!", 20);
            }
            else
            {
                cls_output_controller._add_validation_failed("Неправильна початкова позиція!", 0);
            }

            //положення:
            if (f.Location.X == 0 && f.Location.Y == 0)
            {
                cls_output_controller._add_validation_ok("Вірние розташування форми!", 20);
            }
            else
            {
                cls_output_controller._add_validation_failed("Неправильне розташування форми!", 0);
            }

            //Прозорість:
            if (f.Opacity == .50)
            {
                cls_output_controller._add_validation_ok("Вірна прозорість!", 20);
            }
            else
            {
                cls_output_controller._add_validation_failed("Неправильна прозорість!", 0);
            }
            //------------------------------------------------------------------------>
            //кінець коду валідації:
            //------------------------------------------------------------------------>
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
