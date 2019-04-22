using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07_Square
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Calculate_Click(object sender, EventArgs e)
        {
            //Ініціалізація сторони та її зчитування
            double Side = double.Parse(tb_Input.Text);
            //Ініціалізація периметра, площі та діагоналі та їх обрахунок 
            double Perimeter = Side * 4;
            double Square = Side * Side;
            double Diagonal = Side * Math.Pow(2, 0.5);
            //Виведення сторони, периметра, площі та діагоналі
            lb_Side.Text = "Сторона: " + Side.ToString("#.##");
            lb_Perimeter.Text = "Периметр: " + Perimeter.ToString("#.##");
            lb_Square.Text = "Площа: " + Square.ToString("#.##");
            lb_Diagonal.Text = "Діагональ: " + Diagonal.ToString("#.##");
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tb_Input_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((number < 48 || number > 57) && number != 8)
            {
                e.Handled = true;
            }
        }
    }
}
