namespace Circle
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Input = new System.Windows.Forms.TextBox();
            this.btn_Calculate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_Radius = new System.Windows.Forms.Label();
            this.lb_Diameter = new System.Windows.Forms.Label();
            this.lb_Length = new System.Windows.Forms.Label();
            this.lb_Square = new System.Windows.Forms.Label();
            this.lb_Extent = new System.Windows.Forms.Label();
            this.tb_Info = new System.Windows.Forms.TextBox();
            this.lb_Author = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pb_Image = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введіть радіус кола";
            // 
            // tb_Input
            // 
            this.tb_Input.Location = new System.Drawing.Point(12, 54);
            this.tb_Input.Name = "tb_Input";
            this.tb_Input.Size = new System.Drawing.Size(607, 38);
            this.tb_Input.TabIndex = 2;
            this.tb_Input.Text = "0";
            // 
            // btn_Calculate
            // 
            this.btn_Calculate.BackColor = System.Drawing.Color.LightGreen;
            this.btn_Calculate.Location = new System.Drawing.Point(24, 430);
            this.btn_Calculate.Name = "btn_Calculate";
            this.btn_Calculate.Size = new System.Drawing.Size(300, 50);
            this.btn_Calculate.TabIndex = 7;
            this.btn_Calculate.Text = "Розрахувати";
            this.btn_Calculate.UseVisualStyleBackColor = false;
            this.btn_Calculate.Click += new System.EventHandler(this.btn_Calculate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(318, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 31);
            this.label2.TabIndex = 9;
            this.label2.Text = "Радіус:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(318, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 31);
            this.label3.TabIndex = 10;
            this.label3.Text = "Діаметр:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(318, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 31);
            this.label4.TabIndex = 11;
            this.label4.Text = "Довжина кола:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(318, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 31);
            this.label5.TabIndex = 12;
            this.label5.Text = "Площа круга:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(318, 376);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 31);
            this.label6.TabIndex = 13;
            this.label6.Text = "Об\'єм сфери:";
            // 
            // lb_Radius
            // 
            this.lb_Radius.AutoSize = true;
            this.lb_Radius.Location = new System.Drawing.Point(523, 108);
            this.lb_Radius.Name = "lb_Radius";
            this.lb_Radius.Size = new System.Drawing.Size(29, 31);
            this.lb_Radius.TabIndex = 14;
            this.lb_Radius.Text = "0";
            // 
            // lb_Diameter
            // 
            this.lb_Diameter.AutoSize = true;
            this.lb_Diameter.Location = new System.Drawing.Point(523, 175);
            this.lb_Diameter.Name = "lb_Diameter";
            this.lb_Diameter.Size = new System.Drawing.Size(29, 31);
            this.lb_Diameter.TabIndex = 15;
            this.lb_Diameter.Text = "0";
            // 
            // lb_Length
            // 
            this.lb_Length.AutoSize = true;
            this.lb_Length.Location = new System.Drawing.Point(523, 242);
            this.lb_Length.Name = "lb_Length";
            this.lb_Length.Size = new System.Drawing.Size(29, 31);
            this.lb_Length.TabIndex = 16;
            this.lb_Length.Text = "0";
            // 
            // lb_Square
            // 
            this.lb_Square.AutoSize = true;
            this.lb_Square.Location = new System.Drawing.Point(523, 309);
            this.lb_Square.Name = "lb_Square";
            this.lb_Square.Size = new System.Drawing.Size(29, 31);
            this.lb_Square.TabIndex = 17;
            this.lb_Square.Text = "0";
            // 
            // lb_Extent
            // 
            this.lb_Extent.AutoSize = true;
            this.lb_Extent.Location = new System.Drawing.Point(523, 376);
            this.lb_Extent.Name = "lb_Extent";
            this.lb_Extent.Size = new System.Drawing.Size(29, 31);
            this.lb_Extent.TabIndex = 18;
            this.lb_Extent.Text = "0";
            // 
            // tb_Info
            // 
            this.tb_Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_Info.Location = new System.Drawing.Point(24, 503);
            this.tb_Info.Multiline = true;
            this.tb_Info.Name = "tb_Info";
            this.tb_Info.Size = new System.Drawing.Size(600, 50);
            this.tb_Info.TabIndex = 19;
            this.tb_Info.Text = "Програма для розрахунку розмірностей кола та сфери створена у рамках вивчення про" +
    "грамування обчислювальних проектів.";
            // 
            // lb_Author
            // 
            this.lb_Author.AutoSize = true;
            this.lb_Author.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_Author.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lb_Author.Location = new System.Drawing.Point(63, 578);
            this.lb_Author.Name = "lb_Author";
            this.lb_Author.Size = new System.Drawing.Size(520, 20);
            this.lb_Author.TabIndex = 20;
            this.lb_Author.Text = "Автор: учень 12-В класу Житомирської ЗОШ №30, Шатківський В.М. ";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(12, 502);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(616, 54);
            this.textBox1.TabIndex = 19;
            this.textBox1.Text = "Програма для розрахунку розмірностей кола та сфери створена у рамках вивчення про" +
    "грамування обчислювальних проектів.";
            // 
            // pb_Image
            // 
            this.pb_Image.BackgroundImage = global::Circle.Properties.Resources.Circle;
            this.pb_Image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_Image.Location = new System.Drawing.Point(12, 108);
            this.pb_Image.Name = "pb_Image";
            this.pb_Image.Size = new System.Drawing.Size(300, 300);
            this.pb_Image.TabIndex = 1;
            this.pb_Image.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(12, 108);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 300);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.LightCoral;
            this.btn_Close.Location = new System.Drawing.Point(324, 430);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(300, 50);
            this.btn_Close.TabIndex = 8;
            this.btn_Close.Text = "Закрити";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(650, 627);
            this.Controls.Add(this.lb_Author);
            this.Controls.Add(this.tb_Info);
            this.Controls.Add(this.lb_Extent);
            this.Controls.Add(this.lb_Square);
            this.Controls.Add(this.lb_Length);
            this.Controls.Add(this.lb_Diameter);
            this.Controls.Add(this.lb_Radius);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Calculate);
            this.Controls.Add(this.tb_Input);
            this.Controls.Add(this.pb_Image);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Коло";
            ((System.ComponentModel.ISupportInitialize)(this.pb_Image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pb_Image;
        private System.Windows.Forms.TextBox tb_Input;
        private System.Windows.Forms.Button btn_Calculate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lb_Radius;
        private System.Windows.Forms.Label lb_Diameter;
        private System.Windows.Forms.Label lb_Length;
        private System.Windows.Forms.Label lb_Square;
        private System.Windows.Forms.Label lb_Extent;
        private System.Windows.Forms.TextBox tb_Info;
        private System.Windows.Forms.Label lb_Author;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_Close;
    }
}

