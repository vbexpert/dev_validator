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
            //Form:
            if (f is Form)
            {
                cls_output_controller._add_validation_ok("Form true!", 20);
            }
            else
            {
                cls_output_controller._add_validation_failed("Form false!", 0);
            }

            //Form.BackColor
            if (f.BackColor.Name == "NavajoWhite")
            {
                cls_output_controller._add_validation_ok("this.BackColor true", 20);
            }
            else
            {
                cls_output_controller._add_validation_failed("this.BackColor false!", 0);
            }

            //Form.Text:
            if (f.Text == "Вікно на весь екран")
            {
                cls_output_controller._add_validation_ok("this.Text true!", 20);
            }
            else
            {
                cls_output_controller._add_validation_failed("this.Text false!", 0);
            }


            
            //Form.MaximizeBox:
            if (f.MaximizeBox == false)
            {
                cls_output_controller._add_validation_ok("this.MaximizeBox true!", 20);
            }
            else
            {
                cls_output_controller._add_validation_failed("this.MaximizeBox false!", 0);
            }

            //Form.MinimizeBox:
            if (f.MinimizeBox == false)
            {
                cls_output_controller._add_validation_ok("this.MinimizeBox true!", 20);
            }
            else
            {
                cls_output_controller._add_validation_failed("this.MinimizeBox false!", 0);
            }

            //Form.Maximized:
            if (f.WindowState == FormWindowState.Maximized)
            {
                cls_output_controller._add_validation_ok("FormWindowState.Maximized true!", 20);
            }
            else
            {
                cls_output_controller._add_validation_failed("FormWindowState.Maximized false!", 0);
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
