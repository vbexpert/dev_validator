using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07_Rectangular_Triangle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Calculate_Click(object sender, EventArgs e)
        {
            byte SideA = byte.Parse(tb_SideA.Text);
            byte SideB = byte.Parse(tb_SideB.Text);
            //double SideC = Math.Sqrt(Math.Pow(SideA, 2) + Math.Pow(SideB, 2));
            //SideC = Math.Round(SideC, 3);
            double SideC = Math.Round(Math.Sqrt(Math.Pow(SideA, 2) + Math.Pow(SideB, 2)), 3);
            double Perimeter = SideA + SideB + SideC;
            //double Square = 1 / 2.0 * SideA * SideB;
            //Square = Math.Round(Square, 3);
            double Square = Math.Round(1 / 2.0 * SideA * SideB, 3);
            lb_SideC.Text = SideC.ToString();
            lb_Perimeter.Text = Perimeter.ToString();
            lb_Square.Text = Square.ToString();
        }
    }
}
