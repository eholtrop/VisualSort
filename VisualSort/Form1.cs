using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml;

namespace VisualSort
{
    public partial class Form1 : Form
    {
        private int sleepTime = 50;
        private int[] data;
        public Form1()
        {
            InitializeComponent();
        }

        public void Draw()
        {
            Graphics g = sort_panel.CreateGraphics();
            Pen p = new Pen(Color.Gray);
            SolidBrush b = new SolidBrush(Color.Black);

            int max = data.Max();

            g.Clear(Color.White);

            int x = 0;
            for (int i = 0; i < data.Length; i++)
            {
                drawRectangle(g, b, p, i);
            }
        }

        public void Select(int i)
        {
            drawRectangle(sort_panel.CreateGraphics(), 
                new SolidBrush(Color.Red), 
                new Pen(Color.Gray),
                i);

            Thread.Sleep(sleepTime);
        }

        public void Swap(int i, int j)
        {
            Select(i);
            Select(j);

            int temp = data[i];
            data[i] = data[j];
            data[j] = temp;
            Draw();
            Thread.Sleep(sleepTime);
        }

        public void drawRectangle(Graphics g, Brush b, Pen p, int i)
        {
            int max = data.Max();
            int width = sort_panel.Width/data.Length;
            int height = sort_panel.Height * data[i] / max;
            int startX = i * width;

            g.FillRectangle(b, new Rectangle(startX, sort_panel.Height - height, width, height));
            g.DrawRectangle(p, new Rectangle(startX, sort_panel.Height - height, width, height));
        }

        private void insertion_button_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < data.Length; i ++)
            {
                int x = data[i];
                int j = i;
                while (j > 0 && data[j - 1] > x)
                {
                    Swap(j, j -1);
                    j -= 1;
                    Draw();
                    Thread.Sleep(sleepTime);
                }
                data[j] = x;
                Draw();
                Thread.Sleep(sleepTime);
            }
        }

        private void selection_button_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < data.Length; i ++)
            {
                int min = i;
                for (int j = i + 1; j < data.Length; j++)
                {
                    Select(j);
                    if (data[j] < data[min])
                    {
                        min = j;
                    }
                }

                Swap(i, min);
                Thread.Sleep(sleepTime);
            }
        }

        private void populate_random_Click(object sender, EventArgs e)
        {
            data = new int[50];

            Random rand = new Random();
            for (int i = 0; i < data.Length; i ++)
            {
                data[i] = rand.Next(0, 100);
            }

            Draw();
        }

        private void populate_almost_sorted_Click(object sender, EventArgs e)
        {

        }

        private void populate_reversed_Click(object sender, EventArgs e)
        {
            data = new int[50];
            int num = data.Length;
            for (int i = 0; i < data.Length; i ++)
            {
                data[i] = num;
                num --;
            }
            Draw();
        }
    }

}
