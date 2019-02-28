namespace WindowsApplication1
{
    partial class Black_White
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
            this.pb_Target = new System.Windows.Forms.PictureBox();
            this.btn_White = new System.Windows.Forms.Button();
            this.btn_Black = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Target)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_Target
            // 
            this.pb_Target.Location = new System.Drawing.Point(0, 50);
            this.pb_Target.Name = "pb_Target";
            this.pb_Target.Size = new System.Drawing.Size(500, 300);
            this.pb_Target.TabIndex = 5;
            this.pb_Target.TabStop = false;
            // 
            // btn_White
            // 
            this.btn_White.BackColor = System.Drawing.Color.White;
            this.btn_White.FlatAppearance.BorderSize = 0;
            this.btn_White.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_White.Location = new System.Drawing.Point(250, 0);
            this.btn_White.Name = "btn_White";
            this.btn_White.Size = new System.Drawing.Size(250, 50);
            this.btn_White.TabIndex = 4;
            this.btn_White.UseVisualStyleBackColor = false;
            this.btn_White.Click += new System.EventHandler(this.btn_White_Click);
            // 
            // btn_Black
            // 
            this.btn_Black.BackColor = System.Drawing.Color.Black;
            this.btn_Black.FlatAppearance.BorderSize = 0;
            this.btn_Black.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Black.Location = new System.Drawing.Point(0, 0);
            this.btn_Black.Name = "btn_Black";
            this.btn_Black.Size = new System.Drawing.Size(250, 50);
            this.btn_Black.TabIndex = 3;
            this.btn_Black.UseVisualStyleBackColor = false;
            this.btn_Black.Click += new System.EventHandler(this.btn_Black_Click);
            // 
            // Black_White
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(499, 351);
            this.Controls.Add(this.pb_Target);
            this.Controls.Add(this.btn_White);
            this.Controls.Add(this.btn_Black);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Location = new System.Drawing.Point(200, 200);
            this.Name = "Black_White";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Black_White";
            ((System.ComponentModel.ISupportInitialize)(this.pb_Target)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Target;
        private System.Windows.Forms.Button btn_White;
        private System.Windows.Forms.Button btn_Black;
    }
}

