namespace _06_Lines
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
            this.btb_Line = new System.Windows.Forms.Button();
            this.pb_Result = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rb_AntiAliasON = new System.Windows.Forms.RadioButton();
            this.rb_AntiAliasOF = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Result)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btb_Line
            // 
            this.btb_Line.Location = new System.Drawing.Point(0, 0);
            this.btb_Line.Name = "btb_Line";
            this.btb_Line.Size = new System.Drawing.Size(250, 50);
            this.btb_Line.TabIndex = 0;
            this.btb_Line.Text = "Line";
            this.btb_Line.UseVisualStyleBackColor = true;
            this.btb_Line.Click += new System.EventHandler(this.btb_Line_Click);
            // 
            // pb_Result
            // 
            this.pb_Result.BackColor = System.Drawing.Color.White;
            this.pb_Result.Location = new System.Drawing.Point(250, 0);
            this.pb_Result.Name = "pb_Result";
            this.pb_Result.Size = new System.Drawing.Size(250, 50);
            this.pb_Result.TabIndex = 1;
            this.pb_Result.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.rb_AntiAliasOF);
            this.panel1.Controls.Add(this.rb_AntiAliasON);
            this.panel1.Location = new System.Drawing.Point(0, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 150);
            this.panel1.TabIndex = 2;
            // 
            // rb_AntiAliasON
            // 
            this.rb_AntiAliasON.AutoSize = true;
            this.rb_AntiAliasON.Location = new System.Drawing.Point(12, 47);
            this.rb_AntiAliasON.Name = "rb_AntiAliasON";
            this.rb_AntiAliasON.Size = new System.Drawing.Size(155, 35);
            this.rb_AntiAliasON.TabIndex = 0;
            this.rb_AntiAliasON.TabStop = true;
            this.rb_AntiAliasON.Text = "Включити";
            this.rb_AntiAliasON.UseVisualStyleBackColor = true;
            this.rb_AntiAliasON.CheckedChanged += new System.EventHandler(this.rb_AntiAliasON_CheckedChanged);
            // 
            // rb_AntiAliasOF
            // 
            this.rb_AntiAliasOF.AutoSize = true;
            this.rb_AntiAliasOF.Location = new System.Drawing.Point(12, 88);
            this.rb_AntiAliasOF.Name = "rb_AntiAliasOF";
            this.rb_AntiAliasOF.Size = new System.Drawing.Size(170, 35);
            this.rb_AntiAliasOF.TabIndex = 1;
            this.rb_AntiAliasOF.TabStop = true;
            this.rb_AntiAliasOF.Text = "Виключити";
            this.rb_AntiAliasOF.UseVisualStyleBackColor = true;
            this.rb_AntiAliasOF.CheckedChanged += new System.EventHandler(this.rb_AntiAliasOF_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Зглажування";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pb_Result);
            this.Controls.Add(this.btb_Line);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "Form1";
            this.Text = "Lines";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Result)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btb_Line;
        private System.Windows.Forms.PictureBox pb_Result;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rb_AntiAliasOF;
        private System.Windows.Forms.RadioButton rb_AntiAliasON;
    }
}

