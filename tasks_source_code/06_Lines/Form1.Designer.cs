namespace _06_Lines
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
            this.btb_Lines = new System.Windows.Forms.Button();
            this.pb_Result = new System.Windows.Forms.PictureBox();
            this.btn_Lines_Vertical = new System.Windows.Forms.Button();
            this.btn_Lines_Horizontal = new System.Windows.Forms.Button();
            this.btn_Grid = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_LinesFromClick = new System.Windows.Forms.Button();
            this.pb_BattleField = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chb_SniperBattle = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.trb_Transparent = new System.Windows.Forms.TrackBar();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Result)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_BattleField)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trb_Transparent)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btb_Lines
            // 
            this.btb_Lines.Location = new System.Drawing.Point(0, 0);
            this.btb_Lines.Name = "btb_Lines";
            this.btb_Lines.Size = new System.Drawing.Size(250, 40);
            this.btb_Lines.TabIndex = 0;
            this.btb_Lines.Text = "Lines from coner";
            this.btb_Lines.UseVisualStyleBackColor = true;
            this.btb_Lines.Click += new System.EventHandler(this.btb_Line_Click);
            // 
            // pb_Result
            // 
            this.pb_Result.BackColor = System.Drawing.Color.White;
            this.pb_Result.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pb_Result.Location = new System.Drawing.Point(250, 0);
            this.pb_Result.Name = "pb_Result";
            this.pb_Result.Size = new System.Drawing.Size(256, 162);
            this.pb_Result.TabIndex = 1;
            this.pb_Result.TabStop = false;
            this.pb_Result.Click += new System.EventHandler(this.pb_Result_Click);
            this.pb_Result.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pb_Result_MouseClick);
            this.pb_Result.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pb_Result_MouseDown);
            this.pb_Result.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pb_Result_MouseMove);
            // 
            // btn_Lines_Vertical
            // 
            this.btn_Lines_Vertical.Location = new System.Drawing.Point(0, 46);
            this.btn_Lines_Vertical.Name = "btn_Lines_Vertical";
            this.btn_Lines_Vertical.Size = new System.Drawing.Size(250, 40);
            this.btn_Lines_Vertical.TabIndex = 0;
            this.btn_Lines_Vertical.Text = "Lines Vertical";
            this.btn_Lines_Vertical.UseVisualStyleBackColor = true;
            this.btn_Lines_Vertical.Click += new System.EventHandler(this.btn_Lines_Vertical_Click);
            // 
            // btn_Lines_Horizontal
            // 
            this.btn_Lines_Horizontal.Location = new System.Drawing.Point(0, 92);
            this.btn_Lines_Horizontal.Name = "btn_Lines_Horizontal";
            this.btn_Lines_Horizontal.Size = new System.Drawing.Size(250, 40);
            this.btn_Lines_Horizontal.TabIndex = 2;
            this.btn_Lines_Horizontal.Text = "Lines Horizontal";
            this.btn_Lines_Horizontal.UseVisualStyleBackColor = true;
            this.btn_Lines_Horizontal.Click += new System.EventHandler(this.btn_Lines_Horizontal_Click);
            // 
            // btn_Grid
            // 
            this.btn_Grid.Location = new System.Drawing.Point(0, 138);
            this.btn_Grid.Name = "btn_Grid";
            this.btn_Grid.Size = new System.Drawing.Size(250, 40);
            this.btn_Grid.TabIndex = 2;
            this.btn_Grid.Text = "Grid";
            this.btn_Grid.UseVisualStyleBackColor = true;
            this.btn_Grid.Click += new System.EventHandler(this.btn_Grid_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(0, 184);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(250, 40);
            this.btn_Clear.TabIndex = 3;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_LinesFromClick
            // 
            this.btn_LinesFromClick.Location = new System.Drawing.Point(0, 230);
            this.btn_LinesFromClick.Name = "btn_LinesFromClick";
            this.btn_LinesFromClick.Size = new System.Drawing.Size(250, 40);
            this.btn_LinesFromClick.TabIndex = 4;
            this.btn_LinesFromClick.Text = "Lines from Click";
            this.btn_LinesFromClick.UseVisualStyleBackColor = true;
            this.btn_LinesFromClick.Click += new System.EventHandler(this.btn_LinesFromClick_Click);
            // 
            // pb_BattleField
            // 
            this.pb_BattleField.BackColor = System.Drawing.Color.Black;
            this.pb_BattleField.BackgroundImage = global::_06_Lines.Properties.Resources.sea;
            this.pb_BattleField.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_BattleField.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.pb_BattleField.Location = new System.Drawing.Point(250, 0);
            this.pb_BattleField.Name = "pb_BattleField";
            this.pb_BattleField.Size = new System.Drawing.Size(152, 106);
            this.pb_BattleField.TabIndex = 1;
            this.pb_BattleField.TabStop = false;
            this.pb_BattleField.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pb_BattleField_MouseMove);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.chb_SniperBattle);
            this.panel1.Location = new System.Drawing.Point(0, 704);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 50);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // chb_SniperBattle
            // 
            this.chb_SniperBattle.AutoSize = true;
            this.chb_SniperBattle.Location = new System.Drawing.Point(25, 10);
            this.chb_SniperBattle.Name = "chb_SniperBattle";
            this.chb_SniperBattle.Size = new System.Drawing.Size(134, 28);
            this.chb_SniperBattle.TabIndex = 0;
            this.chb_SniperBattle.Text = "Sniper Battle";
            this.chb_SniperBattle.UseVisualStyleBackColor = true;
            this.chb_SniperBattle.CheckedChanged += new System.EventHandler(this.chb_SniperBattle_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 276);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 40);
            this.button1.TabIndex = 6;
            this.button1.Text = "Fill";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 322);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(250, 40);
            this.button2.TabIndex = 7;
            this.button2.Text = "X, Y";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(0, 368);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(250, 40);
            this.button3.TabIndex = 7;
            this.button3.Text = "X, Y";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.trb_Transparent);
            this.panel2.Location = new System.Drawing.Point(0, 414);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 89);
            this.panel2.TabIndex = 6;
            // 
            // trb_Transparent
            // 
            this.trb_Transparent.Location = new System.Drawing.Point(0, 41);
            this.trb_Transparent.Maximum = 255;
            this.trb_Transparent.Minimum = 1;
            this.trb_Transparent.Name = "trb_Transparent";
            this.trb_Transparent.Size = new System.Drawing.Size(244, 45);
            this.trb_Transparent.TabIndex = 0;
            this.trb_Transparent.Value = 255;
            this.trb_Transparent.Scroll += new System.EventHandler(this.trb_Transparent_Scroll);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.button9);
            this.panel3.Controls.Add(this.button10);
            this.panel3.Controls.Add(this.button11);
            this.panel3.Controls.Add(this.button12);
            this.panel3.Controls.Add(this.button13);
            this.panel3.Controls.Add(this.button8);
            this.panel3.Controls.Add(this.button7);
            this.panel3.Controls.Add(this.button6);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Location = new System.Drawing.Point(0, 509);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 109);
            this.panel3.TabIndex = 7;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(202, 55);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(40, 40);
            this.button9.TabIndex = 9;
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Black;
            this.button10.Location = new System.Drawing.Point(154, 55);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(40, 40);
            this.button10.TabIndex = 8;
            this.button10.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.White;
            this.button11.Location = new System.Drawing.Point(106, 55);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(40, 40);
            this.button11.TabIndex = 7;
            this.button11.UseVisualStyleBackColor = false;
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.Purple;
            this.button12.Location = new System.Drawing.Point(58, 55);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(40, 40);
            this.button12.TabIndex = 6;
            this.button12.UseVisualStyleBackColor = false;
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.Blue;
            this.button13.Location = new System.Drawing.Point(10, 55);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(40, 40);
            this.button13.TabIndex = 5;
            this.button13.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Aqua;
            this.button8.Location = new System.Drawing.Point(202, 9);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(40, 40);
            this.button8.TabIndex = 4;
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Green;
            this.button7.Location = new System.Drawing.Point(154, 9);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(40, 40);
            this.button7.TabIndex = 3;
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Yellow;
            this.button6.Location = new System.Drawing.Point(106, 9);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(40, 40);
            this.button6.TabIndex = 2;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Orange;
            this.button5.Location = new System.Drawing.Point(58, 9);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(40, 40);
            this.button5.TabIndex = 1;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Red;
            this.button4.Location = new System.Drawing.Point(10, 9);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(40, 40);
            this.button4.TabIndex = 0;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(805, 843);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_LinesFromClick);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Grid);
            this.Controls.Add(this.btn_Lines_Horizontal);
            this.Controls.Add(this.pb_BattleField);
            this.Controls.Add(this.pb_Result);
            this.Controls.Add(this.btn_Lines_Vertical);
            this.Controls.Add(this.btb_Lines);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "Form1";
            this.Text = "Lines";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Result)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_BattleField)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trb_Transparent)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btb_Lines;
        private System.Windows.Forms.PictureBox pb_Result;
        private System.Windows.Forms.Button btn_Lines_Vertical;
        private System.Windows.Forms.Button btn_Lines_Horizontal;
        private System.Windows.Forms.Button btn_Grid;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_LinesFromClick;
        private System.Windows.Forms.PictureBox pb_BattleField;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chb_SniperBattle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TrackBar trb_Transparent;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
    }
}

