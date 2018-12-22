namespace Theory_of_Probability_LAB4
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
            this.components = new System.ComponentModel.Container();
            this.Render = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.RegressionEquation = new System.Windows.Forms.Label();
            this.AVGX = new System.Windows.Forms.Label();
            this.AVGY = new System.Windows.Forms.Label();
            this.DEVX = new System.Windows.Forms.Label();
            this.DEVY = new System.Windows.Forms.Label();
            this.COR = new System.Windows.Forms.Label();
            this.Next = new System.Windows.Forms.Button();
            this.REST = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Render
            // 
            this.Render.Interval = 1;
            this.Render.Tick += new System.EventHandler(this.Render_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 458);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выборочное среднее X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 492);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Выборочное среднее Y:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 529);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ср. кв. отклонение X:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 565);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ср. кв. отклонение Y:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 599);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(215, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Коррелляция Пирсона:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(306, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Уравнение линейной регрессии:";
            // 
            // RegressionEquation
            // 
            this.RegressionEquation.AutoSize = true;
            this.RegressionEquation.Location = new System.Drawing.Point(324, 9);
            this.RegressionEquation.Name = "RegressionEquation";
            this.RegressionEquation.Size = new System.Drawing.Size(0, 24);
            this.RegressionEquation.TabIndex = 6;
            // 
            // AVGX
            // 
            this.AVGX.AutoSize = true;
            this.AVGX.Location = new System.Drawing.Point(246, 458);
            this.AVGX.Name = "AVGX";
            this.AVGX.Size = new System.Drawing.Size(0, 24);
            this.AVGX.TabIndex = 7;
            // 
            // AVGY
            // 
            this.AVGY.AutoSize = true;
            this.AVGY.Location = new System.Drawing.Point(246, 492);
            this.AVGY.Name = "AVGY";
            this.AVGY.Size = new System.Drawing.Size(0, 24);
            this.AVGY.TabIndex = 8;
            // 
            // DEVX
            // 
            this.DEVX.AutoSize = true;
            this.DEVX.Location = new System.Drawing.Point(222, 529);
            this.DEVX.Name = "DEVX";
            this.DEVX.Size = new System.Drawing.Size(0, 24);
            this.DEVX.TabIndex = 9;
            // 
            // DEVY
            // 
            this.DEVY.AutoSize = true;
            this.DEVY.Location = new System.Drawing.Point(220, 565);
            this.DEVY.Name = "DEVY";
            this.DEVY.Size = new System.Drawing.Size(0, 24);
            this.DEVY.TabIndex = 10;
            // 
            // COR
            // 
            this.COR.AutoSize = true;
            this.COR.Location = new System.Drawing.Point(233, 599);
            this.COR.Name = "COR";
            this.COR.Size = new System.Drawing.Size(0, 24);
            this.COR.TabIndex = 11;
            // 
            // Next
            // 
            this.Next.Location = new System.Drawing.Point(522, 487);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(150, 165);
            this.Next.TabIndex = 12;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // REST
            // 
            this.REST.AutoSize = true;
            this.REST.Location = new System.Drawing.Point(233, 628);
            this.REST.Name = "REST";
            this.REST.Size = new System.Drawing.Size(0, 24);
            this.REST.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 628);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(202, 24);
            this.label8.TabIndex = 13;
            this.label8.Text = "Остатки (в среднем):";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 661);
            this.Controls.Add(this.REST);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.COR);
            this.Controls.Add(this.DEVY);
            this.Controls.Add(this.DEVX);
            this.Controls.Add(this.AVGY);
            this.Controls.Add(this.AVGX);
            this.Controls.Add(this.RegressionEquation);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer Render;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label RegressionEquation;
        private System.Windows.Forms.Label AVGX;
        private System.Windows.Forms.Label AVGY;
        private System.Windows.Forms.Label DEVX;
        private System.Windows.Forms.Label DEVY;
        private System.Windows.Forms.Label COR;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Label REST;
        private System.Windows.Forms.Label label8;
    }
}

