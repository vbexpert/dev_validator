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
        public void _v_parm(object obj, string s_obj_name, string s_controled_value)
        {
            if (obj.ToString() == s_controled_value)
            {
                //this._add_validation_ok(s_obj_name + " Ok!", 20);
            }
            else
            {
                //this._add_validation_failed(s_obj_name + " Not Ok!", 0);
            }
        }
        public object _v_get_obj(Form f, string s_obj_name)
        {
            return (f.Controls.Find(s_obj_name, true)[0]);
        }


        private void _test_validate(Form f)
        {
            cls_output_controller cls_output_controller = new cls_output_controller();
            //------------------------------------------------------------------------>
            //початок коду валідації:
            CheckBox chk1 = (CheckBox)_v_get_obj(f, "checkBox1");
            _v_parm(chk1.Checked, "CheckBox.Checked", "true");

            //string s_today = this.dateTimePicker1. .Text;
            //if (DateTime.Today.ToString() == s_today)
            //{
            //    s_today = "1";
            //}
            //else {
            //    s_today = "1";
            //}



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
