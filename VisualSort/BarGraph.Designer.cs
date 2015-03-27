namespace VisualSort
{
    partial class BarGraph
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.draw_panel = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.draw_panel)).BeginInit();
            this.SuspendLayout();
            // 
            // draw_panel
            // 
            this.draw_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.draw_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.draw_panel.Location = new System.Drawing.Point(0, 0);
            this.draw_panel.Name = "draw_panel";
            this.draw_panel.Size = new System.Drawing.Size(340, 315);
            this.draw_panel.TabIndex = 0;
            this.draw_panel.TabStop = false;
            // 
            // BarGraph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.draw_panel);
            this.Name = "BarGraph";
            this.Size = new System.Drawing.Size(340, 315);
            ((System.ComponentModel.ISupportInitialize)(this.draw_panel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox draw_panel;

    }
}
