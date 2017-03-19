﻿using System;
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

        public TextBox getTextBox()
        {
            return textBox1;
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
            //TextBox:
            TextBox tbx1 = (TextBox)f.Controls.Find("textBox1", true).FirstOrDefault();
            if (tbx1 is TextBox)
            {
                cls_output_controller._add_validation_ok("TextBox присутній!", 20);
            }
            else
            {
                cls_output_controller._add_validation_failed("TextBox відсутній!", 0);
            }
            //textbox:
            if (tbx1.Text == "2")
            {
                cls_output_controller._add_validation_ok("TextBox.Text вірний!", 20);
            }
            else
            {
                cls_output_controller._add_validation_failed("TextBox.Text неправильнй!", 0);
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