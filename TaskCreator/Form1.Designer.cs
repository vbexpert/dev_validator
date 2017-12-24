namespace TaskCreator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_task_id = new System.Windows.Forms.TextBox();
            this.lbl_TaskId = new System.Windows.Forms.Label();
            this.tb_task_title = new System.Windows.Forms.TextBox();
            this.lbl_task_title = new System.Windows.Forms.Label();
            this.cb_create_task = new System.Windows.Forms.Button();
            this.gb_property = new System.Windows.Forms.GroupBox();
            this.lbl_p_desc = new System.Windows.Forms.Label();
            this.cb_p_desc = new System.Windows.Forms.ComboBox();
            this.cb_add_pvb = new System.Windows.Forms.Button();
            this.lbl_validation_method = new System.Windows.Forms.Label();
            this.cb_validation_method = new System.Windows.Forms.ComboBox();
            this.lbl_p_master_value = new System.Windows.Forms.Label();
            this.lbl_p = new System.Windows.Forms.Label();
            this.cb_master_value = new System.Windows.Forms.ComboBox();
            this.cb_property = new System.Windows.Forms.ComboBox();
            this.lbl_p_type = new System.Windows.Forms.Label();
            this.cb_obj_type = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_pvbs = new System.Windows.Forms.ListBox();
            this.tb_combined_v_line = new System.Windows.Forms.TextBox();
            this.gb_buffers = new System.Windows.Forms.GroupBox();
            this.tb_obj_code_name = new System.Windows.Forms.TextBox();
            this.lbl_final_p = new System.Windows.Forms.Label();
            this.lbl_v_object = new System.Windows.Forms.Label();
            this.gb_property.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_task_id
            // 
            this.tb_task_id.Location = new System.Drawing.Point(12, 8);
            this.tb_task_id.Name = "tb_task_id";
            this.tb_task_id.Size = new System.Drawing.Size(371, 20);
            this.tb_task_id.TabIndex = 0;
            // 
            // lbl_TaskId
            // 
            this.lbl_TaskId.AutoSize = true;
            this.lbl_TaskId.Location = new System.Drawing.Point(389, 11);
            this.lbl_TaskId.Name = "lbl_TaskId";
            this.lbl_TaskId.Size = new System.Drawing.Size(44, 13);
            this.lbl_TaskId.TabIndex = 1;
            this.lbl_TaskId.Text = "- task id";
            // 
            // tb_task_title
            // 
            this.tb_task_title.Location = new System.Drawing.Point(12, 34);
            this.tb_task_title.Name = "tb_task_title";
            this.tb_task_title.Size = new System.Drawing.Size(371, 20);
            this.tb_task_title.TabIndex = 2;
            // 
            // lbl_task_title
            // 
            this.lbl_task_title.AutoSize = true;
            this.lbl_task_title.Location = new System.Drawing.Point(389, 34);
            this.lbl_task_title.Name = "lbl_task_title";
            this.lbl_task_title.Size = new System.Drawing.Size(52, 13);
            this.lbl_task_title.TabIndex = 3;
            this.lbl_task_title.Text = "- task title";
            // 
            // cb_create_task
            // 
            this.cb_create_task.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cb_create_task.Location = new System.Drawing.Point(12, 720);
            this.cb_create_task.Name = "cb_create_task";
            this.cb_create_task.Size = new System.Drawing.Size(451, 30);
            this.cb_create_task.TabIndex = 4;
            this.cb_create_task.Text = "Create Task";
            this.cb_create_task.UseVisualStyleBackColor = true;
            this.cb_create_task.Click += new System.EventHandler(this.cb_create_task_Click);
            // 
            // gb_property
            // 
            this.gb_property.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gb_property.Controls.Add(this.lbl_v_object);
            this.gb_property.Controls.Add(this.lbl_final_p);
            this.gb_property.Controls.Add(this.tb_combined_v_line);
            this.gb_property.Controls.Add(this.tb_obj_code_name);
            this.gb_property.Controls.Add(this.lbl_p_desc);
            this.gb_property.Controls.Add(this.cb_p_desc);
            this.gb_property.Controls.Add(this.cb_add_pvb);
            this.gb_property.Controls.Add(this.lbl_validation_method);
            this.gb_property.Controls.Add(this.cb_validation_method);
            this.gb_property.Controls.Add(this.lbl_p_master_value);
            this.gb_property.Controls.Add(this.lbl_p);
            this.gb_property.Controls.Add(this.cb_master_value);
            this.gb_property.Controls.Add(this.cb_property);
            this.gb_property.Controls.Add(this.lbl_p_type);
            this.gb_property.Controls.Add(this.cb_obj_type);
            this.gb_property.Location = new System.Drawing.Point(12, 60);
            this.gb_property.Name = "gb_property";
            this.gb_property.Size = new System.Drawing.Size(451, 257);
            this.gb_property.TabIndex = 5;
            this.gb_property.TabStop = false;
            this.gb_property.Text = "add property validation block:";
            // 
            // lbl_p_desc
            // 
            this.lbl_p_desc.AutoSize = true;
            this.lbl_p_desc.Location = new System.Drawing.Point(344, 134);
            this.lbl_p_desc.Name = "lbl_p_desc";
            this.lbl_p_desc.Size = new System.Drawing.Size(77, 13);
            this.lbl_p_desc.TabIndex = 12;
            this.lbl_p_desc.Text = "- property desc";
            // 
            // cb_p_desc
            // 
            this.cb_p_desc.FormattingEnabled = true;
            this.cb_p_desc.Location = new System.Drawing.Point(12, 131);
            this.cb_p_desc.Name = "cb_p_desc";
            this.cb_p_desc.Size = new System.Drawing.Size(326, 21);
            this.cb_p_desc.TabIndex = 11;
            // 
            // cb_add_pvb
            // 
            this.cb_add_pvb.Location = new System.Drawing.Point(12, 214);
            this.cb_add_pvb.Name = "cb_add_pvb";
            this.cb_add_pvb.Size = new System.Drawing.Size(429, 30);
            this.cb_add_pvb.TabIndex = 10;
            this.cb_add_pvb.Text = "Add PVB";
            this.cb_add_pvb.UseVisualStyleBackColor = true;
            this.cb_add_pvb.Click += new System.EventHandler(this.cb_add_pvb_Click);
            // 
            // lbl_validation_method
            // 
            this.lbl_validation_method.AutoSize = true;
            this.lbl_validation_method.Location = new System.Drawing.Point(344, 22);
            this.lbl_validation_method.Name = "lbl_validation_method";
            this.lbl_validation_method.Size = new System.Drawing.Size(96, 13);
            this.lbl_validation_method.TabIndex = 9;
            this.lbl_validation_method.Text = "- validation method";
            // 
            // cb_validation_method
            // 
            this.cb_validation_method.FormattingEnabled = true;
            this.cb_validation_method.Items.AddRange(new object[] {
            "_v_parm(obj, s_obj_name, s_controled_value)",
            "_v_obj_exists(obj, s_obj_name)",
            "_v_neg_parm(obj, s_obj_name, s_controled_value)"});
            this.cb_validation_method.Location = new System.Drawing.Point(12, 19);
            this.cb_validation_method.Name = "cb_validation_method";
            this.cb_validation_method.Size = new System.Drawing.Size(326, 21);
            this.cb_validation_method.TabIndex = 8;
            // 
            // lbl_p_master_value
            // 
            this.lbl_p_master_value.AutoSize = true;
            this.lbl_p_master_value.Location = new System.Drawing.Point(344, 161);
            this.lbl_p_master_value.Name = "lbl_p_master_value";
            this.lbl_p_master_value.Size = new System.Drawing.Size(73, 13);
            this.lbl_p_master_value.TabIndex = 6;
            this.lbl_p_master_value.Text = "- master value";
            // 
            // lbl_p
            // 
            this.lbl_p.AutoSize = true;
            this.lbl_p.Location = new System.Drawing.Point(344, 107);
            this.lbl_p.Name = "lbl_p";
            this.lbl_p.Size = new System.Drawing.Size(51, 13);
            this.lbl_p.TabIndex = 5;
            this.lbl_p.Text = "- property";
            // 
            // cb_master_value
            // 
            this.cb_master_value.FormattingEnabled = true;
            this.cb_master_value.Items.AddRange(new object[] {
            "True",
            "False",
            "Програма ",
            "0",
            "1",
            "0.5",
            "50",
            "100"});
            this.cb_master_value.Location = new System.Drawing.Point(12, 158);
            this.cb_master_value.Name = "cb_master_value";
            this.cb_master_value.Size = new System.Drawing.Size(326, 21);
            this.cb_master_value.TabIndex = 4;
            this.cb_master_value.Text = "100";
            // 
            // cb_property
            // 
            this.cb_property.FormattingEnabled = true;
            this.cb_property.Location = new System.Drawing.Point(12, 104);
            this.cb_property.Name = "cb_property";
            this.cb_property.Size = new System.Drawing.Size(326, 21);
            this.cb_property.TabIndex = 3;
            this.cb_property.Text = "Width";
            // 
            // lbl_p_type
            // 
            this.lbl_p_type.AutoSize = true;
            this.lbl_p_type.Location = new System.Drawing.Point(344, 80);
            this.lbl_p_type.Name = "lbl_p_type";
            this.lbl_p_type.Size = new System.Drawing.Size(77, 13);
            this.lbl_p_type.TabIndex = 2;
            this.lbl_p_type.Text = "- obj class type";
            // 
            // cb_obj_type
            // 
            this.cb_obj_type.FormattingEnabled = true;
            this.cb_obj_type.Location = new System.Drawing.Point(176, 77);
            this.cb_obj_type.Name = "cb_obj_type";
            this.cb_obj_type.Size = new System.Drawing.Size(162, 21);
            this.cb_obj_type.TabIndex = 0;
            this.cb_obj_type.Text = "Form";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox2.Location = new System.Drawing.Point(23, 579);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(429, 133);
            this.textBox2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(311, 524);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "t";
            // 
            // lb_pvbs
            // 
            this.lb_pvbs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_pvbs.FormattingEnabled = true;
            this.lb_pvbs.Location = new System.Drawing.Point(41, 566);
            this.lb_pvbs.Name = "lb_pvbs";
            this.lb_pvbs.Size = new System.Drawing.Size(429, 134);
            this.lb_pvbs.TabIndex = 8;
            // 
            // tb_combined_v_line
            // 
            this.tb_combined_v_line.Location = new System.Drawing.Point(12, 185);
            this.tb_combined_v_line.Name = "tb_combined_v_line";
            this.tb_combined_v_line.Size = new System.Drawing.Size(326, 20);
            this.tb_combined_v_line.TabIndex = 9;
            // 
            // gb_buffers
            // 
            this.gb_buffers.Location = new System.Drawing.Point(12, 375);
            this.gb_buffers.Name = "gb_buffers";
            this.gb_buffers.Size = new System.Drawing.Size(451, 119);
            this.gb_buffers.TabIndex = 10;
            this.gb_buffers.TabStop = false;
            this.gb_buffers.Text = "task validation buffers:";
            // 
            // tb_obj_code_name
            // 
            this.tb_obj_code_name.Location = new System.Drawing.Point(12, 77);
            this.tb_obj_code_name.Name = "tb_obj_code_name";
            this.tb_obj_code_name.Size = new System.Drawing.Size(158, 20);
            this.tb_obj_code_name.TabIndex = 13;
            this.tb_obj_code_name.Text = "f";
            // 
            // lbl_final_p
            // 
            this.lbl_final_p.AutoSize = true;
            this.lbl_final_p.Location = new System.Drawing.Point(344, 188);
            this.lbl_final_p.Name = "lbl_final_p";
            this.lbl_final_p.Size = new System.Drawing.Size(61, 13);
            this.lbl_final_p.TabIndex = 14;
            this.lbl_final_p.Text = "- final value";
            // 
            // lbl_v_object
            // 
            this.lbl_v_object.AutoSize = true;
            this.lbl_v_object.Location = new System.Drawing.Point(13, 58);
            this.lbl_v_object.Name = "lbl_v_object";
            this.lbl_v_object.Size = new System.Drawing.Size(87, 13);
            this.lbl_v_object.TabIndex = 15;
            this.lbl_v_object.Text = "validation object:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 762);
            this.Controls.Add(this.gb_buffers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lb_pvbs);
            this.Controls.Add(this.gb_property);
            this.Controls.Add(this.cb_create_task);
            this.Controls.Add(this.lbl_task_title);
            this.Controls.Add(this.tb_task_title);
            this.Controls.Add(this.lbl_TaskId);
            this.Controls.Add(this.tb_task_id);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task Creator:";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb_property.ResumeLayout(false);
            this.gb_property.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_task_id;
        private System.Windows.Forms.Label lbl_TaskId;
        private System.Windows.Forms.TextBox tb_task_title;
        private System.Windows.Forms.Label lbl_task_title;
        private System.Windows.Forms.Button cb_create_task;
        private System.Windows.Forms.GroupBox gb_property;
        private System.Windows.Forms.Label lbl_p_type;
        private System.Windows.Forms.ComboBox cb_obj_type;
        private System.Windows.Forms.ComboBox cb_property;
        private System.Windows.Forms.Label lbl_p_master_value;
        private System.Windows.Forms.Label lbl_p;
        private System.Windows.Forms.ComboBox cb_master_value;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_validation_method;
        private System.Windows.Forms.ComboBox cb_validation_method;
        private System.Windows.Forms.ListBox lb_pvbs;
        private System.Windows.Forms.Button cb_add_pvb;
        private System.Windows.Forms.TextBox tb_combined_v_line;
        private System.Windows.Forms.Label lbl_p_desc;
        private System.Windows.Forms.ComboBox cb_p_desc;
        private System.Windows.Forms.GroupBox gb_buffers;
        private System.Windows.Forms.TextBox tb_obj_code_name;
        private System.Windows.Forms.Label lbl_final_p;
        private System.Windows.Forms.Label lbl_v_object;
    }
}

