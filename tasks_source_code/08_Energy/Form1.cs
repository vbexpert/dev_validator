using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08_Energy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_CalculateKinetic_Click(object sender, EventArgs e)
        {
            //Зчитування
            double MassKinetic = double.Parse(tb_InputMassKinetic.Text);
            double SpeedKinetic = double.Parse(tb_InputSpeedKinetic.Text);
            //Обчислення
            double EnergyKinetic = MassKinetic * Math.Pow(SpeedKinetic, 2) / 2;
            //Виведення
            lb_ResultEnergyKinetic.Text = EnergyKinetic.ToString("#.##");
           // label1.Text = tc_Energy.TabPages.Count.ToString();
        }
    }
}
