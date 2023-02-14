namespace Task_01
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
            this.components = new System.ComponentModel.Container();
            this.tb_Input = new System.Windows.Forms.TextBox();
            this.btn_Start = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rtb_Result = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // tb_Input
            // 
            this.tb_Input.Location = new System.Drawing.Point(68, 91);
            this.tb_Input.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tb_Input.Name = "tb_Input";
            this.tb_Input.Size = new System.Drawing.Size(293, 40);
            this.tb_Input.TabIndex = 0;
            this.tb_Input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Input_KeyPress);
            // 
            // btn_Start
            // 
            this.btn_Start.BackColor = System.Drawing.Color.LightGreen;
            this.btn_Start.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Start.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_Start.Location = new System.Drawing.Point(68, 166);
            this.btn_Start.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(293, 57);
            this.btn_Start.TabIndex = 1;
            this.btn_Start.Text = "Перевірити";
            this.btn_Start.UseVisualStyleBackColor = false;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.LightCoral;
            this.btn_Close.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_Close.Location = new System.Drawing.Point(68, 454);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(293, 57);
            this.btn_Close.TabIndex = 2;
            this.btn_Close.Text = "Закрити";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Результат:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(61, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(307, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Введіть ціле число";
            // 
            // rtb_Result
            // 
            this.rtb_Result.BackColor = System.Drawing.SystemColors.ControlLight;
            this.rtb_Result.Location = new System.Drawing.Point(68, 325);
            this.rtb_Result.Name = "rtb_Result";
            this.rtb_Result.Size = new System.Drawing.Size(293, 94);
            this.rtb_Result.TabIndex = 6;
            this.rtb_Result.Text = "";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 545);
            this.Controls.Add(this.rtb_Result);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.tb_Input);
            this.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Перевірка числа на рівність нулю";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Input;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtb_Result;
        private System.Windows.Forms.Timer timer1;
    }
}

