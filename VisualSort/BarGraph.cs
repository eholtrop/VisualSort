﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualSort
{
    public partial class BarGraph : UserControl
    {
        private int _sleepTime = 250;
        public int sleepTime
        {
            get { return 250; }
            set { _sleepTime = value; }
        }

        private Graphics graphics
        {
            get { return draw_panel.CreateGraphics(); }
        }

        private int[] mData;
        public int[] data
        {
            set
            {
                mData = value;
                Draw();
            }
            get { return mData; }
        }

        public BarGraph()
        {
            InitializeComponent();
        }

        public async Task SelectRange(int start, int finish)
        {
            for (int i = start; i < finish; i ++)
            {
                drawRectangle(graphics,
                    new SolidBrush(Color.Red),
                    new Pen(Color.Gray),
                    i);
            }
            await Task.Delay(sleepTime);
        }

        public async Task SelectAll(int[] arr)
        {
            foreach (int i in arr)
            {
                drawRectangle(graphics,
                    new SolidBrush(Color.Red),
                    new Pen(Color.Gray),
                    i);
            }
            await Task.Delay(sleepTime);
        }

        public async Task Select(int i)
        {
            drawRectangle(graphics,
                new SolidBrush(Color.Red),
                new Pen(Color.Gray),
                i);
            await Task.Delay(sleepTime);
        }

        public async Task Unselect(int[] arr)
        {
            foreach (int i in arr)
            {
                drawRectangle(graphics,
                    new SolidBrush(Color.Black),
                    new Pen(Color.Gray),
                    i);
            }
            await Task.Delay(sleepTime);
        }

        public void UnSelect(int i)
        {
            drawRectangle(graphics,
                new SolidBrush(Color.Black),
                new Pen(Color.Gray),
                i);
        }

        public int[] Swap(int i, int j)
        {
            int[] d = this.data;

            int temp = d[i];
            d[i] = d[j];
            d[j] = temp;
            data = d;

            return data;
        }

        private void Draw()
        {
            if (data == null)
                return;

            Graphics g = graphics;
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

        private void drawRectangle(Graphics g, Brush b, Pen p, int i)
        {
            int max = data.Max();
            int width = draw_panel.Width / data.Length;
            int height = draw_panel.Height * data[i] / max;
            int startX = i * width;

            g.FillRectangle(b, new Rectangle(startX, draw_panel.Height - height, width, height));
            g.DrawRectangle(p, new Rectangle(startX, draw_panel.Height - height, width, height));
        }
    }
}
