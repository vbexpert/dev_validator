using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        
        private void tb_Input_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if((number < 48 || number > 57) && number !=8)
                {
                    e.Handled = true;
                }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Calculate_Click(object sender, EventArgs e)
        {
            int Side = int.Parse(tb_Input.Text);
            //Обрахунок 
            int Perimeter = Side * 4;
            int Square = Side * Side;
            double Diagonal = Side * Math.Pow(2, .5);
            //Виведення 
            lb_Side.Text = "Сторона: " + Side.ToString();
            lb_Perimeter.Text = "Периметр: " + Perimeter.ToString();
            lb_Square.Text = "Площа: " + Square.ToString();
            lb_Diagonal.Text = "Діагональ: " + Diagonal.ToString();
                                          
        }

        private void lb_Side_Click(object sender, EventArgs e)
        {

        }

        private void tb_Input_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
