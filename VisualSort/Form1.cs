using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml;

namespace VisualSort
{
    public partial class Form1 : Form
    {
        private int sleepTime = 50;
        public Form1()
        {
            InitializeComponent();
        }

        private void insertion_button_Click(object sender, EventArgs e)
        {
            int[] data = barGraph1.data;
            for (int i = 1; i < data.Length; i ++)
            {
                int x = data[i];
                int j = i;
                while (j > 0 && data[j - 1] > x)
                {
                    barGraph1.Swap(j, j -1);
                    j -= 1;
                    barGraph1.data = data;
                    Thread.Sleep(sleepTime);
                }
                data[j] = x;
                barGraph1.data = data;
                Thread.Sleep(sleepTime);
            }
        }

        private void selection_button_Click(object sender, EventArgs e)
        {
            int[] data = barGraph1.data;
            for (int i = 0; i < data.Length; i ++)
            {
                int min = i;
                for (int j = i + 1; j < data.Length; j++)
                {
                    barGraph1.Select(j);
                    if (data[j] < data[min])
                    {
                        min = j;
                    }
                }

                barGraph1.Swap(i, min);
                Thread.Sleep(sleepTime);
            }
        }

        private void bubble_button_Click(object sender, EventArgs e)
        {
            int[] data = barGraph1.data;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length - 1; j++)
                {
                    if (data[j] > data[j + 1])
                    {

                        data = barGraph1.Swap(j, j+1);
                    }
                }
            }
        }

        private void populate_random_Click(object sender, EventArgs e)
        {
            int[] data = new int[50];

            Random rand = new Random();
            for (int i = 0; i < data.Length; i ++)
            {
                data[i] = rand.Next(0, 100);
            }

            barGraph1.data = data;
        }

        private void populate_reversed_Click(object sender, EventArgs e)
        {
            int[] data = new int[50];
            int num = data.Length;
            for (int i = 0; i < data.Length; i ++)
            {
                data[i] = num;
                num --;
            }
            barGraph1.data = data;
        }
    }

}
