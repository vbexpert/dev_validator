namespace _07_Square
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
            this.lb_Author = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_Diagonal = new System.Windows.Forms.Label();
            this.lb_Square = new System.Windows.Forms.Label();
            this.lb_Side = new System.Windows.Forms.Label();
            this.lb_Perimeter = new System.Windows.Forms.Label();
            this.btn_Calculate = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.lb_Info = new System.Windows.Forms.Label();
            this.tb_Input = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_Author
            // 
            this.lb_Author.AutoSize = true;
            this.lb_Author.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_Author.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lb_Author.Location = new System.Drawing.Point(38, 520);
            this.lb_Author.Name = "lb_Author";
            this.lb_Author.Size = new System.Drawing.Size(520, 20);
            this.lb_Author.TabIndex = 21;
            this.lb_Author.Text = "Автор: учень 12-В класу Житомирської ЗОШ №30, Шатківський В.М. ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::_07_Square.Properties.Resources.Square;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(42, 148);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(215, 215);
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // lb_Diagonal
            // 
            this.lb_Diagonal.AutoSize = true;
            this.lb_Diagonal.Location = new System.Drawing.Point(279, 331);
            this.lb_Diagonal.Name = "lb_Diagonal";
            this.lb_Diagonal.Size = new System.Drawing.Size(170, 31);
            this.lb_Diagonal.TabIndex = 28;
            this.lb_Diagonal.Text = "Діагональ: 0";
            // 
            // lb_Square
            // 
            this.lb_Square.AutoSize = true;
            this.lb_Square.Location = new System.Drawing.Point(279, 270);
            this.lb_Square.Name = "lb_Square";
            this.lb_Square.Size = new System.Drawing.Size(131, 31);
            this.lb_Square.TabIndex = 29;
            this.lb_Square.Text = "Площа: 0";
            // 
            // lb_Side
            // 
            this.lb_Side.AutoSize = true;
            this.lb_Side.Location = new System.Drawing.Point(279, 148);
            this.lb_Side.Name = "lb_Side";
            this.lb_Side.Size = new System.Drawing.Size(151, 31);
            this.lb_Side.TabIndex = 27;
            this.lb_Side.Text = "Сторона: 0";
            // 
            // lb_Perimeter
            // 
            this.lb_Perimeter.AutoSize = true;
            this.lb_Perimeter.Location = new System.Drawing.Point(279, 209);
            this.lb_Perimeter.Name = "lb_Perimeter";
            this.lb_Perimeter.Size = new System.Drawing.Size(170, 31);
            this.lb_Perimeter.TabIndex = 26;
            this.lb_Perimeter.Text = "Периметр: 0";
            // 
            // btn_Calculate
            // 
            this.btn_Calculate.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_Calculate.Location = new System.Drawing.Point(42, 388);
            this.btn_Calculate.Name = "btn_Calculate";
            this.btn_Calculate.Size = new System.Drawing.Size(500, 50);
            this.btn_Calculate.TabIndex = 24;
            this.btn_Calculate.Text = "Розрахувати";
            this.btn_Calculate.UseVisualStyleBackColor = false;
            this.btn_Calculate.Click += new System.EventHandler(this.btn_Calculate_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.LightCoral;
            this.btn_Close.Location = new System.Drawing.Point(42, 453);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(500, 50);
            this.btn_Close.TabIndex = 25;
            this.btn_Close.Text = "Закрити";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // lb_Info
            // 
            this.lb_Info.AutoSize = true;
            this.lb_Info.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_Info.Location = new System.Drawing.Point(77, 32);
            this.lb_Info.Name = "lb_Info";
            this.lb_Info.Size = new System.Drawing.Size(416, 32);
            this.lb_Info.TabIndex = 23;
            this.lb_Info.Text = "Введіть сторону квадрату";
            // 
            // tb_Input
            // 
            this.tb_Input.Location = new System.Drawing.Point(42, 81);
            this.tb_Input.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tb_Input.Name = "tb_Input";
            this.tb_Input.Size = new System.Drawing.Size(500, 38);
            this.tb_Input.TabIndex = 22;
            this.tb_Input.Text = "0";
            this.tb_Input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Input_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lb_Diagonal);
            this.Controls.Add(this.lb_Square);
            this.Controls.Add(this.lb_Side);
            this.Controls.Add(this.lb_Perimeter);
            this.Controls.Add(this.btn_Calculate);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.lb_Info);
            this.Controls.Add(this.tb_Input);
            this.Controls.Add(this.lb_Author);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Form1";
            this.Text = "Квадрат";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_Author;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lb_Diagonal;
        private System.Windows.Forms.Label lb_Square;
        private System.Windows.Forms.Label lb_Side;
        private System.Windows.Forms.Label lb_Perimeter;
        private System.Windows.Forms.Button btn_Calculate;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Label lb_Info;
        private System.Windows.Forms.TextBox tb_Input;
    }
}

