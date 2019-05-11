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
        Pen myGridPen;
        SolidBrush myRedBrush;
        Color selectedColor;
        int a;
        int b;
        int tranparent;
        int lineThikness;
        int step;
        int shape;

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
            myGridPen = new Pen(Color.DarkGray, lineThikness);
            //початковий колір заливки
            selectedColor = Color.White;
            //початкова прозорість
            tranparent = 255;
            //розмір клітинок
            step = 50;

            //процедура вибору кольору
            //подія програмно додається до всіх кнопок на панелі кольорів
            foreach (var control in this.panel_Color.Controls)
            {
                if (control is Button)
                {
                    ((Button)control).Click += new System.EventHandler(button_Click); ;
                }

            }

            
            
        }

        //випадкове встановлення кольору для палітри кольорів
        private void btn_ColorRandomize_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            foreach (var control in this.panel_Color.Controls)
                {                    
                    Color randomColor = Color.FromArgb(255, rnd.Next(256), rnd.Next(256), rnd.Next(256));
                    if (control is Button)
                    {
                        ((Button)control).BackColor = randomColor;
                    }

                }
        }

        //малювання ліній з кута
        private void btb_Line_Click(object sender, EventArgs e)
        {
            graph.Clear(Color.White);
            //відображаємо зображення в компонент PictureBox:
            pb_Result.Image = myBitmap;            

            //створюємо точки 
            Point point_A = new Point(0, 0);
            
            for (int i = 0; i <= pb_Result.Width; i=i+ step)
            {
                Point point_B = new Point(i, pb_Result.Height);
                //малюємо лінію
                graph.DrawLine(myGridPen, point_A, point_B);
            }
            

            for (int j = pb_Result.Height; j > 0; j = j - step)
            {
                Point point_C = new Point(pb_Result.Width, j);
                //малюємо лінію
                graph.DrawLine(myGridPen, point_A, point_C);
            }

        }
        
        //малювання вертикальних ліній
        private void btn_Lines_Vertical_Click(object sender, EventArgs e)
        {
            graph.Clear(Color.White);
            //відображаємо зображення в компонент PictureBox:
            pb_Result.Image = myBitmap;
  
            for (int i = 0; i <= pb_Result.Width; i = i + step)
            {
                //створюємо точки
                Point point_A = new Point(i, 0);
                Point point_B = new Point(i, pb_Result.Height);
                //малюємо лінію
                graph.DrawLine(myGridPen, point_A, point_B);
            }
        }

        //малювання горизонтальних ліній
        private void btn_Lines_Horizontal_Click(object sender, EventArgs e)
        {
            graph.Clear(Color.White);
            //відображаємо зображення в компонент PictureBox:
            pb_Result.Image = myBitmap;

            for (int i = 0; i <= pb_Result.Height; i = i + step)
            {
                //створюємо точки
                Point point_A = new Point(0, i);
                Point point_B = new Point(pb_Result.Width, i);
                //малюємо лінію
                graph.DrawLine(myGridPen, point_A, point_B);
            }
        }

        //малювання сітки
        private void btn_Grid_Click(object sender, EventArgs e)
        {
            //очищуєуємо полотно
            graph.Clear(Color.White);
            //відображаємо зображення в компонент PictureBox:
            pb_Result.Image = myBitmap;

            for (int i = 0; i <= pb_Result.Height; i = i + step)
            {
                //створюємо точки
                Point point_A = new Point(0, i);
                Point point_B = new Point(pb_Result.Width, i);
                //малюємо лінію
                graph.DrawLine(myGridPen, point_A, point_B);
            }

            for (int i = 0; i <= pb_Result.Width; i = i + step)
            {
                //створюємо точки
                Point point_A = new Point(i, 0);
                Point point_B = new Point(i, pb_Result.Height);
                //малюємо лінію
                graph.DrawLine(myGridPen, point_A, point_B);
            }
        }

        //очищення 
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            //відображаємо зображення в компонент PictureBox:
            pb_Result.Image = myBitmap;
            graph.Clear(Color.White);
        }

        //очищення сітки
        void clearGrid()
        {
            //відображаємо зображення в компонент PictureBox:
            pb_Result.Image = myBitmap;
            graph.Clear(Color.White);
        }

        //лінії з точки кліка мишкою
        private void btn_LinesFromClick_Click(object sender, EventArgs e)
        {

        }

        //вибір кольору на палітрі кольорів
        void button_Click(object sender, EventArgs e)
        {
            selectedColor = ((Button)sender).BackColor;
        }
 
        //зафарбовування клітинок
        private void fillCell()
        {
            //встановлення заливки
            myRedBrush = new SolidBrush(Color.FromArgb(tranparent, selectedColor));
            switch (shape)
            {
                case 1:
                    graph.FillEllipse(myRedBrush, a + 1, b + 1, step - 1, step - 1);
                    break;
                case 2:
                    graph.FillRectangle(myRedBrush, a + 1, b + 1, step - 1, step - 1);
                    break;
                case 3:
                    graph.FillPie(myRedBrush, a + 1, b + 1, step - 1, step - 1, 0, 180);
                    break;
                default:
                    
                    break;
            }
            

            //
            //відображаємо зображення в компонент PictureBox:
            pb_Result.Image = myBitmap;
        }

         //встановлення прозорості заливки
        private void trb_Transparent_Scroll(object sender, EventArgs e)
        {
            tranparent = trb_Transparent.Value;
        }

        //визначення координат при русі над полем для малювання
        private void pb_Result_MouseMove(object sender, MouseEventArgs e)
        {
            btn_MouseCoordinates.Text = e.X.ToString() + " : " + e.Y.ToString();

            //округлення та відображення координат
            a = e.X / 50 * 50;
            b = e.Y / 50 * 50;
            btn_MouseRoundCoordinates.Text = a.ToString() + " : " + b.ToString();

        }

        //малювання прямокутників у точці кліку мишкою
        private void pb_Result_MouseClick(object sender, MouseEventArgs e)
        {
            fillCell();
        }

        //Випадкове заповнення поля різнокольоровими квадратиками
        void randomFillGrid()
        {
            clearGrid();
            Random rnd = new Random();
            for (int i=1;i<2000; i++)
            {
                a = rnd.Next(0, pb_Result.Width) / 50 * 50;
                b = rnd.Next(0, pb_Result.Height) / 50 * 50;
                tranparent = rnd.Next(0, 255);
                selectedColor = Color.FromArgb(tranparent, rnd.Next(256), rnd.Next(256), rnd.Next(256));
                fillCell();
            }
            
        }

        //активація випадкового заповнення сітки кольоровими об'єктами
        private void btn_RandomFillGrid_Click(object sender, EventArgs e)
        {
            randomFillGrid();
        }

        ///////////////////////////////////////////////
        ///////////////////////////////////////////////
        ///////                             ///////////
        ///////          Морський бій       ///////////
        ///////                             ///////////
        ///////////////////////////////////////////////
        ///////////////////////////////////////////////


        //малювання прицілу
        private void Aim(int a, int b)
        {
            //очищуєуємо полотно
            graph.Clear(Color.FromArgb(0, 255, 0, 0));
            //відображаємо зображення в компонент PictureBox:
            //pb_BattleField.BackgroundImage.
            pb_BattleField.Image = myBitmap;
            //малюємо приціл
            graph.DrawEllipse(myGridPen, a - 50, b - 50, 100, 100);
            graph.DrawEllipse(myGridPen, a - 2, b - 2, 4, 4);
            graph.DrawLine(myGridPen, a - 100, b, a - 50, b);
            graph.DrawLine(myGridPen, a + 50, b, a + 100, b);
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
        //коло
        private void button20_Click(object sender, EventArgs e)
        {
            shape = 1;
        }
        //прямокутник
        private void button21_Click(object sender, EventArgs e)
        {
            shape = 2;
        }
        //сектор
        private void button22_Click(object sender, EventArgs e)
        {
            shape = 3;
        }
    }
}
