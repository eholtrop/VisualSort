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
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(470, 13);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(123, 270);
            this.textBox1.TabIndex = 11;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 291);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.sort_panel);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.TextBox textBox1;
    }
}

