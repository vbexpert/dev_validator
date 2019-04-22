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
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_CopyText = new System.Windows.Forms.Button();
            this.lb_Result = new System.Windows.Forms.Label();
            this.tb_Input = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.LightCoral;
            this.btn_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Close.Location = new System.Drawing.Point(193, 315);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(300, 120);
            this.btn_Close.TabIndex = 0;
            this.btn_Close.Text = "Закрити";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_CopyText
            // 
            this.btn_CopyText.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_CopyText.Location = new System.Drawing.Point(193, 178);
            this.btn_CopyText.Name = "btn_CopyText";
            this.btn_CopyText.Size = new System.Drawing.Size(300, 120);
            this.btn_CopyText.TabIndex = 1;
            this.btn_CopyText.Text = "Скопіювати текст";
            this.btn_CopyText.UseVisualStyleBackColor = false;
            this.btn_CopyText.Click += new System.EventHandler(this.btn_CopyText_Click);
            // 
            // lb_Result
            // 
            this.lb_Result.AutoSize = true;
            this.lb_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_Result.Location = new System.Drawing.Point(30, 107);
            this.lb_Result.Name = "lb_Result";
            this.lb_Result.Size = new System.Drawing.Size(626, 31);
            this.lb_Result.TabIndex = 2;
            this.lb_Result.Text = "Тут з\'явиться текст при натисканні на кнопку";
            // 
            // tb_Input
            // 
            this.tb_Input.Location = new System.Drawing.Point(62, 26);
            this.tb_Input.Name = "tb_Input";
            this.tb_Input.Size = new System.Drawing.Size(563, 38);
            this.tb_Input.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.tb_Input);
            this.Controls.Add(this.lb_Result);
            this.Controls.Add(this.btn_CopyText);
            this.Controls.Add(this.btn_Close);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Location = new System.Drawing.Point(400, 400);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Робота з полем для вводу тексту";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_CopyText;
        private System.Windows.Forms.Label lb_Result;
        private System.Windows.Forms.TextBox tb_Input;
    }
}

