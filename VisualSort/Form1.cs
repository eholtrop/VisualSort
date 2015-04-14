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
using System.Threading.Tasks;
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

        private async void populate_random_Click(object sender, EventArgs e)
        {
            barGraph1.data = await GenerateRandomDataAsync(50, 0, 100);
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

        #region BUTTON EVENTS

        private async void sort_button_Clicked(object sender, EventArgs e)
        {
            var data = barGraph1.data;

            if (sender as Button == insertion_button)
                data = await InsertionSortAsync();
            else if (sender as Button == selection_button)
                data = await InsertionSortAsync();
            else if (sender as Button == bubble_button)
                data = await BubbleSortAsync(barGraph1);
            else if (sender as Button == shell_button)
                data = await ShellSortAsync();
            else if (sender as Button == merge_button)
                data = await MergeSortAsync(data, 0, data.Length);

            if (data != null)
                barGraph1.data = data;
        }
        #endregion

        #region DATA GENERATION
        private async Task<int[]> GenerateRandomDataAsync(int num, int min, int max)
        {
            int[] data = new int[num];

            Random rand = new Random();
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = rand.Next(min, max);
            }

            return data;
        }
        #endregion

        #region SORTING IMPLMENTATIONS
        #region INSERTION SORT
        private async Task<int[]> InsertionSortAsync()
        {
            int[] data = barGraph1.data;
            for (int i = 1; i < data.Length; i++)
            {
                int x = data[i];
                int j = i;
                while (j > 0 && data[j - 1] > x)
                {
                    await barGraph1.SelectAll(new int[] { j, j - 1 });
                    barGraph1.Swap(j, j - 1);
                    j -= 1;
                    barGraph1.data = data;
                }
                data[j] = x;
                barGraph1.data = data;
            }

            return data;
        }
        #endregion

        #region SELECTION SORT
        private async Task<int[]> SelectionSortAsync()
        {
            int[] data = barGraph1.data;
            for (int i = 0; i < data.Length; i++)
            {
                int min = i;
                //select the pivot point
                await barGraph1.Select(i);
                for (int j = i + 1; j < data.Length; j++)
                {
                    //select the potential min
                    await barGraph1.Select(j);
                    if (data[j] < data[min])
                    {
                        //ignore unselect if first iteration
                        if (j != i + 1) barGraph1.UnSelect(min);
                        min = j;
                    }
                    if (j != min)
                    {
                        //we dont care about this index anymore.. so unselect it
                        barGraph1.UnSelect(j);
                    }
                }

                //swap the pivot and min
                data = barGraph1.Swap(i, min);
            }

            return data;
        }
        #endregion

        #region BUBBLE SORT
        private async Task<int[]> BubbleSortAsync(BarGraph graph)
        {
            int[] data = graph.data;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length - 1; j++)
                {
                    if (data[j] > data[j + 1])
                    {
                        await graph.SelectAll(new int[] { j, j + 1 });
                        data = graph.Swap(j, j + 1);
                    }
                }
            }

            return data;
        }
        #endregion

        #region SHELL SORT
        private async Task<int[]> ShellSortAsync()
        {
            int[] data = barGraph1.data;
            int n = data.Length;
            int k = n / 2;

            while (k > 0)
            {
                for (int i = 0; i + k < n; i++)
                {
                    int index = i;
                    while (data[index] > data[index + k])
                    {
                        await barGraph1.SelectAll(new int[] { index, index + k });

                        data = barGraph1.Swap(index, index + k);
                        index -= k;
                        if (index < 0) break;
                    }
                }
                if (k / 2 != 0) k /= 2;
                else if (k == 1) k = 0;
                else k = 1;
            }

            return data;
        }
        #endregion

        #region MERGE SORT
        //breaks the data into left and right sub arrays to be further sorted
        // start and finish are used to highlight and update barGraph (not needed for algorithm, purely to create good visual feedback)
        private async Task<int[]> MergeSortAsync(int[] data, int start, int finish)
        {
            if (data.Length == 1) return data;

            int remainder = data.Length%2;
            int length = data.Length/2;

            int[] left = new int[length];
            int[] right = new int[length + remainder];

            Array.Copy(data, left, length);
            Array.Copy(data, length, right, 0, length + remainder);

            left = await MergeSortAsync(left, start, length);
            right = await MergeSortAsync(right, start + left.Length, length + remainder);

            return await Merge(left, right, start, finish);
        }

        //merges the left and right arrays into one ordered array
        //start and length are used to highlight the correct values in barGraph
        private async Task<int[]> Merge(int[] left, int[] right, int start, int length)
        {
            int[] data = new int[left.Length + right.Length];
            int li = 0;
            int ri = 0;

            await barGraph1.SelectRange(start, start + length);
            
            for (int i = 0; i < data.Length; i++)
            {
                if (li == left.Length)
                {
                    data[i] = right[ri++];
                }
                else if (ri == right.Length)
                {
                    data[i] = left[li++];
                }
                else if (left[li] < right[ri])
                {
                    data[i] = left[li++];
                }
                else
                {
                    data[i] = right[ri++];
                }
            }

            int[] temp = barGraph1.data;
            Array.Copy(data, 0, temp, start, length);
            barGraph1.data = temp;

            return data;
        }
        #endregion
        #endregion
    }
}
