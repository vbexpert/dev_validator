using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskCreator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.cb_validation_method.SelectedIndex = 0;
            //autoadd form validation:
            lb_pvbs.Items.Add("//validate form");
            lb_pvbs.Items.Add("cls_output_controller._v_form(f);");
        }
        private void cb_create_task_Click(object sender, EventArgs e)
        {

        }
        private void cb_add_pvb_Click(object sender, EventArgs e)
        {
            string s_property = this.cb_validation_method.Text;
            s_property = s_property.Replace("s_controled_value", _en(this.cb_master_value.Text));
            s_property = s_property.Replace("s_obj_name", _en(this.cb_property.Text));
            s_property = s_property.Replace("obj", _en(this.cb_obj.Text + "." + this.cb_property.Text));
            //
            this.tb_combined_v_line.Text = s_property;
        }
        private string _en(string s_data) {
            return ("\"" + s_data + "\"");
        }
    }
}
