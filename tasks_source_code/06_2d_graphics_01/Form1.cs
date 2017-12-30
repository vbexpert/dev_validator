using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        //-Не чіпайте код нижче:------------------------------------------------------>
        public Form1()
        { InitializeComponent(); }
        private void button1_Click(object sender, EventArgs e)
        {
            //створюємо віртуальну зображення: 
            Bitmap Zobragennya = new Bitmap(pictureBox1.Width, pictureBox1.Size.Height);

            //створюємо графіку та підключаємо до зображення:
            Graphics Grafika = Graphics.FromImage(Zobragennya);

            //створюємо об'єкт пензлик червоного кольору, завширшки 4 пікселя:
            Pen ChervoniiPenzlyk = new Pen(Color.Red, 4);

            //створюємо точку А з координатами Х=50, Y=50:
            Point Tochka_A = new Point(50, 50);

            //створюємо точку B з координатами Х=50, Y=100:
            Point Tochka_B = new Point(50, 100);

            //Малюэмо Лінію:
            Grafika.DrawLine(ChervoniiPenzlyk, Tochka_A, Tochka_B);

            //Відображаємо зображення в Пікчербокс:
            pictureBox1.Image = Zobragennya;
        }
    }
}
