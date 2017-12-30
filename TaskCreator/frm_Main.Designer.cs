namespace TaskCreator
{
    partial class frm_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Main));
            this.lbl_task_title = new System.Windows.Forms.Label();
            this.lbl_task_student_title = new System.Windows.Forms.Label();
            this.tb_task_id = new System.Windows.Forms.TextBox();
            this.lbl_TaskId = new System.Windows.Forms.Label();
            this.tb_task_title = new System.Windows.Forms.TextBox();
            this.tb_task_description = new System.Windows.Forms.TextBox();
            this.tb_php_task_file = new System.Windows.Forms.TextBox();
            this.cb_create_task = new System.Windows.Forms.Button();
            this.lb_cvpb_php = new System.Windows.Forms.ListBox();
            this.gb_php_validation_block = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_cvbs = new System.Windows.Forms.ListBox();
            this.tb_sharp_parameters = new System.Windows.Forms.TextBox();
            this.cb_preview_task = new System.Windows.Forms.Button();
            this.gb_code_txt = new System.Windows.Forms.GroupBox();
            this.lb_steps = new System.Windows.Forms.ListBox();
            this.cb_add_step = new System.Windows.Forms.Button();
            this.tb_step = new System.Windows.Forms.TextBox();
            this.gb_task_php = new System.Windows.Forms.GroupBox();
            this.cb_add_standard_steps = new System.Windows.Forms.Button();
            this.lbl_step = new System.Windows.Forms.Label();
            this.cb_obj_type = new System.Windows.Forms.ComboBox();
            this.lbl_p_type = new System.Windows.Forms.Label();
            this.cb_property = new System.Windows.Forms.ComboBox();
            this.cb_master_value = new System.Windows.Forms.ComboBox();
            this.lbl_p = new System.Windows.Forms.Label();
            this.lbl_p_master_value = new System.Windows.Forms.Label();
            this.cb_validation_method = new System.Windows.Forms.ComboBox();
            this.lbl_validation_method = new System.Windows.Forms.Label();
            this.cb_add_pvb = new System.Windows.Forms.Button();
            this.cb_p_desc_ENG = new System.Windows.Forms.ComboBox();
            this.lbl_p_desc_ENG = new System.Windows.Forms.Label();
            this.tb_obj_instance = new System.Windows.Forms.TextBox();
            this.lbl_v_object = new System.Windows.Forms.Label();
            this.cb_p_desc_UA = new System.Windows.Forms.ComboBox();
            this.lbl_p_desc_UA = new System.Windows.Forms.Label();
            this.gb_property = new System.Windows.Forms.GroupBox();
            this.cb_obj_events = new System.Windows.Forms.ComboBox();
            this.cb_code = new System.Windows.Forms.Button();
            this.cb_insert_image = new System.Windows.Forms.Button();
            this.cb_insert_obj_event = new System.Windows.Forms.Button();
            this.cb_insert_obj_accessor = new System.Windows.Forms.Button();
            this.tb_image = new System.Windows.Forms.TextBox();
            this.tb_code = new System.Windows.Forms.TextBox();
            this.gb_php_validation_block.SuspendLayout();
            this.gb_code_txt.SuspendLayout();
            this.gb_task_php.SuspendLayout();
            this.gb_property.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_task_title
            // 
            this.lbl_task_title.AutoSize = true;
            this.lbl_task_title.Location = new System.Drawing.Point(830, 11);
            this.lbl_task_title.Name = "lbl_task_title";
            this.lbl_task_title.Size = new System.Drawing.Size(52, 13);
            this.lbl_task_title.TabIndex = 3;
            this.lbl_task_title.Text = "- task title";
            // 
            // lbl_task_student_title
            // 
            this.lbl_task_student_title.AutoSize = true;
            this.lbl_task_student_title.Location = new System.Drawing.Point(830, 35);
            this.lbl_task_student_title.Name = "lbl_task_student_title";
            this.lbl_task_student_title.Size = new System.Drawing.Size(92, 13);
            this.lbl_task_student_title.TabIndex = 12;
            this.lbl_task_student_title.Text = "- task title in Index";
            // 
            // tb_task_id
            // 
            this.tb_task_id.Location = new System.Drawing.Point(12, 8);
            this.tb_task_id.Name = "tb_task_id";
            this.tb_task_id.Size = new System.Drawing.Size(338, 20);
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
            this.tb_task_title.Location = new System.Drawing.Point(485, 8);
            this.tb_task_title.Name = "tb_task_title";
            this.tb_task_title.Size = new System.Drawing.Size(338, 20);
            this.tb_task_title.TabIndex = 2;
            this.tb_task_title.Text = "TestTask_01";
            // 
            // tb_task_description
            // 
            this.tb_task_description.Location = new System.Drawing.Point(12, 32);
            this.tb_task_description.Name = "tb_task_description";
            this.tb_task_description.Size = new System.Drawing.Size(811, 20);
            this.tb_task_description.TabIndex = 11;
            this.tb_task_description.Text = "[test] Нове классне завдання із кнопкою!";
            // 
            // tb_php_task_file
            // 
            this.tb_php_task_file.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tb_php_task_file.Location = new System.Drawing.Point(9, 170);
            this.tb_php_task_file.Multiline = true;
            this.tb_php_task_file.Name = "tb_php_task_file";
            this.tb_php_task_file.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_php_task_file.Size = new System.Drawing.Size(432, 150);
            this.tb_php_task_file.TabIndex = 7;
            this.tb_php_task_file.WordWrap = false;
            // 
            // cb_create_task
            // 
            this.cb_create_task.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cb_create_task.Location = new System.Drawing.Point(8, 326);
            this.cb_create_task.Name = "cb_create_task";
            this.cb_create_task.Size = new System.Drawing.Size(433, 36);
            this.cb_create_task.TabIndex = 8;
            this.cb_create_task.Text = "Create Task";
            this.cb_create_task.UseVisualStyleBackColor = true;
            this.cb_create_task.Click += new System.EventHandler(this.cb_create_task_Click_1);
            // 
            // lb_cvpb_php
            // 
            this.lb_cvpb_php.FormattingEnabled = true;
            this.lb_cvpb_php.Location = new System.Drawing.Point(9, 16);
            this.lb_cvpb_php.Name = "lb_cvpb_php";
            this.lb_cvpb_php.ScrollAlwaysVisible = true;
            this.lb_cvpb_php.Size = new System.Drawing.Size(432, 160);
            this.lb_cvpb_php.TabIndex = 18;
            this.lb_cvpb_php.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lb_cvpb_php_KeyDown);
            // 
            // gb_php_validation_block
            // 
            this.gb_php_validation_block.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gb_php_validation_block.Controls.Add(this.lb_cvpb_php);
            this.gb_php_validation_block.Controls.Add(this.tb_php_task_file);
            this.gb_php_validation_block.Controls.Add(this.cb_create_task);
            this.gb_php_validation_block.Location = new System.Drawing.Point(471, 365);
            this.gb_php_validation_block.Name = "gb_php_validation_block";
            this.gb_php_validation_block.Size = new System.Drawing.Size(451, 371);
            this.gb_php_validation_block.TabIndex = 13;
            this.gb_php_validation_block.TabStop = false;
            this.gb_php_validation_block.Text = "task.php [press F4 to Edit Property Manually]:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(311, 553);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "t";
            // 
            // lb_cvbs
            // 
            this.lb_cvbs.AllowDrop = true;
            this.lb_cvbs.FormattingEnabled = true;
            this.lb_cvbs.Location = new System.Drawing.Point(10, 16);
            this.lb_cvbs.Name = "lb_cvbs";
            this.lb_cvbs.ScrollAlwaysVisible = true;
            this.lb_cvbs.Size = new System.Drawing.Size(432, 160);
            this.lb_cvbs.TabIndex = 17;
            this.lb_cvbs.DragDrop += new System.Windows.Forms.DragEventHandler(this.lb_cvbs_DragDrop);
            this.lb_cvbs.DragOver += new System.Windows.Forms.DragEventHandler(this.lb_cvbs_DragOver);
            this.lb_cvbs.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lb_cvbs_KeyDown);
            this.lb_cvbs.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lb_cvbs_MouseDown);
            // 
            // tb_sharp_parameters
            // 
            this.tb_sharp_parameters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tb_sharp_parameters.Location = new System.Drawing.Point(10, 170);
            this.tb_sharp_parameters.Multiline = true;
            this.tb_sharp_parameters.Name = "tb_sharp_parameters";
            this.tb_sharp_parameters.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_sharp_parameters.Size = new System.Drawing.Size(432, 150);
            this.tb_sharp_parameters.TabIndex = 6;
            this.tb_sharp_parameters.WordWrap = false;
            // 
            // cb_preview_task
            // 
            this.cb_preview_task.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cb_preview_task.Location = new System.Drawing.Point(9, 326);
            this.cb_preview_task.Name = "cb_preview_task";
            this.cb_preview_task.Size = new System.Drawing.Size(434, 36);
            this.cb_preview_task.TabIndex = 18;
            this.cb_preview_task.Text = "Preview Task";
            this.cb_preview_task.UseVisualStyleBackColor = true;
            this.cb_preview_task.Click += new System.EventHandler(this.cb_preview_task_Click_1);
            // 
            // gb_code_txt
            // 
            this.gb_code_txt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gb_code_txt.Controls.Add(this.lb_cvbs);
            this.gb_code_txt.Controls.Add(this.cb_preview_task);
            this.gb_code_txt.Controls.Add(this.tb_sharp_parameters);
            this.gb_code_txt.Location = new System.Drawing.Point(13, 365);
            this.gb_code_txt.Name = "gb_code_txt";
            this.gb_code_txt.Size = new System.Drawing.Size(452, 371);
            this.gb_code_txt.TabIndex = 10;
            this.gb_code_txt.TabStop = false;
            this.gb_code_txt.Text = "code.txt [press F4 to Edit Property Manually]:";
            // 
            // lb_steps
            // 
            this.lb_steps.FormattingEnabled = true;
            this.lb_steps.Location = new System.Drawing.Point(6, 60);
            this.lb_steps.Name = "lb_steps";
            this.lb_steps.Size = new System.Drawing.Size(432, 108);
            this.lb_steps.TabIndex = 16;
            this.lb_steps.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lb_steps_KeyDown);
            // 
            // cb_add_step
            // 
            this.cb_add_step.Location = new System.Drawing.Point(6, 174);
            this.cb_add_step.Name = "cb_add_step";
            this.cb_add_step.Size = new System.Drawing.Size(433, 30);
            this.cb_add_step.TabIndex = 0;
            this.cb_add_step.Text = "Add step";
            this.cb_add_step.UseVisualStyleBackColor = true;
            this.cb_add_step.Click += new System.EventHandler(this.cb_add_step_Click);
            // 
            // tb_step
            // 
            this.tb_step.Location = new System.Drawing.Point(6, 37);
            this.tb_step.Name = "tb_step";
            this.tb_step.Size = new System.Drawing.Size(432, 20);
            this.tb_step.TabIndex = 17;
            this.tb_step.Text = "Детальний опис крока - українською!";
            // 
            // gb_task_php
            // 
            this.gb_task_php.Controls.Add(this.cb_add_standard_steps);
            this.gb_task_php.Controls.Add(this.lbl_step);
            this.gb_task_php.Controls.Add(this.tb_step);
            this.gb_task_php.Controls.Add(this.cb_add_step);
            this.gb_task_php.Controls.Add(this.lb_steps);
            this.gb_task_php.Location = new System.Drawing.Point(473, 71);
            this.gb_task_php.Name = "gb_task_php";
            this.gb_task_php.Size = new System.Drawing.Size(449, 288);
            this.gb_task_php.TabIndex = 15;
            this.gb_task_php.TabStop = false;
            this.gb_task_php.Text = "task steps: [press F4 to Edit Property Manually]:";
            // 
            // cb_add_standard_steps
            // 
            this.cb_add_standard_steps.Location = new System.Drawing.Point(6, 247);
            this.cb_add_standard_steps.Name = "cb_add_standard_steps";
            this.cb_add_standard_steps.Size = new System.Drawing.Size(433, 30);
            this.cb_add_standard_steps.TabIndex = 19;
            this.cb_add_standard_steps.Text = "Add Standard Block";
            this.cb_add_standard_steps.UseVisualStyleBackColor = true;
            this.cb_add_standard_steps.Click += new System.EventHandler(this.cb_add_standard_steps_Click);
            // 
            // lbl_step
            // 
            this.lbl_step.AutoSize = true;
            this.lbl_step.Location = new System.Drawing.Point(11, 18);
            this.lbl_step.Name = "lbl_step";
            this.lbl_step.Size = new System.Drawing.Size(97, 13);
            this.lbl_step.TabIndex = 18;
            this.lbl_step.Text = "step (no numbers!):";
            // 
            // cb_obj_type
            // 
            this.cb_obj_type.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cb_obj_type.FormattingEnabled = true;
            this.cb_obj_type.Location = new System.Drawing.Point(12, 60);
            this.cb_obj_type.Name = "cb_obj_type";
            this.cb_obj_type.Size = new System.Drawing.Size(92, 21);
            this.cb_obj_type.Sorted = true;
            this.cb_obj_type.TabIndex = 0;
            this.cb_obj_type.Text = "[select]";
            this.cb_obj_type.TextChanged += new System.EventHandler(this.cb_obj_type_TextChanged);
            // 
            // lbl_p_type
            // 
            this.lbl_p_type.AutoSize = true;
            this.lbl_p_type.Location = new System.Drawing.Point(12, 43);
            this.lbl_p_type.Name = "lbl_p_type";
            this.lbl_p_type.Size = new System.Drawing.Size(34, 13);
            this.lbl_p_type.TabIndex = 2;
            this.lbl_p_type.Text = "class:";
            // 
            // cb_property
            // 
            this.cb_property.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.cb_property.FormattingEnabled = true;
            this.cb_property.Location = new System.Drawing.Point(203, 60);
            this.cb_property.Name = "cb_property";
            this.cb_property.Size = new System.Drawing.Size(135, 21);
            this.cb_property.Sorted = true;
            this.cb_property.TabIndex = 3;
            this.cb_property.Text = "[wait-will-load-automatically]";
            this.cb_property.TextChanged += new System.EventHandler(this.cb_property_TextChanged);
            // 
            // cb_master_value
            // 
            this.cb_master_value.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
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
            this.cb_master_value.Location = new System.Drawing.Point(342, 60);
            this.cb_master_value.Name = "cb_master_value";
            this.cb_master_value.Size = new System.Drawing.Size(98, 21);
            this.cb_master_value.TabIndex = 4;
            this.cb_master_value.Text = "400";
            // 
            // lbl_p
            // 
            this.lbl_p.AutoSize = true;
            this.lbl_p.Location = new System.Drawing.Point(205, 43);
            this.lbl_p.Name = "lbl_p";
            this.lbl_p.Size = new System.Drawing.Size(48, 13);
            this.lbl_p.TabIndex = 5;
            this.lbl_p.Text = "property:";
            // 
            // lbl_p_master_value
            // 
            this.lbl_p_master_value.AutoSize = true;
            this.lbl_p_master_value.Location = new System.Drawing.Point(344, 43);
            this.lbl_p_master_value.Name = "lbl_p_master_value";
            this.lbl_p_master_value.Size = new System.Drawing.Size(36, 13);
            this.lbl_p_master_value.TabIndex = 6;
            this.lbl_p_master_value.Text = "value:";
            // 
            // cb_validation_method
            // 
            this.cb_validation_method.FormattingEnabled = true;
            this.cb_validation_method.Items.AddRange(new object[] {
            "_v_parm([obj], s_obj_name, s_controled_value);",
            "_v_obj_exists([obj], s_obj_name);",
            "_v_neg_parm([obj], s_obj_name, s_controled_value);"});
            this.cb_validation_method.Location = new System.Drawing.Point(12, 20);
            this.cb_validation_method.Name = "cb_validation_method";
            this.cb_validation_method.Size = new System.Drawing.Size(326, 21);
            this.cb_validation_method.TabIndex = 8;
            // 
            // lbl_validation_method
            // 
            this.lbl_validation_method.AutoSize = true;
            this.lbl_validation_method.Location = new System.Drawing.Point(344, 23);
            this.lbl_validation_method.Name = "lbl_validation_method";
            this.lbl_validation_method.Size = new System.Drawing.Size(96, 13);
            this.lbl_validation_method.TabIndex = 9;
            this.lbl_validation_method.Text = "- validation method";
            // 
            // cb_add_pvb
            // 
            this.cb_add_pvb.Location = new System.Drawing.Point(11, 247);
            this.cb_add_pvb.Name = "cb_add_pvb";
            this.cb_add_pvb.Size = new System.Drawing.Size(430, 30);
            this.cb_add_pvb.TabIndex = 10;
            this.cb_add_pvb.Text = "Add PVB - (Property Validation Block)";
            this.cb_add_pvb.UseVisualStyleBackColor = true;
            this.cb_add_pvb.Click += new System.EventHandler(this.cb_add_pvb_Click);
            // 
            // cb_p_desc_ENG
            // 
            this.cb_p_desc_ENG.FormattingEnabled = true;
            this.cb_p_desc_ENG.Location = new System.Drawing.Point(12, 85);
            this.cb_p_desc_ENG.Name = "cb_p_desc_ENG";
            this.cb_p_desc_ENG.Size = new System.Drawing.Size(326, 21);
            this.cb_p_desc_ENG.TabIndex = 11;
            this.cb_p_desc_ENG.Text = "Validated Parameter in English";
            // 
            // lbl_p_desc_ENG
            // 
            this.lbl_p_desc_ENG.AutoSize = true;
            this.lbl_p_desc_ENG.Location = new System.Drawing.Point(342, 88);
            this.lbl_p_desc_ENG.Name = "lbl_p_desc_ENG";
            this.lbl_p_desc_ENG.Size = new System.Drawing.Size(106, 13);
            this.lbl_p_desc_ENG.TabIndex = 12;
            this.lbl_p_desc_ENG.Text = "- property desc. ENG";
            // 
            // tb_obj_instance
            // 
            this.tb_obj_instance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.tb_obj_instance.Location = new System.Drawing.Point(109, 60);
            this.tb_obj_instance.Name = "tb_obj_instance";
            this.tb_obj_instance.Size = new System.Drawing.Size(88, 20);
            this.tb_obj_instance.TabIndex = 13;
            this.tb_obj_instance.Text = "f";
            // 
            // lbl_v_object
            // 
            this.lbl_v_object.AutoSize = true;
            this.lbl_v_object.Location = new System.Drawing.Point(110, 43);
            this.lbl_v_object.Name = "lbl_v_object";
            this.lbl_v_object.Size = new System.Drawing.Size(50, 13);
            this.lbl_v_object.TabIndex = 15;
            this.lbl_v_object.Text = "instance:";
            // 
            // cb_p_desc_UA
            // 
            this.cb_p_desc_UA.FormattingEnabled = true;
            this.cb_p_desc_UA.Location = new System.Drawing.Point(12, 108);
            this.cb_p_desc_UA.Name = "cb_p_desc_UA";
            this.cb_p_desc_UA.Size = new System.Drawing.Size(326, 21);
            this.cb_p_desc_UA.TabIndex = 17;
            this.cb_p_desc_UA.Text = "Опис параметра валідації українською";
            // 
            // lbl_p_desc_UA
            // 
            this.lbl_p_desc_UA.AutoSize = true;
            this.lbl_p_desc_UA.Location = new System.Drawing.Point(342, 111);
            this.lbl_p_desc_UA.Name = "lbl_p_desc_UA";
            this.lbl_p_desc_UA.Size = new System.Drawing.Size(98, 13);
            this.lbl_p_desc_UA.TabIndex = 18;
            this.lbl_p_desc_UA.Text = "- property desc. UA";
            // 
            // gb_property
            // 
            this.gb_property.Controls.Add(this.tb_code);
            this.gb_property.Controls.Add(this.tb_image);
            this.gb_property.Controls.Add(this.cb_obj_events);
            this.gb_property.Controls.Add(this.cb_code);
            this.gb_property.Controls.Add(this.cb_insert_image);
            this.gb_property.Controls.Add(this.cb_insert_obj_event);
            this.gb_property.Controls.Add(this.cb_insert_obj_accessor);
            this.gb_property.Controls.Add(this.lbl_p_desc_UA);
            this.gb_property.Controls.Add(this.cb_p_desc_UA);
            this.gb_property.Controls.Add(this.lbl_v_object);
            this.gb_property.Controls.Add(this.tb_obj_instance);
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
            this.gb_property.Location = new System.Drawing.Point(12, 71);
            this.gb_property.Name = "gb_property";
            this.gb_property.Size = new System.Drawing.Size(452, 288);
            this.gb_property.TabIndex = 5;
            this.gb_property.TabStop = false;
            this.gb_property.Text = "+ image line";
            // 
            // cb_obj_events
            // 
            this.cb_obj_events.FormattingEnabled = true;
            this.cb_obj_events.Location = new System.Drawing.Point(12, 163);
            this.cb_obj_events.Name = "cb_obj_events";
            this.cb_obj_events.Size = new System.Drawing.Size(192, 21);
            this.cb_obj_events.Sorted = true;
            this.cb_obj_events.TabIndex = 23;
            this.cb_obj_events.Text = "[will autopop]";
            // 
            // cb_code
            // 
            this.cb_code.Location = new System.Drawing.Point(210, 213);
            this.cb_code.Name = "cb_code";
            this.cb_code.Size = new System.Drawing.Size(128, 25);
            this.cb_code.TabIndex = 22;
            this.cb_code.Text = "+ highlighted code";
            this.cb_code.UseVisualStyleBackColor = true;
            this.cb_code.Click += new System.EventHandler(this.cb_code_Click);
            // 
            // cb_insert_image
            // 
            this.cb_insert_image.Location = new System.Drawing.Point(210, 187);
            this.cb_insert_image.Name = "cb_insert_image";
            this.cb_insert_image.Size = new System.Drawing.Size(128, 25);
            this.cb_insert_image.TabIndex = 21;
            this.cb_insert_image.Text = "+ image";
            this.cb_insert_image.UseVisualStyleBackColor = true;
            this.cb_insert_image.Click += new System.EventHandler(this.cb_insert_image_Click);
            // 
            // cb_insert_obj_event
            // 
            this.cb_insert_obj_event.Location = new System.Drawing.Point(210, 161);
            this.cb_insert_obj_event.Name = "cb_insert_obj_event";
            this.cb_insert_obj_event.Size = new System.Drawing.Size(128, 25);
            this.cb_insert_obj_event.TabIndex = 20;
            this.cb_insert_obj_event.Text = "+ obj. event caller";
            this.cb_insert_obj_event.UseVisualStyleBackColor = true;
            this.cb_insert_obj_event.Click += new System.EventHandler(this.cb_insert_obj_event_Click);
            // 
            // cb_insert_obj_accessor
            // 
            this.cb_insert_obj_accessor.Location = new System.Drawing.Point(210, 135);
            this.cb_insert_obj_accessor.Name = "cb_insert_obj_accessor";
            this.cb_insert_obj_accessor.Size = new System.Drawing.Size(128, 25);
            this.cb_insert_obj_accessor.TabIndex = 19;
            this.cb_insert_obj_accessor.Text = "+ obj. accessor";
            this.cb_insert_obj_accessor.UseVisualStyleBackColor = true;
            this.cb_insert_obj_accessor.Click += new System.EventHandler(this.cb_obj_accessor_Click);
            // 
            // tb_image
            // 
            this.tb_image.Location = new System.Drawing.Point(12, 190);
            this.tb_image.Name = "tb_image";
            this.tb_image.Size = new System.Drawing.Size(192, 20);
            this.tb_image.TabIndex = 24;
            // 
            // tb_code
            // 
            this.tb_code.Location = new System.Drawing.Point(12, 216);
            this.tb_code.Multiline = true;
            this.tb_code.Name = "tb_code";
            this.tb_code.Size = new System.Drawing.Size(192, 20);
            this.tb_code.TabIndex = 25;
            // 
            // frm_Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(933, 743);
            this.Controls.Add(this.gb_task_php);
            this.Controls.Add(this.gb_php_validation_block);
            this.Controls.Add(this.lbl_task_student_title);
            this.Controls.Add(this.tb_task_description);
            this.Controls.Add(this.gb_code_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gb_property);
            this.Controls.Add(this.lbl_task_title);
            this.Controls.Add(this.tb_task_title);
            this.Controls.Add(this.lbl_TaskId);
            this.Controls.Add(this.tb_task_id);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(949, 650);
            this.Name = "frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task Creator v. 04";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb_php_validation_block.ResumeLayout(false);
            this.gb_php_validation_block.PerformLayout();
            this.gb_code_txt.ResumeLayout(false);
            this.gb_code_txt.PerformLayout();
            this.gb_task_php.ResumeLayout(false);
            this.gb_task_php.PerformLayout();
            this.gb_property.ResumeLayout(false);
            this.gb_property.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_task_title;
        private System.Windows.Forms.Label lbl_task_student_title;
        private System.Windows.Forms.TextBox tb_task_id;
        private System.Windows.Forms.Label lbl_TaskId;
        private System.Windows.Forms.TextBox tb_task_title;
        private System.Windows.Forms.TextBox tb_task_description;
        private System.Windows.Forms.TextBox tb_php_task_file;
        private System.Windows.Forms.Button cb_create_task;
        private System.Windows.Forms.ListBox lb_cvpb_php;
        private System.Windows.Forms.GroupBox gb_php_validation_block;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ListBox lb_cvbs;
        private System.Windows.Forms.TextBox tb_sharp_parameters;
        private System.Windows.Forms.Button cb_preview_task;
        private System.Windows.Forms.GroupBox gb_code_txt;
        private System.Windows.Forms.ListBox lb_steps;
        private System.Windows.Forms.Button cb_add_step;
        private System.Windows.Forms.TextBox tb_step;
        private System.Windows.Forms.GroupBox gb_task_php;
        private System.Windows.Forms.ComboBox cb_obj_type;
        private System.Windows.Forms.Label lbl_p_type;
        private System.Windows.Forms.ComboBox cb_property;
        private System.Windows.Forms.ComboBox cb_master_value;
        private System.Windows.Forms.Label lbl_p;
        private System.Windows.Forms.Label lbl_p_master_value;
        private System.Windows.Forms.ComboBox cb_validation_method;
        private System.Windows.Forms.Label lbl_validation_method;
        private System.Windows.Forms.Button cb_add_pvb;
        private System.Windows.Forms.ComboBox cb_p_desc_ENG;
        private System.Windows.Forms.Label lbl_p_desc_ENG;
        private System.Windows.Forms.TextBox tb_obj_instance;
        private System.Windows.Forms.Label lbl_v_object;
        private System.Windows.Forms.ComboBox cb_p_desc_UA;
        private System.Windows.Forms.Label lbl_p_desc_UA;
        private System.Windows.Forms.GroupBox gb_property;
        private System.Windows.Forms.Button cb_insert_obj_accessor;
        private System.Windows.Forms.Button cb_insert_obj_event;
        private System.Windows.Forms.Button cb_add_standard_steps;
        private System.Windows.Forms.Label lbl_step;
        private System.Windows.Forms.Button cb_insert_image;
        private System.Windows.Forms.Button cb_code;
        private System.Windows.Forms.ComboBox cb_obj_events;
        private System.Windows.Forms.TextBox tb_image;
        private System.Windows.Forms.TextBox tb_code;
    }
}

