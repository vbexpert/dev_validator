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
            ((System.ComponentModel.ISupportInitialize)(this.pb_Result)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_BattleField)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btb_Lines
            // 
            this.btb_Lines.Location = new System.Drawing.Point(0, 0);
            this.btb_Lines.Name = "btb_Lines";
            this.btb_Lines.Size = new System.Drawing.Size(250, 50);
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
            this.pb_Result.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pb_Result_MouseMove);
            this.pb_Result.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pb_Result_MouseMove);
            // 
            // btn_Lines_Vertical
            // 
            this.btn_Lines_Vertical.Location = new System.Drawing.Point(0, 56);
            this.btn_Lines_Vertical.Name = "btn_Lines_Vertical";
            this.btn_Lines_Vertical.Size = new System.Drawing.Size(250, 50);
            this.btn_Lines_Vertical.TabIndex = 0;
            this.btn_Lines_Vertical.Text = "Lines Vertical";
            this.btn_Lines_Vertical.UseVisualStyleBackColor = true;
            this.btn_Lines_Vertical.Click += new System.EventHandler(this.btn_Lines_Vertical_Click);
            // 
            // btn_Lines_Horizontal
            // 
            this.btn_Lines_Horizontal.Location = new System.Drawing.Point(0, 112);
            this.btn_Lines_Horizontal.Name = "btn_Lines_Horizontal";
            this.btn_Lines_Horizontal.Size = new System.Drawing.Size(250, 50);
            this.btn_Lines_Horizontal.TabIndex = 2;
            this.btn_Lines_Horizontal.Text = "Lines Horizontal";
            this.btn_Lines_Horizontal.UseVisualStyleBackColor = true;
            this.btn_Lines_Horizontal.Click += new System.EventHandler(this.btn_Lines_Horizontal_Click);
            // 
            // btn_Grid
            // 
            this.btn_Grid.Location = new System.Drawing.Point(0, 168);
            this.btn_Grid.Name = "btn_Grid";
            this.btn_Grid.Size = new System.Drawing.Size(250, 50);
            this.btn_Grid.TabIndex = 2;
            this.btn_Grid.Text = "Grid";
            this.btn_Grid.UseVisualStyleBackColor = true;
            this.btn_Grid.Click += new System.EventHandler(this.btn_Grid_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(0, 224);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(250, 50);
            this.btn_Clear.TabIndex = 3;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_LinesFromClick
            // 
            this.btn_LinesFromClick.Location = new System.Drawing.Point(0, 280);
            this.btn_LinesFromClick.Name = "btn_LinesFromClick";
            this.btn_LinesFromClick.Size = new System.Drawing.Size(250, 50);
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
            this.panel1.Location = new System.Drawing.Point(0, 333);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 50);
            this.panel1.TabIndex = 5;
            // 
            // chb_SniperBattle
            // 
            this.chb_SniperBattle.AutoSize = true;
            this.chb_SniperBattle.Location = new System.Drawing.Point(25, 10);
            this.chb_SniperBattle.Name = "chb_SniperBattle";
            this.chb_SniperBattle.Size = new System.Drawing.Size(188, 35);
            this.chb_SniperBattle.TabIndex = 0;
            this.chb_SniperBattle.Text = "Sniper Battle";
            this.chb_SniperBattle.UseVisualStyleBackColor = true;
            this.chb_SniperBattle.CheckedChanged += new System.EventHandler(this.chb_SniperBattle_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "Form1";
            this.Text = "Lines";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Result)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_BattleField)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
    }
}

