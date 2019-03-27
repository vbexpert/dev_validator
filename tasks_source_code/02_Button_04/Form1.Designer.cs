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
            this.btn_ChangeText = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_ChangeText
            // 
            this.btn_ChangeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_ChangeText.ForeColor = System.Drawing.Color.Crimson;
            this.btn_ChangeText.Location = new System.Drawing.Point(91, 169);
            this.btn_ChangeText.Name = "btn_ChangeText";
            this.btn_ChangeText.Size = new System.Drawing.Size(500, 100);
            this.btn_ChangeText.TabIndex = 0;
            this.btn_ChangeText.Text = "Змінити напис кнопки";
            this.btn_ChangeText.UseVisualStyleBackColor = true;
            this.btn_ChangeText.Click += new System.EventHandler(this.btn_ChangeText_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(684, 462);
            this.Controls.Add(this.btn_ChangeText);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Location = new System.Drawing.Point(400, 400);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Подія на кнопці";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ChangeText;
    }
}

