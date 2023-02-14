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
            this.btn_MouseCoordinates = new System.Windows.Forms.Button();
            this.btn_MouseRoundCoordinates = new System.Windows.Forms.Button();
            this.trb_Transparent = new System.Windows.Forms.TrackBar();
            this.panel_Color = new System.Windows.Forms.Panel();
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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.btn_ColorRandomize = new System.Windows.Forms.Button();
            this.btn_RandomFillGrid = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Result)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_BattleField)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trb_Transparent)).BeginInit();
            this.panel_Color.SuspendLayout();
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
            this.pb_Result.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pb_Result_MouseClick);
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
            // btn_MouseCoordinates
            // 
            this.btn_MouseCoordinates.Location = new System.Drawing.Point(0, 322);
            this.btn_MouseCoordinates.Name = "btn_MouseCoordinates";
            this.btn_MouseCoordinates.Size = new System.Drawing.Size(250, 40);
            this.btn_MouseCoordinates.TabIndex = 7;
            this.btn_MouseCoordinates.Text = "X, Y";
            this.btn_MouseCoordinates.UseVisualStyleBackColor = true;
            // 
            // btn_MouseRoundCoordinates
            // 
            this.btn_MouseRoundCoordinates.Location = new System.Drawing.Point(0, 368);
            this.btn_MouseRoundCoordinates.Name = "btn_MouseRoundCoordinates";
            this.btn_MouseRoundCoordinates.Size = new System.Drawing.Size(250, 40);
            this.btn_MouseRoundCoordinates.TabIndex = 7;
            this.btn_MouseRoundCoordinates.Text = "X, Y";
            this.btn_MouseRoundCoordinates.UseVisualStyleBackColor = true;
            // 
            // trb_Transparent
            // 
            this.trb_Transparent.Location = new System.Drawing.Point(6, 61);
            this.trb_Transparent.Maximum = 255;
            this.trb_Transparent.Minimum = 1;
            this.trb_Transparent.Name = "trb_Transparent";
            this.trb_Transparent.Size = new System.Drawing.Size(244, 45);
            this.trb_Transparent.TabIndex = 0;
            this.trb_Transparent.Value = 255;
            this.trb_Transparent.Scroll += new System.EventHandler(this.trb_Transparent_Scroll);
            // 
            // panel_Color
            // 
            this.panel_Color.BackColor = System.Drawing.SystemColors.Control;
            this.panel_Color.Controls.Add(this.btn_ColorRandomize);
            this.panel_Color.Controls.Add(this.button16);
            this.panel_Color.Controls.Add(this.button17);
            this.panel_Color.Controls.Add(this.button18);
            this.panel_Color.Controls.Add(this.button19);
            this.panel_Color.Controls.Add(this.button2);
            this.panel_Color.Controls.Add(this.button3);
            this.panel_Color.Controls.Add(this.button14);
            this.panel_Color.Controls.Add(this.button15);
            this.panel_Color.Controls.Add(this.trb_Transparent);
            this.panel_Color.Controls.Add(this.button9);
            this.panel_Color.Controls.Add(this.button10);
            this.panel_Color.Controls.Add(this.button11);
            this.panel_Color.Controls.Add(this.button12);
            this.panel_Color.Controls.Add(this.button13);
            this.panel_Color.Controls.Add(this.button8);
            this.panel_Color.Controls.Add(this.button7);
            this.panel_Color.Controls.Add(this.button6);
            this.panel_Color.Controls.Add(this.button5);
            this.panel_Color.Controls.Add(this.button4);
            this.panel_Color.Location = new System.Drawing.Point(0, 509);
            this.panel_Color.Name = "panel_Color";
            this.panel_Color.Size = new System.Drawing.Size(250, 159);
            this.panel_Color.TabIndex = 7;
            // 
            // button9
            // 
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Location = new System.Drawing.Point(87, 24);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(20, 20);
            this.button9.TabIndex = 9;
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Black;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Location = new System.Drawing.Point(1, 24);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(20, 20);
            this.button10.TabIndex = 8;
            this.button10.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.White;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Location = new System.Drawing.Point(1, 3);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(20, 20);
            this.button11.TabIndex = 7;
            this.button11.UseVisualStyleBackColor = false;
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.Purple;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Location = new System.Drawing.Point(22, 24);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(20, 20);
            this.button12.TabIndex = 6;
            this.button12.UseVisualStyleBackColor = false;
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.Blue;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Location = new System.Drawing.Point(65, 24);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(20, 20);
            this.button13.TabIndex = 5;
            this.button13.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Aqua;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(43, 24);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(20, 20);
            this.button8.TabIndex = 4;
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Green;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(87, 3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(20, 20);
            this.button7.TabIndex = 3;
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Yellow;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(65, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(20, 20);
            this.button6.TabIndex = 2;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Orange;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(43, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(20, 20);
            this.button5.TabIndex = 1;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Red;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(22, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(20, 20);
            this.button4.TabIndex = 0;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DeepPink;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(130, 24);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(20, 20);
            this.button2.TabIndex = 13;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Violet;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(108, 24);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(20, 20);
            this.button3.TabIndex = 12;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.DarkTurquoise;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Location = new System.Drawing.Point(130, 3);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(20, 20);
            this.button14.TabIndex = 11;
            this.button14.UseVisualStyleBackColor = false;
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.Lime;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.Location = new System.Drawing.Point(108, 3);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(20, 20);
            this.button15.TabIndex = 10;
            this.button15.UseVisualStyleBackColor = false;
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.SlateBlue;
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button16.Location = new System.Drawing.Point(175, 24);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(20, 20);
            this.button16.TabIndex = 17;
            this.button16.UseVisualStyleBackColor = false;
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.OliveDrab;
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button17.Location = new System.Drawing.Point(153, 24);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(20, 20);
            this.button17.TabIndex = 16;
            this.button17.UseVisualStyleBackColor = false;
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.Magenta;
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button18.Location = new System.Drawing.Point(175, 3);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(20, 20);
            this.button18.TabIndex = 15;
            this.button18.UseVisualStyleBackColor = false;
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.Color.Maroon;
            this.button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button19.Location = new System.Drawing.Point(153, 3);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(20, 20);
            this.button19.TabIndex = 14;
            this.button19.UseVisualStyleBackColor = false;
            // 
            // btn_ColorRandomize
            // 
            this.btn_ColorRandomize.BackColor = System.Drawing.Color.Magenta;
            this.btn_ColorRandomize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ColorRandomize.Location = new System.Drawing.Point(200, 3);
            this.btn_ColorRandomize.Name = "btn_ColorRandomize";
            this.btn_ColorRandomize.Size = new System.Drawing.Size(46, 41);
            this.btn_ColorRandomize.TabIndex = 18;
            this.btn_ColorRandomize.UseVisualStyleBackColor = false;
            this.btn_ColorRandomize.Click += new System.EventHandler(this.btn_ColorRandomize_Click);
            // 
            // btn_RandomFillGrid
            // 
            this.btn_RandomFillGrid.Location = new System.Drawing.Point(0, 414);
            this.btn_RandomFillGrid.Name = "btn_RandomFillGrid";
            this.btn_RandomFillGrid.Size = new System.Drawing.Size(250, 39);
            this.btn_RandomFillGrid.TabIndex = 19;
            this.btn_RandomFillGrid.Text = "Random Fill Grid";
            this.btn_RandomFillGrid.UseVisualStyleBackColor = true;
            this.btn_RandomFillGrid.Click += new System.EventHandler(this.btn_RandomFillGrid_Click);
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(6, 457);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(51, 46);
            this.button20.TabIndex = 19;
            this.button20.Text = "button20";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(65, 457);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(51, 46);
            this.button21.TabIndex = 19;
            this.button21.Text = "button20";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(122, 457);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(51, 46);
            this.button22.TabIndex = 20;
            this.button22.Text = "button20";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(805, 749);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.btn_RandomFillGrid);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.panel_Color);
            this.Controls.Add(this.btn_MouseRoundCoordinates);
            this.Controls.Add(this.btn_MouseCoordinates);
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
            ((System.ComponentModel.ISupportInitialize)(this.trb_Transparent)).EndInit();
            this.panel_Color.ResumeLayout(false);
            this.panel_Color.PerformLayout();
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
        private System.Windows.Forms.Button btn_MouseCoordinates;
        private System.Windows.Forms.Button btn_MouseRoundCoordinates;
        private System.Windows.Forms.TrackBar trb_Transparent;
        private System.Windows.Forms.Panel panel_Color;
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
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button btn_ColorRandomize;
        private System.Windows.Forms.Button btn_RandomFillGrid;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
    }
}

