namespace VisualSort
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.insertion_button = new System.Windows.Forms.Button();
            this.selection_button = new System.Windows.Forms.Button();
            this.bubble_button = new System.Windows.Forms.Button();
            this.shell_button = new System.Windows.Forms.Button();
            this.merge_button = new System.Windows.Forms.Button();
            this.heap_button = new System.Windows.Forms.Button();
            this.quick_button = new System.Windows.Forms.Button();
            this.quick3_button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sort_panel = new System.Windows.Forms.Panel();
            this.populate_random = new System.Windows.Forms.Button();
            this.populate_almost_sorted = new System.Windows.Forms.Button();
            this.populate_reversed = new System.Windows.Forms.Button();
            this.populate_custom = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // insertion_button
            // 
            this.insertion_button.Location = new System.Drawing.Point(6, 34);
            this.insertion_button.Name = "insertion_button";
            this.insertion_button.Size = new System.Drawing.Size(75, 23);
            this.insertion_button.TabIndex = 1;
            this.insertion_button.Text = "Insertion";
            this.insertion_button.UseVisualStyleBackColor = true;
            this.insertion_button.Click += new System.EventHandler(this.insertion_button_Click);
            // 
            // selection_button
            // 
            this.selection_button.Location = new System.Drawing.Point(6, 63);
            this.selection_button.Name = "selection_button";
            this.selection_button.Size = new System.Drawing.Size(75, 23);
            this.selection_button.TabIndex = 2;
            this.selection_button.Text = "Selection";
            this.selection_button.UseVisualStyleBackColor = true;
            this.selection_button.Click += new System.EventHandler(this.selection_button_Click);
            // 
            // bubble_button
            // 
            this.bubble_button.Location = new System.Drawing.Point(6, 92);
            this.bubble_button.Name = "bubble_button";
            this.bubble_button.Size = new System.Drawing.Size(75, 23);
            this.bubble_button.TabIndex = 3;
            this.bubble_button.Text = "Bubble";
            this.bubble_button.UseVisualStyleBackColor = true;
            // 
            // shell_button
            // 
            this.shell_button.Location = new System.Drawing.Point(6, 121);
            this.shell_button.Name = "shell_button";
            this.shell_button.Size = new System.Drawing.Size(75, 23);
            this.shell_button.TabIndex = 4;
            this.shell_button.Text = "Shell";
            this.shell_button.UseVisualStyleBackColor = true;
            // 
            // merge_button
            // 
            this.merge_button.Location = new System.Drawing.Point(6, 150);
            this.merge_button.Name = "merge_button";
            this.merge_button.Size = new System.Drawing.Size(75, 23);
            this.merge_button.TabIndex = 5;
            this.merge_button.Text = "Merge";
            this.merge_button.UseVisualStyleBackColor = true;
            // 
            // heap_button
            // 
            this.heap_button.Location = new System.Drawing.Point(6, 179);
            this.heap_button.Name = "heap_button";
            this.heap_button.Size = new System.Drawing.Size(75, 23);
            this.heap_button.TabIndex = 6;
            this.heap_button.Text = "Heap";
            this.heap_button.UseVisualStyleBackColor = true;
            // 
            // quick_button
            // 
            this.quick_button.Location = new System.Drawing.Point(6, 208);
            this.quick_button.Name = "quick_button";
            this.quick_button.Size = new System.Drawing.Size(75, 23);
            this.quick_button.TabIndex = 7;
            this.quick_button.Text = "Quick";
            this.quick_button.UseVisualStyleBackColor = true;
            // 
            // quick3_button
            // 
            this.quick3_button.Location = new System.Drawing.Point(6, 237);
            this.quick3_button.Name = "quick3_button";
            this.quick3_button.Size = new System.Drawing.Size(75, 23);
            this.quick3_button.TabIndex = 8;
            this.quick3_button.Text = "Quick3";
            this.quick3_button.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.insertion_button);
            this.groupBox1.Controls.Add(this.quick3_button);
            this.groupBox1.Controls.Add(this.selection_button);
            this.groupBox1.Controls.Add(this.quick_button);
            this.groupBox1.Controls.Add(this.bubble_button);
            this.groupBox1.Controls.Add(this.heap_button);
            this.groupBox1.Controls.Add(this.shell_button);
            this.groupBox1.Controls.Add(this.merge_button);
            this.groupBox1.Location = new System.Drawing.Point(375, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(88, 271);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sorting Algorithms";
            // 
            // sort_panel
            // 
            this.sort_panel.Location = new System.Drawing.Point(12, 13);
            this.sort_panel.Name = "sort_panel";
            this.sort_panel.Size = new System.Drawing.Size(357, 270);
            this.sort_panel.TabIndex = 10;
            // 
            // populate_random
            // 
            this.populate_random.Location = new System.Drawing.Point(12, 289);
            this.populate_random.Name = "populate_random";
            this.populate_random.Size = new System.Drawing.Size(90, 23);
            this.populate_random.TabIndex = 12;
            this.populate_random.Text = "Random";
            this.populate_random.UseVisualStyleBackColor = true;
            this.populate_random.Click += new System.EventHandler(this.populate_random_Click);
            // 
            // populate_almost_sorted
            // 
            this.populate_almost_sorted.Location = new System.Drawing.Point(108, 289);
            this.populate_almost_sorted.Name = "populate_almost_sorted";
            this.populate_almost_sorted.Size = new System.Drawing.Size(90, 23);
            this.populate_almost_sorted.TabIndex = 13;
            this.populate_almost_sorted.Text = "Almost Sorted";
            this.populate_almost_sorted.UseVisualStyleBackColor = true;
            this.populate_almost_sorted.Click += new System.EventHandler(this.populate_almost_sorted_Click);
            // 
            // populate_reversed
            // 
            this.populate_reversed.Location = new System.Drawing.Point(204, 289);
            this.populate_reversed.Name = "populate_reversed";
            this.populate_reversed.Size = new System.Drawing.Size(90, 23);
            this.populate_reversed.TabIndex = 14;
            this.populate_reversed.Text = "Reversed";
            this.populate_reversed.UseVisualStyleBackColor = true;
            this.populate_reversed.Click += new System.EventHandler(this.populate_reversed_Click);
            // 
            // populate_custom
            // 
            this.populate_custom.Location = new System.Drawing.Point(300, 289);
            this.populate_custom.Name = "populate_custom";
            this.populate_custom.Size = new System.Drawing.Size(90, 23);
            this.populate_custom.TabIndex = 15;
            this.populate_custom.Text = "Custom";
            this.populate_custom.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 321);
            this.Controls.Add(this.populate_custom);
            this.Controls.Add(this.populate_reversed);
            this.Controls.Add(this.populate_almost_sorted);
            this.Controls.Add(this.populate_random);
            this.Controls.Add(this.sort_panel);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Button insertion_button;
        private System.Windows.Forms.Button selection_button;
        private System.Windows.Forms.Button bubble_button;
        private System.Windows.Forms.Button shell_button;
        private System.Windows.Forms.Button merge_button;
        private System.Windows.Forms.Button heap_button;
        private System.Windows.Forms.Button quick_button;
        private System.Windows.Forms.Button quick3_button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel sort_panel;
        private System.Windows.Forms.Button populate_random;
        private System.Windows.Forms.Button populate_almost_sorted;
        private System.Windows.Forms.Button populate_reversed;
        private System.Windows.Forms.Button populate_custom;
    }
}

