using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace VisualSort
{
    public partial class Form1 : Form
    {
        int[] data = new int[] { 1, 2, 3, 4, 5 };


        public Form1()
        {
            InitializeComponent();
        }

        public void Draw(int[] data)
        {
            this.data = data;
            sort_panel.Invalidate();
        }

        private void sort_panel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = sort_panel.CreateGraphics();
            Pen p = new Pen(Color.Gray);
            SolidBrush normalBrush = new SolidBrush(Color.Black);
            SolidBrush selectedBrush = new SolidBrush(Color.Red); 
            
            int width = sort_panel.Height / data.Length + 1;
            int height = sort_panel.Width;
            int max = data.Max();

            int x = 0;
            for (int i = 0; i < data.Length; i++)
            {
                g.FillRectangle(normalBrush, new Rectangle(0, x, height * data[i] / max, width));
                g.DrawRectangle(p, new Rectangle(0, x, height * data[i] / max, width));

                x += width;
            }
        }
    }

}
