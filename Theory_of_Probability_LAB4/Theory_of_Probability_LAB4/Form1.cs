using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Theory_of_Probability_LAB4
{
    public partial class Form1 : Form
    {
        private static Random R = new Random();
        private RenderControl RC;
        private Figure F;

        public static double PlainRand(double a, double b)
        {
            return (R.NextDouble() - a) / (b - a);
        }

        public static double[] NormalRand(double M, double D)
        {
            double G = PlainRand(0, 1);
            double R = PlainRand(0, 1);

            double COS = Math.Cos(2 * Math.PI * G);
            double SIN = Math.Sqrt(1 - COS * COS);
            double SQRT = Math.Sqrt(-2 * Math.Log(R, Math.E));

            return new double[] { COS * SQRT * D + M, 
                                  SIN * SQRT * D + M };
        }

        public Form1()
        {
            InitializeComponent();

            RC = new RenderControl();
            RC.Dock = DockStyle.Fill;
            this.Controls.Add(RC);

            AVGX.BackColor = RC.BackColor;
            AVGY.BackColor = RC.BackColor;

            DEVX.BackColor = RC.BackColor;
            DEVY.BackColor = RC.BackColor;

            COR.BackColor = RC.BackColor;
            RegressionEquation.BackColor = RC.BackColor;
            REST.BackColor = RC.BackColor;

            label1.BackColor = RC.BackColor;
            label2.BackColor = RC.BackColor;
            label3.BackColor = RC.BackColor;
            label4.BackColor = RC.BackColor;
            label5.BackColor = RC.BackColor;
            label6.BackColor = RC.BackColor;
            label8.BackColor = RC.BackColor;

            Generate();

            Render.Start();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            Generate();
        }

        private void Render_Tick(object sender, EventArgs e)
        {
            RC.OnRender();
        }

        private void Generate()
        {
            RC.F.Clear();

            int PTS = R.Next(20, 50);

            List<double> X = new List<double>();
            List<double> Y = new List<double>();

            Figure FR = new Figure(Color.Red, OpenGL.GL_POINTS);

            for (int i = 0; i < PTS; i++)
            {
                double[] Z = NormalRand(0, 0.2);

                X.Add(Z[0]);
                Y.Add(Z[1]);

                FR.P.Add(new Point(Convert.ToInt32(Z[0] * this.Width), Convert.ToInt32(Z[1] * this.Height)));
            }

            RC.F.Add(FR);

            SimpleLinearRegression SLR = new SimpleLinearRegression(X.ToArray(), Y.ToArray());

            Figure LINE = new Figure(Color.Green, OpenGL.GL_LINE_STRIP);

            double X1 = 0;
            double Y1 = SLR.PredictY(X1);

            double X2 = 1;
            double Y2 = SLR.PredictY(X2);

            LINE.P.Add(new Point((int)(X1 * this.Width), (int)(Y1 * this.Height)));
            LINE.P.Add(new Point((int)(X2 * this.Width), (int)(Y2 * this.Height)));

            RC.F.Add(LINE);

            AVGX.Text = SLR.AVGX.ToString();
            AVGY.Text = SLR.AVGY.ToString();

            DEVX.Text = SLR.StDevX.ToString();
            DEVY.Text = SLR.StDevY.ToString();

            COR.Text = SLR.Correlation.ToString();
            RegressionEquation.Text = (-SLR.Tan).ToString() + " * x + " + SLR.B.ToString();

            int count = 0;
            double sum = 0;

            for (int i = 0; i < this.Width; i++) {

                double YP = SLR.PredictY(i / this.Width);

                foreach(Point P in FR.P)
                    if (P.X == i) {

                        count++;
                        sum += Math.Abs(P.Y / this.Height - YP);
                    }
            }

            REST.Text = (sum / count).ToString();
        }
    }
}
