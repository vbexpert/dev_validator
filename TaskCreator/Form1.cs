using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
namespace TaskCreator
{
    public partial class Form1 : Form
    {
        cls_Task cls_Task = new cls_Task();
        public Form1()
        {
            InitializeComponent();
            Directory.SetCurrentDirectory("..\\..\\..\\");
            _load_frequent_classes();
            this.cb_obj_type.Text = "Form";
            this.cb_property.Text = "Width";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.cb_validation_method.SelectedIndex = 0;
        }
        private void cb_create_task_Click(object sender, EventArgs e)
        {
            _task_create();
        }
        private void cb_add_pvb_Click(object sender, EventArgs e)
        {
            string s_property = this.cb_validation_method.Text; //_v_obj_exists(obj, s_obj_name);
            s_property = s_property.Replace("s_controled_value", _en(this.cb_master_value.Text));
            s_property = s_property.Replace("s_obj_name", _en(this.cb_p_desc_ENG.Text));
            s_property = s_property.Replace("[obj]",this.tb_obj_code_name.Text + "." + this.cb_property.Text);
            //
            this.tb_combined_v_line.Text = s_property;
            this.lb_cvbs.Items.Add(s_property);

            string s_php_vb_line = "$cls_Task->_add_property(\""+ this.cb_obj_type.Text + "\", \"" + this.cb_p_desc_UA.Text + "\", \""  + this.cb_master_value.Text + "\");";
            this.lb_cvpb_php.Items.Add(s_php_vb_line);
        }
        private string _en(string s_data)
        {
            return ("\"" + s_data + "\"");
        }
        private void _load_frequent_classes()
        {
            Dictionary<string, string> dic_f_classes = new Dictionary<string, string>();
            this.cb_obj_type.Items.Add("Form");
            this.cb_obj_type.Items.Add("Button");
            this.cb_obj_type.Items.Add("Label");
            this.cb_obj_type.Items.Add("TextBox");
            this.cb_obj_type.Items.Add("PictureBox");
            this.cb_obj_type.Items.Add("ComboBox");
            this.cb_obj_type.Items.Add("CheckBox");
            this.cb_obj_type.Items.Add("CheckedListBox");
            this.cb_obj_type.Items.Add("ProgressBar");
            this.cb_obj_type.Items.Add("RadioButton");
            this.cb_obj_type.Items.Add("DateTimePicker");            
            this.cb_obj_type.Items.Add("LinkLabel");
            this.cb_obj_type.Items.Add("ListView");
            this.cb_obj_type.Items.Add("MonthCalendar");
            this.cb_obj_type.Items.Add("NumericUpDown");
            this.cb_obj_type.Items.Add("RichTextBox");
        }
        private void _task_preview() {
            //
            cls_Task.s_id = this.tb_task_id.Text;
            cls_Task.s_fp = "tasks_source_code\\" + cls_Task.s_id;
           
            cls_Task.s_title = this.tb_task_title.Text;
            cls_Task.s_description = this.tb_task_description.Text;
            //
            //aggregate properties sharp:
            StringBuilder sb = new StringBuilder();
            foreach (string value in this.lb_cvbs.Items) {
                sb.Append("cls_output_controller." + value + "\r\n");
            }
            cls_Task.s_block_properties_sharp_code = sb.ToString();

            //aggregate steps php:
            sb.Remove(0, sb.Length);
            int i_ctr = 0;
            foreach (string value in this.lb_steps.Items)
            {
                i_ctr ++;
                sb.Append("$cls_Task->_add_step(\""+ i_ctr + ". " + value + "\");" + "\r\n");
            }
            cls_Task.s_block_steps = sb.ToString();

            //aggregate properties php:
            sb.Remove(0, sb.Length);
            i_ctr = 0;
            foreach (string value in this.lb_cvpb_php.Items)
            {
                i_ctr++;
                string s_line = value + "\r\n";
                sb.Append(s_line);
            }
            cls_Task.s_block_properties_php_code = sb.ToString();

            String s_buf = "";
            //read code file:
            s_buf = File.ReadAllText("tasks_source_code\\00_task_template\\code.txt");
            //patch properties sharp:
            s_buf = s_buf.Replace("[properties-validation-block-sharp]", cls_Task.s_block_properties_sharp_code);
            //preview:
            this.tb_sharp_parameters.Text = s_buf;

            //read task.php:
            s_buf = File.ReadAllText("tasks_source_code\\00_task_template\\task.php");
            //patch php:
            s_buf = s_buf.Replace("[task-title]", this.tb_task_description.Text);
            s_buf = s_buf.Replace("[task-id]", cls_Task.s_id);
            s_buf = s_buf.Replace("[task-description]", cls_Task.s_description);
            s_buf = s_buf.Replace("[step-instructions]", cls_Task.s_block_steps);
            s_buf = s_buf.Replace("[properties-validation-block-php]", cls_Task.s_block_properties_php_code);
            this.tb_php_task_file.Text = s_buf;
        }
        private void _task_create()
        {
            //if exists:
            if (Directory.Exists(cls_Task.s_fp))
            {
                MessageBox.Show("Folder already exists! Aborted!");
                return;
            }
            Directory.CreateDirectory(cls_Task.s_fp);
            string s_template_fp = "tasks_source_code\\00_task_template";

            //https://stackoverflow.com/questions/58744/copy-the-entire-contents-of-a-directory-in-c-sharp

            //copy all folders:
            foreach (string dirPath in Directory.GetDirectories(s_template_fp, "*", SearchOption.AllDirectories))
                Directory.CreateDirectory(dirPath.Replace(s_template_fp, cls_Task.s_fp));

            //copy all files:
            foreach (string newPath in Directory.GetFiles(s_template_fp, "*.*", SearchOption.AllDirectories))
                File.Copy(newPath, newPath.Replace(s_template_fp, cls_Task.s_fp), true);

            //patch project file:
            string s_cs_project_fnp = cls_Task.s_fp + "\\[template-task].csproj";
            string s_buf = File.ReadAllText(s_cs_project_fnp);
            s_buf = s_buf.Replace("[template-task]", cls_Task.s_title);
            File.WriteAllText(cls_Task.s_fp + "\\" + cls_Task.s_id + ".csproj", s_buf);
            File.Delete(s_cs_project_fnp);

            //patch cmd tester:
            string s_cmd_tester_fnp = cls_Task.s_fp + "\\win_test.bat";
            s_buf = File.ReadAllText(s_cmd_tester_fnp);
            s_buf = s_buf.Replace("[task_id]", cls_Task.s_id);
            s_buf = s_buf.Replace("[task_title]", cls_Task.s_title);
            File.WriteAllText(s_cmd_tester_fnp, s_buf);
            File.Delete(s_cs_project_fnp);

            //write code file:
            File.WriteAllText(cls_Task.s_fp + "\\code.txt", this.tb_sharp_parameters.Text);

            //write task.php:
            File.WriteAllText(cls_Task.s_fp + "\\task.php", this.tb_php_task_file.Text);

            MessageBox.Show("Task created Ok! Add to the main project!");
        }
        private void cb_preview_task_Click(object sender, EventArgs e)
        {
            _task_preview();
        }
        private void cb_obj_type_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string s_class_type = this.cb_obj_type.Text;

