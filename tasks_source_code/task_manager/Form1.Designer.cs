namespace task_manager
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_Controls = new System.Windows.Forms.ListBox();
            this.lb_Properties = new System.Windows.Forms.ListBox();
            this.Properties = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_OneItemCode = new System.Windows.Forms.ListBox();
            this.lb_OneItemTask = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_Value = new System.Windows.Forms.TextBox();
            this.btn_AddOneItemTask = new System.Windows.Forms.Button();
            this.lb_PropertiesTranslate = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_Task = new System.Windows.Forms.ListBox();
            this.l_Result = new System.Windows.Forms.Label();
            this.btn_SaveTask = new System.Windows.Forms.Button();
            this.btn_AddTask = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_Code = new System.Windows.Forms.ListBox();
            this.btn_SaveCode = new System.Windows.Forms.Button();
            this.btn_AddCode = new System.Windows.Forms.Button();
            this.btn_AddOneItemCode = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lb_Properties, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lb_Controls, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Properties, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lb_PropertiesTranslate, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.tb_Value, 3, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.15337F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 74.84663F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(491, 636);
            this.tableLayoutPanel1.TabIndex = 2;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Control";
            // 
            // lb_Controls
            // 
            this.lb_Controls.FormattingEnabled = true;
            this.lb_Controls.Location = new System.Drawing.Point(3, 162);
            this.lb_Controls.Name = "lb_Controls";
            this.lb_Controls.Size = new System.Drawing.Size(120, 446);
            this.lb_Controls.TabIndex = 10;
            this.lb_Controls.SelectedIndexChanged += new System.EventHandler(this.lb_Controls_SelectedIndexChanged);
            // 
            // lb_Properties
            // 
            this.lb_Properties.FormattingEnabled = true;
            this.lb_Properties.Location = new System.Drawing.Point(129, 162);
            this.lb_Properties.Name = "lb_Properties";
            this.lb_Properties.Size = new System.Drawing.Size(120, 446);
            this.lb_Properties.TabIndex = 7;
            this.lb_Properties.SelectedIndexChanged += new System.EventHandler(this.lb_Properties_SelectedIndexChanged);
            // 
            // Properties
            // 
            this.Properties.AutoSize = true;
            this.Properties.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Properties.Location = new System.Drawing.Point(129, 0);
            this.Properties.Name = "Properties";
            this.Properties.Size = new System.Drawing.Size(95, 24);
            this.Properties.TabIndex = 3;
            this.Properties.Text = "Properties";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(255, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Переклад";
            // 
            // lb_OneItemCode
            // 
            this.lb_OneItemCode.FormattingEnabled = true;
            this.lb_OneItemCode.Location = new System.Drawing.Point(967, 38);
            this.lb_OneItemCode.Name = "lb_OneItemCode";
            this.lb_OneItemCode.Size = new System.Drawing.Size(341, 121);
            this.lb_OneItemCode.TabIndex = 6;
            // 
            // lb_OneItemTask
            // 
            this.lb_OneItemTask.FormattingEnabled = true;
            this.lb_OneItemTask.Location = new System.Drawing.Point(538, 38);
            this.lb_OneItemTask.Name = "lb_OneItemTask";
            this.lb_OneItemTask.Size = new System.Drawing.Size(410, 121);
            this.lb_OneItemTask.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(381, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Value";
            // 
            // tb_Value
            // 
            this.tb_Value.Location = new System.Drawing.Point(381, 162);
            this.tb_Value.Name = "tb_Value";
            this.tb_Value.Size = new System.Drawing.Size(102, 20);
            this.tb_Value.TabIndex = 9;
            // 
            // btn_AddOneItemTask
            // 
            this.btn_AddOneItemTask.Location = new System.Drawing.Point(657, 172);
            this.btn_AddOneItemTask.Name = "btn_AddOneItemTask";
            this.btn_AddOneItemTask.Size = new System.Drawing.Size(154, 23);
            this.btn_AddOneItemTask.TabIndex = 11;
            this.btn_AddOneItemTask.Text = "AddOneItemTask";
            this.btn_AddOneItemTask.UseVisualStyleBackColor = true;
            this.btn_AddOneItemTask.Click += new System.EventHandler(this.btn_AddOneItemTask_Click);
            // 
            // lb_PropertiesTranslate
            // 
            this.lb_PropertiesTranslate.FormattingEnabled = true;
            this.lb_PropertiesTranslate.Location = new System.Drawing.Point(255, 162);
            this.lb_PropertiesTranslate.Name = "lb_PropertiesTranslate";
            this.lb_PropertiesTranslate.Size = new System.Drawing.Size(120, 446);
            this.lb_PropertiesTranslate.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(534, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 23);
            this.label8.TabIndex = 4;
            this.label8.Text = "One Item task";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(963, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 23);
            this.label6.TabIndex = 4;
            this.label6.Text = "One Item code";
            // 
            // lb_Task
            // 
            this.lb_Task.FormattingEnabled = true;
            this.lb_Task.Location = new System.Drawing.Point(538, 243);
            this.lb_Task.Name = "lb_Task";
            this.lb_Task.Size = new System.Drawing.Size(410, 264);
            this.lb_Task.TabIndex = 7;
            // 
            // l_Result
            // 
            this.l_Result.AutoSize = true;
            this.l_Result.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_Result.Location = new System.Drawing.Point(534, 206);
            this.l_Result.Name = "l_Result";
            this.l_Result.Size = new System.Drawing.Size(115, 23);
            this.l_Result.TabIndex = 5;
            this.l_Result.Text = "Result task";
            // 
            // btn_SaveTask
            // 
            this.btn_SaveTask.BackColor = System.Drawing.Color.LightGreen;
            this.btn_SaveTask.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_SaveTask.Location = new System.Drawing.Point(688, 518);
            this.btn_SaveTask.Name = "btn_SaveTask";
            this.btn_SaveTask.Size = new System.Drawing.Size(100, 100);
            this.btn_SaveTask.TabIndex = 8;
            this.btn_SaveTask.Text = "Save task";
            this.btn_SaveTask.UseVisualStyleBackColor = false;
            this.btn_SaveTask.Click += new System.EventHandler(this.btn_SaveTask_Click);
            // 
            // btn_AddTask
            // 
            this.btn_AddTask.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_AddTask.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_AddTask.Location = new System.Drawing.Point(538, 518);
            this.btn_AddTask.Name = "btn_AddTask";
            this.btn_AddTask.Size = new System.Drawing.Size(100, 100);
            this.btn_AddTask.TabIndex = 9;
            this.btn_AddTask.Text = "Add to task";
            this.btn_AddTask.UseVisualStyleBackColor = false;
            this.btn_AddTask.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(963, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Result code";
            // 
            // lb_Code
            // 
            this.lb_Code.FormattingEnabled = true;
            this.lb_Code.Location = new System.Drawing.Point(967, 243);
            this.lb_Code.Name = "lb_Code";
            this.lb_Code.Size = new System.Drawing.Size(341, 264);
            this.lb_Code.TabIndex = 7;
            // 
            // btn_SaveCode
            // 
            this.btn_SaveCode.BackColor = System.Drawing.Color.LightGreen;
            this.btn_SaveCode.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_SaveCode.Location = new System.Drawing.Point(1196, 518);
            this.btn_SaveCode.Name = "btn_SaveCode";
            this.btn_SaveCode.Size = new System.Drawing.Size(100, 100);
            this.btn_SaveCode.TabIndex = 10;
            this.btn_SaveCode.Text = "Save code";
            this.btn_SaveCode.UseVisualStyleBackColor = false;
            // 
            // btn_AddCode
            // 
            this.btn_AddCode.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_AddCode.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_AddCode.Location = new System.Drawing.Point(1069, 518);
            this.btn_AddCode.Name = "btn_AddCode";
            this.btn_AddCode.Size = new System.Drawing.Size(100, 100);
            this.btn_AddCode.TabIndex = 11;
            this.btn_AddCode.Text = "Add to code";
            this.btn_AddCode.UseVisualStyleBackColor = false;
            // 
            // btn_AddOneItemCode
            // 
            this.btn_AddOneItemCode.Location = new System.Drawing.Point(1050, 171);
            this.btn_AddOneItemCode.Name = "btn_AddOneItemCode";
            this.btn_AddOneItemCode.Size = new System.Drawing.Size(179, 23);
            this.btn_AddOneItemCode.TabIndex = 12;
            this.btn_AddOneItemCode.Text = "AddOneItemCode";
            this.btn_AddOneItemCode.UseVisualStyleBackColor = true;
            this.btn_AddOneItemCode.Click += new System.EventHandler(this.btn_AddOneItemCode_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 671);
            this.Controls.Add(this.btn_AddOneItemCode);
            this.Controls.Add(this.btn_SaveCode);
            this.Controls.Add(this.btn_AddCode);
            this.Controls.Add(this.btn_SaveTask);
            this.Controls.Add(this.btn_AddTask);
            this.Controls.Add(this.lb_Code);
            this.Controls.Add(this.lb_Task);
            this.Controls.Add(this.lb_OneItemCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.l_Result);
            this.Controls.Add(this.btn_AddOneItemTask);
            this.Controls.Add(this.lb_OneItemTask);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_Value;
        private System.Windows.Forms.ListBox lb_Controls;
        private System.Windows.Forms.Label Properties;
        private System.Windows.Forms.ListBox lb_Properties;
        private System.Windows.Forms.ListBox lb_OneItemTask;
        private System.Windows.Forms.ListBox lb_Task;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label l_Result;
        private System.Windows.Forms.Button btn_SaveTask;
        private System.Windows.Forms.Button btn_AddTask;
        private System.Windows.Forms.ListBox lb_OneItemCode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lb_Code;
        private System.Windows.Forms.Button btn_SaveCode;
        private System.Windows.Forms.Button btn_AddCode;
        private System.Windows.Forms.Button btn_AddOneItemTask;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lb_PropertiesTranslate;
        private System.Windows.Forms.Button btn_AddOneItemCode;
    }
}

