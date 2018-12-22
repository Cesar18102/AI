namespace Theory_of_Probability_LAB3
{
    partial class Normal
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
            this.Deviation = new System.Windows.Forms.NumericUpDown();
            this.MathExpect = new System.Windows.Forms.NumericUpDown();
            this.aLabel = new System.Windows.Forms.Label();
            this.bLabel = new System.Windows.Forms.Label();
            this.Render = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Deviation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MathExpect)).BeginInit();
            this.SuspendLayout();
            // 
            // Deviation
            // 
            this.Deviation.DecimalPlaces = 2;
            this.Deviation.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.Deviation.Location = new System.Drawing.Point(484, 617);
            this.Deviation.Margin = new System.Windows.Forms.Padding(6);
            this.Deviation.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.Deviation.Name = "Deviation";
            this.Deviation.Size = new System.Drawing.Size(116, 29);
            this.Deviation.TabIndex = 7;
            this.Deviation.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // MathExpect
            // 
            this.MathExpect.DecimalPlaces = 2;
            this.MathExpect.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.MathExpect.Location = new System.Drawing.Point(483, 576);
            this.MathExpect.Margin = new System.Windows.Forms.Padding(6);
            this.MathExpect.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.MathExpect.Name = "MathExpect";
            this.MathExpect.Size = new System.Drawing.Size(116, 29);
            this.MathExpect.TabIndex = 6;
            // 
            // aLabel
            // 
            this.aLabel.AutoSize = true;
            this.aLabel.BackColor = System.Drawing.Color.Transparent;
            this.aLabel.Location = new System.Drawing.Point(446, 578);
            this.aLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.aLabel.Name = "aLabel";
            this.aLabel.Size = new System.Drawing.Size(31, 24);
            this.aLabel.TabIndex = 5;
            this.aLabel.Text = "M:";
            // 
            // bLabel
            // 
            this.bLabel.AutoSize = true;
            this.bLabel.BackColor = System.Drawing.Color.Transparent;
            this.bLabel.Location = new System.Drawing.Point(445, 619);
            this.bLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.bLabel.Name = "bLabel";
            this.bLabel.Size = new System.Drawing.Size(28, 24);
            this.bLabel.TabIndex = 4;
            this.bLabel.Text = "D:";
            // 
            // Render
            // 
            this.Render.Interval = 500;
            this.Render.Tick += new System.EventHandler(this.Render_Tick);
            // 
            // Normal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 661);
            this.Controls.Add(this.Deviation);
            this.Controls.Add(this.MathExpect);
            this.Controls.Add(this.aLabel);
            this.Controls.Add(this.bLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Normal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Normal";
            ((System.ComponentModel.ISupportInitialize)(this.Deviation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MathExpect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown Deviation;
        private System.Windows.Forms.NumericUpDown MathExpect;
        private System.Windows.Forms.Label aLabel;
        private System.Windows.Forms.Label bLabel;
        private System.Windows.Forms.Timer Render;
    }
}