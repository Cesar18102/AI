namespace Theory_of_Probability_LAB3
{
    partial class Plain
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
            this.bLabel = new System.Windows.Forms.Label();
            this.aLabel = new System.Windows.Forms.Label();
            this.aVal = new System.Windows.Forms.NumericUpDown();
            this.bVal = new System.Windows.Forms.NumericUpDown();
            this.Render = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.aVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bVal)).BeginInit();
            this.SuspendLayout();
            // 
            // bLabel
            // 
            this.bLabel.AutoSize = true;
            this.bLabel.BackColor = System.Drawing.Color.Transparent;
            this.bLabel.Location = new System.Drawing.Point(450, 622);
            this.bLabel.Name = "bLabel";
            this.bLabel.Size = new System.Drawing.Size(26, 24);
            this.bLabel.TabIndex = 0;
            this.bLabel.Text = "b:";
            // 
            // aLabel
            // 
            this.aLabel.AutoSize = true;
            this.aLabel.BackColor = System.Drawing.Color.Transparent;
            this.aLabel.Location = new System.Drawing.Point(450, 587);
            this.aLabel.Name = "aLabel";
            this.aLabel.Size = new System.Drawing.Size(25, 24);
            this.aLabel.TabIndex = 1;
            this.aLabel.Text = "a:";
            // 
            // aVal
            // 
            this.aVal.Location = new System.Drawing.Point(481, 585);
            this.aVal.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.aVal.Name = "aVal";
            this.aVal.Size = new System.Drawing.Size(120, 29);
            this.aVal.TabIndex = 2;
            this.aVal.ValueChanged += new System.EventHandler(this.BorderChanged);
            // 
            // bVal
            // 
            this.bVal.Location = new System.Drawing.Point(482, 620);
            this.bVal.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.bVal.Name = "bVal";
            this.bVal.Size = new System.Drawing.Size(120, 29);
            this.bVal.TabIndex = 3;
            this.bVal.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.bVal.ValueChanged += new System.EventHandler(this.BorderChanged);
            // 
            // Render
            // 
            this.Render.Interval = 500;
            this.Render.Tick += new System.EventHandler(this.Render_Tick);
            // 
            // Plain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 661);
            this.Controls.Add(this.bVal);
            this.Controls.Add(this.aVal);
            this.Controls.Add(this.aLabel);
            this.Controls.Add(this.bLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Plain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plain";
            ((System.ComponentModel.ISupportInitialize)(this.aVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bVal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bLabel;
        private System.Windows.Forms.Label aLabel;
        private System.Windows.Forms.NumericUpDown aVal;
        private System.Windows.Forms.NumericUpDown bVal;
        private System.Windows.Forms.Timer Render;
    }
}