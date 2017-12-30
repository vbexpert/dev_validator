using System;
using System.Windows.Forms;
namespace TaskCreator
{
    public partial class frm_PEditor : Form
    {
        public int i_p_idx = 0;
        public ListBox lb;
        public frm_PEditor()
        {
            InitializeComponent();
        }
        private void cb_save_Click(object sender, EventArgs e)
        {
            lb.Items.RemoveAt(i_p_idx);
            lb.Items.Insert(i_p_idx, this.tb_property.Text);
            this.Close();
        }
    }
}
