using System;
using System.Collections.Generic;
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


            cls_output_controller cls_output_controller = new cls_output_controller();
            //---------------------------------------------------->
            //початок коду валідації:
            cls_output_controller._v_form(this);
            cls_output_controller._v_parm(this.AutoScaleMode, "Form.AutoScaleMode", "None");

            Button b2 = (Button)cls_output_controller._v_get_obj(this, "button2");
            cls_output_controller._v_parm(b2.Text, "button1.Text", "NewButton");

            Button b1 = (Button)cls_output_controller._v_get_obj(this, "button1");

            if (cls_output_controller._v_obj_exists(b1, "button1") == false) {
                cls_output_controller._v_parm(b1.Text, "button1.Text", "NewButton");
                cls_output_controller._v_parm(this.Text, "Form.Text", "Знайомство із кнопкою");
            }
            else {

            }



            //кінець коду валідації:
            //---------------------------------------------------->
            //return (cls_output_controller._final_result());


        }
    }

    //-------------------------------------------------->
    //validation embedded classes:
    public class cls_output_controller
    {
        public List<cls_VResult> ilst_validated_parms = new List<cls_VResult>();
        //core validation methods:
        public void _v_form(object obj)
        {
            if (obj is Form)
            {
                _add_v_result(20, true, "");
            }
            else
            {
                _add_v_result(20, false, "From not detected!");
            }
        }
        public void _add_fail_msg(string s_msg)
        {
            _add_v_result(0, false, s_msg);
        }
        public void _v_parm(object obj, string s_obj_name, string s_controled_value)
        {
            if (null != obj){
                if (obj.ToString() == s_controled_value)
                {
                    _add_v_result(20, true, "");
                    return;
                }
            }
            _add_v_result(20, false, s_obj_name + "=" + obj.ToString() + " master value: " + s_controled_value);
        }
        public void _v_parm_norm(object obj, string s_obj_name, string s_controled_value)
        {
            if (null != obj){
                if (obj.ToString().Replace(",", ".") == s_controled_value.Replace(",", "."))
                {
                    _add_v_result(20, true, "");
                    return;
                }
            }
            _add_v_result(20, false, s_obj_name + "=" + obj.ToString() + " master value: " + s_controled_value);
        }
        public bool _v_obj_exists(object obj, string s_obj_name)
        {
            if (null != obj)
            {
                _add_v_result(20, true, "");
                return true;
            }
            else
            {
                _add_v_result(20, false, obj.ToString());
                return false;
            }
        }
        public void _v_neg_parm(object obj, string s_obj_name, string s_controled_value)
        {
            if (null != obj){
                if (obj.ToString() != s_controled_value)
                {
                    _add_v_result(20, true, "");
                    return;
                }
            }
             _add_v_result(20, false, s_obj_name + "=" + obj.ToString() + " master negative value: " + s_controled_value);
        }
        public object _v_get_obj(Form f, string s_obj_name)
        {
            if (f.Controls.Find(s_obj_name, true).Length == 0)
            {
                return null;
            }
            return (f.Controls.Find(s_obj_name, true)[0]);
        }
        //aux:
        public void _add_v_result(int i_i_score, bool b_v_ok, string s_error_details)
        {
            //if (b_v_ok == false) //force null score if false:
            //{
            //    i_i_score = 0;
            //}
            cls_VResult vr = new cls_VResult(ilst_validated_parms.Count, b_v_ok, i_i_score, s_error_details);
            ilst_validated_parms.Add(vr);
        }
        public string _final_result()
        {
            string s_php_tail = ";\");\r\n";
            string s_reply = "eval(\"\\$_SESSION[\\\"vrp_count\\\"] = " + ilst_validated_parms.Count.ToString() + s_php_tail;
            int i_ctr = 0;
            int i_v_percent = 0;
            int i_total_score = 0;
            int i_current_score = 0;
            foreach (cls_VResult vr in ilst_validated_parms)
            {
                //output php code to be run in eval()
                //use session variables to store results server-side and reusable:
                s_reply += "eval(\"\\$_SESSION[\\\"vr" + i_ctr.ToString() + "_reslt\\\"] = " + vr.b_result.ToString() + s_php_tail;
                s_reply += "eval(\"\\$_SESSION[\\\"vr" + i_ctr.ToString() + "_error\\\"] = \\\"" + vr.s_error_details.ToString() + "\\\"" + s_php_tail;
                s_reply += "eval(\"\\$_SESSION[\\\"vr" + i_ctr.ToString() + "_score\\\"] = " + vr.i_score_points.ToString() + s_php_tail;
                i_total_score += vr.i_score_points;
                if (vr.b_result == true)
                {
                    i_current_score += vr.i_score_points;
                }
                i_ctr++;
            }
            //count percentage:
            //f: total = 100
            //curr = x
            //f= curr * 100 / total
            i_v_percent = i_current_score * 100 / i_total_score;
            //add percentage:
            s_reply += "eval(\"\\$_SESSION[\\\"vr_percent\\\"] = " + i_v_percent.ToString() + s_php_tail;
            //reply:
            return s_reply;
        }
    }
    public class cls_VResult //validation result class
    {
        public int i_id = 0;
        public bool b_result = false;
        public int i_score_points = 0;
        public string s_error_details = "";
        public cls_VResult(int id, bool result, int score, string error_details)
        {
            this.i_id = id;
            this.b_result = result;
            this.i_score_points = score;
            this.s_error_details = error_details;
        }
    }
    //<--------------------------------------------------

}
