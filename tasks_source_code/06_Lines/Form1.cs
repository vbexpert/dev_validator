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
        Pen myGreenPen;
        SolidBrush myRedBrush;
        Color selectedColor;
        int a;
        int b;
        int tranparent;
        int lineThikness;

        public Form1()
        {
            InitializeComponent();
        }
        //завантаження форми, створення об'єкту графіки
        private void Form1_Load(object sender, EventArgs e)
        {
            //Підлаштовуємо розмір Зображення під форму
            pb_Result.Width = this.Width - 250;
            pb_Result.Height = this.Height - 35;

            //
            pb_BattleField.Width = this.Width - 250;
            pb_BattleField.Height = this.Height - 35;
            pb_BattleField.Visible = false;
            
            //створюємо віртуальне зображення: 
            myBitmap = new Bitmap(pb_Result.Width, pb_Result.Size.Height);
            //підключаємо віртуальне зображення до графіки:
            graph = Graphics.FromImage(myBitmap);
            //створюємо об'єкт пензлик
            lineThikness = 1;
            myGreenPen = new Pen(Color.Green, lineThikness);
            //початковий колір заливки
            selectedColor = button4.BackColor;
            //початкова прозорість
            tranparent = 255;
        }

        //малювання ліній з кута
        private void btb_Line_Click(object sender, EventArgs e)
        {
            graph.Clear(Color.White);
            //відображаємо зображення в компонент PictureBox:
            pb_Result.Image = myBitmap;            

            //створюємо точки 
            Point point_A = new Point(0, 0);
            
            for (int i = 0; i <= pb_Result.Width; i=i+50)
            {
                Point point_B = new Point(i, pb_Result.Height);
                //малюємо лінію
                graph.DrawLine(myGreenPen, point_A, point_B);
            }
            

            for (int j = pb_Result.Height; j > 0; j = j - 50)
            {
                Point point_C = new Point(pb_Result.Width, j);
                //малюємо лінію
                graph.DrawLine(myGreenPen, point_A, point_C);
            }

        }
        
        //малювання вертикальних ліній
        private void btn_Lines_Vertical_Click(object sender, EventArgs e)
        {
            graph.Clear(Color.White);
            //відображаємо зображення в компонент PictureBox:
            pb_Result.Image = myBitmap;
            
            //обраховуємо крок зміщення ліній
            int step = 50;

            for (int i = 0; i <= pb_Result.Width; i = i + step)
            {
                //створюємо точки
                Point point_A = new Point(i, 0);
                Point point_B = new Point(i, pb_Result.Height);
                //малюємо лінію
                graph.DrawLine(myGreenPen, point_A, point_B);
            }
        }

        //малювання горизонтальних ліній
        private void btn_Lines_Horizontal_Click(object sender, EventArgs e)
        {
            graph.Clear(Color.White);
            //відображаємо зображення в компонент PictureBox:
            pb_Result.Image = myBitmap;

            //обраховуємо крок зміщення ліній
            int step = 50;

            for (int i = 0; i <= pb_Result.Height; i = i + step)
            {
                //створюємо точки
                Point point_A = new Point(0, i);
                Point point_B = new Point(pb_Result.Width, i);
                //малюємо лінію
                graph.DrawLine(myGreenPen, point_A, point_B);
            }
        }

        //малювання сітки
        private void btn_Grid_Click(object sender, EventArgs e)
        {
            //очищуєуємо полотно
            graph.Clear(Color.White);
            //відображаємо зображення в компонент PictureBox:
            pb_Result.Image = myBitmap;

            //обраховуємо крок зміщення ліній
            int step = 50;

            for (int i = 0; i <= pb_Result.Height; i = i + step)
            {
                //створюємо точки
                Point point_A = new Point(0, i);
                Point point_B = new Point(pb_Result.Width, i);
                //малюємо лінію
                graph.DrawLine(myGreenPen, point_A, point_B);
            }

            for (int i = 0; i <= pb_Result.Width; i = i + step)
            {
                //створюємо точки
                Point point_A = new Point(i, 0);
                Point point_B = new Point(i, pb_Result.Height);
                //малюємо лінію
                graph.DrawLine(myGreenPen, point_A, point_B);
            }
        }

        //очищення 
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            //відображаємо зображення в компонент PictureBox:
            pb_Result.Image = myBitmap;
            graph.Clear(Color.White);
        }

        //малювання прицілу
        private void Aim(int a,int b)
        {
            //очищуєуємо полотно
            graph.Clear(Color.FromArgb(0, 255, 0, 0));
            //відображаємо зображення в компонент PictureBox:
            //pb_BattleField.BackgroundImage.
            pb_BattleField.Image = myBitmap;
            //малюємо приціл
            graph.DrawEllipse(myGreenPen, a - 50, b - 50, 100, 100);
            graph.DrawEllipse(myGreenPen, a - 2, b - 2, 4, 4);
            graph.DrawLine(myGreenPen,a-100,b,a-50,b);
            graph.DrawLine(myGreenPen, a + 50, b, a + 100, b);
        }


        
        //рух приціла над полем бою
        private void pb_BattleField_MouseMove(object sender, MouseEventArgs e)
        {
            Aim(e.X, e.Y);
        }
 
        //включення режиму снайперської битви
        private void chb_SniperBattle_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_SniperBattle.Checked)
            {
                pb_BattleField.Visible = true;
            }
            else
            {
                pb_BattleField.Visible = false;
                graph.Clear(Color.Black);
            }
        }

        //лінії з точки кліка мишкою
        private void btn_LinesFromClick_Click(object sender, EventArgs e)
        {

        }
        
        private void pb_Result_Click(object sender, EventArgs e)
        {
            fillCell();
        }

        //зафарбовування клітинок
        private void fillCell()
        {
            //встановлення заливки
            myRedBrush = new SolidBrush(Color.FromArgb(tranparent, selectedColor));
            graph.FillRectangle(myRedBrush, a, b, 50, 50);
            //відображаємо зображення в компонент PictureBox:
            pb_Result.Image = myBitmap;
        }

        private void pb_Result_MouseDown(object sender, MouseEventArgs e)
        {

        }
        //встановлення прозорості заливки
        private void trb_Transparent_Scroll(object sender, EventArgs e)
        {
            tranparent = trb_Transparent.Value;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //рух над полем для малювання
        private void pb_Result_MouseMove(object sender, MouseEventArgs e)
        {

            //if (e.Button == MouseButtons.Left)
            //{                
            // pb_Result_MouseClick(sender, e); 
            //}

            button2.Text = e.X.ToString() + " : " + e.Y.ToString();
            //button3.Text = a.ToString() + " : " + b.ToString();

        }
        private void pb_Result_MouseClick(object sender, MouseEventArgs e)
        {
            a = e.X / 50 * 50;
            b = e.Y / 50 * 50;
            fillCell();
        }
    }
}
