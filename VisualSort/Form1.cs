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
                    barGraph1.SelectAll(new int[] { j, j-1 });
                    barGraph1.Swap(j, j -1);
                    j -= 1;
                    barGraph1.data = data;
                }
                data[j] = x;
                barGraph1.data = data;
            }
        }

        private void selection_button_Click(object sender, EventArgs e)
        {
            int[] data = barGraph1.data;
            for (int i = 0; i < data.Length; i ++)
            {
                int min = i;
                //select the pivot point
                barGraph1.Select(i);
                for (int j = i + 1; j < data.Length; j++)
                {
                    //select the potential min
                    barGraph1.Select(j);
                    if (data[j] < data[min])
                    {
                        //ignore unselect if first iteration
                        if (j != i+1) barGraph1.UnSelect(min);
                        min = j;
                        //select new min
                        barGraph1.Select(min);
                    }
                    if (j != min)
                    {
                        //we dont care about this index anymore.. so unselect it
                        barGraph1.UnSelect(j);
                    }
                }

                //swap the pivot and min
                barGraph1.Swap(i, min);
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
                        barGraph1.SelectAll(new int[] {j, j+1});
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
