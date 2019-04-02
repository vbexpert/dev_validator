using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace _06_Lines
{
    public partial class Form1 : Form
    {
        Graphics graph;
        Bitmap myBitmap;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Підлаштовуємо розмір Зображення під форму
            pb_Result.Height = this.Height - 30;
            pb_Result.Width = this.Width - 250;
            //створюємо віртуальне зображення: 
            myBitmap = new Bitmap(pb_Result.Width, pb_Result.Size.Height);
            //підключаємо віртуальне зображення до графіки:
            graph = Graphics.FromImage(myBitmap);
            //відображаємо зображення в компонент PictureBox:
        }

        private void btb_Line_Click(object sender, EventArgs e)
        {
            

            pb_Result.Image = myBitmap;

            //створюємо об'єкт пензлик
            Pen penGreen = new Pen(Color.Green, 1);

            //створюємо точки 
            Point point_A = new Point(0, 0);

            
            for (int i = 0; i <= pb_Result.Width; i=i+50)
            {
                Point point_B = new Point(i, pb_Result.Height);
                //малюємо лінію
                graph.DrawLine(penGreen, point_A, point_B);
            }
            

            for (int j = pb_Result.Height; j > 0; j = j - 50)
            {
                Point point_C = new Point(pb_Result.Width, j);
                //малюємо лінію
                graph.DrawLine(penGreen, point_A, point_C);
            }

        }

        private void rb_AntiAliasON_CheckedChanged(object sender, EventArgs e)
        {
            //додаємо зглажування (потрібно підключити using System.Drawing.Drawing2D;)
            graph.SmoothingMode = SmoothingMode.AntiAlias;
            
        }

        private void rb_AntiAliasOF_CheckedChanged(object sender, EventArgs e)
        {
            //ключаємо зглажування (потрібно підключити using System.Drawing.Drawing2D;)
            graph.SmoothingMode = SmoothingMode.None;
            
        }
    }
}