                //get type:
                var obj_class_type = typeof(Control).Assembly.GetType("System.Windows.Forms." + s_class_type, true);

                this.cb_property.Items.Clear();

                //enumerate and populate availiable properties:
                PropertyInfo[] properties = obj_class_type.GetProperties();
                foreach (PropertyInfo controlProperty in properties)
                {
                    this.cb_property.Items.Add(controlProperty.Name);
                }
                string s_inst_name = FirstCharToLower(this.cb_obj_type.Text + "1");
                this.tb_obj_code_name.Text = s_inst_name;
                //just try to refresh properties вообще то сюда надо процедуру cb_property_TextChanged(), но не получается
                string s_property = cb_obj_type.Text + "." + cb_property.Text;
                this.cb_p_desc_ENG.Text = s_property;
                this.cb_p_desc_UA.Text = s_property;
            }
            catch {
            }


        }
        private void cb_property_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string s_property = cb_obj_type.Text + "." + cb_property.Text;
                this.cb_p_desc_ENG.Text = s_property;
                this.cb_p_desc_UA.Text = s_property;
            }
            catch {
            }
        }
        private void cb_add_step_Click(object sender, EventArgs e)
        {
            if (this.tb_step.Text != "") {
                this.lb_steps.Items.Add(this.tb_step.Text);
            }
        }

        public static string FirstCharToLower(string input)
        {
            switch (input)
            {
                case null: throw new ArgumentNullException(nameof(input));
                case "": throw new ArgumentException($"{nameof(input)} cannot be empty", nameof(input));
                default: return input.First().ToString().ToLower() + input.Substring(1);
            }
        }

        private void cb_InsertCreator_Click(object sender, EventArgs e)
        {
            //cb_obj_type
            //lb_cvbs
            //[TextBox tb1 = (TextBox)cls_output_controller._v_get_obj(f, "textBox1");]
            string s_inst_name = this.tb_obj_code_name.Text; //FirstCharToLower(this.cb_obj_type.Text + "1");
            this.lb_cvbs.Items.Add(this.cb_obj_type.Text + " " + this.tb_obj_code_name.Text + " = (" + this.cb_obj_type.Text + ")cls_output_controller._v_get_obj(f, \"" + s_inst_name + "\");");
            //add to tast.php
            string s_obj_type = this.cb_obj_type.Text;
            string s_php_vb_line = "$cls_Task->_add_property(\"<span class=" + @"\" + "\"btn btn-success" + @"\" + "\"> Додати об'єкт </span>" + "\", \"" + "<h5>" + s_obj_type + "</h5>" + "\", \"" + "\");";
            this.lb_cvpb_php.Items.Add(s_php_vb_line);
        }

        private void cb_preview_task_Click_1(object sender, EventArgs e)
        {
            _task_preview();
        }
        private void cb_create_task_Click_1(object sender, EventArgs e)
        {
            _task_create();
        }
        private void lb_cvbs_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                int i_selected = this.lb_cvbs.SelectedIndex;
                this.lb_cvbs.Items.RemoveAt(i_selected);
                this.lb_cvpb_php.Items.RemoveAt(i_selected);
            }
        }
    }
}
