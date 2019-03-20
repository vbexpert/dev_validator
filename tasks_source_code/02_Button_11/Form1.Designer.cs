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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tb_Input = new System.Windows.Forms.TextBox();
            this.lb_Info = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_Close = new System.Windows.Forms.Button();
            this.lb_Perimeter = new System.Windows.Forms.Label();
            this.lb_Side = new System.Windows.Forms.Label();
            this.lb_Square = new System.Windows.Forms.Label();
            this.btn_Calculate = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_Diagonal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_Input
            // 
            this.tb_Input.Location = new System.Drawing.Point(43, 77);
            this.tb_Input.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tb_Input.Name = "tb_Input";
            this.tb_Input.Size = new System.Drawing.Size(500, 40);
            this.tb_Input.TabIndex = 0;
            this.tb_Input.Text = "0";
            this.tb_Input.TextChanged += new System.EventHandler(this.tb_Input_TextChanged);
            this.tb_Input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Input_KeyPress);
            // 
            // lb_Info
            // 
            this.lb_Info.AutoSize = true;
            this.lb_Info.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_Info.Location = new System.Drawing.Point(78, 28);
            this.lb_Info.Name = "lb_Info";
            this.lb_Info.Size = new System.Drawing.Size(416, 32);
            this.lb_Info.TabIndex = 5;
            this.lb_Info.Text = "Введіть сторону квадрату";
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.LightCoral;
            this.btn_Close.Location = new System.Drawing.Point(43, 475);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(500, 50);
            this.btn_Close.TabIndex = 6;
            this.btn_Close.Text = "Закрити";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // lb_Perimeter
            // 
            this.lb_Perimeter.AutoSize = true;
            this.lb_Perimeter.Location = new System.Drawing.Point(280, 217);
            this.lb_Perimeter.Name = "lb_Perimeter";
            this.lb_Perimeter.Size = new System.Drawing.Size(172, 32);
            this.lb_Perimeter.TabIndex = 7;
            this.lb_Perimeter.Text = "Периметр: ";
            // 
            // lb_Side
            // 
            this.lb_Side.AutoSize = true;
            this.lb_Side.Location = new System.Drawing.Point(280, 162);
            this.lb_Side.Name = "lb_Side";
            this.lb_Side.Size = new System.Drawing.Size(151, 32);
            this.lb_Side.TabIndex = 8;
            this.lb_Side.Text = "Сторона: ";
            this.lb_Side.Click += new System.EventHandler(this.lb_Side_Click);
            // 
            // lb_Square
            // 
            this.lb_Square.AutoSize = true;
            this.lb_Square.Location = new System.Drawing.Point(280, 272);
            this.lb_Square.Name = "lb_Square";
            this.lb_Square.Size = new System.Drawing.Size(130, 32);
            this.lb_Square.TabIndex = 9;
            this.lb_Square.Text = "Площа: ";
            // 
            // btn_Calculate
            // 
            this.btn_Calculate.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_Calculate.Location = new System.Drawing.Point(43, 405);
            this.btn_Calculate.Name = "btn_Calculate";
            this.btn_Calculate.Size = new System.Drawing.Size(500, 50);
            this.btn_Calculate.TabIndex = 6;
            this.btn_Calculate.Text = "Розрахувати";
            this.btn_Calculate.UseVisualStyleBackColor = false;
            this.btn_Calculate.Click += new System.EventHandler(this.btn_Calculate_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(43, 153);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(231, 221);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // lb_Diagonal
            // 
            this.lb_Diagonal.AutoSize = true;
            this.lb_Diagonal.Location = new System.Drawing.Point(280, 327);
            this.lb_Diagonal.Name = "lb_Diagonal";
            this.lb_Diagonal.Size = new System.Drawing.Size(174, 32);
            this.lb_Diagonal.TabIndex = 9;
            this.lb_Diagonal.Text = "Діагональ: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 32F);
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
            this.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Квадрат";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Input;
        private System.Windows.Forms.Label lb_Info;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Label lb_Perimeter;
        private System.Windows.Forms.Label lb_Side;
        private System.Windows.Forms.Label lb_Square;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Calculate;
        private System.Windows.Forms.Label lb_Diagonal;
    }
}

