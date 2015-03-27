using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        private int sleepTime = 100;
        List<int> data = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        public void Draw()
        {
            Graphics g = sort_panel.CreateGraphics();
            Pen p = new Pen(Color.Gray);
            SolidBrush normalBrush = new SolidBrush(Color.Black);
            SolidBrush selectedBrush = new SolidBrush(Color.Red);

            int width = sort_panel.Height / data.Count + 1;
            int height = sort_panel.Width;
            int max = data.Max();

            g.FillRectangle(new SolidBrush(Color.White), new Rectangle(0, 0, sort_panel.Width, sort_panel.Height));

            int x = 0;
            for (int i = 0; i < data.Count; i++)
            {
                g.FillRectangle(normalBrush, new Rectangle(0, x, height * data[i] / max, width));
                g.DrawRectangle(p, new Rectangle(0, x, height * data[i] / max, width));

                x += width;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            data.Clear();

            foreach (String s in textBox1.Lines)
            {
                data.Add(Convert.ToInt32(s));
            }
            Draw();
        }

        private void insertion_button_Click(object sender, EventArgs e)
        {
            List<int> unsorted = data;
            for (int i = 1; i < data.Count; i ++)
            {
                int x = data[i];
                int j = i;
                while (j > 0 && data[j - 1] > x)
                {
                    data[j] = data[j - 1];
                    j -= 1;
                    Draw();
                    Thread.Sleep(sleepTime);
                }
                data[j] = x;
                Draw();
                Thread.Sleep(sleepTime);
            }
        }
    }

}
