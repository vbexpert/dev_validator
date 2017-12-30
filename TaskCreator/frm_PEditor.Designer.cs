namespace TaskCreator
{
    partial class frm_PEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_PEditor));
            this.cb_save = new System.Windows.Forms.Button();
            this.tb_property = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cb_save
            // 
            this.cb_save.Location = new System.Drawing.Point(183, 43);
            this.cb_save.Name = "cb_save";
            this.cb_save.Size = new System.Drawing.Size(170, 31);
            this.cb_save.TabIndex = 0;
            this.cb_save.Text = "Save";
            this.cb_save.UseVisualStyleBackColor = true;
            this.cb_save.Click += new System.EventHandler(this.cb_save_Click);
            // 
            // tb_property
            // 
            this.tb_property.Location = new System.Drawing.Point(12, 12);
            this.tb_property.Name = "tb_property";
            this.tb_property.Size = new System.Drawing.Size(515, 20);
            this.tb_property.TabIndex = 1;
            // 
            // frm_PEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 86);
            this.Controls.Add(this.tb_property);
            this.Controls.Add(this.cb_save);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_PEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Property Editor:";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cb_save;
        public System.Windows.Forms.TextBox tb_property;
    }
}