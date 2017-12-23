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
            cls_output_controller cls_output_controller = new cls_output_controller();
            //------------------------------------------------------------------------>
            //початок коду валідації:
            cls_output_controller._v_form(f);
            cls_output_controller._vp(f.Width, "400");
            cls_output_controller._vp(f.Height, "300");
            cls_output_controller._vp(f.BackColor.Name,"Red");
            cls_output_controller._vnp(f.Text, "Form1");
            cls_output_controller._vp(f.Location.X, "200");
            cls_output_controller._vp(f.Location.Y, "200");
            //кінець коду валідації:
            //------------------------------------------------------------------------>
        }
        //-Не чіпайте код нижче:------------------------------------------------------>
        public Form1()
        { InitializeComponent(); }
        private void Form1_Load(object sender, EventArgs e)
        { _test_validate(this); }
    }
    public class cls_output_controller
    {
        public string s_output_buffer = "";
        public int i_total_score = 0;
        public void _v_form(object obj)
        {
            if (obj is Form)
            {
                this._add_validation_ok("Form is Ok!", 20);
            }
            else
            {
                this._add_validation_failed("Form is Not Ok!", 0);
            }
        }
        public void _vp(object obj, string s_controled_value)
        {
            if (obj.ToString() == s_controled_value)
            {
                this._add_validation_ok(obj.ToString() + " Ok!", 20);
            }
            else
            {
                this._add_validation_failed(obj.ToString() + " Not Ok!", 0);
            }
        }
        public void _vnp(object obj, string s_controled_value)
        {
            if (obj.ToString() != s_controled_value)
            {
                this._add_validation_ok(obj.ToString() + " Ok!", 20);
            }
            else
            {
                this._add_validation_failed(obj.ToString() + " Not Ok!", 0);
            }
        }
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
        public string _final_result()
        {
            return this.s_output_buffer += "<div class='c_correct'>Всього: " + i_total_score + "</div><br>\r\n";
        }
    }
}
