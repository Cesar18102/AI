using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theory_of_Probability_LAB4
{
    public class SimpleLinearRegression
    {
        private double[] X, Y;
        public double AVGX { get; private set; }
        public double AVGY { get; private set; }
        public double StDevX { get; private set; }
        public double StDevY { get; private set; }
        public double Correlation { get; private set; }
        public double Tan { get; private set; }
        public double B { get; private set; }

        public SimpleLinearRegression(double[] X, double[] Y)
        {
            this.X = new double[X.Length];
            this.Y = new double[Y.Length];

            Array.Copy(X, this.X, X.Length);
            Array.Copy(Y, this.Y, Y.Length);

            AVGX = GetAVG(X);
            AVGY = GetAVG(Y);

            StDevX = GetStandardDeviation(X);
            StDevY = GetStandardDeviation(Y);

            Correlation = GetCorrelation(X, Y);

            Tan = Correlation * StDevY / StDevX;
            B = GetAVG(Y) - Tan * GetAVG(X);
        }

        public double GetStandardDeviation(double[] A)
        {
            double AVG = GetAVG(A);
            double[] Devs = new double[A.Length];

            for (int i = 0; i < A.Length; i++)
                Devs[i] = Math.Pow(A[i] - AVG, 2.0);

            return Math.Sqrt(Devs.Sum() / (Devs.Length - 1));
        }

        public double GetCorrelation(double[] A1, double[] A2)
        {
            double AVG1 = GetAVG(A1);
            double AVG2 = GetAVG(A2);

            double XYSUM = 0;
            double XSUM = 0;
            double YSUM = 0;

            for (int i = 0; i < A1.Length; i++)
            {
                double X = A1[i] - AVG1;
                double Y = A2[i] - AVG2;

                XYSUM += X * Y;
                XSUM += X * X;
                YSUM += Y * Y;
            }

            return XYSUM / Math.Sqrt(XSUM * YSUM);
        }

        public static double GetAVG(double[] A)
        {
            return A.Sum() / A.Length;
        }

        public double PredictY(double x)
        {
            return B + Tan * x;
        }
    }
}
