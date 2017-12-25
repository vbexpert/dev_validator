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
            this.lbl_p_desc_UA = new System.Windows.Forms.Label();
            this.cb_p_desc_UA = new System.Windows.Forms.ComboBox();
            this.lbl_property_type = new System.Windows.Forms.Label();
            this.lbl_v_object = new System.Windows.Forms.Label();
            this.lbl_final_p = new System.Windows.Forms.Label();
            this.tb_combined_v_line = new System.Windows.Forms.TextBox();
            this.tb_obj_code_name = new System.Windows.Forms.TextBox();
            this.lbl_p_desc_ENG = new System.Windows.Forms.Label();
            this.cb_p_desc_ENG = new System.Windows.Forms.ComboBox();
            this.cb_add_pvb = new System.Windows.Forms.Button();
            this.lbl_validation_method = new System.Windows.Forms.Label();
            this.cb_validation_method = new System.Windows.Forms.ComboBox();
            this.lbl_p_master_value = new System.Windows.Forms.Label();
            this.lbl_p = new System.Windows.Forms.Label();
            this.cb_master_value = new System.Windows.Forms.ComboBox();
            this.cb_property = new System.Windows.Forms.ComboBox();
            this.lbl_p_type = new System.Windows.Forms.Label();
            this.cb_obj_type = new System.Windows.Forms.ComboBox();
            this.tb_sharp_parameters = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_code_txt = new System.Windows.Forms.GroupBox();
            this.tb_task_description = new System.Windows.Forms.TextBox();
            this.lbl_task_student_title = new System.Windows.Forms.Label();
            this.gb_php_validation_block = new System.Windows.Forms.GroupBox();
            this.tb_php_task_file = new System.Windows.Forms.TextBox();
            this.cb_preview_task = new System.Windows.Forms.Button();
            this.gb_task_php = new System.Windows.Forms.GroupBox();
            this.lb_steps = new System.Windows.Forms.ListBox();
            this.lb_cvbs = new System.Windows.Forms.ListBox();
            this.cb_add_step = new System.Windows.Forms.Button();
            this.tb_step = new System.Windows.Forms.TextBox();
            this.lbl_step = new System.Windows.Forms.Label();
            this.lb_cvpb_php = new System.Windows.Forms.ListBox();
            this.gb_property.SuspendLayout();
            this.gb_code_txt.SuspendLayout();
            this.gb_php_validation_block.SuspendLayout();
            this.gb_task_php.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_task_id
            // 
            this.tb_task_id.Location = new System.Drawing.Point(12, 8);
            this.tb_task_id.Name = "tb_task_id";
            this.tb_task_id.Size = new System.Drawing.Size(371, 20);
            this.tb_task_id.TabIndex = 0;
            this.tb_task_id.Text = "00_test_01";
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
            this.tb_task_title.Text = "TestTask_01";
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
            this.cb_create_task.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cb_create_task.Location = new System.Drawing.Point(470, 833);
            this.cb_create_task.Name = "cb_create_task";
            this.cb_create_task.Size = new System.Drawing.Size(453, 36);
            this.cb_create_task.TabIndex = 4;
            this.cb_create_task.Text = "Create Task";
            this.cb_create_task.UseVisualStyleBackColor = true;
            this.cb_create_task.Click += new System.EventHandler(this.cb_create_task_Click);
            // 
            // gb_property
            // 
            this.gb_property.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gb_property.Controls.Add(this.lbl_p_desc_UA);
            this.gb_property.Controls.Add(this.cb_p_desc_UA);
            this.gb_property.Controls.Add(this.lbl_property_type);
            this.gb_property.Controls.Add(this.lbl_v_object);
            this.gb_property.Controls.Add(this.lbl_final_p);
            this.gb_property.Controls.Add(this.tb_combined_v_line);
            this.gb_property.Controls.Add(this.tb_obj_code_name);
            this.gb_property.Controls.Add(this.lbl_p_desc_ENG);
            this.gb_property.Controls.Add(this.cb_p_desc_ENG);
            this.gb_property.Controls.Add(this.cb_add_pvb);
            this.gb_property.Controls.Add(this.lbl_validation_method);
            this.gb_property.Controls.Add(this.cb_validation_method);
            this.gb_property.Controls.Add(this.lbl_p_master_value);
            this.gb_property.Controls.Add(this.lbl_p);
            this.gb_property.Controls.Add(this.cb_master_value);
            this.gb_property.Controls.Add(this.cb_property);
            this.gb_property.Controls.Add(this.lbl_p_type);
            this.gb_property.Controls.Add(this.cb_obj_type);
            this.gb_property.Location = new System.Drawing.Point(12, 87);
            this.gb_property.Name = "gb_property";
            this.gb_property.Size = new System.Drawing.Size(452, 288);
            this.gb_property.TabIndex = 5;
            this.gb_property.TabStop = false;
            this.gb_property.Text = "add property validation block:";
            // 
            // lbl_p_desc_UA
            // 
            this.lbl_p_desc_UA.AutoSize = true;
            this.lbl_p_desc_UA.Location = new System.Drawing.Point(344, 147);
            this.lbl_p_desc_UA.Name = "lbl_p_desc_UA";
            this.lbl_p_desc_UA.Size = new System.Drawing.Size(98, 13);
            this.lbl_p_desc_UA.TabIndex = 18;
            this.lbl_p_desc_UA.Text = "- property desc. UA";
            // 
            // cb_p_desc_UA
            // 
            this.cb_p_desc_UA.FormattingEnabled = true;
            this.cb_p_desc_UA.Location = new System.Drawing.Point(12, 144);
            this.cb_p_desc_UA.Name = "cb_p_desc_UA";
            this.cb_p_desc_UA.Size = new System.Drawing.Size(326, 21);
            this.cb_p_desc_UA.TabIndex = 17;
            this.cb_p_desc_UA.Text = "Опис параметра валідації українською";
            // 
            // lbl_property_type
            // 
            this.lbl_property_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_property_type.Location = new System.Drawing.Point(13, 194);
            this.lbl_property_type.Name = "lbl_property_type";
            this.lbl_property_type.Size = new System.Drawing.Size(157, 18);
            this.lbl_property_type.TabIndex = 16;
            this.lbl_property_type.Text = "[type]";
            this.lbl_property_type.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbl_v_object
            // 
            this.lbl_v_object.AutoSize = true;
            this.lbl_v_object.Location = new System.Drawing.Point(13, 44);
            this.lbl_v_object.Name = "lbl_v_object";
            this.lbl_v_object.Size = new System.Drawing.Size(87, 13);
            this.lbl_v_object.TabIndex = 15;
            this.lbl_v_object.Text = "validation object:";
            // 
            // lbl_final_p
            // 
            this.lbl_final_p.AutoSize = true;
            this.lbl_final_p.Location = new System.Drawing.Point(344, 221);
            this.lbl_final_p.Name = "lbl_final_p";
            this.lbl_final_p.Size = new System.Drawing.Size(61, 13);
            this.lbl_final_p.TabIndex = 14;
            this.lbl_final_p.Text = "- final value";
            // 
            // tb_combined_v_line
            // 
            this.tb_combined_v_line.Location = new System.Drawing.Point(12, 218);
            this.tb_combined_v_line.Name = "tb_combined_v_line";
            this.tb_combined_v_line.Size = new System.Drawing.Size(326, 20);
            this.tb_combined_v_line.TabIndex = 9;
            // 
            // tb_obj_code_name
            // 
            this.tb_obj_code_name.Location = new System.Drawing.Point(12, 63);
            this.tb_obj_code_name.Name = "tb_obj_code_name";
            this.tb_obj_code_name.Size = new System.Drawing.Size(158, 20);
            this.tb_obj_code_name.TabIndex = 13;
            this.tb_obj_code_name.Text = "f";
            // 
            // lbl_p_desc_ENG
            // 
            this.lbl_p_desc_ENG.AutoSize = true;
            this.lbl_p_desc_ENG.Location = new System.Drawing.Point(344, 120);
            this.lbl_p_desc_ENG.Name = "lbl_p_desc_ENG";
            this.lbl_p_desc_ENG.Size = new System.Drawing.Size(106, 13);
            this.lbl_p_desc_ENG.TabIndex = 12;
            this.lbl_p_desc_ENG.Text = "- property desc. ENG";
            // 
            // cb_p_desc_ENG
            // 
            this.cb_p_desc_ENG.FormattingEnabled = true;
            this.cb_p_desc_ENG.Location = new System.Drawing.Point(12, 117);
            this.cb_p_desc_ENG.Name = "cb_p_desc_ENG";
            this.cb_p_desc_ENG.Size = new System.Drawing.Size(326, 21);
            this.cb_p_desc_ENG.TabIndex = 11;
            this.cb_p_desc_ENG.Text = "Validated Parameter in English";
            // 
            // cb_add_pvb
            // 
            this.cb_add_pvb.Location = new System.Drawing.Point(11, 247);
            this.cb_add_pvb.Name = "cb_add_pvb";
            this.cb_add_pvb.Size = new System.Drawing.Size(430, 30);
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
            "_v_parm(obj, s_obj_name, s_controled_value);",
            "_v_obj_exists(obj, s_obj_name);",
            "_v_neg_parm(obj, s_obj_name, s_controled_value);"});
            this.cb_validation_method.Location = new System.Drawing.Point(12, 19);
            this.cb_validation_method.Name = "cb_validation_method";
            this.cb_validation_method.Size = new System.Drawing.Size(326, 21);
            this.cb_validation_method.TabIndex = 8;
            // 
            // lbl_p_master_value
            // 
            this.lbl_p_master_value.AutoSize = true;
            this.lbl_p_master_value.Location = new System.Drawing.Point(344, 194);
            this.lbl_p_master_value.Name = "lbl_p_master_value";
            this.lbl_p_master_value.Size = new System.Drawing.Size(73, 13);
            this.lbl_p_master_value.TabIndex = 6;
            this.lbl_p_master_value.Text = "- master value";
            // 
            // lbl_p
            // 
            this.lbl_p.AutoSize = true;
            this.lbl_p.Location = new System.Drawing.Point(344, 93);
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
            this.cb_master_value.Location = new System.Drawing.Point(176, 191);
            this.cb_master_value.Name = "cb_master_value";
            this.cb_master_value.Size = new System.Drawing.Size(162, 21);
            this.cb_master_value.TabIndex = 4;
            this.cb_master_value.Text = "100";
            // 
            // cb_property
            // 
            this.cb_property.FormattingEnabled = true;
            this.cb_property.Location = new System.Drawing.Point(12, 90);
            this.cb_property.Name = "cb_property";
            this.cb_property.Size = new System.Drawing.Size(326, 21);
            this.cb_property.Sorted = true;
            this.cb_property.TabIndex = 3;
            this.cb_property.Text = "[wait-will-load-automatically]";
            this.cb_property.TextChanged += new System.EventHandler(this.cb_property_TextChanged);
            // 
            // lbl_p_type
            // 
            this.lbl_p_type.AutoSize = true;
            this.lbl_p_type.Location = new System.Drawing.Point(344, 66);
            this.lbl_p_type.Name = "lbl_p_type";
            this.lbl_p_type.Size = new System.Drawing.Size(77, 13);
            this.lbl_p_type.TabIndex = 2;
            this.lbl_p_type.Text = "- obj class type";
            // 
            // cb_obj_type
            // 
            this.cb_obj_type.FormattingEnabled = true;
            this.cb_obj_type.Location = new System.Drawing.Point(176, 63);
            this.cb_obj_type.Name = "cb_obj_type";
            this.cb_obj_type.Size = new System.Drawing.Size(162, 21);
            this.cb_obj_type.Sorted = true;
            this.cb_obj_type.TabIndex = 0;
            this.cb_obj_type.Text = "[select]";
            this.cb_obj_type.TextChanged += new System.EventHandler(this.cb_obj_type_TextChanged);
            // 
            // tb_sharp_parameters
            // 
            this.tb_sharp_parameters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tb_sharp_parameters.Location = new System.Drawing.Point(10, 19);
            this.tb_sharp_parameters.Multiline = true;
            this.tb_sharp_parameters.Name = "tb_sharp_parameters";
            this.tb_sharp_parameters.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_sharp_parameters.Size = new System.Drawing.Size(432, 297);
            this.tb_sharp_parameters.TabIndex = 6;
            this.tb_sharp_parameters.WordWrap = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(311, 687);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "t";
            // 
            // gb_code_txt
            // 
            this.gb_code_txt.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.gb_code_txt.Controls.Add(this.tb_sharp_parameters);
            this.gb_code_txt.Location = new System.Drawing.Point(12, 501);
            this.gb_code_txt.Name = "gb_code_txt";
            this.gb_code_txt.Size = new System.Drawing.Size(452, 326);
            this.gb_code_txt.TabIndex = 10;
            this.gb_code_txt.TabStop = false;
            this.gb_code_txt.Text = "code.txt:";
            // 
            // tb_task_description
            // 
            this.tb_task_description.Location = new System.Drawing.Point(12, 60);
            this.tb_task_description.Name = "tb_task_description";
            this.tb_task_description.Size = new System.Drawing.Size(763, 20);
            this.tb_task_description.TabIndex = 11;
            this.tb_task_description.Text = "Нове классне завдання із кнопкою!";
            // 
            // lbl_task_student_title
            // 
            this.lbl_task_student_title.AutoSize = true;
            this.lbl_task_student_title.Location = new System.Drawing.Point(781, 63);
            this.lbl_task_student_title.Name = "lbl_task_student_title";
            this.lbl_task_student_title.Size = new System.Drawing.Size(92, 13);
            this.lbl_task_student_title.TabIndex = 12;
            this.lbl_task_student_title.Text = "- task title in Index";
            // 
            // gb_php_validation_block
            // 
            this.gb_php_validation_block.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.gb_php_validation_block.Controls.Add(this.tb_php_task_file);
            this.gb_php_validation_block.Location = new System.Drawing.Point(470, 501);
            this.gb_php_validation_block.Name = "gb_php_validation_block";
            this.gb_php_validation_block.Size = new System.Drawing.Size(452, 326);
            this.gb_php_validation_block.TabIndex = 13;
            this.gb_php_validation_block.TabStop = false;
            this.gb_php_validation_block.Text = "task.php";
            // 
            // tb_php_task_file
            // 
            this.tb_php_task_file.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tb_php_task_file.Location = new System.Drawing.Point(9, 19);
            this.tb_php_task_file.Multiline = true;
            this.tb_php_task_file.Name = "tb_php_task_file";
            this.tb_php_task_file.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_php_task_file.Size = new System.Drawing.Size(432, 297);
            this.tb_php_task_file.TabIndex = 7;
            this.tb_php_task_file.WordWrap = false;
            // 
            // cb_preview_task
            // 
            this.cb_preview_task.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cb_preview_task.Location = new System.Drawing.Point(22, 833);
            this.cb_preview_task.Name = "cb_preview_task";
            this.cb_preview_task.Size = new System.Drawing.Size(443, 36);
            this.cb_preview_task.TabIndex = 14;
            this.cb_preview_task.Text = "Preview Task";
            this.cb_preview_task.UseVisualStyleBackColor = true;
            this.cb_preview_task.Click += new System.EventHandler(this.cb_preview_task_Click);
            // 
            // gb_task_php
            // 
            this.gb_task_php.Controls.Add(this.lbl_step);
            this.gb_task_php.Controls.Add(this.tb_step);
            this.gb_task_php.Controls.Add(this.cb_add_step);
            this.gb_task_php.Controls.Add(this.lb_steps);
            this.gb_task_php.Location = new System.Drawing.Point(470, 87);
            this.gb_task_php.Name = "gb_task_php";
            this.gb_task_php.Size = new System.Drawing.Size(449, 288);
            this.gb_task_php.TabIndex = 15;
            this.gb_task_php.TabStop = false;
            this.gb_task_php.Text = "task steps:";
            // 
            // lb_steps
            // 
            this.lb_steps.FormattingEnabled = true;
            this.lb_steps.Location = new System.Drawing.Point(10, 130);
            this.lb_steps.Name = "lb_steps";
            this.lb_steps.Size = new System.Drawing.Size(427, 108);
            this.lb_steps.TabIndex = 16;
            // 
            // lb_cvbs
            // 
            this.lb_cvbs.FormattingEnabled = true;
            this.lb_cvbs.Location = new System.Drawing.Point(22, 384);
            this.lb_cvbs.Name = "lb_cvbs";
            this.lb_cvbs.ScrollAlwaysVisible = true;
            this.lb_cvbs.Size = new System.Drawing.Size(432, 108);
            this.lb_cvbs.TabIndex = 17;
            // 
            // cb_add_step
            // 
            this.cb_add_step.Location = new System.Drawing.Point(9, 247);
            this.cb_add_step.Name = "cb_add_step";
            this.cb_add_step.Size = new System.Drawing.Size(430, 30);
            this.cb_add_step.TabIndex = 0;
            this.cb_add_step.Text = "Add step";
            this.cb_add_step.UseVisualStyleBackColor = true;
            this.cb_add_step.Click += new System.EventHandler(this.cb_add_step_Click);
            // 
            // tb_step
            // 
            this.tb_step.Location = new System.Drawing.Point(10, 90);
            this.tb_step.Name = "tb_step";
            this.tb_step.Size = new System.Drawing.Size(427, 20);
            this.tb_step.TabIndex = 17;
            this.tb_step.Text = "Детальний опис крока - українською!";
            // 
            // lbl_step
            // 
            this.lbl_step.AutoSize = true;
            this.lbl_step.Location = new System.Drawing.Point(12, 66);
            this.lbl_step.Name = "lbl_step";
            this.lbl_step.Size = new System.Drawing.Size(97, 13);
            this.lbl_step.TabIndex = 18;
            this.lbl_step.Text = "step (no numbers!):";
            // 
            // lb_cvpb_php
            // 
            this.lb_cvpb_php.FormattingEnabled = true;
            this.lb_cvpb_php.Location = new System.Drawing.Point(480, 384);
            this.lb_cvpb_php.Name = "lb_cvpb_php";
            this.lb_cvpb_php.ScrollAlwaysVisible = true;
            this.lb_cvpb_php.Size = new System.Drawing.Size(432, 108);
            this.lb_cvpb_php.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 877);
            this.Controls.Add(this.lb_cvpb_php);
            this.Controls.Add(this.lb_cvbs);
            this.Controls.Add(this.gb_task_php);
            this.Controls.Add(this.cb_preview_task);
            this.Controls.Add(this.gb_php_validation_block);
            this.Controls.Add(this.lbl_task_student_title);
            this.Controls.Add(this.tb_task_description);
            this.Controls.Add(this.gb_code_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gb_property);
            this.Controls.Add(this.cb_create_task);
            this.Controls.Add(this.lbl_task_title);
            this.Controls.Add(this.tb_task_title);
            this.Controls.Add(this.lbl_TaskId);
            this.Controls.Add(this.tb_task_id);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task Creator v. 01";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb_property.ResumeLayout(false);
            this.gb_property.PerformLayout();
            this.gb_code_txt.ResumeLayout(false);
            this.gb_code_txt.PerformLayout();
            this.gb_php_validation_block.ResumeLayout(false);
            this.gb_php_validation_block.PerformLayout();
            this.gb_task_php.ResumeLayout(false);
            this.gb_task_php.PerformLayout();
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
        private System.Windows.Forms.TextBox tb_sharp_parameters;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_validation_method;
        private System.Windows.Forms.ComboBox cb_validation_method;
        private System.Windows.Forms.Button cb_add_pvb;
        private System.Windows.Forms.TextBox tb_combined_v_line;
        private System.Windows.Forms.Label lbl_p_desc_ENG;
        private System.Windows.Forms.ComboBox cb_p_desc_ENG;
        private System.Windows.Forms.GroupBox gb_code_txt;
        private System.Windows.Forms.TextBox tb_obj_code_name;
        private System.Windows.Forms.Label lbl_final_p;
        private System.Windows.Forms.Label lbl_v_object;
        private System.Windows.Forms.TextBox tb_task_description;
        private System.Windows.Forms.Label lbl_task_student_title;
        private System.Windows.Forms.GroupBox gb_php_validation_block;
        private System.Windows.Forms.TextBox tb_php_task_file;
        private System.Windows.Forms.Button cb_preview_task;
        private System.Windows.Forms.Label lbl_property_type;
        private System.Windows.Forms.Label lbl_p_desc_UA;
        private System.Windows.Forms.ComboBox cb_p_desc_UA;
        private System.Windows.Forms.GroupBox gb_task_php;
        private System.Windows.Forms.ListBox lb_steps;
        private System.Windows.Forms.ListBox lb_cvbs;
        private System.Windows.Forms.Button cb_add_step;
        private System.Windows.Forms.TextBox tb_step;
        private System.Windows.Forms.Label lbl_step;
        private System.Windows.Forms.ListBox lb_cvpb_php;
    }
}

