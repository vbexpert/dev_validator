using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Circle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Calculate_Click(object sender, EventArgs e)
        {
            //Зчитування
            double Radius = double.Parse(tb_Input.Text);
            //Обрахунок
            double Diameter = Radius * 2;
            double Length = 2 * Math.PI * Radius;
            double Square = Math.PI * Math.Pow(Radius,2);
            double Extent =  Math.PI * Math.Pow(Radius,3) * 4 / 3;
            //Виведення
            lb_Radius.Text = Radius.ToString("#.##");
            lb_Diameter.Text = Diameter.ToString("#.##");
            lb_Length.Text = Length.ToString("#.##");
            lb_Square.Text = Square.ToString("#.##");
            lb_Extent.Text = Extent.ToString("#.##");

        }
    }
}
