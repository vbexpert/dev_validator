namespace _08_Energy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tc_Energy = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_ClearKinetic = new System.Windows.Forms.Button();
            this.btn_CalculateKinetic = new System.Windows.Forms.Button();
            this.lb_ResultEnergyKinetic = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_InputSpeedKinetic = new System.Windows.Forms.TextBox();
            this.tb_InputMassKinetic = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_InfoKinetic = new System.Windows.Forms.TextBox();
            this.pb_PictureKinetic = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_ClearPotential = new System.Windows.Forms.Button();
            this.btn_CalculatePotential = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_InputHeightPotential = new System.Windows.Forms.TextBox();
            this.tb_InputMassPotential = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.tc_Energy.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_PictureKinetic)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tc_Energy
            // 
            this.tc_Energy.Controls.Add(this.tabPage1);
            this.tc_Energy.Controls.Add(this.tabPage2);
            this.tc_Energy.Controls.Add(this.tabPage3);
            this.tc_Energy.Location = new System.Drawing.Point(0, 0);
            this.tc_Energy.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tc_Energy.Name = "tc_Energy";
            this.tc_Energy.SelectedIndex = 0;
            this.tc_Energy.Size = new System.Drawing.Size(780, 560);
            this.tc_Energy.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_ClearKinetic);
            this.tabPage1.Controls.Add(this.btn_CalculateKinetic);
            this.tabPage1.Controls.Add(this.lb_ResultEnergyKinetic);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.tb_InputSpeedKinetic);
            this.tabPage1.Controls.Add(this.tb_InputMassKinetic);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.tb_InfoKinetic);
            this.tabPage1.Controls.Add(this.pb_PictureKinetic);
            this.tabPage1.Location = new System.Drawing.Point(4, 40);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tabPage1.Size = new System.Drawing.Size(772, 516);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Кінетична";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_ClearKinetic
            // 
            this.btn_ClearKinetic.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_ClearKinetic.Location = new System.Drawing.Point(94, 309);
            this.btn_ClearKinetic.Name = "btn_ClearKinetic";
            this.btn_ClearKinetic.Size = new System.Drawing.Size(250, 50);
            this.btn_ClearKinetic.TabIndex = 5;
            this.btn_ClearKinetic.Text = "Очистити";
            this.btn_ClearKinetic.UseVisualStyleBackColor = false;
            // 
            // btn_CalculateKinetic
            // 
            this.btn_CalculateKinetic.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_CalculateKinetic.Location = new System.Drawing.Point(366, 309);
            this.btn_CalculateKinetic.Name = "btn_CalculateKinetic";
            this.btn_CalculateKinetic.Size = new System.Drawing.Size(250, 50);
            this.btn_CalculateKinetic.TabIndex = 5;
            this.btn_CalculateKinetic.Text = "Обрахувати";
            this.btn_CalculateKinetic.UseVisualStyleBackColor = false;
            this.btn_CalculateKinetic.Click += new System.EventHandler(this.btn_CalculateKinetic_Click);
            // 
            // lb_ResultEnergyKinetic
            // 
            this.lb_ResultEnergyKinetic.AutoSize = true;
            this.lb_ResultEnergyKinetic.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_ResultEnergyKinetic.Location = new System.Drawing.Point(549, 241);
            this.lb_ResultEnergyKinetic.Name = "lb_ResultEnergyKinetic";
            this.lb_ResultEnergyKinetic.Size = new System.Drawing.Size(30, 31);
            this.lb_ResultEnergyKinetic.TabIndex = 4;
            this.lb_ResultEnergyKinetic.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(262, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(298, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "Кінетична енергія К=";
            // 
            // tb_InputSpeedKinetic
            // 
            this.tb_InputSpeedKinetic.Location = new System.Drawing.Point(555, 182);
            this.tb_InputSpeedKinetic.Name = "tb_InputSpeedKinetic";
            this.tb_InputSpeedKinetic.Size = new System.Drawing.Size(100, 38);
            this.tb_InputSpeedKinetic.TabIndex = 3;
            // 
            // tb_InputMassKinetic
            // 
            this.tb_InputMassKinetic.Location = new System.Drawing.Point(491, 126);
            this.tb_InputMassKinetic.Name = "tb_InputMassKinetic";
            this.tb_InputMassKinetic.Size = new System.Drawing.Size(100, 38);
            this.tb_InputMassKinetic.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(262, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(287, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Введіть швидкість  v=";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(262, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введіть масу m=";
            // 
            // tb_InfoKinetic
            // 
            this.tb_InfoKinetic.Location = new System.Drawing.Point(22, 21);
            this.tb_InfoKinetic.Multiline = true;
            this.tb_InfoKinetic.Name = "tb_InfoKinetic";
            this.tb_InfoKinetic.Size = new System.Drawing.Size(739, 76);
            this.tb_InfoKinetic.TabIndex = 1;
            this.tb_InfoKinetic.Text = "Кінетична енергія — частина енергії фізичної системи, яку вона має завдяки руху.";
            // 
            // pb_PictureKinetic
            // 
            this.pb_PictureKinetic.BackgroundImage = global::_08_Energy.Properties.Resources.kin;
            this.pb_PictureKinetic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_PictureKinetic.Location = new System.Drawing.Point(22, 128);
            this.pb_PictureKinetic.Name = "pb_PictureKinetic";
            this.pb_PictureKinetic.Size = new System.Drawing.Size(200, 150);
            this.pb_PictureKinetic.TabIndex = 0;
            this.pb_PictureKinetic.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.btn_ClearPotential);
            this.tabPage2.Controls.Add(this.btn_CalculatePotential);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.tb_InputHeightPotential);
            this.tabPage2.Controls.Add(this.tb_InputMassPotential);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.textBox4);
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 40);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tabPage2.Size = new System.Drawing.Size(772, 516);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Потенціальна";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(256, 278);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(490, 31);
            this.label8.TabIndex = 16;
            this.label8.Text = "Прискорення вільного падіння 9,8 м/с";
            // 
            // btn_ClearPotential
            // 
            this.btn_ClearPotential.BackColor = System.Drawing.Color.LightBlue;
            this.btn_ClearPotential.Location = new System.Drawing.Point(113, 387);
            this.btn_ClearPotential.Name = "btn_ClearPotential";
            this.btn_ClearPotential.Size = new System.Drawing.Size(250, 50);
            this.btn_ClearPotential.TabIndex = 14;
            this.btn_ClearPotential.Text = "Очистити";
            this.btn_ClearPotential.UseVisualStyleBackColor = false;
            // 
            // btn_CalculatePotential
            // 
            this.btn_CalculatePotential.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_CalculatePotential.Location = new System.Drawing.Point(378, 387);
            this.btn_CalculatePotential.Name = "btn_CalculatePotential";
            this.btn_CalculatePotential.Size = new System.Drawing.Size(250, 50);
            this.btn_CalculatePotential.TabIndex = 15;
            this.btn_CalculatePotential.Text = "Обрахувати";
            this.btn_CalculatePotential.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(598, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 31);
            this.label4.TabIndex = 12;
            this.label4.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(256, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(351, 31);
            this.label5.TabIndex = 13;
            this.label5.Text = "Потенціальна енергія U=";
            // 
            // tb_InputHeightPotential
            // 
            this.tb_InputHeightPotential.Location = new System.Drawing.Point(498, 228);
            this.tb_InputHeightPotential.Name = "tb_InputHeightPotential";
            this.tb_InputHeightPotential.Size = new System.Drawing.Size(100, 38);
            this.tb_InputHeightPotential.TabIndex = 10;
            // 
            // tb_InputMassPotential
            // 
            this.tb_InputMassPotential.Location = new System.Drawing.Point(484, 181);
            this.tb_InputMassPotential.Name = "tb_InputMassPotential";
            this.tb_InputMassPotential.Size = new System.Drawing.Size(114, 38);
            this.tb_InputMassPotential.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(256, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(245, 31);
            this.label6.TabIndex = 8;
            this.label6.Text = "Введіть висоту  h=";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(256, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(223, 31);
            this.label7.TabIndex = 9;
            this.label7.Text = "Введіть масу m=";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(17, 22);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(739, 135);
            this.textBox4.TabIndex = 7;
            this.textBox4.Text = resources.GetString("textBox4.Text");
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::_08_Energy.Properties.Resources.pot;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(17, 184);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(222, 174);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 40);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(772, 516);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Пружини";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(738, 274);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 24);
            this.label9.TabIndex = 18;
            this.label9.Text = "2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tc_Energy);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Form1";
            this.Text = "Енергія";
            this.tc_Energy.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_PictureKinetic)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tc_Energy;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label lb_ResultEnergyKinetic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_InputSpeedKinetic;
        private System.Windows.Forms.TextBox tb_InputMassKinetic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_InfoKinetic;
        private System.Windows.Forms.PictureBox pb_PictureKinetic;
        private System.Windows.Forms.Button btn_CalculateKinetic;
        private System.Windows.Forms.Button btn_ClearKinetic;
        private System.Windows.Forms.Button btn_ClearPotential;
        private System.Windows.Forms.Button btn_CalculatePotential;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_InputHeightPotential;
        private System.Windows.Forms.TextBox tb_InputMassPotential;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

