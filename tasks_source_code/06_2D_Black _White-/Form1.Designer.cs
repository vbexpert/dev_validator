namespace Black__White
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
            this.btn_Black = new System.Windows.Forms.Button();
            this.btn_White = new System.Windows.Forms.Button();
            this.pb_Target = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Target)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Black
            // 
            this.btn_Black.BackColor = System.Drawing.Color.Black;
            this.btn_Black.FlatAppearance.BorderSize = 0;
            this.btn_Black.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Black.Location = new System.Drawing.Point(0, 0);
            this.btn_Black.Name = "btn_Black";
            this.btn_Black.Size = new System.Drawing.Size(250, 50);
            this.btn_Black.TabIndex = 0;
            this.btn_Black.UseVisualStyleBackColor = false;
            this.btn_Black.Click += new System.EventHandler(this.btn_Black_Click);
            // 
            // btn_White
            // 
            this.btn_White.BackColor = System.Drawing.Color.White;
            this.btn_White.FlatAppearance.BorderSize = 0;
            this.btn_White.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_White.Location = new System.Drawing.Point(250, 0);
            this.btn_White.Name = "btn_White";
            this.btn_White.Size = new System.Drawing.Size(250, 50);
            this.btn_White.TabIndex = 1;
            this.btn_White.UseVisualStyleBackColor = false;
            this.btn_White.Click += new System.EventHandler(this.btn_White_Click);
            // 
            // pb_Target
            // 
            this.pb_Target.Location = new System.Drawing.Point(0, 50);
            this.pb_Target.Name = "pb_Target";
            this.pb_Target.Size = new System.Drawing.Size(500, 300);
            this.pb_Target.TabIndex = 2;
            this.pb_Target.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(499, 351);
            this.Controls.Add(this.pb_Target);
            this.Controls.Add(this.btn_White);
            this.Controls.Add(this.btn_Black);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Black_White";
            ((System.ComponentModel.ISupportInitialize)(this.pb_Target)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Black;
        private System.Windows.Forms.Button btn_White;
        private System.Windows.Forms.PictureBox pb_Target;
    }
}

