namespace Theory_of_Probability_LAB3
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
            this.Plain = new System.Windows.Forms.Button();
            this.Normal = new System.Windows.Forms.Button();
            this.Exp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Plain
            // 
            this.Plain.Location = new System.Drawing.Point(15, 15);
            this.Plain.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Plain.Name = "Plain";
            this.Plain.Size = new System.Drawing.Size(607, 42);
            this.Plain.TabIndex = 0;
            this.Plain.Text = "Равномерное распределение";
            this.Plain.UseVisualStyleBackColor = true;
            this.Plain.Click += new System.EventHandler(this.Plain_Click);
            // 
            // Normal
            // 
            this.Normal.Location = new System.Drawing.Point(15, 69);
            this.Normal.Margin = new System.Windows.Forms.Padding(6);
            this.Normal.Name = "Normal";
            this.Normal.Size = new System.Drawing.Size(607, 42);
            this.Normal.TabIndex = 1;
            this.Normal.Text = "Нормальное распределение";
            this.Normal.UseVisualStyleBackColor = true;
            this.Normal.Click += new System.EventHandler(this.Normal_Click);
            // 
            // Exp
            // 
            this.Exp.Location = new System.Drawing.Point(15, 123);
            this.Exp.Margin = new System.Windows.Forms.Padding(6);
            this.Exp.Name = "Exp";
            this.Exp.Size = new System.Drawing.Size(607, 42);
            this.Exp.TabIndex = 2;
            this.Exp.Text = "Экспоненциальное распределение";
            this.Exp.UseVisualStyleBackColor = true;
            this.Exp.Click += new System.EventHandler(this.Exp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 178);
            this.Controls.Add(this.Exp);
            this.Controls.Add(this.Normal);
            this.Controls.Add(this.Plain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Plain;
        private System.Windows.Forms.Button Normal;
        private System.Windows.Forms.Button Exp;
    }
}

