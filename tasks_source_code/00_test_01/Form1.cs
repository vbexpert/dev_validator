﻿using System;
using System.Windows.Forms;
using System.Collections.Generic;

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
            cls_output_controller._v_parm(f.Width, "Form.Width", "400");

            cls_output_controller._v_obj_exists(f.BackgroundImage, "Form.BackgroundImage");

            string s_vr = cls_output_controller._final_result();
            //кінець коду валідації:
            //------------------------------------------------------------------------>
        }
        //-Не чіпайте код нижче:------------------------------------------------------>
        public Form1()
        { InitializeComponent(); }
        private void Form1_Load(object sender, EventArgs e)
        { _test_validate(this); }
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
                _add_v_result(20, false, obj.ToString());
            }
        }
        public void _v_parm(object obj, string s_obj_name, string s_controled_value)
        {
            if (obj.ToString() == s_controled_value)
            {
                _add_v_result(20, true, "");
            }
            else
            {
                _add_v_result(20, false, s_obj_name + "=" + obj.ToString() + " master value: " + s_controled_value);
            }
        }
        public void _v_parm_norm(object obj, string s_obj_name, string s_controled_value)
        {
            if (obj.ToString().Replace(",", ".") == s_controled_value.Replace(",", "."))
            {
                _add_v_result(20, true, "");
            }
            else
            {
                _add_v_result(20, false, s_obj_name + "=" + obj.ToString() + " master value: " + s_controled_value);
            }
        }
        public void _v_obj_exists(object obj, string s_obj_name)
        {
            if (null == obj)
            {
                _add_v_result(20, true, "");
            }
            else
            {
                _add_v_result(20, false, obj.ToString());
            }
        }
        public void _v_neg_parm(object obj, string s_obj_name, string s_controled_value)
        {
            if (obj.ToString() != s_controled_value)
            {
                _add_v_result(20, true, "");
            }
            else
            {
                _add_v_result(20, false, s_obj_name + "=" + obj.ToString() + " master negative value: " + s_controled_value);
            }
        }
        public object _v_get_obj(Form f, string s_obj_name)
        {
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
                if (vr.b_result == true) {
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