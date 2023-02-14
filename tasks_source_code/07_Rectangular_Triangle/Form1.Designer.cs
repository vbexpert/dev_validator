namespace _07_Rectangular_Triangle
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_SideA = new System.Windows.Forms.TextBox();
            this.tb_SideB = new System.Windows.Forms.TextBox();
            this.btn_Calculate = new System.Windows.Forms.Button();
            this.lb_SideC = new System.Windows.Forms.Label();
            this.lb_Perimeter = new System.Windows.Forms.Label();
            this.lb_Square = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(15, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Перший катет:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(15, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Другий катет:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(307, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Гіпотенуза =";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(307, 91);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Периметр =";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.DarkBlue;
            this.label5.Location = new System.Drawing.Point(307, 142);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Площа =";
            // 
            // tb_SideA
            // 
            this.tb_SideA.Location = new System.Drawing.Point(189, 38);
            this.tb_SideA.Name = "tb_SideA";
            this.tb_SideA.Size = new System.Drawing.Size(100, 29);
            this.tb_SideA.TabIndex = 5;
            // 
            // tb_SideB
            // 
            this.tb_SideB.Location = new System.Drawing.Point(189, 91);
            this.tb_SideB.Name = "tb_SideB";
            this.tb_SideB.Size = new System.Drawing.Size(100, 29);
            this.tb_SideB.TabIndex = 6;
            // 
            // btn_Calculate
            // 
            this.btn_Calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Calculate.ForeColor = System.Drawing.Color.DarkBlue;
            this.btn_Calculate.Location = new System.Drawing.Point(19, 154);
            this.btn_Calculate.Name = "btn_Calculate";
            this.btn_Calculate.Size = new System.Drawing.Size(165, 38);
            this.btn_Calculate.TabIndex = 7;
            this.btn_Calculate.Text = "Обчислити";
            this.btn_Calculate.UseVisualStyleBackColor = true;
            this.btn_Calculate.Click += new System.EventHandler(this.btn_Calculate_Click);
            // 
            // lb_SideC
            // 
            this.lb_SideC.AutoSize = true;
            this.lb_SideC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_SideC.ForeColor = System.Drawing.Color.Red;
            this.lb_SideC.Location = new System.Drawing.Point(443, 38);
            this.lb_SideC.Name = "lb_SideC";
            this.lb_SideC.Size = new System.Drawing.Size(21, 24);
            this.lb_SideC.TabIndex = 8;
            this.lb_SideC.Text = "0";
            // 
            // lb_Perimeter
            // 
            this.lb_Perimeter.AutoSize = true;
            this.lb_Perimeter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_Perimeter.ForeColor = System.Drawing.Color.Red;
            this.lb_Perimeter.Location = new System.Drawing.Point(434, 91);
            this.lb_Perimeter.Name = "lb_Perimeter";
            this.lb_Perimeter.Size = new System.Drawing.Size(21, 24);
            this.lb_Perimeter.TabIndex = 9;
            this.lb_Perimeter.Text = "0";
            // 
            // lb_Square
            // 
            this.lb_Square.AutoSize = true;
            this.lb_Square.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_Square.ForeColor = System.Drawing.Color.Red;
            this.lb_Square.Location = new System.Drawing.Point(396, 142);
            this.lb_Square.Name = "lb_Square";
            this.lb_Square.Size = new System.Drawing.Size(21, 24);
            this.lb_Square.TabIndex = 10;
            this.lb_Square.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Rectangular_Triangle.Properties.Resources.Rectangular_Triangle;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(567, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 183);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(784, 261);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lb_Square);
            this.Controls.Add(this.lb_Perimeter);
            this.Controls.Add(this.lb_SideC);
            this.Controls.Add(this.btn_Calculate);
            this.Controls.Add(this.tb_SideB);
            this.Controls.Add(this.tb_SideA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Прямокутний трикутник - Rectangular Triangle";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_SideA;
        private System.Windows.Forms.TextBox tb_SideB;
        private System.Windows.Forms.Button btn_Calculate;
        private System.Windows.Forms.Label lb_SideC;
        private System.Windows.Forms.Label lb_Perimeter;
        private System.Windows.Forms.Label lb_Square;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

