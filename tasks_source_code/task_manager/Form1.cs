using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace task_manager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //load list from text file
        private void _Load_Items_From_File(string list_file, ListBox lb)
        {
            string line;
            var file = new System.IO.StreamReader(list_file);
            while ((line = file.ReadLine()) != null)
            {
                lb.Items.Add(line);
            }

        }
        //save profile
        private void _Save_File(object sender, EventArgs e, string sPath )
        {
            

            System.IO.StreamWriter obj_StreamWriter = new System.IO.StreamWriter(sPath);
            foreach (var item in lb_Task.Items)
            {
                obj_StreamWriter.WriteLine(item.ToString());
            }
            obj_StreamWriter.Close();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //load controls list from file 
            _Load_Items_From_File("input_controls.txt", lb_Controls);


            //load properties list from file
            _Load_Items_From_File("input_prorerties.txt", lb_Properties);

            //load properties_ua list from file
            //_Load_Items_From_File("input_prorerties_ua.txt", lb_PropertiesTranslate);

            //load from file better then _Load_Items_From_File
            lb_PropertiesTranslate.Items.AddRange(System.IO.File.ReadAllLines(@"input_prorerties_ua.txt"));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //r
            lb_Task.Items.Add("		<!-- " + lb_Controls.SelectedItem + " -->");
            int count = lb_OneItemTask.Items.Count;
            int i = 0;
            while(i<count)
            {
                lb_Task.Items.Add(lb_OneItemTask.Items[i]);
                i++;
            }
                     
            lb_Task.Items.Add("		</table>");
            lb_Task.Items.Add("");
            lb_OneItemTask.Items.Clear();
            lb_Controls.Enabled = true;


        }

        private void btn_SaveTask_Click(object sender, EventArgs e)
        {
            _Save_File(null,null,"task.html");
        }

        private void lb_Controls_SelectedIndexChanged(object sender, EventArgs e)
        {
            // lb_OneItemTask.Items.Add(lb_OneItemTask.Text+lb_Controls.SelectedItem);
            const string quote = "\"";
            lb_OneItemTask.Items.Add("		<table style=" + quote + "width: 100%" + quote + " class=" + quote + "table table-striped table-condensed" + quote + ">");
            lb_OneItemTask.Items.Add("		<caption style=" + quote + "caption-side: top" + quote + ">" + lb_Controls.SelectedItem + "</caption>");
            lb_OneItemTask.Items.Add(" 		 <thead>");
            lb_OneItemTask.Items.Add("		  <tr>");
            lb_OneItemTask.Items.Add("		   <th>Properties</th>");
            lb_OneItemTask.Items.Add("		   <th>Властивість</th>");
            lb_OneItemTask.Items.Add("		   <th>Значення</th>");
            lb_OneItemTask.Items.Add("		   <th>Стан</th>");
            lb_OneItemTask.Items.Add("		  </tr>");
            lb_OneItemTask.Items.Add("		 </thead>");
            lb_Controls.Enabled = false;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_AddOneItemTask_Click(object sender, EventArgs e)
        {
            const string quote = "\"";
            lb_OneItemTask.Items.Add("		  <tr>");
            lb_OneItemTask.Items.Add("		   <td>" + lb_Properties.SelectedItem + "</td>");
            lb_OneItemTask.Items.Add("		   <td>" + lb_PropertiesTranslate.SelectedItem + "</td>");
            lb_OneItemTask.Items.Add("		   <td><b>" + tb_Value.Text + "</b></td>");
            lb_OneItemTask.Items.Add("		   <td><input type=" + quote + "checkbox" + quote + " value=" + quote + "" + quote + "></td>");
            lb_OneItemTask.Items.Add("		  </tr>");
            

        }
        private void btn_AddOneItemCode_Click(object sender, EventArgs e)
        {
            lb_OneItemCode.Items.Add("//"+lb_Controls.SelectedItem + "."+ lb_Properties.SelectedItem +"  "+ lb_PropertiesTranslate.SelectedItem);
            lb_OneItemCode.Items.Add("if (" + lb_Controls.SelectedItem + "." + lb_Properties.SelectedItem + "==" + tb_Value + ")");
            lb_OneItemCode.Items.Add("{" );
            lb_OneItemCode.Items.Add("    cls_output_controller._add_validation_ok("+ lb_Controls.SelectedItem + "." + lb_Properties.SelectedItem + "OK! "+", 20)");
            lb_OneItemCode.Items.Add("}" );


        }

        private void lb_Properties_SelectedIndexChanged(object sender, EventArgs e)
        {
            lb_PropertiesTranslate.SelectedIndex = lb_Properties.SelectedIndex;
            tb_Value.Text = "";
            tb_Value.Focus();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}
