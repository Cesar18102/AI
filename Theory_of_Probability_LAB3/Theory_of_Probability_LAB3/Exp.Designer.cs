namespace Theory_of_Probability_LAB3
{
    partial class Exp
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
            this.components = new System.ComponentModel.Container();
            this.L = new System.Windows.Forms.NumericUpDown();
            this.aLabel = new System.Windows.Forms.Label();
            this.Render = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.L)).BeginInit();
            this.SuspendLayout();
            // 
            // L
            // 
            this.L.DecimalPlaces = 2;
            this.L.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.L.Location = new System.Drawing.Point(483, 617);
            this.L.Margin = new System.Windows.Forms.Padding(6);
            this.L.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.L.Name = "L";
            this.L.Size = new System.Drawing.Size(116, 29);
            this.L.TabIndex = 10;
            this.L.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // aLabel
            // 
            this.aLabel.AutoSize = true;
            this.aLabel.BackColor = System.Drawing.Color.Transparent;
            this.aLabel.Location = new System.Drawing.Point(446, 619);
            this.aLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.aLabel.Name = "aLabel";
            this.aLabel.Size = new System.Drawing.Size(25, 24);
            this.aLabel.TabIndex = 9;
            this.aLabel.Text = "L:";
            // 
            // Render
            // 
            this.Render.Interval = 500;
            this.Render.Tick += new System.EventHandler(this.Render_Tick);
            // 
            // Exp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 661);
            this.Controls.Add(this.L);
            this.Controls.Add(this.aLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Exp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exp";
            ((System.ComponentModel.ISupportInitialize)(this.L)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown L;
        private System.Windows.Forms.Label aLabel;
        private System.Windows.Forms.Timer Render;
    }
}