namespace WindowsApplication1
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
            this.btn_Doubling = new System.Windows.Forms.Button();
            this.lb_Result = new System.Windows.Forms.Label();
            this.tb_Input = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Doubling
            // 
            this.btn_Doubling.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Doubling.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Doubling.Location = new System.Drawing.Point(125, 174);
            this.btn_Doubling.Name = "btn_Doubling";
            this.btn_Doubling.Size = new System.Drawing.Size(250, 50);
            this.btn_Doubling.TabIndex = 0;
            this.btn_Doubling.Text = "Подвоїти";
            this.btn_Doubling.UseVisualStyleBackColor = true;
            this.btn_Doubling.Click += new System.EventHandler(this.btn_Doubling_Click);
            // 
            // lb_Result
            // 
            this.lb_Result.AutoSize = true;
            this.lb_Result.Location = new System.Drawing.Point(306, 66);
            this.lb_Result.Name = "lb_Result";
            this.lb_Result.Size = new System.Drawing.Size(143, 31);
            this.lb_Result.TabIndex = 1;
            this.lb_Result.Text = "Результат";
            // 
            // tb_Input
            // 
            this.tb_Input.Location = new System.Drawing.Point(24, 63);
            this.tb_Input.Name = "tb_Input";
            this.tb_Input.Size = new System.Drawing.Size(250, 38);
            this.tb_Input.TabIndex = 2;
            this.tb_Input.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.tb_Input);
            this.Controls.Add(this.lb_Result);
            this.Controls.Add(this.btn_Doubling);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Location = new System.Drawing.Point(400, 400);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Збільшення числа вдвічі";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Doubling;
        private System.Windows.Forms.Label lb_Result;
        private System.Windows.Forms.TextBox tb_Input;
    }
}

